﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseFreeSenateBL
 表名:PubClassCaseFreeSenate(01120413)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:44
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
public static class  clsPubClassCaseFreeSenateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubClassCaseFreeSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCaseFreeSenateEN GetObj(this K_IdPubClassCaseFreeSenate_PubClassCaseFreeSenate myKey)
{
clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = clsPubClassCaseFreeSenateBL.PubClassCaseFreeSenateDA.GetObjByIdPubClassCaseFreeSenate(myKey.Value);
return objPubClassCaseFreeSenateEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
if (CheckUniqueness(objPubClassCaseFreeSenateEN) == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],用户ID = [{1}],评议主题 = [{2}]的数据已经存在!(in clsPubClassCaseFreeSenateBL.AddNewRecord)", objPubClassCaseFreeSenateEN.IdPubClassCase,objPubClassCaseFreeSenateEN.UserId,objPubClassCaseFreeSenateEN.AppraiseTheme);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsPubClassCaseFreeSenateBL.PubClassCaseFreeSenateDA.AddNewRecordBySQL2(objPubClassCaseFreeSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateBL.ReFreshCache();

if (clsPubClassCaseFreeSenateBL.relatedActions != null)
{
clsPubClassCaseFreeSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, "SetUpdDate");
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
public static bool AddRecordEx(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
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
objPubClassCaseFreeSenateEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objPubClassCaseFreeSenateEN.CheckUniqueness() == false)
{
strMsg = string.Format("(案例流水号(IdPubClassCase)=[{0}],用户ID(UserId)=[{1}],评议主题(AppraiseTheme)=[{2}])已经存在,不能重复!", objPubClassCaseFreeSenateEN.IdPubClassCase, objPubClassCaseFreeSenateEN.UserId, objPubClassCaseFreeSenateEN.AppraiseTheme);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objPubClassCaseFreeSenateEN.AddNewRecord();
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
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
if (CheckUniqueness(objPubClassCaseFreeSenateEN) == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],用户ID = [{1}],评议主题 = [{2}]的数据已经存在!(in clsPubClassCaseFreeSenateBL.AddNewRecordWithReturnKey)", objPubClassCaseFreeSenateEN.IdPubClassCase,objPubClassCaseFreeSenateEN.UserId,objPubClassCaseFreeSenateEN.AppraiseTheme);
throw new Exception(strMsg);
}
try
{
string strKey = clsPubClassCaseFreeSenateBL.PubClassCaseFreeSenateDA.AddNewRecordBySQL2WithReturnKey(objPubClassCaseFreeSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateBL.ReFreshCache();

if (clsPubClassCaseFreeSenateBL.relatedActions != null)
{
clsPubClassCaseFreeSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetIdPubClassCaseFreeSenate(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, long lngIdPubClassCaseFreeSenate, string strComparisonOp="")
	{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = lngIdPubClassCaseFreeSenate; //公开课案例自由评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetIdPubClassCase(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strIdPubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubClassCase, conPubClassCaseFreeSenate.IdPubClassCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCase, 8, conPubClassCaseFreeSenate.IdPubClassCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCase, 8, conPubClassCaseFreeSenate.IdPubClassCase);
}
objPubClassCaseFreeSenateEN.IdPubClassCase = strIdPubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.IdPubClassCase) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.IdPubClassCase, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.IdPubClassCase] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetUserId(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conPubClassCaseFreeSenate.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conPubClassCaseFreeSenate.UserId);
}
objPubClassCaseFreeSenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.UserId) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.UserId, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.UserId] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetAppraiseTheme(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strAppraiseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTheme, 200, conPubClassCaseFreeSenate.AppraiseTheme);
}
objPubClassCaseFreeSenateEN.AppraiseTheme = strAppraiseTheme; //评议主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.AppraiseTheme) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.AppraiseTheme, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.AppraiseTheme] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateTitle(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateTitle, 200, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
}
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = strPubClassCaseFreeSenateTitle; //公开课案例自由评议标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateConten(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateConten, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateConten, 2000, conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
}
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = strPubClassCaseFreeSenateConten; //公开课案例自由评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateDate(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateDate, 8, conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseFreeSenateDate, 8, conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
}
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = strPubClassCaseFreeSenateDate; //公开课案例自由评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateTime(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateTime, 6, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseFreeSenateTime, 6, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
}
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = strPubClassCaseFreeSenateTime; //公开课案例自由评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetVideoStopTime(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strVideoStopTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoStopTime, 48, conPubClassCaseFreeSenate.VideoStopTime);
}
objPubClassCaseFreeSenateEN.VideoStopTime = strVideoStopTime; //公开课案例视频暂停时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.VideoStopTime) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.VideoStopTime, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.VideoStopTime] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetVideoStopImage(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, byte[] bytVideoStopImage, string strComparisonOp="")
	{
objPubClassCaseFreeSenateEN.VideoStopImage = bytVideoStopImage; //公开课案例视频暂停截图
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.VideoStopImage) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.VideoStopImage, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.VideoStopImage] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetBrowseCount(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, int? intBrowseCount, string strComparisonOp="")
	{
objPubClassCaseFreeSenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.BrowseCount) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.BrowseCount, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.BrowseCount] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPubClassCaseFreeSenateEN.CheckPropertyNew();
clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateCond = new clsPubClassCaseFreeSenateEN();
string strCondition = objPubClassCaseFreeSenateCond
.SetIdPubClassCaseFreeSenate(objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, "<>")
.SetIdPubClassCase(objPubClassCaseFreeSenateEN.IdPubClassCase, "=")
.SetUserId(objPubClassCaseFreeSenateEN.UserId, "=")
.SetAppraiseTheme(objPubClassCaseFreeSenateEN.AppraiseTheme, "=")
.GetCombineCondition();
objPubClassCaseFreeSenateEN._IsCheckProperty = true;
bool bolIsExist = clsPubClassCaseFreeSenateBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_PubClassCase_UserId_AppraiseTheme)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPubClassCaseFreeSenateEN.Update();
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
 /// <param name = "objPubClassCaseFreeSenate">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenate)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateCond = new clsPubClassCaseFreeSenateEN();
