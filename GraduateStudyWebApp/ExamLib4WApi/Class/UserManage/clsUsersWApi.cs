
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUsersWApi
 表名:Users(01120034)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:56
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
public static class clsUsersWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetUserId(this clsUsersEN objUsersEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, conUsers.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetUserName(this clsUsersEN objUsersEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, conUsers.UserName);
clsCheckSql.CheckFieldLen(strUserName, 50, conUsers.UserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetDepartmentId(this clsUsersEN objUsersEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, conUsers.DepartmentId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetUserStateId(this clsUsersEN objUsersEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, conUsers.UserStateId);
clsCheckSql.CheckFieldLen(strUserStateId, 2, conUsers.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, conUsers.UserStateId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetPassword(this clsUsersEN objUsersEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPassword, 20, conUsers.Password);
objUsersEN.Password = strPassword; //Password
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetSchoolID1(this clsUsersEN objUsersEN, string strSchoolID1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolID1, 4, conUsers.SchoolID1);
objUsersEN.SchoolID1 = strSchoolID1; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.SchoolID1) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.SchoolID1, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.SchoolID1] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetBeginYearMonth(this clsUsersEN objUsersEN, string strBeginYearMonth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBeginYearMonth, 8, conUsers.BeginYearMonth);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetEndYearMonth(this clsUsersEN objUsersEN, string strEndYearMonth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEndYearMonth, 8, conUsers.EndYearMonth);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN Setid_GradeBase(this clsUsersEN objUsersEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, conUsers.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, conUsers.id_GradeBase);
objUsersEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.id_GradeBase) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.id_GradeBase, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.id_GradeBase] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN Setid_XzCollege(this clsUsersEN objUsersEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conUsers.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conUsers.id_XzCollege);
objUsersEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.id_XzCollege) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.id_XzCollege, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.id_XzCollege] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN Setid_XzMajor(this clsUsersEN objUsersEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, conUsers.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, conUsers.id_XzMajor);
objUsersEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.id_XzMajor) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.id_XzMajor, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.id_XzMajor] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetIsLeaved(this clsUsersEN objUsersEN, bool bolIsLeaved, string strComparisonOp="")
	{
objUsersEN.IsLeaved = bolIsLeaved; //IsLeaved
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetStuIdTeacherId(this clsUsersEN objUsersEN, string strStuIdTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuIdTeacherId, 20, conUsers.StuIdTeacherId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetEmail(this clsUsersEN objUsersEN, string strEmail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEmail, 100, conUsers.Email);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetPhoneNumber(this clsUsersEN objUsersEN, string strPhoneNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, conUsers.PhoneNumber);
objUsersEN.PhoneNumber = strPhoneNumber; //PhoneNumber
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetAvatarsPicture(this clsUsersEN objUsersEN, string strAvatarsPicture, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAvatarsPicture, 100, conUsers.AvatarsPicture);
objUsersEN.AvatarsPicture = strAvatarsPicture; //AvatarsPicture
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetIdentityID(this clsUsersEN objUsersEN, string strIdentityID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityID, conUsers.IdentityID);
clsCheckSql.CheckFieldLen(strIdentityID, 2, conUsers.IdentityID);
clsCheckSql.CheckFieldForeignKey(strIdentityID, 2, conUsers.IdentityID);
objUsersEN.IdentityID = strIdentityID; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IdentityID) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IdentityID, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IdentityID] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetAuditDate(this clsUsersEN objUsersEN, string strAuditDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAuditDate, 14, conUsers.AuditDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetAuditUser(this clsUsersEN objUsersEN, string strAuditUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAuditUser, 18, conUsers.AuditUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetRegisterDate(this clsUsersEN objUsersEN, string strRegisterDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegisterDate, 14, conUsers.RegisterDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetMobilePhone(this clsUsersEN objUsersEN, string strMobilePhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMobilePhone, 20, conUsers.MobilePhone);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetOpenId(this clsUsersEN objUsersEN, string strOpenId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpenId, 50, conUsers.OpenId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetUpdDate(this clsUsersEN objUsersEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conUsers.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetUpdUser(this clsUsersEN objUsersEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conUsers.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetMemo(this clsUsersEN objUsersEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUsers.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUsersEN SetHeadPic(this clsUsersEN objUsersEN, string strHeadPic, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHeadPic, 500, conUsers.HeadPic);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUsersEN objUsers_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUsers_Cond.IsUpdated(conUsers.UserId) == true)
{
string strComparisonOp_UserId = objUsers_Cond.dicFldComparisonOp[conUsers.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.UserId, objUsers_Cond.UserId, strComparisonOp_UserId);
}
if (objUsers_Cond.IsUpdated(conUsers.UserName) == true)
{
string strComparisonOp_UserName = objUsers_Cond.dicFldComparisonOp[conUsers.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.UserName, objUsers_Cond.UserName, strComparisonOp_UserName);
}
if (objUsers_Cond.IsUpdated(conUsers.DepartmentId) == true)
{
string strComparisonOp_DepartmentId = objUsers_Cond.dicFldComparisonOp[conUsers.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.DepartmentId, objUsers_Cond.DepartmentId, strComparisonOp_DepartmentId);
}
if (objUsers_Cond.IsUpdated(conUsers.UserStateId) == true)
{
string strComparisonOp_UserStateId = objUsers_Cond.dicFldComparisonOp[conUsers.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.UserStateId, objUsers_Cond.UserStateId, strComparisonOp_UserStateId);
}
if (objUsers_Cond.IsUpdated(conUsers.Password) == true)
{
string strComparisonOp_Password = objUsers_Cond.dicFldComparisonOp[conUsers.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.Password, objUsers_Cond.Password, strComparisonOp_Password);
}
if (objUsers_Cond.IsUpdated(conUsers.IsGpUser) == true)
{
if (objUsers_Cond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUsers.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUsers.IsGpUser);
}
}
if (objUsers_Cond.IsUpdated(conUsers.SchoolID1) == true)
{
string strComparisonOp_SchoolID1 = objUsers_Cond.dicFldComparisonOp[conUsers.SchoolID1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.SchoolID1, objUsers_Cond.SchoolID1, strComparisonOp_SchoolID1);
}
if (objUsers_Cond.IsUpdated(conUsers.BeginYearMonth) == true)
{
string strComparisonOp_BeginYearMonth = objUsers_Cond.dicFldComparisonOp[conUsers.BeginYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.BeginYearMonth, objUsers_Cond.BeginYearMonth, strComparisonOp_BeginYearMonth);
}
if (objUsers_Cond.IsUpdated(conUsers.EndYearMonth) == true)
{
string strComparisonOp_EndYearMonth = objUsers_Cond.dicFldComparisonOp[conUsers.EndYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.EndYearMonth, objUsers_Cond.EndYearMonth, strComparisonOp_EndYearMonth);
}
if (objUsers_Cond.IsUpdated(conUsers.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objUsers_Cond.dicFldComparisonOp[conUsers.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.id_GradeBase, objUsers_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objUsers_Cond.IsUpdated(conUsers.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objUsers_Cond.dicFldComparisonOp[conUsers.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.id_XzCollege, objUsers_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objUsers_Cond.IsUpdated(conUsers.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objUsers_Cond.dicFldComparisonOp[conUsers.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.id_XzMajor, objUsers_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objUsers_Cond.IsUpdated(conUsers.IsLeaved) == true)
{
if (objUsers_Cond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUsers.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUsers.IsLeaved);
}
}
if (objUsers_Cond.IsUpdated(conUsers.StuIdTeacherId) == true)
{
string strComparisonOp_StuIdTeacherId = objUsers_Cond.dicFldComparisonOp[conUsers.StuIdTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.StuIdTeacherId, objUsers_Cond.StuIdTeacherId, strComparisonOp_StuIdTeacherId);
}
if (objUsers_Cond.IsUpdated(conUsers.Email) == true)
{
string strComparisonOp_Email = objUsers_Cond.dicFldComparisonOp[conUsers.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.Email, objUsers_Cond.Email, strComparisonOp_Email);
}
if (objUsers_Cond.IsUpdated(conUsers.PhoneNumber) == true)
{
string strComparisonOp_PhoneNumber = objUsers_Cond.dicFldComparisonOp[conUsers.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.PhoneNumber, objUsers_Cond.PhoneNumber, strComparisonOp_PhoneNumber);
}
if (objUsers_Cond.IsUpdated(conUsers.AvatarsPicture) == true)
{
string strComparisonOp_AvatarsPicture = objUsers_Cond.dicFldComparisonOp[conUsers.AvatarsPicture];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.AvatarsPicture, objUsers_Cond.AvatarsPicture, strComparisonOp_AvatarsPicture);
}
if (objUsers_Cond.IsUpdated(conUsers.IdentityID) == true)
{
string strComparisonOp_IdentityID = objUsers_Cond.dicFldComparisonOp[conUsers.IdentityID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.IdentityID, objUsers_Cond.IdentityID, strComparisonOp_IdentityID);
}
if (objUsers_Cond.IsUpdated(conUsers.AuditDate) == true)
{
string strComparisonOp_AuditDate = objUsers_Cond.dicFldComparisonOp[conUsers.AuditDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.AuditDate, objUsers_Cond.AuditDate, strComparisonOp_AuditDate);
}
if (objUsers_Cond.IsUpdated(conUsers.AuditUser) == true)
{
string strComparisonOp_AuditUser = objUsers_Cond.dicFldComparisonOp[conUsers.AuditUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.AuditUser, objUsers_Cond.AuditUser, strComparisonOp_AuditUser);
}
if (objUsers_Cond.IsUpdated(conUsers.IsAudit) == true)
{
if (objUsers_Cond.IsAudit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUsers.IsAudit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUsers.IsAudit);
}
}
if (objUsers_Cond.IsUpdated(conUsers.IsRegister) == true)
{
if (objUsers_Cond.IsRegister == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUsers.IsRegister);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUsers.IsRegister);
}
}
if (objUsers_Cond.IsUpdated(conUsers.RegisterDate) == true)
{
string strComparisonOp_RegisterDate = objUsers_Cond.dicFldComparisonOp[conUsers.RegisterDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.RegisterDate, objUsers_Cond.RegisterDate, strComparisonOp_RegisterDate);
}
if (objUsers_Cond.IsUpdated(conUsers.MobilePhone) == true)
{
string strComparisonOp_MobilePhone = objUsers_Cond.dicFldComparisonOp[conUsers.MobilePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.MobilePhone, objUsers_Cond.MobilePhone, strComparisonOp_MobilePhone);
}
if (objUsers_Cond.IsUpdated(conUsers.OpenId) == true)
{
string strComparisonOp_OpenId = objUsers_Cond.dicFldComparisonOp[conUsers.OpenId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.OpenId, objUsers_Cond.OpenId, strComparisonOp_OpenId);
}
if (objUsers_Cond.IsUpdated(conUsers.UpdDate) == true)
{
string strComparisonOp_UpdDate = objUsers_Cond.dicFldComparisonOp[conUsers.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.UpdDate, objUsers_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objUsers_Cond.IsUpdated(conUsers.UpdUser) == true)
{
string strComparisonOp_UpdUser = objUsers_Cond.dicFldComparisonOp[conUsers.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.UpdUser, objUsers_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objUsers_Cond.IsUpdated(conUsers.Memo) == true)
{
string strComparisonOp_Memo = objUsers_Cond.dicFldComparisonOp[conUsers.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.Memo, objUsers_Cond.Memo, strComparisonOp_Memo);
}
if (objUsers_Cond.IsUpdated(conUsers.HeadPic) == true)
{
string strComparisonOp_HeadPic = objUsers_Cond.dicFldComparisonOp[conUsers.HeadPic];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.HeadPic, objUsers_Cond.HeadPic, strComparisonOp_HeadPic);
}
if (objUsers_Cond.IsUpdated(conUsers.IsGSuser) == true)
{
if (objUsers_Cond.IsGSuser == true)
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

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUsersEN objUsersEN)
{
 if (string.IsNullOrEmpty(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objUsersEN.sf_UpdFldSetStr = objUsersEN.getsf_UpdFldSetStr();
clsUsersWApi.CheckPropertyNew(objUsersEN); 
bool bolResult = clsUsersWApi.UpdateRecord(objUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUsersEN objUsersEN)
{
 if (string.IsNullOrEmpty(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUsersWApi.IsExist(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objUsersEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsUsersWApi.CheckPropertyNew(objUsersEN); 
bool bolResult = clsUsersWApi.AddNewRecord(objUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsUsersEN objUsersEN)
{
try
{
clsUsersWApi.CheckPropertyNew(objUsersEN); 
string strUserId = clsUsersWApi.AddNewRecordWithMaxId(objUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersWApi.ReFreshCache();
return strUserId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objUsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUsersEN objUsersEN, string strWhereCond)
{
try
{
clsUsersWApi.CheckPropertyNew(objUsersEN); 
bool bolResult = clsUsersWApi.UpdateWithCondition(objUsersEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 用户(Users)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsUsersWApi
{
private static readonly string mstrApiControllerName = "UsersApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsUsersWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[用户]...","0");
List<clsUsersEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="UserId";
objDDL.DataTextField="UserName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_UserId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conUsers.UserId); 
List<clsUsersEN> arrObjLst = clsUsersWApi.GetObjLst(strCondition);
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsUsersEN objUsersEN)
{
if (!Object.Equals(null, objUsersEN.UserId) && GetStrLen(objUsersEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objUsersEN.UserName) && GetStrLen(objUsersEN.UserName) > 50)
{
 throw new Exception("字段[用户名]的长度不能超过50!");
}
if (!Object.Equals(null, objUsersEN.DepartmentId) && GetStrLen(objUsersEN.DepartmentId) > 8)
{
 throw new Exception("字段[部门Id]的长度不能超过8!");
}
if (!Object.Equals(null, objUsersEN.UserStateId) && GetStrLen(objUsersEN.UserStateId) > 2)
{
 throw new Exception("字段[用户状态Id]的长度不能超过2!");
}
if (!Object.Equals(null, objUsersEN.Password) && GetStrLen(objUsersEN.Password) > 20)
{
 throw new Exception("字段[Password]的长度不能超过20!");
}
if (!Object.Equals(null, objUsersEN.SchoolID1) && GetStrLen(objUsersEN.SchoolID1) > 4)
{
 throw new Exception("字段[学校编号]的长度不能超过4!");
}
if (!Object.Equals(null, objUsersEN.BeginYearMonth) && GetStrLen(objUsersEN.BeginYearMonth) > 8)
{
 throw new Exception("字段[开始年月]的长度不能超过8!");
}
if (!Object.Equals(null, objUsersEN.EndYearMonth) && GetStrLen(objUsersEN.EndYearMonth) > 8)
{
 throw new Exception("字段[结束年月]的长度不能超过8!");
}
if (!Object.Equals(null, objUsersEN.id_GradeBase) && GetStrLen(objUsersEN.id_GradeBase) > 4)
{
 throw new Exception("字段[年级流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objUsersEN.id_XzCollege) && GetStrLen(objUsersEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objUsersEN.id_XzMajor) && GetStrLen(objUsersEN.id_XzMajor) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objUsersEN.StuIdTeacherId) && GetStrLen(objUsersEN.StuIdTeacherId) > 20)
{
 throw new Exception("字段[学工号]的长度不能超过20!");
}
if (!Object.Equals(null, objUsersEN.Email) && GetStrLen(objUsersEN.Email) > 100)
{
 throw new Exception("字段[电子邮箱]的长度不能超过100!");
}
if (!Object.Equals(null, objUsersEN.PhoneNumber) && GetStrLen(objUsersEN.PhoneNumber) > 15)
{
 throw new Exception("字段[PhoneNumber]的长度不能超过15!");
}
if (!Object.Equals(null, objUsersEN.AvatarsPicture) && GetStrLen(objUsersEN.AvatarsPicture) > 100)
{
 throw new Exception("字段[AvatarsPicture]的长度不能超过100!");
}
if (!Object.Equals(null, objUsersEN.IdentityID) && GetStrLen(objUsersEN.IdentityID) > 2)
{
 throw new Exception("字段[身份编号]的长度不能超过2!");
}
if (!Object.Equals(null, objUsersEN.AuditDate) && GetStrLen(objUsersEN.AuditDate) > 14)
{
 throw new Exception("字段[AuditDate]的长度不能超过14!");
}
if (!Object.Equals(null, objUsersEN.AuditUser) && GetStrLen(objUsersEN.AuditUser) > 18)
{
 throw new Exception("字段[AuditUser]的长度不能超过18!");
}
if (!Object.Equals(null, objUsersEN.RegisterDate) && GetStrLen(objUsersEN.RegisterDate) > 14)
{
 throw new Exception("字段[RegisterDate]的长度不能超过14!");
}
if (!Object.Equals(null, objUsersEN.MobilePhone) && GetStrLen(objUsersEN.MobilePhone) > 20)
{
 throw new Exception("字段[手机]的长度不能超过20!");
}
if (!Object.Equals(null, objUsersEN.OpenId) && GetStrLen(objUsersEN.OpenId) > 50)
{
 throw new Exception("字段[微信OpenId]的长度不能超过50!");
}
if (!Object.Equals(null, objUsersEN.UpdDate) && GetStrLen(objUsersEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objUsersEN.UpdUser) && GetStrLen(objUsersEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objUsersEN.Memo) && GetStrLen(objUsersEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objUsersEN.HeadPic) && GetStrLen(objUsersEN.HeadPic) > 500)
{
 throw new Exception("字段[头像]的长度不能超过500!");
}
 objUsersEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUsersEN GetObjByUserId(string strUserId)
{
string strAction = "GetObjByUserId";
string strErrMsg = string.Empty;
string strResult = "";
clsUsersEN objUsersEN = null;
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
objUsersEN = JsonConvert.DeserializeObject<clsUsersEN>((string)jobjReturn["ReturnObj"]);
return objUsersEN;
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
public static clsUsersEN GetObjByUserId_WA_Cache(string strUserId)
{
string strAction = "GetObjByUserId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsUsersEN objUsersEN = null;
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
objUsersEN = JsonConvert.DeserializeObject<clsUsersEN>((string)jobjReturn["ReturnObj"]);
return objUsersEN;
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
public static clsUsersEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsUsersEN objUsersEN = null;
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
objUsersEN = JsonConvert.DeserializeObject<clsUsersEN>((string)jobjReturn["ReturnObj"]);
return objUsersEN;
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
public static clsUsersEN GetObjByUserId_Cache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsUsersEN._CurrTabName_S);
List<clsUsersEN> arrUsersObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsUsersEN> arrUsersObjLst_Sel =
from objUsersEN in arrUsersObjLst_Cache
where objUsersEN.UserId == strUserId
select objUsersEN;
if (arrUsersObjLst_Sel.Count() == 0)
{
   clsUsersEN obj = clsUsersWApi.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrUsersObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserNameByUserId_Cache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsUsersEN._CurrTabName_S);
List<clsUsersEN> arrUsersObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsUsersEN> arrUsersObjLst_Sel1 =
from objUsersEN in arrUsersObjLst_Cache
where objUsersEN.UserId == strUserId
select objUsersEN;
List <clsUsersEN> arrUsersObjLst_Sel = new List<clsUsersEN>();
foreach (clsUsersEN obj in arrUsersObjLst_Sel1)
{
arrUsersObjLst_Sel.Add(obj);
}
if (arrUsersObjLst_Sel.Count > 0)
{
return arrUsersObjLst_Sel[0].UserName;
}
string strErrMsgForGetObjById = string.Format("在Users对象缓存列表中,找不到记录[UserId = {0}](函数:{1})", strUserId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsUsersBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByUserId_Cache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsUsersEN._CurrTabName_S);
List<clsUsersEN> arrUsersObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsUsersEN> arrUsersObjLst_Sel1 =
from objUsersEN in arrUsersObjLst_Cache
where objUsersEN.UserId == strUserId
select objUsersEN;
List <clsUsersEN> arrUsersObjLst_Sel = new List<clsUsersEN>();
foreach (clsUsersEN obj in arrUsersObjLst_Sel1)
{
arrUsersObjLst_Sel.Add(obj);
}
if (arrUsersObjLst_Sel.Count > 0)
{
return arrUsersObjLst_Sel[0].UserName;
}
string strErrMsgForGetObjById = string.Format("在Users对象缓存列表中,找不到记录的相关名称[UserId = {0}](函数:{1})", strUserId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsUsersBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUsersEN> GetObjLst(string strWhereCond)
{
 List<clsUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsUsersEN> GetObjLstByUserIdLst(List<string> arrUserId)
{
 List<clsUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsUsersEN> GetObjLstByUserIdLst_Cache(List<string> arrUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsUsersEN._CurrTabName_S);
List<clsUsersEN> arrUsersObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsUsersEN> arrUsersObjLst_Sel =
from objUsersEN in arrUsersObjLst_Cache
where arrUserId.Contains(objUsersEN.UserId)
select objUsersEN;
return arrUsersObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUsersEN> GetObjLstByUserIdLst_WA_Cache(List<string> arrUserId)
{
 List<clsUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsUsersEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsUsersEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsUsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsUsersEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strUserId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsUsersEN objUsersEN = clsUsersWApi.GetObjByUserId(strUserId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strUserId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsUsersWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelUserss(List<string> arrUserId)
{
string strAction = "DelUserss";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsUsersWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelUserssByCond(string strWhereCond)
{
string strAction = "DelUserssByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsUsersEN objUsersEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUsersEN>(objUsersEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsUsersEN objUsersEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUsersEN>(objUsersEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersWApi.ReFreshCache();
var strUserId = (string)jobjReturn["ReturnStr"];
return strUserId;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsUsersEN objUsersEN)
{
if (string.IsNullOrEmpty(objUsersEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objUsersEN.UserId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUsersEN>(objUsersEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objUsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsUsersEN objUsersEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objUsersEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objUsersEN.UserId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objUsersEN.UserId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUsersEN>(objUsersEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
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
objUsersENT.Password = objUsersENS.Password; //Password
objUsersENT.IsGpUser = objUsersENS.IsGpUser; //是否Gp用户
objUsersENT.SchoolID1 = objUsersENS.SchoolID1; //学校编号
objUsersENT.BeginYearMonth = objUsersENS.BeginYearMonth; //开始年月
objUsersENT.EndYearMonth = objUsersENS.EndYearMonth; //结束年月
objUsersENT.id_GradeBase = objUsersENS.id_GradeBase; //年级流水号
objUsersENT.id_XzCollege = objUsersENS.id_XzCollege; //学院流水号
objUsersENT.id_XzMajor = objUsersENS.id_XzMajor; //专业流水号
objUsersENT.IsLeaved = objUsersENS.IsLeaved; //IsLeaved
objUsersENT.StuIdTeacherId = objUsersENS.StuIdTeacherId; //学工号
objUsersENT.Email = objUsersENS.Email; //电子邮箱
objUsersENT.PhoneNumber = objUsersENS.PhoneNumber; //PhoneNumber
objUsersENT.AvatarsPicture = objUsersENS.AvatarsPicture; //AvatarsPicture
objUsersENT.IdentityID = objUsersENS.IdentityID; //身份编号
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
public static DataTable ToDataTable(List<clsUsersEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsUsersEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsUsersEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsUsersEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsUsersEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsUsersEN.AttributeName)
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserId");
//if (arrUsersObjLst_Cache == null)
//{
//arrUsersObjLst_Cache = await clsUsersWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsUsersEN._CurrTabName_S);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsUsersWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsUsersEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsUsersWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUsersEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsUsersEN._CurrTabName_S);
List<clsUsersEN> arrUsersObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrUsersObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsUsersEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conUsers.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.UserName, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.Password, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.IsGpUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(conUsers.SchoolID1, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.BeginYearMonth, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.EndYearMonth, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.IsLeaved, Type.GetType("System.Boolean"));
objDT.Columns.Add(conUsers.StuIdTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.Email, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.PhoneNumber, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.AvatarsPicture, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.IdentityID, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.AuditDate, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.AuditUser, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.IsAudit, Type.GetType("System.Boolean"));
objDT.Columns.Add(conUsers.IsRegister, Type.GetType("System.Boolean"));
objDT.Columns.Add(conUsers.RegisterDate, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.MobilePhone, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.OpenId, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.HeadPic, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.IsGSuser, Type.GetType("System.Boolean"));
foreach (clsUsersEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conUsers.UserId] = objInFor[conUsers.UserId];
objDR[conUsers.UserName] = objInFor[conUsers.UserName];
objDR[conUsers.DepartmentId] = objInFor[conUsers.DepartmentId];
objDR[conUsers.UserStateId] = objInFor[conUsers.UserStateId];
objDR[conUsers.Password] = objInFor[conUsers.Password];
objDR[conUsers.IsGpUser] = objInFor[conUsers.IsGpUser];
objDR[conUsers.SchoolID1] = objInFor[conUsers.SchoolID1];
objDR[conUsers.BeginYearMonth] = objInFor[conUsers.BeginYearMonth];
objDR[conUsers.EndYearMonth] = objInFor[conUsers.EndYearMonth];
objDR[conUsers.id_GradeBase] = objInFor[conUsers.id_GradeBase];
objDR[conUsers.id_XzCollege] = objInFor[conUsers.id_XzCollege];
objDR[conUsers.id_XzMajor] = objInFor[conUsers.id_XzMajor];
objDR[conUsers.IsLeaved] = objInFor[conUsers.IsLeaved];
objDR[conUsers.StuIdTeacherId] = objInFor[conUsers.StuIdTeacherId];
objDR[conUsers.Email] = objInFor[conUsers.Email];
objDR[conUsers.PhoneNumber] = objInFor[conUsers.PhoneNumber];
objDR[conUsers.AvatarsPicture] = objInFor[conUsers.AvatarsPicture];
objDR[conUsers.IdentityID] = objInFor[conUsers.IdentityID];
objDR[conUsers.AuditDate] = objInFor[conUsers.AuditDate];
objDR[conUsers.AuditUser] = objInFor[conUsers.AuditUser];
objDR[conUsers.IsAudit] = objInFor[conUsers.IsAudit];
objDR[conUsers.IsRegister] = objInFor[conUsers.IsRegister];
objDR[conUsers.RegisterDate] = objInFor[conUsers.RegisterDate];
objDR[conUsers.MobilePhone] = objInFor[conUsers.MobilePhone];
objDR[conUsers.OpenId] = objInFor[conUsers.OpenId];
objDR[conUsers.UpdDate] = objInFor[conUsers.UpdDate];
objDR[conUsers.UpdUser] = objInFor[conUsers.UpdUser];
objDR[conUsers.Memo] = objInFor[conUsers.Memo];
objDR[conUsers.HeadPic] = objInFor[conUsers.HeadPic];
objDR[conUsers.IsGSuser] = objInFor[conUsers.IsGSuser];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 用户(Users)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4Users : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
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
clsUsersWApi.ReFreshThisCache();
clsvUsersWApi.ReFreshThisCache();
clsvUsersSimWApi.ReFreshThisCache();
}
}

}