
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataSynConfigBL
 表名:DataSynConfig(01120226)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:41
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
public static class  clsDataSynConfigBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataSynConfigEN GetObj(this K_mId_DataSynConfig myKey)
{
clsDataSynConfigEN objDataSynConfigEN = clsDataSynConfigBL.DataSynConfigDA.GetObjBymId(myKey.Value);
return objDataSynConfigEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDataSynConfigEN objDataSynConfigEN)
{
if (CheckUniqueness(objDataSynConfigEN) == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}]的数据已经存在!(in clsDataSynConfigBL.AddNewRecord)", objDataSynConfigEN.TabName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsDataSynConfigBL.DataSynConfigDA.AddNewRecordBySQL2(objDataSynConfigEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigBL.ReFreshCache();

if (clsDataSynConfigBL.relatedActions != null)
{
clsDataSynConfigBL.relatedActions.UpdRelaTabDate(objDataSynConfigEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsDataSynConfigEN objDataSynConfigEN)
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
objDataSynConfigEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objDataSynConfigEN.CheckUniqueness() == false)
{
strMsg = string.Format("(表名(TabName)=[{0}])已经存在,不能重复!", objDataSynConfigEN.TabName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objDataSynConfigEN.AddNewRecord();
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
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDataSynConfigEN objDataSynConfigEN)
{
if (CheckUniqueness(objDataSynConfigEN) == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}]的数据已经存在!(in clsDataSynConfigBL.AddNewRecordWithReturnKey)", objDataSynConfigEN.TabName);
throw new Exception(strMsg);
}
try
{
string strKey = clsDataSynConfigBL.DataSynConfigDA.AddNewRecordBySQL2WithReturnKey(objDataSynConfigEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigBL.ReFreshCache();

if (clsDataSynConfigBL.relatedActions != null)
{
clsDataSynConfigBL.relatedActions.UpdRelaTabDate(objDataSynConfigEN.mId, "SetUpdDate");
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
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetmId(this clsDataSynConfigEN objDataSynConfigEN, long lngmId, string strComparisonOp="")
	{
objDataSynConfigEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.mId) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.mId, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.mId] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetTabName(this clsDataSynConfigEN objDataSynConfigEN, string strTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 50, conDataSynConfig.TabName);
}
objDataSynConfigEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.TabName) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.TabName, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.TabName] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetIsSynch(this clsDataSynConfigEN objDataSynConfigEN, bool bolIsSynch, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsSynch, conDataSynConfig.IsSynch);
objDataSynConfigEN.IsSynch = bolIsSynch; //是否同步
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.IsSynch) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.IsSynch, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.IsSynch] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetSynCondition(this clsDataSynConfigEN objDataSynConfigEN, string strSynCondition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSynCondition, conDataSynConfig.SynCondition);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynCondition, 5000, conDataSynConfig.SynCondition);
}
objDataSynConfigEN.SynCondition = strSynCondition; //同步条件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SynCondition) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SynCondition, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SynCondition] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetSynCondition4Web(this clsDataSynConfigEN objDataSynConfigEN, string strSynCondition4Web, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynCondition4Web, 5000, conDataSynConfig.SynCondition4Web);
}
objDataSynConfigEN.SynCondition4Web = strSynCondition4Web; //同步条件4Web
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SynCondition4Web) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SynCondition4Web, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SynCondition4Web] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetSynchCycle(this clsDataSynConfigEN objDataSynConfigEN, string strSynchCycle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSynchCycle, conDataSynConfig.SynchCycle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchCycle, 30, conDataSynConfig.SynchCycle);
}
objDataSynConfigEN.SynchCycle = strSynchCycle; //同步周期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SynchCycle) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SynchCycle, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SynchCycle] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetSynchDate(this clsDataSynConfigEN objDataSynConfigEN, string strSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSynchDate, conDataSynConfig.SynchDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchDate, 30, conDataSynConfig.SynchDate);
}
objDataSynConfigEN.SynchDate = strSynchDate; //同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SynchDate) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SynchDate, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SynchDate] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetSynchTime(this clsDataSynConfigEN objDataSynConfigEN, string strSynchTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSynchTime, conDataSynConfig.SynchTime);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchTime, 30, conDataSynConfig.SynchTime);
}
objDataSynConfigEN.SynchTime = strSynchTime; //同步时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SynchTime) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SynchTime, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SynchTime] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetSenderUser(this clsDataSynConfigEN objDataSynConfigEN, string strSenderUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenderUser, 30, conDataSynConfig.SenderUser);
}
objDataSynConfigEN.SenderUser = strSenderUser; //发送邮件用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SenderUser) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SenderUser, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SenderUser] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetSenderPwd(this clsDataSynConfigEN objDataSynConfigEN, string strSenderPwd, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenderPwd, 30, conDataSynConfig.SenderPwd);
}
objDataSynConfigEN.SenderPwd = strSenderPwd; //发送邮件口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SenderPwd) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SenderPwd, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SenderPwd] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN Setsmtp(this clsDataSynConfigEN objDataSynConfigEN, string strsmtp, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsmtp, 50, conDataSynConfig.smtp);
}
objDataSynConfigEN.smtp = strsmtp; //发送邮件服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.smtp) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.smtp, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.smtp] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetReceiver(this clsDataSynConfigEN objDataSynConfigEN, string strReceiver, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReceiver, 50, conDataSynConfig.Receiver);
}
objDataSynConfigEN.Receiver = strReceiver; //接收者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.Receiver) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.Receiver, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.Receiver] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetlastMailDate(this clsDataSynConfigEN objDataSynConfigEN, string strlastMailDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strlastMailDate, 50, conDataSynConfig.lastMailDate);
}
objDataSynConfigEN.lastMailDate = strlastMailDate; //最后发邮件日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.lastMailDate) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.lastMailDate, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.lastMailDate] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetlastExecuteDate(this clsDataSynConfigEN objDataSynConfigEN, string strlastExecuteDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strlastExecuteDate, 50, conDataSynConfig.lastExecuteDate);
}
objDataSynConfigEN.lastExecuteDate = strlastExecuteDate; //最后执行日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.lastExecuteDate) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.lastExecuteDate, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.lastExecuteDate] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetSynchStartTime(this clsDataSynConfigEN objDataSynConfigEN, string strSynchStartTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchStartTime, 14, conDataSynConfig.SynchStartTime);
}
objDataSynConfigEN.SynchStartTime = strSynchStartTime; //同步开始时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SynchStartTime) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SynchStartTime, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SynchStartTime] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetSynchEndTime(this clsDataSynConfigEN objDataSynConfigEN, string strSynchEndTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchEndTime, 14, conDataSynConfig.SynchEndTime);
}
objDataSynConfigEN.SynchEndTime = strSynchEndTime; //同步结束时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SynchEndTime) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SynchEndTime, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SynchEndTime] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataSynConfigEN SetMemo(this clsDataSynConfigEN objDataSynConfigEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDataSynConfig.Memo);
}
objDataSynConfigEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.Memo) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.Memo, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.Memo] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDataSynConfigEN objDataSynConfigEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDataSynConfigEN.CheckPropertyNew();
clsDataSynConfigEN objDataSynConfigCond = new clsDataSynConfigEN();
string strCondition = objDataSynConfigCond
.SetmId(objDataSynConfigEN.mId, "<>")
.SetTabName(objDataSynConfigEN.TabName, "=")
.GetCombineCondition();
objDataSynConfigEN._IsCheckProperty = true;
bool bolIsExist = clsDataSynConfigBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TabName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDataSynConfigEN.Update();
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
 /// <param name = "objDataSynConfig">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsDataSynConfigEN objDataSynConfig)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsDataSynConfigEN objDataSynConfigCond = new clsDataSynConfigEN();
