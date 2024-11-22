
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsers_JTBL
 表名:vUsers_JT(01120230)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:28
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
public static class  clsvUsers_JTBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUsers_JTEN GetObj(this K_UserId_vUsers_JT myKey)
{
clsvUsers_JTEN objvUsers_JTEN = clsvUsers_JTBL.vUsers_JTDA.GetObjByUserId(myKey.Value);
return objvUsers_JTEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetUserId(this clsvUsers_JTEN objvUsers_JTEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convUsers_JT.UserId);
}
objvUsers_JTEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.UserId) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.UserId, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.UserId] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetUserName(this clsvUsers_JTEN objvUsers_JTEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convUsers_JT.UserName);
}
objvUsers_JTEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.UserName) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.UserName, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.UserName] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetPassword(this clsvUsers_JTEN objvUsers_JTEN, string strPassword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPassword, 20, convUsers_JT.Password);
}
objvUsers_JTEN.Password = strPassword; //Password
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.Password) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.Password, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.Password] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetPhoneNumber(this clsvUsers_JTEN objvUsers_JTEN, string strPhoneNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, convUsers_JT.PhoneNumber);
}
objvUsers_JTEN.PhoneNumber = strPhoneNumber; //PhoneNumber
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.PhoneNumber) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.PhoneNumber, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.PhoneNumber] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetAuditDate(this clsvUsers_JTEN objvUsers_JTEN, string strAuditDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuditDate, 14, convUsers_JT.AuditDate);
}
objvUsers_JTEN.AuditDate = strAuditDate; //AuditDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.AuditDate) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.AuditDate, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.AuditDate] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetAuditUser(this clsvUsers_JTEN objvUsers_JTEN, string strAuditUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuditUser, 18, convUsers_JT.AuditUser);
}
objvUsers_JTEN.AuditUser = strAuditUser; //AuditUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.AuditUser) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.AuditUser, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.AuditUser] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetIsAudit(this clsvUsers_JTEN objvUsers_JTEN, bool bolIsAudit, string strComparisonOp="")
	{
objvUsers_JTEN.IsAudit = bolIsAudit; //是否审核
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.IsAudit) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.IsAudit, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.IsAudit] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetIsRegister(this clsvUsers_JTEN objvUsers_JTEN, bool bolIsRegister, string strComparisonOp="")
	{
objvUsers_JTEN.IsRegister = bolIsRegister; //IsRegister
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.IsRegister) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.IsRegister, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.IsRegister] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetRegisterDate(this clsvUsers_JTEN objvUsers_JTEN, string strRegisterDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegisterDate, 14, convUsers_JT.RegisterDate);
}
objvUsers_JTEN.RegisterDate = strRegisterDate; //RegisterDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.RegisterDate) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.RegisterDate, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.RegisterDate] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetMobilePhone(this clsvUsers_JTEN objvUsers_JTEN, string strMobilePhone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMobilePhone, 20, convUsers_JT.MobilePhone);
}
objvUsers_JTEN.MobilePhone = strMobilePhone; //手机
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.MobilePhone) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.MobilePhone, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.MobilePhone] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetSiteName(this clsvUsers_JTEN objvUsers_JTEN, string strSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSiteName, convUsers_JT.SiteName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSiteName, 100, convUsers_JT.SiteName);
}
objvUsers_JTEN.SiteName = strSiteName; //工地名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.SiteName) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.SiteName, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.SiteName] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetJobCategoryId(this clsvUsers_JTEN objvUsers_JTEN, string strJobCategoryId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJobCategoryId, convUsers_JT.JobCategoryId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJobCategoryId, 2, convUsers_JT.JobCategoryId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strJobCategoryId, 2, convUsers_JT.JobCategoryId);
}
objvUsers_JTEN.JobCategoryId = strJobCategoryId; //岗位类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.JobCategoryId) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.JobCategoryId, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.JobCategoryId] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetJobCategoryName(this clsvUsers_JTEN objvUsers_JTEN, string strJobCategoryName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJobCategoryName, convUsers_JT.JobCategoryName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJobCategoryName, 50, convUsers_JT.JobCategoryName);
}
objvUsers_JTEN.JobCategoryName = strJobCategoryName; //岗位类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.JobCategoryName) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.JobCategoryName, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.JobCategoryName] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetManagedDepartmentId(this clsvUsers_JTEN objvUsers_JTEN, string strManagedDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strManagedDepartmentId, convUsers_JT.ManagedDepartmentId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strManagedDepartmentId, 4, convUsers_JT.ManagedDepartmentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strManagedDepartmentId, 4, convUsers_JT.ManagedDepartmentId);
}
objvUsers_JTEN.ManagedDepartmentId = strManagedDepartmentId; //管理的部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.ManagedDepartmentId) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.ManagedDepartmentId, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.ManagedDepartmentId] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetManagedDepartmentName(this clsvUsers_JTEN objvUsers_JTEN, string strManagedDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strManagedDepartmentName, convUsers_JT.ManagedDepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strManagedDepartmentName, 50, convUsers_JT.ManagedDepartmentName);
}
objvUsers_JTEN.ManagedDepartmentName = strManagedDepartmentName; //管理的部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.ManagedDepartmentName) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.ManagedDepartmentName, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.ManagedDepartmentName] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetIDNumber(this clsvUsers_JTEN objvUsers_JTEN, string strIDNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIDNumber, 18, convUsers_JT.IDNumber);
}
objvUsers_JTEN.IDNumber = strIDNumber; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.IDNumber) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.IDNumber, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.IDNumber] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetUpdDate(this clsvUsers_JTEN objvUsers_JTEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convUsers_JT.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUsers_JT.UpdDate);
}
objvUsers_JTEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.UpdDate) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.UpdDate, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.UpdDate] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetUpdUser(this clsvUsers_JTEN objvUsers_JTEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convUsers_JT.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convUsers_JT.UpdUser);
}
objvUsers_JTEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.UpdUser) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.UpdUser, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.UpdUser] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsers_JTEN SetMemo(this clsvUsers_JTEN objvUsers_JTEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUsers_JT.Memo);
}
objvUsers_JTEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsers_JTEN.dicFldComparisonOp.ContainsKey(convUsers_JT.Memo) == false)
{
objvUsers_JTEN.dicFldComparisonOp.Add(convUsers_JT.Memo, strComparisonOp);
}
else
{
objvUsers_JTEN.dicFldComparisonOp[convUsers_JT.Memo] = strComparisonOp;
}
}
return objvUsers_JTEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvUsers_JTENS">源对象</param>
 /// <param name = "objvUsers_JTENT">目标对象</param>
 public static void CopyTo(this clsvUsers_JTEN objvUsers_JTENS, clsvUsers_JTEN objvUsers_JTENT)
{
try
{
objvUsers_JTENT.UserId = objvUsers_JTENS.UserId; //用户ID
objvUsers_JTENT.UserName = objvUsers_JTENS.UserName; //用户名
objvUsers_JTENT.Password = objvUsers_JTENS.Password; //Password
objvUsers_JTENT.PhoneNumber = objvUsers_JTENS.PhoneNumber; //PhoneNumber
objvUsers_JTENT.AuditDate = objvUsers_JTENS.AuditDate; //AuditDate
objvUsers_JTENT.AuditUser = objvUsers_JTENS.AuditUser; //AuditUser
objvUsers_JTENT.IsAudit = objvUsers_JTENS.IsAudit; //是否审核
objvUsers_JTENT.IsRegister = objvUsers_JTENS.IsRegister; //IsRegister
objvUsers_JTENT.RegisterDate = objvUsers_JTENS.RegisterDate; //RegisterDate
objvUsers_JTENT.MobilePhone = objvUsers_JTENS.MobilePhone; //手机
objvUsers_JTENT.SiteName = objvUsers_JTENS.SiteName; //工地名称
objvUsers_JTENT.JobCategoryId = objvUsers_JTENS.JobCategoryId; //岗位类别Id
objvUsers_JTENT.JobCategoryName = objvUsers_JTENS.JobCategoryName; //岗位类别名
objvUsers_JTENT.ManagedDepartmentId = objvUsers_JTENS.ManagedDepartmentId; //管理的部门Id
objvUsers_JTENT.ManagedDepartmentName = objvUsers_JTENS.ManagedDepartmentName; //管理的部门名
objvUsers_JTENT.IDNumber = objvUsers_JTENS.IDNumber; //身份证号
objvUsers_JTENT.UpdDate = objvUsers_JTENS.UpdDate; //修改日期
objvUsers_JTENT.UpdUser = objvUsers_JTENS.UpdUser; //修改人
objvUsers_JTENT.Memo = objvUsers_JTENS.Memo; //备注
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
 /// <param name = "objvUsers_JTENS">源对象</param>
 /// <returns>目标对象=>clsvUsers_JTEN:objvUsers_JTENT</returns>
 public static clsvUsers_JTEN CopyTo(this clsvUsers_JTEN objvUsers_JTENS)
{
try
{
 clsvUsers_JTEN objvUsers_JTENT = new clsvUsers_JTEN()
{
UserId = objvUsers_JTENS.UserId, //用户ID
UserName = objvUsers_JTENS.UserName, //用户名
Password = objvUsers_JTENS.Password, //Password
PhoneNumber = objvUsers_JTENS.PhoneNumber, //PhoneNumber
AuditDate = objvUsers_JTENS.AuditDate, //AuditDate
AuditUser = objvUsers_JTENS.AuditUser, //AuditUser
IsAudit = objvUsers_JTENS.IsAudit, //是否审核
IsRegister = objvUsers_JTENS.IsRegister, //IsRegister
RegisterDate = objvUsers_JTENS.RegisterDate, //RegisterDate
MobilePhone = objvUsers_JTENS.MobilePhone, //手机
SiteName = objvUsers_JTENS.SiteName, //工地名称
JobCategoryId = objvUsers_JTENS.JobCategoryId, //岗位类别Id
JobCategoryName = objvUsers_JTENS.JobCategoryName, //岗位类别名
ManagedDepartmentId = objvUsers_JTENS.ManagedDepartmentId, //管理的部门Id
ManagedDepartmentName = objvUsers_JTENS.ManagedDepartmentName, //管理的部门名
IDNumber = objvUsers_JTENS.IDNumber, //身份证号
UpdDate = objvUsers_JTENS.UpdDate, //修改日期
UpdUser = objvUsers_JTENS.UpdUser, //修改人
Memo = objvUsers_JTENS.Memo, //备注
};
 return objvUsers_JTENT;
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvUsers_JTEN objvUsers_JTEN)
{
 clsvUsers_JTBL.vUsers_JTDA.CheckProperty4Condition(objvUsers_JTEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUsers_JTEN objvUsers_JTCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUsers_JTCond.IsUpdated(convUsers_JT.UserId) == true)
{
string strComparisonOpUserId = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.UserId, objvUsers_JTCond.UserId, strComparisonOpUserId);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.UserName) == true)
{
string strComparisonOpUserName = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.UserName, objvUsers_JTCond.UserName, strComparisonOpUserName);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.Password) == true)
{
string strComparisonOpPassword = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.Password, objvUsers_JTCond.Password, strComparisonOpPassword);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.PhoneNumber) == true)
{
string strComparisonOpPhoneNumber = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.PhoneNumber, objvUsers_JTCond.PhoneNumber, strComparisonOpPhoneNumber);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.AuditDate) == true)
{
string strComparisonOpAuditDate = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.AuditDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.AuditDate, objvUsers_JTCond.AuditDate, strComparisonOpAuditDate);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.AuditUser) == true)
{
string strComparisonOpAuditUser = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.AuditUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.AuditUser, objvUsers_JTCond.AuditUser, strComparisonOpAuditUser);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.IsAudit) == true)
{
if (objvUsers_JTCond.IsAudit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers_JT.IsAudit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers_JT.IsAudit);
}
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.IsRegister) == true)
{
if (objvUsers_JTCond.IsRegister == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers_JT.IsRegister);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers_JT.IsRegister);
}
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.RegisterDate) == true)
{
string strComparisonOpRegisterDate = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.RegisterDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.RegisterDate, objvUsers_JTCond.RegisterDate, strComparisonOpRegisterDate);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.MobilePhone) == true)
{
string strComparisonOpMobilePhone = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.MobilePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.MobilePhone, objvUsers_JTCond.MobilePhone, strComparisonOpMobilePhone);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.SiteName) == true)
{
string strComparisonOpSiteName = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.SiteName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.SiteName, objvUsers_JTCond.SiteName, strComparisonOpSiteName);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.JobCategoryId) == true)
{
string strComparisonOpJobCategoryId = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.JobCategoryId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.JobCategoryId, objvUsers_JTCond.JobCategoryId, strComparisonOpJobCategoryId);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.JobCategoryName) == true)
{
string strComparisonOpJobCategoryName = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.JobCategoryName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.JobCategoryName, objvUsers_JTCond.JobCategoryName, strComparisonOpJobCategoryName);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.ManagedDepartmentId) == true)
{
string strComparisonOpManagedDepartmentId = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.ManagedDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.ManagedDepartmentId, objvUsers_JTCond.ManagedDepartmentId, strComparisonOpManagedDepartmentId);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.ManagedDepartmentName) == true)
{
string strComparisonOpManagedDepartmentName = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.ManagedDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.ManagedDepartmentName, objvUsers_JTCond.ManagedDepartmentName, strComparisonOpManagedDepartmentName);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.IDNumber) == true)
{
string strComparisonOpIDNumber = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.IDNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.IDNumber, objvUsers_JTCond.IDNumber, strComparisonOpIDNumber);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.UpdDate) == true)
{
string strComparisonOpUpdDate = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.UpdDate, objvUsers_JTCond.UpdDate, strComparisonOpUpdDate);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.UpdUser) == true)
{
string strComparisonOpUpdUser = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.UpdUser, objvUsers_JTCond.UpdUser, strComparisonOpUpdUser);
}
if (objvUsers_JTCond.IsUpdated(convUsers_JT.Memo) == true)
{
string strComparisonOpMemo = objvUsers_JTCond.dicFldComparisonOp[convUsers_JT.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.Memo, objvUsers_JTCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vUsers_JT
{
public virtual bool UpdRelaTabDate(string strUserId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户_JT(vUsers_JT)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvUsers_JTBL
{
public static RelatedActions_vUsers_JT relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvUsers_JTDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvUsers_JTDA vUsers_JTDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvUsers_JTDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvUsers_JTBL()
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
if (string.IsNullOrEmpty(clsvUsers_JTEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUsers_JTEN._ConnectString);
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
public static DataTable GetDataTable_vUsers_JT(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vUsers_JTDA.GetDataTable_vUsers_JT(strWhereCond);
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
objDT = vUsers_JTDA.GetDataTable(strWhereCond);
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
objDT = vUsers_JTDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vUsers_JTDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vUsers_JTDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vUsers_JTDA.GetDataTable_Top(objTopPara);
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
objDT = vUsers_JTDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vUsers_JTDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vUsers_JTDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvUsers_JTEN> GetObjLstByUserIdLst(List<string> arrUserIdLst)
{
List<clsvUsers_JTEN> arrObjLst = new List<clsvUsers_JTEN>(); 
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
	clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN();
try
{
objvUsers_JTEN.UserId = objRow[convUsers_JT.UserId].ToString().Trim(); //用户ID
objvUsers_JTEN.UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(); //用户名
objvUsers_JTEN.Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(); //Password
objvUsers_JTEN.PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber
objvUsers_JTEN.AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(); //AuditDate
objvUsers_JTEN.AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(); //AuditUser
objvUsers_JTEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsAudit].ToString().Trim()); //是否审核
objvUsers_JTEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsRegister].ToString().Trim()); //IsRegister
objvUsers_JTEN.RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate
objvUsers_JTEN.MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(); //手机
objvUsers_JTEN.SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(); //工地名称
objvUsers_JTEN.JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvUsers_JTEN.JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvUsers_JTEN.ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvUsers_JTEN.ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvUsers_JTEN.IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(); //身份证号
objvUsers_JTEN.UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(); //修改日期
objvUsers_JTEN.UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(); //修改人
objvUsers_JTEN.Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsers_JTEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsers_JTEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvUsers_JTEN> GetObjLstByUserIdLstCache(List<string> arrUserIdLst)
{
string strKey = string.Format("{0}", clsvUsers_JTEN._CurrTabName);
List<clsvUsers_JTEN> arrvUsers_JTObjLstCache = GetObjLstCache();
IEnumerable <clsvUsers_JTEN> arrvUsers_JTObjLst_Sel =
arrvUsers_JTObjLstCache
.Where(x => arrUserIdLst.Contains(x.UserId));
return arrvUsers_JTObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsers_JTEN> GetObjLst(string strWhereCond)
{
List<clsvUsers_JTEN> arrObjLst = new List<clsvUsers_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN();
try
{
objvUsers_JTEN.UserId = objRow[convUsers_JT.UserId].ToString().Trim(); //用户ID
objvUsers_JTEN.UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(); //用户名
objvUsers_JTEN.Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(); //Password
objvUsers_JTEN.PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber
objvUsers_JTEN.AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(); //AuditDate
objvUsers_JTEN.AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(); //AuditUser
objvUsers_JTEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsAudit].ToString().Trim()); //是否审核
objvUsers_JTEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsRegister].ToString().Trim()); //IsRegister
objvUsers_JTEN.RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate
objvUsers_JTEN.MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(); //手机
objvUsers_JTEN.SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(); //工地名称
objvUsers_JTEN.JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvUsers_JTEN.JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvUsers_JTEN.ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvUsers_JTEN.ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvUsers_JTEN.IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(); //身份证号
objvUsers_JTEN.UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(); //修改日期
objvUsers_JTEN.UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(); //修改人
objvUsers_JTEN.Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsers_JTEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsers_JTEN);
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
public static List<clsvUsers_JTEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvUsers_JTEN> arrObjLst = new List<clsvUsers_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN();
try
{
objvUsers_JTEN.UserId = objRow[convUsers_JT.UserId].ToString().Trim(); //用户ID
objvUsers_JTEN.UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(); //用户名
objvUsers_JTEN.Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(); //Password
objvUsers_JTEN.PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber
objvUsers_JTEN.AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(); //AuditDate
objvUsers_JTEN.AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(); //AuditUser
objvUsers_JTEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsAudit].ToString().Trim()); //是否审核
objvUsers_JTEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsRegister].ToString().Trim()); //IsRegister
objvUsers_JTEN.RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate
objvUsers_JTEN.MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(); //手机
objvUsers_JTEN.SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(); //工地名称
objvUsers_JTEN.JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvUsers_JTEN.JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvUsers_JTEN.ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvUsers_JTEN.ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvUsers_JTEN.IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(); //身份证号
objvUsers_JTEN.UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(); //修改日期
objvUsers_JTEN.UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(); //修改人
objvUsers_JTEN.Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsers_JTEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsers_JTEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvUsers_JTCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvUsers_JTEN> GetSubObjLstCache(clsvUsers_JTEN objvUsers_JTCond)
{
List<clsvUsers_JTEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUsers_JTEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUsers_JT.AttributeName)
{
if (objvUsers_JTCond.IsUpdated(strFldName) == false) continue;
if (objvUsers_JTCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUsers_JTCond[strFldName].ToString());
}
else
{
if (objvUsers_JTCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUsers_JTCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUsers_JTCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUsers_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUsers_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUsers_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUsers_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUsers_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUsers_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUsers_JTCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUsers_JTCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUsers_JTCond[strFldName]));
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
public static List<clsvUsers_JTEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvUsers_JTEN> arrObjLst = new List<clsvUsers_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN();
try
{
objvUsers_JTEN.UserId = objRow[convUsers_JT.UserId].ToString().Trim(); //用户ID
objvUsers_JTEN.UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(); //用户名
objvUsers_JTEN.Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(); //Password
objvUsers_JTEN.PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber
objvUsers_JTEN.AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(); //AuditDate
objvUsers_JTEN.AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(); //AuditUser
objvUsers_JTEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsAudit].ToString().Trim()); //是否审核
objvUsers_JTEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsRegister].ToString().Trim()); //IsRegister
objvUsers_JTEN.RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate
objvUsers_JTEN.MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(); //手机
objvUsers_JTEN.SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(); //工地名称
objvUsers_JTEN.JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvUsers_JTEN.JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvUsers_JTEN.ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvUsers_JTEN.ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvUsers_JTEN.IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(); //身份证号
objvUsers_JTEN.UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(); //修改日期
objvUsers_JTEN.UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(); //修改人
objvUsers_JTEN.Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsers_JTEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsers_JTEN);
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
public static List<clsvUsers_JTEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvUsers_JTEN> arrObjLst = new List<clsvUsers_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN();
try
{
objvUsers_JTEN.UserId = objRow[convUsers_JT.UserId].ToString().Trim(); //用户ID
objvUsers_JTEN.UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(); //用户名
objvUsers_JTEN.Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(); //Password
objvUsers_JTEN.PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber
objvUsers_JTEN.AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(); //AuditDate
objvUsers_JTEN.AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(); //AuditUser
objvUsers_JTEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsAudit].ToString().Trim()); //是否审核
objvUsers_JTEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsRegister].ToString().Trim()); //IsRegister
objvUsers_JTEN.RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate
objvUsers_JTEN.MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(); //手机
objvUsers_JTEN.SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(); //工地名称
objvUsers_JTEN.JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvUsers_JTEN.JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvUsers_JTEN.ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvUsers_JTEN.ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvUsers_JTEN.IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(); //身份证号
objvUsers_JTEN.UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(); //修改日期
objvUsers_JTEN.UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(); //修改人
objvUsers_JTEN.Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsers_JTEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsers_JTEN);
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
List<clsvUsers_JTEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvUsers_JTEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsers_JTEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvUsers_JTEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvUsers_JTEN> arrObjLst = new List<clsvUsers_JTEN>(); 
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
	clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN();
