
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserLog4FunctionWApi
 表名:vUserLog4Function(01120338)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:23
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理
 模块英文名:LogManage
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
public static class clsvUserLog4FunctionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetmId(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, long lngmId, string strComparisonOp="")
	{
objvUserLog4FunctionEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.mId) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.mId, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.mId] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetUserId(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convUserLog4Function.UserId);
objvUserLog4FunctionEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.UserId) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.UserId, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.UserId] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetUserName(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convUserLog4Function.UserName);
objvUserLog4FunctionEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.UserName) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.UserName, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.UserName] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetRoleName(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleName, 100, convUserLog4Function.RoleName);
objvUserLog4FunctionEN.RoleName = strRoleName; //角色名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.RoleName) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.RoleName, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.RoleName] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetUseTime(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, string strUseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUseTime, 20, convUserLog4Function.UseTime);
objvUserLog4FunctionEN.UseTime = strUseTime; //使用时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.UseTime) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.UseTime, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.UseTime] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetFunctionId(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, string strFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionId, 4, convUserLog4Function.FunctionId);
clsCheckSql.CheckFieldForeignKey(strFunctionId, 4, convUserLog4Function.FunctionId);
objvUserLog4FunctionEN.FunctionId = strFunctionId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.FunctionId) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.FunctionId, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.FunctionId] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetFunctionName(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, string strFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionName, 100, convUserLog4Function.FunctionName);
objvUserLog4FunctionEN.FunctionName = strFunctionName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.FunctionName) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.FunctionName, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.FunctionName] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetFunctionNameCH(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, string strFunctionNameCH, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionNameCH, 255, convUserLog4Function.FunctionNameCH);
objvUserLog4FunctionEN.FunctionNameCH = strFunctionNameCH; //功能中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.FunctionNameCH) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.FunctionNameCH, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.FunctionNameCH] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetModuleName(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, string strModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModuleName, 255, convUserLog4Function.ModuleName);
objvUserLog4FunctionEN.ModuleName = strModuleName; //模块名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.ModuleName) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.ModuleName, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.ModuleName] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetIsStudent(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, bool bolIsStudent, string strComparisonOp="")
	{
objvUserLog4FunctionEN.IsStudent = bolIsStudent; //是否学生
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.IsStudent) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.IsStudent, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.IsStudent] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetIsStudent_Real(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, bool bolIsStudent_Real, string strComparisonOp="")
	{
objvUserLog4FunctionEN.IsStudent_Real = bolIsStudent_Real; //IsStudent_Real
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.IsStudent_Real) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.IsStudent_Real, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.IsStudent_Real] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetIsTeacher(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, bool bolIsTeacher, string strComparisonOp="")
	{
objvUserLog4FunctionEN.IsTeacher = bolIsTeacher; //是否教师
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.IsTeacher) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.IsTeacher, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.IsTeacher] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetIsTeacher_Real(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, bool bolIsTeacher_Real, string strComparisonOp="")
	{
objvUserLog4FunctionEN.IsTeacher_Real = bolIsTeacher_Real; //IsTeacher_Real
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.IsTeacher_Real) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.IsTeacher_Real, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.IsTeacher_Real] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetIsQuestion(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, bool bolIsQuestion, string strComparisonOp="")
	{
objvUserLog4FunctionEN.IsQuestion = bolIsQuestion; //是否题目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.IsQuestion) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.IsQuestion, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.IsQuestion] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetPagePath(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, string strPagePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPagePath, 50, convUserLog4Function.PagePath);
objvUserLog4FunctionEN.PagePath = strPagePath; //页面路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.PagePath) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.PagePath, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.PagePath] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetPageName(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, string strPageName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageName, 100, convUserLog4Function.PageName);
objvUserLog4FunctionEN.PageName = strPageName; //页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.PageName) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.PageName, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.PageName] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetUpdDate(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convUserLog4Function.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUserLog4Function.UpdDate);
objvUserLog4FunctionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.UpdDate) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.UpdDate, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.UpdDate] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetUpdUser(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convUserLog4Function.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convUserLog4Function.UpdUser);
objvUserLog4FunctionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.UpdUser) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.UpdUser, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.UpdUser] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserLog4FunctionEN SetMemo(this clsvUserLog4FunctionEN objvUserLog4FunctionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserLog4Function.Memo);
objvUserLog4FunctionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLog4FunctionEN.dicFldComparisonOp.ContainsKey(convUserLog4Function.Memo) == false)
{
objvUserLog4FunctionEN.dicFldComparisonOp.Add(convUserLog4Function.Memo, strComparisonOp);
}
else
{
objvUserLog4FunctionEN.dicFldComparisonOp[convUserLog4Function.Memo] = strComparisonOp;
}
}
return objvUserLog4FunctionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUserLog4FunctionEN objvUserLog4Function_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.mId) == true)
{
string strComparisonOp_mId = objvUserLog4Function_Cond.dicFldComparisonOp[convUserLog4Function.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convUserLog4Function.mId, objvUserLog4Function_Cond.mId, strComparisonOp_mId);
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.UserId) == true)
{
string strComparisonOp_UserId = objvUserLog4Function_Cond.dicFldComparisonOp[convUserLog4Function.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLog4Function.UserId, objvUserLog4Function_Cond.UserId, strComparisonOp_UserId);
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.UserName) == true)
{
string strComparisonOp_UserName = objvUserLog4Function_Cond.dicFldComparisonOp[convUserLog4Function.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLog4Function.UserName, objvUserLog4Function_Cond.UserName, strComparisonOp_UserName);
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.RoleName) == true)
{
string strComparisonOp_RoleName = objvUserLog4Function_Cond.dicFldComparisonOp[convUserLog4Function.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLog4Function.RoleName, objvUserLog4Function_Cond.RoleName, strComparisonOp_RoleName);
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.UseTime) == true)
{
string strComparisonOp_UseTime = objvUserLog4Function_Cond.dicFldComparisonOp[convUserLog4Function.UseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLog4Function.UseTime, objvUserLog4Function_Cond.UseTime, strComparisonOp_UseTime);
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.FunctionId) == true)
{
string strComparisonOp_FunctionId = objvUserLog4Function_Cond.dicFldComparisonOp[convUserLog4Function.FunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLog4Function.FunctionId, objvUserLog4Function_Cond.FunctionId, strComparisonOp_FunctionId);
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.FunctionName) == true)
{
string strComparisonOp_FunctionName = objvUserLog4Function_Cond.dicFldComparisonOp[convUserLog4Function.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLog4Function.FunctionName, objvUserLog4Function_Cond.FunctionName, strComparisonOp_FunctionName);
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.FunctionNameCH) == true)
{
string strComparisonOp_FunctionNameCH = objvUserLog4Function_Cond.dicFldComparisonOp[convUserLog4Function.FunctionNameCH];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLog4Function.FunctionNameCH, objvUserLog4Function_Cond.FunctionNameCH, strComparisonOp_FunctionNameCH);
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.ModuleName) == true)
{
string strComparisonOp_ModuleName = objvUserLog4Function_Cond.dicFldComparisonOp[convUserLog4Function.ModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLog4Function.ModuleName, objvUserLog4Function_Cond.ModuleName, strComparisonOp_ModuleName);
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.IsStudent) == true)
{
if (objvUserLog4Function_Cond.IsStudent == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserLog4Function.IsStudent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserLog4Function.IsStudent);
}
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.IsStudent_Real) == true)
{
if (objvUserLog4Function_Cond.IsStudent_Real == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserLog4Function.IsStudent_Real);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserLog4Function.IsStudent_Real);
}
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.IsTeacher) == true)
{
if (objvUserLog4Function_Cond.IsTeacher == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserLog4Function.IsTeacher);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserLog4Function.IsTeacher);
}
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.IsTeacher_Real) == true)
{
if (objvUserLog4Function_Cond.IsTeacher_Real == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserLog4Function.IsTeacher_Real);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserLog4Function.IsTeacher_Real);
}
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.IsQuestion) == true)
{
if (objvUserLog4Function_Cond.IsQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserLog4Function.IsQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserLog4Function.IsQuestion);
}
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.PagePath) == true)
{
string strComparisonOp_PagePath = objvUserLog4Function_Cond.dicFldComparisonOp[convUserLog4Function.PagePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLog4Function.PagePath, objvUserLog4Function_Cond.PagePath, strComparisonOp_PagePath);
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.PageName) == true)
{
string strComparisonOp_PageName = objvUserLog4Function_Cond.dicFldComparisonOp[convUserLog4Function.PageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLog4Function.PageName, objvUserLog4Function_Cond.PageName, strComparisonOp_PageName);
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvUserLog4Function_Cond.dicFldComparisonOp[convUserLog4Function.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLog4Function.UpdDate, objvUserLog4Function_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvUserLog4Function_Cond.dicFldComparisonOp[convUserLog4Function.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLog4Function.UpdUser, objvUserLog4Function_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvUserLog4Function_Cond.IsUpdated(convUserLog4Function.Memo) == true)
{
string strComparisonOp_Memo = objvUserLog4Function_Cond.dicFldComparisonOp[convUserLog4Function.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLog4Function.Memo, objvUserLog4Function_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户使用功能日志(vUserLog4Function)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvUserLog4FunctionWApi
{
private static readonly string mstrApiControllerName = "vUserLog4FunctionApi";

 public clsvUserLog4FunctionWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserLog4FunctionEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvUserLog4FunctionEN objvUserLog4FunctionEN = null;
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
objvUserLog4FunctionEN = JsonConvert.DeserializeObject<clsvUserLog4FunctionEN>((string)jobjReturn["ReturnObj"]);
return objvUserLog4FunctionEN;
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
public static clsvUserLog4FunctionEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvUserLog4FunctionEN objvUserLog4FunctionEN = null;
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
objvUserLog4FunctionEN = JsonConvert.DeserializeObject<clsvUserLog4FunctionEN>((string)jobjReturn["ReturnObj"]);
return objvUserLog4FunctionEN;
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
public static clsvUserLog4FunctionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvUserLog4FunctionEN objvUserLog4FunctionEN = null;
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
objvUserLog4FunctionEN = JsonConvert.DeserializeObject<clsvUserLog4FunctionEN>((string)jobjReturn["ReturnObj"]);
return objvUserLog4FunctionEN;
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
public static clsvUserLog4FunctionEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvUserLog4FunctionEN._CurrTabName_S);
List<clsvUserLog4FunctionEN> arrvUserLog4FunctionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUserLog4FunctionEN> arrvUserLog4FunctionObjLst_Sel =
from objvUserLog4FunctionEN in arrvUserLog4FunctionObjLst_Cache
where objvUserLog4FunctionEN.mId == lngmId
select objvUserLog4FunctionEN;
if (arrvUserLog4FunctionObjLst_Sel.Count() == 0)
{
   clsvUserLog4FunctionEN obj = clsvUserLog4FunctionWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvUserLog4FunctionObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserLog4FunctionEN> GetObjLst(string strWhereCond)
{
 List<clsvUserLog4FunctionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserLog4FunctionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserLog4FunctionEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvUserLog4FunctionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserLog4FunctionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvUserLog4FunctionEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvUserLog4FunctionEN._CurrTabName_S);
List<clsvUserLog4FunctionEN> arrvUserLog4FunctionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUserLog4FunctionEN> arrvUserLog4FunctionObjLst_Sel =
from objvUserLog4FunctionEN in arrvUserLog4FunctionObjLst_Cache
where arrMId.Contains(objvUserLog4FunctionEN.mId)
select objvUserLog4FunctionEN;
return arrvUserLog4FunctionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserLog4FunctionEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvUserLog4FunctionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserLog4FunctionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserLog4FunctionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvUserLog4FunctionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserLog4FunctionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserLog4FunctionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvUserLog4FunctionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserLog4FunctionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserLog4FunctionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvUserLog4FunctionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserLog4FunctionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserLog4FunctionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvUserLog4FunctionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserLog4FunctionEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvUserLog4FunctionENS">源对象</param>
 /// <param name = "objvUserLog4FunctionENT">目标对象</param>
 public static void CopyTo(clsvUserLog4FunctionEN objvUserLog4FunctionENS, clsvUserLog4FunctionEN objvUserLog4FunctionENT)
{
try
{
objvUserLog4FunctionENT.mId = objvUserLog4FunctionENS.mId; //mId
objvUserLog4FunctionENT.UserId = objvUserLog4FunctionENS.UserId; //用户ID
objvUserLog4FunctionENT.UserName = objvUserLog4FunctionENS.UserName; //用户名
objvUserLog4FunctionENT.RoleName = objvUserLog4FunctionENS.RoleName; //角色名
objvUserLog4FunctionENT.UseTime = objvUserLog4FunctionENS.UseTime; //使用时间
objvUserLog4FunctionENT.FunctionId = objvUserLog4FunctionENS.FunctionId; //功能Id
objvUserLog4FunctionENT.FunctionName = objvUserLog4FunctionENS.FunctionName; //函数名
objvUserLog4FunctionENT.FunctionNameCH = objvUserLog4FunctionENS.FunctionNameCH; //功能中文名
objvUserLog4FunctionENT.ModuleName = objvUserLog4FunctionENS.ModuleName; //模块名
objvUserLog4FunctionENT.IsStudent = objvUserLog4FunctionENS.IsStudent; //是否学生
objvUserLog4FunctionENT.IsStudent_Real = objvUserLog4FunctionENS.IsStudent_Real; //IsStudent_Real
objvUserLog4FunctionENT.IsTeacher = objvUserLog4FunctionENS.IsTeacher; //是否教师
objvUserLog4FunctionENT.IsTeacher_Real = objvUserLog4FunctionENS.IsTeacher_Real; //IsTeacher_Real
objvUserLog4FunctionENT.IsQuestion = objvUserLog4FunctionENS.IsQuestion; //是否题目
objvUserLog4FunctionENT.PagePath = objvUserLog4FunctionENS.PagePath; //页面路径
objvUserLog4FunctionENT.PageName = objvUserLog4FunctionENS.PageName; //页面名称
objvUserLog4FunctionENT.UpdDate = objvUserLog4FunctionENS.UpdDate; //修改日期
objvUserLog4FunctionENT.UpdUser = objvUserLog4FunctionENS.UpdUser; //修改人
objvUserLog4FunctionENT.Memo = objvUserLog4FunctionENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvUserLog4FunctionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvUserLog4FunctionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvUserLog4FunctionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvUserLog4FunctionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvUserLog4FunctionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvUserLog4FunctionEN.AttributeName)
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
if (clsFunctionNameTabWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionNameTabWApi没有刷新缓存机制(clsFunctionNameTabWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserLog4FunctionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserLog4FunctionWApi没有刷新缓存机制(clsUserLog4FunctionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvUserLog4FunctionObjLst_Cache == null)
//{
//arrvUserLog4FunctionObjLst_Cache = await clsvUserLog4FunctionWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvUserLog4FunctionEN._CurrTabName_S);
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
public static List<clsvUserLog4FunctionEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvUserLog4FunctionEN._CurrTabName_S);
List<clsvUserLog4FunctionEN> arrvUserLog4FunctionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvUserLog4FunctionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvUserLog4FunctionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convUserLog4Function.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convUserLog4Function.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convUserLog4Function.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convUserLog4Function.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convUserLog4Function.UseTime, Type.GetType("System.String"));
objDT.Columns.Add(convUserLog4Function.FunctionId, Type.GetType("System.String"));
objDT.Columns.Add(convUserLog4Function.FunctionName, Type.GetType("System.String"));
objDT.Columns.Add(convUserLog4Function.FunctionNameCH, Type.GetType("System.String"));
objDT.Columns.Add(convUserLog4Function.ModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convUserLog4Function.IsStudent, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserLog4Function.IsStudent_Real, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserLog4Function.IsTeacher, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserLog4Function.IsTeacher_Real, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserLog4Function.IsQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserLog4Function.PagePath, Type.GetType("System.String"));
objDT.Columns.Add(convUserLog4Function.PageName, Type.GetType("System.String"));
objDT.Columns.Add(convUserLog4Function.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convUserLog4Function.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convUserLog4Function.Memo, Type.GetType("System.String"));
foreach (clsvUserLog4FunctionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convUserLog4Function.mId] = objInFor[convUserLog4Function.mId];
objDR[convUserLog4Function.UserId] = objInFor[convUserLog4Function.UserId];
objDR[convUserLog4Function.UserName] = objInFor[convUserLog4Function.UserName];
objDR[convUserLog4Function.RoleName] = objInFor[convUserLog4Function.RoleName];
objDR[convUserLog4Function.UseTime] = objInFor[convUserLog4Function.UseTime];
objDR[convUserLog4Function.FunctionId] = objInFor[convUserLog4Function.FunctionId];
objDR[convUserLog4Function.FunctionName] = objInFor[convUserLog4Function.FunctionName];
objDR[convUserLog4Function.FunctionNameCH] = objInFor[convUserLog4Function.FunctionNameCH];
objDR[convUserLog4Function.ModuleName] = objInFor[convUserLog4Function.ModuleName];
objDR[convUserLog4Function.IsStudent] = objInFor[convUserLog4Function.IsStudent];
objDR[convUserLog4Function.IsStudent_Real] = objInFor[convUserLog4Function.IsStudent_Real];
objDR[convUserLog4Function.IsTeacher] = objInFor[convUserLog4Function.IsTeacher];
objDR[convUserLog4Function.IsTeacher_Real] = objInFor[convUserLog4Function.IsTeacher_Real];
objDR[convUserLog4Function.IsQuestion] = objInFor[convUserLog4Function.IsQuestion];
objDR[convUserLog4Function.PagePath] = objInFor[convUserLog4Function.PagePath];
objDR[convUserLog4Function.PageName] = objInFor[convUserLog4Function.PageName];
objDR[convUserLog4Function.UpdDate] = objInFor[convUserLog4Function.UpdDate];
objDR[convUserLog4Function.UpdUser] = objInFor[convUserLog4Function.UpdUser];
objDR[convUserLog4Function.Memo] = objInFor[convUserLog4Function.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}