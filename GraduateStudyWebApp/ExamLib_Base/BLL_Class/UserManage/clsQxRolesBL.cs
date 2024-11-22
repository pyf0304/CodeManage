﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRolesBL
 表名:QxRoles(01120920)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
public static class  clsQxRolesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxRolesEN GetObj(this K_RoleId_QxRoles myKey)
{
clsQxRolesEN objQxRolesEN = clsQxRolesBL.QxRolesDA.GetObjByRoleId(myKey.Value);
return objQxRolesEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxRolesEN objQxRolesEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objQxRolesEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxRolesBL.IsExist(objQxRolesEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxRolesEN.RoleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsQxRolesBL.QxRolesDA.AddNewRecordBySQL2(objQxRolesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesBL.ReFreshCache();

if (clsQxRolesBL.relatedActions != null)
{
clsQxRolesBL.relatedActions.UpdRelaTabDate(objQxRolesEN.RoleId, objQxRolesEN.UpdUserId);
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
public static bool AddRecordEx(this clsQxRolesEN objQxRolesEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsQxRolesBL.IsExist(objQxRolesEN.RoleId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objQxRolesEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objQxRolesEN.AddNewRecord();
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
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxRolesEN objQxRolesEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objQxRolesEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxRolesBL.IsExist(objQxRolesEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxRolesEN.RoleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsQxRolesBL.QxRolesDA.AddNewRecordBySQL2WithReturnKey(objQxRolesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesBL.ReFreshCache();

if (clsQxRolesBL.relatedActions != null)
{
clsQxRolesBL.relatedActions.UpdRelaTabDate(objQxRolesEN.RoleId, objQxRolesEN.UpdUserId);
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
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetRoleId(this clsQxRolesEN objQxRolesEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, conQxRoles.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQxRoles.RoleId);
}
objQxRolesEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.RoleId) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.RoleId, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.RoleId] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetRoleName(this clsQxRolesEN objQxRolesEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, conQxRoles.RoleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleName, 100, conQxRoles.RoleName);
}
objQxRolesEN.RoleName = strRoleName; //角色名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.RoleName) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.RoleName, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.RoleName] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetRoleENName(this clsQxRolesEN objQxRolesEN, string strRoleENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleENName, 50, conQxRoles.RoleENName);
}
objQxRolesEN.RoleENName = strRoleENName; //角色英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.RoleENName) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.RoleENName, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.RoleENName] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetRoleIndex(this clsQxRolesEN objQxRolesEN, int? intRoleIndex, string strComparisonOp="")
	{
objQxRolesEN.RoleIndex = intRoleIndex; //角色序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.RoleIndex) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.RoleIndex, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.RoleIndex] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetQxPrjId(this clsQxRolesEN objQxRolesEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxRoles.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxRoles.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxRoles.QxPrjId);
}
objQxRolesEN.QxPrjId = strQxPrjId; //QxPrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.QxPrjId) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.QxPrjId, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.QxPrjId] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetIsInUse(this clsQxRolesEN objQxRolesEN, bool bolIsInUse, string strComparisonOp="")
	{
objQxRolesEN.IsInUse = bolIsInUse; //IsInUse
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.IsInUse) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.IsInUse, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.IsInUse] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetUpdDate(this clsQxRolesEN objQxRolesEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxRoles.UpdDate);
}
objQxRolesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.UpdDate) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.UpdDate, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.UpdDate] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetUpdUserId(this clsQxRolesEN objQxRolesEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxRoles.UpdUserId);
}
objQxRolesEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.UpdUserId) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.UpdUserId, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.UpdUserId] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetMemo(this clsQxRolesEN objQxRolesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxRoles.Memo);
}
objQxRolesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.Memo) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.Memo, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.Memo] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetUserType(this clsQxRolesEN objQxRolesEN, string strUserType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserType, 50, conQxRoles.UserType);
}
objQxRolesEN.UserType = strUserType; //用户类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.UserType) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.UserType, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.UserType] = strComparisonOp;
}
}
return objQxRolesEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxRolesEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxRolesEN objQxRolesEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxRolesEN.CheckPropertyNew();
clsQxRolesEN objQxRolesCond = new clsQxRolesEN();
string strCondition = objQxRolesCond
.SetRoleId(objQxRolesEN.RoleId, "=")
.GetCombineCondition();
objQxRolesEN._IsCheckProperty = true;
bool bolIsExist = clsQxRolesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxRolesEN.Update();
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
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxRolesEN objQxRolesEN)
{
 if (string.IsNullOrEmpty(objQxRolesEN.RoleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxRolesBL.QxRolesDA.UpdateBySql2(objQxRolesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesBL.ReFreshCache();

if (clsQxRolesBL.relatedActions != null)
{
clsQxRolesBL.relatedActions.UpdRelaTabDate(objQxRolesEN.RoleId, objQxRolesEN.UpdUserId);
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
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxRolesEN objQxRolesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxRolesEN.RoleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxRolesBL.QxRolesDA.UpdateBySql2(objQxRolesEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesBL.ReFreshCache();

if (clsQxRolesBL.relatedActions != null)
{
clsQxRolesBL.relatedActions.UpdRelaTabDate(objQxRolesEN.RoleId, objQxRolesEN.UpdUserId);
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
 /// <param name = "objQxRolesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxRolesEN objQxRolesEN, string strWhereCond)
{
try
{
bool bolResult = clsQxRolesBL.QxRolesDA.UpdateBySqlWithCondition(objQxRolesEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesBL.ReFreshCache();

if (clsQxRolesBL.relatedActions != null)
{
clsQxRolesBL.relatedActions.UpdRelaTabDate(objQxRolesEN.RoleId, objQxRolesEN.UpdUserId);
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
 /// <param name = "objQxRolesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxRolesEN objQxRolesEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxRolesBL.QxRolesDA.UpdateBySqlWithConditionTransaction(objQxRolesEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesBL.ReFreshCache();

if (clsQxRolesBL.relatedActions != null)
{
clsQxRolesBL.relatedActions.UpdRelaTabDate(objQxRolesEN.RoleId, objQxRolesEN.UpdUserId);
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
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxRolesEN objQxRolesEN)
{
try
{
int intRecNum = clsQxRolesBL.QxRolesDA.DelRecord(objQxRolesEN.RoleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesBL.ReFreshCache();

if (clsQxRolesBL.relatedActions != null)
{
clsQxRolesBL.relatedActions.UpdRelaTabDate(objQxRolesEN.RoleId, objQxRolesEN.UpdUserId);
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
 /// <param name = "objQxRolesENS">源对象</param>
 /// <param name = "objQxRolesENT">目标对象</param>
 public static void CopyTo(this clsQxRolesEN objQxRolesENS, clsQxRolesEN objQxRolesENT)
{
try
{
objQxRolesENT.RoleId = objQxRolesENS.RoleId; //角色Id
objQxRolesENT.RoleName = objQxRolesENS.RoleName; //角色名
objQxRolesENT.RoleENName = objQxRolesENS.RoleENName; //角色英文名
objQxRolesENT.RoleIndex = objQxRolesENS.RoleIndex; //角色序号
objQxRolesENT.QxPrjId = objQxRolesENS.QxPrjId; //QxPrjId
objQxRolesENT.IsInUse = objQxRolesENS.IsInUse; //IsInUse
objQxRolesENT.UpdDate = objQxRolesENS.UpdDate; //修改日期
objQxRolesENT.UpdUserId = objQxRolesENS.UpdUserId; //修改用户Id
objQxRolesENT.Memo = objQxRolesENS.Memo; //备注
objQxRolesENT.UserType = objQxRolesENS.UserType; //用户类型
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
 /// <param name = "objQxRolesENS">源对象</param>
 /// <returns>目标对象=>clsQxRolesEN:objQxRolesENT</returns>
 public static clsQxRolesEN CopyTo(this clsQxRolesEN objQxRolesENS)
{
try
{
 clsQxRolesEN objQxRolesENT = new clsQxRolesEN()
{
RoleId = objQxRolesENS.RoleId, //角色Id
RoleName = objQxRolesENS.RoleName, //角色名
RoleENName = objQxRolesENS.RoleENName, //角色英文名
RoleIndex = objQxRolesENS.RoleIndex, //角色序号
QxPrjId = objQxRolesENS.QxPrjId, //QxPrjId
IsInUse = objQxRolesENS.IsInUse, //IsInUse
UpdDate = objQxRolesENS.UpdDate, //修改日期
UpdUserId = objQxRolesENS.UpdUserId, //修改用户Id
Memo = objQxRolesENS.Memo, //备注
UserType = objQxRolesENS.UserType, //用户类型
};
 return objQxRolesENT;
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
public static void CheckPropertyNew(this clsQxRolesEN objQxRolesEN)
{
 clsQxRolesBL.QxRolesDA.CheckPropertyNew(objQxRolesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxRolesEN objQxRolesEN)
{
 clsQxRolesBL.QxRolesDA.CheckProperty4Condition(objQxRolesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxRolesEN objQxRolesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxRolesCond.IsUpdated(conQxRoles.RoleId) == true)
{
string strComparisonOpRoleId = objQxRolesCond.dicFldComparisonOp[conQxRoles.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.RoleId, objQxRolesCond.RoleId, strComparisonOpRoleId);
}
if (objQxRolesCond.IsUpdated(conQxRoles.RoleName) == true)
{
string strComparisonOpRoleName = objQxRolesCond.dicFldComparisonOp[conQxRoles.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.RoleName, objQxRolesCond.RoleName, strComparisonOpRoleName);
}
if (objQxRolesCond.IsUpdated(conQxRoles.RoleENName) == true)
{
string strComparisonOpRoleENName = objQxRolesCond.dicFldComparisonOp[conQxRoles.RoleENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.RoleENName, objQxRolesCond.RoleENName, strComparisonOpRoleENName);
}
if (objQxRolesCond.IsUpdated(conQxRoles.RoleIndex) == true)
{
string strComparisonOpRoleIndex = objQxRolesCond.dicFldComparisonOp[conQxRoles.RoleIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conQxRoles.RoleIndex, objQxRolesCond.RoleIndex, strComparisonOpRoleIndex);
}
if (objQxRolesCond.IsUpdated(conQxRoles.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxRolesCond.dicFldComparisonOp[conQxRoles.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.QxPrjId, objQxRolesCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxRolesCond.IsUpdated(conQxRoles.IsInUse) == true)
{
if (objQxRolesCond.IsInUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxRoles.IsInUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxRoles.IsInUse);
}
}
if (objQxRolesCond.IsUpdated(conQxRoles.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxRolesCond.dicFldComparisonOp[conQxRoles.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.UpdDate, objQxRolesCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxRolesCond.IsUpdated(conQxRoles.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxRolesCond.dicFldComparisonOp[conQxRoles.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.UpdUserId, objQxRolesCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxRolesCond.IsUpdated(conQxRoles.Memo) == true)
{
string strComparisonOpMemo = objQxRolesCond.dicFldComparisonOp[conQxRoles.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.Memo, objQxRolesCond.Memo, strComparisonOpMemo);
}
if (objQxRolesCond.IsUpdated(conQxRoles.UserType) == true)
{
string strComparisonOpUserType = objQxRolesCond.dicFldComparisonOp[conQxRoles.UserType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.UserType, objQxRolesCond.UserType, strComparisonOpUserType);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxRoles
{
public virtual bool UpdRelaTabDate(string strRoleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumQxRoles
{
 /// <summary>
 /// 统一平台总管理员
 /// </summary>
public const string UP_Admin_00010001 = "00010001";
 /// <summary>
 /// 项目管理员
 /// </summary>
public const string Project_Admin_00010002 = "00010002";
 /// <summary>
 /// 高级用户
 /// </summary>
public const string Advanced_User_00010003 = "00010003";
 /// <summary>
 /// 普通用户
 /// </summary>
public const string Regular_User_00010004 = "00010004";
 /// <summary>
 /// 无
 /// </summary>
public const string none_00620000 = "00620000";
 /// <summary>
 /// 系统管理员
 /// </summary>
public const string System_Admin_00620001 = "00620001";
 /// <summary>
 /// 普通教师
 /// </summary>
public const string Regular_Teacher_00620002 = "00620002";
 /// <summary>
 /// 普通学生
 /// </summary>
public const string Regular_Student_00620003 = "00620003";
 /// <summary>
 /// 小组长(微格)
 /// </summary>
public const string Group_Leader_00620005 = "00620005";
 /// <summary>
 /// 中小学实习指导老师
 /// </summary>
public const string Mentor_for_K_12_Internship_00620006 = "00620006";
 /// <summary>
 /// 学工办辅导员
 /// </summary>
public const string Student_Affairs_Counselor_00620007 = "00620007";
 /// <summary>
 /// 实习指导老师
 /// </summary>
public const string Internship_Mentor_00620008 = "00620008";
 /// <summary>
 /// 指导老师（微格）
 /// </summary>
public const string Mentor_00620009 = "00620009";
 /// <summary>
 /// 评审专家
 /// </summary>
public const string Review_Expert_00620010 = "00620010";
 /// <summary>
 /// 教务处
 /// </summary>
public const string Academic_Affairs_Office_00620011 = "00620011";
 /// <summary>
 /// 案例维护
 /// </summary>
public const string Case_Maintenance_00620012 = "00620012";
 /// <summary>
 /// 中小学教师
 /// </summary>
public const string K_12_Teacher_00620013 = "00620013";
 /// <summary>
 /// 教师(交建)
 /// </summary>
public const string Construction_and_Building_00620014 = "00620014";
 /// <summary>
 /// 交建答题学生
 /// </summary>
public const string Construction_and_Building_Answering_Student_00620015 = "00620015";
 /// <summary>
 /// 语音学生
 /// </summary>
public const string Voice_Student_00620016 = "00620016";
 /// <summary>
 /// 中学学生
 /// </summary>
public const string High_School_Student_00620017 = "00620017";
 /// <summary>
 /// 中学系统管理员
 /// </summary>
public const string Secondary_School_System_Admin_00620018 = "00620018";
 /// <summary>
 /// 系统管理员
 /// </summary>
public const string System_Admin_01030001 = "01030001";
}
 /// <summary>
 /// 角色(QxRoles)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxRolesBL
{
public static RelatedActions_QxRoles relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxRolesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxRolesDA QxRolesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxRolesDA();
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
 public clsQxRolesBL()
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
if (string.IsNullOrEmpty(clsQxRolesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxRolesEN._ConnectString);
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
public static DataTable GetDataTable_QxRoles(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxRolesDA.GetDataTable_QxRoles(strWhereCond);
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
objDT = QxRolesDA.GetDataTable(strWhereCond);
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
objDT = QxRolesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxRolesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxRolesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxRolesDA.GetDataTable_Top(objTopPara);
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
objDT = QxRolesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxRolesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxRolesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRoleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxRolesEN> GetObjLstByRoleIdLst(List<string> arrRoleIdLst)
{
List<clsQxRolesEN> arrObjLst = new List<clsQxRolesEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRoleIdLst, true);
 string strWhereCond = string.Format("RoleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名
objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号
objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //QxPrjId
objQxRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[conQxRoles.IsInUse].ToString().Trim()); //IsInUse
objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注
objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRoleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxRolesEN> GetObjLstByRoleIdLstCache(List<string> arrRoleIdLst)
{
string strKey = string.Format("{0}", clsQxRolesEN._CurrTabName);
List<clsQxRolesEN> arrQxRolesObjLstCache = GetObjLstCache();
IEnumerable <clsQxRolesEN> arrQxRolesObjLst_Sel =
arrQxRolesObjLstCache
.Where(x => arrRoleIdLst.Contains(x.RoleId));
return arrQxRolesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRolesEN> GetObjLst(string strWhereCond)
{
List<clsQxRolesEN> arrObjLst = new List<clsQxRolesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名
objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号
objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //QxPrjId
objQxRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[conQxRoles.IsInUse].ToString().Trim()); //IsInUse
objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注
objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolesEN);
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
public static List<clsQxRolesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxRolesEN> arrObjLst = new List<clsQxRolesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名
objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号
objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //QxPrjId
objQxRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[conQxRoles.IsInUse].ToString().Trim()); //IsInUse
objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注
objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxRolesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxRolesEN> GetSubObjLstCache(clsQxRolesEN objQxRolesCond)
{
List<clsQxRolesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxRolesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxRoles.AttributeName)
{
if (objQxRolesCond.IsUpdated(strFldName) == false) continue;
if (objQxRolesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRolesCond[strFldName].ToString());
}
else
{
if (objQxRolesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxRolesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRolesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxRolesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxRolesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxRolesCond[strFldName]));
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
public static List<clsQxRolesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxRolesEN> arrObjLst = new List<clsQxRolesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名
objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号
objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //QxPrjId
objQxRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[conQxRoles.IsInUse].ToString().Trim()); //IsInUse
objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注
objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolesEN);
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
public static List<clsQxRolesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxRolesEN> arrObjLst = new List<clsQxRolesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名
objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号
objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //QxPrjId
objQxRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[conQxRoles.IsInUse].ToString().Trim()); //IsInUse
objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注
objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolesEN);
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
List<clsQxRolesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxRolesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRolesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxRolesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxRolesEN> arrObjLst = new List<clsQxRolesEN>(); 
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
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名
objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号
objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //QxPrjId
objQxRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[conQxRoles.IsInUse].ToString().Trim()); //IsInUse
objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注
objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolesEN);
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
public static List<clsQxRolesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxRolesEN> arrObjLst = new List<clsQxRolesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名
objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号
objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //QxPrjId
objQxRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[conQxRoles.IsInUse].ToString().Trim()); //IsInUse
objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注
objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxRolesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxRolesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxRolesEN> arrObjLst = new List<clsQxRolesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名
objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号
objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //QxPrjId
objQxRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[conQxRoles.IsInUse].ToString().Trim()); //IsInUse
objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注
objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolesEN);
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
public static List<clsQxRolesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxRolesEN> arrObjLst = new List<clsQxRolesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名
objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号
objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //QxPrjId
objQxRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[conQxRoles.IsInUse].ToString().Trim()); //IsInUse
objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注
objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRolesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxRolesEN> arrObjLst = new List<clsQxRolesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolesEN objQxRolesEN = new clsQxRolesEN();
try
{
objQxRolesEN.RoleId = objRow[conQxRoles.RoleId].ToString().Trim(); //角色Id
objQxRolesEN.RoleName = objRow[conQxRoles.RoleName].ToString().Trim(); //角色名
objQxRolesEN.RoleENName = objRow[conQxRoles.RoleENName] == DBNull.Value ? null : objRow[conQxRoles.RoleENName].ToString().Trim(); //角色英文名
objQxRolesEN.RoleIndex = objRow[conQxRoles.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxRoles.RoleIndex].ToString().Trim()); //角色序号
objQxRolesEN.QxPrjId = objRow[conQxRoles.QxPrjId].ToString().Trim(); //QxPrjId
objQxRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[conQxRoles.IsInUse].ToString().Trim()); //IsInUse
objQxRolesEN.UpdDate = objRow[conQxRoles.UpdDate] == DBNull.Value ? null : objRow[conQxRoles.UpdDate].ToString().Trim(); //修改日期
objQxRolesEN.UpdUserId = objRow[conQxRoles.UpdUserId] == DBNull.Value ? null : objRow[conQxRoles.UpdUserId].ToString().Trim(); //修改用户Id
objQxRolesEN.Memo = objRow[conQxRoles.Memo] == DBNull.Value ? null : objRow[conQxRoles.Memo].ToString().Trim(); //备注
objQxRolesEN.UserType = objRow[conQxRoles.UserType] == DBNull.Value ? null : objRow[conQxRoles.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxRolesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxRoles(ref clsQxRolesEN objQxRolesEN)
{
bool bolResult = QxRolesDA.GetQxRoles(ref objQxRolesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxRolesEN GetObjByRoleId(string strRoleId)
{
if (strRoleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRoleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRoleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRoleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxRolesEN objQxRolesEN = QxRolesDA.GetObjByRoleId(strRoleId);
return objQxRolesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxRolesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxRolesEN objQxRolesEN = QxRolesDA.GetFirstObj(strWhereCond);
 return objQxRolesEN;
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
public static clsQxRolesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxRolesEN objQxRolesEN = QxRolesDA.GetObjByDataRow(objRow);
 return objQxRolesEN;
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
public static clsQxRolesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxRolesEN objQxRolesEN = QxRolesDA.GetObjByDataRow(objRow);
 return objQxRolesEN;
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
 /// <param name = "strRoleId">所给的关键字</param>
 /// <param name = "lstQxRolesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxRolesEN GetObjByRoleIdFromList(string strRoleId, List<clsQxRolesEN> lstQxRolesObjLst)
{
foreach (clsQxRolesEN objQxRolesEN in lstQxRolesObjLst)
{
if (objQxRolesEN.RoleId == strRoleId)
{
return objQxRolesEN;
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
 string strRoleId;
 try
 {
 strRoleId = new clsQxRolesDA().GetFirstID(strWhereCond);
 return strRoleId;
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
 arrList = QxRolesDA.GetID(strWhereCond);
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
bool bolIsExist = QxRolesDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRoleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QxRolesDA.IsExist(strRoleId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strRoleId">角色Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strRoleId, string strOpUser)
{
clsQxRolesEN objQxRolesEN = clsQxRolesBL.GetObjByRoleId(strRoleId);
objQxRolesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxRolesEN.UpdUserId = strOpUser;
return clsQxRolesBL.UpdateBySql2(objQxRolesEN);
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
 bolIsExist = clsQxRolesDA.IsExistTable();
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
 bolIsExist = QxRolesDA.IsExistTable(strTabName);
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
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxRolesEN objQxRolesEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objQxRolesEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxRolesBL.IsExist(objQxRolesEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxRolesEN.RoleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = QxRolesDA.AddNewRecordBySQL2(objQxRolesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesBL.ReFreshCache();

if (clsQxRolesBL.relatedActions != null)
{
clsQxRolesBL.relatedActions.UpdRelaTabDate(objQxRolesEN.RoleId, objQxRolesEN.UpdUserId);
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
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxRolesEN objQxRolesEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objQxRolesEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxRolesBL.IsExist(objQxRolesEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxRolesEN.RoleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = QxRolesDA.AddNewRecordBySQL2WithReturnKey(objQxRolesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesBL.ReFreshCache();

if (clsQxRolesBL.relatedActions != null)
{
clsQxRolesBL.relatedActions.UpdRelaTabDate(objQxRolesEN.RoleId, objQxRolesEN.UpdUserId);
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
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxRolesEN objQxRolesEN)
{
try
{
bool bolResult = QxRolesDA.Update(objQxRolesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesBL.ReFreshCache();

if (clsQxRolesBL.relatedActions != null)
{
clsQxRolesBL.relatedActions.UpdRelaTabDate(objQxRolesEN.RoleId, objQxRolesEN.UpdUserId);
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
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxRolesEN objQxRolesEN)
{
 if (string.IsNullOrEmpty(objQxRolesEN.RoleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxRolesDA.UpdateBySql2(objQxRolesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesBL.ReFreshCache();

if (clsQxRolesBL.relatedActions != null)
{
clsQxRolesBL.relatedActions.UpdRelaTabDate(objQxRolesEN.RoleId, objQxRolesEN.UpdUserId);
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
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strRoleId)
{
try
{
 clsQxRolesEN objQxRolesEN = clsQxRolesBL.GetObjByRoleId(strRoleId);

if (clsQxRolesBL.relatedActions != null)
{
clsQxRolesBL.relatedActions.UpdRelaTabDate(objQxRolesEN.RoleId, objQxRolesEN.UpdUserId);
}
if (objQxRolesEN != null)
{
int intRecNum = QxRolesDA.DelRecord(strRoleId);
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
/// <param name="strRoleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strRoleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxRolesDA.GetSpecSQLObj();
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
//删除与表:[QxRoles]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxRoles.RoleId,
//strRoleId);
//        clsQxRolesBL.DelQxRolessByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxRolesBL.DelRecord(strRoleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxRolesBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRoleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strRoleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxRolesBL.relatedActions != null)
{
clsQxRolesBL.relatedActions.UpdRelaTabDate(strRoleId, "UpdRelaTabDate");
}
bool bolResult = QxRolesDA.DelRecord(strRoleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrRoleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxRoless(List<string> arrRoleIdLst)
{
if (arrRoleIdLst.Count == 0) return 0;
try
{
if (clsQxRolesBL.relatedActions != null)
{
foreach (var strRoleId in arrRoleIdLst)
{
clsQxRolesBL.relatedActions.UpdRelaTabDate(strRoleId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxRolesDA.DelQxRoles(arrRoleIdLst);
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
public static int DelQxRolessByCond(string strWhereCond)
{
try
{
if (clsQxRolesBL.relatedActions != null)
{
List<string> arrRoleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRoleId in arrRoleId)
{
clsQxRolesBL.relatedActions.UpdRelaTabDate(strRoleId, "UpdRelaTabDate");
}
}
int intRecNum = QxRolesDA.DelQxRoles(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxRoles]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strRoleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strRoleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxRolesDA.GetSpecSQLObj();
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
//删除与表:[QxRoles]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxRolesBL.DelRecord(strRoleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxRolesBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRoleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxRolesENS">源对象</param>
 /// <param name = "objQxRolesENT">目标对象</param>
 public static void CopyTo(clsQxRolesEN objQxRolesENS, clsQxRolesEN objQxRolesENT)
{
try
{
objQxRolesENT.RoleId = objQxRolesENS.RoleId; //角色Id
objQxRolesENT.RoleName = objQxRolesENS.RoleName; //角色名
objQxRolesENT.RoleENName = objQxRolesENS.RoleENName; //角色英文名
objQxRolesENT.RoleIndex = objQxRolesENS.RoleIndex; //角色序号
objQxRolesENT.QxPrjId = objQxRolesENS.QxPrjId; //QxPrjId
objQxRolesENT.IsInUse = objQxRolesENS.IsInUse; //IsInUse
objQxRolesENT.UpdDate = objQxRolesENS.UpdDate; //修改日期
objQxRolesENT.UpdUserId = objQxRolesENS.UpdUserId; //修改用户Id
objQxRolesENT.Memo = objQxRolesENS.Memo; //备注
objQxRolesENT.UserType = objQxRolesENS.UserType; //用户类型
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
 /// <param name = "objQxRolesEN">源简化对象</param>
 public static void SetUpdFlag(clsQxRolesEN objQxRolesEN)
{
try
{
objQxRolesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxRolesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxRoles.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolesEN.RoleId = objQxRolesEN.RoleId; //角色Id
}
if (arrFldSet.Contains(conQxRoles.RoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolesEN.RoleName = objQxRolesEN.RoleName; //角色名
}
if (arrFldSet.Contains(conQxRoles.RoleENName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolesEN.RoleENName = objQxRolesEN.RoleENName == "[null]" ? null :  objQxRolesEN.RoleENName; //角色英文名
}
if (arrFldSet.Contains(conQxRoles.RoleIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolesEN.RoleIndex = objQxRolesEN.RoleIndex; //角色序号
}
if (arrFldSet.Contains(conQxRoles.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolesEN.QxPrjId = objQxRolesEN.QxPrjId; //QxPrjId
}
if (arrFldSet.Contains(conQxRoles.IsInUse, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolesEN.IsInUse = objQxRolesEN.IsInUse; //IsInUse
}
if (arrFldSet.Contains(conQxRoles.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolesEN.UpdDate = objQxRolesEN.UpdDate == "[null]" ? null :  objQxRolesEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxRoles.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolesEN.UpdUserId = objQxRolesEN.UpdUserId == "[null]" ? null :  objQxRolesEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conQxRoles.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolesEN.Memo = objQxRolesEN.Memo == "[null]" ? null :  objQxRolesEN.Memo; //备注
}
if (arrFldSet.Contains(conQxRoles.UserType, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolesEN.UserType = objQxRolesEN.UserType == "[null]" ? null :  objQxRolesEN.UserType; //用户类型
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
 /// <param name = "objQxRolesEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxRolesEN objQxRolesEN)
{
try
{
if (objQxRolesEN.RoleENName == "[null]") objQxRolesEN.RoleENName = null; //角色英文名
if (objQxRolesEN.UpdDate == "[null]") objQxRolesEN.UpdDate = null; //修改日期
if (objQxRolesEN.UpdUserId == "[null]") objQxRolesEN.UpdUserId = null; //修改用户Id
if (objQxRolesEN.Memo == "[null]") objQxRolesEN.Memo = null; //备注
if (objQxRolesEN.UserType == "[null]") objQxRolesEN.UserType = null; //用户类型
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
public static void CheckPropertyNew(clsQxRolesEN objQxRolesEN)
{
 QxRolesDA.CheckPropertyNew(objQxRolesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxRolesEN objQxRolesEN)
{
 QxRolesDA.CheckProperty4Condition(objQxRolesEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strQxPrjId"></param>
public static void BindCbo_RoleId(System.Windows.Forms.ComboBox objComboBox , string strQxPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxRoles.RoleId); 
List<clsQxRolesEN> arrObjLst = clsQxRolesBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.QxPrjId == strQxPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxRolesEN objQxRolesEN = new clsQxRolesEN()
{
RoleId = "0",
RoleName = "选[角色]..."
};
arrObjLstSel.Insert(0, objQxRolesEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxRoles.RoleId;
objComboBox.DisplayMember = conQxRoles.RoleName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strQxPrjId"></param>
public static void BindDdl_RoleId(System.Web.UI.WebControls.DropDownList objDDL , string strQxPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[角色]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conQxRoles.RoleId); 
IEnumerable<clsQxRolesEN> arrObjLst = clsQxRolesBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.QxPrjId == strQxPrjId).ToList();
objDDL.DataValueField = conQxRoles.RoleId;
objDDL.DataTextField = conQxRoles.RoleName;
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
public static void BindDdl_RoleIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[角色]...","0");
List<clsQxRolesEN> arrQxRolesObjLst = GetAllQxRolesObjLstCache(); 
objDDL.DataValueField = conQxRoles.RoleId;
objDDL.DataTextField = conQxRoles.RoleName;
objDDL.DataSource = arrQxRolesObjLst;
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
if (clsQxRolesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRolesBL没有刷新缓存机制(clsQxRolesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RoleId");
//if (arrQxRolesObjLstCache == null)
//{
//arrQxRolesObjLstCache = QxRolesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxRolesEN GetObjByRoleIdCache(string strRoleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxRolesEN._CurrTabName);
List<clsQxRolesEN> arrQxRolesObjLstCache = GetObjLstCache();
IEnumerable <clsQxRolesEN> arrQxRolesObjLst_Sel =
arrQxRolesObjLstCache
.Where(x=> x.RoleId == strRoleId 
);
if (arrQxRolesObjLst_Sel.Count() == 0)
{
   clsQxRolesEN obj = clsQxRolesBL.GetObjByRoleId(strRoleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxRolesObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRoleNameByRoleIdCache(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return "";
//获取缓存中的对象列表
clsQxRolesEN objQxRoles = GetObjByRoleIdCache(strRoleId);
if (objQxRoles == null) return "";
return objQxRoles.RoleName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRoleIdCache(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return "";
//获取缓存中的对象列表
clsQxRolesEN objQxRoles = GetObjByRoleIdCache(strRoleId);
if (objQxRoles == null) return "";
return objQxRoles.RoleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxRolesEN> GetAllQxRolesObjLstCache()
{
//获取缓存中的对象列表
List<clsQxRolesEN> arrQxRolesObjLstCache = GetObjLstCache(); 
return arrQxRolesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxRolesEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxRolesEN._CurrTabName);
List<clsQxRolesEN> arrQxRolesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxRolesObjLstCache;
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
string strKey = string.Format("{0}", clsQxRolesEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxRolesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsQxRolesEN._RefreshTimeLst.Count == 0) return "";
return clsQxRolesEN._RefreshTimeLst[clsQxRolesEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsQxRolesBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxRolesEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxRolesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsQxRolesBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strRoleId)
{
if (strInFldName != conQxRoles.RoleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxRoles.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxRoles.AttributeName));
throw new Exception(strMsg);
}
var objQxRoles = clsQxRolesBL.GetObjByRoleIdCache(strRoleId);
if (objQxRoles == null) return "";
return objQxRoles[strOutFldName].ToString();
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
int intRecCount = clsQxRolesDA.GetRecCount(strTabName);
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
int intRecCount = clsQxRolesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxRolesDA.GetRecCount();
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
int intRecCount = clsQxRolesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxRolesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxRolesEN objQxRolesCond)
{
List<clsQxRolesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxRolesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxRoles.AttributeName)
{
if (objQxRolesCond.IsUpdated(strFldName) == false) continue;
if (objQxRolesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRolesCond[strFldName].ToString());
}
else
{
if (objQxRolesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxRolesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRolesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxRolesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxRolesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxRolesCond[strFldName]));
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
 List<string> arrList = clsQxRolesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxRolesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxRolesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxRolesDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxRolesDA.SetFldValue(clsQxRolesEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxRolesDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxRolesDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxRolesDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxRolesDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxRoles] "); 
 strCreateTabCode.Append(" ( "); 
 // /**角色Id*/ 
 strCreateTabCode.Append(" RoleId char(8) primary key, "); 
 // /**角色名*/ 
 strCreateTabCode.Append(" RoleName varchar(100) not Null, "); 
 // /**角色英文名*/ 
 strCreateTabCode.Append(" RoleENName varchar(50) Null, "); 
 // /**角色序号*/ 
 strCreateTabCode.Append(" RoleIndex int Null, "); 
 // /**QxPrjId*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**IsInUse*/ 
 strCreateTabCode.Append(" IsInUse bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**用户类型*/ 
 strCreateTabCode.Append(" UserType varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 角色(QxRoles)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxRoles : clsCommFun4BL
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
clsQxRolesBL.ReFreshThisCache();
}
}

}