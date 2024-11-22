
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TagsBL
 表名:zx_Tags(01120807)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:03:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clszx_TagsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxTagsId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TagsEN GetObj(this K_zxTagsId_zx_Tags myKey)
{
clszx_TagsEN objzx_TagsEN = clszx_TagsBL.zx_TagsDA.GetObjByzxTagsId(myKey.Value);
return objzx_TagsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_TagsEN objzx_TagsEN)
{
if (CheckUniqueness(objzx_TagsEN) == false)
{
var strMsg = string.Format("记录已经存在!标注Id = [{0}]的数据已经存在!(in clszx_TagsBL.AddNewRecord)", objzx_TagsEN.zxTagsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TagsEN.zxTagsId) == true || clszx_TagsBL.IsExist(objzx_TagsEN.zxTagsId) == true)
 {
     objzx_TagsEN.zxTagsId = clszx_TagsBL.GetMaxStrId_S();
 }
bool bolResult = clszx_TagsBL.zx_TagsDA.AddNewRecordBySQL2(objzx_TagsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TagsBL.ReFreshCache();

if (clszx_TagsBL.relatedActions != null)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(objzx_TagsEN.zxTagsId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_TagsEN objzx_TagsEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_TagsBL.IsExist(objzx_TagsEN.zxTagsId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_TagsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_TagsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(标注Id(zxTagsId)=[{0}])已经存在,不能重复!", objzx_TagsEN.zxTagsId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_TagsEN.zxTagsId) == true || clszx_TagsBL.IsExist(objzx_TagsEN.zxTagsId) == true)
 {
     objzx_TagsEN.zxTagsId = clszx_TagsBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_TagsEN.AddNewRecord();
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
 /// <param name = "objzx_TagsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_TagsEN objzx_TagsEN)
{
if (CheckUniqueness(objzx_TagsEN) == false)
{
var strMsg = string.Format("记录已经存在!标注Id = [{0}]的数据已经存在!(in clszx_TagsBL.AddNewRecordWithMaxId)", objzx_TagsEN.zxTagsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TagsEN.zxTagsId) == true || clszx_TagsBL.IsExist(objzx_TagsEN.zxTagsId) == true)
 {
     objzx_TagsEN.zxTagsId = clszx_TagsBL.GetMaxStrId_S();
 }
string strzxTagsId = clszx_TagsBL.zx_TagsDA.AddNewRecordBySQL2WithReturnKey(objzx_TagsEN);
     objzx_TagsEN.zxTagsId = strzxTagsId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TagsBL.ReFreshCache();

if (clszx_TagsBL.relatedActions != null)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(objzx_TagsEN.zxTagsId, "SetUpdDate");
}
return strzxTagsId;
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
 /// <param name = "objzx_TagsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_TagsEN objzx_TagsEN)
{
if (CheckUniqueness(objzx_TagsEN) == false)
{
var strMsg = string.Format("记录已经存在!标注Id = [{0}]的数据已经存在!(in clszx_TagsBL.AddNewRecordWithReturnKey)", objzx_TagsEN.zxTagsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TagsEN.zxTagsId) == true || clszx_TagsBL.IsExist(objzx_TagsEN.zxTagsId) == true)
 {
     objzx_TagsEN.zxTagsId = clszx_TagsBL.GetMaxStrId_S();
 }
string strKey = clszx_TagsBL.zx_TagsDA.AddNewRecordBySQL2WithReturnKey(objzx_TagsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TagsBL.ReFreshCache();

if (clszx_TagsBL.relatedActions != null)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(objzx_TagsEN.zxTagsId, "SetUpdDate");
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
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetzxTagsId(this clszx_TagsEN objzx_TagsEN, string strzxTagsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxTagsId, 10, conzx_Tags.zxTagsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxTagsId, 10, conzx_Tags.zxTagsId);
}
objzx_TagsEN.zxTagsId = strzxTagsId; //标注Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.zxTagsId) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.zxTagsId, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.zxTagsId] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetTagsContent(this clszx_TagsEN objzx_TagsEN, string strTagsContent, string strComparisonOp="")
	{
objzx_TagsEN.TagsContent = strTagsContent; //标注内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.TagsContent) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.TagsContent, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.TagsContent] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetPdfContent(this clszx_TagsEN objzx_TagsEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conzx_Tags.PdfContent);
}
objzx_TagsEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.PdfContent) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.PdfContent, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.PdfContent] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetPdfPageNum(this clszx_TagsEN objzx_TagsEN, int? intPdfPageNum, string strComparisonOp="")
	{
objzx_TagsEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.PdfPageNum) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.PdfPageNum, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.PdfPageNum] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetVoteCount(this clszx_TagsEN objzx_TagsEN, int? intVoteCount, string strComparisonOp="")
	{
objzx_TagsEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.VoteCount) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.VoteCount, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.VoteCount] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetOrderNum(this clszx_TagsEN objzx_TagsEN, int? intOrderNum, string strComparisonOp="")
	{
objzx_TagsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.OrderNum) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.OrderNum, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.OrderNum] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetUpdUser(this clszx_TagsEN objzx_TagsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_Tags.UpdUser);
}
objzx_TagsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.UpdUser) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.UpdUser, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.UpdUser] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetUpdDate(this clszx_TagsEN objzx_TagsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_Tags.UpdDate);
}
objzx_TagsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.UpdDate) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.UpdDate, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.UpdDate] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetPdfLineNum(this clszx_TagsEN objzx_TagsEN, int? intPdfLineNum, string strComparisonOp="")
	{
objzx_TagsEN.PdfLineNum = intPdfLineNum; //pdf行号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.PdfLineNum) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.PdfLineNum, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.PdfLineNum] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetPdfX(this clszx_TagsEN objzx_TagsEN, string strPdfX, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfX, 50, conzx_Tags.PdfX);
}
objzx_TagsEN.PdfX = strPdfX; //PdfX
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.PdfX) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.PdfX, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.PdfX] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetPdfY(this clszx_TagsEN objzx_TagsEN, string strPdfY, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfY, 50, conzx_Tags.PdfY);
}
objzx_TagsEN.PdfY = strPdfY; //PdfY
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.PdfY) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.PdfY, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.PdfY] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetMemo(this clszx_TagsEN objzx_TagsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_Tags.Memo);
}
objzx_TagsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.Memo) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.Memo, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.Memo] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetIdCurrEduCls(this clszx_TagsEN objzx_TagsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_Tags.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_Tags.IdCurrEduCls);
}
objzx_TagsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.IdCurrEduCls) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetTextId(this clszx_TagsEN objzx_TagsEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_Tags.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_Tags.TextId);
}
objzx_TagsEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.TextId) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.TextId, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.TextId] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetzxShareId(this clszx_TagsEN objzx_TagsEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, conzx_Tags.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, conzx_Tags.zxShareId);
}
objzx_TagsEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.zxShareId) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.zxShareId, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.zxShareId] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetPdfPageNumIn(this clszx_TagsEN objzx_TagsEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, conzx_Tags.PdfPageNumIn);
}
objzx_TagsEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.PdfPageNumIn) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.PdfPageNumIn, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.PdfPageNumIn] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetPdfPageTop(this clszx_TagsEN objzx_TagsEN, int? intPdfPageTop, string strComparisonOp="")
	{
objzx_TagsEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.PdfPageTop) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.PdfPageTop, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.PdfPageTop] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetPdfDivLet(this clszx_TagsEN objzx_TagsEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, conzx_Tags.PdfDivLet);
}
objzx_TagsEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.PdfDivLet) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.PdfDivLet, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.PdfDivLet] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetPdfDivTop(this clszx_TagsEN objzx_TagsEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, conzx_Tags.PdfDivTop);
}
objzx_TagsEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.PdfDivTop) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.PdfDivTop, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.PdfDivTop] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetPdfZoom(this clszx_TagsEN objzx_TagsEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, conzx_Tags.PdfZoom);
}
objzx_TagsEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.PdfZoom) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.PdfZoom, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.PdfZoom] = strComparisonOp;
}
}
return objzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TagsEN SetzxTagsTypeId(this clszx_TagsEN objzx_TagsEN, string strzxTagsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxTagsTypeId, 2, conzx_Tags.zxTagsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxTagsTypeId, 2, conzx_Tags.zxTagsTypeId);
}
objzx_TagsEN.zxTagsTypeId = strzxTagsTypeId; //标注类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TagsEN.dicFldComparisonOp.ContainsKey(conzx_Tags.zxTagsTypeId) == false)
{
objzx_TagsEN.dicFldComparisonOp.Add(conzx_Tags.zxTagsTypeId, strComparisonOp);
}
else
{
objzx_TagsEN.dicFldComparisonOp[conzx_Tags.zxTagsTypeId] = strComparisonOp;
}
}
return objzx_TagsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_TagsEN objzx_TagsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_TagsEN.CheckPropertyNew();
clszx_TagsEN objzx_TagsCond = new clszx_TagsEN();
string strCondition = objzx_TagsCond
.SetzxTagsId(objzx_TagsEN.zxTagsId, "<>")
.SetzxTagsId(objzx_TagsEN.zxTagsId, "=")
.GetCombineCondition();
objzx_TagsEN._IsCheckProperty = true;
bool bolIsExist = clszx_TagsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(zxTagsId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_TagsEN.Update();
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
 /// <param name = "objzx_Tags">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_TagsEN objzx_Tags)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_TagsEN objzx_TagsCond = new clszx_TagsEN();
string strCondition = objzx_TagsCond
.SetzxTagsId(objzx_Tags.zxTagsId, "=")
.GetCombineCondition();
objzx_Tags._IsCheckProperty = true;
bool bolIsExist = clszx_TagsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_Tags.zxTagsId = clszx_TagsBL.GetFirstID_S(strCondition);
objzx_Tags.UpdateWithCondition(strCondition);
}
else
{
objzx_Tags.zxTagsId = clszx_TagsBL.GetMaxStrId_S();
objzx_Tags.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TagsEN objzx_TagsEN)
{
 if (string.IsNullOrEmpty(objzx_TagsEN.zxTagsId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TagsBL.zx_TagsDA.UpdateBySql2(objzx_TagsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TagsBL.ReFreshCache();

if (clszx_TagsBL.relatedActions != null)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(objzx_TagsEN.zxTagsId, "SetUpdDate");
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
 /// <param name = "objzx_TagsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TagsEN objzx_TagsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_TagsEN.zxTagsId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TagsBL.zx_TagsDA.UpdateBySql2(objzx_TagsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TagsBL.ReFreshCache();

if (clszx_TagsBL.relatedActions != null)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(objzx_TagsEN.zxTagsId, "SetUpdDate");
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
 /// <param name = "objzx_TagsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TagsEN objzx_TagsEN, string strWhereCond)
{
try
{
bool bolResult = clszx_TagsBL.zx_TagsDA.UpdateBySqlWithCondition(objzx_TagsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TagsBL.ReFreshCache();

if (clszx_TagsBL.relatedActions != null)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(objzx_TagsEN.zxTagsId, "SetUpdDate");
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
 /// <param name = "objzx_TagsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TagsEN objzx_TagsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_TagsBL.zx_TagsDA.UpdateBySqlWithConditionTransaction(objzx_TagsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TagsBL.ReFreshCache();

if (clszx_TagsBL.relatedActions != null)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(objzx_TagsEN.zxTagsId, "SetUpdDate");
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
 /// <param name = "strzxTagsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_TagsEN objzx_TagsEN)
{
try
{
int intRecNum = clszx_TagsBL.zx_TagsDA.DelRecord(objzx_TagsEN.zxTagsId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TagsBL.ReFreshCache();

if (clszx_TagsBL.relatedActions != null)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(objzx_TagsEN.zxTagsId, "SetUpdDate");
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
 /// <param name = "objzx_TagsENS">源对象</param>
 /// <param name = "objzx_TagsENT">目标对象</param>
 public static void CopyTo(this clszx_TagsEN objzx_TagsENS, clszx_TagsEN objzx_TagsENT)
{
try
{
objzx_TagsENT.zxTagsId = objzx_TagsENS.zxTagsId; //标注Id
objzx_TagsENT.TagsContent = objzx_TagsENS.TagsContent; //标注内容
objzx_TagsENT.PdfContent = objzx_TagsENS.PdfContent; //Pdf内容
objzx_TagsENT.PdfPageNum = objzx_TagsENS.PdfPageNum; //Pdf页码
objzx_TagsENT.VoteCount = objzx_TagsENS.VoteCount; //点赞计数
objzx_TagsENT.OrderNum = objzx_TagsENS.OrderNum; //序号
objzx_TagsENT.UpdUser = objzx_TagsENS.UpdUser; //修改人
objzx_TagsENT.UpdDate = objzx_TagsENS.UpdDate; //修改日期
objzx_TagsENT.PdfLineNum = objzx_TagsENS.PdfLineNum; //pdf行号
objzx_TagsENT.PdfX = objzx_TagsENS.PdfX; //PdfX
objzx_TagsENT.PdfY = objzx_TagsENS.PdfY; //PdfY
objzx_TagsENT.Memo = objzx_TagsENS.Memo; //备注
objzx_TagsENT.IdCurrEduCls = objzx_TagsENS.IdCurrEduCls; //教学班流水号
objzx_TagsENT.TextId = objzx_TagsENS.TextId; //课件Id
objzx_TagsENT.zxShareId = objzx_TagsENS.zxShareId; //分享Id
objzx_TagsENT.PdfPageNumIn = objzx_TagsENS.PdfPageNumIn; //PdfPageNumIn
objzx_TagsENT.PdfPageTop = objzx_TagsENS.PdfPageTop; //pdf页面顶部位置
objzx_TagsENT.PdfDivLet = objzx_TagsENS.PdfDivLet; //PdfDivLet
objzx_TagsENT.PdfDivTop = objzx_TagsENS.PdfDivTop; //PdfDivTop
objzx_TagsENT.PdfZoom = objzx_TagsENS.PdfZoom; //PdfZoom
objzx_TagsENT.zxTagsTypeId = objzx_TagsENS.zxTagsTypeId; //标注类型ID
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
 /// <param name = "objzx_TagsENS">源对象</param>
 /// <returns>目标对象=>clszx_TagsEN:objzx_TagsENT</returns>
 public static clszx_TagsEN CopyTo(this clszx_TagsEN objzx_TagsENS)
{
try
{
 clszx_TagsEN objzx_TagsENT = new clszx_TagsEN()
{
zxTagsId = objzx_TagsENS.zxTagsId, //标注Id
TagsContent = objzx_TagsENS.TagsContent, //标注内容
PdfContent = objzx_TagsENS.PdfContent, //Pdf内容
PdfPageNum = objzx_TagsENS.PdfPageNum, //Pdf页码
VoteCount = objzx_TagsENS.VoteCount, //点赞计数
OrderNum = objzx_TagsENS.OrderNum, //序号
UpdUser = objzx_TagsENS.UpdUser, //修改人
UpdDate = objzx_TagsENS.UpdDate, //修改日期
PdfLineNum = objzx_TagsENS.PdfLineNum, //pdf行号
PdfX = objzx_TagsENS.PdfX, //PdfX
PdfY = objzx_TagsENS.PdfY, //PdfY
Memo = objzx_TagsENS.Memo, //备注
IdCurrEduCls = objzx_TagsENS.IdCurrEduCls, //教学班流水号
TextId = objzx_TagsENS.TextId, //课件Id
zxShareId = objzx_TagsENS.zxShareId, //分享Id
PdfPageNumIn = objzx_TagsENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objzx_TagsENS.PdfPageTop, //pdf页面顶部位置
PdfDivLet = objzx_TagsENS.PdfDivLet, //PdfDivLet
PdfDivTop = objzx_TagsENS.PdfDivTop, //PdfDivTop
PdfZoom = objzx_TagsENS.PdfZoom, //PdfZoom
zxTagsTypeId = objzx_TagsENS.zxTagsTypeId, //标注类型ID
};
 return objzx_TagsENT;
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
public static void CheckPropertyNew(this clszx_TagsEN objzx_TagsEN)
{
 clszx_TagsBL.zx_TagsDA.CheckPropertyNew(objzx_TagsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_TagsEN objzx_TagsEN)
{
 clszx_TagsBL.zx_TagsDA.CheckProperty4Condition(objzx_TagsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_TagsEN objzx_TagsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_TagsCond.IsUpdated(conzx_Tags.zxTagsId) == true)
{
string strComparisonOpzxTagsId = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.zxTagsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Tags.zxTagsId, objzx_TagsCond.zxTagsId, strComparisonOpzxTagsId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_TagsCond.IsUpdated(conzx_Tags.PdfContent) == true)
{
string strComparisonOpPdfContent = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Tags.PdfContent, objzx_TagsCond.PdfContent, strComparisonOpPdfContent);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Tags.PdfPageNum, objzx_TagsCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.VoteCount) == true)
{
string strComparisonOpVoteCount = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Tags.VoteCount, objzx_TagsCond.VoteCount, strComparisonOpVoteCount);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.OrderNum) == true)
{
string strComparisonOpOrderNum = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Tags.OrderNum, objzx_TagsCond.OrderNum, strComparisonOpOrderNum);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Tags.UpdUser, objzx_TagsCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Tags.UpdDate, objzx_TagsCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.PdfLineNum) == true)
{
string strComparisonOpPdfLineNum = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.PdfLineNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Tags.PdfLineNum, objzx_TagsCond.PdfLineNum, strComparisonOpPdfLineNum);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.PdfX) == true)
{
string strComparisonOpPdfX = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.PdfX];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Tags.PdfX, objzx_TagsCond.PdfX, strComparisonOpPdfX);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.PdfY) == true)
{
string strComparisonOpPdfY = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.PdfY];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Tags.PdfY, objzx_TagsCond.PdfY, strComparisonOpPdfY);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.Memo) == true)
{
string strComparisonOpMemo = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Tags.Memo, objzx_TagsCond.Memo, strComparisonOpMemo);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Tags.IdCurrEduCls, objzx_TagsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.TextId) == true)
{
string strComparisonOpTextId = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Tags.TextId, objzx_TagsCond.TextId, strComparisonOpTextId);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.zxShareId) == true)
{
string strComparisonOpzxShareId = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Tags.zxShareId, objzx_TagsCond.zxShareId, strComparisonOpzxShareId);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Tags.PdfPageNumIn, objzx_TagsCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Tags.PdfPageTop, objzx_TagsCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Tags.PdfDivLet, objzx_TagsCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Tags.PdfDivTop, objzx_TagsCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Tags.PdfZoom, objzx_TagsCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objzx_TagsCond.IsUpdated(conzx_Tags.zxTagsTypeId) == true)
{
string strComparisonOpzxTagsTypeId = objzx_TagsCond.dicFldComparisonOp[conzx_Tags.zxTagsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Tags.zxTagsTypeId, objzx_TagsCond.zxTagsTypeId, strComparisonOpzxTagsTypeId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_Tags(zx_Tags), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:zxTagsId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_TagsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_TagsEN objzx_TagsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_TagsEN == null) return true;
if (objzx_TagsEN.zxTagsId == null || objzx_TagsEN.zxTagsId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxTagsId = '{0}'", objzx_TagsEN.zxTagsId);
if (clszx_TagsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxTagsId !=  '{0}'", objzx_TagsEN.zxTagsId);
 sbCondition.AppendFormat(" and zxTagsId = '{0}'", objzx_TagsEN.zxTagsId);
if (clszx_TagsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_Tags(zx_Tags), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:zxTagsId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_TagsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_TagsEN objzx_TagsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_TagsEN == null) return "";
if (objzx_TagsEN.zxTagsId == null || objzx_TagsEN.zxTagsId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxTagsId = '{0}'", objzx_TagsEN.zxTagsId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxTagsId !=  '{0}'", objzx_TagsEN.zxTagsId);
 sbCondition.AppendFormat(" and zxTagsId = '{0}'", objzx_TagsEN.zxTagsId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_Tags
{
public virtual bool UpdRelaTabDate(string strzxTagsId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// zx_Tags(zx_Tags)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_TagsBL
{
public static RelatedActions_zx_Tags relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_TagsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_TagsDA zx_TagsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_TagsDA();
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
 public clszx_TagsBL()
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
if (string.IsNullOrEmpty(clszx_TagsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TagsEN._ConnectString);
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
public static DataTable GetDataTable_zx_Tags(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_TagsDA.GetDataTable_zx_Tags(strWhereCond);
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
objDT = zx_TagsDA.GetDataTable(strWhereCond);
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
objDT = zx_TagsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_TagsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_TagsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_TagsDA.GetDataTable_Top(objTopPara);
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
objDT = zx_TagsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_TagsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_TagsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxTagsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_TagsEN> GetObjLstByZxTagsIdLst(List<string> arrZxTagsIdLst)
{
List<clszx_TagsEN> arrObjLst = new List<clszx_TagsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxTagsIdLst, true);
 string strWhereCond = string.Format("zxTagsId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TagsEN objzx_TagsEN = new clszx_TagsEN();
try
{
objzx_TagsEN.zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objzx_TagsEN.TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容
objzx_TagsEN.PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objzx_TagsEN.PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TagsEN.VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objzx_TagsEN.OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.OrderNum].ToString().Trim()); //序号
objzx_TagsEN.UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人
objzx_TagsEN.UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期
objzx_TagsEN.PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objzx_TagsEN.PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX
objzx_TagsEN.PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY
objzx_TagsEN.Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(); //备注
objzx_TagsEN.IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TagsEN.TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(); //课件Id
objzx_TagsEN.zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id
objzx_TagsEN.PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TagsEN.PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TagsEN.PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TagsEN.PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TagsEN.PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TagsEN.zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxTagsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_TagsEN> GetObjLstByZxTagsIdLstCache(List<string> arrZxTagsIdLst)
{
string strKey = string.Format("{0}", clszx_TagsEN._CurrTabName);
List<clszx_TagsEN> arrzx_TagsObjLstCache = GetObjLstCache();
IEnumerable <clszx_TagsEN> arrzx_TagsObjLst_Sel =
arrzx_TagsObjLstCache
.Where(x => arrZxTagsIdLst.Contains(x.zxTagsId));
return arrzx_TagsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TagsEN> GetObjLst(string strWhereCond)
{
List<clszx_TagsEN> arrObjLst = new List<clszx_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TagsEN objzx_TagsEN = new clszx_TagsEN();
try
{
objzx_TagsEN.zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objzx_TagsEN.TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容
objzx_TagsEN.PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objzx_TagsEN.PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TagsEN.VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objzx_TagsEN.OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.OrderNum].ToString().Trim()); //序号
objzx_TagsEN.UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人
objzx_TagsEN.UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期
objzx_TagsEN.PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objzx_TagsEN.PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX
objzx_TagsEN.PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY
objzx_TagsEN.Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(); //备注
objzx_TagsEN.IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TagsEN.TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(); //课件Id
objzx_TagsEN.zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id
objzx_TagsEN.PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TagsEN.PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TagsEN.PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TagsEN.PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TagsEN.PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TagsEN.zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TagsEN);
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
public static List<clszx_TagsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_TagsEN> arrObjLst = new List<clszx_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TagsEN objzx_TagsEN = new clszx_TagsEN();
try
{
objzx_TagsEN.zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objzx_TagsEN.TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容
objzx_TagsEN.PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objzx_TagsEN.PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TagsEN.VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objzx_TagsEN.OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.OrderNum].ToString().Trim()); //序号
objzx_TagsEN.UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人
objzx_TagsEN.UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期
objzx_TagsEN.PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objzx_TagsEN.PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX
objzx_TagsEN.PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY
objzx_TagsEN.Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(); //备注
objzx_TagsEN.IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TagsEN.TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(); //课件Id
objzx_TagsEN.zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id
objzx_TagsEN.PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TagsEN.PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TagsEN.PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TagsEN.PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TagsEN.PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TagsEN.zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_TagsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_TagsEN> GetSubObjLstCache(clszx_TagsEN objzx_TagsCond)
{
List<clszx_TagsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_TagsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Tags.AttributeName)
{
if (objzx_TagsCond.IsUpdated(strFldName) == false) continue;
if (objzx_TagsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TagsCond[strFldName].ToString());
}
else
{
if (objzx_TagsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TagsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TagsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TagsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TagsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TagsCond[strFldName]));
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
public static List<clszx_TagsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_TagsEN> arrObjLst = new List<clszx_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TagsEN objzx_TagsEN = new clszx_TagsEN();
try
{
objzx_TagsEN.zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objzx_TagsEN.TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容
objzx_TagsEN.PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objzx_TagsEN.PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TagsEN.VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objzx_TagsEN.OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.OrderNum].ToString().Trim()); //序号
objzx_TagsEN.UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人
objzx_TagsEN.UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期
objzx_TagsEN.PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objzx_TagsEN.PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX
objzx_TagsEN.PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY
objzx_TagsEN.Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(); //备注
objzx_TagsEN.IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TagsEN.TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(); //课件Id
objzx_TagsEN.zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id
objzx_TagsEN.PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TagsEN.PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TagsEN.PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TagsEN.PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TagsEN.PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TagsEN.zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TagsEN);
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
public static List<clszx_TagsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_TagsEN> arrObjLst = new List<clszx_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TagsEN objzx_TagsEN = new clszx_TagsEN();
try
{
objzx_TagsEN.zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objzx_TagsEN.TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容
objzx_TagsEN.PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objzx_TagsEN.PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TagsEN.VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objzx_TagsEN.OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.OrderNum].ToString().Trim()); //序号
objzx_TagsEN.UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人
objzx_TagsEN.UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期
objzx_TagsEN.PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objzx_TagsEN.PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX
objzx_TagsEN.PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY
objzx_TagsEN.Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(); //备注
objzx_TagsEN.IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TagsEN.TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(); //课件Id
objzx_TagsEN.zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id
objzx_TagsEN.PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TagsEN.PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TagsEN.PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TagsEN.PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TagsEN.PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TagsEN.zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TagsEN);
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
List<clszx_TagsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_TagsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TagsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_TagsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_TagsEN> arrObjLst = new List<clszx_TagsEN>(); 
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
	clszx_TagsEN objzx_TagsEN = new clszx_TagsEN();
try
{
objzx_TagsEN.zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objzx_TagsEN.TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容
objzx_TagsEN.PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objzx_TagsEN.PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TagsEN.VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objzx_TagsEN.OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.OrderNum].ToString().Trim()); //序号
objzx_TagsEN.UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人
objzx_TagsEN.UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期
objzx_TagsEN.PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objzx_TagsEN.PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX
objzx_TagsEN.PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY
objzx_TagsEN.Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(); //备注
objzx_TagsEN.IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TagsEN.TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(); //课件Id
objzx_TagsEN.zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id
objzx_TagsEN.PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TagsEN.PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TagsEN.PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TagsEN.PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TagsEN.PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TagsEN.zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TagsEN);
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
public static List<clszx_TagsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_TagsEN> arrObjLst = new List<clszx_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TagsEN objzx_TagsEN = new clszx_TagsEN();
try
{
objzx_TagsEN.zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objzx_TagsEN.TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容
objzx_TagsEN.PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objzx_TagsEN.PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TagsEN.VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objzx_TagsEN.OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.OrderNum].ToString().Trim()); //序号
objzx_TagsEN.UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人
objzx_TagsEN.UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期
objzx_TagsEN.PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objzx_TagsEN.PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX
objzx_TagsEN.PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY
objzx_TagsEN.Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(); //备注
objzx_TagsEN.IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TagsEN.TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(); //课件Id
objzx_TagsEN.zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id
objzx_TagsEN.PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TagsEN.PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TagsEN.PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TagsEN.PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TagsEN.PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TagsEN.zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_TagsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_TagsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_TagsEN> arrObjLst = new List<clszx_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TagsEN objzx_TagsEN = new clszx_TagsEN();
try
{
objzx_TagsEN.zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objzx_TagsEN.TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容
objzx_TagsEN.PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objzx_TagsEN.PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TagsEN.VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objzx_TagsEN.OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.OrderNum].ToString().Trim()); //序号
objzx_TagsEN.UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人
objzx_TagsEN.UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期
objzx_TagsEN.PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objzx_TagsEN.PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX
objzx_TagsEN.PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY
objzx_TagsEN.Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(); //备注
objzx_TagsEN.IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TagsEN.TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(); //课件Id
objzx_TagsEN.zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id
objzx_TagsEN.PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TagsEN.PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TagsEN.PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TagsEN.PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TagsEN.PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TagsEN.zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TagsEN);
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
public static List<clszx_TagsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_TagsEN> arrObjLst = new List<clszx_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TagsEN objzx_TagsEN = new clszx_TagsEN();
try
{
objzx_TagsEN.zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objzx_TagsEN.TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容
objzx_TagsEN.PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objzx_TagsEN.PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TagsEN.VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objzx_TagsEN.OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.OrderNum].ToString().Trim()); //序号
objzx_TagsEN.UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人
objzx_TagsEN.UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期
objzx_TagsEN.PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objzx_TagsEN.PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX
objzx_TagsEN.PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY
objzx_TagsEN.Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(); //备注
objzx_TagsEN.IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TagsEN.TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(); //课件Id
objzx_TagsEN.zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id
objzx_TagsEN.PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TagsEN.PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TagsEN.PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TagsEN.PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TagsEN.PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TagsEN.zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TagsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_TagsEN> arrObjLst = new List<clszx_TagsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TagsEN objzx_TagsEN = new clszx_TagsEN();
try
{
objzx_TagsEN.zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objzx_TagsEN.TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容
objzx_TagsEN.PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objzx_TagsEN.PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TagsEN.VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objzx_TagsEN.OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.OrderNum].ToString().Trim()); //序号
objzx_TagsEN.UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人
objzx_TagsEN.UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期
objzx_TagsEN.PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objzx_TagsEN.PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX
objzx_TagsEN.PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY
objzx_TagsEN.Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(); //备注
objzx_TagsEN.IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TagsEN.TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(); //课件Id
objzx_TagsEN.zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id
objzx_TagsEN.PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TagsEN.PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TagsEN.PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TagsEN.PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TagsEN.PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TagsEN.zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TagsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_TagsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_Tags(ref clszx_TagsEN objzx_TagsEN)
{
bool bolResult = zx_TagsDA.Getzx_Tags(ref objzx_TagsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxTagsId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TagsEN GetObjByzxTagsId(string strzxTagsId)
{
if (strzxTagsId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxTagsId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxTagsId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxTagsId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_TagsEN objzx_TagsEN = zx_TagsDA.GetObjByzxTagsId(strzxTagsId);
return objzx_TagsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_TagsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_TagsEN objzx_TagsEN = zx_TagsDA.GetFirstObj(strWhereCond);
 return objzx_TagsEN;
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
public static clszx_TagsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_TagsEN objzx_TagsEN = zx_TagsDA.GetObjByDataRow(objRow);
 return objzx_TagsEN;
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
public static clszx_TagsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_TagsEN objzx_TagsEN = zx_TagsDA.GetObjByDataRow(objRow);
 return objzx_TagsEN;
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
 /// <param name = "strzxTagsId">所给的关键字</param>
 /// <param name = "lstzx_TagsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TagsEN GetObjByzxTagsIdFromList(string strzxTagsId, List<clszx_TagsEN> lstzx_TagsObjLst)
{
foreach (clszx_TagsEN objzx_TagsEN in lstzx_TagsObjLst)
{
if (objzx_TagsEN.zxTagsId == strzxTagsId)
{
return objzx_TagsEN;
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
 string strMaxZxTagsId;
 try
 {
 strMaxZxTagsId = clszx_TagsDA.GetMaxStrId();
 return strMaxZxTagsId;
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
 string strzxTagsId;
 try
 {
 strzxTagsId = new clszx_TagsDA().GetFirstID(strWhereCond);
 return strzxTagsId;
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
 arrList = zx_TagsDA.GetID(strWhereCond);
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
bool bolIsExist = zx_TagsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxTagsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxTagsId)
{
if (string.IsNullOrEmpty(strzxTagsId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxTagsId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_TagsDA.IsExist(strzxTagsId);
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
 bolIsExist = clszx_TagsDA.IsExistTable();
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
 bolIsExist = zx_TagsDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_TagsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_TagsEN objzx_TagsEN)
{
if (objzx_TagsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!标注Id = [{0}]的数据已经存在!(in clszx_TagsBL.AddNewRecordBySql2)", objzx_TagsEN.zxTagsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TagsEN.zxTagsId) == true || clszx_TagsBL.IsExist(objzx_TagsEN.zxTagsId) == true)
 {
     objzx_TagsEN.zxTagsId = clszx_TagsBL.GetMaxStrId_S();
 }
bool bolResult = zx_TagsDA.AddNewRecordBySQL2(objzx_TagsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TagsBL.ReFreshCache();

if (clszx_TagsBL.relatedActions != null)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(objzx_TagsEN.zxTagsId, "SetUpdDate");
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
 /// <param name = "objzx_TagsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_TagsEN objzx_TagsEN)
{
if (objzx_TagsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!标注Id = [{0}]的数据已经存在!(in clszx_TagsBL.AddNewRecordBySql2WithReturnKey)", objzx_TagsEN.zxTagsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TagsEN.zxTagsId) == true || clszx_TagsBL.IsExist(objzx_TagsEN.zxTagsId) == true)
 {
     objzx_TagsEN.zxTagsId = clszx_TagsBL.GetMaxStrId_S();
 }
string strKey = zx_TagsDA.AddNewRecordBySQL2WithReturnKey(objzx_TagsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TagsBL.ReFreshCache();

if (clszx_TagsBL.relatedActions != null)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(objzx_TagsEN.zxTagsId, "SetUpdDate");
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
 /// <param name = "objzx_TagsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_TagsEN objzx_TagsEN)
{
try
{
bool bolResult = zx_TagsDA.Update(objzx_TagsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TagsBL.ReFreshCache();

if (clszx_TagsBL.relatedActions != null)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(objzx_TagsEN.zxTagsId, "SetUpdDate");
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
 /// <param name = "objzx_TagsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_TagsEN objzx_TagsEN)
{
 if (string.IsNullOrEmpty(objzx_TagsEN.zxTagsId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_TagsDA.UpdateBySql2(objzx_TagsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TagsBL.ReFreshCache();

if (clszx_TagsBL.relatedActions != null)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(objzx_TagsEN.zxTagsId, "SetUpdDate");
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
 /// <param name = "strzxTagsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxTagsId)
{
try
{
 clszx_TagsEN objzx_TagsEN = clszx_TagsBL.GetObjByzxTagsId(strzxTagsId);

if (clszx_TagsBL.relatedActions != null)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(objzx_TagsEN.zxTagsId, "SetUpdDate");
}
if (objzx_TagsEN != null)
{
int intRecNum = zx_TagsDA.DelRecord(strzxTagsId);
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
/// <param name="strzxTagsId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxTagsId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TagsDA.GetSpecSQLObj();
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
//删除与表:[zx_Tags]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_Tags.zxTagsId,
//strzxTagsId);
//        clszx_TagsBL.Delzx_TagssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TagsBL.DelRecord(strzxTagsId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TagsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxTagsId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxTagsId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxTagsId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_TagsBL.relatedActions != null)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(strzxTagsId, "UpdRelaTabDate");
}
bool bolResult = zx_TagsDA.DelRecord(strzxTagsId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxTagsIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_Tagss(List<string> arrzxTagsIdLst)
{
if (arrzxTagsIdLst.Count == 0) return 0;
try
{
if (clszx_TagsBL.relatedActions != null)
{
foreach (var strzxTagsId in arrzxTagsIdLst)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(strzxTagsId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_TagsDA.Delzx_Tags(arrzxTagsIdLst);
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
public static int Delzx_TagssByCond(string strWhereCond)
{
try
{
if (clszx_TagsBL.relatedActions != null)
{
List<string> arrzxTagsId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxTagsId in arrzxTagsId)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(strzxTagsId, "UpdRelaTabDate");
}
}
int intRecNum = zx_TagsDA.Delzx_Tags(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_Tags]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxTagsId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxTagsId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TagsDA.GetSpecSQLObj();
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
//删除与表:[zx_Tags]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TagsBL.DelRecord(strzxTagsId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TagsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxTagsId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_TagsENS">源对象</param>
 /// <param name = "objzx_TagsENT">目标对象</param>
 public static void CopyTo(clszx_TagsEN objzx_TagsENS, clszx_TagsEN objzx_TagsENT)
{
try
{
objzx_TagsENT.zxTagsId = objzx_TagsENS.zxTagsId; //标注Id
objzx_TagsENT.TagsContent = objzx_TagsENS.TagsContent; //标注内容
objzx_TagsENT.PdfContent = objzx_TagsENS.PdfContent; //Pdf内容
objzx_TagsENT.PdfPageNum = objzx_TagsENS.PdfPageNum; //Pdf页码
objzx_TagsENT.VoteCount = objzx_TagsENS.VoteCount; //点赞计数
objzx_TagsENT.OrderNum = objzx_TagsENS.OrderNum; //序号
objzx_TagsENT.UpdUser = objzx_TagsENS.UpdUser; //修改人
objzx_TagsENT.UpdDate = objzx_TagsENS.UpdDate; //修改日期
objzx_TagsENT.PdfLineNum = objzx_TagsENS.PdfLineNum; //pdf行号
objzx_TagsENT.PdfX = objzx_TagsENS.PdfX; //PdfX
objzx_TagsENT.PdfY = objzx_TagsENS.PdfY; //PdfY
objzx_TagsENT.Memo = objzx_TagsENS.Memo; //备注
objzx_TagsENT.IdCurrEduCls = objzx_TagsENS.IdCurrEduCls; //教学班流水号
objzx_TagsENT.TextId = objzx_TagsENS.TextId; //课件Id
objzx_TagsENT.zxShareId = objzx_TagsENS.zxShareId; //分享Id
objzx_TagsENT.PdfPageNumIn = objzx_TagsENS.PdfPageNumIn; //PdfPageNumIn
objzx_TagsENT.PdfPageTop = objzx_TagsENS.PdfPageTop; //pdf页面顶部位置
objzx_TagsENT.PdfDivLet = objzx_TagsENS.PdfDivLet; //PdfDivLet
objzx_TagsENT.PdfDivTop = objzx_TagsENS.PdfDivTop; //PdfDivTop
objzx_TagsENT.PdfZoom = objzx_TagsENS.PdfZoom; //PdfZoom
objzx_TagsENT.zxTagsTypeId = objzx_TagsENS.zxTagsTypeId; //标注类型ID
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
 /// <param name = "objzx_TagsEN">源简化对象</param>
 public static void SetUpdFlag(clszx_TagsEN objzx_TagsEN)
{
try
{
objzx_TagsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_TagsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_Tags.zxTagsId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.zxTagsId = objzx_TagsEN.zxTagsId; //标注Id
}
if (arrFldSet.Contains(conzx_Tags.TagsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.TagsContent = objzx_TagsEN.TagsContent == "[null]" ? null :  objzx_TagsEN.TagsContent; //标注内容
}
if (arrFldSet.Contains(conzx_Tags.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.PdfContent = objzx_TagsEN.PdfContent == "[null]" ? null :  objzx_TagsEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conzx_Tags.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.PdfPageNum = objzx_TagsEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conzx_Tags.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.VoteCount = objzx_TagsEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conzx_Tags.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.OrderNum = objzx_TagsEN.OrderNum; //序号
}
if (arrFldSet.Contains(conzx_Tags.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.UpdUser = objzx_TagsEN.UpdUser == "[null]" ? null :  objzx_TagsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_Tags.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.UpdDate = objzx_TagsEN.UpdDate == "[null]" ? null :  objzx_TagsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_Tags.PdfLineNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.PdfLineNum = objzx_TagsEN.PdfLineNum; //pdf行号
}
if (arrFldSet.Contains(conzx_Tags.PdfX, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.PdfX = objzx_TagsEN.PdfX == "[null]" ? null :  objzx_TagsEN.PdfX; //PdfX
}
if (arrFldSet.Contains(conzx_Tags.PdfY, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.PdfY = objzx_TagsEN.PdfY == "[null]" ? null :  objzx_TagsEN.PdfY; //PdfY
}
if (arrFldSet.Contains(conzx_Tags.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.Memo = objzx_TagsEN.Memo == "[null]" ? null :  objzx_TagsEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_Tags.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.IdCurrEduCls = objzx_TagsEN.IdCurrEduCls == "[null]" ? null :  objzx_TagsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_Tags.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.TextId = objzx_TagsEN.TextId == "[null]" ? null :  objzx_TagsEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_Tags.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.zxShareId = objzx_TagsEN.zxShareId == "[null]" ? null :  objzx_TagsEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(conzx_Tags.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.PdfPageNumIn = objzx_TagsEN.PdfPageNumIn == "[null]" ? null :  objzx_TagsEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(conzx_Tags.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.PdfPageTop = objzx_TagsEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(conzx_Tags.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.PdfDivLet = objzx_TagsEN.PdfDivLet == "[null]" ? null :  objzx_TagsEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(conzx_Tags.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.PdfDivTop = objzx_TagsEN.PdfDivTop == "[null]" ? null :  objzx_TagsEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(conzx_Tags.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.PdfZoom = objzx_TagsEN.PdfZoom == "[null]" ? null :  objzx_TagsEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(conzx_Tags.zxTagsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TagsEN.zxTagsTypeId = objzx_TagsEN.zxTagsTypeId == "[null]" ? null :  objzx_TagsEN.zxTagsTypeId; //标注类型ID
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
 /// <param name = "objzx_TagsEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_TagsEN objzx_TagsEN)
{
try
{
if (objzx_TagsEN.TagsContent == "[null]") objzx_TagsEN.TagsContent = null; //标注内容
if (objzx_TagsEN.PdfContent == "[null]") objzx_TagsEN.PdfContent = null; //Pdf内容
if (objzx_TagsEN.UpdUser == "[null]") objzx_TagsEN.UpdUser = null; //修改人
if (objzx_TagsEN.UpdDate == "[null]") objzx_TagsEN.UpdDate = null; //修改日期
if (objzx_TagsEN.PdfX == "[null]") objzx_TagsEN.PdfX = null; //PdfX
if (objzx_TagsEN.PdfY == "[null]") objzx_TagsEN.PdfY = null; //PdfY
if (objzx_TagsEN.Memo == "[null]") objzx_TagsEN.Memo = null; //备注
if (objzx_TagsEN.IdCurrEduCls == "[null]") objzx_TagsEN.IdCurrEduCls = null; //教学班流水号
if (objzx_TagsEN.TextId == "[null]") objzx_TagsEN.TextId = null; //课件Id
if (objzx_TagsEN.zxShareId == "[null]") objzx_TagsEN.zxShareId = null; //分享Id
if (objzx_TagsEN.PdfPageNumIn == "[null]") objzx_TagsEN.PdfPageNumIn = null; //PdfPageNumIn
if (objzx_TagsEN.PdfDivLet == "[null]") objzx_TagsEN.PdfDivLet = null; //PdfDivLet
if (objzx_TagsEN.PdfDivTop == "[null]") objzx_TagsEN.PdfDivTop = null; //PdfDivTop
if (objzx_TagsEN.PdfZoom == "[null]") objzx_TagsEN.PdfZoom = null; //PdfZoom
if (objzx_TagsEN.zxTagsTypeId == "[null]") objzx_TagsEN.zxTagsTypeId = null; //标注类型ID
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
public static void CheckPropertyNew(clszx_TagsEN objzx_TagsEN)
{
 zx_TagsDA.CheckPropertyNew(objzx_TagsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_TagsEN objzx_TagsEN)
{
 zx_TagsDA.CheckProperty4Condition(objzx_TagsEN);
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
if (clszx_TagsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TagsBL没有刷新缓存机制(clszx_TagsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxTagsId");
//if (arrzx_TagsObjLstCache == null)
//{
//arrzx_TagsObjLstCache = zx_TagsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxTagsId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TagsEN GetObjByzxTagsIdCache(string strzxTagsId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_TagsEN._CurrTabName);
List<clszx_TagsEN> arrzx_TagsObjLstCache = GetObjLstCache();
IEnumerable <clszx_TagsEN> arrzx_TagsObjLst_Sel =
arrzx_TagsObjLstCache
.Where(x=> x.zxTagsId == strzxTagsId 
);
if (arrzx_TagsObjLst_Sel.Count() == 0)
{
   clszx_TagsEN obj = clszx_TagsBL.GetObjByzxTagsId(strzxTagsId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_TagsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TagsEN> GetAllzx_TagsObjLstCache()
{
//获取缓存中的对象列表
List<clszx_TagsEN> arrzx_TagsObjLstCache = GetObjLstCache(); 
return arrzx_TagsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TagsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_TagsEN._CurrTabName);
List<clszx_TagsEN> arrzx_TagsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_TagsObjLstCache;
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
string strKey = string.Format("{0}", clszx_TagsEN._CurrTabName);
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
if (clszx_TagsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_TagsEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_TagsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_Tags(zx_Tags)
 /// 唯一性条件:zxTagsId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TagsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_TagsEN objzx_TagsEN)
{
//检测记录是否存在
string strResult = zx_TagsDA.GetUniCondStr(objzx_TagsEN);
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
public static string Func(string strInFldName, string strOutFldName, string strzxTagsId)
{
if (strInFldName != conzx_Tags.zxTagsId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_Tags.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_Tags.AttributeName));
throw new Exception(strMsg);
}
var objzx_Tags = clszx_TagsBL.GetObjByzxTagsIdCache(strzxTagsId);
if (objzx_Tags == null) return "";
return objzx_Tags[strOutFldName].ToString();
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
int intRecCount = clszx_TagsDA.GetRecCount(strTabName);
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
int intRecCount = clszx_TagsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_TagsDA.GetRecCount();
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
int intRecCount = clszx_TagsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_TagsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_TagsEN objzx_TagsCond)
{
List<clszx_TagsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_TagsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Tags.AttributeName)
{
if (objzx_TagsCond.IsUpdated(strFldName) == false) continue;
if (objzx_TagsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TagsCond[strFldName].ToString());
}
else
{
if (objzx_TagsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TagsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TagsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TagsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TagsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TagsCond[strFldName]));
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
 List<string> arrList = clszx_TagsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_TagsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_TagsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_TagsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TagsDA.SetFldValue(clszx_TagsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_TagsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TagsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TagsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TagsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_Tags] "); 
 strCreateTabCode.Append(" ( "); 
 // /**标注Id*/ 
 strCreateTabCode.Append(" zxTagsId char(10) primary key, "); 
 // /**标注内容*/ 
 strCreateTabCode.Append(" TagsContent text Null, "); 
 // /**Pdf内容*/ 
 strCreateTabCode.Append(" PdfContent varchar(2000) Null, "); 
 // /**Pdf页码*/ 
 strCreateTabCode.Append(" PdfPageNum int Null, "); 
 // /**点赞计数*/ 
 strCreateTabCode.Append(" VoteCount int Null, "); 
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
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" zxShareId char(2) Null, "); 
 // /**PdfPageNumIn*/ 
 strCreateTabCode.Append(" PdfPageNumIn varchar(50) Null, "); 
 // /**pdf页面顶部位置*/ 
 strCreateTabCode.Append(" PdfPageTop int Null, "); 
 // /**PdfDivLet*/ 
 strCreateTabCode.Append(" PdfDivLet varchar(50) Null, "); 
 // /**PdfDivTop*/ 
 strCreateTabCode.Append(" PdfDivTop varchar(50) Null, "); 
 // /**PdfZoom*/ 
 strCreateTabCode.Append(" PdfZoom varchar(50) Null, "); 
 // /**标注类型ID*/ 
 strCreateTabCode.Append(" zxTagsTypeId char(2) Null ");
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
string strCondition = string.Format("1 = 1 order by {0} ", conzx_Tags.OrderNum); 
List<clszx_TagsEN> arrzx_TagsObjList = new clszx_TagsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clszx_TagsEN objzx_Tags in arrzx_TagsObjList)
{
objzx_Tags.OrderNum = intIndex;
UpdateBySql2(objzx_Tags);
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
/// <param name="strzxTagsId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strzxTagsId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[zxTagsId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字zxTagsId
//5、把当前关键字zxTagsId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字zxTagsId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevzxTagsId = "";    //上一条序号的关键字zxTagsId
string strNextzxTagsId = "";    //下一条序号的关键字zxTagsId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[zxTagsId],获取相应的序号[OrderNum]。

clszx_TagsEN objzx_Tags = clszx_TagsBL.GetObjByzxTagsId(strzxTagsId);

intOrderNum = objzx_Tags.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clszx_TagsBL.GetRecCountByCond(clszx_TagsEN._CurrTabName, "1 = 1");    //获取当前表的记录数
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
strCondition.AppendFormat(" {0} = {1}", conzx_Tags.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字zxTagsId
strPrevzxTagsId = clszx_TagsBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevzxTagsId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字zxTagsId所对应记录的序号减1
//6、把下(上)一个序号关键字zxTagsId所对应的记录序号加1
clszx_TagsBL.SetFldValue(clszx_TagsEN._CurrTabName, conzx_Tags.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conzx_Tags.zxTagsId, strzxTagsId));
clszx_TagsBL.SetFldValue(clszx_TagsEN._CurrTabName, conzx_Tags.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conzx_Tags.zxTagsId, strPrevzxTagsId));
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

//4、获取下一个序号字段的关键字zxTagsId
strCondition.AppendFormat(" {0} = {1}", conzx_Tags.OrderNum, intOrderNum + 1);

strNextzxTagsId = clszx_TagsBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextzxTagsId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字zxTagsId所对应记录的序号加1
//6、把下(上)一个序号关键字zxTagsId所对应的记录序号减1
clszx_TagsBL.SetFldValue(clszx_TagsEN._CurrTabName, conzx_Tags.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conzx_Tags.zxTagsId, strzxTagsId));
clszx_TagsBL.SetFldValue(clszx_TagsEN._CurrTabName, conzx_Tags.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conzx_Tags.zxTagsId, strNextzxTagsId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clszx_TagsBL.ReFreshCache();
if (clszx_TagsBL.relatedActions != null)
{
clszx_TagsBL.relatedActions.UpdRelaTabDate(objzx_Tags.zxTagsId, "UpdRelaTabDate");
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
string strCondition = string.Format("{0} in ({1})", conzx_Tags.zxTagsId, strKeyList);
List<clszx_TagsEN> arrzx_TagsLst = GetObjLst(strCondition);
foreach (clszx_TagsEN objzx_Tags in arrzx_TagsLst)
{
objzx_Tags.OrderNum = objzx_Tags.OrderNum + 10000;
UpdateBySql2(objzx_Tags);
}
strCondition = string.Format("1 = 1 order by {0} ", conzx_Tags.OrderNum); 
List<clszx_TagsEN> arrzx_TagsObjList = new clszx_TagsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clszx_TagsEN objzx_Tags in arrzx_TagsObjList)
{
objzx_Tags.OrderNum = intIndex;
UpdateBySql2(objzx_Tags);
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
string strCondition = string.Format("{0} in ({1})", conzx_Tags.zxTagsId, strKeyList);
List<clszx_TagsEN> arrzx_TagsLst = GetObjLst(strCondition);
foreach (clszx_TagsEN objzx_Tags in arrzx_TagsLst)
{
objzx_Tags.OrderNum = objzx_Tags.OrderNum - 10000;
UpdateBySql2(objzx_Tags);
}
strCondition = string.Format("1 = 1 order by {0} ", conzx_Tags.OrderNum); 
List<clszx_TagsEN> arrzx_TagsObjList = new clszx_TagsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clszx_TagsEN objzx_Tags in arrzx_TagsObjList)
{
objzx_Tags.OrderNum = intIndex;
UpdateBySql2(objzx_Tags);
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
 /// zx_Tags(zx_Tags)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_Tags : clsCommFun4BL
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
clszx_TagsBL.ReFreshThisCache();
}
}

}