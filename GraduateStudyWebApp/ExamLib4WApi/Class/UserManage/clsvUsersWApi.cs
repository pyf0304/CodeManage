
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsersWApi
 表名:vUsers(01120027)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:28
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
public static class clsvUsersWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetUserId(this clsvUsersEN objvUsersEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convUsers.UserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetUserName(this clsvUsersEN objvUsersEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convUsers.UserName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetUserStateId(this clsvUsersEN objvUsersEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convUsers.UserStateId);
clsCheckSql.CheckFieldLen(strUserStateId, 2, convUsers.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convUsers.UserStateId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetUserStateName(this clsvUsersEN objvUsersEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convUsers.UserStateName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetPassword(this clsvUsersEN objvUsersEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPassword, 20, convUsers.Password);
objvUsersEN.Password = strPassword; //Password
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetIsGpUser(this clsvUsersEN objvUsersEN, bool bolIsGpUser, string strComparisonOp="")
	{
objvUsersEN.IsGpUser = bolIsGpUser; //是否Gp用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IsGpUser) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IsGpUser, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IsGpUser] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetBeginYearMonth(this clsvUsersEN objvUsersEN, string strBeginYearMonth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBeginYearMonth, 8, convUsers.BeginYearMonth);
objvUsersEN.BeginYearMonth = strBeginYearMonth; //开始年月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.BeginYearMonth) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.BeginYearMonth, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.BeginYearMonth] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetEndYearMonth(this clsvUsersEN objvUsersEN, string strEndYearMonth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEndYearMonth, 8, convUsers.EndYearMonth);
objvUsersEN.EndYearMonth = strEndYearMonth; //结束年月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.EndYearMonth) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.EndYearMonth, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.EndYearMonth] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN Setid_GradeBase(this clsvUsersEN objvUsersEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convUsers.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convUsers.id_GradeBase);
objvUsersEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.id_GradeBase) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.id_GradeBase, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.id_GradeBase] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetGradeBaseName(this clsvUsersEN objvUsersEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convUsers.GradeBaseName);
objvUsersEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.GradeBaseName) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.GradeBaseName, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.GradeBaseName] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN Setid_XzCollege(this clsvUsersEN objvUsersEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convUsers.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convUsers.id_XzCollege);
objvUsersEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.id_XzCollege) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.id_XzCollege, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.id_XzCollege] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetCollegeID(this clsvUsersEN objvUsersEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convUsers.CollegeID);
objvUsersEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.CollegeID) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.CollegeID, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.CollegeID] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetCollegeName(this clsvUsersEN objvUsersEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convUsers.CollegeName);
objvUsersEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.CollegeName) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.CollegeName, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.CollegeName] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetCollegeNameA(this clsvUsersEN objvUsersEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convUsers.CollegeNameA);
objvUsersEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.CollegeNameA) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.CollegeNameA, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.CollegeNameA] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN Setid_XzMajor(this clsvUsersEN objvUsersEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convUsers.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convUsers.id_XzMajor);
objvUsersEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.id_XzMajor) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.id_XzMajor, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.id_XzMajor] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetMajorName(this clsvUsersEN objvUsersEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convUsers.MajorName);
objvUsersEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.MajorName) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.MajorName, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.MajorName] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetIsLeaved(this clsvUsersEN objvUsersEN, bool bolIsLeaved, string strComparisonOp="")
	{
objvUsersEN.IsLeaved = bolIsLeaved; //IsLeaved
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IsLeaved) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IsLeaved, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IsLeaved] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetStuIdTeacherId(this clsvUsersEN objvUsersEN, string strStuIdTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuIdTeacherId, 20, convUsers.StuIdTeacherId);
objvUsersEN.StuIdTeacherId = strStuIdTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.StuIdTeacherId) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.StuIdTeacherId, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.StuIdTeacherId] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetIdentityID(this clsvUsersEN objvUsersEN, string strIdentityID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityID, convUsers.IdentityID);
clsCheckSql.CheckFieldLen(strIdentityID, 2, convUsers.IdentityID);
clsCheckSql.CheckFieldForeignKey(strIdentityID, 2, convUsers.IdentityID);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetIdentityDesc(this clsvUsersEN objvUsersEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convUsers.IdentityDesc);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetAuditDate(this clsvUsersEN objvUsersEN, string strAuditDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAuditDate, 14, convUsers.AuditDate);
objvUsersEN.AuditDate = strAuditDate; //AuditDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.AuditDate) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.AuditDate, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.AuditDate] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetAuditUser(this clsvUsersEN objvUsersEN, string strAuditUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAuditUser, 18, convUsers.AuditUser);
objvUsersEN.AuditUser = strAuditUser; //AuditUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.AuditUser) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.AuditUser, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.AuditUser] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetIsAudit(this clsvUsersEN objvUsersEN, bool bolIsAudit, string strComparisonOp="")
	{
objvUsersEN.IsAudit = bolIsAudit; //是否审核
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IsAudit) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IsAudit, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IsAudit] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetIsRegister(this clsvUsersEN objvUsersEN, bool bolIsRegister, string strComparisonOp="")
	{
objvUsersEN.IsRegister = bolIsRegister; //IsRegister
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IsRegister) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IsRegister, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IsRegister] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetRegisterDate(this clsvUsersEN objvUsersEN, string strRegisterDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegisterDate, 14, convUsers.RegisterDate);
objvUsersEN.RegisterDate = strRegisterDate; //RegisterDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.RegisterDate) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.RegisterDate, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.RegisterDate] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetMobilePhone(this clsvUsersEN objvUsersEN, string strMobilePhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMobilePhone, 20, convUsers.MobilePhone);
objvUsersEN.MobilePhone = strMobilePhone; //手机
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.MobilePhone) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.MobilePhone, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.MobilePhone] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetUpdDate(this clsvUsersEN objvUsersEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUsers.UpdDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetUpdUser(this clsvUsersEN objvUsersEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convUsers.UpdUser);
objvUsersEN.UpdUser = strUpdUser; //修改人
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetMemo(this clsvUsersEN objvUsersEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUsers.Memo);
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
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetUserNameWithUserId(this clsvUsersEN objvUsersEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserNameWithUserId, convUsers.UserNameWithUserId);
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convUsers.UserNameWithUserId);
objvUsersEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.UserNameWithUserId) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.UserNameWithUserId, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.UserNameWithUserId] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetOpenId(this clsvUsersEN objvUsersEN, string strOpenId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpenId, 50, convUsers.OpenId);
objvUsersEN.OpenId = strOpenId; //微信OpenId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.OpenId) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.OpenId, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.OpenId] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetAvatarsPicture(this clsvUsersEN objvUsersEN, string strAvatarsPicture, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAvatarsPicture, 100, convUsers.AvatarsPicture);
objvUsersEN.AvatarsPicture = strAvatarsPicture; //AvatarsPicture
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.AvatarsPicture) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.AvatarsPicture, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.AvatarsPicture] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetEmail(this clsvUsersEN objvUsersEN, string strEmail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEmail, 100, convUsers.Email);
objvUsersEN.Email = strEmail; //电子邮箱
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetPhoneNumber(this clsvUsersEN objvUsersEN, string strPhoneNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, convUsers.PhoneNumber);
objvUsersEN.PhoneNumber = strPhoneNumber; //PhoneNumber
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetHeadPic(this clsvUsersEN objvUsersEN, string strHeadPic, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHeadPic, 500, convUsers.HeadPic);
objvUsersEN.HeadPic = strHeadPic; //头像
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.HeadPic) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.HeadPic, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.HeadPic] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersEN SetIsGSuser(this clsvUsersEN objvUsersEN, bool bolIsGSuser, string strComparisonOp="")
	{
objvUsersEN.IsGSuser = bolIsGSuser; //是否GS用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IsGSuser) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IsGSuser, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IsGSuser] = strComparisonOp;
}
}
return objvUsersEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
if (objvUsers_Cond.IsUpdated(convUsers.Password) == true)
{
string strComparisonOp_Password = objvUsers_Cond.dicFldComparisonOp[convUsers.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.Password, objvUsers_Cond.Password, strComparisonOp_Password);
}
if (objvUsers_Cond.IsUpdated(convUsers.IsGpUser) == true)
{
if (objvUsers_Cond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers.IsGpUser);
}
}
if (objvUsers_Cond.IsUpdated(convUsers.BeginYearMonth) == true)
{
string strComparisonOp_BeginYearMonth = objvUsers_Cond.dicFldComparisonOp[convUsers.BeginYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.BeginYearMonth, objvUsers_Cond.BeginYearMonth, strComparisonOp_BeginYearMonth);
}
if (objvUsers_Cond.IsUpdated(convUsers.EndYearMonth) == true)
{
string strComparisonOp_EndYearMonth = objvUsers_Cond.dicFldComparisonOp[convUsers.EndYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.EndYearMonth, objvUsers_Cond.EndYearMonth, strComparisonOp_EndYearMonth);
}
if (objvUsers_Cond.IsUpdated(convUsers.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvUsers_Cond.dicFldComparisonOp[convUsers.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.id_GradeBase, objvUsers_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvUsers_Cond.IsUpdated(convUsers.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvUsers_Cond.dicFldComparisonOp[convUsers.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.GradeBaseName, objvUsers_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvUsers_Cond.IsUpdated(convUsers.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvUsers_Cond.dicFldComparisonOp[convUsers.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.id_XzCollege, objvUsers_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvUsers_Cond.IsUpdated(convUsers.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvUsers_Cond.dicFldComparisonOp[convUsers.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.CollegeID, objvUsers_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvUsers_Cond.IsUpdated(convUsers.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvUsers_Cond.dicFldComparisonOp[convUsers.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.CollegeName, objvUsers_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvUsers_Cond.IsUpdated(convUsers.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvUsers_Cond.dicFldComparisonOp[convUsers.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.CollegeNameA, objvUsers_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvUsers_Cond.IsUpdated(convUsers.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvUsers_Cond.dicFldComparisonOp[convUsers.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.id_XzMajor, objvUsers_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvUsers_Cond.IsUpdated(convUsers.MajorName) == true)
{
string strComparisonOp_MajorName = objvUsers_Cond.dicFldComparisonOp[convUsers.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.MajorName, objvUsers_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvUsers_Cond.IsUpdated(convUsers.IsLeaved) == true)
{
if (objvUsers_Cond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers.IsLeaved);
}
}
if (objvUsers_Cond.IsUpdated(convUsers.StuIdTeacherId) == true)
{
string strComparisonOp_StuIdTeacherId = objvUsers_Cond.dicFldComparisonOp[convUsers.StuIdTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.StuIdTeacherId, objvUsers_Cond.StuIdTeacherId, strComparisonOp_StuIdTeacherId);
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
if (objvUsers_Cond.IsUpdated(convUsers.AuditDate) == true)
{
string strComparisonOp_AuditDate = objvUsers_Cond.dicFldComparisonOp[convUsers.AuditDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.AuditDate, objvUsers_Cond.AuditDate, strComparisonOp_AuditDate);
}
if (objvUsers_Cond.IsUpdated(convUsers.AuditUser) == true)
{
string strComparisonOp_AuditUser = objvUsers_Cond.dicFldComparisonOp[convUsers.AuditUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.AuditUser, objvUsers_Cond.AuditUser, strComparisonOp_AuditUser);
}
if (objvUsers_Cond.IsUpdated(convUsers.IsAudit) == true)
{
if (objvUsers_Cond.IsAudit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers.IsAudit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers.IsAudit);
}
}
if (objvUsers_Cond.IsUpdated(convUsers.IsRegister) == true)
{
if (objvUsers_Cond.IsRegister == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers.IsRegister);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers.IsRegister);
}
}
if (objvUsers_Cond.IsUpdated(convUsers.RegisterDate) == true)
{
string strComparisonOp_RegisterDate = objvUsers_Cond.dicFldComparisonOp[convUsers.RegisterDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.RegisterDate, objvUsers_Cond.RegisterDate, strComparisonOp_RegisterDate);
}
if (objvUsers_Cond.IsUpdated(convUsers.MobilePhone) == true)
{
string strComparisonOp_MobilePhone = objvUsers_Cond.dicFldComparisonOp[convUsers.MobilePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.MobilePhone, objvUsers_Cond.MobilePhone, strComparisonOp_MobilePhone);
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
if (objvUsers_Cond.IsUpdated(convUsers.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvUsers_Cond.dicFldComparisonOp[convUsers.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UserNameWithUserId, objvUsers_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvUsers_Cond.IsUpdated(convUsers.OpenId) == true)
{
string strComparisonOp_OpenId = objvUsers_Cond.dicFldComparisonOp[convUsers.OpenId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.OpenId, objvUsers_Cond.OpenId, strComparisonOp_OpenId);
}
if (objvUsers_Cond.IsUpdated(convUsers.AvatarsPicture) == true)
{
string strComparisonOp_AvatarsPicture = objvUsers_Cond.dicFldComparisonOp[convUsers.AvatarsPicture];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.AvatarsPicture, objvUsers_Cond.AvatarsPicture, strComparisonOp_AvatarsPicture);
}
if (objvUsers_Cond.IsUpdated(convUsers.Email) == true)
{
string strComparisonOp_Email = objvUsers_Cond.dicFldComparisonOp[convUsers.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.Email, objvUsers_Cond.Email, strComparisonOp_Email);
}
if (objvUsers_Cond.IsUpdated(convUsers.PhoneNumber) == true)
{
string strComparisonOp_PhoneNumber = objvUsers_Cond.dicFldComparisonOp[convUsers.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.PhoneNumber, objvUsers_Cond.PhoneNumber, strComparisonOp_PhoneNumber);
}
if (objvUsers_Cond.IsUpdated(convUsers.HeadPic) == true)
{
string strComparisonOp_HeadPic = objvUsers_Cond.dicFldComparisonOp[convUsers.HeadPic];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.HeadPic, objvUsers_Cond.HeadPic, strComparisonOp_HeadPic);
}
if (objvUsers_Cond.IsUpdated(convUsers.IsGSuser) == true)
{
if (objvUsers_Cond.IsGSuser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers.IsGSuser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers.IsGSuser);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户(vUsers)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvUsersWApi
{
private static readonly string mstrApiControllerName = "vUsersApi";

 public clsvUsersWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUsersEN GetObjByUserId(string strUserId)
{
string strAction = "GetObjByUserId";
string strErrMsg = string.Empty;
string strResult = "";
clsvUsersEN objvUsersEN = null;
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
objvUsersEN = JsonConvert.DeserializeObject<clsvUsersEN>((string)jobjReturn["ReturnObj"]);
return objvUsersEN;
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
public static clsvUsersEN GetObjByUserId_WA_Cache(string strUserId)
{
string strAction = "GetObjByUserId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvUsersEN objvUsersEN = null;
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
objvUsersEN = JsonConvert.DeserializeObject<clsvUsersEN>((string)jobjReturn["ReturnObj"]);
return objvUsersEN;
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
public static clsvUsersEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvUsersEN objvUsersEN = null;
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
objvUsersEN = JsonConvert.DeserializeObject<clsvUsersEN>((string)jobjReturn["ReturnObj"]);
return objvUsersEN;
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
public static clsvUsersEN GetObjByUserId_Cache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvUsersEN._CurrTabName_S);
List<clsvUsersEN> arrvUsersObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUsersEN> arrvUsersObjLst_Sel =
from objvUsersEN in arrvUsersObjLst_Cache
where objvUsersEN.UserId == strUserId
select objvUsersEN;
if (arrvUsersObjLst_Sel.Count() == 0)
{
   clsvUsersEN obj = clsvUsersWApi.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvUsersObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsersEN> GetObjLst(string strWhereCond)
{
 List<clsvUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUsersEN> GetObjLstByUserIdLst(List<string> arrUserId)
{
 List<clsvUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvUsersEN> GetObjLstByUserIdLst_Cache(List<string> arrUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvUsersEN._CurrTabName_S);
List<clsvUsersEN> arrvUsersObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUsersEN> arrvUsersObjLst_Sel =
from objvUsersEN in arrvUsersObjLst_Cache
where arrUserId.Contains(objvUsersEN.UserId)
select objvUsersEN;
return arrvUsersObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsersEN> GetObjLstByUserIdLst_WA_Cache(List<string> arrUserId)
{
 List<clsvUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUsersEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUsersEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUsersEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvUsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvUsersENS">源对象</param>
 /// <param name = "objvUsersENT">目标对象</param>
 public static void CopyTo(clsvUsersEN objvUsersENS, clsvUsersEN objvUsersENT)
{
try
{
objvUsersENT.UserId = objvUsersENS.UserId; //用户ID
objvUsersENT.UserName = objvUsersENS.UserName; //用户名
objvUsersENT.UserStateId = objvUsersENS.UserStateId; //用户状态Id
objvUsersENT.UserStateName = objvUsersENS.UserStateName; //用户状态名
objvUsersENT.Password = objvUsersENS.Password; //Password
objvUsersENT.IsGpUser = objvUsersENS.IsGpUser; //是否Gp用户
objvUsersENT.BeginYearMonth = objvUsersENS.BeginYearMonth; //开始年月
objvUsersENT.EndYearMonth = objvUsersENS.EndYearMonth; //结束年月
objvUsersENT.id_GradeBase = objvUsersENS.id_GradeBase; //年级流水号
objvUsersENT.GradeBaseName = objvUsersENS.GradeBaseName; //年级名称
objvUsersENT.id_XzCollege = objvUsersENS.id_XzCollege; //学院流水号
objvUsersENT.CollegeID = objvUsersENS.CollegeID; //学院ID
objvUsersENT.CollegeName = objvUsersENS.CollegeName; //学院名称
objvUsersENT.CollegeNameA = objvUsersENS.CollegeNameA; //学院名称简写
objvUsersENT.id_XzMajor = objvUsersENS.id_XzMajor; //专业流水号
objvUsersENT.MajorName = objvUsersENS.MajorName; //专业名称
objvUsersENT.IsLeaved = objvUsersENS.IsLeaved; //IsLeaved
objvUsersENT.StuIdTeacherId = objvUsersENS.StuIdTeacherId; //学工号
objvUsersENT.IdentityID = objvUsersENS.IdentityID; //身份编号
objvUsersENT.IdentityDesc = objvUsersENS.IdentityDesc; //身份描述
objvUsersENT.AuditDate = objvUsersENS.AuditDate; //AuditDate
objvUsersENT.AuditUser = objvUsersENS.AuditUser; //AuditUser
objvUsersENT.IsAudit = objvUsersENS.IsAudit; //是否审核
objvUsersENT.IsRegister = objvUsersENS.IsRegister; //IsRegister
objvUsersENT.RegisterDate = objvUsersENS.RegisterDate; //RegisterDate
objvUsersENT.MobilePhone = objvUsersENS.MobilePhone; //手机
objvUsersENT.UpdDate = objvUsersENS.UpdDate; //修改日期
objvUsersENT.UpdUser = objvUsersENS.UpdUser; //修改人
objvUsersENT.Memo = objvUsersENS.Memo; //备注
objvUsersENT.UserNameWithUserId = objvUsersENS.UserNameWithUserId; //UserNameWithUserId
objvUsersENT.OpenId = objvUsersENS.OpenId; //微信OpenId
objvUsersENT.AvatarsPicture = objvUsersENS.AvatarsPicture; //AvatarsPicture
objvUsersENT.Email = objvUsersENS.Email; //电子邮箱
objvUsersENT.PhoneNumber = objvUsersENS.PhoneNumber; //PhoneNumber
objvUsersENT.HeadPic = objvUsersENS.HeadPic; //头像
objvUsersENT.IsGSuser = objvUsersENS.IsGSuser; //是否GS用户
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
public static DataTable ToDataTable(List<clsvUsersEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvUsersEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvUsersEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvUsersEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvUsersEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvUsersEN.AttributeName)
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserId");
//if (arrvUsersObjLst_Cache == null)
//{
//arrvUsersObjLst_Cache = await clsvUsersWApi.GetObjLst(strWhereCond);
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

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUsersEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvUsersEN._CurrTabName_S);
List<clsvUsersEN> arrvUsersObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvUsersObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvUsersEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convUsers.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.Password, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.IsGpUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUsers.BeginYearMonth, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.EndYearMonth, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.IsLeaved, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUsers.StuIdTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.IdentityID, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.IdentityDesc, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.AuditDate, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.AuditUser, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.IsAudit, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUsers.IsRegister, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUsers.RegisterDate, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.MobilePhone, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.OpenId, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.AvatarsPicture, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.Email, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.PhoneNumber, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.HeadPic, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.IsGSuser, Type.GetType("System.Boolean"));
foreach (clsvUsersEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convUsers.UserId] = objInFor[convUsers.UserId];
objDR[convUsers.UserName] = objInFor[convUsers.UserName];
objDR[convUsers.UserStateId] = objInFor[convUsers.UserStateId];
objDR[convUsers.UserStateName] = objInFor[convUsers.UserStateName];
objDR[convUsers.Password] = objInFor[convUsers.Password];
objDR[convUsers.IsGpUser] = objInFor[convUsers.IsGpUser];
objDR[convUsers.BeginYearMonth] = objInFor[convUsers.BeginYearMonth];
objDR[convUsers.EndYearMonth] = objInFor[convUsers.EndYearMonth];
objDR[convUsers.id_GradeBase] = objInFor[convUsers.id_GradeBase];
objDR[convUsers.GradeBaseName] = objInFor[convUsers.GradeBaseName];
objDR[convUsers.id_XzCollege] = objInFor[convUsers.id_XzCollege];
objDR[convUsers.CollegeID] = objInFor[convUsers.CollegeID];
objDR[convUsers.CollegeName] = objInFor[convUsers.CollegeName];
objDR[convUsers.CollegeNameA] = objInFor[convUsers.CollegeNameA];
objDR[convUsers.id_XzMajor] = objInFor[convUsers.id_XzMajor];
objDR[convUsers.MajorName] = objInFor[convUsers.MajorName];
objDR[convUsers.IsLeaved] = objInFor[convUsers.IsLeaved];
objDR[convUsers.StuIdTeacherId] = objInFor[convUsers.StuIdTeacherId];
objDR[convUsers.IdentityID] = objInFor[convUsers.IdentityID];
objDR[convUsers.IdentityDesc] = objInFor[convUsers.IdentityDesc];
objDR[convUsers.AuditDate] = objInFor[convUsers.AuditDate];
objDR[convUsers.AuditUser] = objInFor[convUsers.AuditUser];
objDR[convUsers.IsAudit] = objInFor[convUsers.IsAudit];
objDR[convUsers.IsRegister] = objInFor[convUsers.IsRegister];
objDR[convUsers.RegisterDate] = objInFor[convUsers.RegisterDate];
objDR[convUsers.MobilePhone] = objInFor[convUsers.MobilePhone];
objDR[convUsers.UpdDate] = objInFor[convUsers.UpdDate];
objDR[convUsers.UpdUser] = objInFor[convUsers.UpdUser];
objDR[convUsers.Memo] = objInFor[convUsers.Memo];
objDR[convUsers.UserNameWithUserId] = objInFor[convUsers.UserNameWithUserId];
objDR[convUsers.OpenId] = objInFor[convUsers.OpenId];
objDR[convUsers.AvatarsPicture] = objInFor[convUsers.AvatarsPicture];
objDR[convUsers.Email] = objInFor[convUsers.Email];
objDR[convUsers.PhoneNumber] = objInFor[convUsers.PhoneNumber];
objDR[convUsers.HeadPic] = objInFor[convUsers.HeadPic];
objDR[convUsers.IsGSuser] = objInFor[convUsers.IsGSuser];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}