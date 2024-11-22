﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCacheUseStateBL
 表名:CacheUseState(00050566)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:51:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsCacheUseStateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCacheUseStateEN GetObj(this K_mId_CacheUseState myKey)
{
clsCacheUseStateEN objCacheUseStateEN = clsCacheUseStateBL.CacheUseStateDA.GetObjBymId(myKey.Value);
return objCacheUseStateEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCacheUseStateEN objCacheUseStateEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCacheUseStateEN) == false)
{
var strMsg = string.Format("记录已经存在!缓存方式Id = [{0}],缓存关键字 = [{1}],用户Id = [{2}]的数据已经存在!(in clsCacheUseStateBL.AddNewRecord)", objCacheUseStateEN.CacheModeId,objCacheUseStateEN.CacheKey,objCacheUseStateEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCacheUseStateBL.CacheUseStateDA.AddNewRecordBySQL2(objCacheUseStateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateBL.ReFreshCache(objCacheUseStateEN.UserId);

if (clsCacheUseStateBL.relatedActions != null)
{
clsCacheUseStateBL.relatedActions.UpdRelaTabDate(objCacheUseStateEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsCacheUseStateEN objCacheUseStateEN, bool bolIsNeedCheckUniqueness = true)
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
objCacheUseStateEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCacheUseStateEN.CheckUniqueness() == false)
{
strMsg = string.Format("(缓存方式Id(CacheModeId)=[{0}],缓存关键字(CacheKey)=[{1}],用户Id(UserId)=[{2}])已经存在,不能重复!", objCacheUseStateEN.CacheModeId, objCacheUseStateEN.CacheKey, objCacheUseStateEN.UserId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCacheUseStateEN.AddNewRecord();
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
 /// <param name = "objCacheUseStateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCacheUseStateEN objCacheUseStateEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCacheUseStateEN) == false)
{
var strMsg = string.Format("记录已经存在!缓存方式Id = [{0}],缓存关键字 = [{1}],用户Id = [{2}]的数据已经存在!(in clsCacheUseStateBL.AddNewRecordWithReturnKey)", objCacheUseStateEN.CacheModeId,objCacheUseStateEN.CacheKey,objCacheUseStateEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsCacheUseStateBL.CacheUseStateDA.AddNewRecordBySQL2WithReturnKey(objCacheUseStateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateBL.ReFreshCache(objCacheUseStateEN.UserId);

if (clsCacheUseStateBL.relatedActions != null)
{
clsCacheUseStateBL.relatedActions.UpdRelaTabDate(objCacheUseStateEN.mId, "SetUpdDate");
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
 /// <param name = "objCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCacheUseStateEN SetmId(this clsCacheUseStateEN objCacheUseStateEN, long lngmId, string strComparisonOp="")
	{
objCacheUseStateEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCacheUseStateEN.dicFldComparisonOp.ContainsKey(conCacheUseState.mId) == false)
{
objCacheUseStateEN.dicFldComparisonOp.Add(conCacheUseState.mId, strComparisonOp);
}
else
{
objCacheUseStateEN.dicFldComparisonOp[conCacheUseState.mId] = strComparisonOp;
}
}
return objCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCacheUseStateEN SetUserId(this clsCacheUseStateEN objCacheUseStateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conCacheUseState.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conCacheUseState.UserId);
}
objCacheUseStateEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCacheUseStateEN.dicFldComparisonOp.ContainsKey(conCacheUseState.UserId) == false)
{
objCacheUseStateEN.dicFldComparisonOp.Add(conCacheUseState.UserId, strComparisonOp);
}
else
{
objCacheUseStateEN.dicFldComparisonOp[conCacheUseState.UserId] = strComparisonOp;
}
}
return objCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCacheUseStateEN SetCacheModeId(this clsCacheUseStateEN objCacheUseStateEN, string strCacheModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCacheModeId, conCacheUseState.CacheModeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheModeId, 2, conCacheUseState.CacheModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCacheModeId, 2, conCacheUseState.CacheModeId);
}
objCacheUseStateEN.CacheModeId = strCacheModeId; //缓存方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCacheUseStateEN.dicFldComparisonOp.ContainsKey(conCacheUseState.CacheModeId) == false)
{
objCacheUseStateEN.dicFldComparisonOp.Add(conCacheUseState.CacheModeId, strComparisonOp);
}
else
{
objCacheUseStateEN.dicFldComparisonOp[conCacheUseState.CacheModeId] = strComparisonOp;
}
}
return objCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCacheUseStateEN SetCacheKey(this clsCacheUseStateEN objCacheUseStateEN, string strCacheKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCacheKey, conCacheUseState.CacheKey);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheKey, 50, conCacheUseState.CacheKey);
}
objCacheUseStateEN.CacheKey = strCacheKey; //缓存关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCacheUseStateEN.dicFldComparisonOp.ContainsKey(conCacheUseState.CacheKey) == false)
{
objCacheUseStateEN.dicFldComparisonOp.Add(conCacheUseState.CacheKey, strComparisonOp);
}
else
{
objCacheUseStateEN.dicFldComparisonOp[conCacheUseState.CacheKey] = strComparisonOp;
}
}
return objCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCacheUseStateEN SetCacheSize(this clsCacheUseStateEN objCacheUseStateEN, int? intCacheSize, string strComparisonOp="")
	{
objCacheUseStateEN.CacheSize = intCacheSize; //缓存大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCacheUseStateEN.dicFldComparisonOp.ContainsKey(conCacheUseState.CacheSize) == false)
{
objCacheUseStateEN.dicFldComparisonOp.Add(conCacheUseState.CacheSize, strComparisonOp);
}
else
{
objCacheUseStateEN.dicFldComparisonOp[conCacheUseState.CacheSize] = strComparisonOp;
}
}
return objCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCacheUseStateEN SetUseDate(this clsCacheUseStateEN objCacheUseStateEN, string strUseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseDate, 20, conCacheUseState.UseDate);
}
objCacheUseStateEN.UseDate = strUseDate; //使用日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCacheUseStateEN.dicFldComparisonOp.ContainsKey(conCacheUseState.UseDate) == false)
{
objCacheUseStateEN.dicFldComparisonOp.Add(conCacheUseState.UseDate, strComparisonOp);
}
else
{
objCacheUseStateEN.dicFldComparisonOp[conCacheUseState.UseDate] = strComparisonOp;
}
}
return objCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCacheUseStateEN SetMemo(this clsCacheUseStateEN objCacheUseStateEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCacheUseState.Memo);
}
objCacheUseStateEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCacheUseStateEN.dicFldComparisonOp.ContainsKey(conCacheUseState.Memo) == false)
{
objCacheUseStateEN.dicFldComparisonOp.Add(conCacheUseState.Memo, strComparisonOp);
}
else
{
objCacheUseStateEN.dicFldComparisonOp[conCacheUseState.Memo] = strComparisonOp;
}
}
return objCacheUseStateEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCacheUseStateEN objCacheUseStateEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCacheUseStateEN.CheckPropertyNew();
clsCacheUseStateEN objCacheUseStateCond = new clsCacheUseStateEN();
string strCondition = objCacheUseStateCond
.SetmId(objCacheUseStateEN.mId, "<>")
.SetCacheModeId(objCacheUseStateEN.CacheModeId, "=")
.SetCacheKey(objCacheUseStateEN.CacheKey, "=")
.SetUserId(objCacheUseStateEN.UserId, "=")
.GetCombineCondition();
objCacheUseStateEN._IsCheckProperty = true;
bool bolIsExist = clsCacheUseStateBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(UserId_CacheModeId_CacheKey)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCacheUseStateEN.Update();
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
 /// <param name = "objCacheUseState">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCacheUseStateEN objCacheUseState)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCacheUseStateEN objCacheUseStateCond = new clsCacheUseStateEN();
