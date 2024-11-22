﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsOperationTypeBL
 表名:OperationType(01120538)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:49
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
public static class  clsOperationTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strOperationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsOperationTypeEN GetObj(this K_OperationTypeId_OperationType myKey)
{
clsOperationTypeEN objOperationTypeEN = clsOperationTypeBL.OperationTypeDA.GetObjByOperationTypeId(myKey.Value);
return objOperationTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsOperationTypeEN objOperationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objOperationTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!操作类型ID = [{0}]的数据已经存在!(in clsOperationTypeBL.AddNewRecord)", objOperationTypeEN.OperationTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objOperationTypeEN.OperationTypeId) == true || clsOperationTypeBL.IsExist(objOperationTypeEN.OperationTypeId) == true)
 {
     objOperationTypeEN.OperationTypeId = clsOperationTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsOperationTypeBL.OperationTypeDA.AddNewRecordBySQL2(objOperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsOperationTypeBL.ReFreshCache();

if (clsOperationTypeBL.relatedActions != null)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(objOperationTypeEN.OperationTypeId, objOperationTypeEN.UpdUserId);
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
public static bool AddRecordEx(this clsOperationTypeEN objOperationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsOperationTypeBL.IsExist(objOperationTypeEN.OperationTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objOperationTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objOperationTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(操作类型ID(OperationTypeId)=[{0}])已经存在,不能重复!", objOperationTypeEN.OperationTypeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objOperationTypeEN.OperationTypeId) == true || clsOperationTypeBL.IsExist(objOperationTypeEN.OperationTypeId) == true)
 {
     objOperationTypeEN.OperationTypeId = clsOperationTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objOperationTypeEN.AddNewRecord();
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
 /// <param name = "objOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsOperationTypeEN objOperationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objOperationTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!操作类型ID = [{0}]的数据已经存在!(in clsOperationTypeBL.AddNewRecordWithMaxId)", objOperationTypeEN.OperationTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objOperationTypeEN.OperationTypeId) == true || clsOperationTypeBL.IsExist(objOperationTypeEN.OperationTypeId) == true)
 {
     objOperationTypeEN.OperationTypeId = clsOperationTypeBL.GetMaxStrId_S();
 }
string strOperationTypeId = clsOperationTypeBL.OperationTypeDA.AddNewRecordBySQL2WithReturnKey(objOperationTypeEN);
     objOperationTypeEN.OperationTypeId = strOperationTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsOperationTypeBL.ReFreshCache();

if (clsOperationTypeBL.relatedActions != null)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(objOperationTypeEN.OperationTypeId, objOperationTypeEN.UpdUserId);
}
return strOperationTypeId;
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
 /// <param name = "objOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsOperationTypeEN objOperationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objOperationTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!操作类型ID = [{0}]的数据已经存在!(in clsOperationTypeBL.AddNewRecordWithReturnKey)", objOperationTypeEN.OperationTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objOperationTypeEN.OperationTypeId) == true || clsOperationTypeBL.IsExist(objOperationTypeEN.OperationTypeId) == true)
 {
     objOperationTypeEN.OperationTypeId = clsOperationTypeBL.GetMaxStrId_S();
 }
string strKey = clsOperationTypeBL.OperationTypeDA.AddNewRecordBySQL2WithReturnKey(objOperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsOperationTypeBL.ReFreshCache();

if (clsOperationTypeBL.relatedActions != null)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(objOperationTypeEN.OperationTypeId, objOperationTypeEN.UpdUserId);
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
 /// <param name = "objOperationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsOperationTypeEN SetOperationTypeId(this clsOperationTypeEN objOperationTypeEN, string strOperationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeId, 4, conOperationType.OperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOperationTypeId, 4, conOperationType.OperationTypeId);
}
objOperationTypeEN.OperationTypeId = strOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objOperationTypeEN.dicFldComparisonOp.ContainsKey(conOperationType.OperationTypeId) == false)
{
objOperationTypeEN.dicFldComparisonOp.Add(conOperationType.OperationTypeId, strComparisonOp);
}
else
{
objOperationTypeEN.dicFldComparisonOp[conOperationType.OperationTypeId] = strComparisonOp;
}
}
return objOperationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objOperationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsOperationTypeEN SetOperationTypeName(this clsOperationTypeEN objOperationTypeEN, string strOperationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOperationTypeName, conOperationType.OperationTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeName, 50, conOperationType.OperationTypeName);
}
objOperationTypeEN.OperationTypeName = strOperationTypeName; //操作类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objOperationTypeEN.dicFldComparisonOp.ContainsKey(conOperationType.OperationTypeName) == false)
{
objOperationTypeEN.dicFldComparisonOp.Add(conOperationType.OperationTypeName, strComparisonOp);
}
else
{
objOperationTypeEN.dicFldComparisonOp[conOperationType.OperationTypeName] = strComparisonOp;
}
}
return objOperationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objOperationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsOperationTypeEN SetUpdDate(this clsOperationTypeEN objOperationTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conOperationType.UpdDate);
}
objOperationTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objOperationTypeEN.dicFldComparisonOp.ContainsKey(conOperationType.UpdDate) == false)
{
objOperationTypeEN.dicFldComparisonOp.Add(conOperationType.UpdDate, strComparisonOp);
}
else
{
objOperationTypeEN.dicFldComparisonOp[conOperationType.UpdDate] = strComparisonOp;
}
}
return objOperationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objOperationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsOperationTypeEN SetUpdUserId(this clsOperationTypeEN objOperationTypeEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conOperationType.UpdUserId);
}
objOperationTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objOperationTypeEN.dicFldComparisonOp.ContainsKey(conOperationType.UpdUserId) == false)
{
objOperationTypeEN.dicFldComparisonOp.Add(conOperationType.UpdUserId, strComparisonOp);
}
else
{
objOperationTypeEN.dicFldComparisonOp[conOperationType.UpdUserId] = strComparisonOp;
}
}
return objOperationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objOperationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsOperationTypeEN SetMemo(this clsOperationTypeEN objOperationTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conOperationType.Memo);
}
objOperationTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objOperationTypeEN.dicFldComparisonOp.ContainsKey(conOperationType.Memo) == false)
{
objOperationTypeEN.dicFldComparisonOp.Add(conOperationType.Memo, strComparisonOp);
}
else
{
objOperationTypeEN.dicFldComparisonOp[conOperationType.Memo] = strComparisonOp;
}
}
return objOperationTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objOperationTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsOperationTypeEN objOperationTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objOperationTypeEN.CheckPropertyNew();
clsOperationTypeEN objOperationTypeCond = new clsOperationTypeEN();
string strCondition = objOperationTypeCond
.SetOperationTypeId(objOperationTypeEN.OperationTypeId, "<>")
.SetOperationTypeId(objOperationTypeEN.OperationTypeId, "=")
.GetCombineCondition();
objOperationTypeEN._IsCheckProperty = true;
bool bolIsExist = clsOperationTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(OperationTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objOperationTypeEN.Update();
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
 /// <param name = "objOperationType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsOperationTypeEN objOperationType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsOperationTypeEN objOperationTypeCond = new clsOperationTypeEN();
string strCondition = objOperationTypeCond
.SetOperationTypeId(objOperationType.OperationTypeId, "=")
.GetCombineCondition();
objOperationType._IsCheckProperty = true;
bool bolIsExist = clsOperationTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objOperationType.OperationTypeId = clsOperationTypeBL.GetFirstID_S(strCondition);
objOperationType.UpdateWithCondition(strCondition);
}
else
{
objOperationType.OperationTypeId = clsOperationTypeBL.GetMaxStrId_S();
objOperationType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsOperationTypeEN objOperationTypeEN)
{
 if (string.IsNullOrEmpty(objOperationTypeEN.OperationTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsOperationTypeBL.OperationTypeDA.UpdateBySql2(objOperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsOperationTypeBL.ReFreshCache();

if (clsOperationTypeBL.relatedActions != null)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(objOperationTypeEN.OperationTypeId, objOperationTypeEN.UpdUserId);
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
 /// <param name = "objOperationTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsOperationTypeEN objOperationTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objOperationTypeEN.OperationTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsOperationTypeBL.OperationTypeDA.UpdateBySql2(objOperationTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsOperationTypeBL.ReFreshCache();

if (clsOperationTypeBL.relatedActions != null)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(objOperationTypeEN.OperationTypeId, objOperationTypeEN.UpdUserId);
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
 /// <param name = "objOperationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsOperationTypeEN objOperationTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsOperationTypeBL.OperationTypeDA.UpdateBySqlWithCondition(objOperationTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsOperationTypeBL.ReFreshCache();

if (clsOperationTypeBL.relatedActions != null)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(objOperationTypeEN.OperationTypeId, objOperationTypeEN.UpdUserId);
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
 /// <param name = "objOperationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsOperationTypeEN objOperationTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsOperationTypeBL.OperationTypeDA.UpdateBySqlWithConditionTransaction(objOperationTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsOperationTypeBL.ReFreshCache();

if (clsOperationTypeBL.relatedActions != null)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(objOperationTypeEN.OperationTypeId, objOperationTypeEN.UpdUserId);
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
 /// <param name = "strOperationTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsOperationTypeEN objOperationTypeEN)
{
try
{
int intRecNum = clsOperationTypeBL.OperationTypeDA.DelRecord(objOperationTypeEN.OperationTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsOperationTypeBL.ReFreshCache();

if (clsOperationTypeBL.relatedActions != null)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(objOperationTypeEN.OperationTypeId, objOperationTypeEN.UpdUserId);
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
 /// <param name = "objOperationTypeENS">源对象</param>
 /// <param name = "objOperationTypeENT">目标对象</param>
 public static void CopyTo(this clsOperationTypeEN objOperationTypeENS, clsOperationTypeEN objOperationTypeENT)
{
try
{
objOperationTypeENT.OperationTypeId = objOperationTypeENS.OperationTypeId; //操作类型ID
objOperationTypeENT.OperationTypeName = objOperationTypeENS.OperationTypeName; //操作类型名
objOperationTypeENT.UpdDate = objOperationTypeENS.UpdDate; //修改日期
objOperationTypeENT.UpdUserId = objOperationTypeENS.UpdUserId; //修改用户Id
objOperationTypeENT.Memo = objOperationTypeENS.Memo; //备注
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
 /// <param name = "objOperationTypeENS">源对象</param>
 /// <returns>目标对象=>clsOperationTypeEN:objOperationTypeENT</returns>
 public static clsOperationTypeEN CopyTo(this clsOperationTypeEN objOperationTypeENS)
{
try
{
 clsOperationTypeEN objOperationTypeENT = new clsOperationTypeEN()
{
OperationTypeId = objOperationTypeENS.OperationTypeId, //操作类型ID
OperationTypeName = objOperationTypeENS.OperationTypeName, //操作类型名
UpdDate = objOperationTypeENS.UpdDate, //修改日期
UpdUserId = objOperationTypeENS.UpdUserId, //修改用户Id
Memo = objOperationTypeENS.Memo, //备注
};
 return objOperationTypeENT;
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
public static void CheckPropertyNew(this clsOperationTypeEN objOperationTypeEN)
{
 clsOperationTypeBL.OperationTypeDA.CheckPropertyNew(objOperationTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsOperationTypeEN objOperationTypeEN)
{
 clsOperationTypeBL.OperationTypeDA.CheckProperty4Condition(objOperationTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsOperationTypeEN objOperationTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objOperationTypeCond.IsUpdated(conOperationType.OperationTypeId) == true)
{
string strComparisonOpOperationTypeId = objOperationTypeCond.dicFldComparisonOp[conOperationType.OperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conOperationType.OperationTypeId, objOperationTypeCond.OperationTypeId, strComparisonOpOperationTypeId);
}
if (objOperationTypeCond.IsUpdated(conOperationType.OperationTypeName) == true)
{
string strComparisonOpOperationTypeName = objOperationTypeCond.dicFldComparisonOp[conOperationType.OperationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conOperationType.OperationTypeName, objOperationTypeCond.OperationTypeName, strComparisonOpOperationTypeName);
}
if (objOperationTypeCond.IsUpdated(conOperationType.UpdDate) == true)
{
string strComparisonOpUpdDate = objOperationTypeCond.dicFldComparisonOp[conOperationType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conOperationType.UpdDate, objOperationTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objOperationTypeCond.IsUpdated(conOperationType.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objOperationTypeCond.dicFldComparisonOp[conOperationType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conOperationType.UpdUserId, objOperationTypeCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objOperationTypeCond.IsUpdated(conOperationType.Memo) == true)
{
string strComparisonOpMemo = objOperationTypeCond.dicFldComparisonOp[conOperationType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conOperationType.Memo, objOperationTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--OperationType(操作类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:OperationTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objOperationTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsOperationTypeEN objOperationTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objOperationTypeEN == null) return true;
if (objOperationTypeEN.OperationTypeId == null || objOperationTypeEN.OperationTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and OperationTypeId = '{0}'", objOperationTypeEN.OperationTypeId);
if (clsOperationTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("OperationTypeId !=  '{0}'", objOperationTypeEN.OperationTypeId);
 sbCondition.AppendFormat(" and OperationTypeId = '{0}'", objOperationTypeEN.OperationTypeId);
if (clsOperationTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--OperationType(操作类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:OperationTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objOperationTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsOperationTypeEN objOperationTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objOperationTypeEN == null) return "";
if (objOperationTypeEN.OperationTypeId == null || objOperationTypeEN.OperationTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and OperationTypeId = '{0}'", objOperationTypeEN.OperationTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("OperationTypeId !=  '{0}'", objOperationTypeEN.OperationTypeId);
 sbCondition.AppendFormat(" and OperationTypeId = '{0}'", objOperationTypeEN.OperationTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_OperationType
{
public virtual bool UpdRelaTabDate(string strOperationTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 操作类型(OperationType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsOperationTypeBL
{
public static RelatedActions_OperationType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsOperationTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsOperationTypeDA OperationTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsOperationTypeDA();
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
 public clsOperationTypeBL()
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
if (string.IsNullOrEmpty(clsOperationTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsOperationTypeEN._ConnectString);
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
public static DataTable GetDataTable_OperationType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = OperationTypeDA.GetDataTable_OperationType(strWhereCond);
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
objDT = OperationTypeDA.GetDataTable(strWhereCond);
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
objDT = OperationTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = OperationTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = OperationTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = OperationTypeDA.GetDataTable_Top(objTopPara);
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
objDT = OperationTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = OperationTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = OperationTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrOperationTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsOperationTypeEN> GetObjLstByOperationTypeIdLst(List<string> arrOperationTypeIdLst)
{
List<clsOperationTypeEN> arrObjLst = new List<clsOperationTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrOperationTypeIdLst, true);
 string strWhereCond = string.Format("OperationTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsOperationTypeEN objOperationTypeEN = new clsOperationTypeEN();
try
{
objOperationTypeEN.OperationTypeId = objRow[conOperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objOperationTypeEN.OperationTypeName = objRow[conOperationType.OperationTypeName].ToString().Trim(); //操作类型名
objOperationTypeEN.UpdDate = objRow[conOperationType.UpdDate] == DBNull.Value ? null : objRow[conOperationType.UpdDate].ToString().Trim(); //修改日期
objOperationTypeEN.UpdUserId = objRow[conOperationType.UpdUserId] == DBNull.Value ? null : objRow[conOperationType.UpdUserId].ToString().Trim(); //修改用户Id
objOperationTypeEN.Memo = objRow[conOperationType.Memo] == DBNull.Value ? null : objRow[conOperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objOperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objOperationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrOperationTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsOperationTypeEN> GetObjLstByOperationTypeIdLstCache(List<string> arrOperationTypeIdLst)
{
string strKey = string.Format("{0}", clsOperationTypeEN._CurrTabName);
List<clsOperationTypeEN> arrOperationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsOperationTypeEN> arrOperationTypeObjLst_Sel =
arrOperationTypeObjLstCache
.Where(x => arrOperationTypeIdLst.Contains(x.OperationTypeId));
return arrOperationTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsOperationTypeEN> GetObjLst(string strWhereCond)
{
List<clsOperationTypeEN> arrObjLst = new List<clsOperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsOperationTypeEN objOperationTypeEN = new clsOperationTypeEN();
try
{
objOperationTypeEN.OperationTypeId = objRow[conOperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objOperationTypeEN.OperationTypeName = objRow[conOperationType.OperationTypeName].ToString().Trim(); //操作类型名
objOperationTypeEN.UpdDate = objRow[conOperationType.UpdDate] == DBNull.Value ? null : objRow[conOperationType.UpdDate].ToString().Trim(); //修改日期
objOperationTypeEN.UpdUserId = objRow[conOperationType.UpdUserId] == DBNull.Value ? null : objRow[conOperationType.UpdUserId].ToString().Trim(); //修改用户Id
objOperationTypeEN.Memo = objRow[conOperationType.Memo] == DBNull.Value ? null : objRow[conOperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objOperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objOperationTypeEN);
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
public static List<clsOperationTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsOperationTypeEN> arrObjLst = new List<clsOperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsOperationTypeEN objOperationTypeEN = new clsOperationTypeEN();
try
{
objOperationTypeEN.OperationTypeId = objRow[conOperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objOperationTypeEN.OperationTypeName = objRow[conOperationType.OperationTypeName].ToString().Trim(); //操作类型名
objOperationTypeEN.UpdDate = objRow[conOperationType.UpdDate] == DBNull.Value ? null : objRow[conOperationType.UpdDate].ToString().Trim(); //修改日期
objOperationTypeEN.UpdUserId = objRow[conOperationType.UpdUserId] == DBNull.Value ? null : objRow[conOperationType.UpdUserId].ToString().Trim(); //修改用户Id
objOperationTypeEN.Memo = objRow[conOperationType.Memo] == DBNull.Value ? null : objRow[conOperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objOperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objOperationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objOperationTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsOperationTypeEN> GetSubObjLstCache(clsOperationTypeEN objOperationTypeCond)
{
List<clsOperationTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsOperationTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conOperationType.AttributeName)
{
if (objOperationTypeCond.IsUpdated(strFldName) == false) continue;
if (objOperationTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objOperationTypeCond[strFldName].ToString());
}
else
{
if (objOperationTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objOperationTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objOperationTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objOperationTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objOperationTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objOperationTypeCond[strFldName]));
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
public static List<clsOperationTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsOperationTypeEN> arrObjLst = new List<clsOperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsOperationTypeEN objOperationTypeEN = new clsOperationTypeEN();
try
{
objOperationTypeEN.OperationTypeId = objRow[conOperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objOperationTypeEN.OperationTypeName = objRow[conOperationType.OperationTypeName].ToString().Trim(); //操作类型名
objOperationTypeEN.UpdDate = objRow[conOperationType.UpdDate] == DBNull.Value ? null : objRow[conOperationType.UpdDate].ToString().Trim(); //修改日期
objOperationTypeEN.UpdUserId = objRow[conOperationType.UpdUserId] == DBNull.Value ? null : objRow[conOperationType.UpdUserId].ToString().Trim(); //修改用户Id
objOperationTypeEN.Memo = objRow[conOperationType.Memo] == DBNull.Value ? null : objRow[conOperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objOperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objOperationTypeEN);
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
public static List<clsOperationTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsOperationTypeEN> arrObjLst = new List<clsOperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsOperationTypeEN objOperationTypeEN = new clsOperationTypeEN();
try
{
objOperationTypeEN.OperationTypeId = objRow[conOperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objOperationTypeEN.OperationTypeName = objRow[conOperationType.OperationTypeName].ToString().Trim(); //操作类型名
objOperationTypeEN.UpdDate = objRow[conOperationType.UpdDate] == DBNull.Value ? null : objRow[conOperationType.UpdDate].ToString().Trim(); //修改日期
objOperationTypeEN.UpdUserId = objRow[conOperationType.UpdUserId] == DBNull.Value ? null : objRow[conOperationType.UpdUserId].ToString().Trim(); //修改用户Id
objOperationTypeEN.Memo = objRow[conOperationType.Memo] == DBNull.Value ? null : objRow[conOperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objOperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objOperationTypeEN);
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
List<clsOperationTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsOperationTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsOperationTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsOperationTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsOperationTypeEN> arrObjLst = new List<clsOperationTypeEN>(); 
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
	clsOperationTypeEN objOperationTypeEN = new clsOperationTypeEN();
try
{
objOperationTypeEN.OperationTypeId = objRow[conOperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objOperationTypeEN.OperationTypeName = objRow[conOperationType.OperationTypeName].ToString().Trim(); //操作类型名
objOperationTypeEN.UpdDate = objRow[conOperationType.UpdDate] == DBNull.Value ? null : objRow[conOperationType.UpdDate].ToString().Trim(); //修改日期
objOperationTypeEN.UpdUserId = objRow[conOperationType.UpdUserId] == DBNull.Value ? null : objRow[conOperationType.UpdUserId].ToString().Trim(); //修改用户Id
objOperationTypeEN.Memo = objRow[conOperationType.Memo] == DBNull.Value ? null : objRow[conOperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objOperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objOperationTypeEN);
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
public static List<clsOperationTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsOperationTypeEN> arrObjLst = new List<clsOperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsOperationTypeEN objOperationTypeEN = new clsOperationTypeEN();
try
{
objOperationTypeEN.OperationTypeId = objRow[conOperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objOperationTypeEN.OperationTypeName = objRow[conOperationType.OperationTypeName].ToString().Trim(); //操作类型名
objOperationTypeEN.UpdDate = objRow[conOperationType.UpdDate] == DBNull.Value ? null : objRow[conOperationType.UpdDate].ToString().Trim(); //修改日期
objOperationTypeEN.UpdUserId = objRow[conOperationType.UpdUserId] == DBNull.Value ? null : objRow[conOperationType.UpdUserId].ToString().Trim(); //修改用户Id
objOperationTypeEN.Memo = objRow[conOperationType.Memo] == DBNull.Value ? null : objRow[conOperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objOperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objOperationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsOperationTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsOperationTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsOperationTypeEN> arrObjLst = new List<clsOperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsOperationTypeEN objOperationTypeEN = new clsOperationTypeEN();
try
{
objOperationTypeEN.OperationTypeId = objRow[conOperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objOperationTypeEN.OperationTypeName = objRow[conOperationType.OperationTypeName].ToString().Trim(); //操作类型名
objOperationTypeEN.UpdDate = objRow[conOperationType.UpdDate] == DBNull.Value ? null : objRow[conOperationType.UpdDate].ToString().Trim(); //修改日期
objOperationTypeEN.UpdUserId = objRow[conOperationType.UpdUserId] == DBNull.Value ? null : objRow[conOperationType.UpdUserId].ToString().Trim(); //修改用户Id
objOperationTypeEN.Memo = objRow[conOperationType.Memo] == DBNull.Value ? null : objRow[conOperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objOperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objOperationTypeEN);
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
public static List<clsOperationTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsOperationTypeEN> arrObjLst = new List<clsOperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsOperationTypeEN objOperationTypeEN = new clsOperationTypeEN();
try
{
objOperationTypeEN.OperationTypeId = objRow[conOperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objOperationTypeEN.OperationTypeName = objRow[conOperationType.OperationTypeName].ToString().Trim(); //操作类型名
objOperationTypeEN.UpdDate = objRow[conOperationType.UpdDate] == DBNull.Value ? null : objRow[conOperationType.UpdDate].ToString().Trim(); //修改日期
objOperationTypeEN.UpdUserId = objRow[conOperationType.UpdUserId] == DBNull.Value ? null : objRow[conOperationType.UpdUserId].ToString().Trim(); //修改用户Id
objOperationTypeEN.Memo = objRow[conOperationType.Memo] == DBNull.Value ? null : objRow[conOperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objOperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objOperationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsOperationTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsOperationTypeEN> arrObjLst = new List<clsOperationTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsOperationTypeEN objOperationTypeEN = new clsOperationTypeEN();
try
{
objOperationTypeEN.OperationTypeId = objRow[conOperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objOperationTypeEN.OperationTypeName = objRow[conOperationType.OperationTypeName].ToString().Trim(); //操作类型名
objOperationTypeEN.UpdDate = objRow[conOperationType.UpdDate] == DBNull.Value ? null : objRow[conOperationType.UpdDate].ToString().Trim(); //修改日期
objOperationTypeEN.UpdUserId = objRow[conOperationType.UpdUserId] == DBNull.Value ? null : objRow[conOperationType.UpdUserId].ToString().Trim(); //修改用户Id
objOperationTypeEN.Memo = objRow[conOperationType.Memo] == DBNull.Value ? null : objRow[conOperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objOperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objOperationTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objOperationTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetOperationType(ref clsOperationTypeEN objOperationTypeEN)
{
bool bolResult = OperationTypeDA.GetOperationType(ref objOperationTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strOperationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsOperationTypeEN GetObjByOperationTypeId(string strOperationTypeId)
{
if (strOperationTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strOperationTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strOperationTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strOperationTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsOperationTypeEN objOperationTypeEN = OperationTypeDA.GetObjByOperationTypeId(strOperationTypeId);
return objOperationTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsOperationTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsOperationTypeEN objOperationTypeEN = OperationTypeDA.GetFirstObj(strWhereCond);
 return objOperationTypeEN;
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
public static clsOperationTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsOperationTypeEN objOperationTypeEN = OperationTypeDA.GetObjByDataRow(objRow);
 return objOperationTypeEN;
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
public static clsOperationTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsOperationTypeEN objOperationTypeEN = OperationTypeDA.GetObjByDataRow(objRow);
 return objOperationTypeEN;
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
 /// <param name = "strOperationTypeId">所给的关键字</param>
 /// <param name = "lstOperationTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsOperationTypeEN GetObjByOperationTypeIdFromList(string strOperationTypeId, List<clsOperationTypeEN> lstOperationTypeObjLst)
{
foreach (clsOperationTypeEN objOperationTypeEN in lstOperationTypeObjLst)
{
if (objOperationTypeEN.OperationTypeId == strOperationTypeId)
{
return objOperationTypeEN;
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
 string strMaxOperationTypeId;
 try
 {
 strMaxOperationTypeId = clsOperationTypeDA.GetMaxStrId();
 return strMaxOperationTypeId;
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
 string strOperationTypeId;
 try
 {
 strOperationTypeId = new clsOperationTypeDA().GetFirstID(strWhereCond);
 return strOperationTypeId;
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
 arrList = OperationTypeDA.GetID(strWhereCond);
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
bool bolIsExist = OperationTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strOperationTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strOperationTypeId)
{
if (string.IsNullOrEmpty(strOperationTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strOperationTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = OperationTypeDA.IsExist(strOperationTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strOperationTypeId">操作类型ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strOperationTypeId, string strOpUser)
{
clsOperationTypeEN objOperationTypeEN = clsOperationTypeBL.GetObjByOperationTypeId(strOperationTypeId);
objOperationTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objOperationTypeEN.UpdUserId = strOpUser;
return clsOperationTypeBL.UpdateBySql2(objOperationTypeEN);
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
 bolIsExist = clsOperationTypeDA.IsExistTable();
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
 bolIsExist = OperationTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsOperationTypeEN objOperationTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objOperationTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!操作类型ID = [{0}]的数据已经存在!(in clsOperationTypeBL.AddNewRecordBySql2)", objOperationTypeEN.OperationTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objOperationTypeEN.OperationTypeId) == true || clsOperationTypeBL.IsExist(objOperationTypeEN.OperationTypeId) == true)
 {
     objOperationTypeEN.OperationTypeId = clsOperationTypeBL.GetMaxStrId_S();
 }
bool bolResult = OperationTypeDA.AddNewRecordBySQL2(objOperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsOperationTypeBL.ReFreshCache();

if (clsOperationTypeBL.relatedActions != null)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(objOperationTypeEN.OperationTypeId, objOperationTypeEN.UpdUserId);
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
 /// <param name = "objOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsOperationTypeEN objOperationTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objOperationTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!操作类型ID = [{0}]的数据已经存在!(in clsOperationTypeBL.AddNewRecordBySql2WithReturnKey)", objOperationTypeEN.OperationTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objOperationTypeEN.OperationTypeId) == true || clsOperationTypeBL.IsExist(objOperationTypeEN.OperationTypeId) == true)
 {
     objOperationTypeEN.OperationTypeId = clsOperationTypeBL.GetMaxStrId_S();
 }
string strKey = OperationTypeDA.AddNewRecordBySQL2WithReturnKey(objOperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsOperationTypeBL.ReFreshCache();

if (clsOperationTypeBL.relatedActions != null)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(objOperationTypeEN.OperationTypeId, objOperationTypeEN.UpdUserId);
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
 /// <param name = "objOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsOperationTypeEN objOperationTypeEN)
{
try
{
bool bolResult = OperationTypeDA.Update(objOperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsOperationTypeBL.ReFreshCache();

if (clsOperationTypeBL.relatedActions != null)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(objOperationTypeEN.OperationTypeId, objOperationTypeEN.UpdUserId);
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
 /// <param name = "objOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsOperationTypeEN objOperationTypeEN)
{
 if (string.IsNullOrEmpty(objOperationTypeEN.OperationTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = OperationTypeDA.UpdateBySql2(objOperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsOperationTypeBL.ReFreshCache();

if (clsOperationTypeBL.relatedActions != null)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(objOperationTypeEN.OperationTypeId, objOperationTypeEN.UpdUserId);
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
 /// <param name = "strOperationTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strOperationTypeId)
{
try
{
 clsOperationTypeEN objOperationTypeEN = clsOperationTypeBL.GetObjByOperationTypeId(strOperationTypeId);

if (clsOperationTypeBL.relatedActions != null)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(objOperationTypeEN.OperationTypeId, objOperationTypeEN.UpdUserId);
}
if (objOperationTypeEN != null)
{
int intRecNum = OperationTypeDA.DelRecord(strOperationTypeId);
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
/// <param name="strOperationTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strOperationTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsOperationTypeDA.GetSpecSQLObj();
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
//删除与表:[OperationType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conOperationType.OperationTypeId,
//strOperationTypeId);
//        clsOperationTypeBL.DelOperationTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsOperationTypeBL.DelRecord(strOperationTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsOperationTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strOperationTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strOperationTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strOperationTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsOperationTypeBL.relatedActions != null)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(strOperationTypeId, "UpdRelaTabDate");
}
bool bolResult = OperationTypeDA.DelRecord(strOperationTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrOperationTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelOperationTypes(List<string> arrOperationTypeIdLst)
{
if (arrOperationTypeIdLst.Count == 0) return 0;
try
{
if (clsOperationTypeBL.relatedActions != null)
{
foreach (var strOperationTypeId in arrOperationTypeIdLst)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(strOperationTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = OperationTypeDA.DelOperationType(arrOperationTypeIdLst);
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
public static int DelOperationTypesByCond(string strWhereCond)
{
try
{
if (clsOperationTypeBL.relatedActions != null)
{
List<string> arrOperationTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strOperationTypeId in arrOperationTypeId)
{
clsOperationTypeBL.relatedActions.UpdRelaTabDate(strOperationTypeId, "UpdRelaTabDate");
}
}
int intRecNum = OperationTypeDA.DelOperationType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[OperationType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strOperationTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strOperationTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsOperationTypeDA.GetSpecSQLObj();
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
//删除与表:[OperationType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsOperationTypeBL.DelRecord(strOperationTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsOperationTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strOperationTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objOperationTypeENS">源对象</param>
 /// <param name = "objOperationTypeENT">目标对象</param>
 public static void CopyTo(clsOperationTypeEN objOperationTypeENS, clsOperationTypeEN objOperationTypeENT)
{
try
{
objOperationTypeENT.OperationTypeId = objOperationTypeENS.OperationTypeId; //操作类型ID
objOperationTypeENT.OperationTypeName = objOperationTypeENS.OperationTypeName; //操作类型名
objOperationTypeENT.UpdDate = objOperationTypeENS.UpdDate; //修改日期
objOperationTypeENT.UpdUserId = objOperationTypeENS.UpdUserId; //修改用户Id
objOperationTypeENT.Memo = objOperationTypeENS.Memo; //备注
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
 /// <param name = "objOperationTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsOperationTypeEN objOperationTypeEN)
{
try
{
objOperationTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objOperationTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conOperationType.OperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objOperationTypeEN.OperationTypeId = objOperationTypeEN.OperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(conOperationType.OperationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objOperationTypeEN.OperationTypeName = objOperationTypeEN.OperationTypeName; //操作类型名
}
if (arrFldSet.Contains(conOperationType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objOperationTypeEN.UpdDate = objOperationTypeEN.UpdDate == "[null]" ? null :  objOperationTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conOperationType.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objOperationTypeEN.UpdUserId = objOperationTypeEN.UpdUserId == "[null]" ? null :  objOperationTypeEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conOperationType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objOperationTypeEN.Memo = objOperationTypeEN.Memo == "[null]" ? null :  objOperationTypeEN.Memo; //备注
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
 /// <param name = "objOperationTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsOperationTypeEN objOperationTypeEN)
{
try
{
if (objOperationTypeEN.UpdDate == "[null]") objOperationTypeEN.UpdDate = null; //修改日期
if (objOperationTypeEN.UpdUserId == "[null]") objOperationTypeEN.UpdUserId = null; //修改用户Id
if (objOperationTypeEN.Memo == "[null]") objOperationTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsOperationTypeEN objOperationTypeEN)
{
 OperationTypeDA.CheckPropertyNew(objOperationTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsOperationTypeEN objOperationTypeEN)
{
 OperationTypeDA.CheckProperty4Condition(objOperationTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_OperationTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[操作类型]...","0");
List<clsOperationTypeEN> arrOperationTypeObjLst = GetAllOperationTypeObjLstCache(); 
objDDL.DataValueField = conOperationType.OperationTypeId;
objDDL.DataTextField = conOperationType.OperationTypeName;
objDDL.DataSource = arrOperationTypeObjLst;
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
if (clsOperationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsOperationTypeBL没有刷新缓存机制(clsOperationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by OperationTypeId");
//if (arrOperationTypeObjLstCache == null)
//{
//arrOperationTypeObjLstCache = OperationTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strOperationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsOperationTypeEN GetObjByOperationTypeIdCache(string strOperationTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsOperationTypeEN._CurrTabName);
List<clsOperationTypeEN> arrOperationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsOperationTypeEN> arrOperationTypeObjLst_Sel =
arrOperationTypeObjLstCache
.Where(x=> x.OperationTypeId == strOperationTypeId 
);
if (arrOperationTypeObjLst_Sel.Count() == 0)
{
   clsOperationTypeEN obj = clsOperationTypeBL.GetObjByOperationTypeId(strOperationTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrOperationTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strOperationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetOperationTypeNameByOperationTypeIdCache(string strOperationTypeId)
{
if (string.IsNullOrEmpty(strOperationTypeId) == true) return "";
//获取缓存中的对象列表
clsOperationTypeEN objOperationType = GetObjByOperationTypeIdCache(strOperationTypeId);
if (objOperationType == null) return "";
return objOperationType.OperationTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strOperationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByOperationTypeIdCache(string strOperationTypeId)
{
if (string.IsNullOrEmpty(strOperationTypeId) == true) return "";
//获取缓存中的对象列表
clsOperationTypeEN objOperationType = GetObjByOperationTypeIdCache(strOperationTypeId);
if (objOperationType == null) return "";
return objOperationType.OperationTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsOperationTypeEN> GetAllOperationTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsOperationTypeEN> arrOperationTypeObjLstCache = GetObjLstCache(); 
return arrOperationTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsOperationTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsOperationTypeEN._CurrTabName);
List<clsOperationTypeEN> arrOperationTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrOperationTypeObjLstCache;
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
string strKey = string.Format("{0}", clsOperationTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsOperationTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsOperationTypeEN._RefreshTimeLst.Count == 0) return "";
return clsOperationTypeEN._RefreshTimeLst[clsOperationTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsOperationTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsOperationTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsOperationTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsOperationTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--OperationType(操作类型)
 /// 唯一性条件:OperationTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objOperationTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsOperationTypeEN objOperationTypeEN)
{
//检测记录是否存在
string strResult = OperationTypeDA.GetUniCondStr(objOperationTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strOperationTypeId)
{
if (strInFldName != conOperationType.OperationTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conOperationType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conOperationType.AttributeName));
throw new Exception(strMsg);
}
var objOperationType = clsOperationTypeBL.GetObjByOperationTypeIdCache(strOperationTypeId);
if (objOperationType == null) return "";
return objOperationType[strOutFldName].ToString();
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
int intRecCount = clsOperationTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsOperationTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsOperationTypeDA.GetRecCount();
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
int intRecCount = clsOperationTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objOperationTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsOperationTypeEN objOperationTypeCond)
{
List<clsOperationTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsOperationTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conOperationType.AttributeName)
{
if (objOperationTypeCond.IsUpdated(strFldName) == false) continue;
if (objOperationTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objOperationTypeCond[strFldName].ToString());
}
else
{
if (objOperationTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objOperationTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objOperationTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objOperationTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objOperationTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objOperationTypeCond[strFldName]));
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
 List<string> arrList = clsOperationTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = OperationTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = OperationTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = OperationTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsOperationTypeDA.SetFldValue(clsOperationTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = OperationTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsOperationTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsOperationTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsOperationTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[OperationType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**操作类型ID*/ 
 strCreateTabCode.Append(" OperationTypeId char(4) primary key, "); 
 // /**操作类型名*/ 
 strCreateTabCode.Append(" OperationTypeName varchar(50) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 操作类型(OperationType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4OperationType : clsCommFun4BL
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
clsOperationTypeBL.ReFreshThisCache();
}
}

}