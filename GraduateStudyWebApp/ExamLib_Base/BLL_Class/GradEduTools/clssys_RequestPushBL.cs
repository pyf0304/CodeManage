
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clssys_RequestPushBL
 表名:sys_RequestPush(01120726)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
public static class  clssys_RequestPushBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngRequestId">表关键字</param>
 /// <returns>表对象</returns>
public static clssys_RequestPushEN GetObj(this K_RequestId_sys_RequestPush myKey)
{
clssys_RequestPushEN objsys_RequestPushEN = clssys_RequestPushBL.sys_RequestPushDA.GetObjByRequestId(myKey.Value);
return objsys_RequestPushEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clssys_RequestPushEN objsys_RequestPushEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objsys_RequestPushEN) == false)
{
var strMsg = string.Format("记录已经存在!请求类型Id = [{0}],表主键 = [{1}]的数据已经存在!(in clssys_RequestPushBL.AddNewRecord)", objsys_RequestPushEN.RequesTypeId,objsys_RequestPushEN.TableKey);
throw new Exception(strMsg);
}
try
{
bool bolResult = clssys_RequestPushBL.sys_RequestPushDA.AddNewRecordBySQL2(objsys_RequestPushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestPushBL.ReFreshCache();

if (clssys_RequestPushBL.relatedActions != null)
{
clssys_RequestPushBL.relatedActions.UpdRelaTabDate(objsys_RequestPushEN.RequestId, "SetUpdDate");
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
public static bool AddRecordEx(this clssys_RequestPushEN objsys_RequestPushEN, bool bolIsNeedCheckUniqueness = true)
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
objsys_RequestPushEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objsys_RequestPushEN.CheckUniqueness() == false)
{
strMsg = string.Format("(请求类型Id(RequesTypeId)=[{0}],表主键(TableKey)=[{1}])已经存在,不能重复!", objsys_RequestPushEN.RequesTypeId, objsys_RequestPushEN.TableKey);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objsys_RequestPushEN.AddNewRecord();
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
 /// <param name = "objsys_RequestPushEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clssys_RequestPushEN objsys_RequestPushEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objsys_RequestPushEN) == false)
{
var strMsg = string.Format("记录已经存在!请求类型Id = [{0}],表主键 = [{1}]的数据已经存在!(in clssys_RequestPushBL.AddNewRecordWithReturnKey)", objsys_RequestPushEN.RequesTypeId,objsys_RequestPushEN.TableKey);
throw new Exception(strMsg);
}
try
{
string strKey = clssys_RequestPushBL.sys_RequestPushDA.AddNewRecordBySQL2WithReturnKey(objsys_RequestPushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestPushBL.ReFreshCache();

if (clssys_RequestPushBL.relatedActions != null)
{
clssys_RequestPushBL.relatedActions.UpdRelaTabDate(objsys_RequestPushEN.RequestId, "SetUpdDate");
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
 /// <param name = "objsys_RequestPushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestPushEN SetRequestId(this clssys_RequestPushEN objsys_RequestPushEN, long lngRequestId, string strComparisonOp="")
	{
objsys_RequestPushEN.RequestId = lngRequestId; //RequestId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestPushEN.dicFldComparisonOp.ContainsKey(consys_RequestPush.RequestId) == false)
{
objsys_RequestPushEN.dicFldComparisonOp.Add(consys_RequestPush.RequestId, strComparisonOp);
}
else
{
objsys_RequestPushEN.dicFldComparisonOp[consys_RequestPush.RequestId] = strComparisonOp;
}
}
return objsys_RequestPushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestPushEN SetRequesTypeId(this clssys_RequestPushEN objsys_RequestPushEN, string strRequesTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequesTypeId, 2, consys_RequestPush.RequesTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRequesTypeId, 2, consys_RequestPush.RequesTypeId);
}
objsys_RequestPushEN.RequesTypeId = strRequesTypeId; //请求类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestPushEN.dicFldComparisonOp.ContainsKey(consys_RequestPush.RequesTypeId) == false)
{
objsys_RequestPushEN.dicFldComparisonOp.Add(consys_RequestPush.RequesTypeId, strComparisonOp);
}
else
{
objsys_RequestPushEN.dicFldComparisonOp[consys_RequestPush.RequesTypeId] = strComparisonOp;
}
}
return objsys_RequestPushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestPushEN SetTableKey(this clssys_RequestPushEN objsys_RequestPushEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 20, consys_RequestPush.TableKey);
}
objsys_RequestPushEN.TableKey = strTableKey; //表主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestPushEN.dicFldComparisonOp.ContainsKey(consys_RequestPush.TableKey) == false)
{
objsys_RequestPushEN.dicFldComparisonOp.Add(consys_RequestPush.TableKey, strComparisonOp);
}
else
{
objsys_RequestPushEN.dicFldComparisonOp[consys_RequestPush.TableKey] = strComparisonOp;
}
}
return objsys_RequestPushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestPushEN SetReceiveUser(this clssys_RequestPushEN objsys_RequestPushEN, string strReceiveUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReceiveUser, 20, consys_RequestPush.ReceiveUser);
}
objsys_RequestPushEN.ReceiveUser = strReceiveUser; //接收用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestPushEN.dicFldComparisonOp.ContainsKey(consys_RequestPush.ReceiveUser) == false)
{
objsys_RequestPushEN.dicFldComparisonOp.Add(consys_RequestPush.ReceiveUser, strComparisonOp);
}
else
{
objsys_RequestPushEN.dicFldComparisonOp[consys_RequestPush.ReceiveUser] = strComparisonOp;
}
}
return objsys_RequestPushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestPushEN SetIsReply(this clssys_RequestPushEN objsys_RequestPushEN, bool bolIsReply, string strComparisonOp="")
	{
objsys_RequestPushEN.IsReply = bolIsReply; //是否回复
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestPushEN.dicFldComparisonOp.ContainsKey(consys_RequestPush.IsReply) == false)
{
objsys_RequestPushEN.dicFldComparisonOp.Add(consys_RequestPush.IsReply, strComparisonOp);
}
else
{
objsys_RequestPushEN.dicFldComparisonOp[consys_RequestPush.IsReply] = strComparisonOp;
}
}
return objsys_RequestPushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestPushEN SetReplyDate(this clssys_RequestPushEN objsys_RequestPushEN, string strReplyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReplyDate, 20, consys_RequestPush.ReplyDate);
}
objsys_RequestPushEN.ReplyDate = strReplyDate; //回复日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestPushEN.dicFldComparisonOp.ContainsKey(consys_RequestPush.ReplyDate) == false)
{
objsys_RequestPushEN.dicFldComparisonOp.Add(consys_RequestPush.ReplyDate, strComparisonOp);
}
else
{
objsys_RequestPushEN.dicFldComparisonOp[consys_RequestPush.ReplyDate] = strComparisonOp;
}
}
return objsys_RequestPushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestPushEN SetRequestUser(this clssys_RequestPushEN objsys_RequestPushEN, string strRequestUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequestUser, 20, consys_RequestPush.RequestUser);
}
objsys_RequestPushEN.RequestUser = strRequestUser; //RequestUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestPushEN.dicFldComparisonOp.ContainsKey(consys_RequestPush.RequestUser) == false)
{
objsys_RequestPushEN.dicFldComparisonOp.Add(consys_RequestPush.RequestUser, strComparisonOp);
}
else
{
objsys_RequestPushEN.dicFldComparisonOp[consys_RequestPush.RequestUser] = strComparisonOp;
}
}
return objsys_RequestPushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestPushEN SetRequestDate(this clssys_RequestPushEN objsys_RequestPushEN, string strRequestDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequestDate, 20, consys_RequestPush.RequestDate);
}
objsys_RequestPushEN.RequestDate = strRequestDate; //RequestDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestPushEN.dicFldComparisonOp.ContainsKey(consys_RequestPush.RequestDate) == false)
{
objsys_RequestPushEN.dicFldComparisonOp.Add(consys_RequestPush.RequestDate, strComparisonOp);
}
else
{
objsys_RequestPushEN.dicFldComparisonOp[consys_RequestPush.RequestDate] = strComparisonOp;
}
}
return objsys_RequestPushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestPushEN SetRequestStata(this clssys_RequestPushEN objsys_RequestPushEN, string strRequestStata, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequestStata, 10, consys_RequestPush.RequestStata);
}
objsys_RequestPushEN.RequestStata = strRequestStata; //RequestStata
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestPushEN.dicFldComparisonOp.ContainsKey(consys_RequestPush.RequestStata) == false)
{
objsys_RequestPushEN.dicFldComparisonOp.Add(consys_RequestPush.RequestStata, strComparisonOp);
}
else
{
objsys_RequestPushEN.dicFldComparisonOp[consys_RequestPush.RequestStata] = strComparisonOp;
}
}
return objsys_RequestPushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestPushEN SetMemo(this clssys_RequestPushEN objsys_RequestPushEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, consys_RequestPush.Memo);
}
objsys_RequestPushEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestPushEN.dicFldComparisonOp.ContainsKey(consys_RequestPush.Memo) == false)
{
objsys_RequestPushEN.dicFldComparisonOp.Add(consys_RequestPush.Memo, strComparisonOp);
}
else
{
objsys_RequestPushEN.dicFldComparisonOp[consys_RequestPush.Memo] = strComparisonOp;
}
}
return objsys_RequestPushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestPushEN SetIdCurrEduCls(this clssys_RequestPushEN objsys_RequestPushEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, consys_RequestPush.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, consys_RequestPush.IdCurrEduCls);
}
objsys_RequestPushEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestPushEN.dicFldComparisonOp.ContainsKey(consys_RequestPush.IdCurrEduCls) == false)
{
objsys_RequestPushEN.dicFldComparisonOp.Add(consys_RequestPush.IdCurrEduCls, strComparisonOp);
}
else
{
objsys_RequestPushEN.dicFldComparisonOp[consys_RequestPush.IdCurrEduCls] = strComparisonOp;
}
}
return objsys_RequestPushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestPushEN SetPushTypeId(this clssys_RequestPushEN objsys_RequestPushEN, string strPushTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPushTypeId, 2, consys_RequestPush.PushTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPushTypeId, 2, consys_RequestPush.PushTypeId);
}
objsys_RequestPushEN.PushTypeId = strPushTypeId; //推送类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestPushEN.dicFldComparisonOp.ContainsKey(consys_RequestPush.PushTypeId) == false)
{
objsys_RequestPushEN.dicFldComparisonOp.Add(consys_RequestPush.PushTypeId, strComparisonOp);
}
else
{
objsys_RequestPushEN.dicFldComparisonOp[consys_RequestPush.PushTypeId] = strComparisonOp;
}
}
return objsys_RequestPushEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clssys_RequestPushEN objsys_RequestPushEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objsys_RequestPushEN.CheckPropertyNew();
clssys_RequestPushEN objsys_RequestPushCond = new clssys_RequestPushEN();
string strCondition = objsys_RequestPushCond
.SetRequestId(objsys_RequestPushEN.RequestId, "<>")
.SetRequesTypeId(objsys_RequestPushEN.RequesTypeId, "=")
.SetTableKey(objsys_RequestPushEN.TableKey, "=")
.GetCombineCondition();
objsys_RequestPushEN._IsCheckProperty = true;
bool bolIsExist = clssys_RequestPushBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(RequesTypeId_TableKey)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objsys_RequestPushEN.Update();
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
 /// <param name = "objsys_RequestPush">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clssys_RequestPushEN objsys_RequestPush)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clssys_RequestPushEN objsys_RequestPushCond = new clssys_RequestPushEN();
