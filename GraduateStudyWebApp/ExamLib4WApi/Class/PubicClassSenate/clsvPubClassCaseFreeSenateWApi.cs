
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseFreeSenateWApi
 表名:vPubClassCaseFreeSenate(01120412)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:05
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩
 模块英文名:PubicClassSenate
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
public static class clsvPubClassCaseFreeSenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN Setid_PubClassCaseFreeSenate(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, long lngid_PubClassCaseFreeSenate, string strComparisonOp="")
	{
objvPubClassCaseFreeSenateEN.id_PubClassCaseFreeSenate = lngid_PubClassCaseFreeSenate; //公开课案例自由评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.id_PubClassCaseFreeSenate) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.id_PubClassCaseFreeSenate, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.id_PubClassCaseFreeSenate] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN Setid_PubClassCase(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strid_PubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubClassCase, convPubClassCaseFreeSenate.id_PubClassCase);
clsCheckSql.CheckFieldLen(strid_PubClassCase, 8, convPubClassCaseFreeSenate.id_PubClassCase);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCase, 8, convPubClassCaseFreeSenate.id_PubClassCase);
objvPubClassCaseFreeSenateEN.id_PubClassCase = strid_PubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.id_PubClassCase) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.id_PubClassCase, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.id_PubClassCase] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseID(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseID, convPubClassCaseFreeSenate.PubClassCaseID);
clsCheckSql.CheckFieldLen(strPubClassCaseID, 8, convPubClassCaseFreeSenate.PubClassCaseID);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseID, 8, convPubClassCaseFreeSenate.PubClassCaseID);
objvPubClassCaseFreeSenateEN.PubClassCaseID = strPubClassCaseID; //案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.PubClassCaseID) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.PubClassCaseID, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseID] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseName(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseName, convPubClassCaseFreeSenate.PubClassCaseName);
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, convPubClassCaseFreeSenate.PubClassCaseName);
objvPubClassCaseFreeSenateEN.PubClassCaseName = strPubClassCaseName; //案例课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.PubClassCaseName) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.PubClassCaseName, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseName] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseExecutor(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, convPubClassCaseFreeSenate.PubClassCaseExecutor);
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = strPubClassCaseExecutor; //案例执教者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.PubClassCaseExecutor) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.PubClassCaseExecutor, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseExecutor] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseTheme(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTheme, 500, convPubClassCaseFreeSenate.PubClassCaseTheme);
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = strPubClassCaseTheme; //案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.PubClassCaseTheme) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.PubClassCaseTheme, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseTheme] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetUserId(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convPubClassCaseFreeSenate.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convPubClassCaseFreeSenate.UserId);
objvPubClassCaseFreeSenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.UserId) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.UserId, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.UserId] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetUserName(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convPubClassCaseFreeSenate.UserName);
objvPubClassCaseFreeSenateEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.UserName) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.UserName, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.UserName] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetAppraiseTheme(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strAppraiseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTheme, 200, convPubClassCaseFreeSenate.AppraiseTheme);
objvPubClassCaseFreeSenateEN.AppraiseTheme = strAppraiseTheme; //评议主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.AppraiseTheme) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.AppraiseTheme, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.AppraiseTheme] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateTitle(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateTitle, 200, convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = strPubClassCaseFreeSenateTitle; //公开课案例自由评议标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateConten(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateConten, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateConten, 2000, convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = strPubClassCaseFreeSenateConten; //公开课案例自由评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateDate(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateDate, 8, convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseFreeSenateDate, 8, convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = strPubClassCaseFreeSenateDate; //公开课案例自由评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateTime(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateTime, 6, convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseFreeSenateTime, 6, convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = strPubClassCaseFreeSenateTime; //公开课案例自由评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetBrowseCount(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, int intBrowseCount, string strComparisonOp="")
	{
objvPubClassCaseFreeSenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.BrowseCount) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.BrowseCount, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.BrowseCount] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetVideoStopTime(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strVideoStopTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoStopTime, 48, convPubClassCaseFreeSenate.VideoStopTime);
objvPubClassCaseFreeSenateEN.VideoStopTime = strVideoStopTime; //公开课案例视频暂停时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.VideoStopTime) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.VideoStopTime, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.VideoStopTime] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetIsVisible(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, bool bolIsVisible, string strComparisonOp="")
	{
objvPubClassCaseFreeSenateEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.IsVisible) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.IsVisible, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.IsVisible] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN Setid_Discipline(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convPubClassCaseFreeSenate.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convPubClassCaseFreeSenate.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convPubClassCaseFreeSenate.id_Discipline);
objvPubClassCaseFreeSenateEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.id_Discipline) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.id_Discipline, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.id_Discipline] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetDisciplineID(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineID, convPubClassCaseFreeSenate.DisciplineID);
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convPubClassCaseFreeSenate.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convPubClassCaseFreeSenate.DisciplineID);
objvPubClassCaseFreeSenateEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.DisciplineID) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.DisciplineID, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.DisciplineID] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetDisciplineName(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convPubClassCaseFreeSenate.DisciplineName);
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convPubClassCaseFreeSenate.DisciplineName);
objvPubClassCaseFreeSenateEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.DisciplineName) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.DisciplineName, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.DisciplineName] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN Setid_StudyLevel(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convPubClassCaseFreeSenate.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convPubClassCaseFreeSenate.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convPubClassCaseFreeSenate.id_StudyLevel);
objvPubClassCaseFreeSenateEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.id_StudyLevel) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.id_StudyLevel, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.id_StudyLevel] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetStudyLevelName(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convPubClassCaseFreeSenate.StudyLevelName);
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convPubClassCaseFreeSenate.StudyLevelName);
objvPubClassCaseFreeSenateEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.StudyLevelName) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.StudyLevelName, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.StudyLevelName] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseTeachDate(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseTeachDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTeachDate, 8, convPubClassCaseFreeSenate.PubClassCaseTeachDate);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTeachDate, 8, convPubClassCaseFreeSenate.PubClassCaseTeachDate);
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = strPubClassCaseTeachDate; //案例授课日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.PubClassCaseTeachDate) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.PubClassCaseTeachDate, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseTeachDate] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseDateIn(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseDateIn, 8, convPubClassCaseFreeSenate.PubClassCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseDateIn, 8, convPubClassCaseFreeSenate.PubClassCaseDateIn);
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = strPubClassCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.PubClassCaseDateIn) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.PubClassCaseDateIn, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseDateIn] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN Setid_TeachingPlan(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingPlan, convPubClassCaseFreeSenate.id_TeachingPlan);
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convPubClassCaseFreeSenate.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convPubClassCaseFreeSenate.id_TeachingPlan);
objvPubClassCaseFreeSenateEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.id_TeachingPlan) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.id_TeachingPlan, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.id_TeachingPlan] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetSubjectName(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strSubjectName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSubjectName, convPubClassCaseFreeSenate.SubjectName);
clsCheckSql.CheckFieldLen(strSubjectName, 200, convPubClassCaseFreeSenate.SubjectName);
objvPubClassCaseFreeSenateEN.SubjectName = strSubjectName; //课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.SubjectName) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.SubjectName, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.SubjectName] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN Setid_PubCaseType(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strid_PubCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubCaseType, convPubClassCaseFreeSenate.id_PubCaseType);
clsCheckSql.CheckFieldLen(strid_PubCaseType, 4, convPubClassCaseFreeSenate.id_PubCaseType);
clsCheckSql.CheckFieldForeignKey(strid_PubCaseType, 4, convPubClassCaseFreeSenate.id_PubCaseType);
objvPubClassCaseFreeSenateEN.id_PubCaseType = strid_PubCaseType; //公开课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.id_PubCaseType) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.id_PubCaseType, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.id_PubCaseType] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubCaseTypeID(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubCaseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeID, convPubClassCaseFreeSenate.PubCaseTypeID);
clsCheckSql.CheckFieldLen(strPubCaseTypeID, 4, convPubClassCaseFreeSenate.PubCaseTypeID);
clsCheckSql.CheckFieldForeignKey(strPubCaseTypeID, 4, convPubClassCaseFreeSenate.PubCaseTypeID);
objvPubClassCaseFreeSenateEN.PubCaseTypeID = strPubCaseTypeID; //公开课案例类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.PubCaseTypeID) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.PubCaseTypeID, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.PubCaseTypeID] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubCaseTypeName(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeName, convPubClassCaseFreeSenate.PubCaseTypeName);
clsCheckSql.CheckFieldLen(strPubCaseTypeName, 50, convPubClassCaseFreeSenate.PubCaseTypeName);
objvPubClassCaseFreeSenateEN.PubCaseTypeName = strPubCaseTypeName; //公开课案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.PubCaseTypeName) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.PubCaseTypeName, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.PubCaseTypeName] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetCollegeID(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convPubClassCaseFreeSenate.CollegeID);
objvPubClassCaseFreeSenateEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.CollegeID) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.CollegeID, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.CollegeID] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetCollegeName(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convPubClassCaseFreeSenate.CollegeName);
objvPubClassCaseFreeSenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.CollegeName) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.CollegeName, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.CollegeName] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN Setid_XzCollege(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convPubClassCaseFreeSenate.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convPubClassCaseFreeSenate.id_XzCollege);
objvPubClassCaseFreeSenateEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.id_XzCollege) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.id_XzCollege, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.id_XzCollege] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetIsLeaved(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, bool bolIsLeaved, string strComparisonOp="")
	{
objvPubClassCaseFreeSenateEN.IsLeaved = bolIsLeaved; //IsLeaved
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.IsLeaved) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.IsLeaved, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.IsLeaved] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetStuIdTeacherId(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strStuIdTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuIdTeacherId, 20, convPubClassCaseFreeSenate.StuIdTeacherId);
objvPubClassCaseFreeSenateEN.StuIdTeacherId = strStuIdTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.StuIdTeacherId) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.StuIdTeacherId, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.StuIdTeacherId] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetBrowseCount4Case(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvPubClassCaseFreeSenateEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.BrowseCount4Case) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.BrowseCount4Case, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.BrowseCount4Case] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetCollegeNameA(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convPubClassCaseFreeSenate.CollegeNameA);
objvPubClassCaseFreeSenateEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.CollegeNameA) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.CollegeNameA, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.CollegeNameA] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.id_PubClassCaseFreeSenate) == true)
{
string strComparisonOp_id_PubClassCaseFreeSenate = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.id_PubClassCaseFreeSenate];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseFreeSenate.id_PubClassCaseFreeSenate, objvPubClassCaseFreeSenate_Cond.id_PubClassCaseFreeSenate, strComparisonOp_id_PubClassCaseFreeSenate);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.id_PubClassCase) == true)
{
string strComparisonOp_id_PubClassCase = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.id_PubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.id_PubClassCase, objvPubClassCaseFreeSenate_Cond.id_PubClassCase, strComparisonOp_id_PubClassCase);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseID) == true)
{
string strComparisonOp_PubClassCaseID = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseID, objvPubClassCaseFreeSenate_Cond.PubClassCaseID, strComparisonOp_PubClassCaseID);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseName) == true)
{
string strComparisonOp_PubClassCaseName = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseName, objvPubClassCaseFreeSenate_Cond.PubClassCaseName, strComparisonOp_PubClassCaseName);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseExecutor) == true)
{
string strComparisonOp_PubClassCaseExecutor = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseExecutor, objvPubClassCaseFreeSenate_Cond.PubClassCaseExecutor, strComparisonOp_PubClassCaseExecutor);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseTheme) == true)
{
string strComparisonOp_PubClassCaseTheme = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseTheme, objvPubClassCaseFreeSenate_Cond.PubClassCaseTheme, strComparisonOp_PubClassCaseTheme);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.UserId) == true)
{
string strComparisonOp_UserId = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.UserId, objvPubClassCaseFreeSenate_Cond.UserId, strComparisonOp_UserId);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.UserName) == true)
{
string strComparisonOp_UserName = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.UserName, objvPubClassCaseFreeSenate_Cond.UserName, strComparisonOp_UserName);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.AppraiseTheme) == true)
{
string strComparisonOp_AppraiseTheme = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.AppraiseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.AppraiseTheme, objvPubClassCaseFreeSenate_Cond.AppraiseTheme, strComparisonOp_AppraiseTheme);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle) == true)
{
string strComparisonOp_PubClassCaseFreeSenateTitle = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle, objvPubClassCaseFreeSenate_Cond.PubClassCaseFreeSenateTitle, strComparisonOp_PubClassCaseFreeSenateTitle);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten) == true)
{
string strComparisonOp_PubClassCaseFreeSenateConten = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten, objvPubClassCaseFreeSenate_Cond.PubClassCaseFreeSenateConten, strComparisonOp_PubClassCaseFreeSenateConten);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate) == true)
{
string strComparisonOp_PubClassCaseFreeSenateDate = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate, objvPubClassCaseFreeSenate_Cond.PubClassCaseFreeSenateDate, strComparisonOp_PubClassCaseFreeSenateDate);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime) == true)
{
string strComparisonOp_PubClassCaseFreeSenateTime = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime, objvPubClassCaseFreeSenate_Cond.PubClassCaseFreeSenateTime, strComparisonOp_PubClassCaseFreeSenateTime);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseFreeSenate.BrowseCount, objvPubClassCaseFreeSenate_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.VideoStopTime) == true)
{
string strComparisonOp_VideoStopTime = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.VideoStopTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.VideoStopTime, objvPubClassCaseFreeSenate_Cond.VideoStopTime, strComparisonOp_VideoStopTime);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.IsVisible) == true)
{
if (objvPubClassCaseFreeSenate_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseFreeSenate.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseFreeSenate.IsVisible);
}
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.id_Discipline, objvPubClassCaseFreeSenate_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.DisciplineID, objvPubClassCaseFreeSenate_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.DisciplineName, objvPubClassCaseFreeSenate_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.id_StudyLevel, objvPubClassCaseFreeSenate_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.StudyLevelName, objvPubClassCaseFreeSenate_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseTeachDate) == true)
{
string strComparisonOp_PubClassCaseTeachDate = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseTeachDate, objvPubClassCaseFreeSenate_Cond.PubClassCaseTeachDate, strComparisonOp_PubClassCaseTeachDate);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseDateIn) == true)
{
string strComparisonOp_PubClassCaseDateIn = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseDateIn, objvPubClassCaseFreeSenate_Cond.PubClassCaseDateIn, strComparisonOp_PubClassCaseDateIn);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.id_TeachingPlan, objvPubClassCaseFreeSenate_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.SubjectName) == true)
{
string strComparisonOp_SubjectName = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.SubjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.SubjectName, objvPubClassCaseFreeSenate_Cond.SubjectName, strComparisonOp_SubjectName);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.id_PubCaseType) == true)
{
string strComparisonOp_id_PubCaseType = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.id_PubCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.id_PubCaseType, objvPubClassCaseFreeSenate_Cond.id_PubCaseType, strComparisonOp_id_PubCaseType);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.PubCaseTypeID) == true)
{
string strComparisonOp_PubCaseTypeID = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubCaseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubCaseTypeID, objvPubClassCaseFreeSenate_Cond.PubCaseTypeID, strComparisonOp_PubCaseTypeID);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.PubCaseTypeName) == true)
{
string strComparisonOp_PubCaseTypeName = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubCaseTypeName, objvPubClassCaseFreeSenate_Cond.PubCaseTypeName, strComparisonOp_PubCaseTypeName);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.CollegeID, objvPubClassCaseFreeSenate_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.CollegeName, objvPubClassCaseFreeSenate_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.id_XzCollege, objvPubClassCaseFreeSenate_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.IsLeaved) == true)
{
if (objvPubClassCaseFreeSenate_Cond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseFreeSenate.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseFreeSenate.IsLeaved);
}
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.StuIdTeacherId) == true)
{
string strComparisonOp_StuIdTeacherId = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.StuIdTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.StuIdTeacherId, objvPubClassCaseFreeSenate_Cond.StuIdTeacherId, strComparisonOp_StuIdTeacherId);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseFreeSenate.BrowseCount4Case, objvPubClassCaseFreeSenate_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvPubClassCaseFreeSenate_Cond.IsUpdated(convPubClassCaseFreeSenate.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvPubClassCaseFreeSenate_Cond.dicFldComparisonOp[convPubClassCaseFreeSenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.CollegeNameA, objvPubClassCaseFreeSenate_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v公开课案例自由评议(vPubClassCaseFreeSenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPubClassCaseFreeSenateWApi
{
private static readonly string mstrApiControllerName = "vPubClassCaseFreeSenateApi";

 public clsvPubClassCaseFreeSenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_PubClassCaseFreeSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseFreeSenateEN GetObjByid_PubClassCaseFreeSenate(long lngid_PubClassCaseFreeSenate)
{
string strAction = "GetObjByid_PubClassCaseFreeSenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCaseFreeSenate"] = lngid_PubClassCaseFreeSenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPubClassCaseFreeSenateEN = JsonConvert.DeserializeObject<clsvPubClassCaseFreeSenateEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCaseFreeSenateEN;
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
 /// <param name = "lngid_PubClassCaseFreeSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseFreeSenateEN GetObjByid_PubClassCaseFreeSenate_WA_Cache(long lngid_PubClassCaseFreeSenate)
{
string strAction = "GetObjByid_PubClassCaseFreeSenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCaseFreeSenate"] = lngid_PubClassCaseFreeSenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPubClassCaseFreeSenateEN = JsonConvert.DeserializeObject<clsvPubClassCaseFreeSenateEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCaseFreeSenateEN;
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
public static clsvPubClassCaseFreeSenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = null;
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
objvPubClassCaseFreeSenateEN = JsonConvert.DeserializeObject<clsvPubClassCaseFreeSenateEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCaseFreeSenateEN;
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
 /// <param name = "lngid_PubClassCaseFreeSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCaseFreeSenateEN GetObjByid_PubClassCaseFreeSenate_Cache(long lngid_PubClassCaseFreeSenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubClassCaseFreeSenateEN._CurrTabName_S);
List<clsvPubClassCaseFreeSenateEN> arrvPubClassCaseFreeSenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubClassCaseFreeSenateEN> arrvPubClassCaseFreeSenateObjLst_Sel =
from objvPubClassCaseFreeSenateEN in arrvPubClassCaseFreeSenateObjLst_Cache
where objvPubClassCaseFreeSenateEN.id_PubClassCaseFreeSenate == lngid_PubClassCaseFreeSenate
select objvPubClassCaseFreeSenateEN;
if (arrvPubClassCaseFreeSenateObjLst_Sel.Count() == 0)
{
   clsvPubClassCaseFreeSenateEN obj = clsvPubClassCaseFreeSenateWApi.GetObjByid_PubClassCaseFreeSenate(lngid_PubClassCaseFreeSenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPubClassCaseFreeSenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseFreeSenateEN> GetObjLst(string strWhereCond)
{
 List<clsvPubClassCaseFreeSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseFreeSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseFreeSenateEN> GetObjLstById_PubClassCaseFreeSenateLst(List<long> arrId_PubClassCaseFreeSenate)
{
 List<clsvPubClassCaseFreeSenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCaseFreeSenateLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCaseFreeSenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseFreeSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_PubClassCaseFreeSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvPubClassCaseFreeSenateEN> GetObjLstById_PubClassCaseFreeSenateLst_Cache(List<long> arrId_PubClassCaseFreeSenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubClassCaseFreeSenateEN._CurrTabName_S);
List<clsvPubClassCaseFreeSenateEN> arrvPubClassCaseFreeSenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubClassCaseFreeSenateEN> arrvPubClassCaseFreeSenateObjLst_Sel =
from objvPubClassCaseFreeSenateEN in arrvPubClassCaseFreeSenateObjLst_Cache
where arrId_PubClassCaseFreeSenate.Contains(objvPubClassCaseFreeSenateEN.id_PubClassCaseFreeSenate)
select objvPubClassCaseFreeSenateEN;
return arrvPubClassCaseFreeSenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseFreeSenateEN> GetObjLstById_PubClassCaseFreeSenateLst_WA_Cache(List<long> arrId_PubClassCaseFreeSenate)
{
 List<clsvPubClassCaseFreeSenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCaseFreeSenateLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCaseFreeSenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseFreeSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseFreeSenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPubClassCaseFreeSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseFreeSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseFreeSenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPubClassCaseFreeSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseFreeSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseFreeSenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPubClassCaseFreeSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseFreeSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseFreeSenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPubClassCaseFreeSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseFreeSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_PubClassCaseFreeSenate)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCaseFreeSenate"] = lngid_PubClassCaseFreeSenate.ToString()
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
 /// <param name = "objvPubClassCaseFreeSenateENS">源对象</param>
 /// <param name = "objvPubClassCaseFreeSenateENT">目标对象</param>
 public static void CopyTo(clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateENS, clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateENT)
{
try
{
objvPubClassCaseFreeSenateENT.id_PubClassCaseFreeSenate = objvPubClassCaseFreeSenateENS.id_PubClassCaseFreeSenate; //公开课案例自由评议流水号
objvPubClassCaseFreeSenateENT.id_PubClassCase = objvPubClassCaseFreeSenateENS.id_PubClassCase; //案例流水号
objvPubClassCaseFreeSenateENT.PubClassCaseID = objvPubClassCaseFreeSenateENS.PubClassCaseID; //案例ID
objvPubClassCaseFreeSenateENT.PubClassCaseName = objvPubClassCaseFreeSenateENS.PubClassCaseName; //案例课题名称
objvPubClassCaseFreeSenateENT.PubClassCaseExecutor = objvPubClassCaseFreeSenateENS.PubClassCaseExecutor; //案例执教者
objvPubClassCaseFreeSenateENT.PubClassCaseTheme = objvPubClassCaseFreeSenateENS.PubClassCaseTheme; //案例主题词
objvPubClassCaseFreeSenateENT.UserId = objvPubClassCaseFreeSenateENS.UserId; //用户ID
objvPubClassCaseFreeSenateENT.UserName = objvPubClassCaseFreeSenateENS.UserName; //用户名
objvPubClassCaseFreeSenateENT.AppraiseTheme = objvPubClassCaseFreeSenateENS.AppraiseTheme; //评议主题
objvPubClassCaseFreeSenateENT.PubClassCaseFreeSenateTitle = objvPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTitle; //公开课案例自由评议标题
objvPubClassCaseFreeSenateENT.PubClassCaseFreeSenateConten = objvPubClassCaseFreeSenateENS.PubClassCaseFreeSenateConten; //公开课案例自由评议内容
objvPubClassCaseFreeSenateENT.PubClassCaseFreeSenateDate = objvPubClassCaseFreeSenateENS.PubClassCaseFreeSenateDate; //公开课案例自由评议日期
objvPubClassCaseFreeSenateENT.PubClassCaseFreeSenateTime = objvPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTime; //公开课案例自由评议时间
objvPubClassCaseFreeSenateENT.BrowseCount = objvPubClassCaseFreeSenateENS.BrowseCount; //浏览次数
objvPubClassCaseFreeSenateENT.VideoStopTime = objvPubClassCaseFreeSenateENS.VideoStopTime; //公开课案例视频暂停时间
objvPubClassCaseFreeSenateENT.IsVisible = objvPubClassCaseFreeSenateENS.IsVisible; //是否显示
objvPubClassCaseFreeSenateENT.id_Discipline = objvPubClassCaseFreeSenateENS.id_Discipline; //学科流水号
objvPubClassCaseFreeSenateENT.DisciplineID = objvPubClassCaseFreeSenateENS.DisciplineID; //学科ID
objvPubClassCaseFreeSenateENT.DisciplineName = objvPubClassCaseFreeSenateENS.DisciplineName; //学科名称
objvPubClassCaseFreeSenateENT.id_StudyLevel = objvPubClassCaseFreeSenateENS.id_StudyLevel; //id_StudyLevel
objvPubClassCaseFreeSenateENT.StudyLevelName = objvPubClassCaseFreeSenateENS.StudyLevelName; //学段名称
objvPubClassCaseFreeSenateENT.PubClassCaseTeachDate = objvPubClassCaseFreeSenateENS.PubClassCaseTeachDate; //案例授课日期
objvPubClassCaseFreeSenateENT.PubClassCaseDateIn = objvPubClassCaseFreeSenateENS.PubClassCaseDateIn; //案例入库日期
objvPubClassCaseFreeSenateENT.id_TeachingPlan = objvPubClassCaseFreeSenateENS.id_TeachingPlan; //教案流水号
objvPubClassCaseFreeSenateENT.SubjectName = objvPubClassCaseFreeSenateENS.SubjectName; //课题名称
objvPubClassCaseFreeSenateENT.id_PubCaseType = objvPubClassCaseFreeSenateENS.id_PubCaseType; //公开课案例类型流水号
objvPubClassCaseFreeSenateENT.PubCaseTypeID = objvPubClassCaseFreeSenateENS.PubCaseTypeID; //公开课案例类型ID
objvPubClassCaseFreeSenateENT.PubCaseTypeName = objvPubClassCaseFreeSenateENS.PubCaseTypeName; //公开课案例类型名称
objvPubClassCaseFreeSenateENT.CollegeID = objvPubClassCaseFreeSenateENS.CollegeID; //学院ID
objvPubClassCaseFreeSenateENT.CollegeName = objvPubClassCaseFreeSenateENS.CollegeName; //学院名称
objvPubClassCaseFreeSenateENT.id_XzCollege = objvPubClassCaseFreeSenateENS.id_XzCollege; //学院流水号
objvPubClassCaseFreeSenateENT.IsLeaved = objvPubClassCaseFreeSenateENS.IsLeaved; //IsLeaved
objvPubClassCaseFreeSenateENT.StuIdTeacherId = objvPubClassCaseFreeSenateENS.StuIdTeacherId; //学工号
objvPubClassCaseFreeSenateENT.BrowseCount4Case = objvPubClassCaseFreeSenateENS.BrowseCount4Case; //课例浏览次数
objvPubClassCaseFreeSenateENT.CollegeNameA = objvPubClassCaseFreeSenateENS.CollegeNameA; //学院名称简写
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
public static DataTable ToDataTable(List<clsvPubClassCaseFreeSenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPubClassCaseFreeSenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPubClassCaseFreeSenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPubClassCaseFreeSenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPubClassCaseFreeSenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPubClassCaseFreeSenateEN.AttributeName)
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
if (clsPubClassCaseFreeSenateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseFreeSenateWApi没有刷新缓存机制(clsPubClassCaseFreeSenateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseWApi没有刷新缓存机制(clsPubClassCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingPlanWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingPlanWApi没有刷新缓存机制(clsTeachingPlanWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateGaugeVersionWApi没有刷新缓存机制(clsPubClassCaseSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubCaseTypeWApi没有刷新缓存机制(clsPubCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_PubClassCaseFreeSenate");
//if (arrvPubClassCaseFreeSenateObjLst_Cache == null)
//{
//arrvPubClassCaseFreeSenateObjLst_Cache = await clsvPubClassCaseFreeSenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvPubClassCaseFreeSenateEN._CurrTabName_S);
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
public static List<clsvPubClassCaseFreeSenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPubClassCaseFreeSenateEN._CurrTabName_S);
List<clsvPubClassCaseFreeSenateEN> arrvPubClassCaseFreeSenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPubClassCaseFreeSenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPubClassCaseFreeSenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPubClassCaseFreeSenate.id_PubClassCaseFreeSenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convPubClassCaseFreeSenate.id_PubClassCase, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.PubClassCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.PubClassCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.PubClassCaseExecutor, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.PubClassCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.AppraiseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPubClassCaseFreeSenate.VideoStopTime, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubClassCaseFreeSenate.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.PubClassCaseTeachDate, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.PubClassCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.SubjectName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.id_PubCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.PubCaseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.PubCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.IsLeaved, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubClassCaseFreeSenate.StuIdTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseFreeSenate.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convPubClassCaseFreeSenate.CollegeNameA, Type.GetType("System.String"));
foreach (clsvPubClassCaseFreeSenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPubClassCaseFreeSenate.id_PubClassCaseFreeSenate] = objInFor[convPubClassCaseFreeSenate.id_PubClassCaseFreeSenate];
objDR[convPubClassCaseFreeSenate.id_PubClassCase] = objInFor[convPubClassCaseFreeSenate.id_PubClassCase];
objDR[convPubClassCaseFreeSenate.PubClassCaseID] = objInFor[convPubClassCaseFreeSenate.PubClassCaseID];
objDR[convPubClassCaseFreeSenate.PubClassCaseName] = objInFor[convPubClassCaseFreeSenate.PubClassCaseName];
objDR[convPubClassCaseFreeSenate.PubClassCaseExecutor] = objInFor[convPubClassCaseFreeSenate.PubClassCaseExecutor];
objDR[convPubClassCaseFreeSenate.PubClassCaseTheme] = objInFor[convPubClassCaseFreeSenate.PubClassCaseTheme];
objDR[convPubClassCaseFreeSenate.UserId] = objInFor[convPubClassCaseFreeSenate.UserId];
objDR[convPubClassCaseFreeSenate.UserName] = objInFor[convPubClassCaseFreeSenate.UserName];
objDR[convPubClassCaseFreeSenate.AppraiseTheme] = objInFor[convPubClassCaseFreeSenate.AppraiseTheme];
objDR[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] = objInFor[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle];
objDR[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] = objInFor[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten];
objDR[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] = objInFor[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate];
objDR[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] = objInFor[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime];
objDR[convPubClassCaseFreeSenate.BrowseCount] = objInFor[convPubClassCaseFreeSenate.BrowseCount];
objDR[convPubClassCaseFreeSenate.VideoStopTime] = objInFor[convPubClassCaseFreeSenate.VideoStopTime];
objDR[convPubClassCaseFreeSenate.IsVisible] = objInFor[convPubClassCaseFreeSenate.IsVisible];
objDR[convPubClassCaseFreeSenate.id_Discipline] = objInFor[convPubClassCaseFreeSenate.id_Discipline];
objDR[convPubClassCaseFreeSenate.DisciplineID] = objInFor[convPubClassCaseFreeSenate.DisciplineID];
objDR[convPubClassCaseFreeSenate.DisciplineName] = objInFor[convPubClassCaseFreeSenate.DisciplineName];
objDR[convPubClassCaseFreeSenate.id_StudyLevel] = objInFor[convPubClassCaseFreeSenate.id_StudyLevel];
objDR[convPubClassCaseFreeSenate.StudyLevelName] = objInFor[convPubClassCaseFreeSenate.StudyLevelName];
objDR[convPubClassCaseFreeSenate.PubClassCaseTeachDate] = objInFor[convPubClassCaseFreeSenate.PubClassCaseTeachDate];
objDR[convPubClassCaseFreeSenate.PubClassCaseDateIn] = objInFor[convPubClassCaseFreeSenate.PubClassCaseDateIn];
objDR[convPubClassCaseFreeSenate.id_TeachingPlan] = objInFor[convPubClassCaseFreeSenate.id_TeachingPlan];
objDR[convPubClassCaseFreeSenate.SubjectName] = objInFor[convPubClassCaseFreeSenate.SubjectName];
objDR[convPubClassCaseFreeSenate.id_PubCaseType] = objInFor[convPubClassCaseFreeSenate.id_PubCaseType];
objDR[convPubClassCaseFreeSenate.PubCaseTypeID] = objInFor[convPubClassCaseFreeSenate.PubCaseTypeID];
objDR[convPubClassCaseFreeSenate.PubCaseTypeName] = objInFor[convPubClassCaseFreeSenate.PubCaseTypeName];
objDR[convPubClassCaseFreeSenate.CollegeID] = objInFor[convPubClassCaseFreeSenate.CollegeID];
objDR[convPubClassCaseFreeSenate.CollegeName] = objInFor[convPubClassCaseFreeSenate.CollegeName];
objDR[convPubClassCaseFreeSenate.id_XzCollege] = objInFor[convPubClassCaseFreeSenate.id_XzCollege];
objDR[convPubClassCaseFreeSenate.IsLeaved] = objInFor[convPubClassCaseFreeSenate.IsLeaved];
objDR[convPubClassCaseFreeSenate.StuIdTeacherId] = objInFor[convPubClassCaseFreeSenate.StuIdTeacherId];
objDR[convPubClassCaseFreeSenate.BrowseCount4Case] = objInFor[convPubClassCaseFreeSenate.BrowseCount4Case];
objDR[convPubClassCaseFreeSenate.CollegeNameA] = objInFor[convPubClassCaseFreeSenate.CollegeNameA];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}