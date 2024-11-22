
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TagsBL
 表名:gs_Tags(01120714)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clsgs_TagsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTagsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_TagsEN GetObj(this K_TagsId_gs_Tags myKey)
{
clsgs_TagsEN objgs_TagsEN = clsgs_TagsBL.gs_TagsDA.GetObjByTagsId(myKey.Value);
return objgs_TagsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_TagsEN objgs_TagsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_TagsEN) == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],标注Id = [{1}]的数据已经存在!(in clsgs_TagsBL.AddNewRecord)", objgs_TagsEN.PaperId,objgs_TagsEN.TagsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TagsEN.TagsId) == true || clsgs_TagsBL.IsExist(objgs_TagsEN.TagsId) == true)
 {
     objgs_TagsEN.TagsId = clsgs_TagsBL.GetMaxStrId_S();
 }
bool bolResult = clsgs_TagsBL.gs_TagsDA.AddNewRecordBySQL2(objgs_TagsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsBL.ReFreshCache();

if (clsgs_TagsBL.relatedActions != null)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(objgs_TagsEN.TagsId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_TagsEN objgs_TagsEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsgs_TagsBL.IsExist(objgs_TagsEN.TagsId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objgs_TagsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_TagsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(论文Id(PaperId)=[{0}],标注Id(TagsId)=[{1}])已经存在,不能重复!", objgs_TagsEN.PaperId, objgs_TagsEN.TagsId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objgs_TagsEN.TagsId) == true || clsgs_TagsBL.IsExist(objgs_TagsEN.TagsId) == true)
 {
     objgs_TagsEN.TagsId = clsgs_TagsBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objgs_TagsEN.AddNewRecord();
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
 /// <param name = "objgs_TagsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsgs_TagsEN objgs_TagsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_TagsEN) == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],标注Id = [{1}]的数据已经存在!(in clsgs_TagsBL.AddNewRecordWithMaxId)", objgs_TagsEN.PaperId,objgs_TagsEN.TagsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TagsEN.TagsId) == true || clsgs_TagsBL.IsExist(objgs_TagsEN.TagsId) == true)
 {
     objgs_TagsEN.TagsId = clsgs_TagsBL.GetMaxStrId_S();
 }
string strTagsId = clsgs_TagsBL.gs_TagsDA.AddNewRecordBySQL2WithReturnKey(objgs_TagsEN);
     objgs_TagsEN.TagsId = strTagsId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsBL.ReFreshCache();

if (clsgs_TagsBL.relatedActions != null)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(objgs_TagsEN.TagsId, "SetUpdDate");
}
return strTagsId;
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
 /// <param name = "objgs_TagsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_TagsEN objgs_TagsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_TagsEN) == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],标注Id = [{1}]的数据已经存在!(in clsgs_TagsBL.AddNewRecordWithReturnKey)", objgs_TagsEN.PaperId,objgs_TagsEN.TagsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TagsEN.TagsId) == true || clsgs_TagsBL.IsExist(objgs_TagsEN.TagsId) == true)
 {
     objgs_TagsEN.TagsId = clsgs_TagsBL.GetMaxStrId_S();
 }
string strKey = clsgs_TagsBL.gs_TagsDA.AddNewRecordBySQL2WithReturnKey(objgs_TagsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsBL.ReFreshCache();

if (clsgs_TagsBL.relatedActions != null)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(objgs_TagsEN.TagsId, "SetUpdDate");
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
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetTagsId(this clsgs_TagsEN objgs_TagsEN, string strTagsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTagsId, 10, congs_Tags.TagsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTagsId, 10, congs_Tags.TagsId);
}
objgs_TagsEN.TagsId = strTagsId; //标注Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.TagsId) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.TagsId, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.TagsId] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetTagsContent(this clsgs_TagsEN objgs_TagsEN, string strTagsContent, string strComparisonOp="")
	{
objgs_TagsEN.TagsContent = strTagsContent; //标注内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.TagsContent) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.TagsContent, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.TagsContent] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetPdfContent(this clsgs_TagsEN objgs_TagsEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, congs_Tags.PdfContent);
}
objgs_TagsEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.PdfContent) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.PdfContent, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.PdfContent] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetPdfPageNum(this clsgs_TagsEN objgs_TagsEN, int? intPdfPageNum, string strComparisonOp="")
	{
objgs_TagsEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.PdfPageNum) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.PdfPageNum, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.PdfPageNum] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetVoteCount(this clsgs_TagsEN objgs_TagsEN, int? intVoteCount, string strComparisonOp="")
	{
objgs_TagsEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.VoteCount) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.VoteCount, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.VoteCount] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetUserId(this clsgs_TagsEN objgs_TagsEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, congs_Tags.UserId);
}
objgs_TagsEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.UserId) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.UserId, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.UserId] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetOrderNum(this clsgs_TagsEN objgs_TagsEN, int? intOrderNum, string strComparisonOp="")
	{
objgs_TagsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.OrderNum) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.OrderNum, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.OrderNum] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetUpdUser(this clsgs_TagsEN objgs_TagsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_Tags.UpdUser);
}
objgs_TagsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.UpdUser) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.UpdUser, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.UpdUser] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetUpdDate(this clsgs_TagsEN objgs_TagsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_Tags.UpdDate);
}
objgs_TagsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.UpdDate) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.UpdDate, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.UpdDate] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetPdfLineNum(this clsgs_TagsEN objgs_TagsEN, int? intPdfLineNum, string strComparisonOp="")
	{
objgs_TagsEN.PdfLineNum = intPdfLineNum; //pdf行号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.PdfLineNum) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.PdfLineNum, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.PdfLineNum] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetPdfX(this clsgs_TagsEN objgs_TagsEN, string strPdfX, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfX, 50, congs_Tags.PdfX);
}
objgs_TagsEN.PdfX = strPdfX; //PdfX
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.PdfX) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.PdfX, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.PdfX] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetPdfY(this clsgs_TagsEN objgs_TagsEN, string strPdfY, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfY, 50, congs_Tags.PdfY);
}
objgs_TagsEN.PdfY = strPdfY; //PdfY
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.PdfY) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.PdfY, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.PdfY] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetMemo(this clsgs_TagsEN objgs_TagsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_Tags.Memo);
}
objgs_TagsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.Memo) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.Memo, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.Memo] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetIdCurrEduCls(this clsgs_TagsEN objgs_TagsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, congs_Tags.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, congs_Tags.IdCurrEduCls);
}
objgs_TagsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.IdCurrEduCls) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.IdCurrEduCls, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.IdCurrEduCls] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetPaperId(this clsgs_TagsEN objgs_TagsEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, congs_Tags.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, congs_Tags.PaperId);
}
objgs_TagsEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.PaperId) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.PaperId, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.PaperId] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetShareId(this clsgs_TagsEN objgs_TagsEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, congs_Tags.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, congs_Tags.ShareId);
}
objgs_TagsEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.ShareId) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.ShareId, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.ShareId] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetPdfPageNumIn(this clsgs_TagsEN objgs_TagsEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, congs_Tags.PdfPageNumIn);
}
objgs_TagsEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.PdfPageNumIn) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.PdfPageNumIn, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.PdfPageNumIn] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetPdfPageTop(this clsgs_TagsEN objgs_TagsEN, int? intPdfPageTop, string strComparisonOp="")
	{
objgs_TagsEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.PdfPageTop) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.PdfPageTop, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.PdfPageTop] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetselectSpanRange(this clsgs_TagsEN objgs_TagsEN, string strselectSpanRange, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strselectSpanRange, 50, congs_Tags.selectSpanRange);
}
objgs_TagsEN.selectSpanRange = strselectSpanRange; //选择Span范围
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.selectSpanRange) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.selectSpanRange, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.selectSpanRange] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetPdfDivLet(this clsgs_TagsEN objgs_TagsEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, congs_Tags.PdfDivLet);
}
objgs_TagsEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.PdfDivLet) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.PdfDivLet, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.PdfDivLet] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetPdfDivTop(this clsgs_TagsEN objgs_TagsEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, congs_Tags.PdfDivTop);
}
objgs_TagsEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.PdfDivTop) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.PdfDivTop, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.PdfDivTop] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetPdfZoom(this clsgs_TagsEN objgs_TagsEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, congs_Tags.PdfZoom);
}
objgs_TagsEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.PdfZoom) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.PdfZoom, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.PdfZoom] = strComparisonOp;
}
}
return objgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsEN SetTagsTypeId(this clsgs_TagsEN objgs_TagsEN, string strTagsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTagsTypeId, 2, congs_Tags.TagsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTagsTypeId, 2, congs_Tags.TagsTypeId);
}
objgs_TagsEN.TagsTypeId = strTagsTypeId; //标注类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsEN.dicFldComparisonOp.ContainsKey(congs_Tags.TagsTypeId) == false)
{
objgs_TagsEN.dicFldComparisonOp.Add(congs_Tags.TagsTypeId, strComparisonOp);
}
else
{
objgs_TagsEN.dicFldComparisonOp[congs_Tags.TagsTypeId] = strComparisonOp;
}
}
return objgs_TagsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_TagsEN objgs_TagsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_TagsEN.CheckPropertyNew();
clsgs_TagsEN objgs_TagsCond = new clsgs_TagsEN();
string strCondition = objgs_TagsCond
.SetTagsId(objgs_TagsEN.TagsId, "<>")
.SetPaperId(objgs_TagsEN.PaperId, "=")
.SetTagsId(objgs_TagsEN.TagsId, "=")
.GetCombineCondition();
objgs_TagsEN._IsCheckProperty = true;
bool bolIsExist = clsgs_TagsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PaperId_TagsId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_TagsEN.Update();
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
 /// <param name = "objgs_Tags">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_TagsEN objgs_Tags)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_TagsEN objgs_TagsCond = new clsgs_TagsEN();
