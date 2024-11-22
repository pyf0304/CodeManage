﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzSchoolBL
 表名:XzSchool(01120029)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:58:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
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
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clsXzSchoolBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSchool">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzSchoolEN GetObj(this K_IdSchool_XzSchool myKey)
{
clsXzSchoolEN objXzSchoolEN = clsXzSchoolBL.XzSchoolDA.GetObjByIdSchool(myKey.Value);
return objXzSchoolEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzSchoolEN objXzSchoolEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objXzSchoolEN.IdSchool) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzSchoolBL.IsExist(objXzSchoolEN.IdSchool) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzSchoolEN.IdSchool, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsXzSchoolBL.XzSchoolDA.AddNewRecordBySQL2(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolBL.ReFreshCache();

if (clsXzSchoolBL.relatedActions != null)
{
clsXzSchoolBL.relatedActions.UpdRelaTabDate(objXzSchoolEN.IdSchool, objXzSchoolEN.UpdUserId);
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
public static bool AddRecordEx(this clsXzSchoolEN objXzSchoolEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsXzSchoolBL.IsExist(objXzSchoolEN.IdSchool))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objXzSchoolEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objXzSchoolEN.AddNewRecord();
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsXzSchoolEN objXzSchoolEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objXzSchoolEN.IdSchool) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzSchoolBL.IsExist(objXzSchoolEN.IdSchool) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzSchoolEN.IdSchool, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsXzSchoolBL.XzSchoolDA.AddNewRecordBySQL2WithReturnKey(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolBL.ReFreshCache();

if (clsXzSchoolBL.relatedActions != null)
{
clsXzSchoolBL.relatedActions.UpdRelaTabDate(objXzSchoolEN.IdSchool, objXzSchoolEN.UpdUserId);
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
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetIdSchool(this clsXzSchoolEN objXzSchoolEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, conXzSchool.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, conXzSchool.IdSchool);
}
objXzSchoolEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.IdSchool) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.IdSchool, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.IdSchool] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetSchoolId(this clsXzSchoolEN objXzSchoolEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, conXzSchool.SchoolId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, conXzSchool.SchoolId);
}
objXzSchoolEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.SchoolId) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.SchoolId, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.SchoolId] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetSchoolName(this clsXzSchoolEN objXzSchoolEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, conXzSchool.SchoolName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolName, 50, conXzSchool.SchoolName);
}
objXzSchoolEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.SchoolName) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.SchoolName, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.SchoolName] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetSchoolENName(this clsXzSchoolEN objXzSchoolEN, string strSchoolENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolENName, 50, conXzSchool.SchoolENName);
}
objXzSchoolEN.SchoolENName = strSchoolENName; //SchoolENName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.SchoolENName) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.SchoolENName, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.SchoolENName] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetSchoolNameA(this clsXzSchoolEN objXzSchoolEN, string strSchoolNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolNameA, 14, conXzSchool.SchoolNameA);
}
objXzSchoolEN.SchoolNameA = strSchoolNameA; //学校简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.SchoolNameA) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.SchoolNameA, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.SchoolNameA] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetSchoolTypeId(this clsXzSchoolEN objXzSchoolEN, string strSchoolTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTypeId, 2, conXzSchool.SchoolTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTypeId, 2, conXzSchool.SchoolTypeId);
}
objXzSchoolEN.SchoolTypeId = strSchoolTypeId; //学校类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.SchoolTypeId) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.SchoolTypeId, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.SchoolTypeId] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetIsCurrentUse(this clsXzSchoolEN objXzSchoolEN, bool bolIsCurrentUse, string strComparisonOp="")
	{
objXzSchoolEN.IsCurrentUse = bolIsCurrentUse; //是否当前使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.IsCurrentUse) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.IsCurrentUse, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.IsCurrentUse] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetUpdDate(this clsXzSchoolEN objXzSchoolEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conXzSchool.UpdDate);
}
objXzSchoolEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.UpdDate) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.UpdDate, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.UpdDate] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetUpdUserId(this clsXzSchoolEN objXzSchoolEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conXzSchool.UpdUserId);
}
objXzSchoolEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.UpdUserId) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.UpdUserId, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.UpdUserId] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetMemo(this clsXzSchoolEN objXzSchoolEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzSchool.Memo);
}
objXzSchoolEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.Memo) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.Memo, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.Memo] = strComparisonOp;
}
}
return objXzSchoolEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsXzSchoolEN objXzSchoolEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objXzSchoolEN.CheckPropertyNew();
clsXzSchoolEN objXzSchoolCond = new clsXzSchoolEN();
string strCondition = objXzSchoolCond
.SetIdSchool(objXzSchoolEN.IdSchool, "=")
.GetCombineCondition();
objXzSchoolEN._IsCheckProperty = true;
bool bolIsExist = clsXzSchoolBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objXzSchoolEN.Update();
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzSchoolEN objXzSchoolEN)
{
 if (string.IsNullOrEmpty(objXzSchoolEN.IdSchool) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzSchoolBL.XzSchoolDA.UpdateBySql2(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolBL.ReFreshCache();

if (clsXzSchoolBL.relatedActions != null)
{
clsXzSchoolBL.relatedActions.UpdRelaTabDate(objXzSchoolEN.IdSchool, objXzSchoolEN.UpdUserId);
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzSchoolEN objXzSchoolEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objXzSchoolEN.IdSchool) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzSchoolBL.XzSchoolDA.UpdateBySql2(objXzSchoolEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolBL.ReFreshCache();

if (clsXzSchoolBL.relatedActions != null)
{
clsXzSchoolBL.relatedActions.UpdRelaTabDate(objXzSchoolEN.IdSchool, objXzSchoolEN.UpdUserId);
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
 /// <param name = "objXzSchoolEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzSchoolEN objXzSchoolEN, string strWhereCond)
{
try
{
bool bolResult = clsXzSchoolBL.XzSchoolDA.UpdateBySqlWithCondition(objXzSchoolEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolBL.ReFreshCache();

if (clsXzSchoolBL.relatedActions != null)
{
clsXzSchoolBL.relatedActions.UpdRelaTabDate(objXzSchoolEN.IdSchool, objXzSchoolEN.UpdUserId);
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
 /// <param name = "objXzSchoolEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzSchoolEN objXzSchoolEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsXzSchoolBL.XzSchoolDA.UpdateBySqlWithConditionTransaction(objXzSchoolEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolBL.ReFreshCache();

if (clsXzSchoolBL.relatedActions != null)
{
clsXzSchoolBL.relatedActions.UpdRelaTabDate(objXzSchoolEN.IdSchool, objXzSchoolEN.UpdUserId);
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
 /// <param name = "strIdSchool">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsXzSchoolEN objXzSchoolEN)
{
try
{
int intRecNum = clsXzSchoolBL.XzSchoolDA.DelRecord(objXzSchoolEN.IdSchool);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolBL.ReFreshCache();

if (clsXzSchoolBL.relatedActions != null)
{
clsXzSchoolBL.relatedActions.UpdRelaTabDate(objXzSchoolEN.IdSchool, objXzSchoolEN.UpdUserId);
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
 /// <param name = "objXzSchoolENS">源对象</param>
 /// <param name = "objXzSchoolENT">目标对象</param>
 public static void CopyTo(this clsXzSchoolEN objXzSchoolENS, clsXzSchoolEN objXzSchoolENT)
{
try
{
objXzSchoolENT.IdSchool = objXzSchoolENS.IdSchool; //学校流水号
objXzSchoolENT.SchoolId = objXzSchoolENS.SchoolId; //学校编号
objXzSchoolENT.SchoolName = objXzSchoolENS.SchoolName; //学校名称
objXzSchoolENT.SchoolENName = objXzSchoolENS.SchoolENName; //SchoolENName
objXzSchoolENT.SchoolNameA = objXzSchoolENS.SchoolNameA; //学校简称
objXzSchoolENT.SchoolTypeId = objXzSchoolENS.SchoolTypeId; //学校类型Id
objXzSchoolENT.IsCurrentUse = objXzSchoolENS.IsCurrentUse; //是否当前使用
objXzSchoolENT.UpdDate = objXzSchoolENS.UpdDate; //修改日期
objXzSchoolENT.UpdUserId = objXzSchoolENS.UpdUserId; //修改用户Id
objXzSchoolENT.Memo = objXzSchoolENS.Memo; //备注
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
 /// <param name = "objXzSchoolENS">源对象</param>
 /// <returns>目标对象=>clsXzSchoolEN:objXzSchoolENT</returns>
 public static clsXzSchoolEN CopyTo(this clsXzSchoolEN objXzSchoolENS)
{
try
{
 clsXzSchoolEN objXzSchoolENT = new clsXzSchoolEN()
{
IdSchool = objXzSchoolENS.IdSchool, //学校流水号
SchoolId = objXzSchoolENS.SchoolId, //学校编号
SchoolName = objXzSchoolENS.SchoolName, //学校名称
SchoolENName = objXzSchoolENS.SchoolENName, //SchoolENName
SchoolNameA = objXzSchoolENS.SchoolNameA, //学校简称
SchoolTypeId = objXzSchoolENS.SchoolTypeId, //学校类型Id
IsCurrentUse = objXzSchoolENS.IsCurrentUse, //是否当前使用
UpdDate = objXzSchoolENS.UpdDate, //修改日期
UpdUserId = objXzSchoolENS.UpdUserId, //修改用户Id
Memo = objXzSchoolENS.Memo, //备注
};
 return objXzSchoolENT;
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
public static void CheckPropertyNew(this clsXzSchoolEN objXzSchoolEN)
{
 clsXzSchoolBL.XzSchoolDA.CheckPropertyNew(objXzSchoolEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsXzSchoolEN objXzSchoolEN)
{
 clsXzSchoolBL.XzSchoolDA.CheckProperty4Condition(objXzSchoolEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzSchoolEN objXzSchoolCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzSchoolCond.IsUpdated(conXzSchool.IdSchool) == true)
{
string strComparisonOpIdSchool = objXzSchoolCond.dicFldComparisonOp[conXzSchool.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.IdSchool, objXzSchoolCond.IdSchool, strComparisonOpIdSchool);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.SchoolId) == true)
{
string strComparisonOpSchoolId = objXzSchoolCond.dicFldComparisonOp[conXzSchool.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.SchoolId, objXzSchoolCond.SchoolId, strComparisonOpSchoolId);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.SchoolName) == true)
{
string strComparisonOpSchoolName = objXzSchoolCond.dicFldComparisonOp[conXzSchool.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.SchoolName, objXzSchoolCond.SchoolName, strComparisonOpSchoolName);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.SchoolENName) == true)
{
string strComparisonOpSchoolENName = objXzSchoolCond.dicFldComparisonOp[conXzSchool.SchoolENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.SchoolENName, objXzSchoolCond.SchoolENName, strComparisonOpSchoolENName);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.SchoolNameA) == true)
{
string strComparisonOpSchoolNameA = objXzSchoolCond.dicFldComparisonOp[conXzSchool.SchoolNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.SchoolNameA, objXzSchoolCond.SchoolNameA, strComparisonOpSchoolNameA);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.SchoolTypeId) == true)
{
string strComparisonOpSchoolTypeId = objXzSchoolCond.dicFldComparisonOp[conXzSchool.SchoolTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.SchoolTypeId, objXzSchoolCond.SchoolTypeId, strComparisonOpSchoolTypeId);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.IsCurrentUse) == true)
{
if (objXzSchoolCond.IsCurrentUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzSchool.IsCurrentUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzSchool.IsCurrentUse);
}
}
if (objXzSchoolCond.IsUpdated(conXzSchool.UpdDate) == true)
{
string strComparisonOpUpdDate = objXzSchoolCond.dicFldComparisonOp[conXzSchool.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.UpdDate, objXzSchoolCond.UpdDate, strComparisonOpUpdDate);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objXzSchoolCond.dicFldComparisonOp[conXzSchool.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.UpdUserId, objXzSchoolCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.Memo) == true)
{
string strComparisonOpMemo = objXzSchoolCond.dicFldComparisonOp[conXzSchool.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.Memo, objXzSchoolCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_XzSchool
{
public virtual bool UpdRelaTabDate(string strIdSchool, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumXzSchool
{
 /// <summary>
 /// 淮阴师范学院
 /// </summary>
public const string HYSF_0001 = "0001";
 /// <summary>
 /// 上海师范大学
 /// </summary>
public const string SHNU_0002 = "0002";
 /// <summary>
 /// 温州大学
 /// </summary>
public const string WZU_0003 = "0003";
 /// <summary>
 /// 宁波大学
 /// </summary>
public const string NBU_0004 = "0004";
 /// <summary>
 /// 淮阴师范测试
 /// </summary>
public const string HYSF_TEST_0005 = "0005";
 /// <summary>
 /// 江苏二师
 /// </summary>
public const string JSIE_0006 = "0006";
 /// <summary>
 /// 上海泰泽
 /// </summary>
public const string TZ_0007 = "0007";
 /// <summary>
 /// 上海师大第二附属中学
 /// </summary>
public const string SSDEFZ_0008 = "0008";
 /// <summary>
 /// 上海市交通局下属单位
 /// </summary>
public const string JT_0009 = "0009";
 /// <summary>
 /// 上海师大智能语音学习平台
 /// </summary>
public const string YYXX_0010 = "0010";
}
 /// <summary>
 /// 学校(XzSchool)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsXzSchoolBL
{
public static RelatedActions_XzSchool relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsXzSchoolDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsXzSchoolDA XzSchoolDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsXzSchoolDA();
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
 public clsXzSchoolBL()
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
if (string.IsNullOrEmpty(clsXzSchoolEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzSchoolEN._ConnectString);
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
public static DataTable GetDataTable_XzSchool(string strWhereCond)
{
DataTable objDT;
try
{
objDT = XzSchoolDA.GetDataTable_XzSchool(strWhereCond);
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
objDT = XzSchoolDA.GetDataTable(strWhereCond);
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
objDT = XzSchoolDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = XzSchoolDA.GetDataTable(strWhereCond, strTabName);
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
objDT = XzSchoolDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = XzSchoolDA.GetDataTable_Top(objTopPara);
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
objDT = XzSchoolDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = XzSchoolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = XzSchoolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdSchoolLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsXzSchoolEN> GetObjLstByIdSchoolLst(List<string> arrIdSchoolLst)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdSchoolLst, true);
 string strWhereCond = string.Format("IdSchool in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(); //学校编号
objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(); //SchoolENName
objXzSchoolEN.SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objXzSchoolEN.SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchoolEN.Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchoolEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchoolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdSchoolLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsXzSchoolEN> GetObjLstByIdSchoolLstCache(List<string> arrIdSchoolLst)
{
string strKey = string.Format("{0}", clsXzSchoolEN._CurrTabName);
List<clsXzSchoolEN> arrXzSchoolObjLstCache = GetObjLstCache();
IEnumerable <clsXzSchoolEN> arrXzSchoolObjLst_Sel =
arrXzSchoolObjLstCache
.Where(x => arrIdSchoolLst.Contains(x.IdSchool));
return arrXzSchoolObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetObjLst(string strWhereCond)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(); //学校编号
objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(); //SchoolENName
objXzSchoolEN.SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objXzSchoolEN.SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchoolEN.Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchoolEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchoolEN);
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
public static List<clsXzSchoolEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(); //学校编号
objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(); //SchoolENName
objXzSchoolEN.SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objXzSchoolEN.SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchoolEN.Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchoolEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchoolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objXzSchoolCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsXzSchoolEN> GetSubObjLstCache(clsXzSchoolEN objXzSchoolCond)
{
List<clsXzSchoolEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzSchoolEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzSchool.AttributeName)
{
if (objXzSchoolCond.IsUpdated(strFldName) == false) continue;
if (objXzSchoolCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzSchoolCond[strFldName].ToString());
}
else
{
if (objXzSchoolCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzSchoolCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzSchoolCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzSchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzSchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzSchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzSchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzSchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzSchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzSchoolCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzSchoolCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzSchoolCond[strFldName]));
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
public static List<clsXzSchoolEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(); //学校编号
objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(); //SchoolENName
objXzSchoolEN.SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objXzSchoolEN.SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchoolEN.Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchoolEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchoolEN);
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
public static List<clsXzSchoolEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(); //学校编号
objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(); //SchoolENName
objXzSchoolEN.SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objXzSchoolEN.SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchoolEN.Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchoolEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchoolEN);
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
List<clsXzSchoolEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsXzSchoolEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsXzSchoolEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
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
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(); //学校编号
objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(); //SchoolENName
objXzSchoolEN.SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objXzSchoolEN.SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchoolEN.Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchoolEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchoolEN);
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
public static List<clsXzSchoolEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(); //学校编号
objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(); //SchoolENName
objXzSchoolEN.SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objXzSchoolEN.SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchoolEN.Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchoolEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchoolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsXzSchoolEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsXzSchoolEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(); //学校编号
objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(); //SchoolENName
objXzSchoolEN.SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objXzSchoolEN.SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchoolEN.Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchoolEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchoolEN);
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
public static List<clsXzSchoolEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(); //学校编号
objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(); //SchoolENName
objXzSchoolEN.SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objXzSchoolEN.SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchoolEN.Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchoolEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchoolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(); //学校编号
objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(); //SchoolENName
objXzSchoolEN.SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objXzSchoolEN.SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchoolEN.Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchoolEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchoolEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objXzSchoolEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetXzSchool(ref clsXzSchoolEN objXzSchoolEN)
{
bool bolResult = XzSchoolDA.GetXzSchool(ref objXzSchoolEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSchool">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzSchoolEN GetObjByIdSchool(string strIdSchool)
{
if (strIdSchool.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdSchool]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdSchool) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdSchool]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsXzSchoolEN objXzSchoolEN = XzSchoolDA.GetObjByIdSchool(strIdSchool);
return objXzSchoolEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsXzSchoolEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsXzSchoolEN objXzSchoolEN = XzSchoolDA.GetFirstObj(strWhereCond);
 return objXzSchoolEN;
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
public static clsXzSchoolEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsXzSchoolEN objXzSchoolEN = XzSchoolDA.GetObjByDataRow(objRow);
 return objXzSchoolEN;
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
public static clsXzSchoolEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsXzSchoolEN objXzSchoolEN = XzSchoolDA.GetObjByDataRow(objRow);
 return objXzSchoolEN;
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
 /// <param name = "strIdSchool">所给的关键字</param>
 /// <param name = "lstXzSchoolObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzSchoolEN GetObjByIdSchoolFromList(string strIdSchool, List<clsXzSchoolEN> lstXzSchoolObjLst)
{
foreach (clsXzSchoolEN objXzSchoolEN in lstXzSchoolObjLst)
{
if (objXzSchoolEN.IdSchool == strIdSchool)
{
return objXzSchoolEN;
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
 string strIdSchool;
 try
 {
 strIdSchool = new clsXzSchoolDA().GetFirstID(strWhereCond);
 return strIdSchool;
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
 arrList = XzSchoolDA.GetID(strWhereCond);
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
bool bolIsExist = XzSchoolDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdSchool">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdSchool)
{
if (string.IsNullOrEmpty(strIdSchool) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdSchool]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = XzSchoolDA.IsExist(strIdSchool);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdSchool">学校流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdSchool, string strOpUser)
{
clsXzSchoolEN objXzSchoolEN = clsXzSchoolBL.GetObjByIdSchool(strIdSchool);
objXzSchoolEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objXzSchoolEN.UpdUserId = strOpUser;
return clsXzSchoolBL.UpdateBySql2(objXzSchoolEN);
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
 bolIsExist = clsXzSchoolDA.IsExistTable();
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
 bolIsExist = XzSchoolDA.IsExistTable(strTabName);
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsXzSchoolEN objXzSchoolEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objXzSchoolEN.IdSchool) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzSchoolBL.IsExist(objXzSchoolEN.IdSchool) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzSchoolEN.IdSchool, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = XzSchoolDA.AddNewRecordBySQL2(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolBL.ReFreshCache();

if (clsXzSchoolBL.relatedActions != null)
{
clsXzSchoolBL.relatedActions.UpdRelaTabDate(objXzSchoolEN.IdSchool, objXzSchoolEN.UpdUserId);
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsXzSchoolEN objXzSchoolEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objXzSchoolEN.IdSchool) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzSchoolBL.IsExist(objXzSchoolEN.IdSchool) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzSchoolEN.IdSchool, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = XzSchoolDA.AddNewRecordBySQL2WithReturnKey(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolBL.ReFreshCache();

if (clsXzSchoolBL.relatedActions != null)
{
clsXzSchoolBL.relatedActions.UpdRelaTabDate(objXzSchoolEN.IdSchool, objXzSchoolEN.UpdUserId);
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsXzSchoolEN objXzSchoolEN)
{
try
{
bool bolResult = XzSchoolDA.Update(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolBL.ReFreshCache();

if (clsXzSchoolBL.relatedActions != null)
{
clsXzSchoolBL.relatedActions.UpdRelaTabDate(objXzSchoolEN.IdSchool, objXzSchoolEN.UpdUserId);
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsXzSchoolEN objXzSchoolEN)
{
 if (string.IsNullOrEmpty(objXzSchoolEN.IdSchool) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = XzSchoolDA.UpdateBySql2(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolBL.ReFreshCache();

if (clsXzSchoolBL.relatedActions != null)
{
clsXzSchoolBL.relatedActions.UpdRelaTabDate(objXzSchoolEN.IdSchool, objXzSchoolEN.UpdUserId);
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
 /// <param name = "strIdSchool">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdSchool)
{
try
{
 clsXzSchoolEN objXzSchoolEN = clsXzSchoolBL.GetObjByIdSchool(strIdSchool);

if (clsXzSchoolBL.relatedActions != null)
{
clsXzSchoolBL.relatedActions.UpdRelaTabDate(objXzSchoolEN.IdSchool, objXzSchoolEN.UpdUserId);
}
if (objXzSchoolEN != null)
{
int intRecNum = XzSchoolDA.DelRecord(strIdSchool);
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
/// <param name="strIdSchool">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdSchool )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzSchoolDA.GetSpecSQLObj();
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
//删除与表:[XzSchool]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conXzSchool.IdSchool,
//strIdSchool);
//        clsXzSchoolBL.DelXzSchoolsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzSchoolBL.DelRecord(strIdSchool, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzSchoolBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdSchool, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdSchool">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdSchool, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsXzSchoolBL.relatedActions != null)
{
clsXzSchoolBL.relatedActions.UpdRelaTabDate(strIdSchool, "UpdRelaTabDate");
}
bool bolResult = XzSchoolDA.DelRecord(strIdSchool,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdSchoolLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelXzSchools(List<string> arrIdSchoolLst)
{
if (arrIdSchoolLst.Count == 0) return 0;
try
{
if (clsXzSchoolBL.relatedActions != null)
{
foreach (var strIdSchool in arrIdSchoolLst)
{
clsXzSchoolBL.relatedActions.UpdRelaTabDate(strIdSchool, "UpdRelaTabDate");
}
}
int intDelRecNum = XzSchoolDA.DelXzSchool(arrIdSchoolLst);
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
public static int DelXzSchoolsByCond(string strWhereCond)
{
try
{
if (clsXzSchoolBL.relatedActions != null)
{
List<string> arrIdSchool = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdSchool in arrIdSchool)
{
clsXzSchoolBL.relatedActions.UpdRelaTabDate(strIdSchool, "UpdRelaTabDate");
}
}
int intRecNum = XzSchoolDA.DelXzSchool(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[XzSchool]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdSchool">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdSchool)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzSchoolDA.GetSpecSQLObj();
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
//删除与表:[XzSchool]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzSchoolBL.DelRecord(strIdSchool, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzSchoolBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdSchool, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objXzSchoolENS">源对象</param>
 /// <param name = "objXzSchoolENT">目标对象</param>
 public static void CopyTo(clsXzSchoolEN objXzSchoolENS, clsXzSchoolEN objXzSchoolENT)
{
try
{
objXzSchoolENT.IdSchool = objXzSchoolENS.IdSchool; //学校流水号
objXzSchoolENT.SchoolId = objXzSchoolENS.SchoolId; //学校编号
objXzSchoolENT.SchoolName = objXzSchoolENS.SchoolName; //学校名称
objXzSchoolENT.SchoolENName = objXzSchoolENS.SchoolENName; //SchoolENName
objXzSchoolENT.SchoolNameA = objXzSchoolENS.SchoolNameA; //学校简称
objXzSchoolENT.SchoolTypeId = objXzSchoolENS.SchoolTypeId; //学校类型Id
objXzSchoolENT.IsCurrentUse = objXzSchoolENS.IsCurrentUse; //是否当前使用
objXzSchoolENT.UpdDate = objXzSchoolENS.UpdDate; //修改日期
objXzSchoolENT.UpdUserId = objXzSchoolENS.UpdUserId; //修改用户Id
objXzSchoolENT.Memo = objXzSchoolENS.Memo; //备注
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
 /// <param name = "objXzSchoolEN">源简化对象</param>
 public static void SetUpdFlag(clsXzSchoolEN objXzSchoolEN)
{
try
{
objXzSchoolEN.ClearUpdateState();
   string strsfUpdFldSetStr = objXzSchoolEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conXzSchool.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchoolEN.IdSchool = objXzSchoolEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(conXzSchool.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchoolEN.SchoolId = objXzSchoolEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(conXzSchool.SchoolName, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchoolEN.SchoolName = objXzSchoolEN.SchoolName; //学校名称
}
if (arrFldSet.Contains(conXzSchool.SchoolENName, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchoolEN.SchoolENName = objXzSchoolEN.SchoolENName == "[null]" ? null :  objXzSchoolEN.SchoolENName; //SchoolENName
}
if (arrFldSet.Contains(conXzSchool.SchoolNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchoolEN.SchoolNameA = objXzSchoolEN.SchoolNameA == "[null]" ? null :  objXzSchoolEN.SchoolNameA; //学校简称
}
if (arrFldSet.Contains(conXzSchool.SchoolTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchoolEN.SchoolTypeId = objXzSchoolEN.SchoolTypeId == "[null]" ? null :  objXzSchoolEN.SchoolTypeId; //学校类型Id
}
if (arrFldSet.Contains(conXzSchool.IsCurrentUse, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchoolEN.IsCurrentUse = objXzSchoolEN.IsCurrentUse; //是否当前使用
}
if (arrFldSet.Contains(conXzSchool.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchoolEN.UpdDate = objXzSchoolEN.UpdDate == "[null]" ? null :  objXzSchoolEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conXzSchool.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchoolEN.UpdUserId = objXzSchoolEN.UpdUserId == "[null]" ? null :  objXzSchoolEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conXzSchool.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchoolEN.Memo = objXzSchoolEN.Memo == "[null]" ? null :  objXzSchoolEN.Memo; //备注
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
 /// <param name = "objXzSchoolEN">源简化对象</param>
 public static void AccessFldValueNull(clsXzSchoolEN objXzSchoolEN)
{
try
{
if (objXzSchoolEN.SchoolENName == "[null]") objXzSchoolEN.SchoolENName = null; //SchoolENName
if (objXzSchoolEN.SchoolNameA == "[null]") objXzSchoolEN.SchoolNameA = null; //学校简称
if (objXzSchoolEN.SchoolTypeId == "[null]") objXzSchoolEN.SchoolTypeId = null; //学校类型Id
if (objXzSchoolEN.UpdDate == "[null]") objXzSchoolEN.UpdDate = null; //修改日期
if (objXzSchoolEN.UpdUserId == "[null]") objXzSchoolEN.UpdUserId = null; //修改用户Id
if (objXzSchoolEN.Memo == "[null]") objXzSchoolEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsXzSchoolEN objXzSchoolEN)
{
 XzSchoolDA.CheckPropertyNew(objXzSchoolEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsXzSchoolEN objXzSchoolEN)
{
 XzSchoolDA.CheckProperty4Condition(objXzSchoolEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdSchoolCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[学校]...","0");
List<clsXzSchoolEN> arrXzSchoolObjLst = GetAllXzSchoolObjLstCache(); 
objDDL.DataValueField = conXzSchool.IdSchool;
objDDL.DataTextField = conXzSchool.SchoolName;
objDDL.DataSource = arrXzSchoolObjLst;
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
if (clsXzSchoolBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolBL没有刷新缓存机制(clsXzSchoolBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdSchool");
//if (arrXzSchoolObjLstCache == null)
//{
//arrXzSchoolObjLstCache = XzSchoolDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdSchool">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzSchoolEN GetObjByIdSchoolCache(string strIdSchool)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsXzSchoolEN._CurrTabName);
List<clsXzSchoolEN> arrXzSchoolObjLstCache = GetObjLstCache();
IEnumerable <clsXzSchoolEN> arrXzSchoolObjLst_Sel =
arrXzSchoolObjLstCache
.Where(x=> x.IdSchool == strIdSchool 
);
if (arrXzSchoolObjLst_Sel.Count() == 0)
{
   clsXzSchoolEN obj = clsXzSchoolBL.GetObjByIdSchool(strIdSchool);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrXzSchoolObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSchool">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSchoolNameByIdSchoolCache(string strIdSchool)
{
if (string.IsNullOrEmpty(strIdSchool) == true) return "";
//获取缓存中的对象列表
clsXzSchoolEN objXzSchool = GetObjByIdSchoolCache(strIdSchool);
if (objXzSchool == null) return "";
return objXzSchool.SchoolName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSchool">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdSchoolCache(string strIdSchool)
{
if (string.IsNullOrEmpty(strIdSchool) == true) return "";
//获取缓存中的对象列表
clsXzSchoolEN objXzSchool = GetObjByIdSchoolCache(strIdSchool);
if (objXzSchool == null) return "";
return objXzSchool.SchoolName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzSchoolEN> GetAllXzSchoolObjLstCache()
{
//获取缓存中的对象列表
List<clsXzSchoolEN> arrXzSchoolObjLstCache = GetObjLstCache(); 
return arrXzSchoolObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzSchoolEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsXzSchoolEN._CurrTabName);
List<clsXzSchoolEN> arrXzSchoolObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzSchoolObjLstCache;
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
string strKey = string.Format("{0}", clsXzSchoolEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzSchoolEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsXzSchoolEN._RefreshTimeLst.Count == 0) return "";
return clsXzSchoolEN._RefreshTimeLst[clsXzSchoolEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsXzSchoolBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzSchoolEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzSchoolEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsXzSchoolBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdSchool)
{
if (strInFldName != conXzSchool.IdSchool)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conXzSchool.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conXzSchool.AttributeName));
throw new Exception(strMsg);
}
var objXzSchool = clsXzSchoolBL.GetObjByIdSchoolCache(strIdSchool);
if (objXzSchool == null) return "";
return objXzSchool[strOutFldName].ToString();
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
int intRecCount = clsXzSchoolDA.GetRecCount(strTabName);
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
int intRecCount = clsXzSchoolDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsXzSchoolDA.GetRecCount();
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
int intRecCount = clsXzSchoolDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objXzSchoolCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsXzSchoolEN objXzSchoolCond)
{
List<clsXzSchoolEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzSchoolEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzSchool.AttributeName)
{
if (objXzSchoolCond.IsUpdated(strFldName) == false) continue;
if (objXzSchoolCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzSchoolCond[strFldName].ToString());
}
else
{
if (objXzSchoolCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzSchoolCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzSchoolCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzSchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzSchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzSchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzSchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzSchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzSchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzSchoolCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzSchoolCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzSchoolCond[strFldName]));
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
 List<string> arrList = clsXzSchoolDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = XzSchoolDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = XzSchoolDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = XzSchoolDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzSchoolDA.SetFldValue(clsXzSchoolEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = XzSchoolDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzSchoolDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzSchoolDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzSchoolDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[XzSchool] "); 
 strCreateTabCode.Append(" ( "); 
 // /**学校流水号*/ 
 strCreateTabCode.Append(" IdSchool char(4) primary key, "); 
 // /**学校编号*/ 
 strCreateTabCode.Append(" SchoolId varchar(10) not Null, "); 
 // /**学校名称*/ 
 strCreateTabCode.Append(" SchoolName varchar(50) not Null, "); 
 // /**SchoolENName*/ 
 strCreateTabCode.Append(" SchoolENName varchar(50) Null, "); 
 // /**学校简称*/ 
 strCreateTabCode.Append(" SchoolNameA varchar(14) Null, "); 
 // /**学校类型Id*/ 
 strCreateTabCode.Append(" SchoolTypeId char(2) Null, "); 
 // /**是否当前使用*/ 
 strCreateTabCode.Append(" IsCurrentUse bit Null, "); 
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
 /// 学校(XzSchool)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4XzSchool : clsCommFun4BL
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
clsXzSchoolBL.ReFreshThisCache();
}
}

}