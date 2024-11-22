
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsers_JTWApi
 表名:vUsers_JT(01120230)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:31
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
 框架-层名:WA_访问层_CS(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using ExamLib.Entity;

namespace ExamLib4WApi
{
public static class clsvUsers_JTWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetUserId(this clsvUsers_JTEN objvUsers_JTEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convUsers_JT.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetUserName(this clsvUsers_JTEN objvUsers_JTEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convUsers_JT.UserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetPassword(this clsvUsers_JTEN objvUsers_JTEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPassword, 20, convUsers_JT.Password);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetPhoneNumber(this clsvUsers_JTEN objvUsers_JTEN, string strPhoneNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, convUsers_JT.PhoneNumber);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetAuditDate(this clsvUsers_JTEN objvUsers_JTEN, string strAuditDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAuditDate, 14, convUsers_JT.AuditDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetAuditUser(this clsvUsers_JTEN objvUsers_JTEN, string strAuditUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAuditUser, 18, convUsers_JT.AuditUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetRegisterDate(this clsvUsers_JTEN objvUsers_JTEN, string strRegisterDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegisterDate, 14, convUsers_JT.RegisterDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetMobilePhone(this clsvUsers_JTEN objvUsers_JTEN, string strMobilePhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMobilePhone, 20, convUsers_JT.MobilePhone);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetSiteName(this clsvUsers_JTEN objvUsers_JTEN, string strSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSiteName, convUsers_JT.SiteName);
clsCheckSql.CheckFieldLen(strSiteName, 100, convUsers_JT.SiteName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetJobCategoryId(this clsvUsers_JTEN objvUsers_JTEN, string strJobCategoryId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJobCategoryId, convUsers_JT.JobCategoryId);
clsCheckSql.CheckFieldLen(strJobCategoryId, 2, convUsers_JT.JobCategoryId);
clsCheckSql.CheckFieldForeignKey(strJobCategoryId, 2, convUsers_JT.JobCategoryId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetJobCategoryName(this clsvUsers_JTEN objvUsers_JTEN, string strJobCategoryName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJobCategoryName, convUsers_JT.JobCategoryName);
clsCheckSql.CheckFieldLen(strJobCategoryName, 50, convUsers_JT.JobCategoryName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetManagedDepartmentId(this clsvUsers_JTEN objvUsers_JTEN, string strManagedDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strManagedDepartmentId, convUsers_JT.ManagedDepartmentId);
clsCheckSql.CheckFieldLen(strManagedDepartmentId, 4, convUsers_JT.ManagedDepartmentId);
clsCheckSql.CheckFieldForeignKey(strManagedDepartmentId, 4, convUsers_JT.ManagedDepartmentId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetManagedDepartmentName(this clsvUsers_JTEN objvUsers_JTEN, string strManagedDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strManagedDepartmentName, convUsers_JT.ManagedDepartmentName);
clsCheckSql.CheckFieldLen(strManagedDepartmentName, 50, convUsers_JT.ManagedDepartmentName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetIDNumber(this clsvUsers_JTEN objvUsers_JTEN, string strIDNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIDNumber, 18, convUsers_JT.IDNumber);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetUpdDate(this clsvUsers_JTEN objvUsers_JTEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convUsers_JT.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUsers_JT.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetUpdUser(this clsvUsers_JTEN objvUsers_JTEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convUsers_JT.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convUsers_JT.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsers_JTEN SetMemo(this clsvUsers_JTEN objvUsers_JTEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUsers_JT.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUsers_JTEN objvUsers_JT_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.UserId) == true)
{
string strComparisonOp_UserId = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.UserId, objvUsers_JT_Cond.UserId, strComparisonOp_UserId);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.UserName) == true)
{
string strComparisonOp_UserName = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.UserName, objvUsers_JT_Cond.UserName, strComparisonOp_UserName);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.Password) == true)
{
string strComparisonOp_Password = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.Password, objvUsers_JT_Cond.Password, strComparisonOp_Password);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.PhoneNumber) == true)
{
string strComparisonOp_PhoneNumber = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.PhoneNumber, objvUsers_JT_Cond.PhoneNumber, strComparisonOp_PhoneNumber);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.AuditDate) == true)
{
string strComparisonOp_AuditDate = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.AuditDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.AuditDate, objvUsers_JT_Cond.AuditDate, strComparisonOp_AuditDate);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.AuditUser) == true)
{
string strComparisonOp_AuditUser = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.AuditUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.AuditUser, objvUsers_JT_Cond.AuditUser, strComparisonOp_AuditUser);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.IsAudit) == true)
{
if (objvUsers_JT_Cond.IsAudit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers_JT.IsAudit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers_JT.IsAudit);
}
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.IsRegister) == true)
{
if (objvUsers_JT_Cond.IsRegister == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers_JT.IsRegister);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers_JT.IsRegister);
}
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.RegisterDate) == true)
{
string strComparisonOp_RegisterDate = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.RegisterDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.RegisterDate, objvUsers_JT_Cond.RegisterDate, strComparisonOp_RegisterDate);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.MobilePhone) == true)
{
string strComparisonOp_MobilePhone = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.MobilePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.MobilePhone, objvUsers_JT_Cond.MobilePhone, strComparisonOp_MobilePhone);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.SiteName) == true)
{
string strComparisonOp_SiteName = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.SiteName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.SiteName, objvUsers_JT_Cond.SiteName, strComparisonOp_SiteName);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.JobCategoryId) == true)
{
string strComparisonOp_JobCategoryId = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.JobCategoryId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.JobCategoryId, objvUsers_JT_Cond.JobCategoryId, strComparisonOp_JobCategoryId);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.JobCategoryName) == true)
{
string strComparisonOp_JobCategoryName = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.JobCategoryName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.JobCategoryName, objvUsers_JT_Cond.JobCategoryName, strComparisonOp_JobCategoryName);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.ManagedDepartmentId) == true)
{
string strComparisonOp_ManagedDepartmentId = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.ManagedDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.ManagedDepartmentId, objvUsers_JT_Cond.ManagedDepartmentId, strComparisonOp_ManagedDepartmentId);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.ManagedDepartmentName) == true)
{
string strComparisonOp_ManagedDepartmentName = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.ManagedDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.ManagedDepartmentName, objvUsers_JT_Cond.ManagedDepartmentName, strComparisonOp_ManagedDepartmentName);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.IDNumber) == true)
{
string strComparisonOp_IDNumber = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.IDNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.IDNumber, objvUsers_JT_Cond.IDNumber, strComparisonOp_IDNumber);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.UpdDate, objvUsers_JT_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.UpdUser, objvUsers_JT_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvUsers_JT_Cond.IsUpdated(convUsers_JT.Memo) == true)
{
string strComparisonOp_Memo = objvUsers_JT_Cond.dicFldComparisonOp[convUsers_JT.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers_JT.Memo, objvUsers_JT_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户_JT(vUsers_JT)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvUsers_JTWApi
{
private static readonly string mstrApiControllerName = "vUsers_JTApi";

 public clsvUsers_JTWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUsers_JTEN GetObjByUserId(string strUserId)
{
string strAction = "GetObjByUserId";
string strErrMsg = string.Empty;
string strResult = "";
clsvUsers_JTEN objvUsers_JTEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["UserId"] = strUserId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvUsers_JTEN = JsonConvert.DeserializeObject<clsvUsers_JTEN>((string)jobjReturn["ReturnObj"]);
return objvUsers_JTEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUsers_JTEN GetObjByUserId_WA_Cache(string strUserId)
{
string strAction = "GetObjByUserId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvUsers_JTEN objvUsers_JTEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["UserId"] = strUserId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvUsers_JTEN = JsonConvert.DeserializeObject<clsvUsers_JTEN>((string)jobjReturn["ReturnObj"]);
return objvUsers_JTEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvUsers_JTEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvUsers_JTEN objvUsers_JTEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvUsers_JTEN = JsonConvert.DeserializeObject<clsvUsers_JTEN>((string)jobjReturn["ReturnObj"]);
return objvUsers_JTEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUsers_JTEN GetObjByUserId_Cache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvUsers_JTEN._CurrTabName_S);
List<clsvUsers_JTEN> arrvUsers_JTObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUsers_JTEN> arrvUsers_JTObjLst_Sel =
from objvUsers_JTEN in arrvUsers_JTObjLst_Cache
where objvUsers_JTEN.UserId == strUserId
select objvUsers_JTEN;
if (arrvUsers_JTObjLst_Sel.Count() == 0)
{
   clsvUsers_JTEN obj = clsvUsers_JTWApi.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvUsers_JTObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsers_JTEN> GetObjLst(string strWhereCond)
{
 List<clsvUsers_JTEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsers_JTEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsers_JTEN> GetObjLstByUserIdLst(List<string> arrUserId)
{
 List<clsvUsers_JTEN> arrObjLst = null; 
string strAction = "GetObjLstByUserIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsers_JTEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvUsers_JTEN> GetObjLstByUserIdLst_Cache(List<string> arrUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvUsers_JTEN._CurrTabName_S);
List<clsvUsers_JTEN> arrvUsers_JTObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUsers_JTEN> arrvUsers_JTObjLst_Sel =
from objvUsers_JTEN in arrvUsers_JTObjLst_Cache
where arrUserId.Contains(objvUsers_JTEN.UserId)
select objvUsers_JTEN;
return arrvUsers_JTObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsers_JTEN> GetObjLstByUserIdLst_WA_Cache(List<string> arrUserId)
{
 List<clsvUsers_JTEN> arrObjLst = null; 
string strAction = "GetObjLstByUserIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsers_JTEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsers_JTEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvUsers_JTEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsers_JTEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsers_JTEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvUsers_JTEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsers_JTEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvUsers_JTEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvUsers_JTEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsers_JTEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvUsers_JTEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvUsers_JTEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsers_JTEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(string strUserId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["UserId"] = strUserId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
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
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsvUsers_JTEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvUsers_JTEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvUsers_JTEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvUsers_JTEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvUsers_JTEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvUsers_JTEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsers_JTWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsers_JTWApi没有刷新缓存机制(clsUsers_JTWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsManagedDepartmentWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsManagedDepartmentWApi没有刷新缓存机制(clsManagedDepartmentWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsJobCategoryWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsJobCategoryWApi没有刷新缓存机制(clsJobCategoryWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserId");
//if (arrvUsers_JTObjLst_Cache == null)
//{
//arrvUsers_JTObjLst_Cache = await clsvUsers_JTWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvUsers_JTEN._CurrTabName_S);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUsers_JTEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvUsers_JTEN._CurrTabName_S);
List<clsvUsers_JTEN> arrvUsers_JTObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvUsers_JTObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvUsers_JTEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convUsers_JT.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.Password, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.PhoneNumber, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.AuditDate, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.AuditUser, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.IsAudit, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUsers_JT.IsRegister, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUsers_JT.RegisterDate, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.MobilePhone, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.SiteName, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.JobCategoryId, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.JobCategoryName, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.ManagedDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.ManagedDepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.IDNumber, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convUsers_JT.Memo, Type.GetType("System.String"));
foreach (clsvUsers_JTEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convUsers_JT.UserId] = objInFor[convUsers_JT.UserId];
objDR[convUsers_JT.UserName] = objInFor[convUsers_JT.UserName];
objDR[convUsers_JT.Password] = objInFor[convUsers_JT.Password];
objDR[convUsers_JT.PhoneNumber] = objInFor[convUsers_JT.PhoneNumber];
objDR[convUsers_JT.AuditDate] = objInFor[convUsers_JT.AuditDate];
objDR[convUsers_JT.AuditUser] = objInFor[convUsers_JT.AuditUser];
objDR[convUsers_JT.IsAudit] = objInFor[convUsers_JT.IsAudit];
objDR[convUsers_JT.IsRegister] = objInFor[convUsers_JT.IsRegister];
objDR[convUsers_JT.RegisterDate] = objInFor[convUsers_JT.RegisterDate];
objDR[convUsers_JT.MobilePhone] = objInFor[convUsers_JT.MobilePhone];
objDR[convUsers_JT.SiteName] = objInFor[convUsers_JT.SiteName];
objDR[convUsers_JT.JobCategoryId] = objInFor[convUsers_JT.JobCategoryId];
objDR[convUsers_JT.JobCategoryName] = objInFor[convUsers_JT.JobCategoryName];
objDR[convUsers_JT.ManagedDepartmentId] = objInFor[convUsers_JT.ManagedDepartmentId];
objDR[convUsers_JT.ManagedDepartmentName] = objInFor[convUsers_JT.ManagedDepartmentName];
objDR[convUsers_JT.IDNumber] = objInFor[convUsers_JT.IDNumber];
objDR[convUsers_JT.UpdDate] = objInFor[convUsers_JT.UpdDate];
objDR[convUsers_JT.UpdUser] = objInFor[convUsers_JT.UpdUser];
objDR[convUsers_JT.Memo] = objInFor[convUsers_JT.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}