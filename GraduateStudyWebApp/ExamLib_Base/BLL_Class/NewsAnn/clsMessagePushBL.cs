
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMessagePushBL
 表名:MessagePush(01120280)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告(NewsAnn)
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
public static class  clsMessagePushBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strMessagePushId">表关键字</param>
 /// <returns>表对象</returns>
public static clsMessagePushEN GetObj(this K_MessagePushId_MessagePush myKey)
{
clsMessagePushEN objMessagePushEN = clsMessagePushBL.MessagePushDA.GetObjByMessagePushId(myKey.Value);
return objMessagePushEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objMessagePushEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMessagePushEN objMessagePushEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objMessagePushEN) == false)
{
var strMsg = string.Format("记录已经存在!消息编号 = [{0}],修改日期 = [{1}]的数据已经存在!(in clsMessagePushBL.AddNewRecord)", objMessagePushEN.MessagePushNumber,objMessagePushEN.UpdDate);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objMessagePushEN.MessagePushId) == true || clsMessagePushBL.IsExist(objMessagePushEN.MessagePushId) == true)
 {
     objMessagePushEN.MessagePushId = clsMessagePushBL.GetMaxStrId_S();
 }
bool bolResult = clsMessagePushBL.MessagePushDA.AddNewRecordBySQL2(objMessagePushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMessagePushBL.ReFreshCache();

if (clsMessagePushBL.relatedActions != null)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(objMessagePushEN.MessagePushId, "SetUpdDate");
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
public static bool AddRecordEx(this clsMessagePushEN objMessagePushEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsMessagePushBL.IsExist(objMessagePushEN.MessagePushId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objMessagePushEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objMessagePushEN.CheckUniqueness() == false)
{
strMsg = string.Format("(消息编号(MessagePushNumber)=[{0}],修改日期(UpdDate)=[{1}])已经存在,不能重复!", objMessagePushEN.MessagePushNumber, objMessagePushEN.UpdDate);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objMessagePushEN.MessagePushId) == true || clsMessagePushBL.IsExist(objMessagePushEN.MessagePushId) == true)
 {
     objMessagePushEN.MessagePushId = clsMessagePushBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objMessagePushEN.AddNewRecord();
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
 /// <param name = "objMessagePushEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsMessagePushEN objMessagePushEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objMessagePushEN) == false)
{
var strMsg = string.Format("记录已经存在!消息编号 = [{0}],修改日期 = [{1}]的数据已经存在!(in clsMessagePushBL.AddNewRecordWithMaxId)", objMessagePushEN.MessagePushNumber,objMessagePushEN.UpdDate);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objMessagePushEN.MessagePushId) == true || clsMessagePushBL.IsExist(objMessagePushEN.MessagePushId) == true)
 {
     objMessagePushEN.MessagePushId = clsMessagePushBL.GetMaxStrId_S();
 }
string strMessagePushId = clsMessagePushBL.MessagePushDA.AddNewRecordBySQL2WithReturnKey(objMessagePushEN);
     objMessagePushEN.MessagePushId = strMessagePushId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMessagePushBL.ReFreshCache();

if (clsMessagePushBL.relatedActions != null)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(objMessagePushEN.MessagePushId, "SetUpdDate");
}
return strMessagePushId;
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
 /// <param name = "objMessagePushEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsMessagePushEN objMessagePushEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objMessagePushEN) == false)
{
var strMsg = string.Format("记录已经存在!消息编号 = [{0}],修改日期 = [{1}]的数据已经存在!(in clsMessagePushBL.AddNewRecordWithReturnKey)", objMessagePushEN.MessagePushNumber,objMessagePushEN.UpdDate);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objMessagePushEN.MessagePushId) == true || clsMessagePushBL.IsExist(objMessagePushEN.MessagePushId) == true)
 {
     objMessagePushEN.MessagePushId = clsMessagePushBL.GetMaxStrId_S();
 }
