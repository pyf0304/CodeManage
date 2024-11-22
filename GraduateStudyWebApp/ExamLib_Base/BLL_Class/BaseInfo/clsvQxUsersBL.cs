
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsersBL
 表名:vQxUsers(01120564)
 * 版本:2024.05.05.1(服务器:WIN-SRV103-116)
 日期:2024/05/19 00:14:01
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
public static class  clsvQxUsersBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUsersEN GetObj(this K_UserId_vQxUsers myKey)
{
clsvQxUsersEN objvQxUsersEN = clsvQxUsersBL.vQxUsersDA.GetObjByUserId(myKey.Value);
return objvQxUsersEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUserId(this clsvQxUsersEN objvQxUsersEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUsers.UserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUserName(this clsvQxUsersEN objvQxUsersEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUsers.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUsers.UserName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUserStateId(this clsvQxUsersEN objvQxUsersEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convQxUsers.UserStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUsers.UserStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUsers.UserStateId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetMemo(this clsvQxUsersEN objvQxUsersEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUsers.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUserStateName(this clsvQxUsersEN objvQxUsersEN, string strUserStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUsers.UserStateName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentId(this clsvQxUsersEN objvQxUsersEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUsers.DepartmentId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUpDepartmentId(this clsvQxUsersEN objvQxUsersEN, string strUpDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, convQxUsers.UpDepartmentId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentName(this clsvQxUsersEN objvQxUsersEN, string strDepartmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUsers.DepartmentName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUpDepartmentName(this clsvQxUsersEN objvQxUsersEN, string strUpDepartmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpDepartmentName, 100, convQxUsers.UpDepartmentName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentTypeName(this clsvQxUsersEN objvQxUsersEN, string strDepartmentTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeName, 50, convQxUsers.DepartmentTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentTypeId(this clsvQxUsersEN objvQxUsersEN, string strDepartmentTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, convQxUsers.DepartmentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, convQxUsers.DepartmentTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentAbbrName(this clsvQxUsersEN objvQxUsersEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 12, convQxUsers.DepartmentAbbrName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUpdDate(this clsvQxUsersEN objvQxUsersEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUsers.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUpdUser(this clsvQxUsersEN objvQxUsersEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQxUsers.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetEffitiveBeginDate(this clsvQxUsersEN objvQxUsersEN, string strEffitiveBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveBeginDate, convQxUsers.EffitiveBeginDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, convQxUsers.EffitiveBeginDate);
}
objvQxUsersEN.EffitiveBeginDate = strEffitiveBeginDate; //有效开始日期
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetEffitiveEndDate(this clsvQxUsersEN objvQxUsersEN, string strEffitiveEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveEndDate, convQxUsers.EffitiveEndDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, convQxUsers.EffitiveEndDate);
}
objvQxUsersEN.EffitiveEndDate = strEffitiveEndDate; //有效结束日期
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetStuTeacherId(this clsvQxUsersEN objvQxUsersEN, string strStuTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuTeacherId, convQxUsers.StuTeacherId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, convQxUsers.StuTeacherId);
}
objvQxUsersEN.StuTeacherId = strStuTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.StuTeacherId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.StuTeacherId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.StuTeacherId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetIdentityId(this clsvQxUsersEN objvQxUsersEN, string strIdentityId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxUsers.IdentityId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxUsers.IdentityId);
}
objvQxUsersEN.IdentityId = strIdentityId; //身份Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.IdentityId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.IdentityId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.IdentityId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetPassword(this clsvQxUsersEN objvQxUsersEN, string strPassword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPassword, 20, convQxUsers.Password);
}
objvQxUsersEN.Password = strPassword; //口令
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetIdentityDesc(this clsvQxUsersEN objvQxUsersEN, string strIdentityDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUsers.IdentityDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetSynchDate(this clsvQxUsersEN objvQxUsersEN, string strSynchDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchDate, 30, convQxUsers.SynchDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetOpenId(this clsvQxUsersEN objvQxUsersEN, string strOpenId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpenId, 50, convQxUsers.OpenId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetCollegeName(this clsvQxUsersEN objvQxUsersEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convQxUsers.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetIdXzCollege(this clsvQxUsersEN objvQxUsersEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convQxUsers.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convQxUsers.IdXzCollege);
}
objvQxUsersEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.IdXzCollege) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.IdXzCollege, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.IdXzCollege] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetEmail(this clsvQxUsersEN objvQxUsersEN, string strEmail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEmail, 100, convQxUsers.Email);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxUsersENS">源对象</param>
 /// <param name = "objvQxUsersENT">目标对象</param>
 public static void CopyTo(this clsvQxUsersEN objvQxUsersENS, clsvQxUsersEN objvQxUsersENT)
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
objvQxUsersENT.UpdDate = objvQxUsersENS.UpdDate; //修改日期
objvQxUsersENT.UpdUser = objvQxUsersENS.UpdUser; //修改人
objvQxUsersENT.EffitiveBeginDate = objvQxUsersENS.EffitiveBeginDate; //有效开始日期
objvQxUsersENT.EffitiveEndDate = objvQxUsersENS.EffitiveEndDate; //有效结束日期
objvQxUsersENT.StuTeacherId = objvQxUsersENS.StuTeacherId; //学工号
objvQxUsersENT.IdentityId = objvQxUsersENS.IdentityId; //身份Id
objvQxUsersENT.Password = objvQxUsersENS.Password; //口令
objvQxUsersENT.IdentityDesc = objvQxUsersENS.IdentityDesc; //身份描述
objvQxUsersENT.IsSynch = objvQxUsersENS.IsSynch; //是否同步
objvQxUsersENT.SynchDate = objvQxUsersENS.SynchDate; //同步日期
objvQxUsersENT.OpenId = objvQxUsersENS.OpenId; //微信OpenId
objvQxUsersENT.CollegeName = objvQxUsersENS.CollegeName; //学院名称
objvQxUsersENT.IdXzCollege = objvQxUsersENS.IdXzCollege; //学院流水号
objvQxUsersENT.Email = objvQxUsersENS.Email; //电子邮箱
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
 /// <param name = "objvQxUsersENS">源对象</param>
 /// <returns>目标对象=>clsvQxUsersEN:objvQxUsersENT</returns>
 public static clsvQxUsersEN CopyTo(this clsvQxUsersEN objvQxUsersENS)
{
try
{
 clsvQxUsersEN objvQxUsersENT = new clsvQxUsersEN()
{
UserId = objvQxUsersENS.UserId, //用户ID
UserName = objvQxUsersENS.UserName, //用户名
UserStateId = objvQxUsersENS.UserStateId, //用户状态Id
Memo = objvQxUsersENS.Memo, //备注
UserStateName = objvQxUsersENS.UserStateName, //用户状态名
DepartmentId = objvQxUsersENS.DepartmentId, //部门Id
UpDepartmentId = objvQxUsersENS.UpDepartmentId, //UpDepartmentId
DepartmentName = objvQxUsersENS.DepartmentName, //部门名称
UpDepartmentName = objvQxUsersENS.UpDepartmentName, //UpDepartmentName
DepartmentTypeName = objvQxUsersENS.DepartmentTypeName, //DepartmentTypeName
DepartmentTypeId = objvQxUsersENS.DepartmentTypeId, //DepartmentTypeId
DepartmentAbbrName = objvQxUsersENS.DepartmentAbbrName, //DepartmentAbbrName
UpdDate = objvQxUsersENS.UpdDate, //修改日期
UpdUser = objvQxUsersENS.UpdUser, //修改人
EffitiveBeginDate = objvQxUsersENS.EffitiveBeginDate, //有效开始日期
EffitiveEndDate = objvQxUsersENS.EffitiveEndDate, //有效结束日期
StuTeacherId = objvQxUsersENS.StuTeacherId, //学工号
IdentityId = objvQxUsersENS.IdentityId, //身份Id
Password = objvQxUsersENS.Password, //口令
IdentityDesc = objvQxUsersENS.IdentityDesc, //身份描述
IsSynch = objvQxUsersENS.IsSynch, //是否同步
SynchDate = objvQxUsersENS.SynchDate, //同步日期
OpenId = objvQxUsersENS.OpenId, //微信OpenId
CollegeName = objvQxUsersENS.CollegeName, //学院名称
IdXzCollege = objvQxUsersENS.IdXzCollege, //学院流水号
Email = objvQxUsersENS.Email, //电子邮箱
};
 return objvQxUsersENT;
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
public static void CheckProperty4Condition(this clsvQxUsersEN objvQxUsersEN)
{
 clsvQxUsersBL.vQxUsersDA.CheckProperty4Condition(objvQxUsersEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUsersEN objvQxUsersCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUsersCond.IsUpdated(convQxUsers.UserId) == true)
{
string strComparisonOpUserId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UserId, objvQxUsersCond.UserId, strComparisonOpUserId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.UserName) == true)
{
string strComparisonOpUserName = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UserName, objvQxUsersCond.UserName, strComparisonOpUserName);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.UserStateId) == true)
{
string strComparisonOpUserStateId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UserStateId, objvQxUsersCond.UserStateId, strComparisonOpUserStateId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.Memo) == true)
{
string strComparisonOpMemo = objvQxUsersCond.dicFldComparisonOp[convQxUsers.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.Memo, objvQxUsersCond.Memo, strComparisonOpMemo);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.UserStateName) == true)
{
string strComparisonOpUserStateName = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UserStateName, objvQxUsersCond.UserStateName, strComparisonOpUserStateName);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.DepartmentId, objvQxUsersCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.UpDepartmentId) == true)
{
string strComparisonOpUpDepartmentId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UpDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UpDepartmentId, objvQxUsersCond.UpDepartmentId, strComparisonOpUpDepartmentId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxUsersCond.dicFldComparisonOp[convQxUsers.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.DepartmentName, objvQxUsersCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.UpDepartmentName) == true)
{
string strComparisonOpUpDepartmentName = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UpDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UpDepartmentName, objvQxUsersCond.UpDepartmentName, strComparisonOpUpDepartmentName);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.DepartmentTypeName) == true)
{
string strComparisonOpDepartmentTypeName = objvQxUsersCond.dicFldComparisonOp[convQxUsers.DepartmentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.DepartmentTypeName, objvQxUsersCond.DepartmentTypeName, strComparisonOpDepartmentTypeName);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.DepartmentTypeId) == true)
{
string strComparisonOpDepartmentTypeId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.DepartmentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.DepartmentTypeId, objvQxUsersCond.DepartmentTypeId, strComparisonOpDepartmentTypeId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.DepartmentAbbrName) == true)
{
string strComparisonOpDepartmentAbbrName = objvQxUsersCond.dicFldComparisonOp[convQxUsers.DepartmentAbbrName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.DepartmentAbbrName, objvQxUsersCond.DepartmentAbbrName, strComparisonOpDepartmentAbbrName);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UpdDate, objvQxUsersCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UpdUser, objvQxUsersCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.EffitiveBeginDate) == true)
{
string strComparisonOpEffitiveBeginDate = objvQxUsersCond.dicFldComparisonOp[convQxUsers.EffitiveBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.EffitiveBeginDate, objvQxUsersCond.EffitiveBeginDate, strComparisonOpEffitiveBeginDate);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.EffitiveEndDate) == true)
{
string strComparisonOpEffitiveEndDate = objvQxUsersCond.dicFldComparisonOp[convQxUsers.EffitiveEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.EffitiveEndDate, objvQxUsersCond.EffitiveEndDate, strComparisonOpEffitiveEndDate);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.StuTeacherId) == true)
{
string strComparisonOpStuTeacherId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.StuTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.StuTeacherId, objvQxUsersCond.StuTeacherId, strComparisonOpStuTeacherId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.IdentityId) == true)
{
string strComparisonOpIdentityId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.IdentityId, objvQxUsersCond.IdentityId, strComparisonOpIdentityId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.Password) == true)
{
string strComparisonOpPassword = objvQxUsersCond.dicFldComparisonOp[convQxUsers.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.Password, objvQxUsersCond.Password, strComparisonOpPassword);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvQxUsersCond.dicFldComparisonOp[convQxUsers.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.IdentityDesc, objvQxUsersCond.IdentityDesc, strComparisonOpIdentityDesc);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.IsSynch) == true)
{
if (objvQxUsersCond.IsSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxUsers.IsSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxUsers.IsSynch);
}
}
if (objvQxUsersCond.IsUpdated(convQxUsers.SynchDate) == true)
{
string strComparisonOpSynchDate = objvQxUsersCond.dicFldComparisonOp[convQxUsers.SynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.SynchDate, objvQxUsersCond.SynchDate, strComparisonOpSynchDate);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.OpenId) == true)
{
string strComparisonOpOpenId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.OpenId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.OpenId, objvQxUsersCond.OpenId, strComparisonOpOpenId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.CollegeName) == true)
{
string strComparisonOpCollegeName = objvQxUsersCond.dicFldComparisonOp[convQxUsers.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.CollegeName, objvQxUsersCond.CollegeName, strComparisonOpCollegeName);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvQxUsersCond.dicFldComparisonOp[convQxUsers.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.IdXzCollege, objvQxUsersCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.Email) == true)
{
string strComparisonOpEmail = objvQxUsersCond.dicFldComparisonOp[convQxUsers.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.Email, objvQxUsersCond.Email, strComparisonOpEmail);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxUsers
{
public virtual bool UpdRelaTabDate(string strUserId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vQx用户(vQxUsers)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxUsersBL
{
public static RelatedActions_vQxUsers relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxUsersDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxUsersDA vQxUsersDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxUsersDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxUsersBL()
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
if (string.IsNullOrEmpty(clsvQxUsersEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUsersEN._ConnectString);
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
public static DataTable GetDataTable_vQxUsers(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxUsersDA.GetDataTable_vQxUsers(strWhereCond);
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
objDT = vQxUsersDA.GetDataTable(strWhereCond);
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
objDT = vQxUsersDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxUsersDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxUsersDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxUsersDA.GetDataTable_Top(objTopPara);
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
objDT = vQxUsersDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxUsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxUsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvQxUsersEN> GetObjLstByUserIdLst(List<string> arrUserIdLst)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
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
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名称
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改人
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份Id
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信OpenId
objvQxUsersEN.CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(); //学院名称
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUsersEN.Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim(); //电子邮箱
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxUsersEN> GetObjLstByUserIdLstCache(List<string> arrUserIdLst)
{
string strKey = string.Format("{0}", clsvQxUsersEN._CurrTabName);
List<clsvQxUsersEN> arrvQxUsersObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsersEN> arrvQxUsersObjLst_Sel =
arrvQxUsersObjLstCache
.Where(x => arrUserIdLst.Contains(x.UserId));
return arrvQxUsersObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsersEN> GetObjLst(string strWhereCond)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名称
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改人
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份Id
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信OpenId
objvQxUsersEN.CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(); //学院名称
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUsersEN.Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim(); //电子邮箱
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
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
public static List<clsvQxUsersEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名称
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改人
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份Id
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信OpenId
objvQxUsersEN.CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(); //学院名称
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUsersEN.Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim(); //电子邮箱
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxUsersCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxUsersEN> GetSubObjLstCache(clsvQxUsersEN objvQxUsersCond)
{
List<clsvQxUsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUsers.AttributeName)
{
if (objvQxUsersCond.IsUpdated(strFldName) == false) continue;
if (objvQxUsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsersCond[strFldName].ToString());
}
else
{
if (objvQxUsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUsersCond[strFldName]));
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
public static List<clsvQxUsersEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名称
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改人
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份Id
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信OpenId
objvQxUsersEN.CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(); //学院名称
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUsersEN.Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim(); //电子邮箱
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
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
public static List<clsvQxUsersEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名称
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改人
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份Id
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信OpenId
objvQxUsersEN.CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(); //学院名称
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUsersEN.Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim(); //电子邮箱
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
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
List<clsvQxUsersEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxUsersEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsersEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxUsersEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
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
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名称
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改人
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份Id
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信OpenId
objvQxUsersEN.CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(); //学院名称
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUsersEN.Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim(); //电子邮箱
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
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
public static List<clsvQxUsersEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名称
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改人
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份Id
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信OpenId
objvQxUsersEN.CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(); //学院名称
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUsersEN.Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim(); //电子邮箱
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxUsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxUsersEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名称
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改人
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份Id
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信OpenId
objvQxUsersEN.CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(); //学院名称
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUsersEN.Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim(); //电子邮箱
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
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
public static List<clsvQxUsersEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名称
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改人
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份Id
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信OpenId
objvQxUsersEN.CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(); //学院名称
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUsersEN.Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim(); //电子邮箱
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsersEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名称
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改人
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份Id
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信OpenId
objvQxUsersEN.CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(); //学院名称
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUsersEN.Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim(); //电子邮箱
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxUsersEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUsers(ref clsvQxUsersEN objvQxUsersEN)
{
bool bolResult = vQxUsersDA.GetvQxUsers(ref objvQxUsersEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUsersEN GetObjByUserId(string strUserId)
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
clsvQxUsersEN objvQxUsersEN = vQxUsersDA.GetObjByUserId(strUserId);
return objvQxUsersEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxUsersEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxUsersEN objvQxUsersEN = vQxUsersDA.GetFirstObj(strWhereCond);
 return objvQxUsersEN;
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
public static clsvQxUsersEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxUsersEN objvQxUsersEN = vQxUsersDA.GetObjByDataRow(objRow);
 return objvQxUsersEN;
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
public static clsvQxUsersEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxUsersEN objvQxUsersEN = vQxUsersDA.GetObjByDataRow(objRow);
 return objvQxUsersEN;
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
 /// <param name = "lstvQxUsersObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUsersEN GetObjByUserIdFromList(string strUserId, List<clsvQxUsersEN> lstvQxUsersObjLst)
{
foreach (clsvQxUsersEN objvQxUsersEN in lstvQxUsersObjLst)
{
if (objvQxUsersEN.UserId == strUserId)
{
return objvQxUsersEN;
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
 strUserId = new clsvQxUsersDA().GetFirstID(strWhereCond);
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
 arrList = vQxUsersDA.GetID(strWhereCond);
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
bool bolIsExist = vQxUsersDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxUsersDA.IsExist(strUserId);
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
 bolIsExist = clsvQxUsersDA.IsExistTable();
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
 bolIsExist = vQxUsersDA.IsExistTable(strTabName);
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
objvQxUsersENT.UpdDate = objvQxUsersENS.UpdDate; //修改日期
objvQxUsersENT.UpdUser = objvQxUsersENS.UpdUser; //修改人
objvQxUsersENT.EffitiveBeginDate = objvQxUsersENS.EffitiveBeginDate; //有效开始日期
objvQxUsersENT.EffitiveEndDate = objvQxUsersENS.EffitiveEndDate; //有效结束日期
objvQxUsersENT.StuTeacherId = objvQxUsersENS.StuTeacherId; //学工号
objvQxUsersENT.IdentityId = objvQxUsersENS.IdentityId; //身份Id
objvQxUsersENT.Password = objvQxUsersENS.Password; //口令
objvQxUsersENT.IdentityDesc = objvQxUsersENS.IdentityDesc; //身份描述
objvQxUsersENT.IsSynch = objvQxUsersENS.IsSynch; //是否同步
objvQxUsersENT.SynchDate = objvQxUsersENS.SynchDate; //同步日期
objvQxUsersENT.OpenId = objvQxUsersENS.OpenId; //微信OpenId
objvQxUsersENT.CollegeName = objvQxUsersENS.CollegeName; //学院名称
objvQxUsersENT.IdXzCollege = objvQxUsersENS.IdXzCollege; //学院流水号
objvQxUsersENT.Email = objvQxUsersENS.Email; //电子邮箱
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
 /// <param name = "objvQxUsersEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxUsersEN objvQxUsersEN)
{
try
{
objvQxUsersEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxUsersEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxUsers.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UserId = objvQxUsersEN.UserId; //用户ID
}
if (arrFldSet.Contains(convQxUsers.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UserName = objvQxUsersEN.UserName; //用户名
}
if (arrFldSet.Contains(convQxUsers.UserStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UserStateId = objvQxUsersEN.UserStateId; //用户状态Id
}
if (arrFldSet.Contains(convQxUsers.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.Memo = objvQxUsersEN.Memo == "[null]" ? null :  objvQxUsersEN.Memo; //备注
}
if (arrFldSet.Contains(convQxUsers.UserStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UserStateName = objvQxUsersEN.UserStateName == "[null]" ? null :  objvQxUsersEN.UserStateName; //用户状态名
}
if (arrFldSet.Contains(convQxUsers.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.DepartmentId = objvQxUsersEN.DepartmentId == "[null]" ? null :  objvQxUsersEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(convQxUsers.UpDepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UpDepartmentId = objvQxUsersEN.UpDepartmentId == "[null]" ? null :  objvQxUsersEN.UpDepartmentId; //UpDepartmentId
}
if (arrFldSet.Contains(convQxUsers.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.DepartmentName = objvQxUsersEN.DepartmentName == "[null]" ? null :  objvQxUsersEN.DepartmentName; //部门名称
}
if (arrFldSet.Contains(convQxUsers.UpDepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UpDepartmentName = objvQxUsersEN.UpDepartmentName == "[null]" ? null :  objvQxUsersEN.UpDepartmentName; //UpDepartmentName
}
if (arrFldSet.Contains(convQxUsers.DepartmentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.DepartmentTypeName = objvQxUsersEN.DepartmentTypeName == "[null]" ? null :  objvQxUsersEN.DepartmentTypeName; //DepartmentTypeName
}
if (arrFldSet.Contains(convQxUsers.DepartmentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.DepartmentTypeId = objvQxUsersEN.DepartmentTypeId == "[null]" ? null :  objvQxUsersEN.DepartmentTypeId; //DepartmentTypeId
}
if (arrFldSet.Contains(convQxUsers.DepartmentAbbrName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.DepartmentAbbrName = objvQxUsersEN.DepartmentAbbrName == "[null]" ? null :  objvQxUsersEN.DepartmentAbbrName; //DepartmentAbbrName
}
if (arrFldSet.Contains(convQxUsers.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UpdDate = objvQxUsersEN.UpdDate == "[null]" ? null :  objvQxUsersEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxUsers.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UpdUser = objvQxUsersEN.UpdUser == "[null]" ? null :  objvQxUsersEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convQxUsers.EffitiveBeginDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.EffitiveBeginDate = objvQxUsersEN.EffitiveBeginDate; //有效开始日期
}
if (arrFldSet.Contains(convQxUsers.EffitiveEndDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.EffitiveEndDate = objvQxUsersEN.EffitiveEndDate; //有效结束日期
}
if (arrFldSet.Contains(convQxUsers.StuTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.StuTeacherId = objvQxUsersEN.StuTeacherId; //学工号
}
if (arrFldSet.Contains(convQxUsers.IdentityId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.IdentityId = objvQxUsersEN.IdentityId == "[null]" ? null :  objvQxUsersEN.IdentityId; //身份Id
}
if (arrFldSet.Contains(convQxUsers.Password, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.Password = objvQxUsersEN.Password == "[null]" ? null :  objvQxUsersEN.Password; //口令
}
if (arrFldSet.Contains(convQxUsers.IdentityDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.IdentityDesc = objvQxUsersEN.IdentityDesc == "[null]" ? null :  objvQxUsersEN.IdentityDesc; //身份描述
}
if (arrFldSet.Contains(convQxUsers.IsSynch, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.IsSynch = objvQxUsersEN.IsSynch; //是否同步
}
if (arrFldSet.Contains(convQxUsers.SynchDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.SynchDate = objvQxUsersEN.SynchDate == "[null]" ? null :  objvQxUsersEN.SynchDate; //同步日期
}
if (arrFldSet.Contains(convQxUsers.OpenId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.OpenId = objvQxUsersEN.OpenId == "[null]" ? null :  objvQxUsersEN.OpenId; //微信OpenId
}
if (arrFldSet.Contains(convQxUsers.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.CollegeName = objvQxUsersEN.CollegeName == "[null]" ? null :  objvQxUsersEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convQxUsers.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.IdXzCollege = objvQxUsersEN.IdXzCollege == "[null]" ? null :  objvQxUsersEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convQxUsers.Email, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.Email = objvQxUsersEN.Email == "[null]" ? null :  objvQxUsersEN.Email; //电子邮箱
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
 /// <param name = "objvQxUsersEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxUsersEN objvQxUsersEN)
{
try
{
if (objvQxUsersEN.Memo == "[null]") objvQxUsersEN.Memo = null; //备注
if (objvQxUsersEN.UserStateName == "[null]") objvQxUsersEN.UserStateName = null; //用户状态名
if (objvQxUsersEN.DepartmentId == "[null]") objvQxUsersEN.DepartmentId = null; //部门Id
if (objvQxUsersEN.UpDepartmentId == "[null]") objvQxUsersEN.UpDepartmentId = null; //UpDepartmentId
if (objvQxUsersEN.DepartmentName == "[null]") objvQxUsersEN.DepartmentName = null; //部门名称
if (objvQxUsersEN.UpDepartmentName == "[null]") objvQxUsersEN.UpDepartmentName = null; //UpDepartmentName
if (objvQxUsersEN.DepartmentTypeName == "[null]") objvQxUsersEN.DepartmentTypeName = null; //DepartmentTypeName
if (objvQxUsersEN.DepartmentTypeId == "[null]") objvQxUsersEN.DepartmentTypeId = null; //DepartmentTypeId
if (objvQxUsersEN.DepartmentAbbrName == "[null]") objvQxUsersEN.DepartmentAbbrName = null; //DepartmentAbbrName
if (objvQxUsersEN.UpdDate == "[null]") objvQxUsersEN.UpdDate = null; //修改日期
if (objvQxUsersEN.UpdUser == "[null]") objvQxUsersEN.UpdUser = null; //修改人
if (objvQxUsersEN.IdentityId == "[null]") objvQxUsersEN.IdentityId = null; //身份Id
if (objvQxUsersEN.Password == "[null]") objvQxUsersEN.Password = null; //口令
if (objvQxUsersEN.IdentityDesc == "[null]") objvQxUsersEN.IdentityDesc = null; //身份描述
if (objvQxUsersEN.SynchDate == "[null]") objvQxUsersEN.SynchDate = null; //同步日期
if (objvQxUsersEN.OpenId == "[null]") objvQxUsersEN.OpenId = null; //微信OpenId
if (objvQxUsersEN.CollegeName == "[null]") objvQxUsersEN.CollegeName = null; //学院名称
if (objvQxUsersEN.IdXzCollege == "[null]") objvQxUsersEN.IdXzCollege = null; //学院流水号
if (objvQxUsersEN.Email == "[null]") objvQxUsersEN.Email = null; //电子邮箱
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
public static void CheckProperty4Condition(clsvQxUsersEN objvQxUsersEN)
{
 vQxUsersDA.CheckProperty4Condition(objvQxUsersEN);
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
if (clsQxUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUsersBL没有刷新缓存机制(clsQxUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserIdentityBL没有刷新缓存机制(clsQxUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserStateBL没有刷新缓存机制(clsQxUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxDepartmentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxDepartmentInfoBL没有刷新缓存机制(clsQxDepartmentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxDepartmentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxDepartmentTypeBL没有刷新缓存机制(clsQxDepartmentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserId");
//if (arrvQxUsersObjLstCache == null)
//{
//arrvQxUsersObjLstCache = vQxUsersDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUsersEN GetObjByUserIdCache(string strUserId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxUsersEN._CurrTabName);
List<clsvQxUsersEN> arrvQxUsersObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsersEN> arrvQxUsersObjLst_Sel =
arrvQxUsersObjLstCache
.Where(x=> x.UserId == strUserId 
);
if (arrvQxUsersObjLst_Sel.Count() == 0)
{
   clsvQxUsersEN obj = clsvQxUsersBL.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxUsersObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUsersEN> GetAllvQxUsersObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxUsersEN> arrvQxUsersObjLstCache = GetObjLstCache(); 
return arrvQxUsersObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUsersEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxUsersEN._CurrTabName);
List<clsvQxUsersEN> arrvQxUsersObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxUsersObjLstCache;
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
string strKey = string.Format("{0}", clsvQxUsersEN._CurrTabName);
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
 /// 日期:2024-05-19
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strUserId)
{
if (strInFldName != convQxUsers.UserId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxUsers.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxUsers.AttributeName));
throw new Exception(strMsg);
}
var objvQxUsers = clsvQxUsersBL.GetObjByUserIdCache(strUserId);
if (objvQxUsers == null) return "";
return objvQxUsers[strOutFldName].ToString();
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
int intRecCount = clsvQxUsersDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxUsersDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxUsersDA.GetRecCount();
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
int intRecCount = clsvQxUsersDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxUsersCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxUsersEN objvQxUsersCond)
{
List<clsvQxUsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUsers.AttributeName)
{
if (objvQxUsersCond.IsUpdated(strFldName) == false) continue;
if (objvQxUsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsersCond[strFldName].ToString());
}
else
{
if (objvQxUsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUsersCond[strFldName]));
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
 List<string> arrList = clsvQxUsersDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxUsersDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxUsersDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}