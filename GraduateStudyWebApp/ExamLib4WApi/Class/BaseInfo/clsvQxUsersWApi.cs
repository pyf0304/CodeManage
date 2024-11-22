
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsersWApi
 表名:vQxUsers(01120564)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:11
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护
 模块英文名:BaseInfo
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
public static class clsvQxUsersWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetUserId(this clsvQxUsersEN objvQxUsersEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convQxUsers.UserId);
objvQxUsersEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UserId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UserId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UserId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetUserName(this clsvQxUsersEN objvQxUsersEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUsers.UserName);
clsCheckSql.CheckFieldLen(strUserName, 50, convQxUsers.UserName);
objvQxUsersEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UserName) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UserName, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UserName] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetUserStateId(this clsvQxUsersEN objvQxUsersEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convQxUsers.UserStateId);
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUsers.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUsers.UserStateId);
objvQxUsersEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UserStateId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UserStateId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UserStateId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetMemo(this clsvQxUsersEN objvQxUsersEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUsers.Memo);
objvQxUsersEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.Memo) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.Memo, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.Memo] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetUserStateName(this clsvQxUsersEN objvQxUsersEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUsers.UserStateName);
objvQxUsersEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UserStateName) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UserStateName, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UserStateName] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentId(this clsvQxUsersEN objvQxUsersEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUsers.DepartmentId);
objvQxUsersEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.DepartmentId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.DepartmentId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.DepartmentId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetUpDepartmentId(this clsvQxUsersEN objvQxUsersEN, string strUpDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, convQxUsers.UpDepartmentId);
objvQxUsersEN.UpDepartmentId = strUpDepartmentId; //UpDepartmentId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UpDepartmentId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UpDepartmentId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UpDepartmentId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentName(this clsvQxUsersEN objvQxUsersEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUsers.DepartmentName);
objvQxUsersEN.DepartmentName = strDepartmentName; //部门名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.DepartmentName) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.DepartmentName, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.DepartmentName] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetUpDepartmentName(this clsvQxUsersEN objvQxUsersEN, string strUpDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentName, 100, convQxUsers.UpDepartmentName);
objvQxUsersEN.UpDepartmentName = strUpDepartmentName; //UpDepartmentName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UpDepartmentName) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UpDepartmentName, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UpDepartmentName] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentTypeName(this clsvQxUsersEN objvQxUsersEN, string strDepartmentTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentTypeName, 50, convQxUsers.DepartmentTypeName);
objvQxUsersEN.DepartmentTypeName = strDepartmentTypeName; //DepartmentTypeName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.DepartmentTypeName) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.DepartmentTypeName, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.DepartmentTypeName] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentTypeId(this clsvQxUsersEN objvQxUsersEN, string strDepartmentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, convQxUsers.DepartmentTypeId);
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, convQxUsers.DepartmentTypeId);
objvQxUsersEN.DepartmentTypeId = strDepartmentTypeId; //DepartmentTypeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.DepartmentTypeId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.DepartmentTypeId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.DepartmentTypeId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentAbbrName(this clsvQxUsersEN objvQxUsersEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 12, convQxUsers.DepartmentAbbrName);
objvQxUsersEN.DepartmentAbbrName = strDepartmentAbbrName; //DepartmentAbbrName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.DepartmentAbbrName) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.DepartmentAbbrName, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.DepartmentAbbrName] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetEffectiveDate(this clsvQxUsersEN objvQxUsersEN, string strEffectiveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEffectiveDate, 8, convQxUsers.EffectiveDate);
objvQxUsersEN.EffectiveDate = strEffectiveDate; //EffectiveDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.EffectiveDate) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.EffectiveDate, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.EffectiveDate] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetUpdDate(this clsvQxUsersEN objvQxUsersEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUsers.UpdDate);
objvQxUsersEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UpdDate) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UpdDate, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UpdDate] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetUpdUser(this clsvQxUsersEN objvQxUsersEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQxUsers.UpdUser);
objvQxUsersEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UpdUser) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UpdUser, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UpdUser] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetEffitiveBeginDate(this clsvQxUsersEN objvQxUsersEN, string strEffitiveBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveBeginDate, convQxUsers.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, convQxUsers.EffitiveBeginDate);
objvQxUsersEN.EffitiveBeginDate = strEffitiveBeginDate; //EffitiveBeginDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.EffitiveBeginDate) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.EffitiveBeginDate, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.EffitiveBeginDate] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetEffitiveEndDate(this clsvQxUsersEN objvQxUsersEN, string strEffitiveEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveEndDate, convQxUsers.EffitiveEndDate);
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, convQxUsers.EffitiveEndDate);
objvQxUsersEN.EffitiveEndDate = strEffitiveEndDate; //EffitiveEndDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.EffitiveEndDate) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.EffitiveEndDate, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.EffitiveEndDate] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetStuTeacherID(this clsvQxUsersEN objvQxUsersEN, string strStuTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuTeacherID, convQxUsers.StuTeacherID);
clsCheckSql.CheckFieldLen(strStuTeacherID, 20, convQxUsers.StuTeacherID);
objvQxUsersEN.StuTeacherID = strStuTeacherID; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.StuTeacherID) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.StuTeacherID, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.StuTeacherID] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetIdentityID(this clsvQxUsersEN objvQxUsersEN, string strIdentityID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityID, 2, convQxUsers.IdentityID);
clsCheckSql.CheckFieldForeignKey(strIdentityID, 2, convQxUsers.IdentityID);
objvQxUsersEN.IdentityID = strIdentityID; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.IdentityID) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.IdentityID, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.IdentityID] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetPassword(this clsvQxUsersEN objvQxUsersEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPassword, 20, convQxUsers.Password);
objvQxUsersEN.Password = strPassword; //Password
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.Password) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.Password, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.Password] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetIdentityDesc(this clsvQxUsersEN objvQxUsersEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUsers.IdentityDesc);
objvQxUsersEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.IdentityDesc) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.IdentityDesc, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.IdentityDesc] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetIsSynch(this clsvQxUsersEN objvQxUsersEN, bool bolIsSynch, string strComparisonOp="")
	{
objvQxUsersEN.IsSynch = bolIsSynch; //是否同步
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.IsSynch) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.IsSynch, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.IsSynch] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetSynchDate(this clsvQxUsersEN objvQxUsersEN, string strSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchDate, 30, convQxUsers.SynchDate);
objvQxUsersEN.SynchDate = strSynchDate; //同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.SynchDate) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.SynchDate, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.SynchDate] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetOpenId(this clsvQxUsersEN objvQxUsersEN, string strOpenId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpenId, 50, convQxUsers.OpenId);
objvQxUsersEN.OpenId = strOpenId; //微信OpenId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.OpenId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.OpenId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.OpenId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetNickName(this clsvQxUsersEN objvQxUsersEN, string strNickName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNickName, 50, convQxUsers.NickName);
objvQxUsersEN.NickName = strNickName; //昵称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.NickName) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.NickName, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.NickName] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetHeadimgUrl(this clsvQxUsersEN objvQxUsersEN, string strHeadimgUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHeadimgUrl, 1000, convQxUsers.HeadimgUrl);
objvQxUsersEN.HeadimgUrl = strHeadimgUrl; //微信头像
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.HeadimgUrl) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.HeadimgUrl, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.HeadimgUrl] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetCollegeName(this clsvQxUsersEN objvQxUsersEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convQxUsers.CollegeName);
objvQxUsersEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.CollegeName) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.CollegeName, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.CollegeName] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN Setid_XzCollege(this clsvQxUsersEN objvQxUsersEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convQxUsers.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convQxUsers.id_XzCollege);
objvQxUsersEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.id_XzCollege) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.id_XzCollege, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.id_XzCollege] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN Setid_XzMajor(this clsvQxUsersEN objvQxUsersEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convQxUsers.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convQxUsers.id_XzMajor);
objvQxUsersEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.id_XzMajor) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.id_XzMajor, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.id_XzMajor] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetMajorName(this clsvQxUsersEN objvQxUsersEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convQxUsers.MajorName);
objvQxUsersEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.MajorName) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.MajorName, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.MajorName] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN SetEmail(this clsvQxUsersEN objvQxUsersEN, string strEmail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEmail, 100, convQxUsers.Email);
objvQxUsersEN.Email = strEmail; //电子邮箱
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.Email) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.Email, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.Email] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxUsersEN Setid_College(this clsvQxUsersEN objvQxUsersEN, string strid_College, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_College, convQxUsers.id_College);
clsCheckSql.CheckFieldLen(strid_College, 4, convQxUsers.id_College);
clsCheckSql.CheckFieldForeignKey(strid_College, 4, convQxUsers.id_College);
objvQxUsersEN.id_College = strid_College; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.id_College) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.id_College, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.id_College] = strComparisonOp;
}
}
return objvQxUsersEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUsersEN objvQxUsers_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUsers_Cond.IsUpdated(convQxUsers.UserId) == true)
{
string strComparisonOp_UserId = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UserId, objvQxUsers_Cond.UserId, strComparisonOp_UserId);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.UserName) == true)
{
string strComparisonOp_UserName = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UserName, objvQxUsers_Cond.UserName, strComparisonOp_UserName);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.UserStateId) == true)
{
string strComparisonOp_UserStateId = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UserStateId, objvQxUsers_Cond.UserStateId, strComparisonOp_UserStateId);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.Memo) == true)
{
string strComparisonOp_Memo = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.Memo, objvQxUsers_Cond.Memo, strComparisonOp_Memo);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.UserStateName) == true)
{
string strComparisonOp_UserStateName = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UserStateName, objvQxUsers_Cond.UserStateName, strComparisonOp_UserStateName);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.DepartmentId) == true)
{
string strComparisonOp_DepartmentId = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.DepartmentId, objvQxUsers_Cond.DepartmentId, strComparisonOp_DepartmentId);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.UpDepartmentId) == true)
{
string strComparisonOp_UpDepartmentId = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.UpDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UpDepartmentId, objvQxUsers_Cond.UpDepartmentId, strComparisonOp_UpDepartmentId);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.DepartmentName) == true)
{
string strComparisonOp_DepartmentName = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.DepartmentName, objvQxUsers_Cond.DepartmentName, strComparisonOp_DepartmentName);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.UpDepartmentName) == true)
{
string strComparisonOp_UpDepartmentName = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.UpDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UpDepartmentName, objvQxUsers_Cond.UpDepartmentName, strComparisonOp_UpDepartmentName);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.DepartmentTypeName) == true)
{
string strComparisonOp_DepartmentTypeName = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.DepartmentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.DepartmentTypeName, objvQxUsers_Cond.DepartmentTypeName, strComparisonOp_DepartmentTypeName);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.DepartmentTypeId) == true)
{
string strComparisonOp_DepartmentTypeId = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.DepartmentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.DepartmentTypeId, objvQxUsers_Cond.DepartmentTypeId, strComparisonOp_DepartmentTypeId);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.DepartmentAbbrName) == true)
{
string strComparisonOp_DepartmentAbbrName = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.DepartmentAbbrName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.DepartmentAbbrName, objvQxUsers_Cond.DepartmentAbbrName, strComparisonOp_DepartmentAbbrName);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.EffectiveDate) == true)
{
string strComparisonOp_EffectiveDate = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.EffectiveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.EffectiveDate, objvQxUsers_Cond.EffectiveDate, strComparisonOp_EffectiveDate);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UpdDate, objvQxUsers_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UpdUser, objvQxUsers_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.EffitiveBeginDate) == true)
{
string strComparisonOp_EffitiveBeginDate = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.EffitiveBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.EffitiveBeginDate, objvQxUsers_Cond.EffitiveBeginDate, strComparisonOp_EffitiveBeginDate);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.EffitiveEndDate) == true)
{
string strComparisonOp_EffitiveEndDate = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.EffitiveEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.EffitiveEndDate, objvQxUsers_Cond.EffitiveEndDate, strComparisonOp_EffitiveEndDate);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.StuTeacherID) == true)
{
string strComparisonOp_StuTeacherID = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.StuTeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.StuTeacherID, objvQxUsers_Cond.StuTeacherID, strComparisonOp_StuTeacherID);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.IdentityID) == true)
{
string strComparisonOp_IdentityID = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.IdentityID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.IdentityID, objvQxUsers_Cond.IdentityID, strComparisonOp_IdentityID);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.Password) == true)
{
string strComparisonOp_Password = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.Password, objvQxUsers_Cond.Password, strComparisonOp_Password);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.IdentityDesc) == true)
{
string strComparisonOp_IdentityDesc = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.IdentityDesc, objvQxUsers_Cond.IdentityDesc, strComparisonOp_IdentityDesc);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.IsSynch) == true)
{
if (objvQxUsers_Cond.IsSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxUsers.IsSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxUsers.IsSynch);
}
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.SynchDate) == true)
{
string strComparisonOp_SynchDate = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.SynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.SynchDate, objvQxUsers_Cond.SynchDate, strComparisonOp_SynchDate);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.OpenId) == true)
{
string strComparisonOp_OpenId = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.OpenId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.OpenId, objvQxUsers_Cond.OpenId, strComparisonOp_OpenId);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.NickName) == true)
{
string strComparisonOp_NickName = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.NickName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.NickName, objvQxUsers_Cond.NickName, strComparisonOp_NickName);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.HeadimgUrl) == true)
{
string strComparisonOp_HeadimgUrl = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.HeadimgUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.HeadimgUrl, objvQxUsers_Cond.HeadimgUrl, strComparisonOp_HeadimgUrl);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.CollegeName, objvQxUsers_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.id_XzCollege, objvQxUsers_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.id_XzMajor, objvQxUsers_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.MajorName) == true)
{
string strComparisonOp_MajorName = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.MajorName, objvQxUsers_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.Email) == true)
{
string strComparisonOp_Email = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.Email, objvQxUsers_Cond.Email, strComparisonOp_Email);
}
if (objvQxUsers_Cond.IsUpdated(convQxUsers.id_College) == true)
{
string strComparisonOp_id_College = objvQxUsers_Cond.dicFldComparisonOp[convQxUsers.id_College];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.id_College, objvQxUsers_Cond.id_College, strComparisonOp_id_College);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vQx用户(vQxUsers)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUsersWApi
{
private static readonly string mstrApiControllerName = "vQxUsersApi";

 public clsvQxUsersWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUsersEN GetObjByUserId(string strUserId)
{
string strAction = "GetObjByUserId";
string strErrMsg = string.Empty;
string strResult = "";
clsvQxUsersEN objvQxUsersEN = null;
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
objvQxUsersEN = JsonConvert.DeserializeObject<clsvQxUsersEN>((string)jobjReturn["ReturnObj"]);
return objvQxUsersEN;
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
public static clsvQxUsersEN GetObjByUserId_WA_Cache(string strUserId)
{
string strAction = "GetObjByUserId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQxUsersEN objvQxUsersEN = null;
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
objvQxUsersEN = JsonConvert.DeserializeObject<clsvQxUsersEN>((string)jobjReturn["ReturnObj"]);
return objvQxUsersEN;
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
public static clsvQxUsersEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQxUsersEN objvQxUsersEN = null;
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
objvQxUsersEN = JsonConvert.DeserializeObject<clsvQxUsersEN>((string)jobjReturn["ReturnObj"]);
return objvQxUsersEN;
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
public static clsvQxUsersEN GetObjByUserId_Cache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvQxUsersEN._CurrTabName_S);
List<clsvQxUsersEN> arrvQxUsersObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQxUsersEN> arrvQxUsersObjLst_Sel =
from objvQxUsersEN in arrvQxUsersObjLst_Cache
where objvQxUsersEN.UserId == strUserId
select objvQxUsersEN;
if (arrvQxUsersObjLst_Sel.Count() == 0)
{
   clsvQxUsersEN obj = clsvQxUsersWApi.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQxUsersObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsersEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxUsersEN> GetObjLstByUserIdLst(List<string> arrUserId)
{
 List<clsvQxUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvQxUsersEN> GetObjLstByUserIdLst_Cache(List<string> arrUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvQxUsersEN._CurrTabName_S);
List<clsvQxUsersEN> arrvQxUsersObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQxUsersEN> arrvQxUsersObjLst_Sel =
from objvQxUsersEN in arrvQxUsersObjLst_Cache
where arrUserId.Contains(objvQxUsersEN.UserId)
select objvQxUsersEN;
return arrvQxUsersObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsersEN> GetObjLstByUserIdLst_WA_Cache(List<string> arrUserId)
{
 List<clsvQxUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxUsersEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxUsersEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxUsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxUsersEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQxUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvQxUsersENS">源对象</param>
 /// <param name = "objvQxUsersENT">目标对象</param>
 public static void CopyTo(clsvQxUsersEN objvQxUsersENS, clsvQxUsersEN objvQxUsersENT)
{
try
{
objvQxUsersENT.UserId = objvQxUsersENS.UserId; //用户ID
objvQxUsersENT.UserName = objvQxUsersENS.UserName; //用户名
objvQxUsersENT.UserStateId = objvQxUsersENS.UserStateId; //用户状态Id
objvQxUsersENT.Memo = objvQxUsersENS.Memo; //备注
objvQxUsersENT.UserStateName = objvQxUsersENS.UserStateName; //用户状态名
objvQxUsersENT.DepartmentId = objvQxUsersENS.DepartmentId; //部门Id
objvQxUsersENT.UpDepartmentId = objvQxUsersENS.UpDepartmentId; //UpDepartmentId
objvQxUsersENT.DepartmentName = objvQxUsersENS.DepartmentName; //部门名称
objvQxUsersENT.UpDepartmentName = objvQxUsersENS.UpDepartmentName; //UpDepartmentName
objvQxUsersENT.DepartmentTypeName = objvQxUsersENS.DepartmentTypeName; //DepartmentTypeName
objvQxUsersENT.DepartmentTypeId = objvQxUsersENS.DepartmentTypeId; //DepartmentTypeId
objvQxUsersENT.DepartmentAbbrName = objvQxUsersENS.DepartmentAbbrName; //DepartmentAbbrName
objvQxUsersENT.EffectiveDate = objvQxUsersENS.EffectiveDate; //EffectiveDate
objvQxUsersENT.UpdDate = objvQxUsersENS.UpdDate; //修改日期
objvQxUsersENT.UpdUser = objvQxUsersENS.UpdUser; //修改人
objvQxUsersENT.EffitiveBeginDate = objvQxUsersENS.EffitiveBeginDate; //EffitiveBeginDate
objvQxUsersENT.EffitiveEndDate = objvQxUsersENS.EffitiveEndDate; //EffitiveEndDate
objvQxUsersENT.StuTeacherID = objvQxUsersENS.StuTeacherID; //学工号
objvQxUsersENT.IdentityID = objvQxUsersENS.IdentityID; //身份编号
objvQxUsersENT.Password = objvQxUsersENS.Password; //Password
objvQxUsersENT.IdentityDesc = objvQxUsersENS.IdentityDesc; //身份描述
objvQxUsersENT.IsSynch = objvQxUsersENS.IsSynch; //是否同步
objvQxUsersENT.SynchDate = objvQxUsersENS.SynchDate; //同步日期
objvQxUsersENT.OpenId = objvQxUsersENS.OpenId; //微信OpenId
objvQxUsersENT.NickName = objvQxUsersENS.NickName; //昵称
objvQxUsersENT.HeadimgUrl = objvQxUsersENS.HeadimgUrl; //微信头像
objvQxUsersENT.CollegeName = objvQxUsersENS.CollegeName; //学院名称
objvQxUsersENT.id_XzCollege = objvQxUsersENS.id_XzCollege; //学院流水号
objvQxUsersENT.id_XzMajor = objvQxUsersENS.id_XzMajor; //专业流水号
objvQxUsersENT.MajorName = objvQxUsersENS.MajorName; //专业名称
objvQxUsersENT.Email = objvQxUsersENS.Email; //电子邮箱
objvQxUsersENT.id_College = objvQxUsersENS.id_College; //学院流水号
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
public static DataTable ToDataTable(List<clsvQxUsersEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxUsersEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxUsersEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxUsersEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxUsersEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxUsersEN.AttributeName)
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
//string strWhereCond = string.Format("1 = 1 order by UserId");
//if (arrvQxUsersObjLst_Cache == null)
//{
//arrvQxUsersObjLst_Cache = await clsvQxUsersWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvQxUsersEN._CurrTabName_S);
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
public static List<clsvQxUsersEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvQxUsersEN._CurrTabName_S);
List<clsvQxUsersEN> arrvQxUsersObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxUsersObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxUsersEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxUsers.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.UpDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.UpDepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.DepartmentTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.DepartmentTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.DepartmentAbbrName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.EffectiveDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.EffitiveBeginDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.EffitiveEndDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.StuTeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.IdentityID, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.Password, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.IdentityDesc, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.IsSynch, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxUsers.SynchDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.OpenId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.NickName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.HeadimgUrl, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.Email, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.id_College, Type.GetType("System.String"));
foreach (clsvQxUsersEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxUsers.UserId] = objInFor[convQxUsers.UserId];
objDR[convQxUsers.UserName] = objInFor[convQxUsers.UserName];
objDR[convQxUsers.UserStateId] = objInFor[convQxUsers.UserStateId];
objDR[convQxUsers.Memo] = objInFor[convQxUsers.Memo];
objDR[convQxUsers.UserStateName] = objInFor[convQxUsers.UserStateName];
objDR[convQxUsers.DepartmentId] = objInFor[convQxUsers.DepartmentId];
objDR[convQxUsers.UpDepartmentId] = objInFor[convQxUsers.UpDepartmentId];
objDR[convQxUsers.DepartmentName] = objInFor[convQxUsers.DepartmentName];
objDR[convQxUsers.UpDepartmentName] = objInFor[convQxUsers.UpDepartmentName];
objDR[convQxUsers.DepartmentTypeName] = objInFor[convQxUsers.DepartmentTypeName];
objDR[convQxUsers.DepartmentTypeId] = objInFor[convQxUsers.DepartmentTypeId];
objDR[convQxUsers.DepartmentAbbrName] = objInFor[convQxUsers.DepartmentAbbrName];
objDR[convQxUsers.EffectiveDate] = objInFor[convQxUsers.EffectiveDate];
objDR[convQxUsers.UpdDate] = objInFor[convQxUsers.UpdDate];
objDR[convQxUsers.UpdUser] = objInFor[convQxUsers.UpdUser];
objDR[convQxUsers.EffitiveBeginDate] = objInFor[convQxUsers.EffitiveBeginDate];
objDR[convQxUsers.EffitiveEndDate] = objInFor[convQxUsers.EffitiveEndDate];
objDR[convQxUsers.StuTeacherID] = objInFor[convQxUsers.StuTeacherID];
objDR[convQxUsers.IdentityID] = objInFor[convQxUsers.IdentityID];
objDR[convQxUsers.Password] = objInFor[convQxUsers.Password];
objDR[convQxUsers.IdentityDesc] = objInFor[convQxUsers.IdentityDesc];
objDR[convQxUsers.IsSynch] = objInFor[convQxUsers.IsSynch];
objDR[convQxUsers.SynchDate] = objInFor[convQxUsers.SynchDate];
objDR[convQxUsers.OpenId] = objInFor[convQxUsers.OpenId];
objDR[convQxUsers.NickName] = objInFor[convQxUsers.NickName];
objDR[convQxUsers.HeadimgUrl] = objInFor[convQxUsers.HeadimgUrl];
objDR[convQxUsers.CollegeName] = objInFor[convQxUsers.CollegeName];
objDR[convQxUsers.id_XzCollege] = objInFor[convQxUsers.id_XzCollege];
objDR[convQxUsers.id_XzMajor] = objInFor[convQxUsers.id_XzMajor];
objDR[convQxUsers.MajorName] = objInFor[convQxUsers.MajorName];
objDR[convQxUsers.Email] = objInFor[convQxUsers.Email];
objDR[convQxUsers.id_College] = objInFor[convQxUsers.id_College];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}