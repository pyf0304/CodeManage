﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeBL
 表名:SenateGauge(01120529)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
public static class  clsSenateGaugeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdsenateGauge">表关键字</param>
 /// <returns>表对象</returns>
public static clsSenateGaugeEN GetObj(this K_IdsenateGauge_SenateGauge myKey)
{
clsSenateGaugeEN objSenateGaugeEN = clsSenateGaugeBL.SenateGaugeDA.GetObjByIdsenateGauge(myKey.Value);
return objSenateGaugeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSenateGaugeEN objSenateGaugeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSenateGaugeEN.IdsenateGauge) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeBL.IsExist(objSenateGaugeEN.IdsenateGauge) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeEN.IdsenateGauge, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsSenateGaugeBL.SenateGaugeDA.AddNewRecordBySQL2(objSenateGaugeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeBL.ReFreshCache();

if (clsSenateGaugeBL.relatedActions != null)
{
clsSenateGaugeBL.relatedActions.UpdRelaTabDate(objSenateGaugeEN.IdsenateGauge, objSenateGaugeEN.UpdUserId);
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
public static bool AddRecordEx(this clsSenateGaugeEN objSenateGaugeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsSenateGaugeBL.IsExist(objSenateGaugeEN.IdsenateGauge))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objSenateGaugeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objSenateGaugeEN.AddNewRecord();
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
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSenateGaugeEN objSenateGaugeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSenateGaugeEN.IdsenateGauge) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeBL.IsExist(objSenateGaugeEN.IdsenateGauge) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeEN.IdsenateGauge, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsSenateGaugeBL.SenateGaugeDA.AddNewRecordBySQL2WithReturnKey(objSenateGaugeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeBL.ReFreshCache();

if (clsSenateGaugeBL.relatedActions != null)
{
clsSenateGaugeBL.relatedActions.UpdRelaTabDate(objSenateGaugeEN.IdsenateGauge, objSenateGaugeEN.UpdUserId);
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
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeEN SetIdsenateGauge(this clsSenateGaugeEN objSenateGaugeEN, string strIdsenateGauge, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdsenateGauge, 4, conSenateGauge.IdsenateGauge);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdsenateGauge, 4, conSenateGauge.IdsenateGauge);
}
objSenateGaugeEN.IdsenateGauge = strIdsenateGauge; //评价量规流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.IdsenateGauge) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.IdsenateGauge, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.IdsenateGauge] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeEN SetsenateGaugeID(this clsSenateGaugeEN objSenateGaugeEN, string strsenateGaugeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeID, conSenateGauge.senateGaugeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeID, 4, conSenateGauge.senateGaugeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeID, 4, conSenateGauge.senateGaugeID);
}
objSenateGaugeEN.senateGaugeID = strsenateGaugeID; //评价量规ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.senateGaugeID) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.senateGaugeID, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.senateGaugeID] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeEN SetsenateGaugeName(this clsSenateGaugeEN objSenateGaugeEN, string strsenateGaugeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeName, conSenateGauge.senateGaugeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeName, 200, conSenateGauge.senateGaugeName);
}
objSenateGaugeEN.senateGaugeName = strsenateGaugeName; //评价量规名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.senateGaugeName) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.senateGaugeName, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.senateGaugeName] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeEN SetsenateGaugeScore(this clsSenateGaugeEN objSenateGaugeEN, float? fltsenateGaugeScore, string strComparisonOp="")
	{
objSenateGaugeEN.senateGaugeScore = fltsenateGaugeScore; //评价量规分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.senateGaugeScore) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.senateGaugeScore, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.senateGaugeScore] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeEN SetSenateGaugeWeight(this clsSenateGaugeEN objSenateGaugeEN, float? fltSenateGaugeWeight, string strComparisonOp="")
	{
objSenateGaugeEN.SenateGaugeWeight = fltSenateGaugeWeight; //评价量规权重
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.SenateGaugeWeight) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.SenateGaugeWeight, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.SenateGaugeWeight] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeEN SetsenateGaugeMemo(this clsSenateGaugeEN objSenateGaugeEN, string strsenateGaugeMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeMemo, 1000, conSenateGauge.senateGaugeMemo);
}
objSenateGaugeEN.senateGaugeMemo = strsenateGaugeMemo; //评价量规指标与说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.senateGaugeMemo) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.senateGaugeMemo, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.senateGaugeMemo] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeEN SetIdPubClassCaseSenateGaugeVersion(this clsSenateGaugeEN objSenateGaugeEN, string strIdPubClassCaseSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubClassCaseSenateGaugeVersion, conSenateGauge.IdPubClassCaseSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCaseSenateGaugeVersion, 4, conSenateGauge.IdPubClassCaseSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCaseSenateGaugeVersion, 4, conSenateGauge.IdPubClassCaseSenateGaugeVersion);
}
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = strIdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.IdPubClassCaseSenateGaugeVersion) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.IdPubClassCaseSenateGaugeVersion, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.IdPubClassCaseSenateGaugeVersion] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeEN SetOrderNum(this clsSenateGaugeEN objSenateGaugeEN, int? intOrderNum, string strComparisonOp="")
	{
objSenateGaugeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.OrderNum) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.OrderNum, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.OrderNum] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeEN SetUpdDate(this clsSenateGaugeEN objSenateGaugeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSenateGauge.UpdDate);
}
objSenateGaugeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.UpdDate) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.UpdDate, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.UpdDate] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeEN SetUpdUserId(this clsSenateGaugeEN objSenateGaugeEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSenateGauge.UpdUserId);
}
objSenateGaugeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.UpdUserId) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.UpdUserId, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.UpdUserId] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSenateGaugeEN objSenateGaugeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSenateGaugeEN.CheckPropertyNew();
clsSenateGaugeEN objSenateGaugeCond = new clsSenateGaugeEN();
string strCondition = objSenateGaugeCond
.SetIdsenateGauge(objSenateGaugeEN.IdsenateGauge, "=")
.GetCombineCondition();
objSenateGaugeEN._IsCheckProperty = true;
bool bolIsExist = clsSenateGaugeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSenateGaugeEN.Update();
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
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSenateGaugeEN objSenateGaugeEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeEN.IdsenateGauge) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSenateGaugeBL.SenateGaugeDA.UpdateBySql2(objSenateGaugeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeBL.ReFreshCache();

if (clsSenateGaugeBL.relatedActions != null)
{
clsSenateGaugeBL.relatedActions.UpdRelaTabDate(objSenateGaugeEN.IdsenateGauge, objSenateGaugeEN.UpdUserId);
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
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSenateGaugeEN objSenateGaugeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSenateGaugeEN.IdsenateGauge) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSenateGaugeBL.SenateGaugeDA.UpdateBySql2(objSenateGaugeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeBL.ReFreshCache();

if (clsSenateGaugeBL.relatedActions != null)
{
clsSenateGaugeBL.relatedActions.UpdRelaTabDate(objSenateGaugeEN.IdsenateGauge, objSenateGaugeEN.UpdUserId);
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
 /// <param name = "objSenateGaugeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSenateGaugeEN objSenateGaugeEN, string strWhereCond)
{
try
{
bool bolResult = clsSenateGaugeBL.SenateGaugeDA.UpdateBySqlWithCondition(objSenateGaugeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeBL.ReFreshCache();

if (clsSenateGaugeBL.relatedActions != null)
{
clsSenateGaugeBL.relatedActions.UpdRelaTabDate(objSenateGaugeEN.IdsenateGauge, objSenateGaugeEN.UpdUserId);
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
 /// <param name = "objSenateGaugeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSenateGaugeEN objSenateGaugeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSenateGaugeBL.SenateGaugeDA.UpdateBySqlWithConditionTransaction(objSenateGaugeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeBL.ReFreshCache();

if (clsSenateGaugeBL.relatedActions != null)
{
clsSenateGaugeBL.relatedActions.UpdRelaTabDate(objSenateGaugeEN.IdsenateGauge, objSenateGaugeEN.UpdUserId);
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
 /// <param name = "strIdsenateGauge">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSenateGaugeEN objSenateGaugeEN)
{
try
{
int intRecNum = clsSenateGaugeBL.SenateGaugeDA.DelRecord(objSenateGaugeEN.IdsenateGauge);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeBL.ReFreshCache();

if (clsSenateGaugeBL.relatedActions != null)
{
clsSenateGaugeBL.relatedActions.UpdRelaTabDate(objSenateGaugeEN.IdsenateGauge, objSenateGaugeEN.UpdUserId);
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
 /// <param name = "objSenateGaugeENS">源对象</param>
 /// <param name = "objSenateGaugeENT">目标对象</param>
 public static void CopyTo(this clsSenateGaugeEN objSenateGaugeENS, clsSenateGaugeEN objSenateGaugeENT)
{
try
{
objSenateGaugeENT.IdsenateGauge = objSenateGaugeENS.IdsenateGauge; //评价量规流水号
objSenateGaugeENT.senateGaugeID = objSenateGaugeENS.senateGaugeID; //评价量规ID
objSenateGaugeENT.senateGaugeName = objSenateGaugeENS.senateGaugeName; //评价量规名称
objSenateGaugeENT.senateGaugeScore = objSenateGaugeENS.senateGaugeScore; //评价量规分值
objSenateGaugeENT.SenateGaugeWeight = objSenateGaugeENS.SenateGaugeWeight; //评价量规权重
objSenateGaugeENT.senateGaugeMemo = objSenateGaugeENS.senateGaugeMemo; //评价量规指标与说明
objSenateGaugeENT.IdPubClassCaseSenateGaugeVersion = objSenateGaugeENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objSenateGaugeENT.OrderNum = objSenateGaugeENS.OrderNum; //序号
objSenateGaugeENT.UpdDate = objSenateGaugeENS.UpdDate; //修改日期
objSenateGaugeENT.UpdUserId = objSenateGaugeENS.UpdUserId; //修改用户Id
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
 /// <param name = "objSenateGaugeENS">源对象</param>
 /// <returns>目标对象=>clsSenateGaugeEN:objSenateGaugeENT</returns>
 public static clsSenateGaugeEN CopyTo(this clsSenateGaugeEN objSenateGaugeENS)
{
try
{
 clsSenateGaugeEN objSenateGaugeENT = new clsSenateGaugeEN()
{
IdsenateGauge = objSenateGaugeENS.IdsenateGauge, //评价量规流水号
senateGaugeID = objSenateGaugeENS.senateGaugeID, //评价量规ID
senateGaugeName = objSenateGaugeENS.senateGaugeName, //评价量规名称
senateGaugeScore = objSenateGaugeENS.senateGaugeScore, //评价量规分值
SenateGaugeWeight = objSenateGaugeENS.SenateGaugeWeight, //评价量规权重
senateGaugeMemo = objSenateGaugeENS.senateGaugeMemo, //评价量规指标与说明
IdPubClassCaseSenateGaugeVersion = objSenateGaugeENS.IdPubClassCaseSenateGaugeVersion, //公开课量表版本流水号
OrderNum = objSenateGaugeENS.OrderNum, //序号
UpdDate = objSenateGaugeENS.UpdDate, //修改日期
UpdUserId = objSenateGaugeENS.UpdUserId, //修改用户Id
};
 return objSenateGaugeENT;
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
public static void CheckPropertyNew(this clsSenateGaugeEN objSenateGaugeEN)
{
 clsSenateGaugeBL.SenateGaugeDA.CheckPropertyNew(objSenateGaugeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSenateGaugeEN objSenateGaugeEN)
{
 clsSenateGaugeBL.SenateGaugeDA.CheckProperty4Condition(objSenateGaugeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSenateGaugeEN objSenateGaugeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSenateGaugeCond.IsUpdated(conSenateGauge.IdsenateGauge) == true)
{
string strComparisonOpIdsenateGauge = objSenateGaugeCond.dicFldComparisonOp[conSenateGauge.IdsenateGauge];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGauge.IdsenateGauge, objSenateGaugeCond.IdsenateGauge, strComparisonOpIdsenateGauge);
}
if (objSenateGaugeCond.IsUpdated(conSenateGauge.senateGaugeID) == true)
{
string strComparisonOpsenateGaugeID = objSenateGaugeCond.dicFldComparisonOp[conSenateGauge.senateGaugeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGauge.senateGaugeID, objSenateGaugeCond.senateGaugeID, strComparisonOpsenateGaugeID);
}
if (objSenateGaugeCond.IsUpdated(conSenateGauge.senateGaugeName) == true)
{
string strComparisonOpsenateGaugeName = objSenateGaugeCond.dicFldComparisonOp[conSenateGauge.senateGaugeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGauge.senateGaugeName, objSenateGaugeCond.senateGaugeName, strComparisonOpsenateGaugeName);
}
if (objSenateGaugeCond.IsUpdated(conSenateGauge.senateGaugeScore) == true)
{
string strComparisonOpsenateGaugeScore = objSenateGaugeCond.dicFldComparisonOp[conSenateGauge.senateGaugeScore];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGauge.senateGaugeScore, objSenateGaugeCond.senateGaugeScore, strComparisonOpsenateGaugeScore);
}
if (objSenateGaugeCond.IsUpdated(conSenateGauge.SenateGaugeWeight) == true)
{
string strComparisonOpSenateGaugeWeight = objSenateGaugeCond.dicFldComparisonOp[conSenateGauge.SenateGaugeWeight];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGauge.SenateGaugeWeight, objSenateGaugeCond.SenateGaugeWeight, strComparisonOpSenateGaugeWeight);
}
if (objSenateGaugeCond.IsUpdated(conSenateGauge.senateGaugeMemo) == true)
{
string strComparisonOpsenateGaugeMemo = objSenateGaugeCond.dicFldComparisonOp[conSenateGauge.senateGaugeMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGauge.senateGaugeMemo, objSenateGaugeCond.senateGaugeMemo, strComparisonOpsenateGaugeMemo);
}
if (objSenateGaugeCond.IsUpdated(conSenateGauge.IdPubClassCaseSenateGaugeVersion) == true)
{
string strComparisonOpIdPubClassCaseSenateGaugeVersion = objSenateGaugeCond.dicFldComparisonOp[conSenateGauge.IdPubClassCaseSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGauge.IdPubClassCaseSenateGaugeVersion, objSenateGaugeCond.IdPubClassCaseSenateGaugeVersion, strComparisonOpIdPubClassCaseSenateGaugeVersion);
}
if (objSenateGaugeCond.IsUpdated(conSenateGauge.OrderNum) == true)
{
string strComparisonOpOrderNum = objSenateGaugeCond.dicFldComparisonOp[conSenateGauge.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGauge.OrderNum, objSenateGaugeCond.OrderNum, strComparisonOpOrderNum);
}
if (objSenateGaugeCond.IsUpdated(conSenateGauge.UpdDate) == true)
{
string strComparisonOpUpdDate = objSenateGaugeCond.dicFldComparisonOp[conSenateGauge.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGauge.UpdDate, objSenateGaugeCond.UpdDate, strComparisonOpUpdDate);
}
if (objSenateGaugeCond.IsUpdated(conSenateGauge.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objSenateGaugeCond.dicFldComparisonOp[conSenateGauge.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGauge.UpdUserId, objSenateGaugeCond.UpdUserId, strComparisonOpUpdUserId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SenateGauge
{
public virtual bool UpdRelaTabDate(string strIdsenateGauge, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 评价量规(SenateGauge)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSenateGaugeBL
{
public static RelatedActions_SenateGauge relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSenateGaugeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSenateGaugeDA SenateGaugeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSenateGaugeDA();
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
 public clsSenateGaugeBL()
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
if (string.IsNullOrEmpty(clsSenateGaugeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSenateGaugeEN._ConnectString);
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
public static DataTable GetDataTable_SenateGauge(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SenateGaugeDA.GetDataTable_SenateGauge(strWhereCond);
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
objDT = SenateGaugeDA.GetDataTable(strWhereCond);
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
objDT = SenateGaugeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SenateGaugeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SenateGaugeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SenateGaugeDA.GetDataTable_Top(objTopPara);
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
objDT = SenateGaugeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SenateGaugeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SenateGaugeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdsenateGaugeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSenateGaugeEN> GetObjLstByIdsenateGaugeLst(List<string> arrIdsenateGaugeLst)
{
List<clsSenateGaugeEN> arrObjLst = new List<clsSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdsenateGaugeLst, true);
 string strWhereCond = string.Format("IdsenateGauge in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN();
try
{
objSenateGaugeEN.IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objSenateGaugeEN.senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objSenateGaugeEN.senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objSenateGaugeEN.senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objSenateGaugeEN.SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objSenateGaugeEN.senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objSenateGaugeEN.OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGauge.OrderNum].ToString().Trim()); //序号
objSenateGaugeEN.UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeEN.UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdsenateGaugeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSenateGaugeEN> GetObjLstByIdsenateGaugeLstCache(List<string> arrIdsenateGaugeLst)
{
string strKey = string.Format("{0}", clsSenateGaugeEN._CurrTabName);
List<clsSenateGaugeEN> arrSenateGaugeObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeEN> arrSenateGaugeObjLst_Sel =
arrSenateGaugeObjLstCache
.Where(x => arrIdsenateGaugeLst.Contains(x.IdsenateGauge));
return arrSenateGaugeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeEN> GetObjLst(string strWhereCond)
{
List<clsSenateGaugeEN> arrObjLst = new List<clsSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN();
try
{
objSenateGaugeEN.IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objSenateGaugeEN.senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objSenateGaugeEN.senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objSenateGaugeEN.senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objSenateGaugeEN.SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objSenateGaugeEN.senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objSenateGaugeEN.OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGauge.OrderNum].ToString().Trim()); //序号
objSenateGaugeEN.UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeEN.UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeEN);
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
public static List<clsSenateGaugeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSenateGaugeEN> arrObjLst = new List<clsSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN();
try
{
objSenateGaugeEN.IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objSenateGaugeEN.senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objSenateGaugeEN.senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objSenateGaugeEN.senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objSenateGaugeEN.SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objSenateGaugeEN.senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objSenateGaugeEN.OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGauge.OrderNum].ToString().Trim()); //序号
objSenateGaugeEN.UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeEN.UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSenateGaugeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSenateGaugeEN> GetSubObjLstCache(clsSenateGaugeEN objSenateGaugeCond)
{
List<clsSenateGaugeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSenateGauge.AttributeName)
{
if (objSenateGaugeCond.IsUpdated(strFldName) == false) continue;
if (objSenateGaugeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeCond[strFldName].ToString());
}
else
{
if (objSenateGaugeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSenateGaugeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSenateGaugeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSenateGaugeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSenateGaugeCond[strFldName]));
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
public static List<clsSenateGaugeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSenateGaugeEN> arrObjLst = new List<clsSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN();
try
{
objSenateGaugeEN.IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objSenateGaugeEN.senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objSenateGaugeEN.senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objSenateGaugeEN.senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objSenateGaugeEN.SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objSenateGaugeEN.senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objSenateGaugeEN.OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGauge.OrderNum].ToString().Trim()); //序号
objSenateGaugeEN.UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeEN.UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeEN);
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
public static List<clsSenateGaugeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSenateGaugeEN> arrObjLst = new List<clsSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN();
try
{
objSenateGaugeEN.IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objSenateGaugeEN.senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objSenateGaugeEN.senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objSenateGaugeEN.senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objSenateGaugeEN.SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objSenateGaugeEN.senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objSenateGaugeEN.OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGauge.OrderNum].ToString().Trim()); //序号
objSenateGaugeEN.UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeEN.UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeEN);
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
List<clsSenateGaugeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSenateGaugeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSenateGaugeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSenateGaugeEN> arrObjLst = new List<clsSenateGaugeEN>(); 
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
	clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN();
try
{
objSenateGaugeEN.IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objSenateGaugeEN.senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objSenateGaugeEN.senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objSenateGaugeEN.senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objSenateGaugeEN.SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objSenateGaugeEN.senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objSenateGaugeEN.OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGauge.OrderNum].ToString().Trim()); //序号
objSenateGaugeEN.UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeEN.UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeEN);
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
public static List<clsSenateGaugeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSenateGaugeEN> arrObjLst = new List<clsSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN();
try
{
objSenateGaugeEN.IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objSenateGaugeEN.senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objSenateGaugeEN.senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objSenateGaugeEN.senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objSenateGaugeEN.SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objSenateGaugeEN.senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objSenateGaugeEN.OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGauge.OrderNum].ToString().Trim()); //序号
objSenateGaugeEN.UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeEN.UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSenateGaugeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSenateGaugeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSenateGaugeEN> arrObjLst = new List<clsSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN();
try
{
objSenateGaugeEN.IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objSenateGaugeEN.senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objSenateGaugeEN.senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objSenateGaugeEN.senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objSenateGaugeEN.SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objSenateGaugeEN.senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objSenateGaugeEN.OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGauge.OrderNum].ToString().Trim()); //序号
objSenateGaugeEN.UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeEN.UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeEN);
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
public static List<clsSenateGaugeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSenateGaugeEN> arrObjLst = new List<clsSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN();
try
{
objSenateGaugeEN.IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objSenateGaugeEN.senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objSenateGaugeEN.senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objSenateGaugeEN.senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objSenateGaugeEN.SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objSenateGaugeEN.senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objSenateGaugeEN.OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGauge.OrderNum].ToString().Trim()); //序号
objSenateGaugeEN.UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeEN.UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSenateGaugeEN> arrObjLst = new List<clsSenateGaugeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN();
try
{
objSenateGaugeEN.IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objSenateGaugeEN.senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objSenateGaugeEN.senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objSenateGaugeEN.senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objSenateGaugeEN.SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objSenateGaugeEN.senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objSenateGaugeEN.OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGauge.OrderNum].ToString().Trim()); //序号
objSenateGaugeEN.UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeEN.UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSenateGaugeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSenateGauge(ref clsSenateGaugeEN objSenateGaugeEN)
{
bool bolResult = SenateGaugeDA.GetSenateGauge(ref objSenateGaugeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdsenateGauge">表关键字</param>
 /// <returns>表对象</returns>
public static clsSenateGaugeEN GetObjByIdsenateGauge(string strIdsenateGauge)
{
if (strIdsenateGauge.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdsenateGauge]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdsenateGauge) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdsenateGauge]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSenateGaugeEN objSenateGaugeEN = SenateGaugeDA.GetObjByIdsenateGauge(strIdsenateGauge);
return objSenateGaugeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSenateGaugeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSenateGaugeEN objSenateGaugeEN = SenateGaugeDA.GetFirstObj(strWhereCond);
 return objSenateGaugeEN;
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
public static clsSenateGaugeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSenateGaugeEN objSenateGaugeEN = SenateGaugeDA.GetObjByDataRow(objRow);
 return objSenateGaugeEN;
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
public static clsSenateGaugeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSenateGaugeEN objSenateGaugeEN = SenateGaugeDA.GetObjByDataRow(objRow);
 return objSenateGaugeEN;
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
 /// <param name = "strIdsenateGauge">所给的关键字</param>
 /// <param name = "lstSenateGaugeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSenateGaugeEN GetObjByIdsenateGaugeFromList(string strIdsenateGauge, List<clsSenateGaugeEN> lstSenateGaugeObjLst)
{
foreach (clsSenateGaugeEN objSenateGaugeEN in lstSenateGaugeObjLst)
{
if (objSenateGaugeEN.IdsenateGauge == strIdsenateGauge)
{
return objSenateGaugeEN;
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
 string strIdsenateGauge;
 try
 {
 strIdsenateGauge = new clsSenateGaugeDA().GetFirstID(strWhereCond);
 return strIdsenateGauge;
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
 arrList = SenateGaugeDA.GetID(strWhereCond);
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
bool bolIsExist = SenateGaugeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdsenateGauge">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdsenateGauge)
{
if (string.IsNullOrEmpty(strIdsenateGauge) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdsenateGauge]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SenateGaugeDA.IsExist(strIdsenateGauge);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdsenateGauge">评价量规流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdsenateGauge, string strOpUser)
{
clsSenateGaugeEN objSenateGaugeEN = clsSenateGaugeBL.GetObjByIdsenateGauge(strIdsenateGauge);
objSenateGaugeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objSenateGaugeEN.UpdUserId = strOpUser;
return clsSenateGaugeBL.UpdateBySql2(objSenateGaugeEN);
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
 bolIsExist = clsSenateGaugeDA.IsExistTable();
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
 bolIsExist = SenateGaugeDA.IsExistTable(strTabName);
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
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSenateGaugeEN objSenateGaugeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSenateGaugeEN.IdsenateGauge) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeBL.IsExist(objSenateGaugeEN.IdsenateGauge) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeEN.IdsenateGauge, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = SenateGaugeDA.AddNewRecordBySQL2(objSenateGaugeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeBL.ReFreshCache();

if (clsSenateGaugeBL.relatedActions != null)
{
clsSenateGaugeBL.relatedActions.UpdRelaTabDate(objSenateGaugeEN.IdsenateGauge, objSenateGaugeEN.UpdUserId);
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
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSenateGaugeEN objSenateGaugeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSenateGaugeEN.IdsenateGauge) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeBL.IsExist(objSenateGaugeEN.IdsenateGauge) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeEN.IdsenateGauge, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = SenateGaugeDA.AddNewRecordBySQL2WithReturnKey(objSenateGaugeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeBL.ReFreshCache();

if (clsSenateGaugeBL.relatedActions != null)
{
clsSenateGaugeBL.relatedActions.UpdRelaTabDate(objSenateGaugeEN.IdsenateGauge, objSenateGaugeEN.UpdUserId);
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
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSenateGaugeEN objSenateGaugeEN)
{
try
{
bool bolResult = SenateGaugeDA.Update(objSenateGaugeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeBL.ReFreshCache();

if (clsSenateGaugeBL.relatedActions != null)
{
clsSenateGaugeBL.relatedActions.UpdRelaTabDate(objSenateGaugeEN.IdsenateGauge, objSenateGaugeEN.UpdUserId);
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
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSenateGaugeEN objSenateGaugeEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeEN.IdsenateGauge) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SenateGaugeDA.UpdateBySql2(objSenateGaugeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeBL.ReFreshCache();

if (clsSenateGaugeBL.relatedActions != null)
{
clsSenateGaugeBL.relatedActions.UpdRelaTabDate(objSenateGaugeEN.IdsenateGauge, objSenateGaugeEN.UpdUserId);
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
 /// <param name = "strIdsenateGauge">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdsenateGauge)
{
try
{
 clsSenateGaugeEN objSenateGaugeEN = clsSenateGaugeBL.GetObjByIdsenateGauge(strIdsenateGauge);

if (clsSenateGaugeBL.relatedActions != null)
{
clsSenateGaugeBL.relatedActions.UpdRelaTabDate(objSenateGaugeEN.IdsenateGauge, objSenateGaugeEN.UpdUserId);
}
if (objSenateGaugeEN != null)
{
int intRecNum = SenateGaugeDA.DelRecord(strIdsenateGauge);
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
/// <param name="strIdsenateGauge">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdsenateGauge )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSenateGaugeDA.GetSpecSQLObj();
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
//删除与表:[SenateGauge]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSenateGauge.IdsenateGauge,
//strIdsenateGauge);
//        clsSenateGaugeBL.DelSenateGaugesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSenateGaugeBL.DelRecord(strIdsenateGauge, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSenateGaugeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdsenateGauge, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdsenateGauge">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdsenateGauge, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSenateGaugeBL.relatedActions != null)
{
clsSenateGaugeBL.relatedActions.UpdRelaTabDate(strIdsenateGauge, "UpdRelaTabDate");
}
bool bolResult = SenateGaugeDA.DelRecord(strIdsenateGauge,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdsenateGaugeLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSenateGauges(List<string> arrIdsenateGaugeLst)
{
if (arrIdsenateGaugeLst.Count == 0) return 0;
try
{
if (clsSenateGaugeBL.relatedActions != null)
{
foreach (var strIdsenateGauge in arrIdsenateGaugeLst)
{
clsSenateGaugeBL.relatedActions.UpdRelaTabDate(strIdsenateGauge, "UpdRelaTabDate");
}
}
int intDelRecNum = SenateGaugeDA.DelSenateGauge(arrIdsenateGaugeLst);
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
public static int DelSenateGaugesByCond(string strWhereCond)
{
try
{
if (clsSenateGaugeBL.relatedActions != null)
{
List<string> arrIdsenateGauge = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdsenateGauge in arrIdsenateGauge)
{
clsSenateGaugeBL.relatedActions.UpdRelaTabDate(strIdsenateGauge, "UpdRelaTabDate");
}
}
int intRecNum = SenateGaugeDA.DelSenateGauge(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SenateGauge]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdsenateGauge">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdsenateGauge)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSenateGaugeDA.GetSpecSQLObj();
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
//删除与表:[SenateGauge]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSenateGaugeBL.DelRecord(strIdsenateGauge, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSenateGaugeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdsenateGauge, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSenateGaugeENS">源对象</param>
 /// <param name = "objSenateGaugeENT">目标对象</param>
 public static void CopyTo(clsSenateGaugeEN objSenateGaugeENS, clsSenateGaugeEN objSenateGaugeENT)
{
try
{
objSenateGaugeENT.IdsenateGauge = objSenateGaugeENS.IdsenateGauge; //评价量规流水号
objSenateGaugeENT.senateGaugeID = objSenateGaugeENS.senateGaugeID; //评价量规ID
objSenateGaugeENT.senateGaugeName = objSenateGaugeENS.senateGaugeName; //评价量规名称
objSenateGaugeENT.senateGaugeScore = objSenateGaugeENS.senateGaugeScore; //评价量规分值
objSenateGaugeENT.SenateGaugeWeight = objSenateGaugeENS.SenateGaugeWeight; //评价量规权重
objSenateGaugeENT.senateGaugeMemo = objSenateGaugeENS.senateGaugeMemo; //评价量规指标与说明
objSenateGaugeENT.IdPubClassCaseSenateGaugeVersion = objSenateGaugeENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objSenateGaugeENT.OrderNum = objSenateGaugeENS.OrderNum; //序号
objSenateGaugeENT.UpdDate = objSenateGaugeENS.UpdDate; //修改日期
objSenateGaugeENT.UpdUserId = objSenateGaugeENS.UpdUserId; //修改用户Id
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
 /// <param name = "objSenateGaugeEN">源简化对象</param>
 public static void SetUpdFlag(clsSenateGaugeEN objSenateGaugeEN)
{
try
{
objSenateGaugeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSenateGaugeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSenateGauge.IdsenateGauge, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeEN.IdsenateGauge = objSenateGaugeEN.IdsenateGauge; //评价量规流水号
}
if (arrFldSet.Contains(conSenateGauge.senateGaugeID, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeEN.senateGaugeID = objSenateGaugeEN.senateGaugeID; //评价量规ID
}
if (arrFldSet.Contains(conSenateGauge.senateGaugeName, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeEN.senateGaugeName = objSenateGaugeEN.senateGaugeName; //评价量规名称
}
if (arrFldSet.Contains(conSenateGauge.senateGaugeScore, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeEN.senateGaugeScore = objSenateGaugeEN.senateGaugeScore; //评价量规分值
}
if (arrFldSet.Contains(conSenateGauge.SenateGaugeWeight, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeEN.SenateGaugeWeight = objSenateGaugeEN.SenateGaugeWeight; //评价量规权重
}
if (arrFldSet.Contains(conSenateGauge.senateGaugeMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeEN.senateGaugeMemo = objSenateGaugeEN.senateGaugeMemo == "[null]" ? null :  objSenateGaugeEN.senateGaugeMemo; //评价量规指标与说明
}
if (arrFldSet.Contains(conSenateGauge.IdPubClassCaseSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
}
if (arrFldSet.Contains(conSenateGauge.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeEN.OrderNum = objSenateGaugeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conSenateGauge.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeEN.UpdDate = objSenateGaugeEN.UpdDate == "[null]" ? null :  objSenateGaugeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSenateGauge.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeEN.UpdUserId = objSenateGaugeEN.UpdUserId == "[null]" ? null :  objSenateGaugeEN.UpdUserId; //修改用户Id
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
 /// <param name = "objSenateGaugeEN">源简化对象</param>
 public static void AccessFldValueNull(clsSenateGaugeEN objSenateGaugeEN)
{
try
{
if (objSenateGaugeEN.senateGaugeMemo == "[null]") objSenateGaugeEN.senateGaugeMemo = null; //评价量规指标与说明
if (objSenateGaugeEN.UpdDate == "[null]") objSenateGaugeEN.UpdDate = null; //修改日期
if (objSenateGaugeEN.UpdUserId == "[null]") objSenateGaugeEN.UpdUserId = null; //修改用户Id
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
public static void CheckPropertyNew(clsSenateGaugeEN objSenateGaugeEN)
{
 SenateGaugeDA.CheckPropertyNew(objSenateGaugeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSenateGaugeEN objSenateGaugeEN)
{
 SenateGaugeDA.CheckProperty4Condition(objSenateGaugeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdsenateGauge(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conSenateGauge.IdsenateGauge); 
List<clsSenateGaugeEN> arrObjLst = clsSenateGaugeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN()
{
IdsenateGauge = "0",
senateGaugeName = "选[评价量规]..."
};
arrObjLst.Insert(0, objSenateGaugeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conSenateGauge.IdsenateGauge;
objComboBox.DisplayMember = conSenateGauge.senateGaugeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdsenateGauge(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[评价量规]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conSenateGauge.IdsenateGauge); 
IEnumerable<clsSenateGaugeEN> arrObjLst = clsSenateGaugeBL.GetObjLst(strCondition);
objDDL.DataValueField = conSenateGauge.IdsenateGauge;
objDDL.DataTextField = conSenateGauge.senateGaugeName;
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
public static void BindDdl_IdsenateGaugeCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[评价量规]...","0");
List<clsSenateGaugeEN> arrSenateGaugeObjLst = GetAllSenateGaugeObjLstCache(); 
objDDL.DataValueField = conSenateGauge.IdsenateGauge;
objDDL.DataTextField = conSenateGauge.senateGaugeName;
objDDL.DataSource = arrSenateGaugeObjLst;
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
if (clsSenateGaugeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeBL没有刷新缓存机制(clsSenateGaugeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdsenateGauge");
//if (arrSenateGaugeObjLstCache == null)
//{
//arrSenateGaugeObjLstCache = SenateGaugeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdsenateGauge">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSenateGaugeEN GetObjByIdsenateGaugeCache(string strIdsenateGauge)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSenateGaugeEN._CurrTabName);
List<clsSenateGaugeEN> arrSenateGaugeObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeEN> arrSenateGaugeObjLst_Sel =
arrSenateGaugeObjLstCache
.Where(x=> x.IdsenateGauge == strIdsenateGauge 
);
if (arrSenateGaugeObjLst_Sel.Count() == 0)
{
   clsSenateGaugeEN obj = clsSenateGaugeBL.GetObjByIdsenateGauge(strIdsenateGauge);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSenateGaugeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdsenateGauge">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetsenateGaugeNameByIdsenateGaugeCache(string strIdsenateGauge)
{
if (string.IsNullOrEmpty(strIdsenateGauge) == true) return "";
//获取缓存中的对象列表
clsSenateGaugeEN objSenateGauge = GetObjByIdsenateGaugeCache(strIdsenateGauge);
if (objSenateGauge == null) return "";
return objSenateGauge.senateGaugeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdsenateGauge">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdsenateGaugeCache(string strIdsenateGauge)
{
if (string.IsNullOrEmpty(strIdsenateGauge) == true) return "";
//获取缓存中的对象列表
clsSenateGaugeEN objSenateGauge = GetObjByIdsenateGaugeCache(strIdsenateGauge);
if (objSenateGauge == null) return "";
return objSenateGauge.senateGaugeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSenateGaugeEN> GetAllSenateGaugeObjLstCache()
{
//获取缓存中的对象列表
List<clsSenateGaugeEN> arrSenateGaugeObjLstCache = GetObjLstCache(); 
return arrSenateGaugeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSenateGaugeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSenateGaugeEN._CurrTabName);
List<clsSenateGaugeEN> arrSenateGaugeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSenateGaugeObjLstCache;
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
string strKey = string.Format("{0}", clsSenateGaugeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSenateGaugeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSenateGaugeEN._RefreshTimeLst.Count == 0) return "";
return clsSenateGaugeEN._RefreshTimeLst[clsSenateGaugeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSenateGaugeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSenateGaugeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSenateGaugeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSenateGaugeBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdsenateGauge)
{
if (strInFldName != conSenateGauge.IdsenateGauge)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSenateGauge.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSenateGauge.AttributeName));
throw new Exception(strMsg);
}
var objSenateGauge = clsSenateGaugeBL.GetObjByIdsenateGaugeCache(strIdsenateGauge);
if (objSenateGauge == null) return "";
return objSenateGauge[strOutFldName].ToString();
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
int intRecCount = clsSenateGaugeDA.GetRecCount(strTabName);
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
int intRecCount = clsSenateGaugeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSenateGaugeDA.GetRecCount();
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
int intRecCount = clsSenateGaugeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSenateGaugeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSenateGaugeEN objSenateGaugeCond)
{
List<clsSenateGaugeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSenateGauge.AttributeName)
{
if (objSenateGaugeCond.IsUpdated(strFldName) == false) continue;
if (objSenateGaugeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeCond[strFldName].ToString());
}
else
{
if (objSenateGaugeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSenateGaugeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSenateGaugeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSenateGaugeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSenateGaugeCond[strFldName]));
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
 List<string> arrList = clsSenateGaugeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SenateGaugeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SenateGaugeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SenateGaugeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSenateGaugeDA.SetFldValue(clsSenateGaugeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SenateGaugeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSenateGaugeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSenateGaugeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSenateGaugeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SenateGauge] "); 
 strCreateTabCode.Append(" ( "); 
 // /**评价量规流水号*/ 
 strCreateTabCode.Append(" IdsenateGauge char(4) primary key, "); 
 // /**评价量规ID*/ 
 strCreateTabCode.Append(" senateGaugeID char(4) not Null, "); 
 // /**评价量规名称*/ 
 strCreateTabCode.Append(" senateGaugeName varchar(200) not Null, "); 
 // /**评价量规分值*/ 
 strCreateTabCode.Append(" senateGaugeScore float Null, "); 
 // /**评价量规权重*/ 
 strCreateTabCode.Append(" SenateGaugeWeight float Null, "); 
 // /**评价量规指标与说明*/ 
 strCreateTabCode.Append(" senateGaugeMemo varchar(1000) Null, "); 
 // /**公开课量表版本流水号*/ 
 strCreateTabCode.Append(" IdPubClassCaseSenateGaugeVersion char(4) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 评价量规(SenateGauge)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SenateGauge : clsCommFun4BL
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
clsSenateGaugeBL.ReFreshThisCache();
}
}

}