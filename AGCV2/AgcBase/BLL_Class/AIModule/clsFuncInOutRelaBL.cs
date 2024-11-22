﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncInOutRelaBL
 表名:FuncInOutRela(00050407)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:44:42
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
public static class  clsFuncInOutRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncInOutRelaEN GetObj(this K_mId_FuncInOutRela myKey)
{
clsFuncInOutRelaEN objFuncInOutRelaEN = clsFuncInOutRelaBL.FuncInOutRelaDA.GetObjBymId(myKey.Value);
return objFuncInOutRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFuncInOutRelaEN objFuncInOutRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFuncInOutRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!功能表Id = [{0}],GC函数名 = [{1}]的数据已经存在!(in clsFuncInOutRelaBL.AddNewRecord)", objFuncInOutRelaEN.FuncTabId,objFuncInOutRelaEN.GcFuncName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsFuncInOutRelaBL.FuncInOutRelaDA.AddNewRecordBySQL2(objFuncInOutRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncInOutRelaBL.ReFreshCache();

if (clsFuncInOutRelaBL.relatedActions != null)
{
clsFuncInOutRelaBL.relatedActions.UpdRelaTabDate(objFuncInOutRelaEN.mId, objFuncInOutRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsFuncInOutRelaEN objFuncInOutRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objFuncInOutRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFuncInOutRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(功能表Id(FuncTabId)=[{0}],GC函数名(GcFuncName)=[{1}])已经存在,不能重复!", objFuncInOutRelaEN.FuncTabId, objFuncInOutRelaEN.GcFuncName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objFuncInOutRelaEN.AddNewRecord();
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
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFuncInOutRelaEN objFuncInOutRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFuncInOutRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!功能表Id = [{0}],GC函数名 = [{1}]的数据已经存在!(in clsFuncInOutRelaBL.AddNewRecordWithReturnKey)", objFuncInOutRelaEN.FuncTabId,objFuncInOutRelaEN.GcFuncName);
throw new Exception(strMsg);
}
try
{
string strKey = clsFuncInOutRelaBL.FuncInOutRelaDA.AddNewRecordBySQL2WithReturnKey(objFuncInOutRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncInOutRelaBL.ReFreshCache();

if (clsFuncInOutRelaBL.relatedActions != null)
{
clsFuncInOutRelaBL.relatedActions.UpdRelaTabDate(objFuncInOutRelaEN.mId, objFuncInOutRelaEN.UpdUser);
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
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetmId(this clsFuncInOutRelaEN objFuncInOutRelaEN, long lngmId, string strComparisonOp="")
	{
objFuncInOutRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.mId) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.mId, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.mId] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetFuncTabId(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strFuncTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTabId, 8, conFuncInOutRela.FuncTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncTabId, 8, conFuncInOutRela.FuncTabId);
}
objFuncInOutRelaEN.FuncTabId = strFuncTabId; //功能表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.FuncTabId) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.FuncTabId, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.FuncTabId] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetInFldIds(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strInFldIds, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInFldIds, 1000, conFuncInOutRela.InFldIds);
}
objFuncInOutRelaEN.InFldIds = strInFldIds; //输入字段Ids
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.InFldIds) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.InFldIds, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.InFldIds] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetInFldNames(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strInFldNames, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInFldNames, 1000, conFuncInOutRela.InFldNames);
}
objFuncInOutRelaEN.InFldNames = strInFldNames; //输入字段名s
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.InFldNames) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.InFldNames, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.InFldNames] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetOutFldIds(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strOutFldIds, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutFldIds, 1000, conFuncInOutRela.OutFldIds);
}
objFuncInOutRelaEN.OutFldIds = strOutFldIds; //输出字段Ids
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.OutFldIds) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.OutFldIds, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.OutFldIds] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetOutFldNames(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strOutFldNames, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutFldNames, 1000, conFuncInOutRela.OutFldNames);
}
objFuncInOutRelaEN.OutFldNames = strOutFldNames; //输出字段名s
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.OutFldNames) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.OutFldNames, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.OutFldNames] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetGcFuncName(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strGcFuncName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGcFuncName, 50, conFuncInOutRela.GcFuncName);
}
objFuncInOutRelaEN.GcFuncName = strGcFuncName; //GC函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.GcFuncName) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.GcFuncName, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.GcFuncName] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetUpdDate(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFuncInOutRela.UpdDate);
}
objFuncInOutRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.UpdDate) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.UpdDate, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.UpdDate] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetUpdUser(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFuncInOutRela.UpdUser);
}
objFuncInOutRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.UpdUser) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.UpdUser, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.UpdUser] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetMemo(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFuncInOutRela.Memo);
}
objFuncInOutRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.Memo) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.Memo, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.Memo] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFuncInOutRelaEN objFuncInOutRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFuncInOutRelaEN.CheckPropertyNew();
clsFuncInOutRelaEN objFuncInOutRelaCond = new clsFuncInOutRelaEN();
string strCondition = objFuncInOutRelaCond
.SetmId(objFuncInOutRelaEN.mId, "<>")
.SetFuncTabId(objFuncInOutRelaEN.FuncTabId, "=")
.SetGcFuncName(objFuncInOutRelaEN.GcFuncName, "=")
.GetCombineCondition();
objFuncInOutRelaEN._IsCheckProperty = true;
bool bolIsExist = clsFuncInOutRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FuncTabId_GCFuncName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFuncInOutRelaEN.Update();
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
 /// <param name = "objFuncInOutRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFuncInOutRelaEN objFuncInOutRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFuncInOutRelaEN objFuncInOutRelaCond = new clsFuncInOutRelaEN();
