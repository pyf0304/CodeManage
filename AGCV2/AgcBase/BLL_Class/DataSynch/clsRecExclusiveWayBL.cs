﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRecExclusiveWayBL
 表名:RecExclusiveWay(00050273)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:44
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class clsRecExclusiveWayBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRecExclusiveWayId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRecExclusiveWayEN GetObj(this K_RecExclusiveWayId_RecExclusiveWay myKey)
{
clsRecExclusiveWayEN objRecExclusiveWayEN = clsRecExclusiveWayBL.RecExclusiveWayDA.GetObjByRecExclusiveWayId(myKey.Value);
return objRecExclusiveWayEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsRecExclusiveWayEN objRecExclusiveWayEN)
{
 if (string.IsNullOrEmpty(objRecExclusiveWayEN.RecExclusiveWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsRecExclusiveWayBL.IsExist(objRecExclusiveWayEN.RecExclusiveWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objRecExclusiveWayEN.RecExclusiveWayId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsRecExclusiveWayBL.RecExclusiveWayDA.AddNewRecordBySQL2(objRecExclusiveWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRecExclusiveWayBL.ReFreshCache();

if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(objRecExclusiveWayEN.RecExclusiveWayId, "SetUpdDate");
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
public static bool AddRecordEx(this clsRecExclusiveWayEN objRecExclusiveWayEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsRecExclusiveWayBL.IsExist(objRecExclusiveWayEN.RecExclusiveWayId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objRecExclusiveWayEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objRecExclusiveWayEN.AddNewRecord();
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
 /// <param name = "objRecExclusiveWayEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsRecExclusiveWayEN objRecExclusiveWayEN)
{
 if (string.IsNullOrEmpty(objRecExclusiveWayEN.RecExclusiveWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsRecExclusiveWayBL.IsExist(objRecExclusiveWayEN.RecExclusiveWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objRecExclusiveWayEN.RecExclusiveWayId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsRecExclusiveWayBL.RecExclusiveWayDA.AddNewRecordBySQL2WithReturnKey(objRecExclusiveWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRecExclusiveWayBL.ReFreshCache();

if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(objRecExclusiveWayEN.RecExclusiveWayId, "SetUpdDate");
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRecExclusiveWayEN SetRecExclusiveWayId(this clsRecExclusiveWayEN objRecExclusiveWayEN, string strRecExclusiveWayId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecExclusiveWayId, 4, conRecExclusiveWay.RecExclusiveWayId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecExclusiveWayId, 4, conRecExclusiveWay.RecExclusiveWayId);
}
objRecExclusiveWayEN.RecExclusiveWayId = strRecExclusiveWayId; //记录排他方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRecExclusiveWayEN.dicFldComparisonOp.ContainsKey(conRecExclusiveWay.RecExclusiveWayId) == false)
{
objRecExclusiveWayEN.dicFldComparisonOp.Add(conRecExclusiveWay.RecExclusiveWayId, strComparisonOp);
}
else
{
objRecExclusiveWayEN.dicFldComparisonOp[conRecExclusiveWay.RecExclusiveWayId] = strComparisonOp;
}
}
return objRecExclusiveWayEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRecExclusiveWayEN SetRecExclusiveWayName(this clsRecExclusiveWayEN objRecExclusiveWayEN, string strRecExclusiveWayName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecExclusiveWayName, conRecExclusiveWay.RecExclusiveWayName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecExclusiveWayName, 30, conRecExclusiveWay.RecExclusiveWayName);
}
objRecExclusiveWayEN.RecExclusiveWayName = strRecExclusiveWayName; //记录排他方式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRecExclusiveWayEN.dicFldComparisonOp.ContainsKey(conRecExclusiveWay.RecExclusiveWayName) == false)
{
objRecExclusiveWayEN.dicFldComparisonOp.Add(conRecExclusiveWay.RecExclusiveWayName, strComparisonOp);
}
else
{
objRecExclusiveWayEN.dicFldComparisonOp[conRecExclusiveWay.RecExclusiveWayName] = strComparisonOp;
}
}
return objRecExclusiveWayEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRecExclusiveWayEN SetMemo(this clsRecExclusiveWayEN objRecExclusiveWayEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conRecExclusiveWay.Memo);
}
objRecExclusiveWayEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRecExclusiveWayEN.dicFldComparisonOp.ContainsKey(conRecExclusiveWay.Memo) == false)
{
objRecExclusiveWayEN.dicFldComparisonOp.Add(conRecExclusiveWay.Memo, strComparisonOp);
}
else
{
objRecExclusiveWayEN.dicFldComparisonOp[conRecExclusiveWay.Memo] = strComparisonOp;
}
}
return objRecExclusiveWayEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsRecExclusiveWayEN objRecExclusiveWayEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objRecExclusiveWayEN.CheckPropertyNew();
clsRecExclusiveWayEN objRecExclusiveWayCond = new clsRecExclusiveWayEN();
string strCondition = objRecExclusiveWayCond
.SetRecExclusiveWayId(objRecExclusiveWayEN.RecExclusiveWayId, "=")
.GetCombineCondition();
objRecExclusiveWayEN._IsCheckProperty = true;
bool bolIsExist = clsRecExclusiveWayBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objRecExclusiveWayEN.Update();
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
 /// <param name = "objRecExclusiveWayEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRecExclusiveWayEN objRecExclusiveWayEN)
{
 if (string.IsNullOrEmpty(objRecExclusiveWayEN.RecExclusiveWayId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRecExclusiveWayBL.RecExclusiveWayDA.UpdateBySql2(objRecExclusiveWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRecExclusiveWayBL.ReFreshCache();

if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(objRecExclusiveWayEN.RecExclusiveWayId, "SetUpdDate");
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
 /// <param name = "objRecExclusiveWayEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRecExclusiveWayEN objRecExclusiveWayEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objRecExclusiveWayEN.RecExclusiveWayId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRecExclusiveWayBL.RecExclusiveWayDA.UpdateBySql2(objRecExclusiveWayEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRecExclusiveWayBL.ReFreshCache();

if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(objRecExclusiveWayEN.RecExclusiveWayId, "SetUpdDate");
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
 /// <param name = "objRecExclusiveWayEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRecExclusiveWayEN objRecExclusiveWayEN, string strWhereCond)
{
try
{
bool bolResult = clsRecExclusiveWayBL.RecExclusiveWayDA.UpdateBySqlWithCondition(objRecExclusiveWayEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRecExclusiveWayBL.ReFreshCache();

if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(objRecExclusiveWayEN.RecExclusiveWayId, "SetUpdDate");
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
 /// <param name = "objRecExclusiveWayEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRecExclusiveWayEN objRecExclusiveWayEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsRecExclusiveWayBL.RecExclusiveWayDA.UpdateBySqlWithConditionTransaction(objRecExclusiveWayEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRecExclusiveWayBL.ReFreshCache();

if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(objRecExclusiveWayEN.RecExclusiveWayId, "SetUpdDate");
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
 /// <param name = "strRecExclusiveWayId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsRecExclusiveWayEN objRecExclusiveWayEN)
{
try
{
int intRecNum = clsRecExclusiveWayBL.RecExclusiveWayDA.DelRecord(objRecExclusiveWayEN.RecExclusiveWayId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRecExclusiveWayBL.ReFreshCache();

if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(objRecExclusiveWayEN.RecExclusiveWayId, "SetUpdDate");
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
 /// <param name = "objRecExclusiveWayENS">源对象</param>
 /// <param name = "objRecExclusiveWayENT">目标对象</param>
 public static void CopyTo(this clsRecExclusiveWayEN objRecExclusiveWayENS, clsRecExclusiveWayEN objRecExclusiveWayENT)
{
try
{
objRecExclusiveWayENT.RecExclusiveWayId = objRecExclusiveWayENS.RecExclusiveWayId; //记录排他方式Id
objRecExclusiveWayENT.RecExclusiveWayName = objRecExclusiveWayENS.RecExclusiveWayName; //记录排他方式名称
objRecExclusiveWayENT.Memo = objRecExclusiveWayENS.Memo; //说明
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
 /// <param name = "objRecExclusiveWayENS">源对象</param>
 /// <returns>目标对象=>clsRecExclusiveWayEN:objRecExclusiveWayENT</returns>
 public static clsRecExclusiveWayEN CopyTo(this clsRecExclusiveWayEN objRecExclusiveWayENS)
{
try
{
 clsRecExclusiveWayEN objRecExclusiveWayENT = new clsRecExclusiveWayEN()
{
RecExclusiveWayId = objRecExclusiveWayENS.RecExclusiveWayId, //记录排他方式Id
RecExclusiveWayName = objRecExclusiveWayENS.RecExclusiveWayName, //记录排他方式名称
Memo = objRecExclusiveWayENS.Memo, //说明
};
 return objRecExclusiveWayENT;
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
public static void CheckPropertyNew(this clsRecExclusiveWayEN objRecExclusiveWayEN)
{
 clsRecExclusiveWayBL.RecExclusiveWayDA.CheckPropertyNew(objRecExclusiveWayEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsRecExclusiveWayEN objRecExclusiveWayEN)
{
 clsRecExclusiveWayBL.RecExclusiveWayDA.CheckProperty4Condition(objRecExclusiveWayEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsRecExclusiveWayEN objRecExclusiveWayCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objRecExclusiveWayCond.IsUpdated(conRecExclusiveWay.RecExclusiveWayId) == true)
{
string strComparisonOpRecExclusiveWayId = objRecExclusiveWayCond.dicFldComparisonOp[conRecExclusiveWay.RecExclusiveWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRecExclusiveWay.RecExclusiveWayId, objRecExclusiveWayCond.RecExclusiveWayId, strComparisonOpRecExclusiveWayId);
}
if (objRecExclusiveWayCond.IsUpdated(conRecExclusiveWay.RecExclusiveWayName) == true)
{
string strComparisonOpRecExclusiveWayName = objRecExclusiveWayCond.dicFldComparisonOp[conRecExclusiveWay.RecExclusiveWayName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRecExclusiveWay.RecExclusiveWayName, objRecExclusiveWayCond.RecExclusiveWayName, strComparisonOpRecExclusiveWayName);
}
if (objRecExclusiveWayCond.IsUpdated(conRecExclusiveWay.Memo) == true)
{
string strComparisonOpMemo = objRecExclusiveWayCond.dicFldComparisonOp[conRecExclusiveWay.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRecExclusiveWay.Memo, objRecExclusiveWayCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_RecExclusiveWay
{
public virtual bool UpdRelaTabDate(string strRecExclusiveWayId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// RecExclusiveWay(RecExclusiveWay)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsRecExclusiveWayBL
{
public static RelatedActions_RecExclusiveWay relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "RecExclusiveWayListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "RecExclusiveWayList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsRecExclusiveWayEN> arrRecExclusiveWayObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsRecExclusiveWayDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsRecExclusiveWayDA RecExclusiveWayDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsRecExclusiveWayDA();
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
 public clsRecExclusiveWayBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsRecExclusiveWayEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsRecExclusiveWayEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = RecExclusiveWayDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = RecExclusiveWayDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = RecExclusiveWayDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_RecExclusiveWay(string strWhereCond)
{
DataTable objDT;
try
{
objDT = RecExclusiveWayDA.GetDataTable_RecExclusiveWay(strWhereCond);
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
objDT = RecExclusiveWayDA.GetDataTable(strWhereCond);
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
objDT = RecExclusiveWayDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = RecExclusiveWayDA.GetDataTable(strWhereCond, strTabName);
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
objDT = RecExclusiveWayDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = RecExclusiveWayDA.GetDataTable_Top(objTopPara);
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
objDT = RecExclusiveWayDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = RecExclusiveWayDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = RecExclusiveWayDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = RecExclusiveWayDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = RecExclusiveWayDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = RecExclusiveWayDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = RecExclusiveWayDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = RecExclusiveWayDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
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
 /// <param name = "arrRecExclusiveWayIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsRecExclusiveWayEN> GetObjLstByRecExclusiveWayIdLst(List<string> arrRecExclusiveWayIdLst)
{
List<clsRecExclusiveWayEN> arrObjLst = new List<clsRecExclusiveWayEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRecExclusiveWayIdLst, true);
 string strWhereCond = string.Format("RecExclusiveWayId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRecExclusiveWayEN.RecExclusiveWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRecExclusiveWayEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRecExclusiveWayIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsRecExclusiveWayEN> GetObjLstByRecExclusiveWayIdLstCache(List<string> arrRecExclusiveWayIdLst)
{
string strKey = string.Format("{0}", clsRecExclusiveWayEN._CurrTabName);
List<clsRecExclusiveWayEN> arrRecExclusiveWayObjLstCache = GetObjLstCache();
IEnumerable <clsRecExclusiveWayEN> arrRecExclusiveWayObjLst_Sel =
arrRecExclusiveWayObjLstCache
.Where(x => arrRecExclusiveWayIdLst.Contains(x.RecExclusiveWayId));
return arrRecExclusiveWayObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsRecExclusiveWayEN> GetObjLst(string strWhereCond)
{
List<clsRecExclusiveWayEN> arrObjLst = new List<clsRecExclusiveWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRecExclusiveWayEN.RecExclusiveWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRecExclusiveWayEN);
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
public static List<clsRecExclusiveWayEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsRecExclusiveWayEN> arrObjLst = new List<clsRecExclusiveWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRecExclusiveWayEN.RecExclusiveWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRecExclusiveWayEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objRecExclusiveWayCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsRecExclusiveWayEN> GetSubObjLstCache(clsRecExclusiveWayEN objRecExclusiveWayCond)
{
List<clsRecExclusiveWayEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsRecExclusiveWayEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRecExclusiveWay.AttributeName)
{
if (objRecExclusiveWayCond.IsUpdated(strFldName) == false) continue;
if (objRecExclusiveWayCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRecExclusiveWayCond[strFldName].ToString());
}
else
{
if (objRecExclusiveWayCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRecExclusiveWayCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRecExclusiveWayCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRecExclusiveWayCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRecExclusiveWayCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRecExclusiveWayCond[strFldName]));
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
public static List<clsRecExclusiveWayEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsRecExclusiveWayEN> arrObjLst = new List<clsRecExclusiveWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRecExclusiveWayEN.RecExclusiveWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRecExclusiveWayEN);
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
public static List<clsRecExclusiveWayEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsRecExclusiveWayEN> arrObjLst = new List<clsRecExclusiveWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRecExclusiveWayEN.RecExclusiveWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRecExclusiveWayEN);
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
List<clsRecExclusiveWayEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsRecExclusiveWayEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsRecExclusiveWayEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsRecExclusiveWayEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsRecExclusiveWayEN> arrObjLst = new List<clsRecExclusiveWayEN>(); 
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
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRecExclusiveWayEN.RecExclusiveWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRecExclusiveWayEN);
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
public static List<clsRecExclusiveWayEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsRecExclusiveWayEN> arrObjLst = new List<clsRecExclusiveWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRecExclusiveWayEN.RecExclusiveWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRecExclusiveWayEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsRecExclusiveWayEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsRecExclusiveWayEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsRecExclusiveWayEN> arrObjLst = new List<clsRecExclusiveWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRecExclusiveWayEN.RecExclusiveWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRecExclusiveWayEN);
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
public static List<clsRecExclusiveWayEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsRecExclusiveWayEN> arrObjLst = new List<clsRecExclusiveWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRecExclusiveWayEN.RecExclusiveWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRecExclusiveWayEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsRecExclusiveWayEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsRecExclusiveWayEN objRecExclusiveWayCond, string strOrderBy)
{
List<clsRecExclusiveWayEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsRecExclusiveWayEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRecExclusiveWay.AttributeName)
{
if (objRecExclusiveWayCond.IsUpdated(strFldName) == false) continue;
if (objRecExclusiveWayCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRecExclusiveWayCond[strFldName].ToString());
}
else
{
if (objRecExclusiveWayCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRecExclusiveWayCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRecExclusiveWayCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRecExclusiveWayCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRecExclusiveWayCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRecExclusiveWayCond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLstSel = arrObjLstSel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLstSel = arrObjLstSel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLstSel = arrObjLstSel.Skip(intSkip).Take(intPageSize);
return arrObjLstSel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsRecExclusiveWayEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsRecExclusiveWayEN objRecExclusiveWayCond = JsonConvert.DeserializeObject<clsRecExclusiveWayEN>(objPagerPara.whereCond);
if (objRecExclusiveWayCond.sfFldComparisonOp == null)
{
objRecExclusiveWayCond.dicFldComparisonOp = null;
}
else
{
objRecExclusiveWayCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objRecExclusiveWayCond.sfFldComparisonOp);
}
clsRecExclusiveWayBL.SetUpdFlag(objRecExclusiveWayCond);
 try
{
CheckProperty4Condition(objRecExclusiveWayCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsRecExclusiveWayBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objRecExclusiveWayCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsRecExclusiveWayEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsRecExclusiveWayEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsRecExclusiveWayEN> arrObjLst = new List<clsRecExclusiveWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRecExclusiveWayEN.RecExclusiveWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRecExclusiveWayEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsRecExclusiveWayEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsRecExclusiveWayEN> arrObjLst = new List<clsRecExclusiveWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRecExclusiveWayEN.RecExclusiveWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRecExclusiveWayEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsRecExclusiveWayEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsRecExclusiveWayEN> arrObjLst = new List<clsRecExclusiveWayEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRecExclusiveWayEN.RecExclusiveWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRecExclusiveWayEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetRecExclusiveWay(ref clsRecExclusiveWayEN objRecExclusiveWayEN)
{
bool bolResult = RecExclusiveWayDA.GetRecExclusiveWay(ref objRecExclusiveWayEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRecExclusiveWayId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRecExclusiveWayEN GetObjByRecExclusiveWayId(string strRecExclusiveWayId)
{
if (strRecExclusiveWayId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRecExclusiveWayId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRecExclusiveWayId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRecExclusiveWayId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsRecExclusiveWayEN objRecExclusiveWayEN = RecExclusiveWayDA.GetObjByRecExclusiveWayId(strRecExclusiveWayId);
return objRecExclusiveWayEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsRecExclusiveWayEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsRecExclusiveWayEN objRecExclusiveWayEN = RecExclusiveWayDA.GetFirstObj(strWhereCond);
 return objRecExclusiveWayEN;
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
public static clsRecExclusiveWayEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsRecExclusiveWayEN objRecExclusiveWayEN = RecExclusiveWayDA.GetObjByDataRow(objRow);
 return objRecExclusiveWayEN;
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
public static clsRecExclusiveWayEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsRecExclusiveWayEN objRecExclusiveWayEN = RecExclusiveWayDA.GetObjByDataRow(objRow);
 return objRecExclusiveWayEN;
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
 /// <param name = "strRecExclusiveWayId">所给的关键字</param>
 /// <param name = "lstRecExclusiveWayObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRecExclusiveWayEN GetObjByRecExclusiveWayIdFromList(string strRecExclusiveWayId, List<clsRecExclusiveWayEN> lstRecExclusiveWayObjLst)
{
foreach (clsRecExclusiveWayEN objRecExclusiveWayEN in lstRecExclusiveWayObjLst)
{
if (objRecExclusiveWayEN.RecExclusiveWayId == strRecExclusiveWayId)
{
return objRecExclusiveWayEN;
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
 string strRecExclusiveWayId;
 try
 {
 strRecExclusiveWayId = new clsRecExclusiveWayDA().GetFirstID(strWhereCond);
 return strRecExclusiveWayId;
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
 arrList = RecExclusiveWayDA.GetID(strWhereCond);
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
bool bolIsExist = RecExclusiveWayDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRecExclusiveWayId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRecExclusiveWayId)
{
if (string.IsNullOrEmpty(strRecExclusiveWayId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRecExclusiveWayId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = RecExclusiveWayDA.IsExist(strRecExclusiveWayId);
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
 bolIsExist = clsRecExclusiveWayDA.IsExistTable();
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
 bolIsExist = RecExclusiveWayDA.IsExistTable(strTabName);
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
 /// <param name = "objRecExclusiveWayEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
 if (string.IsNullOrEmpty(objRecExclusiveWayEN.RecExclusiveWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsRecExclusiveWayBL.IsExist(objRecExclusiveWayEN.RecExclusiveWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objRecExclusiveWayEN.RecExclusiveWayId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = RecExclusiveWayDA.AddNewRecordBySQL2(objRecExclusiveWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRecExclusiveWayBL.ReFreshCache();

if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(objRecExclusiveWayEN.RecExclusiveWayId, "SetUpdDate");
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
 /// <param name = "objRecExclusiveWayEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
 if (string.IsNullOrEmpty(objRecExclusiveWayEN.RecExclusiveWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsRecExclusiveWayBL.IsExist(objRecExclusiveWayEN.RecExclusiveWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objRecExclusiveWayEN.RecExclusiveWayId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = RecExclusiveWayDA.AddNewRecordBySQL2WithReturnKey(objRecExclusiveWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRecExclusiveWayBL.ReFreshCache();

if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(objRecExclusiveWayEN.RecExclusiveWayId, "SetUpdDate");
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

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,数据来源为代表实体对象的XML串
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、使用XML串来源来插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql_XML)
 /// </summary>
 /// <param name = "strRecExclusiveWayObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strRecExclusiveWayObjXml)
{
clsRecExclusiveWayEN objRecExclusiveWayEN = GetObjFromXmlStr(strRecExclusiveWayObjXml);
try
{
bool bolResult = RecExclusiveWayDA.AddNewRecordBySQL2(objRecExclusiveWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRecExclusiveWayBL.ReFreshCache();

if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(objRecExclusiveWayEN.RecExclusiveWayId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000032)添加记录出错!(使用XML), {1}.(from {0})",
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
 /// <param name = "objRecExclusiveWayEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
try
{
bool bolResult = RecExclusiveWayDA.Update(objRecExclusiveWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRecExclusiveWayBL.ReFreshCache();

if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(objRecExclusiveWayEN.RecExclusiveWayId, "SetUpdDate");
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
 /// <param name = "objRecExclusiveWayEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
 if (string.IsNullOrEmpty(objRecExclusiveWayEN.RecExclusiveWayId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = RecExclusiveWayDA.UpdateBySql2(objRecExclusiveWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRecExclusiveWayBL.ReFreshCache();

if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(objRecExclusiveWayEN.RecExclusiveWayId, "SetUpdDate");
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

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql_XML)
 /// </summary>
 /// <param name = "strRecExclusiveWayObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strRecExclusiveWayObjXml)
{
clsRecExclusiveWayEN objRecExclusiveWayEN = GetObjFromXmlStr(strRecExclusiveWayObjXml);
try
{
bool bolResult = RecExclusiveWayDA.UpdateBySql2(objRecExclusiveWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRecExclusiveWayBL.ReFreshCache();

if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(objRecExclusiveWayEN.RecExclusiveWayId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000038)修改记录(UpdateBySql_XML)出错,{1}.!(from {0})",
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
 /// <param name = "strRecExclusiveWayId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strRecExclusiveWayId)
{
try
{
 clsRecExclusiveWayEN objRecExclusiveWayEN = clsRecExclusiveWayBL.GetObjByRecExclusiveWayId(strRecExclusiveWayId);

if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(objRecExclusiveWayEN.RecExclusiveWayId, "SetUpdDate");
}
if (objRecExclusiveWayEN != null)
{
int intRecNum = RecExclusiveWayDA.DelRecord(strRecExclusiveWayId);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="strRecExclusiveWayId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strRecExclusiveWayId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
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
//删除与表:[RecExclusiveWay]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conRecExclusiveWay.RecExclusiveWayId,
//strRecExclusiveWayId);
//        clsRecExclusiveWayBL.DelRecExclusiveWaysByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRecExclusiveWayBL.DelRecord(strRecExclusiveWayId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRecExclusiveWayBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strRecExclusiveWayId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strRecExclusiveWayId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strRecExclusiveWayId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(strRecExclusiveWayId, "UpdRelaTabDate");
}
bool bolResult = RecExclusiveWayDA.DelRecord(strRecExclusiveWayId,objSqlConnection,objSqlTransaction);
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
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordBySP_S)
 /// </summary>
 /// <param name = "strRecExclusiveWayId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strRecExclusiveWayId) 
{
try
{
if (clsRecExclusiveWayBL.relatedActions != null)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(strRecExclusiveWayId, "UpdRelaTabDate");
}
bool bolResult = RecExclusiveWayDA.DelRecordBySP(strRecExclusiveWayId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000041)通过存储过程删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrRecExclusiveWayIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecExclusiveWays(List<string> arrRecExclusiveWayIdLst)
{
if (arrRecExclusiveWayIdLst.Count == 0) return 0;
try
{
if (clsRecExclusiveWayBL.relatedActions != null)
{
foreach (var strRecExclusiveWayId in arrRecExclusiveWayIdLst)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(strRecExclusiveWayId, "UpdRelaTabDate");
}
}
int intDelRecNum = RecExclusiveWayDA.DelRecExclusiveWay(arrRecExclusiveWayIdLst);
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
public static int DelRecExclusiveWaysByCond(string strWhereCond)
{
try
{
if (clsRecExclusiveWayBL.relatedActions != null)
{
List<string> arrRecExclusiveWayId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRecExclusiveWayId in arrRecExclusiveWayId)
{
clsRecExclusiveWayBL.relatedActions.UpdRelaTabDate(strRecExclusiveWayId, "UpdRelaTabDate");
}
}
int intRecNum = RecExclusiveWayDA.DelRecExclusiveWay(strWhereCond);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
/// 这里仅仅是演示函数，使用时请复制到扩展类:[RecExclusiveWay]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strRecExclusiveWayId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strRecExclusiveWayId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
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
//删除与表:[RecExclusiveWay]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRecExclusiveWayBL.DelRecord(strRecExclusiveWayId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRecExclusiveWayBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strRecExclusiveWayId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objRecExclusiveWayENS">源对象</param>
 /// <param name = "objRecExclusiveWayENT">目标对象</param>
 public static void CopyTo(clsRecExclusiveWayEN objRecExclusiveWayENS, clsRecExclusiveWayEN objRecExclusiveWayENT)
{
try
{
objRecExclusiveWayENT.RecExclusiveWayId = objRecExclusiveWayENS.RecExclusiveWayId; //记录排他方式Id
objRecExclusiveWayENT.RecExclusiveWayName = objRecExclusiveWayENS.RecExclusiveWayName; //记录排他方式名称
objRecExclusiveWayENT.Memo = objRecExclusiveWayENS.Memo; //说明
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
 /// <param name = "objRecExclusiveWayEN">源简化对象</param>
 public static void SetUpdFlag(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
try
{
objRecExclusiveWayEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objRecExclusiveWayEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conRecExclusiveWay.RecExclusiveWayId, new clsStrCompareIgnoreCase())  ==  true)
{
objRecExclusiveWayEN.RecExclusiveWayId = objRecExclusiveWayEN.RecExclusiveWayId; //记录排他方式Id
}
if (arrFldSet.Contains(conRecExclusiveWay.RecExclusiveWayName, new clsStrCompareIgnoreCase())  ==  true)
{
objRecExclusiveWayEN.RecExclusiveWayName = objRecExclusiveWayEN.RecExclusiveWayName; //记录排他方式名称
}
if (arrFldSet.Contains(conRecExclusiveWay.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objRecExclusiveWayEN.Memo = objRecExclusiveWayEN.Memo == "[null]" ? null :  objRecExclusiveWayEN.Memo; //说明
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">源简化对象</param>
 public static void AccessFldValueNull(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
try
{
if (objRecExclusiveWayEN.Memo == "[null]") objRecExclusiveWayEN.Memo = null; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckPropertyNew(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
 RecExclusiveWayDA.CheckPropertyNew(objRecExclusiveWayEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
 RecExclusiveWayDA.CheckProperty4Condition(objRecExclusiveWayEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_RecExclusiveWayId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conRecExclusiveWay.RecExclusiveWayId); 
List<clsRecExclusiveWayEN> arrObjLst = clsRecExclusiveWayBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN()
{
RecExclusiveWayId = "0",
RecExclusiveWayName = "选[RecExclusiveWay]..."
};
arrObjLst.Insert(0, objRecExclusiveWayEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conRecExclusiveWay.RecExclusiveWayId;
objComboBox.DisplayMember = conRecExclusiveWay.RecExclusiveWayName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdlRecExclusiveWayId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[RecExclusiveWay]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conRecExclusiveWay.RecExclusiveWayId); 
IEnumerable<clsRecExclusiveWayEN> arrObjLst = clsRecExclusiveWayBL.GetObjLst(strCondition);
objDDL.DataValueField = conRecExclusiveWay.RecExclusiveWayId;
objDDL.DataTextField = conRecExclusiveWay.RecExclusiveWayName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdlRecExclusiveWayIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[RecExclusiveWay]...","0");
List<clsRecExclusiveWayEN> arrRecExclusiveWayObjLst = GetAllRecExclusiveWayObjLstCache(); 
objDDL.DataValueField = conRecExclusiveWay.RecExclusiveWayId;
objDDL.DataTextField = conRecExclusiveWay.RecExclusiveWayName;
objDDL.DataSource = arrRecExclusiveWayObjLst;
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
if (clsRecExclusiveWayBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecExclusiveWayBL没有刷新缓存机制(clsRecExclusiveWayBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RecExclusiveWayId");
//if (arrRecExclusiveWayObjLstCache == null)
//{
//arrRecExclusiveWayObjLstCache = RecExclusiveWayDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRecExclusiveWayId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRecExclusiveWayEN GetObjByRecExclusiveWayIdCache(string strRecExclusiveWayId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsRecExclusiveWayEN._CurrTabName);
List<clsRecExclusiveWayEN> arrRecExclusiveWayObjLstCache = GetObjLstCache();
IEnumerable <clsRecExclusiveWayEN> arrRecExclusiveWayObjLst_Sel =
arrRecExclusiveWayObjLstCache
.Where(x=> x.RecExclusiveWayId == strRecExclusiveWayId 
);
if (arrRecExclusiveWayObjLst_Sel.Count() == 0)
{
   clsRecExclusiveWayEN obj = clsRecExclusiveWayBL.GetObjByRecExclusiveWayId(strRecExclusiveWayId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrRecExclusiveWayObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRecExclusiveWayId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRecExclusiveWayNameByRecExclusiveWayIdCache(string strRecExclusiveWayId)
{
if (string.IsNullOrEmpty(strRecExclusiveWayId) == true) return "";
//获取缓存中的对象列表
clsRecExclusiveWayEN objRecExclusiveWay = GetObjByRecExclusiveWayIdCache(strRecExclusiveWayId);
if (objRecExclusiveWay == null) return "";
return objRecExclusiveWay.RecExclusiveWayName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRecExclusiveWayId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRecExclusiveWayIdCache(string strRecExclusiveWayId)
{
if (string.IsNullOrEmpty(strRecExclusiveWayId) == true) return "";
//获取缓存中的对象列表
clsRecExclusiveWayEN objRecExclusiveWay = GetObjByRecExclusiveWayIdCache(strRecExclusiveWayId);
if (objRecExclusiveWay == null) return "";
return objRecExclusiveWay.RecExclusiveWayName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRecExclusiveWayEN> GetAllRecExclusiveWayObjLstCache()
{
//获取缓存中的对象列表
List<clsRecExclusiveWayEN> arrRecExclusiveWayObjLstCache = GetObjLstCache(); 
return arrRecExclusiveWayObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRecExclusiveWayEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsRecExclusiveWayEN._CurrTabName);
List<clsRecExclusiveWayEN> arrRecExclusiveWayObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrRecExclusiveWayObjLstCache;
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
string strKey = string.Format("{0}", clsRecExclusiveWayEN._CurrTabName);
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
if (clsRecExclusiveWayBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsRecExclusiveWayEN._CurrTabName);
CacheHelper.Remove(strKey);
clsRecExclusiveWayBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstRecExclusiveWayObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsRecExclusiveWayEN> lstRecExclusiveWayObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstRecExclusiveWayObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstRecExclusiveWayObjLst">[clsRecExclusiveWayEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsRecExclusiveWayEN> lstRecExclusiveWayObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsRecExclusiveWayBL.listXmlNode);
writer.WriteStartElement(clsRecExclusiveWayBL.itemsXmlNode);
foreach (clsRecExclusiveWayEN objRecExclusiveWayEN in lstRecExclusiveWayObjLst)
{
clsRecExclusiveWayBL.SerializeXML(writer, objRecExclusiveWayEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objRecExclusiveWayEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsRecExclusiveWayEN objRecExclusiveWayEN)
{
writer.WriteStartElement(clsRecExclusiveWayBL.itemXmlNode);
 
if (objRecExclusiveWayEN.RecExclusiveWayId != null)
{
writer.WriteElementString(conRecExclusiveWay.RecExclusiveWayId, objRecExclusiveWayEN.RecExclusiveWayId.ToString(CultureInfo.InvariantCulture));
}
 
if (objRecExclusiveWayEN.RecExclusiveWayName != null)
{
writer.WriteElementString(conRecExclusiveWay.RecExclusiveWayName, objRecExclusiveWayEN.RecExclusiveWayName.ToString(CultureInfo.InvariantCulture));
}
 
if (objRecExclusiveWayEN.Memo != null)
{
writer.WriteElementString(conRecExclusiveWay.Memo, objRecExclusiveWayEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsRecExclusiveWayEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
reader.Read();
while (!(reader.Name == clsRecExclusiveWayBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conRecExclusiveWay.RecExclusiveWayId))
{
objRecExclusiveWayEN.RecExclusiveWayId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conRecExclusiveWay.RecExclusiveWayName))
{
objRecExclusiveWayEN.RecExclusiveWayName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conRecExclusiveWay.Memo))
{
objRecExclusiveWayEN.Memo = reader.ReadElementContentAsString();
}
}
return objRecExclusiveWayEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strRecExclusiveWayObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsRecExclusiveWayEN GetObjFromXmlStr(string strRecExclusiveWayObjXmlStr)
{
clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strRecExclusiveWayObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsRecExclusiveWayBL.itemXmlNode))
{
objRecExclusiveWayEN = GetObjFromXml(reader);
return objRecExclusiveWayEN;
}
}
return objRecExclusiveWayEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objRecExclusiveWayEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strRecExclusiveWayId)
{
if (strInFldName != conRecExclusiveWay.RecExclusiveWayId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conRecExclusiveWay.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conRecExclusiveWay.AttributeName));
throw new Exception(strMsg);
}
var objRecExclusiveWay = clsRecExclusiveWayBL.GetObjByRecExclusiveWayIdCache(strRecExclusiveWayId);
if (objRecExclusiveWay == null) return "";
return objRecExclusiveWay[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsRecExclusiveWayEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objRecExclusiveWayEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstRecExclusiveWayObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsRecExclusiveWayEN> lstRecExclusiveWayObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstRecExclusiveWayObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsRecExclusiveWayEN objRecExclusiveWayEN in lstRecExclusiveWayObjLst)
{
string strJSON_One = SerializeObjToJSON(objRecExclusiveWayEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


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
int intRecCount = clsRecExclusiveWayDA.GetRecCount(strTabName);
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
int intRecCount = clsRecExclusiveWayDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsRecExclusiveWayDA.GetRecCount();
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
int intRecCount = clsRecExclusiveWayDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objRecExclusiveWayCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsRecExclusiveWayEN objRecExclusiveWayCond)
{
List<clsRecExclusiveWayEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsRecExclusiveWayEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRecExclusiveWay.AttributeName)
{
if (objRecExclusiveWayCond.IsUpdated(strFldName) == false) continue;
if (objRecExclusiveWayCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRecExclusiveWayCond[strFldName].ToString());
}
else
{
if (objRecExclusiveWayCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRecExclusiveWayCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRecExclusiveWayCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRecExclusiveWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRecExclusiveWayCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRecExclusiveWayCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRecExclusiveWayCond[strFldName]));
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
 List<string> arrList = clsRecExclusiveWayDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = RecExclusiveWayDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = RecExclusiveWayDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = RecExclusiveWayDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsRecExclusiveWayDA.SetFldValue(clsRecExclusiveWayEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = RecExclusiveWayDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsRecExclusiveWayDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsRecExclusiveWayDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsRecExclusiveWayDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[RecExclusiveWay] "); 
 strCreateTabCode.Append(" ( "); 
 // /**记录排他方式Id*/ 
 strCreateTabCode.Append(" RecExclusiveWayId char(4) primary key, "); 
 // /**记录排他方式名称*/ 
 strCreateTabCode.Append(" RecExclusiveWayName varchar(30) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// RecExclusiveWay(RecExclusiveWay)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4RecExclusiveWay : clsCommFun4BL
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
clsRecExclusiveWayBL.ReFreshThisCache();
}
}

}