string strCondition = objgs_TagsCond
.SetPaperId(objgs_Tags.PaperId, "=")
.SetTagsId(objgs_Tags.TagsId, "=")
.GetCombineCondition();
objgs_Tags._IsCheckProperty = true;
bool bolIsExist = clsgs_TagsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_Tags.TagsId = clsgs_TagsBL.GetFirstID_S(strCondition);
objgs_Tags.UpdateWithCondition(strCondition);
}
else
{
objgs_Tags.TagsId = clsgs_TagsBL.GetMaxStrId_S();
objgs_Tags.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_TagsEN objgs_TagsEN)
{
 if (string.IsNullOrEmpty(objgs_TagsEN.TagsId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_TagsBL.gs_TagsDA.UpdateBySql2(objgs_TagsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsBL.ReFreshCache();

if (clsgs_TagsBL.relatedActions != null)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(objgs_TagsEN.TagsId, "SetUpdDate");
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
 /// <param name = "objgs_TagsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_TagsEN objgs_TagsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objgs_TagsEN.TagsId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_TagsBL.gs_TagsDA.UpdateBySql2(objgs_TagsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsBL.ReFreshCache();

if (clsgs_TagsBL.relatedActions != null)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(objgs_TagsEN.TagsId, "SetUpdDate");
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
 /// <param name = "objgs_TagsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_TagsEN objgs_TagsEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_TagsBL.gs_TagsDA.UpdateBySqlWithCondition(objgs_TagsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsBL.ReFreshCache();

if (clsgs_TagsBL.relatedActions != null)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(objgs_TagsEN.TagsId, "SetUpdDate");
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
 /// <param name = "objgs_TagsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_TagsEN objgs_TagsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_TagsBL.gs_TagsDA.UpdateBySqlWithConditionTransaction(objgs_TagsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsBL.ReFreshCache();

if (clsgs_TagsBL.relatedActions != null)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(objgs_TagsEN.TagsId, "SetUpdDate");
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
 /// <param name = "strTagsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_TagsEN objgs_TagsEN)
{
try
{
int intRecNum = clsgs_TagsBL.gs_TagsDA.DelRecord(objgs_TagsEN.TagsId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsBL.ReFreshCache();

if (clsgs_TagsBL.relatedActions != null)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(objgs_TagsEN.TagsId, "SetUpdDate");
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
 /// <param name = "objgs_TagsENS">源对象</param>
 /// <param name = "objgs_TagsENT">目标对象</param>
 public static void CopyTo(this clsgs_TagsEN objgs_TagsENS, clsgs_TagsEN objgs_TagsENT)
{
try
{
objgs_TagsENT.TagsId = objgs_TagsENS.TagsId; //标注Id
objgs_TagsENT.TagsContent = objgs_TagsENS.TagsContent; //标注内容
objgs_TagsENT.PdfContent = objgs_TagsENS.PdfContent; //Pdf内容
objgs_TagsENT.PdfPageNum = objgs_TagsENS.PdfPageNum; //Pdf页码
objgs_TagsENT.VoteCount = objgs_TagsENS.VoteCount; //点赞计数
objgs_TagsENT.UserId = objgs_TagsENS.UserId; //用户ID
objgs_TagsENT.OrderNum = objgs_TagsENS.OrderNum; //序号
objgs_TagsENT.UpdUser = objgs_TagsENS.UpdUser; //修改人
objgs_TagsENT.UpdDate = objgs_TagsENS.UpdDate; //修改日期
objgs_TagsENT.PdfLineNum = objgs_TagsENS.PdfLineNum; //pdf行号
objgs_TagsENT.PdfX = objgs_TagsENS.PdfX; //PdfX
objgs_TagsENT.PdfY = objgs_TagsENS.PdfY; //PdfY
objgs_TagsENT.Memo = objgs_TagsENS.Memo; //备注
objgs_TagsENT.IdCurrEduCls = objgs_TagsENS.IdCurrEduCls; //教学班流水号
objgs_TagsENT.PaperId = objgs_TagsENS.PaperId; //论文Id
objgs_TagsENT.ShareId = objgs_TagsENS.ShareId; //分享Id
objgs_TagsENT.PdfPageNumIn = objgs_TagsENS.PdfPageNumIn; //PdfPageNumIn
objgs_TagsENT.PdfPageTop = objgs_TagsENS.PdfPageTop; //pdf页面顶部位置
objgs_TagsENT.selectSpanRange = objgs_TagsENS.selectSpanRange; //选择Span范围
objgs_TagsENT.PdfDivLet = objgs_TagsENS.PdfDivLet; //PdfDivLet
objgs_TagsENT.PdfDivTop = objgs_TagsENS.PdfDivTop; //PdfDivTop
objgs_TagsENT.PdfZoom = objgs_TagsENS.PdfZoom; //PdfZoom
objgs_TagsENT.TagsTypeId = objgs_TagsENS.TagsTypeId; //标注类型ID
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
 /// <param name = "objgs_TagsENS">源对象</param>
 /// <returns>目标对象=>clsgs_TagsEN:objgs_TagsENT</returns>
 public static clsgs_TagsEN CopyTo(this clsgs_TagsEN objgs_TagsENS)
{
try
{
 clsgs_TagsEN objgs_TagsENT = new clsgs_TagsEN()
{
TagsId = objgs_TagsENS.TagsId, //标注Id
TagsContent = objgs_TagsENS.TagsContent, //标注内容
PdfContent = objgs_TagsENS.PdfContent, //Pdf内容
PdfPageNum = objgs_TagsENS.PdfPageNum, //Pdf页码
VoteCount = objgs_TagsENS.VoteCount, //点赞计数
UserId = objgs_TagsENS.UserId, //用户ID
OrderNum = objgs_TagsENS.OrderNum, //序号
UpdUser = objgs_TagsENS.UpdUser, //修改人
UpdDate = objgs_TagsENS.UpdDate, //修改日期
PdfLineNum = objgs_TagsENS.PdfLineNum, //pdf行号
PdfX = objgs_TagsENS.PdfX, //PdfX
PdfY = objgs_TagsENS.PdfY, //PdfY
Memo = objgs_TagsENS.Memo, //备注
IdCurrEduCls = objgs_TagsENS.IdCurrEduCls, //教学班流水号
PaperId = objgs_TagsENS.PaperId, //论文Id
ShareId = objgs_TagsENS.ShareId, //分享Id
PdfPageNumIn = objgs_TagsENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objgs_TagsENS.PdfPageTop, //pdf页面顶部位置
selectSpanRange = objgs_TagsENS.selectSpanRange, //选择Span范围
PdfDivLet = objgs_TagsENS.PdfDivLet, //PdfDivLet
PdfDivTop = objgs_TagsENS.PdfDivTop, //PdfDivTop
PdfZoom = objgs_TagsENS.PdfZoom, //PdfZoom
TagsTypeId = objgs_TagsENS.TagsTypeId, //标注类型ID
};
 return objgs_TagsENT;
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
public static void CheckPropertyNew(this clsgs_TagsEN objgs_TagsEN)
{
 clsgs_TagsBL.gs_TagsDA.CheckPropertyNew(objgs_TagsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_TagsEN objgs_TagsEN)
{
 clsgs_TagsBL.gs_TagsDA.CheckProperty4Condition(objgs_TagsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_TagsEN objgs_TagsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_TagsCond.IsUpdated(congs_Tags.TagsId) == true)
{
string strComparisonOpTagsId = objgs_TagsCond.dicFldComparisonOp[congs_Tags.TagsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.TagsId, objgs_TagsCond.TagsId, strComparisonOpTagsId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objgs_TagsCond.IsUpdated(congs_Tags.PdfContent) == true)
{
string strComparisonOpPdfContent = objgs_TagsCond.dicFldComparisonOp[congs_Tags.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.PdfContent, objgs_TagsCond.PdfContent, strComparisonOpPdfContent);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objgs_TagsCond.dicFldComparisonOp[congs_Tags.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", congs_Tags.PdfPageNum, objgs_TagsCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.VoteCount) == true)
{
string strComparisonOpVoteCount = objgs_TagsCond.dicFldComparisonOp[congs_Tags.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", congs_Tags.VoteCount, objgs_TagsCond.VoteCount, strComparisonOpVoteCount);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.UserId) == true)
{
string strComparisonOpUserId = objgs_TagsCond.dicFldComparisonOp[congs_Tags.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.UserId, objgs_TagsCond.UserId, strComparisonOpUserId);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.OrderNum) == true)
{
string strComparisonOpOrderNum = objgs_TagsCond.dicFldComparisonOp[congs_Tags.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", congs_Tags.OrderNum, objgs_TagsCond.OrderNum, strComparisonOpOrderNum);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_TagsCond.dicFldComparisonOp[congs_Tags.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.UpdUser, objgs_TagsCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_TagsCond.dicFldComparisonOp[congs_Tags.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.UpdDate, objgs_TagsCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.PdfLineNum) == true)
{
string strComparisonOpPdfLineNum = objgs_TagsCond.dicFldComparisonOp[congs_Tags.PdfLineNum];
strWhereCond += string.Format(" And {0} {2} {1}", congs_Tags.PdfLineNum, objgs_TagsCond.PdfLineNum, strComparisonOpPdfLineNum);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.PdfX) == true)
{
string strComparisonOpPdfX = objgs_TagsCond.dicFldComparisonOp[congs_Tags.PdfX];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.PdfX, objgs_TagsCond.PdfX, strComparisonOpPdfX);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.PdfY) == true)
{
string strComparisonOpPdfY = objgs_TagsCond.dicFldComparisonOp[congs_Tags.PdfY];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.PdfY, objgs_TagsCond.PdfY, strComparisonOpPdfY);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.Memo) == true)
{
string strComparisonOpMemo = objgs_TagsCond.dicFldComparisonOp[congs_Tags.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.Memo, objgs_TagsCond.Memo, strComparisonOpMemo);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objgs_TagsCond.dicFldComparisonOp[congs_Tags.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.IdCurrEduCls, objgs_TagsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.PaperId) == true)
{
string strComparisonOpPaperId = objgs_TagsCond.dicFldComparisonOp[congs_Tags.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.PaperId, objgs_TagsCond.PaperId, strComparisonOpPaperId);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.ShareId) == true)
{
string strComparisonOpShareId = objgs_TagsCond.dicFldComparisonOp[congs_Tags.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.ShareId, objgs_TagsCond.ShareId, strComparisonOpShareId);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objgs_TagsCond.dicFldComparisonOp[congs_Tags.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.PdfPageNumIn, objgs_TagsCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objgs_TagsCond.dicFldComparisonOp[congs_Tags.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", congs_Tags.PdfPageTop, objgs_TagsCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.selectSpanRange) == true)
{
string strComparisonOpselectSpanRange = objgs_TagsCond.dicFldComparisonOp[congs_Tags.selectSpanRange];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.selectSpanRange, objgs_TagsCond.selectSpanRange, strComparisonOpselectSpanRange);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objgs_TagsCond.dicFldComparisonOp[congs_Tags.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.PdfDivLet, objgs_TagsCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objgs_TagsCond.dicFldComparisonOp[congs_Tags.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.PdfDivTop, objgs_TagsCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objgs_TagsCond.dicFldComparisonOp[congs_Tags.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.PdfZoom, objgs_TagsCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objgs_TagsCond.IsUpdated(congs_Tags.TagsTypeId) == true)
{
string strComparisonOpTagsTypeId = objgs_TagsCond.dicFldComparisonOp[congs_Tags.TagsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_Tags.TagsTypeId, objgs_TagsCond.TagsTypeId, strComparisonOpTagsTypeId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_Tags(标注), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PaperId_TagsId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_TagsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_TagsEN objgs_TagsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_TagsEN == null) return true;
if (objgs_TagsEN.TagsId == null || objgs_TagsEN.TagsId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_TagsEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null", objgs_TagsEN.PaperId);
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objgs_TagsEN.PaperId);
}
 sbCondition.AppendFormat(" and TagsId = '{0}'", objgs_TagsEN.TagsId);
if (clsgs_TagsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("TagsId !=  '{0}'", objgs_TagsEN.TagsId);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objgs_TagsEN.PaperId);
 sbCondition.AppendFormat(" and TagsId = '{0}'", objgs_TagsEN.TagsId);
if (clsgs_TagsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_Tags(标注), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PaperId_TagsId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_TagsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_TagsEN objgs_TagsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_TagsEN == null) return "";
if (objgs_TagsEN.TagsId == null || objgs_TagsEN.TagsId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_TagsEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null", objgs_TagsEN.PaperId);
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objgs_TagsEN.PaperId);
}
 sbCondition.AppendFormat(" and TagsId = '{0}'", objgs_TagsEN.TagsId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TagsId !=  '{0}'", objgs_TagsEN.TagsId);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objgs_TagsEN.PaperId);
 sbCondition.AppendFormat(" and TagsId = '{0}'", objgs_TagsEN.TagsId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_Tags
{
public virtual bool UpdRelaTabDate(string strTagsId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 标注(gs_Tags)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_TagsBL
{
public static RelatedActions_gs_Tags relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_TagsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_TagsDA gs_TagsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_TagsDA();
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
 public clsgs_TagsBL()
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
if (string.IsNullOrEmpty(clsgs_TagsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_TagsEN._ConnectString);
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
public static DataTable GetDataTable_gs_Tags(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_TagsDA.GetDataTable_gs_Tags(strWhereCond);
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
objDT = gs_TagsDA.GetDataTable(strWhereCond);
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
objDT = gs_TagsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_TagsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_TagsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_TagsDA.GetDataTable_Top(objTopPara);
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
objDT = gs_TagsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_TagsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_TagsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTagsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_TagsEN> GetObjLstByTagsIdLst(List<string> arrTagsIdLst)
{
List<clsgs_TagsEN> arrObjLst = new List<clsgs_TagsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTagsIdLst, true);
 string strWhereCond = string.Format("TagsId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN();
try
{
objgs_TagsEN.TagsId = objRow[congs_Tags.TagsId].ToString().Trim(); //标注Id
objgs_TagsEN.TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容
objgs_TagsEN.PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objgs_TagsEN.PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objgs_TagsEN.VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.VoteCount].ToString().Trim()); //点赞计数
objgs_TagsEN.UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(); //用户ID
objgs_TagsEN.OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.OrderNum].ToString().Trim()); //序号
objgs_TagsEN.UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(); //修改人
objgs_TagsEN.UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期
objgs_TagsEN.PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objgs_TagsEN.PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(); //PdfX
objgs_TagsEN.PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(); //PdfY
objgs_TagsEN.Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(); //备注
objgs_TagsEN.IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TagsEN.PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(); //论文Id
objgs_TagsEN.ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(); //分享Id
objgs_TagsEN.PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objgs_TagsEN.PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objgs_TagsEN.selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围
objgs_TagsEN.PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objgs_TagsEN.PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objgs_TagsEN.PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objgs_TagsEN.TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTagsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_TagsEN> GetObjLstByTagsIdLstCache(List<string> arrTagsIdLst)
{
string strKey = string.Format("{0}", clsgs_TagsEN._CurrTabName);
List<clsgs_TagsEN> arrgs_TagsObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TagsEN> arrgs_TagsObjLst_Sel =
arrgs_TagsObjLstCache
.Where(x => arrTagsIdLst.Contains(x.TagsId));
return arrgs_TagsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_TagsEN> GetObjLst(string strWhereCond)
{
List<clsgs_TagsEN> arrObjLst = new List<clsgs_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN();
try
{
objgs_TagsEN.TagsId = objRow[congs_Tags.TagsId].ToString().Trim(); //标注Id
objgs_TagsEN.TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容
objgs_TagsEN.PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objgs_TagsEN.PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objgs_TagsEN.VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.VoteCount].ToString().Trim()); //点赞计数
objgs_TagsEN.UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(); //用户ID
objgs_TagsEN.OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.OrderNum].ToString().Trim()); //序号
objgs_TagsEN.UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(); //修改人
objgs_TagsEN.UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期
objgs_TagsEN.PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objgs_TagsEN.PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(); //PdfX
objgs_TagsEN.PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(); //PdfY
objgs_TagsEN.Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(); //备注
objgs_TagsEN.IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TagsEN.PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(); //论文Id
objgs_TagsEN.ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(); //分享Id
objgs_TagsEN.PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objgs_TagsEN.PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objgs_TagsEN.selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围
objgs_TagsEN.PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objgs_TagsEN.PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objgs_TagsEN.PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objgs_TagsEN.TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsEN);
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
public static List<clsgs_TagsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_TagsEN> arrObjLst = new List<clsgs_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN();
try
{
objgs_TagsEN.TagsId = objRow[congs_Tags.TagsId].ToString().Trim(); //标注Id
objgs_TagsEN.TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容
objgs_TagsEN.PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objgs_TagsEN.PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objgs_TagsEN.VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.VoteCount].ToString().Trim()); //点赞计数
objgs_TagsEN.UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(); //用户ID
objgs_TagsEN.OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.OrderNum].ToString().Trim()); //序号
objgs_TagsEN.UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(); //修改人
objgs_TagsEN.UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期
objgs_TagsEN.PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objgs_TagsEN.PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(); //PdfX
objgs_TagsEN.PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(); //PdfY
objgs_TagsEN.Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(); //备注
objgs_TagsEN.IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TagsEN.PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(); //论文Id
objgs_TagsEN.ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(); //分享Id
objgs_TagsEN.PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objgs_TagsEN.PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objgs_TagsEN.selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围
objgs_TagsEN.PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objgs_TagsEN.PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objgs_TagsEN.PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objgs_TagsEN.TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_TagsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_TagsEN> GetSubObjLstCache(clsgs_TagsEN objgs_TagsCond)
{
List<clsgs_TagsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TagsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_Tags.AttributeName)
{
if (objgs_TagsCond.IsUpdated(strFldName) == false) continue;
if (objgs_TagsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TagsCond[strFldName].ToString());
}
else
{
if (objgs_TagsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_TagsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TagsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_TagsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_TagsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_TagsCond[strFldName]));
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
public static List<clsgs_TagsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_TagsEN> arrObjLst = new List<clsgs_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN();
try
{
objgs_TagsEN.TagsId = objRow[congs_Tags.TagsId].ToString().Trim(); //标注Id
objgs_TagsEN.TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容
objgs_TagsEN.PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objgs_TagsEN.PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objgs_TagsEN.VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.VoteCount].ToString().Trim()); //点赞计数
objgs_TagsEN.UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(); //用户ID
objgs_TagsEN.OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.OrderNum].ToString().Trim()); //序号
objgs_TagsEN.UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(); //修改人
objgs_TagsEN.UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期
objgs_TagsEN.PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objgs_TagsEN.PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(); //PdfX
objgs_TagsEN.PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(); //PdfY
objgs_TagsEN.Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(); //备注
objgs_TagsEN.IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TagsEN.PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(); //论文Id
objgs_TagsEN.ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(); //分享Id
objgs_TagsEN.PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objgs_TagsEN.PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objgs_TagsEN.selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围
objgs_TagsEN.PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objgs_TagsEN.PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objgs_TagsEN.PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objgs_TagsEN.TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsEN);
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
public static List<clsgs_TagsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_TagsEN> arrObjLst = new List<clsgs_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN();
try
{
objgs_TagsEN.TagsId = objRow[congs_Tags.TagsId].ToString().Trim(); //标注Id
objgs_TagsEN.TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容
objgs_TagsEN.PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objgs_TagsEN.PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objgs_TagsEN.VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.VoteCount].ToString().Trim()); //点赞计数
objgs_TagsEN.UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(); //用户ID
objgs_TagsEN.OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.OrderNum].ToString().Trim()); //序号
objgs_TagsEN.UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(); //修改人
objgs_TagsEN.UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期
objgs_TagsEN.PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objgs_TagsEN.PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(); //PdfX
objgs_TagsEN.PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(); //PdfY
objgs_TagsEN.Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(); //备注
objgs_TagsEN.IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TagsEN.PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(); //论文Id
objgs_TagsEN.ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(); //分享Id
objgs_TagsEN.PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objgs_TagsEN.PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objgs_TagsEN.selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围
objgs_TagsEN.PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objgs_TagsEN.PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objgs_TagsEN.PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objgs_TagsEN.TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsEN);
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
List<clsgs_TagsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_TagsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_TagsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_TagsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_TagsEN> arrObjLst = new List<clsgs_TagsEN>(); 
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
	clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN();
try
{
objgs_TagsEN.TagsId = objRow[congs_Tags.TagsId].ToString().Trim(); //标注Id
objgs_TagsEN.TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容
objgs_TagsEN.PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objgs_TagsEN.PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objgs_TagsEN.VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.VoteCount].ToString().Trim()); //点赞计数
objgs_TagsEN.UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(); //用户ID
objgs_TagsEN.OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.OrderNum].ToString().Trim()); //序号
objgs_TagsEN.UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(); //修改人
objgs_TagsEN.UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期
objgs_TagsEN.PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objgs_TagsEN.PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(); //PdfX
objgs_TagsEN.PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(); //PdfY
objgs_TagsEN.Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(); //备注
objgs_TagsEN.IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TagsEN.PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(); //论文Id
objgs_TagsEN.ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(); //分享Id
objgs_TagsEN.PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objgs_TagsEN.PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objgs_TagsEN.selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围
objgs_TagsEN.PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objgs_TagsEN.PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objgs_TagsEN.PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objgs_TagsEN.TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsEN);
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
public static List<clsgs_TagsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_TagsEN> arrObjLst = new List<clsgs_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN();
try
{
objgs_TagsEN.TagsId = objRow[congs_Tags.TagsId].ToString().Trim(); //标注Id
objgs_TagsEN.TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容
objgs_TagsEN.PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objgs_TagsEN.PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objgs_TagsEN.VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.VoteCount].ToString().Trim()); //点赞计数
objgs_TagsEN.UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(); //用户ID
objgs_TagsEN.OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.OrderNum].ToString().Trim()); //序号
objgs_TagsEN.UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(); //修改人
objgs_TagsEN.UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期
objgs_TagsEN.PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objgs_TagsEN.PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(); //PdfX
objgs_TagsEN.PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(); //PdfY
objgs_TagsEN.Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(); //备注
objgs_TagsEN.IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TagsEN.PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(); //论文Id
objgs_TagsEN.ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(); //分享Id
objgs_TagsEN.PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objgs_TagsEN.PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objgs_TagsEN.selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围
objgs_TagsEN.PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objgs_TagsEN.PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objgs_TagsEN.PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objgs_TagsEN.TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_TagsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_TagsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_TagsEN> arrObjLst = new List<clsgs_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN();
try
{
objgs_TagsEN.TagsId = objRow[congs_Tags.TagsId].ToString().Trim(); //标注Id
objgs_TagsEN.TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容
objgs_TagsEN.PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objgs_TagsEN.PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objgs_TagsEN.VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.VoteCount].ToString().Trim()); //点赞计数
objgs_TagsEN.UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(); //用户ID
objgs_TagsEN.OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.OrderNum].ToString().Trim()); //序号
objgs_TagsEN.UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(); //修改人
objgs_TagsEN.UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期
objgs_TagsEN.PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objgs_TagsEN.PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(); //PdfX
objgs_TagsEN.PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(); //PdfY
objgs_TagsEN.Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(); //备注
objgs_TagsEN.IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TagsEN.PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(); //论文Id
objgs_TagsEN.ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(); //分享Id
objgs_TagsEN.PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objgs_TagsEN.PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objgs_TagsEN.selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围
objgs_TagsEN.PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objgs_TagsEN.PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objgs_TagsEN.PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objgs_TagsEN.TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsEN);
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
public static List<clsgs_TagsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_TagsEN> arrObjLst = new List<clsgs_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN();
try
{
objgs_TagsEN.TagsId = objRow[congs_Tags.TagsId].ToString().Trim(); //标注Id
objgs_TagsEN.TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容
objgs_TagsEN.PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objgs_TagsEN.PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objgs_TagsEN.VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.VoteCount].ToString().Trim()); //点赞计数
objgs_TagsEN.UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(); //用户ID
objgs_TagsEN.OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.OrderNum].ToString().Trim()); //序号
objgs_TagsEN.UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(); //修改人
objgs_TagsEN.UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期
objgs_TagsEN.PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objgs_TagsEN.PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(); //PdfX
objgs_TagsEN.PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(); //PdfY
objgs_TagsEN.Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(); //备注
objgs_TagsEN.IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TagsEN.PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(); //论文Id
objgs_TagsEN.ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(); //分享Id
objgs_TagsEN.PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objgs_TagsEN.PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objgs_TagsEN.selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围
objgs_TagsEN.PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objgs_TagsEN.PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objgs_TagsEN.PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objgs_TagsEN.TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_TagsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_TagsEN> arrObjLst = new List<clsgs_TagsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN();
try
{
objgs_TagsEN.TagsId = objRow[congs_Tags.TagsId].ToString().Trim(); //标注Id
objgs_TagsEN.TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容
objgs_TagsEN.PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objgs_TagsEN.PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objgs_TagsEN.VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.VoteCount].ToString().Trim()); //点赞计数
objgs_TagsEN.UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(); //用户ID
objgs_TagsEN.OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.OrderNum].ToString().Trim()); //序号
objgs_TagsEN.UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(); //修改人
objgs_TagsEN.UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期
objgs_TagsEN.PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objgs_TagsEN.PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(); //PdfX
objgs_TagsEN.PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(); //PdfY
objgs_TagsEN.Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(); //备注
objgs_TagsEN.IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TagsEN.PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(); //论文Id
objgs_TagsEN.ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(); //分享Id
objgs_TagsEN.PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objgs_TagsEN.PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objgs_TagsEN.selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围
objgs_TagsEN.PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objgs_TagsEN.PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objgs_TagsEN.PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objgs_TagsEN.TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_TagsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_Tags(ref clsgs_TagsEN objgs_TagsEN)
{
bool bolResult = gs_TagsDA.Getgs_Tags(ref objgs_TagsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTagsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_TagsEN GetObjByTagsId(string strTagsId)
{
if (strTagsId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTagsId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTagsId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTagsId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsgs_TagsEN objgs_TagsEN = gs_TagsDA.GetObjByTagsId(strTagsId);
return objgs_TagsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_TagsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_TagsEN objgs_TagsEN = gs_TagsDA.GetFirstObj(strWhereCond);
 return objgs_TagsEN;
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
public static clsgs_TagsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_TagsEN objgs_TagsEN = gs_TagsDA.GetObjByDataRow(objRow);
 return objgs_TagsEN;
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
public static clsgs_TagsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_TagsEN objgs_TagsEN = gs_TagsDA.GetObjByDataRow(objRow);
 return objgs_TagsEN;
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
 /// <param name = "strTagsId">所给的关键字</param>
 /// <param name = "lstgs_TagsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_TagsEN GetObjByTagsIdFromList(string strTagsId, List<clsgs_TagsEN> lstgs_TagsObjLst)
{
foreach (clsgs_TagsEN objgs_TagsEN in lstgs_TagsObjLst)
{
if (objgs_TagsEN.TagsId == strTagsId)
{
return objgs_TagsEN;
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
 string strMaxTagsId;
 try
 {
 strMaxTagsId = clsgs_TagsDA.GetMaxStrId();
 return strMaxTagsId;
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
 string strTagsId;
 try
 {
 strTagsId = new clsgs_TagsDA().GetFirstID(strWhereCond);
 return strTagsId;
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
 arrList = gs_TagsDA.GetID(strWhereCond);
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
bool bolIsExist = gs_TagsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTagsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTagsId)
{
if (string.IsNullOrEmpty(strTagsId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTagsId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = gs_TagsDA.IsExist(strTagsId);
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
 bolIsExist = clsgs_TagsDA.IsExistTable();
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
 bolIsExist = gs_TagsDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_TagsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_TagsEN objgs_TagsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_TagsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],标注Id = [{1}]的数据已经存在!(in clsgs_TagsBL.AddNewRecordBySql2)", objgs_TagsEN.PaperId,objgs_TagsEN.TagsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TagsEN.TagsId) == true || clsgs_TagsBL.IsExist(objgs_TagsEN.TagsId) == true)
 {
     objgs_TagsEN.TagsId = clsgs_TagsBL.GetMaxStrId_S();
 }
bool bolResult = gs_TagsDA.AddNewRecordBySQL2(objgs_TagsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsBL.ReFreshCache();

if (clsgs_TagsBL.relatedActions != null)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(objgs_TagsEN.TagsId, "SetUpdDate");
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
 /// <param name = "objgs_TagsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_TagsEN objgs_TagsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_TagsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],标注Id = [{1}]的数据已经存在!(in clsgs_TagsBL.AddNewRecordBySql2WithReturnKey)", objgs_TagsEN.PaperId,objgs_TagsEN.TagsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TagsEN.TagsId) == true || clsgs_TagsBL.IsExist(objgs_TagsEN.TagsId) == true)
 {
     objgs_TagsEN.TagsId = clsgs_TagsBL.GetMaxStrId_S();
 }
string strKey = gs_TagsDA.AddNewRecordBySQL2WithReturnKey(objgs_TagsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsBL.ReFreshCache();

if (clsgs_TagsBL.relatedActions != null)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(objgs_TagsEN.TagsId, "SetUpdDate");
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
 /// <param name = "objgs_TagsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_TagsEN objgs_TagsEN)
{
try
{
bool bolResult = gs_TagsDA.Update(objgs_TagsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsBL.ReFreshCache();

if (clsgs_TagsBL.relatedActions != null)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(objgs_TagsEN.TagsId, "SetUpdDate");
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
 /// <param name = "objgs_TagsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_TagsEN objgs_TagsEN)
{
 if (string.IsNullOrEmpty(objgs_TagsEN.TagsId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_TagsDA.UpdateBySql2(objgs_TagsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsBL.ReFreshCache();

if (clsgs_TagsBL.relatedActions != null)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(objgs_TagsEN.TagsId, "SetUpdDate");
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
 /// <param name = "strTagsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTagsId)
{
try
{
 clsgs_TagsEN objgs_TagsEN = clsgs_TagsBL.GetObjByTagsId(strTagsId);

if (clsgs_TagsBL.relatedActions != null)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(objgs_TagsEN.TagsId, "SetUpdDate");
}
if (objgs_TagsEN != null)
{
int intRecNum = gs_TagsDA.DelRecord(strTagsId);
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
/// <param name="strTagsId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strTagsId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_TagsDA.GetSpecSQLObj();
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
//删除与表:[gs_Tags]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_Tags.TagsId,
//strTagsId);
//        clsgs_TagsBL.Delgs_TagssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_TagsBL.DelRecord(strTagsId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_TagsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTagsId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strTagsId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTagsId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_TagsBL.relatedActions != null)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(strTagsId, "UpdRelaTabDate");
}
bool bolResult = gs_TagsDA.DelRecord(strTagsId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrTagsIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_Tagss(List<string> arrTagsIdLst)
{
if (arrTagsIdLst.Count == 0) return 0;
try
{
if (clsgs_TagsBL.relatedActions != null)
{
foreach (var strTagsId in arrTagsIdLst)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(strTagsId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_TagsDA.Delgs_Tags(arrTagsIdLst);
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
public static int Delgs_TagssByCond(string strWhereCond)
{
try
{
if (clsgs_TagsBL.relatedActions != null)
{
List<string> arrTagsId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTagsId in arrTagsId)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(strTagsId, "UpdRelaTabDate");
}
}
int intRecNum = gs_TagsDA.Delgs_Tags(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_Tags]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTagsId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTagsId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_TagsDA.GetSpecSQLObj();
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
//删除与表:[gs_Tags]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_TagsBL.DelRecord(strTagsId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_TagsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTagsId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_TagsENS">源对象</param>
 /// <param name = "objgs_TagsENT">目标对象</param>
 public static void CopyTo(clsgs_TagsEN objgs_TagsENS, clsgs_TagsEN objgs_TagsENT)
{
try
{
objgs_TagsENT.TagsId = objgs_TagsENS.TagsId; //标注Id
objgs_TagsENT.TagsContent = objgs_TagsENS.TagsContent; //标注内容
objgs_TagsENT.PdfContent = objgs_TagsENS.PdfContent; //Pdf内容
objgs_TagsENT.PdfPageNum = objgs_TagsENS.PdfPageNum; //Pdf页码
objgs_TagsENT.VoteCount = objgs_TagsENS.VoteCount; //点赞计数
objgs_TagsENT.UserId = objgs_TagsENS.UserId; //用户ID
objgs_TagsENT.OrderNum = objgs_TagsENS.OrderNum; //序号
objgs_TagsENT.UpdUser = objgs_TagsENS.UpdUser; //修改人
objgs_TagsENT.UpdDate = objgs_TagsENS.UpdDate; //修改日期
objgs_TagsENT.PdfLineNum = objgs_TagsENS.PdfLineNum; //pdf行号
objgs_TagsENT.PdfX = objgs_TagsENS.PdfX; //PdfX
objgs_TagsENT.PdfY = objgs_TagsENS.PdfY; //PdfY
objgs_TagsENT.Memo = objgs_TagsENS.Memo; //备注
objgs_TagsENT.IdCurrEduCls = objgs_TagsENS.IdCurrEduCls; //教学班流水号
objgs_TagsENT.PaperId = objgs_TagsENS.PaperId; //论文Id
objgs_TagsENT.ShareId = objgs_TagsENS.ShareId; //分享Id
objgs_TagsENT.PdfPageNumIn = objgs_TagsENS.PdfPageNumIn; //PdfPageNumIn
objgs_TagsENT.PdfPageTop = objgs_TagsENS.PdfPageTop; //pdf页面顶部位置
objgs_TagsENT.selectSpanRange = objgs_TagsENS.selectSpanRange; //选择Span范围
objgs_TagsENT.PdfDivLet = objgs_TagsENS.PdfDivLet; //PdfDivLet
objgs_TagsENT.PdfDivTop = objgs_TagsENS.PdfDivTop; //PdfDivTop
objgs_TagsENT.PdfZoom = objgs_TagsENS.PdfZoom; //PdfZoom
objgs_TagsENT.TagsTypeId = objgs_TagsENS.TagsTypeId; //标注类型ID
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
 /// <param name = "objgs_TagsEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_TagsEN objgs_TagsEN)
{
try
{
objgs_TagsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_TagsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_Tags.TagsId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.TagsId = objgs_TagsEN.TagsId; //标注Id
}
if (arrFldSet.Contains(congs_Tags.TagsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.TagsContent = objgs_TagsEN.TagsContent == "[null]" ? null :  objgs_TagsEN.TagsContent; //标注内容
}
if (arrFldSet.Contains(congs_Tags.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.PdfContent = objgs_TagsEN.PdfContent == "[null]" ? null :  objgs_TagsEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(congs_Tags.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.PdfPageNum = objgs_TagsEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(congs_Tags.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.VoteCount = objgs_TagsEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(congs_Tags.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.UserId = objgs_TagsEN.UserId == "[null]" ? null :  objgs_TagsEN.UserId; //用户ID
}
if (arrFldSet.Contains(congs_Tags.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.OrderNum = objgs_TagsEN.OrderNum; //序号
}
if (arrFldSet.Contains(congs_Tags.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.UpdUser = objgs_TagsEN.UpdUser == "[null]" ? null :  objgs_TagsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_Tags.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.UpdDate = objgs_TagsEN.UpdDate == "[null]" ? null :  objgs_TagsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_Tags.PdfLineNum, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.PdfLineNum = objgs_TagsEN.PdfLineNum; //pdf行号
}
if (arrFldSet.Contains(congs_Tags.PdfX, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.PdfX = objgs_TagsEN.PdfX == "[null]" ? null :  objgs_TagsEN.PdfX; //PdfX
}
if (arrFldSet.Contains(congs_Tags.PdfY, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.PdfY = objgs_TagsEN.PdfY == "[null]" ? null :  objgs_TagsEN.PdfY; //PdfY
}
if (arrFldSet.Contains(congs_Tags.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.Memo = objgs_TagsEN.Memo == "[null]" ? null :  objgs_TagsEN.Memo; //备注
}
if (arrFldSet.Contains(congs_Tags.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.IdCurrEduCls = objgs_TagsEN.IdCurrEduCls == "[null]" ? null :  objgs_TagsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(congs_Tags.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.PaperId = objgs_TagsEN.PaperId == "[null]" ? null :  objgs_TagsEN.PaperId; //论文Id
}
if (arrFldSet.Contains(congs_Tags.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.ShareId = objgs_TagsEN.ShareId == "[null]" ? null :  objgs_TagsEN.ShareId; //分享Id
}
if (arrFldSet.Contains(congs_Tags.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.PdfPageNumIn = objgs_TagsEN.PdfPageNumIn == "[null]" ? null :  objgs_TagsEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(congs_Tags.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.PdfPageTop = objgs_TagsEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(congs_Tags.selectSpanRange, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.selectSpanRange = objgs_TagsEN.selectSpanRange == "[null]" ? null :  objgs_TagsEN.selectSpanRange; //选择Span范围
}
if (arrFldSet.Contains(congs_Tags.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.PdfDivLet = objgs_TagsEN.PdfDivLet == "[null]" ? null :  objgs_TagsEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(congs_Tags.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.PdfDivTop = objgs_TagsEN.PdfDivTop == "[null]" ? null :  objgs_TagsEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(congs_Tags.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.PdfZoom = objgs_TagsEN.PdfZoom == "[null]" ? null :  objgs_TagsEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(congs_Tags.TagsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsEN.TagsTypeId = objgs_TagsEN.TagsTypeId == "[null]" ? null :  objgs_TagsEN.TagsTypeId; //标注类型ID
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
 /// <param name = "objgs_TagsEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_TagsEN objgs_TagsEN)
{
try
{
if (objgs_TagsEN.TagsContent == "[null]") objgs_TagsEN.TagsContent = null; //标注内容
if (objgs_TagsEN.PdfContent == "[null]") objgs_TagsEN.PdfContent = null; //Pdf内容
if (objgs_TagsEN.UserId == "[null]") objgs_TagsEN.UserId = null; //用户ID
if (objgs_TagsEN.UpdUser == "[null]") objgs_TagsEN.UpdUser = null; //修改人
if (objgs_TagsEN.UpdDate == "[null]") objgs_TagsEN.UpdDate = null; //修改日期
if (objgs_TagsEN.PdfX == "[null]") objgs_TagsEN.PdfX = null; //PdfX
if (objgs_TagsEN.PdfY == "[null]") objgs_TagsEN.PdfY = null; //PdfY
if (objgs_TagsEN.Memo == "[null]") objgs_TagsEN.Memo = null; //备注
if (objgs_TagsEN.IdCurrEduCls == "[null]") objgs_TagsEN.IdCurrEduCls = null; //教学班流水号
if (objgs_TagsEN.PaperId == "[null]") objgs_TagsEN.PaperId = null; //论文Id
if (objgs_TagsEN.ShareId == "[null]") objgs_TagsEN.ShareId = null; //分享Id
if (objgs_TagsEN.PdfPageNumIn == "[null]") objgs_TagsEN.PdfPageNumIn = null; //PdfPageNumIn
if (objgs_TagsEN.selectSpanRange == "[null]") objgs_TagsEN.selectSpanRange = null; //选择Span范围
if (objgs_TagsEN.PdfDivLet == "[null]") objgs_TagsEN.PdfDivLet = null; //PdfDivLet
if (objgs_TagsEN.PdfDivTop == "[null]") objgs_TagsEN.PdfDivTop = null; //PdfDivTop
if (objgs_TagsEN.PdfZoom == "[null]") objgs_TagsEN.PdfZoom = null; //PdfZoom
if (objgs_TagsEN.TagsTypeId == "[null]") objgs_TagsEN.TagsTypeId = null; //标注类型ID
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
public static void CheckPropertyNew(clsgs_TagsEN objgs_TagsEN)
{
 gs_TagsDA.CheckPropertyNew(objgs_TagsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_TagsEN objgs_TagsEN)
{
 gs_TagsDA.CheckProperty4Condition(objgs_TagsEN);
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
if (clsgs_TagsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_TagsBL没有刷新缓存机制(clsgs_TagsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TagsId");
//if (arrgs_TagsObjLstCache == null)
//{
//arrgs_TagsObjLstCache = gs_TagsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTagsId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_TagsEN GetObjByTagsIdCache(string strTagsId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_TagsEN._CurrTabName);
List<clsgs_TagsEN> arrgs_TagsObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TagsEN> arrgs_TagsObjLst_Sel =
arrgs_TagsObjLstCache
.Where(x=> x.TagsId == strTagsId 
);
if (arrgs_TagsObjLst_Sel.Count() == 0)
{
   clsgs_TagsEN obj = clsgs_TagsBL.GetObjByTagsId(strTagsId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_TagsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_TagsEN> GetAllgs_TagsObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_TagsEN> arrgs_TagsObjLstCache = GetObjLstCache(); 
return arrgs_TagsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_TagsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_TagsEN._CurrTabName);
List<clsgs_TagsEN> arrgs_TagsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_TagsObjLstCache;
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
string strKey = string.Format("{0}", clsgs_TagsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_TagsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_TagsEN._RefreshTimeLst.Count == 0) return "";
return clsgs_TagsEN._RefreshTimeLst[clsgs_TagsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_TagsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_TagsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_TagsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_TagsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_Tags(标注)
 /// 唯一性条件:PaperId_TagsId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_TagsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_TagsEN objgs_TagsEN)
{
//检测记录是否存在
string strResult = gs_TagsDA.GetUniCondStr(objgs_TagsEN);
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
public static string Func(string strInFldName, string strOutFldName, string strTagsId)
{
if (strInFldName != congs_Tags.TagsId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_Tags.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_Tags.AttributeName));
throw new Exception(strMsg);
}
var objgs_Tags = clsgs_TagsBL.GetObjByTagsIdCache(strTagsId);
if (objgs_Tags == null) return "";
return objgs_Tags[strOutFldName].ToString();
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
int intRecCount = clsgs_TagsDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_TagsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_TagsDA.GetRecCount();
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
int intRecCount = clsgs_TagsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_TagsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_TagsEN objgs_TagsCond)
{
List<clsgs_TagsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TagsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_Tags.AttributeName)
{
if (objgs_TagsCond.IsUpdated(strFldName) == false) continue;
if (objgs_TagsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TagsCond[strFldName].ToString());
}
else
{
if (objgs_TagsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_TagsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TagsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_TagsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_TagsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_TagsCond[strFldName]));
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
 List<string> arrList = clsgs_TagsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_TagsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_TagsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_TagsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_TagsDA.SetFldValue(clsgs_TagsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_TagsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_TagsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_TagsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_TagsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_Tags] "); 
 strCreateTabCode.Append(" ( "); 
 // /**标注Id*/ 
 strCreateTabCode.Append(" TagsId char(10) primary key, "); 
 // /**标注内容*/ 
 strCreateTabCode.Append(" TagsContent text Null, "); 
 // /**Pdf内容*/ 
 strCreateTabCode.Append(" PdfContent varchar(2000) Null, "); 
 // /**Pdf页码*/ 
 strCreateTabCode.Append(" PdfPageNum int Null, "); 
 // /**点赞计数*/ 
 strCreateTabCode.Append(" VoteCount int Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**pdf行号*/ 
 strCreateTabCode.Append(" PdfLineNum int Null, "); 
 // /**PdfX*/ 
 strCreateTabCode.Append(" PdfX varchar(50) Null, "); 
 // /**PdfY*/ 
 strCreateTabCode.Append(" PdfY varchar(50) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" ShareId char(2) Null, "); 
 // /**PdfPageNumIn*/ 
 strCreateTabCode.Append(" PdfPageNumIn varchar(50) Null, "); 
 // /**pdf页面顶部位置*/ 
 strCreateTabCode.Append(" PdfPageTop int Null, "); 
 // /**选择Span范围*/ 
 strCreateTabCode.Append(" selectSpanRange varchar(50) Null, "); 
 // /**PdfDivLet*/ 
 strCreateTabCode.Append(" PdfDivLet varchar(50) Null, "); 
 // /**PdfDivTop*/ 
 strCreateTabCode.Append(" PdfDivTop varchar(50) Null, "); 
 // /**PdfZoom*/ 
 strCreateTabCode.Append(" PdfZoom varchar(50) Null, "); 
 // /**标注类型ID*/ 
 strCreateTabCode.Append(" TagsTypeId char(2) Null, "); 
 // /**论文标题*/ 
 strCreateTabCode.Append(" PaperTitle varchar(500) Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) not Null, "); 
 // /**主题名称*/ 
 strCreateTabCode.Append(" PaperName varchar(500) not Null, "); 
 // /**论文标题作者*/ 
 strCreateTabCode.Append(" PaperTitleAuthor varchar(500) not Null ");
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
string strCondition = string.Format("1 = 1 order by {0} ", congs_Tags.OrderNum); 
List<clsgs_TagsEN> arrgs_TagsObjList = new clsgs_TagsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsgs_TagsEN objgs_Tags in arrgs_TagsObjList)
{
objgs_Tags.OrderNum = intIndex;
UpdateBySql2(objgs_Tags);
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
/// <param name="strTagsId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strTagsId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[TagsId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字TagsId
//5、把当前关键字TagsId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字TagsId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevTagsId = "";    //上一条序号的关键字TagsId
string strNextTagsId = "";    //下一条序号的关键字TagsId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[TagsId],获取相应的序号[OrderNum]。

clsgs_TagsEN objgs_Tags = clsgs_TagsBL.GetObjByTagsId(strTagsId);

intOrderNum = objgs_Tags.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsgs_TagsBL.GetRecCountByCond(clsgs_TagsEN._CurrTabName, "1 = 1");    //获取当前表的记录数
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
strCondition.AppendFormat(" {0} = {1}", congs_Tags.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字TagsId
strPrevTagsId = clsgs_TagsBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevTagsId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字TagsId所对应记录的序号减1
//6、把下(上)一个序号关键字TagsId所对应的记录序号加1
clsgs_TagsBL.SetFldValue(clsgs_TagsEN._CurrTabName, congs_Tags.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", congs_Tags.TagsId, strTagsId));
clsgs_TagsBL.SetFldValue(clsgs_TagsEN._CurrTabName, congs_Tags.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", congs_Tags.TagsId, strPrevTagsId));
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

//4、获取下一个序号字段的关键字TagsId
strCondition.AppendFormat(" {0} = {1}", congs_Tags.OrderNum, intOrderNum + 1);

strNextTagsId = clsgs_TagsBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextTagsId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字TagsId所对应记录的序号加1
//6、把下(上)一个序号关键字TagsId所对应的记录序号减1
clsgs_TagsBL.SetFldValue(clsgs_TagsEN._CurrTabName, congs_Tags.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", congs_Tags.TagsId, strTagsId));
clsgs_TagsBL.SetFldValue(clsgs_TagsEN._CurrTabName, congs_Tags.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", congs_Tags.TagsId, strNextTagsId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsgs_TagsBL.ReFreshCache();
if (clsgs_TagsBL.relatedActions != null)
{
clsgs_TagsBL.relatedActions.UpdRelaTabDate(objgs_Tags.TagsId, "UpdRelaTabDate");
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
string strCondition = string.Format("{0} in ({1})", congs_Tags.TagsId, strKeyList);
List<clsgs_TagsEN> arrgs_TagsLst = GetObjLst(strCondition);
foreach (clsgs_TagsEN objgs_Tags in arrgs_TagsLst)
{
objgs_Tags.OrderNum = objgs_Tags.OrderNum + 10000;
UpdateBySql2(objgs_Tags);
}
strCondition = string.Format("1 = 1 order by {0} ", congs_Tags.OrderNum); 
List<clsgs_TagsEN> arrgs_TagsObjList = new clsgs_TagsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsgs_TagsEN objgs_Tags in arrgs_TagsObjList)
{
objgs_Tags.OrderNum = intIndex;
UpdateBySql2(objgs_Tags);
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
string strCondition = string.Format("{0} in ({1})", congs_Tags.TagsId, strKeyList);
List<clsgs_TagsEN> arrgs_TagsLst = GetObjLst(strCondition);
foreach (clsgs_TagsEN objgs_Tags in arrgs_TagsLst)
{
objgs_Tags.OrderNum = objgs_Tags.OrderNum - 10000;
UpdateBySql2(objgs_Tags);
}
strCondition = string.Format("1 = 1 order by {0} ", congs_Tags.OrderNum); 
List<clsgs_TagsEN> arrgs_TagsObjList = new clsgs_TagsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsgs_TagsEN objgs_Tags in arrgs_TagsObjList)
{
objgs_Tags.OrderNum = intIndex;
UpdateBySql2(objgs_Tags);
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
 /// 标注(gs_Tags)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_Tags : clsCommFun4BL
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
clsgs_TagsBL.ReFreshThisCache();
}
}

}