string strKey = clsMessagePushBL.MessagePushDA.AddNewRecordBySQL2WithReturnKey(objMessagePushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMessagePushBL.ReFreshCache();

if (clsMessagePushBL.relatedActions != null)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(objMessagePushEN.MessagePushId, "SetUpdDate");
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
 /// <param name = "objMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMessagePushEN SetMessagePushId(this clsMessagePushEN objMessagePushEN, string strMessagePushId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessagePushId, 8, conMessagePush.MessagePushId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMessagePushId, 8, conMessagePush.MessagePushId);
}
objMessagePushEN.MessagePushId = strMessagePushId; //消息Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMessagePushEN.dicFldComparisonOp.ContainsKey(conMessagePush.MessagePushId) == false)
{
objMessagePushEN.dicFldComparisonOp.Add(conMessagePush.MessagePushId, strComparisonOp);
}
else
{
objMessagePushEN.dicFldComparisonOp[conMessagePush.MessagePushId] = strComparisonOp;
}
}
return objMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMessagePushEN SetMessagePushNumber(this clsMessagePushEN objMessagePushEN, string strMessagePushNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessagePushNumber, 200, conMessagePush.MessagePushNumber);
}
objMessagePushEN.MessagePushNumber = strMessagePushNumber; //消息编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMessagePushEN.dicFldComparisonOp.ContainsKey(conMessagePush.MessagePushNumber) == false)
{
objMessagePushEN.dicFldComparisonOp.Add(conMessagePush.MessagePushNumber, strComparisonOp);
}
else
{
objMessagePushEN.dicFldComparisonOp[conMessagePush.MessagePushNumber] = strComparisonOp;
}
}
return objMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMessagePushEN SetMessageTitle(this clsMessagePushEN objMessagePushEN, string strMessageTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessageTitle, 500, conMessagePush.MessageTitle);
}
objMessagePushEN.MessageTitle = strMessageTitle; //消息标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMessagePushEN.dicFldComparisonOp.ContainsKey(conMessagePush.MessageTitle) == false)
{
objMessagePushEN.dicFldComparisonOp.Add(conMessagePush.MessageTitle, strComparisonOp);
}
else
{
objMessagePushEN.dicFldComparisonOp[conMessagePush.MessageTitle] = strComparisonOp;
}
}
return objMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMessagePushEN SetMessageContent(this clsMessagePushEN objMessagePushEN, string strMessageContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessageContent, 2000, conMessagePush.MessageContent);
}
objMessagePushEN.MessageContent = strMessageContent; //消息内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMessagePushEN.dicFldComparisonOp.ContainsKey(conMessagePush.MessageContent) == false)
{
objMessagePushEN.dicFldComparisonOp.Add(conMessagePush.MessageContent, strComparisonOp);
}
else
{
objMessagePushEN.dicFldComparisonOp[conMessagePush.MessageContent] = strComparisonOp;
}
}
return objMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMessagePushEN SetReceivePeople(this clsMessagePushEN objMessagePushEN, string strReceivePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReceivePeople, 50, conMessagePush.ReceivePeople);
}
objMessagePushEN.ReceivePeople = strReceivePeople; //接收人员
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMessagePushEN.dicFldComparisonOp.ContainsKey(conMessagePush.ReceivePeople) == false)
{
objMessagePushEN.dicFldComparisonOp.Add(conMessagePush.ReceivePeople, strComparisonOp);
}
else
{
objMessagePushEN.dicFldComparisonOp[conMessagePush.ReceivePeople] = strComparisonOp;
}
}
return objMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMessagePushEN SetMessageTypeId(this clsMessagePushEN objMessagePushEN, string strMessageTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMessageTypeId, conMessagePush.MessageTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessageTypeId, 8, conMessagePush.MessageTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMessageTypeId, 8, conMessagePush.MessageTypeId);
}
objMessagePushEN.MessageTypeId = strMessageTypeId; //消息类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMessagePushEN.dicFldComparisonOp.ContainsKey(conMessagePush.MessageTypeId) == false)
{
objMessagePushEN.dicFldComparisonOp.Add(conMessagePush.MessageTypeId, strComparisonOp);
}
else
{
objMessagePushEN.dicFldComparisonOp[conMessagePush.MessageTypeId] = strComparisonOp;
}
}
return objMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMessagePushEN SetIsAllpush(this clsMessagePushEN objMessagePushEN, bool bolIsAllpush, string strComparisonOp="")
	{
objMessagePushEN.IsAllpush = bolIsAllpush; //是否全体推送
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMessagePushEN.dicFldComparisonOp.ContainsKey(conMessagePush.IsAllpush) == false)
{
objMessagePushEN.dicFldComparisonOp.Add(conMessagePush.IsAllpush, strComparisonOp);
}
else
{
objMessagePushEN.dicFldComparisonOp[conMessagePush.IsAllpush] = strComparisonOp;
}
}
return objMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMessagePushEN SetIsReceive(this clsMessagePushEN objMessagePushEN, bool bolIsReceive, string strComparisonOp="")
	{
objMessagePushEN.IsReceive = bolIsReceive; //是否接收
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMessagePushEN.dicFldComparisonOp.ContainsKey(conMessagePush.IsReceive) == false)
{
objMessagePushEN.dicFldComparisonOp.Add(conMessagePush.IsReceive, strComparisonOp);
}
else
{
objMessagePushEN.dicFldComparisonOp[conMessagePush.IsReceive] = strComparisonOp;
}
}
return objMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMessagePushEN SetClientVersionTypeId(this clsMessagePushEN objMessagePushEN, string strClientVersionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClientVersionTypeId, 8, conMessagePush.ClientVersionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClientVersionTypeId, 8, conMessagePush.ClientVersionTypeId);
}
objMessagePushEN.ClientVersionTypeId = strClientVersionTypeId; //客户端版本类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMessagePushEN.dicFldComparisonOp.ContainsKey(conMessagePush.ClientVersionTypeId) == false)
{
objMessagePushEN.dicFldComparisonOp.Add(conMessagePush.ClientVersionTypeId, strComparisonOp);
}
else
{
objMessagePushEN.dicFldComparisonOp[conMessagePush.ClientVersionTypeId] = strComparisonOp;
}
}
return objMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMessagePushEN SetUpdDate(this clsMessagePushEN objMessagePushEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conMessagePush.UpdDate);
}
objMessagePushEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMessagePushEN.dicFldComparisonOp.ContainsKey(conMessagePush.UpdDate) == false)
{
objMessagePushEN.dicFldComparisonOp.Add(conMessagePush.UpdDate, strComparisonOp);
}
else
{
objMessagePushEN.dicFldComparisonOp[conMessagePush.UpdDate] = strComparisonOp;
}
}
return objMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMessagePushEN SetMemo(this clsMessagePushEN objMessagePushEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conMessagePush.Memo);
}
objMessagePushEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMessagePushEN.dicFldComparisonOp.ContainsKey(conMessagePush.Memo) == false)
{
objMessagePushEN.dicFldComparisonOp.Add(conMessagePush.Memo, strComparisonOp);
}
else
{
objMessagePushEN.dicFldComparisonOp[conMessagePush.Memo] = strComparisonOp;
}
}
return objMessagePushEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objMessagePushEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsMessagePushEN objMessagePushEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objMessagePushEN.CheckPropertyNew();
clsMessagePushEN objMessagePushCond = new clsMessagePushEN();
string strCondition = objMessagePushCond
.SetMessagePushId(objMessagePushEN.MessagePushId, "<>")
.SetMessagePushNumber(objMessagePushEN.MessagePushNumber, "=")
.SetUpdDate(objMessagePushEN.UpdDate, "=")
.GetCombineCondition();
objMessagePushEN._IsCheckProperty = true;
bool bolIsExist = clsMessagePushBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(MessagePushNumber_UpdDate)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objMessagePushEN.Update();
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
 /// <param name = "objMessagePush">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsMessagePushEN objMessagePush)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsMessagePushEN objMessagePushCond = new clsMessagePushEN();
