﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionReferedFeatureBL
 表名:FunctionReferedFeature(00050340)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:49:30
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsFunctionReferedFeatureBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionReferedFeatureEN GetObj(this K_mId_FunctionReferedFeature myKey)
{
clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = clsFunctionReferedFeatureBL.FunctionReferedFeatureDA.GetObjBymId(myKey.Value);
return objFunctionReferedFeatureEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFunctionReferedFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFunctionReferedFeatureEN) == false)
{
var strMsg = string.Format("记录已经存在!功能Id = [{0}],函数ID = [{1}]的数据已经存在!(in clsFunctionReferedFeatureBL.AddNewRecord)", objFunctionReferedFeatureEN.FeatureId,objFunctionReferedFeatureEN.FuncId4GC);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsFunctionReferedFeatureBL.FunctionReferedFeatureDA.AddNewRecordBySQL2(objFunctionReferedFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionReferedFeatureBL.ReFreshCache();

if (clsFunctionReferedFeatureBL.relatedActions != null)
{
clsFunctionReferedFeatureBL.relatedActions.UpdRelaTabDate(objFunctionReferedFeatureEN.mId, objFunctionReferedFeatureEN.UpdUser);
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
public static bool AddRecordEx(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN, bool bolIsNeedCheckUniqueness = true)
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
objFunctionReferedFeatureEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFunctionReferedFeatureEN.CheckUniqueness() == false)
{
strMsg = string.Format("(功能Id(FeatureId)=[{0}],函数ID(FuncId4GC)=[{1}])已经存在,不能重复!", objFunctionReferedFeatureEN.FeatureId, objFunctionReferedFeatureEN.FuncId4GC);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objFunctionReferedFeatureEN.AddNewRecord();
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
 /// <param name = "objFunctionReferedFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFunctionReferedFeatureEN) == false)
{
var strMsg = string.Format("记录已经存在!功能Id = [{0}],函数ID = [{1}]的数据已经存在!(in clsFunctionReferedFeatureBL.AddNewRecordWithReturnKey)", objFunctionReferedFeatureEN.FeatureId,objFunctionReferedFeatureEN.FuncId4GC);
throw new Exception(strMsg);
}
try
{
string strKey = clsFunctionReferedFeatureBL.FunctionReferedFeatureDA.AddNewRecordBySQL2WithReturnKey(objFunctionReferedFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionReferedFeatureBL.ReFreshCache();

if (clsFunctionReferedFeatureBL.relatedActions != null)
{
clsFunctionReferedFeatureBL.relatedActions.UpdRelaTabDate(objFunctionReferedFeatureEN.mId, objFunctionReferedFeatureEN.UpdUser);
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
 /// <param name = "objFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionReferedFeatureEN SetmId(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN, long lngmId, string strComparisonOp="")
	{
objFunctionReferedFeatureEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(conFunctionReferedFeature.mId) == false)
{
objFunctionReferedFeatureEN.dicFldComparisonOp.Add(conFunctionReferedFeature.mId, strComparisonOp);
}
else
{
objFunctionReferedFeatureEN.dicFldComparisonOp[conFunctionReferedFeature.mId] = strComparisonOp;
}
}
return objFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionReferedFeatureEN SetFeatureId(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, conFunctionReferedFeature.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, conFunctionReferedFeature.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, conFunctionReferedFeature.FeatureId);
}
objFunctionReferedFeatureEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(conFunctionReferedFeature.FeatureId) == false)
{
objFunctionReferedFeatureEN.dicFldComparisonOp.Add(conFunctionReferedFeature.FeatureId, strComparisonOp);
}
else
{
objFunctionReferedFeatureEN.dicFldComparisonOp[conFunctionReferedFeature.FeatureId] = strComparisonOp;
}
}
return objFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionReferedFeatureEN SetFuncId4GC(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4GC, conFunctionReferedFeature.FuncId4GC);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, conFunctionReferedFeature.FuncId4GC);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, conFunctionReferedFeature.FuncId4GC);
}
objFunctionReferedFeatureEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(conFunctionReferedFeature.FuncId4GC) == false)
{
objFunctionReferedFeatureEN.dicFldComparisonOp.Add(conFunctionReferedFeature.FuncId4GC, strComparisonOp);
}
else
{
objFunctionReferedFeatureEN.dicFldComparisonOp[conFunctionReferedFeature.FuncId4GC] = strComparisonOp;
}
}
return objFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionReferedFeatureEN SetFuncId4Invoked(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN, string strFuncId4Invoked, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4Invoked, conFunctionReferedFeature.FuncId4Invoked);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4Invoked, 10, conFunctionReferedFeature.FuncId4Invoked);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4Invoked, 10, conFunctionReferedFeature.FuncId4Invoked);
}
objFunctionReferedFeatureEN.FuncId4Invoked = strFuncId4Invoked; //被调用函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(conFunctionReferedFeature.FuncId4Invoked) == false)
{
objFunctionReferedFeatureEN.dicFldComparisonOp.Add(conFunctionReferedFeature.FuncId4Invoked, strComparisonOp);
}
else
{
objFunctionReferedFeatureEN.dicFldComparisonOp[conFunctionReferedFeature.FuncId4Invoked] = strComparisonOp;
}
}
return objFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionReferedFeatureEN SetUpdDate(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFunctionReferedFeature.UpdDate);
}
objFunctionReferedFeatureEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(conFunctionReferedFeature.UpdDate) == false)
{
objFunctionReferedFeatureEN.dicFldComparisonOp.Add(conFunctionReferedFeature.UpdDate, strComparisonOp);
}
else
{
objFunctionReferedFeatureEN.dicFldComparisonOp[conFunctionReferedFeature.UpdDate] = strComparisonOp;
}
}
return objFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionReferedFeatureEN SetUpdUser(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFunctionReferedFeature.UpdUser);
}
objFunctionReferedFeatureEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(conFunctionReferedFeature.UpdUser) == false)
{
objFunctionReferedFeatureEN.dicFldComparisonOp.Add(conFunctionReferedFeature.UpdUser, strComparisonOp);
}
else
{
objFunctionReferedFeatureEN.dicFldComparisonOp[conFunctionReferedFeature.UpdUser] = strComparisonOp;
}
}
return objFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionReferedFeatureEN SetMemo(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFunctionReferedFeature.Memo);
}
objFunctionReferedFeatureEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(conFunctionReferedFeature.Memo) == false)
{
objFunctionReferedFeatureEN.dicFldComparisonOp.Add(conFunctionReferedFeature.Memo, strComparisonOp);
}
else
{
objFunctionReferedFeatureEN.dicFldComparisonOp[conFunctionReferedFeature.Memo] = strComparisonOp;
}
}
return objFunctionReferedFeatureEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFunctionReferedFeatureEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFunctionReferedFeatureEN.CheckPropertyNew();
clsFunctionReferedFeatureEN objFunctionReferedFeatureCond = new clsFunctionReferedFeatureEN();
string strCondition = objFunctionReferedFeatureCond
.SetmId(objFunctionReferedFeatureEN.mId, "<>")
.SetFeatureId(objFunctionReferedFeatureEN.FeatureId, "=")
.SetFuncId4GC(objFunctionReferedFeatureEN.FuncId4GC, "=")
.GetCombineCondition();
objFunctionReferedFeatureEN._IsCheckProperty = true;
bool bolIsExist = clsFunctionReferedFeatureBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FeatureId_FuncId4GC)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFunctionReferedFeatureEN.Update();
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
 /// <param name = "objFunctionReferedFeature">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFunctionReferedFeatureEN objFunctionReferedFeature)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFunctionReferedFeatureEN objFunctionReferedFeatureCond = new clsFunctionReferedFeatureEN();