try
{
objvUsers_JTEN.UserId = objRow[convUsers_JT.UserId].ToString().Trim(); //用户ID
objvUsers_JTEN.UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(); //用户名
objvUsers_JTEN.Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(); //Password
objvUsers_JTEN.PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber
objvUsers_JTEN.AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(); //AuditDate
objvUsers_JTEN.AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(); //AuditUser
objvUsers_JTEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsAudit].ToString().Trim()); //是否审核
objvUsers_JTEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsRegister].ToString().Trim()); //IsRegister
objvUsers_JTEN.RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate
objvUsers_JTEN.MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(); //手机
objvUsers_JTEN.SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(); //工地名称
objvUsers_JTEN.JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvUsers_JTEN.JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvUsers_JTEN.ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvUsers_JTEN.ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvUsers_JTEN.IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(); //身份证号
objvUsers_JTEN.UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(); //修改日期
objvUsers_JTEN.UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(); //修改人
objvUsers_JTEN.Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsers_JTEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsers_JTEN);
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
public static List<clsvUsers_JTEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvUsers_JTEN> arrObjLst = new List<clsvUsers_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN();
try
{
objvUsers_JTEN.UserId = objRow[convUsers_JT.UserId].ToString().Trim(); //用户ID
objvUsers_JTEN.UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(); //用户名
objvUsers_JTEN.Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(); //Password
objvUsers_JTEN.PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber
objvUsers_JTEN.AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(); //AuditDate
objvUsers_JTEN.AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(); //AuditUser
objvUsers_JTEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsAudit].ToString().Trim()); //是否审核
objvUsers_JTEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsRegister].ToString().Trim()); //IsRegister
objvUsers_JTEN.RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate
objvUsers_JTEN.MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(); //手机
objvUsers_JTEN.SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(); //工地名称
objvUsers_JTEN.JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvUsers_JTEN.JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvUsers_JTEN.ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvUsers_JTEN.ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvUsers_JTEN.IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(); //身份证号
objvUsers_JTEN.UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(); //修改日期
objvUsers_JTEN.UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(); //修改人
objvUsers_JTEN.Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsers_JTEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsers_JTEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvUsers_JTEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvUsers_JTEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvUsers_JTEN> arrObjLst = new List<clsvUsers_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN();
try
{
objvUsers_JTEN.UserId = objRow[convUsers_JT.UserId].ToString().Trim(); //用户ID
objvUsers_JTEN.UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(); //用户名
objvUsers_JTEN.Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(); //Password
objvUsers_JTEN.PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber
objvUsers_JTEN.AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(); //AuditDate
objvUsers_JTEN.AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(); //AuditUser
objvUsers_JTEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsAudit].ToString().Trim()); //是否审核
objvUsers_JTEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsRegister].ToString().Trim()); //IsRegister
objvUsers_JTEN.RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate
objvUsers_JTEN.MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(); //手机
objvUsers_JTEN.SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(); //工地名称
objvUsers_JTEN.JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvUsers_JTEN.JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvUsers_JTEN.ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvUsers_JTEN.ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvUsers_JTEN.IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(); //身份证号
objvUsers_JTEN.UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(); //修改日期
objvUsers_JTEN.UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(); //修改人
objvUsers_JTEN.Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsers_JTEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsers_JTEN);
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
public static List<clsvUsers_JTEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvUsers_JTEN> arrObjLst = new List<clsvUsers_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN();
try
{
objvUsers_JTEN.UserId = objRow[convUsers_JT.UserId].ToString().Trim(); //用户ID
objvUsers_JTEN.UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(); //用户名
objvUsers_JTEN.Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(); //Password
objvUsers_JTEN.PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber
objvUsers_JTEN.AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(); //AuditDate
objvUsers_JTEN.AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(); //AuditUser
objvUsers_JTEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsAudit].ToString().Trim()); //是否审核
objvUsers_JTEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsRegister].ToString().Trim()); //IsRegister
objvUsers_JTEN.RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate
objvUsers_JTEN.MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(); //手机
objvUsers_JTEN.SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(); //工地名称
objvUsers_JTEN.JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvUsers_JTEN.JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvUsers_JTEN.ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvUsers_JTEN.ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvUsers_JTEN.IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(); //身份证号
objvUsers_JTEN.UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(); //修改日期
objvUsers_JTEN.UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(); //修改人
objvUsers_JTEN.Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsers_JTEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsers_JTEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsers_JTEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvUsers_JTEN> arrObjLst = new List<clsvUsers_JTEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN();
try
{
objvUsers_JTEN.UserId = objRow[convUsers_JT.UserId].ToString().Trim(); //用户ID
objvUsers_JTEN.UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(); //用户名
objvUsers_JTEN.Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(); //Password
objvUsers_JTEN.PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber
objvUsers_JTEN.AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(); //AuditDate
objvUsers_JTEN.AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(); //AuditUser
objvUsers_JTEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsAudit].ToString().Trim()); //是否审核
objvUsers_JTEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsRegister].ToString().Trim()); //IsRegister
objvUsers_JTEN.RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate
objvUsers_JTEN.MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(); //手机
objvUsers_JTEN.SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(); //工地名称
objvUsers_JTEN.JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvUsers_JTEN.JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvUsers_JTEN.ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvUsers_JTEN.ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvUsers_JTEN.IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(); //身份证号
objvUsers_JTEN.UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(); //修改日期
objvUsers_JTEN.UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(); //修改人
objvUsers_JTEN.Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsers_JTEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsers_JTEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvUsers_JTEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvUsers_JT(ref clsvUsers_JTEN objvUsers_JTEN)
{
bool bolResult = vUsers_JTDA.GetvUsers_JT(ref objvUsers_JTEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUsers_JTEN GetObjByUserId(string strUserId)
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
clsvUsers_JTEN objvUsers_JTEN = vUsers_JTDA.GetObjByUserId(strUserId);
return objvUsers_JTEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvUsers_JTEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvUsers_JTEN objvUsers_JTEN = vUsers_JTDA.GetFirstObj(strWhereCond);
 return objvUsers_JTEN;
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
public static clsvUsers_JTEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvUsers_JTEN objvUsers_JTEN = vUsers_JTDA.GetObjByDataRow(objRow);
 return objvUsers_JTEN;
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
public static clsvUsers_JTEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvUsers_JTEN objvUsers_JTEN = vUsers_JTDA.GetObjByDataRow(objRow);
 return objvUsers_JTEN;
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
 /// <param name = "lstvUsers_JTObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUsers_JTEN GetObjByUserIdFromList(string strUserId, List<clsvUsers_JTEN> lstvUsers_JTObjLst)
{
foreach (clsvUsers_JTEN objvUsers_JTEN in lstvUsers_JTObjLst)
{
if (objvUsers_JTEN.UserId == strUserId)
{
return objvUsers_JTEN;
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
 strUserId = new clsvUsers_JTDA().GetFirstID(strWhereCond);
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
 arrList = vUsers_JTDA.GetID(strWhereCond);
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
bool bolIsExist = vUsers_JTDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vUsers_JTDA.IsExist(strUserId);
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
 bolIsExist = clsvUsers_JTDA.IsExistTable();
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
 bolIsExist = vUsers_JTDA.IsExistTable(strTabName);
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


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvUsers_JTENS">源对象</param>
 /// <param name = "objvUsers_JTENT">目标对象</param>
 public static void CopyTo(clsvUsers_JTEN objvUsers_JTENS, clsvUsers_JTEN objvUsers_JTENT)
{
try
{
objvUsers_JTENT.UserId = objvUsers_JTENS.UserId; //用户ID
objvUsers_JTENT.UserName = objvUsers_JTENS.UserName; //用户名
objvUsers_JTENT.Password = objvUsers_JTENS.Password; //Password
objvUsers_JTENT.PhoneNumber = objvUsers_JTENS.PhoneNumber; //PhoneNumber
objvUsers_JTENT.AuditDate = objvUsers_JTENS.AuditDate; //AuditDate
objvUsers_JTENT.AuditUser = objvUsers_JTENS.AuditUser; //AuditUser
objvUsers_JTENT.IsAudit = objvUsers_JTENS.IsAudit; //是否审核
objvUsers_JTENT.IsRegister = objvUsers_JTENS.IsRegister; //IsRegister
objvUsers_JTENT.RegisterDate = objvUsers_JTENS.RegisterDate; //RegisterDate
objvUsers_JTENT.MobilePhone = objvUsers_JTENS.MobilePhone; //手机
objvUsers_JTENT.SiteName = objvUsers_JTENS.SiteName; //工地名称
objvUsers_JTENT.JobCategoryId = objvUsers_JTENS.JobCategoryId; //岗位类别Id
objvUsers_JTENT.JobCategoryName = objvUsers_JTENS.JobCategoryName; //岗位类别名
objvUsers_JTENT.ManagedDepartmentId = objvUsers_JTENS.ManagedDepartmentId; //管理的部门Id
objvUsers_JTENT.ManagedDepartmentName = objvUsers_JTENS.ManagedDepartmentName; //管理的部门名
objvUsers_JTENT.IDNumber = objvUsers_JTENS.IDNumber; //身份证号
objvUsers_JTENT.UpdDate = objvUsers_JTENS.UpdDate; //修改日期
objvUsers_JTENT.UpdUser = objvUsers_JTENS.UpdUser; //修改人
objvUsers_JTENT.Memo = objvUsers_JTENS.Memo; //备注
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
 /// <param name = "objvUsers_JTEN">源简化对象</param>
 public static void SetUpdFlag(clsvUsers_JTEN objvUsers_JTEN)
{
try
{
objvUsers_JTEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvUsers_JTEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convUsers_JT.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.UserId = objvUsers_JTEN.UserId; //用户ID
}
if (arrFldSet.Contains(convUsers_JT.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.UserName = objvUsers_JTEN.UserName == "[null]" ? null :  objvUsers_JTEN.UserName; //用户名
}
if (arrFldSet.Contains(convUsers_JT.Password, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.Password = objvUsers_JTEN.Password == "[null]" ? null :  objvUsers_JTEN.Password; //Password
}
if (arrFldSet.Contains(convUsers_JT.PhoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.PhoneNumber = objvUsers_JTEN.PhoneNumber == "[null]" ? null :  objvUsers_JTEN.PhoneNumber; //PhoneNumber
}
if (arrFldSet.Contains(convUsers_JT.AuditDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.AuditDate = objvUsers_JTEN.AuditDate == "[null]" ? null :  objvUsers_JTEN.AuditDate; //AuditDate
}
if (arrFldSet.Contains(convUsers_JT.AuditUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.AuditUser = objvUsers_JTEN.AuditUser == "[null]" ? null :  objvUsers_JTEN.AuditUser; //AuditUser
}
if (arrFldSet.Contains(convUsers_JT.IsAudit, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.IsAudit = objvUsers_JTEN.IsAudit; //是否审核
}
if (arrFldSet.Contains(convUsers_JT.IsRegister, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.IsRegister = objvUsers_JTEN.IsRegister; //IsRegister
}
if (arrFldSet.Contains(convUsers_JT.RegisterDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.RegisterDate = objvUsers_JTEN.RegisterDate == "[null]" ? null :  objvUsers_JTEN.RegisterDate; //RegisterDate
}
if (arrFldSet.Contains(convUsers_JT.MobilePhone, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.MobilePhone = objvUsers_JTEN.MobilePhone == "[null]" ? null :  objvUsers_JTEN.MobilePhone; //手机
}
if (arrFldSet.Contains(convUsers_JT.SiteName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.SiteName = objvUsers_JTEN.SiteName; //工地名称
}
if (arrFldSet.Contains(convUsers_JT.JobCategoryId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.JobCategoryId = objvUsers_JTEN.JobCategoryId; //岗位类别Id
}
if (arrFldSet.Contains(convUsers_JT.JobCategoryName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.JobCategoryName = objvUsers_JTEN.JobCategoryName; //岗位类别名
}
if (arrFldSet.Contains(convUsers_JT.ManagedDepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.ManagedDepartmentId = objvUsers_JTEN.ManagedDepartmentId; //管理的部门Id
}
if (arrFldSet.Contains(convUsers_JT.ManagedDepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.ManagedDepartmentName = objvUsers_JTEN.ManagedDepartmentName; //管理的部门名
}
if (arrFldSet.Contains(convUsers_JT.IDNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.IDNumber = objvUsers_JTEN.IDNumber == "[null]" ? null :  objvUsers_JTEN.IDNumber; //身份证号
}
if (arrFldSet.Contains(convUsers_JT.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.UpdDate = objvUsers_JTEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convUsers_JT.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.UpdUser = objvUsers_JTEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convUsers_JT.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsers_JTEN.Memo = objvUsers_JTEN.Memo == "[null]" ? null :  objvUsers_JTEN.Memo; //备注
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
 /// <param name = "objvUsers_JTEN">源简化对象</param>
 public static void AccessFldValueNull(clsvUsers_JTEN objvUsers_JTEN)
{
try
{
if (objvUsers_JTEN.UserName == "[null]") objvUsers_JTEN.UserName = null; //用户名
if (objvUsers_JTEN.Password == "[null]") objvUsers_JTEN.Password = null; //Password
if (objvUsers_JTEN.PhoneNumber == "[null]") objvUsers_JTEN.PhoneNumber = null; //PhoneNumber
if (objvUsers_JTEN.AuditDate == "[null]") objvUsers_JTEN.AuditDate = null; //AuditDate
if (objvUsers_JTEN.AuditUser == "[null]") objvUsers_JTEN.AuditUser = null; //AuditUser
if (objvUsers_JTEN.RegisterDate == "[null]") objvUsers_JTEN.RegisterDate = null; //RegisterDate
if (objvUsers_JTEN.MobilePhone == "[null]") objvUsers_JTEN.MobilePhone = null; //手机
if (objvUsers_JTEN.IDNumber == "[null]") objvUsers_JTEN.IDNumber = null; //身份证号
if (objvUsers_JTEN.Memo == "[null]") objvUsers_JTEN.Memo = null; //备注
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvUsers_JTEN objvUsers_JTEN)
{
 vUsers_JTDA.CheckProperty4Condition(objvUsers_JTEN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsers_JTBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsers_JTBL没有刷新缓存机制(clsUsers_JTBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsManagedDepartmentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsManagedDepartmentBL没有刷新缓存机制(clsManagedDepartmentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsJobCategoryBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsJobCategoryBL没有刷新缓存机制(clsJobCategoryBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserId");
//if (arrvUsers_JTObjLstCache == null)
//{
//arrvUsers_JTObjLstCache = vUsers_JTDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUsers_JTEN GetObjByUserIdCache(string strUserId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvUsers_JTEN._CurrTabName);
List<clsvUsers_JTEN> arrvUsers_JTObjLstCache = GetObjLstCache();
IEnumerable <clsvUsers_JTEN> arrvUsers_JTObjLst_Sel =
arrvUsers_JTObjLstCache
.Where(x=> x.UserId == strUserId 
);
if (arrvUsers_JTObjLst_Sel.Count() == 0)
{
   clsvUsers_JTEN obj = clsvUsers_JTBL.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvUsers_JTObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUsers_JTEN> GetAllvUsers_JTObjLstCache()
{
//获取缓存中的对象列表
List<clsvUsers_JTEN> arrvUsers_JTObjLstCache = GetObjLstCache(); 
return arrvUsers_JTObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUsers_JTEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvUsers_JTEN._CurrTabName);
List<clsvUsers_JTEN> arrvUsers_JTObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvUsers_JTObjLstCache;
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
string strKey = string.Format("{0}", clsvUsers_JTEN._CurrTabName);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strUserId)
{
if (strInFldName != convUsers_JT.UserId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convUsers_JT.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convUsers_JT.AttributeName));
throw new Exception(strMsg);
}
var objvUsers_JT = clsvUsers_JTBL.GetObjByUserIdCache(strUserId);
if (objvUsers_JT == null) return "";
return objvUsers_JT[strOutFldName].ToString();
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
int intRecCount = clsvUsers_JTDA.GetRecCount(strTabName);
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
int intRecCount = clsvUsers_JTDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvUsers_JTDA.GetRecCount();
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
int intRecCount = clsvUsers_JTDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvUsers_JTCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvUsers_JTEN objvUsers_JTCond)
{
List<clsvUsers_JTEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUsers_JTEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUsers_JT.AttributeName)
{
if (objvUsers_JTCond.IsUpdated(strFldName) == false) continue;
if (objvUsers_JTCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUsers_JTCond[strFldName].ToString());
}
else
{
if (objvUsers_JTCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUsers_JTCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUsers_JTCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUsers_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUsers_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUsers_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUsers_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUsers_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUsers_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUsers_JTCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUsers_JTCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUsers_JTCond[strFldName]));
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
 List<string> arrList = clsvUsers_JTDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vUsers_JTDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vUsers_JTDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}