string strCondition = objMessagePushCond
.SetMessagePushNumber(objMessagePush.MessagePushNumber, "=")
.SetUpdDate(objMessagePush.UpdDate, "=")
.GetCombineCondition();
objMessagePush._IsCheckProperty = true;
bool bolIsExist = clsMessagePushBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objMessagePush.MessagePushId = clsMessagePushBL.GetFirstID_S(strCondition);
objMessagePush.UpdateWithCondition(strCondition);
}
else
{
objMessagePush.MessagePushId = clsMessagePushBL.GetMaxStrId_S();
objMessagePush.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objMessagePushEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMessagePushEN objMessagePushEN)
{
 if (string.IsNullOrEmpty(objMessagePushEN.MessagePushId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMessagePushBL.MessagePushDA.UpdateBySql2(objMessagePushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMessagePushBL.ReFreshCache();

if (clsMessagePushBL.relatedActions != null)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(objMessagePushEN.MessagePushId, "SetUpdDate");
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
 /// <param name = "objMessagePushEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMessagePushEN objMessagePushEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objMessagePushEN.MessagePushId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMessagePushBL.MessagePushDA.UpdateBySql2(objMessagePushEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMessagePushBL.ReFreshCache();

if (clsMessagePushBL.relatedActions != null)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(objMessagePushEN.MessagePushId, "SetUpdDate");
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
 /// <param name = "objMessagePushEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMessagePushEN objMessagePushEN, string strWhereCond)
{
try
{
bool bolResult = clsMessagePushBL.MessagePushDA.UpdateBySqlWithCondition(objMessagePushEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMessagePushBL.ReFreshCache();

if (clsMessagePushBL.relatedActions != null)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(objMessagePushEN.MessagePushId, "SetUpdDate");
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
 /// <param name = "objMessagePushEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMessagePushEN objMessagePushEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsMessagePushBL.MessagePushDA.UpdateBySqlWithConditionTransaction(objMessagePushEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMessagePushBL.ReFreshCache();

if (clsMessagePushBL.relatedActions != null)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(objMessagePushEN.MessagePushId, "SetUpdDate");
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
 /// <param name = "strMessagePushId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsMessagePushEN objMessagePushEN)
{
try
{
int intRecNum = clsMessagePushBL.MessagePushDA.DelRecord(objMessagePushEN.MessagePushId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMessagePushBL.ReFreshCache();

if (clsMessagePushBL.relatedActions != null)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(objMessagePushEN.MessagePushId, "SetUpdDate");
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
 /// <param name = "objMessagePushENS">源对象</param>
 /// <param name = "objMessagePushENT">目标对象</param>
 public static void CopyTo(this clsMessagePushEN objMessagePushENS, clsMessagePushEN objMessagePushENT)
{
try
{
objMessagePushENT.MessagePushId = objMessagePushENS.MessagePushId; //消息Id
objMessagePushENT.MessagePushNumber = objMessagePushENS.MessagePushNumber; //消息编号
objMessagePushENT.MessageTitle = objMessagePushENS.MessageTitle; //消息标题
objMessagePushENT.MessageContent = objMessagePushENS.MessageContent; //消息内容
objMessagePushENT.ReceivePeople = objMessagePushENS.ReceivePeople; //接收人员
objMessagePushENT.MessageTypeId = objMessagePushENS.MessageTypeId; //消息类型Id
objMessagePushENT.IsAllpush = objMessagePushENS.IsAllpush; //是否全体推送
objMessagePushENT.IsReceive = objMessagePushENS.IsReceive; //是否接收
objMessagePushENT.ClientVersionTypeId = objMessagePushENS.ClientVersionTypeId; //客户端版本类型Id
objMessagePushENT.UpdDate = objMessagePushENS.UpdDate; //修改日期
objMessagePushENT.Memo = objMessagePushENS.Memo; //备注
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
 /// <param name = "objMessagePushENS">源对象</param>
 /// <returns>目标对象=>clsMessagePushEN:objMessagePushENT</returns>
 public static clsMessagePushEN CopyTo(this clsMessagePushEN objMessagePushENS)
{
try
{
 clsMessagePushEN objMessagePushENT = new clsMessagePushEN()
{
MessagePushId = objMessagePushENS.MessagePushId, //消息Id
MessagePushNumber = objMessagePushENS.MessagePushNumber, //消息编号
MessageTitle = objMessagePushENS.MessageTitle, //消息标题
MessageContent = objMessagePushENS.MessageContent, //消息内容
ReceivePeople = objMessagePushENS.ReceivePeople, //接收人员
MessageTypeId = objMessagePushENS.MessageTypeId, //消息类型Id
IsAllpush = objMessagePushENS.IsAllpush, //是否全体推送
IsReceive = objMessagePushENS.IsReceive, //是否接收
ClientVersionTypeId = objMessagePushENS.ClientVersionTypeId, //客户端版本类型Id
UpdDate = objMessagePushENS.UpdDate, //修改日期
Memo = objMessagePushENS.Memo, //备注
};
 return objMessagePushENT;
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
public static void CheckPropertyNew(this clsMessagePushEN objMessagePushEN)
{
 clsMessagePushBL.MessagePushDA.CheckPropertyNew(objMessagePushEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsMessagePushEN objMessagePushEN)
{
 clsMessagePushBL.MessagePushDA.CheckProperty4Condition(objMessagePushEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMessagePushEN objMessagePushCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMessagePushCond.IsUpdated(conMessagePush.MessagePushId) == true)
{
string strComparisonOpMessagePushId = objMessagePushCond.dicFldComparisonOp[conMessagePush.MessagePushId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMessagePush.MessagePushId, objMessagePushCond.MessagePushId, strComparisonOpMessagePushId);
}
if (objMessagePushCond.IsUpdated(conMessagePush.MessagePushNumber) == true)
{
string strComparisonOpMessagePushNumber = objMessagePushCond.dicFldComparisonOp[conMessagePush.MessagePushNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMessagePush.MessagePushNumber, objMessagePushCond.MessagePushNumber, strComparisonOpMessagePushNumber);
}
if (objMessagePushCond.IsUpdated(conMessagePush.MessageTitle) == true)
{
string strComparisonOpMessageTitle = objMessagePushCond.dicFldComparisonOp[conMessagePush.MessageTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMessagePush.MessageTitle, objMessagePushCond.MessageTitle, strComparisonOpMessageTitle);
}
if (objMessagePushCond.IsUpdated(conMessagePush.MessageContent) == true)
{
string strComparisonOpMessageContent = objMessagePushCond.dicFldComparisonOp[conMessagePush.MessageContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMessagePush.MessageContent, objMessagePushCond.MessageContent, strComparisonOpMessageContent);
}
if (objMessagePushCond.IsUpdated(conMessagePush.ReceivePeople) == true)
{
string strComparisonOpReceivePeople = objMessagePushCond.dicFldComparisonOp[conMessagePush.ReceivePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMessagePush.ReceivePeople, objMessagePushCond.ReceivePeople, strComparisonOpReceivePeople);
}
if (objMessagePushCond.IsUpdated(conMessagePush.MessageTypeId) == true)
{
string strComparisonOpMessageTypeId = objMessagePushCond.dicFldComparisonOp[conMessagePush.MessageTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMessagePush.MessageTypeId, objMessagePushCond.MessageTypeId, strComparisonOpMessageTypeId);
}
if (objMessagePushCond.IsUpdated(conMessagePush.IsAllpush) == true)
{
if (objMessagePushCond.IsAllpush == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMessagePush.IsAllpush);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMessagePush.IsAllpush);
}
}
if (objMessagePushCond.IsUpdated(conMessagePush.IsReceive) == true)
{
if (objMessagePushCond.IsReceive == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMessagePush.IsReceive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMessagePush.IsReceive);
}
}
if (objMessagePushCond.IsUpdated(conMessagePush.ClientVersionTypeId) == true)
{
string strComparisonOpClientVersionTypeId = objMessagePushCond.dicFldComparisonOp[conMessagePush.ClientVersionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMessagePush.ClientVersionTypeId, objMessagePushCond.ClientVersionTypeId, strComparisonOpClientVersionTypeId);
}
if (objMessagePushCond.IsUpdated(conMessagePush.UpdDate) == true)
{
string strComparisonOpUpdDate = objMessagePushCond.dicFldComparisonOp[conMessagePush.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMessagePush.UpdDate, objMessagePushCond.UpdDate, strComparisonOpUpdDate);
}
if (objMessagePushCond.IsUpdated(conMessagePush.Memo) == true)
{
string strComparisonOpMemo = objMessagePushCond.dicFldComparisonOp[conMessagePush.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMessagePush.Memo, objMessagePushCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--MessagePush(消息推送), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:MessagePushNumber_UpdDate
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objMessagePushEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsMessagePushEN objMessagePushEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objMessagePushEN == null) return true;
if (objMessagePushEN.MessagePushId == null || objMessagePushEN.MessagePushId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objMessagePushEN.MessagePushNumber == null)
{
 sbCondition.AppendFormat(" and MessagePushNumber is null", objMessagePushEN.MessagePushNumber);
}
else
{
 sbCondition.AppendFormat(" and MessagePushNumber = '{0}'", objMessagePushEN.MessagePushNumber);
}
 if (objMessagePushEN.UpdDate == null)
{
 sbCondition.AppendFormat(" and UpdDate is null", objMessagePushEN.UpdDate);
}
else
{
 sbCondition.AppendFormat(" and UpdDate = '{0}'", objMessagePushEN.UpdDate);
}
if (clsMessagePushBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("MessagePushId !=  '{0}'", objMessagePushEN.MessagePushId);
 sbCondition.AppendFormat(" and MessagePushNumber = '{0}'", objMessagePushEN.MessagePushNumber);
 sbCondition.AppendFormat(" and UpdDate = '{0}'", objMessagePushEN.UpdDate);
if (clsMessagePushBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--MessagePush(消息推送), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:MessagePushNumber_UpdDate
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objMessagePushEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsMessagePushEN objMessagePushEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objMessagePushEN == null) return "";
if (objMessagePushEN.MessagePushId == null || objMessagePushEN.MessagePushId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objMessagePushEN.MessagePushNumber == null)
{
 sbCondition.AppendFormat(" and MessagePushNumber is null", objMessagePushEN.MessagePushNumber);
}
else
{
 sbCondition.AppendFormat(" and MessagePushNumber = '{0}'", objMessagePushEN.MessagePushNumber);
}
 if (objMessagePushEN.UpdDate == null)
{
 sbCondition.AppendFormat(" and UpdDate is null", objMessagePushEN.UpdDate);
}
else
{
 sbCondition.AppendFormat(" and UpdDate = '{0}'", objMessagePushEN.UpdDate);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("MessagePushId !=  '{0}'", objMessagePushEN.MessagePushId);
 sbCondition.AppendFormat(" and MessagePushNumber = '{0}'", objMessagePushEN.MessagePushNumber);
 sbCondition.AppendFormat(" and UpdDate = '{0}'", objMessagePushEN.UpdDate);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_MessagePush
{
public virtual bool UpdRelaTabDate(string strMessagePushId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 消息推送(MessagePush)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsMessagePushBL
{
public static RelatedActions_MessagePush relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsMessagePushDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsMessagePushDA MessagePushDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsMessagePushDA();
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
 public clsMessagePushBL()
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
if (string.IsNullOrEmpty(clsMessagePushEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMessagePushEN._ConnectString);
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
public static DataTable GetDataTable_MessagePush(string strWhereCond)
{
DataTable objDT;
try
{
objDT = MessagePushDA.GetDataTable_MessagePush(strWhereCond);
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
objDT = MessagePushDA.GetDataTable(strWhereCond);
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
objDT = MessagePushDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = MessagePushDA.GetDataTable(strWhereCond, strTabName);
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
objDT = MessagePushDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = MessagePushDA.GetDataTable_Top(objTopPara);
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
objDT = MessagePushDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = MessagePushDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = MessagePushDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMessagePushIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsMessagePushEN> GetObjLstByMessagePushIdLst(List<string> arrMessagePushIdLst)
{
List<clsMessagePushEN> arrObjLst = new List<clsMessagePushEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMessagePushIdLst, true);
 string strWhereCond = string.Format("MessagePushId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMessagePushEN objMessagePushEN = new clsMessagePushEN();
try
{
objMessagePushEN.MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id
objMessagePushEN.MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objMessagePushEN.MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题
objMessagePushEN.MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容
objMessagePushEN.ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objMessagePushEN.MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsReceive].ToString().Trim()); //是否接收
objMessagePushEN.ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objMessagePushEN.UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期
objMessagePushEN.Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMessagePushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMessagePushIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsMessagePushEN> GetObjLstByMessagePushIdLstCache(List<string> arrMessagePushIdLst)
{
string strKey = string.Format("{0}", clsMessagePushEN._CurrTabName);
List<clsMessagePushEN> arrMessagePushObjLstCache = GetObjLstCache();
IEnumerable <clsMessagePushEN> arrMessagePushObjLst_Sel =
arrMessagePushObjLstCache
.Where(x => arrMessagePushIdLst.Contains(x.MessagePushId));
return arrMessagePushObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMessagePushEN> GetObjLst(string strWhereCond)
{
List<clsMessagePushEN> arrObjLst = new List<clsMessagePushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMessagePushEN objMessagePushEN = new clsMessagePushEN();
try
{
objMessagePushEN.MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id
objMessagePushEN.MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objMessagePushEN.MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题
objMessagePushEN.MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容
objMessagePushEN.ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objMessagePushEN.MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsReceive].ToString().Trim()); //是否接收
objMessagePushEN.ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objMessagePushEN.UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期
objMessagePushEN.Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMessagePushEN);
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
public static List<clsMessagePushEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsMessagePushEN> arrObjLst = new List<clsMessagePushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMessagePushEN objMessagePushEN = new clsMessagePushEN();
try
{
objMessagePushEN.MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id
objMessagePushEN.MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objMessagePushEN.MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题
objMessagePushEN.MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容
objMessagePushEN.ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objMessagePushEN.MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsReceive].ToString().Trim()); //是否接收
objMessagePushEN.ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objMessagePushEN.UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期
objMessagePushEN.Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMessagePushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objMessagePushCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsMessagePushEN> GetSubObjLstCache(clsMessagePushEN objMessagePushCond)
{
List<clsMessagePushEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMessagePushEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMessagePush.AttributeName)
{
if (objMessagePushCond.IsUpdated(strFldName) == false) continue;
if (objMessagePushCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMessagePushCond[strFldName].ToString());
}
else
{
if (objMessagePushCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMessagePushCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMessagePushCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMessagePushCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMessagePushCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMessagePushCond[strFldName]));
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
public static List<clsMessagePushEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsMessagePushEN> arrObjLst = new List<clsMessagePushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMessagePushEN objMessagePushEN = new clsMessagePushEN();
try
{
objMessagePushEN.MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id
objMessagePushEN.MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objMessagePushEN.MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题
objMessagePushEN.MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容
objMessagePushEN.ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objMessagePushEN.MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsReceive].ToString().Trim()); //是否接收
objMessagePushEN.ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objMessagePushEN.UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期
objMessagePushEN.Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMessagePushEN);
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
public static List<clsMessagePushEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsMessagePushEN> arrObjLst = new List<clsMessagePushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMessagePushEN objMessagePushEN = new clsMessagePushEN();
try
{
objMessagePushEN.MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id
objMessagePushEN.MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objMessagePushEN.MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题
objMessagePushEN.MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容
objMessagePushEN.ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objMessagePushEN.MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsReceive].ToString().Trim()); //是否接收
objMessagePushEN.ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objMessagePushEN.UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期
objMessagePushEN.Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMessagePushEN);
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
List<clsMessagePushEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsMessagePushEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsMessagePushEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsMessagePushEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsMessagePushEN> arrObjLst = new List<clsMessagePushEN>(); 
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
	clsMessagePushEN objMessagePushEN = new clsMessagePushEN();
try
{
objMessagePushEN.MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id
objMessagePushEN.MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objMessagePushEN.MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题
objMessagePushEN.MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容
objMessagePushEN.ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objMessagePushEN.MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsReceive].ToString().Trim()); //是否接收
objMessagePushEN.ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objMessagePushEN.UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期
objMessagePushEN.Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMessagePushEN);
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
public static List<clsMessagePushEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsMessagePushEN> arrObjLst = new List<clsMessagePushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMessagePushEN objMessagePushEN = new clsMessagePushEN();
try
{
objMessagePushEN.MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id
objMessagePushEN.MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objMessagePushEN.MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题
objMessagePushEN.MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容
objMessagePushEN.ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objMessagePushEN.MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsReceive].ToString().Trim()); //是否接收
objMessagePushEN.ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objMessagePushEN.UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期
objMessagePushEN.Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMessagePushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsMessagePushEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsMessagePushEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsMessagePushEN> arrObjLst = new List<clsMessagePushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMessagePushEN objMessagePushEN = new clsMessagePushEN();
try
{
objMessagePushEN.MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id
objMessagePushEN.MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objMessagePushEN.MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题
objMessagePushEN.MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容
objMessagePushEN.ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objMessagePushEN.MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsReceive].ToString().Trim()); //是否接收
objMessagePushEN.ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objMessagePushEN.UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期
objMessagePushEN.Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMessagePushEN);
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
public static List<clsMessagePushEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsMessagePushEN> arrObjLst = new List<clsMessagePushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMessagePushEN objMessagePushEN = new clsMessagePushEN();
try
{
objMessagePushEN.MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id
objMessagePushEN.MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objMessagePushEN.MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题
objMessagePushEN.MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容
objMessagePushEN.ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objMessagePushEN.MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsReceive].ToString().Trim()); //是否接收
objMessagePushEN.ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objMessagePushEN.UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期
objMessagePushEN.Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMessagePushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsMessagePushEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsMessagePushEN> arrObjLst = new List<clsMessagePushEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMessagePushEN objMessagePushEN = new clsMessagePushEN();
try
{
objMessagePushEN.MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id
objMessagePushEN.MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objMessagePushEN.MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题
objMessagePushEN.MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容
objMessagePushEN.ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objMessagePushEN.MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsReceive].ToString().Trim()); //是否接收
objMessagePushEN.ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objMessagePushEN.UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期
objMessagePushEN.Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMessagePushEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objMessagePushEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetMessagePush(ref clsMessagePushEN objMessagePushEN)
{
bool bolResult = MessagePushDA.GetMessagePush(ref objMessagePushEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strMessagePushId">表关键字</param>
 /// <returns>表对象</returns>
public static clsMessagePushEN GetObjByMessagePushId(string strMessagePushId)
{
if (strMessagePushId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strMessagePushId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strMessagePushId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strMessagePushId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsMessagePushEN objMessagePushEN = MessagePushDA.GetObjByMessagePushId(strMessagePushId);
return objMessagePushEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsMessagePushEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsMessagePushEN objMessagePushEN = MessagePushDA.GetFirstObj(strWhereCond);
 return objMessagePushEN;
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
public static clsMessagePushEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsMessagePushEN objMessagePushEN = MessagePushDA.GetObjByDataRow(objRow);
 return objMessagePushEN;
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
public static clsMessagePushEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsMessagePushEN objMessagePushEN = MessagePushDA.GetObjByDataRow(objRow);
 return objMessagePushEN;
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
 /// <param name = "strMessagePushId">所给的关键字</param>
 /// <param name = "lstMessagePushObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMessagePushEN GetObjByMessagePushIdFromList(string strMessagePushId, List<clsMessagePushEN> lstMessagePushObjLst)
{
foreach (clsMessagePushEN objMessagePushEN in lstMessagePushObjLst)
{
if (objMessagePushEN.MessagePushId == strMessagePushId)
{
return objMessagePushEN;
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
 string strMaxMessagePushId;
 try
 {
 strMaxMessagePushId = clsMessagePushDA.GetMaxStrId();
 return strMaxMessagePushId;
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
 string strMessagePushId;
 try
 {
 strMessagePushId = new clsMessagePushDA().GetFirstID(strWhereCond);
 return strMessagePushId;
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
 arrList = MessagePushDA.GetID(strWhereCond);
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
bool bolIsExist = MessagePushDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strMessagePushId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strMessagePushId)
{
if (string.IsNullOrEmpty(strMessagePushId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strMessagePushId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = MessagePushDA.IsExist(strMessagePushId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strMessagePushId">消息Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strMessagePushId, string strOpUser)
{
clsMessagePushEN objMessagePushEN = clsMessagePushBL.GetObjByMessagePushId(strMessagePushId);
objMessagePushEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsMessagePushBL.UpdateBySql2(objMessagePushEN);
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
 bolIsExist = clsMessagePushDA.IsExistTable();
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
 bolIsExist = MessagePushDA.IsExistTable(strTabName);
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
 /// <param name = "objMessagePushEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsMessagePushEN objMessagePushEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objMessagePushEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!消息编号 = [{0}],修改日期 = [{1}]的数据已经存在!(in clsMessagePushBL.AddNewRecordBySql2)", objMessagePushEN.MessagePushNumber,objMessagePushEN.UpdDate);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objMessagePushEN.MessagePushId) == true || clsMessagePushBL.IsExist(objMessagePushEN.MessagePushId) == true)
 {
     objMessagePushEN.MessagePushId = clsMessagePushBL.GetMaxStrId_S();
 }
bool bolResult = MessagePushDA.AddNewRecordBySQL2(objMessagePushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMessagePushBL.ReFreshCache();

if (clsMessagePushBL.relatedActions != null)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(objMessagePushEN.MessagePushId, "SetUpdDate");
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
 /// <param name = "objMessagePushEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsMessagePushEN objMessagePushEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objMessagePushEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!消息编号 = [{0}],修改日期 = [{1}]的数据已经存在!(in clsMessagePushBL.AddNewRecordBySql2WithReturnKey)", objMessagePushEN.MessagePushNumber,objMessagePushEN.UpdDate);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objMessagePushEN.MessagePushId) == true || clsMessagePushBL.IsExist(objMessagePushEN.MessagePushId) == true)
 {
     objMessagePushEN.MessagePushId = clsMessagePushBL.GetMaxStrId_S();
 }
string strKey = MessagePushDA.AddNewRecordBySQL2WithReturnKey(objMessagePushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMessagePushBL.ReFreshCache();

if (clsMessagePushBL.relatedActions != null)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(objMessagePushEN.MessagePushId, "SetUpdDate");
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
 /// <param name = "objMessagePushEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsMessagePushEN objMessagePushEN)
{
try
{
bool bolResult = MessagePushDA.Update(objMessagePushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMessagePushBL.ReFreshCache();

if (clsMessagePushBL.relatedActions != null)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(objMessagePushEN.MessagePushId, "SetUpdDate");
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
 /// <param name = "objMessagePushEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsMessagePushEN objMessagePushEN)
{
 if (string.IsNullOrEmpty(objMessagePushEN.MessagePushId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = MessagePushDA.UpdateBySql2(objMessagePushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMessagePushBL.ReFreshCache();

if (clsMessagePushBL.relatedActions != null)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(objMessagePushEN.MessagePushId, "SetUpdDate");
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
 /// <param name = "strMessagePushId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strMessagePushId)
{
try
{
 clsMessagePushEN objMessagePushEN = clsMessagePushBL.GetObjByMessagePushId(strMessagePushId);

if (clsMessagePushBL.relatedActions != null)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(objMessagePushEN.MessagePushId, "SetUpdDate");
}
if (objMessagePushEN != null)
{
int intRecNum = MessagePushDA.DelRecord(strMessagePushId);
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
/// <param name="strMessagePushId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strMessagePushId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMessagePushDA.GetSpecSQLObj();
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
//删除与表:[MessagePush]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conMessagePush.MessagePushId,
//strMessagePushId);
//        clsMessagePushBL.DelMessagePushsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMessagePushBL.DelRecord(strMessagePushId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMessagePushBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strMessagePushId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strMessagePushId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strMessagePushId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsMessagePushBL.relatedActions != null)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(strMessagePushId, "UpdRelaTabDate");
}
bool bolResult = MessagePushDA.DelRecord(strMessagePushId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrMessagePushIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelMessagePushs(List<string> arrMessagePushIdLst)
{
if (arrMessagePushIdLst.Count == 0) return 0;
try
{
if (clsMessagePushBL.relatedActions != null)
{
foreach (var strMessagePushId in arrMessagePushIdLst)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(strMessagePushId, "UpdRelaTabDate");
}
}
int intDelRecNum = MessagePushDA.DelMessagePush(arrMessagePushIdLst);
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
public static int DelMessagePushsByCond(string strWhereCond)
{
try
{
if (clsMessagePushBL.relatedActions != null)
{
List<string> arrMessagePushId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strMessagePushId in arrMessagePushId)
{
clsMessagePushBL.relatedActions.UpdRelaTabDate(strMessagePushId, "UpdRelaTabDate");
}
}
int intRecNum = MessagePushDA.DelMessagePush(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[MessagePush]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strMessagePushId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strMessagePushId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMessagePushDA.GetSpecSQLObj();
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
//删除与表:[MessagePush]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMessagePushBL.DelRecord(strMessagePushId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMessagePushBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strMessagePushId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objMessagePushENS">源对象</param>
 /// <param name = "objMessagePushENT">目标对象</param>
 public static void CopyTo(clsMessagePushEN objMessagePushENS, clsMessagePushEN objMessagePushENT)
{
try
{
objMessagePushENT.MessagePushId = objMessagePushENS.MessagePushId; //消息Id
objMessagePushENT.MessagePushNumber = objMessagePushENS.MessagePushNumber; //消息编号
objMessagePushENT.MessageTitle = objMessagePushENS.MessageTitle; //消息标题
objMessagePushENT.MessageContent = objMessagePushENS.MessageContent; //消息内容
objMessagePushENT.ReceivePeople = objMessagePushENS.ReceivePeople; //接收人员
objMessagePushENT.MessageTypeId = objMessagePushENS.MessageTypeId; //消息类型Id
objMessagePushENT.IsAllpush = objMessagePushENS.IsAllpush; //是否全体推送
objMessagePushENT.IsReceive = objMessagePushENS.IsReceive; //是否接收
objMessagePushENT.ClientVersionTypeId = objMessagePushENS.ClientVersionTypeId; //客户端版本类型Id
objMessagePushENT.UpdDate = objMessagePushENS.UpdDate; //修改日期
objMessagePushENT.Memo = objMessagePushENS.Memo; //备注
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
 /// <param name = "objMessagePushEN">源简化对象</param>
 public static void SetUpdFlag(clsMessagePushEN objMessagePushEN)
{
try
{
objMessagePushEN.ClearUpdateState();
   string strsfUpdFldSetStr = objMessagePushEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conMessagePush.MessagePushId, new clsStrCompareIgnoreCase())  ==  true)
{
objMessagePushEN.MessagePushId = objMessagePushEN.MessagePushId; //消息Id
}
if (arrFldSet.Contains(conMessagePush.MessagePushNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objMessagePushEN.MessagePushNumber = objMessagePushEN.MessagePushNumber == "[null]" ? null :  objMessagePushEN.MessagePushNumber; //消息编号
}
if (arrFldSet.Contains(conMessagePush.MessageTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objMessagePushEN.MessageTitle = objMessagePushEN.MessageTitle == "[null]" ? null :  objMessagePushEN.MessageTitle; //消息标题
}
if (arrFldSet.Contains(conMessagePush.MessageContent, new clsStrCompareIgnoreCase())  ==  true)
{
objMessagePushEN.MessageContent = objMessagePushEN.MessageContent == "[null]" ? null :  objMessagePushEN.MessageContent; //消息内容
}
if (arrFldSet.Contains(conMessagePush.ReceivePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objMessagePushEN.ReceivePeople = objMessagePushEN.ReceivePeople == "[null]" ? null :  objMessagePushEN.ReceivePeople; //接收人员
}
if (arrFldSet.Contains(conMessagePush.MessageTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objMessagePushEN.MessageTypeId = objMessagePushEN.MessageTypeId; //消息类型Id
}
if (arrFldSet.Contains(conMessagePush.IsAllpush, new clsStrCompareIgnoreCase())  ==  true)
{
objMessagePushEN.IsAllpush = objMessagePushEN.IsAllpush; //是否全体推送
}
if (arrFldSet.Contains(conMessagePush.IsReceive, new clsStrCompareIgnoreCase())  ==  true)
{
objMessagePushEN.IsReceive = objMessagePushEN.IsReceive; //是否接收
}
if (arrFldSet.Contains(conMessagePush.ClientVersionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objMessagePushEN.ClientVersionTypeId = objMessagePushEN.ClientVersionTypeId == "[null]" ? null :  objMessagePushEN.ClientVersionTypeId; //客户端版本类型Id
}
if (arrFldSet.Contains(conMessagePush.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objMessagePushEN.UpdDate = objMessagePushEN.UpdDate == "[null]" ? null :  objMessagePushEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conMessagePush.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objMessagePushEN.Memo = objMessagePushEN.Memo == "[null]" ? null :  objMessagePushEN.Memo; //备注
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
 /// <param name = "objMessagePushEN">源简化对象</param>
 public static void AccessFldValueNull(clsMessagePushEN objMessagePushEN)
{
try
{
if (objMessagePushEN.MessagePushNumber == "[null]") objMessagePushEN.MessagePushNumber = null; //消息编号
if (objMessagePushEN.MessageTitle == "[null]") objMessagePushEN.MessageTitle = null; //消息标题
if (objMessagePushEN.MessageContent == "[null]") objMessagePushEN.MessageContent = null; //消息内容
if (objMessagePushEN.ReceivePeople == "[null]") objMessagePushEN.ReceivePeople = null; //接收人员
if (objMessagePushEN.ClientVersionTypeId == "[null]") objMessagePushEN.ClientVersionTypeId = null; //客户端版本类型Id
if (objMessagePushEN.UpdDate == "[null]") objMessagePushEN.UpdDate = null; //修改日期
if (objMessagePushEN.Memo == "[null]") objMessagePushEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsMessagePushEN objMessagePushEN)
{
 MessagePushDA.CheckPropertyNew(objMessagePushEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsMessagePushEN objMessagePushEN)
{
 MessagePushDA.CheckProperty4Condition(objMessagePushEN);
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
if (clsMessagePushBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMessagePushBL没有刷新缓存机制(clsMessagePushBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MessagePushId");
//if (arrMessagePushObjLstCache == null)
//{
//arrMessagePushObjLstCache = MessagePushDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strMessagePushId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMessagePushEN GetObjByMessagePushIdCache(string strMessagePushId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsMessagePushEN._CurrTabName);
List<clsMessagePushEN> arrMessagePushObjLstCache = GetObjLstCache();
IEnumerable <clsMessagePushEN> arrMessagePushObjLst_Sel =
arrMessagePushObjLstCache
.Where(x=> x.MessagePushId == strMessagePushId 
);
if (arrMessagePushObjLst_Sel.Count() == 0)
{
   clsMessagePushEN obj = clsMessagePushBL.GetObjByMessagePushId(strMessagePushId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrMessagePushObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMessagePushEN> GetAllMessagePushObjLstCache()
{
//获取缓存中的对象列表
List<clsMessagePushEN> arrMessagePushObjLstCache = GetObjLstCache(); 
return arrMessagePushObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMessagePushEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsMessagePushEN._CurrTabName);
List<clsMessagePushEN> arrMessagePushObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMessagePushObjLstCache;
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
string strKey = string.Format("{0}", clsMessagePushEN._CurrTabName);
CacheHelper.Remove(strKey);
clsMessagePushEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsMessagePushEN._RefreshTimeLst.Count == 0) return "";
return clsMessagePushEN._RefreshTimeLst[clsMessagePushEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsMessagePushBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMessagePushEN._CurrTabName);
CacheHelper.Remove(strKey);
clsMessagePushEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsMessagePushBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--MessagePush(消息推送)
 /// 唯一性条件:MessagePushNumber_UpdDate
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objMessagePushEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsMessagePushEN objMessagePushEN)
{
//检测记录是否存在
string strResult = MessagePushDA.GetUniCondStr(objMessagePushEN);
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
public static string Func(string strInFldName, string strOutFldName, string strMessagePushId)
{
if (strInFldName != conMessagePush.MessagePushId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conMessagePush.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conMessagePush.AttributeName));
throw new Exception(strMsg);
}
var objMessagePush = clsMessagePushBL.GetObjByMessagePushIdCache(strMessagePushId);
if (objMessagePush == null) return "";
return objMessagePush[strOutFldName].ToString();
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
int intRecCount = clsMessagePushDA.GetRecCount(strTabName);
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
int intRecCount = clsMessagePushDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsMessagePushDA.GetRecCount();
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
int intRecCount = clsMessagePushDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objMessagePushCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsMessagePushEN objMessagePushCond)
{
List<clsMessagePushEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMessagePushEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMessagePush.AttributeName)
{
if (objMessagePushCond.IsUpdated(strFldName) == false) continue;
if (objMessagePushCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMessagePushCond[strFldName].ToString());
}
else
{
if (objMessagePushCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMessagePushCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMessagePushCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMessagePushCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMessagePushCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMessagePushCond[strFldName]));
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
 List<string> arrList = clsMessagePushDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = MessagePushDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = MessagePushDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = MessagePushDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsMessagePushDA.SetFldValue(clsMessagePushEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = MessagePushDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsMessagePushDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsMessagePushDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsMessagePushDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[MessagePush] "); 
 strCreateTabCode.Append(" ( "); 
 // /**消息Id*/ 
 strCreateTabCode.Append(" MessagePushId char(8) primary key, "); 
 // /**消息编号*/ 
 strCreateTabCode.Append(" MessagePushNumber varchar(200) Null, "); 
 // /**消息标题*/ 
 strCreateTabCode.Append(" MessageTitle varchar(500) Null, "); 
 // /**消息内容*/ 
 strCreateTabCode.Append(" MessageContent varchar(2000) Null, "); 
 // /**接收人员*/ 
 strCreateTabCode.Append(" ReceivePeople varchar(50) Null, "); 
 // /**消息类型Id*/ 
 strCreateTabCode.Append(" MessageTypeId char(8) not Null, "); 
 // /**是否全体推送*/ 
 strCreateTabCode.Append(" IsAllpush bit Null, "); 
 // /**是否接收*/ 
 strCreateTabCode.Append(" IsReceive bit Null, "); 
 // /**客户端版本类型Id*/ 
 strCreateTabCode.Append(" ClientVersionTypeId char(8) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 消息推送(MessagePush)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4MessagePush : clsCommFun4BL
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
clsMessagePushBL.ReFreshThisCache();
}
}

}