string strCondition = objFunctionReferedFeatureCond
.SetFeatureId(objFunctionReferedFeature.FeatureId, "=")
.SetFuncId4GC(objFunctionReferedFeature.FuncId4GC, "=")
.GetCombineCondition();
objFunctionReferedFeature._IsCheckProperty = true;
bool bolIsExist = clsFunctionReferedFeatureBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFunctionReferedFeature.mId = clsFunctionReferedFeatureBL.GetFirstID_S(strCondition);
objFunctionReferedFeature.UpdateWithCondition(strCondition);
}
else
{
objFunctionReferedFeature.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFunctionReferedFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN)
{
 if (objFunctionReferedFeatureEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunctionReferedFeatureBL.FunctionReferedFeatureDA.UpdateBySql2(objFunctionReferedFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionReferedFeatureBL.ReFreshCache();

if (clsFunctionReferedFeatureBL.relatedActions != null)
{
clsFunctionReferedFeatureBL.relatedActions.UpdRelaTabDate(objFunctionReferedFeatureEN.mId, objFunctionReferedFeatureEN.UpdUser);
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
 /// <param name = "objFunctionReferedFeatureEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFunctionReferedFeatureEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunctionReferedFeatureBL.FunctionReferedFeatureDA.UpdateBySql2(objFunctionReferedFeatureEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionReferedFeatureBL.ReFreshCache();

if (clsFunctionReferedFeatureBL.relatedActions != null)
{
clsFunctionReferedFeatureBL.relatedActions.UpdRelaTabDate(objFunctionReferedFeatureEN.mId, objFunctionReferedFeatureEN.UpdUser);
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
 /// <param name = "objFunctionReferedFeatureEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN, string strWhereCond)
{
try
{
bool bolResult = clsFunctionReferedFeatureBL.FunctionReferedFeatureDA.UpdateBySqlWithCondition(objFunctionReferedFeatureEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionReferedFeatureBL.ReFreshCache();

if (clsFunctionReferedFeatureBL.relatedActions != null)
{
clsFunctionReferedFeatureBL.relatedActions.UpdRelaTabDate(objFunctionReferedFeatureEN.mId, objFunctionReferedFeatureEN.UpdUser);
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
 /// <param name = "objFunctionReferedFeatureEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFunctionReferedFeatureBL.FunctionReferedFeatureDA.UpdateBySqlWithConditionTransaction(objFunctionReferedFeatureEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionReferedFeatureBL.ReFreshCache();

if (clsFunctionReferedFeatureBL.relatedActions != null)
{
clsFunctionReferedFeatureBL.relatedActions.UpdRelaTabDate(objFunctionReferedFeatureEN.mId, objFunctionReferedFeatureEN.UpdUser);
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
public static int Delete(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN)
{
try
{
int intRecNum = clsFunctionReferedFeatureBL.FunctionReferedFeatureDA.DelRecord(objFunctionReferedFeatureEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionReferedFeatureBL.ReFreshCache();

if (clsFunctionReferedFeatureBL.relatedActions != null)
{
clsFunctionReferedFeatureBL.relatedActions.UpdRelaTabDate(objFunctionReferedFeatureEN.mId, objFunctionReferedFeatureEN.UpdUser);
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
 /// <param name = "objFunctionReferedFeatureENS">源对象</param>
 /// <param name = "objFunctionReferedFeatureENT">目标对象</param>
 public static void CopyTo(this clsFunctionReferedFeatureEN objFunctionReferedFeatureENS, clsFunctionReferedFeatureEN objFunctionReferedFeatureENT)
{
try
{
objFunctionReferedFeatureENT.mId = objFunctionReferedFeatureENS.mId; //mId
objFunctionReferedFeatureENT.FeatureId = objFunctionReferedFeatureENS.FeatureId; //功能Id
objFunctionReferedFeatureENT.FuncId4GC = objFunctionReferedFeatureENS.FuncId4GC; //函数ID
objFunctionReferedFeatureENT.FuncId4Invoked = objFunctionReferedFeatureENS.FuncId4Invoked; //被调用函数
objFunctionReferedFeatureENT.UpdDate = objFunctionReferedFeatureENS.UpdDate; //修改日期
objFunctionReferedFeatureENT.UpdUser = objFunctionReferedFeatureENS.UpdUser; //修改者
objFunctionReferedFeatureENT.Memo = objFunctionReferedFeatureENS.Memo; //说明
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
 /// <param name = "objFunctionReferedFeatureENS">源对象</param>
 /// <returns>目标对象=>clsFunctionReferedFeatureEN:objFunctionReferedFeatureENT</returns>
 public static clsFunctionReferedFeatureEN CopyTo(this clsFunctionReferedFeatureEN objFunctionReferedFeatureENS)
{
try
{
 clsFunctionReferedFeatureEN objFunctionReferedFeatureENT = new clsFunctionReferedFeatureEN()
{
mId = objFunctionReferedFeatureENS.mId, //mId
FeatureId = objFunctionReferedFeatureENS.FeatureId, //功能Id
FuncId4GC = objFunctionReferedFeatureENS.FuncId4GC, //函数ID
FuncId4Invoked = objFunctionReferedFeatureENS.FuncId4Invoked, //被调用函数
UpdDate = objFunctionReferedFeatureENS.UpdDate, //修改日期
UpdUser = objFunctionReferedFeatureENS.UpdUser, //修改者
Memo = objFunctionReferedFeatureENS.Memo, //说明
};
 return objFunctionReferedFeatureENT;
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
public static void CheckPropertyNew(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN)
{
 clsFunctionReferedFeatureBL.FunctionReferedFeatureDA.CheckPropertyNew(objFunctionReferedFeatureEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN)
{
 clsFunctionReferedFeatureBL.FunctionReferedFeatureDA.CheckProperty4Condition(objFunctionReferedFeatureEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFunctionReferedFeatureEN objFunctionReferedFeatureCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFunctionReferedFeatureCond.IsUpdated(conFunctionReferedFeature.mId) == true)
{
string strComparisonOpmId = objFunctionReferedFeatureCond.dicFldComparisonOp[conFunctionReferedFeature.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conFunctionReferedFeature.mId, objFunctionReferedFeatureCond.mId, strComparisonOpmId);
}
if (objFunctionReferedFeatureCond.IsUpdated(conFunctionReferedFeature.FeatureId) == true)
{
string strComparisonOpFeatureId = objFunctionReferedFeatureCond.dicFldComparisonOp[conFunctionReferedFeature.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionReferedFeature.FeatureId, objFunctionReferedFeatureCond.FeatureId, strComparisonOpFeatureId);
}
if (objFunctionReferedFeatureCond.IsUpdated(conFunctionReferedFeature.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objFunctionReferedFeatureCond.dicFldComparisonOp[conFunctionReferedFeature.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionReferedFeature.FuncId4GC, objFunctionReferedFeatureCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objFunctionReferedFeatureCond.IsUpdated(conFunctionReferedFeature.FuncId4Invoked) == true)
{
string strComparisonOpFuncId4Invoked = objFunctionReferedFeatureCond.dicFldComparisonOp[conFunctionReferedFeature.FuncId4Invoked];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionReferedFeature.FuncId4Invoked, objFunctionReferedFeatureCond.FuncId4Invoked, strComparisonOpFuncId4Invoked);
}
if (objFunctionReferedFeatureCond.IsUpdated(conFunctionReferedFeature.UpdDate) == true)
{
string strComparisonOpUpdDate = objFunctionReferedFeatureCond.dicFldComparisonOp[conFunctionReferedFeature.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionReferedFeature.UpdDate, objFunctionReferedFeatureCond.UpdDate, strComparisonOpUpdDate);
}
if (objFunctionReferedFeatureCond.IsUpdated(conFunctionReferedFeature.UpdUser) == true)
{
string strComparisonOpUpdUser = objFunctionReferedFeatureCond.dicFldComparisonOp[conFunctionReferedFeature.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionReferedFeature.UpdUser, objFunctionReferedFeatureCond.UpdUser, strComparisonOpUpdUser);
}
if (objFunctionReferedFeatureCond.IsUpdated(conFunctionReferedFeature.Memo) == true)
{
string strComparisonOpMemo = objFunctionReferedFeatureCond.dicFldComparisonOp[conFunctionReferedFeature.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionReferedFeature.Memo, objFunctionReferedFeatureCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FunctionReferedFeature(功能相关函数), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FeatureId_FuncId4GC
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFunctionReferedFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFunctionReferedFeatureEN == null) return true;
if (objFunctionReferedFeatureEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFunctionReferedFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objFunctionReferedFeatureEN.FuncId4GC);
if (clsFunctionReferedFeatureBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFunctionReferedFeatureEN.mId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFunctionReferedFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objFunctionReferedFeatureEN.FuncId4GC);
if (clsFunctionReferedFeatureBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FunctionReferedFeature(功能相关函数), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FeatureId_FuncId4GC
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFunctionReferedFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFunctionReferedFeatureEN objFunctionReferedFeatureEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFunctionReferedFeatureEN == null) return "";
if (objFunctionReferedFeatureEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFunctionReferedFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objFunctionReferedFeatureEN.FuncId4GC);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFunctionReferedFeatureEN.mId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFunctionReferedFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objFunctionReferedFeatureEN.FuncId4GC);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FunctionReferedFeature
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 功能相关函数(FunctionReferedFeature)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFunctionReferedFeatureBL
{
public static RelatedActions_FunctionReferedFeature relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFunctionReferedFeatureDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFunctionReferedFeatureDA FunctionReferedFeatureDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFunctionReferedFeatureDA();
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
 public clsFunctionReferedFeatureBL()
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
if (string.IsNullOrEmpty(clsFunctionReferedFeatureEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFunctionReferedFeatureEN._ConnectString);
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
public static DataTable GetDataTable_FunctionReferedFeature(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FunctionReferedFeatureDA.GetDataTable_FunctionReferedFeature(strWhereCond);
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
objDT = FunctionReferedFeatureDA.GetDataTable(strWhereCond);
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
objDT = FunctionReferedFeatureDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FunctionReferedFeatureDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FunctionReferedFeatureDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FunctionReferedFeatureDA.GetDataTable_Top(objTopPara);
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
objDT = FunctionReferedFeatureDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FunctionReferedFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FunctionReferedFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsFunctionReferedFeatureEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsFunctionReferedFeatureEN> arrObjLst = new List<clsFunctionReferedFeatureEN>(); 
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
	clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = new clsFunctionReferedFeatureEN();
try
{
objFunctionReferedFeatureEN.mId = Int32.Parse(objRow[conFunctionReferedFeature.mId].ToString().Trim()); //mId
objFunctionReferedFeatureEN.FeatureId = objRow[conFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objFunctionReferedFeatureEN.FuncId4GC = objRow[conFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objFunctionReferedFeatureEN.FuncId4Invoked = objRow[conFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objFunctionReferedFeatureEN.UpdDate = objRow[conFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objFunctionReferedFeatureEN.UpdUser = objRow[conFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objFunctionReferedFeatureEN.Memo = objRow[conFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[conFunctionReferedFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionReferedFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFunctionReferedFeatureEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsFunctionReferedFeatureEN._CurrTabName);
List<clsFunctionReferedFeatureEN> arrFunctionReferedFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionReferedFeatureEN> arrFunctionReferedFeatureObjLst_Sel =
arrFunctionReferedFeatureObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrFunctionReferedFeatureObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionReferedFeatureEN> GetObjLst(string strWhereCond)
{
List<clsFunctionReferedFeatureEN> arrObjLst = new List<clsFunctionReferedFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = new clsFunctionReferedFeatureEN();
try
{
objFunctionReferedFeatureEN.mId = Int32.Parse(objRow[conFunctionReferedFeature.mId].ToString().Trim()); //mId
objFunctionReferedFeatureEN.FeatureId = objRow[conFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objFunctionReferedFeatureEN.FuncId4GC = objRow[conFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objFunctionReferedFeatureEN.FuncId4Invoked = objRow[conFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objFunctionReferedFeatureEN.UpdDate = objRow[conFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objFunctionReferedFeatureEN.UpdUser = objRow[conFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objFunctionReferedFeatureEN.Memo = objRow[conFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[conFunctionReferedFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionReferedFeatureEN);
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
public static List<clsFunctionReferedFeatureEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFunctionReferedFeatureEN> arrObjLst = new List<clsFunctionReferedFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = new clsFunctionReferedFeatureEN();
try
{
objFunctionReferedFeatureEN.mId = Int32.Parse(objRow[conFunctionReferedFeature.mId].ToString().Trim()); //mId
objFunctionReferedFeatureEN.FeatureId = objRow[conFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objFunctionReferedFeatureEN.FuncId4GC = objRow[conFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objFunctionReferedFeatureEN.FuncId4Invoked = objRow[conFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objFunctionReferedFeatureEN.UpdDate = objRow[conFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objFunctionReferedFeatureEN.UpdUser = objRow[conFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objFunctionReferedFeatureEN.Memo = objRow[conFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[conFunctionReferedFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionReferedFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFunctionReferedFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFunctionReferedFeatureEN> GetSubObjLstCache(clsFunctionReferedFeatureEN objFunctionReferedFeatureCond)
{
List<clsFunctionReferedFeatureEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionReferedFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunctionReferedFeature.AttributeName)
{
if (objFunctionReferedFeatureCond.IsUpdated(strFldName) == false) continue;
if (objFunctionReferedFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionReferedFeatureCond[strFldName].ToString());
}
else
{
if (objFunctionReferedFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunctionReferedFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionReferedFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunctionReferedFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunctionReferedFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunctionReferedFeatureCond[strFldName]));
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
public static List<clsFunctionReferedFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFunctionReferedFeatureEN> arrObjLst = new List<clsFunctionReferedFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = new clsFunctionReferedFeatureEN();
try
{
objFunctionReferedFeatureEN.mId = Int32.Parse(objRow[conFunctionReferedFeature.mId].ToString().Trim()); //mId
objFunctionReferedFeatureEN.FeatureId = objRow[conFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objFunctionReferedFeatureEN.FuncId4GC = objRow[conFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objFunctionReferedFeatureEN.FuncId4Invoked = objRow[conFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objFunctionReferedFeatureEN.UpdDate = objRow[conFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objFunctionReferedFeatureEN.UpdUser = objRow[conFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objFunctionReferedFeatureEN.Memo = objRow[conFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[conFunctionReferedFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionReferedFeatureEN);
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
public static List<clsFunctionReferedFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFunctionReferedFeatureEN> arrObjLst = new List<clsFunctionReferedFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = new clsFunctionReferedFeatureEN();
try
{
objFunctionReferedFeatureEN.mId = Int32.Parse(objRow[conFunctionReferedFeature.mId].ToString().Trim()); //mId
objFunctionReferedFeatureEN.FeatureId = objRow[conFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objFunctionReferedFeatureEN.FuncId4GC = objRow[conFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objFunctionReferedFeatureEN.FuncId4Invoked = objRow[conFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objFunctionReferedFeatureEN.UpdDate = objRow[conFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objFunctionReferedFeatureEN.UpdUser = objRow[conFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objFunctionReferedFeatureEN.Memo = objRow[conFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[conFunctionReferedFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionReferedFeatureEN);
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
List<clsFunctionReferedFeatureEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFunctionReferedFeatureEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionReferedFeatureEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFunctionReferedFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFunctionReferedFeatureEN> arrObjLst = new List<clsFunctionReferedFeatureEN>(); 
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
	clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = new clsFunctionReferedFeatureEN();
try
{
objFunctionReferedFeatureEN.mId = Int32.Parse(objRow[conFunctionReferedFeature.mId].ToString().Trim()); //mId
objFunctionReferedFeatureEN.FeatureId = objRow[conFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objFunctionReferedFeatureEN.FuncId4GC = objRow[conFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objFunctionReferedFeatureEN.FuncId4Invoked = objRow[conFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objFunctionReferedFeatureEN.UpdDate = objRow[conFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objFunctionReferedFeatureEN.UpdUser = objRow[conFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objFunctionReferedFeatureEN.Memo = objRow[conFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[conFunctionReferedFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionReferedFeatureEN);
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
public static List<clsFunctionReferedFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFunctionReferedFeatureEN> arrObjLst = new List<clsFunctionReferedFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = new clsFunctionReferedFeatureEN();
try
{
objFunctionReferedFeatureEN.mId = Int32.Parse(objRow[conFunctionReferedFeature.mId].ToString().Trim()); //mId
objFunctionReferedFeatureEN.FeatureId = objRow[conFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objFunctionReferedFeatureEN.FuncId4GC = objRow[conFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objFunctionReferedFeatureEN.FuncId4Invoked = objRow[conFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objFunctionReferedFeatureEN.UpdDate = objRow[conFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objFunctionReferedFeatureEN.UpdUser = objRow[conFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objFunctionReferedFeatureEN.Memo = objRow[conFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[conFunctionReferedFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionReferedFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFunctionReferedFeatureEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFunctionReferedFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFunctionReferedFeatureEN> arrObjLst = new List<clsFunctionReferedFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = new clsFunctionReferedFeatureEN();
try
{
objFunctionReferedFeatureEN.mId = Int32.Parse(objRow[conFunctionReferedFeature.mId].ToString().Trim()); //mId
objFunctionReferedFeatureEN.FeatureId = objRow[conFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objFunctionReferedFeatureEN.FuncId4GC = objRow[conFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objFunctionReferedFeatureEN.FuncId4Invoked = objRow[conFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objFunctionReferedFeatureEN.UpdDate = objRow[conFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objFunctionReferedFeatureEN.UpdUser = objRow[conFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objFunctionReferedFeatureEN.Memo = objRow[conFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[conFunctionReferedFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionReferedFeatureEN);
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
public static List<clsFunctionReferedFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFunctionReferedFeatureEN> arrObjLst = new List<clsFunctionReferedFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = new clsFunctionReferedFeatureEN();
try
{
objFunctionReferedFeatureEN.mId = Int32.Parse(objRow[conFunctionReferedFeature.mId].ToString().Trim()); //mId
objFunctionReferedFeatureEN.FeatureId = objRow[conFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objFunctionReferedFeatureEN.FuncId4GC = objRow[conFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objFunctionReferedFeatureEN.FuncId4Invoked = objRow[conFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objFunctionReferedFeatureEN.UpdDate = objRow[conFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objFunctionReferedFeatureEN.UpdUser = objRow[conFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objFunctionReferedFeatureEN.Memo = objRow[conFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[conFunctionReferedFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionReferedFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionReferedFeatureEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFunctionReferedFeatureEN> arrObjLst = new List<clsFunctionReferedFeatureEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = new clsFunctionReferedFeatureEN();
try
{
objFunctionReferedFeatureEN.mId = Int32.Parse(objRow[conFunctionReferedFeature.mId].ToString().Trim()); //mId
objFunctionReferedFeatureEN.FeatureId = objRow[conFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objFunctionReferedFeatureEN.FuncId4GC = objRow[conFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objFunctionReferedFeatureEN.FuncId4Invoked = objRow[conFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objFunctionReferedFeatureEN.UpdDate = objRow[conFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objFunctionReferedFeatureEN.UpdUser = objRow[conFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[conFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objFunctionReferedFeatureEN.Memo = objRow[conFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[conFunctionReferedFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionReferedFeatureEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFunctionReferedFeatureEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFunctionReferedFeature(ref clsFunctionReferedFeatureEN objFunctionReferedFeatureEN)
{
bool bolResult = FunctionReferedFeatureDA.GetFunctionReferedFeature(ref objFunctionReferedFeatureEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionReferedFeatureEN GetObjBymId(long lngmId)
{
clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = FunctionReferedFeatureDA.GetObjBymId(lngmId);
return objFunctionReferedFeatureEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFunctionReferedFeatureEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = FunctionReferedFeatureDA.GetFirstObj(strWhereCond);
 return objFunctionReferedFeatureEN;
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
public static clsFunctionReferedFeatureEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = FunctionReferedFeatureDA.GetObjByDataRow(objRow);
 return objFunctionReferedFeatureEN;
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
public static clsFunctionReferedFeatureEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = FunctionReferedFeatureDA.GetObjByDataRow(objRow);
 return objFunctionReferedFeatureEN;
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
 /// <param name = "lstFunctionReferedFeatureObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionReferedFeatureEN GetObjBymIdFromList(long lngmId, List<clsFunctionReferedFeatureEN> lstFunctionReferedFeatureObjLst)
{
foreach (clsFunctionReferedFeatureEN objFunctionReferedFeatureEN in lstFunctionReferedFeatureObjLst)
{
if (objFunctionReferedFeatureEN.mId == lngmId)
{
return objFunctionReferedFeatureEN;
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
 lngmId = new clsFunctionReferedFeatureDA().GetFirstID(strWhereCond);
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
 arrList = FunctionReferedFeatureDA.GetID(strWhereCond);
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
bool bolIsExist = FunctionReferedFeatureDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = FunctionReferedFeatureDA.IsExist(lngmId);
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
clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = clsFunctionReferedFeatureBL.GetObjBymId(lngmId);
objFunctionReferedFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFunctionReferedFeatureEN.UpdUser = strOpUser;
return clsFunctionReferedFeatureBL.UpdateBySql2(objFunctionReferedFeatureEN);
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
 bolIsExist = clsFunctionReferedFeatureDA.IsExistTable();
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
 bolIsExist = FunctionReferedFeatureDA.IsExistTable(strTabName);
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
 /// <param name = "objFunctionReferedFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFunctionReferedFeatureEN objFunctionReferedFeatureEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFunctionReferedFeatureEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能Id = [{0}],函数ID = [{1}]的数据已经存在!(in clsFunctionReferedFeatureBL.AddNewRecordBySql2)", objFunctionReferedFeatureEN.FeatureId,objFunctionReferedFeatureEN.FuncId4GC);
throw new Exception(strMsg);
}
try
{
bool bolResult = FunctionReferedFeatureDA.AddNewRecordBySQL2(objFunctionReferedFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionReferedFeatureBL.ReFreshCache();

if (clsFunctionReferedFeatureBL.relatedActions != null)
{
clsFunctionReferedFeatureBL.relatedActions.UpdRelaTabDate(objFunctionReferedFeatureEN.mId, objFunctionReferedFeatureEN.UpdUser);
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
 /// <param name = "objFunctionReferedFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFunctionReferedFeatureEN objFunctionReferedFeatureEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFunctionReferedFeatureEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能Id = [{0}],函数ID = [{1}]的数据已经存在!(in clsFunctionReferedFeatureBL.AddNewRecordBySql2WithReturnKey)", objFunctionReferedFeatureEN.FeatureId,objFunctionReferedFeatureEN.FuncId4GC);
throw new Exception(strMsg);
}
try
{
string strKey = FunctionReferedFeatureDA.AddNewRecordBySQL2WithReturnKey(objFunctionReferedFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionReferedFeatureBL.ReFreshCache();

if (clsFunctionReferedFeatureBL.relatedActions != null)
{
clsFunctionReferedFeatureBL.relatedActions.UpdRelaTabDate(objFunctionReferedFeatureEN.mId, objFunctionReferedFeatureEN.UpdUser);
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
 /// <param name = "objFunctionReferedFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFunctionReferedFeatureEN objFunctionReferedFeatureEN)
{
try
{
bool bolResult = FunctionReferedFeatureDA.Update(objFunctionReferedFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionReferedFeatureBL.ReFreshCache();

if (clsFunctionReferedFeatureBL.relatedActions != null)
{
clsFunctionReferedFeatureBL.relatedActions.UpdRelaTabDate(objFunctionReferedFeatureEN.mId, objFunctionReferedFeatureEN.UpdUser);
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
 /// <param name = "objFunctionReferedFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFunctionReferedFeatureEN objFunctionReferedFeatureEN)
{
 if (objFunctionReferedFeatureEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FunctionReferedFeatureDA.UpdateBySql2(objFunctionReferedFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionReferedFeatureBL.ReFreshCache();

if (clsFunctionReferedFeatureBL.relatedActions != null)
{
clsFunctionReferedFeatureBL.relatedActions.UpdRelaTabDate(objFunctionReferedFeatureEN.mId, objFunctionReferedFeatureEN.UpdUser);
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
 clsFunctionReferedFeatureEN objFunctionReferedFeatureEN = clsFunctionReferedFeatureBL.GetObjBymId(lngmId);

if (clsFunctionReferedFeatureBL.relatedActions != null)
{
clsFunctionReferedFeatureBL.relatedActions.UpdRelaTabDate(objFunctionReferedFeatureEN.mId, objFunctionReferedFeatureEN.UpdUser);
}
if (objFunctionReferedFeatureEN != null)
{
int intRecNum = FunctionReferedFeatureDA.DelRecord(lngmId);
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
objSQL = clsFunctionReferedFeatureDA.GetSpecSQLObj();
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
//删除与表:[FunctionReferedFeature]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFunctionReferedFeature.mId,
//lngmId);
//        clsFunctionReferedFeatureBL.DelFunctionReferedFeaturesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunctionReferedFeatureBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunctionReferedFeatureBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsFunctionReferedFeatureBL.relatedActions != null)
{
clsFunctionReferedFeatureBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = FunctionReferedFeatureDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelFunctionReferedFeatures(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsFunctionReferedFeatureBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsFunctionReferedFeatureBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = FunctionReferedFeatureDA.DelFunctionReferedFeature(arrmIdLst);
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
public static int DelFunctionReferedFeaturesByCond(string strWhereCond)
{
try
{
if (clsFunctionReferedFeatureBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsFunctionReferedFeatureBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = FunctionReferedFeatureDA.DelFunctionReferedFeature(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FunctionReferedFeature]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunctionReferedFeatureDA.GetSpecSQLObj();
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
//删除与表:[FunctionReferedFeature]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunctionReferedFeatureBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunctionReferedFeatureBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objFunctionReferedFeatureENS">源对象</param>
 /// <param name = "objFunctionReferedFeatureENT">目标对象</param>
 public static void CopyTo(clsFunctionReferedFeatureEN objFunctionReferedFeatureENS, clsFunctionReferedFeatureEN objFunctionReferedFeatureENT)
{
try
{
objFunctionReferedFeatureENT.mId = objFunctionReferedFeatureENS.mId; //mId
objFunctionReferedFeatureENT.FeatureId = objFunctionReferedFeatureENS.FeatureId; //功能Id
objFunctionReferedFeatureENT.FuncId4GC = objFunctionReferedFeatureENS.FuncId4GC; //函数ID
objFunctionReferedFeatureENT.FuncId4Invoked = objFunctionReferedFeatureENS.FuncId4Invoked; //被调用函数
objFunctionReferedFeatureENT.UpdDate = objFunctionReferedFeatureENS.UpdDate; //修改日期
objFunctionReferedFeatureENT.UpdUser = objFunctionReferedFeatureENS.UpdUser; //修改者
objFunctionReferedFeatureENT.Memo = objFunctionReferedFeatureENS.Memo; //说明
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
 /// <param name = "objFunctionReferedFeatureEN">源简化对象</param>
 public static void SetUpdFlag(clsFunctionReferedFeatureEN objFunctionReferedFeatureEN)
{
try
{
objFunctionReferedFeatureEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFunctionReferedFeatureEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFunctionReferedFeature.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionReferedFeatureEN.mId = objFunctionReferedFeatureEN.mId; //mId
}
if (arrFldSet.Contains(conFunctionReferedFeature.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionReferedFeatureEN.FeatureId = objFunctionReferedFeatureEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(conFunctionReferedFeature.FuncId4GC, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionReferedFeatureEN.FuncId4GC = objFunctionReferedFeatureEN.FuncId4GC; //函数ID
}
if (arrFldSet.Contains(conFunctionReferedFeature.FuncId4Invoked, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionReferedFeatureEN.FuncId4Invoked = objFunctionReferedFeatureEN.FuncId4Invoked; //被调用函数
}
if (arrFldSet.Contains(conFunctionReferedFeature.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionReferedFeatureEN.UpdDate = objFunctionReferedFeatureEN.UpdDate == "[null]" ? null :  objFunctionReferedFeatureEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFunctionReferedFeature.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionReferedFeatureEN.UpdUser = objFunctionReferedFeatureEN.UpdUser == "[null]" ? null :  objFunctionReferedFeatureEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFunctionReferedFeature.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionReferedFeatureEN.Memo = objFunctionReferedFeatureEN.Memo == "[null]" ? null :  objFunctionReferedFeatureEN.Memo; //说明
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
 /// <param name = "objFunctionReferedFeatureEN">源简化对象</param>
 public static void AccessFldValueNull(clsFunctionReferedFeatureEN objFunctionReferedFeatureEN)
{
try
{
if (objFunctionReferedFeatureEN.UpdDate == "[null]") objFunctionReferedFeatureEN.UpdDate = null; //修改日期
if (objFunctionReferedFeatureEN.UpdUser == "[null]") objFunctionReferedFeatureEN.UpdUser = null; //修改者
if (objFunctionReferedFeatureEN.Memo == "[null]") objFunctionReferedFeatureEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFunctionReferedFeatureEN objFunctionReferedFeatureEN)
{
 FunctionReferedFeatureDA.CheckPropertyNew(objFunctionReferedFeatureEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFunctionReferedFeatureEN objFunctionReferedFeatureEN)
{
 FunctionReferedFeatureDA.CheckProperty4Condition(objFunctionReferedFeatureEN);
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
if (clsFunctionReferedFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionReferedFeatureBL没有刷新缓存机制(clsFunctionReferedFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrFunctionReferedFeatureObjLstCache == null)
//{
//arrFunctionReferedFeatureObjLstCache = FunctionReferedFeatureDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionReferedFeatureEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFunctionReferedFeatureEN._CurrTabName);
List<clsFunctionReferedFeatureEN> arrFunctionReferedFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionReferedFeatureEN> arrFunctionReferedFeatureObjLst_Sel =
arrFunctionReferedFeatureObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrFunctionReferedFeatureObjLst_Sel.Count() == 0)
{
   clsFunctionReferedFeatureEN obj = clsFunctionReferedFeatureBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFunctionReferedFeatureObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionReferedFeatureEN> GetAllFunctionReferedFeatureObjLstCache()
{
//获取缓存中的对象列表
List<clsFunctionReferedFeatureEN> arrFunctionReferedFeatureObjLstCache = GetObjLstCache(); 
return arrFunctionReferedFeatureObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionReferedFeatureEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFunctionReferedFeatureEN._CurrTabName);
List<clsFunctionReferedFeatureEN> arrFunctionReferedFeatureObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFunctionReferedFeatureObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:FeatureId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrFunctionReferedFeatureObjLst">需要排序的对象列表</param>
public static List <clsFunctionReferedFeatureEN> GetSubSet4FunctionReferedFeatureObjLstByFeatureIdCache(string strFeatureId)
{
   if (string.IsNullOrEmpty(strFeatureId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsFunctionReferedFeatureEN._CurrTabName);
List<clsFunctionReferedFeatureEN> arrFunctionReferedFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionReferedFeatureEN> arrFunctionReferedFeatureObjLst_Sel1 =
from objFunctionReferedFeatureEN in arrFunctionReferedFeatureObjLstCache
where objFunctionReferedFeatureEN.FeatureId == strFeatureId
select objFunctionReferedFeatureEN;
List <clsFunctionReferedFeatureEN> arrFunctionReferedFeatureObjLst_Sel = new List<clsFunctionReferedFeatureEN>();
foreach (clsFunctionReferedFeatureEN obj in arrFunctionReferedFeatureObjLst_Sel1)
{
arrFunctionReferedFeatureObjLst_Sel.Add(obj);
}
return arrFunctionReferedFeatureObjLst_Sel;
}
 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:FuncId4GC字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrFunctionReferedFeatureObjLst">需要排序的对象列表</param>
public static List <clsFunctionReferedFeatureEN> GetSubSet4FunctionReferedFeatureObjLstByFuncId4GCCache(string strFuncId4GC)
{
   if (string.IsNullOrEmpty(strFuncId4GC) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsFunctionReferedFeatureEN._CurrTabName);
List<clsFunctionReferedFeatureEN> arrFunctionReferedFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionReferedFeatureEN> arrFunctionReferedFeatureObjLst_Sel1 =
from objFunctionReferedFeatureEN in arrFunctionReferedFeatureObjLstCache
where objFunctionReferedFeatureEN.FuncId4GC == strFuncId4GC
select objFunctionReferedFeatureEN;
List <clsFunctionReferedFeatureEN> arrFunctionReferedFeatureObjLst_Sel = new List<clsFunctionReferedFeatureEN>();
foreach (clsFunctionReferedFeatureEN obj in arrFunctionReferedFeatureObjLst_Sel1)
{
arrFunctionReferedFeatureObjLst_Sel.Add(obj);
}
return arrFunctionReferedFeatureObjLst_Sel;
}
 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:FuncId4Invoked字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrFunctionReferedFeatureObjLst">需要排序的对象列表</param>
public static List <clsFunctionReferedFeatureEN> GetSubSet4FunctionReferedFeatureObjLstByFuncId4InvokedCache(string strFuncId4Invoked)
{
   if (string.IsNullOrEmpty(strFuncId4Invoked) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsFunctionReferedFeatureEN._CurrTabName);
List<clsFunctionReferedFeatureEN> arrFunctionReferedFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionReferedFeatureEN> arrFunctionReferedFeatureObjLst_Sel1 =
from objFunctionReferedFeatureEN in arrFunctionReferedFeatureObjLstCache
where objFunctionReferedFeatureEN.FuncId4Invoked == strFuncId4Invoked
select objFunctionReferedFeatureEN;
List <clsFunctionReferedFeatureEN> arrFunctionReferedFeatureObjLst_Sel = new List<clsFunctionReferedFeatureEN>();
foreach (clsFunctionReferedFeatureEN obj in arrFunctionReferedFeatureObjLst_Sel1)
{
arrFunctionReferedFeatureObjLst_Sel.Add(obj);
}
return arrFunctionReferedFeatureObjLst_Sel;
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
string strKey = string.Format("{0}", clsFunctionReferedFeatureEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunctionReferedFeatureEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFunctionReferedFeatureEN._RefreshTimeLst.Count == 0) return "";
return clsFunctionReferedFeatureEN._RefreshTimeLst[clsFunctionReferedFeatureEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFunctionReferedFeatureBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFunctionReferedFeatureEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunctionReferedFeatureEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFunctionReferedFeatureBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FunctionReferedFeature(功能相关函数)
 /// 唯一性条件:FeatureId_FuncId4GC
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFunctionReferedFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFunctionReferedFeatureEN objFunctionReferedFeatureEN)
{
//检测记录是否存在
string strResult = FunctionReferedFeatureDA.GetUniCondStr(objFunctionReferedFeatureEN);
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
if (strInFldName != conFunctionReferedFeature.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFunctionReferedFeature.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFunctionReferedFeature.AttributeName));
throw new Exception(strMsg);
}
var objFunctionReferedFeature = clsFunctionReferedFeatureBL.GetObjBymIdCache(lngmId);
if (objFunctionReferedFeature == null) return "";
return objFunctionReferedFeature[strOutFldName].ToString();
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
int intRecCount = clsFunctionReferedFeatureDA.GetRecCount(strTabName);
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
int intRecCount = clsFunctionReferedFeatureDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFunctionReferedFeatureDA.GetRecCount();
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
int intRecCount = clsFunctionReferedFeatureDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFunctionReferedFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFunctionReferedFeatureEN objFunctionReferedFeatureCond)
{
List<clsFunctionReferedFeatureEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionReferedFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunctionReferedFeature.AttributeName)
{
if (objFunctionReferedFeatureCond.IsUpdated(strFldName) == false) continue;
if (objFunctionReferedFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionReferedFeatureCond[strFldName].ToString());
}
else
{
if (objFunctionReferedFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunctionReferedFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionReferedFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunctionReferedFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunctionReferedFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunctionReferedFeatureCond[strFldName]));
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
 List<string> arrList = clsFunctionReferedFeatureDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FunctionReferedFeatureDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FunctionReferedFeatureDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FunctionReferedFeatureDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunctionReferedFeatureDA.SetFldValue(clsFunctionReferedFeatureEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FunctionReferedFeatureDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunctionReferedFeatureDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunctionReferedFeatureDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunctionReferedFeatureDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FunctionReferedFeature] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**功能Id*/ 
 strCreateTabCode.Append(" FeatureId char(4) not Null, "); 
 // /**函数ID*/ 
 strCreateTabCode.Append(" FuncId4GC char(10) not Null, "); 
 // /**被调用函数*/ 
 strCreateTabCode.Append(" FuncId4Invoked char(10) not Null, "); 
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
 /// 功能相关函数(FunctionReferedFeature)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FunctionReferedFeature : clsCommFun4BL
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
clsFunctionReferedFeatureBL.ReFreshThisCache();
}
}

}