string strCondition = objDataSynConfigCond
.SetTabName(objDataSynConfig.TabName, "=")
.GetCombineCondition();
objDataSynConfig._IsCheckProperty = true;
bool bolIsExist = clsDataSynConfigBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objDataSynConfig.mId = clsDataSynConfigBL.GetFirstID_S(strCondition);
objDataSynConfig.UpdateWithCondition(strCondition);
}
else
{
objDataSynConfig.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataSynConfigEN objDataSynConfigEN)
{
 if (objDataSynConfigEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDataSynConfigBL.DataSynConfigDA.UpdateBySql2(objDataSynConfigEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigBL.ReFreshCache();

if (clsDataSynConfigBL.relatedActions != null)
{
clsDataSynConfigBL.relatedActions.UpdRelaTabDate(objDataSynConfigEN.mId, "SetUpdDate");
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
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataSynConfigEN objDataSynConfigEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDataSynConfigEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDataSynConfigBL.DataSynConfigDA.UpdateBySql2(objDataSynConfigEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigBL.ReFreshCache();

if (clsDataSynConfigBL.relatedActions != null)
{
clsDataSynConfigBL.relatedActions.UpdRelaTabDate(objDataSynConfigEN.mId, "SetUpdDate");
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
 /// <param name = "objDataSynConfigEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataSynConfigEN objDataSynConfigEN, string strWhereCond)
{
try
{
bool bolResult = clsDataSynConfigBL.DataSynConfigDA.UpdateBySqlWithCondition(objDataSynConfigEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigBL.ReFreshCache();

if (clsDataSynConfigBL.relatedActions != null)
{
clsDataSynConfigBL.relatedActions.UpdRelaTabDate(objDataSynConfigEN.mId, "SetUpdDate");
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
 /// <param name = "objDataSynConfigEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataSynConfigEN objDataSynConfigEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDataSynConfigBL.DataSynConfigDA.UpdateBySqlWithConditionTransaction(objDataSynConfigEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigBL.ReFreshCache();

if (clsDataSynConfigBL.relatedActions != null)
{
clsDataSynConfigBL.relatedActions.UpdRelaTabDate(objDataSynConfigEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDataSynConfigEN objDataSynConfigEN)
{
try
{
int intRecNum = clsDataSynConfigBL.DataSynConfigDA.DelRecord(objDataSynConfigEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigBL.ReFreshCache();

if (clsDataSynConfigBL.relatedActions != null)
{
clsDataSynConfigBL.relatedActions.UpdRelaTabDate(objDataSynConfigEN.mId, "SetUpdDate");
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
 /// <param name = "objDataSynConfigENS">源对象</param>
 /// <param name = "objDataSynConfigENT">目标对象</param>
 public static void CopyTo(this clsDataSynConfigEN objDataSynConfigENS, clsDataSynConfigEN objDataSynConfigENT)
{
try
{
objDataSynConfigENT.mId = objDataSynConfigENS.mId; //mId
objDataSynConfigENT.TabName = objDataSynConfigENS.TabName; //表名
objDataSynConfigENT.IsSynch = objDataSynConfigENS.IsSynch; //是否同步
objDataSynConfigENT.SynCondition = objDataSynConfigENS.SynCondition; //同步条件
objDataSynConfigENT.SynCondition4Web = objDataSynConfigENS.SynCondition4Web; //同步条件4Web
objDataSynConfigENT.SynchCycle = objDataSynConfigENS.SynchCycle; //同步周期
objDataSynConfigENT.SynchDate = objDataSynConfigENS.SynchDate; //同步日期
objDataSynConfigENT.SynchTime = objDataSynConfigENS.SynchTime; //同步时间
objDataSynConfigENT.SenderUser = objDataSynConfigENS.SenderUser; //发送邮件用户
objDataSynConfigENT.SenderPwd = objDataSynConfigENS.SenderPwd; //发送邮件口令
objDataSynConfigENT.smtp = objDataSynConfigENS.smtp; //发送邮件服务器
objDataSynConfigENT.Receiver = objDataSynConfigENS.Receiver; //接收者
objDataSynConfigENT.lastMailDate = objDataSynConfigENS.lastMailDate; //最后发邮件日期
objDataSynConfigENT.lastExecuteDate = objDataSynConfigENS.lastExecuteDate; //最后执行日期
objDataSynConfigENT.SynchStartTime = objDataSynConfigENS.SynchStartTime; //同步开始时间
objDataSynConfigENT.SynchEndTime = objDataSynConfigENS.SynchEndTime; //同步结束时间
objDataSynConfigENT.Memo = objDataSynConfigENS.Memo; //备注
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
 /// <param name = "objDataSynConfigENS">源对象</param>
 /// <returns>目标对象=>clsDataSynConfigEN:objDataSynConfigENT</returns>
 public static clsDataSynConfigEN CopyTo(this clsDataSynConfigEN objDataSynConfigENS)
{
try
{
 clsDataSynConfigEN objDataSynConfigENT = new clsDataSynConfigEN()
{
mId = objDataSynConfigENS.mId, //mId
TabName = objDataSynConfigENS.TabName, //表名
IsSynch = objDataSynConfigENS.IsSynch, //是否同步
SynCondition = objDataSynConfigENS.SynCondition, //同步条件
SynCondition4Web = objDataSynConfigENS.SynCondition4Web, //同步条件4Web
SynchCycle = objDataSynConfigENS.SynchCycle, //同步周期
SynchDate = objDataSynConfigENS.SynchDate, //同步日期
SynchTime = objDataSynConfigENS.SynchTime, //同步时间
SenderUser = objDataSynConfigENS.SenderUser, //发送邮件用户
SenderPwd = objDataSynConfigENS.SenderPwd, //发送邮件口令
smtp = objDataSynConfigENS.smtp, //发送邮件服务器
Receiver = objDataSynConfigENS.Receiver, //接收者
lastMailDate = objDataSynConfigENS.lastMailDate, //最后发邮件日期
lastExecuteDate = objDataSynConfigENS.lastExecuteDate, //最后执行日期
SynchStartTime = objDataSynConfigENS.SynchStartTime, //同步开始时间
SynchEndTime = objDataSynConfigENS.SynchEndTime, //同步结束时间
Memo = objDataSynConfigENS.Memo, //备注
};
 return objDataSynConfigENT;
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
public static void CheckPropertyNew(this clsDataSynConfigEN objDataSynConfigEN)
{
 clsDataSynConfigBL.DataSynConfigDA.CheckPropertyNew(objDataSynConfigEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDataSynConfigEN objDataSynConfigEN)
{
 clsDataSynConfigBL.DataSynConfigDA.CheckProperty4Condition(objDataSynConfigEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDataSynConfigEN objDataSynConfigCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.mId) == true)
{
string strComparisonOpmId = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conDataSynConfig.mId, objDataSynConfigCond.mId, strComparisonOpmId);
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.TabName) == true)
{
string strComparisonOpTabName = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.TabName, objDataSynConfigCond.TabName, strComparisonOpTabName);
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.IsSynch) == true)
{
if (objDataSynConfigCond.IsSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataSynConfig.IsSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataSynConfig.IsSynch);
}
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.SynCondition) == true)
{
string strComparisonOpSynCondition = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.SynCondition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SynCondition, objDataSynConfigCond.SynCondition, strComparisonOpSynCondition);
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.SynCondition4Web) == true)
{
string strComparisonOpSynCondition4Web = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.SynCondition4Web];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SynCondition4Web, objDataSynConfigCond.SynCondition4Web, strComparisonOpSynCondition4Web);
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.SynchCycle) == true)
{
string strComparisonOpSynchCycle = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.SynchCycle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SynchCycle, objDataSynConfigCond.SynchCycle, strComparisonOpSynchCycle);
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.SynchDate) == true)
{
string strComparisonOpSynchDate = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.SynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SynchDate, objDataSynConfigCond.SynchDate, strComparisonOpSynchDate);
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.SynchTime) == true)
{
string strComparisonOpSynchTime = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.SynchTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SynchTime, objDataSynConfigCond.SynchTime, strComparisonOpSynchTime);
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.SenderUser) == true)
{
string strComparisonOpSenderUser = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.SenderUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SenderUser, objDataSynConfigCond.SenderUser, strComparisonOpSenderUser);
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.SenderPwd) == true)
{
string strComparisonOpSenderPwd = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.SenderPwd];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SenderPwd, objDataSynConfigCond.SenderPwd, strComparisonOpSenderPwd);
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.smtp) == true)
{
string strComparisonOpsmtp = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.smtp];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.smtp, objDataSynConfigCond.smtp, strComparisonOpsmtp);
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.Receiver) == true)
{
string strComparisonOpReceiver = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.Receiver];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.Receiver, objDataSynConfigCond.Receiver, strComparisonOpReceiver);
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.lastMailDate) == true)
{
string strComparisonOplastMailDate = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.lastMailDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.lastMailDate, objDataSynConfigCond.lastMailDate, strComparisonOplastMailDate);
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.lastExecuteDate) == true)
{
string strComparisonOplastExecuteDate = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.lastExecuteDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.lastExecuteDate, objDataSynConfigCond.lastExecuteDate, strComparisonOplastExecuteDate);
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.SynchStartTime) == true)
{
string strComparisonOpSynchStartTime = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.SynchStartTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SynchStartTime, objDataSynConfigCond.SynchStartTime, strComparisonOpSynchStartTime);
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.SynchEndTime) == true)
{
string strComparisonOpSynchEndTime = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.SynchEndTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SynchEndTime, objDataSynConfigCond.SynchEndTime, strComparisonOpSynchEndTime);
}
if (objDataSynConfigCond.IsUpdated(conDataSynConfig.Memo) == true)
{
string strComparisonOpMemo = objDataSynConfigCond.dicFldComparisonOp[conDataSynConfig.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.Memo, objDataSynConfigCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--DataSynConfig(同步配置), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TabName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objDataSynConfigEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsDataSynConfigEN objDataSynConfigEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objDataSynConfigEN == null) return true;
if (objDataSynConfigEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objDataSynConfigEN.TabName == null)
{
 sbCondition.AppendFormat(" and TabName is null", objDataSynConfigEN.TabName);
}
else
{
 sbCondition.AppendFormat(" and TabName = '{0}'", objDataSynConfigEN.TabName);
}
if (clsDataSynConfigBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objDataSynConfigEN.mId);
 sbCondition.AppendFormat(" and TabName = '{0}'", objDataSynConfigEN.TabName);
if (clsDataSynConfigBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--DataSynConfig(同步配置), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDataSynConfigEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsDataSynConfigEN objDataSynConfigEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDataSynConfigEN == null) return "";
if (objDataSynConfigEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objDataSynConfigEN.TabName == null)
{
 sbCondition.AppendFormat(" and TabName is null", objDataSynConfigEN.TabName);
}
else
{
 sbCondition.AppendFormat(" and TabName = '{0}'", objDataSynConfigEN.TabName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objDataSynConfigEN.mId);
 sbCondition.AppendFormat(" and TabName = '{0}'", objDataSynConfigEN.TabName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DataSynConfig
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 同步配置(DataSynConfig)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDataSynConfigBL
{
public static RelatedActions_DataSynConfig relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDataSynConfigDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDataSynConfigDA DataSynConfigDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDataSynConfigDA();
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
 public clsDataSynConfigBL()
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
if (string.IsNullOrEmpty(clsDataSynConfigEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDataSynConfigEN._ConnectString);
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
public static DataTable GetDataTable_DataSynConfig(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DataSynConfigDA.GetDataTable_DataSynConfig(strWhereCond);
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
objDT = DataSynConfigDA.GetDataTable(strWhereCond);
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
objDT = DataSynConfigDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DataSynConfigDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DataSynConfigDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DataSynConfigDA.GetDataTable_Top(objTopPara);
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
objDT = DataSynConfigDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DataSynConfigDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DataSynConfigDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDataSynConfigEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsDataSynConfigEN> arrObjLst = new List<clsDataSynConfigEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
objDataSynConfigEN.mId = Int32.Parse(objRow[conDataSynConfig.mId].ToString().Trim()); //mId
objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objDataSynConfigEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步
objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataSynConfigEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataSynConfigEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDataSynConfigEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsDataSynConfigEN._CurrTabName);
List<clsDataSynConfigEN> arrDataSynConfigObjLstCache = GetObjLstCache();
IEnumerable <clsDataSynConfigEN> arrDataSynConfigObjLst_Sel =
arrDataSynConfigObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrDataSynConfigObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataSynConfigEN> GetObjLst(string strWhereCond)
{
List<clsDataSynConfigEN> arrObjLst = new List<clsDataSynConfigEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
objDataSynConfigEN.mId = Int32.Parse(objRow[conDataSynConfig.mId].ToString().Trim()); //mId
objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objDataSynConfigEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步
objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataSynConfigEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataSynConfigEN);
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
public static List<clsDataSynConfigEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDataSynConfigEN> arrObjLst = new List<clsDataSynConfigEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
objDataSynConfigEN.mId = Int32.Parse(objRow[conDataSynConfig.mId].ToString().Trim()); //mId
objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objDataSynConfigEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步
objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataSynConfigEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataSynConfigEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDataSynConfigCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDataSynConfigEN> GetSubObjLstCache(clsDataSynConfigEN objDataSynConfigCond)
{
List<clsDataSynConfigEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDataSynConfigEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDataSynConfig.AttributeName)
{
if (objDataSynConfigCond.IsUpdated(strFldName) == false) continue;
if (objDataSynConfigCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataSynConfigCond[strFldName].ToString());
}
else
{
if (objDataSynConfigCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDataSynConfigCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataSynConfigCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDataSynConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDataSynConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDataSynConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDataSynConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDataSynConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDataSynConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDataSynConfigCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDataSynConfigCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDataSynConfigCond[strFldName]));
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
public static List<clsDataSynConfigEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDataSynConfigEN> arrObjLst = new List<clsDataSynConfigEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
objDataSynConfigEN.mId = Int32.Parse(objRow[conDataSynConfig.mId].ToString().Trim()); //mId
objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objDataSynConfigEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步
objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataSynConfigEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataSynConfigEN);
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
public static List<clsDataSynConfigEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDataSynConfigEN> arrObjLst = new List<clsDataSynConfigEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
objDataSynConfigEN.mId = Int32.Parse(objRow[conDataSynConfig.mId].ToString().Trim()); //mId
objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objDataSynConfigEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步
objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataSynConfigEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataSynConfigEN);
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
List<clsDataSynConfigEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDataSynConfigEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataSynConfigEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDataSynConfigEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDataSynConfigEN> arrObjLst = new List<clsDataSynConfigEN>(); 
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
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
objDataSynConfigEN.mId = Int32.Parse(objRow[conDataSynConfig.mId].ToString().Trim()); //mId
objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objDataSynConfigEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步
objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataSynConfigEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataSynConfigEN);
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
public static List<clsDataSynConfigEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDataSynConfigEN> arrObjLst = new List<clsDataSynConfigEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
objDataSynConfigEN.mId = Int32.Parse(objRow[conDataSynConfig.mId].ToString().Trim()); //mId
objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objDataSynConfigEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步
objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataSynConfigEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataSynConfigEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDataSynConfigEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDataSynConfigEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDataSynConfigEN> arrObjLst = new List<clsDataSynConfigEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
objDataSynConfigEN.mId = Int32.Parse(objRow[conDataSynConfig.mId].ToString().Trim()); //mId
objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objDataSynConfigEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步
objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataSynConfigEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataSynConfigEN);
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
public static List<clsDataSynConfigEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDataSynConfigEN> arrObjLst = new List<clsDataSynConfigEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
objDataSynConfigEN.mId = Int32.Parse(objRow[conDataSynConfig.mId].ToString().Trim()); //mId
objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objDataSynConfigEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步
objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataSynConfigEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataSynConfigEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataSynConfigEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDataSynConfigEN> arrObjLst = new List<clsDataSynConfigEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
objDataSynConfigEN.mId = Int32.Parse(objRow[conDataSynConfig.mId].ToString().Trim()); //mId
objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objDataSynConfigEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步
objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataSynConfigEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataSynConfigEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDataSynConfigEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDataSynConfig(ref clsDataSynConfigEN objDataSynConfigEN)
{
bool bolResult = DataSynConfigDA.GetDataSynConfig(ref objDataSynConfigEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataSynConfigEN GetObjBymId(long lngmId)
{
clsDataSynConfigEN objDataSynConfigEN = DataSynConfigDA.GetObjBymId(lngmId);
return objDataSynConfigEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDataSynConfigEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDataSynConfigEN objDataSynConfigEN = DataSynConfigDA.GetFirstObj(strWhereCond);
 return objDataSynConfigEN;
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
public static clsDataSynConfigEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDataSynConfigEN objDataSynConfigEN = DataSynConfigDA.GetObjByDataRow(objRow);
 return objDataSynConfigEN;
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
public static clsDataSynConfigEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDataSynConfigEN objDataSynConfigEN = DataSynConfigDA.GetObjByDataRow(objRow);
 return objDataSynConfigEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstDataSynConfigObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataSynConfigEN GetObjBymIdFromList(long lngmId, List<clsDataSynConfigEN> lstDataSynConfigObjLst)
{
foreach (clsDataSynConfigEN objDataSynConfigEN in lstDataSynConfigObjLst)
{
if (objDataSynConfigEN.mId == lngmId)
{
return objDataSynConfigEN;
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
 long lngmId;
 try
 {
 lngmId = new clsDataSynConfigDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = DataSynConfigDA.GetID(strWhereCond);
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
bool bolIsExist = DataSynConfigDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = DataSynConfigDA.IsExist(lngmId);
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
 bolIsExist = clsDataSynConfigDA.IsExistTable();
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
 bolIsExist = DataSynConfigDA.IsExistTable(strTabName);
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
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDataSynConfigEN objDataSynConfigEN)
{
if (objDataSynConfigEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}]的数据已经存在!(in clsDataSynConfigBL.AddNewRecordBySql2)", objDataSynConfigEN.TabName);
throw new Exception(strMsg);
}
try
{
bool bolResult = DataSynConfigDA.AddNewRecordBySQL2(objDataSynConfigEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigBL.ReFreshCache();

if (clsDataSynConfigBL.relatedActions != null)
{
clsDataSynConfigBL.relatedActions.UpdRelaTabDate(objDataSynConfigEN.mId, "SetUpdDate");
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
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDataSynConfigEN objDataSynConfigEN)
{
if (objDataSynConfigEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}]的数据已经存在!(in clsDataSynConfigBL.AddNewRecordBySql2WithReturnKey)", objDataSynConfigEN.TabName);
throw new Exception(strMsg);
}
try
{
string strKey = DataSynConfigDA.AddNewRecordBySQL2WithReturnKey(objDataSynConfigEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigBL.ReFreshCache();

if (clsDataSynConfigBL.relatedActions != null)
{
clsDataSynConfigBL.relatedActions.UpdRelaTabDate(objDataSynConfigEN.mId, "SetUpdDate");
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
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDataSynConfigEN objDataSynConfigEN)
{
try
{
bool bolResult = DataSynConfigDA.Update(objDataSynConfigEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigBL.ReFreshCache();

if (clsDataSynConfigBL.relatedActions != null)
{
clsDataSynConfigBL.relatedActions.UpdRelaTabDate(objDataSynConfigEN.mId, "SetUpdDate");
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
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDataSynConfigEN objDataSynConfigEN)
{
 if (objDataSynConfigEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DataSynConfigDA.UpdateBySql2(objDataSynConfigEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigBL.ReFreshCache();

if (clsDataSynConfigBL.relatedActions != null)
{
clsDataSynConfigBL.relatedActions.UpdRelaTabDate(objDataSynConfigEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsDataSynConfigEN objDataSynConfigEN = clsDataSynConfigBL.GetObjBymId(lngmId);

if (clsDataSynConfigBL.relatedActions != null)
{
clsDataSynConfigBL.relatedActions.UpdRelaTabDate(objDataSynConfigEN.mId, "SetUpdDate");
}
if (objDataSynConfigEN != null)
{
int intRecNum = DataSynConfigDA.DelRecord(lngmId);
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDataSynConfigDA.GetSpecSQLObj();
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
//删除与表:[DataSynConfig]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDataSynConfig.mId,
//lngmId);
//        clsDataSynConfigBL.DelDataSynConfigsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDataSynConfigBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDataSynConfigBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDataSynConfigBL.relatedActions != null)
{
clsDataSynConfigBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = DataSynConfigDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDataSynConfigs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsDataSynConfigBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsDataSynConfigBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = DataSynConfigDA.DelDataSynConfig(arrmIdLst);
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
public static int DelDataSynConfigsByCond(string strWhereCond)
{
try
{
if (clsDataSynConfigBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsDataSynConfigBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = DataSynConfigDA.DelDataSynConfig(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DataSynConfig]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDataSynConfigDA.GetSpecSQLObj();
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
//删除与表:[DataSynConfig]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDataSynConfigBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDataSynConfigBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDataSynConfigENS">源对象</param>
 /// <param name = "objDataSynConfigENT">目标对象</param>
 public static void CopyTo(clsDataSynConfigEN objDataSynConfigENS, clsDataSynConfigEN objDataSynConfigENT)
{
try
{
objDataSynConfigENT.mId = objDataSynConfigENS.mId; //mId
objDataSynConfigENT.TabName = objDataSynConfigENS.TabName; //表名
objDataSynConfigENT.IsSynch = objDataSynConfigENS.IsSynch; //是否同步
objDataSynConfigENT.SynCondition = objDataSynConfigENS.SynCondition; //同步条件
objDataSynConfigENT.SynCondition4Web = objDataSynConfigENS.SynCondition4Web; //同步条件4Web
objDataSynConfigENT.SynchCycle = objDataSynConfigENS.SynchCycle; //同步周期
objDataSynConfigENT.SynchDate = objDataSynConfigENS.SynchDate; //同步日期
objDataSynConfigENT.SynchTime = objDataSynConfigENS.SynchTime; //同步时间
objDataSynConfigENT.SenderUser = objDataSynConfigENS.SenderUser; //发送邮件用户
objDataSynConfigENT.SenderPwd = objDataSynConfigENS.SenderPwd; //发送邮件口令
objDataSynConfigENT.smtp = objDataSynConfigENS.smtp; //发送邮件服务器
objDataSynConfigENT.Receiver = objDataSynConfigENS.Receiver; //接收者
objDataSynConfigENT.lastMailDate = objDataSynConfigENS.lastMailDate; //最后发邮件日期
objDataSynConfigENT.lastExecuteDate = objDataSynConfigENS.lastExecuteDate; //最后执行日期
objDataSynConfigENT.SynchStartTime = objDataSynConfigENS.SynchStartTime; //同步开始时间
objDataSynConfigENT.SynchEndTime = objDataSynConfigENS.SynchEndTime; //同步结束时间
objDataSynConfigENT.Memo = objDataSynConfigENS.Memo; //备注
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
 /// <param name = "objDataSynConfigEN">源简化对象</param>
 public static void SetUpdFlag(clsDataSynConfigEN objDataSynConfigEN)
{
try
{
objDataSynConfigEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDataSynConfigEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDataSynConfig.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.mId = objDataSynConfigEN.mId; //mId
}
if (arrFldSet.Contains(conDataSynConfig.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.TabName = objDataSynConfigEN.TabName == "[null]" ? null :  objDataSynConfigEN.TabName; //表名
}
if (arrFldSet.Contains(conDataSynConfig.IsSynch, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.IsSynch = objDataSynConfigEN.IsSynch; //是否同步
}
if (arrFldSet.Contains(conDataSynConfig.SynCondition, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.SynCondition = objDataSynConfigEN.SynCondition; //同步条件
}
if (arrFldSet.Contains(conDataSynConfig.SynCondition4Web, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.SynCondition4Web = objDataSynConfigEN.SynCondition4Web == "[null]" ? null :  objDataSynConfigEN.SynCondition4Web; //同步条件4Web
}
if (arrFldSet.Contains(conDataSynConfig.SynchCycle, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.SynchCycle = objDataSynConfigEN.SynchCycle; //同步周期
}
if (arrFldSet.Contains(conDataSynConfig.SynchDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.SynchDate = objDataSynConfigEN.SynchDate; //同步日期
}
if (arrFldSet.Contains(conDataSynConfig.SynchTime, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.SynchTime = objDataSynConfigEN.SynchTime; //同步时间
}
if (arrFldSet.Contains(conDataSynConfig.SenderUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.SenderUser = objDataSynConfigEN.SenderUser == "[null]" ? null :  objDataSynConfigEN.SenderUser; //发送邮件用户
}
if (arrFldSet.Contains(conDataSynConfig.SenderPwd, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.SenderPwd = objDataSynConfigEN.SenderPwd == "[null]" ? null :  objDataSynConfigEN.SenderPwd; //发送邮件口令
}
if (arrFldSet.Contains(conDataSynConfig.smtp, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.smtp = objDataSynConfigEN.smtp == "[null]" ? null :  objDataSynConfigEN.smtp; //发送邮件服务器
}
if (arrFldSet.Contains(conDataSynConfig.Receiver, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.Receiver = objDataSynConfigEN.Receiver == "[null]" ? null :  objDataSynConfigEN.Receiver; //接收者
}
if (arrFldSet.Contains(conDataSynConfig.lastMailDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.lastMailDate = objDataSynConfigEN.lastMailDate == "[null]" ? null :  objDataSynConfigEN.lastMailDate; //最后发邮件日期
}
if (arrFldSet.Contains(conDataSynConfig.lastExecuteDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.lastExecuteDate = objDataSynConfigEN.lastExecuteDate == "[null]" ? null :  objDataSynConfigEN.lastExecuteDate; //最后执行日期
}
if (arrFldSet.Contains(conDataSynConfig.SynchStartTime, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.SynchStartTime = objDataSynConfigEN.SynchStartTime == "[null]" ? null :  objDataSynConfigEN.SynchStartTime; //同步开始时间
}
if (arrFldSet.Contains(conDataSynConfig.SynchEndTime, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.SynchEndTime = objDataSynConfigEN.SynchEndTime == "[null]" ? null :  objDataSynConfigEN.SynchEndTime; //同步结束时间
}
if (arrFldSet.Contains(conDataSynConfig.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDataSynConfigEN.Memo = objDataSynConfigEN.Memo == "[null]" ? null :  objDataSynConfigEN.Memo; //备注
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
 /// <param name = "objDataSynConfigEN">源简化对象</param>
 public static void AccessFldValueNull(clsDataSynConfigEN objDataSynConfigEN)
{
try
{
if (objDataSynConfigEN.TabName == "[null]") objDataSynConfigEN.TabName = null; //表名
if (objDataSynConfigEN.SynCondition4Web == "[null]") objDataSynConfigEN.SynCondition4Web = null; //同步条件4Web
if (objDataSynConfigEN.SenderUser == "[null]") objDataSynConfigEN.SenderUser = null; //发送邮件用户
if (objDataSynConfigEN.SenderPwd == "[null]") objDataSynConfigEN.SenderPwd = null; //发送邮件口令
if (objDataSynConfigEN.smtp == "[null]") objDataSynConfigEN.smtp = null; //发送邮件服务器
if (objDataSynConfigEN.Receiver == "[null]") objDataSynConfigEN.Receiver = null; //接收者
if (objDataSynConfigEN.lastMailDate == "[null]") objDataSynConfigEN.lastMailDate = null; //最后发邮件日期
if (objDataSynConfigEN.lastExecuteDate == "[null]") objDataSynConfigEN.lastExecuteDate = null; //最后执行日期
if (objDataSynConfigEN.SynchStartTime == "[null]") objDataSynConfigEN.SynchStartTime = null; //同步开始时间
if (objDataSynConfigEN.SynchEndTime == "[null]") objDataSynConfigEN.SynchEndTime = null; //同步结束时间
if (objDataSynConfigEN.Memo == "[null]") objDataSynConfigEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsDataSynConfigEN objDataSynConfigEN)
{
 DataSynConfigDA.CheckPropertyNew(objDataSynConfigEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDataSynConfigEN objDataSynConfigEN)
{
 DataSynConfigDA.CheckProperty4Condition(objDataSynConfigEN);
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
if (clsDataSynConfigBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataSynConfigBL没有刷新缓存机制(clsDataSynConfigBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrDataSynConfigObjLstCache == null)
//{
//arrDataSynConfigObjLstCache = DataSynConfigDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataSynConfigEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsDataSynConfigEN._CurrTabName);
List<clsDataSynConfigEN> arrDataSynConfigObjLstCache = GetObjLstCache();
IEnumerable <clsDataSynConfigEN> arrDataSynConfigObjLst_Sel =
arrDataSynConfigObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrDataSynConfigObjLst_Sel.Count() == 0)
{
   clsDataSynConfigEN obj = clsDataSynConfigBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrDataSynConfigObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataSynConfigEN> GetAllDataSynConfigObjLstCache()
{
//获取缓存中的对象列表
List<clsDataSynConfigEN> arrDataSynConfigObjLstCache = GetObjLstCache(); 
return arrDataSynConfigObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataSynConfigEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsDataSynConfigEN._CurrTabName);
List<clsDataSynConfigEN> arrDataSynConfigObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDataSynConfigObjLstCache;
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
string strKey = string.Format("{0}", clsDataSynConfigEN._CurrTabName);
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
if (clsDataSynConfigBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDataSynConfigEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDataSynConfigBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--DataSynConfig(同步配置)
 /// 唯一性条件:TabName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDataSynConfigEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsDataSynConfigEN objDataSynConfigEN)
{
//检测记录是否存在
string strResult = DataSynConfigDA.GetUniCondStr(objDataSynConfigEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conDataSynConfig.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDataSynConfig.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDataSynConfig.AttributeName));
throw new Exception(strMsg);
}
var objDataSynConfig = clsDataSynConfigBL.GetObjBymIdCache(lngmId);
if (objDataSynConfig == null) return "";
return objDataSynConfig[strOutFldName].ToString();
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
int intRecCount = clsDataSynConfigDA.GetRecCount(strTabName);
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
int intRecCount = clsDataSynConfigDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDataSynConfigDA.GetRecCount();
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
int intRecCount = clsDataSynConfigDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDataSynConfigCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDataSynConfigEN objDataSynConfigCond)
{
List<clsDataSynConfigEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDataSynConfigEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDataSynConfig.AttributeName)
{
if (objDataSynConfigCond.IsUpdated(strFldName) == false) continue;
if (objDataSynConfigCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataSynConfigCond[strFldName].ToString());
}
else
{
if (objDataSynConfigCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDataSynConfigCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataSynConfigCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDataSynConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDataSynConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDataSynConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDataSynConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDataSynConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDataSynConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDataSynConfigCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDataSynConfigCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDataSynConfigCond[strFldName]));
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
 List<string> arrList = clsDataSynConfigDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DataSynConfigDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DataSynConfigDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DataSynConfigDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDataSynConfigDA.SetFldValue(clsDataSynConfigEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DataSynConfigDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDataSynConfigDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDataSynConfigDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDataSynConfigDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DataSynConfig] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(50) Null, "); 
 // /**是否同步*/ 
 strCreateTabCode.Append(" IsSynch bit not Null, "); 
 // /**同步条件*/ 
 strCreateTabCode.Append(" SynCondition varchar(5000) not Null, "); 
 // /**同步条件4Web*/ 
 strCreateTabCode.Append(" SynCondition4Web varchar(5000) Null, "); 
 // /**同步周期*/ 
 strCreateTabCode.Append(" SynchCycle varchar(30) not Null, "); 
 // /**同步日期*/ 
 strCreateTabCode.Append(" SynchDate varchar(30) not Null, "); 
 // /**同步时间*/ 
 strCreateTabCode.Append(" SynchTime varchar(30) not Null, "); 
 // /**发送邮件用户*/ 
 strCreateTabCode.Append(" SenderUser varchar(30) Null, "); 
 // /**发送邮件口令*/ 
 strCreateTabCode.Append(" SenderPwd varchar(30) Null, "); 
 // /**发送邮件服务器*/ 
 strCreateTabCode.Append(" smtp varchar(50) Null, "); 
 // /**接收者*/ 
 strCreateTabCode.Append(" Receiver varchar(50) Null, "); 
 // /**最后发邮件日期*/ 
 strCreateTabCode.Append(" lastMailDate varchar(50) Null, "); 
 // /**最后执行日期*/ 
 strCreateTabCode.Append(" lastExecuteDate varchar(50) Null, "); 
 // /**同步开始时间*/ 
 strCreateTabCode.Append(" SynchStartTime varchar(14) Null, "); 
 // /**同步结束时间*/ 
 strCreateTabCode.Append(" SynchEndTime varchar(14) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 同步配置(DataSynConfig)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DataSynConfig : clsCommFun4BL
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
clsDataSynConfigBL.ReFreshThisCache();
}
}

}