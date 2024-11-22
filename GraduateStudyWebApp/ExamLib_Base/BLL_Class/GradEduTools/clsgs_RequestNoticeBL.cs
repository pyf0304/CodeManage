
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_RequestNoticeBL
 表名:gs_RequestNotice(01120724)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
public static class  clsgs_RequestNoticeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngRequestId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_RequestNoticeEN GetObj(this K_RequestId_gs_RequestNotice myKey)
{
clsgs_RequestNoticeEN objgs_RequestNoticeEN = clsgs_RequestNoticeBL.gs_RequestNoticeDA.GetObjByRequestId(myKey.Value);
return objgs_RequestNoticeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
if (CheckUniqueness(objgs_RequestNoticeEN) == false)
{
var strMsg = string.Format("记录已经存在!请求类型Id = [{0}],表主键 = [{1}]的数据已经存在!(in clsgs_RequestNoticeBL.AddNewRecord)", objgs_RequestNoticeEN.RequesTypeId,objgs_RequestNoticeEN.TableKey);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsgs_RequestNoticeBL.gs_RequestNoticeDA.AddNewRecordBySQL2(objgs_RequestNoticeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_RequestNoticeBL.ReFreshCache();

if (clsgs_RequestNoticeBL.relatedActions != null)
{
clsgs_RequestNoticeBL.relatedActions.UpdRelaTabDate(objgs_RequestNoticeEN.RequestId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_RequestNoticeEN objgs_RequestNoticeEN)
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
objgs_RequestNoticeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objgs_RequestNoticeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(请求类型Id(RequesTypeId)=[{0}],表主键(TableKey)=[{1}])已经存在,不能重复!", objgs_RequestNoticeEN.RequesTypeId, objgs_RequestNoticeEN.TableKey);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objgs_RequestNoticeEN.AddNewRecord();
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
 /// <param name = "objgs_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
if (CheckUniqueness(objgs_RequestNoticeEN) == false)
{
var strMsg = string.Format("记录已经存在!请求类型Id = [{0}],表主键 = [{1}]的数据已经存在!(in clsgs_RequestNoticeBL.AddNewRecordWithReturnKey)", objgs_RequestNoticeEN.RequesTypeId,objgs_RequestNoticeEN.TableKey);
throw new Exception(strMsg);
}
try
{
string strKey = clsgs_RequestNoticeBL.gs_RequestNoticeDA.AddNewRecordBySQL2WithReturnKey(objgs_RequestNoticeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_RequestNoticeBL.ReFreshCache();

if (clsgs_RequestNoticeBL.relatedActions != null)
{
clsgs_RequestNoticeBL.relatedActions.UpdRelaTabDate(objgs_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objgs_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_RequestNoticeEN SetRequestId(this clsgs_RequestNoticeEN objgs_RequestNoticeEN, long lngRequestId, string strComparisonOp="")
	{
objgs_RequestNoticeEN.RequestId = lngRequestId; //RequestId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_RequestNoticeEN.dicFldComparisonOp.ContainsKey(congs_RequestNotice.RequestId) == false)
{
objgs_RequestNoticeEN.dicFldComparisonOp.Add(congs_RequestNotice.RequestId, strComparisonOp);
}
else
{
objgs_RequestNoticeEN.dicFldComparisonOp[congs_RequestNotice.RequestId] = strComparisonOp;
}
}
return objgs_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_RequestNoticeEN SetRequesTypeId(this clsgs_RequestNoticeEN objgs_RequestNoticeEN, string strRequesTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequesTypeId, 2, congs_RequestNotice.RequesTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRequesTypeId, 2, congs_RequestNotice.RequesTypeId);
}
objgs_RequestNoticeEN.RequesTypeId = strRequesTypeId; //请求类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_RequestNoticeEN.dicFldComparisonOp.ContainsKey(congs_RequestNotice.RequesTypeId) == false)
{
objgs_RequestNoticeEN.dicFldComparisonOp.Add(congs_RequestNotice.RequesTypeId, strComparisonOp);
}
else
{
objgs_RequestNoticeEN.dicFldComparisonOp[congs_RequestNotice.RequesTypeId] = strComparisonOp;
}
}
return objgs_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_RequestNoticeEN SetTableKey(this clsgs_RequestNoticeEN objgs_RequestNoticeEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 20, congs_RequestNotice.TableKey);
}
objgs_RequestNoticeEN.TableKey = strTableKey; //表主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_RequestNoticeEN.dicFldComparisonOp.ContainsKey(congs_RequestNotice.TableKey) == false)
{
objgs_RequestNoticeEN.dicFldComparisonOp.Add(congs_RequestNotice.TableKey, strComparisonOp);
}
else
{
objgs_RequestNoticeEN.dicFldComparisonOp[congs_RequestNotice.TableKey] = strComparisonOp;
}
}
return objgs_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_RequestNoticeEN SetReceiveUser(this clsgs_RequestNoticeEN objgs_RequestNoticeEN, string strReceiveUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReceiveUser, 20, congs_RequestNotice.ReceiveUser);
}
objgs_RequestNoticeEN.ReceiveUser = strReceiveUser; //接收用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_RequestNoticeEN.dicFldComparisonOp.ContainsKey(congs_RequestNotice.ReceiveUser) == false)
{
objgs_RequestNoticeEN.dicFldComparisonOp.Add(congs_RequestNotice.ReceiveUser, strComparisonOp);
}
else
{
objgs_RequestNoticeEN.dicFldComparisonOp[congs_RequestNotice.ReceiveUser] = strComparisonOp;
}
}
return objgs_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_RequestNoticeEN SetIsReply(this clsgs_RequestNoticeEN objgs_RequestNoticeEN, bool bolIsReply, string strComparisonOp="")
	{
objgs_RequestNoticeEN.IsReply = bolIsReply; //是否回复
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_RequestNoticeEN.dicFldComparisonOp.ContainsKey(congs_RequestNotice.IsReply) == false)
{
objgs_RequestNoticeEN.dicFldComparisonOp.Add(congs_RequestNotice.IsReply, strComparisonOp);
}
else
{
objgs_RequestNoticeEN.dicFldComparisonOp[congs_RequestNotice.IsReply] = strComparisonOp;
}
}
return objgs_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_RequestNoticeEN SetReplyDate(this clsgs_RequestNoticeEN objgs_RequestNoticeEN, string strReplyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReplyDate, 20, congs_RequestNotice.ReplyDate);
}
objgs_RequestNoticeEN.ReplyDate = strReplyDate; //回复日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_RequestNoticeEN.dicFldComparisonOp.ContainsKey(congs_RequestNotice.ReplyDate) == false)
{
objgs_RequestNoticeEN.dicFldComparisonOp.Add(congs_RequestNotice.ReplyDate, strComparisonOp);
}
else
{
objgs_RequestNoticeEN.dicFldComparisonOp[congs_RequestNotice.ReplyDate] = strComparisonOp;
}
}
return objgs_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_RequestNoticeEN SetRequestUser(this clsgs_RequestNoticeEN objgs_RequestNoticeEN, string strRequestUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequestUser, 20, congs_RequestNotice.RequestUser);
}
objgs_RequestNoticeEN.RequestUser = strRequestUser; //RequestUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_RequestNoticeEN.dicFldComparisonOp.ContainsKey(congs_RequestNotice.RequestUser) == false)
{
objgs_RequestNoticeEN.dicFldComparisonOp.Add(congs_RequestNotice.RequestUser, strComparisonOp);
}
else
{
objgs_RequestNoticeEN.dicFldComparisonOp[congs_RequestNotice.RequestUser] = strComparisonOp;
}
}
return objgs_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_RequestNoticeEN SetRequestDate(this clsgs_RequestNoticeEN objgs_RequestNoticeEN, string strRequestDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequestDate, 20, congs_RequestNotice.RequestDate);
}
objgs_RequestNoticeEN.RequestDate = strRequestDate; //RequestDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_RequestNoticeEN.dicFldComparisonOp.ContainsKey(congs_RequestNotice.RequestDate) == false)
{
objgs_RequestNoticeEN.dicFldComparisonOp.Add(congs_RequestNotice.RequestDate, strComparisonOp);
}
else
{
objgs_RequestNoticeEN.dicFldComparisonOp[congs_RequestNotice.RequestDate] = strComparisonOp;
}
}
return objgs_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_RequestNoticeEN SetRequestStata(this clsgs_RequestNoticeEN objgs_RequestNoticeEN, string strRequestStata, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequestStata, 10, congs_RequestNotice.RequestStata);
}
objgs_RequestNoticeEN.RequestStata = strRequestStata; //RequestStata
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_RequestNoticeEN.dicFldComparisonOp.ContainsKey(congs_RequestNotice.RequestStata) == false)
{
objgs_RequestNoticeEN.dicFldComparisonOp.Add(congs_RequestNotice.RequestStata, strComparisonOp);
}
else
{
objgs_RequestNoticeEN.dicFldComparisonOp[congs_RequestNotice.RequestStata] = strComparisonOp;
}
}
return objgs_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_RequestNoticeEN SetPushTypeId(this clsgs_RequestNoticeEN objgs_RequestNoticeEN, string strPushTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPushTypeId, 2, congs_RequestNotice.PushTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPushTypeId, 2, congs_RequestNotice.PushTypeId);
}
objgs_RequestNoticeEN.PushTypeId = strPushTypeId; //推送类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_RequestNoticeEN.dicFldComparisonOp.ContainsKey(congs_RequestNotice.PushTypeId) == false)
{
objgs_RequestNoticeEN.dicFldComparisonOp.Add(congs_RequestNotice.PushTypeId, strComparisonOp);
}
else
{
objgs_RequestNoticeEN.dicFldComparisonOp[congs_RequestNotice.PushTypeId] = strComparisonOp;
}
}
return objgs_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_RequestNoticeEN SetIdCurrEduCls(this clsgs_RequestNoticeEN objgs_RequestNoticeEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, congs_RequestNotice.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, congs_RequestNotice.IdCurrEduCls);
}
objgs_RequestNoticeEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_RequestNoticeEN.dicFldComparisonOp.ContainsKey(congs_RequestNotice.IdCurrEduCls) == false)
{
objgs_RequestNoticeEN.dicFldComparisonOp.Add(congs_RequestNotice.IdCurrEduCls, strComparisonOp);
}
else
{
objgs_RequestNoticeEN.dicFldComparisonOp[congs_RequestNotice.IdCurrEduCls] = strComparisonOp;
}
}
return objgs_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_RequestNoticeEN SetMemo(this clsgs_RequestNoticeEN objgs_RequestNoticeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_RequestNotice.Memo);
}
objgs_RequestNoticeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_RequestNoticeEN.dicFldComparisonOp.ContainsKey(congs_RequestNotice.Memo) == false)
{
objgs_RequestNoticeEN.dicFldComparisonOp.Add(congs_RequestNotice.Memo, strComparisonOp);
}
else
{
objgs_RequestNoticeEN.dicFldComparisonOp[congs_RequestNotice.Memo] = strComparisonOp;
}
}
return objgs_RequestNoticeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_RequestNoticeEN.CheckPropertyNew();
clsgs_RequestNoticeEN objgs_RequestNoticeCond = new clsgs_RequestNoticeEN();
string strCondition = objgs_RequestNoticeCond
.SetRequestId(objgs_RequestNoticeEN.RequestId, "<>")
.SetRequesTypeId(objgs_RequestNoticeEN.RequesTypeId, "=")
.SetTableKey(objgs_RequestNoticeEN.TableKey, "=")
.GetCombineCondition();
objgs_RequestNoticeEN._IsCheckProperty = true;
bool bolIsExist = clsgs_RequestNoticeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(RequesTypeId_TableKey)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_RequestNoticeEN.Update();
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
 /// <param name = "objgs_RequestNotice">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_RequestNoticeEN objgs_RequestNotice)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_RequestNoticeEN objgs_RequestNoticeCond = new clsgs_RequestNoticeEN();
