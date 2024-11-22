
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsersWApi
 表名:QxUsers(01120258)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:26
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
public static class clsQxUsersWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetUserId(this clsQxUsersEN objQxUsersEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, conQxUsers.UserId);
objQxUsersEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.UserId) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.UserId, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.UserId] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetUserName(this clsQxUsersEN objQxUsersEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, conQxUsers.UserName);
clsCheckSql.CheckFieldLen(strUserName, 50, conQxUsers.UserName);
objQxUsersEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.UserName) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.UserName, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.UserName] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetDepartmentId(this clsQxUsersEN objQxUsersEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, conQxUsers.DepartmentId);
objQxUsersEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.DepartmentId) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.DepartmentId, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.DepartmentId] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN Setid_XzCollege(this clsQxUsersEN objQxUsersEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conQxUsers.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conQxUsers.id_XzCollege);
objQxUsersEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.id_XzCollege) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.id_XzCollege, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.id_XzCollege] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetUserStateId(this clsQxUsersEN objQxUsersEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, conQxUsers.UserStateId);
clsCheckSql.CheckFieldLen(strUserStateId, 2, conQxUsers.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, conQxUsers.UserStateId);
objQxUsersEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.UserStateId) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.UserStateId, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.UserStateId] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN Setid_GradeBase(this clsQxUsersEN objQxUsersEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, conQxUsers.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, conQxUsers.id_GradeBase);
objQxUsersEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.id_GradeBase) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.id_GradeBase, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.id_GradeBase] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetCard_State(this clsQxUsersEN objQxUsersEN, string strCard_State, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCard_State, 10, conQxUsers.Card_State);
objQxUsersEN.Card_State = strCard_State; //Card_State
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.Card_State) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.Card_State, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.Card_State] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetIsLeaved(this clsQxUsersEN objQxUsersEN, bool bolIsLeaved, string strComparisonOp="")
	{
objQxUsersEN.IsLeaved = bolIsLeaved; //IsLeaved
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.IsLeaved) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.IsLeaved, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.IsLeaved] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetCardNo(this clsQxUsersEN objQxUsersEN, string strCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCardNo, 18, conQxUsers.CardNo);
objQxUsersEN.CardNo = strCardNo; //卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.CardNo) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.CardNo, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.CardNo] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetBeginYearMonth(this clsQxUsersEN objQxUsersEN, string strBeginYearMonth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBeginYearMonth, 8, conQxUsers.BeginYearMonth);
objQxUsersEN.BeginYearMonth = strBeginYearMonth; //开始年月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.BeginYearMonth) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.BeginYearMonth, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.BeginYearMonth] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetEndYearMonth(this clsQxUsersEN objQxUsersEN, string strEndYearMonth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEndYearMonth, 8, conQxUsers.EndYearMonth);
objQxUsersEN.EndYearMonth = strEndYearMonth; //结束年月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.EndYearMonth) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.EndYearMonth, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.EndYearMonth] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetOptUser(this clsQxUsersEN objQxUsersEN, string strOptUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptUser, 20, conQxUsers.OptUser);
objQxUsersEN.OptUser = strOptUser; //OptUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.OptUser) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.OptUser, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.OptUser] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetOptDate(this clsQxUsersEN objQxUsersEN, string strOptDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptDate, 20, conQxUsers.OptDate);
objQxUsersEN.OptDate = strOptDate; //OptDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.OptDate) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.OptDate, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.OptDate] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetMemo(this clsQxUsersEN objQxUsersEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUsers.Memo);
objQxUsersEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.Memo) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.Memo, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.Memo] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetPassword(this clsQxUsersEN objQxUsersEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPassword, 20, conQxUsers.Password);
objQxUsersEN.Password = strPassword; //Password
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.Password) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.Password, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.Password] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetIsGpUser(this clsQxUsersEN objQxUsersEN, bool bolIsGpUser, string strComparisonOp="")
	{
objQxUsersEN.IsGpUser = bolIsGpUser; //是否Gp用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.IsGpUser) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.IsGpUser, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.IsGpUser] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetSchoolID1(this clsQxUsersEN objQxUsersEN, string strSchoolID1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolID1, 4, conQxUsers.SchoolID1);
objQxUsersEN.SchoolID1 = strSchoolID1; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.SchoolID1) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.SchoolID1, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.SchoolID1] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetAvatarsPicture(this clsQxUsersEN objQxUsersEN, string strAvatarsPicture, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAvatarsPicture, 100, conQxUsers.AvatarsPicture);
objQxUsersEN.AvatarsPicture = strAvatarsPicture; //AvatarsPicture
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.AvatarsPicture) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.AvatarsPicture, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.AvatarsPicture] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetEmail(this clsQxUsersEN objQxUsersEN, string strEmail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEmail, 100, conQxUsers.Email);
objQxUsersEN.Email = strEmail; //电子邮箱
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.Email) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.Email, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.Email] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetPhoneNumber(this clsQxUsersEN objQxUsersEN, string strPhoneNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, conQxUsers.PhoneNumber);
objQxUsersEN.PhoneNumber = strPhoneNumber; //PhoneNumber
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.PhoneNumber) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.PhoneNumber, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.PhoneNumber] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetEffectiveDate(this clsQxUsersEN objQxUsersEN, string strEffectiveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEffectiveDate, 8, conQxUsers.EffectiveDate);
objQxUsersEN.EffectiveDate = strEffectiveDate; //EffectiveDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.EffectiveDate) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.EffectiveDate, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.EffectiveDate] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetUpdDate(this clsQxUsersEN objQxUsersEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxUsers.UpdDate);
objQxUsersEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.UpdDate) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.UpdDate, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.UpdDate] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetUpdUser(this clsQxUsersEN objQxUsersEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQxUsers.UpdUser);
objQxUsersEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.UpdUser) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.UpdUser, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.UpdUser] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetEffitiveBeginDate(this clsQxUsersEN objQxUsersEN, string strEffitiveBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveBeginDate, conQxUsers.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, conQxUsers.EffitiveBeginDate);
objQxUsersEN.EffitiveBeginDate = strEffitiveBeginDate; //EffitiveBeginDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.EffitiveBeginDate) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.EffitiveBeginDate, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.EffitiveBeginDate] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetEffitiveEndDate(this clsQxUsersEN objQxUsersEN, string strEffitiveEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveEndDate, conQxUsers.EffitiveEndDate);
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, conQxUsers.EffitiveEndDate);
objQxUsersEN.EffitiveEndDate = strEffitiveEndDate; //EffitiveEndDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.EffitiveEndDate) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.EffitiveEndDate, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.EffitiveEndDate] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN Setid_College(this clsQxUsersEN objQxUsersEN, string strid_College, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_College, conQxUsers.id_College);
clsCheckSql.CheckFieldLen(strid_College, 4, conQxUsers.id_College);
clsCheckSql.CheckFieldForeignKey(strid_College, 4, conQxUsers.id_College);
objQxUsersEN.id_College = strid_College; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.id_College) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.id_College, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.id_College] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetStuTeacherID(this clsQxUsersEN objQxUsersEN, string strStuTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuTeacherID, conQxUsers.StuTeacherID);
clsCheckSql.CheckFieldLen(strStuTeacherID, 20, conQxUsers.StuTeacherID);
objQxUsersEN.StuTeacherID = strStuTeacherID; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.StuTeacherID) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.StuTeacherID, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.StuTeacherID] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetIdentityID(this clsQxUsersEN objQxUsersEN, string strIdentityID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityID, 2, conQxUsers.IdentityID);
clsCheckSql.CheckFieldForeignKey(strIdentityID, 2, conQxUsers.IdentityID);
objQxUsersEN.IdentityID = strIdentityID; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.IdentityID) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.IdentityID, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.IdentityID] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetIsArchive(this clsQxUsersEN objQxUsersEN, bool bolIsArchive, string strComparisonOp="")
	{
objQxUsersEN.IsArchive = bolIsArchive; //IsArchive
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.IsArchive) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.IsArchive, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.IsArchive] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetHeadimgUrl(this clsQxUsersEN objQxUsersEN, string strHeadimgUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHeadimgUrl, 1000, conQxUsers.HeadimgUrl);
objQxUsersEN.HeadimgUrl = strHeadimgUrl; //微信头像
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.HeadimgUrl) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.HeadimgUrl, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.HeadimgUrl] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetOpenId(this clsQxUsersEN objQxUsersEN, string strOpenId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpenId, 50, conQxUsers.OpenId);
objQxUsersEN.OpenId = strOpenId; //微信OpenId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.OpenId) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.OpenId, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.OpenId] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetNickName(this clsQxUsersEN objQxUsersEN, string strNickName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNickName, 50, conQxUsers.NickName);
objQxUsersEN.NickName = strNickName; //昵称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.NickName) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.NickName, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.NickName] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetIsSynch(this clsQxUsersEN objQxUsersEN, bool bolIsSynch, string strComparisonOp="")
	{
objQxUsersEN.IsSynch = bolIsSynch; //是否同步
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.IsSynch) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.IsSynch, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.IsSynch] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUsersEN SetSynchDate(this clsQxUsersEN objQxUsersEN, string strSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchDate, 30, conQxUsers.SynchDate);
objQxUsersEN.SynchDate = strSynchDate; //同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.SynchDate) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.SynchDate, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.SynchDate] = strComparisonOp;
}
}
return objQxUsersEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxUsersEN objQxUsers_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxUsers_Cond.IsUpdated(conQxUsers.UserId) == true)
{
string strComparisonOp_UserId = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.UserId, objQxUsers_Cond.UserId, strComparisonOp_UserId);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.UserName) == true)
{
string strComparisonOp_UserName = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.UserName, objQxUsers_Cond.UserName, strComparisonOp_UserName);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.DepartmentId) == true)
{
string strComparisonOp_DepartmentId = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.DepartmentId, objQxUsers_Cond.DepartmentId, strComparisonOp_DepartmentId);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.id_XzCollege, objQxUsers_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.UserStateId) == true)
{
string strComparisonOp_UserStateId = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.UserStateId, objQxUsers_Cond.UserStateId, strComparisonOp_UserStateId);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.id_GradeBase, objQxUsers_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.Card_State) == true)
{
string strComparisonOp_Card_State = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.Card_State];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.Card_State, objQxUsers_Cond.Card_State, strComparisonOp_Card_State);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.IsLeaved) == true)
{
if (objQxUsers_Cond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUsers.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUsers.IsLeaved);
}
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.CardNo) == true)
{
string strComparisonOp_CardNo = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.CardNo, objQxUsers_Cond.CardNo, strComparisonOp_CardNo);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.BeginYearMonth) == true)
{
string strComparisonOp_BeginYearMonth = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.BeginYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.BeginYearMonth, objQxUsers_Cond.BeginYearMonth, strComparisonOp_BeginYearMonth);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.EndYearMonth) == true)
{
string strComparisonOp_EndYearMonth = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.EndYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.EndYearMonth, objQxUsers_Cond.EndYearMonth, strComparisonOp_EndYearMonth);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.OptUser) == true)
{
string strComparisonOp_OptUser = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.OptUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.OptUser, objQxUsers_Cond.OptUser, strComparisonOp_OptUser);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.OptDate) == true)
{
string strComparisonOp_OptDate = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.OptDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.OptDate, objQxUsers_Cond.OptDate, strComparisonOp_OptDate);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.Memo) == true)
{
string strComparisonOp_Memo = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.Memo, objQxUsers_Cond.Memo, strComparisonOp_Memo);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.Password) == true)
{
string strComparisonOp_Password = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.Password, objQxUsers_Cond.Password, strComparisonOp_Password);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.IsGpUser) == true)
{
if (objQxUsers_Cond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUsers.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUsers.IsGpUser);
}
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.SchoolID1) == true)
{
string strComparisonOp_SchoolID1 = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.SchoolID1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.SchoolID1, objQxUsers_Cond.SchoolID1, strComparisonOp_SchoolID1);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.AvatarsPicture) == true)
{
string strComparisonOp_AvatarsPicture = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.AvatarsPicture];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.AvatarsPicture, objQxUsers_Cond.AvatarsPicture, strComparisonOp_AvatarsPicture);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.Email) == true)
{
string strComparisonOp_Email = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.Email, objQxUsers_Cond.Email, strComparisonOp_Email);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.PhoneNumber) == true)
{
string strComparisonOp_PhoneNumber = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.PhoneNumber, objQxUsers_Cond.PhoneNumber, strComparisonOp_PhoneNumber);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.EffectiveDate) == true)
{
string strComparisonOp_EffectiveDate = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.EffectiveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.EffectiveDate, objQxUsers_Cond.EffectiveDate, strComparisonOp_EffectiveDate);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.UpdDate) == true)
{
string strComparisonOp_UpdDate = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.UpdDate, objQxUsers_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.UpdUser) == true)
{
string strComparisonOp_UpdUser = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.UpdUser, objQxUsers_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.EffitiveBeginDate) == true)
{
string strComparisonOp_EffitiveBeginDate = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.EffitiveBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.EffitiveBeginDate, objQxUsers_Cond.EffitiveBeginDate, strComparisonOp_EffitiveBeginDate);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.EffitiveEndDate) == true)
{
string strComparisonOp_EffitiveEndDate = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.EffitiveEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.EffitiveEndDate, objQxUsers_Cond.EffitiveEndDate, strComparisonOp_EffitiveEndDate);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.id_College) == true)
{
string strComparisonOp_id_College = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.id_College];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.id_College, objQxUsers_Cond.id_College, strComparisonOp_id_College);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.StuTeacherID) == true)
{
string strComparisonOp_StuTeacherID = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.StuTeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.StuTeacherID, objQxUsers_Cond.StuTeacherID, strComparisonOp_StuTeacherID);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.IdentityID) == true)
{
string strComparisonOp_IdentityID = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.IdentityID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.IdentityID, objQxUsers_Cond.IdentityID, strComparisonOp_IdentityID);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.IsArchive) == true)
{
if (objQxUsers_Cond.IsArchive == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUsers.IsArchive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUsers.IsArchive);
}
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.HeadimgUrl) == true)
{
string strComparisonOp_HeadimgUrl = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.HeadimgUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.HeadimgUrl, objQxUsers_Cond.HeadimgUrl, strComparisonOp_HeadimgUrl);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.OpenId) == true)
{
string strComparisonOp_OpenId = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.OpenId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.OpenId, objQxUsers_Cond.OpenId, strComparisonOp_OpenId);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.NickName) == true)
{
string strComparisonOp_NickName = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.NickName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.NickName, objQxUsers_Cond.NickName, strComparisonOp_NickName);
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.IsSynch) == true)
{
if (objQxUsers_Cond.IsSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUsers.IsSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUsers.IsSynch);
}
}
if (objQxUsers_Cond.IsUpdated(conQxUsers.SynchDate) == true)
{
string strComparisonOp_SynchDate = objQxUsers_Cond.dicFldComparisonOp[conQxUsers.SynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.SynchDate, objQxUsers_Cond.SynchDate, strComparisonOp_SynchDate);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUsersEN objQxUsersEN)
{
 if (string.IsNullOrEmpty(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxUsersEN.sf_UpdFldSetStr = objQxUsersEN.getsf_UpdFldSetStr();
clsQxUsersWApi.CheckPropertyNew(objQxUsersEN); 
bool bolResult = clsQxUsersWApi.UpdateRecord(objQxUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersWApi.ReFreshCache();
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
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUsersEN objQxUsersEN)
{
 if (string.IsNullOrEmpty(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxUsersWApi.IsExist(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objQxUsersEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsQxUsersWApi.CheckPropertyNew(objQxUsersEN); 
bool bolResult = clsQxUsersWApi.AddNewRecord(objQxUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersWApi.ReFreshCache();
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
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxUsersEN objQxUsersEN)
{
try
{
clsQxUsersWApi.CheckPropertyNew(objQxUsersEN); 
string strUserId = clsQxUsersWApi.AddNewRecordWithMaxId(objQxUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersWApi.ReFreshCache();
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
 /// <param name = "objQxUsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUsersEN objQxUsersEN, string strWhereCond)
{
try
{
clsQxUsersWApi.CheckPropertyNew(objQxUsersEN); 
bool bolResult = clsQxUsersWApi.UpdateWithCondition(objQxUsersEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersWApi.ReFreshCache();
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
 /// Qx用户(QxUsers)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUsersWApi
{
private static readonly string mstrApiControllerName = "QxUsersApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsQxUsersWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxUsersEN objQxUsersEN)
{
if (!Object.Equals(null, objQxUsersEN.UserId) && GetStrLen(objQxUsersEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersEN.UserName) && GetStrLen(objQxUsersEN.UserName) > 50)
{
 throw new Exception("字段[用户名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxUsersEN.DepartmentId) && GetStrLen(objQxUsersEN.DepartmentId) > 8)
{
 throw new Exception("字段[部门Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUsersEN.id_XzCollege) && GetStrLen(objQxUsersEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUsersEN.UserStateId) && GetStrLen(objQxUsersEN.UserStateId) > 2)
{
 throw new Exception("字段[用户状态Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQxUsersEN.id_GradeBase) && GetStrLen(objQxUsersEN.id_GradeBase) > 4)
{
 throw new Exception("字段[年级流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUsersEN.Card_State) && GetStrLen(objQxUsersEN.Card_State) > 10)
{
 throw new Exception("字段[Card_State]的长度不能超过10!");
}
if (!Object.Equals(null, objQxUsersEN.CardNo) && GetStrLen(objQxUsersEN.CardNo) > 18)
{
 throw new Exception("字段[卡号]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUsersEN.BeginYearMonth) && GetStrLen(objQxUsersEN.BeginYearMonth) > 8)
{
 throw new Exception("字段[开始年月]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUsersEN.EndYearMonth) && GetStrLen(objQxUsersEN.EndYearMonth) > 8)
{
 throw new Exception("字段[结束年月]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUsersEN.OptUser) && GetStrLen(objQxUsersEN.OptUser) > 20)
{
 throw new Exception("字段[OptUser]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersEN.OptDate) && GetStrLen(objQxUsersEN.OptDate) > 20)
{
 throw new Exception("字段[OptDate]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersEN.Memo) && GetStrLen(objQxUsersEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objQxUsersEN.Password) && GetStrLen(objQxUsersEN.Password) > 20)
{
 throw new Exception("字段[Password]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersEN.SchoolID1) && GetStrLen(objQxUsersEN.SchoolID1) > 4)
{
 throw new Exception("字段[学校编号]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUsersEN.AvatarsPicture) && GetStrLen(objQxUsersEN.AvatarsPicture) > 100)
{
 throw new Exception("字段[AvatarsPicture]的长度不能超过100!");
}
if (!Object.Equals(null, objQxUsersEN.Email) && GetStrLen(objQxUsersEN.Email) > 100)
{
 throw new Exception("字段[电子邮箱]的长度不能超过100!");
}
if (!Object.Equals(null, objQxUsersEN.PhoneNumber) && GetStrLen(objQxUsersEN.PhoneNumber) > 15)
{
 throw new Exception("字段[PhoneNumber]的长度不能超过15!");
}
if (!Object.Equals(null, objQxUsersEN.EffectiveDate) && GetStrLen(objQxUsersEN.EffectiveDate) > 8)
{
 throw new Exception("字段[EffectiveDate]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUsersEN.UpdDate) && GetStrLen(objQxUsersEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersEN.UpdUser) && GetStrLen(objQxUsersEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersEN.EffitiveBeginDate) && GetStrLen(objQxUsersEN.EffitiveBeginDate) > 14)
{
 throw new Exception("字段[EffitiveBeginDate]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsersEN.EffitiveEndDate) && GetStrLen(objQxUsersEN.EffitiveEndDate) > 14)
{
 throw new Exception("字段[EffitiveEndDate]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsersEN.id_College) && GetStrLen(objQxUsersEN.id_College) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUsersEN.StuTeacherID) && GetStrLen(objQxUsersEN.StuTeacherID) > 20)
{
 throw new Exception("字段[学工号]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersEN.IdentityID) && GetStrLen(objQxUsersEN.IdentityID) > 2)
{
 throw new Exception("字段[身份编号]的长度不能超过2!");
}
if (!Object.Equals(null, objQxUsersEN.HeadimgUrl) && GetStrLen(objQxUsersEN.HeadimgUrl) > 1000)
{
 throw new Exception("字段[微信头像]的长度不能超过1000!");
}
if (!Object.Equals(null, objQxUsersEN.OpenId) && GetStrLen(objQxUsersEN.OpenId) > 50)
{
 throw new Exception("字段[微信OpenId]的长度不能超过50!");
}
if (!Object.Equals(null, objQxUsersEN.NickName) && GetStrLen(objQxUsersEN.NickName) > 50)
{
 throw new Exception("字段[昵称]的长度不能超过50!");
}
if (!Object.Equals(null, objQxUsersEN.SynchDate) && GetStrLen(objQxUsersEN.SynchDate) > 30)
{
 throw new Exception("字段[同步日期]的长度不能超过30!");
}
 objQxUsersEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUsersEN GetObjByUserId(string strUserId)
{
string strAction = "GetObjByUserId";
string strErrMsg = string.Empty;
string strResult = "";
clsQxUsersEN objQxUsersEN = null;
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
objQxUsersEN = JsonConvert.DeserializeObject<clsQxUsersEN>((string)jobjReturn["ReturnObj"]);
return objQxUsersEN;
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
public static clsQxUsersEN GetObjByUserId_WA_Cache(string strUserId)
{
string strAction = "GetObjByUserId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsQxUsersEN objQxUsersEN = null;
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
objQxUsersEN = JsonConvert.DeserializeObject<clsQxUsersEN>((string)jobjReturn["ReturnObj"]);
return objQxUsersEN;
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
public static clsQxUsersEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsQxUsersEN objQxUsersEN = null;
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
objQxUsersEN = JsonConvert.DeserializeObject<clsQxUsersEN>((string)jobjReturn["ReturnObj"]);
return objQxUsersEN;
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
public static clsQxUsersEN GetObjByUserId_Cache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsQxUsersEN._CurrTabName_S);
List<clsQxUsersEN> arrQxUsersObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQxUsersEN> arrQxUsersObjLst_Sel =
from objQxUsersEN in arrQxUsersObjLst_Cache
where objQxUsersEN.UserId == strUserId
select objQxUsersEN;
if (arrQxUsersObjLst_Sel.Count() == 0)
{
   clsQxUsersEN obj = clsQxUsersWApi.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQxUsersObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersEN> GetObjLst(string strWhereCond)
{
 List<clsQxUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQxUsersEN> GetObjLstByUserIdLst(List<string> arrUserId)
{
 List<clsQxUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsQxUsersEN> GetObjLstByUserIdLst_Cache(List<string> arrUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQxUsersEN._CurrTabName_S);
List<clsQxUsersEN> arrQxUsersObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQxUsersEN> arrQxUsersObjLst_Sel =
from objQxUsersEN in arrQxUsersObjLst_Cache
where arrUserId.Contains(objQxUsersEN.UserId)
select objQxUsersEN;
return arrQxUsersObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersEN> GetObjLstByUserIdLst_WA_Cache(List<string> arrUserId)
{
 List<clsQxUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQxUsersEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQxUsersEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQxUsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQxUsersEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsQxUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
 clsQxUsersEN objQxUsersEN = clsQxUsersWApi.GetObjByUserId(strUserId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strUserId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQxUsersWApi.ReFreshCache();
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
public static int DelQxUserss(List<string> arrUserId)
{
string strAction = "DelQxUserss";
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
clsQxUsersWApi.ReFreshCache();
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
public static int DelQxUserssByCond(string strWhereCond)
{
string strAction = "DelQxUserssByCond";
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
public static bool AddNewRecord(clsQxUsersEN objQxUsersEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsersEN>(objQxUsersEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsQxUsersEN objQxUsersEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsersEN>(objQxUsersEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersWApi.ReFreshCache();
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
public static bool UpdateRecord(clsQxUsersEN objQxUsersEN)
{
if (string.IsNullOrEmpty(objQxUsersEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQxUsersEN.UserId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsersEN>(objQxUsersEN);
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
 /// <param name = "objQxUsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxUsersEN objQxUsersEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxUsersEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQxUsersEN.UserId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQxUsersEN.UserId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsersEN>(objQxUsersEN);
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
 /// <param name = "objQxUsersENS">源对象</param>
 /// <param name = "objQxUsersENT">目标对象</param>
 public static void CopyTo(clsQxUsersEN objQxUsersENS, clsQxUsersEN objQxUsersENT)
{
try
{
objQxUsersENT.UserId = objQxUsersENS.UserId; //用户ID
objQxUsersENT.UserName = objQxUsersENS.UserName; //用户名
objQxUsersENT.DepartmentId = objQxUsersENS.DepartmentId; //部门Id
objQxUsersENT.id_XzCollege = objQxUsersENS.id_XzCollege; //学院流水号
objQxUsersENT.UserStateId = objQxUsersENS.UserStateId; //用户状态Id
objQxUsersENT.id_GradeBase = objQxUsersENS.id_GradeBase; //年级流水号
objQxUsersENT.Card_State = objQxUsersENS.Card_State; //Card_State
objQxUsersENT.IsLeaved = objQxUsersENS.IsLeaved; //IsLeaved
objQxUsersENT.CardNo = objQxUsersENS.CardNo; //卡号
objQxUsersENT.BeginYearMonth = objQxUsersENS.BeginYearMonth; //开始年月
objQxUsersENT.EndYearMonth = objQxUsersENS.EndYearMonth; //结束年月
objQxUsersENT.OptUser = objQxUsersENS.OptUser; //OptUser
objQxUsersENT.OptDate = objQxUsersENS.OptDate; //OptDate
objQxUsersENT.Memo = objQxUsersENS.Memo; //备注
objQxUsersENT.Password = objQxUsersENS.Password; //Password
objQxUsersENT.IsGpUser = objQxUsersENS.IsGpUser; //是否Gp用户
objQxUsersENT.SchoolID1 = objQxUsersENS.SchoolID1; //学校编号
objQxUsersENT.AvatarsPicture = objQxUsersENS.AvatarsPicture; //AvatarsPicture
objQxUsersENT.Email = objQxUsersENS.Email; //电子邮箱
objQxUsersENT.PhoneNumber = objQxUsersENS.PhoneNumber; //PhoneNumber
objQxUsersENT.EffectiveDate = objQxUsersENS.EffectiveDate; //EffectiveDate
objQxUsersENT.UpdDate = objQxUsersENS.UpdDate; //修改日期
objQxUsersENT.UpdUser = objQxUsersENS.UpdUser; //修改人
objQxUsersENT.EffitiveBeginDate = objQxUsersENS.EffitiveBeginDate; //EffitiveBeginDate
objQxUsersENT.EffitiveEndDate = objQxUsersENS.EffitiveEndDate; //EffitiveEndDate
objQxUsersENT.id_College = objQxUsersENS.id_College; //学院流水号
objQxUsersENT.StuTeacherID = objQxUsersENS.StuTeacherID; //学工号
objQxUsersENT.IdentityID = objQxUsersENS.IdentityID; //身份编号
objQxUsersENT.IsArchive = objQxUsersENS.IsArchive; //IsArchive
objQxUsersENT.HeadimgUrl = objQxUsersENS.HeadimgUrl; //微信头像
objQxUsersENT.OpenId = objQxUsersENS.OpenId; //微信OpenId
objQxUsersENT.NickName = objQxUsersENS.NickName; //昵称
objQxUsersENT.IsSynch = objQxUsersENS.IsSynch; //是否同步
objQxUsersENT.SynchDate = objQxUsersENS.SynchDate; //同步日期
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
public static DataTable ToDataTable(List<clsQxUsersEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxUsersEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxUsersEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxUsersEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxUsersEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxUsersEN.AttributeName)
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserId");
//if (arrQxUsersObjLst_Cache == null)
//{
//arrQxUsersObjLst_Cache = await clsQxUsersWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsQxUsersEN._CurrTabName_S);
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
if (clsQxUsersWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUsersEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsQxUsersWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUsersEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsQxUsersEN._CurrTabName_S);
List<clsQxUsersEN> arrQxUsersObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxUsersObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxUsersEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxUsers.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.UserName, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.Card_State, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.IsLeaved, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxUsers.CardNo, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.BeginYearMonth, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.EndYearMonth, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.OptUser, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.OptDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.Password, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.IsGpUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxUsers.SchoolID1, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.AvatarsPicture, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.Email, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.PhoneNumber, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.EffectiveDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.EffitiveBeginDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.EffitiveEndDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.id_College, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.StuTeacherID, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.IdentityID, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.IsArchive, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxUsers.HeadimgUrl, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.OpenId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.NickName, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.IsSynch, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxUsers.SynchDate, Type.GetType("System.String"));
foreach (clsQxUsersEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxUsers.UserId] = objInFor[conQxUsers.UserId];
objDR[conQxUsers.UserName] = objInFor[conQxUsers.UserName];
objDR[conQxUsers.DepartmentId] = objInFor[conQxUsers.DepartmentId];
objDR[conQxUsers.id_XzCollege] = objInFor[conQxUsers.id_XzCollege];
objDR[conQxUsers.UserStateId] = objInFor[conQxUsers.UserStateId];
objDR[conQxUsers.id_GradeBase] = objInFor[conQxUsers.id_GradeBase];
objDR[conQxUsers.Card_State] = objInFor[conQxUsers.Card_State];
objDR[conQxUsers.IsLeaved] = objInFor[conQxUsers.IsLeaved];
objDR[conQxUsers.CardNo] = objInFor[conQxUsers.CardNo];
objDR[conQxUsers.BeginYearMonth] = objInFor[conQxUsers.BeginYearMonth];
objDR[conQxUsers.EndYearMonth] = objInFor[conQxUsers.EndYearMonth];
objDR[conQxUsers.OptUser] = objInFor[conQxUsers.OptUser];
objDR[conQxUsers.OptDate] = objInFor[conQxUsers.OptDate];
objDR[conQxUsers.Memo] = objInFor[conQxUsers.Memo];
objDR[conQxUsers.Password] = objInFor[conQxUsers.Password];
objDR[conQxUsers.IsGpUser] = objInFor[conQxUsers.IsGpUser];
objDR[conQxUsers.SchoolID1] = objInFor[conQxUsers.SchoolID1];
objDR[conQxUsers.AvatarsPicture] = objInFor[conQxUsers.AvatarsPicture];
objDR[conQxUsers.Email] = objInFor[conQxUsers.Email];
objDR[conQxUsers.PhoneNumber] = objInFor[conQxUsers.PhoneNumber];
objDR[conQxUsers.EffectiveDate] = objInFor[conQxUsers.EffectiveDate];
objDR[conQxUsers.UpdDate] = objInFor[conQxUsers.UpdDate];
objDR[conQxUsers.UpdUser] = objInFor[conQxUsers.UpdUser];
objDR[conQxUsers.EffitiveBeginDate] = objInFor[conQxUsers.EffitiveBeginDate];
objDR[conQxUsers.EffitiveEndDate] = objInFor[conQxUsers.EffitiveEndDate];
objDR[conQxUsers.id_College] = objInFor[conQxUsers.id_College];
objDR[conQxUsers.StuTeacherID] = objInFor[conQxUsers.StuTeacherID];
objDR[conQxUsers.IdentityID] = objInFor[conQxUsers.IdentityID];
objDR[conQxUsers.IsArchive] = objInFor[conQxUsers.IsArchive];
objDR[conQxUsers.HeadimgUrl] = objInFor[conQxUsers.HeadimgUrl];
objDR[conQxUsers.OpenId] = objInFor[conQxUsers.OpenId];
objDR[conQxUsers.NickName] = objInFor[conQxUsers.NickName];
objDR[conQxUsers.IsSynch] = objInFor[conQxUsers.IsSynch];
objDR[conQxUsers.SynchDate] = objInFor[conQxUsers.SynchDate];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// Qx用户(QxUsers)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4QxUsers : clsCommFun4BL
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
clsQxUsersWApi.ReFreshThisCache();
clsvQxUsersWApi.ReFreshThisCache();
}
}

}