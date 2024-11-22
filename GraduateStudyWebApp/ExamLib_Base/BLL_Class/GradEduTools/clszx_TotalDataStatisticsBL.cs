﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TotalDataStatisticsBL
 表名:zx_TotalDataStatistics(01120791)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clszx_TotalDataStatisticsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTotalDataId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TotalDataStatisticsEN GetObj(this K_TotalDataId_zx_TotalDataStatistics myKey)
{
clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = clszx_TotalDataStatisticsBL.zx_TotalDataStatisticsDA.GetObjByTotalDataId(myKey.Value);
return objzx_TotalDataStatisticsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
 if (string.IsNullOrEmpty(objzx_TotalDataStatisticsEN.TotalDataId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_TotalDataStatisticsBL.IsExist(objzx_TotalDataStatisticsEN.TotalDataId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_TotalDataStatisticsEN.TotalDataId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clszx_TotalDataStatisticsBL.zx_TotalDataStatisticsDA.AddNewRecordBySQL2(objzx_TotalDataStatisticsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TotalDataStatisticsBL.ReFreshCache(objzx_TotalDataStatisticsEN.IdCurrEduCls);

if (clszx_TotalDataStatisticsBL.relatedActions != null)
{
clszx_TotalDataStatisticsBL.relatedActions.UpdRelaTabDate(objzx_TotalDataStatisticsEN.TotalDataId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clszx_TotalDataStatisticsBL.IsExist(objzx_TotalDataStatisticsEN.TotalDataId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objzx_TotalDataStatisticsEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objzx_TotalDataStatisticsEN.AddNewRecord();
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
 if (string.IsNullOrEmpty(objzx_TotalDataStatisticsEN.TotalDataId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_TotalDataStatisticsBL.IsExist(objzx_TotalDataStatisticsEN.TotalDataId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_TotalDataStatisticsEN.TotalDataId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clszx_TotalDataStatisticsBL.zx_TotalDataStatisticsDA.AddNewRecordBySQL2WithReturnKey(objzx_TotalDataStatisticsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TotalDataStatisticsBL.ReFreshCache(objzx_TotalDataStatisticsEN.IdCurrEduCls);

if (clszx_TotalDataStatisticsBL.relatedActions != null)
{
clszx_TotalDataStatisticsBL.relatedActions.UpdRelaTabDate(objzx_TotalDataStatisticsEN.TotalDataId, "SetUpdDate");
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TotalDataStatisticsEN SetTotalDataId(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, string strTotalDataId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTotalDataId, 12, conzx_TotalDataStatistics.TotalDataId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTotalDataId, 12, conzx_TotalDataStatistics.TotalDataId);
}
objzx_TotalDataStatisticsEN.TotalDataId = strTotalDataId; //TotalDataId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(conzx_TotalDataStatistics.TotalDataId) == false)
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(conzx_TotalDataStatistics.TotalDataId, strComparisonOp);
}
else
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp[conzx_TotalDataStatistics.TotalDataId] = strComparisonOp;
}
}
return objzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TotalDataStatisticsEN SetIdCurrEduCls(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, conzx_TotalDataStatistics.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_TotalDataStatistics.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_TotalDataStatistics.IdCurrEduCls);
}
objzx_TotalDataStatisticsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(conzx_TotalDataStatistics.IdCurrEduCls) == false)
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(conzx_TotalDataStatistics.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp[conzx_TotalDataStatistics.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TotalDataStatisticsEN SetzxTotalDataTypeId(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, string strzxTotalDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxTotalDataTypeId, conzx_TotalDataStatistics.zxTotalDataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxTotalDataTypeId, 2, conzx_TotalDataStatistics.zxTotalDataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxTotalDataTypeId, 2, conzx_TotalDataStatistics.zxTotalDataTypeId);
}
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = strzxTotalDataTypeId; //总数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(conzx_TotalDataStatistics.zxTotalDataTypeId) == false)
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(conzx_TotalDataStatistics.zxTotalDataTypeId, strComparisonOp);
}
else
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp[conzx_TotalDataStatistics.zxTotalDataTypeId] = strComparisonOp;
}
}
return objzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TotalDataStatisticsEN SetTableKey(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 20, conzx_TotalDataStatistics.TableKey);
}
objzx_TotalDataStatisticsEN.TableKey = strTableKey; //表主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(conzx_TotalDataStatistics.TableKey) == false)
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(conzx_TotalDataStatistics.TableKey, strComparisonOp);
}
else
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp[conzx_TotalDataStatistics.TableKey] = strComparisonOp;
}
}
return objzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TotalDataStatisticsEN SetDataUser(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, string strDataUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataUser, 20, conzx_TotalDataStatistics.DataUser);
}
objzx_TotalDataStatisticsEN.DataUser = strDataUser; //数据用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(conzx_TotalDataStatistics.DataUser) == false)
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(conzx_TotalDataStatistics.DataUser, strComparisonOp);
}
else
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp[conzx_TotalDataStatistics.DataUser] = strComparisonOp;
}
}
return objzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TotalDataStatisticsEN SetDataAddDate(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, string strDataAddDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataAddDate, 20, conzx_TotalDataStatistics.DataAddDate);
}
objzx_TotalDataStatisticsEN.DataAddDate = strDataAddDate; //数据添加日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(conzx_TotalDataStatistics.DataAddDate) == false)
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(conzx_TotalDataStatistics.DataAddDate, strComparisonOp);
}
else
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp[conzx_TotalDataStatistics.DataAddDate] = strComparisonOp;
}
}
return objzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TotalDataStatisticsEN SetMonth(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, int? intMonth, string strComparisonOp="")
	{
objzx_TotalDataStatisticsEN.Month = intMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(conzx_TotalDataStatistics.Month) == false)
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(conzx_TotalDataStatistics.Month, strComparisonOp);
}
else
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp[conzx_TotalDataStatistics.Month] = strComparisonOp;
}
}
return objzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TotalDataStatisticsEN SetWeek(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, int? intWeek, string strComparisonOp="")
	{
objzx_TotalDataStatisticsEN.Week = intWeek; //周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(conzx_TotalDataStatistics.Week) == false)
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(conzx_TotalDataStatistics.Week, strComparisonOp);
}
else
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp[conzx_TotalDataStatistics.Week] = strComparisonOp;
}
}
return objzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TotalDataStatisticsEN SetUpdDate(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_TotalDataStatistics.UpdDate);
}
objzx_TotalDataStatisticsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(conzx_TotalDataStatistics.UpdDate) == false)
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(conzx_TotalDataStatistics.UpdDate, strComparisonOp);
}
else
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp[conzx_TotalDataStatistics.UpdDate] = strComparisonOp;
}
}
return objzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TotalDataStatisticsEN SetUpdUser(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_TotalDataStatistics.UpdUser);
}
objzx_TotalDataStatisticsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(conzx_TotalDataStatistics.UpdUser) == false)
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(conzx_TotalDataStatistics.UpdUser, strComparisonOp);
}
else
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp[conzx_TotalDataStatistics.UpdUser] = strComparisonOp;
}
}
return objzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TotalDataStatisticsEN SetMemo(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_TotalDataStatistics.Memo);
}
objzx_TotalDataStatisticsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(conzx_TotalDataStatistics.Memo) == false)
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(conzx_TotalDataStatistics.Memo, strComparisonOp);
}
else
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp[conzx_TotalDataStatistics.Memo] = strComparisonOp;
}
}
return objzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TotalDataStatisticsEN SetScore(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, float? fltScore, string strComparisonOp="")
	{
objzx_TotalDataStatisticsEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(conzx_TotalDataStatistics.Score) == false)
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(conzx_TotalDataStatistics.Score, strComparisonOp);
}
else
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp[conzx_TotalDataStatistics.Score] = strComparisonOp;
}
}
return objzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TotalDataStatisticsEN SetTeaScore(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_TotalDataStatisticsEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(conzx_TotalDataStatistics.TeaScore) == false)
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(conzx_TotalDataStatistics.TeaScore, strComparisonOp);
}
else
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp[conzx_TotalDataStatistics.TeaScore] = strComparisonOp;
}
}
return objzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TotalDataStatisticsEN SetWeekTimeRange(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, string strWeekTimeRange, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWeekTimeRange, 100, conzx_TotalDataStatistics.WeekTimeRange);
}
objzx_TotalDataStatisticsEN.WeekTimeRange = strWeekTimeRange; //WeekTimeRange
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(conzx_TotalDataStatistics.WeekTimeRange) == false)
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(conzx_TotalDataStatistics.WeekTimeRange, strComparisonOp);
}
else
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp[conzx_TotalDataStatistics.WeekTimeRange] = strComparisonOp;
}
}
return objzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TotalDataStatisticsEN SetStuScore(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_TotalDataStatisticsEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(conzx_TotalDataStatistics.StuScore) == false)
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(conzx_TotalDataStatistics.StuScore, strComparisonOp);
}
else
{
objzx_TotalDataStatisticsEN.dicFldComparisonOp[conzx_TotalDataStatistics.StuScore] = strComparisonOp;
}
}
return objzx_TotalDataStatisticsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_TotalDataStatisticsEN.CheckPropertyNew();
clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsCond = new clszx_TotalDataStatisticsEN();
string strCondition = objzx_TotalDataStatisticsCond
.SetTotalDataId(objzx_TotalDataStatisticsEN.TotalDataId, "=")
.GetCombineCondition();
objzx_TotalDataStatisticsEN._IsCheckProperty = true;
bool bolIsExist = clszx_TotalDataStatisticsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_TotalDataStatisticsEN.Update();
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
 if (string.IsNullOrEmpty(objzx_TotalDataStatisticsEN.TotalDataId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TotalDataStatisticsBL.zx_TotalDataStatisticsDA.UpdateBySql2(objzx_TotalDataStatisticsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TotalDataStatisticsBL.ReFreshCache(objzx_TotalDataStatisticsEN.IdCurrEduCls);

if (clszx_TotalDataStatisticsBL.relatedActions != null)
{
clszx_TotalDataStatisticsBL.relatedActions.UpdRelaTabDate(objzx_TotalDataStatisticsEN.TotalDataId, "SetUpdDate");
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_TotalDataStatisticsEN.TotalDataId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TotalDataStatisticsBL.zx_TotalDataStatisticsDA.UpdateBySql2(objzx_TotalDataStatisticsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TotalDataStatisticsBL.ReFreshCache(objzx_TotalDataStatisticsEN.IdCurrEduCls);

if (clszx_TotalDataStatisticsBL.relatedActions != null)
{
clszx_TotalDataStatisticsBL.relatedActions.UpdRelaTabDate(objzx_TotalDataStatisticsEN.TotalDataId, "SetUpdDate");
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, string strWhereCond)
{
try
{
bool bolResult = clszx_TotalDataStatisticsBL.zx_TotalDataStatisticsDA.UpdateBySqlWithCondition(objzx_TotalDataStatisticsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TotalDataStatisticsBL.ReFreshCache(objzx_TotalDataStatisticsEN.IdCurrEduCls);

if (clszx_TotalDataStatisticsBL.relatedActions != null)
{
clszx_TotalDataStatisticsBL.relatedActions.UpdRelaTabDate(objzx_TotalDataStatisticsEN.TotalDataId, "SetUpdDate");
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_TotalDataStatisticsBL.zx_TotalDataStatisticsDA.UpdateBySqlWithConditionTransaction(objzx_TotalDataStatisticsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TotalDataStatisticsBL.ReFreshCache(objzx_TotalDataStatisticsEN.IdCurrEduCls);

if (clszx_TotalDataStatisticsBL.relatedActions != null)
{
clszx_TotalDataStatisticsBL.relatedActions.UpdRelaTabDate(objzx_TotalDataStatisticsEN.TotalDataId, "SetUpdDate");
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
 /// <param name = "strTotalDataId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
try
{
int intRecNum = clszx_TotalDataStatisticsBL.zx_TotalDataStatisticsDA.DelRecord(objzx_TotalDataStatisticsEN.TotalDataId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TotalDataStatisticsBL.ReFreshCache(objzx_TotalDataStatisticsEN.IdCurrEduCls);

if (clszx_TotalDataStatisticsBL.relatedActions != null)
{
clszx_TotalDataStatisticsBL.relatedActions.UpdRelaTabDate(objzx_TotalDataStatisticsEN.TotalDataId, "SetUpdDate");
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
 /// <param name = "objzx_TotalDataStatisticsENS">源对象</param>
 /// <param name = "objzx_TotalDataStatisticsENT">目标对象</param>
 public static void CopyTo(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsENS, clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsENT)
{
try
{
objzx_TotalDataStatisticsENT.TotalDataId = objzx_TotalDataStatisticsENS.TotalDataId; //TotalDataId
objzx_TotalDataStatisticsENT.IdCurrEduCls = objzx_TotalDataStatisticsENS.IdCurrEduCls; //教学班流水号
objzx_TotalDataStatisticsENT.zxTotalDataTypeId = objzx_TotalDataStatisticsENS.zxTotalDataTypeId; //总数据类型Id
objzx_TotalDataStatisticsENT.TableKey = objzx_TotalDataStatisticsENS.TableKey; //表主键
objzx_TotalDataStatisticsENT.DataUser = objzx_TotalDataStatisticsENS.DataUser; //数据用户
objzx_TotalDataStatisticsENT.DataAddDate = objzx_TotalDataStatisticsENS.DataAddDate; //数据添加日期
objzx_TotalDataStatisticsENT.Month = objzx_TotalDataStatisticsENS.Month; //月
objzx_TotalDataStatisticsENT.Week = objzx_TotalDataStatisticsENS.Week; //周
objzx_TotalDataStatisticsENT.UpdDate = objzx_TotalDataStatisticsENS.UpdDate; //修改日期
objzx_TotalDataStatisticsENT.UpdUser = objzx_TotalDataStatisticsENS.UpdUser; //修改人
objzx_TotalDataStatisticsENT.Memo = objzx_TotalDataStatisticsENS.Memo; //备注
objzx_TotalDataStatisticsENT.Score = objzx_TotalDataStatisticsENS.Score; //评分
objzx_TotalDataStatisticsENT.TeaScore = objzx_TotalDataStatisticsENS.TeaScore; //教师评分
objzx_TotalDataStatisticsENT.WeekTimeRange = objzx_TotalDataStatisticsENS.WeekTimeRange; //WeekTimeRange
objzx_TotalDataStatisticsENT.StuScore = objzx_TotalDataStatisticsENS.StuScore; //学生平均分
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
 /// <param name = "objzx_TotalDataStatisticsENS">源对象</param>
 /// <returns>目标对象=>clszx_TotalDataStatisticsEN:objzx_TotalDataStatisticsENT</returns>
 public static clszx_TotalDataStatisticsEN CopyTo(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsENS)
{
try
{
 clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsENT = new clszx_TotalDataStatisticsEN()
{
TotalDataId = objzx_TotalDataStatisticsENS.TotalDataId, //TotalDataId
IdCurrEduCls = objzx_TotalDataStatisticsENS.IdCurrEduCls, //教学班流水号
zxTotalDataTypeId = objzx_TotalDataStatisticsENS.zxTotalDataTypeId, //总数据类型Id
TableKey = objzx_TotalDataStatisticsENS.TableKey, //表主键
DataUser = objzx_TotalDataStatisticsENS.DataUser, //数据用户
DataAddDate = objzx_TotalDataStatisticsENS.DataAddDate, //数据添加日期
Month = objzx_TotalDataStatisticsENS.Month, //月
Week = objzx_TotalDataStatisticsENS.Week, //周
UpdDate = objzx_TotalDataStatisticsENS.UpdDate, //修改日期
UpdUser = objzx_TotalDataStatisticsENS.UpdUser, //修改人
Memo = objzx_TotalDataStatisticsENS.Memo, //备注
Score = objzx_TotalDataStatisticsENS.Score, //评分
TeaScore = objzx_TotalDataStatisticsENS.TeaScore, //教师评分
WeekTimeRange = objzx_TotalDataStatisticsENS.WeekTimeRange, //WeekTimeRange
StuScore = objzx_TotalDataStatisticsENS.StuScore, //学生平均分
};
 return objzx_TotalDataStatisticsENT;
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
public static void CheckPropertyNew(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
 clszx_TotalDataStatisticsBL.zx_TotalDataStatisticsDA.CheckPropertyNew(objzx_TotalDataStatisticsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
 clszx_TotalDataStatisticsBL.zx_TotalDataStatisticsDA.CheckProperty4Condition(objzx_TotalDataStatisticsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_TotalDataStatisticsCond.IsUpdated(conzx_TotalDataStatistics.TotalDataId) == true)
{
string strComparisonOpTotalDataId = objzx_TotalDataStatisticsCond.dicFldComparisonOp[conzx_TotalDataStatistics.TotalDataId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TotalDataStatistics.TotalDataId, objzx_TotalDataStatisticsCond.TotalDataId, strComparisonOpTotalDataId);
}
if (objzx_TotalDataStatisticsCond.IsUpdated(conzx_TotalDataStatistics.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_TotalDataStatisticsCond.dicFldComparisonOp[conzx_TotalDataStatistics.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TotalDataStatistics.IdCurrEduCls, objzx_TotalDataStatisticsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_TotalDataStatisticsCond.IsUpdated(conzx_TotalDataStatistics.zxTotalDataTypeId) == true)
{
string strComparisonOpzxTotalDataTypeId = objzx_TotalDataStatisticsCond.dicFldComparisonOp[conzx_TotalDataStatistics.zxTotalDataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TotalDataStatistics.zxTotalDataTypeId, objzx_TotalDataStatisticsCond.zxTotalDataTypeId, strComparisonOpzxTotalDataTypeId);
}
if (objzx_TotalDataStatisticsCond.IsUpdated(conzx_TotalDataStatistics.TableKey) == true)
{
string strComparisonOpTableKey = objzx_TotalDataStatisticsCond.dicFldComparisonOp[conzx_TotalDataStatistics.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TotalDataStatistics.TableKey, objzx_TotalDataStatisticsCond.TableKey, strComparisonOpTableKey);
}
if (objzx_TotalDataStatisticsCond.IsUpdated(conzx_TotalDataStatistics.DataUser) == true)
{
string strComparisonOpDataUser = objzx_TotalDataStatisticsCond.dicFldComparisonOp[conzx_TotalDataStatistics.DataUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TotalDataStatistics.DataUser, objzx_TotalDataStatisticsCond.DataUser, strComparisonOpDataUser);
}
if (objzx_TotalDataStatisticsCond.IsUpdated(conzx_TotalDataStatistics.DataAddDate) == true)
{
string strComparisonOpDataAddDate = objzx_TotalDataStatisticsCond.dicFldComparisonOp[conzx_TotalDataStatistics.DataAddDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TotalDataStatistics.DataAddDate, objzx_TotalDataStatisticsCond.DataAddDate, strComparisonOpDataAddDate);
}
if (objzx_TotalDataStatisticsCond.IsUpdated(conzx_TotalDataStatistics.Month) == true)
{
string strComparisonOpMonth = objzx_TotalDataStatisticsCond.dicFldComparisonOp[conzx_TotalDataStatistics.Month];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TotalDataStatistics.Month, objzx_TotalDataStatisticsCond.Month, strComparisonOpMonth);
}
if (objzx_TotalDataStatisticsCond.IsUpdated(conzx_TotalDataStatistics.Week) == true)
{
string strComparisonOpWeek = objzx_TotalDataStatisticsCond.dicFldComparisonOp[conzx_TotalDataStatistics.Week];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TotalDataStatistics.Week, objzx_TotalDataStatisticsCond.Week, strComparisonOpWeek);
}
if (objzx_TotalDataStatisticsCond.IsUpdated(conzx_TotalDataStatistics.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_TotalDataStatisticsCond.dicFldComparisonOp[conzx_TotalDataStatistics.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TotalDataStatistics.UpdDate, objzx_TotalDataStatisticsCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_TotalDataStatisticsCond.IsUpdated(conzx_TotalDataStatistics.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_TotalDataStatisticsCond.dicFldComparisonOp[conzx_TotalDataStatistics.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TotalDataStatistics.UpdUser, objzx_TotalDataStatisticsCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_TotalDataStatisticsCond.IsUpdated(conzx_TotalDataStatistics.Memo) == true)
{
string strComparisonOpMemo = objzx_TotalDataStatisticsCond.dicFldComparisonOp[conzx_TotalDataStatistics.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TotalDataStatistics.Memo, objzx_TotalDataStatisticsCond.Memo, strComparisonOpMemo);
}
if (objzx_TotalDataStatisticsCond.IsUpdated(conzx_TotalDataStatistics.Score) == true)
{
string strComparisonOpScore = objzx_TotalDataStatisticsCond.dicFldComparisonOp[conzx_TotalDataStatistics.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TotalDataStatistics.Score, objzx_TotalDataStatisticsCond.Score, strComparisonOpScore);
}
if (objzx_TotalDataStatisticsCond.IsUpdated(conzx_TotalDataStatistics.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_TotalDataStatisticsCond.dicFldComparisonOp[conzx_TotalDataStatistics.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TotalDataStatistics.TeaScore, objzx_TotalDataStatisticsCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_TotalDataStatisticsCond.IsUpdated(conzx_TotalDataStatistics.WeekTimeRange) == true)
{
string strComparisonOpWeekTimeRange = objzx_TotalDataStatisticsCond.dicFldComparisonOp[conzx_TotalDataStatistics.WeekTimeRange];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TotalDataStatistics.WeekTimeRange, objzx_TotalDataStatisticsCond.WeekTimeRange, strComparisonOpWeekTimeRange);
}
if (objzx_TotalDataStatisticsCond.IsUpdated(conzx_TotalDataStatistics.StuScore) == true)
{
string strComparisonOpStuScore = objzx_TotalDataStatisticsCond.dicFldComparisonOp[conzx_TotalDataStatistics.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TotalDataStatistics.StuScore, objzx_TotalDataStatisticsCond.StuScore, strComparisonOpStuScore);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_TotalDataStatistics
{
public virtual bool UpdRelaTabDate(string strTotalDataId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学总数据统计(zx_TotalDataStatistics)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_TotalDataStatisticsBL
{
public static RelatedActions_zx_TotalDataStatistics relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_TotalDataStatisticsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_TotalDataStatisticsDA zx_TotalDataStatisticsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_TotalDataStatisticsDA();
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
 public clszx_TotalDataStatisticsBL()
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
if (string.IsNullOrEmpty(clszx_TotalDataStatisticsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TotalDataStatisticsEN._ConnectString);
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
public static DataTable GetDataTable_zx_TotalDataStatistics(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_TotalDataStatisticsDA.GetDataTable_zx_TotalDataStatistics(strWhereCond);
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
objDT = zx_TotalDataStatisticsDA.GetDataTable(strWhereCond);
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
objDT = zx_TotalDataStatisticsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_TotalDataStatisticsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_TotalDataStatisticsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_TotalDataStatisticsDA.GetDataTable_Top(objTopPara);
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
objDT = zx_TotalDataStatisticsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_TotalDataStatisticsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_TotalDataStatisticsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTotalDataIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_TotalDataStatisticsEN> GetObjLstByTotalDataIdLst(List<string> arrTotalDataIdLst)
{
List<clszx_TotalDataStatisticsEN> arrObjLst = new List<clszx_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTotalDataIdLst, true);
 string strWhereCond = string.Format("TotalDataId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN();
try
{
objzx_TotalDataStatisticsEN.TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objzx_TotalDataStatisticsEN.TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objzx_TotalDataStatisticsEN.DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objzx_TotalDataStatisticsEN.DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objzx_TotalDataStatisticsEN.Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()); //月
objzx_TotalDataStatisticsEN.Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()); //周
objzx_TotalDataStatisticsEN.UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objzx_TotalDataStatisticsEN.UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objzx_TotalDataStatisticsEN.Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objzx_TotalDataStatisticsEN.Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objzx_TotalDataStatisticsEN.TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objzx_TotalDataStatisticsEN.WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_TotalDataStatisticsEN.StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TotalDataStatisticsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTotalDataIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_TotalDataStatisticsEN> GetObjLstByTotalDataIdLstCache(List<string> arrTotalDataIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clszx_TotalDataStatisticsEN._CurrTabName, strIdCurrEduCls);
List<clszx_TotalDataStatisticsEN> arrzx_TotalDataStatisticsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TotalDataStatisticsEN> arrzx_TotalDataStatisticsObjLst_Sel =
arrzx_TotalDataStatisticsObjLstCache
.Where(x => arrTotalDataIdLst.Contains(x.TotalDataId));
return arrzx_TotalDataStatisticsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TotalDataStatisticsEN> GetObjLst(string strWhereCond)
{
List<clszx_TotalDataStatisticsEN> arrObjLst = new List<clszx_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN();
try
{
objzx_TotalDataStatisticsEN.TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objzx_TotalDataStatisticsEN.TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objzx_TotalDataStatisticsEN.DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objzx_TotalDataStatisticsEN.DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objzx_TotalDataStatisticsEN.Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()); //月
objzx_TotalDataStatisticsEN.Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()); //周
objzx_TotalDataStatisticsEN.UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objzx_TotalDataStatisticsEN.UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objzx_TotalDataStatisticsEN.Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objzx_TotalDataStatisticsEN.Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objzx_TotalDataStatisticsEN.TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objzx_TotalDataStatisticsEN.WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_TotalDataStatisticsEN.StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TotalDataStatisticsEN);
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
public static List<clszx_TotalDataStatisticsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_TotalDataStatisticsEN> arrObjLst = new List<clszx_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN();
try
{
objzx_TotalDataStatisticsEN.TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objzx_TotalDataStatisticsEN.TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objzx_TotalDataStatisticsEN.DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objzx_TotalDataStatisticsEN.DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objzx_TotalDataStatisticsEN.Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()); //月
objzx_TotalDataStatisticsEN.Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()); //周
objzx_TotalDataStatisticsEN.UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objzx_TotalDataStatisticsEN.UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objzx_TotalDataStatisticsEN.Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objzx_TotalDataStatisticsEN.Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objzx_TotalDataStatisticsEN.TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objzx_TotalDataStatisticsEN.WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_TotalDataStatisticsEN.StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TotalDataStatisticsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_TotalDataStatisticsEN> GetSubObjLstCache(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsCond)
{
 string strIdCurrEduCls = objzx_TotalDataStatisticsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clszx_TotalDataStatisticsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clszx_TotalDataStatisticsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TotalDataStatisticsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TotalDataStatistics.AttributeName)
{
if (objzx_TotalDataStatisticsCond.IsUpdated(strFldName) == false) continue;
if (objzx_TotalDataStatisticsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TotalDataStatisticsCond[strFldName].ToString());
}
else
{
if (objzx_TotalDataStatisticsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TotalDataStatisticsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TotalDataStatisticsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TotalDataStatisticsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TotalDataStatisticsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TotalDataStatisticsCond[strFldName]));
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
public static List<clszx_TotalDataStatisticsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_TotalDataStatisticsEN> arrObjLst = new List<clszx_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN();
try
{
objzx_TotalDataStatisticsEN.TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objzx_TotalDataStatisticsEN.TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objzx_TotalDataStatisticsEN.DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objzx_TotalDataStatisticsEN.DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objzx_TotalDataStatisticsEN.Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()); //月
objzx_TotalDataStatisticsEN.Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()); //周
objzx_TotalDataStatisticsEN.UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objzx_TotalDataStatisticsEN.UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objzx_TotalDataStatisticsEN.Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objzx_TotalDataStatisticsEN.Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objzx_TotalDataStatisticsEN.TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objzx_TotalDataStatisticsEN.WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_TotalDataStatisticsEN.StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TotalDataStatisticsEN);
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
public static List<clszx_TotalDataStatisticsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_TotalDataStatisticsEN> arrObjLst = new List<clszx_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN();
try
{
objzx_TotalDataStatisticsEN.TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objzx_TotalDataStatisticsEN.TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objzx_TotalDataStatisticsEN.DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objzx_TotalDataStatisticsEN.DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objzx_TotalDataStatisticsEN.Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()); //月
objzx_TotalDataStatisticsEN.Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()); //周
objzx_TotalDataStatisticsEN.UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objzx_TotalDataStatisticsEN.UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objzx_TotalDataStatisticsEN.Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objzx_TotalDataStatisticsEN.Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objzx_TotalDataStatisticsEN.TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objzx_TotalDataStatisticsEN.WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_TotalDataStatisticsEN.StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TotalDataStatisticsEN);
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
List<clszx_TotalDataStatisticsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_TotalDataStatisticsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TotalDataStatisticsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_TotalDataStatisticsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_TotalDataStatisticsEN> arrObjLst = new List<clszx_TotalDataStatisticsEN>(); 
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
	clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN();
try
{
objzx_TotalDataStatisticsEN.TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objzx_TotalDataStatisticsEN.TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objzx_TotalDataStatisticsEN.DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objzx_TotalDataStatisticsEN.DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objzx_TotalDataStatisticsEN.Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()); //月
objzx_TotalDataStatisticsEN.Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()); //周
objzx_TotalDataStatisticsEN.UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objzx_TotalDataStatisticsEN.UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objzx_TotalDataStatisticsEN.Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objzx_TotalDataStatisticsEN.Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objzx_TotalDataStatisticsEN.TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objzx_TotalDataStatisticsEN.WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_TotalDataStatisticsEN.StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TotalDataStatisticsEN);
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
public static List<clszx_TotalDataStatisticsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_TotalDataStatisticsEN> arrObjLst = new List<clszx_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN();
try
{
objzx_TotalDataStatisticsEN.TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objzx_TotalDataStatisticsEN.TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objzx_TotalDataStatisticsEN.DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objzx_TotalDataStatisticsEN.DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objzx_TotalDataStatisticsEN.Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()); //月
objzx_TotalDataStatisticsEN.Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()); //周
objzx_TotalDataStatisticsEN.UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objzx_TotalDataStatisticsEN.UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objzx_TotalDataStatisticsEN.Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objzx_TotalDataStatisticsEN.Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objzx_TotalDataStatisticsEN.TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objzx_TotalDataStatisticsEN.WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_TotalDataStatisticsEN.StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TotalDataStatisticsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_TotalDataStatisticsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_TotalDataStatisticsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_TotalDataStatisticsEN> arrObjLst = new List<clszx_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN();
try
{
objzx_TotalDataStatisticsEN.TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objzx_TotalDataStatisticsEN.TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objzx_TotalDataStatisticsEN.DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objzx_TotalDataStatisticsEN.DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objzx_TotalDataStatisticsEN.Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()); //月
objzx_TotalDataStatisticsEN.Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()); //周
objzx_TotalDataStatisticsEN.UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objzx_TotalDataStatisticsEN.UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objzx_TotalDataStatisticsEN.Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objzx_TotalDataStatisticsEN.Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objzx_TotalDataStatisticsEN.TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objzx_TotalDataStatisticsEN.WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_TotalDataStatisticsEN.StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TotalDataStatisticsEN);
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
public static List<clszx_TotalDataStatisticsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_TotalDataStatisticsEN> arrObjLst = new List<clszx_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN();
try
{
objzx_TotalDataStatisticsEN.TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objzx_TotalDataStatisticsEN.TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objzx_TotalDataStatisticsEN.DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objzx_TotalDataStatisticsEN.DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objzx_TotalDataStatisticsEN.Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()); //月
objzx_TotalDataStatisticsEN.Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()); //周
objzx_TotalDataStatisticsEN.UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objzx_TotalDataStatisticsEN.UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objzx_TotalDataStatisticsEN.Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objzx_TotalDataStatisticsEN.Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objzx_TotalDataStatisticsEN.TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objzx_TotalDataStatisticsEN.WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_TotalDataStatisticsEN.StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TotalDataStatisticsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TotalDataStatisticsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_TotalDataStatisticsEN> arrObjLst = new List<clszx_TotalDataStatisticsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN();
try
{
objzx_TotalDataStatisticsEN.TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objzx_TotalDataStatisticsEN.TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objzx_TotalDataStatisticsEN.DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objzx_TotalDataStatisticsEN.DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objzx_TotalDataStatisticsEN.Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()); //月
objzx_TotalDataStatisticsEN.Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()); //周
objzx_TotalDataStatisticsEN.UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objzx_TotalDataStatisticsEN.UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objzx_TotalDataStatisticsEN.Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objzx_TotalDataStatisticsEN.Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objzx_TotalDataStatisticsEN.TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objzx_TotalDataStatisticsEN.WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_TotalDataStatisticsEN.StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TotalDataStatisticsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_TotalDataStatistics(ref clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
bool bolResult = zx_TotalDataStatisticsDA.Getzx_TotalDataStatistics(ref objzx_TotalDataStatisticsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTotalDataId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TotalDataStatisticsEN GetObjByTotalDataId(string strTotalDataId)
{
if (strTotalDataId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTotalDataId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTotalDataId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTotalDataId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = zx_TotalDataStatisticsDA.GetObjByTotalDataId(strTotalDataId);
return objzx_TotalDataStatisticsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_TotalDataStatisticsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = zx_TotalDataStatisticsDA.GetFirstObj(strWhereCond);
 return objzx_TotalDataStatisticsEN;
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
public static clszx_TotalDataStatisticsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = zx_TotalDataStatisticsDA.GetObjByDataRow(objRow);
 return objzx_TotalDataStatisticsEN;
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
public static clszx_TotalDataStatisticsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = zx_TotalDataStatisticsDA.GetObjByDataRow(objRow);
 return objzx_TotalDataStatisticsEN;
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
 /// <param name = "strTotalDataId">所给的关键字</param>
 /// <param name = "lstzx_TotalDataStatisticsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TotalDataStatisticsEN GetObjByTotalDataIdFromList(string strTotalDataId, List<clszx_TotalDataStatisticsEN> lstzx_TotalDataStatisticsObjLst)
{
foreach (clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN in lstzx_TotalDataStatisticsObjLst)
{
if (objzx_TotalDataStatisticsEN.TotalDataId == strTotalDataId)
{
return objzx_TotalDataStatisticsEN;
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
 string strTotalDataId;
 try
 {
 strTotalDataId = new clszx_TotalDataStatisticsDA().GetFirstID(strWhereCond);
 return strTotalDataId;
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
 arrList = zx_TotalDataStatisticsDA.GetID(strWhereCond);
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
bool bolIsExist = zx_TotalDataStatisticsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTotalDataId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTotalDataId)
{
if (string.IsNullOrEmpty(strTotalDataId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTotalDataId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_TotalDataStatisticsDA.IsExist(strTotalDataId);
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
 bolIsExist = clszx_TotalDataStatisticsDA.IsExistTable();
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
 bolIsExist = zx_TotalDataStatisticsDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
 if (string.IsNullOrEmpty(objzx_TotalDataStatisticsEN.TotalDataId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_TotalDataStatisticsBL.IsExist(objzx_TotalDataStatisticsEN.TotalDataId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_TotalDataStatisticsEN.TotalDataId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = zx_TotalDataStatisticsDA.AddNewRecordBySQL2(objzx_TotalDataStatisticsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TotalDataStatisticsBL.ReFreshCache(objzx_TotalDataStatisticsEN.IdCurrEduCls);

if (clszx_TotalDataStatisticsBL.relatedActions != null)
{
clszx_TotalDataStatisticsBL.relatedActions.UpdRelaTabDate(objzx_TotalDataStatisticsEN.TotalDataId, "SetUpdDate");
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
 if (string.IsNullOrEmpty(objzx_TotalDataStatisticsEN.TotalDataId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_TotalDataStatisticsBL.IsExist(objzx_TotalDataStatisticsEN.TotalDataId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_TotalDataStatisticsEN.TotalDataId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = zx_TotalDataStatisticsDA.AddNewRecordBySQL2WithReturnKey(objzx_TotalDataStatisticsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TotalDataStatisticsBL.ReFreshCache(objzx_TotalDataStatisticsEN.IdCurrEduCls);

if (clszx_TotalDataStatisticsBL.relatedActions != null)
{
clszx_TotalDataStatisticsBL.relatedActions.UpdRelaTabDate(objzx_TotalDataStatisticsEN.TotalDataId, "SetUpdDate");
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
try
{
bool bolResult = zx_TotalDataStatisticsDA.Update(objzx_TotalDataStatisticsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TotalDataStatisticsBL.ReFreshCache(objzx_TotalDataStatisticsEN.IdCurrEduCls);

if (clszx_TotalDataStatisticsBL.relatedActions != null)
{
clszx_TotalDataStatisticsBL.relatedActions.UpdRelaTabDate(objzx_TotalDataStatisticsEN.TotalDataId, "SetUpdDate");
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
 if (string.IsNullOrEmpty(objzx_TotalDataStatisticsEN.TotalDataId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_TotalDataStatisticsDA.UpdateBySql2(objzx_TotalDataStatisticsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TotalDataStatisticsBL.ReFreshCache(objzx_TotalDataStatisticsEN.IdCurrEduCls);

if (clszx_TotalDataStatisticsBL.relatedActions != null)
{
clszx_TotalDataStatisticsBL.relatedActions.UpdRelaTabDate(objzx_TotalDataStatisticsEN.TotalDataId, "SetUpdDate");
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
 /// <param name = "strTotalDataId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTotalDataId)
{
try
{
 clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = clszx_TotalDataStatisticsBL.GetObjByTotalDataId(strTotalDataId);

if (clszx_TotalDataStatisticsBL.relatedActions != null)
{
clszx_TotalDataStatisticsBL.relatedActions.UpdRelaTabDate(objzx_TotalDataStatisticsEN.TotalDataId, "SetUpdDate");
}
if (objzx_TotalDataStatisticsEN != null)
{
int intRecNum = zx_TotalDataStatisticsDA.DelRecord(strTotalDataId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_TotalDataStatisticsEN.IdCurrEduCls);
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
/// <param name="strTotalDataId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strTotalDataId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
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
//删除与表:[zx_TotalDataStatistics]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_TotalDataStatistics.TotalDataId,
//strTotalDataId);
//        clszx_TotalDataStatisticsBL.Delzx_TotalDataStatisticssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TotalDataStatisticsBL.DelRecord(strTotalDataId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TotalDataStatisticsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTotalDataId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strTotalDataId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTotalDataId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_TotalDataStatisticsBL.relatedActions != null)
{
clszx_TotalDataStatisticsBL.relatedActions.UpdRelaTabDate(strTotalDataId, "UpdRelaTabDate");
}
bool bolResult = zx_TotalDataStatisticsDA.DelRecord(strTotalDataId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strIdCurrEduCls);
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
 /// <param name = "arrTotalDataIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_TotalDataStatisticss(List<string> arrTotalDataIdLst)
{
if (arrTotalDataIdLst.Count == 0) return 0;
try
{
if (clszx_TotalDataStatisticsBL.relatedActions != null)
{
foreach (var strTotalDataId in arrTotalDataIdLst)
{
clszx_TotalDataStatisticsBL.relatedActions.UpdRelaTabDate(strTotalDataId, "UpdRelaTabDate");
}
}
 clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = clszx_TotalDataStatisticsBL.GetObjByTotalDataId(arrTotalDataIdLst[0]);
int intDelRecNum = zx_TotalDataStatisticsDA.Delzx_TotalDataStatistics(arrTotalDataIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_TotalDataStatisticsEN.IdCurrEduCls);
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
public static int Delzx_TotalDataStatisticssByCond(string strWhereCond)
{
try
{
if (clszx_TotalDataStatisticsBL.relatedActions != null)
{
List<string> arrTotalDataId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTotalDataId in arrTotalDataId)
{
clszx_TotalDataStatisticsBL.relatedActions.UpdRelaTabDate(strTotalDataId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conzx_TotalDataStatistics.IdCurrEduCls, strWhereCond);
int intRecNum = zx_TotalDataStatisticsDA.Delzx_TotalDataStatistics(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrIdCurrEduCls.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_TotalDataStatistics]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTotalDataId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTotalDataId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
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
//删除与表:[zx_TotalDataStatistics]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TotalDataStatisticsBL.DelRecord(strTotalDataId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TotalDataStatisticsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTotalDataId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_TotalDataStatisticsENS">源对象</param>
 /// <param name = "objzx_TotalDataStatisticsENT">目标对象</param>
 public static void CopyTo(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsENS, clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsENT)
{
try
{
objzx_TotalDataStatisticsENT.TotalDataId = objzx_TotalDataStatisticsENS.TotalDataId; //TotalDataId
objzx_TotalDataStatisticsENT.IdCurrEduCls = objzx_TotalDataStatisticsENS.IdCurrEduCls; //教学班流水号
objzx_TotalDataStatisticsENT.zxTotalDataTypeId = objzx_TotalDataStatisticsENS.zxTotalDataTypeId; //总数据类型Id
objzx_TotalDataStatisticsENT.TableKey = objzx_TotalDataStatisticsENS.TableKey; //表主键
objzx_TotalDataStatisticsENT.DataUser = objzx_TotalDataStatisticsENS.DataUser; //数据用户
objzx_TotalDataStatisticsENT.DataAddDate = objzx_TotalDataStatisticsENS.DataAddDate; //数据添加日期
objzx_TotalDataStatisticsENT.Month = objzx_TotalDataStatisticsENS.Month; //月
objzx_TotalDataStatisticsENT.Week = objzx_TotalDataStatisticsENS.Week; //周
objzx_TotalDataStatisticsENT.UpdDate = objzx_TotalDataStatisticsENS.UpdDate; //修改日期
objzx_TotalDataStatisticsENT.UpdUser = objzx_TotalDataStatisticsENS.UpdUser; //修改人
objzx_TotalDataStatisticsENT.Memo = objzx_TotalDataStatisticsENS.Memo; //备注
objzx_TotalDataStatisticsENT.Score = objzx_TotalDataStatisticsENS.Score; //评分
objzx_TotalDataStatisticsENT.TeaScore = objzx_TotalDataStatisticsENS.TeaScore; //教师评分
objzx_TotalDataStatisticsENT.WeekTimeRange = objzx_TotalDataStatisticsENS.WeekTimeRange; //WeekTimeRange
objzx_TotalDataStatisticsENT.StuScore = objzx_TotalDataStatisticsENS.StuScore; //学生平均分
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
 /// <param name = "objzx_TotalDataStatisticsEN">源简化对象</param>
 public static void SetUpdFlag(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
try
{
objzx_TotalDataStatisticsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_TotalDataStatisticsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_TotalDataStatistics.TotalDataId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TotalDataStatisticsEN.TotalDataId = objzx_TotalDataStatisticsEN.TotalDataId; //TotalDataId
}
if (arrFldSet.Contains(conzx_TotalDataStatistics.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TotalDataStatisticsEN.IdCurrEduCls = objzx_TotalDataStatisticsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_TotalDataStatistics.zxTotalDataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objzx_TotalDataStatisticsEN.zxTotalDataTypeId; //总数据类型Id
}
if (arrFldSet.Contains(conzx_TotalDataStatistics.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TotalDataStatisticsEN.TableKey = objzx_TotalDataStatisticsEN.TableKey == "[null]" ? null :  objzx_TotalDataStatisticsEN.TableKey; //表主键
}
if (arrFldSet.Contains(conzx_TotalDataStatistics.DataUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TotalDataStatisticsEN.DataUser = objzx_TotalDataStatisticsEN.DataUser == "[null]" ? null :  objzx_TotalDataStatisticsEN.DataUser; //数据用户
}
if (arrFldSet.Contains(conzx_TotalDataStatistics.DataAddDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TotalDataStatisticsEN.DataAddDate = objzx_TotalDataStatisticsEN.DataAddDate == "[null]" ? null :  objzx_TotalDataStatisticsEN.DataAddDate; //数据添加日期
}
if (arrFldSet.Contains(conzx_TotalDataStatistics.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TotalDataStatisticsEN.Month = objzx_TotalDataStatisticsEN.Month; //月
}
if (arrFldSet.Contains(conzx_TotalDataStatistics.Week, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TotalDataStatisticsEN.Week = objzx_TotalDataStatisticsEN.Week; //周
}
if (arrFldSet.Contains(conzx_TotalDataStatistics.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TotalDataStatisticsEN.UpdDate = objzx_TotalDataStatisticsEN.UpdDate == "[null]" ? null :  objzx_TotalDataStatisticsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_TotalDataStatistics.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TotalDataStatisticsEN.UpdUser = objzx_TotalDataStatisticsEN.UpdUser == "[null]" ? null :  objzx_TotalDataStatisticsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_TotalDataStatistics.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TotalDataStatisticsEN.Memo = objzx_TotalDataStatisticsEN.Memo == "[null]" ? null :  objzx_TotalDataStatisticsEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_TotalDataStatistics.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TotalDataStatisticsEN.Score = objzx_TotalDataStatisticsEN.Score; //评分
}
if (arrFldSet.Contains(conzx_TotalDataStatistics.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TotalDataStatisticsEN.TeaScore = objzx_TotalDataStatisticsEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_TotalDataStatistics.WeekTimeRange, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TotalDataStatisticsEN.WeekTimeRange = objzx_TotalDataStatisticsEN.WeekTimeRange == "[null]" ? null :  objzx_TotalDataStatisticsEN.WeekTimeRange; //WeekTimeRange
}
if (arrFldSet.Contains(conzx_TotalDataStatistics.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TotalDataStatisticsEN.StuScore = objzx_TotalDataStatisticsEN.StuScore; //学生平均分
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
 /// <param name = "objzx_TotalDataStatisticsEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
try
{
if (objzx_TotalDataStatisticsEN.TableKey == "[null]") objzx_TotalDataStatisticsEN.TableKey = null; //表主键
if (objzx_TotalDataStatisticsEN.DataUser == "[null]") objzx_TotalDataStatisticsEN.DataUser = null; //数据用户
if (objzx_TotalDataStatisticsEN.DataAddDate == "[null]") objzx_TotalDataStatisticsEN.DataAddDate = null; //数据添加日期
if (objzx_TotalDataStatisticsEN.UpdDate == "[null]") objzx_TotalDataStatisticsEN.UpdDate = null; //修改日期
if (objzx_TotalDataStatisticsEN.UpdUser == "[null]") objzx_TotalDataStatisticsEN.UpdUser = null; //修改人
if (objzx_TotalDataStatisticsEN.Memo == "[null]") objzx_TotalDataStatisticsEN.Memo = null; //备注
if (objzx_TotalDataStatisticsEN.WeekTimeRange == "[null]") objzx_TotalDataStatisticsEN.WeekTimeRange = null; //WeekTimeRange
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
public static void CheckPropertyNew(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
 zx_TotalDataStatisticsDA.CheckPropertyNew(objzx_TotalDataStatisticsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
 zx_TotalDataStatisticsDA.CheckProperty4Condition(objzx_TotalDataStatisticsEN);
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
if (clszx_TotalDataStatisticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TotalDataStatisticsBL没有刷新缓存机制(clszx_TotalDataStatisticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TotalDataId");
//if (arrzx_TotalDataStatisticsObjLstCache == null)
//{
//arrzx_TotalDataStatisticsObjLstCache = zx_TotalDataStatisticsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTotalDataId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TotalDataStatisticsEN GetObjByTotalDataIdCache(string strTotalDataId, string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clszx_TotalDataStatisticsEN._CurrTabName, strIdCurrEduCls);
List<clszx_TotalDataStatisticsEN> arrzx_TotalDataStatisticsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TotalDataStatisticsEN> arrzx_TotalDataStatisticsObjLst_Sel =
arrzx_TotalDataStatisticsObjLstCache
.Where(x=> x.TotalDataId == strTotalDataId 
);
if (arrzx_TotalDataStatisticsObjLst_Sel.Count() == 0)
{
   clszx_TotalDataStatisticsEN obj = clszx_TotalDataStatisticsBL.GetObjByTotalDataId(strTotalDataId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTotalDataId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrzx_TotalDataStatisticsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TotalDataStatisticsEN> GetAllzx_TotalDataStatisticsObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clszx_TotalDataStatisticsEN> arrzx_TotalDataStatisticsObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrzx_TotalDataStatisticsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TotalDataStatisticsEN> GetObjLstCache(string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clszx_TotalDataStatisticsEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clszx_TotalDataStatisticsEN> arrzx_TotalDataStatisticsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrzx_TotalDataStatisticsObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strIdCurrEduCls = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clszx_TotalDataStatisticsEN._CurrTabName, strIdCurrEduCls);
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
public static void ReFreshCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("缓存分类字段:[IdCurrEduCls]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_TotalDataStatisticsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clszx_TotalDataStatisticsEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clszx_TotalDataStatisticsBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-11-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTotalDataId, string strIdCurrEduCls)
{
if (strInFldName != conzx_TotalDataStatistics.TotalDataId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_TotalDataStatistics.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_TotalDataStatistics.AttributeName));
throw new Exception(strMsg);
}
var objzx_TotalDataStatistics = clszx_TotalDataStatisticsBL.GetObjByTotalDataIdCache(strTotalDataId, strIdCurrEduCls);
if (objzx_TotalDataStatistics == null) return "";
return objzx_TotalDataStatistics[strOutFldName].ToString();
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
int intRecCount = clszx_TotalDataStatisticsDA.GetRecCount(strTabName);
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
int intRecCount = clszx_TotalDataStatisticsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_TotalDataStatisticsDA.GetRecCount();
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
int intRecCount = clszx_TotalDataStatisticsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsCond)
{
 string strIdCurrEduCls = objzx_TotalDataStatisticsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clszx_TotalDataStatisticsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clszx_TotalDataStatisticsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TotalDataStatisticsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TotalDataStatistics.AttributeName)
{
if (objzx_TotalDataStatisticsCond.IsUpdated(strFldName) == false) continue;
if (objzx_TotalDataStatisticsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TotalDataStatisticsCond[strFldName].ToString());
}
else
{
if (objzx_TotalDataStatisticsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TotalDataStatisticsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TotalDataStatisticsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TotalDataStatisticsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TotalDataStatisticsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TotalDataStatisticsCond[strFldName]));
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
 List<string> arrList = clszx_TotalDataStatisticsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_TotalDataStatisticsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_TotalDataStatisticsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_TotalDataStatisticsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TotalDataStatisticsDA.SetFldValue(clszx_TotalDataStatisticsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_TotalDataStatisticsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TotalDataStatisticsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TotalDataStatisticsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TotalDataStatisticsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_TotalDataStatistics] "); 
 strCreateTabCode.Append(" ( "); 
 // /**TotalDataId*/ 
 strCreateTabCode.Append(" TotalDataId char(12) primary key, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) not Null, "); 
 // /**总数据类型Id*/ 
 strCreateTabCode.Append(" zxTotalDataTypeId char(2) not Null, "); 
 // /**表主键*/ 
 strCreateTabCode.Append(" TableKey varchar(20) Null, "); 
 // /**数据用户*/ 
 strCreateTabCode.Append(" DataUser varchar(20) Null, "); 
 // /**数据添加日期*/ 
 strCreateTabCode.Append(" DataAddDate varchar(20) Null, "); 
 // /**月*/ 
 strCreateTabCode.Append(" Month int Null, "); 
 // /**周*/ 
 strCreateTabCode.Append(" Week int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
 // /**WeekTimeRange*/ 
 strCreateTabCode.Append(" WeekTimeRange varchar(100) Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 中学总数据统计(zx_TotalDataStatistics)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_TotalDataStatistics : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strIdCurrEduCls)
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
clszx_TotalDataStatisticsBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}