string strCondition = objPubClassCaseFreeSenateCond
.SetIdPubClassCase(objPubClassCaseFreeSenate.IdPubClassCase, "=")
.SetUserId(objPubClassCaseFreeSenate.UserId, "=")
.SetAppraiseTheme(objPubClassCaseFreeSenate.AppraiseTheme, "=")
.GetCombineCondition();
objPubClassCaseFreeSenate._IsCheckProperty = true;
bool bolIsExist = clsPubClassCaseFreeSenateBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPubClassCaseFreeSenate.IdPubClassCaseFreeSenate = clsPubClassCaseFreeSenateBL.GetFirstID_S(strCondition);
objPubClassCaseFreeSenate.UpdateWithCondition(strCondition);
}
else
{
objPubClassCaseFreeSenate.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
 if (objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPubClassCaseFreeSenateBL.PubClassCaseFreeSenateDA.UpdateBySql2(objPubClassCaseFreeSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateBL.ReFreshCache();

if (clsPubClassCaseFreeSenateBL.relatedActions != null)
{
clsPubClassCaseFreeSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPubClassCaseFreeSenateBL.PubClassCaseFreeSenateDA.UpdateBySql2(objPubClassCaseFreeSenateEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateBL.ReFreshCache();

if (clsPubClassCaseFreeSenateBL.relatedActions != null)
{
clsPubClassCaseFreeSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseFreeSenateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strWhereCond)
{
try
{
bool bolResult = clsPubClassCaseFreeSenateBL.PubClassCaseFreeSenateDA.UpdateBySqlWithCondition(objPubClassCaseFreeSenateEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateBL.ReFreshCache();

if (clsPubClassCaseFreeSenateBL.relatedActions != null)
{
clsPubClassCaseFreeSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseFreeSenateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPubClassCaseFreeSenateBL.PubClassCaseFreeSenateDA.UpdateBySqlWithConditionTransaction(objPubClassCaseFreeSenateEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateBL.ReFreshCache();

if (clsPubClassCaseFreeSenateBL.relatedActions != null)
{
clsPubClassCaseFreeSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, "SetUpdDate");
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
 /// <param name = "lngIdPubClassCaseFreeSenate">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
try
{
int intRecNum = clsPubClassCaseFreeSenateBL.PubClassCaseFreeSenateDA.DelRecord(objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateBL.ReFreshCache();

if (clsPubClassCaseFreeSenateBL.relatedActions != null)
{
clsPubClassCaseFreeSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseFreeSenateENS">源对象</param>
 /// <param name = "objPubClassCaseFreeSenateENT">目标对象</param>
 public static void CopyTo(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateENS, clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateENT)
{
try
{
objPubClassCaseFreeSenateENT.IdPubClassCaseFreeSenate = objPubClassCaseFreeSenateENS.IdPubClassCaseFreeSenate; //公开课案例自由评议流水号
objPubClassCaseFreeSenateENT.IdPubClassCase = objPubClassCaseFreeSenateENS.IdPubClassCase; //案例流水号
objPubClassCaseFreeSenateENT.UserId = objPubClassCaseFreeSenateENS.UserId; //用户ID
objPubClassCaseFreeSenateENT.AppraiseTheme = objPubClassCaseFreeSenateENS.AppraiseTheme; //评议主题
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateTitle = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTitle; //公开课案例自由评议标题
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateConten = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateConten; //公开课案例自由评议内容
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateDate = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateDate; //公开课案例自由评议日期
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateTime = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTime; //公开课案例自由评议时间
objPubClassCaseFreeSenateENT.VideoStopTime = objPubClassCaseFreeSenateENS.VideoStopTime; //公开课案例视频暂停时间
objPubClassCaseFreeSenateENT.VideoStopImage = objPubClassCaseFreeSenateENS.VideoStopImage; //公开课案例视频暂停截图
objPubClassCaseFreeSenateENT.BrowseCount = objPubClassCaseFreeSenateENS.BrowseCount; //浏览次数
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
 /// <param name = "objPubClassCaseFreeSenateENS">源对象</param>
 /// <returns>目标对象=>clsPubClassCaseFreeSenateEN:objPubClassCaseFreeSenateENT</returns>
 public static clsPubClassCaseFreeSenateEN CopyTo(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateENS)
{
try
{
 clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateENT = new clsPubClassCaseFreeSenateEN()
{
IdPubClassCaseFreeSenate = objPubClassCaseFreeSenateENS.IdPubClassCaseFreeSenate, //公开课案例自由评议流水号
IdPubClassCase = objPubClassCaseFreeSenateENS.IdPubClassCase, //案例流水号
UserId = objPubClassCaseFreeSenateENS.UserId, //用户ID
AppraiseTheme = objPubClassCaseFreeSenateENS.AppraiseTheme, //评议主题
PubClassCaseFreeSenateTitle = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTitle, //公开课案例自由评议标题
PubClassCaseFreeSenateConten = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateConten, //公开课案例自由评议内容
PubClassCaseFreeSenateDate = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateDate, //公开课案例自由评议日期
PubClassCaseFreeSenateTime = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTime, //公开课案例自由评议时间
VideoStopTime = objPubClassCaseFreeSenateENS.VideoStopTime, //公开课案例视频暂停时间
VideoStopImage = objPubClassCaseFreeSenateENS.VideoStopImage, //公开课案例视频暂停截图
BrowseCount = objPubClassCaseFreeSenateENS.BrowseCount, //浏览次数
};
 return objPubClassCaseFreeSenateENT;
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
public static void CheckPropertyNew(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
 clsPubClassCaseFreeSenateBL.PubClassCaseFreeSenateDA.CheckPropertyNew(objPubClassCaseFreeSenateEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
 clsPubClassCaseFreeSenateBL.PubClassCaseFreeSenateDA.CheckProperty4Condition(objPubClassCaseFreeSenateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPubClassCaseFreeSenateCond.IsUpdated(conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate) == true)
{
string strComparisonOpIdPubClassCaseFreeSenate = objPubClassCaseFreeSenateCond.dicFldComparisonOp[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate];
strWhereCond += string.Format(" And {0} {2} {1}", conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate, objPubClassCaseFreeSenateCond.IdPubClassCaseFreeSenate, strComparisonOpIdPubClassCaseFreeSenate);
}
if (objPubClassCaseFreeSenateCond.IsUpdated(conPubClassCaseFreeSenate.IdPubClassCase) == true)
{
string strComparisonOpIdPubClassCase = objPubClassCaseFreeSenateCond.dicFldComparisonOp[conPubClassCaseFreeSenate.IdPubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.IdPubClassCase, objPubClassCaseFreeSenateCond.IdPubClassCase, strComparisonOpIdPubClassCase);
}
if (objPubClassCaseFreeSenateCond.IsUpdated(conPubClassCaseFreeSenate.UserId) == true)
{
string strComparisonOpUserId = objPubClassCaseFreeSenateCond.dicFldComparisonOp[conPubClassCaseFreeSenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.UserId, objPubClassCaseFreeSenateCond.UserId, strComparisonOpUserId);
}
if (objPubClassCaseFreeSenateCond.IsUpdated(conPubClassCaseFreeSenate.AppraiseTheme) == true)
{
string strComparisonOpAppraiseTheme = objPubClassCaseFreeSenateCond.dicFldComparisonOp[conPubClassCaseFreeSenate.AppraiseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.AppraiseTheme, objPubClassCaseFreeSenateCond.AppraiseTheme, strComparisonOpAppraiseTheme);
}
if (objPubClassCaseFreeSenateCond.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle) == true)
{
string strComparisonOpPubClassCaseFreeSenateTitle = objPubClassCaseFreeSenateCond.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle, objPubClassCaseFreeSenateCond.PubClassCaseFreeSenateTitle, strComparisonOpPubClassCaseFreeSenateTitle);
}
if (objPubClassCaseFreeSenateCond.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten) == true)
{
string strComparisonOpPubClassCaseFreeSenateConten = objPubClassCaseFreeSenateCond.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten, objPubClassCaseFreeSenateCond.PubClassCaseFreeSenateConten, strComparisonOpPubClassCaseFreeSenateConten);
}
if (objPubClassCaseFreeSenateCond.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate) == true)
{
string strComparisonOpPubClassCaseFreeSenateDate = objPubClassCaseFreeSenateCond.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate, objPubClassCaseFreeSenateCond.PubClassCaseFreeSenateDate, strComparisonOpPubClassCaseFreeSenateDate);
}
if (objPubClassCaseFreeSenateCond.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime) == true)
{
string strComparisonOpPubClassCaseFreeSenateTime = objPubClassCaseFreeSenateCond.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime, objPubClassCaseFreeSenateCond.PubClassCaseFreeSenateTime, strComparisonOpPubClassCaseFreeSenateTime);
}
if (objPubClassCaseFreeSenateCond.IsUpdated(conPubClassCaseFreeSenate.VideoStopTime) == true)
{
string strComparisonOpVideoStopTime = objPubClassCaseFreeSenateCond.dicFldComparisonOp[conPubClassCaseFreeSenate.VideoStopTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.VideoStopTime, objPubClassCaseFreeSenateCond.VideoStopTime, strComparisonOpVideoStopTime);
}
//数据类型byte[](image)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objPubClassCaseFreeSenateCond.IsUpdated(conPubClassCaseFreeSenate.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objPubClassCaseFreeSenateCond.dicFldComparisonOp[conPubClassCaseFreeSenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPubClassCaseFreeSenate.BrowseCount, objPubClassCaseFreeSenateCond.BrowseCount, strComparisonOpBrowseCount);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PubClassCaseFreeSenate(公开课案例自由评议), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_PubClassCase_UserId_AppraiseTheme
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPubClassCaseFreeSenateEN == null) return true;
if (objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdPubClassCase = '{0}'", objPubClassCaseFreeSenateEN.IdPubClassCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objPubClassCaseFreeSenateEN.UserId);
 if (objPubClassCaseFreeSenateEN.AppraiseTheme == null)
{
 sbCondition.AppendFormat(" and AppraiseTheme is null", objPubClassCaseFreeSenateEN.AppraiseTheme);
}
else
{
 sbCondition.AppendFormat(" and AppraiseTheme = '{0}'", objPubClassCaseFreeSenateEN.AppraiseTheme);
}
if (clsPubClassCaseFreeSenateBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdPubClassCaseFreeSenate !=  {0}", objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate);
 sbCondition.AppendFormat(" and IdPubClassCase = '{0}'", objPubClassCaseFreeSenateEN.IdPubClassCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objPubClassCaseFreeSenateEN.UserId);
 sbCondition.AppendFormat(" and AppraiseTheme = '{0}'", objPubClassCaseFreeSenateEN.AppraiseTheme);
if (clsPubClassCaseFreeSenateBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PubClassCaseFreeSenate(公开课案例自由评议), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_PubClassCase_UserId_AppraiseTheme
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPubClassCaseFreeSenateEN == null) return "";
if (objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdPubClassCase = '{0}'", objPubClassCaseFreeSenateEN.IdPubClassCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objPubClassCaseFreeSenateEN.UserId);
 if (objPubClassCaseFreeSenateEN.AppraiseTheme == null)
{
 sbCondition.AppendFormat(" and AppraiseTheme is null", objPubClassCaseFreeSenateEN.AppraiseTheme);
}
else
{
 sbCondition.AppendFormat(" and AppraiseTheme = '{0}'", objPubClassCaseFreeSenateEN.AppraiseTheme);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdPubClassCaseFreeSenate !=  {0}", objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate);
 sbCondition.AppendFormat(" and IdPubClassCase = '{0}'", objPubClassCaseFreeSenateEN.IdPubClassCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objPubClassCaseFreeSenateEN.UserId);
 sbCondition.AppendFormat(" and AppraiseTheme = '{0}'", objPubClassCaseFreeSenateEN.AppraiseTheme);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PubClassCaseFreeSenate
{
public virtual bool UpdRelaTabDate(long lngIdPubClassCaseFreeSenate, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 公开课案例自由评议(PubClassCaseFreeSenate)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPubClassCaseFreeSenateBL
{
public static RelatedActions_PubClassCaseFreeSenate relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPubClassCaseFreeSenateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPubClassCaseFreeSenateDA PubClassCaseFreeSenateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPubClassCaseFreeSenateDA();
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
 public clsPubClassCaseFreeSenateBL()
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
if (string.IsNullOrEmpty(clsPubClassCaseFreeSenateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPubClassCaseFreeSenateEN._ConnectString);
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
public static DataTable GetDataTable_PubClassCaseFreeSenate(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PubClassCaseFreeSenateDA.GetDataTable_PubClassCaseFreeSenate(strWhereCond);
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
objDT = PubClassCaseFreeSenateDA.GetDataTable(strWhereCond);
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
objDT = PubClassCaseFreeSenateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PubClassCaseFreeSenateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PubClassCaseFreeSenateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PubClassCaseFreeSenateDA.GetDataTable_Top(objTopPara);
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
objDT = PubClassCaseFreeSenateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PubClassCaseFreeSenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PubClassCaseFreeSenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdPubClassCaseFreeSenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPubClassCaseFreeSenateEN> GetObjLstByIdPubClassCaseFreeSenateLst(List<long> arrIdPubClassCaseFreeSenateLst)
{
List<clsPubClassCaseFreeSenateEN> arrObjLst = new List<clsPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPubClassCaseFreeSenateLst);
 string strWhereCond = string.Format("IdPubClassCaseFreeSenate in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN();
try
{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objPubClassCaseFreeSenateEN.IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseFreeSenateEN.UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objPubClassCaseFreeSenateEN.AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objPubClassCaseFreeSenateEN.VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objPubClassCaseFreeSenateEN.VideoStopImage = (byte[])objRow[conPubClassCaseFreeSenate.VideoStopImage]; //公开课案例视频暂停截图
objPubClassCaseFreeSenateEN.BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseFreeSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPubClassCaseFreeSenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPubClassCaseFreeSenateEN> GetObjLstByIdPubClassCaseFreeSenateLstCache(List<long> arrIdPubClassCaseFreeSenateLst)
{
string strKey = string.Format("{0}", clsPubClassCaseFreeSenateEN._CurrTabName);
List<clsPubClassCaseFreeSenateEN> arrPubClassCaseFreeSenateObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseFreeSenateEN> arrPubClassCaseFreeSenateObjLst_Sel =
arrPubClassCaseFreeSenateObjLstCache
.Where(x => arrIdPubClassCaseFreeSenateLst.Contains(x.IdPubClassCaseFreeSenate));
return arrPubClassCaseFreeSenateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseFreeSenateEN> GetObjLst(string strWhereCond)
{
List<clsPubClassCaseFreeSenateEN> arrObjLst = new List<clsPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN();
try
{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objPubClassCaseFreeSenateEN.IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseFreeSenateEN.UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objPubClassCaseFreeSenateEN.AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objPubClassCaseFreeSenateEN.VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objPubClassCaseFreeSenateEN.VideoStopImage = (byte[])objRow[conPubClassCaseFreeSenate.VideoStopImage]; //公开课案例视频暂停截图
objPubClassCaseFreeSenateEN.BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseFreeSenateEN);
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
public static List<clsPubClassCaseFreeSenateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPubClassCaseFreeSenateEN> arrObjLst = new List<clsPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN();
try
{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objPubClassCaseFreeSenateEN.IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseFreeSenateEN.UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objPubClassCaseFreeSenateEN.AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objPubClassCaseFreeSenateEN.VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objPubClassCaseFreeSenateEN.VideoStopImage = (byte[])objRow[conPubClassCaseFreeSenate.VideoStopImage]; //公开课案例视频暂停截图
objPubClassCaseFreeSenateEN.BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseFreeSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPubClassCaseFreeSenateEN> GetSubObjLstCache(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateCond)
{
List<clsPubClassCaseFreeSenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseFreeSenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPubClassCaseFreeSenate.AttributeName)
{
if (objPubClassCaseFreeSenateCond.IsUpdated(strFldName) == false) continue;
if (objPubClassCaseFreeSenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseFreeSenateCond[strFldName].ToString());
}
else
{
if (objPubClassCaseFreeSenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPubClassCaseFreeSenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseFreeSenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPubClassCaseFreeSenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPubClassCaseFreeSenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPubClassCaseFreeSenateCond[strFldName]));
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
public static List<clsPubClassCaseFreeSenateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPubClassCaseFreeSenateEN> arrObjLst = new List<clsPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN();
try
{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objPubClassCaseFreeSenateEN.IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseFreeSenateEN.UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objPubClassCaseFreeSenateEN.AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objPubClassCaseFreeSenateEN.VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objPubClassCaseFreeSenateEN.VideoStopImage = (byte[])objRow[conPubClassCaseFreeSenate.VideoStopImage]; //公开课案例视频暂停截图
objPubClassCaseFreeSenateEN.BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseFreeSenateEN);
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
public static List<clsPubClassCaseFreeSenateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPubClassCaseFreeSenateEN> arrObjLst = new List<clsPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN();
try
{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objPubClassCaseFreeSenateEN.IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseFreeSenateEN.UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objPubClassCaseFreeSenateEN.AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objPubClassCaseFreeSenateEN.VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objPubClassCaseFreeSenateEN.VideoStopImage = (byte[])objRow[conPubClassCaseFreeSenate.VideoStopImage]; //公开课案例视频暂停截图
objPubClassCaseFreeSenateEN.BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseFreeSenateEN);
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
List<clsPubClassCaseFreeSenateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPubClassCaseFreeSenateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseFreeSenateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPubClassCaseFreeSenateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPubClassCaseFreeSenateEN> arrObjLst = new List<clsPubClassCaseFreeSenateEN>(); 
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
	clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN();
try
{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objPubClassCaseFreeSenateEN.IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseFreeSenateEN.UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objPubClassCaseFreeSenateEN.AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objPubClassCaseFreeSenateEN.VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objPubClassCaseFreeSenateEN.VideoStopImage = (byte[])objRow[conPubClassCaseFreeSenate.VideoStopImage]; //公开课案例视频暂停截图
objPubClassCaseFreeSenateEN.BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseFreeSenateEN);
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
public static List<clsPubClassCaseFreeSenateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPubClassCaseFreeSenateEN> arrObjLst = new List<clsPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN();
try
{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objPubClassCaseFreeSenateEN.IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseFreeSenateEN.UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objPubClassCaseFreeSenateEN.AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objPubClassCaseFreeSenateEN.VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objPubClassCaseFreeSenateEN.VideoStopImage = (byte[])objRow[conPubClassCaseFreeSenate.VideoStopImage]; //公开课案例视频暂停截图
objPubClassCaseFreeSenateEN.BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseFreeSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPubClassCaseFreeSenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPubClassCaseFreeSenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPubClassCaseFreeSenateEN> arrObjLst = new List<clsPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN();
try
{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objPubClassCaseFreeSenateEN.IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseFreeSenateEN.UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objPubClassCaseFreeSenateEN.AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objPubClassCaseFreeSenateEN.VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objPubClassCaseFreeSenateEN.VideoStopImage = (byte[])objRow[conPubClassCaseFreeSenate.VideoStopImage]; //公开课案例视频暂停截图
objPubClassCaseFreeSenateEN.BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseFreeSenateEN);
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
public static List<clsPubClassCaseFreeSenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPubClassCaseFreeSenateEN> arrObjLst = new List<clsPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN();
try
{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objPubClassCaseFreeSenateEN.IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseFreeSenateEN.UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objPubClassCaseFreeSenateEN.AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objPubClassCaseFreeSenateEN.VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objPubClassCaseFreeSenateEN.VideoStopImage = (byte[])objRow[conPubClassCaseFreeSenate.VideoStopImage]; //公开课案例视频暂停截图
objPubClassCaseFreeSenateEN.BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseFreeSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseFreeSenateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPubClassCaseFreeSenateEN> arrObjLst = new List<clsPubClassCaseFreeSenateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN();
try
{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objPubClassCaseFreeSenateEN.IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseFreeSenateEN.UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objPubClassCaseFreeSenateEN.AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objPubClassCaseFreeSenateEN.VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objPubClassCaseFreeSenateEN.VideoStopImage = (byte[])objRow[conPubClassCaseFreeSenate.VideoStopImage]; //公开课案例视频暂停截图
objPubClassCaseFreeSenateEN.BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseFreeSenateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPubClassCaseFreeSenate(ref clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
bool bolResult = PubClassCaseFreeSenateDA.GetPubClassCaseFreeSenate(ref objPubClassCaseFreeSenateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubClassCaseFreeSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCaseFreeSenateEN GetObjByIdPubClassCaseFreeSenate(long lngIdPubClassCaseFreeSenate)
{
clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = PubClassCaseFreeSenateDA.GetObjByIdPubClassCaseFreeSenate(lngIdPubClassCaseFreeSenate);
return objPubClassCaseFreeSenateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPubClassCaseFreeSenateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = PubClassCaseFreeSenateDA.GetFirstObj(strWhereCond);
 return objPubClassCaseFreeSenateEN;
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
public static clsPubClassCaseFreeSenateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = PubClassCaseFreeSenateDA.GetObjByDataRow(objRow);
 return objPubClassCaseFreeSenateEN;
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
public static clsPubClassCaseFreeSenateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = PubClassCaseFreeSenateDA.GetObjByDataRow(objRow);
 return objPubClassCaseFreeSenateEN;
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
 /// <param name = "lngIdPubClassCaseFreeSenate">所给的关键字</param>
 /// <param name = "lstPubClassCaseFreeSenateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPubClassCaseFreeSenateEN GetObjByIdPubClassCaseFreeSenateFromList(long lngIdPubClassCaseFreeSenate, List<clsPubClassCaseFreeSenateEN> lstPubClassCaseFreeSenateObjLst)
{
foreach (clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN in lstPubClassCaseFreeSenateObjLst)
{
if (objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate == lngIdPubClassCaseFreeSenate)
{
return objPubClassCaseFreeSenateEN;
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
 long lngIdPubClassCaseFreeSenate;
 try
 {
 lngIdPubClassCaseFreeSenate = new clsPubClassCaseFreeSenateDA().GetFirstID(strWhereCond);
 return lngIdPubClassCaseFreeSenate;
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
 arrList = PubClassCaseFreeSenateDA.GetID(strWhereCond);
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
bool bolIsExist = PubClassCaseFreeSenateDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdPubClassCaseFreeSenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdPubClassCaseFreeSenate)
{
//检测记录是否存在
bool bolIsExist = PubClassCaseFreeSenateDA.IsExist(lngIdPubClassCaseFreeSenate);
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
 bolIsExist = clsPubClassCaseFreeSenateDA.IsExistTable();
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
 bolIsExist = PubClassCaseFreeSenateDA.IsExistTable(strTabName);
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
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
if (objPubClassCaseFreeSenateEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],用户ID = [{1}],评议主题 = [{2}]的数据已经存在!(in clsPubClassCaseFreeSenateBL.AddNewRecordBySql2)", objPubClassCaseFreeSenateEN.IdPubClassCase,objPubClassCaseFreeSenateEN.UserId,objPubClassCaseFreeSenateEN.AppraiseTheme);
throw new Exception(strMsg);
}
try
{
bool bolResult = PubClassCaseFreeSenateDA.AddNewRecordBySQL2(objPubClassCaseFreeSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateBL.ReFreshCache();

if (clsPubClassCaseFreeSenateBL.relatedActions != null)
{
clsPubClassCaseFreeSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
if (objPubClassCaseFreeSenateEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],用户ID = [{1}],评议主题 = [{2}]的数据已经存在!(in clsPubClassCaseFreeSenateBL.AddNewRecordBySql2WithReturnKey)", objPubClassCaseFreeSenateEN.IdPubClassCase,objPubClassCaseFreeSenateEN.UserId,objPubClassCaseFreeSenateEN.AppraiseTheme);
throw new Exception(strMsg);
}
try
{
string strKey = PubClassCaseFreeSenateDA.AddNewRecordBySQL2WithReturnKey(objPubClassCaseFreeSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateBL.ReFreshCache();

if (clsPubClassCaseFreeSenateBL.relatedActions != null)
{
clsPubClassCaseFreeSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
try
{
bool bolResult = PubClassCaseFreeSenateDA.Update(objPubClassCaseFreeSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateBL.ReFreshCache();

if (clsPubClassCaseFreeSenateBL.relatedActions != null)
{
clsPubClassCaseFreeSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
 if (objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PubClassCaseFreeSenateDA.UpdateBySql2(objPubClassCaseFreeSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateBL.ReFreshCache();

if (clsPubClassCaseFreeSenateBL.relatedActions != null)
{
clsPubClassCaseFreeSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, "SetUpdDate");
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
 /// <param name = "lngIdPubClassCaseFreeSenate">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdPubClassCaseFreeSenate)
{
try
{
 clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = clsPubClassCaseFreeSenateBL.GetObjByIdPubClassCaseFreeSenate(lngIdPubClassCaseFreeSenate);

if (clsPubClassCaseFreeSenateBL.relatedActions != null)
{
clsPubClassCaseFreeSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, "SetUpdDate");
}
if (objPubClassCaseFreeSenateEN != null)
{
int intRecNum = PubClassCaseFreeSenateDA.DelRecord(lngIdPubClassCaseFreeSenate);
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
/// <param name="lngIdPubClassCaseFreeSenate">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdPubClassCaseFreeSenate )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
//删除与表:[PubClassCaseFreeSenate]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate,
//lngIdPubClassCaseFreeSenate);
//        clsPubClassCaseFreeSenateBL.DelPubClassCaseFreeSenatesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPubClassCaseFreeSenateBL.DelRecord(lngIdPubClassCaseFreeSenate, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPubClassCaseFreeSenateBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdPubClassCaseFreeSenate, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdPubClassCaseFreeSenate">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdPubClassCaseFreeSenate, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPubClassCaseFreeSenateBL.relatedActions != null)
{
clsPubClassCaseFreeSenateBL.relatedActions.UpdRelaTabDate(lngIdPubClassCaseFreeSenate, "UpdRelaTabDate");
}
bool bolResult = PubClassCaseFreeSenateDA.DelRecord(lngIdPubClassCaseFreeSenate,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdPubClassCaseFreeSenateLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPubClassCaseFreeSenates(List<string> arrIdPubClassCaseFreeSenateLst)
{
if (arrIdPubClassCaseFreeSenateLst.Count == 0) return 0;
try
{
if (clsPubClassCaseFreeSenateBL.relatedActions != null)
{
foreach (var strIdPubClassCaseFreeSenate in arrIdPubClassCaseFreeSenateLst)
{
long lngIdPubClassCaseFreeSenate = long.Parse(strIdPubClassCaseFreeSenate);
clsPubClassCaseFreeSenateBL.relatedActions.UpdRelaTabDate(lngIdPubClassCaseFreeSenate, "UpdRelaTabDate");
}
}
int intDelRecNum = PubClassCaseFreeSenateDA.DelPubClassCaseFreeSenate(arrIdPubClassCaseFreeSenateLst);
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
public static int DelPubClassCaseFreeSenatesByCond(string strWhereCond)
{
try
{
if (clsPubClassCaseFreeSenateBL.relatedActions != null)
{
List<string> arrIdPubClassCaseFreeSenate = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdPubClassCaseFreeSenate in arrIdPubClassCaseFreeSenate)
{
long lngIdPubClassCaseFreeSenate = long.Parse(strIdPubClassCaseFreeSenate);
clsPubClassCaseFreeSenateBL.relatedActions.UpdRelaTabDate(lngIdPubClassCaseFreeSenate, "UpdRelaTabDate");
}
}
int intRecNum = PubClassCaseFreeSenateDA.DelPubClassCaseFreeSenate(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PubClassCaseFreeSenate]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdPubClassCaseFreeSenate">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdPubClassCaseFreeSenate)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
//删除与表:[PubClassCaseFreeSenate]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPubClassCaseFreeSenateBL.DelRecord(lngIdPubClassCaseFreeSenate, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPubClassCaseFreeSenateBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdPubClassCaseFreeSenate, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPubClassCaseFreeSenateENS">源对象</param>
 /// <param name = "objPubClassCaseFreeSenateENT">目标对象</param>
 public static void CopyTo(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateENS, clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateENT)
{
try
{
objPubClassCaseFreeSenateENT.IdPubClassCaseFreeSenate = objPubClassCaseFreeSenateENS.IdPubClassCaseFreeSenate; //公开课案例自由评议流水号
objPubClassCaseFreeSenateENT.IdPubClassCase = objPubClassCaseFreeSenateENS.IdPubClassCase; //案例流水号
objPubClassCaseFreeSenateENT.UserId = objPubClassCaseFreeSenateENS.UserId; //用户ID
objPubClassCaseFreeSenateENT.AppraiseTheme = objPubClassCaseFreeSenateENS.AppraiseTheme; //评议主题
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateTitle = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTitle; //公开课案例自由评议标题
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateConten = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateConten; //公开课案例自由评议内容
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateDate = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateDate; //公开课案例自由评议日期
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateTime = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTime; //公开课案例自由评议时间
objPubClassCaseFreeSenateENT.VideoStopTime = objPubClassCaseFreeSenateENS.VideoStopTime; //公开课案例视频暂停时间
objPubClassCaseFreeSenateENT.VideoStopImage = objPubClassCaseFreeSenateENS.VideoStopImage; //公开课案例视频暂停截图
objPubClassCaseFreeSenateENT.BrowseCount = objPubClassCaseFreeSenateENS.BrowseCount; //浏览次数
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
 /// <param name = "objPubClassCaseFreeSenateEN">源简化对象</param>
 public static void SetUpdFlag(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
try
{
objPubClassCaseFreeSenateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPubClassCaseFreeSenateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate; //公开课案例自由评议流水号
}
if (arrFldSet.Contains(conPubClassCaseFreeSenate.IdPubClassCase, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseFreeSenateEN.IdPubClassCase = objPubClassCaseFreeSenateEN.IdPubClassCase; //案例流水号
}
if (arrFldSet.Contains(conPubClassCaseFreeSenate.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseFreeSenateEN.UserId = objPubClassCaseFreeSenateEN.UserId; //用户ID
}
if (arrFldSet.Contains(conPubClassCaseFreeSenate.AppraiseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseFreeSenateEN.AppraiseTheme = objPubClassCaseFreeSenateEN.AppraiseTheme == "[null]" ? null :  objPubClassCaseFreeSenateEN.AppraiseTheme; //评议主题
}
if (arrFldSet.Contains(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle == "[null]" ? null :  objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle; //公开课案例自由评议标题
}
if (arrFldSet.Contains(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten == "[null]" ? null :  objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten; //公开课案例自由评议内容
}
if (arrFldSet.Contains(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate == "[null]" ? null :  objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate; //公开课案例自由评议日期
}
if (arrFldSet.Contains(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime == "[null]" ? null :  objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime; //公开课案例自由评议时间
}
if (arrFldSet.Contains(conPubClassCaseFreeSenate.VideoStopTime, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseFreeSenateEN.VideoStopTime = objPubClassCaseFreeSenateEN.VideoStopTime == "[null]" ? null :  objPubClassCaseFreeSenateEN.VideoStopTime; //公开课案例视频暂停时间
}
if (arrFldSet.Contains(conPubClassCaseFreeSenate.VideoStopImage, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseFreeSenateEN.VideoStopImage = objPubClassCaseFreeSenateEN.VideoStopImage; //公开课案例视频暂停截图
}
if (arrFldSet.Contains(conPubClassCaseFreeSenate.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseFreeSenateEN.BrowseCount = objPubClassCaseFreeSenateEN.BrowseCount; //浏览次数
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
 /// <param name = "objPubClassCaseFreeSenateEN">源简化对象</param>
 public static void AccessFldValueNull(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
try
{
if (objPubClassCaseFreeSenateEN.AppraiseTheme == "[null]") objPubClassCaseFreeSenateEN.AppraiseTheme = null; //评议主题
if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle == "[null]") objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = null; //公开课案例自由评议标题
if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten == "[null]") objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = null; //公开课案例自由评议内容
if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate == "[null]") objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = null; //公开课案例自由评议日期
if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime == "[null]") objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = null; //公开课案例自由评议时间
if (objPubClassCaseFreeSenateEN.VideoStopTime == "[null]") objPubClassCaseFreeSenateEN.VideoStopTime = null; //公开课案例视频暂停时间
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
public static void CheckPropertyNew(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
 PubClassCaseFreeSenateDA.CheckPropertyNew(objPubClassCaseFreeSenateEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
 PubClassCaseFreeSenateDA.CheckProperty4Condition(objPubClassCaseFreeSenateEN);
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
if (clsPubClassCaseFreeSenateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseFreeSenateBL没有刷新缓存机制(clsPubClassCaseFreeSenateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdPubClassCaseFreeSenate");
//if (arrPubClassCaseFreeSenateObjLstCache == null)
//{
//arrPubClassCaseFreeSenateObjLstCache = PubClassCaseFreeSenateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdPubClassCaseFreeSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPubClassCaseFreeSenateEN GetObjByIdPubClassCaseFreeSenateCache(long lngIdPubClassCaseFreeSenate)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPubClassCaseFreeSenateEN._CurrTabName);
List<clsPubClassCaseFreeSenateEN> arrPubClassCaseFreeSenateObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseFreeSenateEN> arrPubClassCaseFreeSenateObjLst_Sel =
arrPubClassCaseFreeSenateObjLstCache
.Where(x=> x.IdPubClassCaseFreeSenate == lngIdPubClassCaseFreeSenate 
);
if (arrPubClassCaseFreeSenateObjLst_Sel.Count() == 0)
{
   clsPubClassCaseFreeSenateEN obj = clsPubClassCaseFreeSenateBL.GetObjByIdPubClassCaseFreeSenate(lngIdPubClassCaseFreeSenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPubClassCaseFreeSenateObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPubClassCaseFreeSenateEN> GetAllPubClassCaseFreeSenateObjLstCache()
{
//获取缓存中的对象列表
List<clsPubClassCaseFreeSenateEN> arrPubClassCaseFreeSenateObjLstCache = GetObjLstCache(); 
return arrPubClassCaseFreeSenateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPubClassCaseFreeSenateEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPubClassCaseFreeSenateEN._CurrTabName);
List<clsPubClassCaseFreeSenateEN> arrPubClassCaseFreeSenateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPubClassCaseFreeSenateObjLstCache;
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
string strKey = string.Format("{0}", clsPubClassCaseFreeSenateEN._CurrTabName);
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
if (clsPubClassCaseFreeSenateBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPubClassCaseFreeSenateEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPubClassCaseFreeSenateBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PubClassCaseFreeSenate(公开课案例自由评议)
 /// 唯一性条件:id_PubClassCase_UserId_AppraiseTheme
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
//检测记录是否存在
string strResult = PubClassCaseFreeSenateDA.GetUniCondStr(objPubClassCaseFreeSenateEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdPubClassCaseFreeSenate)
{
if (strInFldName != conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPubClassCaseFreeSenate.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPubClassCaseFreeSenate.AttributeName));
throw new Exception(strMsg);
}
var objPubClassCaseFreeSenate = clsPubClassCaseFreeSenateBL.GetObjByIdPubClassCaseFreeSenateCache(lngIdPubClassCaseFreeSenate);
if (objPubClassCaseFreeSenate == null) return "";
return objPubClassCaseFreeSenate[strOutFldName].ToString();
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
int intRecCount = clsPubClassCaseFreeSenateDA.GetRecCount(strTabName);
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
int intRecCount = clsPubClassCaseFreeSenateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPubClassCaseFreeSenateDA.GetRecCount();
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
int intRecCount = clsPubClassCaseFreeSenateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateCond)
{
List<clsPubClassCaseFreeSenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseFreeSenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPubClassCaseFreeSenate.AttributeName)
{
if (objPubClassCaseFreeSenateCond.IsUpdated(strFldName) == false) continue;
if (objPubClassCaseFreeSenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseFreeSenateCond[strFldName].ToString());
}
else
{
if (objPubClassCaseFreeSenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPubClassCaseFreeSenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseFreeSenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPubClassCaseFreeSenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPubClassCaseFreeSenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPubClassCaseFreeSenateCond[strFldName]));
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
 List<string> arrList = clsPubClassCaseFreeSenateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PubClassCaseFreeSenateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PubClassCaseFreeSenateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PubClassCaseFreeSenateDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPubClassCaseFreeSenateDA.SetFldValue(clsPubClassCaseFreeSenateEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PubClassCaseFreeSenateDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPubClassCaseFreeSenateDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPubClassCaseFreeSenateDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPubClassCaseFreeSenateDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PubClassCaseFreeSenate] "); 
 strCreateTabCode.Append(" ( "); 
 // /**公开课案例自由评议流水号*/ 
 strCreateTabCode.Append(" IdPubClassCaseFreeSenate bigint primary key identity, "); 
 // /**案例流水号*/ 
 strCreateTabCode.Append(" IdPubClassCase char(8) not Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**评议主题*/ 
 strCreateTabCode.Append(" AppraiseTheme varchar(200) Null, "); 
 // /**公开课案例自由评议标题*/ 
 strCreateTabCode.Append(" PubClassCaseFreeSenateTitle varchar(200) Null, "); 
 // /**公开课案例自由评议内容*/ 
 strCreateTabCode.Append(" PubClassCaseFreeSenateConten varchar(2000) Null, "); 
 // /**公开课案例自由评议日期*/ 
 strCreateTabCode.Append(" PubClassCaseFreeSenateDate char(8) Null, "); 
 // /**公开课案例自由评议时间*/ 
 strCreateTabCode.Append(" PubClassCaseFreeSenateTime char(6) Null, "); 
 // /**公开课案例视频暂停时间*/ 
 strCreateTabCode.Append(" VideoStopTime varchar(48) Null, "); 
 // /**公开课案例视频暂停截图*/ 
 strCreateTabCode.Append(" VideoStopImage image Null, "); 
 // /**浏览次数*/ 
 strCreateTabCode.Append(" BrowseCount int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 公开课案例自由评议(PubClassCaseFreeSenate)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PubClassCaseFreeSenate : clsCommFun4BL
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
clsPubClassCaseFreeSenateBL.ReFreshThisCache();
}
}

}