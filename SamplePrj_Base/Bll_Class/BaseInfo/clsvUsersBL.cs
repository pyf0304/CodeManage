
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsersBL
 表名:vUsers(01160035)
 生成代码版本:2022.04.24.1
 生成日期:2022/04/25 00:30:08
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:基本信息(BaseInfo)
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
using SimplePrj.Entity;
using System.Data; 
using System.Data.SqlClient; 
using SimplePrj.DAL;

namespace SimplePrj.BusinessLogic
{
public static class clsvUsersBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUsersEN GetObj(this K_UserId_vUsers myKey)
{
clsvUsersEN objvUsersEN = clsvUsersBL.vUsersDA.GetObjByUserId(myKey.Value);
return objvUsersEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetUserId(this clsvUsersEN objvUsersEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convUsers.UserId);
}
objvUsersEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.UserId) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.UserId, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.UserId] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetUserName(this clsvUsersEN objvUsersEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convUsers.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convUsers.UserName);
}
objvUsersEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.UserName) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.UserName, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.UserName] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetPassword(this clsvUsersEN objvUsersEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPassword, convUsers.Password);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPassword, 20, convUsers.Password);
}
objvUsersEN.Password = strPassword; //密码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.Password) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.Password, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.Password] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetDepartmentId(this clsvUsersEN objvUsersEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 6, convUsers.DepartmentId);
}
objvUsersEN.DepartmentId = strDepartmentId; //部门ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.DepartmentId) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.DepartmentId, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.DepartmentId] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetDepartmentName(this clsvUsersEN objvUsersEN, string strDepartmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 20, convUsers.DepartmentName);
}
objvUsersEN.DepartmentName = strDepartmentName; //部门名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.DepartmentName) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.DepartmentName, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.DepartmentName] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetEmail(this clsvUsersEN objvUsersEN, string strEmail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEmail, 100, convUsers.Email);
}
objvUsersEN.Email = strEmail; //Email
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.Email) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.Email, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.Email] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetIdentityID(this clsvUsersEN objvUsersEN, string strIdentityID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityID, 2, convUsers.IdentityID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityID, 2, convUsers.IdentityID);
}
objvUsersEN.IdentityID = strIdentityID; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IdentityID) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IdentityID, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IdentityID] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetIdentityDesc(this clsvUsersEN objvUsersEN, string strIdentityDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convUsers.IdentityDesc);
}
objvUsersEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IdentityDesc) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IdentityDesc, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IdentityDesc] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetPhoneNumber(this clsvUsersEN objvUsersEN, string strPhoneNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, convUsers.PhoneNumber);
}
objvUsersEN.PhoneNumber = strPhoneNumber; //手机
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.PhoneNumber) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.PhoneNumber, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.PhoneNumber] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetUserStateId(this clsvUsersEN objvUsersEN, string strUserStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateId, 2, convUsers.UserStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convUsers.UserStateId);
}
objvUsersEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.UserStateId) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.UserStateId, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.UserStateId] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetUserStateName(this clsvUsersEN objvUsersEN, string strUserStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convUsers.UserStateName);
}
objvUsersEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.UserStateName) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.UserStateName, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.UserStateName] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetStuTeacherId(this clsvUsersEN objvUsersEN, string strStuTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuTeacherId, convUsers.StuTeacherId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, convUsers.StuTeacherId);
}
objvUsersEN.StuTeacherId = strStuTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.StuTeacherId) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.StuTeacherId, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.StuTeacherId] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetOrderNum(this clsvUsersEN objvUsersEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convUsers.OrderNum);
objvUsersEN.OrderNum = intOrderNum; //排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.OrderNum) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.OrderNum, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.OrderNum] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetUpdDate(this clsvUsersEN objvUsersEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUsers.UpdDate);
}
objvUsersEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.UpdDate) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.UpdDate, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.UpdDate] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetUpdUser(this clsvUsersEN objvUsersEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convUsers.UpdUser);
}
objvUsersEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.UpdUser) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.UpdUser, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.UpdUser] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetMemo(this clsvUsersEN objvUsersEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUsers.Memo);
}
objvUsersEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.Memo) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.Memo, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.Memo] = strComparisonOp;
}
}
return objvUsersEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvUsersENS">源对象</param>
 /// <param name = "objvUsersENT">目标对象</param>
 public static void CopyTo(this clsvUsersEN objvUsersENS, clsvUsersEN objvUsersENT)
{
try
{
objvUsersENT.UserId = objvUsersENS.UserId; //用户ID
objvUsersENT.UserName = objvUsersENS.UserName; //用户名
objvUsersENT.Password = objvUsersENS.Password; //密码
objvUsersENT.DepartmentId = objvUsersENS.DepartmentId; //部门ID
objvUsersENT.DepartmentName = objvUsersENS.DepartmentName; //部门名称
objvUsersENT.Email = objvUsersENS.Email; //Email
objvUsersENT.IdentityID = objvUsersENS.IdentityID; //身份编号
objvUsersENT.IdentityDesc = objvUsersENS.IdentityDesc; //身份描述
objvUsersENT.PhoneNumber = objvUsersENS.PhoneNumber; //手机
objvUsersENT.UserStateId = objvUsersENS.UserStateId; //用户状态Id
objvUsersENT.UserStateName = objvUsersENS.UserStateName; //用户状态名
objvUsersENT.StuTeacherId = objvUsersENS.StuTeacherId; //学工号
objvUsersENT.OrderNum = objvUsersENS.OrderNum; //排序
objvUsersENT.UpdDate = objvUsersENS.UpdDate; //修改日期
objvUsersENT.UpdUser = objvUsersENS.UpdUser; //修改用户
objvUsersENT.Memo = objvUsersENS.Memo; //备注
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
 /// <param name = "objvUsersENS">源对象</param>
 /// <returns>目标对象=>clsvUsersEN:objvUsersENT</returns>
 public static clsvUsersEN CopyTo(this clsvUsersEN objvUsersENS)
{
try
{
 clsvUsersEN objvUsersENT = new clsvUsersEN()
{
UserId = objvUsersENS.UserId, //用户ID
UserName = objvUsersENS.UserName, //用户名
Password = objvUsersENS.Password, //密码
DepartmentId = objvUsersENS.DepartmentId, //部门ID
DepartmentName = objvUsersENS.DepartmentName, //部门名称
Email = objvUsersENS.Email, //Email
IdentityID = objvUsersENS.IdentityID, //身份编号
IdentityDesc = objvUsersENS.IdentityDesc, //身份描述
PhoneNumber = objvUsersENS.PhoneNumber, //手机
UserStateId = objvUsersENS.UserStateId, //用户状态Id
UserStateName = objvUsersENS.UserStateName, //用户状态名
StuTeacherId = objvUsersENS.StuTeacherId, //学工号
OrderNum = objvUsersENS.OrderNum, //排序
UpdDate = objvUsersENS.UpdDate, //修改日期
UpdUser = objvUsersENS.UpdUser, //修改用户
Memo = objvUsersENS.Memo, //备注
};
 return objvUsersENT;
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
public static void CheckProperty4Condition(this clsvUsersEN objvUsersEN)
{
 clsvUsersBL.vUsersDA.CheckProperty4Condition(objvUsersEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUsersEN objvUsers_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUsers_Cond.IsUpdated(convUsers.UserId) == true)
{
string strComparisonOp_UserId = objvUsers_Cond.dicFldComparisonOp[convUsers.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UserId, objvUsers_Cond.UserId, strComparisonOp_UserId);
}
if (objvUsers_Cond.IsUpdated(convUsers.UserName) == true)
{
string strComparisonOp_UserName = objvUsers_Cond.dicFldComparisonOp[convUsers.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UserName, objvUsers_Cond.UserName, strComparisonOp_UserName);
}
if (objvUsers_Cond.IsUpdated(convUsers.Password) == true)
{
string strComparisonOp_Password = objvUsers_Cond.dicFldComparisonOp[convUsers.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.Password, objvUsers_Cond.Password, strComparisonOp_Password);
}
if (objvUsers_Cond.IsUpdated(convUsers.DepartmentId) == true)
{
string strComparisonOp_DepartmentId = objvUsers_Cond.dicFldComparisonOp[convUsers.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.DepartmentId, objvUsers_Cond.DepartmentId, strComparisonOp_DepartmentId);
}
if (objvUsers_Cond.IsUpdated(convUsers.DepartmentName) == true)
{
string strComparisonOp_DepartmentName = objvUsers_Cond.dicFldComparisonOp[convUsers.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.DepartmentName, objvUsers_Cond.DepartmentName, strComparisonOp_DepartmentName);
}
if (objvUsers_Cond.IsUpdated(convUsers.Email) == true)
{
string strComparisonOp_Email = objvUsers_Cond.dicFldComparisonOp[convUsers.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.Email, objvUsers_Cond.Email, strComparisonOp_Email);
}
if (objvUsers_Cond.IsUpdated(convUsers.IdentityID) == true)
{
string strComparisonOp_IdentityID = objvUsers_Cond.dicFldComparisonOp[convUsers.IdentityID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.IdentityID, objvUsers_Cond.IdentityID, strComparisonOp_IdentityID);
}
if (objvUsers_Cond.IsUpdated(convUsers.IdentityDesc) == true)
{
string strComparisonOp_IdentityDesc = objvUsers_Cond.dicFldComparisonOp[convUsers.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.IdentityDesc, objvUsers_Cond.IdentityDesc, strComparisonOp_IdentityDesc);
}
if (objvUsers_Cond.IsUpdated(convUsers.PhoneNumber) == true)
{
string strComparisonOp_PhoneNumber = objvUsers_Cond.dicFldComparisonOp[convUsers.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.PhoneNumber, objvUsers_Cond.PhoneNumber, strComparisonOp_PhoneNumber);
}
if (objvUsers_Cond.IsUpdated(convUsers.UserStateId) == true)
{
string strComparisonOp_UserStateId = objvUsers_Cond.dicFldComparisonOp[convUsers.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UserStateId, objvUsers_Cond.UserStateId, strComparisonOp_UserStateId);
}
if (objvUsers_Cond.IsUpdated(convUsers.UserStateName) == true)
{
string strComparisonOp_UserStateName = objvUsers_Cond.dicFldComparisonOp[convUsers.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UserStateName, objvUsers_Cond.UserStateName, strComparisonOp_UserStateName);
}
if (objvUsers_Cond.IsUpdated(convUsers.StuTeacherId) == true)
{
string strComparisonOp_StuTeacherId = objvUsers_Cond.dicFldComparisonOp[convUsers.StuTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.StuTeacherId, objvUsers_Cond.StuTeacherId, strComparisonOp_StuTeacherId);
}
if (objvUsers_Cond.IsUpdated(convUsers.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvUsers_Cond.dicFldComparisonOp[convUsers.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convUsers.OrderNum, objvUsers_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvUsers_Cond.IsUpdated(convUsers.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvUsers_Cond.dicFldComparisonOp[convUsers.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UpdDate, objvUsers_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvUsers_Cond.IsUpdated(convUsers.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvUsers_Cond.dicFldComparisonOp[convUsers.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UpdUser, objvUsers_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvUsers_Cond.IsUpdated(convUsers.Memo) == true)
{
string strComparisonOp_Memo = objvUsers_Cond.dicFldComparisonOp[convUsers.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.Memo, objvUsers_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vUsers
{
public virtual bool UpdRelaTabDate(string strUserId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vUsers(vUsers)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvUsersBL
{
public static RelatedActions_vUsers relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vUsersListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vUsersList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvUsersEN> arrvUsersObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvUsersDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvUsersDA vUsersDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvUsersDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvUsersBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvUsersEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUsersEN._ConnectString);
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
objDS = vUsersDA.GetDataSet(strWhereCond);
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
objDS = vUsersDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vUsersDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vUsers(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vUsersDA.GetDataTable_vUsers(strWhereCond);
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
objDT = vUsersDA.GetDataTable(strWhereCond);
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
objDT = vUsersDA.GetDataTable(strWhereCond, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vUsersDA.GetDataTable(strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000008)获取表数据出错!(是否检查SQL攻击), {1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = vUsersDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vUsersDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabNameWithCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vUsersDA.GetDataTable(strWhereCond, strTabName, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000063)获取表数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = vUsersDA.GetDataTable_Top(objTopPara);
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
objDT = vUsersDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vUsersDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vUsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vUsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vUsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vUsersDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vUsersDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vUsersDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvUsersEN> GetObjLstByUserIdLst(List<string> arrUserIdLst)
{
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
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
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //密码
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.Email = objRow[convUsers.Email].ToString().Trim(); //Email
objvUsersEN.IdentityID = objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber].ToString().Trim(); //手机
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.StuTeacherId = objRow[convUsers.StuTeacherId].ToString().Trim(); //学工号
objvUsersEN.OrderNum = Int32.Parse(objRow[convUsers.OrderNum].ToString().Trim()); //排序
objvUsersEN.UpdDate = objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser].ToString().Trim(); //修改用户
objvUsersEN.Memo = objRow[convUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvUsersEN> GetObjLstByUserIdLst_Cache(List<string> arrUserIdLst)
{
string strKey = string.Format("{0}", clsvUsersEN._CurrTabName_S);
List<clsvUsersEN> arrvUsersObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUsersEN> arrvUsersObjLst_Sel =
arrvUsersObjLst_Cache
.Where(x => arrUserIdLst.Contains(x.UserId));
return arrvUsersObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsersEN> GetObjLst(string strWhereCond)
{
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //密码
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.Email = objRow[convUsers.Email].ToString().Trim(); //Email
objvUsersEN.IdentityID = objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber].ToString().Trim(); //手机
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.StuTeacherId = objRow[convUsers.StuTeacherId].ToString().Trim(); //学工号
objvUsersEN.OrderNum = Int32.Parse(objRow[convUsers.OrderNum].ToString().Trim()); //排序
objvUsersEN.UpdDate = objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser].ToString().Trim(); //修改用户
objvUsersEN.Memo = objRow[convUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersEN);
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
public static List<clsvUsersEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //密码
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.Email = objRow[convUsers.Email].ToString().Trim(); //Email
objvUsersEN.IdentityID = objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber].ToString().Trim(); //手机
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.StuTeacherId = objRow[convUsers.StuTeacherId].ToString().Trim(); //学工号
objvUsersEN.OrderNum = Int32.Parse(objRow[convUsers.OrderNum].ToString().Trim()); //排序
objvUsersEN.UpdDate = objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser].ToString().Trim(); //修改用户
objvUsersEN.Memo = objRow[convUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLst_Cache)
 /// </summary>
 /// <param name = "objvUsers_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvUsersEN> GetSubObjLst_Cache(clsvUsersEN objvUsers_Cond)
{
List<clsvUsersEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUsersEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in convUsers.AttributeName)
{
if (objvUsers_Cond.IsUpdated(strFldName) == false) continue;
if (objvUsers_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvUsers_Cond[strFldName].ToString());
}
else
{
if (objvUsers_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUsers_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvUsers_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objvUsers_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUsers_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUsers_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUsers_Cond[strFldName]));
}
}
}
return arrObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsersEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //密码
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.Email = objRow[convUsers.Email].ToString().Trim(); //Email
objvUsersEN.IdentityID = objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber].ToString().Trim(); //手机
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.StuTeacherId = objRow[convUsers.StuTeacherId].ToString().Trim(); //学工号
objvUsersEN.OrderNum = Int32.Parse(objRow[convUsers.OrderNum].ToString().Trim()); //排序
objvUsersEN.UpdDate = objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser].ToString().Trim(); //修改用户
objvUsersEN.Memo = objRow[convUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersEN);
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
public static List<clsvUsersEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //密码
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.Email = objRow[convUsers.Email].ToString().Trim(); //Email
objvUsersEN.IdentityID = objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber].ToString().Trim(); //手机
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.StuTeacherId = objRow[convUsers.StuTeacherId].ToString().Trim(); //学工号
objvUsersEN.OrderNum = Int32.Parse(objRow[convUsers.OrderNum].ToString().Trim()); //排序
objvUsersEN.UpdDate = objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser].ToString().Trim(); //修改用户
objvUsersEN.Memo = objRow[convUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersEN);
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
List<clsvUsersEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvUsersEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsersEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvUsersEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
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
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //密码
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.Email = objRow[convUsers.Email].ToString().Trim(); //Email
objvUsersEN.IdentityID = objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber].ToString().Trim(); //手机
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.StuTeacherId = objRow[convUsers.StuTeacherId].ToString().Trim(); //学工号
objvUsersEN.OrderNum = Int32.Parse(objRow[convUsers.OrderNum].ToString().Trim()); //排序
objvUsersEN.UpdDate = objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser].ToString().Trim(); //修改用户
objvUsersEN.Memo = objRow[convUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersEN);
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
public static List<clsvUsersEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //密码
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.Email = objRow[convUsers.Email].ToString().Trim(); //Email
objvUsersEN.IdentityID = objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber].ToString().Trim(); //手机
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.StuTeacherId = objRow[convUsers.StuTeacherId].ToString().Trim(); //学工号
objvUsersEN.OrderNum = Int32.Parse(objRow[convUsers.OrderNum].ToString().Trim()); //排序
objvUsersEN.UpdDate = objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser].ToString().Trim(); //修改用户
objvUsersEN.Memo = objRow[convUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvUsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvUsersEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //密码
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.Email = objRow[convUsers.Email].ToString().Trim(); //Email
objvUsersEN.IdentityID = objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber].ToString().Trim(); //手机
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.StuTeacherId = objRow[convUsers.StuTeacherId].ToString().Trim(); //学工号
objvUsersEN.OrderNum = Int32.Parse(objRow[convUsers.OrderNum].ToString().Trim()); //排序
objvUsersEN.UpdDate = objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser].ToString().Trim(); //修改用户
objvUsersEN.Memo = objRow[convUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersEN);
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
public static List<clsvUsersEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //密码
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.Email = objRow[convUsers.Email].ToString().Trim(); //Email
objvUsersEN.IdentityID = objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber].ToString().Trim(); //手机
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.StuTeacherId = objRow[convUsers.StuTeacherId].ToString().Trim(); //学工号
objvUsersEN.OrderNum = Int32.Parse(objRow[convUsers.OrderNum].ToString().Trim()); //排序
objvUsersEN.UpdDate = objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser].ToString().Trim(); //修改用户
objvUsersEN.Memo = objRow[convUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsvUsersEN> GetObjLstByPager_Cache(int intPageIndex, int intPageSize, clsvUsersEN objvUsers_Cond, string strOrderBy)
{
List<clsvUsersEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUsersEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in convUsers.AttributeName)
{
if (objvUsers_Cond.IsUpdated(strFldName) == false) continue;
if (objvUsers_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvUsers_Cond[strFldName].ToString());
}
else
{
if (objvUsers_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUsers_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvUsers_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objvUsers_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUsers_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUsers_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUsers_Cond[strFldName]));
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
arrObjLst_Sel = arrObjLst_Sel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLst_Sel = arrObjLst_Sel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLst_Sel = arrObjLst_Sel.Skip(intSkip).Take(intPageSize);
return arrObjLst_Sel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsvUsersEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
clsvUsersEN objvUsers_Cond = JsonConvert.DeserializeObject<clsvUsersEN>(objPagerPara.whereCond);
if (objvUsers_Cond.sf_FldComparisonOp == null)
{
objvUsers_Cond.dicFldComparisonOp = null;
}
else
{
objvUsers_Cond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvUsers_Cond.sf_FldComparisonOp);
}
clsvUsersBL.SetUpdFlag(objvUsers_Cond);
 try
{
CheckProperty4Condition(objvUsers_Cond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000150)在输入条件中含有{0},请检查!(clsvUsersBL:GetObjLstByPager_Cache)", objException.Message));
}
 return GetObjLstByPager_Cache(objPagerPara.pageIndex, objPagerPara.pageSize, objvUsers_Cond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsersEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvUsersEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //密码
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.Email = objRow[convUsers.Email].ToString().Trim(); //Email
objvUsersEN.IdentityID = objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber].ToString().Trim(); //手机
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.StuTeacherId = objRow[convUsers.StuTeacherId].ToString().Trim(); //学工号
objvUsersEN.OrderNum = Int32.Parse(objRow[convUsers.OrderNum].ToString().Trim()); //排序
objvUsersEN.UpdDate = objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser].ToString().Trim(); //修改用户
objvUsersEN.Memo = objRow[convUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersEN);
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
public static List<clsvUsersEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //密码
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.Email = objRow[convUsers.Email].ToString().Trim(); //Email
objvUsersEN.IdentityID = objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber].ToString().Trim(); //手机
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.StuTeacherId = objRow[convUsers.StuTeacherId].ToString().Trim(); //学工号
objvUsersEN.OrderNum = Int32.Parse(objRow[convUsers.OrderNum].ToString().Trim()); //排序
objvUsersEN.UpdDate = objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser].ToString().Trim(); //修改用户
objvUsersEN.Memo = objRow[convUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsersEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //密码
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.Email = objRow[convUsers.Email].ToString().Trim(); //Email
objvUsersEN.IdentityID = objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber].ToString().Trim(); //手机
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.StuTeacherId = objRow[convUsers.StuTeacherId].ToString().Trim(); //学工号
objvUsersEN.OrderNum = Int32.Parse(objRow[convUsers.OrderNum].ToString().Trim()); //排序
objvUsersEN.UpdDate = objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser].ToString().Trim(); //修改用户
objvUsersEN.Memo = objRow[convUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvUsersEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvUsers(ref clsvUsersEN objvUsersEN)
{
bool bolResult = vUsersDA.GetvUsers(ref objvUsersEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUsersEN GetObjByUserId(string strUserId)
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
clsvUsersEN objvUsersEN = vUsersDA.GetObjByUserId(strUserId);
return objvUsersEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvUsersEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvUsersEN objvUsersEN = vUsersDA.GetFirstObj(strWhereCond);
 return objvUsersEN;
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
public static clsvUsersEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvUsersEN objvUsersEN = vUsersDA.GetObjByDataRow(objRow);
 return objvUsersEN;
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
public static clsvUsersEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvUsersEN objvUsersEN = vUsersDA.GetObjByDataRow(objRow);
 return objvUsersEN;
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
 /// <param name = "lstvUsersObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUsersEN GetObjByUserIdFromList(string strUserId, List<clsvUsersEN> lstvUsersObjLst)
{
foreach (clsvUsersEN objvUsersEN in lstvUsersObjLst)
{
if (objvUsersEN.UserId == strUserId)
{
return objvUsersEN;
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
 strUserId = new clsvUsersDA().GetFirstID(strWhereCond);
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
 arrList = vUsersDA.GetID(strWhereCond);
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
bool bolIsExist = vUsersDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vUsersDA.IsExist(strUserId);
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
 bolIsExist = clsvUsersDA.IsExistTable();
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
 bolIsExist = vUsersDA.IsExistTable(strTabName);
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
 /// <param name = "objvUsersENS">源对象</param>
 /// <param name = "objvUsersENT">目标对象</param>
 public static void CopyTo(clsvUsersEN objvUsersENS, clsvUsersEN objvUsersENT)
{
try
{
objvUsersENT.UserId = objvUsersENS.UserId; //用户ID
objvUsersENT.UserName = objvUsersENS.UserName; //用户名
objvUsersENT.Password = objvUsersENS.Password; //密码
objvUsersENT.DepartmentId = objvUsersENS.DepartmentId; //部门ID
objvUsersENT.DepartmentName = objvUsersENS.DepartmentName; //部门名称
objvUsersENT.Email = objvUsersENS.Email; //Email
objvUsersENT.IdentityID = objvUsersENS.IdentityID; //身份编号
objvUsersENT.IdentityDesc = objvUsersENS.IdentityDesc; //身份描述
objvUsersENT.PhoneNumber = objvUsersENS.PhoneNumber; //手机
objvUsersENT.UserStateId = objvUsersENS.UserStateId; //用户状态Id
objvUsersENT.UserStateName = objvUsersENS.UserStateName; //用户状态名
objvUsersENT.StuTeacherId = objvUsersENS.StuTeacherId; //学工号
objvUsersENT.OrderNum = objvUsersENS.OrderNum; //排序
objvUsersENT.UpdDate = objvUsersENS.UpdDate; //修改日期
objvUsersENT.UpdUser = objvUsersENS.UpdUser; //修改用户
objvUsersENT.Memo = objvUsersENS.Memo; //备注
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
 /// <param name = "objvUsersEN">源简化对象</param>
 public static void SetUpdFlag(clsvUsersEN objvUsersEN)
{
try
{
objvUsersEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvUsersEN.sf_UpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convUsers.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.UserId = objvUsersEN.UserId; //用户ID
}
if (arrFldSet.Contains(convUsers.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.UserName = objvUsersEN.UserName; //用户名
}
if (arrFldSet.Contains(convUsers.Password, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.Password = objvUsersEN.Password; //密码
}
if (arrFldSet.Contains(convUsers.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.DepartmentId = objvUsersEN.DepartmentId; //部门ID
}
if (arrFldSet.Contains(convUsers.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.DepartmentName = objvUsersEN.DepartmentName; //部门名称
}
if (arrFldSet.Contains(convUsers.Email, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.Email = objvUsersEN.Email; //Email
}
if (arrFldSet.Contains(convUsers.IdentityID, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.IdentityID = objvUsersEN.IdentityID; //身份编号
}
if (arrFldSet.Contains(convUsers.IdentityDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.IdentityDesc = objvUsersEN.IdentityDesc; //身份描述
}
if (arrFldSet.Contains(convUsers.PhoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.PhoneNumber = objvUsersEN.PhoneNumber; //手机
}
if (arrFldSet.Contains(convUsers.UserStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.UserStateId = objvUsersEN.UserStateId; //用户状态Id
}
if (arrFldSet.Contains(convUsers.UserStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.UserStateName = objvUsersEN.UserStateName; //用户状态名
}
if (arrFldSet.Contains(convUsers.StuTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.StuTeacherId = objvUsersEN.StuTeacherId; //学工号
}
if (arrFldSet.Contains(convUsers.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.OrderNum = objvUsersEN.OrderNum; //排序
}
if (arrFldSet.Contains(convUsers.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.UpdDate = objvUsersEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convUsers.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.UpdUser = objvUsersEN.UpdUser; //修改用户
}
if (arrFldSet.Contains(convUsers.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.Memo = objvUsersEN.Memo; //备注
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


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvUsersEN objvUsersEN)
{
 vUsersDA.CheckProperty4Condition(objvUsersEN);
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
if (clsDepartmentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDepartmentInfoBL没有刷新缓存机制(clsDepartmentInfoBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserId");
//if (arrvUsersObjLst_Cache == null)
//{
//arrvUsersObjLst_Cache = vUsersDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUsersEN GetObjByUserId_Cache(string strUserId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvUsersEN._CurrTabName_S);
List<clsvUsersEN> arrvUsersObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUsersEN> arrvUsersObjLst_Sel =
arrvUsersObjLst_Cache
.Where(x => x.UserId == strUserId);
if (arrvUsersObjLst_Sel.Count() == 0)
{
   clsvUsersEN obj = clsvUsersBL.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return null;
 }
return null;
}
return arrvUsersObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUsersEN> GetAllvUsersObjLst_Cache()
{
//获取缓存中的对象列表
List<clsvUsersEN> arrvUsersObjLst_Cache = GetObjLst_Cache(); 
return arrvUsersObjLst_Cache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUsersEN> GetObjLst_Cache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvUsersEN._CurrTabName_S);
List<clsvUsersEN> arrvUsersObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvUsersObjLst_Cache;
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
string strKey = string.Format("{0}", clsvUsersEN._CurrTabName_S);
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
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvUsersObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvUsersEN> lstvUsersObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvUsersObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstvUsersObjLst">[clsvUsersEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvUsersEN> lstvUsersObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvUsersBL.listXmlNode);
writer.WriteStartElement(clsvUsersBL.itemsXmlNode);
foreach (clsvUsersEN objvUsersEN in lstvUsersObjLst)
{
clsvUsersBL.SerializeXML(writer, objvUsersEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objvUsersEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvUsersEN objvUsersEN)
{
writer.WriteStartElement(clsvUsersBL.itemXmlNode);
 
if (objvUsersEN.UserId != null)
{
writer.WriteElementString(convUsers.UserId, objvUsersEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvUsersEN.UserName != null)
{
writer.WriteElementString(convUsers.UserName, objvUsersEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvUsersEN.Password != null)
{
writer.WriteElementString(convUsers.Password, objvUsersEN.Password.ToString(CultureInfo.InvariantCulture));
}
 
if (objvUsersEN.DepartmentId != null)
{
writer.WriteElementString(convUsers.DepartmentId, objvUsersEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvUsersEN.DepartmentName != null)
{
writer.WriteElementString(convUsers.DepartmentName, objvUsersEN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvUsersEN.Email != null)
{
writer.WriteElementString(convUsers.Email, objvUsersEN.Email.ToString(CultureInfo.InvariantCulture));
}
 
if (objvUsersEN.IdentityID != null)
{
writer.WriteElementString(convUsers.IdentityID, objvUsersEN.IdentityID.ToString(CultureInfo.InvariantCulture));
}
 
if (objvUsersEN.IdentityDesc != null)
{
writer.WriteElementString(convUsers.IdentityDesc, objvUsersEN.IdentityDesc.ToString(CultureInfo.InvariantCulture));
}
 
if (objvUsersEN.PhoneNumber != null)
{
writer.WriteElementString(convUsers.PhoneNumber, objvUsersEN.PhoneNumber.ToString(CultureInfo.InvariantCulture));
}
 
if (objvUsersEN.UserStateId != null)
{
writer.WriteElementString(convUsers.UserStateId, objvUsersEN.UserStateId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvUsersEN.UserStateName != null)
{
writer.WriteElementString(convUsers.UserStateName, objvUsersEN.UserStateName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvUsersEN.StuTeacherId != null)
{
writer.WriteElementString(convUsers.StuTeacherId, objvUsersEN.StuTeacherId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convUsers.OrderNum, objvUsersEN.OrderNum.ToString(CultureInfo.InvariantCulture));
 
if (objvUsersEN.UpdDate != null)
{
writer.WriteElementString(convUsers.UpdDate, objvUsersEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvUsersEN.UpdUser != null)
{
writer.WriteElementString(convUsers.UpdUser, objvUsersEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objvUsersEN.Memo != null)
{
writer.WriteElementString(convUsers.Memo, objvUsersEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsvUsersEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvUsersEN objvUsersEN = new clsvUsersEN();
reader.Read();
while (!(reader.Name == clsvUsersBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convUsers.UserId))
{
objvUsersEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convUsers.UserName))
{
objvUsersEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convUsers.Password))
{
objvUsersEN.Password = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convUsers.DepartmentId))
{
objvUsersEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convUsers.DepartmentName))
{
objvUsersEN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convUsers.Email))
{
objvUsersEN.Email = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convUsers.IdentityID))
{
objvUsersEN.IdentityID = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convUsers.IdentityDesc))
{
objvUsersEN.IdentityDesc = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convUsers.PhoneNumber))
{
objvUsersEN.PhoneNumber = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convUsers.UserStateId))
{
objvUsersEN.UserStateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convUsers.UserStateName))
{
objvUsersEN.UserStateName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convUsers.StuTeacherId))
{
objvUsersEN.StuTeacherId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convUsers.OrderNum))
{
objvUsersEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convUsers.UpdDate))
{
objvUsersEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convUsers.UpdUser))
{
objvUsersEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convUsers.Memo))
{
objvUsersEN.Memo = reader.ReadElementContentAsString();
}
}
return objvUsersEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvUsersObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvUsersEN GetObjFromXmlStr(string strvUsersObjXmlStr)
{
clsvUsersEN objvUsersEN = new clsvUsersEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvUsersObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvUsersBL.itemXmlNode))
{
objvUsersEN = GetObjFromXml(reader);
return objvUsersEN;
}
}
return objvUsersEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvUsersEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvUsersEN objvUsersEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvUsersEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strUserId)
{
if (strInFldName != convUsers.UserId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convUsers.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convUsers.AttributeName));
throw new Exception(strMsg);
}
var objvUsers = clsvUsersBL.GetObjByUserId_Cache(strUserId );
if (objvUsers == null) return "";
return objvUsers[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvUsersEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvUsersEN objvUsersEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvUsersEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvUsersEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstvUsersObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvUsersEN> lstvUsersObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvUsersObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvUsersEN objvUsersEN in lstvUsersObjLst)
{
string strJSON_One = SerializeObjToJSON(objvUsersEN);
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
int intRecCount = clsvUsersDA.GetRecCount(strTabName);
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
int intRecCount = clsvUsersDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvUsersDA.GetRecCount();
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
int intRecCount = clsvUsersDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObj_Cache)
 /// </summary>
 /// <param name = "objvUsers_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCond_Cache(clsvUsersEN objvUsers_Cond)
{
List<clsvUsersEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUsersEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in convUsers.AttributeName)
{
if (objvUsers_Cond.IsUpdated(strFldName) == false) continue;
if (objvUsers_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvUsers_Cond[strFldName].ToString());
}
else
{
if (objvUsers_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUsers_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvUsers_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objvUsers_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUsers_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUsers_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUsers_Cond[strFldName]));
}
}
}
return arrObjLst_Sel.Count();
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
 List<string> arrList = clsvUsersDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vUsersDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vUsersDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}