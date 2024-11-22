
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsersBL
 表名:vUsers(01120027)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:16
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
public static class  clsvUsersBL_Static
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetUserName(this clsvUsersEN objvUsersEN, string strUserName, string strComparisonOp="")
	{
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetUserStateId(this clsvUsersEN objvUsersEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convUsers.UserStateId);
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetPassword(this clsvUsersEN objvUsersEN, string strPassword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPassword, 20, convUsers.Password);
}
objvUsersEN.Password = strPassword; //口令
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetBeginYearMonth(this clsvUsersEN objvUsersEN, string strBeginYearMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBeginYearMonth, 8, convUsers.BeginYearMonth);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetEndYearMonth(this clsvUsersEN objvUsersEN, string strEndYearMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndYearMonth, 8, convUsers.EndYearMonth);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetIdGradeBase(this clsvUsersEN objvUsersEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convUsers.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convUsers.IdGradeBase);
}
objvUsersEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IdGradeBase) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IdGradeBase, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IdGradeBase] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetGradeBaseName(this clsvUsersEN objvUsersEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convUsers.GradeBaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetIdXzCollege(this clsvUsersEN objvUsersEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convUsers.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convUsers.IdXzCollege);
}
objvUsersEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IdXzCollege) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IdXzCollege, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IdXzCollege] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetCollegeId(this clsvUsersEN objvUsersEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convUsers.CollegeId);
}
objvUsersEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.CollegeId) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.CollegeId, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.CollegeId] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetCollegeName(this clsvUsersEN objvUsersEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convUsers.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetCollegeNameA(this clsvUsersEN objvUsersEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convUsers.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetIdXzMajor(this clsvUsersEN objvUsersEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convUsers.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convUsers.IdXzMajor);
}
objvUsersEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IdXzMajor) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IdXzMajor, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IdXzMajor] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetMajorName(this clsvUsersEN objvUsersEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convUsers.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetIsLeaved(this clsvUsersEN objvUsersEN, bool bolIsLeaved, string strComparisonOp="")
	{
objvUsersEN.IsLeaved = bolIsLeaved; //是否离开
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetStuIdTeacherId(this clsvUsersEN objvUsersEN, string strStuIdTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuIdTeacherId, 20, convUsers.StuIdTeacherId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetIdentityId(this clsvUsersEN objvUsersEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityId, convUsers.IdentityId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityId, 2, convUsers.IdentityId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convUsers.IdentityId);
}
objvUsersEN.IdentityId = strIdentityId; //身份Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IdentityId) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IdentityId, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IdentityId] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetAuditDate(this clsvUsersEN objvUsersEN, string strAuditDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuditDate, 14, convUsers.AuditDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetAuditUser(this clsvUsersEN objvUsersEN, string strAuditUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuditUser, 18, convUsers.AuditUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetRegisterDate(this clsvUsersEN objvUsersEN, string strRegisterDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegisterDate, 14, convUsers.RegisterDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetMobilePhone(this clsvUsersEN objvUsersEN, string strMobilePhone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMobilePhone, 20, convUsers.MobilePhone);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetUpdUser(this clsvUsersEN objvUsersEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convUsers.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetUserNameWithUserId(this clsvUsersEN objvUsersEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserNameWithUserId, convUsers.UserNameWithUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convUsers.UserNameWithUserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetOpenId(this clsvUsersEN objvUsersEN, string strOpenId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpenId, 50, convUsers.OpenId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetAvatarsPicture(this clsvUsersEN objvUsersEN, string strAvatarsPicture, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAvatarsPicture, 100, convUsers.AvatarsPicture);
}
objvUsersEN.AvatarsPicture = strAvatarsPicture; //虚拟头像
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetEmail(this clsvUsersEN objvUsersEN, string strEmail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEmail, 100, convUsers.Email);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetPhoneNumber(this clsvUsersEN objvUsersEN, string strPhoneNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, convUsers.PhoneNumber);
}
objvUsersEN.PhoneNumber = strPhoneNumber; //电话
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetHeadPic(this clsvUsersEN objvUsersEN, string strHeadPic, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHeadPic, 500, convUsers.HeadPic);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
objvUsersENT.UserStateId = objvUsersENS.UserStateId; //用户状态Id
objvUsersENT.UserStateName = objvUsersENS.UserStateName; //用户状态名
objvUsersENT.Password = objvUsersENS.Password; //口令
objvUsersENT.IsGpUser = objvUsersENS.IsGpUser; //是否Gp用户
objvUsersENT.BeginYearMonth = objvUsersENS.BeginYearMonth; //开始年月
objvUsersENT.EndYearMonth = objvUsersENS.EndYearMonth; //结束年月
objvUsersENT.IdGradeBase = objvUsersENS.IdGradeBase; //年级流水号
objvUsersENT.GradeBaseName = objvUsersENS.GradeBaseName; //年级名称
objvUsersENT.IdXzCollege = objvUsersENS.IdXzCollege; //学院流水号
objvUsersENT.CollegeId = objvUsersENS.CollegeId; //学院ID
objvUsersENT.CollegeName = objvUsersENS.CollegeName; //学院名称
objvUsersENT.CollegeNameA = objvUsersENS.CollegeNameA; //学院名称简写
objvUsersENT.IdXzMajor = objvUsersENS.IdXzMajor; //专业流水号
objvUsersENT.MajorName = objvUsersENS.MajorName; //专业名称
objvUsersENT.IsLeaved = objvUsersENS.IsLeaved; //是否离开
objvUsersENT.StuIdTeacherId = objvUsersENS.StuIdTeacherId; //学工号
objvUsersENT.IdentityId = objvUsersENS.IdentityId; //身份Id
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
objvUsersENT.AvatarsPicture = objvUsersENS.AvatarsPicture; //虚拟头像
objvUsersENT.Email = objvUsersENS.Email; //电子邮箱
objvUsersENT.PhoneNumber = objvUsersENS.PhoneNumber; //电话
objvUsersENT.HeadPic = objvUsersENS.HeadPic; //头像
objvUsersENT.IsGSuser = objvUsersENS.IsGSuser; //是否GS用户
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
UserStateId = objvUsersENS.UserStateId, //用户状态Id
UserStateName = objvUsersENS.UserStateName, //用户状态名
Password = objvUsersENS.Password, //口令
IsGpUser = objvUsersENS.IsGpUser, //是否Gp用户
BeginYearMonth = objvUsersENS.BeginYearMonth, //开始年月
EndYearMonth = objvUsersENS.EndYearMonth, //结束年月
IdGradeBase = objvUsersENS.IdGradeBase, //年级流水号
GradeBaseName = objvUsersENS.GradeBaseName, //年级名称
IdXzCollege = objvUsersENS.IdXzCollege, //学院流水号
CollegeId = objvUsersENS.CollegeId, //学院ID
CollegeName = objvUsersENS.CollegeName, //学院名称
CollegeNameA = objvUsersENS.CollegeNameA, //学院名称简写
IdXzMajor = objvUsersENS.IdXzMajor, //专业流水号
MajorName = objvUsersENS.MajorName, //专业名称
IsLeaved = objvUsersENS.IsLeaved, //是否离开
StuIdTeacherId = objvUsersENS.StuIdTeacherId, //学工号
IdentityId = objvUsersENS.IdentityId, //身份Id
IdentityDesc = objvUsersENS.IdentityDesc, //身份描述
AuditDate = objvUsersENS.AuditDate, //AuditDate
AuditUser = objvUsersENS.AuditUser, //AuditUser
IsAudit = objvUsersENS.IsAudit, //是否审核
IsRegister = objvUsersENS.IsRegister, //IsRegister
RegisterDate = objvUsersENS.RegisterDate, //RegisterDate
MobilePhone = objvUsersENS.MobilePhone, //手机
UpdDate = objvUsersENS.UpdDate, //修改日期
UpdUser = objvUsersENS.UpdUser, //修改人
Memo = objvUsersENS.Memo, //备注
UserNameWithUserId = objvUsersENS.UserNameWithUserId, //UserNameWithUserId
OpenId = objvUsersENS.OpenId, //微信OpenId
AvatarsPicture = objvUsersENS.AvatarsPicture, //虚拟头像
Email = objvUsersENS.Email, //电子邮箱
PhoneNumber = objvUsersENS.PhoneNumber, //电话
HeadPic = objvUsersENS.HeadPic, //头像
IsGSuser = objvUsersENS.IsGSuser, //是否GS用户
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
public static string GetCombineCondition(this clsvUsersEN objvUsersCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUsersCond.IsUpdated(convUsers.UserId) == true)
{
string strComparisonOpUserId = objvUsersCond.dicFldComparisonOp[convUsers.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UserId, objvUsersCond.UserId, strComparisonOpUserId);
}
if (objvUsersCond.IsUpdated(convUsers.UserName) == true)
{
string strComparisonOpUserName = objvUsersCond.dicFldComparisonOp[convUsers.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UserName, objvUsersCond.UserName, strComparisonOpUserName);
}
if (objvUsersCond.IsUpdated(convUsers.UserStateId) == true)
{
string strComparisonOpUserStateId = objvUsersCond.dicFldComparisonOp[convUsers.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UserStateId, objvUsersCond.UserStateId, strComparisonOpUserStateId);
}
if (objvUsersCond.IsUpdated(convUsers.UserStateName) == true)
{
string strComparisonOpUserStateName = objvUsersCond.dicFldComparisonOp[convUsers.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UserStateName, objvUsersCond.UserStateName, strComparisonOpUserStateName);
}
if (objvUsersCond.IsUpdated(convUsers.Password) == true)
{
string strComparisonOpPassword = objvUsersCond.dicFldComparisonOp[convUsers.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.Password, objvUsersCond.Password, strComparisonOpPassword);
}
if (objvUsersCond.IsUpdated(convUsers.IsGpUser) == true)
{
if (objvUsersCond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers.IsGpUser);
}
}
if (objvUsersCond.IsUpdated(convUsers.BeginYearMonth) == true)
{
string strComparisonOpBeginYearMonth = objvUsersCond.dicFldComparisonOp[convUsers.BeginYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.BeginYearMonth, objvUsersCond.BeginYearMonth, strComparisonOpBeginYearMonth);
}
if (objvUsersCond.IsUpdated(convUsers.EndYearMonth) == true)
{
string strComparisonOpEndYearMonth = objvUsersCond.dicFldComparisonOp[convUsers.EndYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.EndYearMonth, objvUsersCond.EndYearMonth, strComparisonOpEndYearMonth);
}
if (objvUsersCond.IsUpdated(convUsers.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvUsersCond.dicFldComparisonOp[convUsers.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.IdGradeBase, objvUsersCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvUsersCond.IsUpdated(convUsers.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvUsersCond.dicFldComparisonOp[convUsers.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.GradeBaseName, objvUsersCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvUsersCond.IsUpdated(convUsers.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvUsersCond.dicFldComparisonOp[convUsers.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.IdXzCollege, objvUsersCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvUsersCond.IsUpdated(convUsers.CollegeId) == true)
{
string strComparisonOpCollegeId = objvUsersCond.dicFldComparisonOp[convUsers.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.CollegeId, objvUsersCond.CollegeId, strComparisonOpCollegeId);
}
if (objvUsersCond.IsUpdated(convUsers.CollegeName) == true)
{
string strComparisonOpCollegeName = objvUsersCond.dicFldComparisonOp[convUsers.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.CollegeName, objvUsersCond.CollegeName, strComparisonOpCollegeName);
}
if (objvUsersCond.IsUpdated(convUsers.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvUsersCond.dicFldComparisonOp[convUsers.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.CollegeNameA, objvUsersCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvUsersCond.IsUpdated(convUsers.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvUsersCond.dicFldComparisonOp[convUsers.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.IdXzMajor, objvUsersCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvUsersCond.IsUpdated(convUsers.MajorName) == true)
{
string strComparisonOpMajorName = objvUsersCond.dicFldComparisonOp[convUsers.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.MajorName, objvUsersCond.MajorName, strComparisonOpMajorName);
}
if (objvUsersCond.IsUpdated(convUsers.IsLeaved) == true)
{
if (objvUsersCond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers.IsLeaved);
}
}
if (objvUsersCond.IsUpdated(convUsers.StuIdTeacherId) == true)
{
string strComparisonOpStuIdTeacherId = objvUsersCond.dicFldComparisonOp[convUsers.StuIdTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.StuIdTeacherId, objvUsersCond.StuIdTeacherId, strComparisonOpStuIdTeacherId);
}
if (objvUsersCond.IsUpdated(convUsers.IdentityId) == true)
{
string strComparisonOpIdentityId = objvUsersCond.dicFldComparisonOp[convUsers.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.IdentityId, objvUsersCond.IdentityId, strComparisonOpIdentityId);
}
if (objvUsersCond.IsUpdated(convUsers.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvUsersCond.dicFldComparisonOp[convUsers.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.IdentityDesc, objvUsersCond.IdentityDesc, strComparisonOpIdentityDesc);
}
if (objvUsersCond.IsUpdated(convUsers.AuditDate) == true)
{
string strComparisonOpAuditDate = objvUsersCond.dicFldComparisonOp[convUsers.AuditDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.AuditDate, objvUsersCond.AuditDate, strComparisonOpAuditDate);
}
if (objvUsersCond.IsUpdated(convUsers.AuditUser) == true)
{
string strComparisonOpAuditUser = objvUsersCond.dicFldComparisonOp[convUsers.AuditUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.AuditUser, objvUsersCond.AuditUser, strComparisonOpAuditUser);
}
if (objvUsersCond.IsUpdated(convUsers.IsAudit) == true)
{
if (objvUsersCond.IsAudit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers.IsAudit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers.IsAudit);
}
}
if (objvUsersCond.IsUpdated(convUsers.IsRegister) == true)
{
if (objvUsersCond.IsRegister == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers.IsRegister);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers.IsRegister);
}
}
if (objvUsersCond.IsUpdated(convUsers.RegisterDate) == true)
{
string strComparisonOpRegisterDate = objvUsersCond.dicFldComparisonOp[convUsers.RegisterDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.RegisterDate, objvUsersCond.RegisterDate, strComparisonOpRegisterDate);
}
if (objvUsersCond.IsUpdated(convUsers.MobilePhone) == true)
{
string strComparisonOpMobilePhone = objvUsersCond.dicFldComparisonOp[convUsers.MobilePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.MobilePhone, objvUsersCond.MobilePhone, strComparisonOpMobilePhone);
}
if (objvUsersCond.IsUpdated(convUsers.UpdDate) == true)
{
string strComparisonOpUpdDate = objvUsersCond.dicFldComparisonOp[convUsers.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UpdDate, objvUsersCond.UpdDate, strComparisonOpUpdDate);
}
if (objvUsersCond.IsUpdated(convUsers.UpdUser) == true)
{
string strComparisonOpUpdUser = objvUsersCond.dicFldComparisonOp[convUsers.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UpdUser, objvUsersCond.UpdUser, strComparisonOpUpdUser);
}
if (objvUsersCond.IsUpdated(convUsers.Memo) == true)
{
string strComparisonOpMemo = objvUsersCond.dicFldComparisonOp[convUsers.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.Memo, objvUsersCond.Memo, strComparisonOpMemo);
}
if (objvUsersCond.IsUpdated(convUsers.UserNameWithUserId) == true)
{
string strComparisonOpUserNameWithUserId = objvUsersCond.dicFldComparisonOp[convUsers.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UserNameWithUserId, objvUsersCond.UserNameWithUserId, strComparisonOpUserNameWithUserId);
}
if (objvUsersCond.IsUpdated(convUsers.OpenId) == true)
{
string strComparisonOpOpenId = objvUsersCond.dicFldComparisonOp[convUsers.OpenId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.OpenId, objvUsersCond.OpenId, strComparisonOpOpenId);
}
if (objvUsersCond.IsUpdated(convUsers.AvatarsPicture) == true)
{
string strComparisonOpAvatarsPicture = objvUsersCond.dicFldComparisonOp[convUsers.AvatarsPicture];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.AvatarsPicture, objvUsersCond.AvatarsPicture, strComparisonOpAvatarsPicture);
}
if (objvUsersCond.IsUpdated(convUsers.Email) == true)
{
string strComparisonOpEmail = objvUsersCond.dicFldComparisonOp[convUsers.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.Email, objvUsersCond.Email, strComparisonOpEmail);
}
if (objvUsersCond.IsUpdated(convUsers.PhoneNumber) == true)
{
string strComparisonOpPhoneNumber = objvUsersCond.dicFldComparisonOp[convUsers.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.PhoneNumber, objvUsersCond.PhoneNumber, strComparisonOpPhoneNumber);
}
if (objvUsersCond.IsUpdated(convUsers.HeadPic) == true)
{
string strComparisonOpHeadPic = objvUsersCond.dicFldComparisonOp[convUsers.HeadPic];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.HeadPic, objvUsersCond.HeadPic, strComparisonOpHeadPic);
}
if (objvUsersCond.IsUpdated(convUsers.IsGSuser) == true)
{
if (objvUsersCond.IsGSuser == true)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
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
 /// v用户(vUsers)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvUsersBL
{
public static RelatedActions_vUsers relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvUsersDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
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
objvUsersEN.UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objvUsersEN.BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(); //开始年月
objvUsersEN.EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(); //结束年月
objvUsersEN.IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(); //年级流水号
objvUsersEN.GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(); //年级名称
objvUsersEN.IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersEN.CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(); //学院ID
objvUsersEN.CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(); //学院名称
objvUsersEN.CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(); //学院名称简写
objvUsersEN.IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersEN.MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(); //专业名称
objvUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsLeaved].ToString().Trim()); //是否离开
objvUsersEN.StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(); //学工号
objvUsersEN.IdentityId = objRow[convUsers.IdentityId].ToString().Trim(); //身份Id
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //AuditDate
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //AuditUser
objvUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsRegister].ToString().Trim()); //IsRegister
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //RegisterDate
objvUsersEN.MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(); //手机
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改人
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //备注
objvUsersEN.UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvUsersEN.OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(); //微信OpenId
objvUsersEN.AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(); //电话
objvUsersEN.HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(); //头像
objvUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGSuser].ToString().Trim()); //是否GS用户
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvUsersEN> GetObjLstByUserIdLstCache(List<string> arrUserIdLst)
{
string strKey = string.Format("{0}", clsvUsersEN._CurrTabName);
List<clsvUsersEN> arrvUsersObjLstCache = GetObjLstCache();
IEnumerable <clsvUsersEN> arrvUsersObjLst_Sel =
arrvUsersObjLstCache
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
objvUsersEN.UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objvUsersEN.BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(); //开始年月
objvUsersEN.EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(); //结束年月
objvUsersEN.IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(); //年级流水号
objvUsersEN.GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(); //年级名称
objvUsersEN.IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersEN.CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(); //学院ID
objvUsersEN.CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(); //学院名称
objvUsersEN.CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(); //学院名称简写
objvUsersEN.IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersEN.MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(); //专业名称
objvUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsLeaved].ToString().Trim()); //是否离开
objvUsersEN.StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(); //学工号
objvUsersEN.IdentityId = objRow[convUsers.IdentityId].ToString().Trim(); //身份Id
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //AuditDate
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //AuditUser
objvUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsRegister].ToString().Trim()); //IsRegister
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //RegisterDate
objvUsersEN.MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(); //手机
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改人
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //备注
objvUsersEN.UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvUsersEN.OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(); //微信OpenId
objvUsersEN.AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(); //电话
objvUsersEN.HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(); //头像
objvUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGSuser].ToString().Trim()); //是否GS用户
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
objvUsersEN.UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objvUsersEN.BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(); //开始年月
objvUsersEN.EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(); //结束年月
objvUsersEN.IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(); //年级流水号
objvUsersEN.GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(); //年级名称
objvUsersEN.IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersEN.CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(); //学院ID
objvUsersEN.CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(); //学院名称
objvUsersEN.CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(); //学院名称简写
objvUsersEN.IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersEN.MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(); //专业名称
objvUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsLeaved].ToString().Trim()); //是否离开
objvUsersEN.StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(); //学工号
objvUsersEN.IdentityId = objRow[convUsers.IdentityId].ToString().Trim(); //身份Id
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //AuditDate
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //AuditUser
objvUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsRegister].ToString().Trim()); //IsRegister
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //RegisterDate
objvUsersEN.MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(); //手机
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改人
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //备注
objvUsersEN.UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvUsersEN.OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(); //微信OpenId
objvUsersEN.AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(); //电话
objvUsersEN.HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(); //头像
objvUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGSuser].ToString().Trim()); //是否GS用户
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvUsersCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvUsersEN> GetSubObjLstCache(clsvUsersEN objvUsersCond)
{
List<clsvUsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUsers.AttributeName)
{
if (objvUsersCond.IsUpdated(strFldName) == false) continue;
if (objvUsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUsersCond[strFldName].ToString());
}
else
{
if (objvUsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUsersCond[strFldName]));
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
objvUsersEN.UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objvUsersEN.BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(); //开始年月
objvUsersEN.EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(); //结束年月
objvUsersEN.IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(); //年级流水号
objvUsersEN.GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(); //年级名称
objvUsersEN.IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersEN.CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(); //学院ID
objvUsersEN.CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(); //学院名称
objvUsersEN.CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(); //学院名称简写
objvUsersEN.IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersEN.MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(); //专业名称
objvUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsLeaved].ToString().Trim()); //是否离开
objvUsersEN.StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(); //学工号
objvUsersEN.IdentityId = objRow[convUsers.IdentityId].ToString().Trim(); //身份Id
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //AuditDate
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //AuditUser
objvUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsRegister].ToString().Trim()); //IsRegister
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //RegisterDate
objvUsersEN.MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(); //手机
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改人
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //备注
objvUsersEN.UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvUsersEN.OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(); //微信OpenId
objvUsersEN.AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(); //电话
objvUsersEN.HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(); //头像
objvUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGSuser].ToString().Trim()); //是否GS用户
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
objvUsersEN.UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objvUsersEN.BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(); //开始年月
objvUsersEN.EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(); //结束年月
objvUsersEN.IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(); //年级流水号
objvUsersEN.GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(); //年级名称
objvUsersEN.IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersEN.CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(); //学院ID
objvUsersEN.CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(); //学院名称
objvUsersEN.CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(); //学院名称简写
objvUsersEN.IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersEN.MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(); //专业名称
objvUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsLeaved].ToString().Trim()); //是否离开
objvUsersEN.StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(); //学工号
objvUsersEN.IdentityId = objRow[convUsers.IdentityId].ToString().Trim(); //身份Id
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //AuditDate
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //AuditUser
objvUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsRegister].ToString().Trim()); //IsRegister
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //RegisterDate
objvUsersEN.MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(); //手机
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改人
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //备注
objvUsersEN.UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvUsersEN.OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(); //微信OpenId
objvUsersEN.AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(); //电话
objvUsersEN.HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(); //头像
objvUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGSuser].ToString().Trim()); //是否GS用户
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
objvUsersEN.UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objvUsersEN.BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(); //开始年月
objvUsersEN.EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(); //结束年月
objvUsersEN.IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(); //年级流水号
objvUsersEN.GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(); //年级名称
objvUsersEN.IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersEN.CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(); //学院ID
objvUsersEN.CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(); //学院名称
objvUsersEN.CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(); //学院名称简写
objvUsersEN.IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersEN.MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(); //专业名称
objvUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsLeaved].ToString().Trim()); //是否离开
objvUsersEN.StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(); //学工号
objvUsersEN.IdentityId = objRow[convUsers.IdentityId].ToString().Trim(); //身份Id
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //AuditDate
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //AuditUser
objvUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsRegister].ToString().Trim()); //IsRegister
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //RegisterDate
objvUsersEN.MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(); //手机
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改人
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //备注
objvUsersEN.UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvUsersEN.OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(); //微信OpenId
objvUsersEN.AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(); //电话
objvUsersEN.HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(); //头像
objvUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGSuser].ToString().Trim()); //是否GS用户
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
objvUsersEN.UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objvUsersEN.BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(); //开始年月
objvUsersEN.EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(); //结束年月
objvUsersEN.IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(); //年级流水号
objvUsersEN.GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(); //年级名称
objvUsersEN.IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersEN.CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(); //学院ID
objvUsersEN.CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(); //学院名称
objvUsersEN.CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(); //学院名称简写
objvUsersEN.IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersEN.MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(); //专业名称
objvUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsLeaved].ToString().Trim()); //是否离开
objvUsersEN.StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(); //学工号
objvUsersEN.IdentityId = objRow[convUsers.IdentityId].ToString().Trim(); //身份Id
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //AuditDate
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //AuditUser
objvUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsRegister].ToString().Trim()); //IsRegister
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //RegisterDate
objvUsersEN.MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(); //手机
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改人
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //备注
objvUsersEN.UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvUsersEN.OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(); //微信OpenId
objvUsersEN.AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(); //电话
objvUsersEN.HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(); //头像
objvUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGSuser].ToString().Trim()); //是否GS用户
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
objvUsersEN.UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objvUsersEN.BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(); //开始年月
objvUsersEN.EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(); //结束年月
objvUsersEN.IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(); //年级流水号
objvUsersEN.GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(); //年级名称
objvUsersEN.IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersEN.CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(); //学院ID
objvUsersEN.CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(); //学院名称
objvUsersEN.CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(); //学院名称简写
objvUsersEN.IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersEN.MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(); //专业名称
objvUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsLeaved].ToString().Trim()); //是否离开
objvUsersEN.StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(); //学工号
objvUsersEN.IdentityId = objRow[convUsers.IdentityId].ToString().Trim(); //身份Id
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //AuditDate
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //AuditUser
objvUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsRegister].ToString().Trim()); //IsRegister
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //RegisterDate
objvUsersEN.MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(); //手机
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改人
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //备注
objvUsersEN.UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvUsersEN.OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(); //微信OpenId
objvUsersEN.AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(); //电话
objvUsersEN.HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(); //头像
objvUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGSuser].ToString().Trim()); //是否GS用户
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
objvUsersEN.UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objvUsersEN.BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(); //开始年月
objvUsersEN.EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(); //结束年月
objvUsersEN.IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(); //年级流水号
objvUsersEN.GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(); //年级名称
objvUsersEN.IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersEN.CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(); //学院ID
objvUsersEN.CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(); //学院名称
objvUsersEN.CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(); //学院名称简写
objvUsersEN.IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersEN.MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(); //专业名称
objvUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsLeaved].ToString().Trim()); //是否离开
objvUsersEN.StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(); //学工号
objvUsersEN.IdentityId = objRow[convUsers.IdentityId].ToString().Trim(); //身份Id
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //AuditDate
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //AuditUser
objvUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsRegister].ToString().Trim()); //IsRegister
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //RegisterDate
objvUsersEN.MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(); //手机
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改人
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //备注
objvUsersEN.UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvUsersEN.OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(); //微信OpenId
objvUsersEN.AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(); //电话
objvUsersEN.HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(); //头像
objvUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGSuser].ToString().Trim()); //是否GS用户
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
objvUsersEN.UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objvUsersEN.BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(); //开始年月
objvUsersEN.EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(); //结束年月
objvUsersEN.IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(); //年级流水号
objvUsersEN.GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(); //年级名称
objvUsersEN.IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersEN.CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(); //学院ID
objvUsersEN.CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(); //学院名称
objvUsersEN.CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(); //学院名称简写
objvUsersEN.IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersEN.MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(); //专业名称
objvUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsLeaved].ToString().Trim()); //是否离开
objvUsersEN.StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(); //学工号
objvUsersEN.IdentityId = objRow[convUsers.IdentityId].ToString().Trim(); //身份Id
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //AuditDate
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //AuditUser
objvUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsRegister].ToString().Trim()); //IsRegister
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //RegisterDate
objvUsersEN.MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(); //手机
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改人
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //备注
objvUsersEN.UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvUsersEN.OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(); //微信OpenId
objvUsersEN.AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(); //电话
objvUsersEN.HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(); //头像
objvUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGSuser].ToString().Trim()); //是否GS用户
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
objvUsersENT.UserStateId = objvUsersENS.UserStateId; //用户状态Id
objvUsersENT.UserStateName = objvUsersENS.UserStateName; //用户状态名
objvUsersENT.Password = objvUsersENS.Password; //口令
objvUsersENT.IsGpUser = objvUsersENS.IsGpUser; //是否Gp用户
objvUsersENT.BeginYearMonth = objvUsersENS.BeginYearMonth; //开始年月
objvUsersENT.EndYearMonth = objvUsersENS.EndYearMonth; //结束年月
objvUsersENT.IdGradeBase = objvUsersENS.IdGradeBase; //年级流水号
objvUsersENT.GradeBaseName = objvUsersENS.GradeBaseName; //年级名称
objvUsersENT.IdXzCollege = objvUsersENS.IdXzCollege; //学院流水号
objvUsersENT.CollegeId = objvUsersENS.CollegeId; //学院ID
objvUsersENT.CollegeName = objvUsersENS.CollegeName; //学院名称
objvUsersENT.CollegeNameA = objvUsersENS.CollegeNameA; //学院名称简写
objvUsersENT.IdXzMajor = objvUsersENS.IdXzMajor; //专业流水号
objvUsersENT.MajorName = objvUsersENS.MajorName; //专业名称
objvUsersENT.IsLeaved = objvUsersENS.IsLeaved; //是否离开
objvUsersENT.StuIdTeacherId = objvUsersENS.StuIdTeacherId; //学工号
objvUsersENT.IdentityId = objvUsersENS.IdentityId; //身份Id
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
objvUsersENT.AvatarsPicture = objvUsersENS.AvatarsPicture; //虚拟头像
objvUsersENT.Email = objvUsersENS.Email; //电子邮箱
objvUsersENT.PhoneNumber = objvUsersENS.PhoneNumber; //电话
objvUsersENT.HeadPic = objvUsersENS.HeadPic; //头像
objvUsersENT.IsGSuser = objvUsersENS.IsGSuser; //是否GS用户
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
   string strsfUpdFldSetStr = objvUsersEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convUsers.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.UserId = objvUsersEN.UserId; //用户ID
}
if (arrFldSet.Contains(convUsers.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.UserName = objvUsersEN.UserName == "[null]" ? null :  objvUsersEN.UserName; //用户名
}
if (arrFldSet.Contains(convUsers.UserStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.UserStateId = objvUsersEN.UserStateId; //用户状态Id
}
if (arrFldSet.Contains(convUsers.UserStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.UserStateName = objvUsersEN.UserStateName == "[null]" ? null :  objvUsersEN.UserStateName; //用户状态名
}
if (arrFldSet.Contains(convUsers.Password, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.Password = objvUsersEN.Password == "[null]" ? null :  objvUsersEN.Password; //口令
}
if (arrFldSet.Contains(convUsers.IsGpUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.IsGpUser = objvUsersEN.IsGpUser; //是否Gp用户
}
if (arrFldSet.Contains(convUsers.BeginYearMonth, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.BeginYearMonth = objvUsersEN.BeginYearMonth == "[null]" ? null :  objvUsersEN.BeginYearMonth; //开始年月
}
if (arrFldSet.Contains(convUsers.EndYearMonth, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.EndYearMonth = objvUsersEN.EndYearMonth == "[null]" ? null :  objvUsersEN.EndYearMonth; //结束年月
}
if (arrFldSet.Contains(convUsers.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.IdGradeBase = objvUsersEN.IdGradeBase == "[null]" ? null :  objvUsersEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convUsers.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.GradeBaseName = objvUsersEN.GradeBaseName == "[null]" ? null :  objvUsersEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convUsers.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.IdXzCollege = objvUsersEN.IdXzCollege == "[null]" ? null :  objvUsersEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convUsers.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.CollegeId = objvUsersEN.CollegeId == "[null]" ? null :  objvUsersEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convUsers.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.CollegeName = objvUsersEN.CollegeName == "[null]" ? null :  objvUsersEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convUsers.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.CollegeNameA = objvUsersEN.CollegeNameA == "[null]" ? null :  objvUsersEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convUsers.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.IdXzMajor = objvUsersEN.IdXzMajor == "[null]" ? null :  objvUsersEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convUsers.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.MajorName = objvUsersEN.MajorName == "[null]" ? null :  objvUsersEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convUsers.IsLeaved, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.IsLeaved = objvUsersEN.IsLeaved; //是否离开
}
if (arrFldSet.Contains(convUsers.StuIdTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.StuIdTeacherId = objvUsersEN.StuIdTeacherId == "[null]" ? null :  objvUsersEN.StuIdTeacherId; //学工号
}
if (arrFldSet.Contains(convUsers.IdentityId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.IdentityId = objvUsersEN.IdentityId; //身份Id
}
if (arrFldSet.Contains(convUsers.IdentityDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.IdentityDesc = objvUsersEN.IdentityDesc == "[null]" ? null :  objvUsersEN.IdentityDesc; //身份描述
}
if (arrFldSet.Contains(convUsers.AuditDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.AuditDate = objvUsersEN.AuditDate == "[null]" ? null :  objvUsersEN.AuditDate; //AuditDate
}
if (arrFldSet.Contains(convUsers.AuditUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.AuditUser = objvUsersEN.AuditUser == "[null]" ? null :  objvUsersEN.AuditUser; //AuditUser
}
if (arrFldSet.Contains(convUsers.IsAudit, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.IsAudit = objvUsersEN.IsAudit; //是否审核
}
if (arrFldSet.Contains(convUsers.IsRegister, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.IsRegister = objvUsersEN.IsRegister; //IsRegister
}
if (arrFldSet.Contains(convUsers.RegisterDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.RegisterDate = objvUsersEN.RegisterDate == "[null]" ? null :  objvUsersEN.RegisterDate; //RegisterDate
}
if (arrFldSet.Contains(convUsers.MobilePhone, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.MobilePhone = objvUsersEN.MobilePhone == "[null]" ? null :  objvUsersEN.MobilePhone; //手机
}
if (arrFldSet.Contains(convUsers.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.UpdDate = objvUsersEN.UpdDate == "[null]" ? null :  objvUsersEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convUsers.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.UpdUser = objvUsersEN.UpdUser == "[null]" ? null :  objvUsersEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convUsers.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.Memo = objvUsersEN.Memo == "[null]" ? null :  objvUsersEN.Memo; //备注
}
if (arrFldSet.Contains(convUsers.UserNameWithUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.UserNameWithUserId = objvUsersEN.UserNameWithUserId; //UserNameWithUserId
}
if (arrFldSet.Contains(convUsers.OpenId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.OpenId = objvUsersEN.OpenId == "[null]" ? null :  objvUsersEN.OpenId; //微信OpenId
}
if (arrFldSet.Contains(convUsers.AvatarsPicture, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.AvatarsPicture = objvUsersEN.AvatarsPicture == "[null]" ? null :  objvUsersEN.AvatarsPicture; //虚拟头像
}
if (arrFldSet.Contains(convUsers.Email, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.Email = objvUsersEN.Email == "[null]" ? null :  objvUsersEN.Email; //电子邮箱
}
if (arrFldSet.Contains(convUsers.PhoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.PhoneNumber = objvUsersEN.PhoneNumber == "[null]" ? null :  objvUsersEN.PhoneNumber; //电话
}
if (arrFldSet.Contains(convUsers.HeadPic, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.HeadPic = objvUsersEN.HeadPic == "[null]" ? null :  objvUsersEN.HeadPic; //头像
}
if (arrFldSet.Contains(convUsers.IsGSuser, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersEN.IsGSuser = objvUsersEN.IsGSuser; //是否GS用户
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
 /// <param name = "objvUsersEN">源简化对象</param>
 public static void AccessFldValueNull(clsvUsersEN objvUsersEN)
{
try
{
if (objvUsersEN.UserName == "[null]") objvUsersEN.UserName = null; //用户名
if (objvUsersEN.UserStateName == "[null]") objvUsersEN.UserStateName = null; //用户状态名
if (objvUsersEN.Password == "[null]") objvUsersEN.Password = null; //口令
if (objvUsersEN.BeginYearMonth == "[null]") objvUsersEN.BeginYearMonth = null; //开始年月
if (objvUsersEN.EndYearMonth == "[null]") objvUsersEN.EndYearMonth = null; //结束年月
if (objvUsersEN.IdGradeBase == "[null]") objvUsersEN.IdGradeBase = null; //年级流水号
if (objvUsersEN.GradeBaseName == "[null]") objvUsersEN.GradeBaseName = null; //年级名称
if (objvUsersEN.IdXzCollege == "[null]") objvUsersEN.IdXzCollege = null; //学院流水号
if (objvUsersEN.CollegeId == "[null]") objvUsersEN.CollegeId = null; //学院ID
if (objvUsersEN.CollegeName == "[null]") objvUsersEN.CollegeName = null; //学院名称
if (objvUsersEN.CollegeNameA == "[null]") objvUsersEN.CollegeNameA = null; //学院名称简写
if (objvUsersEN.IdXzMajor == "[null]") objvUsersEN.IdXzMajor = null; //专业流水号
if (objvUsersEN.MajorName == "[null]") objvUsersEN.MajorName = null; //专业名称
if (objvUsersEN.StuIdTeacherId == "[null]") objvUsersEN.StuIdTeacherId = null; //学工号
if (objvUsersEN.IdentityDesc == "[null]") objvUsersEN.IdentityDesc = null; //身份描述
if (objvUsersEN.AuditDate == "[null]") objvUsersEN.AuditDate = null; //AuditDate
if (objvUsersEN.AuditUser == "[null]") objvUsersEN.AuditUser = null; //AuditUser
if (objvUsersEN.RegisterDate == "[null]") objvUsersEN.RegisterDate = null; //RegisterDate
if (objvUsersEN.MobilePhone == "[null]") objvUsersEN.MobilePhone = null; //手机
if (objvUsersEN.UpdDate == "[null]") objvUsersEN.UpdDate = null; //修改日期
if (objvUsersEN.UpdUser == "[null]") objvUsersEN.UpdUser = null; //修改人
if (objvUsersEN.Memo == "[null]") objvUsersEN.Memo = null; //备注
if (objvUsersEN.OpenId == "[null]") objvUsersEN.OpenId = null; //微信OpenId
if (objvUsersEN.AvatarsPicture == "[null]") objvUsersEN.AvatarsPicture = null; //虚拟头像
if (objvUsersEN.Email == "[null]") objvUsersEN.Email = null; //电子邮箱
if (objvUsersEN.PhoneNumber == "[null]") objvUsersEN.PhoneNumber = null; //电话
if (objvUsersEN.HeadPic == "[null]") objvUsersEN.HeadPic = null; //头像
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserId");
//if (arrvUsersObjLstCache == null)
//{
//arrvUsersObjLstCache = vUsersDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUsersEN GetObjByUserIdCache(string strUserId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvUsersEN._CurrTabName);
List<clsvUsersEN> arrvUsersObjLstCache = GetObjLstCache();
IEnumerable <clsvUsersEN> arrvUsersObjLst_Sel =
arrvUsersObjLstCache
.Where(x=> x.UserId == strUserId 
);
if (arrvUsersObjLst_Sel.Count() == 0)
{
   clsvUsersEN obj = clsvUsersBL.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvUsersObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUsersEN> GetAllvUsersObjLstCache()
{
//获取缓存中的对象列表
List<clsvUsersEN> arrvUsersObjLstCache = GetObjLstCache(); 
return arrvUsersObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUsersEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvUsersEN._CurrTabName);
List<clsvUsersEN> arrvUsersObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvUsersObjLstCache;
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
string strKey = string.Format("{0}", clsvUsersEN._CurrTabName);
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
 /// 日期:2024-02-27
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
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convUsers.AttributeName));
throw new Exception(strMsg);
}
var objvUsers = clsvUsersBL.GetObjByUserIdCache(strUserId);
if (objvUsers == null) return "";
return objvUsers[strOutFldName].ToString();
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvUsersCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvUsersEN objvUsersCond)
{
List<clsvUsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUsers.AttributeName)
{
if (objvUsersCond.IsUpdated(strFldName) == false) continue;
if (objvUsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUsersCond[strFldName].ToString());
}
else
{
if (objvUsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUsersCond[strFldName]));
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