
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLoginLogBL
 表名:LoginLog(01120357)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理(LogManage)
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
public static class  clsLoginLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngLoginLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsLoginLogEN GetObj(this K_LoginLogId_LoginLog myKey)
{
clsLoginLogEN objLoginLogEN = clsLoginLogBL.LoginLogDA.GetObjByLoginLogId(myKey.Value);
return objLoginLogEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsLoginLogEN objLoginLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objLoginLogEN) == false)
{
var strMsg = string.Format("记录已经存在!LoginUserId = [{0}],LoginIP = [{1}],LoginTime = [{2}]的数据已经存在!(in clsLoginLogBL.AddNewRecord)", objLoginLogEN.LoginUserId,objLoginLogEN.LoginIP,objLoginLogEN.LoginTime);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsLoginLogBL.LoginLogDA.AddNewRecordBySQL2(objLoginLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogBL.ReFreshCache();

if (clsLoginLogBL.relatedActions != null)
{
clsLoginLogBL.relatedActions.UpdRelaTabDate(objLoginLogEN.LoginLogId, "SetUpdDate");
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
public static bool AddRecordEx(this clsLoginLogEN objLoginLogEN, bool bolIsNeedCheckUniqueness = true)
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
objLoginLogEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objLoginLogEN.CheckUniqueness() == false)
{
strMsg = string.Format("(LoginUserId(LoginUserId)=[{0}],LoginIP(LoginIP)=[{1}],LoginTime(LoginTime)=[{2}])已经存在,不能重复!", objLoginLogEN.LoginUserId, objLoginLogEN.LoginIP, objLoginLogEN.LoginTime);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objLoginLogEN.AddNewRecord();
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
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsLoginLogEN objLoginLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objLoginLogEN) == false)
{
var strMsg = string.Format("记录已经存在!LoginUserId = [{0}],LoginIP = [{1}],LoginTime = [{2}]的数据已经存在!(in clsLoginLogBL.AddNewRecordWithReturnKey)", objLoginLogEN.LoginUserId,objLoginLogEN.LoginIP,objLoginLogEN.LoginTime);
throw new Exception(strMsg);
}
try
{
string strKey = clsLoginLogBL.LoginLogDA.AddNewRecordBySQL2WithReturnKey(objLoginLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogBL.ReFreshCache();

if (clsLoginLogBL.relatedActions != null)
{
clsLoginLogBL.relatedActions.UpdRelaTabDate(objLoginLogEN.LoginLogId, "SetUpdDate");
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
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLoginLogEN SetLoginLogId(this clsLoginLogEN objLoginLogEN, long lngLoginLogId, string strComparisonOp="")
	{
objLoginLogEN.LoginLogId = lngLoginLogId; //LoginLogId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.LoginLogId) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.LoginLogId, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.LoginLogId] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLoginLogEN SetLoginLogNumber(this clsLoginLogEN objLoginLogEN, string strLoginLogNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLoginLogNumber, 500, conLoginLog.LoginLogNumber);
}
objLoginLogEN.LoginLogNumber = strLoginLogNumber; //LoginLogNumber
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.LoginLogNumber) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.LoginLogNumber, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.LoginLogNumber] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLoginLogEN SetLoginIP(this clsLoginLogEN objLoginLogEN, string strLoginIP, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLoginIP, 200, conLoginLog.LoginIP);
}
objLoginLogEN.LoginIP = strLoginIP; //LoginIP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.LoginIP) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.LoginIP, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.LoginIP] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLoginLogEN SetFailReason(this clsLoginLogEN objLoginLogEN, string strFailReason, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFailReason, 500, conLoginLog.FailReason);
}
objLoginLogEN.FailReason = strFailReason; //FailReason
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.FailReason) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.FailReason, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.FailReason] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLoginLogEN SetLoginResult(this clsLoginLogEN objLoginLogEN, string strLoginResult, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLoginResult, 500, conLoginLog.LoginResult);
}
objLoginLogEN.LoginResult = strLoginResult; //LoginResult
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.LoginResult) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.LoginResult, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.LoginResult] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLoginLogEN SetLoginTime(this clsLoginLogEN objLoginLogEN, string strLoginTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLoginTime, 20, conLoginLog.LoginTime);
}
objLoginLogEN.LoginTime = strLoginTime; //LoginTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.LoginTime) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.LoginTime, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.LoginTime] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLoginLogEN SetLoginUserId(this clsLoginLogEN objLoginLogEN, string strLoginUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLoginUserId, 200, conLoginLog.LoginUserId);
}
objLoginLogEN.LoginUserId = strLoginUserId; //LoginUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.LoginUserId) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.LoginUserId, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.LoginUserId] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLoginLogEN SetOnlineTime(this clsLoginLogEN objLoginLogEN, string strOnlineTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOnlineTime, 200, conLoginLog.OnlineTime);
}
objLoginLogEN.OnlineTime = strOnlineTime; //OnlineTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.OnlineTime) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.OnlineTime, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.OnlineTime] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLoginLogEN SetOutTime(this clsLoginLogEN objLoginLogEN, string strOutTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutTime, 20, conLoginLog.OutTime);
}
objLoginLogEN.OutTime = strOutTime; //OutTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.OutTime) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.OutTime, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.OutTime] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLoginLogEN SetMemo(this clsLoginLogEN objLoginLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conLoginLog.Memo);
}
objLoginLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.Memo) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.Memo, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.Memo] = strComparisonOp;
}
}
return objLoginLogEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objLoginLogEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsLoginLogEN objLoginLogEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objLoginLogEN.CheckPropertyNew();
clsLoginLogEN objLoginLogCond = new clsLoginLogEN();
string strCondition = objLoginLogCond
.SetLoginLogId(objLoginLogEN.LoginLogId, "<>")
.SetLoginUserId(objLoginLogEN.LoginUserId, "=")
.SetLoginIP(objLoginLogEN.LoginIP, "=")
.SetLoginTime(objLoginLogEN.LoginTime, "=")
.GetCombineCondition();
objLoginLogEN._IsCheckProperty = true;
bool bolIsExist = clsLoginLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(LoginUserId_LoginIP_LoginTime)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objLoginLogEN.Update();
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
 /// <param name = "objLoginLog">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsLoginLogEN objLoginLog)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsLoginLogEN objLoginLogCond = new clsLoginLogEN();
