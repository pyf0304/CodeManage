
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_QuestionsBL
 表名:zx_Questions(01120722)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
public static class  clszx_QuestionsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxQuestionsId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_QuestionsEN GetObj(this K_zxQuestionsId_zx_Questions myKey)
{
clszx_QuestionsEN objzx_QuestionsEN = clszx_QuestionsBL.zx_QuestionsDA.GetObjByzxQuestionsId(myKey.Value);
return objzx_QuestionsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_QuestionsEN objzx_QuestionsEN)
{
if (CheckUniqueness(objzx_QuestionsEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_QuestionsBL.AddNewRecord)", objzx_QuestionsEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_QuestionsEN.zxQuestionsId) == true || clszx_QuestionsBL.IsExist(objzx_QuestionsEN.zxQuestionsId) == true)
 {
     objzx_QuestionsEN.zxQuestionsId = clszx_QuestionsBL.GetMaxStrId_S();
 }
bool bolResult = clszx_QuestionsBL.zx_QuestionsDA.AddNewRecordBySQL2(objzx_QuestionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_QuestionsBL.ReFreshCache();

if (clszx_QuestionsBL.relatedActions != null)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(objzx_QuestionsEN.zxQuestionsId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_QuestionsEN objzx_QuestionsEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_QuestionsBL.IsExist(objzx_QuestionsEN.zxQuestionsId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_QuestionsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_QuestionsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(课件Id(TextId)=[{0}])已经存在,不能重复!", objzx_QuestionsEN.TextId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_QuestionsEN.zxQuestionsId) == true || clszx_QuestionsBL.IsExist(objzx_QuestionsEN.zxQuestionsId) == true)
 {
     objzx_QuestionsEN.zxQuestionsId = clszx_QuestionsBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_QuestionsEN.AddNewRecord();
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
 /// <param name = "objzx_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_QuestionsEN objzx_QuestionsEN)
{
if (CheckUniqueness(objzx_QuestionsEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_QuestionsBL.AddNewRecordWithMaxId)", objzx_QuestionsEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_QuestionsEN.zxQuestionsId) == true || clszx_QuestionsBL.IsExist(objzx_QuestionsEN.zxQuestionsId) == true)
 {
     objzx_QuestionsEN.zxQuestionsId = clszx_QuestionsBL.GetMaxStrId_S();
 }
string strzxQuestionsId = clszx_QuestionsBL.zx_QuestionsDA.AddNewRecordBySQL2WithReturnKey(objzx_QuestionsEN);
     objzx_QuestionsEN.zxQuestionsId = strzxQuestionsId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_QuestionsBL.ReFreshCache();

if (clszx_QuestionsBL.relatedActions != null)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(objzx_QuestionsEN.zxQuestionsId, "SetUpdDate");
}
return strzxQuestionsId;
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
 /// <param name = "objzx_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_QuestionsEN objzx_QuestionsEN)
{
if (CheckUniqueness(objzx_QuestionsEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_QuestionsBL.AddNewRecordWithReturnKey)", objzx_QuestionsEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_QuestionsEN.zxQuestionsId) == true || clszx_QuestionsBL.IsExist(objzx_QuestionsEN.zxQuestionsId) == true)
 {
     objzx_QuestionsEN.zxQuestionsId = clszx_QuestionsBL.GetMaxStrId_S();
 }
string strKey = clszx_QuestionsBL.zx_QuestionsDA.AddNewRecordBySQL2WithReturnKey(objzx_QuestionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_QuestionsBL.ReFreshCache();

if (clszx_QuestionsBL.relatedActions != null)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(objzx_QuestionsEN.zxQuestionsId, "SetUpdDate");
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
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetzxQuestionsId(this clszx_QuestionsEN objzx_QuestionsEN, string strzxQuestionsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxQuestionsId, 8, conzx_Questions.zxQuestionsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxQuestionsId, 8, conzx_Questions.zxQuestionsId);
}
objzx_QuestionsEN.zxQuestionsId = strzxQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.zxQuestionsId) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.zxQuestionsId, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.zxQuestionsId] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetTextId(this clszx_QuestionsEN objzx_QuestionsEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_Questions.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_Questions.TextId);
}
objzx_QuestionsEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.TextId) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.TextId, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.TextId] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetQuestionsContent(this clszx_QuestionsEN objzx_QuestionsEN, string strQuestionsContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsContent, 1000, conzx_Questions.QuestionsContent);
}
objzx_QuestionsEN.QuestionsContent = strQuestionsContent; //提问内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.QuestionsContent) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.QuestionsContent, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.QuestionsContent] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetPdfPageNum(this clszx_QuestionsEN objzx_QuestionsEN, int? intPdfPageNum, string strComparisonOp="")
	{
objzx_QuestionsEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.PdfPageNum) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.PdfPageNum, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.PdfPageNum] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetPdfContent(this clszx_QuestionsEN objzx_QuestionsEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conzx_Questions.PdfContent);
}
objzx_QuestionsEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.PdfContent) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.PdfContent, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.PdfContent] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetIsDelete(this clszx_QuestionsEN objzx_QuestionsEN, bool bolIsDelete, string strComparisonOp="")
	{
objzx_QuestionsEN.IsDelete = bolIsDelete; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.IsDelete) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.IsDelete, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.IsDelete] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetIsPublic(this clszx_QuestionsEN objzx_QuestionsEN, bool bolIsPublic, string strComparisonOp="")
	{
objzx_QuestionsEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.IsPublic) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.IsPublic, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.IsPublic] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetIsEnd(this clszx_QuestionsEN objzx_QuestionsEN, bool bolIsEnd, string strComparisonOp="")
	{
objzx_QuestionsEN.IsEnd = bolIsEnd; //是否结束
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.IsEnd) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.IsEnd, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.IsEnd] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetVoteCount(this clszx_QuestionsEN objzx_QuestionsEN, int? intVoteCount, string strComparisonOp="")
	{
objzx_QuestionsEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.VoteCount) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.VoteCount, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.VoteCount] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetAnswerCount(this clszx_QuestionsEN objzx_QuestionsEN, int? intAnswerCount, string strComparisonOp="")
	{
objzx_QuestionsEN.AnswerCount = intAnswerCount; //回答计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.AnswerCount) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.AnswerCount, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.AnswerCount] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetOrderNum(this clszx_QuestionsEN objzx_QuestionsEN, int? intOrderNum, string strComparisonOp="")
	{
objzx_QuestionsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.OrderNum) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.OrderNum, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.OrderNum] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetPdfPageTop(this clszx_QuestionsEN objzx_QuestionsEN, int? intPdfPageTop, string strComparisonOp="")
	{
objzx_QuestionsEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.PdfPageTop) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.PdfPageTop, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.PdfPageTop] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetPdfPageNumIn(this clszx_QuestionsEN objzx_QuestionsEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, conzx_Questions.PdfPageNumIn);
}
objzx_QuestionsEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.PdfPageNumIn) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.PdfPageNumIn, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.PdfPageNumIn] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetPdfDivTop(this clszx_QuestionsEN objzx_QuestionsEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, conzx_Questions.PdfDivTop);
}
objzx_QuestionsEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.PdfDivTop) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.PdfDivTop, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.PdfDivTop] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetPdfDivLet(this clszx_QuestionsEN objzx_QuestionsEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, conzx_Questions.PdfDivLet);
}
objzx_QuestionsEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.PdfDivLet) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.PdfDivLet, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.PdfDivLet] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetPdfZoom(this clszx_QuestionsEN objzx_QuestionsEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, conzx_Questions.PdfZoom);
}
objzx_QuestionsEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.PdfZoom) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.PdfZoom, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.PdfZoom] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetUpdUser(this clszx_QuestionsEN objzx_QuestionsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_Questions.UpdUser);
}
objzx_QuestionsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.UpdUser) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.UpdUser, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.UpdUser] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetUpdDate(this clszx_QuestionsEN objzx_QuestionsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_Questions.UpdDate);
}
objzx_QuestionsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.UpdDate) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.UpdDate, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.UpdDate] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetMemo(this clszx_QuestionsEN objzx_QuestionsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_Questions.Memo);
}
objzx_QuestionsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.Memo) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.Memo, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.Memo] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetZxqaPaperId(this clszx_QuestionsEN objzx_QuestionsEN, string strZxqaPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strZxqaPaperId, conzx_Questions.ZxqaPaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strZxqaPaperId, 8, conzx_Questions.ZxqaPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strZxqaPaperId, 8, conzx_Questions.ZxqaPaperId);
}
objzx_QuestionsEN.ZxqaPaperId = strZxqaPaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.ZxqaPaperId) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.ZxqaPaperId, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.ZxqaPaperId] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetUserId(this clszx_QuestionsEN objzx_QuestionsEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conzx_Questions.UserId);
}
objzx_QuestionsEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.UserId) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.UserId, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.UserId] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetzxQuestionsTypeId(this clszx_QuestionsEN objzx_QuestionsEN, string strzxQuestionsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxQuestionsTypeId, conzx_Questions.zxQuestionsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxQuestionsTypeId, 2, conzx_Questions.zxQuestionsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxQuestionsTypeId, 2, conzx_Questions.zxQuestionsTypeId);
}
objzx_QuestionsEN.zxQuestionsTypeId = strzxQuestionsTypeId; //问题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.zxQuestionsTypeId) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.zxQuestionsTypeId, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.zxQuestionsTypeId] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetDiscussCount(this clszx_QuestionsEN objzx_QuestionsEN, int? intDiscussCount, string strComparisonOp="")
	{
objzx_QuestionsEN.DiscussCount = intDiscussCount; //DiscussCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.DiscussCount) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.DiscussCount, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.DiscussCount] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetGroupDiscussCount(this clszx_QuestionsEN objzx_QuestionsEN, int? intGroupDiscussCount, string strComparisonOp="")
	{
objzx_QuestionsEN.GroupDiscussCount = intGroupDiscussCount; //GroupDiscussCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.GroupDiscussCount) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.GroupDiscussCount, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.GroupDiscussCount] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_QuestionsEN SetRecommendAnswerCount(this clszx_QuestionsEN objzx_QuestionsEN, int? intRecommendAnswerCount, string strComparisonOp="")
	{
objzx_QuestionsEN.RecommendAnswerCount = intRecommendAnswerCount; //RecommendAnswerCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_QuestionsEN.dicFldComparisonOp.ContainsKey(conzx_Questions.RecommendAnswerCount) == false)
{
objzx_QuestionsEN.dicFldComparisonOp.Add(conzx_Questions.RecommendAnswerCount, strComparisonOp);
}
else
{
objzx_QuestionsEN.dicFldComparisonOp[conzx_Questions.RecommendAnswerCount] = strComparisonOp;
}
}
return objzx_QuestionsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_QuestionsEN objzx_QuestionsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_QuestionsEN.CheckPropertyNew();
clszx_QuestionsEN objzx_QuestionsCond = new clszx_QuestionsEN();
string strCondition = objzx_QuestionsCond
.SetzxQuestionsId(objzx_QuestionsEN.zxQuestionsId, "<>")
.SetTextId(objzx_QuestionsEN.TextId, "=")
.GetCombineCondition();
objzx_QuestionsEN._IsCheckProperty = true;
bool bolIsExist = clszx_QuestionsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TextId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_QuestionsEN.Update();
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
 /// <param name = "objzx_Questions">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_QuestionsEN objzx_Questions)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_QuestionsEN objzx_QuestionsCond = new clszx_QuestionsEN();
string strCondition = objzx_QuestionsCond
.SetTextId(objzx_Questions.TextId, "=")
.GetCombineCondition();
objzx_Questions._IsCheckProperty = true;
bool bolIsExist = clszx_QuestionsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_Questions.zxQuestionsId = clszx_QuestionsBL.GetFirstID_S(strCondition);
objzx_Questions.UpdateWithCondition(strCondition);
}
else
{
objzx_Questions.zxQuestionsId = clszx_QuestionsBL.GetMaxStrId_S();
objzx_Questions.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_QuestionsEN objzx_QuestionsEN)
{
 if (string.IsNullOrEmpty(objzx_QuestionsEN.zxQuestionsId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_QuestionsBL.zx_QuestionsDA.UpdateBySql2(objzx_QuestionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_QuestionsBL.ReFreshCache();

if (clszx_QuestionsBL.relatedActions != null)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(objzx_QuestionsEN.zxQuestionsId, "SetUpdDate");
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
 /// <param name = "objzx_QuestionsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_QuestionsEN objzx_QuestionsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_QuestionsEN.zxQuestionsId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_QuestionsBL.zx_QuestionsDA.UpdateBySql2(objzx_QuestionsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_QuestionsBL.ReFreshCache();

if (clszx_QuestionsBL.relatedActions != null)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(objzx_QuestionsEN.zxQuestionsId, "SetUpdDate");
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
 /// <param name = "objzx_QuestionsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_QuestionsEN objzx_QuestionsEN, string strWhereCond)
{
try
{
bool bolResult = clszx_QuestionsBL.zx_QuestionsDA.UpdateBySqlWithCondition(objzx_QuestionsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_QuestionsBL.ReFreshCache();

if (clszx_QuestionsBL.relatedActions != null)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(objzx_QuestionsEN.zxQuestionsId, "SetUpdDate");
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
 /// <param name = "objzx_QuestionsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_QuestionsEN objzx_QuestionsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_QuestionsBL.zx_QuestionsDA.UpdateBySqlWithConditionTransaction(objzx_QuestionsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_QuestionsBL.ReFreshCache();

if (clszx_QuestionsBL.relatedActions != null)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(objzx_QuestionsEN.zxQuestionsId, "SetUpdDate");
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
 /// <param name = "strzxQuestionsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_QuestionsEN objzx_QuestionsEN)
{
try
{
int intRecNum = clszx_QuestionsBL.zx_QuestionsDA.DelRecord(objzx_QuestionsEN.zxQuestionsId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_QuestionsBL.ReFreshCache();

if (clszx_QuestionsBL.relatedActions != null)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(objzx_QuestionsEN.zxQuestionsId, "SetUpdDate");
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
 /// <param name = "objzx_QuestionsENS">源对象</param>
 /// <param name = "objzx_QuestionsENT">目标对象</param>
 public static void CopyTo(this clszx_QuestionsEN objzx_QuestionsENS, clszx_QuestionsEN objzx_QuestionsENT)
{
try
{
objzx_QuestionsENT.zxQuestionsId = objzx_QuestionsENS.zxQuestionsId; //提问Id
objzx_QuestionsENT.TextId = objzx_QuestionsENS.TextId; //课件Id
objzx_QuestionsENT.QuestionsContent = objzx_QuestionsENS.QuestionsContent; //提问内容
objzx_QuestionsENT.PdfPageNum = objzx_QuestionsENS.PdfPageNum; //Pdf页码
objzx_QuestionsENT.PdfContent = objzx_QuestionsENS.PdfContent; //Pdf内容
objzx_QuestionsENT.IsDelete = objzx_QuestionsENS.IsDelete; //是否删除
objzx_QuestionsENT.IsPublic = objzx_QuestionsENS.IsPublic; //是否公开
objzx_QuestionsENT.IsEnd = objzx_QuestionsENS.IsEnd; //是否结束
objzx_QuestionsENT.VoteCount = objzx_QuestionsENS.VoteCount; //点赞计数
objzx_QuestionsENT.AnswerCount = objzx_QuestionsENS.AnswerCount; //回答计数
objzx_QuestionsENT.OrderNum = objzx_QuestionsENS.OrderNum; //序号
objzx_QuestionsENT.PdfPageTop = objzx_QuestionsENS.PdfPageTop; //pdf页面顶部位置
objzx_QuestionsENT.PdfPageNumIn = objzx_QuestionsENS.PdfPageNumIn; //PdfPageNumIn
objzx_QuestionsENT.PdfDivTop = objzx_QuestionsENS.PdfDivTop; //PdfDivTop
objzx_QuestionsENT.PdfDivLet = objzx_QuestionsENS.PdfDivLet; //PdfDivLet
objzx_QuestionsENT.PdfZoom = objzx_QuestionsENS.PdfZoom; //PdfZoom
objzx_QuestionsENT.UpdUser = objzx_QuestionsENS.UpdUser; //修改人
objzx_QuestionsENT.UpdDate = objzx_QuestionsENS.UpdDate; //修改日期
objzx_QuestionsENT.Memo = objzx_QuestionsENS.Memo; //备注
objzx_QuestionsENT.ZxqaPaperId = objzx_QuestionsENS.ZxqaPaperId; //论文答疑Id
objzx_QuestionsENT.UserId = objzx_QuestionsENS.UserId; //用户ID
objzx_QuestionsENT.zxQuestionsTypeId = objzx_QuestionsENS.zxQuestionsTypeId; //问题类型Id
objzx_QuestionsENT.DiscussCount = objzx_QuestionsENS.DiscussCount; //DiscussCount
objzx_QuestionsENT.GroupDiscussCount = objzx_QuestionsENS.GroupDiscussCount; //GroupDiscussCount
objzx_QuestionsENT.RecommendAnswerCount = objzx_QuestionsENS.RecommendAnswerCount; //RecommendAnswerCount
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
 /// <param name = "objzx_QuestionsENS">源对象</param>
 /// <returns>目标对象=>clszx_QuestionsEN:objzx_QuestionsENT</returns>
 public static clszx_QuestionsEN CopyTo(this clszx_QuestionsEN objzx_QuestionsENS)
{
try
{
 clszx_QuestionsEN objzx_QuestionsENT = new clszx_QuestionsEN()
{
zxQuestionsId = objzx_QuestionsENS.zxQuestionsId, //提问Id
TextId = objzx_QuestionsENS.TextId, //课件Id
QuestionsContent = objzx_QuestionsENS.QuestionsContent, //提问内容
PdfPageNum = objzx_QuestionsENS.PdfPageNum, //Pdf页码
PdfContent = objzx_QuestionsENS.PdfContent, //Pdf内容
IsDelete = objzx_QuestionsENS.IsDelete, //是否删除
IsPublic = objzx_QuestionsENS.IsPublic, //是否公开
IsEnd = objzx_QuestionsENS.IsEnd, //是否结束
VoteCount = objzx_QuestionsENS.VoteCount, //点赞计数
AnswerCount = objzx_QuestionsENS.AnswerCount, //回答计数
OrderNum = objzx_QuestionsENS.OrderNum, //序号
PdfPageTop = objzx_QuestionsENS.PdfPageTop, //pdf页面顶部位置
PdfPageNumIn = objzx_QuestionsENS.PdfPageNumIn, //PdfPageNumIn
PdfDivTop = objzx_QuestionsENS.PdfDivTop, //PdfDivTop
PdfDivLet = objzx_QuestionsENS.PdfDivLet, //PdfDivLet
PdfZoom = objzx_QuestionsENS.PdfZoom, //PdfZoom
UpdUser = objzx_QuestionsENS.UpdUser, //修改人
UpdDate = objzx_QuestionsENS.UpdDate, //修改日期
Memo = objzx_QuestionsENS.Memo, //备注
ZxqaPaperId = objzx_QuestionsENS.ZxqaPaperId, //论文答疑Id
UserId = objzx_QuestionsENS.UserId, //用户ID
zxQuestionsTypeId = objzx_QuestionsENS.zxQuestionsTypeId, //问题类型Id
DiscussCount = objzx_QuestionsENS.DiscussCount, //DiscussCount
GroupDiscussCount = objzx_QuestionsENS.GroupDiscussCount, //GroupDiscussCount
RecommendAnswerCount = objzx_QuestionsENS.RecommendAnswerCount, //RecommendAnswerCount
};
 return objzx_QuestionsENT;
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
public static void CheckPropertyNew(this clszx_QuestionsEN objzx_QuestionsEN)
{
 clszx_QuestionsBL.zx_QuestionsDA.CheckPropertyNew(objzx_QuestionsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_QuestionsEN objzx_QuestionsEN)
{
 clszx_QuestionsBL.zx_QuestionsDA.CheckProperty4Condition(objzx_QuestionsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_QuestionsEN objzx_QuestionsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.zxQuestionsId) == true)
{
string strComparisonOpzxQuestionsId = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.zxQuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Questions.zxQuestionsId, objzx_QuestionsCond.zxQuestionsId, strComparisonOpzxQuestionsId);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.TextId) == true)
{
string strComparisonOpTextId = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Questions.TextId, objzx_QuestionsCond.TextId, strComparisonOpTextId);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.QuestionsContent) == true)
{
string strComparisonOpQuestionsContent = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.QuestionsContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Questions.QuestionsContent, objzx_QuestionsCond.QuestionsContent, strComparisonOpQuestionsContent);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Questions.PdfPageNum, objzx_QuestionsCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.PdfContent) == true)
{
string strComparisonOpPdfContent = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Questions.PdfContent, objzx_QuestionsCond.PdfContent, strComparisonOpPdfContent);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.IsDelete) == true)
{
if (objzx_QuestionsCond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Questions.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Questions.IsDelete);
}
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.IsPublic) == true)
{
if (objzx_QuestionsCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Questions.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Questions.IsPublic);
}
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.IsEnd) == true)
{
if (objzx_QuestionsCond.IsEnd == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Questions.IsEnd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Questions.IsEnd);
}
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.VoteCount) == true)
{
string strComparisonOpVoteCount = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Questions.VoteCount, objzx_QuestionsCond.VoteCount, strComparisonOpVoteCount);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.AnswerCount) == true)
{
string strComparisonOpAnswerCount = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Questions.AnswerCount, objzx_QuestionsCond.AnswerCount, strComparisonOpAnswerCount);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.OrderNum) == true)
{
string strComparisonOpOrderNum = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Questions.OrderNum, objzx_QuestionsCond.OrderNum, strComparisonOpOrderNum);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Questions.PdfPageTop, objzx_QuestionsCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Questions.PdfPageNumIn, objzx_QuestionsCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Questions.PdfDivTop, objzx_QuestionsCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Questions.PdfDivLet, objzx_QuestionsCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Questions.PdfZoom, objzx_QuestionsCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Questions.UpdUser, objzx_QuestionsCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Questions.UpdDate, objzx_QuestionsCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.Memo) == true)
{
string strComparisonOpMemo = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Questions.Memo, objzx_QuestionsCond.Memo, strComparisonOpMemo);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.ZxqaPaperId) == true)
{
string strComparisonOpZxqaPaperId = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.ZxqaPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Questions.ZxqaPaperId, objzx_QuestionsCond.ZxqaPaperId, strComparisonOpZxqaPaperId);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.UserId) == true)
{
string strComparisonOpUserId = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Questions.UserId, objzx_QuestionsCond.UserId, strComparisonOpUserId);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.zxQuestionsTypeId) == true)
{
string strComparisonOpzxQuestionsTypeId = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.zxQuestionsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Questions.zxQuestionsTypeId, objzx_QuestionsCond.zxQuestionsTypeId, strComparisonOpzxQuestionsTypeId);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.DiscussCount) == true)
{
string strComparisonOpDiscussCount = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.DiscussCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Questions.DiscussCount, objzx_QuestionsCond.DiscussCount, strComparisonOpDiscussCount);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.GroupDiscussCount) == true)
{
string strComparisonOpGroupDiscussCount = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.GroupDiscussCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Questions.GroupDiscussCount, objzx_QuestionsCond.GroupDiscussCount, strComparisonOpGroupDiscussCount);
}
if (objzx_QuestionsCond.IsUpdated(conzx_Questions.RecommendAnswerCount) == true)
{
string strComparisonOpRecommendAnswerCount = objzx_QuestionsCond.dicFldComparisonOp[conzx_Questions.RecommendAnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Questions.RecommendAnswerCount, objzx_QuestionsCond.RecommendAnswerCount, strComparisonOpRecommendAnswerCount);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_Questions(zx_Questions), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_QuestionsEN objzx_QuestionsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_QuestionsEN == null) return true;
if (objzx_QuestionsEN.zxQuestionsId == null || objzx_QuestionsEN.zxQuestionsId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_QuestionsEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null", objzx_QuestionsEN.TextId);
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_QuestionsEN.TextId);
}
if (clszx_QuestionsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxQuestionsId !=  '{0}'", objzx_QuestionsEN.zxQuestionsId);
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_QuestionsEN.TextId);
if (clszx_QuestionsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_Questions(zx_Questions), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_QuestionsEN objzx_QuestionsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_QuestionsEN == null) return "";
if (objzx_QuestionsEN.zxQuestionsId == null || objzx_QuestionsEN.zxQuestionsId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_QuestionsEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null", objzx_QuestionsEN.TextId);
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_QuestionsEN.TextId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxQuestionsId !=  '{0}'", objzx_QuestionsEN.zxQuestionsId);
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_QuestionsEN.TextId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_Questions
{
public virtual bool UpdRelaTabDate(string strzxQuestionsId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// zx_Questions(zx_Questions)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_QuestionsBL
{
public static RelatedActions_zx_Questions relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_QuestionsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_QuestionsDA zx_QuestionsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_QuestionsDA();
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
 public clszx_QuestionsBL()
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
if (string.IsNullOrEmpty(clszx_QuestionsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_QuestionsEN._ConnectString);
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
public static DataTable GetDataTable_zx_Questions(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_QuestionsDA.GetDataTable_zx_Questions(strWhereCond);
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
objDT = zx_QuestionsDA.GetDataTable(strWhereCond);
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
objDT = zx_QuestionsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_QuestionsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_QuestionsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_QuestionsDA.GetDataTable_Top(objTopPara);
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
objDT = zx_QuestionsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_QuestionsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_QuestionsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxQuestionsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_QuestionsEN> GetObjLstByZxQuestionsIdLst(List<string> arrZxQuestionsIdLst)
{
List<clszx_QuestionsEN> arrObjLst = new List<clszx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxQuestionsIdLst, true);
 string strWhereCond = string.Format("zxQuestionsId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();
try
{
objzx_QuestionsEN.zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objzx_QuestionsEN.TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(); //课件Id
objzx_QuestionsEN.QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objzx_QuestionsEN.PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_QuestionsEN.PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsDelete].ToString().Trim()); //是否删除
objzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsPublic].ToString().Trim()); //是否公开
objzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsEnd].ToString().Trim()); //是否结束
objzx_QuestionsEN.VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objzx_QuestionsEN.AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objzx_QuestionsEN.OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.OrderNum].ToString().Trim()); //序号
objzx_QuestionsEN.PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_QuestionsEN.PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_QuestionsEN.PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_QuestionsEN.PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_QuestionsEN.PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objzx_QuestionsEN.UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人
objzx_QuestionsEN.UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期
objzx_QuestionsEN.Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(); //备注
objzx_QuestionsEN.ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_QuestionsEN.UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(); //用户ID
objzx_QuestionsEN.zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objzx_QuestionsEN.DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objzx_QuestionsEN.GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objzx_QuestionsEN.RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_QuestionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxQuestionsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_QuestionsEN> GetObjLstByZxQuestionsIdLstCache(List<string> arrZxQuestionsIdLst)
{
string strKey = string.Format("{0}", clszx_QuestionsEN._CurrTabName);
List<clszx_QuestionsEN> arrzx_QuestionsObjLstCache = GetObjLstCache();
IEnumerable <clszx_QuestionsEN> arrzx_QuestionsObjLst_Sel =
arrzx_QuestionsObjLstCache
.Where(x => arrZxQuestionsIdLst.Contains(x.zxQuestionsId));
return arrzx_QuestionsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_QuestionsEN> GetObjLst(string strWhereCond)
{
List<clszx_QuestionsEN> arrObjLst = new List<clszx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();
try
{
objzx_QuestionsEN.zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objzx_QuestionsEN.TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(); //课件Id
objzx_QuestionsEN.QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objzx_QuestionsEN.PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_QuestionsEN.PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsDelete].ToString().Trim()); //是否删除
objzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsPublic].ToString().Trim()); //是否公开
objzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsEnd].ToString().Trim()); //是否结束
objzx_QuestionsEN.VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objzx_QuestionsEN.AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objzx_QuestionsEN.OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.OrderNum].ToString().Trim()); //序号
objzx_QuestionsEN.PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_QuestionsEN.PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_QuestionsEN.PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_QuestionsEN.PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_QuestionsEN.PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objzx_QuestionsEN.UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人
objzx_QuestionsEN.UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期
objzx_QuestionsEN.Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(); //备注
objzx_QuestionsEN.ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_QuestionsEN.UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(); //用户ID
objzx_QuestionsEN.zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objzx_QuestionsEN.DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objzx_QuestionsEN.GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objzx_QuestionsEN.RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_QuestionsEN);
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
public static List<clszx_QuestionsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_QuestionsEN> arrObjLst = new List<clszx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();
try
{
objzx_QuestionsEN.zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objzx_QuestionsEN.TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(); //课件Id
objzx_QuestionsEN.QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objzx_QuestionsEN.PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_QuestionsEN.PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsDelete].ToString().Trim()); //是否删除
objzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsPublic].ToString().Trim()); //是否公开
objzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsEnd].ToString().Trim()); //是否结束
objzx_QuestionsEN.VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objzx_QuestionsEN.AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objzx_QuestionsEN.OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.OrderNum].ToString().Trim()); //序号
objzx_QuestionsEN.PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_QuestionsEN.PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_QuestionsEN.PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_QuestionsEN.PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_QuestionsEN.PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objzx_QuestionsEN.UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人
objzx_QuestionsEN.UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期
objzx_QuestionsEN.Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(); //备注
objzx_QuestionsEN.ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_QuestionsEN.UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(); //用户ID
objzx_QuestionsEN.zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objzx_QuestionsEN.DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objzx_QuestionsEN.GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objzx_QuestionsEN.RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_QuestionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_QuestionsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_QuestionsEN> GetSubObjLstCache(clszx_QuestionsEN objzx_QuestionsCond)
{
List<clszx_QuestionsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_QuestionsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Questions.AttributeName)
{
if (objzx_QuestionsCond.IsUpdated(strFldName) == false) continue;
if (objzx_QuestionsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_QuestionsCond[strFldName].ToString());
}
else
{
if (objzx_QuestionsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_QuestionsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_QuestionsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_QuestionsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_QuestionsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_QuestionsCond[strFldName]));
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
public static List<clszx_QuestionsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_QuestionsEN> arrObjLst = new List<clszx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();
try
{
objzx_QuestionsEN.zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objzx_QuestionsEN.TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(); //课件Id
objzx_QuestionsEN.QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objzx_QuestionsEN.PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_QuestionsEN.PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsDelete].ToString().Trim()); //是否删除
objzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsPublic].ToString().Trim()); //是否公开
objzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsEnd].ToString().Trim()); //是否结束
objzx_QuestionsEN.VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objzx_QuestionsEN.AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objzx_QuestionsEN.OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.OrderNum].ToString().Trim()); //序号
objzx_QuestionsEN.PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_QuestionsEN.PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_QuestionsEN.PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_QuestionsEN.PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_QuestionsEN.PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objzx_QuestionsEN.UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人
objzx_QuestionsEN.UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期
objzx_QuestionsEN.Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(); //备注
objzx_QuestionsEN.ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_QuestionsEN.UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(); //用户ID
objzx_QuestionsEN.zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objzx_QuestionsEN.DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objzx_QuestionsEN.GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objzx_QuestionsEN.RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_QuestionsEN);
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
public static List<clszx_QuestionsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_QuestionsEN> arrObjLst = new List<clszx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();
try
{
objzx_QuestionsEN.zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objzx_QuestionsEN.TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(); //课件Id
objzx_QuestionsEN.QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objzx_QuestionsEN.PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_QuestionsEN.PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsDelete].ToString().Trim()); //是否删除
objzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsPublic].ToString().Trim()); //是否公开
objzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsEnd].ToString().Trim()); //是否结束
objzx_QuestionsEN.VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objzx_QuestionsEN.AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objzx_QuestionsEN.OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.OrderNum].ToString().Trim()); //序号
objzx_QuestionsEN.PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_QuestionsEN.PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_QuestionsEN.PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_QuestionsEN.PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_QuestionsEN.PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objzx_QuestionsEN.UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人
objzx_QuestionsEN.UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期
objzx_QuestionsEN.Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(); //备注
objzx_QuestionsEN.ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_QuestionsEN.UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(); //用户ID
objzx_QuestionsEN.zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objzx_QuestionsEN.DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objzx_QuestionsEN.GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objzx_QuestionsEN.RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_QuestionsEN);
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
List<clszx_QuestionsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_QuestionsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_QuestionsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_QuestionsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_QuestionsEN> arrObjLst = new List<clszx_QuestionsEN>(); 
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
	clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();
