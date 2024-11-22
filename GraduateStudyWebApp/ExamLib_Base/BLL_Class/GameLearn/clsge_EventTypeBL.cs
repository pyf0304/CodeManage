﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_EventTypeBL
 表名:ge_EventType(01120899)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
public static class  clsge_EventTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strEventTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_EventTypeEN GetObj(this K_EventTypeId_ge_EventType myKey)
{
clsge_EventTypeEN objge_EventTypeEN = clsge_EventTypeBL.ge_EventTypeDA.GetObjByEventTypeId(myKey.Value);
return objge_EventTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_EventTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_EventTypeEN objge_EventTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_EventTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!事件名称 = [{0}]的数据已经存在!(in clsge_EventTypeBL.AddNewRecord)", objge_EventTypeEN.EventTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_EventTypeEN.EventTypeId) == true || clsge_EventTypeBL.IsExist(objge_EventTypeEN.EventTypeId) == true)
 {
     objge_EventTypeEN.EventTypeId = clsge_EventTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsge_EventTypeBL.ge_EventTypeDA.AddNewRecordBySQL2(objge_EventTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_EventTypeBL.ReFreshCache();

if (clsge_EventTypeBL.relatedActions != null)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(objge_EventTypeEN.EventTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsge_EventTypeEN objge_EventTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsge_EventTypeBL.IsExist(objge_EventTypeEN.EventTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objge_EventTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_EventTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(事件名称(EventTypeName)=[{0}])已经存在,不能重复!", objge_EventTypeEN.EventTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objge_EventTypeEN.EventTypeId) == true || clsge_EventTypeBL.IsExist(objge_EventTypeEN.EventTypeId) == true)
 {
     objge_EventTypeEN.EventTypeId = clsge_EventTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objge_EventTypeEN.AddNewRecord();
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
 /// <param name = "objge_EventTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsge_EventTypeEN objge_EventTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_EventTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!事件名称 = [{0}]的数据已经存在!(in clsge_EventTypeBL.AddNewRecordWithMaxId)", objge_EventTypeEN.EventTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_EventTypeEN.EventTypeId) == true || clsge_EventTypeBL.IsExist(objge_EventTypeEN.EventTypeId) == true)
 {
     objge_EventTypeEN.EventTypeId = clsge_EventTypeBL.GetMaxStrId_S();
 }
string strEventTypeId = clsge_EventTypeBL.ge_EventTypeDA.AddNewRecordBySQL2WithReturnKey(objge_EventTypeEN);
     objge_EventTypeEN.EventTypeId = strEventTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_EventTypeBL.ReFreshCache();

if (clsge_EventTypeBL.relatedActions != null)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(objge_EventTypeEN.EventTypeId, "SetUpdDate");
}
return strEventTypeId;
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
 /// <param name = "objge_EventTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_EventTypeEN objge_EventTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_EventTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!事件名称 = [{0}]的数据已经存在!(in clsge_EventTypeBL.AddNewRecordWithReturnKey)", objge_EventTypeEN.EventTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_EventTypeEN.EventTypeId) == true || clsge_EventTypeBL.IsExist(objge_EventTypeEN.EventTypeId) == true)
 {
     objge_EventTypeEN.EventTypeId = clsge_EventTypeBL.GetMaxStrId_S();
 }
string strKey = clsge_EventTypeBL.ge_EventTypeDA.AddNewRecordBySQL2WithReturnKey(objge_EventTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_EventTypeBL.ReFreshCache();

if (clsge_EventTypeBL.relatedActions != null)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(objge_EventTypeEN.EventTypeId, "SetUpdDate");
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
 /// <param name = "objge_EventTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_EventTypeEN SetEventTypeId(this clsge_EventTypeEN objge_EventTypeEN, string strEventTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEventTypeId, 4, conge_EventType.EventTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEventTypeId, 4, conge_EventType.EventTypeId);
}
objge_EventTypeEN.EventTypeId = strEventTypeId; //事件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_EventTypeEN.dicFldComparisonOp.ContainsKey(conge_EventType.EventTypeId) == false)
{
objge_EventTypeEN.dicFldComparisonOp.Add(conge_EventType.EventTypeId, strComparisonOp);
}
else
{
objge_EventTypeEN.dicFldComparisonOp[conge_EventType.EventTypeId] = strComparisonOp;
}
}
return objge_EventTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_EventTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_EventTypeEN SetEventTypeName(this clsge_EventTypeEN objge_EventTypeEN, string strEventTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEventTypeName, 100, conge_EventType.EventTypeName);
}
objge_EventTypeEN.EventTypeName = strEventTypeName; //事件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_EventTypeEN.dicFldComparisonOp.ContainsKey(conge_EventType.EventTypeName) == false)
{
objge_EventTypeEN.dicFldComparisonOp.Add(conge_EventType.EventTypeName, strComparisonOp);
}
else
{
objge_EventTypeEN.dicFldComparisonOp[conge_EventType.EventTypeName] = strComparisonOp;
}
}
return objge_EventTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_EventTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_EventTypeEN SetEventTypeEnName(this clsge_EventTypeEN objge_EventTypeEN, string strEventTypeEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEventTypeEnName, 100, conge_EventType.EventTypeEnName);
}
objge_EventTypeEN.EventTypeEnName = strEventTypeEnName; //事件英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_EventTypeEN.dicFldComparisonOp.ContainsKey(conge_EventType.EventTypeEnName) == false)
{
objge_EventTypeEN.dicFldComparisonOp.Add(conge_EventType.EventTypeEnName, strComparisonOp);
}
else
{
objge_EventTypeEN.dicFldComparisonOp[conge_EventType.EventTypeEnName] = strComparisonOp;
}
}
return objge_EventTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_EventTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_EventTypeEN SetUpdDate(this clsge_EventTypeEN objge_EventTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_EventType.UpdDate);
}
objge_EventTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_EventTypeEN.dicFldComparisonOp.ContainsKey(conge_EventType.UpdDate) == false)
{
objge_EventTypeEN.dicFldComparisonOp.Add(conge_EventType.UpdDate, strComparisonOp);
}
else
{
objge_EventTypeEN.dicFldComparisonOp[conge_EventType.UpdDate] = strComparisonOp;
}
}
return objge_EventTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_EventTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_EventTypeEN SetUpdUser(this clsge_EventTypeEN objge_EventTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_EventType.UpdUser);
}
objge_EventTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_EventTypeEN.dicFldComparisonOp.ContainsKey(conge_EventType.UpdUser) == false)
{
objge_EventTypeEN.dicFldComparisonOp.Add(conge_EventType.UpdUser, strComparisonOp);
}
else
{
objge_EventTypeEN.dicFldComparisonOp[conge_EventType.UpdUser] = strComparisonOp;
}
}
return objge_EventTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_EventTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_EventTypeEN SetMemo(this clsge_EventTypeEN objge_EventTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_EventType.Memo);
}
objge_EventTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_EventTypeEN.dicFldComparisonOp.ContainsKey(conge_EventType.Memo) == false)
{
objge_EventTypeEN.dicFldComparisonOp.Add(conge_EventType.Memo, strComparisonOp);
}
else
{
objge_EventTypeEN.dicFldComparisonOp[conge_EventType.Memo] = strComparisonOp;
}
}
return objge_EventTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_EventTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_EventTypeEN objge_EventTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_EventTypeEN.CheckPropertyNew();
clsge_EventTypeEN objge_EventTypeCond = new clsge_EventTypeEN();
string strCondition = objge_EventTypeCond
.SetEventTypeId(objge_EventTypeEN.EventTypeId, "<>")
.SetEventTypeName(objge_EventTypeEN.EventTypeName, "=")
.GetCombineCondition();
objge_EventTypeEN._IsCheckProperty = true;
bool bolIsExist = clsge_EventTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(EventTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_EventTypeEN.Update();
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
 /// <param name = "objge_EventType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_EventTypeEN objge_EventType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_EventTypeEN objge_EventTypeCond = new clsge_EventTypeEN();
string strCondition = objge_EventTypeCond
.SetEventTypeName(objge_EventType.EventTypeName, "=")
.GetCombineCondition();
objge_EventType._IsCheckProperty = true;
bool bolIsExist = clsge_EventTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_EventType.EventTypeId = clsge_EventTypeBL.GetFirstID_S(strCondition);
objge_EventType.UpdateWithCondition(strCondition);
}
else
{
objge_EventType.EventTypeId = clsge_EventTypeBL.GetMaxStrId_S();
objge_EventType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_EventTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_EventTypeEN objge_EventTypeEN)
{
 if (string.IsNullOrEmpty(objge_EventTypeEN.EventTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_EventTypeBL.ge_EventTypeDA.UpdateBySql2(objge_EventTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_EventTypeBL.ReFreshCache();

if (clsge_EventTypeBL.relatedActions != null)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(objge_EventTypeEN.EventTypeId, "SetUpdDate");
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
 /// <param name = "objge_EventTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_EventTypeEN objge_EventTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objge_EventTypeEN.EventTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_EventTypeBL.ge_EventTypeDA.UpdateBySql2(objge_EventTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_EventTypeBL.ReFreshCache();

if (clsge_EventTypeBL.relatedActions != null)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(objge_EventTypeEN.EventTypeId, "SetUpdDate");
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
 /// <param name = "objge_EventTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_EventTypeEN objge_EventTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsge_EventTypeBL.ge_EventTypeDA.UpdateBySqlWithCondition(objge_EventTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_EventTypeBL.ReFreshCache();

if (clsge_EventTypeBL.relatedActions != null)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(objge_EventTypeEN.EventTypeId, "SetUpdDate");
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
 /// <param name = "objge_EventTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_EventTypeEN objge_EventTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_EventTypeBL.ge_EventTypeDA.UpdateBySqlWithConditionTransaction(objge_EventTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_EventTypeBL.ReFreshCache();

if (clsge_EventTypeBL.relatedActions != null)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(objge_EventTypeEN.EventTypeId, "SetUpdDate");
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
 /// <param name = "strEventTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_EventTypeEN objge_EventTypeEN)
{
try
{
int intRecNum = clsge_EventTypeBL.ge_EventTypeDA.DelRecord(objge_EventTypeEN.EventTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_EventTypeBL.ReFreshCache();

if (clsge_EventTypeBL.relatedActions != null)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(objge_EventTypeEN.EventTypeId, "SetUpdDate");
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
 /// <param name = "objge_EventTypeENS">源对象</param>
 /// <param name = "objge_EventTypeENT">目标对象</param>
 public static void CopyTo(this clsge_EventTypeEN objge_EventTypeENS, clsge_EventTypeEN objge_EventTypeENT)
{
try
{
objge_EventTypeENT.EventTypeId = objge_EventTypeENS.EventTypeId; //事件Id
objge_EventTypeENT.EventTypeName = objge_EventTypeENS.EventTypeName; //事件名称
objge_EventTypeENT.EventTypeEnName = objge_EventTypeENS.EventTypeEnName; //事件英文名称
objge_EventTypeENT.UpdDate = objge_EventTypeENS.UpdDate; //修改日期
objge_EventTypeENT.UpdUser = objge_EventTypeENS.UpdUser; //修改人
objge_EventTypeENT.Memo = objge_EventTypeENS.Memo; //备注
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
 /// <param name = "objge_EventTypeENS">源对象</param>
 /// <returns>目标对象=>clsge_EventTypeEN:objge_EventTypeENT</returns>
 public static clsge_EventTypeEN CopyTo(this clsge_EventTypeEN objge_EventTypeENS)
{
try
{
 clsge_EventTypeEN objge_EventTypeENT = new clsge_EventTypeEN()
{
EventTypeId = objge_EventTypeENS.EventTypeId, //事件Id
EventTypeName = objge_EventTypeENS.EventTypeName, //事件名称
EventTypeEnName = objge_EventTypeENS.EventTypeEnName, //事件英文名称
UpdDate = objge_EventTypeENS.UpdDate, //修改日期
UpdUser = objge_EventTypeENS.UpdUser, //修改人
Memo = objge_EventTypeENS.Memo, //备注
};
 return objge_EventTypeENT;
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
public static void CheckPropertyNew(this clsge_EventTypeEN objge_EventTypeEN)
{
 clsge_EventTypeBL.ge_EventTypeDA.CheckPropertyNew(objge_EventTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_EventTypeEN objge_EventTypeEN)
{
 clsge_EventTypeBL.ge_EventTypeDA.CheckProperty4Condition(objge_EventTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_EventTypeEN objge_EventTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_EventTypeCond.IsUpdated(conge_EventType.EventTypeId) == true)
{
string strComparisonOpEventTypeId = objge_EventTypeCond.dicFldComparisonOp[conge_EventType.EventTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_EventType.EventTypeId, objge_EventTypeCond.EventTypeId, strComparisonOpEventTypeId);
}
if (objge_EventTypeCond.IsUpdated(conge_EventType.EventTypeName) == true)
{
string strComparisonOpEventTypeName = objge_EventTypeCond.dicFldComparisonOp[conge_EventType.EventTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_EventType.EventTypeName, objge_EventTypeCond.EventTypeName, strComparisonOpEventTypeName);
}
if (objge_EventTypeCond.IsUpdated(conge_EventType.EventTypeEnName) == true)
{
string strComparisonOpEventTypeEnName = objge_EventTypeCond.dicFldComparisonOp[conge_EventType.EventTypeEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_EventType.EventTypeEnName, objge_EventTypeCond.EventTypeEnName, strComparisonOpEventTypeEnName);
}
if (objge_EventTypeCond.IsUpdated(conge_EventType.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_EventTypeCond.dicFldComparisonOp[conge_EventType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_EventType.UpdDate, objge_EventTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_EventTypeCond.IsUpdated(conge_EventType.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_EventTypeCond.dicFldComparisonOp[conge_EventType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_EventType.UpdUser, objge_EventTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_EventTypeCond.IsUpdated(conge_EventType.Memo) == true)
{
string strComparisonOpMemo = objge_EventTypeCond.dicFldComparisonOp[conge_EventType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_EventType.Memo, objge_EventTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_EventType(事件类型表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:EventTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_EventTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_EventTypeEN objge_EventTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_EventTypeEN == null) return true;
if (objge_EventTypeEN.EventTypeId == null || objge_EventTypeEN.EventTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objge_EventTypeEN.EventTypeName == null)
{
 sbCondition.AppendFormat(" and EventTypeName is null", objge_EventTypeEN.EventTypeName);
}
else
{
 sbCondition.AppendFormat(" and EventTypeName = '{0}'", objge_EventTypeEN.EventTypeName);
}
if (clsge_EventTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("EventTypeId !=  '{0}'", objge_EventTypeEN.EventTypeId);
 sbCondition.AppendFormat(" and EventTypeName = '{0}'", objge_EventTypeEN.EventTypeName);
if (clsge_EventTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_EventType(事件类型表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:EventTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_EventTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_EventTypeEN objge_EventTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_EventTypeEN == null) return "";
if (objge_EventTypeEN.EventTypeId == null || objge_EventTypeEN.EventTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objge_EventTypeEN.EventTypeName == null)
{
 sbCondition.AppendFormat(" and EventTypeName is null", objge_EventTypeEN.EventTypeName);
}
else
{
 sbCondition.AppendFormat(" and EventTypeName = '{0}'", objge_EventTypeEN.EventTypeName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("EventTypeId !=  '{0}'", objge_EventTypeEN.EventTypeId);
 sbCondition.AppendFormat(" and EventTypeName = '{0}'", objge_EventTypeEN.EventTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_EventType
{
public virtual bool UpdRelaTabDate(string strEventTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 事件类型表(ge_EventType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_EventTypeBL
{
public static RelatedActions_ge_EventType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_EventTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_EventTypeDA ge_EventTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_EventTypeDA();
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
 public clsge_EventTypeBL()
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
if (string.IsNullOrEmpty(clsge_EventTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_EventTypeEN._ConnectString);
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
public static DataTable GetDataTable_ge_EventType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_EventTypeDA.GetDataTable_ge_EventType(strWhereCond);
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
objDT = ge_EventTypeDA.GetDataTable(strWhereCond);
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
objDT = ge_EventTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_EventTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_EventTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_EventTypeDA.GetDataTable_Top(objTopPara);
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
objDT = ge_EventTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_EventTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_EventTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrEventTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsge_EventTypeEN> GetObjLstByEventTypeIdLst(List<string> arrEventTypeIdLst)
{
List<clsge_EventTypeEN> arrObjLst = new List<clsge_EventTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrEventTypeIdLst, true);
 string strWhereCond = string.Format("EventTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_EventTypeEN objge_EventTypeEN = new clsge_EventTypeEN();
try
{
objge_EventTypeEN.EventTypeId = objRow[conge_EventType.EventTypeId].ToString().Trim(); //事件Id
objge_EventTypeEN.EventTypeName = objRow[conge_EventType.EventTypeName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeName].ToString().Trim(); //事件名称
objge_EventTypeEN.EventTypeEnName = objRow[conge_EventType.EventTypeEnName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeEnName].ToString().Trim(); //事件英文名称
objge_EventTypeEN.UpdDate = objRow[conge_EventType.UpdDate] == DBNull.Value ? null : objRow[conge_EventType.UpdDate].ToString().Trim(); //修改日期
objge_EventTypeEN.UpdUser = objRow[conge_EventType.UpdUser] == DBNull.Value ? null : objRow[conge_EventType.UpdUser].ToString().Trim(); //修改人
objge_EventTypeEN.Memo = objRow[conge_EventType.Memo] == DBNull.Value ? null : objRow[conge_EventType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_EventTypeEN.EventTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_EventTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrEventTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_EventTypeEN> GetObjLstByEventTypeIdLstCache(List<string> arrEventTypeIdLst)
{
string strKey = string.Format("{0}", clsge_EventTypeEN._CurrTabName);
List<clsge_EventTypeEN> arrge_EventTypeObjLstCache = GetObjLstCache();
IEnumerable <clsge_EventTypeEN> arrge_EventTypeObjLst_Sel =
arrge_EventTypeObjLstCache
.Where(x => arrEventTypeIdLst.Contains(x.EventTypeId));
return arrge_EventTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_EventTypeEN> GetObjLst(string strWhereCond)
{
List<clsge_EventTypeEN> arrObjLst = new List<clsge_EventTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_EventTypeEN objge_EventTypeEN = new clsge_EventTypeEN();
try
{
objge_EventTypeEN.EventTypeId = objRow[conge_EventType.EventTypeId].ToString().Trim(); //事件Id
objge_EventTypeEN.EventTypeName = objRow[conge_EventType.EventTypeName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeName].ToString().Trim(); //事件名称
objge_EventTypeEN.EventTypeEnName = objRow[conge_EventType.EventTypeEnName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeEnName].ToString().Trim(); //事件英文名称
objge_EventTypeEN.UpdDate = objRow[conge_EventType.UpdDate] == DBNull.Value ? null : objRow[conge_EventType.UpdDate].ToString().Trim(); //修改日期
objge_EventTypeEN.UpdUser = objRow[conge_EventType.UpdUser] == DBNull.Value ? null : objRow[conge_EventType.UpdUser].ToString().Trim(); //修改人
objge_EventTypeEN.Memo = objRow[conge_EventType.Memo] == DBNull.Value ? null : objRow[conge_EventType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_EventTypeEN.EventTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_EventTypeEN);
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
public static List<clsge_EventTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_EventTypeEN> arrObjLst = new List<clsge_EventTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_EventTypeEN objge_EventTypeEN = new clsge_EventTypeEN();
try
{
objge_EventTypeEN.EventTypeId = objRow[conge_EventType.EventTypeId].ToString().Trim(); //事件Id
objge_EventTypeEN.EventTypeName = objRow[conge_EventType.EventTypeName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeName].ToString().Trim(); //事件名称
objge_EventTypeEN.EventTypeEnName = objRow[conge_EventType.EventTypeEnName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeEnName].ToString().Trim(); //事件英文名称
objge_EventTypeEN.UpdDate = objRow[conge_EventType.UpdDate] == DBNull.Value ? null : objRow[conge_EventType.UpdDate].ToString().Trim(); //修改日期
objge_EventTypeEN.UpdUser = objRow[conge_EventType.UpdUser] == DBNull.Value ? null : objRow[conge_EventType.UpdUser].ToString().Trim(); //修改人
objge_EventTypeEN.Memo = objRow[conge_EventType.Memo] == DBNull.Value ? null : objRow[conge_EventType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_EventTypeEN.EventTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_EventTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_EventTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_EventTypeEN> GetSubObjLstCache(clsge_EventTypeEN objge_EventTypeCond)
{
List<clsge_EventTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsge_EventTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_EventType.AttributeName)
{
if (objge_EventTypeCond.IsUpdated(strFldName) == false) continue;
if (objge_EventTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_EventTypeCond[strFldName].ToString());
}
else
{
if (objge_EventTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_EventTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_EventTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_EventTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_EventTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_EventTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_EventTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_EventTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_EventTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_EventTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_EventTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_EventTypeCond[strFldName]));
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
public static List<clsge_EventTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_EventTypeEN> arrObjLst = new List<clsge_EventTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_EventTypeEN objge_EventTypeEN = new clsge_EventTypeEN();
try
{
objge_EventTypeEN.EventTypeId = objRow[conge_EventType.EventTypeId].ToString().Trim(); //事件Id
objge_EventTypeEN.EventTypeName = objRow[conge_EventType.EventTypeName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeName].ToString().Trim(); //事件名称
objge_EventTypeEN.EventTypeEnName = objRow[conge_EventType.EventTypeEnName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeEnName].ToString().Trim(); //事件英文名称
objge_EventTypeEN.UpdDate = objRow[conge_EventType.UpdDate] == DBNull.Value ? null : objRow[conge_EventType.UpdDate].ToString().Trim(); //修改日期
objge_EventTypeEN.UpdUser = objRow[conge_EventType.UpdUser] == DBNull.Value ? null : objRow[conge_EventType.UpdUser].ToString().Trim(); //修改人
objge_EventTypeEN.Memo = objRow[conge_EventType.Memo] == DBNull.Value ? null : objRow[conge_EventType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_EventTypeEN.EventTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_EventTypeEN);
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
public static List<clsge_EventTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_EventTypeEN> arrObjLst = new List<clsge_EventTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_EventTypeEN objge_EventTypeEN = new clsge_EventTypeEN();
try
{
objge_EventTypeEN.EventTypeId = objRow[conge_EventType.EventTypeId].ToString().Trim(); //事件Id
objge_EventTypeEN.EventTypeName = objRow[conge_EventType.EventTypeName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeName].ToString().Trim(); //事件名称
objge_EventTypeEN.EventTypeEnName = objRow[conge_EventType.EventTypeEnName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeEnName].ToString().Trim(); //事件英文名称
objge_EventTypeEN.UpdDate = objRow[conge_EventType.UpdDate] == DBNull.Value ? null : objRow[conge_EventType.UpdDate].ToString().Trim(); //修改日期
objge_EventTypeEN.UpdUser = objRow[conge_EventType.UpdUser] == DBNull.Value ? null : objRow[conge_EventType.UpdUser].ToString().Trim(); //修改人
objge_EventTypeEN.Memo = objRow[conge_EventType.Memo] == DBNull.Value ? null : objRow[conge_EventType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_EventTypeEN.EventTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_EventTypeEN);
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
List<clsge_EventTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_EventTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_EventTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_EventTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_EventTypeEN> arrObjLst = new List<clsge_EventTypeEN>(); 
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
	clsge_EventTypeEN objge_EventTypeEN = new clsge_EventTypeEN();
try
{
objge_EventTypeEN.EventTypeId = objRow[conge_EventType.EventTypeId].ToString().Trim(); //事件Id
objge_EventTypeEN.EventTypeName = objRow[conge_EventType.EventTypeName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeName].ToString().Trim(); //事件名称
objge_EventTypeEN.EventTypeEnName = objRow[conge_EventType.EventTypeEnName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeEnName].ToString().Trim(); //事件英文名称
objge_EventTypeEN.UpdDate = objRow[conge_EventType.UpdDate] == DBNull.Value ? null : objRow[conge_EventType.UpdDate].ToString().Trim(); //修改日期
objge_EventTypeEN.UpdUser = objRow[conge_EventType.UpdUser] == DBNull.Value ? null : objRow[conge_EventType.UpdUser].ToString().Trim(); //修改人
objge_EventTypeEN.Memo = objRow[conge_EventType.Memo] == DBNull.Value ? null : objRow[conge_EventType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_EventTypeEN.EventTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_EventTypeEN);
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
public static List<clsge_EventTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_EventTypeEN> arrObjLst = new List<clsge_EventTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_EventTypeEN objge_EventTypeEN = new clsge_EventTypeEN();
try
{
objge_EventTypeEN.EventTypeId = objRow[conge_EventType.EventTypeId].ToString().Trim(); //事件Id
objge_EventTypeEN.EventTypeName = objRow[conge_EventType.EventTypeName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeName].ToString().Trim(); //事件名称
objge_EventTypeEN.EventTypeEnName = objRow[conge_EventType.EventTypeEnName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeEnName].ToString().Trim(); //事件英文名称
objge_EventTypeEN.UpdDate = objRow[conge_EventType.UpdDate] == DBNull.Value ? null : objRow[conge_EventType.UpdDate].ToString().Trim(); //修改日期
objge_EventTypeEN.UpdUser = objRow[conge_EventType.UpdUser] == DBNull.Value ? null : objRow[conge_EventType.UpdUser].ToString().Trim(); //修改人
objge_EventTypeEN.Memo = objRow[conge_EventType.Memo] == DBNull.Value ? null : objRow[conge_EventType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_EventTypeEN.EventTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_EventTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_EventTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_EventTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_EventTypeEN> arrObjLst = new List<clsge_EventTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_EventTypeEN objge_EventTypeEN = new clsge_EventTypeEN();
try
{
objge_EventTypeEN.EventTypeId = objRow[conge_EventType.EventTypeId].ToString().Trim(); //事件Id
objge_EventTypeEN.EventTypeName = objRow[conge_EventType.EventTypeName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeName].ToString().Trim(); //事件名称
objge_EventTypeEN.EventTypeEnName = objRow[conge_EventType.EventTypeEnName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeEnName].ToString().Trim(); //事件英文名称
objge_EventTypeEN.UpdDate = objRow[conge_EventType.UpdDate] == DBNull.Value ? null : objRow[conge_EventType.UpdDate].ToString().Trim(); //修改日期
objge_EventTypeEN.UpdUser = objRow[conge_EventType.UpdUser] == DBNull.Value ? null : objRow[conge_EventType.UpdUser].ToString().Trim(); //修改人
objge_EventTypeEN.Memo = objRow[conge_EventType.Memo] == DBNull.Value ? null : objRow[conge_EventType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_EventTypeEN.EventTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_EventTypeEN);
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
public static List<clsge_EventTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_EventTypeEN> arrObjLst = new List<clsge_EventTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_EventTypeEN objge_EventTypeEN = new clsge_EventTypeEN();
try
{
objge_EventTypeEN.EventTypeId = objRow[conge_EventType.EventTypeId].ToString().Trim(); //事件Id
objge_EventTypeEN.EventTypeName = objRow[conge_EventType.EventTypeName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeName].ToString().Trim(); //事件名称
objge_EventTypeEN.EventTypeEnName = objRow[conge_EventType.EventTypeEnName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeEnName].ToString().Trim(); //事件英文名称
objge_EventTypeEN.UpdDate = objRow[conge_EventType.UpdDate] == DBNull.Value ? null : objRow[conge_EventType.UpdDate].ToString().Trim(); //修改日期
objge_EventTypeEN.UpdUser = objRow[conge_EventType.UpdUser] == DBNull.Value ? null : objRow[conge_EventType.UpdUser].ToString().Trim(); //修改人
objge_EventTypeEN.Memo = objRow[conge_EventType.Memo] == DBNull.Value ? null : objRow[conge_EventType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_EventTypeEN.EventTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_EventTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_EventTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_EventTypeEN> arrObjLst = new List<clsge_EventTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_EventTypeEN objge_EventTypeEN = new clsge_EventTypeEN();
try
{
objge_EventTypeEN.EventTypeId = objRow[conge_EventType.EventTypeId].ToString().Trim(); //事件Id
objge_EventTypeEN.EventTypeName = objRow[conge_EventType.EventTypeName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeName].ToString().Trim(); //事件名称
objge_EventTypeEN.EventTypeEnName = objRow[conge_EventType.EventTypeEnName] == DBNull.Value ? null : objRow[conge_EventType.EventTypeEnName].ToString().Trim(); //事件英文名称
objge_EventTypeEN.UpdDate = objRow[conge_EventType.UpdDate] == DBNull.Value ? null : objRow[conge_EventType.UpdDate].ToString().Trim(); //修改日期
objge_EventTypeEN.UpdUser = objRow[conge_EventType.UpdUser] == DBNull.Value ? null : objRow[conge_EventType.UpdUser].ToString().Trim(); //修改人
objge_EventTypeEN.Memo = objRow[conge_EventType.Memo] == DBNull.Value ? null : objRow[conge_EventType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_EventTypeEN.EventTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_EventTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_EventTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_EventType(ref clsge_EventTypeEN objge_EventTypeEN)
{
bool bolResult = ge_EventTypeDA.Getge_EventType(ref objge_EventTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strEventTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_EventTypeEN GetObjByEventTypeId(string strEventTypeId)
{
if (strEventTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strEventTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strEventTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strEventTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsge_EventTypeEN objge_EventTypeEN = ge_EventTypeDA.GetObjByEventTypeId(strEventTypeId);
return objge_EventTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_EventTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_EventTypeEN objge_EventTypeEN = ge_EventTypeDA.GetFirstObj(strWhereCond);
 return objge_EventTypeEN;
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
public static clsge_EventTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_EventTypeEN objge_EventTypeEN = ge_EventTypeDA.GetObjByDataRow(objRow);
 return objge_EventTypeEN;
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
public static clsge_EventTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_EventTypeEN objge_EventTypeEN = ge_EventTypeDA.GetObjByDataRow(objRow);
 return objge_EventTypeEN;
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
 /// <param name = "strEventTypeId">所给的关键字</param>
 /// <param name = "lstge_EventTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_EventTypeEN GetObjByEventTypeIdFromList(string strEventTypeId, List<clsge_EventTypeEN> lstge_EventTypeObjLst)
{
foreach (clsge_EventTypeEN objge_EventTypeEN in lstge_EventTypeObjLst)
{
if (objge_EventTypeEN.EventTypeId == strEventTypeId)
{
return objge_EventTypeEN;
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
 string strMaxEventTypeId;
 try
 {
 strMaxEventTypeId = clsge_EventTypeDA.GetMaxStrId();
 return strMaxEventTypeId;
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
 string strEventTypeId;
 try
 {
 strEventTypeId = new clsge_EventTypeDA().GetFirstID(strWhereCond);
 return strEventTypeId;
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
 arrList = ge_EventTypeDA.GetID(strWhereCond);
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
bool bolIsExist = ge_EventTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strEventTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strEventTypeId)
{
if (string.IsNullOrEmpty(strEventTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strEventTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ge_EventTypeDA.IsExist(strEventTypeId);
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
 bolIsExist = clsge_EventTypeDA.IsExistTable();
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
 bolIsExist = ge_EventTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objge_EventTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_EventTypeEN objge_EventTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_EventTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!事件名称 = [{0}]的数据已经存在!(in clsge_EventTypeBL.AddNewRecordBySql2)", objge_EventTypeEN.EventTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_EventTypeEN.EventTypeId) == true || clsge_EventTypeBL.IsExist(objge_EventTypeEN.EventTypeId) == true)
 {
     objge_EventTypeEN.EventTypeId = clsge_EventTypeBL.GetMaxStrId_S();
 }
bool bolResult = ge_EventTypeDA.AddNewRecordBySQL2(objge_EventTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_EventTypeBL.ReFreshCache();

if (clsge_EventTypeBL.relatedActions != null)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(objge_EventTypeEN.EventTypeId, "SetUpdDate");
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
 /// <param name = "objge_EventTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_EventTypeEN objge_EventTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_EventTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!事件名称 = [{0}]的数据已经存在!(in clsge_EventTypeBL.AddNewRecordBySql2WithReturnKey)", objge_EventTypeEN.EventTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_EventTypeEN.EventTypeId) == true || clsge_EventTypeBL.IsExist(objge_EventTypeEN.EventTypeId) == true)
 {
     objge_EventTypeEN.EventTypeId = clsge_EventTypeBL.GetMaxStrId_S();
 }
string strKey = ge_EventTypeDA.AddNewRecordBySQL2WithReturnKey(objge_EventTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_EventTypeBL.ReFreshCache();

if (clsge_EventTypeBL.relatedActions != null)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(objge_EventTypeEN.EventTypeId, "SetUpdDate");
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
 /// <param name = "objge_EventTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_EventTypeEN objge_EventTypeEN)
{
try
{
bool bolResult = ge_EventTypeDA.Update(objge_EventTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_EventTypeBL.ReFreshCache();

if (clsge_EventTypeBL.relatedActions != null)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(objge_EventTypeEN.EventTypeId, "SetUpdDate");
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
 /// <param name = "objge_EventTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_EventTypeEN objge_EventTypeEN)
{
 if (string.IsNullOrEmpty(objge_EventTypeEN.EventTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_EventTypeDA.UpdateBySql2(objge_EventTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_EventTypeBL.ReFreshCache();

if (clsge_EventTypeBL.relatedActions != null)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(objge_EventTypeEN.EventTypeId, "SetUpdDate");
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
 /// <param name = "strEventTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strEventTypeId)
{
try
{
 clsge_EventTypeEN objge_EventTypeEN = clsge_EventTypeBL.GetObjByEventTypeId(strEventTypeId);

if (clsge_EventTypeBL.relatedActions != null)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(objge_EventTypeEN.EventTypeId, "SetUpdDate");
}
if (objge_EventTypeEN != null)
{
int intRecNum = ge_EventTypeDA.DelRecord(strEventTypeId);
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
/// <param name="strEventTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strEventTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_EventTypeDA.GetSpecSQLObj();
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
//删除与表:[ge_EventType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_EventType.EventTypeId,
//strEventTypeId);
//        clsge_EventTypeBL.Delge_EventTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_EventTypeBL.DelRecord(strEventTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_EventTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strEventTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strEventTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strEventTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_EventTypeBL.relatedActions != null)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(strEventTypeId, "UpdRelaTabDate");
}
bool bolResult = ge_EventTypeDA.DelRecord(strEventTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrEventTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delge_EventTypes(List<string> arrEventTypeIdLst)
{
if (arrEventTypeIdLst.Count == 0) return 0;
try
{
if (clsge_EventTypeBL.relatedActions != null)
{
foreach (var strEventTypeId in arrEventTypeIdLst)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(strEventTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = ge_EventTypeDA.Delge_EventType(arrEventTypeIdLst);
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
public static int Delge_EventTypesByCond(string strWhereCond)
{
try
{
if (clsge_EventTypeBL.relatedActions != null)
{
List<string> arrEventTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strEventTypeId in arrEventTypeId)
{
clsge_EventTypeBL.relatedActions.UpdRelaTabDate(strEventTypeId, "UpdRelaTabDate");
}
}
int intRecNum = ge_EventTypeDA.Delge_EventType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_EventType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strEventTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strEventTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_EventTypeDA.GetSpecSQLObj();
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
//删除与表:[ge_EventType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_EventTypeBL.DelRecord(strEventTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_EventTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strEventTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_EventTypeENS">源对象</param>
 /// <param name = "objge_EventTypeENT">目标对象</param>
 public static void CopyTo(clsge_EventTypeEN objge_EventTypeENS, clsge_EventTypeEN objge_EventTypeENT)
{
try
{
objge_EventTypeENT.EventTypeId = objge_EventTypeENS.EventTypeId; //事件Id
objge_EventTypeENT.EventTypeName = objge_EventTypeENS.EventTypeName; //事件名称
objge_EventTypeENT.EventTypeEnName = objge_EventTypeENS.EventTypeEnName; //事件英文名称
objge_EventTypeENT.UpdDate = objge_EventTypeENS.UpdDate; //修改日期
objge_EventTypeENT.UpdUser = objge_EventTypeENS.UpdUser; //修改人
objge_EventTypeENT.Memo = objge_EventTypeENS.Memo; //备注
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
 /// <param name = "objge_EventTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsge_EventTypeEN objge_EventTypeEN)
{
try
{
objge_EventTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_EventTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_EventType.EventTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_EventTypeEN.EventTypeId = objge_EventTypeEN.EventTypeId; //事件Id
}
if (arrFldSet.Contains(conge_EventType.EventTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_EventTypeEN.EventTypeName = objge_EventTypeEN.EventTypeName == "[null]" ? null :  objge_EventTypeEN.EventTypeName; //事件名称
}
if (arrFldSet.Contains(conge_EventType.EventTypeEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_EventTypeEN.EventTypeEnName = objge_EventTypeEN.EventTypeEnName == "[null]" ? null :  objge_EventTypeEN.EventTypeEnName; //事件英文名称
}
if (arrFldSet.Contains(conge_EventType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_EventTypeEN.UpdDate = objge_EventTypeEN.UpdDate == "[null]" ? null :  objge_EventTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_EventType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_EventTypeEN.UpdUser = objge_EventTypeEN.UpdUser == "[null]" ? null :  objge_EventTypeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_EventType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_EventTypeEN.Memo = objge_EventTypeEN.Memo == "[null]" ? null :  objge_EventTypeEN.Memo; //备注
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
 /// <param name = "objge_EventTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_EventTypeEN objge_EventTypeEN)
{
try
{
if (objge_EventTypeEN.EventTypeName == "[null]") objge_EventTypeEN.EventTypeName = null; //事件名称
if (objge_EventTypeEN.EventTypeEnName == "[null]") objge_EventTypeEN.EventTypeEnName = null; //事件英文名称
if (objge_EventTypeEN.UpdDate == "[null]") objge_EventTypeEN.UpdDate = null; //修改日期
if (objge_EventTypeEN.UpdUser == "[null]") objge_EventTypeEN.UpdUser = null; //修改人
if (objge_EventTypeEN.Memo == "[null]") objge_EventTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsge_EventTypeEN objge_EventTypeEN)
{
 ge_EventTypeDA.CheckPropertyNew(objge_EventTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_EventTypeEN objge_EventTypeEN)
{
 ge_EventTypeDA.CheckProperty4Condition(objge_EventTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_EventTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[事件类型表]...","0");
List<clsge_EventTypeEN> arrge_EventTypeObjLst = GetAllge_EventTypeObjLstCache(); 
objDDL.DataValueField = conge_EventType.EventTypeId;
objDDL.DataTextField = conge_EventType.EventTypeName;
objDDL.DataSource = arrge_EventTypeObjLst;
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
if (clsge_EventTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_EventTypeBL没有刷新缓存机制(clsge_EventTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by EventTypeId");
//if (arrge_EventTypeObjLstCache == null)
//{
//arrge_EventTypeObjLstCache = ge_EventTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strEventTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_EventTypeEN GetObjByEventTypeIdCache(string strEventTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsge_EventTypeEN._CurrTabName);
List<clsge_EventTypeEN> arrge_EventTypeObjLstCache = GetObjLstCache();
IEnumerable <clsge_EventTypeEN> arrge_EventTypeObjLst_Sel =
arrge_EventTypeObjLstCache
.Where(x=> x.EventTypeId == strEventTypeId 
);
if (arrge_EventTypeObjLst_Sel.Count() == 0)
{
   clsge_EventTypeEN obj = clsge_EventTypeBL.GetObjByEventTypeId(strEventTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrge_EventTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strEventTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetEventTypeNameByEventTypeIdCache(string strEventTypeId)
{
if (string.IsNullOrEmpty(strEventTypeId) == true) return "";
//获取缓存中的对象列表
clsge_EventTypeEN objge_EventType = GetObjByEventTypeIdCache(strEventTypeId);
if (objge_EventType == null) return "";
return objge_EventType.EventTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strEventTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByEventTypeIdCache(string strEventTypeId)
{
if (string.IsNullOrEmpty(strEventTypeId) == true) return "";
//获取缓存中的对象列表
clsge_EventTypeEN objge_EventType = GetObjByEventTypeIdCache(strEventTypeId);
if (objge_EventType == null) return "";
return objge_EventType.EventTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_EventTypeEN> GetAllge_EventTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsge_EventTypeEN> arrge_EventTypeObjLstCache = GetObjLstCache(); 
return arrge_EventTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_EventTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsge_EventTypeEN._CurrTabName);
List<clsge_EventTypeEN> arrge_EventTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrge_EventTypeObjLstCache;
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
string strKey = string.Format("{0}", clsge_EventTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsge_EventTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_EventTypeEN._RefreshTimeLst.Count == 0) return "";
return clsge_EventTypeEN._RefreshTimeLst[clsge_EventTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsge_EventTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsge_EventTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsge_EventTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_EventTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_EventType(事件类型表)
 /// 唯一性条件:EventTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_EventTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_EventTypeEN objge_EventTypeEN)
{
//检测记录是否存在
string strResult = ge_EventTypeDA.GetUniCondStr(objge_EventTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strEventTypeId)
{
if (strInFldName != conge_EventType.EventTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_EventType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_EventType.AttributeName));
throw new Exception(strMsg);
}
var objge_EventType = clsge_EventTypeBL.GetObjByEventTypeIdCache(strEventTypeId);
if (objge_EventType == null) return "";
return objge_EventType[strOutFldName].ToString();
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
int intRecCount = clsge_EventTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsge_EventTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_EventTypeDA.GetRecCount();
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
int intRecCount = clsge_EventTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_EventTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_EventTypeEN objge_EventTypeCond)
{
List<clsge_EventTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsge_EventTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_EventType.AttributeName)
{
if (objge_EventTypeCond.IsUpdated(strFldName) == false) continue;
if (objge_EventTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_EventTypeCond[strFldName].ToString());
}
else
{
if (objge_EventTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_EventTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_EventTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_EventTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_EventTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_EventTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_EventTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_EventTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_EventTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_EventTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_EventTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_EventTypeCond[strFldName]));
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
 List<string> arrList = clsge_EventTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_EventTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_EventTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_EventTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_EventTypeDA.SetFldValue(clsge_EventTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_EventTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_EventTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_EventTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_EventTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_EventType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**事件Id*/ 
 strCreateTabCode.Append(" EventTypeId char(4) primary key, "); 
 // /**事件名称*/ 
 strCreateTabCode.Append(" EventTypeName varchar(100) Null, "); 
 // /**事件英文名称*/ 
 strCreateTabCode.Append(" EventTypeEnName varchar(100) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 事件类型表(ge_EventType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_EventType : clsCommFun4BL
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
clsge_EventTypeBL.ReFreshThisCache();
}
}

}