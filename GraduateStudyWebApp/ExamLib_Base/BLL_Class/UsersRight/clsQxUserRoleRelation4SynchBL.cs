﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserRoleRelation4SynchBL
 表名:QxUserRoleRelation4Synch(01120556)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
public static class  clsQxUserRoleRelation4SynchBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserRoleRelation4SynchEN GetObj(this K_mId_QxUserRoleRelation4Synch myKey)
{
clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = clsQxUserRoleRelation4SynchBL.QxUserRoleRelation4SynchDA.GetObjBymId(myKey.Value);
return objQxUserRoleRelation4SynchEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQxUserRoleRelation4SynchEN) == false)
{
var strMsg = string.Format("记录已经存在!Ip地址 = [{0}],QxPrjId = [{1}],角色Id = [{2}],用户ID = [{3}]的数据已经存在!(in clsQxUserRoleRelation4SynchBL.AddNewRecord)", objQxUserRoleRelation4SynchEN.IpAddress,objQxUserRoleRelation4SynchEN.QxPrjId,objQxUserRoleRelation4SynchEN.RoleId,objQxUserRoleRelation4SynchEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxUserRoleRelation4SynchBL.QxUserRoleRelation4SynchDA.AddNewRecordBySQL2(objQxUserRoleRelation4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchBL.ReFreshCache();

if (clsQxUserRoleRelation4SynchBL.relatedActions != null)
{
clsQxUserRoleRelation4SynchBL.relatedActions.UpdRelaTabDate(objQxUserRoleRelation4SynchEN.mId, objQxUserRoleRelation4SynchEN.UpdUserId);
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
public static bool AddRecordEx(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, bool bolIsNeedCheckUniqueness = true)
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
objQxUserRoleRelation4SynchEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objQxUserRoleRelation4SynchEN.CheckUniqueness() == false)
{
strMsg = string.Format("(Ip地址(IpAddress)=[{0}],QxPrjId(QxPrjId)=[{1}],角色Id(RoleId)=[{2}],用户ID(UserId)=[{3}])已经存在,不能重复!", objQxUserRoleRelation4SynchEN.IpAddress, objQxUserRoleRelation4SynchEN.QxPrjId, objQxUserRoleRelation4SynchEN.RoleId, objQxUserRoleRelation4SynchEN.UserId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxUserRoleRelation4SynchEN.AddNewRecord();
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
 /// <param name = "objQxUserRoleRelation4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQxUserRoleRelation4SynchEN) == false)
{
var strMsg = string.Format("记录已经存在!Ip地址 = [{0}],QxPrjId = [{1}],角色Id = [{2}],用户ID = [{3}]的数据已经存在!(in clsQxUserRoleRelation4SynchBL.AddNewRecordWithReturnKey)", objQxUserRoleRelation4SynchEN.IpAddress,objQxUserRoleRelation4SynchEN.QxPrjId,objQxUserRoleRelation4SynchEN.RoleId,objQxUserRoleRelation4SynchEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxUserRoleRelation4SynchBL.QxUserRoleRelation4SynchDA.AddNewRecordBySQL2WithReturnKey(objQxUserRoleRelation4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchBL.ReFreshCache();

if (clsQxUserRoleRelation4SynchBL.relatedActions != null)
{
clsQxUserRoleRelation4SynchBL.relatedActions.UpdRelaTabDate(objQxUserRoleRelation4SynchEN.mId, objQxUserRoleRelation4SynchEN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetmId(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, long lngmId, string strComparisonOp="")
	{
objQxUserRoleRelation4SynchEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.mId) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.mId, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.mId] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetIpAddress(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIpAddress, conQxUserRoleRelation4Synch.IpAddress);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 50, conQxUserRoleRelation4Synch.IpAddress);
}
objQxUserRoleRelation4SynchEN.IpAddress = strIpAddress; //Ip地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.IpAddress) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.IpAddress, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.IpAddress] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetUserId(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conQxUserRoleRelation4Synch.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conQxUserRoleRelation4Synch.UserId);
}
objQxUserRoleRelation4SynchEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.UserId) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.UserId, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.UserId] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetRoleId(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleId, conQxUserRoleRelation4Synch.RoleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, conQxUserRoleRelation4Synch.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQxUserRoleRelation4Synch.RoleId);
}
objQxUserRoleRelation4SynchEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.RoleId) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.RoleId, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.RoleId] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetQxPrjId(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxUserRoleRelation4Synch.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxUserRoleRelation4Synch.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxUserRoleRelation4Synch.QxPrjId);
}
objQxUserRoleRelation4SynchEN.QxPrjId = strQxPrjId; //QxPrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.QxPrjId) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.QxPrjId, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.QxPrjId] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetUpdDate(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxUserRoleRelation4Synch.UpdDate);
}
objQxUserRoleRelation4SynchEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.UpdDate) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.UpdDate, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.UpdDate] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetUpdUserId(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxUserRoleRelation4Synch.UpdUserId);
}
objQxUserRoleRelation4SynchEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.UpdUserId) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.UpdUserId, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.UpdUserId] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetMemo(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUserRoleRelation4Synch.Memo);
}
objQxUserRoleRelation4SynchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.Memo) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.Memo, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.Memo] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxUserRoleRelation4SynchEN.CheckPropertyNew();
clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchCond = new clsQxUserRoleRelation4SynchEN();
string strCondition = objQxUserRoleRelation4SynchCond
.SetmId(objQxUserRoleRelation4SynchEN.mId, "<>")
.SetIpAddress(objQxUserRoleRelation4SynchEN.IpAddress, "=")
.SetQxPrjId(objQxUserRoleRelation4SynchEN.QxPrjId, "=")
.SetRoleId(objQxUserRoleRelation4SynchEN.RoleId, "=")
.SetUserId(objQxUserRoleRelation4SynchEN.UserId, "=")
.GetCombineCondition();
objQxUserRoleRelation4SynchEN._IsCheckProperty = true;
bool bolIsExist = clsQxUserRoleRelation4SynchBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(IpAddress_QxPrjId_RoleId_UserId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxUserRoleRelation4SynchEN.Update();
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
 /// <param name = "objQxUserRoleRelation4Synch">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4Synch)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchCond = new clsQxUserRoleRelation4SynchEN();
string strCondition = objQxUserRoleRelation4SynchCond
.SetIpAddress(objQxUserRoleRelation4Synch.IpAddress, "=")
.SetQxPrjId(objQxUserRoleRelation4Synch.QxPrjId, "=")
.SetRoleId(objQxUserRoleRelation4Synch.RoleId, "=")
.SetUserId(objQxUserRoleRelation4Synch.UserId, "=")
.GetCombineCondition();
objQxUserRoleRelation4Synch._IsCheckProperty = true;
bool bolIsExist = clsQxUserRoleRelation4SynchBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxUserRoleRelation4Synch.mId = clsQxUserRoleRelation4SynchBL.GetFirstID_S(strCondition);
objQxUserRoleRelation4Synch.UpdateWithCondition(strCondition);
}
else
{
objQxUserRoleRelation4Synch.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
 if (objQxUserRoleRelation4SynchEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUserRoleRelation4SynchBL.QxUserRoleRelation4SynchDA.UpdateBySql2(objQxUserRoleRelation4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchBL.ReFreshCache();

if (clsQxUserRoleRelation4SynchBL.relatedActions != null)
{
clsQxUserRoleRelation4SynchBL.relatedActions.UpdRelaTabDate(objQxUserRoleRelation4SynchEN.mId, objQxUserRoleRelation4SynchEN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelation4SynchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxUserRoleRelation4SynchEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUserRoleRelation4SynchBL.QxUserRoleRelation4SynchDA.UpdateBySql2(objQxUserRoleRelation4SynchEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchBL.ReFreshCache();

if (clsQxUserRoleRelation4SynchBL.relatedActions != null)
{
clsQxUserRoleRelation4SynchBL.relatedActions.UpdRelaTabDate(objQxUserRoleRelation4SynchEN.mId, objQxUserRoleRelation4SynchEN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelation4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strWhereCond)
{
try
{
bool bolResult = clsQxUserRoleRelation4SynchBL.QxUserRoleRelation4SynchDA.UpdateBySqlWithCondition(objQxUserRoleRelation4SynchEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchBL.ReFreshCache();

if (clsQxUserRoleRelation4SynchBL.relatedActions != null)
{
clsQxUserRoleRelation4SynchBL.relatedActions.UpdRelaTabDate(objQxUserRoleRelation4SynchEN.mId, objQxUserRoleRelation4SynchEN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelation4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxUserRoleRelation4SynchBL.QxUserRoleRelation4SynchDA.UpdateBySqlWithConditionTransaction(objQxUserRoleRelation4SynchEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchBL.ReFreshCache();

if (clsQxUserRoleRelation4SynchBL.relatedActions != null)
{
clsQxUserRoleRelation4SynchBL.relatedActions.UpdRelaTabDate(objQxUserRoleRelation4SynchEN.mId, objQxUserRoleRelation4SynchEN.UpdUserId);
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
public static int Delete(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
try
{
int intRecNum = clsQxUserRoleRelation4SynchBL.QxUserRoleRelation4SynchDA.DelRecord(objQxUserRoleRelation4SynchEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchBL.ReFreshCache();

if (clsQxUserRoleRelation4SynchBL.relatedActions != null)
{
clsQxUserRoleRelation4SynchBL.relatedActions.UpdRelaTabDate(objQxUserRoleRelation4SynchEN.mId, objQxUserRoleRelation4SynchEN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelation4SynchENS">源对象</param>
 /// <param name = "objQxUserRoleRelation4SynchENT">目标对象</param>
 public static void CopyTo(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchENS, clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchENT)
{
try
{
objQxUserRoleRelation4SynchENT.mId = objQxUserRoleRelation4SynchENS.mId; //mId
objQxUserRoleRelation4SynchENT.IpAddress = objQxUserRoleRelation4SynchENS.IpAddress; //Ip地址
objQxUserRoleRelation4SynchENT.UserId = objQxUserRoleRelation4SynchENS.UserId; //用户ID
objQxUserRoleRelation4SynchENT.RoleId = objQxUserRoleRelation4SynchENS.RoleId; //角色Id
objQxUserRoleRelation4SynchENT.QxPrjId = objQxUserRoleRelation4SynchENS.QxPrjId; //QxPrjId
objQxUserRoleRelation4SynchENT.UpdDate = objQxUserRoleRelation4SynchENS.UpdDate; //修改日期
objQxUserRoleRelation4SynchENT.UpdUserId = objQxUserRoleRelation4SynchENS.UpdUserId; //修改用户Id
objQxUserRoleRelation4SynchENT.Memo = objQxUserRoleRelation4SynchENS.Memo; //备注
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
 /// <param name = "objQxUserRoleRelation4SynchENS">源对象</param>
 /// <returns>目标对象=>clsQxUserRoleRelation4SynchEN:objQxUserRoleRelation4SynchENT</returns>
 public static clsQxUserRoleRelation4SynchEN CopyTo(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchENS)
{
try
{
 clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchENT = new clsQxUserRoleRelation4SynchEN()
{
mId = objQxUserRoleRelation4SynchENS.mId, //mId
IpAddress = objQxUserRoleRelation4SynchENS.IpAddress, //Ip地址
UserId = objQxUserRoleRelation4SynchENS.UserId, //用户ID
RoleId = objQxUserRoleRelation4SynchENS.RoleId, //角色Id
QxPrjId = objQxUserRoleRelation4SynchENS.QxPrjId, //QxPrjId
UpdDate = objQxUserRoleRelation4SynchENS.UpdDate, //修改日期
UpdUserId = objQxUserRoleRelation4SynchENS.UpdUserId, //修改用户Id
Memo = objQxUserRoleRelation4SynchENS.Memo, //备注
};
 return objQxUserRoleRelation4SynchENT;
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
public static void CheckPropertyNew(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
 clsQxUserRoleRelation4SynchBL.QxUserRoleRelation4SynchDA.CheckPropertyNew(objQxUserRoleRelation4SynchEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
 clsQxUserRoleRelation4SynchBL.QxUserRoleRelation4SynchDA.CheckProperty4Condition(objQxUserRoleRelation4SynchEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxUserRoleRelation4SynchCond.IsUpdated(conQxUserRoleRelation4Synch.mId) == true)
{
string strComparisonOpmId = objQxUserRoleRelation4SynchCond.dicFldComparisonOp[conQxUserRoleRelation4Synch.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxUserRoleRelation4Synch.mId, objQxUserRoleRelation4SynchCond.mId, strComparisonOpmId);
}
if (objQxUserRoleRelation4SynchCond.IsUpdated(conQxUserRoleRelation4Synch.IpAddress) == true)
{
string strComparisonOpIpAddress = objQxUserRoleRelation4SynchCond.dicFldComparisonOp[conQxUserRoleRelation4Synch.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelation4Synch.IpAddress, objQxUserRoleRelation4SynchCond.IpAddress, strComparisonOpIpAddress);
}
if (objQxUserRoleRelation4SynchCond.IsUpdated(conQxUserRoleRelation4Synch.UserId) == true)
{
string strComparisonOpUserId = objQxUserRoleRelation4SynchCond.dicFldComparisonOp[conQxUserRoleRelation4Synch.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelation4Synch.UserId, objQxUserRoleRelation4SynchCond.UserId, strComparisonOpUserId);
}
if (objQxUserRoleRelation4SynchCond.IsUpdated(conQxUserRoleRelation4Synch.RoleId) == true)
{
string strComparisonOpRoleId = objQxUserRoleRelation4SynchCond.dicFldComparisonOp[conQxUserRoleRelation4Synch.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelation4Synch.RoleId, objQxUserRoleRelation4SynchCond.RoleId, strComparisonOpRoleId);
}
if (objQxUserRoleRelation4SynchCond.IsUpdated(conQxUserRoleRelation4Synch.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxUserRoleRelation4SynchCond.dicFldComparisonOp[conQxUserRoleRelation4Synch.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelation4Synch.QxPrjId, objQxUserRoleRelation4SynchCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxUserRoleRelation4SynchCond.IsUpdated(conQxUserRoleRelation4Synch.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxUserRoleRelation4SynchCond.dicFldComparisonOp[conQxUserRoleRelation4Synch.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelation4Synch.UpdDate, objQxUserRoleRelation4SynchCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxUserRoleRelation4SynchCond.IsUpdated(conQxUserRoleRelation4Synch.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxUserRoleRelation4SynchCond.dicFldComparisonOp[conQxUserRoleRelation4Synch.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelation4Synch.UpdUserId, objQxUserRoleRelation4SynchCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxUserRoleRelation4SynchCond.IsUpdated(conQxUserRoleRelation4Synch.Memo) == true)
{
string strComparisonOpMemo = objQxUserRoleRelation4SynchCond.dicFldComparisonOp[conQxUserRoleRelation4Synch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelation4Synch.Memo, objQxUserRoleRelation4SynchCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxUserRoleRelation4Synch(QxUserRoleRelation4Synch), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:IpAddress_QxPrjId_RoleId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxUserRoleRelation4SynchEN == null) return true;
if (objQxUserRoleRelation4SynchEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objQxUserRoleRelation4SynchEN.IpAddress);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxUserRoleRelation4SynchEN.QxPrjId);
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxUserRoleRelation4SynchEN.RoleId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserRoleRelation4SynchEN.UserId);
if (clsQxUserRoleRelation4SynchBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxUserRoleRelation4SynchEN.mId);
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objQxUserRoleRelation4SynchEN.IpAddress);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxUserRoleRelation4SynchEN.QxPrjId);
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxUserRoleRelation4SynchEN.RoleId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserRoleRelation4SynchEN.UserId);
if (clsQxUserRoleRelation4SynchBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxUserRoleRelation4Synch(QxUserRoleRelation4Synch), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:IpAddress_QxPrjId_RoleId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxUserRoleRelation4SynchEN == null) return "";
if (objQxUserRoleRelation4SynchEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objQxUserRoleRelation4SynchEN.IpAddress);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxUserRoleRelation4SynchEN.QxPrjId);
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxUserRoleRelation4SynchEN.RoleId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserRoleRelation4SynchEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxUserRoleRelation4SynchEN.mId);
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objQxUserRoleRelation4SynchEN.IpAddress);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxUserRoleRelation4SynchEN.QxPrjId);
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxUserRoleRelation4SynchEN.RoleId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserRoleRelation4SynchEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxUserRoleRelation4Synch
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// QxUserRoleRelation4Synch(QxUserRoleRelation4Synch)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxUserRoleRelation4SynchBL
{
public static RelatedActions_QxUserRoleRelation4Synch relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxUserRoleRelation4SynchDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxUserRoleRelation4SynchDA QxUserRoleRelation4SynchDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxUserRoleRelation4SynchDA();
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
 public clsQxUserRoleRelation4SynchBL()
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
if (string.IsNullOrEmpty(clsQxUserRoleRelation4SynchEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUserRoleRelation4SynchEN._ConnectString);
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
public static DataTable GetDataTable_QxUserRoleRelation4Synch(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxUserRoleRelation4SynchDA.GetDataTable_QxUserRoleRelation4Synch(strWhereCond);
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
objDT = QxUserRoleRelation4SynchDA.GetDataTable(strWhereCond);
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
objDT = QxUserRoleRelation4SynchDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxUserRoleRelation4SynchDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxUserRoleRelation4SynchDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxUserRoleRelation4SynchDA.GetDataTable_Top(objTopPara);
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
objDT = QxUserRoleRelation4SynchDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxUserRoleRelation4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxUserRoleRelation4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsQxUserRoleRelation4SynchEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsQxUserRoleRelation4SynchEN> arrObjLst = new List<clsQxUserRoleRelation4SynchEN>(); 
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
	clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = new clsQxUserRoleRelation4SynchEN();
try
{
objQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[conQxUserRoleRelation4Synch.mId].ToString().Trim()); //mId
objQxUserRoleRelation4SynchEN.IpAddress = objRow[conQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //Ip地址
objQxUserRoleRelation4SynchEN.UserId = objRow[conQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objQxUserRoleRelation4SynchEN.RoleId = objRow[conQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objQxUserRoleRelation4SynchEN.QxPrjId = objRow[conQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //QxPrjId
objQxUserRoleRelation4SynchEN.UpdDate = objRow[conQxUserRoleRelation4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelation4SynchEN.UpdUserId = objRow[conQxUserRoleRelation4Synch.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelation4SynchEN.Memo = objRow[conQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelation4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxUserRoleRelation4SynchEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsQxUserRoleRelation4SynchEN._CurrTabName);
List<clsQxUserRoleRelation4SynchEN> arrQxUserRoleRelation4SynchObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRoleRelation4SynchEN> arrQxUserRoleRelation4SynchObjLst_Sel =
arrQxUserRoleRelation4SynchObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrQxUserRoleRelation4SynchObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRoleRelation4SynchEN> GetObjLst(string strWhereCond)
{
List<clsQxUserRoleRelation4SynchEN> arrObjLst = new List<clsQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = new clsQxUserRoleRelation4SynchEN();
try
{
objQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[conQxUserRoleRelation4Synch.mId].ToString().Trim()); //mId
objQxUserRoleRelation4SynchEN.IpAddress = objRow[conQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //Ip地址
objQxUserRoleRelation4SynchEN.UserId = objRow[conQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objQxUserRoleRelation4SynchEN.RoleId = objRow[conQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objQxUserRoleRelation4SynchEN.QxPrjId = objRow[conQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //QxPrjId
objQxUserRoleRelation4SynchEN.UpdDate = objRow[conQxUserRoleRelation4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelation4SynchEN.UpdUserId = objRow[conQxUserRoleRelation4Synch.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelation4SynchEN.Memo = objRow[conQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelation4SynchEN);
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
public static List<clsQxUserRoleRelation4SynchEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxUserRoleRelation4SynchEN> arrObjLst = new List<clsQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = new clsQxUserRoleRelation4SynchEN();
try
{
objQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[conQxUserRoleRelation4Synch.mId].ToString().Trim()); //mId
objQxUserRoleRelation4SynchEN.IpAddress = objRow[conQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //Ip地址
objQxUserRoleRelation4SynchEN.UserId = objRow[conQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objQxUserRoleRelation4SynchEN.RoleId = objRow[conQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objQxUserRoleRelation4SynchEN.QxPrjId = objRow[conQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //QxPrjId
objQxUserRoleRelation4SynchEN.UpdDate = objRow[conQxUserRoleRelation4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelation4SynchEN.UpdUserId = objRow[conQxUserRoleRelation4Synch.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelation4SynchEN.Memo = objRow[conQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelation4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxUserRoleRelation4SynchEN> GetSubObjLstCache(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchCond)
{
List<clsQxUserRoleRelation4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRoleRelation4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserRoleRelation4Synch.AttributeName)
{
if (objQxUserRoleRelation4SynchCond.IsUpdated(strFldName) == false) continue;
if (objQxUserRoleRelation4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRoleRelation4SynchCond[strFldName].ToString());
}
else
{
if (objQxUserRoleRelation4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserRoleRelation4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRoleRelation4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserRoleRelation4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserRoleRelation4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserRoleRelation4SynchCond[strFldName]));
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
public static List<clsQxUserRoleRelation4SynchEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxUserRoleRelation4SynchEN> arrObjLst = new List<clsQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = new clsQxUserRoleRelation4SynchEN();
try
{
objQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[conQxUserRoleRelation4Synch.mId].ToString().Trim()); //mId
objQxUserRoleRelation4SynchEN.IpAddress = objRow[conQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //Ip地址
objQxUserRoleRelation4SynchEN.UserId = objRow[conQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objQxUserRoleRelation4SynchEN.RoleId = objRow[conQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objQxUserRoleRelation4SynchEN.QxPrjId = objRow[conQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //QxPrjId
objQxUserRoleRelation4SynchEN.UpdDate = objRow[conQxUserRoleRelation4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelation4SynchEN.UpdUserId = objRow[conQxUserRoleRelation4Synch.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelation4SynchEN.Memo = objRow[conQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelation4SynchEN);
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
public static List<clsQxUserRoleRelation4SynchEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxUserRoleRelation4SynchEN> arrObjLst = new List<clsQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = new clsQxUserRoleRelation4SynchEN();
try
{
objQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[conQxUserRoleRelation4Synch.mId].ToString().Trim()); //mId
objQxUserRoleRelation4SynchEN.IpAddress = objRow[conQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //Ip地址
objQxUserRoleRelation4SynchEN.UserId = objRow[conQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objQxUserRoleRelation4SynchEN.RoleId = objRow[conQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objQxUserRoleRelation4SynchEN.QxPrjId = objRow[conQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //QxPrjId
objQxUserRoleRelation4SynchEN.UpdDate = objRow[conQxUserRoleRelation4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelation4SynchEN.UpdUserId = objRow[conQxUserRoleRelation4Synch.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelation4SynchEN.Memo = objRow[conQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelation4SynchEN);
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
List<clsQxUserRoleRelation4SynchEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxUserRoleRelation4SynchEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRoleRelation4SynchEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxUserRoleRelation4SynchEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxUserRoleRelation4SynchEN> arrObjLst = new List<clsQxUserRoleRelation4SynchEN>(); 
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
	clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = new clsQxUserRoleRelation4SynchEN();
try
{
objQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[conQxUserRoleRelation4Synch.mId].ToString().Trim()); //mId
objQxUserRoleRelation4SynchEN.IpAddress = objRow[conQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //Ip地址
objQxUserRoleRelation4SynchEN.UserId = objRow[conQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objQxUserRoleRelation4SynchEN.RoleId = objRow[conQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objQxUserRoleRelation4SynchEN.QxPrjId = objRow[conQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //QxPrjId
objQxUserRoleRelation4SynchEN.UpdDate = objRow[conQxUserRoleRelation4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelation4SynchEN.UpdUserId = objRow[conQxUserRoleRelation4Synch.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelation4SynchEN.Memo = objRow[conQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelation4SynchEN);
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
public static List<clsQxUserRoleRelation4SynchEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxUserRoleRelation4SynchEN> arrObjLst = new List<clsQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = new clsQxUserRoleRelation4SynchEN();
try
{
objQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[conQxUserRoleRelation4Synch.mId].ToString().Trim()); //mId
objQxUserRoleRelation4SynchEN.IpAddress = objRow[conQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //Ip地址
objQxUserRoleRelation4SynchEN.UserId = objRow[conQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objQxUserRoleRelation4SynchEN.RoleId = objRow[conQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objQxUserRoleRelation4SynchEN.QxPrjId = objRow[conQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //QxPrjId
objQxUserRoleRelation4SynchEN.UpdDate = objRow[conQxUserRoleRelation4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelation4SynchEN.UpdUserId = objRow[conQxUserRoleRelation4Synch.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelation4SynchEN.Memo = objRow[conQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelation4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxUserRoleRelation4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxUserRoleRelation4SynchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxUserRoleRelation4SynchEN> arrObjLst = new List<clsQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = new clsQxUserRoleRelation4SynchEN();
try
{
objQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[conQxUserRoleRelation4Synch.mId].ToString().Trim()); //mId
objQxUserRoleRelation4SynchEN.IpAddress = objRow[conQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //Ip地址
objQxUserRoleRelation4SynchEN.UserId = objRow[conQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objQxUserRoleRelation4SynchEN.RoleId = objRow[conQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objQxUserRoleRelation4SynchEN.QxPrjId = objRow[conQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //QxPrjId
objQxUserRoleRelation4SynchEN.UpdDate = objRow[conQxUserRoleRelation4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelation4SynchEN.UpdUserId = objRow[conQxUserRoleRelation4Synch.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelation4SynchEN.Memo = objRow[conQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelation4SynchEN);
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
public static List<clsQxUserRoleRelation4SynchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxUserRoleRelation4SynchEN> arrObjLst = new List<clsQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = new clsQxUserRoleRelation4SynchEN();
try
{
objQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[conQxUserRoleRelation4Synch.mId].ToString().Trim()); //mId
objQxUserRoleRelation4SynchEN.IpAddress = objRow[conQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //Ip地址
objQxUserRoleRelation4SynchEN.UserId = objRow[conQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objQxUserRoleRelation4SynchEN.RoleId = objRow[conQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objQxUserRoleRelation4SynchEN.QxPrjId = objRow[conQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //QxPrjId
objQxUserRoleRelation4SynchEN.UpdDate = objRow[conQxUserRoleRelation4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelation4SynchEN.UpdUserId = objRow[conQxUserRoleRelation4Synch.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelation4SynchEN.Memo = objRow[conQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelation4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRoleRelation4SynchEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxUserRoleRelation4SynchEN> arrObjLst = new List<clsQxUserRoleRelation4SynchEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = new clsQxUserRoleRelation4SynchEN();
try
{
objQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[conQxUserRoleRelation4Synch.mId].ToString().Trim()); //mId
objQxUserRoleRelation4SynchEN.IpAddress = objRow[conQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //Ip地址
objQxUserRoleRelation4SynchEN.UserId = objRow[conQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objQxUserRoleRelation4SynchEN.RoleId = objRow[conQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objQxUserRoleRelation4SynchEN.QxPrjId = objRow[conQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //QxPrjId
objQxUserRoleRelation4SynchEN.UpdDate = objRow[conQxUserRoleRelation4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelation4SynchEN.UpdUserId = objRow[conQxUserRoleRelation4Synch.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelation4SynchEN.Memo = objRow[conQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelation4SynchEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserRoleRelation4Synch(ref clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
bool bolResult = QxUserRoleRelation4SynchDA.GetQxUserRoleRelation4Synch(ref objQxUserRoleRelation4SynchEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserRoleRelation4SynchEN GetObjBymId(long lngmId)
{
clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = QxUserRoleRelation4SynchDA.GetObjBymId(lngmId);
return objQxUserRoleRelation4SynchEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxUserRoleRelation4SynchEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = QxUserRoleRelation4SynchDA.GetFirstObj(strWhereCond);
 return objQxUserRoleRelation4SynchEN;
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
public static clsQxUserRoleRelation4SynchEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = QxUserRoleRelation4SynchDA.GetObjByDataRow(objRow);
 return objQxUserRoleRelation4SynchEN;
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
public static clsQxUserRoleRelation4SynchEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = QxUserRoleRelation4SynchDA.GetObjByDataRow(objRow);
 return objQxUserRoleRelation4SynchEN;
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
 /// <param name = "lstQxUserRoleRelation4SynchObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserRoleRelation4SynchEN GetObjBymIdFromList(long lngmId, List<clsQxUserRoleRelation4SynchEN> lstQxUserRoleRelation4SynchObjLst)
{
foreach (clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN in lstQxUserRoleRelation4SynchObjLst)
{
if (objQxUserRoleRelation4SynchEN.mId == lngmId)
{
return objQxUserRoleRelation4SynchEN;
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
 lngmId = new clsQxUserRoleRelation4SynchDA().GetFirstID(strWhereCond);
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
 arrList = QxUserRoleRelation4SynchDA.GetID(strWhereCond);
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
bool bolIsExist = QxUserRoleRelation4SynchDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = QxUserRoleRelation4SynchDA.IsExist(lngmId);
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
clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = clsQxUserRoleRelation4SynchBL.GetObjBymId(lngmId);
objQxUserRoleRelation4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxUserRoleRelation4SynchEN.UpdUserId = strOpUser;
return clsQxUserRoleRelation4SynchBL.UpdateBySql2(objQxUserRoleRelation4SynchEN);
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
 bolIsExist = clsQxUserRoleRelation4SynchDA.IsExistTable();
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
 bolIsExist = QxUserRoleRelation4SynchDA.IsExistTable(strTabName);
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
 /// <param name = "objQxUserRoleRelation4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQxUserRoleRelation4SynchEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!Ip地址 = [{0}],QxPrjId = [{1}],角色Id = [{2}],用户ID = [{3}]的数据已经存在!(in clsQxUserRoleRelation4SynchBL.AddNewRecordBySql2)", objQxUserRoleRelation4SynchEN.IpAddress,objQxUserRoleRelation4SynchEN.QxPrjId,objQxUserRoleRelation4SynchEN.RoleId,objQxUserRoleRelation4SynchEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxUserRoleRelation4SynchDA.AddNewRecordBySQL2(objQxUserRoleRelation4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchBL.ReFreshCache();

if (clsQxUserRoleRelation4SynchBL.relatedActions != null)
{
clsQxUserRoleRelation4SynchBL.relatedActions.UpdRelaTabDate(objQxUserRoleRelation4SynchEN.mId, objQxUserRoleRelation4SynchEN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelation4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQxUserRoleRelation4SynchEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!Ip地址 = [{0}],QxPrjId = [{1}],角色Id = [{2}],用户ID = [{3}]的数据已经存在!(in clsQxUserRoleRelation4SynchBL.AddNewRecordBySql2WithReturnKey)", objQxUserRoleRelation4SynchEN.IpAddress,objQxUserRoleRelation4SynchEN.QxPrjId,objQxUserRoleRelation4SynchEN.RoleId,objQxUserRoleRelation4SynchEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = QxUserRoleRelation4SynchDA.AddNewRecordBySQL2WithReturnKey(objQxUserRoleRelation4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchBL.ReFreshCache();

if (clsQxUserRoleRelation4SynchBL.relatedActions != null)
{
clsQxUserRoleRelation4SynchBL.relatedActions.UpdRelaTabDate(objQxUserRoleRelation4SynchEN.mId, objQxUserRoleRelation4SynchEN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelation4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
try
{
bool bolResult = QxUserRoleRelation4SynchDA.Update(objQxUserRoleRelation4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchBL.ReFreshCache();

if (clsQxUserRoleRelation4SynchBL.relatedActions != null)
{
clsQxUserRoleRelation4SynchBL.relatedActions.UpdRelaTabDate(objQxUserRoleRelation4SynchEN.mId, objQxUserRoleRelation4SynchEN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelation4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
 if (objQxUserRoleRelation4SynchEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxUserRoleRelation4SynchDA.UpdateBySql2(objQxUserRoleRelation4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchBL.ReFreshCache();

if (clsQxUserRoleRelation4SynchBL.relatedActions != null)
{
clsQxUserRoleRelation4SynchBL.relatedActions.UpdRelaTabDate(objQxUserRoleRelation4SynchEN.mId, objQxUserRoleRelation4SynchEN.UpdUserId);
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
 clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = clsQxUserRoleRelation4SynchBL.GetObjBymId(lngmId);

if (clsQxUserRoleRelation4SynchBL.relatedActions != null)
{
clsQxUserRoleRelation4SynchBL.relatedActions.UpdRelaTabDate(objQxUserRoleRelation4SynchEN.mId, objQxUserRoleRelation4SynchEN.UpdUserId);
}
if (objQxUserRoleRelation4SynchEN != null)
{
int intRecNum = QxUserRoleRelation4SynchDA.DelRecord(lngmId);
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
objSQL = clsQxUserRoleRelation4SynchDA.GetSpecSQLObj();
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
//删除与表:[QxUserRoleRelation4Synch]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxUserRoleRelation4Synch.mId,
//lngmId);
//        clsQxUserRoleRelation4SynchBL.DelQxUserRoleRelation4SynchsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUserRoleRelation4SynchBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUserRoleRelation4SynchBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsQxUserRoleRelation4SynchBL.relatedActions != null)
{
clsQxUserRoleRelation4SynchBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = QxUserRoleRelation4SynchDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelQxUserRoleRelation4Synchs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsQxUserRoleRelation4SynchBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsQxUserRoleRelation4SynchBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxUserRoleRelation4SynchDA.DelQxUserRoleRelation4Synch(arrmIdLst);
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
public static int DelQxUserRoleRelation4SynchsByCond(string strWhereCond)
{
try
{
if (clsQxUserRoleRelation4SynchBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsQxUserRoleRelation4SynchBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = QxUserRoleRelation4SynchDA.DelQxUserRoleRelation4Synch(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxUserRoleRelation4Synch]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUserRoleRelation4SynchDA.GetSpecSQLObj();
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
//删除与表:[QxUserRoleRelation4Synch]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUserRoleRelation4SynchBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUserRoleRelation4SynchBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objQxUserRoleRelation4SynchENS">源对象</param>
 /// <param name = "objQxUserRoleRelation4SynchENT">目标对象</param>
 public static void CopyTo(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchENS, clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchENT)
{
try
{
objQxUserRoleRelation4SynchENT.mId = objQxUserRoleRelation4SynchENS.mId; //mId
objQxUserRoleRelation4SynchENT.IpAddress = objQxUserRoleRelation4SynchENS.IpAddress; //Ip地址
objQxUserRoleRelation4SynchENT.UserId = objQxUserRoleRelation4SynchENS.UserId; //用户ID
objQxUserRoleRelation4SynchENT.RoleId = objQxUserRoleRelation4SynchENS.RoleId; //角色Id
objQxUserRoleRelation4SynchENT.QxPrjId = objQxUserRoleRelation4SynchENS.QxPrjId; //QxPrjId
objQxUserRoleRelation4SynchENT.UpdDate = objQxUserRoleRelation4SynchENS.UpdDate; //修改日期
objQxUserRoleRelation4SynchENT.UpdUserId = objQxUserRoleRelation4SynchENS.UpdUserId; //修改用户Id
objQxUserRoleRelation4SynchENT.Memo = objQxUserRoleRelation4SynchENS.Memo; //备注
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
 /// <param name = "objQxUserRoleRelation4SynchEN">源简化对象</param>
 public static void SetUpdFlag(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
try
{
objQxUserRoleRelation4SynchEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxUserRoleRelation4SynchEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxUserRoleRelation4Synch.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRoleRelation4SynchEN.mId = objQxUserRoleRelation4SynchEN.mId; //mId
}
if (arrFldSet.Contains(conQxUserRoleRelation4Synch.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRoleRelation4SynchEN.IpAddress = objQxUserRoleRelation4SynchEN.IpAddress; //Ip地址
}
if (arrFldSet.Contains(conQxUserRoleRelation4Synch.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRoleRelation4SynchEN.UserId = objQxUserRoleRelation4SynchEN.UserId; //用户ID
}
if (arrFldSet.Contains(conQxUserRoleRelation4Synch.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRoleRelation4SynchEN.RoleId = objQxUserRoleRelation4SynchEN.RoleId; //角色Id
}
if (arrFldSet.Contains(conQxUserRoleRelation4Synch.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRoleRelation4SynchEN.QxPrjId = objQxUserRoleRelation4SynchEN.QxPrjId; //QxPrjId
}
if (arrFldSet.Contains(conQxUserRoleRelation4Synch.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRoleRelation4SynchEN.UpdDate = objQxUserRoleRelation4SynchEN.UpdDate == "[null]" ? null :  objQxUserRoleRelation4SynchEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxUserRoleRelation4Synch.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRoleRelation4SynchEN.UpdUserId = objQxUserRoleRelation4SynchEN.UpdUserId == "[null]" ? null :  objQxUserRoleRelation4SynchEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conQxUserRoleRelation4Synch.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRoleRelation4SynchEN.Memo = objQxUserRoleRelation4SynchEN.Memo == "[null]" ? null :  objQxUserRoleRelation4SynchEN.Memo; //备注
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
 /// <param name = "objQxUserRoleRelation4SynchEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
try
{
if (objQxUserRoleRelation4SynchEN.UpdDate == "[null]") objQxUserRoleRelation4SynchEN.UpdDate = null; //修改日期
if (objQxUserRoleRelation4SynchEN.UpdUserId == "[null]") objQxUserRoleRelation4SynchEN.UpdUserId = null; //修改用户Id
if (objQxUserRoleRelation4SynchEN.Memo == "[null]") objQxUserRoleRelation4SynchEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
 QxUserRoleRelation4SynchDA.CheckPropertyNew(objQxUserRoleRelation4SynchEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
 QxUserRoleRelation4SynchDA.CheckProperty4Condition(objQxUserRoleRelation4SynchEN);
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
if (clsQxUserRoleRelation4SynchBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserRoleRelation4SynchBL没有刷新缓存机制(clsQxUserRoleRelation4SynchBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrQxUserRoleRelation4SynchObjLstCache == null)
//{
//arrQxUserRoleRelation4SynchObjLstCache = QxUserRoleRelation4SynchDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserRoleRelation4SynchEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxUserRoleRelation4SynchEN._CurrTabName);
List<clsQxUserRoleRelation4SynchEN> arrQxUserRoleRelation4SynchObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRoleRelation4SynchEN> arrQxUserRoleRelation4SynchObjLst_Sel =
arrQxUserRoleRelation4SynchObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrQxUserRoleRelation4SynchObjLst_Sel.Count() == 0)
{
   clsQxUserRoleRelation4SynchEN obj = clsQxUserRoleRelation4SynchBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxUserRoleRelation4SynchObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserRoleRelation4SynchEN> GetAllQxUserRoleRelation4SynchObjLstCache()
{
//获取缓存中的对象列表
List<clsQxUserRoleRelation4SynchEN> arrQxUserRoleRelation4SynchObjLstCache = GetObjLstCache(); 
return arrQxUserRoleRelation4SynchObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserRoleRelation4SynchEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxUserRoleRelation4SynchEN._CurrTabName);
List<clsQxUserRoleRelation4SynchEN> arrQxUserRoleRelation4SynchObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxUserRoleRelation4SynchObjLstCache;
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
string strKey = string.Format("{0}", clsQxUserRoleRelation4SynchEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUserRoleRelation4SynchEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsQxUserRoleRelation4SynchEN._RefreshTimeLst.Count == 0) return "";
return clsQxUserRoleRelation4SynchEN._RefreshTimeLst[clsQxUserRoleRelation4SynchEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsQxUserRoleRelation4SynchBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUserRoleRelation4SynchEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUserRoleRelation4SynchEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsQxUserRoleRelation4SynchBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxUserRoleRelation4Synch(QxUserRoleRelation4Synch)
 /// 唯一性条件:IpAddress_QxPrjId_RoleId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
//检测记录是否存在
string strResult = QxUserRoleRelation4SynchDA.GetUniCondStr(objQxUserRoleRelation4SynchEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conQxUserRoleRelation4Synch.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxUserRoleRelation4Synch.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxUserRoleRelation4Synch.AttributeName));
throw new Exception(strMsg);
}
var objQxUserRoleRelation4Synch = clsQxUserRoleRelation4SynchBL.GetObjBymIdCache(lngmId);
if (objQxUserRoleRelation4Synch == null) return "";
return objQxUserRoleRelation4Synch[strOutFldName].ToString();
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
int intRecCount = clsQxUserRoleRelation4SynchDA.GetRecCount(strTabName);
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
int intRecCount = clsQxUserRoleRelation4SynchDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxUserRoleRelation4SynchDA.GetRecCount();
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
int intRecCount = clsQxUserRoleRelation4SynchDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchCond)
{
List<clsQxUserRoleRelation4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRoleRelation4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserRoleRelation4Synch.AttributeName)
{
if (objQxUserRoleRelation4SynchCond.IsUpdated(strFldName) == false) continue;
if (objQxUserRoleRelation4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRoleRelation4SynchCond[strFldName].ToString());
}
else
{
if (objQxUserRoleRelation4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserRoleRelation4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRoleRelation4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserRoleRelation4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserRoleRelation4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserRoleRelation4SynchCond[strFldName]));
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
 List<string> arrList = clsQxUserRoleRelation4SynchDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxUserRoleRelation4SynchDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxUserRoleRelation4SynchDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxUserRoleRelation4SynchDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUserRoleRelation4SynchDA.SetFldValue(clsQxUserRoleRelation4SynchEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxUserRoleRelation4SynchDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUserRoleRelation4SynchDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUserRoleRelation4SynchDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUserRoleRelation4SynchDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxUserRoleRelation4Synch] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**Ip地址*/ 
 strCreateTabCode.Append(" IpAddress varchar(50) not Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**角色Id*/ 
 strCreateTabCode.Append(" RoleId char(8) not Null, "); 
 // /**QxPrjId*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
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
 /// QxUserRoleRelation4Synch(QxUserRoleRelation4Synch)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxUserRoleRelation4Synch : clsCommFun4BL
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
clsQxUserRoleRelation4SynchBL.ReFreshThisCache();
}
}

}