string strCondition = objFuncInOutRelaCond
.SetFuncTabId(objFuncInOutRela.FuncTabId, "=")
.SetGcFuncName(objFuncInOutRela.GcFuncName, "=")
.GetCombineCondition();
objFuncInOutRela._IsCheckProperty = true;
bool bolIsExist = clsFuncInOutRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFuncInOutRela.mId = clsFuncInOutRelaBL.GetFirstID_S(strCondition);
objFuncInOutRela.UpdateWithCondition(strCondition);
}
else
{
objFuncInOutRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncInOutRelaEN objFuncInOutRelaEN)
{
 if (objFuncInOutRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFuncInOutRelaBL.FuncInOutRelaDA.UpdateBySql2(objFuncInOutRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncInOutRelaBL.ReFreshCache();

if (clsFuncInOutRelaBL.relatedActions != null)
{
clsFuncInOutRelaBL.relatedActions.UpdRelaTabDate(objFuncInOutRelaEN.mId, objFuncInOutRelaEN.UpdUser);
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
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncInOutRelaEN objFuncInOutRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFuncInOutRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFuncInOutRelaBL.FuncInOutRelaDA.UpdateBySql2(objFuncInOutRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncInOutRelaBL.ReFreshCache();

if (clsFuncInOutRelaBL.relatedActions != null)
{
clsFuncInOutRelaBL.relatedActions.UpdRelaTabDate(objFuncInOutRelaEN.mId, objFuncInOutRelaEN.UpdUser);
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
 /// <param name = "objFuncInOutRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsFuncInOutRelaBL.FuncInOutRelaDA.UpdateBySqlWithCondition(objFuncInOutRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncInOutRelaBL.ReFreshCache();

if (clsFuncInOutRelaBL.relatedActions != null)
{
clsFuncInOutRelaBL.relatedActions.UpdRelaTabDate(objFuncInOutRelaEN.mId, objFuncInOutRelaEN.UpdUser);
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
 /// <param name = "objFuncInOutRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFuncInOutRelaBL.FuncInOutRelaDA.UpdateBySqlWithConditionTransaction(objFuncInOutRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncInOutRelaBL.ReFreshCache();

if (clsFuncInOutRelaBL.relatedActions != null)
{
clsFuncInOutRelaBL.relatedActions.UpdRelaTabDate(objFuncInOutRelaEN.mId, objFuncInOutRelaEN.UpdUser);
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
public static int Delete(this clsFuncInOutRelaEN objFuncInOutRelaEN)
{
try
{
int intRecNum = clsFuncInOutRelaBL.FuncInOutRelaDA.DelRecord(objFuncInOutRelaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncInOutRelaBL.ReFreshCache();

if (clsFuncInOutRelaBL.relatedActions != null)
{
clsFuncInOutRelaBL.relatedActions.UpdRelaTabDate(objFuncInOutRelaEN.mId, objFuncInOutRelaEN.UpdUser);
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
 /// <param name = "objFuncInOutRelaENS">源对象</param>
 /// <param name = "objFuncInOutRelaENT">目标对象</param>
 public static void CopyTo(this clsFuncInOutRelaEN objFuncInOutRelaENS, clsFuncInOutRelaEN objFuncInOutRelaENT)
{
try
{
objFuncInOutRelaENT.mId = objFuncInOutRelaENS.mId; //mId
objFuncInOutRelaENT.FuncTabId = objFuncInOutRelaENS.FuncTabId; //功能表Id
objFuncInOutRelaENT.InFldIds = objFuncInOutRelaENS.InFldIds; //输入字段Ids
objFuncInOutRelaENT.InFldNames = objFuncInOutRelaENS.InFldNames; //输入字段名s
objFuncInOutRelaENT.OutFldIds = objFuncInOutRelaENS.OutFldIds; //输出字段Ids
objFuncInOutRelaENT.OutFldNames = objFuncInOutRelaENS.OutFldNames; //输出字段名s
objFuncInOutRelaENT.GcFuncName = objFuncInOutRelaENS.GcFuncName; //GC函数名
objFuncInOutRelaENT.UpdDate = objFuncInOutRelaENS.UpdDate; //修改日期
objFuncInOutRelaENT.UpdUser = objFuncInOutRelaENS.UpdUser; //修改者
objFuncInOutRelaENT.Memo = objFuncInOutRelaENS.Memo; //说明
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
 /// <param name = "objFuncInOutRelaENS">源对象</param>
 /// <returns>目标对象=>clsFuncInOutRelaEN:objFuncInOutRelaENT</returns>
 public static clsFuncInOutRelaEN CopyTo(this clsFuncInOutRelaEN objFuncInOutRelaENS)
{
try
{
 clsFuncInOutRelaEN objFuncInOutRelaENT = new clsFuncInOutRelaEN()
{
mId = objFuncInOutRelaENS.mId, //mId
FuncTabId = objFuncInOutRelaENS.FuncTabId, //功能表Id
InFldIds = objFuncInOutRelaENS.InFldIds, //输入字段Ids
InFldNames = objFuncInOutRelaENS.InFldNames, //输入字段名s
OutFldIds = objFuncInOutRelaENS.OutFldIds, //输出字段Ids
OutFldNames = objFuncInOutRelaENS.OutFldNames, //输出字段名s
GcFuncName = objFuncInOutRelaENS.GcFuncName, //GC函数名
UpdDate = objFuncInOutRelaENS.UpdDate, //修改日期
UpdUser = objFuncInOutRelaENS.UpdUser, //修改者
Memo = objFuncInOutRelaENS.Memo, //说明
};
 return objFuncInOutRelaENT;
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
public static void CheckPropertyNew(this clsFuncInOutRelaEN objFuncInOutRelaEN)
{
 clsFuncInOutRelaBL.FuncInOutRelaDA.CheckPropertyNew(objFuncInOutRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFuncInOutRelaEN objFuncInOutRelaEN)
{
 clsFuncInOutRelaBL.FuncInOutRelaDA.CheckProperty4Condition(objFuncInOutRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFuncInOutRelaEN objFuncInOutRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.mId) == true)
{
string strComparisonOpmId = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conFuncInOutRela.mId, objFuncInOutRelaCond.mId, strComparisonOpmId);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.FuncTabId) == true)
{
string strComparisonOpFuncTabId = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.FuncTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.FuncTabId, objFuncInOutRelaCond.FuncTabId, strComparisonOpFuncTabId);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.InFldIds) == true)
{
string strComparisonOpInFldIds = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.InFldIds];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.InFldIds, objFuncInOutRelaCond.InFldIds, strComparisonOpInFldIds);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.InFldNames) == true)
{
string strComparisonOpInFldNames = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.InFldNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.InFldNames, objFuncInOutRelaCond.InFldNames, strComparisonOpInFldNames);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.OutFldIds) == true)
{
string strComparisonOpOutFldIds = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.OutFldIds];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.OutFldIds, objFuncInOutRelaCond.OutFldIds, strComparisonOpOutFldIds);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.OutFldNames) == true)
{
string strComparisonOpOutFldNames = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.OutFldNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.OutFldNames, objFuncInOutRelaCond.OutFldNames, strComparisonOpOutFldNames);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.GcFuncName) == true)
{
string strComparisonOpGcFuncName = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.GcFuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.GcFuncName, objFuncInOutRelaCond.GcFuncName, strComparisonOpGcFuncName);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.UpdDate, objFuncInOutRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.UpdUser, objFuncInOutRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.Memo) == true)
{
string strComparisonOpMemo = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.Memo, objFuncInOutRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FuncInOutRela(函数输入输出关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FuncTabId_GCFuncName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFuncInOutRelaEN objFuncInOutRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFuncInOutRelaEN == null) return true;
if (objFuncInOutRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objFuncInOutRelaEN.FuncTabId == null)
{
 sbCondition.AppendFormat(" and FuncTabId is null", objFuncInOutRelaEN.FuncTabId);
}
else
{
 sbCondition.AppendFormat(" and FuncTabId = '{0}'", objFuncInOutRelaEN.FuncTabId);
}
 if (objFuncInOutRelaEN.GcFuncName == null)
{
 sbCondition.AppendFormat(" and GcFuncName is null", objFuncInOutRelaEN.GcFuncName);
}
else
{
 sbCondition.AppendFormat(" and GcFuncName = '{0}'", objFuncInOutRelaEN.GcFuncName);
}
if (clsFuncInOutRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFuncInOutRelaEN.mId);
 sbCondition.AppendFormat(" and FuncTabId = '{0}'", objFuncInOutRelaEN.FuncTabId);
 sbCondition.AppendFormat(" and GcFuncName = '{0}'", objFuncInOutRelaEN.GcFuncName);
if (clsFuncInOutRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FuncInOutRela(函数输入输出关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FuncTabId_GCFuncName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFuncInOutRelaEN objFuncInOutRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFuncInOutRelaEN == null) return "";
if (objFuncInOutRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objFuncInOutRelaEN.FuncTabId == null)
{
 sbCondition.AppendFormat(" and FuncTabId is null", objFuncInOutRelaEN.FuncTabId);
}
else
{
 sbCondition.AppendFormat(" and FuncTabId = '{0}'", objFuncInOutRelaEN.FuncTabId);
}
 if (objFuncInOutRelaEN.GcFuncName == null)
{
 sbCondition.AppendFormat(" and GcFuncName is null", objFuncInOutRelaEN.GcFuncName);
}
else
{
 sbCondition.AppendFormat(" and GcFuncName = '{0}'", objFuncInOutRelaEN.GcFuncName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFuncInOutRelaEN.mId);
 sbCondition.AppendFormat(" and FuncTabId = '{0}'", objFuncInOutRelaEN.FuncTabId);
 sbCondition.AppendFormat(" and GcFuncName = '{0}'", objFuncInOutRelaEN.GcFuncName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FuncInOutRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 函数输入输出关系(FuncInOutRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFuncInOutRelaBL
{
public static RelatedActions_FuncInOutRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFuncInOutRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFuncInOutRelaDA FuncInOutRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFuncInOutRelaDA();
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
 public clsFuncInOutRelaBL()
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
if (string.IsNullOrEmpty(clsFuncInOutRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFuncInOutRelaEN._ConnectString);
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
public static DataTable GetDataTable_FuncInOutRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FuncInOutRelaDA.GetDataTable_FuncInOutRela(strWhereCond);
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
objDT = FuncInOutRelaDA.GetDataTable(strWhereCond);
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
objDT = FuncInOutRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FuncInOutRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FuncInOutRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FuncInOutRelaDA.GetDataTable_Top(objTopPara);
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
objDT = FuncInOutRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FuncInOutRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FuncInOutRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsFuncInOutRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsFuncInOutRelaEN> arrObjLst = new List<clsFuncInOutRelaEN>(); 
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
	clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN();
try
{
objFuncInOutRelaEN.mId = Int32.Parse(objRow[conFuncInOutRela.mId].ToString().Trim()); //mId
objFuncInOutRelaEN.FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objFuncInOutRelaEN.InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objFuncInOutRelaEN.InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objFuncInOutRelaEN.OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objFuncInOutRelaEN.OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objFuncInOutRelaEN.GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objFuncInOutRelaEN.UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objFuncInOutRelaEN.UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objFuncInOutRelaEN.Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncInOutRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFuncInOutRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsFuncInOutRelaEN._CurrTabName);
List<clsFuncInOutRelaEN> arrFuncInOutRelaObjLstCache = GetObjLstCache();
IEnumerable <clsFuncInOutRelaEN> arrFuncInOutRelaObjLst_Sel =
arrFuncInOutRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrFuncInOutRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncInOutRelaEN> GetObjLst(string strWhereCond)
{
List<clsFuncInOutRelaEN> arrObjLst = new List<clsFuncInOutRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN();
try
{
objFuncInOutRelaEN.mId = Int32.Parse(objRow[conFuncInOutRela.mId].ToString().Trim()); //mId
objFuncInOutRelaEN.FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objFuncInOutRelaEN.InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objFuncInOutRelaEN.InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objFuncInOutRelaEN.OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objFuncInOutRelaEN.OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objFuncInOutRelaEN.GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objFuncInOutRelaEN.UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objFuncInOutRelaEN.UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objFuncInOutRelaEN.Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncInOutRelaEN);
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
public static List<clsFuncInOutRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFuncInOutRelaEN> arrObjLst = new List<clsFuncInOutRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN();
try
{
objFuncInOutRelaEN.mId = Int32.Parse(objRow[conFuncInOutRela.mId].ToString().Trim()); //mId
objFuncInOutRelaEN.FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objFuncInOutRelaEN.InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objFuncInOutRelaEN.InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objFuncInOutRelaEN.OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objFuncInOutRelaEN.OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objFuncInOutRelaEN.GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objFuncInOutRelaEN.UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objFuncInOutRelaEN.UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objFuncInOutRelaEN.Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncInOutRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFuncInOutRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFuncInOutRelaEN> GetSubObjLstCache(clsFuncInOutRelaEN objFuncInOutRelaCond)
{
List<clsFuncInOutRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFuncInOutRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFuncInOutRela.AttributeName)
{
if (objFuncInOutRelaCond.IsUpdated(strFldName) == false) continue;
if (objFuncInOutRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncInOutRelaCond[strFldName].ToString());
}
else
{
if (objFuncInOutRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFuncInOutRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncInOutRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFuncInOutRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFuncInOutRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFuncInOutRelaCond[strFldName]));
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
public static List<clsFuncInOutRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFuncInOutRelaEN> arrObjLst = new List<clsFuncInOutRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN();
try
{
objFuncInOutRelaEN.mId = Int32.Parse(objRow[conFuncInOutRela.mId].ToString().Trim()); //mId
objFuncInOutRelaEN.FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objFuncInOutRelaEN.InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objFuncInOutRelaEN.InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objFuncInOutRelaEN.OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objFuncInOutRelaEN.OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objFuncInOutRelaEN.GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objFuncInOutRelaEN.UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objFuncInOutRelaEN.UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objFuncInOutRelaEN.Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncInOutRelaEN);
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
public static List<clsFuncInOutRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFuncInOutRelaEN> arrObjLst = new List<clsFuncInOutRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN();
try
{
objFuncInOutRelaEN.mId = Int32.Parse(objRow[conFuncInOutRela.mId].ToString().Trim()); //mId
objFuncInOutRelaEN.FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objFuncInOutRelaEN.InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objFuncInOutRelaEN.InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objFuncInOutRelaEN.OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objFuncInOutRelaEN.OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objFuncInOutRelaEN.GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objFuncInOutRelaEN.UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objFuncInOutRelaEN.UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objFuncInOutRelaEN.Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncInOutRelaEN);
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
List<clsFuncInOutRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFuncInOutRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncInOutRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFuncInOutRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFuncInOutRelaEN> arrObjLst = new List<clsFuncInOutRelaEN>(); 
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
	clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN();
try
{
objFuncInOutRelaEN.mId = Int32.Parse(objRow[conFuncInOutRela.mId].ToString().Trim()); //mId
objFuncInOutRelaEN.FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objFuncInOutRelaEN.InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objFuncInOutRelaEN.InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objFuncInOutRelaEN.OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objFuncInOutRelaEN.OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objFuncInOutRelaEN.GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objFuncInOutRelaEN.UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objFuncInOutRelaEN.UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objFuncInOutRelaEN.Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncInOutRelaEN);
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
public static List<clsFuncInOutRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFuncInOutRelaEN> arrObjLst = new List<clsFuncInOutRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN();
try
{
objFuncInOutRelaEN.mId = Int32.Parse(objRow[conFuncInOutRela.mId].ToString().Trim()); //mId
objFuncInOutRelaEN.FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objFuncInOutRelaEN.InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objFuncInOutRelaEN.InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objFuncInOutRelaEN.OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objFuncInOutRelaEN.OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objFuncInOutRelaEN.GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objFuncInOutRelaEN.UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objFuncInOutRelaEN.UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objFuncInOutRelaEN.Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncInOutRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFuncInOutRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFuncInOutRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFuncInOutRelaEN> arrObjLst = new List<clsFuncInOutRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN();
try
{
objFuncInOutRelaEN.mId = Int32.Parse(objRow[conFuncInOutRela.mId].ToString().Trim()); //mId
objFuncInOutRelaEN.FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objFuncInOutRelaEN.InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objFuncInOutRelaEN.InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objFuncInOutRelaEN.OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objFuncInOutRelaEN.OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objFuncInOutRelaEN.GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objFuncInOutRelaEN.UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objFuncInOutRelaEN.UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objFuncInOutRelaEN.Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncInOutRelaEN);
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
public static List<clsFuncInOutRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFuncInOutRelaEN> arrObjLst = new List<clsFuncInOutRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN();
try
{
objFuncInOutRelaEN.mId = Int32.Parse(objRow[conFuncInOutRela.mId].ToString().Trim()); //mId
objFuncInOutRelaEN.FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objFuncInOutRelaEN.InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objFuncInOutRelaEN.InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objFuncInOutRelaEN.OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objFuncInOutRelaEN.OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objFuncInOutRelaEN.GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objFuncInOutRelaEN.UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objFuncInOutRelaEN.UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objFuncInOutRelaEN.Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncInOutRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncInOutRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFuncInOutRelaEN> arrObjLst = new List<clsFuncInOutRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN();
try
{
objFuncInOutRelaEN.mId = Int32.Parse(objRow[conFuncInOutRela.mId].ToString().Trim()); //mId
objFuncInOutRelaEN.FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objFuncInOutRelaEN.InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objFuncInOutRelaEN.InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objFuncInOutRelaEN.OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objFuncInOutRelaEN.OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objFuncInOutRelaEN.GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objFuncInOutRelaEN.UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objFuncInOutRelaEN.UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objFuncInOutRelaEN.Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncInOutRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFuncInOutRela(ref clsFuncInOutRelaEN objFuncInOutRelaEN)
{
bool bolResult = FuncInOutRelaDA.GetFuncInOutRela(ref objFuncInOutRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncInOutRelaEN GetObjBymId(long lngmId)
{
clsFuncInOutRelaEN objFuncInOutRelaEN = FuncInOutRelaDA.GetObjBymId(lngmId);
return objFuncInOutRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFuncInOutRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFuncInOutRelaEN objFuncInOutRelaEN = FuncInOutRelaDA.GetFirstObj(strWhereCond);
 return objFuncInOutRelaEN;
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
public static clsFuncInOutRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFuncInOutRelaEN objFuncInOutRelaEN = FuncInOutRelaDA.GetObjByDataRow(objRow);
 return objFuncInOutRelaEN;
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
public static clsFuncInOutRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFuncInOutRelaEN objFuncInOutRelaEN = FuncInOutRelaDA.GetObjByDataRow(objRow);
 return objFuncInOutRelaEN;
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
 /// <param name = "lstFuncInOutRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFuncInOutRelaEN GetObjBymIdFromList(long lngmId, List<clsFuncInOutRelaEN> lstFuncInOutRelaObjLst)
{
foreach (clsFuncInOutRelaEN objFuncInOutRelaEN in lstFuncInOutRelaObjLst)
{
if (objFuncInOutRelaEN.mId == lngmId)
{
return objFuncInOutRelaEN;
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
 lngmId = new clsFuncInOutRelaDA().GetFirstID(strWhereCond);
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
 arrList = FuncInOutRelaDA.GetID(strWhereCond);
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
bool bolIsExist = FuncInOutRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = FuncInOutRelaDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">mId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clsFuncInOutRelaEN objFuncInOutRelaEN = clsFuncInOutRelaBL.GetObjBymId(lngmId);
objFuncInOutRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFuncInOutRelaEN.UpdUser = strOpUser;
return clsFuncInOutRelaBL.UpdateBySql2(objFuncInOutRelaEN);
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
 bolIsExist = clsFuncInOutRelaDA.IsExistTable();
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
 bolIsExist = FuncInOutRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFuncInOutRelaEN objFuncInOutRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFuncInOutRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能表Id = [{0}],GC函数名 = [{1}]的数据已经存在!(in clsFuncInOutRelaBL.AddNewRecordBySql2)", objFuncInOutRelaEN.FuncTabId,objFuncInOutRelaEN.GcFuncName);
throw new Exception(strMsg);
}
try
{
bool bolResult = FuncInOutRelaDA.AddNewRecordBySQL2(objFuncInOutRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncInOutRelaBL.ReFreshCache();

if (clsFuncInOutRelaBL.relatedActions != null)
{
clsFuncInOutRelaBL.relatedActions.UpdRelaTabDate(objFuncInOutRelaEN.mId, objFuncInOutRelaEN.UpdUser);
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
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFuncInOutRelaEN objFuncInOutRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFuncInOutRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能表Id = [{0}],GC函数名 = [{1}]的数据已经存在!(in clsFuncInOutRelaBL.AddNewRecordBySql2WithReturnKey)", objFuncInOutRelaEN.FuncTabId,objFuncInOutRelaEN.GcFuncName);
throw new Exception(strMsg);
}
try
{
string strKey = FuncInOutRelaDA.AddNewRecordBySQL2WithReturnKey(objFuncInOutRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncInOutRelaBL.ReFreshCache();

if (clsFuncInOutRelaBL.relatedActions != null)
{
clsFuncInOutRelaBL.relatedActions.UpdRelaTabDate(objFuncInOutRelaEN.mId, objFuncInOutRelaEN.UpdUser);
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
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
try
{
bool bolResult = FuncInOutRelaDA.Update(objFuncInOutRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncInOutRelaBL.ReFreshCache();

if (clsFuncInOutRelaBL.relatedActions != null)
{
clsFuncInOutRelaBL.relatedActions.UpdRelaTabDate(objFuncInOutRelaEN.mId, objFuncInOutRelaEN.UpdUser);
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
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
 if (objFuncInOutRelaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FuncInOutRelaDA.UpdateBySql2(objFuncInOutRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncInOutRelaBL.ReFreshCache();

if (clsFuncInOutRelaBL.relatedActions != null)
{
clsFuncInOutRelaBL.relatedActions.UpdRelaTabDate(objFuncInOutRelaEN.mId, objFuncInOutRelaEN.UpdUser);
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
 clsFuncInOutRelaEN objFuncInOutRelaEN = clsFuncInOutRelaBL.GetObjBymId(lngmId);

if (clsFuncInOutRelaBL.relatedActions != null)
{
clsFuncInOutRelaBL.relatedActions.UpdRelaTabDate(objFuncInOutRelaEN.mId, objFuncInOutRelaEN.UpdUser);
}
if (objFuncInOutRelaEN != null)
{
int intRecNum = FuncInOutRelaDA.DelRecord(lngmId);
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
objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
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
//删除与表:[FuncInOutRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFuncInOutRela.mId,
//lngmId);
//        clsFuncInOutRelaBL.DelFuncInOutRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFuncInOutRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFuncInOutRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsFuncInOutRelaBL.relatedActions != null)
{
clsFuncInOutRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = FuncInOutRelaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelFuncInOutRelas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsFuncInOutRelaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsFuncInOutRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = FuncInOutRelaDA.DelFuncInOutRela(arrmIdLst);
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
public static int DelFuncInOutRelasByCond(string strWhereCond)
{
try
{
if (clsFuncInOutRelaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsFuncInOutRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = FuncInOutRelaDA.DelFuncInOutRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FuncInOutRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
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
//删除与表:[FuncInOutRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFuncInOutRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFuncInOutRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objFuncInOutRelaENS">源对象</param>
 /// <param name = "objFuncInOutRelaENT">目标对象</param>
 public static void CopyTo(clsFuncInOutRelaEN objFuncInOutRelaENS, clsFuncInOutRelaEN objFuncInOutRelaENT)
{
try
{
objFuncInOutRelaENT.mId = objFuncInOutRelaENS.mId; //mId
objFuncInOutRelaENT.FuncTabId = objFuncInOutRelaENS.FuncTabId; //功能表Id
objFuncInOutRelaENT.InFldIds = objFuncInOutRelaENS.InFldIds; //输入字段Ids
objFuncInOutRelaENT.InFldNames = objFuncInOutRelaENS.InFldNames; //输入字段名s
objFuncInOutRelaENT.OutFldIds = objFuncInOutRelaENS.OutFldIds; //输出字段Ids
objFuncInOutRelaENT.OutFldNames = objFuncInOutRelaENS.OutFldNames; //输出字段名s
objFuncInOutRelaENT.GcFuncName = objFuncInOutRelaENS.GcFuncName; //GC函数名
objFuncInOutRelaENT.UpdDate = objFuncInOutRelaENS.UpdDate; //修改日期
objFuncInOutRelaENT.UpdUser = objFuncInOutRelaENS.UpdUser; //修改者
objFuncInOutRelaENT.Memo = objFuncInOutRelaENS.Memo; //说明
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
 /// <param name = "objFuncInOutRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
try
{
objFuncInOutRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFuncInOutRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFuncInOutRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncInOutRelaEN.mId = objFuncInOutRelaEN.mId; //mId
}
if (arrFldSet.Contains(conFuncInOutRela.FuncTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncInOutRelaEN.FuncTabId = objFuncInOutRelaEN.FuncTabId == "[null]" ? null :  objFuncInOutRelaEN.FuncTabId; //功能表Id
}
if (arrFldSet.Contains(conFuncInOutRela.InFldIds, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncInOutRelaEN.InFldIds = objFuncInOutRelaEN.InFldIds == "[null]" ? null :  objFuncInOutRelaEN.InFldIds; //输入字段Ids
}
if (arrFldSet.Contains(conFuncInOutRela.InFldNames, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncInOutRelaEN.InFldNames = objFuncInOutRelaEN.InFldNames == "[null]" ? null :  objFuncInOutRelaEN.InFldNames; //输入字段名s
}
if (arrFldSet.Contains(conFuncInOutRela.OutFldIds, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncInOutRelaEN.OutFldIds = objFuncInOutRelaEN.OutFldIds == "[null]" ? null :  objFuncInOutRelaEN.OutFldIds; //输出字段Ids
}
if (arrFldSet.Contains(conFuncInOutRela.OutFldNames, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncInOutRelaEN.OutFldNames = objFuncInOutRelaEN.OutFldNames == "[null]" ? null :  objFuncInOutRelaEN.OutFldNames; //输出字段名s
}
if (arrFldSet.Contains(conFuncInOutRela.GcFuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncInOutRelaEN.GcFuncName = objFuncInOutRelaEN.GcFuncName == "[null]" ? null :  objFuncInOutRelaEN.GcFuncName; //GC函数名
}
if (arrFldSet.Contains(conFuncInOutRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncInOutRelaEN.UpdDate = objFuncInOutRelaEN.UpdDate == "[null]" ? null :  objFuncInOutRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFuncInOutRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncInOutRelaEN.UpdUser = objFuncInOutRelaEN.UpdUser == "[null]" ? null :  objFuncInOutRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFuncInOutRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncInOutRelaEN.Memo = objFuncInOutRelaEN.Memo == "[null]" ? null :  objFuncInOutRelaEN.Memo; //说明
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
 /// <param name = "objFuncInOutRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
try
{
if (objFuncInOutRelaEN.FuncTabId == "[null]") objFuncInOutRelaEN.FuncTabId = null; //功能表Id
if (objFuncInOutRelaEN.InFldIds == "[null]") objFuncInOutRelaEN.InFldIds = null; //输入字段Ids
if (objFuncInOutRelaEN.InFldNames == "[null]") objFuncInOutRelaEN.InFldNames = null; //输入字段名s
if (objFuncInOutRelaEN.OutFldIds == "[null]") objFuncInOutRelaEN.OutFldIds = null; //输出字段Ids
if (objFuncInOutRelaEN.OutFldNames == "[null]") objFuncInOutRelaEN.OutFldNames = null; //输出字段名s
if (objFuncInOutRelaEN.GcFuncName == "[null]") objFuncInOutRelaEN.GcFuncName = null; //GC函数名
if (objFuncInOutRelaEN.UpdDate == "[null]") objFuncInOutRelaEN.UpdDate = null; //修改日期
if (objFuncInOutRelaEN.UpdUser == "[null]") objFuncInOutRelaEN.UpdUser = null; //修改者
if (objFuncInOutRelaEN.Memo == "[null]") objFuncInOutRelaEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
 FuncInOutRelaDA.CheckPropertyNew(objFuncInOutRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
 FuncInOutRelaDA.CheckProperty4Condition(objFuncInOutRelaEN);
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
if (clsFuncInOutRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncInOutRelaBL没有刷新缓存机制(clsFuncInOutRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrFuncInOutRelaObjLstCache == null)
//{
//arrFuncInOutRelaObjLstCache = FuncInOutRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFuncInOutRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFuncInOutRelaEN._CurrTabName);
List<clsFuncInOutRelaEN> arrFuncInOutRelaObjLstCache = GetObjLstCache();
IEnumerable <clsFuncInOutRelaEN> arrFuncInOutRelaObjLst_Sel =
arrFuncInOutRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrFuncInOutRelaObjLst_Sel.Count() == 0)
{
   clsFuncInOutRelaEN obj = clsFuncInOutRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFuncInOutRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFuncInOutRelaEN> GetAllFuncInOutRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsFuncInOutRelaEN> arrFuncInOutRelaObjLstCache = GetObjLstCache(); 
return arrFuncInOutRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFuncInOutRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFuncInOutRelaEN._CurrTabName);
List<clsFuncInOutRelaEN> arrFuncInOutRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFuncInOutRelaObjLstCache;
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
string strKey = string.Format("{0}", clsFuncInOutRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFuncInOutRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFuncInOutRelaEN._RefreshTimeLst.Count == 0) return "";
return clsFuncInOutRelaEN._RefreshTimeLst[clsFuncInOutRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFuncInOutRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFuncInOutRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFuncInOutRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFuncInOutRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FuncInOutRela(函数输入输出关系)
 /// 唯一性条件:FuncTabId_GCFuncName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
//检测记录是否存在
string strResult = FuncInOutRelaDA.GetUniCondStr(objFuncInOutRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conFuncInOutRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFuncInOutRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFuncInOutRela.AttributeName));
throw new Exception(strMsg);
}
var objFuncInOutRela = clsFuncInOutRelaBL.GetObjBymIdCache(lngmId);
if (objFuncInOutRela == null) return "";
return objFuncInOutRela[strOutFldName].ToString();
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
int intRecCount = clsFuncInOutRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsFuncInOutRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFuncInOutRelaDA.GetRecCount();
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
int intRecCount = clsFuncInOutRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFuncInOutRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFuncInOutRelaEN objFuncInOutRelaCond)
{
List<clsFuncInOutRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFuncInOutRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFuncInOutRela.AttributeName)
{
if (objFuncInOutRelaCond.IsUpdated(strFldName) == false) continue;
if (objFuncInOutRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncInOutRelaCond[strFldName].ToString());
}
else
{
if (objFuncInOutRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFuncInOutRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncInOutRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFuncInOutRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFuncInOutRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFuncInOutRelaCond[strFldName]));
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
 List<string> arrList = clsFuncInOutRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FuncInOutRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FuncInOutRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FuncInOutRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFuncInOutRelaDA.SetFldValue(clsFuncInOutRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FuncInOutRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFuncInOutRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFuncInOutRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFuncInOutRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FuncInOutRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**功能表Id*/ 
 strCreateTabCode.Append(" FuncTabId char(8) Null, "); 
 // /**输入字段Ids*/ 
 strCreateTabCode.Append(" InFldIds varchar(1000) Null, "); 
 // /**输入字段名s*/ 
 strCreateTabCode.Append(" InFldNames varchar(1000) Null, "); 
 // /**输出字段Ids*/ 
 strCreateTabCode.Append(" OutFldIds varchar(1000) Null, "); 
 // /**输出字段名s*/ 
 strCreateTabCode.Append(" OutFldNames varchar(1000) Null, "); 
 // /**GC函数名*/ 
 strCreateTabCode.Append(" GcFuncName varchar(50) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 函数输入输出关系(FuncInOutRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FuncInOutRela : clsCommFun4BL
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
clsFuncInOutRelaBL.ReFreshThisCache();
}
}

}