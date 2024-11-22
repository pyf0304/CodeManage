﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFileServerBL
 表名:FileServer(01120325)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
public static class  clsFileServerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdFile">表关键字</param>
 /// <returns>表对象</returns>
public static clsFileServerEN GetObj(this K_IdFile_FileServer myKey)
{
clsFileServerEN objFileServerEN = clsFileServerBL.FileServerDA.GetObjByIdFile(myKey.Value);
return objFileServerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFileServerEN objFileServerEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objFileServerEN.IdFile) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFileServerBL.IsExist(objFileServerEN.IdFile) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFileServerEN.IdFile, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsFileServerBL.FileServerDA.AddNewRecordBySQL2(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.IdFile, "SetUpdDate");
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
public static bool AddRecordEx(this clsFileServerEN objFileServerEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsFileServerBL.IsExist(objFileServerEN.IdFile))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objFileServerEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objFileServerEN.AddNewRecord();
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFileServerEN objFileServerEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objFileServerEN.IdFile) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFileServerBL.IsExist(objFileServerEN.IdFile) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFileServerEN.IdFile, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsFileServerBL.FileServerDA.AddNewRecordBySQL2WithReturnKey(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.IdFile, "SetUpdDate");
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
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileServerEN SetIdFile(this clsFileServerEN objFileServerEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, conFileServer.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, conFileServer.IdFile);
}
objFileServerEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.IdFile) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.IdFile, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.IdFile] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileServerEN SetFileName(this clsFileServerEN objFileServerEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, conFileServer.FileName);
}
objFileServerEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.FileName) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.FileName, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.FileName] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileServerEN SetFileContent(this clsFileServerEN objFileServerEN, byte[] bytFileContent, string strComparisonOp="")
	{
objFileServerEN.FileContent = bytFileContent; //文件内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.FileContent) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.FileContent, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.FileContent] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileServerEN SetFileType(this clsFileServerEN objFileServerEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, conFileServer.FileType);
}
objFileServerEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.FileType) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.FileType, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.FileType] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileServerEN SetSaveDate(this clsFileServerEN objFileServerEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, conFileServer.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, conFileServer.SaveDate);
}
objFileServerEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.SaveDate) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.SaveDate, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.SaveDate] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileServerEN SetFileSize(this clsFileServerEN objFileServerEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, conFileServer.FileSize);
}
objFileServerEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.FileSize) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.FileSize, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.FileSize] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileServerEN SetSaveTime(this clsFileServerEN objFileServerEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, conFileServer.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, conFileServer.SaveTime);
}
objFileServerEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.SaveTime) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.SaveTime, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.SaveTime] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileServerEN SetResourceOwner(this clsFileServerEN objFileServerEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, conFileServer.ResourceOwner);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, conFileServer.ResourceOwner);
}
objFileServerEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.ResourceOwner) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.ResourceOwner, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.ResourceOwner] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileServerEN SetFileOriginName(this clsFileServerEN objFileServerEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, conFileServer.FileOriginName);
}
objFileServerEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.FileOriginName) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.FileOriginName, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.FileOriginName] = strComparisonOp;
}
}
return objFileServerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFileServerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFileServerEN objFileServerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFileServerEN.CheckPropertyNew();
clsFileServerEN objFileServerCond = new clsFileServerEN();
string strCondition = objFileServerCond
.SetIdFile(objFileServerEN.IdFile, "=")
.GetCombineCondition();
objFileServerEN._IsCheckProperty = true;
bool bolIsExist = clsFileServerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFileServerEN.Update();
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFileServerEN objFileServerEN)
{
 if (string.IsNullOrEmpty(objFileServerEN.IdFile) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFileServerBL.FileServerDA.UpdateBySql2(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.IdFile, "SetUpdDate");
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFileServerEN objFileServerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objFileServerEN.IdFile) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFileServerBL.FileServerDA.UpdateBySql2(objFileServerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.IdFile, "SetUpdDate");
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
 /// <param name = "objFileServerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFileServerEN objFileServerEN, string strWhereCond)
{
try
{
bool bolResult = clsFileServerBL.FileServerDA.UpdateBySqlWithCondition(objFileServerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.IdFile, "SetUpdDate");
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
 /// <param name = "objFileServerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFileServerEN objFileServerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFileServerBL.FileServerDA.UpdateBySqlWithConditionTransaction(objFileServerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.IdFile, "SetUpdDate");
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
 /// <param name = "strIdFile">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFileServerEN objFileServerEN)
{
try
{
int intRecNum = clsFileServerBL.FileServerDA.DelRecord(objFileServerEN.IdFile);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.IdFile, "SetUpdDate");
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
 /// <param name = "objFileServerENS">源对象</param>
 /// <param name = "objFileServerENT">目标对象</param>
 public static void CopyTo(this clsFileServerEN objFileServerENS, clsFileServerEN objFileServerENT)
{
try
{
objFileServerENT.IdFile = objFileServerENS.IdFile; //文件流水号
objFileServerENT.FileName = objFileServerENS.FileName; //文件名称
objFileServerENT.FileContent = objFileServerENS.FileContent; //文件内容
objFileServerENT.FileType = objFileServerENS.FileType; //文件类型
objFileServerENT.SaveDate = objFileServerENS.SaveDate; //创建日期
objFileServerENT.FileSize = objFileServerENS.FileSize; //文件大小
objFileServerENT.SaveTime = objFileServerENS.SaveTime; //创建时间
objFileServerENT.ResourceOwner = objFileServerENS.ResourceOwner; //上传者
objFileServerENT.FileOriginName = objFileServerENS.FileOriginName; //原文件名
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
 /// <param name = "objFileServerENS">源对象</param>
 /// <returns>目标对象=>clsFileServerEN:objFileServerENT</returns>
 public static clsFileServerEN CopyTo(this clsFileServerEN objFileServerENS)
{
try
{
 clsFileServerEN objFileServerENT = new clsFileServerEN()
{
IdFile = objFileServerENS.IdFile, //文件流水号
FileName = objFileServerENS.FileName, //文件名称
FileContent = objFileServerENS.FileContent, //文件内容
FileType = objFileServerENS.FileType, //文件类型
SaveDate = objFileServerENS.SaveDate, //创建日期
FileSize = objFileServerENS.FileSize, //文件大小
SaveTime = objFileServerENS.SaveTime, //创建时间
ResourceOwner = objFileServerENS.ResourceOwner, //上传者
FileOriginName = objFileServerENS.FileOriginName, //原文件名
};
 return objFileServerENT;
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
public static void CheckPropertyNew(this clsFileServerEN objFileServerEN)
{
 clsFileServerBL.FileServerDA.CheckPropertyNew(objFileServerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFileServerEN objFileServerEN)
{
 clsFileServerBL.FileServerDA.CheckProperty4Condition(objFileServerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFileServerEN objFileServerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFileServerCond.IsUpdated(conFileServer.IdFile) == true)
{
string strComparisonOpIdFile = objFileServerCond.dicFldComparisonOp[conFileServer.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.IdFile, objFileServerCond.IdFile, strComparisonOpIdFile);
}
if (objFileServerCond.IsUpdated(conFileServer.FileName) == true)
{
string strComparisonOpFileName = objFileServerCond.dicFldComparisonOp[conFileServer.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.FileName, objFileServerCond.FileName, strComparisonOpFileName);
}
//数据类型byte[](image)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objFileServerCond.IsUpdated(conFileServer.FileType) == true)
{
string strComparisonOpFileType = objFileServerCond.dicFldComparisonOp[conFileServer.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.FileType, objFileServerCond.FileType, strComparisonOpFileType);
}
if (objFileServerCond.IsUpdated(conFileServer.SaveDate) == true)
{
string strComparisonOpSaveDate = objFileServerCond.dicFldComparisonOp[conFileServer.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.SaveDate, objFileServerCond.SaveDate, strComparisonOpSaveDate);
}
if (objFileServerCond.IsUpdated(conFileServer.FileSize) == true)
{
string strComparisonOpFileSize = objFileServerCond.dicFldComparisonOp[conFileServer.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.FileSize, objFileServerCond.FileSize, strComparisonOpFileSize);
}
if (objFileServerCond.IsUpdated(conFileServer.SaveTime) == true)
{
string strComparisonOpSaveTime = objFileServerCond.dicFldComparisonOp[conFileServer.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.SaveTime, objFileServerCond.SaveTime, strComparisonOpSaveTime);
}
if (objFileServerCond.IsUpdated(conFileServer.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objFileServerCond.dicFldComparisonOp[conFileServer.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.ResourceOwner, objFileServerCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objFileServerCond.IsUpdated(conFileServer.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objFileServerCond.dicFldComparisonOp[conFileServer.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.FileOriginName, objFileServerCond.FileOriginName, strComparisonOpFileOriginName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FileServer
{
public virtual bool UpdRelaTabDate(string strIdFile, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 文件服务(FileServer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFileServerBL
{
public static RelatedActions_FileServer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFileServerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFileServerDA FileServerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFileServerDA();
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
 public clsFileServerBL()
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
if (string.IsNullOrEmpty(clsFileServerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFileServerEN._ConnectString);
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
public static DataTable GetDataTable_FileServer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FileServerDA.GetDataTable_FileServer(strWhereCond);
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
objDT = FileServerDA.GetDataTable(strWhereCond);
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
objDT = FileServerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FileServerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FileServerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FileServerDA.GetDataTable_Top(objTopPara);
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
objDT = FileServerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FileServerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FileServerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdFileLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFileServerEN> GetObjLstByIdFileLst(List<string> arrIdFileLst)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdFileLst, true);
 string strWhereCond = string.Format("IdFile in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.IdFile = objRow[conFileServer.IdFile].ToString().Trim(); //文件流水号
objFileServerEN.FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(); //文件名称
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //创建日期
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objFileServerEN.SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(); //创建时间
objFileServerEN.ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者
objFileServerEN.FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.IdFile, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdFileLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFileServerEN> GetObjLstByIdFileLstCache(List<string> arrIdFileLst)
{
string strKey = string.Format("{0}", clsFileServerEN._CurrTabName);
List<clsFileServerEN> arrFileServerObjLstCache = GetObjLstCache();
IEnumerable <clsFileServerEN> arrFileServerObjLst_Sel =
arrFileServerObjLstCache
.Where(x => arrIdFileLst.Contains(x.IdFile));
return arrFileServerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileServerEN> GetObjLst(string strWhereCond)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.IdFile = objRow[conFileServer.IdFile].ToString().Trim(); //文件流水号
objFileServerEN.FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(); //文件名称
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //创建日期
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objFileServerEN.SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(); //创建时间
objFileServerEN.ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者
objFileServerEN.FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.IdFile, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
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
public static List<clsFileServerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.IdFile = objRow[conFileServer.IdFile].ToString().Trim(); //文件流水号
objFileServerEN.FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(); //文件名称
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //创建日期
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objFileServerEN.SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(); //创建时间
objFileServerEN.ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者
objFileServerEN.FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.IdFile, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFileServerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFileServerEN> GetSubObjLstCache(clsFileServerEN objFileServerCond)
{
List<clsFileServerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFileServerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFileServer.AttributeName)
{
if (objFileServerCond.IsUpdated(strFldName) == false) continue;
if (objFileServerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFileServerCond[strFldName].ToString());
}
else
{
if (objFileServerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFileServerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFileServerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFileServerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFileServerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFileServerCond[strFldName]));
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
public static List<clsFileServerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.IdFile = objRow[conFileServer.IdFile].ToString().Trim(); //文件流水号
objFileServerEN.FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(); //文件名称
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //创建日期
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objFileServerEN.SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(); //创建时间
objFileServerEN.ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者
objFileServerEN.FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.IdFile, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
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
public static List<clsFileServerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.IdFile = objRow[conFileServer.IdFile].ToString().Trim(); //文件流水号
objFileServerEN.FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(); //文件名称
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //创建日期
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objFileServerEN.SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(); //创建时间
objFileServerEN.ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者
objFileServerEN.FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.IdFile, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
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
List<clsFileServerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFileServerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileServerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFileServerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
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
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.IdFile = objRow[conFileServer.IdFile].ToString().Trim(); //文件流水号
objFileServerEN.FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(); //文件名称
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //创建日期
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objFileServerEN.SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(); //创建时间
objFileServerEN.ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者
objFileServerEN.FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.IdFile, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
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
public static List<clsFileServerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.IdFile = objRow[conFileServer.IdFile].ToString().Trim(); //文件流水号
objFileServerEN.FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(); //文件名称
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //创建日期
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objFileServerEN.SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(); //创建时间
objFileServerEN.ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者
objFileServerEN.FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.IdFile, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFileServerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFileServerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.IdFile = objRow[conFileServer.IdFile].ToString().Trim(); //文件流水号
objFileServerEN.FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(); //文件名称
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //创建日期
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objFileServerEN.SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(); //创建时间
objFileServerEN.ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者
objFileServerEN.FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.IdFile, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
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
public static List<clsFileServerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.IdFile = objRow[conFileServer.IdFile].ToString().Trim(); //文件流水号
objFileServerEN.FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(); //文件名称
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //创建日期
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objFileServerEN.SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(); //创建时间
objFileServerEN.ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者
objFileServerEN.FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.IdFile, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileServerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.IdFile = objRow[conFileServer.IdFile].ToString().Trim(); //文件流水号
objFileServerEN.FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(); //文件名称
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //创建日期
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objFileServerEN.SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(); //创建时间
objFileServerEN.ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者
objFileServerEN.FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.IdFile, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFileServerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFileServer(ref clsFileServerEN objFileServerEN)
{
bool bolResult = FileServerDA.GetFileServer(ref objFileServerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdFile">表关键字</param>
 /// <returns>表对象</returns>
public static clsFileServerEN GetObjByIdFile(string strIdFile)
{
if (strIdFile.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdFile]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdFile) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdFile]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsFileServerEN objFileServerEN = FileServerDA.GetObjByIdFile(strIdFile);
return objFileServerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFileServerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFileServerEN objFileServerEN = FileServerDA.GetFirstObj(strWhereCond);
 return objFileServerEN;
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
public static clsFileServerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFileServerEN objFileServerEN = FileServerDA.GetObjByDataRow(objRow);
 return objFileServerEN;
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
public static clsFileServerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFileServerEN objFileServerEN = FileServerDA.GetObjByDataRow(objRow);
 return objFileServerEN;
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
 /// <param name = "strIdFile">所给的关键字</param>
 /// <param name = "lstFileServerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFileServerEN GetObjByIdFileFromList(string strIdFile, List<clsFileServerEN> lstFileServerObjLst)
{
foreach (clsFileServerEN objFileServerEN in lstFileServerObjLst)
{
if (objFileServerEN.IdFile == strIdFile)
{
return objFileServerEN;
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
 string strIdFile;
 try
 {
 strIdFile = new clsFileServerDA().GetFirstID(strWhereCond);
 return strIdFile;
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
 arrList = FileServerDA.GetID(strWhereCond);
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
bool bolIsExist = FileServerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdFile">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdFile)
{
if (string.IsNullOrEmpty(strIdFile) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdFile]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = FileServerDA.IsExist(strIdFile);
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
 bolIsExist = clsFileServerDA.IsExistTable();
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
 bolIsExist = FileServerDA.IsExistTable(strTabName);
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFileServerEN objFileServerEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objFileServerEN.IdFile) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFileServerBL.IsExist(objFileServerEN.IdFile) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFileServerEN.IdFile, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = FileServerDA.AddNewRecordBySQL2(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.IdFile, "SetUpdDate");
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFileServerEN objFileServerEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objFileServerEN.IdFile) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFileServerBL.IsExist(objFileServerEN.IdFile) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFileServerEN.IdFile, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = FileServerDA.AddNewRecordBySQL2WithReturnKey(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.IdFile, "SetUpdDate");
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFileServerEN objFileServerEN)
{
try
{
bool bolResult = FileServerDA.Update(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.IdFile, "SetUpdDate");
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFileServerEN objFileServerEN)
{
 if (string.IsNullOrEmpty(objFileServerEN.IdFile) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FileServerDA.UpdateBySql2(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.IdFile, "SetUpdDate");
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
 /// <param name = "strIdFile">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdFile)
{
try
{
 clsFileServerEN objFileServerEN = clsFileServerBL.GetObjByIdFile(strIdFile);

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.IdFile, "SetUpdDate");
}
if (objFileServerEN != null)
{
int intRecNum = FileServerDA.DelRecord(strIdFile);
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
/// <param name="strIdFile">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdFile )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFileServerDA.GetSpecSQLObj();
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
//删除与表:[FileServer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFileServer.IdFile,
//strIdFile);
//        clsFileServerBL.DelFileServersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFileServerBL.DelRecord(strIdFile, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFileServerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdFile, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdFile">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdFile, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(strIdFile, "UpdRelaTabDate");
}
bool bolResult = FileServerDA.DelRecord(strIdFile,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdFileLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFileServers(List<string> arrIdFileLst)
{
if (arrIdFileLst.Count == 0) return 0;
try
{
if (clsFileServerBL.relatedActions != null)
{
foreach (var strIdFile in arrIdFileLst)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(strIdFile, "UpdRelaTabDate");
}
}
int intDelRecNum = FileServerDA.DelFileServer(arrIdFileLst);
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
public static int DelFileServersByCond(string strWhereCond)
{
try
{
if (clsFileServerBL.relatedActions != null)
{
List<string> arrIdFile = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdFile in arrIdFile)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(strIdFile, "UpdRelaTabDate");
}
}
int intRecNum = FileServerDA.DelFileServer(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FileServer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdFile">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdFile)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFileServerDA.GetSpecSQLObj();
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
//删除与表:[FileServer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFileServerBL.DelRecord(strIdFile, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFileServerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdFile, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFileServerENS">源对象</param>
 /// <param name = "objFileServerENT">目标对象</param>
 public static void CopyTo(clsFileServerEN objFileServerENS, clsFileServerEN objFileServerENT)
{
try
{
objFileServerENT.IdFile = objFileServerENS.IdFile; //文件流水号
objFileServerENT.FileName = objFileServerENS.FileName; //文件名称
objFileServerENT.FileContent = objFileServerENS.FileContent; //文件内容
objFileServerENT.FileType = objFileServerENS.FileType; //文件类型
objFileServerENT.SaveDate = objFileServerENS.SaveDate; //创建日期
objFileServerENT.FileSize = objFileServerENS.FileSize; //文件大小
objFileServerENT.SaveTime = objFileServerENS.SaveTime; //创建时间
objFileServerENT.ResourceOwner = objFileServerENS.ResourceOwner; //上传者
objFileServerENT.FileOriginName = objFileServerENS.FileOriginName; //原文件名
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
 /// <param name = "objFileServerEN">源简化对象</param>
 public static void SetUpdFlag(clsFileServerEN objFileServerEN)
{
try
{
objFileServerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFileServerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFileServer.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.IdFile = objFileServerEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(conFileServer.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.FileName = objFileServerEN.FileName == "[null]" ? null :  objFileServerEN.FileName; //文件名称
}
if (arrFldSet.Contains(conFileServer.FileContent, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.FileContent = objFileServerEN.FileContent; //文件内容
}
if (arrFldSet.Contains(conFileServer.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.FileType = objFileServerEN.FileType == "[null]" ? null :  objFileServerEN.FileType; //文件类型
}
if (arrFldSet.Contains(conFileServer.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.SaveDate = objFileServerEN.SaveDate == "[null]" ? null :  objFileServerEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(conFileServer.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.FileSize = objFileServerEN.FileSize == "[null]" ? null :  objFileServerEN.FileSize; //文件大小
}
if (arrFldSet.Contains(conFileServer.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.SaveTime = objFileServerEN.SaveTime == "[null]" ? null :  objFileServerEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(conFileServer.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.ResourceOwner = objFileServerEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(conFileServer.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.FileOriginName = objFileServerEN.FileOriginName == "[null]" ? null :  objFileServerEN.FileOriginName; //原文件名
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
 /// <param name = "objFileServerEN">源简化对象</param>
 public static void AccessFldValueNull(clsFileServerEN objFileServerEN)
{
try
{
if (objFileServerEN.FileName == "[null]") objFileServerEN.FileName = null; //文件名称
if (objFileServerEN.FileType == "[null]") objFileServerEN.FileType = null; //文件类型
if (objFileServerEN.SaveDate == "[null]") objFileServerEN.SaveDate = null; //创建日期
if (objFileServerEN.FileSize == "[null]") objFileServerEN.FileSize = null; //文件大小
if (objFileServerEN.SaveTime == "[null]") objFileServerEN.SaveTime = null; //创建时间
if (objFileServerEN.FileOriginName == "[null]") objFileServerEN.FileOriginName = null; //原文件名
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
public static void CheckPropertyNew(clsFileServerEN objFileServerEN)
{
 FileServerDA.CheckPropertyNew(objFileServerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFileServerEN objFileServerEN)
{
 FileServerDA.CheckProperty4Condition(objFileServerEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdFileCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[文件服务]...","0");
List<clsFileServerEN> arrFileServerObjLst = GetAllFileServerObjLstCache(); 
objDDL.DataValueField = conFileServer.IdFile;
objDDL.DataTextField = conFileServer.FileName;
objDDL.DataSource = arrFileServerObjLst;
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
if (clsFileServerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerBL没有刷新缓存机制(clsFileServerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdFile");
//if (arrFileServerObjLstCache == null)
//{
//arrFileServerObjLstCache = FileServerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdFile">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFileServerEN GetObjByIdFileCache(string strIdFile)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFileServerEN._CurrTabName);
List<clsFileServerEN> arrFileServerObjLstCache = GetObjLstCache();
IEnumerable <clsFileServerEN> arrFileServerObjLst_Sel =
arrFileServerObjLstCache
.Where(x=> x.IdFile == strIdFile 
);
if (arrFileServerObjLst_Sel.Count() == 0)
{
   clsFileServerEN obj = clsFileServerBL.GetObjByIdFile(strIdFile);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFileServerObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdFile">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFileNameByIdFileCache(string strIdFile)
{
if (string.IsNullOrEmpty(strIdFile) == true) return "";
//获取缓存中的对象列表
clsFileServerEN objFileServer = GetObjByIdFileCache(strIdFile);
if (objFileServer == null) return "";
return objFileServer.FileName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdFile">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdFileCache(string strIdFile)
{
if (string.IsNullOrEmpty(strIdFile) == true) return "";
//获取缓存中的对象列表
clsFileServerEN objFileServer = GetObjByIdFileCache(strIdFile);
if (objFileServer == null) return "";
return objFileServer.FileName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFileServerEN> GetAllFileServerObjLstCache()
{
//获取缓存中的对象列表
List<clsFileServerEN> arrFileServerObjLstCache = GetObjLstCache(); 
return arrFileServerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFileServerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFileServerEN._CurrTabName);
List<clsFileServerEN> arrFileServerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFileServerObjLstCache;
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
string strKey = string.Format("{0}", clsFileServerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFileServerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFileServerEN._RefreshTimeLst.Count == 0) return "";
return clsFileServerEN._RefreshTimeLst[clsFileServerEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFileServerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFileServerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFileServerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFileServerBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdFile)
{
if (strInFldName != conFileServer.IdFile)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFileServer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFileServer.AttributeName));
throw new Exception(strMsg);
}
var objFileServer = clsFileServerBL.GetObjByIdFileCache(strIdFile);
if (objFileServer == null) return "";
return objFileServer[strOutFldName].ToString();
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
int intRecCount = clsFileServerDA.GetRecCount(strTabName);
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
int intRecCount = clsFileServerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFileServerDA.GetRecCount();
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
int intRecCount = clsFileServerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFileServerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFileServerEN objFileServerCond)
{
List<clsFileServerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFileServerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFileServer.AttributeName)
{
if (objFileServerCond.IsUpdated(strFldName) == false) continue;
if (objFileServerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFileServerCond[strFldName].ToString());
}
else
{
if (objFileServerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFileServerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFileServerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFileServerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFileServerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFileServerCond[strFldName]));
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
 List<string> arrList = clsFileServerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FileServerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FileServerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FileServerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFileServerDA.SetFldValue(clsFileServerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FileServerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFileServerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFileServerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFileServerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FileServer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**文件流水号*/ 
 strCreateTabCode.Append(" IdFile char(8) primary key, "); 
 // /**文件名称*/ 
 strCreateTabCode.Append(" FileName varchar(500) Null, "); 
 // /**文件内容*/ 
 strCreateTabCode.Append(" FileContent image Null, "); 
 // /**文件类型*/ 
 strCreateTabCode.Append(" FileType varchar(30) Null, "); 
 // /**创建日期*/ 
 strCreateTabCode.Append(" SaveDate char(8) Null, "); 
 // /**文件大小*/ 
 strCreateTabCode.Append(" FileSize varchar(50) Null, "); 
 // /**创建时间*/ 
 strCreateTabCode.Append(" SaveTime char(6) Null, "); 
 // /**上传者*/ 
 strCreateTabCode.Append(" ResourceOwner varchar(50) not Null, "); 
 // /**原文件名*/ 
 strCreateTabCode.Append(" FileOriginName varchar(500) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 文件服务(FileServer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FileServer : clsCommFun4BL
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
clsFileServerBL.ReFreshThisCache();
}
}

}