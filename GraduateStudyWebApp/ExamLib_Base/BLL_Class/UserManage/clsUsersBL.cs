﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUsersBL
 表名:Users(01120034)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:31
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
public static class  clsUsersBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUsersEN GetObj(this K_UserId_Users myKey)
{
clsUsersEN objUsersEN = clsUsersBL.UsersDA.GetObjByUserId(myKey.Value);
return objUsersEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUsersEN objUsersEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUsersBL.IsExist(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objUsersEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsUsersBL.UsersDA.AddNewRecordBySQL2(objUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersBL.ReFreshCache();

if (clsUsersBL.relatedActions != null)
{
clsUsersBL.relatedActions.UpdRelaTabDate(objUsersEN.UserId, objUsersEN.UpdUser);
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
public static bool AddRecordEx(this clsUsersEN objUsersEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsUsersBL.IsExist(objUsersEN.UserId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objUsersEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objUsersEN.AddNewRecord();
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
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUsersEN objUsersEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUsersBL.IsExist(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objUsersEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsUsersBL.UsersDA.AddNewRecordBySQL2WithReturnKey(objUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersBL.ReFreshCache();

if (clsUsersBL.relatedActions != null)
{
clsUsersBL.relatedActions.UpdRelaTabDate(objUsersEN.UserId, objUsersEN.UpdUser);
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
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetUserId(this clsUsersEN objUsersEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conUsers.UserId);
}
objUsersEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.UserId) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.UserId, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.UserId] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetUserName(this clsUsersEN objUsersEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, conUsers.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, conUsers.UserName);
}
objUsersEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.UserName) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.UserName, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.UserName] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetDepartmentId(this clsUsersEN objUsersEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, conUsers.DepartmentId);
}
objUsersEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.DepartmentId) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.DepartmentId, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.DepartmentId] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetUserStateId(this clsUsersEN objUsersEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, conUsers.UserStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateId, 2, conUsers.UserStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, conUsers.UserStateId);
}
objUsersEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.UserStateId) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.UserStateId, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.UserStateId] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetPassword(this clsUsersEN objUsersEN, string strPassword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPassword, 20, conUsers.Password);
}
objUsersEN.Password = strPassword; //口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.Password) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.Password, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.Password] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetIsGpUser(this clsUsersEN objUsersEN, bool bolIsGpUser, string strComparisonOp="")
	{
objUsersEN.IsGpUser = bolIsGpUser; //是否Gp用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IsGpUser) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IsGpUser, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IsGpUser] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetIdSchool(this clsUsersEN objUsersEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, conUsers.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, conUsers.IdSchool);
}
objUsersEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IdSchool) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IdSchool, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IdSchool] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetBeginYearMonth(this clsUsersEN objUsersEN, string strBeginYearMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBeginYearMonth, 8, conUsers.BeginYearMonth);
}
objUsersEN.BeginYearMonth = strBeginYearMonth; //开始年月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.BeginYearMonth) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.BeginYearMonth, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.BeginYearMonth] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetEndYearMonth(this clsUsersEN objUsersEN, string strEndYearMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndYearMonth, 8, conUsers.EndYearMonth);
}
objUsersEN.EndYearMonth = strEndYearMonth; //结束年月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.EndYearMonth) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.EndYearMonth, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.EndYearMonth] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetIdGradeBase(this clsUsersEN objUsersEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, conUsers.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, conUsers.IdGradeBase);
}
objUsersEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IdGradeBase) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IdGradeBase, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IdGradeBase] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetIdGrade(this clsUsersEN objUsersEN, string strIdGrade, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGrade, 4, conUsers.IdGrade);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGrade, 4, conUsers.IdGrade);
}
objUsersEN.IdGrade = strIdGrade; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IdGrade) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IdGrade, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IdGrade] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetIdXzCollege(this clsUsersEN objUsersEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conUsers.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conUsers.IdXzCollege);
}
objUsersEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IdXzCollege) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IdXzCollege, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IdXzCollege] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetIdXzMajor(this clsUsersEN objUsersEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, conUsers.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, conUsers.IdXzMajor);
}
objUsersEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IdXzMajor) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IdXzMajor, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IdXzMajor] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetIsLeaved(this clsUsersEN objUsersEN, bool bolIsLeaved, string strComparisonOp="")
	{
objUsersEN.IsLeaved = bolIsLeaved; //是否离开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IsLeaved) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IsLeaved, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IsLeaved] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetStuIdTeacherId(this clsUsersEN objUsersEN, string strStuIdTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuIdTeacherId, 20, conUsers.StuIdTeacherId);
}
objUsersEN.StuIdTeacherId = strStuIdTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.StuIdTeacherId) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.StuIdTeacherId, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.StuIdTeacherId] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetEmail(this clsUsersEN objUsersEN, string strEmail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEmail, 100, conUsers.Email);
}
objUsersEN.Email = strEmail; //电子邮箱
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.Email) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.Email, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.Email] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetPhoneNumber(this clsUsersEN objUsersEN, string strPhoneNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, conUsers.PhoneNumber);
}
objUsersEN.PhoneNumber = strPhoneNumber; //电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.PhoneNumber) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.PhoneNumber, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.PhoneNumber] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetAvatarsPicture(this clsUsersEN objUsersEN, string strAvatarsPicture, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAvatarsPicture, 100, conUsers.AvatarsPicture);
}
objUsersEN.AvatarsPicture = strAvatarsPicture; //虚拟头像
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.AvatarsPicture) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.AvatarsPicture, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.AvatarsPicture] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetIdentityId(this clsUsersEN objUsersEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityId, conUsers.IdentityId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityId, 2, conUsers.IdentityId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, conUsers.IdentityId);
}
objUsersEN.IdentityId = strIdentityId; //身份Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IdentityId) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IdentityId, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IdentityId] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetAuditDate(this clsUsersEN objUsersEN, string strAuditDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuditDate, 14, conUsers.AuditDate);
}
objUsersEN.AuditDate = strAuditDate; //AuditDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.AuditDate) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.AuditDate, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.AuditDate] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetAuditUser(this clsUsersEN objUsersEN, string strAuditUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuditUser, 18, conUsers.AuditUser);
}
objUsersEN.AuditUser = strAuditUser; //AuditUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.AuditUser) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.AuditUser, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.AuditUser] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetIsAudit(this clsUsersEN objUsersEN, bool bolIsAudit, string strComparisonOp="")
	{
objUsersEN.IsAudit = bolIsAudit; //是否审核
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IsAudit) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IsAudit, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IsAudit] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetIsRegister(this clsUsersEN objUsersEN, bool bolIsRegister, string strComparisonOp="")
	{
objUsersEN.IsRegister = bolIsRegister; //IsRegister
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IsRegister) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IsRegister, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IsRegister] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetRegisterDate(this clsUsersEN objUsersEN, string strRegisterDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegisterDate, 14, conUsers.RegisterDate);
}
objUsersEN.RegisterDate = strRegisterDate; //RegisterDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.RegisterDate) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.RegisterDate, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.RegisterDate] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetMobilePhone(this clsUsersEN objUsersEN, string strMobilePhone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMobilePhone, 20, conUsers.MobilePhone);
}
objUsersEN.MobilePhone = strMobilePhone; //手机
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.MobilePhone) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.MobilePhone, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.MobilePhone] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetOpenId(this clsUsersEN objUsersEN, string strOpenId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpenId, 50, conUsers.OpenId);
}
objUsersEN.OpenId = strOpenId; //微信OpenId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.OpenId) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.OpenId, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.OpenId] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetUpdDate(this clsUsersEN objUsersEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conUsers.UpdDate);
}
objUsersEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.UpdDate) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.UpdDate, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.UpdDate] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetUpdUser(this clsUsersEN objUsersEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conUsers.UpdUser);
}
objUsersEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.UpdUser) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.UpdUser, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.UpdUser] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetMemo(this clsUsersEN objUsersEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUsers.Memo);
}
objUsersEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.Memo) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.Memo, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.Memo] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetHeadPic(this clsUsersEN objUsersEN, string strHeadPic, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHeadPic, 500, conUsers.HeadPic);
}
objUsersEN.HeadPic = strHeadPic; //头像
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.HeadPic) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.HeadPic, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.HeadPic] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetIsGSuser(this clsUsersEN objUsersEN, bool bolIsGSuser, string strComparisonOp="")
	{
objUsersEN.IsGSuser = bolIsGSuser; //是否GS用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IsGSuser) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IsGSuser, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IsGSuser] = strComparisonOp;
}
}
return objUsersEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objUsersEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsUsersEN objUsersEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objUsersEN.CheckPropertyNew();
clsUsersEN objUsersCond = new clsUsersEN();
string strCondition = objUsersCond
.SetUserId(objUsersEN.UserId, "=")
.GetCombineCondition();
objUsersEN._IsCheckProperty = true;
bool bolIsExist = clsUsersBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objUsersEN.Update();
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
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUsersEN objUsersEN)
{
 if (string.IsNullOrEmpty(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUsersBL.UsersDA.UpdateBySql2(objUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersBL.ReFreshCache();

if (clsUsersBL.relatedActions != null)
{
clsUsersBL.relatedActions.UpdRelaTabDate(objUsersEN.UserId, objUsersEN.UpdUser);
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
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUsersEN objUsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUsersBL.UsersDA.UpdateBySql2(objUsersEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersBL.ReFreshCache();

if (clsUsersBL.relatedActions != null)
{
clsUsersBL.relatedActions.UpdRelaTabDate(objUsersEN.UserId, objUsersEN.UpdUser);
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
 /// <param name = "objUsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUsersEN objUsersEN, string strWhereCond)
{
try
{
bool bolResult = clsUsersBL.UsersDA.UpdateBySqlWithCondition(objUsersEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersBL.ReFreshCache();

if (clsUsersBL.relatedActions != null)
{
clsUsersBL.relatedActions.UpdRelaTabDate(objUsersEN.UserId, objUsersEN.UpdUser);
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
 /// <param name = "objUsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUsersEN objUsersEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsUsersBL.UsersDA.UpdateBySqlWithConditionTransaction(objUsersEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersBL.ReFreshCache();

if (clsUsersBL.relatedActions != null)
{
clsUsersBL.relatedActions.UpdRelaTabDate(objUsersEN.UserId, objUsersEN.UpdUser);
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsUsersEN objUsersEN)
{
try
{
int intRecNum = clsUsersBL.UsersDA.DelRecord(objUsersEN.UserId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersBL.ReFreshCache();

if (clsUsersBL.relatedActions != null)
{
clsUsersBL.relatedActions.UpdRelaTabDate(objUsersEN.UserId, objUsersEN.UpdUser);
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
 /// <param name = "objUsersENS">源对象</param>
 /// <param name = "objUsersENT">目标对象</param>
 public static void CopyTo(this clsUsersEN objUsersENS, clsUsersEN objUsersENT)
{
try
{
objUsersENT.UserId = objUsersENS.UserId; //用户ID
objUsersENT.UserName = objUsersENS.UserName; //用户名
objUsersENT.DepartmentId = objUsersENS.DepartmentId; //部门Id
objUsersENT.UserStateId = objUsersENS.UserStateId; //用户状态Id
objUsersENT.Password = objUsersENS.Password; //口令
objUsersENT.IsGpUser = objUsersENS.IsGpUser; //是否Gp用户
objUsersENT.IdSchool = objUsersENS.IdSchool; //学校流水号
objUsersENT.BeginYearMonth = objUsersENS.BeginYearMonth; //开始年月
objUsersENT.EndYearMonth = objUsersENS.EndYearMonth; //结束年月
objUsersENT.IdGradeBase = objUsersENS.IdGradeBase; //年级流水号
objUsersENT.IdGrade = objUsersENS.IdGrade; //年级流水号
objUsersENT.IdXzCollege = objUsersENS.IdXzCollege; //学院流水号
objUsersENT.IdXzMajor = objUsersENS.IdXzMajor; //专业流水号
objUsersENT.IsLeaved = objUsersENS.IsLeaved; //是否离开
objUsersENT.StuIdTeacherId = objUsersENS.StuIdTeacherId; //学工号
objUsersENT.Email = objUsersENS.Email; //电子邮箱
objUsersENT.PhoneNumber = objUsersENS.PhoneNumber; //电话
objUsersENT.AvatarsPicture = objUsersENS.AvatarsPicture; //虚拟头像
objUsersENT.IdentityId = objUsersENS.IdentityId; //身份Id
objUsersENT.AuditDate = objUsersENS.AuditDate; //AuditDate
objUsersENT.AuditUser = objUsersENS.AuditUser; //AuditUser
objUsersENT.IsAudit = objUsersENS.IsAudit; //是否审核
objUsersENT.IsRegister = objUsersENS.IsRegister; //IsRegister
objUsersENT.RegisterDate = objUsersENS.RegisterDate; //RegisterDate
objUsersENT.MobilePhone = objUsersENS.MobilePhone; //手机
objUsersENT.OpenId = objUsersENS.OpenId; //微信OpenId
objUsersENT.UpdDate = objUsersENS.UpdDate; //修改日期
objUsersENT.UpdUser = objUsersENS.UpdUser; //修改人
objUsersENT.Memo = objUsersENS.Memo; //备注
objUsersENT.HeadPic = objUsersENS.HeadPic; //头像
objUsersENT.IsGSuser = objUsersENS.IsGSuser; //是否GS用户
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
 /// <param name = "objUsersENS">源对象</param>
 /// <returns>目标对象=>clsUsersEN:objUsersENT</returns>
 public static clsUsersEN CopyTo(this clsUsersEN objUsersENS)
{
try
{
 clsUsersEN objUsersENT = new clsUsersEN()
{
UserId = objUsersENS.UserId, //用户ID
UserName = objUsersENS.UserName, //用户名
DepartmentId = objUsersENS.DepartmentId, //部门Id
UserStateId = objUsersENS.UserStateId, //用户状态Id
Password = objUsersENS.Password, //口令
IsGpUser = objUsersENS.IsGpUser, //是否Gp用户
IdSchool = objUsersENS.IdSchool, //学校流水号
BeginYearMonth = objUsersENS.BeginYearMonth, //开始年月
EndYearMonth = objUsersENS.EndYearMonth, //结束年月
IdGradeBase = objUsersENS.IdGradeBase, //年级流水号
IdGrade = objUsersENS.IdGrade, //年级流水号
IdXzCollege = objUsersENS.IdXzCollege, //学院流水号
IdXzMajor = objUsersENS.IdXzMajor, //专业流水号
IsLeaved = objUsersENS.IsLeaved, //是否离开
StuIdTeacherId = objUsersENS.StuIdTeacherId, //学工号
Email = objUsersENS.Email, //电子邮箱
PhoneNumber = objUsersENS.PhoneNumber, //电话
AvatarsPicture = objUsersENS.AvatarsPicture, //虚拟头像
IdentityId = objUsersENS.IdentityId, //身份Id
AuditDate = objUsersENS.AuditDate, //AuditDate
AuditUser = objUsersENS.AuditUser, //AuditUser
IsAudit = objUsersENS.IsAudit, //是否审核
IsRegister = objUsersENS.IsRegister, //IsRegister
RegisterDate = objUsersENS.RegisterDate, //RegisterDate
MobilePhone = objUsersENS.MobilePhone, //手机
OpenId = objUsersENS.OpenId, //微信OpenId
UpdDate = objUsersENS.UpdDate, //修改日期
UpdUser = objUsersENS.UpdUser, //修改人
Memo = objUsersENS.Memo, //备注
HeadPic = objUsersENS.HeadPic, //头像
IsGSuser = objUsersENS.IsGSuser, //是否GS用户
};
 return objUsersENT;
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
public static void CheckPropertyNew(this clsUsersEN objUsersEN)
{
 clsUsersBL.UsersDA.CheckPropertyNew(objUsersEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsUsersEN objUsersEN)
{
 clsUsersBL.UsersDA.CheckProperty4Condition(objUsersEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUsersEN objUsersCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUsersCond.IsUpdated(conUsers.UserId) == true)
{
string strComparisonOpUserId = objUsersCond.dicFldComparisonOp[conUsers.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.UserId, objUsersCond.UserId, strComparisonOpUserId);
}
if (objUsersCond.IsUpdated(conUsers.UserName) == true)
{
string strComparisonOpUserName = objUsersCond.dicFldComparisonOp[conUsers.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.UserName, objUsersCond.UserName, strComparisonOpUserName);
}
if (objUsersCond.IsUpdated(conUsers.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objUsersCond.dicFldComparisonOp[conUsers.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.DepartmentId, objUsersCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objUsersCond.IsUpdated(conUsers.UserStateId) == true)
{
string strComparisonOpUserStateId = objUsersCond.dicFldComparisonOp[conUsers.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.UserStateId, objUsersCond.UserStateId, strComparisonOpUserStateId);
}
if (objUsersCond.IsUpdated(conUsers.Password) == true)
{
string strComparisonOpPassword = objUsersCond.dicFldComparisonOp[conUsers.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.Password, objUsersCond.Password, strComparisonOpPassword);
}
if (objUsersCond.IsUpdated(conUsers.IsGpUser) == true)
{
if (objUsersCond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUsers.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUsers.IsGpUser);
}
}
if (objUsersCond.IsUpdated(conUsers.IdSchool) == true)
{
string strComparisonOpIdSchool = objUsersCond.dicFldComparisonOp[conUsers.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.IdSchool, objUsersCond.IdSchool, strComparisonOpIdSchool);
}
if (objUsersCond.IsUpdated(conUsers.BeginYearMonth) == true)
{
string strComparisonOpBeginYearMonth = objUsersCond.dicFldComparisonOp[conUsers.BeginYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.BeginYearMonth, objUsersCond.BeginYearMonth, strComparisonOpBeginYearMonth);
}
if (objUsersCond.IsUpdated(conUsers.EndYearMonth) == true)
{
string strComparisonOpEndYearMonth = objUsersCond.dicFldComparisonOp[conUsers.EndYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.EndYearMonth, objUsersCond.EndYearMonth, strComparisonOpEndYearMonth);
}
if (objUsersCond.IsUpdated(conUsers.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objUsersCond.dicFldComparisonOp[conUsers.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.IdGradeBase, objUsersCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objUsersCond.IsUpdated(conUsers.IdGrade) == true)
{
string strComparisonOpIdGrade = objUsersCond.dicFldComparisonOp[conUsers.IdGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.IdGrade, objUsersCond.IdGrade, strComparisonOpIdGrade);
}
if (objUsersCond.IsUpdated(conUsers.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objUsersCond.dicFldComparisonOp[conUsers.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.IdXzCollege, objUsersCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objUsersCond.IsUpdated(conUsers.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objUsersCond.dicFldComparisonOp[conUsers.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.IdXzMajor, objUsersCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objUsersCond.IsUpdated(conUsers.IsLeaved) == true)
{
if (objUsersCond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUsers.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUsers.IsLeaved);
}
}
if (objUsersCond.IsUpdated(conUsers.StuIdTeacherId) == true)
{
string strComparisonOpStuIdTeacherId = objUsersCond.dicFldComparisonOp[conUsers.StuIdTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.StuIdTeacherId, objUsersCond.StuIdTeacherId, strComparisonOpStuIdTeacherId);
}
if (objUsersCond.IsUpdated(conUsers.Email) == true)
{
string strComparisonOpEmail = objUsersCond.dicFldComparisonOp[conUsers.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.Email, objUsersCond.Email, strComparisonOpEmail);
}
if (objUsersCond.IsUpdated(conUsers.PhoneNumber) == true)
{
string strComparisonOpPhoneNumber = objUsersCond.dicFldComparisonOp[conUsers.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.PhoneNumber, objUsersCond.PhoneNumber, strComparisonOpPhoneNumber);
}
if (objUsersCond.IsUpdated(conUsers.AvatarsPicture) == true)
{
string strComparisonOpAvatarsPicture = objUsersCond.dicFldComparisonOp[conUsers.AvatarsPicture];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.AvatarsPicture, objUsersCond.AvatarsPicture, strComparisonOpAvatarsPicture);
}
if (objUsersCond.IsUpdated(conUsers.IdentityId) == true)
{
string strComparisonOpIdentityId = objUsersCond.dicFldComparisonOp[conUsers.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.IdentityId, objUsersCond.IdentityId, strComparisonOpIdentityId);
}
if (objUsersCond.IsUpdated(conUsers.AuditDate) == true)
{
string strComparisonOpAuditDate = objUsersCond.dicFldComparisonOp[conUsers.AuditDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.AuditDate, objUsersCond.AuditDate, strComparisonOpAuditDate);
}
if (objUsersCond.IsUpdated(conUsers.AuditUser) == true)
{
string strComparisonOpAuditUser = objUsersCond.dicFldComparisonOp[conUsers.AuditUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.AuditUser, objUsersCond.AuditUser, strComparisonOpAuditUser);
}
if (objUsersCond.IsUpdated(conUsers.IsAudit) == true)
{
if (objUsersCond.IsAudit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUsers.IsAudit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUsers.IsAudit);
}
}
if (objUsersCond.IsUpdated(conUsers.IsRegister) == true)
{
if (objUsersCond.IsRegister == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUsers.IsRegister);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUsers.IsRegister);
}
}
if (objUsersCond.IsUpdated(conUsers.RegisterDate) == true)
{
string strComparisonOpRegisterDate = objUsersCond.dicFldComparisonOp[conUsers.RegisterDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.RegisterDate, objUsersCond.RegisterDate, strComparisonOpRegisterDate);
}
if (objUsersCond.IsUpdated(conUsers.MobilePhone) == true)
{
string strComparisonOpMobilePhone = objUsersCond.dicFldComparisonOp[conUsers.MobilePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.MobilePhone, objUsersCond.MobilePhone, strComparisonOpMobilePhone);
}
if (objUsersCond.IsUpdated(conUsers.OpenId) == true)
{
string strComparisonOpOpenId = objUsersCond.dicFldComparisonOp[conUsers.OpenId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.OpenId, objUsersCond.OpenId, strComparisonOpOpenId);
}
if (objUsersCond.IsUpdated(conUsers.UpdDate) == true)
{
string strComparisonOpUpdDate = objUsersCond.dicFldComparisonOp[conUsers.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.UpdDate, objUsersCond.UpdDate, strComparisonOpUpdDate);
}
if (objUsersCond.IsUpdated(conUsers.UpdUser) == true)
{
string strComparisonOpUpdUser = objUsersCond.dicFldComparisonOp[conUsers.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.UpdUser, objUsersCond.UpdUser, strComparisonOpUpdUser);
}
if (objUsersCond.IsUpdated(conUsers.Memo) == true)
{
string strComparisonOpMemo = objUsersCond.dicFldComparisonOp[conUsers.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.Memo, objUsersCond.Memo, strComparisonOpMemo);
}
if (objUsersCond.IsUpdated(conUsers.HeadPic) == true)
{
string strComparisonOpHeadPic = objUsersCond.dicFldComparisonOp[conUsers.HeadPic];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.HeadPic, objUsersCond.HeadPic, strComparisonOpHeadPic);
}
if (objUsersCond.IsUpdated(conUsers.IsGSuser) == true)
{
if (objUsersCond.IsGSuser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUsers.IsGSuser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUsers.IsGSuser);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Users
{
public virtual bool UpdRelaTabDate(string strUserId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户(Users)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsUsersBL
{
public static RelatedActions_Users relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsUsersDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsUsersDA UsersDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsUsersDA();
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
 public clsUsersBL()
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
if (string.IsNullOrEmpty(clsUsersEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUsersEN._ConnectString);
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
public static DataTable GetDataTable_Users(string strWhereCond)
{
DataTable objDT;
try
{
objDT = UsersDA.GetDataTable_Users(strWhereCond);
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
objDT = UsersDA.GetDataTable(strWhereCond);
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
objDT = UsersDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = UsersDA.GetDataTable(strWhereCond, strTabName);
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
objDT = UsersDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = UsersDA.GetDataTable_Top(objTopPara);
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
objDT = UsersDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = UsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = UsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsUsersEN> GetObjLstByUserIdLst(List<string> arrUserIdLst)
{
List<clsUsersEN> arrObjLst = new List<clsUsersEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrUserIdLst, true);
 string strWhereCond = string.Format("UserId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户ID
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId] == DBNull.Value ? null : objRow[conUsers.DepartmentId].ToString().Trim(); //部门Id
objUsersEN.UserStateId = objRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id
objUsersEN.Password = objRow[conUsers.Password] == DBNull.Value ? null : objRow[conUsers.Password].ToString().Trim(); //口令
objUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objUsersEN.IdSchool = objRow[conUsers.IdSchool] == DBNull.Value ? null : objRow[conUsers.IdSchool].ToString().Trim(); //学校流水号
objUsersEN.BeginYearMonth = objRow[conUsers.BeginYearMonth] == DBNull.Value ? null : objRow[conUsers.BeginYearMonth].ToString().Trim(); //开始年月
objUsersEN.EndYearMonth = objRow[conUsers.EndYearMonth] == DBNull.Value ? null : objRow[conUsers.EndYearMonth].ToString().Trim(); //结束年月
objUsersEN.IdGradeBase = objRow[conUsers.IdGradeBase] == DBNull.Value ? null : objRow[conUsers.IdGradeBase].ToString().Trim(); //年级流水号
objUsersEN.IdGrade = objRow[conUsers.IdGrade] == DBNull.Value ? null : objRow[conUsers.IdGrade].ToString().Trim(); //年级流水号
objUsersEN.IdXzCollege = objRow[conUsers.IdXzCollege] == DBNull.Value ? null : objRow[conUsers.IdXzCollege].ToString().Trim(); //学院流水号
objUsersEN.IdXzMajor = objRow[conUsers.IdXzMajor] == DBNull.Value ? null : objRow[conUsers.IdXzMajor].ToString().Trim(); //专业流水号
objUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsLeaved].ToString().Trim()); //是否离开
objUsersEN.StuIdTeacherId = objRow[conUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[conUsers.StuIdTeacherId].ToString().Trim(); //学工号
objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //电子邮箱
objUsersEN.PhoneNumber = objRow[conUsers.PhoneNumber] == DBNull.Value ? null : objRow[conUsers.PhoneNumber].ToString().Trim(); //电话
objUsersEN.AvatarsPicture = objRow[conUsers.AvatarsPicture] == DBNull.Value ? null : objRow[conUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objUsersEN.IdentityId = objRow[conUsers.IdentityId].ToString().Trim(); //身份Id
objUsersEN.AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(); //AuditDate
objUsersEN.AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(); //AuditUser
objUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsAudit].ToString().Trim()); //是否审核
objUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsRegister].ToString().Trim()); //IsRegister
objUsersEN.RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(); //RegisterDate
objUsersEN.MobilePhone = objRow[conUsers.MobilePhone] == DBNull.Value ? null : objRow[conUsers.MobilePhone].ToString().Trim(); //手机
objUsersEN.OpenId = objRow[conUsers.OpenId] == DBNull.Value ? null : objRow[conUsers.OpenId].ToString().Trim(); //微信OpenId
objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改人
objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //备注
objUsersEN.HeadPic = objRow[conUsers.HeadPic] == DBNull.Value ? null : objRow[conUsers.HeadPic].ToString().Trim(); //头像
objUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsUsersEN> GetObjLstByUserIdLstCache(List<string> arrUserIdLst)
{
string strKey = string.Format("{0}", clsUsersEN._CurrTabName);
List<clsUsersEN> arrUsersObjLstCache = GetObjLstCache();
IEnumerable <clsUsersEN> arrUsersObjLst_Sel =
arrUsersObjLstCache
.Where(x => arrUserIdLst.Contains(x.UserId));
return arrUsersObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUsersEN> GetObjLst(string strWhereCond)
{
List<clsUsersEN> arrObjLst = new List<clsUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户ID
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId] == DBNull.Value ? null : objRow[conUsers.DepartmentId].ToString().Trim(); //部门Id
objUsersEN.UserStateId = objRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id
objUsersEN.Password = objRow[conUsers.Password] == DBNull.Value ? null : objRow[conUsers.Password].ToString().Trim(); //口令
objUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objUsersEN.IdSchool = objRow[conUsers.IdSchool] == DBNull.Value ? null : objRow[conUsers.IdSchool].ToString().Trim(); //学校流水号
objUsersEN.BeginYearMonth = objRow[conUsers.BeginYearMonth] == DBNull.Value ? null : objRow[conUsers.BeginYearMonth].ToString().Trim(); //开始年月
objUsersEN.EndYearMonth = objRow[conUsers.EndYearMonth] == DBNull.Value ? null : objRow[conUsers.EndYearMonth].ToString().Trim(); //结束年月
objUsersEN.IdGradeBase = objRow[conUsers.IdGradeBase] == DBNull.Value ? null : objRow[conUsers.IdGradeBase].ToString().Trim(); //年级流水号
objUsersEN.IdGrade = objRow[conUsers.IdGrade] == DBNull.Value ? null : objRow[conUsers.IdGrade].ToString().Trim(); //年级流水号
objUsersEN.IdXzCollege = objRow[conUsers.IdXzCollege] == DBNull.Value ? null : objRow[conUsers.IdXzCollege].ToString().Trim(); //学院流水号
objUsersEN.IdXzMajor = objRow[conUsers.IdXzMajor] == DBNull.Value ? null : objRow[conUsers.IdXzMajor].ToString().Trim(); //专业流水号
objUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsLeaved].ToString().Trim()); //是否离开
objUsersEN.StuIdTeacherId = objRow[conUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[conUsers.StuIdTeacherId].ToString().Trim(); //学工号
objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //电子邮箱
objUsersEN.PhoneNumber = objRow[conUsers.PhoneNumber] == DBNull.Value ? null : objRow[conUsers.PhoneNumber].ToString().Trim(); //电话
objUsersEN.AvatarsPicture = objRow[conUsers.AvatarsPicture] == DBNull.Value ? null : objRow[conUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objUsersEN.IdentityId = objRow[conUsers.IdentityId].ToString().Trim(); //身份Id
objUsersEN.AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(); //AuditDate
objUsersEN.AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(); //AuditUser
objUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsAudit].ToString().Trim()); //是否审核
objUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsRegister].ToString().Trim()); //IsRegister
objUsersEN.RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(); //RegisterDate
objUsersEN.MobilePhone = objRow[conUsers.MobilePhone] == DBNull.Value ? null : objRow[conUsers.MobilePhone].ToString().Trim(); //手机
objUsersEN.OpenId = objRow[conUsers.OpenId] == DBNull.Value ? null : objRow[conUsers.OpenId].ToString().Trim(); //微信OpenId
objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改人
objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //备注
objUsersEN.HeadPic = objRow[conUsers.HeadPic] == DBNull.Value ? null : objRow[conUsers.HeadPic].ToString().Trim(); //头像
objUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUsersEN);
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
public static List<clsUsersEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsUsersEN> arrObjLst = new List<clsUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户ID
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId] == DBNull.Value ? null : objRow[conUsers.DepartmentId].ToString().Trim(); //部门Id
objUsersEN.UserStateId = objRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id
objUsersEN.Password = objRow[conUsers.Password] == DBNull.Value ? null : objRow[conUsers.Password].ToString().Trim(); //口令
objUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objUsersEN.IdSchool = objRow[conUsers.IdSchool] == DBNull.Value ? null : objRow[conUsers.IdSchool].ToString().Trim(); //学校流水号
objUsersEN.BeginYearMonth = objRow[conUsers.BeginYearMonth] == DBNull.Value ? null : objRow[conUsers.BeginYearMonth].ToString().Trim(); //开始年月
objUsersEN.EndYearMonth = objRow[conUsers.EndYearMonth] == DBNull.Value ? null : objRow[conUsers.EndYearMonth].ToString().Trim(); //结束年月
objUsersEN.IdGradeBase = objRow[conUsers.IdGradeBase] == DBNull.Value ? null : objRow[conUsers.IdGradeBase].ToString().Trim(); //年级流水号
objUsersEN.IdGrade = objRow[conUsers.IdGrade] == DBNull.Value ? null : objRow[conUsers.IdGrade].ToString().Trim(); //年级流水号
objUsersEN.IdXzCollege = objRow[conUsers.IdXzCollege] == DBNull.Value ? null : objRow[conUsers.IdXzCollege].ToString().Trim(); //学院流水号
objUsersEN.IdXzMajor = objRow[conUsers.IdXzMajor] == DBNull.Value ? null : objRow[conUsers.IdXzMajor].ToString().Trim(); //专业流水号
objUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsLeaved].ToString().Trim()); //是否离开
objUsersEN.StuIdTeacherId = objRow[conUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[conUsers.StuIdTeacherId].ToString().Trim(); //学工号
objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //电子邮箱
objUsersEN.PhoneNumber = objRow[conUsers.PhoneNumber] == DBNull.Value ? null : objRow[conUsers.PhoneNumber].ToString().Trim(); //电话
objUsersEN.AvatarsPicture = objRow[conUsers.AvatarsPicture] == DBNull.Value ? null : objRow[conUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objUsersEN.IdentityId = objRow[conUsers.IdentityId].ToString().Trim(); //身份Id
objUsersEN.AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(); //AuditDate
objUsersEN.AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(); //AuditUser
objUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsAudit].ToString().Trim()); //是否审核
objUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsRegister].ToString().Trim()); //IsRegister
objUsersEN.RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(); //RegisterDate
objUsersEN.MobilePhone = objRow[conUsers.MobilePhone] == DBNull.Value ? null : objRow[conUsers.MobilePhone].ToString().Trim(); //手机
objUsersEN.OpenId = objRow[conUsers.OpenId] == DBNull.Value ? null : objRow[conUsers.OpenId].ToString().Trim(); //微信OpenId
objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改人
objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //备注
objUsersEN.HeadPic = objRow[conUsers.HeadPic] == DBNull.Value ? null : objRow[conUsers.HeadPic].ToString().Trim(); //头像
objUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objUsersCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsUsersEN> GetSubObjLstCache(clsUsersEN objUsersCond)
{
List<clsUsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUsers.AttributeName)
{
if (objUsersCond.IsUpdated(strFldName) == false) continue;
if (objUsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUsersCond[strFldName].ToString());
}
else
{
if (objUsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUsersCond[strFldName]));
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
public static List<clsUsersEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsUsersEN> arrObjLst = new List<clsUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户ID
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId] == DBNull.Value ? null : objRow[conUsers.DepartmentId].ToString().Trim(); //部门Id
objUsersEN.UserStateId = objRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id
objUsersEN.Password = objRow[conUsers.Password] == DBNull.Value ? null : objRow[conUsers.Password].ToString().Trim(); //口令
objUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objUsersEN.IdSchool = objRow[conUsers.IdSchool] == DBNull.Value ? null : objRow[conUsers.IdSchool].ToString().Trim(); //学校流水号
objUsersEN.BeginYearMonth = objRow[conUsers.BeginYearMonth] == DBNull.Value ? null : objRow[conUsers.BeginYearMonth].ToString().Trim(); //开始年月
objUsersEN.EndYearMonth = objRow[conUsers.EndYearMonth] == DBNull.Value ? null : objRow[conUsers.EndYearMonth].ToString().Trim(); //结束年月
objUsersEN.IdGradeBase = objRow[conUsers.IdGradeBase] == DBNull.Value ? null : objRow[conUsers.IdGradeBase].ToString().Trim(); //年级流水号
objUsersEN.IdGrade = objRow[conUsers.IdGrade] == DBNull.Value ? null : objRow[conUsers.IdGrade].ToString().Trim(); //年级流水号
objUsersEN.IdXzCollege = objRow[conUsers.IdXzCollege] == DBNull.Value ? null : objRow[conUsers.IdXzCollege].ToString().Trim(); //学院流水号
objUsersEN.IdXzMajor = objRow[conUsers.IdXzMajor] == DBNull.Value ? null : objRow[conUsers.IdXzMajor].ToString().Trim(); //专业流水号
objUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsLeaved].ToString().Trim()); //是否离开
objUsersEN.StuIdTeacherId = objRow[conUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[conUsers.StuIdTeacherId].ToString().Trim(); //学工号
objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //电子邮箱
objUsersEN.PhoneNumber = objRow[conUsers.PhoneNumber] == DBNull.Value ? null : objRow[conUsers.PhoneNumber].ToString().Trim(); //电话
objUsersEN.AvatarsPicture = objRow[conUsers.AvatarsPicture] == DBNull.Value ? null : objRow[conUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objUsersEN.IdentityId = objRow[conUsers.IdentityId].ToString().Trim(); //身份Id
objUsersEN.AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(); //AuditDate
objUsersEN.AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(); //AuditUser
objUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsAudit].ToString().Trim()); //是否审核
objUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsRegister].ToString().Trim()); //IsRegister
objUsersEN.RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(); //RegisterDate
objUsersEN.MobilePhone = objRow[conUsers.MobilePhone] == DBNull.Value ? null : objRow[conUsers.MobilePhone].ToString().Trim(); //手机
objUsersEN.OpenId = objRow[conUsers.OpenId] == DBNull.Value ? null : objRow[conUsers.OpenId].ToString().Trim(); //微信OpenId
objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改人
objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //备注
objUsersEN.HeadPic = objRow[conUsers.HeadPic] == DBNull.Value ? null : objRow[conUsers.HeadPic].ToString().Trim(); //头像
objUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUsersEN);
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
public static List<clsUsersEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsUsersEN> arrObjLst = new List<clsUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户ID
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId] == DBNull.Value ? null : objRow[conUsers.DepartmentId].ToString().Trim(); //部门Id
objUsersEN.UserStateId = objRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id
objUsersEN.Password = objRow[conUsers.Password] == DBNull.Value ? null : objRow[conUsers.Password].ToString().Trim(); //口令
objUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objUsersEN.IdSchool = objRow[conUsers.IdSchool] == DBNull.Value ? null : objRow[conUsers.IdSchool].ToString().Trim(); //学校流水号
objUsersEN.BeginYearMonth = objRow[conUsers.BeginYearMonth] == DBNull.Value ? null : objRow[conUsers.BeginYearMonth].ToString().Trim(); //开始年月
objUsersEN.EndYearMonth = objRow[conUsers.EndYearMonth] == DBNull.Value ? null : objRow[conUsers.EndYearMonth].ToString().Trim(); //结束年月
objUsersEN.IdGradeBase = objRow[conUsers.IdGradeBase] == DBNull.Value ? null : objRow[conUsers.IdGradeBase].ToString().Trim(); //年级流水号
objUsersEN.IdGrade = objRow[conUsers.IdGrade] == DBNull.Value ? null : objRow[conUsers.IdGrade].ToString().Trim(); //年级流水号
objUsersEN.IdXzCollege = objRow[conUsers.IdXzCollege] == DBNull.Value ? null : objRow[conUsers.IdXzCollege].ToString().Trim(); //学院流水号
objUsersEN.IdXzMajor = objRow[conUsers.IdXzMajor] == DBNull.Value ? null : objRow[conUsers.IdXzMajor].ToString().Trim(); //专业流水号
objUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsLeaved].ToString().Trim()); //是否离开
objUsersEN.StuIdTeacherId = objRow[conUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[conUsers.StuIdTeacherId].ToString().Trim(); //学工号
objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //电子邮箱
objUsersEN.PhoneNumber = objRow[conUsers.PhoneNumber] == DBNull.Value ? null : objRow[conUsers.PhoneNumber].ToString().Trim(); //电话
objUsersEN.AvatarsPicture = objRow[conUsers.AvatarsPicture] == DBNull.Value ? null : objRow[conUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objUsersEN.IdentityId = objRow[conUsers.IdentityId].ToString().Trim(); //身份Id
objUsersEN.AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(); //AuditDate
objUsersEN.AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(); //AuditUser
objUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsAudit].ToString().Trim()); //是否审核
objUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsRegister].ToString().Trim()); //IsRegister
objUsersEN.RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(); //RegisterDate
objUsersEN.MobilePhone = objRow[conUsers.MobilePhone] == DBNull.Value ? null : objRow[conUsers.MobilePhone].ToString().Trim(); //手机
objUsersEN.OpenId = objRow[conUsers.OpenId] == DBNull.Value ? null : objRow[conUsers.OpenId].ToString().Trim(); //微信OpenId
objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改人
objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //备注
objUsersEN.HeadPic = objRow[conUsers.HeadPic] == DBNull.Value ? null : objRow[conUsers.HeadPic].ToString().Trim(); //头像
objUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUsersEN);
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
List<clsUsersEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsUsersEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUsersEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsUsersEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsUsersEN> arrObjLst = new List<clsUsersEN>(); 
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
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户ID
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId] == DBNull.Value ? null : objRow[conUsers.DepartmentId].ToString().Trim(); //部门Id
objUsersEN.UserStateId = objRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id
objUsersEN.Password = objRow[conUsers.Password] == DBNull.Value ? null : objRow[conUsers.Password].ToString().Trim(); //口令
objUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objUsersEN.IdSchool = objRow[conUsers.IdSchool] == DBNull.Value ? null : objRow[conUsers.IdSchool].ToString().Trim(); //学校流水号
objUsersEN.BeginYearMonth = objRow[conUsers.BeginYearMonth] == DBNull.Value ? null : objRow[conUsers.BeginYearMonth].ToString().Trim(); //开始年月
objUsersEN.EndYearMonth = objRow[conUsers.EndYearMonth] == DBNull.Value ? null : objRow[conUsers.EndYearMonth].ToString().Trim(); //结束年月
objUsersEN.IdGradeBase = objRow[conUsers.IdGradeBase] == DBNull.Value ? null : objRow[conUsers.IdGradeBase].ToString().Trim(); //年级流水号
objUsersEN.IdGrade = objRow[conUsers.IdGrade] == DBNull.Value ? null : objRow[conUsers.IdGrade].ToString().Trim(); //年级流水号
objUsersEN.IdXzCollege = objRow[conUsers.IdXzCollege] == DBNull.Value ? null : objRow[conUsers.IdXzCollege].ToString().Trim(); //学院流水号
objUsersEN.IdXzMajor = objRow[conUsers.IdXzMajor] == DBNull.Value ? null : objRow[conUsers.IdXzMajor].ToString().Trim(); //专业流水号
objUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsLeaved].ToString().Trim()); //是否离开
objUsersEN.StuIdTeacherId = objRow[conUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[conUsers.StuIdTeacherId].ToString().Trim(); //学工号
objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //电子邮箱
objUsersEN.PhoneNumber = objRow[conUsers.PhoneNumber] == DBNull.Value ? null : objRow[conUsers.PhoneNumber].ToString().Trim(); //电话
objUsersEN.AvatarsPicture = objRow[conUsers.AvatarsPicture] == DBNull.Value ? null : objRow[conUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objUsersEN.IdentityId = objRow[conUsers.IdentityId].ToString().Trim(); //身份Id
objUsersEN.AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(); //AuditDate
objUsersEN.AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(); //AuditUser
objUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsAudit].ToString().Trim()); //是否审核
objUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsRegister].ToString().Trim()); //IsRegister
objUsersEN.RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(); //RegisterDate
objUsersEN.MobilePhone = objRow[conUsers.MobilePhone] == DBNull.Value ? null : objRow[conUsers.MobilePhone].ToString().Trim(); //手机
objUsersEN.OpenId = objRow[conUsers.OpenId] == DBNull.Value ? null : objRow[conUsers.OpenId].ToString().Trim(); //微信OpenId
objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改人
objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //备注
objUsersEN.HeadPic = objRow[conUsers.HeadPic] == DBNull.Value ? null : objRow[conUsers.HeadPic].ToString().Trim(); //头像
objUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUsersEN);
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
public static List<clsUsersEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsUsersEN> arrObjLst = new List<clsUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户ID
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId] == DBNull.Value ? null : objRow[conUsers.DepartmentId].ToString().Trim(); //部门Id
objUsersEN.UserStateId = objRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id
objUsersEN.Password = objRow[conUsers.Password] == DBNull.Value ? null : objRow[conUsers.Password].ToString().Trim(); //口令
objUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objUsersEN.IdSchool = objRow[conUsers.IdSchool] == DBNull.Value ? null : objRow[conUsers.IdSchool].ToString().Trim(); //学校流水号
objUsersEN.BeginYearMonth = objRow[conUsers.BeginYearMonth] == DBNull.Value ? null : objRow[conUsers.BeginYearMonth].ToString().Trim(); //开始年月
objUsersEN.EndYearMonth = objRow[conUsers.EndYearMonth] == DBNull.Value ? null : objRow[conUsers.EndYearMonth].ToString().Trim(); //结束年月
objUsersEN.IdGradeBase = objRow[conUsers.IdGradeBase] == DBNull.Value ? null : objRow[conUsers.IdGradeBase].ToString().Trim(); //年级流水号
objUsersEN.IdGrade = objRow[conUsers.IdGrade] == DBNull.Value ? null : objRow[conUsers.IdGrade].ToString().Trim(); //年级流水号
objUsersEN.IdXzCollege = objRow[conUsers.IdXzCollege] == DBNull.Value ? null : objRow[conUsers.IdXzCollege].ToString().Trim(); //学院流水号
objUsersEN.IdXzMajor = objRow[conUsers.IdXzMajor] == DBNull.Value ? null : objRow[conUsers.IdXzMajor].ToString().Trim(); //专业流水号
objUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsLeaved].ToString().Trim()); //是否离开
objUsersEN.StuIdTeacherId = objRow[conUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[conUsers.StuIdTeacherId].ToString().Trim(); //学工号
objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //电子邮箱
objUsersEN.PhoneNumber = objRow[conUsers.PhoneNumber] == DBNull.Value ? null : objRow[conUsers.PhoneNumber].ToString().Trim(); //电话
objUsersEN.AvatarsPicture = objRow[conUsers.AvatarsPicture] == DBNull.Value ? null : objRow[conUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objUsersEN.IdentityId = objRow[conUsers.IdentityId].ToString().Trim(); //身份Id
objUsersEN.AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(); //AuditDate
objUsersEN.AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(); //AuditUser
objUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsAudit].ToString().Trim()); //是否审核
objUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsRegister].ToString().Trim()); //IsRegister
objUsersEN.RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(); //RegisterDate
objUsersEN.MobilePhone = objRow[conUsers.MobilePhone] == DBNull.Value ? null : objRow[conUsers.MobilePhone].ToString().Trim(); //手机
objUsersEN.OpenId = objRow[conUsers.OpenId] == DBNull.Value ? null : objRow[conUsers.OpenId].ToString().Trim(); //微信OpenId
objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改人
objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //备注
objUsersEN.HeadPic = objRow[conUsers.HeadPic] == DBNull.Value ? null : objRow[conUsers.HeadPic].ToString().Trim(); //头像
objUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsUsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsUsersEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsUsersEN> arrObjLst = new List<clsUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户ID
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId] == DBNull.Value ? null : objRow[conUsers.DepartmentId].ToString().Trim(); //部门Id
objUsersEN.UserStateId = objRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id
objUsersEN.Password = objRow[conUsers.Password] == DBNull.Value ? null : objRow[conUsers.Password].ToString().Trim(); //口令
objUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objUsersEN.IdSchool = objRow[conUsers.IdSchool] == DBNull.Value ? null : objRow[conUsers.IdSchool].ToString().Trim(); //学校流水号
objUsersEN.BeginYearMonth = objRow[conUsers.BeginYearMonth] == DBNull.Value ? null : objRow[conUsers.BeginYearMonth].ToString().Trim(); //开始年月
objUsersEN.EndYearMonth = objRow[conUsers.EndYearMonth] == DBNull.Value ? null : objRow[conUsers.EndYearMonth].ToString().Trim(); //结束年月
objUsersEN.IdGradeBase = objRow[conUsers.IdGradeBase] == DBNull.Value ? null : objRow[conUsers.IdGradeBase].ToString().Trim(); //年级流水号
objUsersEN.IdGrade = objRow[conUsers.IdGrade] == DBNull.Value ? null : objRow[conUsers.IdGrade].ToString().Trim(); //年级流水号
objUsersEN.IdXzCollege = objRow[conUsers.IdXzCollege] == DBNull.Value ? null : objRow[conUsers.IdXzCollege].ToString().Trim(); //学院流水号
objUsersEN.IdXzMajor = objRow[conUsers.IdXzMajor] == DBNull.Value ? null : objRow[conUsers.IdXzMajor].ToString().Trim(); //专业流水号
objUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsLeaved].ToString().Trim()); //是否离开
objUsersEN.StuIdTeacherId = objRow[conUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[conUsers.StuIdTeacherId].ToString().Trim(); //学工号
objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //电子邮箱
objUsersEN.PhoneNumber = objRow[conUsers.PhoneNumber] == DBNull.Value ? null : objRow[conUsers.PhoneNumber].ToString().Trim(); //电话
objUsersEN.AvatarsPicture = objRow[conUsers.AvatarsPicture] == DBNull.Value ? null : objRow[conUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objUsersEN.IdentityId = objRow[conUsers.IdentityId].ToString().Trim(); //身份Id
objUsersEN.AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(); //AuditDate
objUsersEN.AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(); //AuditUser
objUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsAudit].ToString().Trim()); //是否审核
objUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsRegister].ToString().Trim()); //IsRegister
objUsersEN.RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(); //RegisterDate
objUsersEN.MobilePhone = objRow[conUsers.MobilePhone] == DBNull.Value ? null : objRow[conUsers.MobilePhone].ToString().Trim(); //手机
objUsersEN.OpenId = objRow[conUsers.OpenId] == DBNull.Value ? null : objRow[conUsers.OpenId].ToString().Trim(); //微信OpenId
objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改人
objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //备注
objUsersEN.HeadPic = objRow[conUsers.HeadPic] == DBNull.Value ? null : objRow[conUsers.HeadPic].ToString().Trim(); //头像
objUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUsersEN);
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
public static List<clsUsersEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsUsersEN> arrObjLst = new List<clsUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户ID
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId] == DBNull.Value ? null : objRow[conUsers.DepartmentId].ToString().Trim(); //部门Id
objUsersEN.UserStateId = objRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id
objUsersEN.Password = objRow[conUsers.Password] == DBNull.Value ? null : objRow[conUsers.Password].ToString().Trim(); //口令
objUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objUsersEN.IdSchool = objRow[conUsers.IdSchool] == DBNull.Value ? null : objRow[conUsers.IdSchool].ToString().Trim(); //学校流水号
objUsersEN.BeginYearMonth = objRow[conUsers.BeginYearMonth] == DBNull.Value ? null : objRow[conUsers.BeginYearMonth].ToString().Trim(); //开始年月
objUsersEN.EndYearMonth = objRow[conUsers.EndYearMonth] == DBNull.Value ? null : objRow[conUsers.EndYearMonth].ToString().Trim(); //结束年月
objUsersEN.IdGradeBase = objRow[conUsers.IdGradeBase] == DBNull.Value ? null : objRow[conUsers.IdGradeBase].ToString().Trim(); //年级流水号
objUsersEN.IdGrade = objRow[conUsers.IdGrade] == DBNull.Value ? null : objRow[conUsers.IdGrade].ToString().Trim(); //年级流水号
objUsersEN.IdXzCollege = objRow[conUsers.IdXzCollege] == DBNull.Value ? null : objRow[conUsers.IdXzCollege].ToString().Trim(); //学院流水号
objUsersEN.IdXzMajor = objRow[conUsers.IdXzMajor] == DBNull.Value ? null : objRow[conUsers.IdXzMajor].ToString().Trim(); //专业流水号
objUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsLeaved].ToString().Trim()); //是否离开
objUsersEN.StuIdTeacherId = objRow[conUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[conUsers.StuIdTeacherId].ToString().Trim(); //学工号
objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //电子邮箱
objUsersEN.PhoneNumber = objRow[conUsers.PhoneNumber] == DBNull.Value ? null : objRow[conUsers.PhoneNumber].ToString().Trim(); //电话
objUsersEN.AvatarsPicture = objRow[conUsers.AvatarsPicture] == DBNull.Value ? null : objRow[conUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objUsersEN.IdentityId = objRow[conUsers.IdentityId].ToString().Trim(); //身份Id
objUsersEN.AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(); //AuditDate
objUsersEN.AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(); //AuditUser
objUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsAudit].ToString().Trim()); //是否审核
objUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsRegister].ToString().Trim()); //IsRegister
objUsersEN.RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(); //RegisterDate
objUsersEN.MobilePhone = objRow[conUsers.MobilePhone] == DBNull.Value ? null : objRow[conUsers.MobilePhone].ToString().Trim(); //手机
objUsersEN.OpenId = objRow[conUsers.OpenId] == DBNull.Value ? null : objRow[conUsers.OpenId].ToString().Trim(); //微信OpenId
objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改人
objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //备注
objUsersEN.HeadPic = objRow[conUsers.HeadPic] == DBNull.Value ? null : objRow[conUsers.HeadPic].ToString().Trim(); //头像
objUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsUsersEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsUsersEN> arrObjLst = new List<clsUsersEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户ID
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId] == DBNull.Value ? null : objRow[conUsers.DepartmentId].ToString().Trim(); //部门Id
objUsersEN.UserStateId = objRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id
objUsersEN.Password = objRow[conUsers.Password] == DBNull.Value ? null : objRow[conUsers.Password].ToString().Trim(); //口令
objUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objUsersEN.IdSchool = objRow[conUsers.IdSchool] == DBNull.Value ? null : objRow[conUsers.IdSchool].ToString().Trim(); //学校流水号
objUsersEN.BeginYearMonth = objRow[conUsers.BeginYearMonth] == DBNull.Value ? null : objRow[conUsers.BeginYearMonth].ToString().Trim(); //开始年月
objUsersEN.EndYearMonth = objRow[conUsers.EndYearMonth] == DBNull.Value ? null : objRow[conUsers.EndYearMonth].ToString().Trim(); //结束年月
objUsersEN.IdGradeBase = objRow[conUsers.IdGradeBase] == DBNull.Value ? null : objRow[conUsers.IdGradeBase].ToString().Trim(); //年级流水号
objUsersEN.IdGrade = objRow[conUsers.IdGrade] == DBNull.Value ? null : objRow[conUsers.IdGrade].ToString().Trim(); //年级流水号
objUsersEN.IdXzCollege = objRow[conUsers.IdXzCollege] == DBNull.Value ? null : objRow[conUsers.IdXzCollege].ToString().Trim(); //学院流水号
objUsersEN.IdXzMajor = objRow[conUsers.IdXzMajor] == DBNull.Value ? null : objRow[conUsers.IdXzMajor].ToString().Trim(); //专业流水号
objUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsLeaved].ToString().Trim()); //是否离开
objUsersEN.StuIdTeacherId = objRow[conUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[conUsers.StuIdTeacherId].ToString().Trim(); //学工号
objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //电子邮箱
objUsersEN.PhoneNumber = objRow[conUsers.PhoneNumber] == DBNull.Value ? null : objRow[conUsers.PhoneNumber].ToString().Trim(); //电话
objUsersEN.AvatarsPicture = objRow[conUsers.AvatarsPicture] == DBNull.Value ? null : objRow[conUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objUsersEN.IdentityId = objRow[conUsers.IdentityId].ToString().Trim(); //身份Id
objUsersEN.AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(); //AuditDate
objUsersEN.AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(); //AuditUser
objUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsAudit].ToString().Trim()); //是否审核
objUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsRegister].ToString().Trim()); //IsRegister
objUsersEN.RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(); //RegisterDate
objUsersEN.MobilePhone = objRow[conUsers.MobilePhone] == DBNull.Value ? null : objRow[conUsers.MobilePhone].ToString().Trim(); //手机
objUsersEN.OpenId = objRow[conUsers.OpenId] == DBNull.Value ? null : objRow[conUsers.OpenId].ToString().Trim(); //微信OpenId
objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改人
objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //备注
objUsersEN.HeadPic = objRow[conUsers.HeadPic] == DBNull.Value ? null : objRow[conUsers.HeadPic].ToString().Trim(); //头像
objUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUsersEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objUsersEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetUsers(ref clsUsersEN objUsersEN)
{
bool bolResult = UsersDA.GetUsers(ref objUsersEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUsersEN GetObjByUserId(string strUserId)
{
if (strUserId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strUserId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strUserId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strUserId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsUsersEN objUsersEN = UsersDA.GetObjByUserId(strUserId);
return objUsersEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsUsersEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsUsersEN objUsersEN = UsersDA.GetFirstObj(strWhereCond);
 return objUsersEN;
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
public static clsUsersEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsUsersEN objUsersEN = UsersDA.GetObjByDataRow(objRow);
 return objUsersEN;
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
public static clsUsersEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsUsersEN objUsersEN = UsersDA.GetObjByDataRow(objRow);
 return objUsersEN;
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
 /// <param name = "strUserId">所给的关键字</param>
 /// <param name = "lstUsersObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUsersEN GetObjByUserIdFromList(string strUserId, List<clsUsersEN> lstUsersObjLst)
{
foreach (clsUsersEN objUsersEN in lstUsersObjLst)
{
if (objUsersEN.UserId == strUserId)
{
return objUsersEN;
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
 string strUserId;
 try
 {
 strUserId = new clsUsersDA().GetFirstID(strWhereCond);
 return strUserId;
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
 arrList = UsersDA.GetID(strWhereCond);
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
bool bolIsExist = UsersDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strUserId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = UsersDA.IsExist(strUserId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strUserId">用户ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strUserId, string strOpUser)
{
clsUsersEN objUsersEN = clsUsersBL.GetObjByUserId(strUserId);
objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objUsersEN.UpdUser = strOpUser;
return clsUsersBL.UpdateBySql2(objUsersEN);
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
 bolIsExist = clsUsersDA.IsExistTable();
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
 bolIsExist = UsersDA.IsExistTable(strTabName);
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
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsUsersEN objUsersEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUsersBL.IsExist(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objUsersEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = UsersDA.AddNewRecordBySQL2(objUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersBL.ReFreshCache();

if (clsUsersBL.relatedActions != null)
{
clsUsersBL.relatedActions.UpdRelaTabDate(objUsersEN.UserId, objUsersEN.UpdUser);
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
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsUsersEN objUsersEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUsersBL.IsExist(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objUsersEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = UsersDA.AddNewRecordBySQL2WithReturnKey(objUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersBL.ReFreshCache();

if (clsUsersBL.relatedActions != null)
{
clsUsersBL.relatedActions.UpdRelaTabDate(objUsersEN.UserId, objUsersEN.UpdUser);
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
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsUsersEN objUsersEN)
{
try
{
bool bolResult = UsersDA.Update(objUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersBL.ReFreshCache();

if (clsUsersBL.relatedActions != null)
{
clsUsersBL.relatedActions.UpdRelaTabDate(objUsersEN.UserId, objUsersEN.UpdUser);
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
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsUsersEN objUsersEN)
{
 if (string.IsNullOrEmpty(objUsersEN.UserId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = UsersDA.UpdateBySql2(objUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersBL.ReFreshCache();

if (clsUsersBL.relatedActions != null)
{
clsUsersBL.relatedActions.UpdRelaTabDate(objUsersEN.UserId, objUsersEN.UpdUser);
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strUserId)
{
try
{
 clsUsersEN objUsersEN = clsUsersBL.GetObjByUserId(strUserId);

if (clsUsersBL.relatedActions != null)
{
clsUsersBL.relatedActions.UpdRelaTabDate(objUsersEN.UserId, objUsersEN.UpdUser);
}
if (objUsersEN != null)
{
int intRecNum = UsersDA.DelRecord(strUserId);
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
/// <param name="strUserId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strUserId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUsersDA.GetSpecSQLObj();
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
//删除与表:[Users]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conUsers.UserId,
//strUserId);
//        clsUsersBL.DelUserssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUsersBL.DelRecord(strUserId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUsersBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strUserId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strUserId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsUsersBL.relatedActions != null)
{
clsUsersBL.relatedActions.UpdRelaTabDate(strUserId, "UpdRelaTabDate");
}
bool bolResult = UsersDA.DelRecord(strUserId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrUserIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelUserss(List<string> arrUserIdLst)
{
if (arrUserIdLst.Count == 0) return 0;
try
{
if (clsUsersBL.relatedActions != null)
{
foreach (var strUserId in arrUserIdLst)
{
clsUsersBL.relatedActions.UpdRelaTabDate(strUserId, "UpdRelaTabDate");
}
}
int intDelRecNum = UsersDA.DelUsers(arrUserIdLst);
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
public static int DelUserssByCond(string strWhereCond)
{
try
{
if (clsUsersBL.relatedActions != null)
{
List<string> arrUserId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strUserId in arrUserId)
{
clsUsersBL.relatedActions.UpdRelaTabDate(strUserId, "UpdRelaTabDate");
}
}
int intRecNum = UsersDA.DelUsers(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Users]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strUserId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strUserId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUsersDA.GetSpecSQLObj();
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
//删除与表:[Users]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUsersBL.DelRecord(strUserId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUsersBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strUserId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objUsersENS">源对象</param>
 /// <param name = "objUsersENT">目标对象</param>
 public static void CopyTo(clsUsersEN objUsersENS, clsUsersEN objUsersENT)
{
try
{
objUsersENT.UserId = objUsersENS.UserId; //用户ID
objUsersENT.UserName = objUsersENS.UserName; //用户名
objUsersENT.DepartmentId = objUsersENS.DepartmentId; //部门Id
objUsersENT.UserStateId = objUsersENS.UserStateId; //用户状态Id
objUsersENT.Password = objUsersENS.Password; //口令
objUsersENT.IsGpUser = objUsersENS.IsGpUser; //是否Gp用户
objUsersENT.IdSchool = objUsersENS.IdSchool; //学校流水号
objUsersENT.BeginYearMonth = objUsersENS.BeginYearMonth; //开始年月
objUsersENT.EndYearMonth = objUsersENS.EndYearMonth; //结束年月
objUsersENT.IdGradeBase = objUsersENS.IdGradeBase; //年级流水号
objUsersENT.IdGrade = objUsersENS.IdGrade; //年级流水号
objUsersENT.IdXzCollege = objUsersENS.IdXzCollege; //学院流水号
objUsersENT.IdXzMajor = objUsersENS.IdXzMajor; //专业流水号
objUsersENT.IsLeaved = objUsersENS.IsLeaved; //是否离开
objUsersENT.StuIdTeacherId = objUsersENS.StuIdTeacherId; //学工号
objUsersENT.Email = objUsersENS.Email; //电子邮箱
objUsersENT.PhoneNumber = objUsersENS.PhoneNumber; //电话
objUsersENT.AvatarsPicture = objUsersENS.AvatarsPicture; //虚拟头像
objUsersENT.IdentityId = objUsersENS.IdentityId; //身份Id
objUsersENT.AuditDate = objUsersENS.AuditDate; //AuditDate
objUsersENT.AuditUser = objUsersENS.AuditUser; //AuditUser
objUsersENT.IsAudit = objUsersENS.IsAudit; //是否审核
objUsersENT.IsRegister = objUsersENS.IsRegister; //IsRegister
objUsersENT.RegisterDate = objUsersENS.RegisterDate; //RegisterDate
objUsersENT.MobilePhone = objUsersENS.MobilePhone; //手机
objUsersENT.OpenId = objUsersENS.OpenId; //微信OpenId
objUsersENT.UpdDate = objUsersENS.UpdDate; //修改日期
objUsersENT.UpdUser = objUsersENS.UpdUser; //修改人
objUsersENT.Memo = objUsersENS.Memo; //备注
objUsersENT.HeadPic = objUsersENS.HeadPic; //头像
objUsersENT.IsGSuser = objUsersENS.IsGSuser; //是否GS用户
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
 /// <param name = "objUsersEN">源简化对象</param>
 public static void SetUpdFlag(clsUsersEN objUsersEN)
{
try
{
objUsersEN.ClearUpdateState();
   string strsfUpdFldSetStr = objUsersEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conUsers.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.UserId = objUsersEN.UserId; //用户ID
}
if (arrFldSet.Contains(conUsers.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.UserName = objUsersEN.UserName; //用户名
}
if (arrFldSet.Contains(conUsers.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.DepartmentId = objUsersEN.DepartmentId == "[null]" ? null :  objUsersEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(conUsers.UserStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.UserStateId = objUsersEN.UserStateId; //用户状态Id
}
if (arrFldSet.Contains(conUsers.Password, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.Password = objUsersEN.Password == "[null]" ? null :  objUsersEN.Password; //口令
}
if (arrFldSet.Contains(conUsers.IsGpUser, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.IsGpUser = objUsersEN.IsGpUser; //是否Gp用户
}
if (arrFldSet.Contains(conUsers.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.IdSchool = objUsersEN.IdSchool == "[null]" ? null :  objUsersEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(conUsers.BeginYearMonth, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.BeginYearMonth = objUsersEN.BeginYearMonth == "[null]" ? null :  objUsersEN.BeginYearMonth; //开始年月
}
if (arrFldSet.Contains(conUsers.EndYearMonth, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.EndYearMonth = objUsersEN.EndYearMonth == "[null]" ? null :  objUsersEN.EndYearMonth; //结束年月
}
if (arrFldSet.Contains(conUsers.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.IdGradeBase = objUsersEN.IdGradeBase == "[null]" ? null :  objUsersEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(conUsers.IdGrade, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.IdGrade = objUsersEN.IdGrade == "[null]" ? null :  objUsersEN.IdGrade; //年级流水号
}
if (arrFldSet.Contains(conUsers.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.IdXzCollege = objUsersEN.IdXzCollege == "[null]" ? null :  objUsersEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(conUsers.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.IdXzMajor = objUsersEN.IdXzMajor == "[null]" ? null :  objUsersEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(conUsers.IsLeaved, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.IsLeaved = objUsersEN.IsLeaved; //是否离开
}
if (arrFldSet.Contains(conUsers.StuIdTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.StuIdTeacherId = objUsersEN.StuIdTeacherId == "[null]" ? null :  objUsersEN.StuIdTeacherId; //学工号
}
if (arrFldSet.Contains(conUsers.Email, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.Email = objUsersEN.Email == "[null]" ? null :  objUsersEN.Email; //电子邮箱
}
if (arrFldSet.Contains(conUsers.PhoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.PhoneNumber = objUsersEN.PhoneNumber == "[null]" ? null :  objUsersEN.PhoneNumber; //电话
}
if (arrFldSet.Contains(conUsers.AvatarsPicture, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.AvatarsPicture = objUsersEN.AvatarsPicture == "[null]" ? null :  objUsersEN.AvatarsPicture; //虚拟头像
}
if (arrFldSet.Contains(conUsers.IdentityId, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.IdentityId = objUsersEN.IdentityId; //身份Id
}
if (arrFldSet.Contains(conUsers.AuditDate, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.AuditDate = objUsersEN.AuditDate == "[null]" ? null :  objUsersEN.AuditDate; //AuditDate
}
if (arrFldSet.Contains(conUsers.AuditUser, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.AuditUser = objUsersEN.AuditUser == "[null]" ? null :  objUsersEN.AuditUser; //AuditUser
}
if (arrFldSet.Contains(conUsers.IsAudit, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.IsAudit = objUsersEN.IsAudit; //是否审核
}
if (arrFldSet.Contains(conUsers.IsRegister, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.IsRegister = objUsersEN.IsRegister; //IsRegister
}
if (arrFldSet.Contains(conUsers.RegisterDate, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.RegisterDate = objUsersEN.RegisterDate == "[null]" ? null :  objUsersEN.RegisterDate; //RegisterDate
}
if (arrFldSet.Contains(conUsers.MobilePhone, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.MobilePhone = objUsersEN.MobilePhone == "[null]" ? null :  objUsersEN.MobilePhone; //手机
}
if (arrFldSet.Contains(conUsers.OpenId, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.OpenId = objUsersEN.OpenId == "[null]" ? null :  objUsersEN.OpenId; //微信OpenId
}
if (arrFldSet.Contains(conUsers.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.UpdDate = objUsersEN.UpdDate == "[null]" ? null :  objUsersEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conUsers.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.UpdUser = objUsersEN.UpdUser == "[null]" ? null :  objUsersEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conUsers.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.Memo = objUsersEN.Memo == "[null]" ? null :  objUsersEN.Memo; //备注
}
if (arrFldSet.Contains(conUsers.HeadPic, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.HeadPic = objUsersEN.HeadPic == "[null]" ? null :  objUsersEN.HeadPic; //头像
}
if (arrFldSet.Contains(conUsers.IsGSuser, new clsStrCompareIgnoreCase())  ==  true)
{
objUsersEN.IsGSuser = objUsersEN.IsGSuser; //是否GS用户
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
 /// <param name = "objUsersEN">源简化对象</param>
 public static void AccessFldValueNull(clsUsersEN objUsersEN)
{
try
{
if (objUsersEN.DepartmentId == "[null]") objUsersEN.DepartmentId = null; //部门Id
if (objUsersEN.Password == "[null]") objUsersEN.Password = null; //口令
if (objUsersEN.IdSchool == "[null]") objUsersEN.IdSchool = null; //学校流水号
if (objUsersEN.BeginYearMonth == "[null]") objUsersEN.BeginYearMonth = null; //开始年月
if (objUsersEN.EndYearMonth == "[null]") objUsersEN.EndYearMonth = null; //结束年月
if (objUsersEN.IdGradeBase == "[null]") objUsersEN.IdGradeBase = null; //年级流水号
if (objUsersEN.IdGrade == "[null]") objUsersEN.IdGrade = null; //年级流水号
if (objUsersEN.IdXzCollege == "[null]") objUsersEN.IdXzCollege = null; //学院流水号
if (objUsersEN.IdXzMajor == "[null]") objUsersEN.IdXzMajor = null; //专业流水号
if (objUsersEN.StuIdTeacherId == "[null]") objUsersEN.StuIdTeacherId = null; //学工号
if (objUsersEN.Email == "[null]") objUsersEN.Email = null; //电子邮箱
if (objUsersEN.PhoneNumber == "[null]") objUsersEN.PhoneNumber = null; //电话
if (objUsersEN.AvatarsPicture == "[null]") objUsersEN.AvatarsPicture = null; //虚拟头像
if (objUsersEN.AuditDate == "[null]") objUsersEN.AuditDate = null; //AuditDate
if (objUsersEN.AuditUser == "[null]") objUsersEN.AuditUser = null; //AuditUser
if (objUsersEN.RegisterDate == "[null]") objUsersEN.RegisterDate = null; //RegisterDate
if (objUsersEN.MobilePhone == "[null]") objUsersEN.MobilePhone = null; //手机
if (objUsersEN.OpenId == "[null]") objUsersEN.OpenId = null; //微信OpenId
if (objUsersEN.UpdDate == "[null]") objUsersEN.UpdDate = null; //修改日期
if (objUsersEN.UpdUser == "[null]") objUsersEN.UpdUser = null; //修改人
if (objUsersEN.Memo == "[null]") objUsersEN.Memo = null; //备注
if (objUsersEN.HeadPic == "[null]") objUsersEN.HeadPic = null; //头像
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
public static void CheckPropertyNew(clsUsersEN objUsersEN)
{
 UsersDA.CheckPropertyNew(objUsersEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsUsersEN objUsersEN)
{
 UsersDA.CheckProperty4Condition(objUsersEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_UserId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conUsers.UserId); 
List<clsUsersEN> arrObjLst = clsUsersBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsUsersEN objUsersEN = new clsUsersEN()
{
UserId = "0",
UserName = "选[用户]..."
};
arrObjLst.Insert(0, objUsersEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conUsers.UserId;
objComboBox.DisplayMember = conUsers.UserName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[用户]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conUsers.UserId); 
IEnumerable<clsUsersEN> arrObjLst = clsUsersBL.GetObjLst(strCondition);
objDDL.DataValueField = conUsers.UserId;
objDDL.DataTextField = conUsers.UserName;
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
public static void BindDdl_UserIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[用户]...","0");
List<clsUsersEN> arrUsersObjLst = GetAllUsersObjLstCache(); 
objDDL.DataValueField = conUsers.UserId;
objDDL.DataTextField = conUsers.UserName;
objDDL.DataSource = arrUsersObjLst;
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserId");
//if (arrUsersObjLstCache == null)
//{
//arrUsersObjLstCache = UsersDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUsersEN GetObjByUserIdCache(string strUserId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsUsersEN._CurrTabName);
List<clsUsersEN> arrUsersObjLstCache = GetObjLstCache();
IEnumerable <clsUsersEN> arrUsersObjLst_Sel =
arrUsersObjLstCache
.Where(x=> x.UserId == strUserId 
);
if (arrUsersObjLst_Sel.Count() == 0)
{
   clsUsersEN obj = clsUsersBL.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrUsersObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserNameByUserIdCache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return "";
//获取缓存中的对象列表
clsUsersEN objUsers = GetObjByUserIdCache(strUserId);
if (objUsers == null) return "";
return objUsers.UserName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByUserIdCache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return "";
//获取缓存中的对象列表
clsUsersEN objUsers = GetObjByUserIdCache(strUserId);
if (objUsers == null) return "";
return objUsers.UserName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUsersEN> GetAllUsersObjLstCache()
{
//获取缓存中的对象列表
List<clsUsersEN> arrUsersObjLstCache = GetObjLstCache(); 
return arrUsersObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUsersEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsUsersEN._CurrTabName);
List<clsUsersEN> arrUsersObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrUsersObjLstCache;
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
string strKey = string.Format("{0}", clsUsersEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUsersEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsUsersEN._RefreshTimeLst.Count == 0) return "";
return clsUsersEN._RefreshTimeLst[clsUsersEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsUsersBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsUsersEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUsersEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsUsersBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strUserId)
{
if (strInFldName != conUsers.UserId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conUsers.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conUsers.AttributeName));
throw new Exception(strMsg);
}
var objUsers = clsUsersBL.GetObjByUserIdCache(strUserId);
if (objUsers == null) return "";
return objUsers[strOutFldName].ToString();
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
int intRecCount = clsUsersDA.GetRecCount(strTabName);
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
int intRecCount = clsUsersDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsUsersDA.GetRecCount();
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
int intRecCount = clsUsersDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objUsersCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsUsersEN objUsersCond)
{
List<clsUsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUsers.AttributeName)
{
if (objUsersCond.IsUpdated(strFldName) == false) continue;
if (objUsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUsersCond[strFldName].ToString());
}
else
{
if (objUsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUsersCond[strFldName]));
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
 List<string> arrList = clsUsersDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = UsersDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = UsersDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = UsersDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsUsersDA.SetFldValue(clsUsersEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = UsersDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsUsersDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsUsersDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsUsersDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Users] "); 
 strCreateTabCode.Append(" ( "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) primary key, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) not Null, "); 
 // /**部门Id*/ 
 strCreateTabCode.Append(" DepartmentId varchar(8) Null, "); 
 // /**用户状态Id*/ 
 strCreateTabCode.Append(" UserStateId char(2) not Null, "); 
 // /**口令*/ 
 strCreateTabCode.Append(" Password varchar(20) Null, "); 
 // /**是否Gp用户*/ 
 strCreateTabCode.Append(" IsGpUser bit Null, "); 
 // /**学校流水号*/ 
 strCreateTabCode.Append(" IdSchool char(4) Null, "); 
 // /**开始年月*/ 
 strCreateTabCode.Append(" BeginYearMonth varchar(8) Null, "); 
 // /**结束年月*/ 
 strCreateTabCode.Append(" EndYearMonth varchar(8) Null, "); 
 // /**年级流水号*/ 
 strCreateTabCode.Append(" IdGradeBase char(4) Null, "); 
 // /**年级流水号*/ 
 strCreateTabCode.Append(" IdGrade char(4) Null, "); 
 // /**学院流水号*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) Null, "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" IdXzMajor char(8) Null, "); 
 // /**是否离开*/ 
 strCreateTabCode.Append(" IsLeaved bit Null, "); 
 // /**学工号*/ 
 strCreateTabCode.Append(" StuIdTeacherId varchar(20) Null, "); 
 // /**电子邮箱*/ 
 strCreateTabCode.Append(" Email varchar(100) Null, "); 
 // /**电话*/ 
 strCreateTabCode.Append(" PhoneNumber varchar(15) Null, "); 
 // /**虚拟头像*/ 
 strCreateTabCode.Append(" AvatarsPicture varchar(100) Null, "); 
 // /**身份Id*/ 
 strCreateTabCode.Append(" IdentityId char(2) not Null, "); 
 // /**AuditDate*/ 
 strCreateTabCode.Append(" AuditDate varchar(14) Null, "); 
 // /**AuditUser*/ 
 strCreateTabCode.Append(" AuditUser varchar(18) Null, "); 
 // /**是否审核*/ 
 strCreateTabCode.Append(" IsAudit bit Null, "); 
 // /**IsRegister*/ 
 strCreateTabCode.Append(" IsRegister bit Null, "); 
 // /**RegisterDate*/ 
 strCreateTabCode.Append(" RegisterDate varchar(14) Null, "); 
 // /**手机*/ 
 strCreateTabCode.Append(" MobilePhone varchar(20) Null, "); 
 // /**微信OpenId*/ 
 strCreateTabCode.Append(" OpenId varchar(50) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**头像*/ 
 strCreateTabCode.Append(" HeadPic varchar(500) Null, "); 
 // /**是否GS用户*/ 
 strCreateTabCode.Append(" IsGSuser bit Null, "); 
 // /**学院名称*/ 
 strCreateTabCode.Append(" CollegeName varchar(100) Null, "); 
 // /**专业名称*/ 
 strCreateTabCode.Append(" MajorName varchar(100) Null, "); 
 // /**用户状态名*/ 
 strCreateTabCode.Append(" UserStateName varchar(20) Null, "); 
 // /**年级名称*/ 
 strCreateTabCode.Append(" GradeBaseName varchar(50) Null, "); 
 // /**角色列表*/ 
 strCreateTabCode.Append(" RoleNames varchar(50) Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" DateTimeSim varchar(20) Null, "); 
 // /**身份描述*/ 
 strCreateTabCode.Append(" IdentityDesc varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 用户(Users)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Users : clsCommFun4BL
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
clsUsersBL.ReFreshThisCache();
}
}

}