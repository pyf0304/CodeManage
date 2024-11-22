﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncModuleBL
 表名:FuncModule(01120121)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:14
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数管理(SysParaMan)
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
public static class  clsFuncModuleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncModuleEN GetObj(this K_FuncModuleId_FuncModule myKey)
{
clsFuncModuleEN objFuncModuleEN = clsFuncModuleBL.FuncModuleDA.GetObjByFuncModuleId(myKey.Value);
return objFuncModuleEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFuncModuleEN objFuncModuleEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFuncModuleBL.IsExist(objFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFuncModuleEN.FuncModuleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsFuncModuleBL.FuncModuleDA.AddNewRecordBySQL2(objFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModuleBL.ReFreshCache();

if (clsFuncModuleBL.relatedActions != null)
{
clsFuncModuleBL.relatedActions.UpdRelaTabDate(objFuncModuleEN.FuncModuleId, objFuncModuleEN.UpdUser);
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
public static bool AddRecordEx(this clsFuncModuleEN objFuncModuleEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsFuncModuleBL.IsExist(objFuncModuleEN.FuncModuleId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objFuncModuleEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objFuncModuleEN.AddNewRecord();
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
 /// <param name = "objFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFuncModuleEN objFuncModuleEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFuncModuleBL.IsExist(objFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFuncModuleEN.FuncModuleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsFuncModuleBL.FuncModuleDA.AddNewRecordBySQL2WithReturnKey(objFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModuleBL.ReFreshCache();

if (clsFuncModuleBL.relatedActions != null)
{
clsFuncModuleBL.relatedActions.UpdRelaTabDate(objFuncModuleEN.FuncModuleId, objFuncModuleEN.UpdUser);
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
 /// <param name = "objFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModuleEN SetFuncModuleId(this clsFuncModuleEN objFuncModuleEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conFuncModule.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conFuncModule.FuncModuleId);
}
objFuncModuleEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModuleEN.dicFldComparisonOp.ContainsKey(conFuncModule.FuncModuleId) == false)
{
objFuncModuleEN.dicFldComparisonOp.Add(conFuncModule.FuncModuleId, strComparisonOp);
}
else
{
objFuncModuleEN.dicFldComparisonOp[conFuncModule.FuncModuleId] = strComparisonOp;
}
}
return objFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModuleEN SetFuncModuleName(this clsFuncModuleEN objFuncModuleEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, conFuncModule.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, conFuncModule.FuncModuleName);
}
objFuncModuleEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModuleEN.dicFldComparisonOp.ContainsKey(conFuncModule.FuncModuleName) == false)
{
objFuncModuleEN.dicFldComparisonOp.Add(conFuncModule.FuncModuleName, strComparisonOp);
}
else
{
objFuncModuleEN.dicFldComparisonOp[conFuncModule.FuncModuleName] = strComparisonOp;
}
}
return objFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModuleEN SetFuncModuleNameSim(this clsFuncModuleEN objFuncModuleEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, conFuncModule.FuncModuleNameSim);
}
objFuncModuleEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModuleEN.dicFldComparisonOp.ContainsKey(conFuncModule.FuncModuleNameSim) == false)
{
objFuncModuleEN.dicFldComparisonOp.Add(conFuncModule.FuncModuleNameSim, strComparisonOp);
}
else
{
objFuncModuleEN.dicFldComparisonOp[conFuncModule.FuncModuleNameSim] = strComparisonOp;
}
}
return objFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModuleEN SetMemo(this clsFuncModuleEN objFuncModuleEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFuncModule.Memo);
}
objFuncModuleEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModuleEN.dicFldComparisonOp.ContainsKey(conFuncModule.Memo) == false)
{
objFuncModuleEN.dicFldComparisonOp.Add(conFuncModule.Memo, strComparisonOp);
}
else
{
objFuncModuleEN.dicFldComparisonOp[conFuncModule.Memo] = strComparisonOp;
}
}
return objFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModuleEN SetUpdDate(this clsFuncModuleEN objFuncModuleEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFuncModule.UpdDate);
}
objFuncModuleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModuleEN.dicFldComparisonOp.ContainsKey(conFuncModule.UpdDate) == false)
{
objFuncModuleEN.dicFldComparisonOp.Add(conFuncModule.UpdDate, strComparisonOp);
}
else
{
objFuncModuleEN.dicFldComparisonOp[conFuncModule.UpdDate] = strComparisonOp;
}
}
return objFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModuleEN SetUpdUser(this clsFuncModuleEN objFuncModuleEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFuncModule.UpdUser);
}
objFuncModuleEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModuleEN.dicFldComparisonOp.ContainsKey(conFuncModule.UpdUser) == false)
{
objFuncModuleEN.dicFldComparisonOp.Add(conFuncModule.UpdUser, strComparisonOp);
}
else
{
objFuncModuleEN.dicFldComparisonOp[conFuncModule.UpdUser] = strComparisonOp;
}
}
return objFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModuleEN SetOrderNum(this clsFuncModuleEN objFuncModuleEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conFuncModule.OrderNum);
objFuncModuleEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModuleEN.dicFldComparisonOp.ContainsKey(conFuncModule.OrderNum) == false)
{
objFuncModuleEN.dicFldComparisonOp.Add(conFuncModule.OrderNum, strComparisonOp);
}
else
{
objFuncModuleEN.dicFldComparisonOp[conFuncModule.OrderNum] = strComparisonOp;
}
}
return objFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModuleEN SetPrjId(this clsFuncModuleEN objFuncModuleEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conFuncModule.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFuncModule.PrjId);
}
objFuncModuleEN.PrjId = strPrjId; //PrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModuleEN.dicFldComparisonOp.ContainsKey(conFuncModule.PrjId) == false)
{
objFuncModuleEN.dicFldComparisonOp.Add(conFuncModule.PrjId, strComparisonOp);
}
else
{
objFuncModuleEN.dicFldComparisonOp[conFuncModule.PrjId] = strComparisonOp;
}
}
return objFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModuleEN SetFuncModuleEnName(this clsFuncModuleEN objFuncModuleEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, conFuncModule.FuncModuleEnName);
}
objFuncModuleEN.FuncModuleEnName = strFuncModuleEnName; //FuncModuleEnName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModuleEN.dicFldComparisonOp.ContainsKey(conFuncModule.FuncModuleEnName) == false)
{
objFuncModuleEN.dicFldComparisonOp.Add(conFuncModule.FuncModuleEnName, strComparisonOp);
}
else
{
objFuncModuleEN.dicFldComparisonOp[conFuncModule.FuncModuleEnName] = strComparisonOp;
}
}
return objFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModuleEN SetUseStateId(this clsFuncModuleEN objFuncModuleEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, conFuncModule.UseStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateId, 4, conFuncModule.UseStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, conFuncModule.UseStateId);
}
objFuncModuleEN.UseStateId = strUseStateId; //UseStateId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModuleEN.dicFldComparisonOp.ContainsKey(conFuncModule.UseStateId) == false)
{
objFuncModuleEN.dicFldComparisonOp.Add(conFuncModule.UseStateId, strComparisonOp);
}
else
{
objFuncModuleEN.dicFldComparisonOp[conFuncModule.UseStateId] = strComparisonOp;
}
}
return objFuncModuleEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFuncModuleEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFuncModuleEN objFuncModuleEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFuncModuleEN.CheckPropertyNew();
clsFuncModuleEN objFuncModuleCond = new clsFuncModuleEN();
string strCondition = objFuncModuleCond
.SetFuncModuleId(objFuncModuleEN.FuncModuleId, "=")
.GetCombineCondition();
objFuncModuleEN._IsCheckProperty = true;
bool bolIsExist = clsFuncModuleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFuncModuleEN.Update();
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
 /// <param name = "objFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncModuleEN objFuncModuleEN)
{
 if (string.IsNullOrEmpty(objFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFuncModuleBL.FuncModuleDA.UpdateBySql2(objFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModuleBL.ReFreshCache();

if (clsFuncModuleBL.relatedActions != null)
{
clsFuncModuleBL.relatedActions.UpdRelaTabDate(objFuncModuleEN.FuncModuleId, objFuncModuleEN.UpdUser);
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
 /// <param name = "objFuncModuleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncModuleEN objFuncModuleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFuncModuleBL.FuncModuleDA.UpdateBySql2(objFuncModuleEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModuleBL.ReFreshCache();

if (clsFuncModuleBL.relatedActions != null)
{
clsFuncModuleBL.relatedActions.UpdRelaTabDate(objFuncModuleEN.FuncModuleId, objFuncModuleEN.UpdUser);
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
 /// <param name = "objFuncModuleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncModuleEN objFuncModuleEN, string strWhereCond)
{
try
{
bool bolResult = clsFuncModuleBL.FuncModuleDA.UpdateBySqlWithCondition(objFuncModuleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModuleBL.ReFreshCache();

if (clsFuncModuleBL.relatedActions != null)
{
clsFuncModuleBL.relatedActions.UpdRelaTabDate(objFuncModuleEN.FuncModuleId, objFuncModuleEN.UpdUser);
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
 /// <param name = "objFuncModuleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncModuleEN objFuncModuleEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFuncModuleBL.FuncModuleDA.UpdateBySqlWithConditionTransaction(objFuncModuleEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModuleBL.ReFreshCache();

if (clsFuncModuleBL.relatedActions != null)
{
clsFuncModuleBL.relatedActions.UpdRelaTabDate(objFuncModuleEN.FuncModuleId, objFuncModuleEN.UpdUser);
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
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFuncModuleEN objFuncModuleEN)
{
try
{
int intRecNum = clsFuncModuleBL.FuncModuleDA.DelRecord(objFuncModuleEN.FuncModuleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModuleBL.ReFreshCache();

if (clsFuncModuleBL.relatedActions != null)
{
clsFuncModuleBL.relatedActions.UpdRelaTabDate(objFuncModuleEN.FuncModuleId, objFuncModuleEN.UpdUser);
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
 /// <param name = "objFuncModuleENS">源对象</param>
 /// <param name = "objFuncModuleENT">目标对象</param>
 public static void CopyTo(this clsFuncModuleEN objFuncModuleENS, clsFuncModuleEN objFuncModuleENT)
{
try
{
objFuncModuleENT.FuncModuleId = objFuncModuleENS.FuncModuleId; //功能模块Id
objFuncModuleENT.FuncModuleName = objFuncModuleENS.FuncModuleName; //功能模块名称
objFuncModuleENT.FuncModuleNameSim = objFuncModuleENS.FuncModuleNameSim; //功能模块简称
objFuncModuleENT.Memo = objFuncModuleENS.Memo; //备注
objFuncModuleENT.UpdDate = objFuncModuleENS.UpdDate; //修改日期
objFuncModuleENT.UpdUser = objFuncModuleENS.UpdUser; //修改人
objFuncModuleENT.OrderNum = objFuncModuleENS.OrderNum; //序号
objFuncModuleENT.PrjId = objFuncModuleENS.PrjId; //PrjId
objFuncModuleENT.FuncModuleEnName = objFuncModuleENS.FuncModuleEnName; //FuncModuleEnName
objFuncModuleENT.UseStateId = objFuncModuleENS.UseStateId; //UseStateId
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
 /// <param name = "objFuncModuleENS">源对象</param>
 /// <returns>目标对象=>clsFuncModuleEN:objFuncModuleENT</returns>
 public static clsFuncModuleEN CopyTo(this clsFuncModuleEN objFuncModuleENS)
{
try
{
 clsFuncModuleEN objFuncModuleENT = new clsFuncModuleEN()
{
FuncModuleId = objFuncModuleENS.FuncModuleId, //功能模块Id
FuncModuleName = objFuncModuleENS.FuncModuleName, //功能模块名称
FuncModuleNameSim = objFuncModuleENS.FuncModuleNameSim, //功能模块简称
Memo = objFuncModuleENS.Memo, //备注
UpdDate = objFuncModuleENS.UpdDate, //修改日期
UpdUser = objFuncModuleENS.UpdUser, //修改人
OrderNum = objFuncModuleENS.OrderNum, //序号
PrjId = objFuncModuleENS.PrjId, //PrjId
FuncModuleEnName = objFuncModuleENS.FuncModuleEnName, //FuncModuleEnName
UseStateId = objFuncModuleENS.UseStateId, //UseStateId
};
 return objFuncModuleENT;
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
public static void CheckPropertyNew(this clsFuncModuleEN objFuncModuleEN)
{
 clsFuncModuleBL.FuncModuleDA.CheckPropertyNew(objFuncModuleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFuncModuleEN objFuncModuleEN)
{
 clsFuncModuleBL.FuncModuleDA.CheckProperty4Condition(objFuncModuleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFuncModuleEN objFuncModuleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFuncModuleCond.IsUpdated(conFuncModule.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objFuncModuleCond.dicFldComparisonOp[conFuncModule.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule.FuncModuleId, objFuncModuleCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objFuncModuleCond.IsUpdated(conFuncModule.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objFuncModuleCond.dicFldComparisonOp[conFuncModule.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule.FuncModuleName, objFuncModuleCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objFuncModuleCond.IsUpdated(conFuncModule.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objFuncModuleCond.dicFldComparisonOp[conFuncModule.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule.FuncModuleNameSim, objFuncModuleCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objFuncModuleCond.IsUpdated(conFuncModule.Memo) == true)
{
string strComparisonOpMemo = objFuncModuleCond.dicFldComparisonOp[conFuncModule.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule.Memo, objFuncModuleCond.Memo, strComparisonOpMemo);
}
if (objFuncModuleCond.IsUpdated(conFuncModule.UpdDate) == true)
{
string strComparisonOpUpdDate = objFuncModuleCond.dicFldComparisonOp[conFuncModule.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule.UpdDate, objFuncModuleCond.UpdDate, strComparisonOpUpdDate);
}
if (objFuncModuleCond.IsUpdated(conFuncModule.UpdUser) == true)
{
string strComparisonOpUpdUser = objFuncModuleCond.dicFldComparisonOp[conFuncModule.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule.UpdUser, objFuncModuleCond.UpdUser, strComparisonOpUpdUser);
}
if (objFuncModuleCond.IsUpdated(conFuncModule.OrderNum) == true)
{
string strComparisonOpOrderNum = objFuncModuleCond.dicFldComparisonOp[conFuncModule.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFuncModule.OrderNum, objFuncModuleCond.OrderNum, strComparisonOpOrderNum);
}
if (objFuncModuleCond.IsUpdated(conFuncModule.PrjId) == true)
{
string strComparisonOpPrjId = objFuncModuleCond.dicFldComparisonOp[conFuncModule.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule.PrjId, objFuncModuleCond.PrjId, strComparisonOpPrjId);
}
if (objFuncModuleCond.IsUpdated(conFuncModule.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objFuncModuleCond.dicFldComparisonOp[conFuncModule.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule.FuncModuleEnName, objFuncModuleCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objFuncModuleCond.IsUpdated(conFuncModule.UseStateId) == true)
{
string strComparisonOpUseStateId = objFuncModuleCond.dicFldComparisonOp[conFuncModule.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule.UseStateId, objFuncModuleCond.UseStateId, strComparisonOpUseStateId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FuncModule
{
public virtual bool UpdRelaTabDate(string strFuncModuleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 功能模块(FuncModule)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFuncModuleBL
{
public static RelatedActions_FuncModule relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFuncModuleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFuncModuleDA FuncModuleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFuncModuleDA();
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
 public clsFuncModuleBL()
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
if (string.IsNullOrEmpty(clsFuncModuleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFuncModuleEN._ConnectString);
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
public static DataTable GetDataTable_FuncModule(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FuncModuleDA.GetDataTable_FuncModule(strWhereCond);
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
objDT = FuncModuleDA.GetDataTable(strWhereCond);
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
objDT = FuncModuleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FuncModuleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FuncModuleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FuncModuleDA.GetDataTable_Top(objTopPara);
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
objDT = FuncModuleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FuncModuleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FuncModuleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncModuleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFuncModuleEN> GetObjLstByFuncModuleIdLst(List<string> arrFuncModuleIdLst)
{
List<clsFuncModuleEN> arrObjLst = new List<clsFuncModuleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncModuleIdLst, true);
 string strWhereCond = string.Format("FuncModuleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN();
try
{
objFuncModuleEN.FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id
objFuncModuleEN.FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModuleEN.FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModuleEN.Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(); //备注
objFuncModuleEN.UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期
objFuncModuleEN.UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(); //修改人
objFuncModuleEN.OrderNum = Int32.Parse(objRow[conFuncModule.OrderNum].ToString().Trim()); //序号
objFuncModuleEN.PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(); //PrjId
objFuncModuleEN.FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName
objFuncModuleEN.UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncModuleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFuncModuleEN> GetObjLstByFuncModuleIdLstCache(List<string> arrFuncModuleIdLst)
{
string strKey = string.Format("{0}", clsFuncModuleEN._CurrTabName);
List<clsFuncModuleEN> arrFuncModuleObjLstCache = GetObjLstCache();
IEnumerable <clsFuncModuleEN> arrFuncModuleObjLst_Sel =
arrFuncModuleObjLstCache
.Where(x => arrFuncModuleIdLst.Contains(x.FuncModuleId));
return arrFuncModuleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncModuleEN> GetObjLst(string strWhereCond)
{
List<clsFuncModuleEN> arrObjLst = new List<clsFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN();
try
{
objFuncModuleEN.FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id
objFuncModuleEN.FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModuleEN.FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModuleEN.Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(); //备注
objFuncModuleEN.UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期
objFuncModuleEN.UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(); //修改人
objFuncModuleEN.OrderNum = Int32.Parse(objRow[conFuncModule.OrderNum].ToString().Trim()); //序号
objFuncModuleEN.PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(); //PrjId
objFuncModuleEN.FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName
objFuncModuleEN.UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModuleEN);
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
public static List<clsFuncModuleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFuncModuleEN> arrObjLst = new List<clsFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN();
try
{
objFuncModuleEN.FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id
objFuncModuleEN.FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModuleEN.FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModuleEN.Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(); //备注
objFuncModuleEN.UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期
objFuncModuleEN.UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(); //修改人
objFuncModuleEN.OrderNum = Int32.Parse(objRow[conFuncModule.OrderNum].ToString().Trim()); //序号
objFuncModuleEN.PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(); //PrjId
objFuncModuleEN.FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName
objFuncModuleEN.UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFuncModuleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFuncModuleEN> GetSubObjLstCache(clsFuncModuleEN objFuncModuleCond)
{
List<clsFuncModuleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFuncModuleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFuncModule.AttributeName)
{
if (objFuncModuleCond.IsUpdated(strFldName) == false) continue;
if (objFuncModuleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncModuleCond[strFldName].ToString());
}
else
{
if (objFuncModuleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFuncModuleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncModuleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFuncModuleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFuncModuleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFuncModuleCond[strFldName]));
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
public static List<clsFuncModuleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFuncModuleEN> arrObjLst = new List<clsFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN();
try
{
objFuncModuleEN.FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id
objFuncModuleEN.FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModuleEN.FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModuleEN.Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(); //备注
objFuncModuleEN.UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期
objFuncModuleEN.UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(); //修改人
objFuncModuleEN.OrderNum = Int32.Parse(objRow[conFuncModule.OrderNum].ToString().Trim()); //序号
objFuncModuleEN.PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(); //PrjId
objFuncModuleEN.FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName
objFuncModuleEN.UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModuleEN);
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
public static List<clsFuncModuleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFuncModuleEN> arrObjLst = new List<clsFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN();
try
{
objFuncModuleEN.FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id
objFuncModuleEN.FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModuleEN.FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModuleEN.Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(); //备注
objFuncModuleEN.UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期
objFuncModuleEN.UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(); //修改人
objFuncModuleEN.OrderNum = Int32.Parse(objRow[conFuncModule.OrderNum].ToString().Trim()); //序号
objFuncModuleEN.PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(); //PrjId
objFuncModuleEN.FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName
objFuncModuleEN.UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModuleEN);
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
List<clsFuncModuleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFuncModuleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncModuleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFuncModuleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFuncModuleEN> arrObjLst = new List<clsFuncModuleEN>(); 
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
	clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN();
try
{
objFuncModuleEN.FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id
objFuncModuleEN.FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModuleEN.FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModuleEN.Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(); //备注
objFuncModuleEN.UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期
objFuncModuleEN.UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(); //修改人
objFuncModuleEN.OrderNum = Int32.Parse(objRow[conFuncModule.OrderNum].ToString().Trim()); //序号
objFuncModuleEN.PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(); //PrjId
objFuncModuleEN.FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName
objFuncModuleEN.UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModuleEN);
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
public static List<clsFuncModuleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFuncModuleEN> arrObjLst = new List<clsFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN();
try
{
objFuncModuleEN.FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id
objFuncModuleEN.FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModuleEN.FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModuleEN.Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(); //备注
objFuncModuleEN.UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期
objFuncModuleEN.UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(); //修改人
objFuncModuleEN.OrderNum = Int32.Parse(objRow[conFuncModule.OrderNum].ToString().Trim()); //序号
objFuncModuleEN.PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(); //PrjId
objFuncModuleEN.FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName
objFuncModuleEN.UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFuncModuleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFuncModuleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFuncModuleEN> arrObjLst = new List<clsFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN();
try
{
objFuncModuleEN.FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id
objFuncModuleEN.FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModuleEN.FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModuleEN.Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(); //备注
objFuncModuleEN.UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期
objFuncModuleEN.UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(); //修改人
objFuncModuleEN.OrderNum = Int32.Parse(objRow[conFuncModule.OrderNum].ToString().Trim()); //序号
objFuncModuleEN.PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(); //PrjId
objFuncModuleEN.FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName
objFuncModuleEN.UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModuleEN);
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
public static List<clsFuncModuleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFuncModuleEN> arrObjLst = new List<clsFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN();
try
{
objFuncModuleEN.FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id
objFuncModuleEN.FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModuleEN.FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModuleEN.Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(); //备注
objFuncModuleEN.UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期
objFuncModuleEN.UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(); //修改人
objFuncModuleEN.OrderNum = Int32.Parse(objRow[conFuncModule.OrderNum].ToString().Trim()); //序号
objFuncModuleEN.PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(); //PrjId
objFuncModuleEN.FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName
objFuncModuleEN.UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncModuleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFuncModuleEN> arrObjLst = new List<clsFuncModuleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN();
try
{
objFuncModuleEN.FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id
objFuncModuleEN.FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModuleEN.FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModuleEN.Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(); //备注
objFuncModuleEN.UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期
objFuncModuleEN.UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(); //修改人
objFuncModuleEN.OrderNum = Int32.Parse(objRow[conFuncModule.OrderNum].ToString().Trim()); //序号
objFuncModuleEN.PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(); //PrjId
objFuncModuleEN.FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName
objFuncModuleEN.UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModuleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFuncModuleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFuncModule(ref clsFuncModuleEN objFuncModuleEN)
{
bool bolResult = FuncModuleDA.GetFuncModule(ref objFuncModuleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncModuleEN GetObjByFuncModuleId(string strFuncModuleId)
{
if (strFuncModuleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncModuleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncModuleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncModuleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsFuncModuleEN objFuncModuleEN = FuncModuleDA.GetObjByFuncModuleId(strFuncModuleId);
return objFuncModuleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFuncModuleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFuncModuleEN objFuncModuleEN = FuncModuleDA.GetFirstObj(strWhereCond);
 return objFuncModuleEN;
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
public static clsFuncModuleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFuncModuleEN objFuncModuleEN = FuncModuleDA.GetObjByDataRow(objRow);
 return objFuncModuleEN;
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
public static clsFuncModuleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFuncModuleEN objFuncModuleEN = FuncModuleDA.GetObjByDataRow(objRow);
 return objFuncModuleEN;
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
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <param name = "lstFuncModuleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFuncModuleEN GetObjByFuncModuleIdFromList(string strFuncModuleId, List<clsFuncModuleEN> lstFuncModuleObjLst)
{
foreach (clsFuncModuleEN objFuncModuleEN in lstFuncModuleObjLst)
{
if (objFuncModuleEN.FuncModuleId == strFuncModuleId)
{
return objFuncModuleEN;
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
 string strFuncModuleId;
 try
 {
 strFuncModuleId = new clsFuncModuleDA().GetFirstID(strWhereCond);
 return strFuncModuleId;
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
 arrList = FuncModuleDA.GetID(strWhereCond);
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
bool bolIsExist = FuncModuleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncModuleId)
{
if (string.IsNullOrEmpty(strFuncModuleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncModuleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = FuncModuleDA.IsExist(strFuncModuleId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strFuncModuleId">功能模块Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strFuncModuleId, string strOpUser)
{
clsFuncModuleEN objFuncModuleEN = clsFuncModuleBL.GetObjByFuncModuleId(strFuncModuleId);
objFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFuncModuleEN.UpdUser = strOpUser;
return clsFuncModuleBL.UpdateBySql2(objFuncModuleEN);
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
 bolIsExist = clsFuncModuleDA.IsExistTable();
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
 bolIsExist = FuncModuleDA.IsExistTable(strTabName);
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
 /// <param name = "objFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFuncModuleEN objFuncModuleEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFuncModuleBL.IsExist(objFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFuncModuleEN.FuncModuleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = FuncModuleDA.AddNewRecordBySQL2(objFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModuleBL.ReFreshCache();

if (clsFuncModuleBL.relatedActions != null)
{
clsFuncModuleBL.relatedActions.UpdRelaTabDate(objFuncModuleEN.FuncModuleId, objFuncModuleEN.UpdUser);
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
 /// <param name = "objFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFuncModuleEN objFuncModuleEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFuncModuleBL.IsExist(objFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFuncModuleEN.FuncModuleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = FuncModuleDA.AddNewRecordBySQL2WithReturnKey(objFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModuleBL.ReFreshCache();

if (clsFuncModuleBL.relatedActions != null)
{
clsFuncModuleBL.relatedActions.UpdRelaTabDate(objFuncModuleEN.FuncModuleId, objFuncModuleEN.UpdUser);
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
 /// <param name = "objFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFuncModuleEN objFuncModuleEN)
{
try
{
bool bolResult = FuncModuleDA.Update(objFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModuleBL.ReFreshCache();

if (clsFuncModuleBL.relatedActions != null)
{
clsFuncModuleBL.relatedActions.UpdRelaTabDate(objFuncModuleEN.FuncModuleId, objFuncModuleEN.UpdUser);
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
 /// <param name = "objFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFuncModuleEN objFuncModuleEN)
{
 if (string.IsNullOrEmpty(objFuncModuleEN.FuncModuleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FuncModuleDA.UpdateBySql2(objFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModuleBL.ReFreshCache();

if (clsFuncModuleBL.relatedActions != null)
{
clsFuncModuleBL.relatedActions.UpdRelaTabDate(objFuncModuleEN.FuncModuleId, objFuncModuleEN.UpdUser);
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
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFuncModuleId)
{
try
{
 clsFuncModuleEN objFuncModuleEN = clsFuncModuleBL.GetObjByFuncModuleId(strFuncModuleId);

if (clsFuncModuleBL.relatedActions != null)
{
clsFuncModuleBL.relatedActions.UpdRelaTabDate(objFuncModuleEN.FuncModuleId, objFuncModuleEN.UpdUser);
}
if (objFuncModuleEN != null)
{
int intRecNum = FuncModuleDA.DelRecord(strFuncModuleId);
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
/// <param name="strFuncModuleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strFuncModuleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFuncModuleDA.GetSpecSQLObj();
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
//删除与表:[FuncModule]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFuncModule.FuncModuleId,
//strFuncModuleId);
//        clsFuncModuleBL.DelFuncModulesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFuncModuleBL.DelRecord(strFuncModuleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFuncModuleBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncModuleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFuncModuleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFuncModuleBL.relatedActions != null)
{
clsFuncModuleBL.relatedActions.UpdRelaTabDate(strFuncModuleId, "UpdRelaTabDate");
}
bool bolResult = FuncModuleDA.DelRecord(strFuncModuleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFuncModuleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFuncModules(List<string> arrFuncModuleIdLst)
{
if (arrFuncModuleIdLst.Count == 0) return 0;
try
{
if (clsFuncModuleBL.relatedActions != null)
{
foreach (var strFuncModuleId in arrFuncModuleIdLst)
{
clsFuncModuleBL.relatedActions.UpdRelaTabDate(strFuncModuleId, "UpdRelaTabDate");
}
}
int intDelRecNum = FuncModuleDA.DelFuncModule(arrFuncModuleIdLst);
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
public static int DelFuncModulesByCond(string strWhereCond)
{
try
{
if (clsFuncModuleBL.relatedActions != null)
{
List<string> arrFuncModuleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFuncModuleId in arrFuncModuleId)
{
clsFuncModuleBL.relatedActions.UpdRelaTabDate(strFuncModuleId, "UpdRelaTabDate");
}
}
int intRecNum = FuncModuleDA.DelFuncModule(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FuncModule]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFuncModuleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFuncModuleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFuncModuleDA.GetSpecSQLObj();
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
//删除与表:[FuncModule]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFuncModuleBL.DelRecord(strFuncModuleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFuncModuleBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncModuleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFuncModuleENS">源对象</param>
 /// <param name = "objFuncModuleENT">目标对象</param>
 public static void CopyTo(clsFuncModuleEN objFuncModuleENS, clsFuncModuleEN objFuncModuleENT)
{
try
{
objFuncModuleENT.FuncModuleId = objFuncModuleENS.FuncModuleId; //功能模块Id
objFuncModuleENT.FuncModuleName = objFuncModuleENS.FuncModuleName; //功能模块名称
objFuncModuleENT.FuncModuleNameSim = objFuncModuleENS.FuncModuleNameSim; //功能模块简称
objFuncModuleENT.Memo = objFuncModuleENS.Memo; //备注
objFuncModuleENT.UpdDate = objFuncModuleENS.UpdDate; //修改日期
objFuncModuleENT.UpdUser = objFuncModuleENS.UpdUser; //修改人
objFuncModuleENT.OrderNum = objFuncModuleENS.OrderNum; //序号
objFuncModuleENT.PrjId = objFuncModuleENS.PrjId; //PrjId
objFuncModuleENT.FuncModuleEnName = objFuncModuleENS.FuncModuleEnName; //FuncModuleEnName
objFuncModuleENT.UseStateId = objFuncModuleENS.UseStateId; //UseStateId
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
 /// <param name = "objFuncModuleEN">源简化对象</param>
 public static void SetUpdFlag(clsFuncModuleEN objFuncModuleEN)
{
try
{
objFuncModuleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFuncModuleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFuncModule.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModuleEN.FuncModuleId = objFuncModuleEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(conFuncModule.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModuleEN.FuncModuleName = objFuncModuleEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(conFuncModule.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModuleEN.FuncModuleNameSim = objFuncModuleEN.FuncModuleNameSim == "[null]" ? null :  objFuncModuleEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(conFuncModule.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModuleEN.Memo = objFuncModuleEN.Memo == "[null]" ? null :  objFuncModuleEN.Memo; //备注
}
if (arrFldSet.Contains(conFuncModule.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModuleEN.UpdDate = objFuncModuleEN.UpdDate == "[null]" ? null :  objFuncModuleEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFuncModule.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModuleEN.UpdUser = objFuncModuleEN.UpdUser == "[null]" ? null :  objFuncModuleEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conFuncModule.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModuleEN.OrderNum = objFuncModuleEN.OrderNum; //序号
}
if (arrFldSet.Contains(conFuncModule.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModuleEN.PrjId = objFuncModuleEN.PrjId == "[null]" ? null :  objFuncModuleEN.PrjId; //PrjId
}
if (arrFldSet.Contains(conFuncModule.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModuleEN.FuncModuleEnName = objFuncModuleEN.FuncModuleEnName == "[null]" ? null :  objFuncModuleEN.FuncModuleEnName; //FuncModuleEnName
}
if (arrFldSet.Contains(conFuncModule.UseStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModuleEN.UseStateId = objFuncModuleEN.UseStateId; //UseStateId
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
 /// <param name = "objFuncModuleEN">源简化对象</param>
 public static void AccessFldValueNull(clsFuncModuleEN objFuncModuleEN)
{
try
{
if (objFuncModuleEN.FuncModuleNameSim == "[null]") objFuncModuleEN.FuncModuleNameSim = null; //功能模块简称
if (objFuncModuleEN.Memo == "[null]") objFuncModuleEN.Memo = null; //备注
if (objFuncModuleEN.UpdDate == "[null]") objFuncModuleEN.UpdDate = null; //修改日期
if (objFuncModuleEN.UpdUser == "[null]") objFuncModuleEN.UpdUser = null; //修改人
if (objFuncModuleEN.PrjId == "[null]") objFuncModuleEN.PrjId = null; //PrjId
if (objFuncModuleEN.FuncModuleEnName == "[null]") objFuncModuleEN.FuncModuleEnName = null; //FuncModuleEnName
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
public static void CheckPropertyNew(clsFuncModuleEN objFuncModuleEN)
{
 FuncModuleDA.CheckPropertyNew(objFuncModuleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFuncModuleEN objFuncModuleEN)
{
 FuncModuleDA.CheckProperty4Condition(objFuncModuleEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FuncModuleIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[功能模块]...","0");
List<clsFuncModuleEN> arrFuncModuleObjLst = GetAllFuncModuleObjLstCache(); 
objDDL.DataValueField = conFuncModule.FuncModuleId;
objDDL.DataTextField = conFuncModule.FuncModuleName;
objDDL.DataSource = arrFuncModuleObjLst;
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
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncModuleId");
//if (arrFuncModuleObjLstCache == null)
//{
//arrFuncModuleObjLstCache = FuncModuleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFuncModuleEN GetObjByFuncModuleIdCache(string strFuncModuleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFuncModuleEN._CurrTabName);
List<clsFuncModuleEN> arrFuncModuleObjLstCache = GetObjLstCache();
IEnumerable <clsFuncModuleEN> arrFuncModuleObjLst_Sel =
arrFuncModuleObjLstCache
.Where(x=> x.FuncModuleId == strFuncModuleId 
);
if (arrFuncModuleObjLst_Sel.Count() == 0)
{
   clsFuncModuleEN obj = clsFuncModuleBL.GetObjByFuncModuleId(strFuncModuleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFuncModuleObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncModuleNameByFuncModuleIdCache(string strFuncModuleId)
{
if (string.IsNullOrEmpty(strFuncModuleId) == true) return "";
//获取缓存中的对象列表
clsFuncModuleEN objFuncModule = GetObjByFuncModuleIdCache(strFuncModuleId);
if (objFuncModule == null) return "";
return objFuncModule.FuncModuleName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncModuleIdCache(string strFuncModuleId)
{
if (string.IsNullOrEmpty(strFuncModuleId) == true) return "";
//获取缓存中的对象列表
clsFuncModuleEN objFuncModule = GetObjByFuncModuleIdCache(strFuncModuleId);
if (objFuncModule == null) return "";
return objFuncModule.FuncModuleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFuncModuleEN> GetAllFuncModuleObjLstCache()
{
//获取缓存中的对象列表
List<clsFuncModuleEN> arrFuncModuleObjLstCache = GetObjLstCache(); 
return arrFuncModuleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFuncModuleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFuncModuleEN._CurrTabName);
List<clsFuncModuleEN> arrFuncModuleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFuncModuleObjLstCache;
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
string strKey = string.Format("{0}", clsFuncModuleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFuncModuleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFuncModuleEN._RefreshTimeLst.Count == 0) return "";
return clsFuncModuleEN._RefreshTimeLst[clsFuncModuleEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFuncModuleBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFuncModuleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFuncModuleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFuncModuleBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strFuncModuleId)
{
if (strInFldName != conFuncModule.FuncModuleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFuncModule.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFuncModule.AttributeName));
throw new Exception(strMsg);
}
var objFuncModule = clsFuncModuleBL.GetObjByFuncModuleIdCache(strFuncModuleId);
if (objFuncModule == null) return "";
return objFuncModule[strOutFldName].ToString();
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
int intRecCount = clsFuncModuleDA.GetRecCount(strTabName);
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
int intRecCount = clsFuncModuleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFuncModuleDA.GetRecCount();
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
int intRecCount = clsFuncModuleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFuncModuleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFuncModuleEN objFuncModuleCond)
{
List<clsFuncModuleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFuncModuleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFuncModule.AttributeName)
{
if (objFuncModuleCond.IsUpdated(strFldName) == false) continue;
if (objFuncModuleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncModuleCond[strFldName].ToString());
}
else
{
if (objFuncModuleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFuncModuleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncModuleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFuncModuleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFuncModuleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFuncModuleCond[strFldName]));
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
 List<string> arrList = clsFuncModuleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FuncModuleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FuncModuleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FuncModuleDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFuncModuleDA.SetFldValue(clsFuncModuleEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FuncModuleDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFuncModuleDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFuncModuleDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFuncModuleDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FuncModule] "); 
 strCreateTabCode.Append(" ( "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) primary key, "); 
 // /**功能模块名称*/ 
 strCreateTabCode.Append(" FuncModuleName varchar(30) not Null, "); 
 // /**功能模块简称*/ 
 strCreateTabCode.Append(" FuncModuleNameSim varchar(30) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**PrjId*/ 
 strCreateTabCode.Append(" PrjId char(4) Null, "); 
 // /**FuncModuleEnName*/ 
 strCreateTabCode.Append(" FuncModuleEnName varchar(30) Null, "); 
 // /**UseStateId*/ 
 strCreateTabCode.Append(" UseStateId char(4) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 功能模块(FuncModule)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FuncModule : clsCommFun4BL
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
clsFuncModuleBL.ReFreshThisCache();
}
}

}