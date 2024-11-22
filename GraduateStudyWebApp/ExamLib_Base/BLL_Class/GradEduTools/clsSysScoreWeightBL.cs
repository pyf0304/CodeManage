﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysScoreWeightBL
 表名:SysScoreWeight(01120629)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
public static class  clsSysScoreWeightBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strScoreWeightId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysScoreWeightEN GetObj(this K_ScoreWeightId_SysScoreWeight myKey)
{
clsSysScoreWeightEN objSysScoreWeightEN = clsSysScoreWeightBL.SysScoreWeightDA.GetObjByScoreWeightId(myKey.Value);
return objSysScoreWeightEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSysScoreWeightEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSysScoreWeightEN objSysScoreWeightEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSysScoreWeightEN.ScoreWeightId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysScoreWeightBL.IsExist(objSysScoreWeightEN.ScoreWeightId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysScoreWeightEN.ScoreWeightId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsSysScoreWeightBL.SysScoreWeightDA.AddNewRecordBySQL2(objSysScoreWeightEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreWeightBL.ReFreshCache();

if (clsSysScoreWeightBL.relatedActions != null)
{
clsSysScoreWeightBL.relatedActions.UpdRelaTabDate(objSysScoreWeightEN.ScoreWeightId, "SetUpdDate");
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
public static bool AddRecordEx(this clsSysScoreWeightEN objSysScoreWeightEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsSysScoreWeightBL.IsExist(objSysScoreWeightEN.ScoreWeightId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objSysScoreWeightEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objSysScoreWeightEN.AddNewRecord();
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
 /// <param name = "objSysScoreWeightEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSysScoreWeightEN objSysScoreWeightEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSysScoreWeightEN.ScoreWeightId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysScoreWeightBL.IsExist(objSysScoreWeightEN.ScoreWeightId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysScoreWeightEN.ScoreWeightId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsSysScoreWeightBL.SysScoreWeightDA.AddNewRecordBySQL2WithReturnKey(objSysScoreWeightEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreWeightBL.ReFreshCache();

if (clsSysScoreWeightBL.relatedActions != null)
{
clsSysScoreWeightBL.relatedActions.UpdRelaTabDate(objSysScoreWeightEN.ScoreWeightId, "SetUpdDate");
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
 /// <param name = "objSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreWeightEN SetScoreWeightId(this clsSysScoreWeightEN objSysScoreWeightEN, string strScoreWeightId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreWeightId, 1, conSysScoreWeight.ScoreWeightId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreWeightId, 1, conSysScoreWeight.ScoreWeightId);
}
objSysScoreWeightEN.ScoreWeightId = strScoreWeightId; //分数权重Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreWeightEN.dicFldComparisonOp.ContainsKey(conSysScoreWeight.ScoreWeightId) == false)
{
objSysScoreWeightEN.dicFldComparisonOp.Add(conSysScoreWeight.ScoreWeightId, strComparisonOp);
}
else
{
objSysScoreWeightEN.dicFldComparisonOp[conSysScoreWeight.ScoreWeightId] = strComparisonOp;
}
}
return objSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreWeightEN SetMemo(this clsSysScoreWeightEN objSysScoreWeightEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSysScoreWeight.Memo);
}
objSysScoreWeightEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreWeightEN.dicFldComparisonOp.ContainsKey(conSysScoreWeight.Memo) == false)
{
objSysScoreWeightEN.dicFldComparisonOp.Add(conSysScoreWeight.Memo, strComparisonOp);
}
else
{
objSysScoreWeightEN.dicFldComparisonOp[conSysScoreWeight.Memo] = strComparisonOp;
}
}
return objSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreWeightEN SetIsPublic(this clsSysScoreWeightEN objSysScoreWeightEN, bool bolIsPublic, string strComparisonOp="")
	{
objSysScoreWeightEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreWeightEN.dicFldComparisonOp.ContainsKey(conSysScoreWeight.IsPublic) == false)
{
objSysScoreWeightEN.dicFldComparisonOp.Add(conSysScoreWeight.IsPublic, strComparisonOp);
}
else
{
objSysScoreWeightEN.dicFldComparisonOp[conSysScoreWeight.IsPublic] = strComparisonOp;
}
}
return objSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreWeightEN SetScoreTypeId(this clsSysScoreWeightEN objSysScoreWeightEN, string strScoreTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreTypeId, 4, conSysScoreWeight.ScoreTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreTypeId, 4, conSysScoreWeight.ScoreTypeId);
}
objSysScoreWeightEN.ScoreTypeId = strScoreTypeId; //分数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreWeightEN.dicFldComparisonOp.ContainsKey(conSysScoreWeight.ScoreTypeId) == false)
{
objSysScoreWeightEN.dicFldComparisonOp.Add(conSysScoreWeight.ScoreTypeId, strComparisonOp);
}
else
{
objSysScoreWeightEN.dicFldComparisonOp[conSysScoreWeight.ScoreTypeId] = strComparisonOp;
}
}
return objSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreWeightEN SetScoreWeightValue(this clsSysScoreWeightEN objSysScoreWeightEN, string strScoreWeightValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strScoreWeightValue, conSysScoreWeight.ScoreWeightValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreWeightValue, 20, conSysScoreWeight.ScoreWeightValue);
}
objSysScoreWeightEN.ScoreWeightValue = strScoreWeightValue; //分数权重值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreWeightEN.dicFldComparisonOp.ContainsKey(conSysScoreWeight.ScoreWeightValue) == false)
{
objSysScoreWeightEN.dicFldComparisonOp.Add(conSysScoreWeight.ScoreWeightValue, strComparisonOp);
}
else
{
objSysScoreWeightEN.dicFldComparisonOp[conSysScoreWeight.ScoreWeightValue] = strComparisonOp;
}
}
return objSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreWeightEN SetUpdDate(this clsSysScoreWeightEN objSysScoreWeightEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSysScoreWeight.UpdDate);
}
objSysScoreWeightEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreWeightEN.dicFldComparisonOp.ContainsKey(conSysScoreWeight.UpdDate) == false)
{
objSysScoreWeightEN.dicFldComparisonOp.Add(conSysScoreWeight.UpdDate, strComparisonOp);
}
else
{
objSysScoreWeightEN.dicFldComparisonOp[conSysScoreWeight.UpdDate] = strComparisonOp;
}
}
return objSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreWeightEN SetUpdUser(this clsSysScoreWeightEN objSysScoreWeightEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conSysScoreWeight.UpdUser);
}
objSysScoreWeightEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreWeightEN.dicFldComparisonOp.ContainsKey(conSysScoreWeight.UpdUser) == false)
{
objSysScoreWeightEN.dicFldComparisonOp.Add(conSysScoreWeight.UpdUser, strComparisonOp);
}
else
{
objSysScoreWeightEN.dicFldComparisonOp[conSysScoreWeight.UpdUser] = strComparisonOp;
}
}
return objSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreWeightEN SetIdCurrEduCls(this clsSysScoreWeightEN objSysScoreWeightEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conSysScoreWeight.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conSysScoreWeight.IdCurrEduCls);
}
objSysScoreWeightEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreWeightEN.dicFldComparisonOp.ContainsKey(conSysScoreWeight.IdCurrEduCls) == false)
{
objSysScoreWeightEN.dicFldComparisonOp.Add(conSysScoreWeight.IdCurrEduCls, strComparisonOp);
}
else
{
objSysScoreWeightEN.dicFldComparisonOp[conSysScoreWeight.IdCurrEduCls] = strComparisonOp;
}
}
return objSysScoreWeightEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSysScoreWeightEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSysScoreWeightEN objSysScoreWeightEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSysScoreWeightEN.CheckPropertyNew();
clsSysScoreWeightEN objSysScoreWeightCond = new clsSysScoreWeightEN();
string strCondition = objSysScoreWeightCond
.SetScoreWeightId(objSysScoreWeightEN.ScoreWeightId, "=")
.GetCombineCondition();
objSysScoreWeightEN._IsCheckProperty = true;
bool bolIsExist = clsSysScoreWeightBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSysScoreWeightEN.Update();
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
 /// <param name = "objSysScoreWeightEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysScoreWeightEN objSysScoreWeightEN)
{
 if (string.IsNullOrEmpty(objSysScoreWeightEN.ScoreWeightId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysScoreWeightBL.SysScoreWeightDA.UpdateBySql2(objSysScoreWeightEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreWeightBL.ReFreshCache();

if (clsSysScoreWeightBL.relatedActions != null)
{
clsSysScoreWeightBL.relatedActions.UpdRelaTabDate(objSysScoreWeightEN.ScoreWeightId, "SetUpdDate");
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
 /// <param name = "objSysScoreWeightEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysScoreWeightEN objSysScoreWeightEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSysScoreWeightEN.ScoreWeightId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysScoreWeightBL.SysScoreWeightDA.UpdateBySql2(objSysScoreWeightEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreWeightBL.ReFreshCache();

if (clsSysScoreWeightBL.relatedActions != null)
{
clsSysScoreWeightBL.relatedActions.UpdRelaTabDate(objSysScoreWeightEN.ScoreWeightId, "SetUpdDate");
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
 /// <param name = "objSysScoreWeightEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysScoreWeightEN objSysScoreWeightEN, string strWhereCond)
{
try
{
bool bolResult = clsSysScoreWeightBL.SysScoreWeightDA.UpdateBySqlWithCondition(objSysScoreWeightEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreWeightBL.ReFreshCache();

if (clsSysScoreWeightBL.relatedActions != null)
{
clsSysScoreWeightBL.relatedActions.UpdRelaTabDate(objSysScoreWeightEN.ScoreWeightId, "SetUpdDate");
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
 /// <param name = "objSysScoreWeightEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysScoreWeightEN objSysScoreWeightEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSysScoreWeightBL.SysScoreWeightDA.UpdateBySqlWithConditionTransaction(objSysScoreWeightEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreWeightBL.ReFreshCache();

if (clsSysScoreWeightBL.relatedActions != null)
{
clsSysScoreWeightBL.relatedActions.UpdRelaTabDate(objSysScoreWeightEN.ScoreWeightId, "SetUpdDate");
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
 /// <param name = "strScoreWeightId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSysScoreWeightEN objSysScoreWeightEN)
{
try
{
int intRecNum = clsSysScoreWeightBL.SysScoreWeightDA.DelRecord(objSysScoreWeightEN.ScoreWeightId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreWeightBL.ReFreshCache();

if (clsSysScoreWeightBL.relatedActions != null)
{
clsSysScoreWeightBL.relatedActions.UpdRelaTabDate(objSysScoreWeightEN.ScoreWeightId, "SetUpdDate");
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
 /// <param name = "objSysScoreWeightENS">源对象</param>
 /// <param name = "objSysScoreWeightENT">目标对象</param>
 public static void CopyTo(this clsSysScoreWeightEN objSysScoreWeightENS, clsSysScoreWeightEN objSysScoreWeightENT)
{
try
{
objSysScoreWeightENT.ScoreWeightId = objSysScoreWeightENS.ScoreWeightId; //分数权重Id
objSysScoreWeightENT.Memo = objSysScoreWeightENS.Memo; //备注
objSysScoreWeightENT.IsPublic = objSysScoreWeightENS.IsPublic; //是否公开
objSysScoreWeightENT.ScoreTypeId = objSysScoreWeightENS.ScoreTypeId; //分数类型Id
objSysScoreWeightENT.ScoreWeightValue = objSysScoreWeightENS.ScoreWeightValue; //分数权重值
objSysScoreWeightENT.UpdDate = objSysScoreWeightENS.UpdDate; //修改日期
objSysScoreWeightENT.UpdUser = objSysScoreWeightENS.UpdUser; //修改人
objSysScoreWeightENT.IdCurrEduCls = objSysScoreWeightENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objSysScoreWeightENS">源对象</param>
 /// <returns>目标对象=>clsSysScoreWeightEN:objSysScoreWeightENT</returns>
 public static clsSysScoreWeightEN CopyTo(this clsSysScoreWeightEN objSysScoreWeightENS)
{
try
{
 clsSysScoreWeightEN objSysScoreWeightENT = new clsSysScoreWeightEN()
{
ScoreWeightId = objSysScoreWeightENS.ScoreWeightId, //分数权重Id
Memo = objSysScoreWeightENS.Memo, //备注
IsPublic = objSysScoreWeightENS.IsPublic, //是否公开
ScoreTypeId = objSysScoreWeightENS.ScoreTypeId, //分数类型Id
ScoreWeightValue = objSysScoreWeightENS.ScoreWeightValue, //分数权重值
UpdDate = objSysScoreWeightENS.UpdDate, //修改日期
UpdUser = objSysScoreWeightENS.UpdUser, //修改人
IdCurrEduCls = objSysScoreWeightENS.IdCurrEduCls, //教学班流水号
};
 return objSysScoreWeightENT;
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
public static void CheckPropertyNew(this clsSysScoreWeightEN objSysScoreWeightEN)
{
 clsSysScoreWeightBL.SysScoreWeightDA.CheckPropertyNew(objSysScoreWeightEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSysScoreWeightEN objSysScoreWeightEN)
{
 clsSysScoreWeightBL.SysScoreWeightDA.CheckProperty4Condition(objSysScoreWeightEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSysScoreWeightEN objSysScoreWeightCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSysScoreWeightCond.IsUpdated(conSysScoreWeight.ScoreWeightId) == true)
{
string strComparisonOpScoreWeightId = objSysScoreWeightCond.dicFldComparisonOp[conSysScoreWeight.ScoreWeightId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysScoreWeight.ScoreWeightId, objSysScoreWeightCond.ScoreWeightId, strComparisonOpScoreWeightId);
}
if (objSysScoreWeightCond.IsUpdated(conSysScoreWeight.Memo) == true)
{
string strComparisonOpMemo = objSysScoreWeightCond.dicFldComparisonOp[conSysScoreWeight.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysScoreWeight.Memo, objSysScoreWeightCond.Memo, strComparisonOpMemo);
}
if (objSysScoreWeightCond.IsUpdated(conSysScoreWeight.IsPublic) == true)
{
if (objSysScoreWeightCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSysScoreWeight.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSysScoreWeight.IsPublic);
}
}
if (objSysScoreWeightCond.IsUpdated(conSysScoreWeight.ScoreTypeId) == true)
{
string strComparisonOpScoreTypeId = objSysScoreWeightCond.dicFldComparisonOp[conSysScoreWeight.ScoreTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysScoreWeight.ScoreTypeId, objSysScoreWeightCond.ScoreTypeId, strComparisonOpScoreTypeId);
}
if (objSysScoreWeightCond.IsUpdated(conSysScoreWeight.ScoreWeightValue) == true)
{
string strComparisonOpScoreWeightValue = objSysScoreWeightCond.dicFldComparisonOp[conSysScoreWeight.ScoreWeightValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysScoreWeight.ScoreWeightValue, objSysScoreWeightCond.ScoreWeightValue, strComparisonOpScoreWeightValue);
}
if (objSysScoreWeightCond.IsUpdated(conSysScoreWeight.UpdDate) == true)
{
string strComparisonOpUpdDate = objSysScoreWeightCond.dicFldComparisonOp[conSysScoreWeight.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysScoreWeight.UpdDate, objSysScoreWeightCond.UpdDate, strComparisonOpUpdDate);
}
if (objSysScoreWeightCond.IsUpdated(conSysScoreWeight.UpdUser) == true)
{
string strComparisonOpUpdUser = objSysScoreWeightCond.dicFldComparisonOp[conSysScoreWeight.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysScoreWeight.UpdUser, objSysScoreWeightCond.UpdUser, strComparisonOpUpdUser);
}
if (objSysScoreWeightCond.IsUpdated(conSysScoreWeight.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objSysScoreWeightCond.dicFldComparisonOp[conSysScoreWeight.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysScoreWeight.IdCurrEduCls, objSysScoreWeightCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SysScoreWeight
{
public virtual bool UpdRelaTabDate(string strScoreWeightId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 系统分数权重表(SysScoreWeight)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSysScoreWeightBL
{
public static RelatedActions_SysScoreWeight relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSysScoreWeightDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSysScoreWeightDA SysScoreWeightDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSysScoreWeightDA();
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
 public clsSysScoreWeightBL()
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
if (string.IsNullOrEmpty(clsSysScoreWeightEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysScoreWeightEN._ConnectString);
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
public static DataTable GetDataTable_SysScoreWeight(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SysScoreWeightDA.GetDataTable_SysScoreWeight(strWhereCond);
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
objDT = SysScoreWeightDA.GetDataTable(strWhereCond);
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
objDT = SysScoreWeightDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SysScoreWeightDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SysScoreWeightDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SysScoreWeightDA.GetDataTable_Top(objTopPara);
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
objDT = SysScoreWeightDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SysScoreWeightDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SysScoreWeightDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrScoreWeightIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSysScoreWeightEN> GetObjLstByScoreWeightIdLst(List<string> arrScoreWeightIdLst)
{
List<clsSysScoreWeightEN> arrObjLst = new List<clsSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrScoreWeightIdLst, true);
 string strWhereCond = string.Format("ScoreWeightId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreWeightEN objSysScoreWeightEN = new clsSysScoreWeightEN();
try
{
objSysScoreWeightEN.ScoreWeightId = objRow[conSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objSysScoreWeightEN.Memo = objRow[conSysScoreWeight.Memo] == DBNull.Value ? null : objRow[conSysScoreWeight.Memo].ToString().Trim(); //备注
objSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objSysScoreWeightEN.ScoreTypeId = objRow[conSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreWeightEN.ScoreWeightValue = objRow[conSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objSysScoreWeightEN.UpdDate = objRow[conSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objSysScoreWeightEN.UpdUser = objRow[conSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objSysScoreWeightEN.IdCurrEduCls = objRow[conSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreWeightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrScoreWeightIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSysScoreWeightEN> GetObjLstByScoreWeightIdLstCache(List<string> arrScoreWeightIdLst)
{
string strKey = string.Format("{0}", clsSysScoreWeightEN._CurrTabName);
List<clsSysScoreWeightEN> arrSysScoreWeightObjLstCache = GetObjLstCache();
IEnumerable <clsSysScoreWeightEN> arrSysScoreWeightObjLst_Sel =
arrSysScoreWeightObjLstCache
.Where(x => arrScoreWeightIdLst.Contains(x.ScoreWeightId));
return arrSysScoreWeightObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysScoreWeightEN> GetObjLst(string strWhereCond)
{
List<clsSysScoreWeightEN> arrObjLst = new List<clsSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreWeightEN objSysScoreWeightEN = new clsSysScoreWeightEN();
try
{
objSysScoreWeightEN.ScoreWeightId = objRow[conSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objSysScoreWeightEN.Memo = objRow[conSysScoreWeight.Memo] == DBNull.Value ? null : objRow[conSysScoreWeight.Memo].ToString().Trim(); //备注
objSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objSysScoreWeightEN.ScoreTypeId = objRow[conSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreWeightEN.ScoreWeightValue = objRow[conSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objSysScoreWeightEN.UpdDate = objRow[conSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objSysScoreWeightEN.UpdUser = objRow[conSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objSysScoreWeightEN.IdCurrEduCls = objRow[conSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreWeightEN);
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
public static List<clsSysScoreWeightEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSysScoreWeightEN> arrObjLst = new List<clsSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreWeightEN objSysScoreWeightEN = new clsSysScoreWeightEN();
try
{
objSysScoreWeightEN.ScoreWeightId = objRow[conSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objSysScoreWeightEN.Memo = objRow[conSysScoreWeight.Memo] == DBNull.Value ? null : objRow[conSysScoreWeight.Memo].ToString().Trim(); //备注
objSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objSysScoreWeightEN.ScoreTypeId = objRow[conSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreWeightEN.ScoreWeightValue = objRow[conSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objSysScoreWeightEN.UpdDate = objRow[conSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objSysScoreWeightEN.UpdUser = objRow[conSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objSysScoreWeightEN.IdCurrEduCls = objRow[conSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreWeightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSysScoreWeightCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSysScoreWeightEN> GetSubObjLstCache(clsSysScoreWeightEN objSysScoreWeightCond)
{
List<clsSysScoreWeightEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysScoreWeightEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysScoreWeight.AttributeName)
{
if (objSysScoreWeightCond.IsUpdated(strFldName) == false) continue;
if (objSysScoreWeightCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysScoreWeightCond[strFldName].ToString());
}
else
{
if (objSysScoreWeightCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysScoreWeightCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysScoreWeightCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysScoreWeightCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysScoreWeightCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysScoreWeightCond[strFldName]));
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
public static List<clsSysScoreWeightEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSysScoreWeightEN> arrObjLst = new List<clsSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreWeightEN objSysScoreWeightEN = new clsSysScoreWeightEN();
try
{
objSysScoreWeightEN.ScoreWeightId = objRow[conSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objSysScoreWeightEN.Memo = objRow[conSysScoreWeight.Memo] == DBNull.Value ? null : objRow[conSysScoreWeight.Memo].ToString().Trim(); //备注
objSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objSysScoreWeightEN.ScoreTypeId = objRow[conSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreWeightEN.ScoreWeightValue = objRow[conSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objSysScoreWeightEN.UpdDate = objRow[conSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objSysScoreWeightEN.UpdUser = objRow[conSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objSysScoreWeightEN.IdCurrEduCls = objRow[conSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreWeightEN);
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
public static List<clsSysScoreWeightEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSysScoreWeightEN> arrObjLst = new List<clsSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreWeightEN objSysScoreWeightEN = new clsSysScoreWeightEN();
try
{
objSysScoreWeightEN.ScoreWeightId = objRow[conSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objSysScoreWeightEN.Memo = objRow[conSysScoreWeight.Memo] == DBNull.Value ? null : objRow[conSysScoreWeight.Memo].ToString().Trim(); //备注
objSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objSysScoreWeightEN.ScoreTypeId = objRow[conSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreWeightEN.ScoreWeightValue = objRow[conSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objSysScoreWeightEN.UpdDate = objRow[conSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objSysScoreWeightEN.UpdUser = objRow[conSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objSysScoreWeightEN.IdCurrEduCls = objRow[conSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreWeightEN);
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
List<clsSysScoreWeightEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSysScoreWeightEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysScoreWeightEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSysScoreWeightEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSysScoreWeightEN> arrObjLst = new List<clsSysScoreWeightEN>(); 
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
	clsSysScoreWeightEN objSysScoreWeightEN = new clsSysScoreWeightEN();
try
{
objSysScoreWeightEN.ScoreWeightId = objRow[conSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objSysScoreWeightEN.Memo = objRow[conSysScoreWeight.Memo] == DBNull.Value ? null : objRow[conSysScoreWeight.Memo].ToString().Trim(); //备注
objSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objSysScoreWeightEN.ScoreTypeId = objRow[conSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreWeightEN.ScoreWeightValue = objRow[conSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objSysScoreWeightEN.UpdDate = objRow[conSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objSysScoreWeightEN.UpdUser = objRow[conSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objSysScoreWeightEN.IdCurrEduCls = objRow[conSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreWeightEN);
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
public static List<clsSysScoreWeightEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSysScoreWeightEN> arrObjLst = new List<clsSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreWeightEN objSysScoreWeightEN = new clsSysScoreWeightEN();
try
{
objSysScoreWeightEN.ScoreWeightId = objRow[conSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objSysScoreWeightEN.Memo = objRow[conSysScoreWeight.Memo] == DBNull.Value ? null : objRow[conSysScoreWeight.Memo].ToString().Trim(); //备注
objSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objSysScoreWeightEN.ScoreTypeId = objRow[conSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreWeightEN.ScoreWeightValue = objRow[conSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objSysScoreWeightEN.UpdDate = objRow[conSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objSysScoreWeightEN.UpdUser = objRow[conSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objSysScoreWeightEN.IdCurrEduCls = objRow[conSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreWeightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSysScoreWeightEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSysScoreWeightEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSysScoreWeightEN> arrObjLst = new List<clsSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreWeightEN objSysScoreWeightEN = new clsSysScoreWeightEN();
try
{
objSysScoreWeightEN.ScoreWeightId = objRow[conSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objSysScoreWeightEN.Memo = objRow[conSysScoreWeight.Memo] == DBNull.Value ? null : objRow[conSysScoreWeight.Memo].ToString().Trim(); //备注
objSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objSysScoreWeightEN.ScoreTypeId = objRow[conSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreWeightEN.ScoreWeightValue = objRow[conSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objSysScoreWeightEN.UpdDate = objRow[conSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objSysScoreWeightEN.UpdUser = objRow[conSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objSysScoreWeightEN.IdCurrEduCls = objRow[conSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreWeightEN);
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
public static List<clsSysScoreWeightEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSysScoreWeightEN> arrObjLst = new List<clsSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreWeightEN objSysScoreWeightEN = new clsSysScoreWeightEN();
try
{
objSysScoreWeightEN.ScoreWeightId = objRow[conSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objSysScoreWeightEN.Memo = objRow[conSysScoreWeight.Memo] == DBNull.Value ? null : objRow[conSysScoreWeight.Memo].ToString().Trim(); //备注
objSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objSysScoreWeightEN.ScoreTypeId = objRow[conSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreWeightEN.ScoreWeightValue = objRow[conSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objSysScoreWeightEN.UpdDate = objRow[conSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objSysScoreWeightEN.UpdUser = objRow[conSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objSysScoreWeightEN.IdCurrEduCls = objRow[conSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreWeightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysScoreWeightEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSysScoreWeightEN> arrObjLst = new List<clsSysScoreWeightEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreWeightEN objSysScoreWeightEN = new clsSysScoreWeightEN();
try
{
objSysScoreWeightEN.ScoreWeightId = objRow[conSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objSysScoreWeightEN.Memo = objRow[conSysScoreWeight.Memo] == DBNull.Value ? null : objRow[conSysScoreWeight.Memo].ToString().Trim(); //备注
objSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objSysScoreWeightEN.ScoreTypeId = objRow[conSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreWeightEN.ScoreWeightValue = objRow[conSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objSysScoreWeightEN.UpdDate = objRow[conSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objSysScoreWeightEN.UpdUser = objRow[conSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[conSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objSysScoreWeightEN.IdCurrEduCls = objRow[conSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreWeightEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSysScoreWeightEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSysScoreWeight(ref clsSysScoreWeightEN objSysScoreWeightEN)
{
bool bolResult = SysScoreWeightDA.GetSysScoreWeight(ref objSysScoreWeightEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strScoreWeightId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysScoreWeightEN GetObjByScoreWeightId(string strScoreWeightId)
{
if (strScoreWeightId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strScoreWeightId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strScoreWeightId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strScoreWeightId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSysScoreWeightEN objSysScoreWeightEN = SysScoreWeightDA.GetObjByScoreWeightId(strScoreWeightId);
return objSysScoreWeightEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSysScoreWeightEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSysScoreWeightEN objSysScoreWeightEN = SysScoreWeightDA.GetFirstObj(strWhereCond);
 return objSysScoreWeightEN;
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
public static clsSysScoreWeightEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSysScoreWeightEN objSysScoreWeightEN = SysScoreWeightDA.GetObjByDataRow(objRow);
 return objSysScoreWeightEN;
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
public static clsSysScoreWeightEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSysScoreWeightEN objSysScoreWeightEN = SysScoreWeightDA.GetObjByDataRow(objRow);
 return objSysScoreWeightEN;
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
 /// <param name = "strScoreWeightId">所给的关键字</param>
 /// <param name = "lstSysScoreWeightObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysScoreWeightEN GetObjByScoreWeightIdFromList(string strScoreWeightId, List<clsSysScoreWeightEN> lstSysScoreWeightObjLst)
{
foreach (clsSysScoreWeightEN objSysScoreWeightEN in lstSysScoreWeightObjLst)
{
if (objSysScoreWeightEN.ScoreWeightId == strScoreWeightId)
{
return objSysScoreWeightEN;
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
 string strScoreWeightId;
 try
 {
 strScoreWeightId = new clsSysScoreWeightDA().GetFirstID(strWhereCond);
 return strScoreWeightId;
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
 arrList = SysScoreWeightDA.GetID(strWhereCond);
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
bool bolIsExist = SysScoreWeightDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strScoreWeightId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strScoreWeightId)
{
if (string.IsNullOrEmpty(strScoreWeightId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strScoreWeightId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SysScoreWeightDA.IsExist(strScoreWeightId);
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
 bolIsExist = clsSysScoreWeightDA.IsExistTable();
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
 bolIsExist = SysScoreWeightDA.IsExistTable(strTabName);
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
 /// <param name = "objSysScoreWeightEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSysScoreWeightEN objSysScoreWeightEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSysScoreWeightEN.ScoreWeightId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysScoreWeightBL.IsExist(objSysScoreWeightEN.ScoreWeightId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysScoreWeightEN.ScoreWeightId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = SysScoreWeightDA.AddNewRecordBySQL2(objSysScoreWeightEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreWeightBL.ReFreshCache();

if (clsSysScoreWeightBL.relatedActions != null)
{
clsSysScoreWeightBL.relatedActions.UpdRelaTabDate(objSysScoreWeightEN.ScoreWeightId, "SetUpdDate");
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
 /// <param name = "objSysScoreWeightEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSysScoreWeightEN objSysScoreWeightEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSysScoreWeightEN.ScoreWeightId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysScoreWeightBL.IsExist(objSysScoreWeightEN.ScoreWeightId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysScoreWeightEN.ScoreWeightId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = SysScoreWeightDA.AddNewRecordBySQL2WithReturnKey(objSysScoreWeightEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreWeightBL.ReFreshCache();

if (clsSysScoreWeightBL.relatedActions != null)
{
clsSysScoreWeightBL.relatedActions.UpdRelaTabDate(objSysScoreWeightEN.ScoreWeightId, "SetUpdDate");
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
 /// <param name = "objSysScoreWeightEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSysScoreWeightEN objSysScoreWeightEN)
{
try
{
bool bolResult = SysScoreWeightDA.Update(objSysScoreWeightEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreWeightBL.ReFreshCache();

if (clsSysScoreWeightBL.relatedActions != null)
{
clsSysScoreWeightBL.relatedActions.UpdRelaTabDate(objSysScoreWeightEN.ScoreWeightId, "SetUpdDate");
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
 /// <param name = "objSysScoreWeightEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSysScoreWeightEN objSysScoreWeightEN)
{
 if (string.IsNullOrEmpty(objSysScoreWeightEN.ScoreWeightId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SysScoreWeightDA.UpdateBySql2(objSysScoreWeightEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreWeightBL.ReFreshCache();

if (clsSysScoreWeightBL.relatedActions != null)
{
clsSysScoreWeightBL.relatedActions.UpdRelaTabDate(objSysScoreWeightEN.ScoreWeightId, "SetUpdDate");
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
 /// <param name = "strScoreWeightId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strScoreWeightId)
{
try
{
 clsSysScoreWeightEN objSysScoreWeightEN = clsSysScoreWeightBL.GetObjByScoreWeightId(strScoreWeightId);

if (clsSysScoreWeightBL.relatedActions != null)
{
clsSysScoreWeightBL.relatedActions.UpdRelaTabDate(objSysScoreWeightEN.ScoreWeightId, "SetUpdDate");
}
if (objSysScoreWeightEN != null)
{
int intRecNum = SysScoreWeightDA.DelRecord(strScoreWeightId);
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
/// <param name="strScoreWeightId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strScoreWeightId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysScoreWeightDA.GetSpecSQLObj();
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
//删除与表:[SysScoreWeight]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSysScoreWeight.ScoreWeightId,
//strScoreWeightId);
//        clsSysScoreWeightBL.DelSysScoreWeightsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysScoreWeightBL.DelRecord(strScoreWeightId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysScoreWeightBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strScoreWeightId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strScoreWeightId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strScoreWeightId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSysScoreWeightBL.relatedActions != null)
{
clsSysScoreWeightBL.relatedActions.UpdRelaTabDate(strScoreWeightId, "UpdRelaTabDate");
}
bool bolResult = SysScoreWeightDA.DelRecord(strScoreWeightId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrScoreWeightIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSysScoreWeights(List<string> arrScoreWeightIdLst)
{
if (arrScoreWeightIdLst.Count == 0) return 0;
try
{
if (clsSysScoreWeightBL.relatedActions != null)
{
foreach (var strScoreWeightId in arrScoreWeightIdLst)
{
clsSysScoreWeightBL.relatedActions.UpdRelaTabDate(strScoreWeightId, "UpdRelaTabDate");
}
}
int intDelRecNum = SysScoreWeightDA.DelSysScoreWeight(arrScoreWeightIdLst);
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
public static int DelSysScoreWeightsByCond(string strWhereCond)
{
try
{
if (clsSysScoreWeightBL.relatedActions != null)
{
List<string> arrScoreWeightId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strScoreWeightId in arrScoreWeightId)
{
clsSysScoreWeightBL.relatedActions.UpdRelaTabDate(strScoreWeightId, "UpdRelaTabDate");
}
}
int intRecNum = SysScoreWeightDA.DelSysScoreWeight(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SysScoreWeight]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strScoreWeightId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strScoreWeightId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysScoreWeightDA.GetSpecSQLObj();
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
//删除与表:[SysScoreWeight]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysScoreWeightBL.DelRecord(strScoreWeightId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysScoreWeightBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strScoreWeightId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSysScoreWeightENS">源对象</param>
 /// <param name = "objSysScoreWeightENT">目标对象</param>
 public static void CopyTo(clsSysScoreWeightEN objSysScoreWeightENS, clsSysScoreWeightEN objSysScoreWeightENT)
{
try
{
objSysScoreWeightENT.ScoreWeightId = objSysScoreWeightENS.ScoreWeightId; //分数权重Id
objSysScoreWeightENT.Memo = objSysScoreWeightENS.Memo; //备注
objSysScoreWeightENT.IsPublic = objSysScoreWeightENS.IsPublic; //是否公开
objSysScoreWeightENT.ScoreTypeId = objSysScoreWeightENS.ScoreTypeId; //分数类型Id
objSysScoreWeightENT.ScoreWeightValue = objSysScoreWeightENS.ScoreWeightValue; //分数权重值
objSysScoreWeightENT.UpdDate = objSysScoreWeightENS.UpdDate; //修改日期
objSysScoreWeightENT.UpdUser = objSysScoreWeightENS.UpdUser; //修改人
objSysScoreWeightENT.IdCurrEduCls = objSysScoreWeightENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objSysScoreWeightEN">源简化对象</param>
 public static void SetUpdFlag(clsSysScoreWeightEN objSysScoreWeightEN)
{
try
{
objSysScoreWeightEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSysScoreWeightEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSysScoreWeight.ScoreWeightId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreWeightEN.ScoreWeightId = objSysScoreWeightEN.ScoreWeightId; //分数权重Id
}
if (arrFldSet.Contains(conSysScoreWeight.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreWeightEN.Memo = objSysScoreWeightEN.Memo == "[null]" ? null :  objSysScoreWeightEN.Memo; //备注
}
if (arrFldSet.Contains(conSysScoreWeight.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreWeightEN.IsPublic = objSysScoreWeightEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(conSysScoreWeight.ScoreTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreWeightEN.ScoreTypeId = objSysScoreWeightEN.ScoreTypeId == "[null]" ? null :  objSysScoreWeightEN.ScoreTypeId; //分数类型Id
}
if (arrFldSet.Contains(conSysScoreWeight.ScoreWeightValue, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreWeightEN.ScoreWeightValue = objSysScoreWeightEN.ScoreWeightValue; //分数权重值
}
if (arrFldSet.Contains(conSysScoreWeight.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreWeightEN.UpdDate = objSysScoreWeightEN.UpdDate == "[null]" ? null :  objSysScoreWeightEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSysScoreWeight.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreWeightEN.UpdUser = objSysScoreWeightEN.UpdUser == "[null]" ? null :  objSysScoreWeightEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conSysScoreWeight.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreWeightEN.IdCurrEduCls = objSysScoreWeightEN.IdCurrEduCls == "[null]" ? null :  objSysScoreWeightEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objSysScoreWeightEN">源简化对象</param>
 public static void AccessFldValueNull(clsSysScoreWeightEN objSysScoreWeightEN)
{
try
{
if (objSysScoreWeightEN.Memo == "[null]") objSysScoreWeightEN.Memo = null; //备注
if (objSysScoreWeightEN.ScoreTypeId == "[null]") objSysScoreWeightEN.ScoreTypeId = null; //分数类型Id
if (objSysScoreWeightEN.UpdDate == "[null]") objSysScoreWeightEN.UpdDate = null; //修改日期
if (objSysScoreWeightEN.UpdUser == "[null]") objSysScoreWeightEN.UpdUser = null; //修改人
if (objSysScoreWeightEN.IdCurrEduCls == "[null]") objSysScoreWeightEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckPropertyNew(clsSysScoreWeightEN objSysScoreWeightEN)
{
 SysScoreWeightDA.CheckPropertyNew(objSysScoreWeightEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSysScoreWeightEN objSysScoreWeightEN)
{
 SysScoreWeightDA.CheckProperty4Condition(objSysScoreWeightEN);
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
if (clsSysScoreWeightBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysScoreWeightBL没有刷新缓存机制(clsSysScoreWeightBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ScoreWeightId");
//if (arrSysScoreWeightObjLstCache == null)
//{
//arrSysScoreWeightObjLstCache = SysScoreWeightDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strScoreWeightId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysScoreWeightEN GetObjByScoreWeightIdCache(string strScoreWeightId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSysScoreWeightEN._CurrTabName);
List<clsSysScoreWeightEN> arrSysScoreWeightObjLstCache = GetObjLstCache();
IEnumerable <clsSysScoreWeightEN> arrSysScoreWeightObjLst_Sel =
arrSysScoreWeightObjLstCache
.Where(x=> x.ScoreWeightId == strScoreWeightId 
);
if (arrSysScoreWeightObjLst_Sel.Count() == 0)
{
   clsSysScoreWeightEN obj = clsSysScoreWeightBL.GetObjByScoreWeightId(strScoreWeightId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSysScoreWeightObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysScoreWeightEN> GetAllSysScoreWeightObjLstCache()
{
//获取缓存中的对象列表
List<clsSysScoreWeightEN> arrSysScoreWeightObjLstCache = GetObjLstCache(); 
return arrSysScoreWeightObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysScoreWeightEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSysScoreWeightEN._CurrTabName);
List<clsSysScoreWeightEN> arrSysScoreWeightObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSysScoreWeightObjLstCache;
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
string strKey = string.Format("{0}", clsSysScoreWeightEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysScoreWeightEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSysScoreWeightEN._RefreshTimeLst.Count == 0) return "";
return clsSysScoreWeightEN._RefreshTimeLst[clsSysScoreWeightEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSysScoreWeightBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSysScoreWeightEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysScoreWeightEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSysScoreWeightBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strScoreWeightId)
{
if (strInFldName != conSysScoreWeight.ScoreWeightId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSysScoreWeight.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSysScoreWeight.AttributeName));
throw new Exception(strMsg);
}
var objSysScoreWeight = clsSysScoreWeightBL.GetObjByScoreWeightIdCache(strScoreWeightId);
if (objSysScoreWeight == null) return "";
return objSysScoreWeight[strOutFldName].ToString();
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
int intRecCount = clsSysScoreWeightDA.GetRecCount(strTabName);
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
int intRecCount = clsSysScoreWeightDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSysScoreWeightDA.GetRecCount();
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
int intRecCount = clsSysScoreWeightDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSysScoreWeightCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSysScoreWeightEN objSysScoreWeightCond)
{
List<clsSysScoreWeightEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysScoreWeightEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysScoreWeight.AttributeName)
{
if (objSysScoreWeightCond.IsUpdated(strFldName) == false) continue;
if (objSysScoreWeightCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysScoreWeightCond[strFldName].ToString());
}
else
{
if (objSysScoreWeightCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysScoreWeightCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysScoreWeightCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysScoreWeightCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysScoreWeightCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysScoreWeightCond[strFldName]));
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
 List<string> arrList = clsSysScoreWeightDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SysScoreWeightDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SysScoreWeightDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SysScoreWeightDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysScoreWeightDA.SetFldValue(clsSysScoreWeightEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SysScoreWeightDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysScoreWeightDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysScoreWeightDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysScoreWeightDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SysScoreWeight] "); 
 strCreateTabCode.Append(" ( "); 
 // /**分数权重Id*/ 
 strCreateTabCode.Append(" ScoreWeightId char(1) primary key, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**是否公开*/ 
 strCreateTabCode.Append(" IsPublic bit Null, "); 
 // /**分数类型Id*/ 
 strCreateTabCode.Append(" ScoreTypeId char(4) Null, "); 
 // /**分数权重值*/ 
 strCreateTabCode.Append(" ScoreWeightValue varchar(20) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 系统分数权重表(SysScoreWeight)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SysScoreWeight : clsCommFun4BL
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
clsSysScoreWeightBL.ReFreshThisCache();
}
}

}