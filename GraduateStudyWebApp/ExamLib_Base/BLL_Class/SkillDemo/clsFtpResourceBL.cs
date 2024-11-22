﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFtpResourceBL
 表名:FtpResource(01120326)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
public static class  clsFtpResourceBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdFtpResource">表关键字</param>
 /// <returns>表对象</returns>
public static clsFtpResourceEN GetObj(this K_IdFtpResource_FtpResource myKey)
{
clsFtpResourceEN objFtpResourceEN = clsFtpResourceBL.FtpResourceDA.GetObjByIdFtpResource(myKey.Value);
return objFtpResourceEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFtpResourceEN objFtpResourceEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objFtpResourceEN.IdFtpResource) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFtpResourceBL.IsExist(objFtpResourceEN.IdFtpResource) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFtpResourceEN.IdFtpResource, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsFtpResourceBL.FtpResourceDA.AddNewRecordBySQL2(objFtpResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceBL.ReFreshCache();

if (clsFtpResourceBL.relatedActions != null)
{
clsFtpResourceBL.relatedActions.UpdRelaTabDate(objFtpResourceEN.IdFtpResource, "SetUpdDate");
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
public static bool AddRecordEx(this clsFtpResourceEN objFtpResourceEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsFtpResourceBL.IsExist(objFtpResourceEN.IdFtpResource))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objFtpResourceEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objFtpResourceEN.AddNewRecord();
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
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFtpResourceEN objFtpResourceEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objFtpResourceEN.IdFtpResource) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFtpResourceBL.IsExist(objFtpResourceEN.IdFtpResource) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFtpResourceEN.IdFtpResource, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsFtpResourceBL.FtpResourceDA.AddNewRecordBySQL2WithReturnKey(objFtpResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceBL.ReFreshCache();

if (clsFtpResourceBL.relatedActions != null)
{
clsFtpResourceBL.relatedActions.UpdRelaTabDate(objFtpResourceEN.IdFtpResource, "SetUpdDate");
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
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetIdFtpResource(this clsFtpResourceEN objFtpResourceEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, conFtpResource.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, conFtpResource.IdFtpResource);
}
objFtpResourceEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.IdFtpResource) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.IdFtpResource, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.IdFtpResource] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetFtpResourceID(this clsFtpResourceEN objFtpResourceEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, conFtpResource.FtpResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, conFtpResource.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, conFtpResource.FtpResourceID);
}
objFtpResourceEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FtpResourceID) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FtpResourceID, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FtpResourceID] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetFileOriginalName(this clsFtpResourceEN objFtpResourceEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, conFtpResource.FileOriginalName);
}
objFtpResourceEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileOriginalName) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileOriginalName, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileOriginalName] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetFileDirName(this clsFtpResourceEN objFtpResourceEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, conFtpResource.FileDirName);
}
objFtpResourceEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileDirName) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileDirName, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileDirName] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetFileRename(this clsFtpResourceEN objFtpResourceEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, conFtpResource.FileRename);
}
objFtpResourceEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileRename) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileRename, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileRename] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetFileUpDate(this clsFtpResourceEN objFtpResourceEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, conFtpResource.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, conFtpResource.FileUpDate);
}
objFtpResourceEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileUpDate) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileUpDate, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileUpDate] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetFileUpTime(this clsFtpResourceEN objFtpResourceEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, conFtpResource.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, conFtpResource.FileUpTime);
}
objFtpResourceEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileUpTime) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileUpTime, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileUpTime] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetMemo(this clsFtpResourceEN objFtpResourceEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFtpResource.Memo);
}
objFtpResourceEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.Memo) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.Memo, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.Memo] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetFileSize(this clsFtpResourceEN objFtpResourceEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, conFtpResource.FileSize);
}
objFtpResourceEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileSize) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileSize, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileSize] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetFileType(this clsFtpResourceEN objFtpResourceEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, conFtpResource.FileType);
}
objFtpResourceEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileType) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileType, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileType] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetCheckDateTime(this clsFtpResourceEN objFtpResourceEN, string strCheckDateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckDateTime, 30, conFtpResource.CheckDateTime);
}
objFtpResourceEN.CheckDateTime = strCheckDateTime; //CheckDateTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.CheckDateTime) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.CheckDateTime, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.CheckDateTime] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetResourceOwner(this clsFtpResourceEN objFtpResourceEN, string strResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, conFtpResource.ResourceOwner);
}
objFtpResourceEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.ResourceOwner) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.ResourceOwner, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.ResourceOwner] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetIsExistFile(this clsFtpResourceEN objFtpResourceEN, bool bolIsExistFile, string strComparisonOp="")
	{
objFtpResourceEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.IsExistFile) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.IsExistFile, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.IsExistFile] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetFuncModuleId(this clsFtpResourceEN objFtpResourceEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conFtpResource.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conFtpResource.FuncModuleId);
}
objFtpResourceEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FuncModuleId) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FuncModuleId, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FuncModuleId] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetFileResourceID(this clsFtpResourceEN objFtpResourceEN, long lngFileResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngFileResourceID, conFtpResource.FileResourceID);
objFtpResourceEN.FileResourceID = lngFileResourceID; //FileResourceID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileResourceID) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileResourceID, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileResourceID] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetFileNameBak(this clsFtpResourceEN objFtpResourceEN, string strFileNameBak, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNameBak, 500, conFtpResource.FileNameBak);
}
objFtpResourceEN.FileNameBak = strFileNameBak; //FileName_Bak
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileNameBak) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileNameBak, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileNameBak] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetUpdDate(this clsFtpResourceEN objFtpResourceEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFtpResource.UpdDate);
}
objFtpResourceEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.UpdDate) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.UpdDate, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.UpdDate] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFtpResourceEN SetUpdUser(this clsFtpResourceEN objFtpResourceEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFtpResource.UpdUser);
}
objFtpResourceEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.UpdUser) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.UpdUser, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.UpdUser] = strComparisonOp;
}
}
return objFtpResourceEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFtpResourceEN objFtpResourceEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFtpResourceEN.CheckPropertyNew();
clsFtpResourceEN objFtpResourceCond = new clsFtpResourceEN();
string strCondition = objFtpResourceCond
.SetIdFtpResource(objFtpResourceEN.IdFtpResource, "=")
.GetCombineCondition();
objFtpResourceEN._IsCheckProperty = true;
bool bolIsExist = clsFtpResourceBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFtpResourceEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFtpResourceEN objFtpResourceEN)
{
 if (string.IsNullOrEmpty(objFtpResourceEN.IdFtpResource) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFtpResourceBL.FtpResourceDA.UpdateBySql2(objFtpResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceBL.ReFreshCache();

if (clsFtpResourceBL.relatedActions != null)
{
clsFtpResourceBL.relatedActions.UpdRelaTabDate(objFtpResourceEN.IdFtpResource, "SetUpdDate");
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
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFtpResourceEN objFtpResourceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objFtpResourceEN.IdFtpResource) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFtpResourceBL.FtpResourceDA.UpdateBySql2(objFtpResourceEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceBL.ReFreshCache();

if (clsFtpResourceBL.relatedActions != null)
{
clsFtpResourceBL.relatedActions.UpdRelaTabDate(objFtpResourceEN.IdFtpResource, "SetUpdDate");
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
 /// <param name = "objFtpResourceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFtpResourceEN objFtpResourceEN, string strWhereCond)
{
try
{
bool bolResult = clsFtpResourceBL.FtpResourceDA.UpdateBySqlWithCondition(objFtpResourceEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceBL.ReFreshCache();

if (clsFtpResourceBL.relatedActions != null)
{
clsFtpResourceBL.relatedActions.UpdRelaTabDate(objFtpResourceEN.IdFtpResource, "SetUpdDate");
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
 /// <param name = "objFtpResourceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFtpResourceEN objFtpResourceEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFtpResourceBL.FtpResourceDA.UpdateBySqlWithConditionTransaction(objFtpResourceEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceBL.ReFreshCache();

if (clsFtpResourceBL.relatedActions != null)
{
clsFtpResourceBL.relatedActions.UpdRelaTabDate(objFtpResourceEN.IdFtpResource, "SetUpdDate");
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
 /// <param name = "strIdFtpResource">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFtpResourceEN objFtpResourceEN)
{
try
{
int intRecNum = clsFtpResourceBL.FtpResourceDA.DelRecord(objFtpResourceEN.IdFtpResource);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceBL.ReFreshCache();

if (clsFtpResourceBL.relatedActions != null)
{
clsFtpResourceBL.relatedActions.UpdRelaTabDate(objFtpResourceEN.IdFtpResource, "SetUpdDate");
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
 /// <param name = "objFtpResourceENS">源对象</param>
 /// <param name = "objFtpResourceENT">目标对象</param>
 public static void CopyTo(this clsFtpResourceEN objFtpResourceENS, clsFtpResourceEN objFtpResourceENT)
{
try
{
objFtpResourceENT.IdFtpResource = objFtpResourceENS.IdFtpResource; //FTP资源流水号
objFtpResourceENT.FtpResourceID = objFtpResourceENS.FtpResourceID; //FTP资源ID
objFtpResourceENT.FileOriginalName = objFtpResourceENS.FileOriginalName; //文件原名
objFtpResourceENT.FileDirName = objFtpResourceENS.FileDirName; //文件目录名
objFtpResourceENT.FileRename = objFtpResourceENS.FileRename; //文件新名
objFtpResourceENT.FileUpDate = objFtpResourceENS.FileUpDate; //创建日期
objFtpResourceENT.FileUpTime = objFtpResourceENS.FileUpTime; //创建时间
objFtpResourceENT.Memo = objFtpResourceENS.Memo; //备注
objFtpResourceENT.FileSize = objFtpResourceENS.FileSize; //文件大小
objFtpResourceENT.FileType = objFtpResourceENS.FileType; //文件类型
objFtpResourceENT.CheckDateTime = objFtpResourceENS.CheckDateTime; //CheckDateTime
objFtpResourceENT.ResourceOwner = objFtpResourceENS.ResourceOwner; //上传者
objFtpResourceENT.IsExistFile = objFtpResourceENS.IsExistFile; //是否存在文件
objFtpResourceENT.FuncModuleId = objFtpResourceENS.FuncModuleId; //功能模块Id
objFtpResourceENT.FileResourceID = objFtpResourceENS.FileResourceID; //FileResourceID
objFtpResourceENT.FileNameBak = objFtpResourceENS.FileNameBak; //FileName_Bak
objFtpResourceENT.UpdDate = objFtpResourceENS.UpdDate; //修改日期
objFtpResourceENT.UpdUser = objFtpResourceENS.UpdUser; //修改人
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
 /// <param name = "objFtpResourceENS">源对象</param>
 /// <returns>目标对象=>clsFtpResourceEN:objFtpResourceENT</returns>
 public static clsFtpResourceEN CopyTo(this clsFtpResourceEN objFtpResourceENS)
{
try
{
 clsFtpResourceEN objFtpResourceENT = new clsFtpResourceEN()
{
IdFtpResource = objFtpResourceENS.IdFtpResource, //FTP资源流水号
FtpResourceID = objFtpResourceENS.FtpResourceID, //FTP资源ID
FileOriginalName = objFtpResourceENS.FileOriginalName, //文件原名
FileDirName = objFtpResourceENS.FileDirName, //文件目录名
FileRename = objFtpResourceENS.FileRename, //文件新名
FileUpDate = objFtpResourceENS.FileUpDate, //创建日期
FileUpTime = objFtpResourceENS.FileUpTime, //创建时间
Memo = objFtpResourceENS.Memo, //备注
FileSize = objFtpResourceENS.FileSize, //文件大小
FileType = objFtpResourceENS.FileType, //文件类型
CheckDateTime = objFtpResourceENS.CheckDateTime, //CheckDateTime
ResourceOwner = objFtpResourceENS.ResourceOwner, //上传者
IsExistFile = objFtpResourceENS.IsExistFile, //是否存在文件
FuncModuleId = objFtpResourceENS.FuncModuleId, //功能模块Id
FileResourceID = objFtpResourceENS.FileResourceID, //FileResourceID
FileNameBak = objFtpResourceENS.FileNameBak, //FileName_Bak
UpdDate = objFtpResourceENS.UpdDate, //修改日期
UpdUser = objFtpResourceENS.UpdUser, //修改人
};
 return objFtpResourceENT;
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
public static void CheckPropertyNew(this clsFtpResourceEN objFtpResourceEN)
{
 clsFtpResourceBL.FtpResourceDA.CheckPropertyNew(objFtpResourceEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFtpResourceEN objFtpResourceEN)
{
 clsFtpResourceBL.FtpResourceDA.CheckProperty4Condition(objFtpResourceEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFtpResourceEN objFtpResourceCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFtpResourceCond.IsUpdated(conFtpResource.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objFtpResourceCond.dicFldComparisonOp[conFtpResource.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.IdFtpResource, objFtpResourceCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objFtpResourceCond.dicFldComparisonOp[conFtpResource.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FtpResourceID, objFtpResourceCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objFtpResourceCond.dicFldComparisonOp[conFtpResource.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FileOriginalName, objFtpResourceCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.FileDirName) == true)
{
string strComparisonOpFileDirName = objFtpResourceCond.dicFldComparisonOp[conFtpResource.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FileDirName, objFtpResourceCond.FileDirName, strComparisonOpFileDirName);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.FileRename) == true)
{
string strComparisonOpFileRename = objFtpResourceCond.dicFldComparisonOp[conFtpResource.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FileRename, objFtpResourceCond.FileRename, strComparisonOpFileRename);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objFtpResourceCond.dicFldComparisonOp[conFtpResource.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FileUpDate, objFtpResourceCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objFtpResourceCond.dicFldComparisonOp[conFtpResource.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FileUpTime, objFtpResourceCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.Memo) == true)
{
string strComparisonOpMemo = objFtpResourceCond.dicFldComparisonOp[conFtpResource.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.Memo, objFtpResourceCond.Memo, strComparisonOpMemo);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.FileSize) == true)
{
string strComparisonOpFileSize = objFtpResourceCond.dicFldComparisonOp[conFtpResource.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FileSize, objFtpResourceCond.FileSize, strComparisonOpFileSize);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.FileType) == true)
{
string strComparisonOpFileType = objFtpResourceCond.dicFldComparisonOp[conFtpResource.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FileType, objFtpResourceCond.FileType, strComparisonOpFileType);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.CheckDateTime) == true)
{
string strComparisonOpCheckDateTime = objFtpResourceCond.dicFldComparisonOp[conFtpResource.CheckDateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.CheckDateTime, objFtpResourceCond.CheckDateTime, strComparisonOpCheckDateTime);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objFtpResourceCond.dicFldComparisonOp[conFtpResource.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.ResourceOwner, objFtpResourceCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.IsExistFile) == true)
{
if (objFtpResourceCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFtpResource.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFtpResource.IsExistFile);
}
}
if (objFtpResourceCond.IsUpdated(conFtpResource.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objFtpResourceCond.dicFldComparisonOp[conFtpResource.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FuncModuleId, objFtpResourceCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.FileResourceID) == true)
{
string strComparisonOpFileResourceID = objFtpResourceCond.dicFldComparisonOp[conFtpResource.FileResourceID];
strWhereCond += string.Format(" And {0} {2} {1}", conFtpResource.FileResourceID, objFtpResourceCond.FileResourceID, strComparisonOpFileResourceID);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.FileNameBak) == true)
{
string strComparisonOpFileNameBak = objFtpResourceCond.dicFldComparisonOp[conFtpResource.FileNameBak];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FileNameBak, objFtpResourceCond.FileNameBak, strComparisonOpFileNameBak);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.UpdDate) == true)
{
string strComparisonOpUpdDate = objFtpResourceCond.dicFldComparisonOp[conFtpResource.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.UpdDate, objFtpResourceCond.UpdDate, strComparisonOpUpdDate);
}
if (objFtpResourceCond.IsUpdated(conFtpResource.UpdUser) == true)
{
string strComparisonOpUpdUser = objFtpResourceCond.dicFldComparisonOp[conFtpResource.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.UpdUser, objFtpResourceCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FtpResource
{
public virtual bool UpdRelaTabDate(string strIdFtpResource, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// FTP资源(FtpResource)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFtpResourceBL
{
public static RelatedActions_FtpResource relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFtpResourceDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFtpResourceDA FtpResourceDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFtpResourceDA();
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
 public clsFtpResourceBL()
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
if (string.IsNullOrEmpty(clsFtpResourceEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFtpResourceEN._ConnectString);
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
public static DataTable GetDataTable_FtpResource(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FtpResourceDA.GetDataTable_FtpResource(strWhereCond);
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
objDT = FtpResourceDA.GetDataTable(strWhereCond);
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
objDT = FtpResourceDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FtpResourceDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FtpResourceDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FtpResourceDA.GetDataTable_Top(objTopPara);
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
objDT = FtpResourceDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FtpResourceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FtpResourceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdFtpResourceLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFtpResourceEN> GetObjLstByIdFtpResourceLst(List<string> arrIdFtpResourceLst)
{
List<clsFtpResourceEN> arrObjLst = new List<clsFtpResourceEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdFtpResourceLst, true);
 string strWhereCond = string.Format("IdFtpResource in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //备注
objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? null : objRow[conFtpResource.FileSize].ToString().Trim(); //文件大小
objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objFtpResourceEN.CheckDateTime = objRow[conFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[conFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //上传者
objFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objFtpResourceEN.FuncModuleId = objRow[conFtpResource.FuncModuleId] == DBNull.Value ? null : objRow[conFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objFtpResourceEN.FileResourceID = Int32.Parse(objRow[conFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objFtpResourceEN.FileNameBak = objRow[conFtpResource.FileNameBak] == DBNull.Value ? null : objRow[conFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objFtpResourceEN.UpdDate = objRow[conFtpResource.UpdDate] == DBNull.Value ? null : objRow[conFtpResource.UpdDate].ToString().Trim(); //修改日期
objFtpResourceEN.UpdUser = objRow[conFtpResource.UpdUser] == DBNull.Value ? null : objRow[conFtpResource.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFtpResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdFtpResourceLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFtpResourceEN> GetObjLstByIdFtpResourceLstCache(List<string> arrIdFtpResourceLst)
{
string strKey = string.Format("{0}", clsFtpResourceEN._CurrTabName);
List<clsFtpResourceEN> arrFtpResourceObjLstCache = GetObjLstCache();
IEnumerable <clsFtpResourceEN> arrFtpResourceObjLst_Sel =
arrFtpResourceObjLstCache
.Where(x => arrIdFtpResourceLst.Contains(x.IdFtpResource));
return arrFtpResourceObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFtpResourceEN> GetObjLst(string strWhereCond)
{
List<clsFtpResourceEN> arrObjLst = new List<clsFtpResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //备注
objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? null : objRow[conFtpResource.FileSize].ToString().Trim(); //文件大小
objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objFtpResourceEN.CheckDateTime = objRow[conFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[conFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //上传者
objFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objFtpResourceEN.FuncModuleId = objRow[conFtpResource.FuncModuleId] == DBNull.Value ? null : objRow[conFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objFtpResourceEN.FileResourceID = Int32.Parse(objRow[conFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objFtpResourceEN.FileNameBak = objRow[conFtpResource.FileNameBak] == DBNull.Value ? null : objRow[conFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objFtpResourceEN.UpdDate = objRow[conFtpResource.UpdDate] == DBNull.Value ? null : objRow[conFtpResource.UpdDate].ToString().Trim(); //修改日期
objFtpResourceEN.UpdUser = objRow[conFtpResource.UpdUser] == DBNull.Value ? null : objRow[conFtpResource.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFtpResourceEN);
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
public static List<clsFtpResourceEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFtpResourceEN> arrObjLst = new List<clsFtpResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //备注
objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? null : objRow[conFtpResource.FileSize].ToString().Trim(); //文件大小
objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objFtpResourceEN.CheckDateTime = objRow[conFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[conFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //上传者
objFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objFtpResourceEN.FuncModuleId = objRow[conFtpResource.FuncModuleId] == DBNull.Value ? null : objRow[conFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objFtpResourceEN.FileResourceID = Int32.Parse(objRow[conFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objFtpResourceEN.FileNameBak = objRow[conFtpResource.FileNameBak] == DBNull.Value ? null : objRow[conFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objFtpResourceEN.UpdDate = objRow[conFtpResource.UpdDate] == DBNull.Value ? null : objRow[conFtpResource.UpdDate].ToString().Trim(); //修改日期
objFtpResourceEN.UpdUser = objRow[conFtpResource.UpdUser] == DBNull.Value ? null : objRow[conFtpResource.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFtpResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFtpResourceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFtpResourceEN> GetSubObjLstCache(clsFtpResourceEN objFtpResourceCond)
{
List<clsFtpResourceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFtpResourceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFtpResource.AttributeName)
{
if (objFtpResourceCond.IsUpdated(strFldName) == false) continue;
if (objFtpResourceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFtpResourceCond[strFldName].ToString());
}
else
{
if (objFtpResourceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFtpResourceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFtpResourceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFtpResourceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFtpResourceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFtpResourceCond[strFldName]));
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
public static List<clsFtpResourceEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFtpResourceEN> arrObjLst = new List<clsFtpResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //备注
objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? null : objRow[conFtpResource.FileSize].ToString().Trim(); //文件大小
objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objFtpResourceEN.CheckDateTime = objRow[conFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[conFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //上传者
objFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objFtpResourceEN.FuncModuleId = objRow[conFtpResource.FuncModuleId] == DBNull.Value ? null : objRow[conFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objFtpResourceEN.FileResourceID = Int32.Parse(objRow[conFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objFtpResourceEN.FileNameBak = objRow[conFtpResource.FileNameBak] == DBNull.Value ? null : objRow[conFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objFtpResourceEN.UpdDate = objRow[conFtpResource.UpdDate] == DBNull.Value ? null : objRow[conFtpResource.UpdDate].ToString().Trim(); //修改日期
objFtpResourceEN.UpdUser = objRow[conFtpResource.UpdUser] == DBNull.Value ? null : objRow[conFtpResource.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFtpResourceEN);
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
public static List<clsFtpResourceEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFtpResourceEN> arrObjLst = new List<clsFtpResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //备注
objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? null : objRow[conFtpResource.FileSize].ToString().Trim(); //文件大小
objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objFtpResourceEN.CheckDateTime = objRow[conFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[conFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //上传者
objFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objFtpResourceEN.FuncModuleId = objRow[conFtpResource.FuncModuleId] == DBNull.Value ? null : objRow[conFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objFtpResourceEN.FileResourceID = Int32.Parse(objRow[conFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objFtpResourceEN.FileNameBak = objRow[conFtpResource.FileNameBak] == DBNull.Value ? null : objRow[conFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objFtpResourceEN.UpdDate = objRow[conFtpResource.UpdDate] == DBNull.Value ? null : objRow[conFtpResource.UpdDate].ToString().Trim(); //修改日期
objFtpResourceEN.UpdUser = objRow[conFtpResource.UpdUser] == DBNull.Value ? null : objRow[conFtpResource.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFtpResourceEN);
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
List<clsFtpResourceEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFtpResourceEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFtpResourceEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFtpResourceEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFtpResourceEN> arrObjLst = new List<clsFtpResourceEN>(); 
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
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //备注
objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? null : objRow[conFtpResource.FileSize].ToString().Trim(); //文件大小
objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objFtpResourceEN.CheckDateTime = objRow[conFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[conFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //上传者
objFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objFtpResourceEN.FuncModuleId = objRow[conFtpResource.FuncModuleId] == DBNull.Value ? null : objRow[conFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objFtpResourceEN.FileResourceID = Int32.Parse(objRow[conFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objFtpResourceEN.FileNameBak = objRow[conFtpResource.FileNameBak] == DBNull.Value ? null : objRow[conFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objFtpResourceEN.UpdDate = objRow[conFtpResource.UpdDate] == DBNull.Value ? null : objRow[conFtpResource.UpdDate].ToString().Trim(); //修改日期
objFtpResourceEN.UpdUser = objRow[conFtpResource.UpdUser] == DBNull.Value ? null : objRow[conFtpResource.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFtpResourceEN);
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
public static List<clsFtpResourceEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFtpResourceEN> arrObjLst = new List<clsFtpResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //备注
objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? null : objRow[conFtpResource.FileSize].ToString().Trim(); //文件大小
objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objFtpResourceEN.CheckDateTime = objRow[conFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[conFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //上传者
objFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objFtpResourceEN.FuncModuleId = objRow[conFtpResource.FuncModuleId] == DBNull.Value ? null : objRow[conFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objFtpResourceEN.FileResourceID = Int32.Parse(objRow[conFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objFtpResourceEN.FileNameBak = objRow[conFtpResource.FileNameBak] == DBNull.Value ? null : objRow[conFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objFtpResourceEN.UpdDate = objRow[conFtpResource.UpdDate] == DBNull.Value ? null : objRow[conFtpResource.UpdDate].ToString().Trim(); //修改日期
objFtpResourceEN.UpdUser = objRow[conFtpResource.UpdUser] == DBNull.Value ? null : objRow[conFtpResource.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFtpResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFtpResourceEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFtpResourceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFtpResourceEN> arrObjLst = new List<clsFtpResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //备注
objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? null : objRow[conFtpResource.FileSize].ToString().Trim(); //文件大小
objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objFtpResourceEN.CheckDateTime = objRow[conFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[conFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //上传者
objFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objFtpResourceEN.FuncModuleId = objRow[conFtpResource.FuncModuleId] == DBNull.Value ? null : objRow[conFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objFtpResourceEN.FileResourceID = Int32.Parse(objRow[conFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objFtpResourceEN.FileNameBak = objRow[conFtpResource.FileNameBak] == DBNull.Value ? null : objRow[conFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objFtpResourceEN.UpdDate = objRow[conFtpResource.UpdDate] == DBNull.Value ? null : objRow[conFtpResource.UpdDate].ToString().Trim(); //修改日期
objFtpResourceEN.UpdUser = objRow[conFtpResource.UpdUser] == DBNull.Value ? null : objRow[conFtpResource.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFtpResourceEN);
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
public static List<clsFtpResourceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFtpResourceEN> arrObjLst = new List<clsFtpResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //备注
objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? null : objRow[conFtpResource.FileSize].ToString().Trim(); //文件大小
objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objFtpResourceEN.CheckDateTime = objRow[conFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[conFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //上传者
objFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objFtpResourceEN.FuncModuleId = objRow[conFtpResource.FuncModuleId] == DBNull.Value ? null : objRow[conFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objFtpResourceEN.FileResourceID = Int32.Parse(objRow[conFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objFtpResourceEN.FileNameBak = objRow[conFtpResource.FileNameBak] == DBNull.Value ? null : objRow[conFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objFtpResourceEN.UpdDate = objRow[conFtpResource.UpdDate] == DBNull.Value ? null : objRow[conFtpResource.UpdDate].ToString().Trim(); //修改日期
objFtpResourceEN.UpdUser = objRow[conFtpResource.UpdUser] == DBNull.Value ? null : objRow[conFtpResource.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFtpResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFtpResourceEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFtpResourceEN> arrObjLst = new List<clsFtpResourceEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //备注
objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? null : objRow[conFtpResource.FileSize].ToString().Trim(); //文件大小
objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objFtpResourceEN.CheckDateTime = objRow[conFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[conFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //上传者
objFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objFtpResourceEN.FuncModuleId = objRow[conFtpResource.FuncModuleId] == DBNull.Value ? null : objRow[conFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objFtpResourceEN.FileResourceID = Int32.Parse(objRow[conFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objFtpResourceEN.FileNameBak = objRow[conFtpResource.FileNameBak] == DBNull.Value ? null : objRow[conFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objFtpResourceEN.UpdDate = objRow[conFtpResource.UpdDate] == DBNull.Value ? null : objRow[conFtpResource.UpdDate].ToString().Trim(); //修改日期
objFtpResourceEN.UpdUser = objRow[conFtpResource.UpdUser] == DBNull.Value ? null : objRow[conFtpResource.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFtpResourceEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFtpResourceEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFtpResource(ref clsFtpResourceEN objFtpResourceEN)
{
bool bolResult = FtpResourceDA.GetFtpResource(ref objFtpResourceEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdFtpResource">表关键字</param>
 /// <returns>表对象</returns>
public static clsFtpResourceEN GetObjByIdFtpResource(string strIdFtpResource)
{
if (strIdFtpResource.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdFtpResource]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdFtpResource) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdFtpResource]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsFtpResourceEN objFtpResourceEN = FtpResourceDA.GetObjByIdFtpResource(strIdFtpResource);
return objFtpResourceEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFtpResourceEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFtpResourceEN objFtpResourceEN = FtpResourceDA.GetFirstObj(strWhereCond);
 return objFtpResourceEN;
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
public static clsFtpResourceEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFtpResourceEN objFtpResourceEN = FtpResourceDA.GetObjByDataRow(objRow);
 return objFtpResourceEN;
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
public static clsFtpResourceEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFtpResourceEN objFtpResourceEN = FtpResourceDA.GetObjByDataRow(objRow);
 return objFtpResourceEN;
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
 /// <param name = "strIdFtpResource">所给的关键字</param>
 /// <param name = "lstFtpResourceObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFtpResourceEN GetObjByIdFtpResourceFromList(string strIdFtpResource, List<clsFtpResourceEN> lstFtpResourceObjLst)
{
foreach (clsFtpResourceEN objFtpResourceEN in lstFtpResourceObjLst)
{
if (objFtpResourceEN.IdFtpResource == strIdFtpResource)
{
return objFtpResourceEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdFtpResource;
 try
 {
 strIdFtpResource = new clsFtpResourceDA().GetFirstID(strWhereCond);
 return strIdFtpResource;
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
 arrList = FtpResourceDA.GetID(strWhereCond);
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
bool bolIsExist = FtpResourceDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdFtpResource">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdFtpResource)
{
if (string.IsNullOrEmpty(strIdFtpResource) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdFtpResource]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = FtpResourceDA.IsExist(strIdFtpResource);
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
 bolIsExist = clsFtpResourceDA.IsExistTable();
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
 bolIsExist = FtpResourceDA.IsExistTable(strTabName);
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
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFtpResourceEN objFtpResourceEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objFtpResourceEN.IdFtpResource) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFtpResourceBL.IsExist(objFtpResourceEN.IdFtpResource) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFtpResourceEN.IdFtpResource, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = FtpResourceDA.AddNewRecordBySQL2(objFtpResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceBL.ReFreshCache();

if (clsFtpResourceBL.relatedActions != null)
{
clsFtpResourceBL.relatedActions.UpdRelaTabDate(objFtpResourceEN.IdFtpResource, "SetUpdDate");
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
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFtpResourceEN objFtpResourceEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objFtpResourceEN.IdFtpResource) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFtpResourceBL.IsExist(objFtpResourceEN.IdFtpResource) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFtpResourceEN.IdFtpResource, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = FtpResourceDA.AddNewRecordBySQL2WithReturnKey(objFtpResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceBL.ReFreshCache();

if (clsFtpResourceBL.relatedActions != null)
{
clsFtpResourceBL.relatedActions.UpdRelaTabDate(objFtpResourceEN.IdFtpResource, "SetUpdDate");
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
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFtpResourceEN objFtpResourceEN)
{
try
{
bool bolResult = FtpResourceDA.Update(objFtpResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceBL.ReFreshCache();

if (clsFtpResourceBL.relatedActions != null)
{
clsFtpResourceBL.relatedActions.UpdRelaTabDate(objFtpResourceEN.IdFtpResource, "SetUpdDate");
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
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFtpResourceEN objFtpResourceEN)
{
 if (string.IsNullOrEmpty(objFtpResourceEN.IdFtpResource) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FtpResourceDA.UpdateBySql2(objFtpResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceBL.ReFreshCache();

if (clsFtpResourceBL.relatedActions != null)
{
clsFtpResourceBL.relatedActions.UpdRelaTabDate(objFtpResourceEN.IdFtpResource, "SetUpdDate");
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
 /// <param name = "strIdFtpResource">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdFtpResource)
{
try
{
 clsFtpResourceEN objFtpResourceEN = clsFtpResourceBL.GetObjByIdFtpResource(strIdFtpResource);

if (clsFtpResourceBL.relatedActions != null)
{
clsFtpResourceBL.relatedActions.UpdRelaTabDate(objFtpResourceEN.IdFtpResource, "SetUpdDate");
}
if (objFtpResourceEN != null)
{
int intRecNum = FtpResourceDA.DelRecord(strIdFtpResource);
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
/// <param name="strIdFtpResource">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdFtpResource )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFtpResourceDA.GetSpecSQLObj();
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
//删除与表:[FtpResource]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFtpResource.IdFtpResource,
//strIdFtpResource);
//        clsFtpResourceBL.DelFtpResourcesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFtpResourceBL.DelRecord(strIdFtpResource, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFtpResourceBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdFtpResource, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdFtpResource">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdFtpResource, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFtpResourceBL.relatedActions != null)
{
clsFtpResourceBL.relatedActions.UpdRelaTabDate(strIdFtpResource, "UpdRelaTabDate");
}
bool bolResult = FtpResourceDA.DelRecord(strIdFtpResource,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdFtpResourceLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFtpResources(List<string> arrIdFtpResourceLst)
{
if (arrIdFtpResourceLst.Count == 0) return 0;
try
{
if (clsFtpResourceBL.relatedActions != null)
{
foreach (var strIdFtpResource in arrIdFtpResourceLst)
{
clsFtpResourceBL.relatedActions.UpdRelaTabDate(strIdFtpResource, "UpdRelaTabDate");
}
}
int intDelRecNum = FtpResourceDA.DelFtpResource(arrIdFtpResourceLst);
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
public static int DelFtpResourcesByCond(string strWhereCond)
{
try
{
if (clsFtpResourceBL.relatedActions != null)
{
List<string> arrIdFtpResource = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdFtpResource in arrIdFtpResource)
{
clsFtpResourceBL.relatedActions.UpdRelaTabDate(strIdFtpResource, "UpdRelaTabDate");
}
}
int intRecNum = FtpResourceDA.DelFtpResource(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FtpResource]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdFtpResource">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdFtpResource)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFtpResourceDA.GetSpecSQLObj();
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
//删除与表:[FtpResource]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFtpResourceBL.DelRecord(strIdFtpResource, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFtpResourceBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdFtpResource, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFtpResourceENS">源对象</param>
 /// <param name = "objFtpResourceENT">目标对象</param>
 public static void CopyTo(clsFtpResourceEN objFtpResourceENS, clsFtpResourceEN objFtpResourceENT)
{
try
{
objFtpResourceENT.IdFtpResource = objFtpResourceENS.IdFtpResource; //FTP资源流水号
objFtpResourceENT.FtpResourceID = objFtpResourceENS.FtpResourceID; //FTP资源ID
objFtpResourceENT.FileOriginalName = objFtpResourceENS.FileOriginalName; //文件原名
objFtpResourceENT.FileDirName = objFtpResourceENS.FileDirName; //文件目录名
objFtpResourceENT.FileRename = objFtpResourceENS.FileRename; //文件新名
objFtpResourceENT.FileUpDate = objFtpResourceENS.FileUpDate; //创建日期
objFtpResourceENT.FileUpTime = objFtpResourceENS.FileUpTime; //创建时间
objFtpResourceENT.Memo = objFtpResourceENS.Memo; //备注
objFtpResourceENT.FileSize = objFtpResourceENS.FileSize; //文件大小
objFtpResourceENT.FileType = objFtpResourceENS.FileType; //文件类型
objFtpResourceENT.CheckDateTime = objFtpResourceENS.CheckDateTime; //CheckDateTime
objFtpResourceENT.ResourceOwner = objFtpResourceENS.ResourceOwner; //上传者
objFtpResourceENT.IsExistFile = objFtpResourceENS.IsExistFile; //是否存在文件
objFtpResourceENT.FuncModuleId = objFtpResourceENS.FuncModuleId; //功能模块Id
objFtpResourceENT.FileResourceID = objFtpResourceENS.FileResourceID; //FileResourceID
objFtpResourceENT.FileNameBak = objFtpResourceENS.FileNameBak; //FileName_Bak
objFtpResourceENT.UpdDate = objFtpResourceENS.UpdDate; //修改日期
objFtpResourceENT.UpdUser = objFtpResourceENS.UpdUser; //修改人
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
 /// <param name = "objFtpResourceEN">源简化对象</param>
 public static void SetUpdFlag(clsFtpResourceEN objFtpResourceEN)
{
try
{
objFtpResourceEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFtpResourceEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFtpResource.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.IdFtpResource = objFtpResourceEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(conFtpResource.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.FtpResourceID = objFtpResourceEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(conFtpResource.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.FileOriginalName = objFtpResourceEN.FileOriginalName == "[null]" ? null :  objFtpResourceEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(conFtpResource.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.FileDirName = objFtpResourceEN.FileDirName == "[null]" ? null :  objFtpResourceEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(conFtpResource.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.FileRename = objFtpResourceEN.FileRename == "[null]" ? null :  objFtpResourceEN.FileRename; //文件新名
}
if (arrFldSet.Contains(conFtpResource.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.FileUpDate = objFtpResourceEN.FileUpDate == "[null]" ? null :  objFtpResourceEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(conFtpResource.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.FileUpTime = objFtpResourceEN.FileUpTime == "[null]" ? null :  objFtpResourceEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(conFtpResource.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.Memo = objFtpResourceEN.Memo == "[null]" ? null :  objFtpResourceEN.Memo; //备注
}
if (arrFldSet.Contains(conFtpResource.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.FileSize = objFtpResourceEN.FileSize == "[null]" ? null :  objFtpResourceEN.FileSize; //文件大小
}
if (arrFldSet.Contains(conFtpResource.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.FileType = objFtpResourceEN.FileType == "[null]" ? null :  objFtpResourceEN.FileType; //文件类型
}
if (arrFldSet.Contains(conFtpResource.CheckDateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.CheckDateTime = objFtpResourceEN.CheckDateTime == "[null]" ? null :  objFtpResourceEN.CheckDateTime; //CheckDateTime
}
if (arrFldSet.Contains(conFtpResource.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.ResourceOwner = objFtpResourceEN.ResourceOwner == "[null]" ? null :  objFtpResourceEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(conFtpResource.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.IsExistFile = objFtpResourceEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(conFtpResource.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.FuncModuleId = objFtpResourceEN.FuncModuleId == "[null]" ? null :  objFtpResourceEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(conFtpResource.FileResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.FileResourceID = objFtpResourceEN.FileResourceID; //FileResourceID
}
if (arrFldSet.Contains(conFtpResource.FileNameBak, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.FileNameBak = objFtpResourceEN.FileNameBak == "[null]" ? null :  objFtpResourceEN.FileNameBak; //FileName_Bak
}
if (arrFldSet.Contains(conFtpResource.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.UpdDate = objFtpResourceEN.UpdDate == "[null]" ? null :  objFtpResourceEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFtpResource.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFtpResourceEN.UpdUser = objFtpResourceEN.UpdUser == "[null]" ? null :  objFtpResourceEN.UpdUser; //修改人
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
 /// <param name = "objFtpResourceEN">源简化对象</param>
 public static void AccessFldValueNull(clsFtpResourceEN objFtpResourceEN)
{
try
{
if (objFtpResourceEN.FileOriginalName == "[null]") objFtpResourceEN.FileOriginalName = null; //文件原名
if (objFtpResourceEN.FileDirName == "[null]") objFtpResourceEN.FileDirName = null; //文件目录名
if (objFtpResourceEN.FileRename == "[null]") objFtpResourceEN.FileRename = null; //文件新名
if (objFtpResourceEN.FileUpDate == "[null]") objFtpResourceEN.FileUpDate = null; //创建日期
if (objFtpResourceEN.FileUpTime == "[null]") objFtpResourceEN.FileUpTime = null; //创建时间
if (objFtpResourceEN.Memo == "[null]") objFtpResourceEN.Memo = null; //备注
if (objFtpResourceEN.FileSize == "[null]") objFtpResourceEN.FileSize = null; //文件大小
if (objFtpResourceEN.FileType == "[null]") objFtpResourceEN.FileType = null; //文件类型
if (objFtpResourceEN.CheckDateTime == "[null]") objFtpResourceEN.CheckDateTime = null; //CheckDateTime
if (objFtpResourceEN.ResourceOwner == "[null]") objFtpResourceEN.ResourceOwner = null; //上传者
if (objFtpResourceEN.FuncModuleId == "[null]") objFtpResourceEN.FuncModuleId = null; //功能模块Id
if (objFtpResourceEN.FileNameBak == "[null]") objFtpResourceEN.FileNameBak = null; //FileName_Bak
if (objFtpResourceEN.UpdDate == "[null]") objFtpResourceEN.UpdDate = null; //修改日期
if (objFtpResourceEN.UpdUser == "[null]") objFtpResourceEN.UpdUser = null; //修改人
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
public static void CheckPropertyNew(clsFtpResourceEN objFtpResourceEN)
{
 FtpResourceDA.CheckPropertyNew(objFtpResourceEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFtpResourceEN objFtpResourceEN)
{
 FtpResourceDA.CheckProperty4Condition(objFtpResourceEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdFtpResourceCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[FTP资源]...","0");
List<clsFtpResourceEN> arrFtpResourceObjLst = GetAllFtpResourceObjLstCache(); 
objDDL.DataValueField = conFtpResource.IdFtpResource;
objDDL.DataTextField = conFtpResource.FileRename;
objDDL.DataSource = arrFtpResourceObjLst;
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
if (clsFtpResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceBL没有刷新缓存机制(clsFtpResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdFtpResource");
//if (arrFtpResourceObjLstCache == null)
//{
//arrFtpResourceObjLstCache = FtpResourceDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdFtpResource">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFtpResourceEN GetObjByIdFtpResourceCache(string strIdFtpResource)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFtpResourceEN._CurrTabName);
List<clsFtpResourceEN> arrFtpResourceObjLstCache = GetObjLstCache();
IEnumerable <clsFtpResourceEN> arrFtpResourceObjLst_Sel =
arrFtpResourceObjLstCache
.Where(x=> x.IdFtpResource == strIdFtpResource 
);
if (arrFtpResourceObjLst_Sel.Count() == 0)
{
   clsFtpResourceEN obj = clsFtpResourceBL.GetObjByIdFtpResource(strIdFtpResource);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFtpResourceObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdFtpResource">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFileRenameByIdFtpResourceCache(string strIdFtpResource)
{
if (string.IsNullOrEmpty(strIdFtpResource) == true) return "";
//获取缓存中的对象列表
clsFtpResourceEN objFtpResource = GetObjByIdFtpResourceCache(strIdFtpResource);
if (objFtpResource == null) return "";
return objFtpResource.FileRename;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdFtpResource">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdFtpResourceCache(string strIdFtpResource)
{
if (string.IsNullOrEmpty(strIdFtpResource) == true) return "";
//获取缓存中的对象列表
clsFtpResourceEN objFtpResource = GetObjByIdFtpResourceCache(strIdFtpResource);
if (objFtpResource == null) return "";
return objFtpResource.FileRename;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFtpResourceEN> GetAllFtpResourceObjLstCache()
{
//获取缓存中的对象列表
List<clsFtpResourceEN> arrFtpResourceObjLstCache = GetObjLstCache(); 
return arrFtpResourceObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFtpResourceEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFtpResourceEN._CurrTabName);
List<clsFtpResourceEN> arrFtpResourceObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFtpResourceObjLstCache;
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
string strKey = string.Format("{0}", clsFtpResourceEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFtpResourceEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFtpResourceEN._RefreshTimeLst.Count == 0) return "";
return clsFtpResourceEN._RefreshTimeLst[clsFtpResourceEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFtpResourceBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFtpResourceEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFtpResourceEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFtpResourceBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strIdFtpResource)
{
if (strInFldName != conFtpResource.IdFtpResource)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFtpResource.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFtpResource.AttributeName));
throw new Exception(strMsg);
}
var objFtpResource = clsFtpResourceBL.GetObjByIdFtpResourceCache(strIdFtpResource);
if (objFtpResource == null) return "";
return objFtpResource[strOutFldName].ToString();
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
int intRecCount = clsFtpResourceDA.GetRecCount(strTabName);
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
int intRecCount = clsFtpResourceDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFtpResourceDA.GetRecCount();
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
int intRecCount = clsFtpResourceDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFtpResourceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFtpResourceEN objFtpResourceCond)
{
List<clsFtpResourceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFtpResourceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFtpResource.AttributeName)
{
if (objFtpResourceCond.IsUpdated(strFldName) == false) continue;
if (objFtpResourceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFtpResourceCond[strFldName].ToString());
}
else
{
if (objFtpResourceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFtpResourceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFtpResourceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFtpResourceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFtpResourceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFtpResourceCond[strFldName]));
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
 List<string> arrList = clsFtpResourceDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FtpResourceDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FtpResourceDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FtpResourceDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFtpResourceDA.SetFldValue(clsFtpResourceEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FtpResourceDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFtpResourceDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFtpResourceDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFtpResourceDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FtpResource] "); 
 strCreateTabCode.Append(" ( "); 
 // /**FTP资源流水号*/ 
 strCreateTabCode.Append(" IdFtpResource char(8) primary key, "); 
 // /**FTP资源ID*/ 
 strCreateTabCode.Append(" FtpResourceID char(8) not Null, "); 
 // /**文件原名*/ 
 strCreateTabCode.Append(" FileOriginalName varchar(200) Null, "); 
 // /**文件目录名*/ 
 strCreateTabCode.Append(" FileDirName varchar(200) Null, "); 
 // /**文件新名*/ 
 strCreateTabCode.Append(" FileRename varchar(200) Null, "); 
 // /**创建日期*/ 
 strCreateTabCode.Append(" FileUpDate char(8) Null, "); 
 // /**创建时间*/ 
 strCreateTabCode.Append(" FileUpTime char(6) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**文件大小*/ 
 strCreateTabCode.Append(" FileSize varchar(50) Null, "); 
 // /**文件类型*/ 
 strCreateTabCode.Append(" FileType varchar(30) Null, "); 
 // /**CheckDateTime*/ 
 strCreateTabCode.Append(" CheckDateTime varchar(30) Null, "); 
 // /**上传者*/ 
 strCreateTabCode.Append(" ResourceOwner varchar(50) Null, "); 
 // /**是否存在文件*/ 
 strCreateTabCode.Append(" IsExistFile bit Null, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) Null, "); 
 // /**FileResourceID*/ 
 strCreateTabCode.Append(" FileResourceID bigint not Null, "); 
 // /**FileName_Bak*/ 
 strCreateTabCode.Append(" FileNameBak varchar(500) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// FTP资源(FtpResource)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FtpResource : clsCommFun4BL
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
clsFtpResourceBL.ReFreshThisCache();
}
}

}