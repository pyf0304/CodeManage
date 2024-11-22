﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEventTabBL
 表名:EventTab(00050031)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:48:36
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class  clsEventTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngEventId">表关键字</param>
 /// <returns>表对象</returns>
public static clsEventTabEN GetObj(this K_EventId_EventTab myKey)
{
clsEventTabEN objEventTabEN = clsEventTabBL.EventTabDA.GetObjByEventId(myKey.Value);
return objEventTabEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsEventTabEN objEventTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objEventTabEN) == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}],ColName = [{1}],OpdType = [{2}]的数据已经存在!(in clsEventTabBL.AddNewRecord)", objEventTabEN.TabName,objEventTabEN.ColName,objEventTabEN.OpdType);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsEventTabBL.EventTabDA.AddNewRecordBySQL2(objEventTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabBL.ReFreshCache();

if (clsEventTabBL.relatedActions != null)
{
clsEventTabBL.relatedActions.UpdRelaTabDate(objEventTabEN.EventId, "SetUpdDate");
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
public static bool AddRecordEx(this clsEventTabEN objEventTabEN, bool bolIsNeedCheckUniqueness = true)
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
objEventTabEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objEventTabEN.CheckUniqueness() == false)
{
strMsg = string.Format("(表名(TabName)=[{0}],ColName(ColName)=[{1}],OpdType(OpdType)=[{2}])已经存在,不能重复!", objEventTabEN.TabName, objEventTabEN.ColName, objEventTabEN.OpdType);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objEventTabEN.AddNewRecord();
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
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsEventTabEN objEventTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objEventTabEN) == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}],ColName = [{1}],OpdType = [{2}]的数据已经存在!(in clsEventTabBL.AddNewRecordWithReturnKey)", objEventTabEN.TabName,objEventTabEN.ColName,objEventTabEN.OpdType);
throw new Exception(strMsg);
}
try
{
string strKey = clsEventTabBL.EventTabDA.AddNewRecordBySQL2WithReturnKey(objEventTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabBL.ReFreshCache();

if (clsEventTabBL.relatedActions != null)
{
clsEventTabBL.relatedActions.UpdRelaTabDate(objEventTabEN.EventId, "SetUpdDate");
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
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetEventId(this clsEventTabEN objEventTabEN, long lngEventId, string strComparisonOp="")
	{
objEventTabEN.EventId = lngEventId; //EventId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.EventId) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.EventId, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.EventId] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetTabName(this clsEventTabEN objEventTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, conEventTab.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, conEventTab.TabName);
}
objEventTabEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.TabName) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.TabName, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.TabName] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetColName(this clsEventTabEN objEventTabEN, string strColName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strColName, conEventTab.ColName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strColName, 30, conEventTab.ColName);
}
objEventTabEN.ColName = strColName; //ColName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.ColName) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.ColName, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.ColName] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetRecordId(this clsEventTabEN objEventTabEN, string strRecordId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecordId, 30, conEventTab.RecordId);
}
objEventTabEN.RecordId = strRecordId; //RecordId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.RecordId) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.RecordId, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.RecordId] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetInitValue(this clsEventTabEN objEventTabEN, string strInitValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInitValue, 1000, conEventTab.InitValue);
}
objEventTabEN.InitValue = strInitValue; //初始值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.InitValue) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.InitValue, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.InitValue] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetUpdateValue(this clsEventTabEN objEventTabEN, string strUpdateValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdateValue, 1000, conEventTab.UpdateValue);
}
objEventTabEN.UpdateValue = strUpdateValue; //UpdateValue
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.UpdateValue) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.UpdateValue, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.UpdateValue] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetUpdDate(this clsEventTabEN objEventTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conEventTab.UpdDate);
}
objEventTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.UpdDate) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.UpdDate, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.UpdDate] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetUpdTime(this clsEventTabEN objEventTabEN, string strUpdTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdTime, 6, conEventTab.UpdTime);
}
objEventTabEN.UpdTime = strUpdTime; //修改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.UpdTime) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.UpdTime, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.UpdTime] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetUpdNameId(this clsEventTabEN objEventTabEN, string strUpdNameId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdNameId, 18, conEventTab.UpdNameId);
}
objEventTabEN.UpdNameId = strUpdNameId; //UpdNameId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.UpdNameId) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.UpdNameId, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.UpdNameId] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetOpdType(this clsEventTabEN objEventTabEN, string strOpdType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpdType, 20, conEventTab.OpdType);
}
objEventTabEN.OpdType = strOpdType; //OpdType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.OpdType) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.OpdType, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.OpdType] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetMemo(this clsEventTabEN objEventTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conEventTab.Memo);
}
objEventTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.Memo) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.Memo, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.Memo] = strComparisonOp;
}
}
return objEventTabEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objEventTabEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsEventTabEN objEventTabEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objEventTabEN.CheckPropertyNew();
clsEventTabEN objEventTabCond = new clsEventTabEN();
string strCondition = objEventTabCond
.SetEventId(objEventTabEN.EventId, "<>")
.SetTabName(objEventTabEN.TabName, "=")
.SetColName(objEventTabEN.ColName, "=")
.SetOpdType(objEventTabEN.OpdType, "=")
.GetCombineCondition();
objEventTabEN._IsCheckProperty = true;
bool bolIsExist = clsEventTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TabName_ColName_OpdType)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objEventTabEN.Update();
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
 /// <param name = "objEventTab">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsEventTabEN objEventTab)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsEventTabEN objEventTabCond = new clsEventTabEN();