string strCondition = objCacheUseStateCond
.SetCacheModeId(objCacheUseState.CacheModeId, "=")
.SetCacheKey(objCacheUseState.CacheKey, "=")
.SetUserId(objCacheUseState.UserId, "=")
.GetCombineCondition();
objCacheUseState._IsCheckProperty = true;
bool bolIsExist = clsCacheUseStateBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCacheUseState.mId = clsCacheUseStateBL.GetFirstID_S(strCondition);
objCacheUseState.UpdateWithCondition(strCondition);
}
else
{
objCacheUseState.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCacheUseStateEN objCacheUseStateEN)
{
 if (objCacheUseStateEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCacheUseStateBL.CacheUseStateDA.UpdateBySql2(objCacheUseStateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateBL.ReFreshCache(objCacheUseStateEN.UserId);

if (clsCacheUseStateBL.relatedActions != null)
{
clsCacheUseStateBL.relatedActions.UpdRelaTabDate(objCacheUseStateEN.mId, "SetUpdDate");
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
 /// <param name = "objCacheUseStateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCacheUseStateEN objCacheUseStateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCacheUseStateEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCacheUseStateBL.CacheUseStateDA.UpdateBySql2(objCacheUseStateEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateBL.ReFreshCache(objCacheUseStateEN.UserId);

if (clsCacheUseStateBL.relatedActions != null)
{
clsCacheUseStateBL.relatedActions.UpdRelaTabDate(objCacheUseStateEN.mId, "SetUpdDate");
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
 /// <param name = "objCacheUseStateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCacheUseStateEN objCacheUseStateEN, string strWhereCond)
{
try
{
bool bolResult = clsCacheUseStateBL.CacheUseStateDA.UpdateBySqlWithCondition(objCacheUseStateEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateBL.ReFreshCache(objCacheUseStateEN.UserId);

if (clsCacheUseStateBL.relatedActions != null)
{
clsCacheUseStateBL.relatedActions.UpdRelaTabDate(objCacheUseStateEN.mId, "SetUpdDate");
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
 /// <param name = "objCacheUseStateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCacheUseStateEN objCacheUseStateEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCacheUseStateBL.CacheUseStateDA.UpdateBySqlWithConditionTransaction(objCacheUseStateEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateBL.ReFreshCache(objCacheUseStateEN.UserId);

if (clsCacheUseStateBL.relatedActions != null)
{
clsCacheUseStateBL.relatedActions.UpdRelaTabDate(objCacheUseStateEN.mId, "SetUpdDate");
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
public static int Delete(this clsCacheUseStateEN objCacheUseStateEN)
{
try
{
int intRecNum = clsCacheUseStateBL.CacheUseStateDA.DelRecord(objCacheUseStateEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateBL.ReFreshCache(objCacheUseStateEN.UserId);

if (clsCacheUseStateBL.relatedActions != null)
{
clsCacheUseStateBL.relatedActions.UpdRelaTabDate(objCacheUseStateEN.mId, "SetUpdDate");
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
 /// <param name = "objCacheUseStateENS">源对象</param>
 /// <param name = "objCacheUseStateENT">目标对象</param>
 public static void CopyTo(this clsCacheUseStateEN objCacheUseStateENS, clsCacheUseStateEN objCacheUseStateENT)
{
try
{
objCacheUseStateENT.mId = objCacheUseStateENS.mId; //mId
objCacheUseStateENT.UserId = objCacheUseStateENS.UserId; //用户Id
objCacheUseStateENT.CacheModeId = objCacheUseStateENS.CacheModeId; //缓存方式Id
objCacheUseStateENT.CacheKey = objCacheUseStateENS.CacheKey; //缓存关键字
objCacheUseStateENT.CacheSize = objCacheUseStateENS.CacheSize; //缓存大小
objCacheUseStateENT.UseDate = objCacheUseStateENS.UseDate; //使用日期
objCacheUseStateENT.Memo = objCacheUseStateENS.Memo; //说明
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
 /// <param name = "objCacheUseStateENS">源对象</param>
 /// <returns>目标对象=>clsCacheUseStateEN:objCacheUseStateENT</returns>
 public static clsCacheUseStateEN CopyTo(this clsCacheUseStateEN objCacheUseStateENS)
{
try
{
 clsCacheUseStateEN objCacheUseStateENT = new clsCacheUseStateEN()
{
mId = objCacheUseStateENS.mId, //mId
UserId = objCacheUseStateENS.UserId, //用户Id
CacheModeId = objCacheUseStateENS.CacheModeId, //缓存方式Id
CacheKey = objCacheUseStateENS.CacheKey, //缓存关键字
CacheSize = objCacheUseStateENS.CacheSize, //缓存大小
UseDate = objCacheUseStateENS.UseDate, //使用日期
Memo = objCacheUseStateENS.Memo, //说明
};
 return objCacheUseStateENT;
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
public static void CheckPropertyNew(this clsCacheUseStateEN objCacheUseStateEN)
{
 clsCacheUseStateBL.CacheUseStateDA.CheckPropertyNew(objCacheUseStateEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCacheUseStateEN objCacheUseStateEN)
{
 clsCacheUseStateBL.CacheUseStateDA.CheckProperty4Condition(objCacheUseStateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCacheUseStateEN objCacheUseStateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCacheUseStateCond.IsUpdated(conCacheUseState.mId) == true)
{
string strComparisonOpmId = objCacheUseStateCond.dicFldComparisonOp[conCacheUseState.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCacheUseState.mId, objCacheUseStateCond.mId, strComparisonOpmId);
}
if (objCacheUseStateCond.IsUpdated(conCacheUseState.UserId) == true)
{
string strComparisonOpUserId = objCacheUseStateCond.dicFldComparisonOp[conCacheUseState.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCacheUseState.UserId, objCacheUseStateCond.UserId, strComparisonOpUserId);
}
if (objCacheUseStateCond.IsUpdated(conCacheUseState.CacheModeId) == true)
{
string strComparisonOpCacheModeId = objCacheUseStateCond.dicFldComparisonOp[conCacheUseState.CacheModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCacheUseState.CacheModeId, objCacheUseStateCond.CacheModeId, strComparisonOpCacheModeId);
}
if (objCacheUseStateCond.IsUpdated(conCacheUseState.CacheKey) == true)
{
string strComparisonOpCacheKey = objCacheUseStateCond.dicFldComparisonOp[conCacheUseState.CacheKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCacheUseState.CacheKey, objCacheUseStateCond.CacheKey, strComparisonOpCacheKey);
}
if (objCacheUseStateCond.IsUpdated(conCacheUseState.CacheSize) == true)
{
string strComparisonOpCacheSize = objCacheUseStateCond.dicFldComparisonOp[conCacheUseState.CacheSize];
strWhereCond += string.Format(" And {0} {2} {1}", conCacheUseState.CacheSize, objCacheUseStateCond.CacheSize, strComparisonOpCacheSize);
}
if (objCacheUseStateCond.IsUpdated(conCacheUseState.UseDate) == true)
{
string strComparisonOpUseDate = objCacheUseStateCond.dicFldComparisonOp[conCacheUseState.UseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCacheUseState.UseDate, objCacheUseStateCond.UseDate, strComparisonOpUseDate);
}
if (objCacheUseStateCond.IsUpdated(conCacheUseState.Memo) == true)
{
string strComparisonOpMemo = objCacheUseStateCond.dicFldComparisonOp[conCacheUseState.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCacheUseState.Memo, objCacheUseStateCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CacheUseState(缓存使用状态), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:UserId_CacheModeId_CacheKey
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCacheUseStateEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCacheUseStateEN objCacheUseStateEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCacheUseStateEN == null) return true;
if (objCacheUseStateEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CacheModeId = '{0}'", objCacheUseStateEN.CacheModeId);
 sbCondition.AppendFormat(" and CacheKey = '{0}'", objCacheUseStateEN.CacheKey);
 sbCondition.AppendFormat(" and UserId = '{0}'", objCacheUseStateEN.UserId);
if (clsCacheUseStateBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCacheUseStateEN.mId);
 sbCondition.AppendFormat(" and CacheModeId = '{0}'", objCacheUseStateEN.CacheModeId);
 sbCondition.AppendFormat(" and CacheKey = '{0}'", objCacheUseStateEN.CacheKey);
 sbCondition.AppendFormat(" and UserId = '{0}'", objCacheUseStateEN.UserId);
if (clsCacheUseStateBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CacheUseState(缓存使用状态), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_CacheModeId_CacheKey
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCacheUseStateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCacheUseStateEN objCacheUseStateEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCacheUseStateEN == null) return "";
if (objCacheUseStateEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CacheModeId = '{0}'", objCacheUseStateEN.CacheModeId);
 sbCondition.AppendFormat(" and CacheKey = '{0}'", objCacheUseStateEN.CacheKey);
 sbCondition.AppendFormat(" and UserId = '{0}'", objCacheUseStateEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCacheUseStateEN.mId);
 sbCondition.AppendFormat(" and CacheModeId = '{0}'", objCacheUseStateEN.CacheModeId);
 sbCondition.AppendFormat(" and CacheKey = '{0}'", objCacheUseStateEN.CacheKey);
 sbCondition.AppendFormat(" and UserId = '{0}'", objCacheUseStateEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CacheUseState
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 缓存使用状态(CacheUseState)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCacheUseStateBL
{
public static RelatedActions_CacheUseState relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCacheUseStateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCacheUseStateDA CacheUseStateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCacheUseStateDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsCacheUseStateBL()
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
if (string.IsNullOrEmpty(clsCacheUseStateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCacheUseStateEN._ConnectString);
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
public static DataTable GetDataTable_CacheUseState(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CacheUseStateDA.GetDataTable_CacheUseState(strWhereCond);
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
objDT = CacheUseStateDA.GetDataTable(strWhereCond);
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
objDT = CacheUseStateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CacheUseStateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CacheUseStateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CacheUseStateDA.GetDataTable_Top(objTopPara);
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
objDT = CacheUseStateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CacheUseStateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CacheUseStateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsCacheUseStateEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsCacheUseStateEN> arrObjLst = new List<clsCacheUseStateEN>(); 
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
	clsCacheUseStateEN objCacheUseStateEN = new clsCacheUseStateEN();
try
{
objCacheUseStateEN.mId = Int32.Parse(objRow[conCacheUseState.mId].ToString().Trim()); //mId
objCacheUseStateEN.UserId = objRow[conCacheUseState.UserId].ToString().Trim(); //用户Id
objCacheUseStateEN.CacheModeId = objRow[conCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objCacheUseStateEN.CacheKey = objRow[conCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objCacheUseStateEN.CacheSize = objRow[conCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objCacheUseStateEN.UseDate = objRow[conCacheUseState.UseDate] == DBNull.Value ? null : objRow[conCacheUseState.UseDate].ToString().Trim(); //使用日期
objCacheUseStateEN.Memo = objRow[conCacheUseState.Memo] == DBNull.Value ? null : objRow[conCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCacheUseStateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCacheUseStateEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strUserId)
{
string strKey = string.Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
List<clsCacheUseStateEN> arrCacheUseStateObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsCacheUseStateEN> arrCacheUseStateObjLst_Sel =
arrCacheUseStateObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrCacheUseStateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCacheUseStateEN> GetObjLst(string strWhereCond)
{
List<clsCacheUseStateEN> arrObjLst = new List<clsCacheUseStateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCacheUseStateEN objCacheUseStateEN = new clsCacheUseStateEN();
try
{
objCacheUseStateEN.mId = Int32.Parse(objRow[conCacheUseState.mId].ToString().Trim()); //mId
objCacheUseStateEN.UserId = objRow[conCacheUseState.UserId].ToString().Trim(); //用户Id
objCacheUseStateEN.CacheModeId = objRow[conCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objCacheUseStateEN.CacheKey = objRow[conCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objCacheUseStateEN.CacheSize = objRow[conCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objCacheUseStateEN.UseDate = objRow[conCacheUseState.UseDate] == DBNull.Value ? null : objRow[conCacheUseState.UseDate].ToString().Trim(); //使用日期
objCacheUseStateEN.Memo = objRow[conCacheUseState.Memo] == DBNull.Value ? null : objRow[conCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCacheUseStateEN);
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
public static List<clsCacheUseStateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCacheUseStateEN> arrObjLst = new List<clsCacheUseStateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCacheUseStateEN objCacheUseStateEN = new clsCacheUseStateEN();
try
{
objCacheUseStateEN.mId = Int32.Parse(objRow[conCacheUseState.mId].ToString().Trim()); //mId
objCacheUseStateEN.UserId = objRow[conCacheUseState.UserId].ToString().Trim(); //用户Id
objCacheUseStateEN.CacheModeId = objRow[conCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objCacheUseStateEN.CacheKey = objRow[conCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objCacheUseStateEN.CacheSize = objRow[conCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objCacheUseStateEN.UseDate = objRow[conCacheUseState.UseDate] == DBNull.Value ? null : objRow[conCacheUseState.UseDate].ToString().Trim(); //使用日期
objCacheUseStateEN.Memo = objRow[conCacheUseState.Memo] == DBNull.Value ? null : objRow[conCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCacheUseStateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCacheUseStateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCacheUseStateEN> GetSubObjLstCache(clsCacheUseStateEN objCacheUseStateCond)
{
 string strUserId = objCacheUseStateCond.UserId;
 if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsCacheUseStateBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsCacheUseStateEN> arrObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsCacheUseStateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCacheUseState.AttributeName)
{
if (objCacheUseStateCond.IsUpdated(strFldName) == false) continue;
if (objCacheUseStateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCacheUseStateCond[strFldName].ToString());
}
else
{
if (objCacheUseStateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCacheUseStateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCacheUseStateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCacheUseStateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCacheUseStateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCacheUseStateCond[strFldName]));
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
public static List<clsCacheUseStateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCacheUseStateEN> arrObjLst = new List<clsCacheUseStateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCacheUseStateEN objCacheUseStateEN = new clsCacheUseStateEN();
try
{
objCacheUseStateEN.mId = Int32.Parse(objRow[conCacheUseState.mId].ToString().Trim()); //mId
objCacheUseStateEN.UserId = objRow[conCacheUseState.UserId].ToString().Trim(); //用户Id
objCacheUseStateEN.CacheModeId = objRow[conCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objCacheUseStateEN.CacheKey = objRow[conCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objCacheUseStateEN.CacheSize = objRow[conCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objCacheUseStateEN.UseDate = objRow[conCacheUseState.UseDate] == DBNull.Value ? null : objRow[conCacheUseState.UseDate].ToString().Trim(); //使用日期
objCacheUseStateEN.Memo = objRow[conCacheUseState.Memo] == DBNull.Value ? null : objRow[conCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCacheUseStateEN);
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
public static List<clsCacheUseStateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCacheUseStateEN> arrObjLst = new List<clsCacheUseStateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCacheUseStateEN objCacheUseStateEN = new clsCacheUseStateEN();
try
{
objCacheUseStateEN.mId = Int32.Parse(objRow[conCacheUseState.mId].ToString().Trim()); //mId
objCacheUseStateEN.UserId = objRow[conCacheUseState.UserId].ToString().Trim(); //用户Id
objCacheUseStateEN.CacheModeId = objRow[conCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objCacheUseStateEN.CacheKey = objRow[conCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objCacheUseStateEN.CacheSize = objRow[conCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objCacheUseStateEN.UseDate = objRow[conCacheUseState.UseDate] == DBNull.Value ? null : objRow[conCacheUseState.UseDate].ToString().Trim(); //使用日期
objCacheUseStateEN.Memo = objRow[conCacheUseState.Memo] == DBNull.Value ? null : objRow[conCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCacheUseStateEN);
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
List<clsCacheUseStateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCacheUseStateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCacheUseStateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCacheUseStateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCacheUseStateEN> arrObjLst = new List<clsCacheUseStateEN>(); 
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
	clsCacheUseStateEN objCacheUseStateEN = new clsCacheUseStateEN();
try
{
objCacheUseStateEN.mId = Int32.Parse(objRow[conCacheUseState.mId].ToString().Trim()); //mId
objCacheUseStateEN.UserId = objRow[conCacheUseState.UserId].ToString().Trim(); //用户Id
objCacheUseStateEN.CacheModeId = objRow[conCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objCacheUseStateEN.CacheKey = objRow[conCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objCacheUseStateEN.CacheSize = objRow[conCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objCacheUseStateEN.UseDate = objRow[conCacheUseState.UseDate] == DBNull.Value ? null : objRow[conCacheUseState.UseDate].ToString().Trim(); //使用日期
objCacheUseStateEN.Memo = objRow[conCacheUseState.Memo] == DBNull.Value ? null : objRow[conCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCacheUseStateEN);
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
public static List<clsCacheUseStateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCacheUseStateEN> arrObjLst = new List<clsCacheUseStateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCacheUseStateEN objCacheUseStateEN = new clsCacheUseStateEN();
try
{
objCacheUseStateEN.mId = Int32.Parse(objRow[conCacheUseState.mId].ToString().Trim()); //mId
objCacheUseStateEN.UserId = objRow[conCacheUseState.UserId].ToString().Trim(); //用户Id
objCacheUseStateEN.CacheModeId = objRow[conCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objCacheUseStateEN.CacheKey = objRow[conCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objCacheUseStateEN.CacheSize = objRow[conCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objCacheUseStateEN.UseDate = objRow[conCacheUseState.UseDate] == DBNull.Value ? null : objRow[conCacheUseState.UseDate].ToString().Trim(); //使用日期
objCacheUseStateEN.Memo = objRow[conCacheUseState.Memo] == DBNull.Value ? null : objRow[conCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCacheUseStateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCacheUseStateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCacheUseStateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCacheUseStateEN> arrObjLst = new List<clsCacheUseStateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCacheUseStateEN objCacheUseStateEN = new clsCacheUseStateEN();
try
{
objCacheUseStateEN.mId = Int32.Parse(objRow[conCacheUseState.mId].ToString().Trim()); //mId
objCacheUseStateEN.UserId = objRow[conCacheUseState.UserId].ToString().Trim(); //用户Id
objCacheUseStateEN.CacheModeId = objRow[conCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objCacheUseStateEN.CacheKey = objRow[conCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objCacheUseStateEN.CacheSize = objRow[conCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objCacheUseStateEN.UseDate = objRow[conCacheUseState.UseDate] == DBNull.Value ? null : objRow[conCacheUseState.UseDate].ToString().Trim(); //使用日期
objCacheUseStateEN.Memo = objRow[conCacheUseState.Memo] == DBNull.Value ? null : objRow[conCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCacheUseStateEN);
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
public static List<clsCacheUseStateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCacheUseStateEN> arrObjLst = new List<clsCacheUseStateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCacheUseStateEN objCacheUseStateEN = new clsCacheUseStateEN();
try
{
objCacheUseStateEN.mId = Int32.Parse(objRow[conCacheUseState.mId].ToString().Trim()); //mId
objCacheUseStateEN.UserId = objRow[conCacheUseState.UserId].ToString().Trim(); //用户Id
objCacheUseStateEN.CacheModeId = objRow[conCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objCacheUseStateEN.CacheKey = objRow[conCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objCacheUseStateEN.CacheSize = objRow[conCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objCacheUseStateEN.UseDate = objRow[conCacheUseState.UseDate] == DBNull.Value ? null : objRow[conCacheUseState.UseDate].ToString().Trim(); //使用日期
objCacheUseStateEN.Memo = objRow[conCacheUseState.Memo] == DBNull.Value ? null : objRow[conCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCacheUseStateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCacheUseStateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCacheUseStateEN> arrObjLst = new List<clsCacheUseStateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCacheUseStateEN objCacheUseStateEN = new clsCacheUseStateEN();
try
{
objCacheUseStateEN.mId = Int32.Parse(objRow[conCacheUseState.mId].ToString().Trim()); //mId
objCacheUseStateEN.UserId = objRow[conCacheUseState.UserId].ToString().Trim(); //用户Id
objCacheUseStateEN.CacheModeId = objRow[conCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objCacheUseStateEN.CacheKey = objRow[conCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objCacheUseStateEN.CacheSize = objRow[conCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objCacheUseStateEN.UseDate = objRow[conCacheUseState.UseDate] == DBNull.Value ? null : objRow[conCacheUseState.UseDate].ToString().Trim(); //使用日期
objCacheUseStateEN.Memo = objRow[conCacheUseState.Memo] == DBNull.Value ? null : objRow[conCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCacheUseStateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCacheUseStateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCacheUseState(ref clsCacheUseStateEN objCacheUseStateEN)
{
bool bolResult = CacheUseStateDA.GetCacheUseState(ref objCacheUseStateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCacheUseStateEN GetObjBymId(long lngmId)
{
clsCacheUseStateEN objCacheUseStateEN = CacheUseStateDA.GetObjBymId(lngmId);
return objCacheUseStateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCacheUseStateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCacheUseStateEN objCacheUseStateEN = CacheUseStateDA.GetFirstObj(strWhereCond);
 return objCacheUseStateEN;
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
public static clsCacheUseStateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCacheUseStateEN objCacheUseStateEN = CacheUseStateDA.GetObjByDataRow(objRow);
 return objCacheUseStateEN;
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
public static clsCacheUseStateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCacheUseStateEN objCacheUseStateEN = CacheUseStateDA.GetObjByDataRow(objRow);
 return objCacheUseStateEN;
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
 /// <param name = "lstCacheUseStateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCacheUseStateEN GetObjBymIdFromList(long lngmId, List<clsCacheUseStateEN> lstCacheUseStateObjLst)
{
foreach (clsCacheUseStateEN objCacheUseStateEN in lstCacheUseStateObjLst)
{
if (objCacheUseStateEN.mId == lngmId)
{
return objCacheUseStateEN;
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
 lngmId = new clsCacheUseStateDA().GetFirstID(strWhereCond);
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
 arrList = CacheUseStateDA.GetID(strWhereCond);
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
bool bolIsExist = CacheUseStateDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = CacheUseStateDA.IsExist(lngmId);
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
 bolIsExist = clsCacheUseStateDA.IsExistTable();
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
 bolIsExist = CacheUseStateDA.IsExistTable(strTabName);
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
 /// <param name = "objCacheUseStateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCacheUseStateEN objCacheUseStateEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCacheUseStateEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!缓存方式Id = [{0}],缓存关键字 = [{1}],用户Id = [{2}]的数据已经存在!(in clsCacheUseStateBL.AddNewRecordBySql2)", objCacheUseStateEN.CacheModeId,objCacheUseStateEN.CacheKey,objCacheUseStateEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = CacheUseStateDA.AddNewRecordBySQL2(objCacheUseStateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateBL.ReFreshCache(objCacheUseStateEN.UserId);

if (clsCacheUseStateBL.relatedActions != null)
{
clsCacheUseStateBL.relatedActions.UpdRelaTabDate(objCacheUseStateEN.mId, "SetUpdDate");
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
 /// <param name = "objCacheUseStateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCacheUseStateEN objCacheUseStateEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCacheUseStateEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!缓存方式Id = [{0}],缓存关键字 = [{1}],用户Id = [{2}]的数据已经存在!(in clsCacheUseStateBL.AddNewRecordBySql2WithReturnKey)", objCacheUseStateEN.CacheModeId,objCacheUseStateEN.CacheKey,objCacheUseStateEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = CacheUseStateDA.AddNewRecordBySQL2WithReturnKey(objCacheUseStateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateBL.ReFreshCache(objCacheUseStateEN.UserId);

if (clsCacheUseStateBL.relatedActions != null)
{
clsCacheUseStateBL.relatedActions.UpdRelaTabDate(objCacheUseStateEN.mId, "SetUpdDate");
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
 /// <param name = "objCacheUseStateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCacheUseStateEN objCacheUseStateEN)
{
try
{
bool bolResult = CacheUseStateDA.Update(objCacheUseStateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateBL.ReFreshCache(objCacheUseStateEN.UserId);

if (clsCacheUseStateBL.relatedActions != null)
{
clsCacheUseStateBL.relatedActions.UpdRelaTabDate(objCacheUseStateEN.mId, "SetUpdDate");
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
 /// <param name = "objCacheUseStateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCacheUseStateEN objCacheUseStateEN)
{
 if (objCacheUseStateEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CacheUseStateDA.UpdateBySql2(objCacheUseStateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateBL.ReFreshCache(objCacheUseStateEN.UserId);

if (clsCacheUseStateBL.relatedActions != null)
{
clsCacheUseStateBL.relatedActions.UpdRelaTabDate(objCacheUseStateEN.mId, "SetUpdDate");
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
 clsCacheUseStateEN objCacheUseStateEN = clsCacheUseStateBL.GetObjBymId(lngmId);

if (clsCacheUseStateBL.relatedActions != null)
{
clsCacheUseStateBL.relatedActions.UpdRelaTabDate(objCacheUseStateEN.mId, "SetUpdDate");
}
if (objCacheUseStateEN != null)
{
int intRecNum = CacheUseStateDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCacheUseStateEN.UserId);
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
 /// <param name = "strUserId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strUserId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCacheUseStateDA.GetSpecSQLObj();
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
//删除与表:[CacheUseState]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCacheUseState.mId,
//lngmId);
//        clsCacheUseStateBL.DelCacheUseStatesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCacheUseStateBL.DelRecord(lngmId, strUserId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCacheUseStateBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, string strUserId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCacheUseStateBL.relatedActions != null)
{
clsCacheUseStateBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = CacheUseStateDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strUserId);
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
public static int DelCacheUseStates(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsCacheUseStateBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsCacheUseStateBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsCacheUseStateEN objCacheUseStateEN = clsCacheUseStateBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = CacheUseStateDA.DelCacheUseState(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCacheUseStateEN.UserId);
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
public static int DelCacheUseStatesByCond(string strWhereCond)
{
try
{
if (clsCacheUseStateBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsCacheUseStateBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrUserId = GetFldValue(conCacheUseState.UserId, strWhereCond);
int intRecNum = CacheUseStateDA.DelCacheUseState(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrUserId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CacheUseState]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strUserId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strUserId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCacheUseStateDA.GetSpecSQLObj();
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
//删除与表:[CacheUseState]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCacheUseStateBL.DelRecord(lngmId, strUserId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCacheUseStateBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objCacheUseStateENS">源对象</param>
 /// <param name = "objCacheUseStateENT">目标对象</param>
 public static void CopyTo(clsCacheUseStateEN objCacheUseStateENS, clsCacheUseStateEN objCacheUseStateENT)
{
try
{
objCacheUseStateENT.mId = objCacheUseStateENS.mId; //mId
objCacheUseStateENT.UserId = objCacheUseStateENS.UserId; //用户Id
objCacheUseStateENT.CacheModeId = objCacheUseStateENS.CacheModeId; //缓存方式Id
objCacheUseStateENT.CacheKey = objCacheUseStateENS.CacheKey; //缓存关键字
objCacheUseStateENT.CacheSize = objCacheUseStateENS.CacheSize; //缓存大小
objCacheUseStateENT.UseDate = objCacheUseStateENS.UseDate; //使用日期
objCacheUseStateENT.Memo = objCacheUseStateENS.Memo; //说明
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
 /// <param name = "objCacheUseStateEN">源简化对象</param>
 public static void SetUpdFlag(clsCacheUseStateEN objCacheUseStateEN)
{
try
{
objCacheUseStateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCacheUseStateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCacheUseState.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objCacheUseStateEN.mId = objCacheUseStateEN.mId; //mId
}
if (arrFldSet.Contains(conCacheUseState.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objCacheUseStateEN.UserId = objCacheUseStateEN.UserId; //用户Id
}
if (arrFldSet.Contains(conCacheUseState.CacheModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCacheUseStateEN.CacheModeId = objCacheUseStateEN.CacheModeId; //缓存方式Id
}
if (arrFldSet.Contains(conCacheUseState.CacheKey, new clsStrCompareIgnoreCase())  ==  true)
{
objCacheUseStateEN.CacheKey = objCacheUseStateEN.CacheKey; //缓存关键字
}
if (arrFldSet.Contains(conCacheUseState.CacheSize, new clsStrCompareIgnoreCase())  ==  true)
{
objCacheUseStateEN.CacheSize = objCacheUseStateEN.CacheSize; //缓存大小
}
if (arrFldSet.Contains(conCacheUseState.UseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCacheUseStateEN.UseDate = objCacheUseStateEN.UseDate == "[null]" ? null :  objCacheUseStateEN.UseDate; //使用日期
}
if (arrFldSet.Contains(conCacheUseState.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCacheUseStateEN.Memo = objCacheUseStateEN.Memo == "[null]" ? null :  objCacheUseStateEN.Memo; //说明
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
 /// <param name = "objCacheUseStateEN">源简化对象</param>
 public static void AccessFldValueNull(clsCacheUseStateEN objCacheUseStateEN)
{
try
{
if (objCacheUseStateEN.UseDate == "[null]") objCacheUseStateEN.UseDate = null; //使用日期
if (objCacheUseStateEN.Memo == "[null]") objCacheUseStateEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsCacheUseStateEN objCacheUseStateEN)
{
 CacheUseStateDA.CheckPropertyNew(objCacheUseStateEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCacheUseStateEN objCacheUseStateEN)
{
 CacheUseStateDA.CheckProperty4Condition(objCacheUseStateEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strUserId"></param>
public static void BindCbo_mId(System.Windows.Forms.ComboBox objComboBox , string strUserId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCacheUseState.mId); 
List<clsCacheUseStateEN> arrObjLst = clsCacheUseStateBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.UserId == strUserId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCacheUseStateEN objCacheUseStateEN = new clsCacheUseStateEN()
{
mId = 0,
UserId = "选[缓存使用状态]..."
};
arrObjLstSel.Insert(0, objCacheUseStateEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCacheUseState.mId;
objComboBox.DisplayMember = conCacheUseState.UserId;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strUserId"></param>
public static void BindDdl_mId(System.Web.UI.WebControls.DropDownList objDDL , string strUserId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[缓存使用状态]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conCacheUseState.mId); 
IEnumerable<clsCacheUseStateEN> arrObjLst = clsCacheUseStateBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.UserId == strUserId).ToList();
objDDL.DataValueField = conCacheUseState.mId;
objDDL.DataTextField = conCacheUseState.UserId;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_mIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strUserId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[缓存使用状态]...","0");
List<clsCacheUseStateEN> arrCacheUseStateObjLst = GetAllCacheUseStateObjLstCache(strUserId); 
objDDL.DataValueField = conCacheUseState.mId;
objDDL.DataTextField = conCacheUseState.UserId;
objDDL.DataSource = arrCacheUseStateObjLst;
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
if (clsCacheUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCacheUseStateBL没有刷新缓存机制(clsCacheUseStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrCacheUseStateObjLstCache == null)
//{
//arrCacheUseStateObjLstCache = CacheUseStateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strUserId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCacheUseStateEN GetObjBymIdCache(long lngmId, string strUserId)
{

if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strUserId.Length != 18)
{
var strMsg = string.Format("缓存分类变量:[strUserId]的长度:[{0}]不正确!(In {1})", strUserId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
List<clsCacheUseStateEN> arrCacheUseStateObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsCacheUseStateEN> arrCacheUseStateObjLst_Sel =
arrCacheUseStateObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrCacheUseStateObjLst_Sel.Count() == 0)
{
   clsCacheUseStateEN obj = clsCacheUseStateBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.UserId == strUserId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strUserId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrCacheUseStateObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserIdBymIdCache(long lngmId, string strUserId)
{
//获取缓存中的对象列表
clsCacheUseStateEN objCacheUseState = GetObjBymIdCache(lngmId, strUserId);
if (objCacheUseState == null) return "";
return objCacheUseState.UserId;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBymIdCache(long lngmId, string strUserId)
{
//获取缓存中的对象列表
clsCacheUseStateEN objCacheUseState = GetObjBymIdCache(lngmId, strUserId);
if (objCacheUseState == null) return "";
return objCacheUseState.UserId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCacheUseStateEN> GetAllCacheUseStateObjLstCache(string strUserId)
{
//获取缓存中的对象列表
List<clsCacheUseStateEN> arrCacheUseStateObjLstCache = GetObjLstCache(strUserId); 
return arrCacheUseStateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCacheUseStateEN> GetObjLstCache(string strUserId)
{

if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strUserId.Length != 18)
{
var strMsg = string.Format("缓存分类变量:[strUserId]的长度:[{0}]不正确!(In {1})", strUserId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
string strCondition = string.Format("UserId='{0}'", strUserId);
List<clsCacheUseStateEN> arrCacheUseStateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrCacheUseStateObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strUserId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
CacheHelper.Remove(strKey);
clsCacheUseStateEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCacheUseStateEN._RefreshTimeLst.Count == 0) return "";
return clsCacheUseStateEN._RefreshTimeLst[clsCacheUseStateEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("缓存分类字段:[UserId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCacheUseStateBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
CacheHelper.Remove(strKey);
clsCacheUseStateEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCacheUseStateBL.objCommFun4BL.ReFreshCache(strUserId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CacheUseState(缓存使用状态)
 /// 唯一性条件:UserId_CacheModeId_CacheKey
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCacheUseStateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCacheUseStateEN objCacheUseStateEN)
{
//检测记录是否存在
string strResult = CacheUseStateDA.GetUniCondStr(objCacheUseStateEN);
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
 /// <param name = "strUserId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strUserId)
{
if (strInFldName != conCacheUseState.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCacheUseState.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCacheUseState.AttributeName));
throw new Exception(strMsg);
}
var objCacheUseState = clsCacheUseStateBL.GetObjBymIdCache(lngmId, strUserId);
if (objCacheUseState == null) return "";
return objCacheUseState[strOutFldName].ToString();
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
int intRecCount = clsCacheUseStateDA.GetRecCount(strTabName);
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
int intRecCount = clsCacheUseStateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCacheUseStateDA.GetRecCount();
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
int intRecCount = clsCacheUseStateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCacheUseStateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCacheUseStateEN objCacheUseStateCond)
{
 string strUserId = objCacheUseStateCond.UserId;
 if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsCacheUseStateBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsCacheUseStateEN> arrObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsCacheUseStateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCacheUseState.AttributeName)
{
if (objCacheUseStateCond.IsUpdated(strFldName) == false) continue;
if (objCacheUseStateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCacheUseStateCond[strFldName].ToString());
}
else
{
if (objCacheUseStateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCacheUseStateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCacheUseStateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCacheUseStateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCacheUseStateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCacheUseStateCond[strFldName]));
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
 List<string> arrList = clsCacheUseStateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CacheUseStateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CacheUseStateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CacheUseStateDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCacheUseStateDA.SetFldValue(clsCacheUseStateEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CacheUseStateDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCacheUseStateDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCacheUseStateDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCacheUseStateDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CacheUseState] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**缓存方式Id*/ 
 strCreateTabCode.Append(" CacheModeId char(2) not Null, "); 
 // /**缓存关键字*/ 
 strCreateTabCode.Append(" CacheKey varchar(50) not Null, "); 
 // /**缓存大小*/ 
 strCreateTabCode.Append(" CacheSize int Null, "); 
 // /**使用日期*/ 
 strCreateTabCode.Append(" UseDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**缓存方式名*/ 
 strCreateTabCode.Append(" CacheModeName varchar(50) Null, "); 
 // /**缓存方式英文名*/ 
 strCreateTabCode.Append(" CacheModeENName varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 缓存使用状态(CacheUseState)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CacheUseState : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strUserId)
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
clsCacheUseStateBL.ReFreshThisCache(strUserId);
}
}

}