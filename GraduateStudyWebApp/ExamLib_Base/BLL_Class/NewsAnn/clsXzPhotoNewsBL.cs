﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzPhotoNewsBL
 表名:XzPhotoNews(01120421)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:52:14
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告(NewsAnn)
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
public static class  clsXzPhotoNewsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPhotoNewsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzPhotoNewsEN GetObj(this K_PhotoNewsId_XzPhotoNews myKey)
{
clsXzPhotoNewsEN objXzPhotoNewsEN = clsXzPhotoNewsBL.XzPhotoNewsDA.GetObjByPhotoNewsId(myKey.Value);
return objXzPhotoNewsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzPhotoNewsEN objXzPhotoNewsEN)
{
if (CheckUniqueness(objXzPhotoNewsEN) == false)
{
var strMsg = string.Format("记录已经存在!标题 = [{0}],用户 = [{1}]的数据已经存在!(in clsXzPhotoNewsBL.AddNewRecord)", objXzPhotoNewsEN.PhotoNewsTitle,objXzPhotoNewsEN.PhotoNewsUser);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsXzPhotoNewsBL.XzPhotoNewsDA.AddNewRecordBySQL2(objXzPhotoNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsBL.ReFreshCache();

if (clsXzPhotoNewsBL.relatedActions != null)
{
clsXzPhotoNewsBL.relatedActions.UpdRelaTabDate(objXzPhotoNewsEN.PhotoNewsId, "SetUpdDate");
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
public static bool AddRecordEx(this clsXzPhotoNewsEN objXzPhotoNewsEN)
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
objXzPhotoNewsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objXzPhotoNewsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(标题(PhotoNewsTitle)=[{0}],用户(PhotoNewsUser)=[{1}])已经存在,不能重复!", objXzPhotoNewsEN.PhotoNewsTitle, objXzPhotoNewsEN.PhotoNewsUser);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objXzPhotoNewsEN.AddNewRecord();
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
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsXzPhotoNewsEN objXzPhotoNewsEN)
{
if (CheckUniqueness(objXzPhotoNewsEN) == false)
{
var strMsg = string.Format("记录已经存在!标题 = [{0}],用户 = [{1}]的数据已经存在!(in clsXzPhotoNewsBL.AddNewRecordWithReturnKey)", objXzPhotoNewsEN.PhotoNewsTitle,objXzPhotoNewsEN.PhotoNewsUser);
throw new Exception(strMsg);
}
try
{
string strKey = clsXzPhotoNewsBL.XzPhotoNewsDA.AddNewRecordBySQL2WithReturnKey(objXzPhotoNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsBL.ReFreshCache();

if (clsXzPhotoNewsBL.relatedActions != null)
{
clsXzPhotoNewsBL.relatedActions.UpdRelaTabDate(objXzPhotoNewsEN.PhotoNewsId, "SetUpdDate");
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
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzPhotoNewsEN SetPhotoNewsId(this clsXzPhotoNewsEN objXzPhotoNewsEN, long lngPhotoNewsId, string strComparisonOp="")
	{
objXzPhotoNewsEN.PhotoNewsId = lngPhotoNewsId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.PhotoNewsId) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.PhotoNewsId, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.PhotoNewsId] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzPhotoNewsEN SetPhotoNewsTitle(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strPhotoNewsTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPhotoNewsTitle, conXzPhotoNews.PhotoNewsTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhotoNewsTitle, 100, conXzPhotoNews.PhotoNewsTitle);
}
objXzPhotoNewsEN.PhotoNewsTitle = strPhotoNewsTitle; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.PhotoNewsTitle) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.PhotoNewsTitle, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.PhotoNewsTitle] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzPhotoNewsEN SetImageUrl(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strImageUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImageUrl, 100, conXzPhotoNews.ImageUrl);
}
objXzPhotoNewsEN.ImageUrl = strImageUrl; //ImageUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.ImageUrl) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.ImageUrl, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.ImageUrl] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzPhotoNewsEN SetPhotoNewsContent(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strPhotoNewsContent, string strComparisonOp="")
	{
objXzPhotoNewsEN.PhotoNewsContent = strPhotoNewsContent; //内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.PhotoNewsContent) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.PhotoNewsContent, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.PhotoNewsContent] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzPhotoNewsEN SetPhotoNewsDate(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strPhotoNewsDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhotoNewsDate, 16, conXzPhotoNews.PhotoNewsDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPhotoNewsDate, 16, conXzPhotoNews.PhotoNewsDate);
}
objXzPhotoNewsEN.PhotoNewsDate = strPhotoNewsDate; //日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.PhotoNewsDate) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.PhotoNewsDate, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.PhotoNewsDate] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzPhotoNewsEN SetPhotoNewsUser(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strPhotoNewsUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhotoNewsUser, 50, conXzPhotoNews.PhotoNewsUser);
}
objXzPhotoNewsEN.PhotoNewsUser = strPhotoNewsUser; //用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.PhotoNewsUser) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.PhotoNewsUser, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.PhotoNewsUser] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzPhotoNewsEN SetDepartmentID(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strDepartmentID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentID, conXzPhotoNews.DepartmentID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentID, 8, conXzPhotoNews.DepartmentID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDepartmentID, 8, conXzPhotoNews.DepartmentID);
}
objXzPhotoNewsEN.DepartmentID = strDepartmentID; //部门ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.DepartmentID) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.DepartmentID, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.DepartmentID] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzPhotoNewsEN SetIdXzMajor(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, conXzPhotoNews.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, conXzPhotoNews.IdXzMajor);
}
objXzPhotoNewsEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.IdXzMajor) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.IdXzMajor, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.IdXzMajor] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzPhotoNewsEN SetViews(this clsXzPhotoNewsEN objXzPhotoNewsEN, int? intViews, string strComparisonOp="")
	{
objXzPhotoNewsEN.Views = intViews; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.Views) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.Views, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.Views] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzPhotoNewsEN SetIsTop(this clsXzPhotoNewsEN objXzPhotoNewsEN, bool bolIsTop, string strComparisonOp="")
	{
objXzPhotoNewsEN.IsTop = bolIsTop; //是否置顶
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.IsTop) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.IsTop, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.IsTop] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzPhotoNewsEN SetIsUrgent(this clsXzPhotoNewsEN objXzPhotoNewsEN, bool bolIsUrgent, string strComparisonOp="")
	{
objXzPhotoNewsEN.IsUrgent = bolIsUrgent; //是否紧急
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.IsUrgent) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.IsUrgent, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.IsUrgent] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzPhotoNewsEN SetAudit(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strAudit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAudit, 1, conXzPhotoNews.Audit);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAudit, 1, conXzPhotoNews.Audit);
}
objXzPhotoNewsEN.Audit = strAudit; //审核
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.Audit) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.Audit, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.Audit] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzPhotoNewsEN SetMemo(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzPhotoNews.Memo);
}
objXzPhotoNewsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.Memo) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.Memo, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.Memo] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsXzPhotoNewsEN objXzPhotoNewsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objXzPhotoNewsEN.CheckPropertyNew();
clsXzPhotoNewsEN objXzPhotoNewsCond = new clsXzPhotoNewsEN();
string strCondition = objXzPhotoNewsCond
.SetPhotoNewsId(objXzPhotoNewsEN.PhotoNewsId, "<>")
.SetPhotoNewsTitle(objXzPhotoNewsEN.PhotoNewsTitle, "=")
.SetPhotoNewsUser(objXzPhotoNewsEN.PhotoNewsUser, "=")
.GetCombineCondition();
objXzPhotoNewsEN._IsCheckProperty = true;
bool bolIsExist = clsXzPhotoNewsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PhotoNewsTitle_PhotoNewsUser)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objXzPhotoNewsEN.Update();
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
 /// <param name = "objXzPhotoNews">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsXzPhotoNewsEN objXzPhotoNews)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsXzPhotoNewsEN objXzPhotoNewsCond = new clsXzPhotoNewsEN();