string strCondition = objEventTabCond
.SetTabName(objEventTab.TabName, "=")
.SetColName(objEventTab.ColName, "=")
.SetOpdType(objEventTab.OpdType, "=")
.GetCombineCondition();
objEventTab._IsCheckProperty = true;
bool bolIsExist = clsEventTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objEventTab.EventId = clsEventTabBL.GetFirstID_S(strCondition);
objEventTab.UpdateWithCondition(strCondition);
}
else
{
objEventTab.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsEventTabEN objEventTabEN)
{
 if (objEventTabEN.EventId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsEventTabBL.EventTabDA.UpdateBySql2(objEventTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabBL.ReFreshCache();

if (clsEventTabBL.relatedActions != null)
{
clsEventTabBL.relatedActions.UpdRelaTabDate(objEventTabEN.EventId, "SetUpdDate");
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
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsEventTabEN objEventTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objEventTabEN.EventId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsEventTabBL.EventTabDA.UpdateBySql2(objEventTabEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabBL.ReFreshCache();

if (clsEventTabBL.relatedActions != null)
{
clsEventTabBL.relatedActions.UpdRelaTabDate(objEventTabEN.EventId, "SetUpdDate");
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
 /// <param name = "objEventTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsEventTabEN objEventTabEN, string strWhereCond)
{
try
{
bool bolResult = clsEventTabBL.EventTabDA.UpdateBySqlWithCondition(objEventTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabBL.ReFreshCache();

if (clsEventTabBL.relatedActions != null)
{
clsEventTabBL.relatedActions.UpdRelaTabDate(objEventTabEN.EventId, "SetUpdDate");
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
 /// <param name = "objEventTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsEventTabEN objEventTabEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsEventTabBL.EventTabDA.UpdateBySqlWithConditionTransaction(objEventTabEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabBL.ReFreshCache();

if (clsEventTabBL.relatedActions != null)
{
clsEventTabBL.relatedActions.UpdRelaTabDate(objEventTabEN.EventId, "SetUpdDate");
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
 /// <param name = "lngEventId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsEventTabEN objEventTabEN)
{
try
{
int intRecNum = clsEventTabBL.EventTabDA.DelRecord(objEventTabEN.EventId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabBL.ReFreshCache();

if (clsEventTabBL.relatedActions != null)
{
clsEventTabBL.relatedActions.UpdRelaTabDate(objEventTabEN.EventId, "SetUpdDate");
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
 /// <param name = "objEventTabENS">源对象</param>
 /// <param name = "objEventTabENT">目标对象</param>
 public static void CopyTo(this clsEventTabEN objEventTabENS, clsEventTabEN objEventTabENT)
{
try
{
objEventTabENT.EventId = objEventTabENS.EventId; //EventId
objEventTabENT.TabName = objEventTabENS.TabName; //表名
objEventTabENT.ColName = objEventTabENS.ColName; //ColName
objEventTabENT.RecordId = objEventTabENS.RecordId; //RecordId
objEventTabENT.InitValue = objEventTabENS.InitValue; //初始值
objEventTabENT.UpdateValue = objEventTabENS.UpdateValue; //UpdateValue
objEventTabENT.UpdDate = objEventTabENS.UpdDate; //修改日期
objEventTabENT.UpdTime = objEventTabENS.UpdTime; //修改时间
objEventTabENT.UpdNameId = objEventTabENS.UpdNameId; //UpdNameId
objEventTabENT.OpdType = objEventTabENS.OpdType; //OpdType
objEventTabENT.Memo = objEventTabENS.Memo; //说明
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
 /// <param name = "objEventTabENS">源对象</param>
 /// <returns>目标对象=>clsEventTabEN:objEventTabENT</returns>
 public static clsEventTabEN CopyTo(this clsEventTabEN objEventTabENS)
{
try
{
 clsEventTabEN objEventTabENT = new clsEventTabEN()
{
EventId = objEventTabENS.EventId, //EventId
TabName = objEventTabENS.TabName, //表名
ColName = objEventTabENS.ColName, //ColName
RecordId = objEventTabENS.RecordId, //RecordId
InitValue = objEventTabENS.InitValue, //初始值
UpdateValue = objEventTabENS.UpdateValue, //UpdateValue
UpdDate = objEventTabENS.UpdDate, //修改日期
UpdTime = objEventTabENS.UpdTime, //修改时间
UpdNameId = objEventTabENS.UpdNameId, //UpdNameId
OpdType = objEventTabENS.OpdType, //OpdType
Memo = objEventTabENS.Memo, //说明
};
 return objEventTabENT;
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
public static void CheckPropertyNew(this clsEventTabEN objEventTabEN)
{
 clsEventTabBL.EventTabDA.CheckPropertyNew(objEventTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsEventTabEN objEventTabEN)
{
 clsEventTabBL.EventTabDA.CheckProperty4Condition(objEventTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsEventTabEN objEventTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objEventTabCond.IsUpdated(conEventTab.EventId) == true)
{
string strComparisonOpEventId = objEventTabCond.dicFldComparisonOp[conEventTab.EventId];
strWhereCond += string.Format(" And {0} {2} {1}", conEventTab.EventId, objEventTabCond.EventId, strComparisonOpEventId);
}
if (objEventTabCond.IsUpdated(conEventTab.TabName) == true)
{
string strComparisonOpTabName = objEventTabCond.dicFldComparisonOp[conEventTab.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.TabName, objEventTabCond.TabName, strComparisonOpTabName);
}
if (objEventTabCond.IsUpdated(conEventTab.ColName) == true)
{
string strComparisonOpColName = objEventTabCond.dicFldComparisonOp[conEventTab.ColName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.ColName, objEventTabCond.ColName, strComparisonOpColName);
}
if (objEventTabCond.IsUpdated(conEventTab.RecordId) == true)
{
string strComparisonOpRecordId = objEventTabCond.dicFldComparisonOp[conEventTab.RecordId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.RecordId, objEventTabCond.RecordId, strComparisonOpRecordId);
}
if (objEventTabCond.IsUpdated(conEventTab.InitValue) == true)
{
string strComparisonOpInitValue = objEventTabCond.dicFldComparisonOp[conEventTab.InitValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.InitValue, objEventTabCond.InitValue, strComparisonOpInitValue);
}
if (objEventTabCond.IsUpdated(conEventTab.UpdateValue) == true)
{
string strComparisonOpUpdateValue = objEventTabCond.dicFldComparisonOp[conEventTab.UpdateValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.UpdateValue, objEventTabCond.UpdateValue, strComparisonOpUpdateValue);
}
if (objEventTabCond.IsUpdated(conEventTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objEventTabCond.dicFldComparisonOp[conEventTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.UpdDate, objEventTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objEventTabCond.IsUpdated(conEventTab.UpdTime) == true)
{
string strComparisonOpUpdTime = objEventTabCond.dicFldComparisonOp[conEventTab.UpdTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.UpdTime, objEventTabCond.UpdTime, strComparisonOpUpdTime);
}
if (objEventTabCond.IsUpdated(conEventTab.UpdNameId) == true)
{
string strComparisonOpUpdNameId = objEventTabCond.dicFldComparisonOp[conEventTab.UpdNameId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.UpdNameId, objEventTabCond.UpdNameId, strComparisonOpUpdNameId);
}
if (objEventTabCond.IsUpdated(conEventTab.OpdType) == true)
{
string strComparisonOpOpdType = objEventTabCond.dicFldComparisonOp[conEventTab.OpdType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.OpdType, objEventTabCond.OpdType, strComparisonOpOpdType);
}
if (objEventTabCond.IsUpdated(conEventTab.Memo) == true)
{
string strComparisonOpMemo = objEventTabCond.dicFldComparisonOp[conEventTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.Memo, objEventTabCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--EventTab(事件), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TabName_ColName_OpdType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objEventTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsEventTabEN objEventTabEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objEventTabEN == null) return true;
if (objEventTabEN.EventId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabName = '{0}'", objEventTabEN.TabName);
 sbCondition.AppendFormat(" and ColName = '{0}'", objEventTabEN.ColName);
 if (objEventTabEN.OpdType == null)
{
 sbCondition.AppendFormat(" and OpdType is null", objEventTabEN.OpdType);
}
else
{
 sbCondition.AppendFormat(" and OpdType = '{0}'", objEventTabEN.OpdType);
}
if (clsEventTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("EventId !=  {0}", objEventTabEN.EventId);
 sbCondition.AppendFormat(" and TabName = '{0}'", objEventTabEN.TabName);
 sbCondition.AppendFormat(" and ColName = '{0}'", objEventTabEN.ColName);
 sbCondition.AppendFormat(" and OpdType = '{0}'", objEventTabEN.OpdType);
if (clsEventTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--EventTab(事件), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabName_ColName_OpdType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objEventTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsEventTabEN objEventTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objEventTabEN == null) return "";
if (objEventTabEN.EventId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabName = '{0}'", objEventTabEN.TabName);
 sbCondition.AppendFormat(" and ColName = '{0}'", objEventTabEN.ColName);
 if (objEventTabEN.OpdType == null)
{
 sbCondition.AppendFormat(" and OpdType is null", objEventTabEN.OpdType);
}
else
{
 sbCondition.AppendFormat(" and OpdType = '{0}'", objEventTabEN.OpdType);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("EventId !=  {0}", objEventTabEN.EventId);
 sbCondition.AppendFormat(" and TabName = '{0}'", objEventTabEN.TabName);
 sbCondition.AppendFormat(" and ColName = '{0}'", objEventTabEN.ColName);
 sbCondition.AppendFormat(" and OpdType = '{0}'", objEventTabEN.OpdType);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_EventTab
{
public virtual bool UpdRelaTabDate(long lngEventId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 事件(EventTab)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsEventTabBL
{
public static RelatedActions_EventTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsEventTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsEventTabDA EventTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsEventTabDA();
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
 public clsEventTabBL()
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
if (string.IsNullOrEmpty(clsEventTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsEventTabEN._ConnectString);
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
public static DataTable GetDataTable_EventTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = EventTabDA.GetDataTable_EventTab(strWhereCond);
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
objDT = EventTabDA.GetDataTable(strWhereCond);
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
objDT = EventTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = EventTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = EventTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = EventTabDA.GetDataTable_Top(objTopPara);
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
objDT = EventTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = EventTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = EventTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrEventIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsEventTabEN> GetObjLstByEventIdLst(List<long> arrEventIdLst)
{
List<clsEventTabEN> arrObjLst = new List<clsEventTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrEventIdLst);
 string strWhereCond = string.Format("EventId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEventTabEN objEventTabEN = new clsEventTabEN();
try
{
objEventTabEN.EventId = Int32.Parse(objRow[conEventTab.EventId].ToString().Trim()); //EventId
objEventTabEN.TabName = objRow[conEventTab.TabName].ToString().Trim(); //表名
objEventTabEN.ColName = objRow[conEventTab.ColName].ToString().Trim(); //ColName
objEventTabEN.RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(); //RecordId
objEventTabEN.InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(); //初始值
objEventTabEN.UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue
objEventTabEN.UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(); //修改日期
objEventTabEN.UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(); //修改时间
objEventTabEN.UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId
objEventTabEN.OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(); //OpdType
objEventTabEN.Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEventTabEN.EventId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEventTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrEventIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsEventTabEN> GetObjLstByEventIdLstCache(List<long> arrEventIdLst)
{
string strKey = string.Format("{0}", clsEventTabEN._CurrTabName);
List<clsEventTabEN> arrEventTabObjLstCache = GetObjLstCache();
IEnumerable <clsEventTabEN> arrEventTabObjLst_Sel =
arrEventTabObjLstCache
.Where(x => arrEventIdLst.Contains(x.EventId));
return arrEventTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsEventTabEN> GetObjLst(string strWhereCond)
{
List<clsEventTabEN> arrObjLst = new List<clsEventTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEventTabEN objEventTabEN = new clsEventTabEN();
try
{
objEventTabEN.EventId = Int32.Parse(objRow[conEventTab.EventId].ToString().Trim()); //EventId
objEventTabEN.TabName = objRow[conEventTab.TabName].ToString().Trim(); //表名
objEventTabEN.ColName = objRow[conEventTab.ColName].ToString().Trim(); //ColName
objEventTabEN.RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(); //RecordId
objEventTabEN.InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(); //初始值
objEventTabEN.UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue
objEventTabEN.UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(); //修改日期
objEventTabEN.UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(); //修改时间
objEventTabEN.UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId
objEventTabEN.OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(); //OpdType
objEventTabEN.Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEventTabEN.EventId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEventTabEN);
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
public static List<clsEventTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsEventTabEN> arrObjLst = new List<clsEventTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEventTabEN objEventTabEN = new clsEventTabEN();
try
{
objEventTabEN.EventId = Int32.Parse(objRow[conEventTab.EventId].ToString().Trim()); //EventId
objEventTabEN.TabName = objRow[conEventTab.TabName].ToString().Trim(); //表名
objEventTabEN.ColName = objRow[conEventTab.ColName].ToString().Trim(); //ColName
objEventTabEN.RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(); //RecordId
objEventTabEN.InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(); //初始值
objEventTabEN.UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue
objEventTabEN.UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(); //修改日期
objEventTabEN.UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(); //修改时间
objEventTabEN.UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId
objEventTabEN.OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(); //OpdType
objEventTabEN.Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEventTabEN.EventId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEventTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objEventTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsEventTabEN> GetSubObjLstCache(clsEventTabEN objEventTabCond)
{
List<clsEventTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsEventTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conEventTab.AttributeName)
{
if (objEventTabCond.IsUpdated(strFldName) == false) continue;
if (objEventTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objEventTabCond[strFldName].ToString());
}
else
{
if (objEventTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objEventTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objEventTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objEventTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objEventTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objEventTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objEventTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objEventTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objEventTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objEventTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objEventTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objEventTabCond[strFldName]));
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
public static List<clsEventTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsEventTabEN> arrObjLst = new List<clsEventTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEventTabEN objEventTabEN = new clsEventTabEN();
try
{
objEventTabEN.EventId = Int32.Parse(objRow[conEventTab.EventId].ToString().Trim()); //EventId
objEventTabEN.TabName = objRow[conEventTab.TabName].ToString().Trim(); //表名
objEventTabEN.ColName = objRow[conEventTab.ColName].ToString().Trim(); //ColName
objEventTabEN.RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(); //RecordId
objEventTabEN.InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(); //初始值
objEventTabEN.UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue
objEventTabEN.UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(); //修改日期
objEventTabEN.UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(); //修改时间
objEventTabEN.UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId
objEventTabEN.OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(); //OpdType
objEventTabEN.Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEventTabEN.EventId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEventTabEN);
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
public static List<clsEventTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsEventTabEN> arrObjLst = new List<clsEventTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEventTabEN objEventTabEN = new clsEventTabEN();
try
{
objEventTabEN.EventId = Int32.Parse(objRow[conEventTab.EventId].ToString().Trim()); //EventId
objEventTabEN.TabName = objRow[conEventTab.TabName].ToString().Trim(); //表名
objEventTabEN.ColName = objRow[conEventTab.ColName].ToString().Trim(); //ColName
objEventTabEN.RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(); //RecordId
objEventTabEN.InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(); //初始值
objEventTabEN.UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue
objEventTabEN.UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(); //修改日期
objEventTabEN.UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(); //修改时间
objEventTabEN.UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId
objEventTabEN.OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(); //OpdType
objEventTabEN.Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEventTabEN.EventId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEventTabEN);
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
List<clsEventTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsEventTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsEventTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsEventTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsEventTabEN> arrObjLst = new List<clsEventTabEN>(); 
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
	clsEventTabEN objEventTabEN = new clsEventTabEN();
try
{
objEventTabEN.EventId = Int32.Parse(objRow[conEventTab.EventId].ToString().Trim()); //EventId
objEventTabEN.TabName = objRow[conEventTab.TabName].ToString().Trim(); //表名
objEventTabEN.ColName = objRow[conEventTab.ColName].ToString().Trim(); //ColName
objEventTabEN.RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(); //RecordId
objEventTabEN.InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(); //初始值
objEventTabEN.UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue
objEventTabEN.UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(); //修改日期
objEventTabEN.UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(); //修改时间
objEventTabEN.UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId
objEventTabEN.OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(); //OpdType
objEventTabEN.Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEventTabEN.EventId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEventTabEN);
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
public static List<clsEventTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsEventTabEN> arrObjLst = new List<clsEventTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEventTabEN objEventTabEN = new clsEventTabEN();
try
{
objEventTabEN.EventId = Int32.Parse(objRow[conEventTab.EventId].ToString().Trim()); //EventId
objEventTabEN.TabName = objRow[conEventTab.TabName].ToString().Trim(); //表名
objEventTabEN.ColName = objRow[conEventTab.ColName].ToString().Trim(); //ColName
objEventTabEN.RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(); //RecordId
objEventTabEN.InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(); //初始值
objEventTabEN.UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue
objEventTabEN.UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(); //修改日期
objEventTabEN.UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(); //修改时间
objEventTabEN.UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId
objEventTabEN.OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(); //OpdType
objEventTabEN.Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEventTabEN.EventId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEventTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsEventTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsEventTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsEventTabEN> arrObjLst = new List<clsEventTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEventTabEN objEventTabEN = new clsEventTabEN();
try
{
objEventTabEN.EventId = Int32.Parse(objRow[conEventTab.EventId].ToString().Trim()); //EventId
objEventTabEN.TabName = objRow[conEventTab.TabName].ToString().Trim(); //表名
objEventTabEN.ColName = objRow[conEventTab.ColName].ToString().Trim(); //ColName
objEventTabEN.RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(); //RecordId
objEventTabEN.InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(); //初始值
objEventTabEN.UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue
objEventTabEN.UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(); //修改日期
objEventTabEN.UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(); //修改时间
objEventTabEN.UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId
objEventTabEN.OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(); //OpdType
objEventTabEN.Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEventTabEN.EventId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEventTabEN);
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
public static List<clsEventTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsEventTabEN> arrObjLst = new List<clsEventTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEventTabEN objEventTabEN = new clsEventTabEN();
try
{
objEventTabEN.EventId = Int32.Parse(objRow[conEventTab.EventId].ToString().Trim()); //EventId
objEventTabEN.TabName = objRow[conEventTab.TabName].ToString().Trim(); //表名
objEventTabEN.ColName = objRow[conEventTab.ColName].ToString().Trim(); //ColName
objEventTabEN.RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(); //RecordId
objEventTabEN.InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(); //初始值
objEventTabEN.UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue
objEventTabEN.UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(); //修改日期
objEventTabEN.UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(); //修改时间
objEventTabEN.UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId
objEventTabEN.OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(); //OpdType
objEventTabEN.Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEventTabEN.EventId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEventTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsEventTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsEventTabEN> arrObjLst = new List<clsEventTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEventTabEN objEventTabEN = new clsEventTabEN();
try
{
objEventTabEN.EventId = Int32.Parse(objRow[conEventTab.EventId].ToString().Trim()); //EventId
objEventTabEN.TabName = objRow[conEventTab.TabName].ToString().Trim(); //表名
objEventTabEN.ColName = objRow[conEventTab.ColName].ToString().Trim(); //ColName
objEventTabEN.RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(); //RecordId
objEventTabEN.InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(); //初始值
objEventTabEN.UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue
objEventTabEN.UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(); //修改日期
objEventTabEN.UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(); //修改时间
objEventTabEN.UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId
objEventTabEN.OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(); //OpdType
objEventTabEN.Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEventTabEN.EventId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEventTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objEventTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetEventTab(ref clsEventTabEN objEventTabEN)
{
bool bolResult = EventTabDA.GetEventTab(ref objEventTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngEventId">表关键字</param>
 /// <returns>表对象</returns>
public static clsEventTabEN GetObjByEventId(long lngEventId)
{
clsEventTabEN objEventTabEN = EventTabDA.GetObjByEventId(lngEventId);
return objEventTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsEventTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsEventTabEN objEventTabEN = EventTabDA.GetFirstObj(strWhereCond);
 return objEventTabEN;
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
public static clsEventTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsEventTabEN objEventTabEN = EventTabDA.GetObjByDataRow(objRow);
 return objEventTabEN;
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
public static clsEventTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsEventTabEN objEventTabEN = EventTabDA.GetObjByDataRow(objRow);
 return objEventTabEN;
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
 /// <param name = "lngEventId">所给的关键字</param>
 /// <param name = "lstEventTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsEventTabEN GetObjByEventIdFromList(long lngEventId, List<clsEventTabEN> lstEventTabObjLst)
{
foreach (clsEventTabEN objEventTabEN in lstEventTabObjLst)
{
if (objEventTabEN.EventId == lngEventId)
{
return objEventTabEN;
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
 long lngEventId;
 try
 {
 lngEventId = new clsEventTabDA().GetFirstID(strWhereCond);
 return lngEventId;
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
 arrList = EventTabDA.GetID(strWhereCond);
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
bool bolIsExist = EventTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngEventId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngEventId)
{
//检测记录是否存在
bool bolIsExist = EventTabDA.IsExist(lngEventId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngEventId">EventId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngEventId, string strOpUser)
{
clsEventTabEN objEventTabEN = clsEventTabBL.GetObjByEventId(lngEventId);
objEventTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsEventTabBL.UpdateBySql2(objEventTabEN);
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
 bolIsExist = clsEventTabDA.IsExistTable();
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
 bolIsExist = EventTabDA.IsExistTable(strTabName);
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
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsEventTabEN objEventTabEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objEventTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}],ColName = [{1}],OpdType = [{2}]的数据已经存在!(in clsEventTabBL.AddNewRecordBySql2)", objEventTabEN.TabName,objEventTabEN.ColName,objEventTabEN.OpdType);
throw new Exception(strMsg);
}
try
{
bool bolResult = EventTabDA.AddNewRecordBySQL2(objEventTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabBL.ReFreshCache();

if (clsEventTabBL.relatedActions != null)
{
clsEventTabBL.relatedActions.UpdRelaTabDate(objEventTabEN.EventId, "SetUpdDate");
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
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsEventTabEN objEventTabEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objEventTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}],ColName = [{1}],OpdType = [{2}]的数据已经存在!(in clsEventTabBL.AddNewRecordBySql2WithReturnKey)", objEventTabEN.TabName,objEventTabEN.ColName,objEventTabEN.OpdType);
throw new Exception(strMsg);
}
try
{
string strKey = EventTabDA.AddNewRecordBySQL2WithReturnKey(objEventTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabBL.ReFreshCache();

if (clsEventTabBL.relatedActions != null)
{
clsEventTabBL.relatedActions.UpdRelaTabDate(objEventTabEN.EventId, "SetUpdDate");
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
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsEventTabEN objEventTabEN)
{
try
{
bool bolResult = EventTabDA.Update(objEventTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabBL.ReFreshCache();

if (clsEventTabBL.relatedActions != null)
{
clsEventTabBL.relatedActions.UpdRelaTabDate(objEventTabEN.EventId, "SetUpdDate");
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
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsEventTabEN objEventTabEN)
{
 if (objEventTabEN.EventId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = EventTabDA.UpdateBySql2(objEventTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabBL.ReFreshCache();

if (clsEventTabBL.relatedActions != null)
{
clsEventTabBL.relatedActions.UpdRelaTabDate(objEventTabEN.EventId, "SetUpdDate");
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
 /// <param name = "lngEventId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngEventId)
{
try
{
 clsEventTabEN objEventTabEN = clsEventTabBL.GetObjByEventId(lngEventId);

if (clsEventTabBL.relatedActions != null)
{
clsEventTabBL.relatedActions.UpdRelaTabDate(objEventTabEN.EventId, "SetUpdDate");
}
if (objEventTabEN != null)
{
int intRecNum = EventTabDA.DelRecord(lngEventId);
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
/// <param name="lngEventId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngEventId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsEventTabDA.GetSpecSQLObj();
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
//删除与表:[EventTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conEventTab.EventId,
//lngEventId);
//        clsEventTabBL.DelEventTabsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsEventTabBL.DelRecord(lngEventId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsEventTabBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngEventId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngEventId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngEventId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsEventTabBL.relatedActions != null)
{
clsEventTabBL.relatedActions.UpdRelaTabDate(lngEventId, "UpdRelaTabDate");
}
bool bolResult = EventTabDA.DelRecord(lngEventId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrEventIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelEventTabs(List<string> arrEventIdLst)
{
if (arrEventIdLst.Count == 0) return 0;
try
{
if (clsEventTabBL.relatedActions != null)
{
foreach (var strEventId in arrEventIdLst)
{
long lngEventId = long.Parse(strEventId);
clsEventTabBL.relatedActions.UpdRelaTabDate(lngEventId, "UpdRelaTabDate");
}
}
int intDelRecNum = EventTabDA.DelEventTab(arrEventIdLst);
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
public static int DelEventTabsByCond(string strWhereCond)
{
try
{
if (clsEventTabBL.relatedActions != null)
{
List<string> arrEventId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strEventId in arrEventId)
{
long lngEventId = long.Parse(strEventId);
clsEventTabBL.relatedActions.UpdRelaTabDate(lngEventId, "UpdRelaTabDate");
}
}
int intRecNum = EventTabDA.DelEventTab(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[EventTab]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngEventId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngEventId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsEventTabDA.GetSpecSQLObj();
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
//删除与表:[EventTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsEventTabBL.DelRecord(lngEventId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsEventTabBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngEventId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objEventTabENS">源对象</param>
 /// <param name = "objEventTabENT">目标对象</param>
 public static void CopyTo(clsEventTabEN objEventTabENS, clsEventTabEN objEventTabENT)
{
try
{
objEventTabENT.EventId = objEventTabENS.EventId; //EventId
objEventTabENT.TabName = objEventTabENS.TabName; //表名
objEventTabENT.ColName = objEventTabENS.ColName; //ColName
objEventTabENT.RecordId = objEventTabENS.RecordId; //RecordId
objEventTabENT.InitValue = objEventTabENS.InitValue; //初始值
objEventTabENT.UpdateValue = objEventTabENS.UpdateValue; //UpdateValue
objEventTabENT.UpdDate = objEventTabENS.UpdDate; //修改日期
objEventTabENT.UpdTime = objEventTabENS.UpdTime; //修改时间
objEventTabENT.UpdNameId = objEventTabENS.UpdNameId; //UpdNameId
objEventTabENT.OpdType = objEventTabENS.OpdType; //OpdType
objEventTabENT.Memo = objEventTabENS.Memo; //说明
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
 /// <param name = "objEventTabEN">源简化对象</param>
 public static void SetUpdFlag(clsEventTabEN objEventTabEN)
{
try
{
objEventTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objEventTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conEventTab.EventId, new clsStrCompareIgnoreCase())  ==  true)
{
objEventTabEN.EventId = objEventTabEN.EventId; //EventId
}
if (arrFldSet.Contains(conEventTab.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objEventTabEN.TabName = objEventTabEN.TabName; //表名
}
if (arrFldSet.Contains(conEventTab.ColName, new clsStrCompareIgnoreCase())  ==  true)
{
objEventTabEN.ColName = objEventTabEN.ColName; //ColName
}
if (arrFldSet.Contains(conEventTab.RecordId, new clsStrCompareIgnoreCase())  ==  true)
{
objEventTabEN.RecordId = objEventTabEN.RecordId == "[null]" ? null :  objEventTabEN.RecordId; //RecordId
}
if (arrFldSet.Contains(conEventTab.InitValue, new clsStrCompareIgnoreCase())  ==  true)
{
objEventTabEN.InitValue = objEventTabEN.InitValue == "[null]" ? null :  objEventTabEN.InitValue; //初始值
}
if (arrFldSet.Contains(conEventTab.UpdateValue, new clsStrCompareIgnoreCase())  ==  true)
{
objEventTabEN.UpdateValue = objEventTabEN.UpdateValue == "[null]" ? null :  objEventTabEN.UpdateValue; //UpdateValue
}
if (arrFldSet.Contains(conEventTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objEventTabEN.UpdDate = objEventTabEN.UpdDate == "[null]" ? null :  objEventTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conEventTab.UpdTime, new clsStrCompareIgnoreCase())  ==  true)
{
objEventTabEN.UpdTime = objEventTabEN.UpdTime == "[null]" ? null :  objEventTabEN.UpdTime; //修改时间
}
if (arrFldSet.Contains(conEventTab.UpdNameId, new clsStrCompareIgnoreCase())  ==  true)
{
objEventTabEN.UpdNameId = objEventTabEN.UpdNameId == "[null]" ? null :  objEventTabEN.UpdNameId; //UpdNameId
}
if (arrFldSet.Contains(conEventTab.OpdType, new clsStrCompareIgnoreCase())  ==  true)
{
objEventTabEN.OpdType = objEventTabEN.OpdType == "[null]" ? null :  objEventTabEN.OpdType; //OpdType
}
if (arrFldSet.Contains(conEventTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objEventTabEN.Memo = objEventTabEN.Memo == "[null]" ? null :  objEventTabEN.Memo; //说明
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
 /// <param name = "objEventTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsEventTabEN objEventTabEN)
{
try
{
if (objEventTabEN.RecordId == "[null]") objEventTabEN.RecordId = null; //RecordId
if (objEventTabEN.InitValue == "[null]") objEventTabEN.InitValue = null; //初始值
if (objEventTabEN.UpdateValue == "[null]") objEventTabEN.UpdateValue = null; //UpdateValue
if (objEventTabEN.UpdDate == "[null]") objEventTabEN.UpdDate = null; //修改日期
if (objEventTabEN.UpdTime == "[null]") objEventTabEN.UpdTime = null; //修改时间
if (objEventTabEN.UpdNameId == "[null]") objEventTabEN.UpdNameId = null; //UpdNameId
if (objEventTabEN.OpdType == "[null]") objEventTabEN.OpdType = null; //OpdType
if (objEventTabEN.Memo == "[null]") objEventTabEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsEventTabEN objEventTabEN)
{
 EventTabDA.CheckPropertyNew(objEventTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsEventTabEN objEventTabEN)
{
 EventTabDA.CheckProperty4Condition(objEventTabEN);
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
if (clsEventTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsEventTabBL没有刷新缓存机制(clsEventTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by EventId");
//if (arrEventTabObjLstCache == null)
//{
//arrEventTabObjLstCache = EventTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngEventId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsEventTabEN GetObjByEventIdCache(long lngEventId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsEventTabEN._CurrTabName);
List<clsEventTabEN> arrEventTabObjLstCache = GetObjLstCache();
IEnumerable <clsEventTabEN> arrEventTabObjLst_Sel =
arrEventTabObjLstCache
.Where(x=> x.EventId == lngEventId 
);
if (arrEventTabObjLst_Sel.Count() == 0)
{
   clsEventTabEN obj = clsEventTabBL.GetObjByEventId(lngEventId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrEventTabObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsEventTabEN> GetAllEventTabObjLstCache()
{
//获取缓存中的对象列表
List<clsEventTabEN> arrEventTabObjLstCache = GetObjLstCache(); 
return arrEventTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsEventTabEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsEventTabEN._CurrTabName);
List<clsEventTabEN> arrEventTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrEventTabObjLstCache;
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
string strKey = string.Format("{0}", clsEventTabEN._CurrTabName);
CacheHelper.Remove(strKey);
clsEventTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsEventTabEN._RefreshTimeLst.Count == 0) return "";
return clsEventTabEN._RefreshTimeLst[clsEventTabEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsEventTabBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsEventTabEN._CurrTabName);
CacheHelper.Remove(strKey);
clsEventTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsEventTabBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--EventTab(事件)
 /// 唯一性条件:TabName_ColName_OpdType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objEventTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsEventTabEN objEventTabEN)
{
//检测记录是否存在
string strResult = EventTabDA.GetUniCondStr(objEventTabEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-10-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngEventId)
{
if (strInFldName != conEventTab.EventId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conEventTab.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conEventTab.AttributeName));
throw new Exception(strMsg);
}
var objEventTab = clsEventTabBL.GetObjByEventIdCache(lngEventId);
if (objEventTab == null) return "";
return objEventTab[strOutFldName].ToString();
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
int intRecCount = clsEventTabDA.GetRecCount(strTabName);
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
int intRecCount = clsEventTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsEventTabDA.GetRecCount();
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
int intRecCount = clsEventTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objEventTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsEventTabEN objEventTabCond)
{
List<clsEventTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsEventTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conEventTab.AttributeName)
{
if (objEventTabCond.IsUpdated(strFldName) == false) continue;
if (objEventTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objEventTabCond[strFldName].ToString());
}
else
{
if (objEventTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objEventTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objEventTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objEventTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objEventTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objEventTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objEventTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objEventTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objEventTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objEventTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objEventTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objEventTabCond[strFldName]));
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
 List<string> arrList = clsEventTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = EventTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = EventTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = EventTabDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsEventTabDA.SetFldValue(clsEventTabEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = EventTabDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsEventTabDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsEventTabDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsEventTabDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[EventTab] "); 
 strCreateTabCode.Append(" ( "); 
 // /**EventId*/ 
 strCreateTabCode.Append(" EventId bigint primary key identity, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) not Null, "); 
 // /**ColName*/ 
 strCreateTabCode.Append(" ColName varchar(30) not Null, "); 
 // /**RecordId*/ 
 strCreateTabCode.Append(" RecordId varchar(30) Null, "); 
 // /**初始值*/ 
 strCreateTabCode.Append(" InitValue varchar(1000) Null, "); 
 // /**UpdateValue*/ 
 strCreateTabCode.Append(" UpdateValue varchar(1000) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改时间*/ 
 strCreateTabCode.Append(" UpdTime varchar(6) Null, "); 
 // /**UpdNameId*/ 
 strCreateTabCode.Append(" UpdNameId varchar(18) Null, "); 
 // /**OpdType*/ 
 strCreateTabCode.Append(" OpdType varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 事件(EventTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4EventTab : clsCommFun4BL
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
clsEventTabBL.ReFreshThisCache();
}
}

}