string strCondition = objLoginLogCond
.SetLoginUserId(objLoginLog.LoginUserId, "=")
.SetLoginIP(objLoginLog.LoginIP, "=")
.SetLoginTime(objLoginLog.LoginTime, "=")
.GetCombineCondition();
objLoginLog._IsCheckProperty = true;
bool bolIsExist = clsLoginLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objLoginLog.LoginLogId = clsLoginLogBL.GetFirstID_S(strCondition);
objLoginLog.UpdateWithCondition(strCondition);
}
else
{
objLoginLog.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsLoginLogEN objLoginLogEN)
{
 if (objLoginLogEN.LoginLogId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsLoginLogBL.LoginLogDA.UpdateBySql2(objLoginLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogBL.ReFreshCache();

if (clsLoginLogBL.relatedActions != null)
{
clsLoginLogBL.relatedActions.UpdRelaTabDate(objLoginLogEN.LoginLogId, "SetUpdDate");
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
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsLoginLogEN objLoginLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objLoginLogEN.LoginLogId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsLoginLogBL.LoginLogDA.UpdateBySql2(objLoginLogEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogBL.ReFreshCache();

if (clsLoginLogBL.relatedActions != null)
{
clsLoginLogBL.relatedActions.UpdRelaTabDate(objLoginLogEN.LoginLogId, "SetUpdDate");
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
 /// <param name = "objLoginLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsLoginLogEN objLoginLogEN, string strWhereCond)
{
try
{
bool bolResult = clsLoginLogBL.LoginLogDA.UpdateBySqlWithCondition(objLoginLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogBL.ReFreshCache();

if (clsLoginLogBL.relatedActions != null)
{
clsLoginLogBL.relatedActions.UpdRelaTabDate(objLoginLogEN.LoginLogId, "SetUpdDate");
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
 /// <param name = "objLoginLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsLoginLogEN objLoginLogEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsLoginLogBL.LoginLogDA.UpdateBySqlWithConditionTransaction(objLoginLogEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogBL.ReFreshCache();

if (clsLoginLogBL.relatedActions != null)
{
clsLoginLogBL.relatedActions.UpdRelaTabDate(objLoginLogEN.LoginLogId, "SetUpdDate");
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
 /// <param name = "lngLoginLogId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsLoginLogEN objLoginLogEN)
{
try
{
int intRecNum = clsLoginLogBL.LoginLogDA.DelRecord(objLoginLogEN.LoginLogId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogBL.ReFreshCache();

if (clsLoginLogBL.relatedActions != null)
{
clsLoginLogBL.relatedActions.UpdRelaTabDate(objLoginLogEN.LoginLogId, "SetUpdDate");
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
 /// <param name = "objLoginLogENS">源对象</param>
 /// <param name = "objLoginLogENT">目标对象</param>
 public static void CopyTo(this clsLoginLogEN objLoginLogENS, clsLoginLogEN objLoginLogENT)
{
try
{
objLoginLogENT.LoginLogId = objLoginLogENS.LoginLogId; //LoginLogId
objLoginLogENT.LoginLogNumber = objLoginLogENS.LoginLogNumber; //LoginLogNumber
objLoginLogENT.LoginIP = objLoginLogENS.LoginIP; //LoginIP
objLoginLogENT.FailReason = objLoginLogENS.FailReason; //FailReason
objLoginLogENT.LoginResult = objLoginLogENS.LoginResult; //LoginResult
objLoginLogENT.LoginTime = objLoginLogENS.LoginTime; //LoginTime
objLoginLogENT.LoginUserId = objLoginLogENS.LoginUserId; //LoginUserId
objLoginLogENT.OnlineTime = objLoginLogENS.OnlineTime; //OnlineTime
objLoginLogENT.OutTime = objLoginLogENS.OutTime; //OutTime
objLoginLogENT.Memo = objLoginLogENS.Memo; //备注
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
 /// <param name = "objLoginLogENS">源对象</param>
 /// <returns>目标对象=>clsLoginLogEN:objLoginLogENT</returns>
 public static clsLoginLogEN CopyTo(this clsLoginLogEN objLoginLogENS)
{
try
{
 clsLoginLogEN objLoginLogENT = new clsLoginLogEN()
{
LoginLogId = objLoginLogENS.LoginLogId, //LoginLogId
LoginLogNumber = objLoginLogENS.LoginLogNumber, //LoginLogNumber
LoginIP = objLoginLogENS.LoginIP, //LoginIP
FailReason = objLoginLogENS.FailReason, //FailReason
LoginResult = objLoginLogENS.LoginResult, //LoginResult
LoginTime = objLoginLogENS.LoginTime, //LoginTime
LoginUserId = objLoginLogENS.LoginUserId, //LoginUserId
OnlineTime = objLoginLogENS.OnlineTime, //OnlineTime
OutTime = objLoginLogENS.OutTime, //OutTime
Memo = objLoginLogENS.Memo, //备注
};
 return objLoginLogENT;
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
public static void CheckPropertyNew(this clsLoginLogEN objLoginLogEN)
{
 clsLoginLogBL.LoginLogDA.CheckPropertyNew(objLoginLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsLoginLogEN objLoginLogEN)
{
 clsLoginLogBL.LoginLogDA.CheckProperty4Condition(objLoginLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsLoginLogEN objLoginLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objLoginLogCond.IsUpdated(conLoginLog.LoginLogId) == true)
{
string strComparisonOpLoginLogId = objLoginLogCond.dicFldComparisonOp[conLoginLog.LoginLogId];
strWhereCond += string.Format(" And {0} {2} {1}", conLoginLog.LoginLogId, objLoginLogCond.LoginLogId, strComparisonOpLoginLogId);
}
if (objLoginLogCond.IsUpdated(conLoginLog.LoginLogNumber) == true)
{
string strComparisonOpLoginLogNumber = objLoginLogCond.dicFldComparisonOp[conLoginLog.LoginLogNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.LoginLogNumber, objLoginLogCond.LoginLogNumber, strComparisonOpLoginLogNumber);
}
if (objLoginLogCond.IsUpdated(conLoginLog.LoginIP) == true)
{
string strComparisonOpLoginIP = objLoginLogCond.dicFldComparisonOp[conLoginLog.LoginIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.LoginIP, objLoginLogCond.LoginIP, strComparisonOpLoginIP);
}
if (objLoginLogCond.IsUpdated(conLoginLog.FailReason) == true)
{
string strComparisonOpFailReason = objLoginLogCond.dicFldComparisonOp[conLoginLog.FailReason];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.FailReason, objLoginLogCond.FailReason, strComparisonOpFailReason);
}
if (objLoginLogCond.IsUpdated(conLoginLog.LoginResult) == true)
{
string strComparisonOpLoginResult = objLoginLogCond.dicFldComparisonOp[conLoginLog.LoginResult];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.LoginResult, objLoginLogCond.LoginResult, strComparisonOpLoginResult);
}
if (objLoginLogCond.IsUpdated(conLoginLog.LoginTime) == true)
{
string strComparisonOpLoginTime = objLoginLogCond.dicFldComparisonOp[conLoginLog.LoginTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.LoginTime, objLoginLogCond.LoginTime, strComparisonOpLoginTime);
}
if (objLoginLogCond.IsUpdated(conLoginLog.LoginUserId) == true)
{
string strComparisonOpLoginUserId = objLoginLogCond.dicFldComparisonOp[conLoginLog.LoginUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.LoginUserId, objLoginLogCond.LoginUserId, strComparisonOpLoginUserId);
}
if (objLoginLogCond.IsUpdated(conLoginLog.OnlineTime) == true)
{
string strComparisonOpOnlineTime = objLoginLogCond.dicFldComparisonOp[conLoginLog.OnlineTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.OnlineTime, objLoginLogCond.OnlineTime, strComparisonOpOnlineTime);
}
if (objLoginLogCond.IsUpdated(conLoginLog.OutTime) == true)
{
string strComparisonOpOutTime = objLoginLogCond.dicFldComparisonOp[conLoginLog.OutTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.OutTime, objLoginLogCond.OutTime, strComparisonOpOutTime);
}
if (objLoginLogCond.IsUpdated(conLoginLog.Memo) == true)
{
string strComparisonOpMemo = objLoginLogCond.dicFldComparisonOp[conLoginLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.Memo, objLoginLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--LoginLog(登录日志), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:LoginUserId_LoginIP_LoginTime
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objLoginLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsLoginLogEN objLoginLogEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objLoginLogEN == null) return true;
if (objLoginLogEN.LoginLogId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objLoginLogEN.LoginUserId == null)
{
 sbCondition.AppendFormat(" and LoginUserId is null", objLoginLogEN.LoginUserId);
}
else
{
 sbCondition.AppendFormat(" and LoginUserId = '{0}'", objLoginLogEN.LoginUserId);
}
 if (objLoginLogEN.LoginIP == null)
{
 sbCondition.AppendFormat(" and LoginIP is null", objLoginLogEN.LoginIP);
}
else
{
 sbCondition.AppendFormat(" and LoginIP = '{0}'", objLoginLogEN.LoginIP);
}
 if (objLoginLogEN.LoginTime == null)
{
 sbCondition.AppendFormat(" and LoginTime is null", objLoginLogEN.LoginTime);
}
else
{
 sbCondition.AppendFormat(" and LoginTime = '{0}'", objLoginLogEN.LoginTime);
}
if (clsLoginLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("LoginLogId !=  {0}", objLoginLogEN.LoginLogId);
 sbCondition.AppendFormat(" and LoginUserId = '{0}'", objLoginLogEN.LoginUserId);
 sbCondition.AppendFormat(" and LoginIP = '{0}'", objLoginLogEN.LoginIP);
 sbCondition.AppendFormat(" and LoginTime = '{0}'", objLoginLogEN.LoginTime);
if (clsLoginLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--LoginLog(登录日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:LoginUserId_LoginIP_LoginTime
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objLoginLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsLoginLogEN objLoginLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objLoginLogEN == null) return "";
if (objLoginLogEN.LoginLogId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objLoginLogEN.LoginUserId == null)
{
 sbCondition.AppendFormat(" and LoginUserId is null", objLoginLogEN.LoginUserId);
}
else
{
 sbCondition.AppendFormat(" and LoginUserId = '{0}'", objLoginLogEN.LoginUserId);
}
 if (objLoginLogEN.LoginIP == null)
{
 sbCondition.AppendFormat(" and LoginIP is null", objLoginLogEN.LoginIP);
}
else
{
 sbCondition.AppendFormat(" and LoginIP = '{0}'", objLoginLogEN.LoginIP);
}
 if (objLoginLogEN.LoginTime == null)
{
 sbCondition.AppendFormat(" and LoginTime is null", objLoginLogEN.LoginTime);
}
else
{
 sbCondition.AppendFormat(" and LoginTime = '{0}'", objLoginLogEN.LoginTime);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("LoginLogId !=  {0}", objLoginLogEN.LoginLogId);
 sbCondition.AppendFormat(" and LoginUserId = '{0}'", objLoginLogEN.LoginUserId);
 sbCondition.AppendFormat(" and LoginIP = '{0}'", objLoginLogEN.LoginIP);
 sbCondition.AppendFormat(" and LoginTime = '{0}'", objLoginLogEN.LoginTime);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_LoginLog
{
public virtual bool UpdRelaTabDate(long lngLoginLogId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 登录日志(LoginLog)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsLoginLogBL
{
public static RelatedActions_LoginLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsLoginLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsLoginLogDA LoginLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsLoginLogDA();
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
 public clsLoginLogBL()
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
if (string.IsNullOrEmpty(clsLoginLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsLoginLogEN._ConnectString);
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
public static DataTable GetDataTable_LoginLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = LoginLogDA.GetDataTable_LoginLog(strWhereCond);
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
objDT = LoginLogDA.GetDataTable(strWhereCond);
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
objDT = LoginLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = LoginLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = LoginLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = LoginLogDA.GetDataTable_Top(objTopPara);
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
objDT = LoginLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = LoginLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = LoginLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrLoginLogIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsLoginLogEN> GetObjLstByLoginLogIdLst(List<long> arrLoginLogIdLst)
{
List<clsLoginLogEN> arrObjLst = new List<clsLoginLogEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrLoginLogIdLst);
 string strWhereCond = string.Format("LoginLogId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLoginLogEN objLoginLogEN = new clsLoginLogEN();
try
{
objLoginLogEN.LoginLogId = Int32.Parse(objRow[conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objLoginLogEN.LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objLoginLogEN.LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP
objLoginLogEN.FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(); //FailReason
objLoginLogEN.LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult
objLoginLogEN.LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime
objLoginLogEN.LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objLoginLogEN.OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objLoginLogEN.OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(); //OutTime
objLoginLogEN.Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLoginLogEN.LoginLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLoginLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrLoginLogIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsLoginLogEN> GetObjLstByLoginLogIdLstCache(List<long> arrLoginLogIdLst)
{
string strKey = string.Format("{0}", clsLoginLogEN._CurrTabName);
List<clsLoginLogEN> arrLoginLogObjLstCache = GetObjLstCache();
IEnumerable <clsLoginLogEN> arrLoginLogObjLst_Sel =
arrLoginLogObjLstCache
.Where(x => arrLoginLogIdLst.Contains(x.LoginLogId));
return arrLoginLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsLoginLogEN> GetObjLst(string strWhereCond)
{
List<clsLoginLogEN> arrObjLst = new List<clsLoginLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLoginLogEN objLoginLogEN = new clsLoginLogEN();
try
{
objLoginLogEN.LoginLogId = Int32.Parse(objRow[conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objLoginLogEN.LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objLoginLogEN.LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP
objLoginLogEN.FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(); //FailReason
objLoginLogEN.LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult
objLoginLogEN.LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime
objLoginLogEN.LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objLoginLogEN.OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objLoginLogEN.OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(); //OutTime
objLoginLogEN.Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLoginLogEN.LoginLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLoginLogEN);
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
public static List<clsLoginLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsLoginLogEN> arrObjLst = new List<clsLoginLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLoginLogEN objLoginLogEN = new clsLoginLogEN();
try
{
objLoginLogEN.LoginLogId = Int32.Parse(objRow[conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objLoginLogEN.LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objLoginLogEN.LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP
objLoginLogEN.FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(); //FailReason
objLoginLogEN.LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult
objLoginLogEN.LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime
objLoginLogEN.LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objLoginLogEN.OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objLoginLogEN.OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(); //OutTime
objLoginLogEN.Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLoginLogEN.LoginLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLoginLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objLoginLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsLoginLogEN> GetSubObjLstCache(clsLoginLogEN objLoginLogCond)
{
List<clsLoginLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsLoginLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conLoginLog.AttributeName)
{
if (objLoginLogCond.IsUpdated(strFldName) == false) continue;
if (objLoginLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLoginLogCond[strFldName].ToString());
}
else
{
if (objLoginLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objLoginLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLoginLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objLoginLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objLoginLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objLoginLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objLoginLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objLoginLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objLoginLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objLoginLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objLoginLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objLoginLogCond[strFldName]));
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
public static List<clsLoginLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsLoginLogEN> arrObjLst = new List<clsLoginLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLoginLogEN objLoginLogEN = new clsLoginLogEN();
try
{
objLoginLogEN.LoginLogId = Int32.Parse(objRow[conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objLoginLogEN.LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objLoginLogEN.LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP
objLoginLogEN.FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(); //FailReason
objLoginLogEN.LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult
objLoginLogEN.LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime
objLoginLogEN.LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objLoginLogEN.OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objLoginLogEN.OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(); //OutTime
objLoginLogEN.Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLoginLogEN.LoginLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLoginLogEN);
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
public static List<clsLoginLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsLoginLogEN> arrObjLst = new List<clsLoginLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLoginLogEN objLoginLogEN = new clsLoginLogEN();
try
{
objLoginLogEN.LoginLogId = Int32.Parse(objRow[conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objLoginLogEN.LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objLoginLogEN.LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP
objLoginLogEN.FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(); //FailReason
objLoginLogEN.LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult
objLoginLogEN.LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime
objLoginLogEN.LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objLoginLogEN.OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objLoginLogEN.OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(); //OutTime
objLoginLogEN.Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLoginLogEN.LoginLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLoginLogEN);
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
List<clsLoginLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsLoginLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsLoginLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsLoginLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsLoginLogEN> arrObjLst = new List<clsLoginLogEN>(); 
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
	clsLoginLogEN objLoginLogEN = new clsLoginLogEN();
try
{
objLoginLogEN.LoginLogId = Int32.Parse(objRow[conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objLoginLogEN.LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objLoginLogEN.LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP
objLoginLogEN.FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(); //FailReason
objLoginLogEN.LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult
objLoginLogEN.LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime
objLoginLogEN.LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objLoginLogEN.OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objLoginLogEN.OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(); //OutTime
objLoginLogEN.Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLoginLogEN.LoginLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLoginLogEN);
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
public static List<clsLoginLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsLoginLogEN> arrObjLst = new List<clsLoginLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLoginLogEN objLoginLogEN = new clsLoginLogEN();
try
{
objLoginLogEN.LoginLogId = Int32.Parse(objRow[conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objLoginLogEN.LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objLoginLogEN.LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP
objLoginLogEN.FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(); //FailReason
objLoginLogEN.LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult
objLoginLogEN.LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime
objLoginLogEN.LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objLoginLogEN.OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objLoginLogEN.OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(); //OutTime
objLoginLogEN.Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLoginLogEN.LoginLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLoginLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsLoginLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsLoginLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsLoginLogEN> arrObjLst = new List<clsLoginLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLoginLogEN objLoginLogEN = new clsLoginLogEN();
try
{
objLoginLogEN.LoginLogId = Int32.Parse(objRow[conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objLoginLogEN.LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objLoginLogEN.LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP
objLoginLogEN.FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(); //FailReason
objLoginLogEN.LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult
objLoginLogEN.LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime
objLoginLogEN.LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objLoginLogEN.OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objLoginLogEN.OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(); //OutTime
objLoginLogEN.Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLoginLogEN.LoginLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLoginLogEN);
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
public static List<clsLoginLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsLoginLogEN> arrObjLst = new List<clsLoginLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLoginLogEN objLoginLogEN = new clsLoginLogEN();
try
{
objLoginLogEN.LoginLogId = Int32.Parse(objRow[conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objLoginLogEN.LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objLoginLogEN.LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP
objLoginLogEN.FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(); //FailReason
objLoginLogEN.LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult
objLoginLogEN.LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime
objLoginLogEN.LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objLoginLogEN.OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objLoginLogEN.OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(); //OutTime
objLoginLogEN.Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLoginLogEN.LoginLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLoginLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsLoginLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsLoginLogEN> arrObjLst = new List<clsLoginLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLoginLogEN objLoginLogEN = new clsLoginLogEN();
try
{
objLoginLogEN.LoginLogId = Int32.Parse(objRow[conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objLoginLogEN.LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objLoginLogEN.LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP
objLoginLogEN.FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(); //FailReason
objLoginLogEN.LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult
objLoginLogEN.LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime
objLoginLogEN.LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objLoginLogEN.OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objLoginLogEN.OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(); //OutTime
objLoginLogEN.Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLoginLogEN.LoginLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLoginLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objLoginLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetLoginLog(ref clsLoginLogEN objLoginLogEN)
{
bool bolResult = LoginLogDA.GetLoginLog(ref objLoginLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngLoginLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsLoginLogEN GetObjByLoginLogId(long lngLoginLogId)
{
clsLoginLogEN objLoginLogEN = LoginLogDA.GetObjByLoginLogId(lngLoginLogId);
return objLoginLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsLoginLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsLoginLogEN objLoginLogEN = LoginLogDA.GetFirstObj(strWhereCond);
 return objLoginLogEN;
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
public static clsLoginLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsLoginLogEN objLoginLogEN = LoginLogDA.GetObjByDataRow(objRow);
 return objLoginLogEN;
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
public static clsLoginLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsLoginLogEN objLoginLogEN = LoginLogDA.GetObjByDataRow(objRow);
 return objLoginLogEN;
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
 /// <param name = "lngLoginLogId">所给的关键字</param>
 /// <param name = "lstLoginLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsLoginLogEN GetObjByLoginLogIdFromList(long lngLoginLogId, List<clsLoginLogEN> lstLoginLogObjLst)
{
foreach (clsLoginLogEN objLoginLogEN in lstLoginLogObjLst)
{
if (objLoginLogEN.LoginLogId == lngLoginLogId)
{
return objLoginLogEN;
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
 long lngLoginLogId;
 try
 {
 lngLoginLogId = new clsLoginLogDA().GetFirstID(strWhereCond);
 return lngLoginLogId;
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
 arrList = LoginLogDA.GetID(strWhereCond);
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
bool bolIsExist = LoginLogDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngLoginLogId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngLoginLogId)
{
//检测记录是否存在
bool bolIsExist = LoginLogDA.IsExist(lngLoginLogId);
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
 bolIsExist = clsLoginLogDA.IsExistTable();
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
 bolIsExist = LoginLogDA.IsExistTable(strTabName);
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
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsLoginLogEN objLoginLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objLoginLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!LoginUserId = [{0}],LoginIP = [{1}],LoginTime = [{2}]的数据已经存在!(in clsLoginLogBL.AddNewRecordBySql2)", objLoginLogEN.LoginUserId,objLoginLogEN.LoginIP,objLoginLogEN.LoginTime);
throw new Exception(strMsg);
}
try
{
bool bolResult = LoginLogDA.AddNewRecordBySQL2(objLoginLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogBL.ReFreshCache();

if (clsLoginLogBL.relatedActions != null)
{
clsLoginLogBL.relatedActions.UpdRelaTabDate(objLoginLogEN.LoginLogId, "SetUpdDate");
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
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsLoginLogEN objLoginLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objLoginLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!LoginUserId = [{0}],LoginIP = [{1}],LoginTime = [{2}]的数据已经存在!(in clsLoginLogBL.AddNewRecordBySql2WithReturnKey)", objLoginLogEN.LoginUserId,objLoginLogEN.LoginIP,objLoginLogEN.LoginTime);
throw new Exception(strMsg);
}
try
{
string strKey = LoginLogDA.AddNewRecordBySQL2WithReturnKey(objLoginLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogBL.ReFreshCache();

if (clsLoginLogBL.relatedActions != null)
{
clsLoginLogBL.relatedActions.UpdRelaTabDate(objLoginLogEN.LoginLogId, "SetUpdDate");
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
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsLoginLogEN objLoginLogEN)
{
try
{
bool bolResult = LoginLogDA.Update(objLoginLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogBL.ReFreshCache();

if (clsLoginLogBL.relatedActions != null)
{
clsLoginLogBL.relatedActions.UpdRelaTabDate(objLoginLogEN.LoginLogId, "SetUpdDate");
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
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsLoginLogEN objLoginLogEN)
{
 if (objLoginLogEN.LoginLogId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = LoginLogDA.UpdateBySql2(objLoginLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogBL.ReFreshCache();

if (clsLoginLogBL.relatedActions != null)
{
clsLoginLogBL.relatedActions.UpdRelaTabDate(objLoginLogEN.LoginLogId, "SetUpdDate");
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
 /// <param name = "lngLoginLogId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngLoginLogId)
{
try
{
 clsLoginLogEN objLoginLogEN = clsLoginLogBL.GetObjByLoginLogId(lngLoginLogId);

if (clsLoginLogBL.relatedActions != null)
{
clsLoginLogBL.relatedActions.UpdRelaTabDate(objLoginLogEN.LoginLogId, "SetUpdDate");
}
if (objLoginLogEN != null)
{
int intRecNum = LoginLogDA.DelRecord(lngLoginLogId);
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
/// <param name="lngLoginLogId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngLoginLogId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsLoginLogDA.GetSpecSQLObj();
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
//删除与表:[LoginLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conLoginLog.LoginLogId,
//lngLoginLogId);
//        clsLoginLogBL.DelLoginLogsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsLoginLogBL.DelRecord(lngLoginLogId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsLoginLogBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngLoginLogId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngLoginLogId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngLoginLogId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsLoginLogBL.relatedActions != null)
{
clsLoginLogBL.relatedActions.UpdRelaTabDate(lngLoginLogId, "UpdRelaTabDate");
}
bool bolResult = LoginLogDA.DelRecord(lngLoginLogId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrLoginLogIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelLoginLogs(List<string> arrLoginLogIdLst)
{
if (arrLoginLogIdLst.Count == 0) return 0;
try
{
if (clsLoginLogBL.relatedActions != null)
{
foreach (var strLoginLogId in arrLoginLogIdLst)
{
long lngLoginLogId = long.Parse(strLoginLogId);
clsLoginLogBL.relatedActions.UpdRelaTabDate(lngLoginLogId, "UpdRelaTabDate");
}
}
int intDelRecNum = LoginLogDA.DelLoginLog(arrLoginLogIdLst);
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
public static int DelLoginLogsByCond(string strWhereCond)
{
try
{
if (clsLoginLogBL.relatedActions != null)
{
List<string> arrLoginLogId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strLoginLogId in arrLoginLogId)
{
long lngLoginLogId = long.Parse(strLoginLogId);
clsLoginLogBL.relatedActions.UpdRelaTabDate(lngLoginLogId, "UpdRelaTabDate");
}
}
int intRecNum = LoginLogDA.DelLoginLog(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[LoginLog]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngLoginLogId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngLoginLogId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsLoginLogDA.GetSpecSQLObj();
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
//删除与表:[LoginLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsLoginLogBL.DelRecord(lngLoginLogId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsLoginLogBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngLoginLogId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objLoginLogENS">源对象</param>
 /// <param name = "objLoginLogENT">目标对象</param>
 public static void CopyTo(clsLoginLogEN objLoginLogENS, clsLoginLogEN objLoginLogENT)
{
try
{
objLoginLogENT.LoginLogId = objLoginLogENS.LoginLogId; //LoginLogId
objLoginLogENT.LoginLogNumber = objLoginLogENS.LoginLogNumber; //LoginLogNumber
objLoginLogENT.LoginIP = objLoginLogENS.LoginIP; //LoginIP
objLoginLogENT.FailReason = objLoginLogENS.FailReason; //FailReason
objLoginLogENT.LoginResult = objLoginLogENS.LoginResult; //LoginResult
objLoginLogENT.LoginTime = objLoginLogENS.LoginTime; //LoginTime
objLoginLogENT.LoginUserId = objLoginLogENS.LoginUserId; //LoginUserId
objLoginLogENT.OnlineTime = objLoginLogENS.OnlineTime; //OnlineTime
objLoginLogENT.OutTime = objLoginLogENS.OutTime; //OutTime
objLoginLogENT.Memo = objLoginLogENS.Memo; //备注
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
 /// <param name = "objLoginLogEN">源简化对象</param>
 public static void SetUpdFlag(clsLoginLogEN objLoginLogEN)
{
try
{
objLoginLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objLoginLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conLoginLog.LoginLogId, new clsStrCompareIgnoreCase())  ==  true)
{
objLoginLogEN.LoginLogId = objLoginLogEN.LoginLogId; //LoginLogId
}
if (arrFldSet.Contains(conLoginLog.LoginLogNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objLoginLogEN.LoginLogNumber = objLoginLogEN.LoginLogNumber == "[null]" ? null :  objLoginLogEN.LoginLogNumber; //LoginLogNumber
}
if (arrFldSet.Contains(conLoginLog.LoginIP, new clsStrCompareIgnoreCase())  ==  true)
{
objLoginLogEN.LoginIP = objLoginLogEN.LoginIP == "[null]" ? null :  objLoginLogEN.LoginIP; //LoginIP
}
if (arrFldSet.Contains(conLoginLog.FailReason, new clsStrCompareIgnoreCase())  ==  true)
{
objLoginLogEN.FailReason = objLoginLogEN.FailReason == "[null]" ? null :  objLoginLogEN.FailReason; //FailReason
}
if (arrFldSet.Contains(conLoginLog.LoginResult, new clsStrCompareIgnoreCase())  ==  true)
{
objLoginLogEN.LoginResult = objLoginLogEN.LoginResult == "[null]" ? null :  objLoginLogEN.LoginResult; //LoginResult
}
if (arrFldSet.Contains(conLoginLog.LoginTime, new clsStrCompareIgnoreCase())  ==  true)
{
objLoginLogEN.LoginTime = objLoginLogEN.LoginTime == "[null]" ? null :  objLoginLogEN.LoginTime; //LoginTime
}
if (arrFldSet.Contains(conLoginLog.LoginUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objLoginLogEN.LoginUserId = objLoginLogEN.LoginUserId == "[null]" ? null :  objLoginLogEN.LoginUserId; //LoginUserId
}
if (arrFldSet.Contains(conLoginLog.OnlineTime, new clsStrCompareIgnoreCase())  ==  true)
{
objLoginLogEN.OnlineTime = objLoginLogEN.OnlineTime == "[null]" ? null :  objLoginLogEN.OnlineTime; //OnlineTime
}
if (arrFldSet.Contains(conLoginLog.OutTime, new clsStrCompareIgnoreCase())  ==  true)
{
objLoginLogEN.OutTime = objLoginLogEN.OutTime == "[null]" ? null :  objLoginLogEN.OutTime; //OutTime
}
if (arrFldSet.Contains(conLoginLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objLoginLogEN.Memo = objLoginLogEN.Memo == "[null]" ? null :  objLoginLogEN.Memo; //备注
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
 /// <param name = "objLoginLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsLoginLogEN objLoginLogEN)
{
try
{
if (objLoginLogEN.LoginLogNumber == "[null]") objLoginLogEN.LoginLogNumber = null; //LoginLogNumber
if (objLoginLogEN.LoginIP == "[null]") objLoginLogEN.LoginIP = null; //LoginIP
if (objLoginLogEN.FailReason == "[null]") objLoginLogEN.FailReason = null; //FailReason
if (objLoginLogEN.LoginResult == "[null]") objLoginLogEN.LoginResult = null; //LoginResult
if (objLoginLogEN.LoginTime == "[null]") objLoginLogEN.LoginTime = null; //LoginTime
if (objLoginLogEN.LoginUserId == "[null]") objLoginLogEN.LoginUserId = null; //LoginUserId
if (objLoginLogEN.OnlineTime == "[null]") objLoginLogEN.OnlineTime = null; //OnlineTime
if (objLoginLogEN.OutTime == "[null]") objLoginLogEN.OutTime = null; //OutTime
if (objLoginLogEN.Memo == "[null]") objLoginLogEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsLoginLogEN objLoginLogEN)
{
 LoginLogDA.CheckPropertyNew(objLoginLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsLoginLogEN objLoginLogEN)
{
 LoginLogDA.CheckProperty4Condition(objLoginLogEN);
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
if (clsLoginLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsLoginLogBL没有刷新缓存机制(clsLoginLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by LoginLogId");
//if (arrLoginLogObjLstCache == null)
//{
//arrLoginLogObjLstCache = LoginLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngLoginLogId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsLoginLogEN GetObjByLoginLogIdCache(long lngLoginLogId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsLoginLogEN._CurrTabName);
List<clsLoginLogEN> arrLoginLogObjLstCache = GetObjLstCache();
IEnumerable <clsLoginLogEN> arrLoginLogObjLst_Sel =
arrLoginLogObjLstCache
.Where(x=> x.LoginLogId == lngLoginLogId 
);
if (arrLoginLogObjLst_Sel.Count() == 0)
{
   clsLoginLogEN obj = clsLoginLogBL.GetObjByLoginLogId(lngLoginLogId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrLoginLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsLoginLogEN> GetAllLoginLogObjLstCache()
{
//获取缓存中的对象列表
List<clsLoginLogEN> arrLoginLogObjLstCache = GetObjLstCache(); 
return arrLoginLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsLoginLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsLoginLogEN._CurrTabName);
List<clsLoginLogEN> arrLoginLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrLoginLogObjLstCache;
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
string strKey = string.Format("{0}", clsLoginLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsLoginLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsLoginLogEN._RefreshTimeLst.Count == 0) return "";
return clsLoginLogEN._RefreshTimeLst[clsLoginLogEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsLoginLogBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsLoginLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsLoginLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsLoginLogBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--LoginLog(登录日志)
 /// 唯一性条件:LoginUserId_LoginIP_LoginTime
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objLoginLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsLoginLogEN objLoginLogEN)
{
//检测记录是否存在
string strResult = LoginLogDA.GetUniCondStr(objLoginLogEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngLoginLogId)
{
if (strInFldName != conLoginLog.LoginLogId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conLoginLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conLoginLog.AttributeName));
throw new Exception(strMsg);
}
var objLoginLog = clsLoginLogBL.GetObjByLoginLogIdCache(lngLoginLogId);
if (objLoginLog == null) return "";
return objLoginLog[strOutFldName].ToString();
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
int intRecCount = clsLoginLogDA.GetRecCount(strTabName);
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
int intRecCount = clsLoginLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsLoginLogDA.GetRecCount();
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
int intRecCount = clsLoginLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objLoginLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsLoginLogEN objLoginLogCond)
{
List<clsLoginLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsLoginLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conLoginLog.AttributeName)
{
if (objLoginLogCond.IsUpdated(strFldName) == false) continue;
if (objLoginLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLoginLogCond[strFldName].ToString());
}
else
{
if (objLoginLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objLoginLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLoginLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objLoginLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objLoginLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objLoginLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objLoginLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objLoginLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objLoginLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objLoginLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objLoginLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objLoginLogCond[strFldName]));
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
 List<string> arrList = clsLoginLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = LoginLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = LoginLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = LoginLogDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsLoginLogDA.SetFldValue(clsLoginLogEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = LoginLogDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsLoginLogDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsLoginLogDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsLoginLogDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[LoginLog] "); 
 strCreateTabCode.Append(" ( "); 
 // /**LoginLogId*/ 
 strCreateTabCode.Append(" LoginLogId bigint primary key identity, "); 
 // /**LoginLogNumber*/ 
 strCreateTabCode.Append(" LoginLogNumber varchar(500) Null, "); 
 // /**LoginIP*/ 
 strCreateTabCode.Append(" LoginIP varchar(200) Null, "); 
 // /**FailReason*/ 
 strCreateTabCode.Append(" FailReason varchar(500) Null, "); 
 // /**LoginResult*/ 
 strCreateTabCode.Append(" LoginResult varchar(500) Null, "); 
 // /**LoginTime*/ 
 strCreateTabCode.Append(" LoginTime varchar(20) Null, "); 
 // /**LoginUserId*/ 
 strCreateTabCode.Append(" LoginUserId varchar(200) Null, "); 
 // /**OnlineTime*/ 
 strCreateTabCode.Append(" OnlineTime varchar(200) Null, "); 
 // /**OutTime*/ 
 strCreateTabCode.Append(" OutTime varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 登录日志(LoginLog)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4LoginLog : clsCommFun4BL
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
clsLoginLogBL.ReFreshThisCache();
}
}

}