string strCondition = objXzPhotoNewsCond
.SetPhotoNewsTitle(objXzPhotoNews.PhotoNewsTitle, "=")
.SetPhotoNewsUser(objXzPhotoNews.PhotoNewsUser, "=")
.GetCombineCondition();
objXzPhotoNews._IsCheckProperty = true;
bool bolIsExist = clsXzPhotoNewsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objXzPhotoNews.PhotoNewsId = clsXzPhotoNewsBL.GetFirstID_S(strCondition);
objXzPhotoNews.UpdateWithCondition(strCondition);
}
else
{
objXzPhotoNews.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzPhotoNewsEN objXzPhotoNewsEN)
{
 if (objXzPhotoNewsEN.PhotoNewsId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzPhotoNewsBL.XzPhotoNewsDA.UpdateBySql2(objXzPhotoNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsBL.ReFreshCache();

if (clsXzPhotoNewsBL.relatedActions != null)
{
clsXzPhotoNewsBL.relatedActions.UpdRelaTabDate(objXzPhotoNewsEN.PhotoNewsId, "SetUpdDate");
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
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzPhotoNewsEN objXzPhotoNewsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objXzPhotoNewsEN.PhotoNewsId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzPhotoNewsBL.XzPhotoNewsDA.UpdateBySql2(objXzPhotoNewsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsBL.ReFreshCache();

if (clsXzPhotoNewsBL.relatedActions != null)
{
clsXzPhotoNewsBL.relatedActions.UpdRelaTabDate(objXzPhotoNewsEN.PhotoNewsId, "SetUpdDate");
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
 /// <param name = "objXzPhotoNewsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strWhereCond)
{
try
{
bool bolResult = clsXzPhotoNewsBL.XzPhotoNewsDA.UpdateBySqlWithCondition(objXzPhotoNewsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsBL.ReFreshCache();

if (clsXzPhotoNewsBL.relatedActions != null)
{
clsXzPhotoNewsBL.relatedActions.UpdRelaTabDate(objXzPhotoNewsEN.PhotoNewsId, "SetUpdDate");
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
 /// <param name = "objXzPhotoNewsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsXzPhotoNewsBL.XzPhotoNewsDA.UpdateBySqlWithConditionTransaction(objXzPhotoNewsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsBL.ReFreshCache();

if (clsXzPhotoNewsBL.relatedActions != null)
{
clsXzPhotoNewsBL.relatedActions.UpdRelaTabDate(objXzPhotoNewsEN.PhotoNewsId, "SetUpdDate");
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
 /// <param name = "lngPhotoNewsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsXzPhotoNewsEN objXzPhotoNewsEN)
{
try
{
int intRecNum = clsXzPhotoNewsBL.XzPhotoNewsDA.DelRecord(objXzPhotoNewsEN.PhotoNewsId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsBL.ReFreshCache();

if (clsXzPhotoNewsBL.relatedActions != null)
{
clsXzPhotoNewsBL.relatedActions.UpdRelaTabDate(objXzPhotoNewsEN.PhotoNewsId, "SetUpdDate");
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
 /// <param name = "objXzPhotoNewsENS">源对象</param>
 /// <param name = "objXzPhotoNewsENT">目标对象</param>
 public static void CopyTo(this clsXzPhotoNewsEN objXzPhotoNewsENS, clsXzPhotoNewsEN objXzPhotoNewsENT)
{
try
{
objXzPhotoNewsENT.PhotoNewsId = objXzPhotoNewsENS.PhotoNewsId; //流水号
objXzPhotoNewsENT.PhotoNewsTitle = objXzPhotoNewsENS.PhotoNewsTitle; //标题
objXzPhotoNewsENT.ImageUrl = objXzPhotoNewsENS.ImageUrl; //ImageUrl
objXzPhotoNewsENT.PhotoNewsContent = objXzPhotoNewsENS.PhotoNewsContent; //内容
objXzPhotoNewsENT.PhotoNewsDate = objXzPhotoNewsENS.PhotoNewsDate; //日期
objXzPhotoNewsENT.PhotoNewsUser = objXzPhotoNewsENS.PhotoNewsUser; //用户
objXzPhotoNewsENT.DepartmentID = objXzPhotoNewsENS.DepartmentID; //部门ID
objXzPhotoNewsENT.IdXzMajor = objXzPhotoNewsENS.IdXzMajor; //专业流水号
objXzPhotoNewsENT.Views = objXzPhotoNewsENS.Views; //浏览量
objXzPhotoNewsENT.IsTop = objXzPhotoNewsENS.IsTop; //是否置顶
objXzPhotoNewsENT.IsUrgent = objXzPhotoNewsENS.IsUrgent; //是否紧急
objXzPhotoNewsENT.Audit = objXzPhotoNewsENS.Audit; //审核
objXzPhotoNewsENT.Memo = objXzPhotoNewsENS.Memo; //备注
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
 /// <param name = "objXzPhotoNewsENS">源对象</param>
 /// <returns>目标对象=>clsXzPhotoNewsEN:objXzPhotoNewsENT</returns>
 public static clsXzPhotoNewsEN CopyTo(this clsXzPhotoNewsEN objXzPhotoNewsENS)
{
try
{
 clsXzPhotoNewsEN objXzPhotoNewsENT = new clsXzPhotoNewsEN()
{
PhotoNewsId = objXzPhotoNewsENS.PhotoNewsId, //流水号
PhotoNewsTitle = objXzPhotoNewsENS.PhotoNewsTitle, //标题
ImageUrl = objXzPhotoNewsENS.ImageUrl, //ImageUrl
PhotoNewsContent = objXzPhotoNewsENS.PhotoNewsContent, //内容
PhotoNewsDate = objXzPhotoNewsENS.PhotoNewsDate, //日期
PhotoNewsUser = objXzPhotoNewsENS.PhotoNewsUser, //用户
DepartmentID = objXzPhotoNewsENS.DepartmentID, //部门ID
IdXzMajor = objXzPhotoNewsENS.IdXzMajor, //专业流水号
Views = objXzPhotoNewsENS.Views, //浏览量
IsTop = objXzPhotoNewsENS.IsTop, //是否置顶
IsUrgent = objXzPhotoNewsENS.IsUrgent, //是否紧急
Audit = objXzPhotoNewsENS.Audit, //审核
Memo = objXzPhotoNewsENS.Memo, //备注
};
 return objXzPhotoNewsENT;
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
public static void CheckPropertyNew(this clsXzPhotoNewsEN objXzPhotoNewsEN)
{
 clsXzPhotoNewsBL.XzPhotoNewsDA.CheckPropertyNew(objXzPhotoNewsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsXzPhotoNewsEN objXzPhotoNewsEN)
{
 clsXzPhotoNewsBL.XzPhotoNewsDA.CheckProperty4Condition(objXzPhotoNewsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzPhotoNewsEN objXzPhotoNewsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzPhotoNewsCond.IsUpdated(conXzPhotoNews.PhotoNewsId) == true)
{
string strComparisonOpPhotoNewsId = objXzPhotoNewsCond.dicFldComparisonOp[conXzPhotoNews.PhotoNewsId];
strWhereCond += string.Format(" And {0} {2} {1}", conXzPhotoNews.PhotoNewsId, objXzPhotoNewsCond.PhotoNewsId, strComparisonOpPhotoNewsId);
}
if (objXzPhotoNewsCond.IsUpdated(conXzPhotoNews.PhotoNewsTitle) == true)
{
string strComparisonOpPhotoNewsTitle = objXzPhotoNewsCond.dicFldComparisonOp[conXzPhotoNews.PhotoNewsTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.PhotoNewsTitle, objXzPhotoNewsCond.PhotoNewsTitle, strComparisonOpPhotoNewsTitle);
}
if (objXzPhotoNewsCond.IsUpdated(conXzPhotoNews.ImageUrl) == true)
{
string strComparisonOpImageUrl = objXzPhotoNewsCond.dicFldComparisonOp[conXzPhotoNews.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.ImageUrl, objXzPhotoNewsCond.ImageUrl, strComparisonOpImageUrl);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objXzPhotoNewsCond.IsUpdated(conXzPhotoNews.PhotoNewsDate) == true)
{
string strComparisonOpPhotoNewsDate = objXzPhotoNewsCond.dicFldComparisonOp[conXzPhotoNews.PhotoNewsDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.PhotoNewsDate, objXzPhotoNewsCond.PhotoNewsDate, strComparisonOpPhotoNewsDate);
}
if (objXzPhotoNewsCond.IsUpdated(conXzPhotoNews.PhotoNewsUser) == true)
{
string strComparisonOpPhotoNewsUser = objXzPhotoNewsCond.dicFldComparisonOp[conXzPhotoNews.PhotoNewsUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.PhotoNewsUser, objXzPhotoNewsCond.PhotoNewsUser, strComparisonOpPhotoNewsUser);
}
if (objXzPhotoNewsCond.IsUpdated(conXzPhotoNews.DepartmentID) == true)
{
string strComparisonOpDepartmentID = objXzPhotoNewsCond.dicFldComparisonOp[conXzPhotoNews.DepartmentID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.DepartmentID, objXzPhotoNewsCond.DepartmentID, strComparisonOpDepartmentID);
}
if (objXzPhotoNewsCond.IsUpdated(conXzPhotoNews.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objXzPhotoNewsCond.dicFldComparisonOp[conXzPhotoNews.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.IdXzMajor, objXzPhotoNewsCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objXzPhotoNewsCond.IsUpdated(conXzPhotoNews.Views) == true)
{
string strComparisonOpViews = objXzPhotoNewsCond.dicFldComparisonOp[conXzPhotoNews.Views];
strWhereCond += string.Format(" And {0} {2} {1}", conXzPhotoNews.Views, objXzPhotoNewsCond.Views, strComparisonOpViews);
}
if (objXzPhotoNewsCond.IsUpdated(conXzPhotoNews.IsTop) == true)
{
if (objXzPhotoNewsCond.IsTop == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzPhotoNews.IsTop);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzPhotoNews.IsTop);
}
}
if (objXzPhotoNewsCond.IsUpdated(conXzPhotoNews.IsUrgent) == true)
{
if (objXzPhotoNewsCond.IsUrgent == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzPhotoNews.IsUrgent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzPhotoNews.IsUrgent);
}
}
if (objXzPhotoNewsCond.IsUpdated(conXzPhotoNews.Audit) == true)
{
string strComparisonOpAudit = objXzPhotoNewsCond.dicFldComparisonOp[conXzPhotoNews.Audit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.Audit, objXzPhotoNewsCond.Audit, strComparisonOpAudit);
}
if (objXzPhotoNewsCond.IsUpdated(conXzPhotoNews.Memo) == true)
{
string strComparisonOpMemo = objXzPhotoNewsCond.dicFldComparisonOp[conXzPhotoNews.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.Memo, objXzPhotoNewsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--XzPhotoNews(图片新闻), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PhotoNewsTitle_PhotoNewsUser
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsXzPhotoNewsEN objXzPhotoNewsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objXzPhotoNewsEN == null) return true;
if (objXzPhotoNewsEN.PhotoNewsId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PhotoNewsTitle = '{0}'", objXzPhotoNewsEN.PhotoNewsTitle);
 if (objXzPhotoNewsEN.PhotoNewsUser == null)
{
 sbCondition.AppendFormat(" and PhotoNewsUser is null", objXzPhotoNewsEN.PhotoNewsUser);
}
else
{
 sbCondition.AppendFormat(" and PhotoNewsUser = '{0}'", objXzPhotoNewsEN.PhotoNewsUser);
}
if (clsXzPhotoNewsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PhotoNewsId !=  {0}", objXzPhotoNewsEN.PhotoNewsId);
 sbCondition.AppendFormat(" and PhotoNewsTitle = '{0}'", objXzPhotoNewsEN.PhotoNewsTitle);
 sbCondition.AppendFormat(" and PhotoNewsUser = '{0}'", objXzPhotoNewsEN.PhotoNewsUser);
if (clsXzPhotoNewsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--XzPhotoNews(图片新闻), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PhotoNewsTitle_PhotoNewsUser
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsXzPhotoNewsEN objXzPhotoNewsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objXzPhotoNewsEN == null) return "";
if (objXzPhotoNewsEN.PhotoNewsId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PhotoNewsTitle = '{0}'", objXzPhotoNewsEN.PhotoNewsTitle);
 if (objXzPhotoNewsEN.PhotoNewsUser == null)
{
 sbCondition.AppendFormat(" and PhotoNewsUser is null", objXzPhotoNewsEN.PhotoNewsUser);
}
else
{
 sbCondition.AppendFormat(" and PhotoNewsUser = '{0}'", objXzPhotoNewsEN.PhotoNewsUser);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PhotoNewsId !=  {0}", objXzPhotoNewsEN.PhotoNewsId);
 sbCondition.AppendFormat(" and PhotoNewsTitle = '{0}'", objXzPhotoNewsEN.PhotoNewsTitle);
 sbCondition.AppendFormat(" and PhotoNewsUser = '{0}'", objXzPhotoNewsEN.PhotoNewsUser);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_XzPhotoNews
{
public virtual bool UpdRelaTabDate(long lngPhotoNewsId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 图片新闻(XzPhotoNews)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsXzPhotoNewsBL
{
public static RelatedActions_XzPhotoNews relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsXzPhotoNewsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsXzPhotoNewsDA XzPhotoNewsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsXzPhotoNewsDA();
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
 public clsXzPhotoNewsBL()
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
if (string.IsNullOrEmpty(clsXzPhotoNewsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzPhotoNewsEN._ConnectString);
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
public static DataTable GetDataTable_XzPhotoNews(string strWhereCond)
{
DataTable objDT;
try
{
objDT = XzPhotoNewsDA.GetDataTable_XzPhotoNews(strWhereCond);
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
objDT = XzPhotoNewsDA.GetDataTable(strWhereCond);
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
objDT = XzPhotoNewsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = XzPhotoNewsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = XzPhotoNewsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = XzPhotoNewsDA.GetDataTable_Top(objTopPara);
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
objDT = XzPhotoNewsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = XzPhotoNewsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = XzPhotoNewsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPhotoNewsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsXzPhotoNewsEN> GetObjLstByPhotoNewsIdLst(List<long> arrPhotoNewsIdLst)
{
List<clsXzPhotoNewsEN> arrObjLst = new List<clsXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPhotoNewsIdLst);
 string strWhereCond = string.Format("PhotoNewsId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN();
try
{
objXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objXzPhotoNewsEN.PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objXzPhotoNewsEN.ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objXzPhotoNewsEN.PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objXzPhotoNewsEN.PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objXzPhotoNewsEN.PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objXzPhotoNewsEN.DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objXzPhotoNewsEN.IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objXzPhotoNewsEN.Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzPhotoNews.Views].ToString().Trim()); //浏览量
objXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objXzPhotoNewsEN.Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(); //审核
objXzPhotoNewsEN.Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzPhotoNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPhotoNewsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsXzPhotoNewsEN> GetObjLstByPhotoNewsIdLstCache(List<long> arrPhotoNewsIdLst)
{
string strKey = string.Format("{0}", clsXzPhotoNewsEN._CurrTabName);
List<clsXzPhotoNewsEN> arrXzPhotoNewsObjLstCache = GetObjLstCache();
IEnumerable <clsXzPhotoNewsEN> arrXzPhotoNewsObjLst_Sel =
arrXzPhotoNewsObjLstCache
.Where(x => arrPhotoNewsIdLst.Contains(x.PhotoNewsId));
return arrXzPhotoNewsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzPhotoNewsEN> GetObjLst(string strWhereCond)
{
List<clsXzPhotoNewsEN> arrObjLst = new List<clsXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN();
try
{
objXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objXzPhotoNewsEN.PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objXzPhotoNewsEN.ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objXzPhotoNewsEN.PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objXzPhotoNewsEN.PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objXzPhotoNewsEN.PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objXzPhotoNewsEN.DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objXzPhotoNewsEN.IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objXzPhotoNewsEN.Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzPhotoNews.Views].ToString().Trim()); //浏览量
objXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objXzPhotoNewsEN.Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(); //审核
objXzPhotoNewsEN.Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzPhotoNewsEN);
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
public static List<clsXzPhotoNewsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsXzPhotoNewsEN> arrObjLst = new List<clsXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN();
try
{
objXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objXzPhotoNewsEN.PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objXzPhotoNewsEN.ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objXzPhotoNewsEN.PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objXzPhotoNewsEN.PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objXzPhotoNewsEN.PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objXzPhotoNewsEN.DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objXzPhotoNewsEN.IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objXzPhotoNewsEN.Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzPhotoNews.Views].ToString().Trim()); //浏览量
objXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objXzPhotoNewsEN.Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(); //审核
objXzPhotoNewsEN.Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzPhotoNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objXzPhotoNewsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsXzPhotoNewsEN> GetSubObjLstCache(clsXzPhotoNewsEN objXzPhotoNewsCond)
{
List<clsXzPhotoNewsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzPhotoNewsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzPhotoNews.AttributeName)
{
if (objXzPhotoNewsCond.IsUpdated(strFldName) == false) continue;
if (objXzPhotoNewsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzPhotoNewsCond[strFldName].ToString());
}
else
{
if (objXzPhotoNewsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzPhotoNewsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzPhotoNewsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzPhotoNewsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzPhotoNewsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzPhotoNewsCond[strFldName]));
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
public static List<clsXzPhotoNewsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsXzPhotoNewsEN> arrObjLst = new List<clsXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN();
try
{
objXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objXzPhotoNewsEN.PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objXzPhotoNewsEN.ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objXzPhotoNewsEN.PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objXzPhotoNewsEN.PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objXzPhotoNewsEN.PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objXzPhotoNewsEN.DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objXzPhotoNewsEN.IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objXzPhotoNewsEN.Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzPhotoNews.Views].ToString().Trim()); //浏览量
objXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objXzPhotoNewsEN.Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(); //审核
objXzPhotoNewsEN.Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzPhotoNewsEN);
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
public static List<clsXzPhotoNewsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsXzPhotoNewsEN> arrObjLst = new List<clsXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN();
try
{
objXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objXzPhotoNewsEN.PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objXzPhotoNewsEN.ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objXzPhotoNewsEN.PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objXzPhotoNewsEN.PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objXzPhotoNewsEN.PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objXzPhotoNewsEN.DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objXzPhotoNewsEN.IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objXzPhotoNewsEN.Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzPhotoNews.Views].ToString().Trim()); //浏览量
objXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objXzPhotoNewsEN.Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(); //审核
objXzPhotoNewsEN.Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzPhotoNewsEN);
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
List<clsXzPhotoNewsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsXzPhotoNewsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzPhotoNewsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsXzPhotoNewsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsXzPhotoNewsEN> arrObjLst = new List<clsXzPhotoNewsEN>(); 
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
	clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN();
try
{
objXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objXzPhotoNewsEN.PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objXzPhotoNewsEN.ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objXzPhotoNewsEN.PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objXzPhotoNewsEN.PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objXzPhotoNewsEN.PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objXzPhotoNewsEN.DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objXzPhotoNewsEN.IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objXzPhotoNewsEN.Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzPhotoNews.Views].ToString().Trim()); //浏览量
objXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objXzPhotoNewsEN.Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(); //审核
objXzPhotoNewsEN.Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzPhotoNewsEN);
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
public static List<clsXzPhotoNewsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsXzPhotoNewsEN> arrObjLst = new List<clsXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN();
try
{
objXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objXzPhotoNewsEN.PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objXzPhotoNewsEN.ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objXzPhotoNewsEN.PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objXzPhotoNewsEN.PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objXzPhotoNewsEN.PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objXzPhotoNewsEN.DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objXzPhotoNewsEN.IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objXzPhotoNewsEN.Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzPhotoNews.Views].ToString().Trim()); //浏览量
objXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objXzPhotoNewsEN.Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(); //审核
objXzPhotoNewsEN.Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzPhotoNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsXzPhotoNewsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsXzPhotoNewsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsXzPhotoNewsEN> arrObjLst = new List<clsXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN();
try
{
objXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objXzPhotoNewsEN.PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objXzPhotoNewsEN.ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objXzPhotoNewsEN.PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objXzPhotoNewsEN.PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objXzPhotoNewsEN.PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objXzPhotoNewsEN.DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objXzPhotoNewsEN.IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objXzPhotoNewsEN.Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzPhotoNews.Views].ToString().Trim()); //浏览量
objXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objXzPhotoNewsEN.Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(); //审核
objXzPhotoNewsEN.Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzPhotoNewsEN);
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
public static List<clsXzPhotoNewsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsXzPhotoNewsEN> arrObjLst = new List<clsXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN();
try
{
objXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objXzPhotoNewsEN.PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objXzPhotoNewsEN.ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objXzPhotoNewsEN.PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objXzPhotoNewsEN.PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objXzPhotoNewsEN.PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objXzPhotoNewsEN.DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objXzPhotoNewsEN.IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objXzPhotoNewsEN.Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzPhotoNews.Views].ToString().Trim()); //浏览量
objXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objXzPhotoNewsEN.Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(); //审核
objXzPhotoNewsEN.Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzPhotoNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzPhotoNewsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsXzPhotoNewsEN> arrObjLst = new List<clsXzPhotoNewsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN();
try
{
objXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objXzPhotoNewsEN.PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objXzPhotoNewsEN.ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objXzPhotoNewsEN.PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objXzPhotoNewsEN.PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objXzPhotoNewsEN.PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objXzPhotoNewsEN.DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objXzPhotoNewsEN.IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objXzPhotoNewsEN.Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzPhotoNews.Views].ToString().Trim()); //浏览量
objXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objXzPhotoNewsEN.Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(); //审核
objXzPhotoNewsEN.Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzPhotoNewsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetXzPhotoNews(ref clsXzPhotoNewsEN objXzPhotoNewsEN)
{
bool bolResult = XzPhotoNewsDA.GetXzPhotoNews(ref objXzPhotoNewsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPhotoNewsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzPhotoNewsEN GetObjByPhotoNewsId(long lngPhotoNewsId)
{
clsXzPhotoNewsEN objXzPhotoNewsEN = XzPhotoNewsDA.GetObjByPhotoNewsId(lngPhotoNewsId);
return objXzPhotoNewsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsXzPhotoNewsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsXzPhotoNewsEN objXzPhotoNewsEN = XzPhotoNewsDA.GetFirstObj(strWhereCond);
 return objXzPhotoNewsEN;
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
public static clsXzPhotoNewsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsXzPhotoNewsEN objXzPhotoNewsEN = XzPhotoNewsDA.GetObjByDataRow(objRow);
 return objXzPhotoNewsEN;
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
public static clsXzPhotoNewsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsXzPhotoNewsEN objXzPhotoNewsEN = XzPhotoNewsDA.GetObjByDataRow(objRow);
 return objXzPhotoNewsEN;
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
 /// <param name = "lngPhotoNewsId">所给的关键字</param>
 /// <param name = "lstXzPhotoNewsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzPhotoNewsEN GetObjByPhotoNewsIdFromList(long lngPhotoNewsId, List<clsXzPhotoNewsEN> lstXzPhotoNewsObjLst)
{
foreach (clsXzPhotoNewsEN objXzPhotoNewsEN in lstXzPhotoNewsObjLst)
{
if (objXzPhotoNewsEN.PhotoNewsId == lngPhotoNewsId)
{
return objXzPhotoNewsEN;
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
 long lngPhotoNewsId;
 try
 {
 lngPhotoNewsId = new clsXzPhotoNewsDA().GetFirstID(strWhereCond);
 return lngPhotoNewsId;
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
 arrList = XzPhotoNewsDA.GetID(strWhereCond);
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
bool bolIsExist = XzPhotoNewsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPhotoNewsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPhotoNewsId)
{
//检测记录是否存在
bool bolIsExist = XzPhotoNewsDA.IsExist(lngPhotoNewsId);
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
 bolIsExist = clsXzPhotoNewsDA.IsExistTable();
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
 bolIsExist = XzPhotoNewsDA.IsExistTable(strTabName);
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
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
if (objXzPhotoNewsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!标题 = [{0}],用户 = [{1}]的数据已经存在!(in clsXzPhotoNewsBL.AddNewRecordBySql2)", objXzPhotoNewsEN.PhotoNewsTitle,objXzPhotoNewsEN.PhotoNewsUser);
throw new Exception(strMsg);
}
try
{
bool bolResult = XzPhotoNewsDA.AddNewRecordBySQL2(objXzPhotoNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsBL.ReFreshCache();

if (clsXzPhotoNewsBL.relatedActions != null)
{
clsXzPhotoNewsBL.relatedActions.UpdRelaTabDate(objXzPhotoNewsEN.PhotoNewsId, "SetUpdDate");
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
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
if (objXzPhotoNewsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!标题 = [{0}],用户 = [{1}]的数据已经存在!(in clsXzPhotoNewsBL.AddNewRecordBySql2WithReturnKey)", objXzPhotoNewsEN.PhotoNewsTitle,objXzPhotoNewsEN.PhotoNewsUser);
throw new Exception(strMsg);
}
try
{
string strKey = XzPhotoNewsDA.AddNewRecordBySQL2WithReturnKey(objXzPhotoNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsBL.ReFreshCache();

if (clsXzPhotoNewsBL.relatedActions != null)
{
clsXzPhotoNewsBL.relatedActions.UpdRelaTabDate(objXzPhotoNewsEN.PhotoNewsId, "SetUpdDate");
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
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
try
{
bool bolResult = XzPhotoNewsDA.Update(objXzPhotoNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsBL.ReFreshCache();

if (clsXzPhotoNewsBL.relatedActions != null)
{
clsXzPhotoNewsBL.relatedActions.UpdRelaTabDate(objXzPhotoNewsEN.PhotoNewsId, "SetUpdDate");
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
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
 if (objXzPhotoNewsEN.PhotoNewsId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = XzPhotoNewsDA.UpdateBySql2(objXzPhotoNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsBL.ReFreshCache();

if (clsXzPhotoNewsBL.relatedActions != null)
{
clsXzPhotoNewsBL.relatedActions.UpdRelaTabDate(objXzPhotoNewsEN.PhotoNewsId, "SetUpdDate");
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
 /// <param name = "lngPhotoNewsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngPhotoNewsId)
{
try
{
 clsXzPhotoNewsEN objXzPhotoNewsEN = clsXzPhotoNewsBL.GetObjByPhotoNewsId(lngPhotoNewsId);

if (clsXzPhotoNewsBL.relatedActions != null)
{
clsXzPhotoNewsBL.relatedActions.UpdRelaTabDate(objXzPhotoNewsEN.PhotoNewsId, "SetUpdDate");
}
if (objXzPhotoNewsEN != null)
{
int intRecNum = XzPhotoNewsDA.DelRecord(lngPhotoNewsId);
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
/// <param name="lngPhotoNewsId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngPhotoNewsId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
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
//删除与表:[XzPhotoNews]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conXzPhotoNews.PhotoNewsId,
//lngPhotoNewsId);
//        clsXzPhotoNewsBL.DelXzPhotoNewssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzPhotoNewsBL.DelRecord(lngPhotoNewsId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzPhotoNewsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPhotoNewsId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngPhotoNewsId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngPhotoNewsId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsXzPhotoNewsBL.relatedActions != null)
{
clsXzPhotoNewsBL.relatedActions.UpdRelaTabDate(lngPhotoNewsId, "UpdRelaTabDate");
}
bool bolResult = XzPhotoNewsDA.DelRecord(lngPhotoNewsId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPhotoNewsIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelXzPhotoNewss(List<string> arrPhotoNewsIdLst)
{
if (arrPhotoNewsIdLst.Count == 0) return 0;
try
{
if (clsXzPhotoNewsBL.relatedActions != null)
{
foreach (var strPhotoNewsId in arrPhotoNewsIdLst)
{
long lngPhotoNewsId = long.Parse(strPhotoNewsId);
clsXzPhotoNewsBL.relatedActions.UpdRelaTabDate(lngPhotoNewsId, "UpdRelaTabDate");
}
}
int intDelRecNum = XzPhotoNewsDA.DelXzPhotoNews(arrPhotoNewsIdLst);
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
public static int DelXzPhotoNewssByCond(string strWhereCond)
{
try
{
if (clsXzPhotoNewsBL.relatedActions != null)
{
List<string> arrPhotoNewsId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPhotoNewsId in arrPhotoNewsId)
{
long lngPhotoNewsId = long.Parse(strPhotoNewsId);
clsXzPhotoNewsBL.relatedActions.UpdRelaTabDate(lngPhotoNewsId, "UpdRelaTabDate");
}
}
int intRecNum = XzPhotoNewsDA.DelXzPhotoNews(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[XzPhotoNews]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngPhotoNewsId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngPhotoNewsId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
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
//删除与表:[XzPhotoNews]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzPhotoNewsBL.DelRecord(lngPhotoNewsId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzPhotoNewsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPhotoNewsId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objXzPhotoNewsENS">源对象</param>
 /// <param name = "objXzPhotoNewsENT">目标对象</param>
 public static void CopyTo(clsXzPhotoNewsEN objXzPhotoNewsENS, clsXzPhotoNewsEN objXzPhotoNewsENT)
{
try
{
objXzPhotoNewsENT.PhotoNewsId = objXzPhotoNewsENS.PhotoNewsId; //流水号
objXzPhotoNewsENT.PhotoNewsTitle = objXzPhotoNewsENS.PhotoNewsTitle; //标题
objXzPhotoNewsENT.ImageUrl = objXzPhotoNewsENS.ImageUrl; //ImageUrl
objXzPhotoNewsENT.PhotoNewsContent = objXzPhotoNewsENS.PhotoNewsContent; //内容
objXzPhotoNewsENT.PhotoNewsDate = objXzPhotoNewsENS.PhotoNewsDate; //日期
objXzPhotoNewsENT.PhotoNewsUser = objXzPhotoNewsENS.PhotoNewsUser; //用户
objXzPhotoNewsENT.DepartmentID = objXzPhotoNewsENS.DepartmentID; //部门ID
objXzPhotoNewsENT.IdXzMajor = objXzPhotoNewsENS.IdXzMajor; //专业流水号
objXzPhotoNewsENT.Views = objXzPhotoNewsENS.Views; //浏览量
objXzPhotoNewsENT.IsTop = objXzPhotoNewsENS.IsTop; //是否置顶
objXzPhotoNewsENT.IsUrgent = objXzPhotoNewsENS.IsUrgent; //是否紧急
objXzPhotoNewsENT.Audit = objXzPhotoNewsENS.Audit; //审核
objXzPhotoNewsENT.Memo = objXzPhotoNewsENS.Memo; //备注
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
 /// <param name = "objXzPhotoNewsEN">源简化对象</param>
 public static void SetUpdFlag(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
try
{
objXzPhotoNewsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objXzPhotoNewsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conXzPhotoNews.PhotoNewsId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzPhotoNewsEN.PhotoNewsId = objXzPhotoNewsEN.PhotoNewsId; //流水号
}
if (arrFldSet.Contains(conXzPhotoNews.PhotoNewsTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objXzPhotoNewsEN.PhotoNewsTitle = objXzPhotoNewsEN.PhotoNewsTitle; //标题
}
if (arrFldSet.Contains(conXzPhotoNews.ImageUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objXzPhotoNewsEN.ImageUrl = objXzPhotoNewsEN.ImageUrl == "[null]" ? null :  objXzPhotoNewsEN.ImageUrl; //ImageUrl
}
if (arrFldSet.Contains(conXzPhotoNews.PhotoNewsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objXzPhotoNewsEN.PhotoNewsContent = objXzPhotoNewsEN.PhotoNewsContent == "[null]" ? null :  objXzPhotoNewsEN.PhotoNewsContent; //内容
}
if (arrFldSet.Contains(conXzPhotoNews.PhotoNewsDate, new clsStrCompareIgnoreCase())  ==  true)
{
objXzPhotoNewsEN.PhotoNewsDate = objXzPhotoNewsEN.PhotoNewsDate == "[null]" ? null :  objXzPhotoNewsEN.PhotoNewsDate; //日期
}
if (arrFldSet.Contains(conXzPhotoNews.PhotoNewsUser, new clsStrCompareIgnoreCase())  ==  true)
{
objXzPhotoNewsEN.PhotoNewsUser = objXzPhotoNewsEN.PhotoNewsUser == "[null]" ? null :  objXzPhotoNewsEN.PhotoNewsUser; //用户
}
if (arrFldSet.Contains(conXzPhotoNews.DepartmentID, new clsStrCompareIgnoreCase())  ==  true)
{
objXzPhotoNewsEN.DepartmentID = objXzPhotoNewsEN.DepartmentID; //部门ID
}
if (arrFldSet.Contains(conXzPhotoNews.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objXzPhotoNewsEN.IdXzMajor = objXzPhotoNewsEN.IdXzMajor == "[null]" ? null :  objXzPhotoNewsEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(conXzPhotoNews.Views, new clsStrCompareIgnoreCase())  ==  true)
{
objXzPhotoNewsEN.Views = objXzPhotoNewsEN.Views; //浏览量
}
if (arrFldSet.Contains(conXzPhotoNews.IsTop, new clsStrCompareIgnoreCase())  ==  true)
{
objXzPhotoNewsEN.IsTop = objXzPhotoNewsEN.IsTop; //是否置顶
}
if (arrFldSet.Contains(conXzPhotoNews.IsUrgent, new clsStrCompareIgnoreCase())  ==  true)
{
objXzPhotoNewsEN.IsUrgent = objXzPhotoNewsEN.IsUrgent; //是否紧急
}
if (arrFldSet.Contains(conXzPhotoNews.Audit, new clsStrCompareIgnoreCase())  ==  true)
{
objXzPhotoNewsEN.Audit = objXzPhotoNewsEN.Audit == "[null]" ? null :  objXzPhotoNewsEN.Audit; //审核
}
if (arrFldSet.Contains(conXzPhotoNews.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objXzPhotoNewsEN.Memo = objXzPhotoNewsEN.Memo == "[null]" ? null :  objXzPhotoNewsEN.Memo; //备注
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
 /// <param name = "objXzPhotoNewsEN">源简化对象</param>
 public static void AccessFldValueNull(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
try
{
if (objXzPhotoNewsEN.ImageUrl == "[null]") objXzPhotoNewsEN.ImageUrl = null; //ImageUrl
if (objXzPhotoNewsEN.PhotoNewsContent == "[null]") objXzPhotoNewsEN.PhotoNewsContent = null; //内容
if (objXzPhotoNewsEN.PhotoNewsDate == "[null]") objXzPhotoNewsEN.PhotoNewsDate = null; //日期
if (objXzPhotoNewsEN.PhotoNewsUser == "[null]") objXzPhotoNewsEN.PhotoNewsUser = null; //用户
if (objXzPhotoNewsEN.IdXzMajor == "[null]") objXzPhotoNewsEN.IdXzMajor = null; //专业流水号
if (objXzPhotoNewsEN.Audit == "[null]") objXzPhotoNewsEN.Audit = null; //审核
if (objXzPhotoNewsEN.Memo == "[null]") objXzPhotoNewsEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
 XzPhotoNewsDA.CheckPropertyNew(objXzPhotoNewsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
 XzPhotoNewsDA.CheckProperty4Condition(objXzPhotoNewsEN);
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
if (clsXzPhotoNewsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzPhotoNewsBL没有刷新缓存机制(clsXzPhotoNewsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PhotoNewsId");
//if (arrXzPhotoNewsObjLstCache == null)
//{
//arrXzPhotoNewsObjLstCache = XzPhotoNewsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPhotoNewsId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzPhotoNewsEN GetObjByPhotoNewsIdCache(long lngPhotoNewsId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsXzPhotoNewsEN._CurrTabName);
List<clsXzPhotoNewsEN> arrXzPhotoNewsObjLstCache = GetObjLstCache();
IEnumerable <clsXzPhotoNewsEN> arrXzPhotoNewsObjLst_Sel =
arrXzPhotoNewsObjLstCache
.Where(x=> x.PhotoNewsId == lngPhotoNewsId 
);
if (arrXzPhotoNewsObjLst_Sel.Count() == 0)
{
   clsXzPhotoNewsEN obj = clsXzPhotoNewsBL.GetObjByPhotoNewsId(lngPhotoNewsId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrXzPhotoNewsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzPhotoNewsEN> GetAllXzPhotoNewsObjLstCache()
{
//获取缓存中的对象列表
List<clsXzPhotoNewsEN> arrXzPhotoNewsObjLstCache = GetObjLstCache(); 
return arrXzPhotoNewsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzPhotoNewsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsXzPhotoNewsEN._CurrTabName);
List<clsXzPhotoNewsEN> arrXzPhotoNewsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzPhotoNewsObjLstCache;
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
string strKey = string.Format("{0}", clsXzPhotoNewsEN._CurrTabName);
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
if (clsXzPhotoNewsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzPhotoNewsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzPhotoNewsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--XzPhotoNews(图片新闻)
 /// 唯一性条件:PhotoNewsTitle_PhotoNewsUser
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
//检测记录是否存在
string strResult = XzPhotoNewsDA.GetUniCondStr(objXzPhotoNewsEN);
return strResult;
}


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
public static string Func(string strInFldName, string strOutFldName, long lngPhotoNewsId)
{
if (strInFldName != conXzPhotoNews.PhotoNewsId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conXzPhotoNews.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conXzPhotoNews.AttributeName));
throw new Exception(strMsg);
}
var objXzPhotoNews = clsXzPhotoNewsBL.GetObjByPhotoNewsIdCache(lngPhotoNewsId);
if (objXzPhotoNews == null) return "";
return objXzPhotoNews[strOutFldName].ToString();
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
int intRecCount = clsXzPhotoNewsDA.GetRecCount(strTabName);
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
int intRecCount = clsXzPhotoNewsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsXzPhotoNewsDA.GetRecCount();
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
int intRecCount = clsXzPhotoNewsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objXzPhotoNewsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsXzPhotoNewsEN objXzPhotoNewsCond)
{
List<clsXzPhotoNewsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzPhotoNewsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzPhotoNews.AttributeName)
{
if (objXzPhotoNewsCond.IsUpdated(strFldName) == false) continue;
if (objXzPhotoNewsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzPhotoNewsCond[strFldName].ToString());
}
else
{
if (objXzPhotoNewsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzPhotoNewsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzPhotoNewsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzPhotoNewsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzPhotoNewsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzPhotoNewsCond[strFldName]));
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
 List<string> arrList = clsXzPhotoNewsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = XzPhotoNewsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = XzPhotoNewsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = XzPhotoNewsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzPhotoNewsDA.SetFldValue(clsXzPhotoNewsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = XzPhotoNewsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzPhotoNewsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzPhotoNewsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzPhotoNewsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[XzPhotoNews] "); 
 strCreateTabCode.Append(" ( "); 
 // /**流水号*/ 
 strCreateTabCode.Append(" PhotoNewsId bigint primary key identity, "); 
 // /**标题*/ 
 strCreateTabCode.Append(" PhotoNewsTitle varchar(100) not Null, "); 
 // /**ImageUrl*/ 
 strCreateTabCode.Append(" ImageUrl varchar(100) Null, "); 
 // /**内容*/ 
 strCreateTabCode.Append(" PhotoNewsContent text Null, "); 
 // /**日期*/ 
 strCreateTabCode.Append(" PhotoNewsDate char(16) Null, "); 
 // /**用户*/ 
 strCreateTabCode.Append(" PhotoNewsUser varchar(50) Null, "); 
 // /**部门ID*/ 
 strCreateTabCode.Append(" DepartmentID char(8) not Null, "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" IdXzMajor char(8) Null, "); 
 // /**浏览量*/ 
 strCreateTabCode.Append(" Views int Null, "); 
 // /**是否置顶*/ 
 strCreateTabCode.Append(" IsTop bit Null, "); 
 // /**是否紧急*/ 
 strCreateTabCode.Append(" IsUrgent bit Null, "); 
 // /**审核*/ 
 strCreateTabCode.Append(" Audit char(1) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 图片新闻(XzPhotoNews)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4XzPhotoNews : clsCommFun4BL
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
clsXzPhotoNewsBL.ReFreshThisCache();
}
}

}