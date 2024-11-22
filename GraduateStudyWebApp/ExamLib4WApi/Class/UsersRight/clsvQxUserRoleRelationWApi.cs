
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRoleRelationWApi
 表名:vQxUserRoleRelation(01120257)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:40
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理
 模块英文名:UsersRight
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
public static class clsvQxUserRoleRelationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetmId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, long lngmId, string strComparisonOp="")
	{
objvQxUserRoleRelationEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.mId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.mId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.mId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetUserId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convQxUserRoleRelation.UserId);
objvQxUserRoleRelationEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.UserId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.UserId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.UserId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetRoleId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleId, convQxUserRoleRelation.RoleId);
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxUserRoleRelation.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxUserRoleRelation.RoleId);
objvQxUserRoleRelationEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.RoleId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.RoleId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.RoleId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetQxPrjId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxUserRoleRelation.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserRoleRelation.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserRoleRelation.QxPrjId);
objvQxUserRoleRelationEN.QxPrjId = strQxPrjId; //QxPrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.QxPrjId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.QxPrjId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.QxPrjId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetMemo(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserRoleRelation.Memo);
objvQxUserRoleRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.Memo) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.Memo, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.Memo] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetPrjName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserRoleRelation.PrjName);
objvQxUserRoleRelationEN.PrjName = strPrjName; //PrjName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.PrjName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.PrjName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.PrjName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetRoleName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleName, 100, convQxUserRoleRelation.RoleName);
objvQxUserRoleRelationEN.RoleName = strRoleName; //角色名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.RoleName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.RoleName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.RoleName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetUserName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convQxUserRoleRelation.UserName);
objvQxUserRoleRelationEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.UserName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.UserName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.UserName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetDepartmentId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUserRoleRelation.DepartmentId);
objvQxUserRoleRelationEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.DepartmentId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.DepartmentId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.DepartmentId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetUserStateId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUserRoleRelation.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUserRoleRelation.UserStateId);
objvQxUserRoleRelationEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.UserStateId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.UserStateId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.UserStateId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetDepartmentName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUserRoleRelation.DepartmentName);
objvQxUserRoleRelationEN.DepartmentName = strDepartmentName; //部门名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.DepartmentName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.DepartmentName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.DepartmentName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetUserStateName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUserRoleRelation.UserStateName);
objvQxUserRoleRelationEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.UserStateName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.UserStateName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.UserStateName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetIdentityDesc(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUserRoleRelation.IdentityDesc);
objvQxUserRoleRelationEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.IdentityDesc) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.IdentityDesc, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.IdentityDesc] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetIdentityID(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strIdentityID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityID, 2, convQxUserRoleRelation.IdentityID);
clsCheckSql.CheckFieldForeignKey(strIdentityID, 2, convQxUserRoleRelation.IdentityID);
objvQxUserRoleRelationEN.IdentityID = strIdentityID; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.IdentityID) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.IdentityID, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.IdentityID] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetStuTeacherID(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strStuTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTeacherID, 20, convQxUserRoleRelation.StuTeacherID);
objvQxUserRoleRelationEN.StuTeacherID = strStuTeacherID; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.StuTeacherID) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.StuTeacherID, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.StuTeacherID] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN Setid_XzMajor(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convQxUserRoleRelation.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convQxUserRoleRelation.id_XzMajor);
objvQxUserRoleRelationEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.id_XzMajor) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.id_XzMajor, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.id_XzMajor] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetCollegeName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convQxUserRoleRelation.CollegeName);
objvQxUserRoleRelationEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.CollegeName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.CollegeName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.CollegeName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN Setid_XzCollege(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convQxUserRoleRelation.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convQxUserRoleRelation.id_XzCollege);
objvQxUserRoleRelationEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.id_XzCollege) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.id_XzCollege, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.id_XzCollege] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetMajorName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convQxUserRoleRelation.MajorName);
objvQxUserRoleRelationEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.MajorName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.MajorName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.MajorName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetPassword(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPassword, 20, convQxUserRoleRelation.Password);
objvQxUserRoleRelationEN.Password = strPassword; //Password
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.Password) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.Password, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.Password] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUserRoleRelationEN objvQxUserRoleRelation_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.mId) == true)
{
string strComparisonOp_mId = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUserRoleRelation.mId, objvQxUserRoleRelation_Cond.mId, strComparisonOp_mId);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.UserId) == true)
{
string strComparisonOp_UserId = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.UserId, objvQxUserRoleRelation_Cond.UserId, strComparisonOp_UserId);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.RoleId) == true)
{
string strComparisonOp_RoleId = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.RoleId, objvQxUserRoleRelation_Cond.RoleId, strComparisonOp_RoleId);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.QxPrjId) == true)
{
string strComparisonOp_QxPrjId = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.QxPrjId, objvQxUserRoleRelation_Cond.QxPrjId, strComparisonOp_QxPrjId);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.Memo) == true)
{
string strComparisonOp_Memo = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.Memo, objvQxUserRoleRelation_Cond.Memo, strComparisonOp_Memo);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.PrjName) == true)
{
string strComparisonOp_PrjName = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.PrjName, objvQxUserRoleRelation_Cond.PrjName, strComparisonOp_PrjName);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.RoleName) == true)
{
string strComparisonOp_RoleName = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.RoleName, objvQxUserRoleRelation_Cond.RoleName, strComparisonOp_RoleName);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.UserName) == true)
{
string strComparisonOp_UserName = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.UserName, objvQxUserRoleRelation_Cond.UserName, strComparisonOp_UserName);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.DepartmentId) == true)
{
string strComparisonOp_DepartmentId = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.DepartmentId, objvQxUserRoleRelation_Cond.DepartmentId, strComparisonOp_DepartmentId);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.UserStateId) == true)
{
string strComparisonOp_UserStateId = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.UserStateId, objvQxUserRoleRelation_Cond.UserStateId, strComparisonOp_UserStateId);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.DepartmentName) == true)
{
string strComparisonOp_DepartmentName = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.DepartmentName, objvQxUserRoleRelation_Cond.DepartmentName, strComparisonOp_DepartmentName);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.UserStateName) == true)
{
string strComparisonOp_UserStateName = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.UserStateName, objvQxUserRoleRelation_Cond.UserStateName, strComparisonOp_UserStateName);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.IdentityDesc) == true)
{
string strComparisonOp_IdentityDesc = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.IdentityDesc, objvQxUserRoleRelation_Cond.IdentityDesc, strComparisonOp_IdentityDesc);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.IdentityID) == true)
{
string strComparisonOp_IdentityID = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.IdentityID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.IdentityID, objvQxUserRoleRelation_Cond.IdentityID, strComparisonOp_IdentityID);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.StuTeacherID) == true)
{
string strComparisonOp_StuTeacherID = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.StuTeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.StuTeacherID, objvQxUserRoleRelation_Cond.StuTeacherID, strComparisonOp_StuTeacherID);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.id_XzMajor, objvQxUserRoleRelation_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.CollegeName, objvQxUserRoleRelation_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.id_XzCollege, objvQxUserRoleRelation_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.MajorName) == true)
{
string strComparisonOp_MajorName = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.MajorName, objvQxUserRoleRelation_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvQxUserRoleRelation_Cond.IsUpdated(convQxUserRoleRelation.Password) == true)
{
string strComparisonOp_Password = objvQxUserRoleRelation_Cond.dicFldComparisonOp[convQxUserRoleRelation.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.Password, objvQxUserRoleRelation_Cond.Password, strComparisonOp_Password);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vQxUserRoleRelation(vQx用户角色关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_mId_UserId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvQxUserRoleRelationEN == null) return "";
if (objvQxUserRoleRelationEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvQxUserRoleRelationEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objvQxUserRoleRelationEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvQxUserRoleRelationEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objvQxUserRoleRelationEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objvQxUserRoleRelationEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// vQx用户角色关系(vQxUserRoleRelation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserRoleRelationWApi
{
private static readonly string mstrApiControllerName = "vQxUserRoleRelationApi";

 public clsvQxUserRoleRelationWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRoleRelationEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQxUserRoleRelationEN = JsonConvert.DeserializeObject<clsvQxUserRoleRelationEN>((string)jobjReturn["ReturnObj"]);
return objvQxUserRoleRelationEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRoleRelationEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQxUserRoleRelationEN = JsonConvert.DeserializeObject<clsvQxUserRoleRelationEN>((string)jobjReturn["ReturnObj"]);
return objvQxUserRoleRelationEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvQxUserRoleRelationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = null;
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
objvQxUserRoleRelationEN = JsonConvert.DeserializeObject<clsvQxUserRoleRelationEN>((string)jobjReturn["ReturnObj"]);
return objvQxUserRoleRelationEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserRoleRelationEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvQxUserRoleRelationEN._CurrTabName_S);
List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLst_Sel =
from objvQxUserRoleRelationEN in arrvQxUserRoleRelationObjLst_Cache
where objvQxUserRoleRelationEN.mId == lngmId
select objvQxUserRoleRelationEN;
if (arrvQxUserRoleRelationObjLst_Sel.Count() == 0)
{
   clsvQxUserRoleRelationEN obj = clsvQxUserRoleRelationWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQxUserRoleRelationObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRoleRelationEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserRoleRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQxUserRoleRelationEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvQxUserRoleRelationEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvQxUserRoleRelationEN._CurrTabName_S);
List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLst_Sel =
from objvQxUserRoleRelationEN in arrvQxUserRoleRelationObjLst_Cache
where arrMId.Contains(objvQxUserRoleRelationEN.mId)
select objvQxUserRoleRelationEN;
return arrvQxUserRoleRelationObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRoleRelationEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvQxUserRoleRelationEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxUserRoleRelationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxUserRoleRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxUserRoleRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxUserRoleRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQxUserRoleRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
 /// <param name = "objvQxUserRoleRelationENS">源对象</param>
 /// <param name = "objvQxUserRoleRelationENT">目标对象</param>
 public static void CopyTo(clsvQxUserRoleRelationEN objvQxUserRoleRelationENS, clsvQxUserRoleRelationEN objvQxUserRoleRelationENT)
{
try
{
objvQxUserRoleRelationENT.mId = objvQxUserRoleRelationENS.mId; //mId
objvQxUserRoleRelationENT.UserId = objvQxUserRoleRelationENS.UserId; //用户ID
objvQxUserRoleRelationENT.RoleId = objvQxUserRoleRelationENS.RoleId; //角色Id
objvQxUserRoleRelationENT.QxPrjId = objvQxUserRoleRelationENS.QxPrjId; //QxPrjId
objvQxUserRoleRelationENT.Memo = objvQxUserRoleRelationENS.Memo; //备注
objvQxUserRoleRelationENT.PrjName = objvQxUserRoleRelationENS.PrjName; //PrjName
objvQxUserRoleRelationENT.RoleName = objvQxUserRoleRelationENS.RoleName; //角色名
objvQxUserRoleRelationENT.UserName = objvQxUserRoleRelationENS.UserName; //用户名
objvQxUserRoleRelationENT.DepartmentId = objvQxUserRoleRelationENS.DepartmentId; //部门Id
objvQxUserRoleRelationENT.UserStateId = objvQxUserRoleRelationENS.UserStateId; //用户状态Id
objvQxUserRoleRelationENT.DepartmentName = objvQxUserRoleRelationENS.DepartmentName; //部门名称
objvQxUserRoleRelationENT.UserStateName = objvQxUserRoleRelationENS.UserStateName; //用户状态名
objvQxUserRoleRelationENT.IdentityDesc = objvQxUserRoleRelationENS.IdentityDesc; //身份描述
objvQxUserRoleRelationENT.IdentityID = objvQxUserRoleRelationENS.IdentityID; //身份编号
objvQxUserRoleRelationENT.StuTeacherID = objvQxUserRoleRelationENS.StuTeacherID; //学工号
objvQxUserRoleRelationENT.id_XzMajor = objvQxUserRoleRelationENS.id_XzMajor; //专业流水号
objvQxUserRoleRelationENT.CollegeName = objvQxUserRoleRelationENS.CollegeName; //学院名称
objvQxUserRoleRelationENT.id_XzCollege = objvQxUserRoleRelationENS.id_XzCollege; //学院流水号
objvQxUserRoleRelationENT.MajorName = objvQxUserRoleRelationENS.MajorName; //专业名称
objvQxUserRoleRelationENT.Password = objvQxUserRoleRelationENS.Password; //Password
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
public static DataTable ToDataTable(List<clsvQxUserRoleRelationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxUserRoleRelationEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxUserRoleRelationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxUserRoleRelationEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxUserRoleRelationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxUserRoleRelationEN.AttributeName)
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
if (clsQxUserRoleRelationWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserRoleRelationWApi没有刷新缓存机制(clsQxUserRoleRelationWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserRolesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserRolesWApi没有刷新缓存机制(clsQxUserRolesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxProjectsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxProjectsWApi没有刷新缓存机制(clsQxProjectsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUsersWApi没有刷新缓存机制(clsQxUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserIdentityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserIdentityWApi没有刷新缓存机制(clsQxUserIdentityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserStateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserStateWApi没有刷新缓存机制(clsQxUserStateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateWApi没有刷新缓存机制(clsUserStateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityWApi没有刷新缓存机制(clsUserIdentityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxDepartmentInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxDepartmentInfoWApi没有刷新缓存机制(clsQxDepartmentInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxDepartmentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxDepartmentTypeWApi没有刷新缓存机制(clsQxDepartmentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvQxUserRoleRelationObjLst_Cache == null)
//{
//arrvQxUserRoleRelationObjLst_Cache = await clsvQxUserRoleRelationWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvQxUserRoleRelationEN._CurrTabName_S);
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
public static List<clsvQxUserRoleRelationEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvQxUserRoleRelationEN._CurrTabName_S);
List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxUserRoleRelationObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxUserRoleRelationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxUserRoleRelation.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxUserRoleRelation.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.IdentityDesc, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.IdentityID, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.StuTeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.Password, Type.GetType("System.String"));
foreach (clsvQxUserRoleRelationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxUserRoleRelation.mId] = objInFor[convQxUserRoleRelation.mId];
objDR[convQxUserRoleRelation.UserId] = objInFor[convQxUserRoleRelation.UserId];
objDR[convQxUserRoleRelation.RoleId] = objInFor[convQxUserRoleRelation.RoleId];
objDR[convQxUserRoleRelation.QxPrjId] = objInFor[convQxUserRoleRelation.QxPrjId];
objDR[convQxUserRoleRelation.Memo] = objInFor[convQxUserRoleRelation.Memo];
objDR[convQxUserRoleRelation.PrjName] = objInFor[convQxUserRoleRelation.PrjName];
objDR[convQxUserRoleRelation.RoleName] = objInFor[convQxUserRoleRelation.RoleName];
objDR[convQxUserRoleRelation.UserName] = objInFor[convQxUserRoleRelation.UserName];
objDR[convQxUserRoleRelation.DepartmentId] = objInFor[convQxUserRoleRelation.DepartmentId];
objDR[convQxUserRoleRelation.UserStateId] = objInFor[convQxUserRoleRelation.UserStateId];
objDR[convQxUserRoleRelation.DepartmentName] = objInFor[convQxUserRoleRelation.DepartmentName];
objDR[convQxUserRoleRelation.UserStateName] = objInFor[convQxUserRoleRelation.UserStateName];
objDR[convQxUserRoleRelation.IdentityDesc] = objInFor[convQxUserRoleRelation.IdentityDesc];
objDR[convQxUserRoleRelation.IdentityID] = objInFor[convQxUserRoleRelation.IdentityID];
objDR[convQxUserRoleRelation.StuTeacherID] = objInFor[convQxUserRoleRelation.StuTeacherID];
objDR[convQxUserRoleRelation.id_XzMajor] = objInFor[convQxUserRoleRelation.id_XzMajor];
objDR[convQxUserRoleRelation.CollegeName] = objInFor[convQxUserRoleRelation.CollegeName];
objDR[convQxUserRoleRelation.id_XzCollege] = objInFor[convQxUserRoleRelation.id_XzCollege];
objDR[convQxUserRoleRelation.MajorName] = objInFor[convQxUserRoleRelation.MajorName];
objDR[convQxUserRoleRelation.Password] = objInFor[convQxUserRoleRelation.Password];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}