try
{
objzx_QuestionsEN.zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objzx_QuestionsEN.TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(); //课件Id
objzx_QuestionsEN.QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objzx_QuestionsEN.PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_QuestionsEN.PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsDelete].ToString().Trim()); //是否删除
objzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsPublic].ToString().Trim()); //是否公开
objzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsEnd].ToString().Trim()); //是否结束
objzx_QuestionsEN.VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objzx_QuestionsEN.AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objzx_QuestionsEN.OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.OrderNum].ToString().Trim()); //序号
objzx_QuestionsEN.PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_QuestionsEN.PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_QuestionsEN.PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_QuestionsEN.PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_QuestionsEN.PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objzx_QuestionsEN.UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人
objzx_QuestionsEN.UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期
objzx_QuestionsEN.Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(); //备注
objzx_QuestionsEN.ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_QuestionsEN.UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(); //用户ID
objzx_QuestionsEN.zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objzx_QuestionsEN.DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objzx_QuestionsEN.GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objzx_QuestionsEN.RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_QuestionsEN);
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
public static List<clszx_QuestionsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_QuestionsEN> arrObjLst = new List<clszx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();
try
{
objzx_QuestionsEN.zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objzx_QuestionsEN.TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(); //课件Id
objzx_QuestionsEN.QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objzx_QuestionsEN.PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_QuestionsEN.PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsDelete].ToString().Trim()); //是否删除
objzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsPublic].ToString().Trim()); //是否公开
objzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsEnd].ToString().Trim()); //是否结束
objzx_QuestionsEN.VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objzx_QuestionsEN.AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objzx_QuestionsEN.OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.OrderNum].ToString().Trim()); //序号
objzx_QuestionsEN.PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_QuestionsEN.PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_QuestionsEN.PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_QuestionsEN.PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_QuestionsEN.PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objzx_QuestionsEN.UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人
objzx_QuestionsEN.UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期
objzx_QuestionsEN.Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(); //备注
objzx_QuestionsEN.ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_QuestionsEN.UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(); //用户ID
objzx_QuestionsEN.zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objzx_QuestionsEN.DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objzx_QuestionsEN.GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objzx_QuestionsEN.RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_QuestionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_QuestionsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_QuestionsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_QuestionsEN> arrObjLst = new List<clszx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();
try
{
objzx_QuestionsEN.zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objzx_QuestionsEN.TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(); //课件Id
objzx_QuestionsEN.QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objzx_QuestionsEN.PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_QuestionsEN.PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsDelete].ToString().Trim()); //是否删除
objzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsPublic].ToString().Trim()); //是否公开
objzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsEnd].ToString().Trim()); //是否结束
objzx_QuestionsEN.VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objzx_QuestionsEN.AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objzx_QuestionsEN.OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.OrderNum].ToString().Trim()); //序号
objzx_QuestionsEN.PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_QuestionsEN.PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_QuestionsEN.PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_QuestionsEN.PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_QuestionsEN.PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objzx_QuestionsEN.UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人
objzx_QuestionsEN.UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期
objzx_QuestionsEN.Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(); //备注
objzx_QuestionsEN.ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_QuestionsEN.UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(); //用户ID
objzx_QuestionsEN.zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objzx_QuestionsEN.DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objzx_QuestionsEN.GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objzx_QuestionsEN.RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_QuestionsEN);
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
public static List<clszx_QuestionsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_QuestionsEN> arrObjLst = new List<clszx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();
try
{
objzx_QuestionsEN.zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objzx_QuestionsEN.TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(); //课件Id
objzx_QuestionsEN.QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objzx_QuestionsEN.PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_QuestionsEN.PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsDelete].ToString().Trim()); //是否删除
objzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsPublic].ToString().Trim()); //是否公开
objzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsEnd].ToString().Trim()); //是否结束
objzx_QuestionsEN.VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objzx_QuestionsEN.AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objzx_QuestionsEN.OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.OrderNum].ToString().Trim()); //序号
objzx_QuestionsEN.PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_QuestionsEN.PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_QuestionsEN.PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_QuestionsEN.PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_QuestionsEN.PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objzx_QuestionsEN.UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人
objzx_QuestionsEN.UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期
objzx_QuestionsEN.Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(); //备注
objzx_QuestionsEN.ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_QuestionsEN.UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(); //用户ID
objzx_QuestionsEN.zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objzx_QuestionsEN.DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objzx_QuestionsEN.GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objzx_QuestionsEN.RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_QuestionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_QuestionsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_QuestionsEN> arrObjLst = new List<clszx_QuestionsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();
try
{
objzx_QuestionsEN.zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objzx_QuestionsEN.TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(); //课件Id
objzx_QuestionsEN.QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objzx_QuestionsEN.PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_QuestionsEN.PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsDelete].ToString().Trim()); //是否删除
objzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsPublic].ToString().Trim()); //是否公开
objzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsEnd].ToString().Trim()); //是否结束
objzx_QuestionsEN.VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objzx_QuestionsEN.AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objzx_QuestionsEN.OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.OrderNum].ToString().Trim()); //序号
objzx_QuestionsEN.PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_QuestionsEN.PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_QuestionsEN.PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_QuestionsEN.PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_QuestionsEN.PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objzx_QuestionsEN.UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人
objzx_QuestionsEN.UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期
objzx_QuestionsEN.Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(); //备注
objzx_QuestionsEN.ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_QuestionsEN.UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(); //用户ID
objzx_QuestionsEN.zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objzx_QuestionsEN.DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objzx_QuestionsEN.GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objzx_QuestionsEN.RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_QuestionsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_Questions(ref clszx_QuestionsEN objzx_QuestionsEN)
{
bool bolResult = zx_QuestionsDA.Getzx_Questions(ref objzx_QuestionsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxQuestionsId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_QuestionsEN GetObjByzxQuestionsId(string strzxQuestionsId)
{
if (strzxQuestionsId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxQuestionsId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxQuestionsId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxQuestionsId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_QuestionsEN objzx_QuestionsEN = zx_QuestionsDA.GetObjByzxQuestionsId(strzxQuestionsId);
return objzx_QuestionsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_QuestionsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_QuestionsEN objzx_QuestionsEN = zx_QuestionsDA.GetFirstObj(strWhereCond);
 return objzx_QuestionsEN;
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
public static clszx_QuestionsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_QuestionsEN objzx_QuestionsEN = zx_QuestionsDA.GetObjByDataRow(objRow);
 return objzx_QuestionsEN;
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
public static clszx_QuestionsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_QuestionsEN objzx_QuestionsEN = zx_QuestionsDA.GetObjByDataRow(objRow);
 return objzx_QuestionsEN;
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
 /// <param name = "strzxQuestionsId">所给的关键字</param>
 /// <param name = "lstzx_QuestionsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_QuestionsEN GetObjByzxQuestionsIdFromList(string strzxQuestionsId, List<clszx_QuestionsEN> lstzx_QuestionsObjLst)
{
foreach (clszx_QuestionsEN objzx_QuestionsEN in lstzx_QuestionsObjLst)
{
if (objzx_QuestionsEN.zxQuestionsId == strzxQuestionsId)
{
return objzx_QuestionsEN;
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
 string strMaxZxQuestionsId;
 try
 {
 strMaxZxQuestionsId = clszx_QuestionsDA.GetMaxStrId();
 return strMaxZxQuestionsId;
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
 string strzxQuestionsId;
 try
 {
 strzxQuestionsId = new clszx_QuestionsDA().GetFirstID(strWhereCond);
 return strzxQuestionsId;
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
 arrList = zx_QuestionsDA.GetID(strWhereCond);
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
bool bolIsExist = zx_QuestionsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxQuestionsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxQuestionsId)
{
if (string.IsNullOrEmpty(strzxQuestionsId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxQuestionsId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_QuestionsDA.IsExist(strzxQuestionsId);
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
 bolIsExist = clszx_QuestionsDA.IsExistTable();
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
 bolIsExist = zx_QuestionsDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_QuestionsEN objzx_QuestionsEN)
{
if (objzx_QuestionsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_QuestionsBL.AddNewRecordBySql2)", objzx_QuestionsEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_QuestionsEN.zxQuestionsId) == true || clszx_QuestionsBL.IsExist(objzx_QuestionsEN.zxQuestionsId) == true)
 {
     objzx_QuestionsEN.zxQuestionsId = clszx_QuestionsBL.GetMaxStrId_S();
 }
bool bolResult = zx_QuestionsDA.AddNewRecordBySQL2(objzx_QuestionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_QuestionsBL.ReFreshCache();

if (clszx_QuestionsBL.relatedActions != null)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(objzx_QuestionsEN.zxQuestionsId, "SetUpdDate");
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
 /// <param name = "objzx_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_QuestionsEN objzx_QuestionsEN)
{
if (objzx_QuestionsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_QuestionsBL.AddNewRecordBySql2WithReturnKey)", objzx_QuestionsEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_QuestionsEN.zxQuestionsId) == true || clszx_QuestionsBL.IsExist(objzx_QuestionsEN.zxQuestionsId) == true)
 {
     objzx_QuestionsEN.zxQuestionsId = clszx_QuestionsBL.GetMaxStrId_S();
 }
string strKey = zx_QuestionsDA.AddNewRecordBySQL2WithReturnKey(objzx_QuestionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_QuestionsBL.ReFreshCache();

if (clszx_QuestionsBL.relatedActions != null)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(objzx_QuestionsEN.zxQuestionsId, "SetUpdDate");
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
 /// <param name = "objzx_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_QuestionsEN objzx_QuestionsEN)
{
try
{
bool bolResult = zx_QuestionsDA.Update(objzx_QuestionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_QuestionsBL.ReFreshCache();

if (clszx_QuestionsBL.relatedActions != null)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(objzx_QuestionsEN.zxQuestionsId, "SetUpdDate");
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
 /// <param name = "objzx_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_QuestionsEN objzx_QuestionsEN)
{
 if (string.IsNullOrEmpty(objzx_QuestionsEN.zxQuestionsId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_QuestionsDA.UpdateBySql2(objzx_QuestionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_QuestionsBL.ReFreshCache();

if (clszx_QuestionsBL.relatedActions != null)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(objzx_QuestionsEN.zxQuestionsId, "SetUpdDate");
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
 /// <param name = "strzxQuestionsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxQuestionsId)
{
try
{
 clszx_QuestionsEN objzx_QuestionsEN = clszx_QuestionsBL.GetObjByzxQuestionsId(strzxQuestionsId);

if (clszx_QuestionsBL.relatedActions != null)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(objzx_QuestionsEN.zxQuestionsId, "SetUpdDate");
}
if (objzx_QuestionsEN != null)
{
int intRecNum = zx_QuestionsDA.DelRecord(strzxQuestionsId);
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
/// <param name="strzxQuestionsId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxQuestionsId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_QuestionsDA.GetSpecSQLObj();
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
//删除与表:[zx_Questions]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_Questions.zxQuestionsId,
//strzxQuestionsId);
//        clszx_QuestionsBL.Delzx_QuestionssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_QuestionsBL.DelRecord(strzxQuestionsId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_QuestionsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxQuestionsId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxQuestionsId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxQuestionsId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_QuestionsBL.relatedActions != null)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(strzxQuestionsId, "UpdRelaTabDate");
}
bool bolResult = zx_QuestionsDA.DelRecord(strzxQuestionsId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxQuestionsIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_Questionss(List<string> arrzxQuestionsIdLst)
{
if (arrzxQuestionsIdLst.Count == 0) return 0;
try
{
if (clszx_QuestionsBL.relatedActions != null)
{
foreach (var strzxQuestionsId in arrzxQuestionsIdLst)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(strzxQuestionsId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_QuestionsDA.Delzx_Questions(arrzxQuestionsIdLst);
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
public static int Delzx_QuestionssByCond(string strWhereCond)
{
try
{
if (clszx_QuestionsBL.relatedActions != null)
{
List<string> arrzxQuestionsId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxQuestionsId in arrzxQuestionsId)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(strzxQuestionsId, "UpdRelaTabDate");
}
}
int intRecNum = zx_QuestionsDA.Delzx_Questions(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_Questions]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxQuestionsId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxQuestionsId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_QuestionsDA.GetSpecSQLObj();
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
//删除与表:[zx_Questions]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_QuestionsBL.DelRecord(strzxQuestionsId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_QuestionsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxQuestionsId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_QuestionsENS">源对象</param>
 /// <param name = "objzx_QuestionsENT">目标对象</param>
 public static void CopyTo(clszx_QuestionsEN objzx_QuestionsENS, clszx_QuestionsEN objzx_QuestionsENT)
{
try
{
objzx_QuestionsENT.zxQuestionsId = objzx_QuestionsENS.zxQuestionsId; //提问Id
objzx_QuestionsENT.TextId = objzx_QuestionsENS.TextId; //课件Id
objzx_QuestionsENT.QuestionsContent = objzx_QuestionsENS.QuestionsContent; //提问内容
objzx_QuestionsENT.PdfPageNum = objzx_QuestionsENS.PdfPageNum; //Pdf页码
objzx_QuestionsENT.PdfContent = objzx_QuestionsENS.PdfContent; //Pdf内容
objzx_QuestionsENT.IsDelete = objzx_QuestionsENS.IsDelete; //是否删除
objzx_QuestionsENT.IsPublic = objzx_QuestionsENS.IsPublic; //是否公开
objzx_QuestionsENT.IsEnd = objzx_QuestionsENS.IsEnd; //是否结束
objzx_QuestionsENT.VoteCount = objzx_QuestionsENS.VoteCount; //点赞计数
objzx_QuestionsENT.AnswerCount = objzx_QuestionsENS.AnswerCount; //回答计数
objzx_QuestionsENT.OrderNum = objzx_QuestionsENS.OrderNum; //序号
objzx_QuestionsENT.PdfPageTop = objzx_QuestionsENS.PdfPageTop; //pdf页面顶部位置
objzx_QuestionsENT.PdfPageNumIn = objzx_QuestionsENS.PdfPageNumIn; //PdfPageNumIn
objzx_QuestionsENT.PdfDivTop = objzx_QuestionsENS.PdfDivTop; //PdfDivTop
objzx_QuestionsENT.PdfDivLet = objzx_QuestionsENS.PdfDivLet; //PdfDivLet
objzx_QuestionsENT.PdfZoom = objzx_QuestionsENS.PdfZoom; //PdfZoom
objzx_QuestionsENT.UpdUser = objzx_QuestionsENS.UpdUser; //修改人
objzx_QuestionsENT.UpdDate = objzx_QuestionsENS.UpdDate; //修改日期
objzx_QuestionsENT.Memo = objzx_QuestionsENS.Memo; //备注
objzx_QuestionsENT.ZxqaPaperId = objzx_QuestionsENS.ZxqaPaperId; //论文答疑Id
objzx_QuestionsENT.UserId = objzx_QuestionsENS.UserId; //用户ID
objzx_QuestionsENT.zxQuestionsTypeId = objzx_QuestionsENS.zxQuestionsTypeId; //问题类型Id
objzx_QuestionsENT.DiscussCount = objzx_QuestionsENS.DiscussCount; //DiscussCount
objzx_QuestionsENT.GroupDiscussCount = objzx_QuestionsENS.GroupDiscussCount; //GroupDiscussCount
objzx_QuestionsENT.RecommendAnswerCount = objzx_QuestionsENS.RecommendAnswerCount; //RecommendAnswerCount
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
 /// <param name = "objzx_QuestionsEN">源简化对象</param>
 public static void SetUpdFlag(clszx_QuestionsEN objzx_QuestionsEN)
{
try
{
objzx_QuestionsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_QuestionsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_Questions.zxQuestionsId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.zxQuestionsId = objzx_QuestionsEN.zxQuestionsId; //提问Id
}
if (arrFldSet.Contains(conzx_Questions.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.TextId = objzx_QuestionsEN.TextId == "[null]" ? null :  objzx_QuestionsEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_Questions.QuestionsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.QuestionsContent = objzx_QuestionsEN.QuestionsContent == "[null]" ? null :  objzx_QuestionsEN.QuestionsContent; //提问内容
}
if (arrFldSet.Contains(conzx_Questions.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.PdfPageNum = objzx_QuestionsEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conzx_Questions.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.PdfContent = objzx_QuestionsEN.PdfContent == "[null]" ? null :  objzx_QuestionsEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conzx_Questions.IsDelete, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.IsDelete = objzx_QuestionsEN.IsDelete; //是否删除
}
if (arrFldSet.Contains(conzx_Questions.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.IsPublic = objzx_QuestionsEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(conzx_Questions.IsEnd, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.IsEnd = objzx_QuestionsEN.IsEnd; //是否结束
}
if (arrFldSet.Contains(conzx_Questions.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.VoteCount = objzx_QuestionsEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conzx_Questions.AnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.AnswerCount = objzx_QuestionsEN.AnswerCount; //回答计数
}
if (arrFldSet.Contains(conzx_Questions.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.OrderNum = objzx_QuestionsEN.OrderNum; //序号
}
if (arrFldSet.Contains(conzx_Questions.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.PdfPageTop = objzx_QuestionsEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(conzx_Questions.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.PdfPageNumIn = objzx_QuestionsEN.PdfPageNumIn == "[null]" ? null :  objzx_QuestionsEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(conzx_Questions.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.PdfDivTop = objzx_QuestionsEN.PdfDivTop == "[null]" ? null :  objzx_QuestionsEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(conzx_Questions.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.PdfDivLet = objzx_QuestionsEN.PdfDivLet == "[null]" ? null :  objzx_QuestionsEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(conzx_Questions.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.PdfZoom = objzx_QuestionsEN.PdfZoom == "[null]" ? null :  objzx_QuestionsEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(conzx_Questions.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.UpdUser = objzx_QuestionsEN.UpdUser == "[null]" ? null :  objzx_QuestionsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_Questions.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.UpdDate = objzx_QuestionsEN.UpdDate == "[null]" ? null :  objzx_QuestionsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_Questions.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.Memo = objzx_QuestionsEN.Memo == "[null]" ? null :  objzx_QuestionsEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_Questions.ZxqaPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.ZxqaPaperId = objzx_QuestionsEN.ZxqaPaperId; //论文答疑Id
}
if (arrFldSet.Contains(conzx_Questions.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.UserId = objzx_QuestionsEN.UserId == "[null]" ? null :  objzx_QuestionsEN.UserId; //用户ID
}
if (arrFldSet.Contains(conzx_Questions.zxQuestionsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.zxQuestionsTypeId = objzx_QuestionsEN.zxQuestionsTypeId; //问题类型Id
}
if (arrFldSet.Contains(conzx_Questions.DiscussCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.DiscussCount = objzx_QuestionsEN.DiscussCount; //DiscussCount
}
if (arrFldSet.Contains(conzx_Questions.GroupDiscussCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.GroupDiscussCount = objzx_QuestionsEN.GroupDiscussCount; //GroupDiscussCount
}
if (arrFldSet.Contains(conzx_Questions.RecommendAnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_QuestionsEN.RecommendAnswerCount = objzx_QuestionsEN.RecommendAnswerCount; //RecommendAnswerCount
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
 /// <param name = "objzx_QuestionsEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_QuestionsEN objzx_QuestionsEN)
{
try
{
if (objzx_QuestionsEN.TextId == "[null]") objzx_QuestionsEN.TextId = null; //课件Id
if (objzx_QuestionsEN.QuestionsContent == "[null]") objzx_QuestionsEN.QuestionsContent = null; //提问内容
if (objzx_QuestionsEN.PdfContent == "[null]") objzx_QuestionsEN.PdfContent = null; //Pdf内容
if (objzx_QuestionsEN.PdfPageNumIn == "[null]") objzx_QuestionsEN.PdfPageNumIn = null; //PdfPageNumIn
if (objzx_QuestionsEN.PdfDivTop == "[null]") objzx_QuestionsEN.PdfDivTop = null; //PdfDivTop
if (objzx_QuestionsEN.PdfDivLet == "[null]") objzx_QuestionsEN.PdfDivLet = null; //PdfDivLet
if (objzx_QuestionsEN.PdfZoom == "[null]") objzx_QuestionsEN.PdfZoom = null; //PdfZoom
if (objzx_QuestionsEN.UpdUser == "[null]") objzx_QuestionsEN.UpdUser = null; //修改人
if (objzx_QuestionsEN.UpdDate == "[null]") objzx_QuestionsEN.UpdDate = null; //修改日期
if (objzx_QuestionsEN.Memo == "[null]") objzx_QuestionsEN.Memo = null; //备注
if (objzx_QuestionsEN.UserId == "[null]") objzx_QuestionsEN.UserId = null; //用户ID
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
public static void CheckPropertyNew(clszx_QuestionsEN objzx_QuestionsEN)
{
 zx_QuestionsDA.CheckPropertyNew(objzx_QuestionsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_QuestionsEN objzx_QuestionsEN)
{
 zx_QuestionsDA.CheckProperty4Condition(objzx_QuestionsEN);
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
if (clszx_QuestionsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_QuestionsBL没有刷新缓存机制(clszx_QuestionsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxQuestionsId");
//if (arrzx_QuestionsObjLstCache == null)
//{
//arrzx_QuestionsObjLstCache = zx_QuestionsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxQuestionsId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_QuestionsEN GetObjByzxQuestionsIdCache(string strzxQuestionsId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_QuestionsEN._CurrTabName);
List<clszx_QuestionsEN> arrzx_QuestionsObjLstCache = GetObjLstCache();
IEnumerable <clszx_QuestionsEN> arrzx_QuestionsObjLst_Sel =
arrzx_QuestionsObjLstCache
.Where(x=> x.zxQuestionsId == strzxQuestionsId 
);
if (arrzx_QuestionsObjLst_Sel.Count() == 0)
{
   clszx_QuestionsEN obj = clszx_QuestionsBL.GetObjByzxQuestionsId(strzxQuestionsId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_QuestionsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_QuestionsEN> GetAllzx_QuestionsObjLstCache()
{
//获取缓存中的对象列表
List<clszx_QuestionsEN> arrzx_QuestionsObjLstCache = GetObjLstCache(); 
return arrzx_QuestionsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_QuestionsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_QuestionsEN._CurrTabName);
List<clszx_QuestionsEN> arrzx_QuestionsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_QuestionsObjLstCache;
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
string strKey = string.Format("{0}", clszx_QuestionsEN._CurrTabName);
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
if (clszx_QuestionsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_QuestionsEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_QuestionsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_Questions(zx_Questions)
 /// 唯一性条件:TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_QuestionsEN objzx_QuestionsEN)
{
//检测记录是否存在
string strResult = zx_QuestionsDA.GetUniCondStr(objzx_QuestionsEN);
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
public static string Func(string strInFldName, string strOutFldName, string strzxQuestionsId)
{
if (strInFldName != conzx_Questions.zxQuestionsId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_Questions.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_Questions.AttributeName));
throw new Exception(strMsg);
}
var objzx_Questions = clszx_QuestionsBL.GetObjByzxQuestionsIdCache(strzxQuestionsId);
if (objzx_Questions == null) return "";
return objzx_Questions[strOutFldName].ToString();
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
int intRecCount = clszx_QuestionsDA.GetRecCount(strTabName);
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
int intRecCount = clszx_QuestionsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_QuestionsDA.GetRecCount();
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
int intRecCount = clszx_QuestionsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_QuestionsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_QuestionsEN objzx_QuestionsCond)
{
List<clszx_QuestionsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_QuestionsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Questions.AttributeName)
{
if (objzx_QuestionsCond.IsUpdated(strFldName) == false) continue;
if (objzx_QuestionsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_QuestionsCond[strFldName].ToString());
}
else
{
if (objzx_QuestionsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_QuestionsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_QuestionsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_QuestionsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_QuestionsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_QuestionsCond[strFldName]));
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
 List<string> arrList = clszx_QuestionsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_QuestionsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_QuestionsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_QuestionsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_QuestionsDA.SetFldValue(clszx_QuestionsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_QuestionsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_QuestionsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_QuestionsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_QuestionsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_Questions] "); 
 strCreateTabCode.Append(" ( "); 
 // /**提问Id*/ 
 strCreateTabCode.Append(" zxQuestionsId char(8) primary key, "); 
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) Null, "); 
 // /**提问内容*/ 
 strCreateTabCode.Append(" QuestionsContent varchar(1000) Null, "); 
 // /**Pdf页码*/ 
 strCreateTabCode.Append(" PdfPageNum int Null, "); 
 // /**Pdf内容*/ 
 strCreateTabCode.Append(" PdfContent varchar(2000) Null, "); 
 // /**是否删除*/ 
 strCreateTabCode.Append(" IsDelete bit Null, "); 
 // /**是否公开*/ 
 strCreateTabCode.Append(" IsPublic bit Null, "); 
 // /**是否结束*/ 
 strCreateTabCode.Append(" IsEnd bit Null, "); 
 // /**点赞计数*/ 
 strCreateTabCode.Append(" VoteCount int Null, "); 
 // /**回答计数*/ 
 strCreateTabCode.Append(" AnswerCount int Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**pdf页面顶部位置*/ 
 strCreateTabCode.Append(" PdfPageTop int Null, "); 
 // /**PdfPageNumIn*/ 
 strCreateTabCode.Append(" PdfPageNumIn varchar(50) Null, "); 
 // /**PdfDivTop*/ 
 strCreateTabCode.Append(" PdfDivTop varchar(50) Null, "); 
 // /**PdfDivLet*/ 
 strCreateTabCode.Append(" PdfDivLet varchar(50) Null, "); 
 // /**PdfZoom*/ 
 strCreateTabCode.Append(" PdfZoom varchar(50) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**论文答疑Id*/ 
 strCreateTabCode.Append(" ZxqaPaperId char(8) not Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**问题类型Id*/ 
 strCreateTabCode.Append(" zxQuestionsTypeId char(2) not Null, "); 
 // /**DiscussCount*/ 
 strCreateTabCode.Append(" DiscussCount int Null, "); 
 // /**GroupDiscussCount*/ 
 strCreateTabCode.Append(" GroupDiscussCount int Null, "); 
 // /**RecommendAnswerCount*/ 
 strCreateTabCode.Append(" RecommendAnswerCount int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder()
{
try
{
string strCondition = string.Format("1 = 1 order by {0} ", conzx_Questions.OrderNum); 
List<clszx_QuestionsEN> arrzx_QuestionsObjList = new clszx_QuestionsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clszx_QuestionsEN objzx_Questions in arrzx_QuestionsObjList)
{
objzx_Questions.OrderNum = intIndex;
UpdateBySql2(objzx_Questions);
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
/// 调整所给关键字记录的序号。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strzxQuestionsId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strzxQuestionsId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[zxQuestionsId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字zxQuestionsId
//5、把当前关键字zxQuestionsId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字zxQuestionsId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevzxQuestionsId = "";    //上一条序号的关键字zxQuestionsId
string strNextzxQuestionsId = "";    //下一条序号的关键字zxQuestionsId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[zxQuestionsId],获取相应的序号[OrderNum]。

clszx_QuestionsEN objzx_Questions = clszx_QuestionsBL.GetObjByzxQuestionsId(strzxQuestionsId);

intOrderNum = objzx_Questions.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clszx_QuestionsBL.GetRecCountByCond(clszx_QuestionsEN._CurrTabName, "1 = 1");    //获取当前表的记录数
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
strCondition.AppendFormat(" {0} = {1}", conzx_Questions.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字zxQuestionsId
strPrevzxQuestionsId = clszx_QuestionsBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevzxQuestionsId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字zxQuestionsId所对应记录的序号减1
//6、把下(上)一个序号关键字zxQuestionsId所对应的记录序号加1
clszx_QuestionsBL.SetFldValue(clszx_QuestionsEN._CurrTabName, conzx_Questions.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conzx_Questions.zxQuestionsId, strzxQuestionsId));
clszx_QuestionsBL.SetFldValue(clszx_QuestionsEN._CurrTabName, conzx_Questions.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conzx_Questions.zxQuestionsId, strPrevzxQuestionsId));
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

//4、获取下一个序号字段的关键字zxQuestionsId
strCondition.AppendFormat(" {0} = {1}", conzx_Questions.OrderNum, intOrderNum + 1);

strNextzxQuestionsId = clszx_QuestionsBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextzxQuestionsId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字zxQuestionsId所对应记录的序号加1
//6、把下(上)一个序号关键字zxQuestionsId所对应的记录序号减1
clszx_QuestionsBL.SetFldValue(clszx_QuestionsEN._CurrTabName, conzx_Questions.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conzx_Questions.zxQuestionsId, strzxQuestionsId));
clszx_QuestionsBL.SetFldValue(clszx_QuestionsEN._CurrTabName, conzx_Questions.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conzx_Questions.zxQuestionsId, strNextzxQuestionsId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clszx_QuestionsBL.ReFreshCache();
if (clszx_QuestionsBL.relatedActions != null)
{
clszx_QuestionsBL.relatedActions.UpdRelaTabDate(objzx_Questions.zxQuestionsId, "UpdRelaTabDate");
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
/// 把所给的关键字列表所对应的对象置底。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conzx_Questions.zxQuestionsId, strKeyList);
List<clszx_QuestionsEN> arrzx_QuestionsLst = GetObjLst(strCondition);
foreach (clszx_QuestionsEN objzx_Questions in arrzx_QuestionsLst)
{
objzx_Questions.OrderNum = objzx_Questions.OrderNum + 10000;
UpdateBySql2(objzx_Questions);
}
strCondition = string.Format("1 = 1 order by {0} ", conzx_Questions.OrderNum); 
List<clszx_QuestionsEN> arrzx_QuestionsObjList = new clszx_QuestionsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clszx_QuestionsEN objzx_Questions in arrzx_QuestionsObjList)
{
objzx_Questions.OrderNum = intIndex;
UpdateBySql2(objzx_Questions);
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
/// 把所给的关键字列表所对应的对象置顶。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conzx_Questions.zxQuestionsId, strKeyList);
List<clszx_QuestionsEN> arrzx_QuestionsLst = GetObjLst(strCondition);
foreach (clszx_QuestionsEN objzx_Questions in arrzx_QuestionsLst)
{
objzx_Questions.OrderNum = objzx_Questions.OrderNum - 10000;
UpdateBySql2(objzx_Questions);
}
strCondition = string.Format("1 = 1 order by {0} ", conzx_Questions.OrderNum); 
List<clszx_QuestionsEN> arrzx_QuestionsObjList = new clszx_QuestionsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clszx_QuestionsEN objzx_Questions in arrzx_QuestionsObjList)
{
objzx_Questions.OrderNum = intIndex;
UpdateBySql2(objzx_Questions);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错!错误:{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// zx_Questions(zx_Questions)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_Questions : clsCommFun4BL
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
clszx_QuestionsBL.ReFreshThisCache();
}
}

}