string strCondition = objgs_RequestNoticeCond
.SetRequesTypeId(objgs_RequestNotice.RequesTypeId, "=")
.SetTableKey(objgs_RequestNotice.TableKey, "=")
.GetCombineCondition();
objgs_RequestNotice._IsCheckProperty = true;
bool bolIsExist = clsgs_RequestNoticeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_RequestNotice.RequestId = clsgs_RequestNoticeBL.GetFirstID_S(strCondition);
objgs_RequestNotice.UpdateWithCondition(strCondition);
}
else
{
objgs_RequestNotice.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
 if (objgs_RequestNoticeEN.RequestId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_RequestNoticeBL.gs_RequestNoticeDA.UpdateBySql2(objgs_RequestNoticeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_RequestNoticeBL.ReFreshCache();

if (clsgs_RequestNoticeBL.relatedActions != null)
{
clsgs_RequestNoticeBL.relatedActions.UpdRelaTabDate(objgs_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objgs_RequestNoticeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_RequestNoticeEN objgs_RequestNoticeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_RequestNoticeEN.RequestId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_RequestNoticeBL.gs_RequestNoticeDA.UpdateBySql2(objgs_RequestNoticeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_RequestNoticeBL.ReFreshCache();

if (clsgs_RequestNoticeBL.relatedActions != null)
{
clsgs_RequestNoticeBL.relatedActions.UpdRelaTabDate(objgs_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objgs_RequestNoticeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_RequestNoticeEN objgs_RequestNoticeEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_RequestNoticeBL.gs_RequestNoticeDA.UpdateBySqlWithCondition(objgs_RequestNoticeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_RequestNoticeBL.ReFreshCache();

if (clsgs_RequestNoticeBL.relatedActions != null)
{
clsgs_RequestNoticeBL.relatedActions.UpdRelaTabDate(objgs_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objgs_RequestNoticeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_RequestNoticeEN objgs_RequestNoticeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_RequestNoticeBL.gs_RequestNoticeDA.UpdateBySqlWithConditionTransaction(objgs_RequestNoticeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_RequestNoticeBL.ReFreshCache();

if (clsgs_RequestNoticeBL.relatedActions != null)
{
clsgs_RequestNoticeBL.relatedActions.UpdRelaTabDate(objgs_RequestNoticeEN.RequestId, "SetUpdDate");
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
public static int Delete(this clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
try
{
int intRecNum = clsgs_RequestNoticeBL.gs_RequestNoticeDA.DelRecord(objgs_RequestNoticeEN.RequestId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_RequestNoticeBL.ReFreshCache();

if (clsgs_RequestNoticeBL.relatedActions != null)
{
clsgs_RequestNoticeBL.relatedActions.UpdRelaTabDate(objgs_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objgs_RequestNoticeENS">源对象</param>
 /// <param name = "objgs_RequestNoticeENT">目标对象</param>
 public static void CopyTo(this clsgs_RequestNoticeEN objgs_RequestNoticeENS, clsgs_RequestNoticeEN objgs_RequestNoticeENT)
{
try
{
objgs_RequestNoticeENT.RequestId = objgs_RequestNoticeENS.RequestId; //RequestId
objgs_RequestNoticeENT.RequesTypeId = objgs_RequestNoticeENS.RequesTypeId; //请求类型Id
objgs_RequestNoticeENT.TableKey = objgs_RequestNoticeENS.TableKey; //表主键
objgs_RequestNoticeENT.ReceiveUser = objgs_RequestNoticeENS.ReceiveUser; //接收用户
objgs_RequestNoticeENT.IsReply = objgs_RequestNoticeENS.IsReply; //是否回复
objgs_RequestNoticeENT.ReplyDate = objgs_RequestNoticeENS.ReplyDate; //回复日期
objgs_RequestNoticeENT.RequestUser = objgs_RequestNoticeENS.RequestUser; //RequestUser
objgs_RequestNoticeENT.RequestDate = objgs_RequestNoticeENS.RequestDate; //RequestDate
objgs_RequestNoticeENT.RequestStata = objgs_RequestNoticeENS.RequestStata; //RequestStata
objgs_RequestNoticeENT.PushTypeId = objgs_RequestNoticeENS.PushTypeId; //推送类型Id
objgs_RequestNoticeENT.IdCurrEduCls = objgs_RequestNoticeENS.IdCurrEduCls; //教学班流水号
objgs_RequestNoticeENT.Memo = objgs_RequestNoticeENS.Memo; //备注
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
 /// <param name = "objgs_RequestNoticeENS">源对象</param>
 /// <returns>目标对象=>clsgs_RequestNoticeEN:objgs_RequestNoticeENT</returns>
 public static clsgs_RequestNoticeEN CopyTo(this clsgs_RequestNoticeEN objgs_RequestNoticeENS)
{
try
{
 clsgs_RequestNoticeEN objgs_RequestNoticeENT = new clsgs_RequestNoticeEN()
{
RequestId = objgs_RequestNoticeENS.RequestId, //RequestId
RequesTypeId = objgs_RequestNoticeENS.RequesTypeId, //请求类型Id
TableKey = objgs_RequestNoticeENS.TableKey, //表主键
ReceiveUser = objgs_RequestNoticeENS.ReceiveUser, //接收用户
IsReply = objgs_RequestNoticeENS.IsReply, //是否回复
ReplyDate = objgs_RequestNoticeENS.ReplyDate, //回复日期
RequestUser = objgs_RequestNoticeENS.RequestUser, //RequestUser
RequestDate = objgs_RequestNoticeENS.RequestDate, //RequestDate
RequestStata = objgs_RequestNoticeENS.RequestStata, //RequestStata
PushTypeId = objgs_RequestNoticeENS.PushTypeId, //推送类型Id
IdCurrEduCls = objgs_RequestNoticeENS.IdCurrEduCls, //教学班流水号
Memo = objgs_RequestNoticeENS.Memo, //备注
};
 return objgs_RequestNoticeENT;
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
public static void CheckPropertyNew(this clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
 clsgs_RequestNoticeBL.gs_RequestNoticeDA.CheckPropertyNew(objgs_RequestNoticeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
 clsgs_RequestNoticeBL.gs_RequestNoticeDA.CheckProperty4Condition(objgs_RequestNoticeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_RequestNoticeEN objgs_RequestNoticeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_RequestNoticeCond.IsUpdated(congs_RequestNotice.RequestId) == true)
{
string strComparisonOpRequestId = objgs_RequestNoticeCond.dicFldComparisonOp[congs_RequestNotice.RequestId];
strWhereCond += string.Format(" And {0} {2} {1}", congs_RequestNotice.RequestId, objgs_RequestNoticeCond.RequestId, strComparisonOpRequestId);
}
if (objgs_RequestNoticeCond.IsUpdated(congs_RequestNotice.RequesTypeId) == true)
{
string strComparisonOpRequesTypeId = objgs_RequestNoticeCond.dicFldComparisonOp[congs_RequestNotice.RequesTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_RequestNotice.RequesTypeId, objgs_RequestNoticeCond.RequesTypeId, strComparisonOpRequesTypeId);
}
if (objgs_RequestNoticeCond.IsUpdated(congs_RequestNotice.TableKey) == true)
{
string strComparisonOpTableKey = objgs_RequestNoticeCond.dicFldComparisonOp[congs_RequestNotice.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_RequestNotice.TableKey, objgs_RequestNoticeCond.TableKey, strComparisonOpTableKey);
}
if (objgs_RequestNoticeCond.IsUpdated(congs_RequestNotice.ReceiveUser) == true)
{
string strComparisonOpReceiveUser = objgs_RequestNoticeCond.dicFldComparisonOp[congs_RequestNotice.ReceiveUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_RequestNotice.ReceiveUser, objgs_RequestNoticeCond.ReceiveUser, strComparisonOpReceiveUser);
}
if (objgs_RequestNoticeCond.IsUpdated(congs_RequestNotice.IsReply) == true)
{
if (objgs_RequestNoticeCond.IsReply == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_RequestNotice.IsReply);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_RequestNotice.IsReply);
}
}
if (objgs_RequestNoticeCond.IsUpdated(congs_RequestNotice.ReplyDate) == true)
{
string strComparisonOpReplyDate = objgs_RequestNoticeCond.dicFldComparisonOp[congs_RequestNotice.ReplyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_RequestNotice.ReplyDate, objgs_RequestNoticeCond.ReplyDate, strComparisonOpReplyDate);
}
if (objgs_RequestNoticeCond.IsUpdated(congs_RequestNotice.RequestUser) == true)
{
string strComparisonOpRequestUser = objgs_RequestNoticeCond.dicFldComparisonOp[congs_RequestNotice.RequestUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_RequestNotice.RequestUser, objgs_RequestNoticeCond.RequestUser, strComparisonOpRequestUser);
}
if (objgs_RequestNoticeCond.IsUpdated(congs_RequestNotice.RequestDate) == true)
{
string strComparisonOpRequestDate = objgs_RequestNoticeCond.dicFldComparisonOp[congs_RequestNotice.RequestDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_RequestNotice.RequestDate, objgs_RequestNoticeCond.RequestDate, strComparisonOpRequestDate);
}
if (objgs_RequestNoticeCond.IsUpdated(congs_RequestNotice.RequestStata) == true)
{
string strComparisonOpRequestStata = objgs_RequestNoticeCond.dicFldComparisonOp[congs_RequestNotice.RequestStata];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_RequestNotice.RequestStata, objgs_RequestNoticeCond.RequestStata, strComparisonOpRequestStata);
}
if (objgs_RequestNoticeCond.IsUpdated(congs_RequestNotice.PushTypeId) == true)
{
string strComparisonOpPushTypeId = objgs_RequestNoticeCond.dicFldComparisonOp[congs_RequestNotice.PushTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_RequestNotice.PushTypeId, objgs_RequestNoticeCond.PushTypeId, strComparisonOpPushTypeId);
}
if (objgs_RequestNoticeCond.IsUpdated(congs_RequestNotice.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objgs_RequestNoticeCond.dicFldComparisonOp[congs_RequestNotice.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_RequestNotice.IdCurrEduCls, objgs_RequestNoticeCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objgs_RequestNoticeCond.IsUpdated(congs_RequestNotice.Memo) == true)
{
string strComparisonOpMemo = objgs_RequestNoticeCond.dicFldComparisonOp[congs_RequestNotice.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_RequestNotice.Memo, objgs_RequestNoticeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_RequestNotice(请求通知表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RequesTypeId_TableKey
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_RequestNoticeEN == null) return true;
if (objgs_RequestNoticeEN.RequestId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_RequestNoticeEN.RequesTypeId == null)
{
 sbCondition.AppendFormat(" and RequesTypeId is null", objgs_RequestNoticeEN.RequesTypeId);
}
else
{
 sbCondition.AppendFormat(" and RequesTypeId = '{0}'", objgs_RequestNoticeEN.RequesTypeId);
}
 if (objgs_RequestNoticeEN.TableKey == null)
{
 sbCondition.AppendFormat(" and TableKey is null", objgs_RequestNoticeEN.TableKey);
}
else
{
 sbCondition.AppendFormat(" and TableKey = '{0}'", objgs_RequestNoticeEN.TableKey);
}
if (clsgs_RequestNoticeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("RequestId !=  {0}", objgs_RequestNoticeEN.RequestId);
 sbCondition.AppendFormat(" and RequesTypeId = '{0}'", objgs_RequestNoticeEN.RequesTypeId);
 sbCondition.AppendFormat(" and TableKey = '{0}'", objgs_RequestNoticeEN.TableKey);
if (clsgs_RequestNoticeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_RequestNotice(请求通知表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RequesTypeId_TableKey
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_RequestNoticeEN == null) return "";
if (objgs_RequestNoticeEN.RequestId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_RequestNoticeEN.RequesTypeId == null)
{
 sbCondition.AppendFormat(" and RequesTypeId is null", objgs_RequestNoticeEN.RequesTypeId);
}
else
{
 sbCondition.AppendFormat(" and RequesTypeId = '{0}'", objgs_RequestNoticeEN.RequesTypeId);
}
 if (objgs_RequestNoticeEN.TableKey == null)
{
 sbCondition.AppendFormat(" and TableKey is null", objgs_RequestNoticeEN.TableKey);
}
else
{
 sbCondition.AppendFormat(" and TableKey = '{0}'", objgs_RequestNoticeEN.TableKey);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RequestId !=  {0}", objgs_RequestNoticeEN.RequestId);
 sbCondition.AppendFormat(" and RequesTypeId = '{0}'", objgs_RequestNoticeEN.RequesTypeId);
 sbCondition.AppendFormat(" and TableKey = '{0}'", objgs_RequestNoticeEN.TableKey);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_RequestNotice
{
public virtual bool UpdRelaTabDate(long lngRequestId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 请求通知表(gs_RequestNotice)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_RequestNoticeBL
{
public static RelatedActions_gs_RequestNotice relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_RequestNoticeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_RequestNoticeDA gs_RequestNoticeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_RequestNoticeDA();
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
 public clsgs_RequestNoticeBL()
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
if (string.IsNullOrEmpty(clsgs_RequestNoticeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_RequestNoticeEN._ConnectString);
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
public static DataTable GetDataTable_gs_RequestNotice(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_RequestNoticeDA.GetDataTable_gs_RequestNotice(strWhereCond);
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
objDT = gs_RequestNoticeDA.GetDataTable(strWhereCond);
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
objDT = gs_RequestNoticeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_RequestNoticeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_RequestNoticeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_RequestNoticeDA.GetDataTable_Top(objTopPara);
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
objDT = gs_RequestNoticeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_RequestNoticeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_RequestNoticeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsgs_RequestNoticeEN> GetObjLstByRequestIdLst(List<long> arrRequestIdLst)
{
List<clsgs_RequestNoticeEN> arrObjLst = new List<clsgs_RequestNoticeEN>(); 
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
	clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN();
try
{
objgs_RequestNoticeEN.RequestId = Int32.Parse(objRow[congs_RequestNotice.RequestId].ToString().Trim()); //RequestId
objgs_RequestNoticeEN.RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objgs_RequestNoticeEN.TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键
objgs_RequestNoticeEN.ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objgs_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[congs_RequestNotice.IsReply].ToString().Trim()); //是否回复
objgs_RequestNoticeEN.ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objgs_RequestNoticeEN.RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objgs_RequestNoticeEN.RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objgs_RequestNoticeEN.RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objgs_RequestNoticeEN.PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objgs_RequestNoticeEN.IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_RequestNoticeEN.Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_RequestNoticeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRequestIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_RequestNoticeEN> GetObjLstByRequestIdLstCache(List<long> arrRequestIdLst)
{
string strKey = string.Format("{0}", clsgs_RequestNoticeEN._CurrTabName);
List<clsgs_RequestNoticeEN> arrgs_RequestNoticeObjLstCache = GetObjLstCache();
IEnumerable <clsgs_RequestNoticeEN> arrgs_RequestNoticeObjLst_Sel =
arrgs_RequestNoticeObjLstCache
.Where(x => arrRequestIdLst.Contains(x.RequestId));
return arrgs_RequestNoticeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_RequestNoticeEN> GetObjLst(string strWhereCond)
{
List<clsgs_RequestNoticeEN> arrObjLst = new List<clsgs_RequestNoticeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN();
try
{
objgs_RequestNoticeEN.RequestId = Int32.Parse(objRow[congs_RequestNotice.RequestId].ToString().Trim()); //RequestId
objgs_RequestNoticeEN.RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objgs_RequestNoticeEN.TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键
objgs_RequestNoticeEN.ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objgs_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[congs_RequestNotice.IsReply].ToString().Trim()); //是否回复
objgs_RequestNoticeEN.ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objgs_RequestNoticeEN.RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objgs_RequestNoticeEN.RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objgs_RequestNoticeEN.RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objgs_RequestNoticeEN.PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objgs_RequestNoticeEN.IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_RequestNoticeEN.Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_RequestNoticeEN);
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
public static List<clsgs_RequestNoticeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_RequestNoticeEN> arrObjLst = new List<clsgs_RequestNoticeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN();
try
{
objgs_RequestNoticeEN.RequestId = Int32.Parse(objRow[congs_RequestNotice.RequestId].ToString().Trim()); //RequestId
objgs_RequestNoticeEN.RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objgs_RequestNoticeEN.TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键
objgs_RequestNoticeEN.ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objgs_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[congs_RequestNotice.IsReply].ToString().Trim()); //是否回复
objgs_RequestNoticeEN.ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objgs_RequestNoticeEN.RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objgs_RequestNoticeEN.RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objgs_RequestNoticeEN.RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objgs_RequestNoticeEN.PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objgs_RequestNoticeEN.IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_RequestNoticeEN.Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_RequestNoticeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_RequestNoticeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_RequestNoticeEN> GetSubObjLstCache(clsgs_RequestNoticeEN objgs_RequestNoticeCond)
{
List<clsgs_RequestNoticeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_RequestNoticeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_RequestNotice.AttributeName)
{
if (objgs_RequestNoticeCond.IsUpdated(strFldName) == false) continue;
if (objgs_RequestNoticeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_RequestNoticeCond[strFldName].ToString());
}
else
{
if (objgs_RequestNoticeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_RequestNoticeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_RequestNoticeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_RequestNoticeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_RequestNoticeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_RequestNoticeCond[strFldName]));
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
public static List<clsgs_RequestNoticeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_RequestNoticeEN> arrObjLst = new List<clsgs_RequestNoticeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN();
try
{
objgs_RequestNoticeEN.RequestId = Int32.Parse(objRow[congs_RequestNotice.RequestId].ToString().Trim()); //RequestId
objgs_RequestNoticeEN.RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objgs_RequestNoticeEN.TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键
objgs_RequestNoticeEN.ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objgs_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[congs_RequestNotice.IsReply].ToString().Trim()); //是否回复
objgs_RequestNoticeEN.ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objgs_RequestNoticeEN.RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objgs_RequestNoticeEN.RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objgs_RequestNoticeEN.RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objgs_RequestNoticeEN.PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objgs_RequestNoticeEN.IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_RequestNoticeEN.Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_RequestNoticeEN);
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
public static List<clsgs_RequestNoticeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_RequestNoticeEN> arrObjLst = new List<clsgs_RequestNoticeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN();
try
{
objgs_RequestNoticeEN.RequestId = Int32.Parse(objRow[congs_RequestNotice.RequestId].ToString().Trim()); //RequestId
objgs_RequestNoticeEN.RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objgs_RequestNoticeEN.TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键
objgs_RequestNoticeEN.ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objgs_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[congs_RequestNotice.IsReply].ToString().Trim()); //是否回复
objgs_RequestNoticeEN.ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objgs_RequestNoticeEN.RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objgs_RequestNoticeEN.RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objgs_RequestNoticeEN.RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objgs_RequestNoticeEN.PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objgs_RequestNoticeEN.IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_RequestNoticeEN.Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_RequestNoticeEN);
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
List<clsgs_RequestNoticeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_RequestNoticeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_RequestNoticeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_RequestNoticeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_RequestNoticeEN> arrObjLst = new List<clsgs_RequestNoticeEN>(); 
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
	clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN();
try
{
objgs_RequestNoticeEN.RequestId = Int32.Parse(objRow[congs_RequestNotice.RequestId].ToString().Trim()); //RequestId
objgs_RequestNoticeEN.RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objgs_RequestNoticeEN.TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键
objgs_RequestNoticeEN.ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objgs_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[congs_RequestNotice.IsReply].ToString().Trim()); //是否回复
objgs_RequestNoticeEN.ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objgs_RequestNoticeEN.RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objgs_RequestNoticeEN.RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objgs_RequestNoticeEN.RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objgs_RequestNoticeEN.PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objgs_RequestNoticeEN.IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_RequestNoticeEN.Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_RequestNoticeEN);
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
public static List<clsgs_RequestNoticeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_RequestNoticeEN> arrObjLst = new List<clsgs_RequestNoticeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN();
try
{
objgs_RequestNoticeEN.RequestId = Int32.Parse(objRow[congs_RequestNotice.RequestId].ToString().Trim()); //RequestId
objgs_RequestNoticeEN.RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objgs_RequestNoticeEN.TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键
objgs_RequestNoticeEN.ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objgs_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[congs_RequestNotice.IsReply].ToString().Trim()); //是否回复
objgs_RequestNoticeEN.ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objgs_RequestNoticeEN.RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objgs_RequestNoticeEN.RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objgs_RequestNoticeEN.RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objgs_RequestNoticeEN.PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objgs_RequestNoticeEN.IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_RequestNoticeEN.Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_RequestNoticeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_RequestNoticeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_RequestNoticeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_RequestNoticeEN> arrObjLst = new List<clsgs_RequestNoticeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN();
try
{
objgs_RequestNoticeEN.RequestId = Int32.Parse(objRow[congs_RequestNotice.RequestId].ToString().Trim()); //RequestId
objgs_RequestNoticeEN.RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objgs_RequestNoticeEN.TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键
objgs_RequestNoticeEN.ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objgs_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[congs_RequestNotice.IsReply].ToString().Trim()); //是否回复
objgs_RequestNoticeEN.ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objgs_RequestNoticeEN.RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objgs_RequestNoticeEN.RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objgs_RequestNoticeEN.RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objgs_RequestNoticeEN.PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objgs_RequestNoticeEN.IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_RequestNoticeEN.Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_RequestNoticeEN);
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
public static List<clsgs_RequestNoticeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_RequestNoticeEN> arrObjLst = new List<clsgs_RequestNoticeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN();
try
{
objgs_RequestNoticeEN.RequestId = Int32.Parse(objRow[congs_RequestNotice.RequestId].ToString().Trim()); //RequestId
objgs_RequestNoticeEN.RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objgs_RequestNoticeEN.TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键
objgs_RequestNoticeEN.ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objgs_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[congs_RequestNotice.IsReply].ToString().Trim()); //是否回复
objgs_RequestNoticeEN.ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objgs_RequestNoticeEN.RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objgs_RequestNoticeEN.RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objgs_RequestNoticeEN.RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objgs_RequestNoticeEN.PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objgs_RequestNoticeEN.IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_RequestNoticeEN.Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_RequestNoticeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_RequestNoticeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_RequestNoticeEN> arrObjLst = new List<clsgs_RequestNoticeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN();
try
{
objgs_RequestNoticeEN.RequestId = Int32.Parse(objRow[congs_RequestNotice.RequestId].ToString().Trim()); //RequestId
objgs_RequestNoticeEN.RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objgs_RequestNoticeEN.TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键
objgs_RequestNoticeEN.ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objgs_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[congs_RequestNotice.IsReply].ToString().Trim()); //是否回复
objgs_RequestNoticeEN.ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objgs_RequestNoticeEN.RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objgs_RequestNoticeEN.RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objgs_RequestNoticeEN.RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objgs_RequestNoticeEN.PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objgs_RequestNoticeEN.IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_RequestNoticeEN.Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_RequestNoticeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_RequestNotice(ref clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
bool bolResult = gs_RequestNoticeDA.Getgs_RequestNotice(ref objgs_RequestNoticeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngRequestId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_RequestNoticeEN GetObjByRequestId(long lngRequestId)
{
clsgs_RequestNoticeEN objgs_RequestNoticeEN = gs_RequestNoticeDA.GetObjByRequestId(lngRequestId);
return objgs_RequestNoticeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_RequestNoticeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_RequestNoticeEN objgs_RequestNoticeEN = gs_RequestNoticeDA.GetFirstObj(strWhereCond);
 return objgs_RequestNoticeEN;
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
public static clsgs_RequestNoticeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_RequestNoticeEN objgs_RequestNoticeEN = gs_RequestNoticeDA.GetObjByDataRow(objRow);
 return objgs_RequestNoticeEN;
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
public static clsgs_RequestNoticeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_RequestNoticeEN objgs_RequestNoticeEN = gs_RequestNoticeDA.GetObjByDataRow(objRow);
 return objgs_RequestNoticeEN;
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
 /// <param name = "lstgs_RequestNoticeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_RequestNoticeEN GetObjByRequestIdFromList(long lngRequestId, List<clsgs_RequestNoticeEN> lstgs_RequestNoticeObjLst)
{
foreach (clsgs_RequestNoticeEN objgs_RequestNoticeEN in lstgs_RequestNoticeObjLst)
{
if (objgs_RequestNoticeEN.RequestId == lngRequestId)
{
return objgs_RequestNoticeEN;
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
 lngRequestId = new clsgs_RequestNoticeDA().GetFirstID(strWhereCond);
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
 arrList = gs_RequestNoticeDA.GetID(strWhereCond);
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
bool bolIsExist = gs_RequestNoticeDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = gs_RequestNoticeDA.IsExist(lngRequestId);
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
 bolIsExist = clsgs_RequestNoticeDA.IsExistTable();
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
 bolIsExist = gs_RequestNoticeDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
if (objgs_RequestNoticeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!请求类型Id = [{0}],表主键 = [{1}]的数据已经存在!(in clsgs_RequestNoticeBL.AddNewRecordBySql2)", objgs_RequestNoticeEN.RequesTypeId,objgs_RequestNoticeEN.TableKey);
throw new Exception(strMsg);
}
try
{
bool bolResult = gs_RequestNoticeDA.AddNewRecordBySQL2(objgs_RequestNoticeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_RequestNoticeBL.ReFreshCache();

if (clsgs_RequestNoticeBL.relatedActions != null)
{
clsgs_RequestNoticeBL.relatedActions.UpdRelaTabDate(objgs_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objgs_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
if (objgs_RequestNoticeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!请求类型Id = [{0}],表主键 = [{1}]的数据已经存在!(in clsgs_RequestNoticeBL.AddNewRecordBySql2WithReturnKey)", objgs_RequestNoticeEN.RequesTypeId,objgs_RequestNoticeEN.TableKey);
throw new Exception(strMsg);
}
try
{
string strKey = gs_RequestNoticeDA.AddNewRecordBySQL2WithReturnKey(objgs_RequestNoticeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_RequestNoticeBL.ReFreshCache();

if (clsgs_RequestNoticeBL.relatedActions != null)
{
clsgs_RequestNoticeBL.relatedActions.UpdRelaTabDate(objgs_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objgs_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
try
{
bool bolResult = gs_RequestNoticeDA.Update(objgs_RequestNoticeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_RequestNoticeBL.ReFreshCache();

if (clsgs_RequestNoticeBL.relatedActions != null)
{
clsgs_RequestNoticeBL.relatedActions.UpdRelaTabDate(objgs_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objgs_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
 if (objgs_RequestNoticeEN.RequestId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_RequestNoticeDA.UpdateBySql2(objgs_RequestNoticeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_RequestNoticeBL.ReFreshCache();

if (clsgs_RequestNoticeBL.relatedActions != null)
{
clsgs_RequestNoticeBL.relatedActions.UpdRelaTabDate(objgs_RequestNoticeEN.RequestId, "SetUpdDate");
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
 clsgs_RequestNoticeEN objgs_RequestNoticeEN = clsgs_RequestNoticeBL.GetObjByRequestId(lngRequestId);

if (clsgs_RequestNoticeBL.relatedActions != null)
{
clsgs_RequestNoticeBL.relatedActions.UpdRelaTabDate(objgs_RequestNoticeEN.RequestId, "SetUpdDate");
}
if (objgs_RequestNoticeEN != null)
{
int intRecNum = gs_RequestNoticeDA.DelRecord(lngRequestId);
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
objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
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
//删除与表:[gs_RequestNotice]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_RequestNotice.RequestId,
//lngRequestId);
//        clsgs_RequestNoticeBL.Delgs_RequestNoticesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_RequestNoticeBL.DelRecord(lngRequestId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_RequestNoticeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsgs_RequestNoticeBL.relatedActions != null)
{
clsgs_RequestNoticeBL.relatedActions.UpdRelaTabDate(lngRequestId, "UpdRelaTabDate");
}
bool bolResult = gs_RequestNoticeDA.DelRecord(lngRequestId,objSqlConnection,objSqlTransaction);
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
public static int Delgs_RequestNotices(List<string> arrRequestIdLst)
{
if (arrRequestIdLst.Count == 0) return 0;
try
{
if (clsgs_RequestNoticeBL.relatedActions != null)
{
foreach (var strRequestId in arrRequestIdLst)
{
long lngRequestId = long.Parse(strRequestId);
clsgs_RequestNoticeBL.relatedActions.UpdRelaTabDate(lngRequestId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_RequestNoticeDA.Delgs_RequestNotice(arrRequestIdLst);
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
public static int Delgs_RequestNoticesByCond(string strWhereCond)
{
try
{
if (clsgs_RequestNoticeBL.relatedActions != null)
{
List<string> arrRequestId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRequestId in arrRequestId)
{
long lngRequestId = long.Parse(strRequestId);
clsgs_RequestNoticeBL.relatedActions.UpdRelaTabDate(lngRequestId, "UpdRelaTabDate");
}
}
int intRecNum = gs_RequestNoticeDA.Delgs_RequestNotice(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_RequestNotice]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngRequestId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngRequestId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
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
//删除与表:[gs_RequestNotice]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_RequestNoticeBL.DelRecord(lngRequestId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_RequestNoticeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objgs_RequestNoticeENS">源对象</param>
 /// <param name = "objgs_RequestNoticeENT">目标对象</param>
 public static void CopyTo(clsgs_RequestNoticeEN objgs_RequestNoticeENS, clsgs_RequestNoticeEN objgs_RequestNoticeENT)
{
try
{
objgs_RequestNoticeENT.RequestId = objgs_RequestNoticeENS.RequestId; //RequestId
objgs_RequestNoticeENT.RequesTypeId = objgs_RequestNoticeENS.RequesTypeId; //请求类型Id
objgs_RequestNoticeENT.TableKey = objgs_RequestNoticeENS.TableKey; //表主键
objgs_RequestNoticeENT.ReceiveUser = objgs_RequestNoticeENS.ReceiveUser; //接收用户
objgs_RequestNoticeENT.IsReply = objgs_RequestNoticeENS.IsReply; //是否回复
objgs_RequestNoticeENT.ReplyDate = objgs_RequestNoticeENS.ReplyDate; //回复日期
objgs_RequestNoticeENT.RequestUser = objgs_RequestNoticeENS.RequestUser; //RequestUser
objgs_RequestNoticeENT.RequestDate = objgs_RequestNoticeENS.RequestDate; //RequestDate
objgs_RequestNoticeENT.RequestStata = objgs_RequestNoticeENS.RequestStata; //RequestStata
objgs_RequestNoticeENT.PushTypeId = objgs_RequestNoticeENS.PushTypeId; //推送类型Id
objgs_RequestNoticeENT.IdCurrEduCls = objgs_RequestNoticeENS.IdCurrEduCls; //教学班流水号
objgs_RequestNoticeENT.Memo = objgs_RequestNoticeENS.Memo; //备注
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
 /// <param name = "objgs_RequestNoticeEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
try
{
objgs_RequestNoticeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_RequestNoticeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_RequestNotice.RequestId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_RequestNoticeEN.RequestId = objgs_RequestNoticeEN.RequestId; //RequestId
}
if (arrFldSet.Contains(congs_RequestNotice.RequesTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_RequestNoticeEN.RequesTypeId = objgs_RequestNoticeEN.RequesTypeId == "[null]" ? null :  objgs_RequestNoticeEN.RequesTypeId; //请求类型Id
}
if (arrFldSet.Contains(congs_RequestNotice.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_RequestNoticeEN.TableKey = objgs_RequestNoticeEN.TableKey == "[null]" ? null :  objgs_RequestNoticeEN.TableKey; //表主键
}
if (arrFldSet.Contains(congs_RequestNotice.ReceiveUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_RequestNoticeEN.ReceiveUser = objgs_RequestNoticeEN.ReceiveUser == "[null]" ? null :  objgs_RequestNoticeEN.ReceiveUser; //接收用户
}
if (arrFldSet.Contains(congs_RequestNotice.IsReply, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_RequestNoticeEN.IsReply = objgs_RequestNoticeEN.IsReply; //是否回复
}
if (arrFldSet.Contains(congs_RequestNotice.ReplyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_RequestNoticeEN.ReplyDate = objgs_RequestNoticeEN.ReplyDate == "[null]" ? null :  objgs_RequestNoticeEN.ReplyDate; //回复日期
}
if (arrFldSet.Contains(congs_RequestNotice.RequestUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_RequestNoticeEN.RequestUser = objgs_RequestNoticeEN.RequestUser == "[null]" ? null :  objgs_RequestNoticeEN.RequestUser; //RequestUser
}
if (arrFldSet.Contains(congs_RequestNotice.RequestDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_RequestNoticeEN.RequestDate = objgs_RequestNoticeEN.RequestDate == "[null]" ? null :  objgs_RequestNoticeEN.RequestDate; //RequestDate
}
if (arrFldSet.Contains(congs_RequestNotice.RequestStata, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_RequestNoticeEN.RequestStata = objgs_RequestNoticeEN.RequestStata == "[null]" ? null :  objgs_RequestNoticeEN.RequestStata; //RequestStata
}
if (arrFldSet.Contains(congs_RequestNotice.PushTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_RequestNoticeEN.PushTypeId = objgs_RequestNoticeEN.PushTypeId == "[null]" ? null :  objgs_RequestNoticeEN.PushTypeId; //推送类型Id
}
if (arrFldSet.Contains(congs_RequestNotice.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_RequestNoticeEN.IdCurrEduCls = objgs_RequestNoticeEN.IdCurrEduCls == "[null]" ? null :  objgs_RequestNoticeEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(congs_RequestNotice.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_RequestNoticeEN.Memo = objgs_RequestNoticeEN.Memo == "[null]" ? null :  objgs_RequestNoticeEN.Memo; //备注
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
 /// <param name = "objgs_RequestNoticeEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
try
{
if (objgs_RequestNoticeEN.RequesTypeId == "[null]") objgs_RequestNoticeEN.RequesTypeId = null; //请求类型Id
if (objgs_RequestNoticeEN.TableKey == "[null]") objgs_RequestNoticeEN.TableKey = null; //表主键
if (objgs_RequestNoticeEN.ReceiveUser == "[null]") objgs_RequestNoticeEN.ReceiveUser = null; //接收用户
if (objgs_RequestNoticeEN.ReplyDate == "[null]") objgs_RequestNoticeEN.ReplyDate = null; //回复日期
if (objgs_RequestNoticeEN.RequestUser == "[null]") objgs_RequestNoticeEN.RequestUser = null; //RequestUser
if (objgs_RequestNoticeEN.RequestDate == "[null]") objgs_RequestNoticeEN.RequestDate = null; //RequestDate
if (objgs_RequestNoticeEN.RequestStata == "[null]") objgs_RequestNoticeEN.RequestStata = null; //RequestStata
if (objgs_RequestNoticeEN.PushTypeId == "[null]") objgs_RequestNoticeEN.PushTypeId = null; //推送类型Id
if (objgs_RequestNoticeEN.IdCurrEduCls == "[null]") objgs_RequestNoticeEN.IdCurrEduCls = null; //教学班流水号
if (objgs_RequestNoticeEN.Memo == "[null]") objgs_RequestNoticeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
 gs_RequestNoticeDA.CheckPropertyNew(objgs_RequestNoticeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
 gs_RequestNoticeDA.CheckProperty4Condition(objgs_RequestNoticeEN);
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
if (clsgs_RequestNoticeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_RequestNoticeBL没有刷新缓存机制(clsgs_RequestNoticeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RequestId");
//if (arrgs_RequestNoticeObjLstCache == null)
//{
//arrgs_RequestNoticeObjLstCache = gs_RequestNoticeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngRequestId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_RequestNoticeEN GetObjByRequestIdCache(long lngRequestId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_RequestNoticeEN._CurrTabName);
List<clsgs_RequestNoticeEN> arrgs_RequestNoticeObjLstCache = GetObjLstCache();
IEnumerable <clsgs_RequestNoticeEN> arrgs_RequestNoticeObjLst_Sel =
arrgs_RequestNoticeObjLstCache
.Where(x=> x.RequestId == lngRequestId 
);
if (arrgs_RequestNoticeObjLst_Sel.Count() == 0)
{
   clsgs_RequestNoticeEN obj = clsgs_RequestNoticeBL.GetObjByRequestId(lngRequestId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_RequestNoticeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_RequestNoticeEN> GetAllgs_RequestNoticeObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_RequestNoticeEN> arrgs_RequestNoticeObjLstCache = GetObjLstCache(); 
return arrgs_RequestNoticeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_RequestNoticeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_RequestNoticeEN._CurrTabName);
List<clsgs_RequestNoticeEN> arrgs_RequestNoticeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_RequestNoticeObjLstCache;
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
string strKey = string.Format("{0}", clsgs_RequestNoticeEN._CurrTabName);
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
if (clsgs_RequestNoticeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_RequestNoticeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_RequestNoticeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_RequestNotice(请求通知表)
 /// 唯一性条件:RequesTypeId_TableKey
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
//检测记录是否存在
string strResult = gs_RequestNoticeDA.GetUniCondStr(objgs_RequestNoticeEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngRequestId)
{
if (strInFldName != congs_RequestNotice.RequestId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_RequestNotice.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_RequestNotice.AttributeName));
throw new Exception(strMsg);
}
var objgs_RequestNotice = clsgs_RequestNoticeBL.GetObjByRequestIdCache(lngRequestId);
if (objgs_RequestNotice == null) return "";
return objgs_RequestNotice[strOutFldName].ToString();
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
int intRecCount = clsgs_RequestNoticeDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_RequestNoticeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_RequestNoticeDA.GetRecCount();
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
int intRecCount = clsgs_RequestNoticeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_RequestNoticeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_RequestNoticeEN objgs_RequestNoticeCond)
{
List<clsgs_RequestNoticeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_RequestNoticeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_RequestNotice.AttributeName)
{
if (objgs_RequestNoticeCond.IsUpdated(strFldName) == false) continue;
if (objgs_RequestNoticeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_RequestNoticeCond[strFldName].ToString());
}
else
{
if (objgs_RequestNoticeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_RequestNoticeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_RequestNoticeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_RequestNoticeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_RequestNoticeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_RequestNoticeCond[strFldName]));
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
 List<string> arrList = clsgs_RequestNoticeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_RequestNoticeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_RequestNoticeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_RequestNoticeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_RequestNoticeDA.SetFldValue(clsgs_RequestNoticeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_RequestNoticeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_RequestNoticeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_RequestNoticeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_RequestNoticeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_RequestNotice] "); 
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
 // /**推送类型Id*/ 
 strCreateTabCode.Append(" PushTypeId char(2) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 请求通知表(gs_RequestNotice)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_RequestNotice : clsCommFun4BL
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
clsgs_RequestNoticeBL.ReFreshThisCache();
}
}

}