string strCondition = objsys_RequestPushCond
.SetRequesTypeId(objsys_RequestPush.RequesTypeId, "=")
.SetTableKey(objsys_RequestPush.TableKey, "=")
.GetCombineCondition();
objsys_RequestPush._IsCheckProperty = true;
bool bolIsExist = clssys_RequestPushBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objsys_RequestPush.RequestId = clssys_RequestPushBL.GetFirstID_S(strCondition);
objsys_RequestPush.UpdateWithCondition(strCondition);
}
else
{
objsys_RequestPush.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clssys_RequestPushEN objsys_RequestPushEN)
{
 if (objsys_RequestPushEN.RequestId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clssys_RequestPushBL.sys_RequestPushDA.UpdateBySql2(objsys_RequestPushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestPushBL.ReFreshCache();

if (clssys_RequestPushBL.relatedActions != null)
{
clssys_RequestPushBL.relatedActions.UpdRelaTabDate(objsys_RequestPushEN.RequestId, "SetUpdDate");
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
 /// <param name = "objsys_RequestPushEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clssys_RequestPushEN objsys_RequestPushEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objsys_RequestPushEN.RequestId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clssys_RequestPushBL.sys_RequestPushDA.UpdateBySql2(objsys_RequestPushEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestPushBL.ReFreshCache();

if (clssys_RequestPushBL.relatedActions != null)
{
clssys_RequestPushBL.relatedActions.UpdRelaTabDate(objsys_RequestPushEN.RequestId, "SetUpdDate");
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
 /// <param name = "objsys_RequestPushEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clssys_RequestPushEN objsys_RequestPushEN, string strWhereCond)
{
try
{
bool bolResult = clssys_RequestPushBL.sys_RequestPushDA.UpdateBySqlWithCondition(objsys_RequestPushEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestPushBL.ReFreshCache();

if (clssys_RequestPushBL.relatedActions != null)
{
clssys_RequestPushBL.relatedActions.UpdRelaTabDate(objsys_RequestPushEN.RequestId, "SetUpdDate");
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
 /// <param name = "objsys_RequestPushEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clssys_RequestPushEN objsys_RequestPushEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clssys_RequestPushBL.sys_RequestPushDA.UpdateBySqlWithConditionTransaction(objsys_RequestPushEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestPushBL.ReFreshCache();

if (clssys_RequestPushBL.relatedActions != null)
{
clssys_RequestPushBL.relatedActions.UpdRelaTabDate(objsys_RequestPushEN.RequestId, "SetUpdDate");
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
 /// <param name = "lngRequestId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clssys_RequestPushEN objsys_RequestPushEN)
{
try
{
int intRecNum = clssys_RequestPushBL.sys_RequestPushDA.DelRecord(objsys_RequestPushEN.RequestId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestPushBL.ReFreshCache();

if (clssys_RequestPushBL.relatedActions != null)
{
clssys_RequestPushBL.relatedActions.UpdRelaTabDate(objsys_RequestPushEN.RequestId, "SetUpdDate");
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
 /// <param name = "objsys_RequestPushENS">源对象</param>
 /// <param name = "objsys_RequestPushENT">目标对象</param>
 public static void CopyTo(this clssys_RequestPushEN objsys_RequestPushENS, clssys_RequestPushEN objsys_RequestPushENT)
{
try
{
objsys_RequestPushENT.RequestId = objsys_RequestPushENS.RequestId; //RequestId
objsys_RequestPushENT.RequesTypeId = objsys_RequestPushENS.RequesTypeId; //请求类型Id
objsys_RequestPushENT.TableKey = objsys_RequestPushENS.TableKey; //表主键
objsys_RequestPushENT.ReceiveUser = objsys_RequestPushENS.ReceiveUser; //接收用户
objsys_RequestPushENT.IsReply = objsys_RequestPushENS.IsReply; //是否回复
objsys_RequestPushENT.ReplyDate = objsys_RequestPushENS.ReplyDate; //回复日期
objsys_RequestPushENT.RequestUser = objsys_RequestPushENS.RequestUser; //RequestUser
objsys_RequestPushENT.RequestDate = objsys_RequestPushENS.RequestDate; //RequestDate
objsys_RequestPushENT.RequestStata = objsys_RequestPushENS.RequestStata; //RequestStata
objsys_RequestPushENT.Memo = objsys_RequestPushENS.Memo; //备注
objsys_RequestPushENT.IdCurrEduCls = objsys_RequestPushENS.IdCurrEduCls; //教学班流水号
objsys_RequestPushENT.PushTypeId = objsys_RequestPushENS.PushTypeId; //推送类型Id
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
 /// <param name = "objsys_RequestPushENS">源对象</param>
 /// <returns>目标对象=>clssys_RequestPushEN:objsys_RequestPushENT</returns>
 public static clssys_RequestPushEN CopyTo(this clssys_RequestPushEN objsys_RequestPushENS)
{
try
{
 clssys_RequestPushEN objsys_RequestPushENT = new clssys_RequestPushEN()
{
RequestId = objsys_RequestPushENS.RequestId, //RequestId
RequesTypeId = objsys_RequestPushENS.RequesTypeId, //请求类型Id
TableKey = objsys_RequestPushENS.TableKey, //表主键
ReceiveUser = objsys_RequestPushENS.ReceiveUser, //接收用户
IsReply = objsys_RequestPushENS.IsReply, //是否回复
ReplyDate = objsys_RequestPushENS.ReplyDate, //回复日期
RequestUser = objsys_RequestPushENS.RequestUser, //RequestUser
RequestDate = objsys_RequestPushENS.RequestDate, //RequestDate
RequestStata = objsys_RequestPushENS.RequestStata, //RequestStata
Memo = objsys_RequestPushENS.Memo, //备注
IdCurrEduCls = objsys_RequestPushENS.IdCurrEduCls, //教学班流水号
PushTypeId = objsys_RequestPushENS.PushTypeId, //推送类型Id
};
 return objsys_RequestPushENT;
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
public static void CheckPropertyNew(this clssys_RequestPushEN objsys_RequestPushEN)
{
 clssys_RequestPushBL.sys_RequestPushDA.CheckPropertyNew(objsys_RequestPushEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clssys_RequestPushEN objsys_RequestPushEN)
{
 clssys_RequestPushBL.sys_RequestPushDA.CheckProperty4Condition(objsys_RequestPushEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clssys_RequestPushEN objsys_RequestPushCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objsys_RequestPushCond.IsUpdated(consys_RequestPush.RequestId) == true)
{
string strComparisonOpRequestId = objsys_RequestPushCond.dicFldComparisonOp[consys_RequestPush.RequestId];
strWhereCond += string.Format(" And {0} {2} {1}", consys_RequestPush.RequestId, objsys_RequestPushCond.RequestId, strComparisonOpRequestId);
}
if (objsys_RequestPushCond.IsUpdated(consys_RequestPush.RequesTypeId) == true)
{
string strComparisonOpRequesTypeId = objsys_RequestPushCond.dicFldComparisonOp[consys_RequestPush.RequesTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", consys_RequestPush.RequesTypeId, objsys_RequestPushCond.RequesTypeId, strComparisonOpRequesTypeId);
}
if (objsys_RequestPushCond.IsUpdated(consys_RequestPush.TableKey) == true)
{
string strComparisonOpTableKey = objsys_RequestPushCond.dicFldComparisonOp[consys_RequestPush.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", consys_RequestPush.TableKey, objsys_RequestPushCond.TableKey, strComparisonOpTableKey);
}
if (objsys_RequestPushCond.IsUpdated(consys_RequestPush.ReceiveUser) == true)
{
string strComparisonOpReceiveUser = objsys_RequestPushCond.dicFldComparisonOp[consys_RequestPush.ReceiveUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", consys_RequestPush.ReceiveUser, objsys_RequestPushCond.ReceiveUser, strComparisonOpReceiveUser);
}
if (objsys_RequestPushCond.IsUpdated(consys_RequestPush.IsReply) == true)
{
if (objsys_RequestPushCond.IsReply == true)
{
strWhereCond += string.Format(" And {0} = '1'", consys_RequestPush.IsReply);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", consys_RequestPush.IsReply);
}
}
if (objsys_RequestPushCond.IsUpdated(consys_RequestPush.ReplyDate) == true)
{
string strComparisonOpReplyDate = objsys_RequestPushCond.dicFldComparisonOp[consys_RequestPush.ReplyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", consys_RequestPush.ReplyDate, objsys_RequestPushCond.ReplyDate, strComparisonOpReplyDate);
}
if (objsys_RequestPushCond.IsUpdated(consys_RequestPush.RequestUser) == true)
{
string strComparisonOpRequestUser = objsys_RequestPushCond.dicFldComparisonOp[consys_RequestPush.RequestUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", consys_RequestPush.RequestUser, objsys_RequestPushCond.RequestUser, strComparisonOpRequestUser);
}
if (objsys_RequestPushCond.IsUpdated(consys_RequestPush.RequestDate) == true)
{
string strComparisonOpRequestDate = objsys_RequestPushCond.dicFldComparisonOp[consys_RequestPush.RequestDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", consys_RequestPush.RequestDate, objsys_RequestPushCond.RequestDate, strComparisonOpRequestDate);
}
if (objsys_RequestPushCond.IsUpdated(consys_RequestPush.RequestStata) == true)
{
string strComparisonOpRequestStata = objsys_RequestPushCond.dicFldComparisonOp[consys_RequestPush.RequestStata];
strWhereCond += string.Format(" And {0} {2} '{1}'", consys_RequestPush.RequestStata, objsys_RequestPushCond.RequestStata, strComparisonOpRequestStata);
}
if (objsys_RequestPushCond.IsUpdated(consys_RequestPush.Memo) == true)
{
string strComparisonOpMemo = objsys_RequestPushCond.dicFldComparisonOp[consys_RequestPush.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", consys_RequestPush.Memo, objsys_RequestPushCond.Memo, strComparisonOpMemo);
}
if (objsys_RequestPushCond.IsUpdated(consys_RequestPush.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objsys_RequestPushCond.dicFldComparisonOp[consys_RequestPush.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", consys_RequestPush.IdCurrEduCls, objsys_RequestPushCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objsys_RequestPushCond.IsUpdated(consys_RequestPush.PushTypeId) == true)
{
string strComparisonOpPushTypeId = objsys_RequestPushCond.dicFldComparisonOp[consys_RequestPush.PushTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", consys_RequestPush.PushTypeId, objsys_RequestPushCond.PushTypeId, strComparisonOpPushTypeId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--sys_RequestPush(请求推送表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RequesTypeId_TableKey
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clssys_RequestPushEN objsys_RequestPushEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objsys_RequestPushEN == null) return true;
if (objsys_RequestPushEN.RequestId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objsys_RequestPushEN.RequesTypeId == null)
{
 sbCondition.AppendFormat(" and RequesTypeId is null", objsys_RequestPushEN.RequesTypeId);
}
else
{
 sbCondition.AppendFormat(" and RequesTypeId = '{0}'", objsys_RequestPushEN.RequesTypeId);
}
 if (objsys_RequestPushEN.TableKey == null)
{
 sbCondition.AppendFormat(" and TableKey is null", objsys_RequestPushEN.TableKey);
}
else
{
 sbCondition.AppendFormat(" and TableKey = '{0}'", objsys_RequestPushEN.TableKey);
}
if (clssys_RequestPushBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("RequestId !=  {0}", objsys_RequestPushEN.RequestId);
 sbCondition.AppendFormat(" and RequesTypeId = '{0}'", objsys_RequestPushEN.RequesTypeId);
 sbCondition.AppendFormat(" and TableKey = '{0}'", objsys_RequestPushEN.TableKey);
if (clssys_RequestPushBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--sys_RequestPush(请求推送表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RequesTypeId_TableKey
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clssys_RequestPushEN objsys_RequestPushEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objsys_RequestPushEN == null) return "";
if (objsys_RequestPushEN.RequestId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objsys_RequestPushEN.RequesTypeId == null)
{
 sbCondition.AppendFormat(" and RequesTypeId is null", objsys_RequestPushEN.RequesTypeId);
}
else
{
 sbCondition.AppendFormat(" and RequesTypeId = '{0}'", objsys_RequestPushEN.RequesTypeId);
}
 if (objsys_RequestPushEN.TableKey == null)
{
 sbCondition.AppendFormat(" and TableKey is null", objsys_RequestPushEN.TableKey);
}
else
{
 sbCondition.AppendFormat(" and TableKey = '{0}'", objsys_RequestPushEN.TableKey);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RequestId !=  {0}", objsys_RequestPushEN.RequestId);
 sbCondition.AppendFormat(" and RequesTypeId = '{0}'", objsys_RequestPushEN.RequesTypeId);
 sbCondition.AppendFormat(" and TableKey = '{0}'", objsys_RequestPushEN.TableKey);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_sys_RequestPush
{
public virtual bool UpdRelaTabDate(long lngRequestId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 请求推送表(sys_RequestPush)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clssys_RequestPushBL
{
public static RelatedActions_sys_RequestPush relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clssys_RequestPushDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clssys_RequestPushDA sys_RequestPushDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clssys_RequestPushDA();
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
 public clssys_RequestPushBL()
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
if (string.IsNullOrEmpty(clssys_RequestPushEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clssys_RequestPushEN._ConnectString);
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
public static DataTable GetDataTable_sys_RequestPush(string strWhereCond)
{
DataTable objDT;
try
{
objDT = sys_RequestPushDA.GetDataTable_sys_RequestPush(strWhereCond);
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
objDT = sys_RequestPushDA.GetDataTable(strWhereCond);
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
objDT = sys_RequestPushDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = sys_RequestPushDA.GetDataTable(strWhereCond, strTabName);
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
objDT = sys_RequestPushDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = sys_RequestPushDA.GetDataTable_Top(objTopPara);
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
objDT = sys_RequestPushDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = sys_RequestPushDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = sys_RequestPushDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRequestIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clssys_RequestPushEN> GetObjLstByRequestIdLst(List<long> arrRequestIdLst)
{
List<clssys_RequestPushEN> arrObjLst = new List<clssys_RequestPushEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRequestIdLst);
 string strWhereCond = string.Format("RequestId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN();
try
{
objsys_RequestPushEN.RequestId = Int32.Parse(objRow[consys_RequestPush.RequestId].ToString().Trim()); //RequestId
objsys_RequestPushEN.RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id
objsys_RequestPushEN.TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键
objsys_RequestPushEN.ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户
objsys_RequestPushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[consys_RequestPush.IsReply].ToString().Trim()); //是否回复
objsys_RequestPushEN.ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期
objsys_RequestPushEN.RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser
objsys_RequestPushEN.RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate
objsys_RequestPushEN.RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata
objsys_RequestPushEN.Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(); //备注
objsys_RequestPushEN.IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号
objsys_RequestPushEN.PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestPushEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestPushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRequestIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clssys_RequestPushEN> GetObjLstByRequestIdLstCache(List<long> arrRequestIdLst)
{
string strKey = string.Format("{0}", clssys_RequestPushEN._CurrTabName);
List<clssys_RequestPushEN> arrsys_RequestPushObjLstCache = GetObjLstCache();
IEnumerable <clssys_RequestPushEN> arrsys_RequestPushObjLst_Sel =
arrsys_RequestPushObjLstCache
.Where(x => arrRequestIdLst.Contains(x.RequestId));
return arrsys_RequestPushObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clssys_RequestPushEN> GetObjLst(string strWhereCond)
{
List<clssys_RequestPushEN> arrObjLst = new List<clssys_RequestPushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN();
try
{
objsys_RequestPushEN.RequestId = Int32.Parse(objRow[consys_RequestPush.RequestId].ToString().Trim()); //RequestId
objsys_RequestPushEN.RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id
objsys_RequestPushEN.TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键
objsys_RequestPushEN.ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户
objsys_RequestPushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[consys_RequestPush.IsReply].ToString().Trim()); //是否回复
objsys_RequestPushEN.ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期
objsys_RequestPushEN.RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser
objsys_RequestPushEN.RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate
objsys_RequestPushEN.RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata
objsys_RequestPushEN.Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(); //备注
objsys_RequestPushEN.IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号
objsys_RequestPushEN.PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestPushEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestPushEN);
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
public static List<clssys_RequestPushEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clssys_RequestPushEN> arrObjLst = new List<clssys_RequestPushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN();
try
{
objsys_RequestPushEN.RequestId = Int32.Parse(objRow[consys_RequestPush.RequestId].ToString().Trim()); //RequestId
objsys_RequestPushEN.RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id
objsys_RequestPushEN.TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键
objsys_RequestPushEN.ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户
objsys_RequestPushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[consys_RequestPush.IsReply].ToString().Trim()); //是否回复
objsys_RequestPushEN.ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期
objsys_RequestPushEN.RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser
objsys_RequestPushEN.RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate
objsys_RequestPushEN.RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata
objsys_RequestPushEN.Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(); //备注
objsys_RequestPushEN.IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号
objsys_RequestPushEN.PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestPushEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestPushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objsys_RequestPushCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clssys_RequestPushEN> GetSubObjLstCache(clssys_RequestPushEN objsys_RequestPushCond)
{
List<clssys_RequestPushEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clssys_RequestPushEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in consys_RequestPush.AttributeName)
{
if (objsys_RequestPushCond.IsUpdated(strFldName) == false) continue;
if (objsys_RequestPushCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objsys_RequestPushCond[strFldName].ToString());
}
else
{
if (objsys_RequestPushCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objsys_RequestPushCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objsys_RequestPushCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objsys_RequestPushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objsys_RequestPushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objsys_RequestPushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objsys_RequestPushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objsys_RequestPushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objsys_RequestPushCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objsys_RequestPushCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objsys_RequestPushCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objsys_RequestPushCond[strFldName]));
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
public static List<clssys_RequestPushEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clssys_RequestPushEN> arrObjLst = new List<clssys_RequestPushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN();
try
{
objsys_RequestPushEN.RequestId = Int32.Parse(objRow[consys_RequestPush.RequestId].ToString().Trim()); //RequestId
objsys_RequestPushEN.RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id
objsys_RequestPushEN.TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键
objsys_RequestPushEN.ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户
objsys_RequestPushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[consys_RequestPush.IsReply].ToString().Trim()); //是否回复
objsys_RequestPushEN.ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期
objsys_RequestPushEN.RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser
objsys_RequestPushEN.RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate
objsys_RequestPushEN.RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata
objsys_RequestPushEN.Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(); //备注
objsys_RequestPushEN.IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号
objsys_RequestPushEN.PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestPushEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestPushEN);
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
public static List<clssys_RequestPushEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clssys_RequestPushEN> arrObjLst = new List<clssys_RequestPushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN();
try
{
objsys_RequestPushEN.RequestId = Int32.Parse(objRow[consys_RequestPush.RequestId].ToString().Trim()); //RequestId
objsys_RequestPushEN.RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id
objsys_RequestPushEN.TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键
objsys_RequestPushEN.ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户
objsys_RequestPushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[consys_RequestPush.IsReply].ToString().Trim()); //是否回复
objsys_RequestPushEN.ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期
objsys_RequestPushEN.RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser
objsys_RequestPushEN.RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate
objsys_RequestPushEN.RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata
objsys_RequestPushEN.Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(); //备注
objsys_RequestPushEN.IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号
objsys_RequestPushEN.PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestPushEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestPushEN);
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
List<clssys_RequestPushEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clssys_RequestPushEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clssys_RequestPushEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clssys_RequestPushEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clssys_RequestPushEN> arrObjLst = new List<clssys_RequestPushEN>(); 
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
	clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN();
try
{
objsys_RequestPushEN.RequestId = Int32.Parse(objRow[consys_RequestPush.RequestId].ToString().Trim()); //RequestId
objsys_RequestPushEN.RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id
objsys_RequestPushEN.TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键
objsys_RequestPushEN.ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户
objsys_RequestPushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[consys_RequestPush.IsReply].ToString().Trim()); //是否回复
objsys_RequestPushEN.ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期
objsys_RequestPushEN.RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser
objsys_RequestPushEN.RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate
objsys_RequestPushEN.RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata
objsys_RequestPushEN.Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(); //备注
objsys_RequestPushEN.IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号
objsys_RequestPushEN.PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestPushEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestPushEN);
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
public static List<clssys_RequestPushEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clssys_RequestPushEN> arrObjLst = new List<clssys_RequestPushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN();
try
{
objsys_RequestPushEN.RequestId = Int32.Parse(objRow[consys_RequestPush.RequestId].ToString().Trim()); //RequestId
objsys_RequestPushEN.RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id
objsys_RequestPushEN.TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键
objsys_RequestPushEN.ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户
objsys_RequestPushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[consys_RequestPush.IsReply].ToString().Trim()); //是否回复
objsys_RequestPushEN.ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期
objsys_RequestPushEN.RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser
objsys_RequestPushEN.RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate
objsys_RequestPushEN.RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata
objsys_RequestPushEN.Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(); //备注
objsys_RequestPushEN.IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号
objsys_RequestPushEN.PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestPushEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestPushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clssys_RequestPushEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clssys_RequestPushEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clssys_RequestPushEN> arrObjLst = new List<clssys_RequestPushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN();
try
{
objsys_RequestPushEN.RequestId = Int32.Parse(objRow[consys_RequestPush.RequestId].ToString().Trim()); //RequestId
objsys_RequestPushEN.RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id
objsys_RequestPushEN.TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键
objsys_RequestPushEN.ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户
objsys_RequestPushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[consys_RequestPush.IsReply].ToString().Trim()); //是否回复
objsys_RequestPushEN.ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期
objsys_RequestPushEN.RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser
objsys_RequestPushEN.RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate
objsys_RequestPushEN.RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata
objsys_RequestPushEN.Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(); //备注
objsys_RequestPushEN.IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号
objsys_RequestPushEN.PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestPushEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestPushEN);
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
public static List<clssys_RequestPushEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clssys_RequestPushEN> arrObjLst = new List<clssys_RequestPushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN();
try
{
objsys_RequestPushEN.RequestId = Int32.Parse(objRow[consys_RequestPush.RequestId].ToString().Trim()); //RequestId
objsys_RequestPushEN.RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id
objsys_RequestPushEN.TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键
objsys_RequestPushEN.ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户
objsys_RequestPushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[consys_RequestPush.IsReply].ToString().Trim()); //是否回复
objsys_RequestPushEN.ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期
objsys_RequestPushEN.RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser
objsys_RequestPushEN.RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate
objsys_RequestPushEN.RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata
objsys_RequestPushEN.Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(); //备注
objsys_RequestPushEN.IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号
objsys_RequestPushEN.PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestPushEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestPushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clssys_RequestPushEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clssys_RequestPushEN> arrObjLst = new List<clssys_RequestPushEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN();
try
{
objsys_RequestPushEN.RequestId = Int32.Parse(objRow[consys_RequestPush.RequestId].ToString().Trim()); //RequestId
objsys_RequestPushEN.RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id
objsys_RequestPushEN.TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键
objsys_RequestPushEN.ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户
objsys_RequestPushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[consys_RequestPush.IsReply].ToString().Trim()); //是否回复
objsys_RequestPushEN.ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期
objsys_RequestPushEN.RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser
objsys_RequestPushEN.RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate
objsys_RequestPushEN.RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata
objsys_RequestPushEN.Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(); //备注
objsys_RequestPushEN.IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号
objsys_RequestPushEN.PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestPushEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestPushEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getsys_RequestPush(ref clssys_RequestPushEN objsys_RequestPushEN)
{
bool bolResult = sys_RequestPushDA.Getsys_RequestPush(ref objsys_RequestPushEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngRequestId">表关键字</param>
 /// <returns>表对象</returns>
public static clssys_RequestPushEN GetObjByRequestId(long lngRequestId)
{
clssys_RequestPushEN objsys_RequestPushEN = sys_RequestPushDA.GetObjByRequestId(lngRequestId);
return objsys_RequestPushEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clssys_RequestPushEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clssys_RequestPushEN objsys_RequestPushEN = sys_RequestPushDA.GetFirstObj(strWhereCond);
 return objsys_RequestPushEN;
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
public static clssys_RequestPushEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clssys_RequestPushEN objsys_RequestPushEN = sys_RequestPushDA.GetObjByDataRow(objRow);
 return objsys_RequestPushEN;
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
public static clssys_RequestPushEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clssys_RequestPushEN objsys_RequestPushEN = sys_RequestPushDA.GetObjByDataRow(objRow);
 return objsys_RequestPushEN;
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
 /// <param name = "lngRequestId">所给的关键字</param>
 /// <param name = "lstsys_RequestPushObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clssys_RequestPushEN GetObjByRequestIdFromList(long lngRequestId, List<clssys_RequestPushEN> lstsys_RequestPushObjLst)
{
foreach (clssys_RequestPushEN objsys_RequestPushEN in lstsys_RequestPushObjLst)
{
if (objsys_RequestPushEN.RequestId == lngRequestId)
{
return objsys_RequestPushEN;
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
 long lngRequestId;
 try
 {
 lngRequestId = new clssys_RequestPushDA().GetFirstID(strWhereCond);
 return lngRequestId;
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
 arrList = sys_RequestPushDA.GetID(strWhereCond);
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
bool bolIsExist = sys_RequestPushDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngRequestId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngRequestId)
{
//检测记录是否存在
bool bolIsExist = sys_RequestPushDA.IsExist(lngRequestId);
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
 bolIsExist = clssys_RequestPushDA.IsExistTable();
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
 bolIsExist = sys_RequestPushDA.IsExistTable(strTabName);
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
 /// <param name = "objsys_RequestPushEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clssys_RequestPushEN objsys_RequestPushEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objsys_RequestPushEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!请求类型Id = [{0}],表主键 = [{1}]的数据已经存在!(in clssys_RequestPushBL.AddNewRecordBySql2)", objsys_RequestPushEN.RequesTypeId,objsys_RequestPushEN.TableKey);
throw new Exception(strMsg);
}
try
{
bool bolResult = sys_RequestPushDA.AddNewRecordBySQL2(objsys_RequestPushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestPushBL.ReFreshCache();

if (clssys_RequestPushBL.relatedActions != null)
{
clssys_RequestPushBL.relatedActions.UpdRelaTabDate(objsys_RequestPushEN.RequestId, "SetUpdDate");
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
 /// <param name = "objsys_RequestPushEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clssys_RequestPushEN objsys_RequestPushEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objsys_RequestPushEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!请求类型Id = [{0}],表主键 = [{1}]的数据已经存在!(in clssys_RequestPushBL.AddNewRecordBySql2WithReturnKey)", objsys_RequestPushEN.RequesTypeId,objsys_RequestPushEN.TableKey);
throw new Exception(strMsg);
}
try
{
string strKey = sys_RequestPushDA.AddNewRecordBySQL2WithReturnKey(objsys_RequestPushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestPushBL.ReFreshCache();

if (clssys_RequestPushBL.relatedActions != null)
{
clssys_RequestPushBL.relatedActions.UpdRelaTabDate(objsys_RequestPushEN.RequestId, "SetUpdDate");
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
 /// <param name = "objsys_RequestPushEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clssys_RequestPushEN objsys_RequestPushEN)
{
try
{
bool bolResult = sys_RequestPushDA.Update(objsys_RequestPushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestPushBL.ReFreshCache();

if (clssys_RequestPushBL.relatedActions != null)
{
clssys_RequestPushBL.relatedActions.UpdRelaTabDate(objsys_RequestPushEN.RequestId, "SetUpdDate");
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
 /// <param name = "objsys_RequestPushEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clssys_RequestPushEN objsys_RequestPushEN)
{
 if (objsys_RequestPushEN.RequestId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = sys_RequestPushDA.UpdateBySql2(objsys_RequestPushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestPushBL.ReFreshCache();

if (clssys_RequestPushBL.relatedActions != null)
{
clssys_RequestPushBL.relatedActions.UpdRelaTabDate(objsys_RequestPushEN.RequestId, "SetUpdDate");
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
 /// <param name = "lngRequestId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngRequestId)
{
try
{
 clssys_RequestPushEN objsys_RequestPushEN = clssys_RequestPushBL.GetObjByRequestId(lngRequestId);

if (clssys_RequestPushBL.relatedActions != null)
{
clssys_RequestPushBL.relatedActions.UpdRelaTabDate(objsys_RequestPushEN.RequestId, "SetUpdDate");
}
if (objsys_RequestPushEN != null)
{
int intRecNum = sys_RequestPushDA.DelRecord(lngRequestId);
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
/// <param name="lngRequestId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngRequestId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clssys_RequestPushDA.GetSpecSQLObj();
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
//删除与表:[sys_RequestPush]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//consys_RequestPush.RequestId,
//lngRequestId);
//        clssys_RequestPushBL.Delsys_RequestPushsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clssys_RequestPushBL.DelRecord(lngRequestId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clssys_RequestPushBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngRequestId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngRequestId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngRequestId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clssys_RequestPushBL.relatedActions != null)
{
clssys_RequestPushBL.relatedActions.UpdRelaTabDate(lngRequestId, "UpdRelaTabDate");
}
bool bolResult = sys_RequestPushDA.DelRecord(lngRequestId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrRequestIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delsys_RequestPushs(List<string> arrRequestIdLst)
{
if (arrRequestIdLst.Count == 0) return 0;
try
{
if (clssys_RequestPushBL.relatedActions != null)
{
foreach (var strRequestId in arrRequestIdLst)
{
long lngRequestId = long.Parse(strRequestId);
clssys_RequestPushBL.relatedActions.UpdRelaTabDate(lngRequestId, "UpdRelaTabDate");
}
}
int intDelRecNum = sys_RequestPushDA.Delsys_RequestPush(arrRequestIdLst);
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
public static int Delsys_RequestPushsByCond(string strWhereCond)
{
try
{
if (clssys_RequestPushBL.relatedActions != null)
{
List<string> arrRequestId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRequestId in arrRequestId)
{
long lngRequestId = long.Parse(strRequestId);
clssys_RequestPushBL.relatedActions.UpdRelaTabDate(lngRequestId, "UpdRelaTabDate");
}
}
int intRecNum = sys_RequestPushDA.Delsys_RequestPush(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[sys_RequestPush]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngRequestId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngRequestId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clssys_RequestPushDA.GetSpecSQLObj();
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
//删除与表:[sys_RequestPush]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clssys_RequestPushBL.DelRecord(lngRequestId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clssys_RequestPushBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngRequestId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objsys_RequestPushENS">源对象</param>
 /// <param name = "objsys_RequestPushENT">目标对象</param>
 public static void CopyTo(clssys_RequestPushEN objsys_RequestPushENS, clssys_RequestPushEN objsys_RequestPushENT)
{
try
{
objsys_RequestPushENT.RequestId = objsys_RequestPushENS.RequestId; //RequestId
objsys_RequestPushENT.RequesTypeId = objsys_RequestPushENS.RequesTypeId; //请求类型Id
objsys_RequestPushENT.TableKey = objsys_RequestPushENS.TableKey; //表主键
objsys_RequestPushENT.ReceiveUser = objsys_RequestPushENS.ReceiveUser; //接收用户
objsys_RequestPushENT.IsReply = objsys_RequestPushENS.IsReply; //是否回复
objsys_RequestPushENT.ReplyDate = objsys_RequestPushENS.ReplyDate; //回复日期
objsys_RequestPushENT.RequestUser = objsys_RequestPushENS.RequestUser; //RequestUser
objsys_RequestPushENT.RequestDate = objsys_RequestPushENS.RequestDate; //RequestDate
objsys_RequestPushENT.RequestStata = objsys_RequestPushENS.RequestStata; //RequestStata
objsys_RequestPushENT.Memo = objsys_RequestPushENS.Memo; //备注
objsys_RequestPushENT.IdCurrEduCls = objsys_RequestPushENS.IdCurrEduCls; //教学班流水号
objsys_RequestPushENT.PushTypeId = objsys_RequestPushENS.PushTypeId; //推送类型Id
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
 /// <param name = "objsys_RequestPushEN">源简化对象</param>
 public static void SetUpdFlag(clssys_RequestPushEN objsys_RequestPushEN)
{
try
{
objsys_RequestPushEN.ClearUpdateState();
   string strsfUpdFldSetStr = objsys_RequestPushEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(consys_RequestPush.RequestId, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestPushEN.RequestId = objsys_RequestPushEN.RequestId; //RequestId
}
if (arrFldSet.Contains(consys_RequestPush.RequesTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestPushEN.RequesTypeId = objsys_RequestPushEN.RequesTypeId == "[null]" ? null :  objsys_RequestPushEN.RequesTypeId; //请求类型Id
}
if (arrFldSet.Contains(consys_RequestPush.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestPushEN.TableKey = objsys_RequestPushEN.TableKey == "[null]" ? null :  objsys_RequestPushEN.TableKey; //表主键
}
if (arrFldSet.Contains(consys_RequestPush.ReceiveUser, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestPushEN.ReceiveUser = objsys_RequestPushEN.ReceiveUser == "[null]" ? null :  objsys_RequestPushEN.ReceiveUser; //接收用户
}
if (arrFldSet.Contains(consys_RequestPush.IsReply, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestPushEN.IsReply = objsys_RequestPushEN.IsReply; //是否回复
}
if (arrFldSet.Contains(consys_RequestPush.ReplyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestPushEN.ReplyDate = objsys_RequestPushEN.ReplyDate == "[null]" ? null :  objsys_RequestPushEN.ReplyDate; //回复日期
}
if (arrFldSet.Contains(consys_RequestPush.RequestUser, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestPushEN.RequestUser = objsys_RequestPushEN.RequestUser == "[null]" ? null :  objsys_RequestPushEN.RequestUser; //RequestUser
}
if (arrFldSet.Contains(consys_RequestPush.RequestDate, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestPushEN.RequestDate = objsys_RequestPushEN.RequestDate == "[null]" ? null :  objsys_RequestPushEN.RequestDate; //RequestDate
}
if (arrFldSet.Contains(consys_RequestPush.RequestStata, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestPushEN.RequestStata = objsys_RequestPushEN.RequestStata == "[null]" ? null :  objsys_RequestPushEN.RequestStata; //RequestStata
}
if (arrFldSet.Contains(consys_RequestPush.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestPushEN.Memo = objsys_RequestPushEN.Memo == "[null]" ? null :  objsys_RequestPushEN.Memo; //备注
}
if (arrFldSet.Contains(consys_RequestPush.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestPushEN.IdCurrEduCls = objsys_RequestPushEN.IdCurrEduCls == "[null]" ? null :  objsys_RequestPushEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(consys_RequestPush.PushTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestPushEN.PushTypeId = objsys_RequestPushEN.PushTypeId == "[null]" ? null :  objsys_RequestPushEN.PushTypeId; //推送类型Id
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
 /// <param name = "objsys_RequestPushEN">源简化对象</param>
 public static void AccessFldValueNull(clssys_RequestPushEN objsys_RequestPushEN)
{
try
{
if (objsys_RequestPushEN.RequesTypeId == "[null]") objsys_RequestPushEN.RequesTypeId = null; //请求类型Id
if (objsys_RequestPushEN.TableKey == "[null]") objsys_RequestPushEN.TableKey = null; //表主键
if (objsys_RequestPushEN.ReceiveUser == "[null]") objsys_RequestPushEN.ReceiveUser = null; //接收用户
if (objsys_RequestPushEN.ReplyDate == "[null]") objsys_RequestPushEN.ReplyDate = null; //回复日期
if (objsys_RequestPushEN.RequestUser == "[null]") objsys_RequestPushEN.RequestUser = null; //RequestUser
if (objsys_RequestPushEN.RequestDate == "[null]") objsys_RequestPushEN.RequestDate = null; //RequestDate
if (objsys_RequestPushEN.RequestStata == "[null]") objsys_RequestPushEN.RequestStata = null; //RequestStata
if (objsys_RequestPushEN.Memo == "[null]") objsys_RequestPushEN.Memo = null; //备注
if (objsys_RequestPushEN.IdCurrEduCls == "[null]") objsys_RequestPushEN.IdCurrEduCls = null; //教学班流水号
if (objsys_RequestPushEN.PushTypeId == "[null]") objsys_RequestPushEN.PushTypeId = null; //推送类型Id
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
public static void CheckPropertyNew(clssys_RequestPushEN objsys_RequestPushEN)
{
 sys_RequestPushDA.CheckPropertyNew(objsys_RequestPushEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clssys_RequestPushEN objsys_RequestPushEN)
{
 sys_RequestPushDA.CheckProperty4Condition(objsys_RequestPushEN);
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
if (clssys_RequestPushBL.objCommFun4BL == null)
{
strMsg = string.Format("类clssys_RequestPushBL没有刷新缓存机制(clssys_RequestPushBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RequestId");
//if (arrsys_RequestPushObjLstCache == null)
//{
//arrsys_RequestPushObjLstCache = sys_RequestPushDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngRequestId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clssys_RequestPushEN GetObjByRequestIdCache(long lngRequestId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clssys_RequestPushEN._CurrTabName);
List<clssys_RequestPushEN> arrsys_RequestPushObjLstCache = GetObjLstCache();
IEnumerable <clssys_RequestPushEN> arrsys_RequestPushObjLst_Sel =
arrsys_RequestPushObjLstCache
.Where(x=> x.RequestId == lngRequestId 
);
if (arrsys_RequestPushObjLst_Sel.Count() == 0)
{
   clssys_RequestPushEN obj = clssys_RequestPushBL.GetObjByRequestId(lngRequestId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrsys_RequestPushObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clssys_RequestPushEN> GetAllsys_RequestPushObjLstCache()
{
//获取缓存中的对象列表
List<clssys_RequestPushEN> arrsys_RequestPushObjLstCache = GetObjLstCache(); 
return arrsys_RequestPushObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clssys_RequestPushEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clssys_RequestPushEN._CurrTabName);
List<clssys_RequestPushEN> arrsys_RequestPushObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrsys_RequestPushObjLstCache;
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
string strKey = string.Format("{0}", clssys_RequestPushEN._CurrTabName);
CacheHelper.Remove(strKey);
clssys_RequestPushEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clssys_RequestPushEN._RefreshTimeLst.Count == 0) return "";
return clssys_RequestPushEN._RefreshTimeLst[clssys_RequestPushEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clssys_RequestPushBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clssys_RequestPushEN._CurrTabName);
CacheHelper.Remove(strKey);
clssys_RequestPushEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clssys_RequestPushBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--sys_RequestPush(请求推送表)
 /// 唯一性条件:RequesTypeId_TableKey
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clssys_RequestPushEN objsys_RequestPushEN)
{
//检测记录是否存在
string strResult = sys_RequestPushDA.GetUniCondStr(objsys_RequestPushEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngRequestId)
{
if (strInFldName != consys_RequestPush.RequestId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (consys_RequestPush.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", consys_RequestPush.AttributeName));
throw new Exception(strMsg);
}
var objsys_RequestPush = clssys_RequestPushBL.GetObjByRequestIdCache(lngRequestId);
if (objsys_RequestPush == null) return "";
return objsys_RequestPush[strOutFldName].ToString();
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
int intRecCount = clssys_RequestPushDA.GetRecCount(strTabName);
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
int intRecCount = clssys_RequestPushDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clssys_RequestPushDA.GetRecCount();
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
int intRecCount = clssys_RequestPushDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objsys_RequestPushCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clssys_RequestPushEN objsys_RequestPushCond)
{
List<clssys_RequestPushEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clssys_RequestPushEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in consys_RequestPush.AttributeName)
{
if (objsys_RequestPushCond.IsUpdated(strFldName) == false) continue;
if (objsys_RequestPushCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objsys_RequestPushCond[strFldName].ToString());
}
else
{
if (objsys_RequestPushCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objsys_RequestPushCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objsys_RequestPushCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objsys_RequestPushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objsys_RequestPushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objsys_RequestPushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objsys_RequestPushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objsys_RequestPushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objsys_RequestPushCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objsys_RequestPushCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objsys_RequestPushCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objsys_RequestPushCond[strFldName]));
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
 List<string> arrList = clssys_RequestPushDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = sys_RequestPushDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = sys_RequestPushDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = sys_RequestPushDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clssys_RequestPushDA.SetFldValue(clssys_RequestPushEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = sys_RequestPushDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clssys_RequestPushDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clssys_RequestPushDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clssys_RequestPushDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[sys_RequestPush] "); 
 strCreateTabCode.Append(" ( "); 
 // /**RequestId*/ 
 strCreateTabCode.Append(" RequestId bigint primary key identity, "); 
 // /**请求类型Id*/ 
 strCreateTabCode.Append(" RequesTypeId char(2) Null, "); 
 // /**表主键*/ 
 strCreateTabCode.Append(" TableKey varchar(20) Null, "); 
 // /**接收用户*/ 
 strCreateTabCode.Append(" ReceiveUser varchar(20) Null, "); 
 // /**是否回复*/ 
 strCreateTabCode.Append(" IsReply bit Null, "); 
 // /**回复日期*/ 
 strCreateTabCode.Append(" ReplyDate varchar(20) Null, "); 
 // /**RequestUser*/ 
 strCreateTabCode.Append(" RequestUser varchar(20) Null, "); 
 // /**RequestDate*/ 
 strCreateTabCode.Append(" RequestDate varchar(20) Null, "); 
 // /**RequestStata*/ 
 strCreateTabCode.Append(" RequestStata varchar(10) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**推送类型Id*/ 
 strCreateTabCode.Append(" PushTypeId char(2) Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) Null, "); 
 // /**教学班名*/ 
 strCreateTabCode.Append(" EduClsName varchar(100) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 请求推送表(sys_RequestPush)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4sys_RequestPush : clsCommFun4BL
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
clssys_RequestPushBL.ReFreshThisCache();
}
}

}