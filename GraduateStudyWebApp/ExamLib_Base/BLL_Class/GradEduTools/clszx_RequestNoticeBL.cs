
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_RequestNoticeBL
 表名:zx_RequestNotice(01120786)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
public static class  clszx_RequestNoticeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngRequestId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_RequestNoticeEN GetObj(this K_RequestId_zx_RequestNotice myKey)
{
clszx_RequestNoticeEN objzx_RequestNoticeEN = clszx_RequestNoticeBL.zx_RequestNoticeDA.GetObjByRequestId(myKey.Value);
return objzx_RequestNoticeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
if (CheckUniqueness(objzx_RequestNoticeEN) == false)
{
var strMsg = string.Format("记录已经存在!RequestId = [{0}]的数据已经存在!(in clszx_RequestNoticeBL.AddNewRecord)", objzx_RequestNoticeEN.RequestId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clszx_RequestNoticeBL.zx_RequestNoticeDA.AddNewRecordBySQL2(objzx_RequestNoticeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_RequestNoticeBL.ReFreshCache();

if (clszx_RequestNoticeBL.relatedActions != null)
{
clszx_RequestNoticeBL.relatedActions.UpdRelaTabDate(objzx_RequestNoticeEN.RequestId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_RequestNoticeEN objzx_RequestNoticeEN)
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
objzx_RequestNoticeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_RequestNoticeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(RequestId(RequestId)=[{0}])已经存在,不能重复!", objzx_RequestNoticeEN.RequestId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objzx_RequestNoticeEN.AddNewRecord();
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
 /// <param name = "objzx_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
if (CheckUniqueness(objzx_RequestNoticeEN) == false)
{
var strMsg = string.Format("记录已经存在!RequestId = [{0}]的数据已经存在!(in clszx_RequestNoticeBL.AddNewRecordWithReturnKey)", objzx_RequestNoticeEN.RequestId);
throw new Exception(strMsg);
}
try
{
string strKey = clszx_RequestNoticeBL.zx_RequestNoticeDA.AddNewRecordBySQL2WithReturnKey(objzx_RequestNoticeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_RequestNoticeBL.ReFreshCache();

if (clszx_RequestNoticeBL.relatedActions != null)
{
clszx_RequestNoticeBL.relatedActions.UpdRelaTabDate(objzx_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objzx_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_RequestNoticeEN SetRequestId(this clszx_RequestNoticeEN objzx_RequestNoticeEN, long lngRequestId, string strComparisonOp="")
	{
objzx_RequestNoticeEN.RequestId = lngRequestId; //RequestId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_RequestNoticeEN.dicFldComparisonOp.ContainsKey(conzx_RequestNotice.RequestId) == false)
{
objzx_RequestNoticeEN.dicFldComparisonOp.Add(conzx_RequestNotice.RequestId, strComparisonOp);
}
else
{
objzx_RequestNoticeEN.dicFldComparisonOp[conzx_RequestNotice.RequestId] = strComparisonOp;
}
}
return objzx_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_RequestNoticeEN SetRequesTypeId(this clszx_RequestNoticeEN objzx_RequestNoticeEN, string strRequesTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequesTypeId, 2, conzx_RequestNotice.RequesTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRequesTypeId, 2, conzx_RequestNotice.RequesTypeId);
}
objzx_RequestNoticeEN.RequesTypeId = strRequesTypeId; //请求类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_RequestNoticeEN.dicFldComparisonOp.ContainsKey(conzx_RequestNotice.RequesTypeId) == false)
{
objzx_RequestNoticeEN.dicFldComparisonOp.Add(conzx_RequestNotice.RequesTypeId, strComparisonOp);
}
else
{
objzx_RequestNoticeEN.dicFldComparisonOp[conzx_RequestNotice.RequesTypeId] = strComparisonOp;
}
}
return objzx_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_RequestNoticeEN SetTableKey(this clszx_RequestNoticeEN objzx_RequestNoticeEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 20, conzx_RequestNotice.TableKey);
}
objzx_RequestNoticeEN.TableKey = strTableKey; //表主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_RequestNoticeEN.dicFldComparisonOp.ContainsKey(conzx_RequestNotice.TableKey) == false)
{
objzx_RequestNoticeEN.dicFldComparisonOp.Add(conzx_RequestNotice.TableKey, strComparisonOp);
}
else
{
objzx_RequestNoticeEN.dicFldComparisonOp[conzx_RequestNotice.TableKey] = strComparisonOp;
}
}
return objzx_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_RequestNoticeEN SetReceiveUser(this clszx_RequestNoticeEN objzx_RequestNoticeEN, string strReceiveUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReceiveUser, 20, conzx_RequestNotice.ReceiveUser);
}
objzx_RequestNoticeEN.ReceiveUser = strReceiveUser; //接收用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_RequestNoticeEN.dicFldComparisonOp.ContainsKey(conzx_RequestNotice.ReceiveUser) == false)
{
objzx_RequestNoticeEN.dicFldComparisonOp.Add(conzx_RequestNotice.ReceiveUser, strComparisonOp);
}
else
{
objzx_RequestNoticeEN.dicFldComparisonOp[conzx_RequestNotice.ReceiveUser] = strComparisonOp;
}
}
return objzx_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_RequestNoticeEN SetIsReply(this clszx_RequestNoticeEN objzx_RequestNoticeEN, bool bolIsReply, string strComparisonOp="")
	{
objzx_RequestNoticeEN.IsReply = bolIsReply; //是否回复
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_RequestNoticeEN.dicFldComparisonOp.ContainsKey(conzx_RequestNotice.IsReply) == false)
{
objzx_RequestNoticeEN.dicFldComparisonOp.Add(conzx_RequestNotice.IsReply, strComparisonOp);
}
else
{
objzx_RequestNoticeEN.dicFldComparisonOp[conzx_RequestNotice.IsReply] = strComparisonOp;
}
}
return objzx_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_RequestNoticeEN SetReplyDate(this clszx_RequestNoticeEN objzx_RequestNoticeEN, string strReplyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReplyDate, 20, conzx_RequestNotice.ReplyDate);
}
objzx_RequestNoticeEN.ReplyDate = strReplyDate; //回复日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_RequestNoticeEN.dicFldComparisonOp.ContainsKey(conzx_RequestNotice.ReplyDate) == false)
{
objzx_RequestNoticeEN.dicFldComparisonOp.Add(conzx_RequestNotice.ReplyDate, strComparisonOp);
}
else
{
objzx_RequestNoticeEN.dicFldComparisonOp[conzx_RequestNotice.ReplyDate] = strComparisonOp;
}
}
return objzx_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_RequestNoticeEN SetRequestUser(this clszx_RequestNoticeEN objzx_RequestNoticeEN, string strRequestUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequestUser, 20, conzx_RequestNotice.RequestUser);
}
objzx_RequestNoticeEN.RequestUser = strRequestUser; //RequestUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_RequestNoticeEN.dicFldComparisonOp.ContainsKey(conzx_RequestNotice.RequestUser) == false)
{
objzx_RequestNoticeEN.dicFldComparisonOp.Add(conzx_RequestNotice.RequestUser, strComparisonOp);
}
else
{
objzx_RequestNoticeEN.dicFldComparisonOp[conzx_RequestNotice.RequestUser] = strComparisonOp;
}
}
return objzx_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_RequestNoticeEN SetRequestDate(this clszx_RequestNoticeEN objzx_RequestNoticeEN, string strRequestDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequestDate, 20, conzx_RequestNotice.RequestDate);
}
objzx_RequestNoticeEN.RequestDate = strRequestDate; //RequestDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_RequestNoticeEN.dicFldComparisonOp.ContainsKey(conzx_RequestNotice.RequestDate) == false)
{
objzx_RequestNoticeEN.dicFldComparisonOp.Add(conzx_RequestNotice.RequestDate, strComparisonOp);
}
else
{
objzx_RequestNoticeEN.dicFldComparisonOp[conzx_RequestNotice.RequestDate] = strComparisonOp;
}
}
return objzx_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_RequestNoticeEN SetRequestStata(this clszx_RequestNoticeEN objzx_RequestNoticeEN, string strRequestStata, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequestStata, 10, conzx_RequestNotice.RequestStata);
}
objzx_RequestNoticeEN.RequestStata = strRequestStata; //RequestStata
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_RequestNoticeEN.dicFldComparisonOp.ContainsKey(conzx_RequestNotice.RequestStata) == false)
{
objzx_RequestNoticeEN.dicFldComparisonOp.Add(conzx_RequestNotice.RequestStata, strComparisonOp);
}
else
{
objzx_RequestNoticeEN.dicFldComparisonOp[conzx_RequestNotice.RequestStata] = strComparisonOp;
}
}
return objzx_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_RequestNoticeEN SetMemo(this clszx_RequestNoticeEN objzx_RequestNoticeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_RequestNotice.Memo);
}
objzx_RequestNoticeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_RequestNoticeEN.dicFldComparisonOp.ContainsKey(conzx_RequestNotice.Memo) == false)
{
objzx_RequestNoticeEN.dicFldComparisonOp.Add(conzx_RequestNotice.Memo, strComparisonOp);
}
else
{
objzx_RequestNoticeEN.dicFldComparisonOp[conzx_RequestNotice.Memo] = strComparisonOp;
}
}
return objzx_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_RequestNoticeEN SetPushTypeId(this clszx_RequestNoticeEN objzx_RequestNoticeEN, string strPushTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPushTypeId, 2, conzx_RequestNotice.PushTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPushTypeId, 2, conzx_RequestNotice.PushTypeId);
}
objzx_RequestNoticeEN.PushTypeId = strPushTypeId; //推送类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_RequestNoticeEN.dicFldComparisonOp.ContainsKey(conzx_RequestNotice.PushTypeId) == false)
{
objzx_RequestNoticeEN.dicFldComparisonOp.Add(conzx_RequestNotice.PushTypeId, strComparisonOp);
}
else
{
objzx_RequestNoticeEN.dicFldComparisonOp[conzx_RequestNotice.PushTypeId] = strComparisonOp;
}
}
return objzx_RequestNoticeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_RequestNoticeEN SetIdCurrEduCls(this clszx_RequestNoticeEN objzx_RequestNoticeEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_RequestNotice.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_RequestNotice.IdCurrEduCls);
}
objzx_RequestNoticeEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_RequestNoticeEN.dicFldComparisonOp.ContainsKey(conzx_RequestNotice.IdCurrEduCls) == false)
{
objzx_RequestNoticeEN.dicFldComparisonOp.Add(conzx_RequestNotice.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_RequestNoticeEN.dicFldComparisonOp[conzx_RequestNotice.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_RequestNoticeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_RequestNoticeEN.CheckPropertyNew();
clszx_RequestNoticeEN objzx_RequestNoticeCond = new clszx_RequestNoticeEN();
string strCondition = objzx_RequestNoticeCond
.SetRequestId(objzx_RequestNoticeEN.RequestId, "<>")
.SetRequestId(objzx_RequestNoticeEN.RequestId, "=")
.GetCombineCondition();
objzx_RequestNoticeEN._IsCheckProperty = true;
bool bolIsExist = clszx_RequestNoticeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(RequestId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_RequestNoticeEN.Update();
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
 /// <param name = "objzx_RequestNotice">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_RequestNoticeEN objzx_RequestNotice)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_RequestNoticeEN objzx_RequestNoticeCond = new clszx_RequestNoticeEN();
string strCondition = objzx_RequestNoticeCond
.SetRequestId(objzx_RequestNotice.RequestId, "=")
.GetCombineCondition();
objzx_RequestNotice._IsCheckProperty = true;
bool bolIsExist = clszx_RequestNoticeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_RequestNotice.RequestId = clszx_RequestNoticeBL.GetFirstID_S(strCondition);
objzx_RequestNotice.UpdateWithCondition(strCondition);
}
else
{
objzx_RequestNotice.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
 if (objzx_RequestNoticeEN.RequestId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_RequestNoticeBL.zx_RequestNoticeDA.UpdateBySql2(objzx_RequestNoticeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_RequestNoticeBL.ReFreshCache();

if (clszx_RequestNoticeBL.relatedActions != null)
{
clszx_RequestNoticeBL.relatedActions.UpdRelaTabDate(objzx_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objzx_RequestNoticeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_RequestNoticeEN objzx_RequestNoticeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_RequestNoticeEN.RequestId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_RequestNoticeBL.zx_RequestNoticeDA.UpdateBySql2(objzx_RequestNoticeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_RequestNoticeBL.ReFreshCache();

if (clszx_RequestNoticeBL.relatedActions != null)
{
clszx_RequestNoticeBL.relatedActions.UpdRelaTabDate(objzx_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objzx_RequestNoticeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_RequestNoticeEN objzx_RequestNoticeEN, string strWhereCond)
{
try
{
bool bolResult = clszx_RequestNoticeBL.zx_RequestNoticeDA.UpdateBySqlWithCondition(objzx_RequestNoticeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_RequestNoticeBL.ReFreshCache();

if (clszx_RequestNoticeBL.relatedActions != null)
{
clszx_RequestNoticeBL.relatedActions.UpdRelaTabDate(objzx_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objzx_RequestNoticeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_RequestNoticeEN objzx_RequestNoticeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_RequestNoticeBL.zx_RequestNoticeDA.UpdateBySqlWithConditionTransaction(objzx_RequestNoticeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_RequestNoticeBL.ReFreshCache();

if (clszx_RequestNoticeBL.relatedActions != null)
{
clszx_RequestNoticeBL.relatedActions.UpdRelaTabDate(objzx_RequestNoticeEN.RequestId, "SetUpdDate");
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
public static int Delete(this clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
try
{
int intRecNum = clszx_RequestNoticeBL.zx_RequestNoticeDA.DelRecord(objzx_RequestNoticeEN.RequestId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_RequestNoticeBL.ReFreshCache();

if (clszx_RequestNoticeBL.relatedActions != null)
{
clszx_RequestNoticeBL.relatedActions.UpdRelaTabDate(objzx_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objzx_RequestNoticeENS">源对象</param>
 /// <param name = "objzx_RequestNoticeENT">目标对象</param>
 public static void CopyTo(this clszx_RequestNoticeEN objzx_RequestNoticeENS, clszx_RequestNoticeEN objzx_RequestNoticeENT)
{
try
{
objzx_RequestNoticeENT.RequestId = objzx_RequestNoticeENS.RequestId; //RequestId
objzx_RequestNoticeENT.RequesTypeId = objzx_RequestNoticeENS.RequesTypeId; //请求类型Id
objzx_RequestNoticeENT.TableKey = objzx_RequestNoticeENS.TableKey; //表主键
objzx_RequestNoticeENT.ReceiveUser = objzx_RequestNoticeENS.ReceiveUser; //接收用户
objzx_RequestNoticeENT.IsReply = objzx_RequestNoticeENS.IsReply; //是否回复
objzx_RequestNoticeENT.ReplyDate = objzx_RequestNoticeENS.ReplyDate; //回复日期
objzx_RequestNoticeENT.RequestUser = objzx_RequestNoticeENS.RequestUser; //RequestUser
objzx_RequestNoticeENT.RequestDate = objzx_RequestNoticeENS.RequestDate; //RequestDate
objzx_RequestNoticeENT.RequestStata = objzx_RequestNoticeENS.RequestStata; //RequestStata
objzx_RequestNoticeENT.Memo = objzx_RequestNoticeENS.Memo; //备注
objzx_RequestNoticeENT.PushTypeId = objzx_RequestNoticeENS.PushTypeId; //推送类型Id
objzx_RequestNoticeENT.IdCurrEduCls = objzx_RequestNoticeENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objzx_RequestNoticeENS">源对象</param>
 /// <returns>目标对象=>clszx_RequestNoticeEN:objzx_RequestNoticeENT</returns>
 public static clszx_RequestNoticeEN CopyTo(this clszx_RequestNoticeEN objzx_RequestNoticeENS)
{
try
{
 clszx_RequestNoticeEN objzx_RequestNoticeENT = new clszx_RequestNoticeEN()
{
RequestId = objzx_RequestNoticeENS.RequestId, //RequestId
RequesTypeId = objzx_RequestNoticeENS.RequesTypeId, //请求类型Id
TableKey = objzx_RequestNoticeENS.TableKey, //表主键
ReceiveUser = objzx_RequestNoticeENS.ReceiveUser, //接收用户
IsReply = objzx_RequestNoticeENS.IsReply, //是否回复
ReplyDate = objzx_RequestNoticeENS.ReplyDate, //回复日期
RequestUser = objzx_RequestNoticeENS.RequestUser, //RequestUser
RequestDate = objzx_RequestNoticeENS.RequestDate, //RequestDate
RequestStata = objzx_RequestNoticeENS.RequestStata, //RequestStata
Memo = objzx_RequestNoticeENS.Memo, //备注
PushTypeId = objzx_RequestNoticeENS.PushTypeId, //推送类型Id
IdCurrEduCls = objzx_RequestNoticeENS.IdCurrEduCls, //教学班流水号
};
 return objzx_RequestNoticeENT;
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
public static void CheckPropertyNew(this clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
 clszx_RequestNoticeBL.zx_RequestNoticeDA.CheckPropertyNew(objzx_RequestNoticeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
 clszx_RequestNoticeBL.zx_RequestNoticeDA.CheckProperty4Condition(objzx_RequestNoticeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_RequestNoticeEN objzx_RequestNoticeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_RequestNoticeCond.IsUpdated(conzx_RequestNotice.RequestId) == true)
{
string strComparisonOpRequestId = objzx_RequestNoticeCond.dicFldComparisonOp[conzx_RequestNotice.RequestId];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_RequestNotice.RequestId, objzx_RequestNoticeCond.RequestId, strComparisonOpRequestId);
}
if (objzx_RequestNoticeCond.IsUpdated(conzx_RequestNotice.RequesTypeId) == true)
{
string strComparisonOpRequesTypeId = objzx_RequestNoticeCond.dicFldComparisonOp[conzx_RequestNotice.RequesTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_RequestNotice.RequesTypeId, objzx_RequestNoticeCond.RequesTypeId, strComparisonOpRequesTypeId);
}
if (objzx_RequestNoticeCond.IsUpdated(conzx_RequestNotice.TableKey) == true)
{
string strComparisonOpTableKey = objzx_RequestNoticeCond.dicFldComparisonOp[conzx_RequestNotice.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_RequestNotice.TableKey, objzx_RequestNoticeCond.TableKey, strComparisonOpTableKey);
}
if (objzx_RequestNoticeCond.IsUpdated(conzx_RequestNotice.ReceiveUser) == true)
{
string strComparisonOpReceiveUser = objzx_RequestNoticeCond.dicFldComparisonOp[conzx_RequestNotice.ReceiveUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_RequestNotice.ReceiveUser, objzx_RequestNoticeCond.ReceiveUser, strComparisonOpReceiveUser);
}
if (objzx_RequestNoticeCond.IsUpdated(conzx_RequestNotice.IsReply) == true)
{
if (objzx_RequestNoticeCond.IsReply == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_RequestNotice.IsReply);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_RequestNotice.IsReply);
}
}
if (objzx_RequestNoticeCond.IsUpdated(conzx_RequestNotice.ReplyDate) == true)
{
string strComparisonOpReplyDate = objzx_RequestNoticeCond.dicFldComparisonOp[conzx_RequestNotice.ReplyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_RequestNotice.ReplyDate, objzx_RequestNoticeCond.ReplyDate, strComparisonOpReplyDate);
}
if (objzx_RequestNoticeCond.IsUpdated(conzx_RequestNotice.RequestUser) == true)
{
string strComparisonOpRequestUser = objzx_RequestNoticeCond.dicFldComparisonOp[conzx_RequestNotice.RequestUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_RequestNotice.RequestUser, objzx_RequestNoticeCond.RequestUser, strComparisonOpRequestUser);
}
if (objzx_RequestNoticeCond.IsUpdated(conzx_RequestNotice.RequestDate) == true)
{
string strComparisonOpRequestDate = objzx_RequestNoticeCond.dicFldComparisonOp[conzx_RequestNotice.RequestDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_RequestNotice.RequestDate, objzx_RequestNoticeCond.RequestDate, strComparisonOpRequestDate);
}
if (objzx_RequestNoticeCond.IsUpdated(conzx_RequestNotice.RequestStata) == true)
{
string strComparisonOpRequestStata = objzx_RequestNoticeCond.dicFldComparisonOp[conzx_RequestNotice.RequestStata];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_RequestNotice.RequestStata, objzx_RequestNoticeCond.RequestStata, strComparisonOpRequestStata);
}
if (objzx_RequestNoticeCond.IsUpdated(conzx_RequestNotice.Memo) == true)
{
string strComparisonOpMemo = objzx_RequestNoticeCond.dicFldComparisonOp[conzx_RequestNotice.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_RequestNotice.Memo, objzx_RequestNoticeCond.Memo, strComparisonOpMemo);
}
if (objzx_RequestNoticeCond.IsUpdated(conzx_RequestNotice.PushTypeId) == true)
{
string strComparisonOpPushTypeId = objzx_RequestNoticeCond.dicFldComparisonOp[conzx_RequestNotice.PushTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_RequestNotice.PushTypeId, objzx_RequestNoticeCond.PushTypeId, strComparisonOpPushTypeId);
}
if (objzx_RequestNoticeCond.IsUpdated(conzx_RequestNotice.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_RequestNoticeCond.dicFldComparisonOp[conzx_RequestNotice.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_RequestNotice.IdCurrEduCls, objzx_RequestNoticeCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_RequestNotice(中学请求通知表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RequestId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_RequestNoticeEN == null) return true;
if (objzx_RequestNoticeEN.RequestId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RequestId = '{0}'", objzx_RequestNoticeEN.RequestId);
if (clszx_RequestNoticeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("RequestId !=  {0}", objzx_RequestNoticeEN.RequestId);
 sbCondition.AppendFormat(" and RequestId = '{0}'", objzx_RequestNoticeEN.RequestId);
if (clszx_RequestNoticeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_RequestNotice(中学请求通知表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RequestId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_RequestNoticeEN == null) return "";
if (objzx_RequestNoticeEN.RequestId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RequestId = '{0}'", objzx_RequestNoticeEN.RequestId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RequestId !=  {0}", objzx_RequestNoticeEN.RequestId);
 sbCondition.AppendFormat(" and RequestId = '{0}'", objzx_RequestNoticeEN.RequestId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_RequestNotice
{
public virtual bool UpdRelaTabDate(long lngRequestId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学请求通知表(zx_RequestNotice)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_RequestNoticeBL
{
public static RelatedActions_zx_RequestNotice relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_RequestNoticeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_RequestNoticeDA zx_RequestNoticeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_RequestNoticeDA();
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
 public clszx_RequestNoticeBL()
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
if (string.IsNullOrEmpty(clszx_RequestNoticeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_RequestNoticeEN._ConnectString);
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
public static DataTable GetDataTable_zx_RequestNotice(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_RequestNoticeDA.GetDataTable_zx_RequestNotice(strWhereCond);
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
objDT = zx_RequestNoticeDA.GetDataTable(strWhereCond);
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
objDT = zx_RequestNoticeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_RequestNoticeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_RequestNoticeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_RequestNoticeDA.GetDataTable_Top(objTopPara);
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
objDT = zx_RequestNoticeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_RequestNoticeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_RequestNoticeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clszx_RequestNoticeEN> GetObjLstByRequestIdLst(List<long> arrRequestIdLst)
{
List<clszx_RequestNoticeEN> arrObjLst = new List<clszx_RequestNoticeEN>(); 
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
	clszx_RequestNoticeEN objzx_RequestNoticeEN = new clszx_RequestNoticeEN();
try
{
objzx_RequestNoticeEN.RequestId = Int32.Parse(objRow[conzx_RequestNotice.RequestId].ToString().Trim()); //RequestId
objzx_RequestNoticeEN.RequesTypeId = objRow[conzx_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objzx_RequestNoticeEN.TableKey = objRow[conzx_RequestNotice.TableKey] == DBNull.Value ? null : objRow[conzx_RequestNotice.TableKey].ToString().Trim(); //表主键
objzx_RequestNoticeEN.ReceiveUser = objRow[conzx_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objzx_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[conzx_RequestNotice.IsReply].ToString().Trim()); //是否回复
objzx_RequestNoticeEN.ReplyDate = objRow[conzx_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objzx_RequestNoticeEN.RequestUser = objRow[conzx_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objzx_RequestNoticeEN.RequestDate = objRow[conzx_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objzx_RequestNoticeEN.RequestStata = objRow[conzx_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objzx_RequestNoticeEN.Memo = objRow[conzx_RequestNotice.Memo] == DBNull.Value ? null : objRow[conzx_RequestNotice.Memo].ToString().Trim(); //备注
objzx_RequestNoticeEN.PushTypeId = objRow[conzx_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objzx_RequestNoticeEN.IdCurrEduCls = objRow[conzx_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_RequestNoticeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRequestIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_RequestNoticeEN> GetObjLstByRequestIdLstCache(List<long> arrRequestIdLst)
{
string strKey = string.Format("{0}", clszx_RequestNoticeEN._CurrTabName);
List<clszx_RequestNoticeEN> arrzx_RequestNoticeObjLstCache = GetObjLstCache();
IEnumerable <clszx_RequestNoticeEN> arrzx_RequestNoticeObjLst_Sel =
arrzx_RequestNoticeObjLstCache
.Where(x => arrRequestIdLst.Contains(x.RequestId));
return arrzx_RequestNoticeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_RequestNoticeEN> GetObjLst(string strWhereCond)
{
List<clszx_RequestNoticeEN> arrObjLst = new List<clszx_RequestNoticeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_RequestNoticeEN objzx_RequestNoticeEN = new clszx_RequestNoticeEN();
try
{
objzx_RequestNoticeEN.RequestId = Int32.Parse(objRow[conzx_RequestNotice.RequestId].ToString().Trim()); //RequestId
objzx_RequestNoticeEN.RequesTypeId = objRow[conzx_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objzx_RequestNoticeEN.TableKey = objRow[conzx_RequestNotice.TableKey] == DBNull.Value ? null : objRow[conzx_RequestNotice.TableKey].ToString().Trim(); //表主键
objzx_RequestNoticeEN.ReceiveUser = objRow[conzx_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objzx_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[conzx_RequestNotice.IsReply].ToString().Trim()); //是否回复
objzx_RequestNoticeEN.ReplyDate = objRow[conzx_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objzx_RequestNoticeEN.RequestUser = objRow[conzx_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objzx_RequestNoticeEN.RequestDate = objRow[conzx_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objzx_RequestNoticeEN.RequestStata = objRow[conzx_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objzx_RequestNoticeEN.Memo = objRow[conzx_RequestNotice.Memo] == DBNull.Value ? null : objRow[conzx_RequestNotice.Memo].ToString().Trim(); //备注
objzx_RequestNoticeEN.PushTypeId = objRow[conzx_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objzx_RequestNoticeEN.IdCurrEduCls = objRow[conzx_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_RequestNoticeEN);
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
public static List<clszx_RequestNoticeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_RequestNoticeEN> arrObjLst = new List<clszx_RequestNoticeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_RequestNoticeEN objzx_RequestNoticeEN = new clszx_RequestNoticeEN();
try
{
objzx_RequestNoticeEN.RequestId = Int32.Parse(objRow[conzx_RequestNotice.RequestId].ToString().Trim()); //RequestId
objzx_RequestNoticeEN.RequesTypeId = objRow[conzx_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objzx_RequestNoticeEN.TableKey = objRow[conzx_RequestNotice.TableKey] == DBNull.Value ? null : objRow[conzx_RequestNotice.TableKey].ToString().Trim(); //表主键
objzx_RequestNoticeEN.ReceiveUser = objRow[conzx_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objzx_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[conzx_RequestNotice.IsReply].ToString().Trim()); //是否回复
objzx_RequestNoticeEN.ReplyDate = objRow[conzx_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objzx_RequestNoticeEN.RequestUser = objRow[conzx_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objzx_RequestNoticeEN.RequestDate = objRow[conzx_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objzx_RequestNoticeEN.RequestStata = objRow[conzx_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objzx_RequestNoticeEN.Memo = objRow[conzx_RequestNotice.Memo] == DBNull.Value ? null : objRow[conzx_RequestNotice.Memo].ToString().Trim(); //备注
objzx_RequestNoticeEN.PushTypeId = objRow[conzx_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objzx_RequestNoticeEN.IdCurrEduCls = objRow[conzx_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_RequestNoticeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_RequestNoticeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_RequestNoticeEN> GetSubObjLstCache(clszx_RequestNoticeEN objzx_RequestNoticeCond)
{
List<clszx_RequestNoticeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_RequestNoticeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_RequestNotice.AttributeName)
{
if (objzx_RequestNoticeCond.IsUpdated(strFldName) == false) continue;
if (objzx_RequestNoticeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_RequestNoticeCond[strFldName].ToString());
}
else
{
if (objzx_RequestNoticeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_RequestNoticeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_RequestNoticeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_RequestNoticeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_RequestNoticeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_RequestNoticeCond[strFldName]));
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
public static List<clszx_RequestNoticeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_RequestNoticeEN> arrObjLst = new List<clszx_RequestNoticeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_RequestNoticeEN objzx_RequestNoticeEN = new clszx_RequestNoticeEN();
try
{
objzx_RequestNoticeEN.RequestId = Int32.Parse(objRow[conzx_RequestNotice.RequestId].ToString().Trim()); //RequestId
objzx_RequestNoticeEN.RequesTypeId = objRow[conzx_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objzx_RequestNoticeEN.TableKey = objRow[conzx_RequestNotice.TableKey] == DBNull.Value ? null : objRow[conzx_RequestNotice.TableKey].ToString().Trim(); //表主键
objzx_RequestNoticeEN.ReceiveUser = objRow[conzx_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objzx_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[conzx_RequestNotice.IsReply].ToString().Trim()); //是否回复
objzx_RequestNoticeEN.ReplyDate = objRow[conzx_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objzx_RequestNoticeEN.RequestUser = objRow[conzx_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objzx_RequestNoticeEN.RequestDate = objRow[conzx_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objzx_RequestNoticeEN.RequestStata = objRow[conzx_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objzx_RequestNoticeEN.Memo = objRow[conzx_RequestNotice.Memo] == DBNull.Value ? null : objRow[conzx_RequestNotice.Memo].ToString().Trim(); //备注
objzx_RequestNoticeEN.PushTypeId = objRow[conzx_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objzx_RequestNoticeEN.IdCurrEduCls = objRow[conzx_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_RequestNoticeEN);
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
public static List<clszx_RequestNoticeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_RequestNoticeEN> arrObjLst = new List<clszx_RequestNoticeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_RequestNoticeEN objzx_RequestNoticeEN = new clszx_RequestNoticeEN();
try
{
objzx_RequestNoticeEN.RequestId = Int32.Parse(objRow[conzx_RequestNotice.RequestId].ToString().Trim()); //RequestId
objzx_RequestNoticeEN.RequesTypeId = objRow[conzx_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objzx_RequestNoticeEN.TableKey = objRow[conzx_RequestNotice.TableKey] == DBNull.Value ? null : objRow[conzx_RequestNotice.TableKey].ToString().Trim(); //表主键
objzx_RequestNoticeEN.ReceiveUser = objRow[conzx_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objzx_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[conzx_RequestNotice.IsReply].ToString().Trim()); //是否回复
objzx_RequestNoticeEN.ReplyDate = objRow[conzx_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objzx_RequestNoticeEN.RequestUser = objRow[conzx_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objzx_RequestNoticeEN.RequestDate = objRow[conzx_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objzx_RequestNoticeEN.RequestStata = objRow[conzx_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objzx_RequestNoticeEN.Memo = objRow[conzx_RequestNotice.Memo] == DBNull.Value ? null : objRow[conzx_RequestNotice.Memo].ToString().Trim(); //备注
objzx_RequestNoticeEN.PushTypeId = objRow[conzx_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objzx_RequestNoticeEN.IdCurrEduCls = objRow[conzx_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_RequestNoticeEN);
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
List<clszx_RequestNoticeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_RequestNoticeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_RequestNoticeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_RequestNoticeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_RequestNoticeEN> arrObjLst = new List<clszx_RequestNoticeEN>(); 
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
	clszx_RequestNoticeEN objzx_RequestNoticeEN = new clszx_RequestNoticeEN();
try
{
objzx_RequestNoticeEN.RequestId = Int32.Parse(objRow[conzx_RequestNotice.RequestId].ToString().Trim()); //RequestId
objzx_RequestNoticeEN.RequesTypeId = objRow[conzx_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objzx_RequestNoticeEN.TableKey = objRow[conzx_RequestNotice.TableKey] == DBNull.Value ? null : objRow[conzx_RequestNotice.TableKey].ToString().Trim(); //表主键
objzx_RequestNoticeEN.ReceiveUser = objRow[conzx_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objzx_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[conzx_RequestNotice.IsReply].ToString().Trim()); //是否回复
objzx_RequestNoticeEN.ReplyDate = objRow[conzx_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objzx_RequestNoticeEN.RequestUser = objRow[conzx_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objzx_RequestNoticeEN.RequestDate = objRow[conzx_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objzx_RequestNoticeEN.RequestStata = objRow[conzx_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objzx_RequestNoticeEN.Memo = objRow[conzx_RequestNotice.Memo] == DBNull.Value ? null : objRow[conzx_RequestNotice.Memo].ToString().Trim(); //备注
objzx_RequestNoticeEN.PushTypeId = objRow[conzx_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objzx_RequestNoticeEN.IdCurrEduCls = objRow[conzx_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_RequestNoticeEN);
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
public static List<clszx_RequestNoticeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_RequestNoticeEN> arrObjLst = new List<clszx_RequestNoticeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_RequestNoticeEN objzx_RequestNoticeEN = new clszx_RequestNoticeEN();
try
{
objzx_RequestNoticeEN.RequestId = Int32.Parse(objRow[conzx_RequestNotice.RequestId].ToString().Trim()); //RequestId
objzx_RequestNoticeEN.RequesTypeId = objRow[conzx_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objzx_RequestNoticeEN.TableKey = objRow[conzx_RequestNotice.TableKey] == DBNull.Value ? null : objRow[conzx_RequestNotice.TableKey].ToString().Trim(); //表主键
objzx_RequestNoticeEN.ReceiveUser = objRow[conzx_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objzx_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[conzx_RequestNotice.IsReply].ToString().Trim()); //是否回复
objzx_RequestNoticeEN.ReplyDate = objRow[conzx_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objzx_RequestNoticeEN.RequestUser = objRow[conzx_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objzx_RequestNoticeEN.RequestDate = objRow[conzx_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objzx_RequestNoticeEN.RequestStata = objRow[conzx_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objzx_RequestNoticeEN.Memo = objRow[conzx_RequestNotice.Memo] == DBNull.Value ? null : objRow[conzx_RequestNotice.Memo].ToString().Trim(); //备注
objzx_RequestNoticeEN.PushTypeId = objRow[conzx_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objzx_RequestNoticeEN.IdCurrEduCls = objRow[conzx_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_RequestNoticeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_RequestNoticeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_RequestNoticeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_RequestNoticeEN> arrObjLst = new List<clszx_RequestNoticeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_RequestNoticeEN objzx_RequestNoticeEN = new clszx_RequestNoticeEN();
try
{
objzx_RequestNoticeEN.RequestId = Int32.Parse(objRow[conzx_RequestNotice.RequestId].ToString().Trim()); //RequestId
objzx_RequestNoticeEN.RequesTypeId = objRow[conzx_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objzx_RequestNoticeEN.TableKey = objRow[conzx_RequestNotice.TableKey] == DBNull.Value ? null : objRow[conzx_RequestNotice.TableKey].ToString().Trim(); //表主键
objzx_RequestNoticeEN.ReceiveUser = objRow[conzx_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objzx_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[conzx_RequestNotice.IsReply].ToString().Trim()); //是否回复
objzx_RequestNoticeEN.ReplyDate = objRow[conzx_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objzx_RequestNoticeEN.RequestUser = objRow[conzx_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objzx_RequestNoticeEN.RequestDate = objRow[conzx_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objzx_RequestNoticeEN.RequestStata = objRow[conzx_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objzx_RequestNoticeEN.Memo = objRow[conzx_RequestNotice.Memo] == DBNull.Value ? null : objRow[conzx_RequestNotice.Memo].ToString().Trim(); //备注
objzx_RequestNoticeEN.PushTypeId = objRow[conzx_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objzx_RequestNoticeEN.IdCurrEduCls = objRow[conzx_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_RequestNoticeEN);
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
public static List<clszx_RequestNoticeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_RequestNoticeEN> arrObjLst = new List<clszx_RequestNoticeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_RequestNoticeEN objzx_RequestNoticeEN = new clszx_RequestNoticeEN();
try
{
objzx_RequestNoticeEN.RequestId = Int32.Parse(objRow[conzx_RequestNotice.RequestId].ToString().Trim()); //RequestId
objzx_RequestNoticeEN.RequesTypeId = objRow[conzx_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objzx_RequestNoticeEN.TableKey = objRow[conzx_RequestNotice.TableKey] == DBNull.Value ? null : objRow[conzx_RequestNotice.TableKey].ToString().Trim(); //表主键
objzx_RequestNoticeEN.ReceiveUser = objRow[conzx_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objzx_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[conzx_RequestNotice.IsReply].ToString().Trim()); //是否回复
objzx_RequestNoticeEN.ReplyDate = objRow[conzx_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objzx_RequestNoticeEN.RequestUser = objRow[conzx_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objzx_RequestNoticeEN.RequestDate = objRow[conzx_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objzx_RequestNoticeEN.RequestStata = objRow[conzx_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objzx_RequestNoticeEN.Memo = objRow[conzx_RequestNotice.Memo] == DBNull.Value ? null : objRow[conzx_RequestNotice.Memo].ToString().Trim(); //备注
objzx_RequestNoticeEN.PushTypeId = objRow[conzx_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objzx_RequestNoticeEN.IdCurrEduCls = objRow[conzx_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_RequestNoticeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_RequestNoticeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_RequestNoticeEN> arrObjLst = new List<clszx_RequestNoticeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_RequestNoticeEN objzx_RequestNoticeEN = new clszx_RequestNoticeEN();
try
{
objzx_RequestNoticeEN.RequestId = Int32.Parse(objRow[conzx_RequestNotice.RequestId].ToString().Trim()); //RequestId
objzx_RequestNoticeEN.RequesTypeId = objRow[conzx_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objzx_RequestNoticeEN.TableKey = objRow[conzx_RequestNotice.TableKey] == DBNull.Value ? null : objRow[conzx_RequestNotice.TableKey].ToString().Trim(); //表主键
objzx_RequestNoticeEN.ReceiveUser = objRow[conzx_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objzx_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[conzx_RequestNotice.IsReply].ToString().Trim()); //是否回复
objzx_RequestNoticeEN.ReplyDate = objRow[conzx_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objzx_RequestNoticeEN.RequestUser = objRow[conzx_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objzx_RequestNoticeEN.RequestDate = objRow[conzx_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objzx_RequestNoticeEN.RequestStata = objRow[conzx_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[conzx_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objzx_RequestNoticeEN.Memo = objRow[conzx_RequestNotice.Memo] == DBNull.Value ? null : objRow[conzx_RequestNotice.Memo].ToString().Trim(); //备注
objzx_RequestNoticeEN.PushTypeId = objRow[conzx_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[conzx_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objzx_RequestNoticeEN.IdCurrEduCls = objRow[conzx_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_RequestNoticeEN.RequestId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_RequestNoticeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_RequestNotice(ref clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
bool bolResult = zx_RequestNoticeDA.Getzx_RequestNotice(ref objzx_RequestNoticeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngRequestId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_RequestNoticeEN GetObjByRequestId(long lngRequestId)
{
clszx_RequestNoticeEN objzx_RequestNoticeEN = zx_RequestNoticeDA.GetObjByRequestId(lngRequestId);
return objzx_RequestNoticeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_RequestNoticeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_RequestNoticeEN objzx_RequestNoticeEN = zx_RequestNoticeDA.GetFirstObj(strWhereCond);
 return objzx_RequestNoticeEN;
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
public static clszx_RequestNoticeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_RequestNoticeEN objzx_RequestNoticeEN = zx_RequestNoticeDA.GetObjByDataRow(objRow);
 return objzx_RequestNoticeEN;
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
public static clszx_RequestNoticeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_RequestNoticeEN objzx_RequestNoticeEN = zx_RequestNoticeDA.GetObjByDataRow(objRow);
 return objzx_RequestNoticeEN;
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
 /// <param name = "lstzx_RequestNoticeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_RequestNoticeEN GetObjByRequestIdFromList(long lngRequestId, List<clszx_RequestNoticeEN> lstzx_RequestNoticeObjLst)
{
foreach (clszx_RequestNoticeEN objzx_RequestNoticeEN in lstzx_RequestNoticeObjLst)
{
if (objzx_RequestNoticeEN.RequestId == lngRequestId)
{
return objzx_RequestNoticeEN;
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
 lngRequestId = new clszx_RequestNoticeDA().GetFirstID(strWhereCond);
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
 arrList = zx_RequestNoticeDA.GetID(strWhereCond);
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
bool bolIsExist = zx_RequestNoticeDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = zx_RequestNoticeDA.IsExist(lngRequestId);
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
 bolIsExist = clszx_RequestNoticeDA.IsExistTable();
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
 bolIsExist = zx_RequestNoticeDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
if (objzx_RequestNoticeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!RequestId = [{0}]的数据已经存在!(in clszx_RequestNoticeBL.AddNewRecordBySql2)", objzx_RequestNoticeEN.RequestId);
throw new Exception(strMsg);
}
try
{
bool bolResult = zx_RequestNoticeDA.AddNewRecordBySQL2(objzx_RequestNoticeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_RequestNoticeBL.ReFreshCache();

if (clszx_RequestNoticeBL.relatedActions != null)
{
clszx_RequestNoticeBL.relatedActions.UpdRelaTabDate(objzx_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objzx_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
if (objzx_RequestNoticeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!RequestId = [{0}]的数据已经存在!(in clszx_RequestNoticeBL.AddNewRecordBySql2WithReturnKey)", objzx_RequestNoticeEN.RequestId);
throw new Exception(strMsg);
}
try
{
string strKey = zx_RequestNoticeDA.AddNewRecordBySQL2WithReturnKey(objzx_RequestNoticeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_RequestNoticeBL.ReFreshCache();

if (clszx_RequestNoticeBL.relatedActions != null)
{
clszx_RequestNoticeBL.relatedActions.UpdRelaTabDate(objzx_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objzx_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
try
{
bool bolResult = zx_RequestNoticeDA.Update(objzx_RequestNoticeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_RequestNoticeBL.ReFreshCache();

if (clszx_RequestNoticeBL.relatedActions != null)
{
clszx_RequestNoticeBL.relatedActions.UpdRelaTabDate(objzx_RequestNoticeEN.RequestId, "SetUpdDate");
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
 /// <param name = "objzx_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
 if (objzx_RequestNoticeEN.RequestId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_RequestNoticeDA.UpdateBySql2(objzx_RequestNoticeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_RequestNoticeBL.ReFreshCache();

if (clszx_RequestNoticeBL.relatedActions != null)
{
clszx_RequestNoticeBL.relatedActions.UpdRelaTabDate(objzx_RequestNoticeEN.RequestId, "SetUpdDate");
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
 clszx_RequestNoticeEN objzx_RequestNoticeEN = clszx_RequestNoticeBL.GetObjByRequestId(lngRequestId);

if (clszx_RequestNoticeBL.relatedActions != null)
{
clszx_RequestNoticeBL.relatedActions.UpdRelaTabDate(objzx_RequestNoticeEN.RequestId, "SetUpdDate");
}
if (objzx_RequestNoticeEN != null)
{
int intRecNum = zx_RequestNoticeDA.DelRecord(lngRequestId);
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
objSQL = clszx_RequestNoticeDA.GetSpecSQLObj();
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
//删除与表:[zx_RequestNotice]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_RequestNotice.RequestId,
//lngRequestId);
//        clszx_RequestNoticeBL.Delzx_RequestNoticesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_RequestNoticeBL.DelRecord(lngRequestId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_RequestNoticeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clszx_RequestNoticeBL.relatedActions != null)
{
clszx_RequestNoticeBL.relatedActions.UpdRelaTabDate(lngRequestId, "UpdRelaTabDate");
}
bool bolResult = zx_RequestNoticeDA.DelRecord(lngRequestId,objSqlConnection,objSqlTransaction);
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
public static int Delzx_RequestNotices(List<string> arrRequestIdLst)
{
if (arrRequestIdLst.Count == 0) return 0;
try
{
if (clszx_RequestNoticeBL.relatedActions != null)
{
foreach (var strRequestId in arrRequestIdLst)
{
long lngRequestId = long.Parse(strRequestId);
clszx_RequestNoticeBL.relatedActions.UpdRelaTabDate(lngRequestId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_RequestNoticeDA.Delzx_RequestNotice(arrRequestIdLst);
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
public static int Delzx_RequestNoticesByCond(string strWhereCond)
{
try
{
if (clszx_RequestNoticeBL.relatedActions != null)
{
List<string> arrRequestId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRequestId in arrRequestId)
{
long lngRequestId = long.Parse(strRequestId);
clszx_RequestNoticeBL.relatedActions.UpdRelaTabDate(lngRequestId, "UpdRelaTabDate");
}
}
int intRecNum = zx_RequestNoticeDA.Delzx_RequestNotice(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_RequestNotice]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngRequestId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngRequestId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_RequestNoticeDA.GetSpecSQLObj();
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
//删除与表:[zx_RequestNotice]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_RequestNoticeBL.DelRecord(lngRequestId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_RequestNoticeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objzx_RequestNoticeENS">源对象</param>
 /// <param name = "objzx_RequestNoticeENT">目标对象</param>
 public static void CopyTo(clszx_RequestNoticeEN objzx_RequestNoticeENS, clszx_RequestNoticeEN objzx_RequestNoticeENT)
{
try
{
objzx_RequestNoticeENT.RequestId = objzx_RequestNoticeENS.RequestId; //RequestId
objzx_RequestNoticeENT.RequesTypeId = objzx_RequestNoticeENS.RequesTypeId; //请求类型Id
objzx_RequestNoticeENT.TableKey = objzx_RequestNoticeENS.TableKey; //表主键
objzx_RequestNoticeENT.ReceiveUser = objzx_RequestNoticeENS.ReceiveUser; //接收用户
objzx_RequestNoticeENT.IsReply = objzx_RequestNoticeENS.IsReply; //是否回复
objzx_RequestNoticeENT.ReplyDate = objzx_RequestNoticeENS.ReplyDate; //回复日期
objzx_RequestNoticeENT.RequestUser = objzx_RequestNoticeENS.RequestUser; //RequestUser
objzx_RequestNoticeENT.RequestDate = objzx_RequestNoticeENS.RequestDate; //RequestDate
objzx_RequestNoticeENT.RequestStata = objzx_RequestNoticeENS.RequestStata; //RequestStata
objzx_RequestNoticeENT.Memo = objzx_RequestNoticeENS.Memo; //备注
objzx_RequestNoticeENT.PushTypeId = objzx_RequestNoticeENS.PushTypeId; //推送类型Id
objzx_RequestNoticeENT.IdCurrEduCls = objzx_RequestNoticeENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objzx_RequestNoticeEN">源简化对象</param>
 public static void SetUpdFlag(clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
try
{
objzx_RequestNoticeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_RequestNoticeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_RequestNotice.RequestId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_RequestNoticeEN.RequestId = objzx_RequestNoticeEN.RequestId; //RequestId
}
if (arrFldSet.Contains(conzx_RequestNotice.RequesTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_RequestNoticeEN.RequesTypeId = objzx_RequestNoticeEN.RequesTypeId == "[null]" ? null :  objzx_RequestNoticeEN.RequesTypeId; //请求类型Id
}
if (arrFldSet.Contains(conzx_RequestNotice.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_RequestNoticeEN.TableKey = objzx_RequestNoticeEN.TableKey == "[null]" ? null :  objzx_RequestNoticeEN.TableKey; //表主键
}
if (arrFldSet.Contains(conzx_RequestNotice.ReceiveUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_RequestNoticeEN.ReceiveUser = objzx_RequestNoticeEN.ReceiveUser == "[null]" ? null :  objzx_RequestNoticeEN.ReceiveUser; //接收用户
}
if (arrFldSet.Contains(conzx_RequestNotice.IsReply, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_RequestNoticeEN.IsReply = objzx_RequestNoticeEN.IsReply; //是否回复
}
if (arrFldSet.Contains(conzx_RequestNotice.ReplyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_RequestNoticeEN.ReplyDate = objzx_RequestNoticeEN.ReplyDate == "[null]" ? null :  objzx_RequestNoticeEN.ReplyDate; //回复日期
}
if (arrFldSet.Contains(conzx_RequestNotice.RequestUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_RequestNoticeEN.RequestUser = objzx_RequestNoticeEN.RequestUser == "[null]" ? null :  objzx_RequestNoticeEN.RequestUser; //RequestUser
}
if (arrFldSet.Contains(conzx_RequestNotice.RequestDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_RequestNoticeEN.RequestDate = objzx_RequestNoticeEN.RequestDate == "[null]" ? null :  objzx_RequestNoticeEN.RequestDate; //RequestDate
}
if (arrFldSet.Contains(conzx_RequestNotice.RequestStata, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_RequestNoticeEN.RequestStata = objzx_RequestNoticeEN.RequestStata == "[null]" ? null :  objzx_RequestNoticeEN.RequestStata; //RequestStata
}
if (arrFldSet.Contains(conzx_RequestNotice.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_RequestNoticeEN.Memo = objzx_RequestNoticeEN.Memo == "[null]" ? null :  objzx_RequestNoticeEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_RequestNotice.PushTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_RequestNoticeEN.PushTypeId = objzx_RequestNoticeEN.PushTypeId == "[null]" ? null :  objzx_RequestNoticeEN.PushTypeId; //推送类型Id
}
if (arrFldSet.Contains(conzx_RequestNotice.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_RequestNoticeEN.IdCurrEduCls = objzx_RequestNoticeEN.IdCurrEduCls == "[null]" ? null :  objzx_RequestNoticeEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objzx_RequestNoticeEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
try
{
if (objzx_RequestNoticeEN.RequesTypeId == "[null]") objzx_RequestNoticeEN.RequesTypeId = null; //请求类型Id
if (objzx_RequestNoticeEN.TableKey == "[null]") objzx_RequestNoticeEN.TableKey = null; //表主键
if (objzx_RequestNoticeEN.ReceiveUser == "[null]") objzx_RequestNoticeEN.ReceiveUser = null; //接收用户
if (objzx_RequestNoticeEN.ReplyDate == "[null]") objzx_RequestNoticeEN.ReplyDate = null; //回复日期
if (objzx_RequestNoticeEN.RequestUser == "[null]") objzx_RequestNoticeEN.RequestUser = null; //RequestUser
if (objzx_RequestNoticeEN.RequestDate == "[null]") objzx_RequestNoticeEN.RequestDate = null; //RequestDate
if (objzx_RequestNoticeEN.RequestStata == "[null]") objzx_RequestNoticeEN.RequestStata = null; //RequestStata
if (objzx_RequestNoticeEN.Memo == "[null]") objzx_RequestNoticeEN.Memo = null; //备注
if (objzx_RequestNoticeEN.PushTypeId == "[null]") objzx_RequestNoticeEN.PushTypeId = null; //推送类型Id
if (objzx_RequestNoticeEN.IdCurrEduCls == "[null]") objzx_RequestNoticeEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckPropertyNew(clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
 zx_RequestNoticeDA.CheckPropertyNew(objzx_RequestNoticeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
 zx_RequestNoticeDA.CheckProperty4Condition(objzx_RequestNoticeEN);
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
if (clszx_RequestNoticeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_RequestNoticeBL没有刷新缓存机制(clszx_RequestNoticeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RequestId");
//if (arrzx_RequestNoticeObjLstCache == null)
//{
//arrzx_RequestNoticeObjLstCache = zx_RequestNoticeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngRequestId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_RequestNoticeEN GetObjByRequestIdCache(long lngRequestId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_RequestNoticeEN._CurrTabName);
List<clszx_RequestNoticeEN> arrzx_RequestNoticeObjLstCache = GetObjLstCache();
IEnumerable <clszx_RequestNoticeEN> arrzx_RequestNoticeObjLst_Sel =
arrzx_RequestNoticeObjLstCache
.Where(x=> x.RequestId == lngRequestId 
);
if (arrzx_RequestNoticeObjLst_Sel.Count() == 0)
{
   clszx_RequestNoticeEN obj = clszx_RequestNoticeBL.GetObjByRequestId(lngRequestId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_RequestNoticeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_RequestNoticeEN> GetAllzx_RequestNoticeObjLstCache()
{
//获取缓存中的对象列表
List<clszx_RequestNoticeEN> arrzx_RequestNoticeObjLstCache = GetObjLstCache(); 
return arrzx_RequestNoticeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_RequestNoticeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_RequestNoticeEN._CurrTabName);
List<clszx_RequestNoticeEN> arrzx_RequestNoticeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_RequestNoticeObjLstCache;
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
string strKey = string.Format("{0}", clszx_RequestNoticeEN._CurrTabName);
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
if (clszx_RequestNoticeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_RequestNoticeEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_RequestNoticeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_RequestNotice(中学请求通知表)
 /// 唯一性条件:RequestId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_RequestNoticeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_RequestNoticeEN objzx_RequestNoticeEN)
{
//检测记录是否存在
string strResult = zx_RequestNoticeDA.GetUniCondStr(objzx_RequestNoticeEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngRequestId)
{
if (strInFldName != conzx_RequestNotice.RequestId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_RequestNotice.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_RequestNotice.AttributeName));
throw new Exception(strMsg);
}
var objzx_RequestNotice = clszx_RequestNoticeBL.GetObjByRequestIdCache(lngRequestId);
if (objzx_RequestNotice == null) return "";
return objzx_RequestNotice[strOutFldName].ToString();
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
int intRecCount = clszx_RequestNoticeDA.GetRecCount(strTabName);
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
int intRecCount = clszx_RequestNoticeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_RequestNoticeDA.GetRecCount();
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
int intRecCount = clszx_RequestNoticeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_RequestNoticeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_RequestNoticeEN objzx_RequestNoticeCond)
{
List<clszx_RequestNoticeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_RequestNoticeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_RequestNotice.AttributeName)
{
if (objzx_RequestNoticeCond.IsUpdated(strFldName) == false) continue;
if (objzx_RequestNoticeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_RequestNoticeCond[strFldName].ToString());
}
else
{
if (objzx_RequestNoticeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_RequestNoticeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_RequestNoticeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_RequestNoticeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_RequestNoticeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_RequestNoticeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_RequestNoticeCond[strFldName]));
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
 List<string> arrList = clszx_RequestNoticeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_RequestNoticeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_RequestNoticeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_RequestNoticeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_RequestNoticeDA.SetFldValue(clszx_RequestNoticeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_RequestNoticeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_RequestNoticeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_RequestNoticeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_RequestNoticeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_RequestNotice] "); 
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
 // /**推送类型Id*/ 
 strCreateTabCode.Append(" PushTypeId char(2) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 中学请求通知表(zx_RequestNotice)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_RequestNotice : clsCommFun4BL
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
clszx_RequestNoticeBL.ReFreshThisCache();
}
}

}