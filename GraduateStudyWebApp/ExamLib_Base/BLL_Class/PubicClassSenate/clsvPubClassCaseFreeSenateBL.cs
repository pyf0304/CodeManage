
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseFreeSenateBL
 表名:vPubClassCaseFreeSenate(01120412)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
public static class  clsvPubClassCaseFreeSenateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubClassCaseFreeSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseFreeSenateEN GetObj(this K_IdPubClassCaseFreeSenate_vPubClassCaseFreeSenate myKey)
{
clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = clsvPubClassCaseFreeSenateBL.vPubClassCaseFreeSenateDA.GetObjByIdPubClassCaseFreeSenate(myKey.Value);
return objvPubClassCaseFreeSenateEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetIdPubClassCaseFreeSenate(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, long lngIdPubClassCaseFreeSenate, string strComparisonOp="")
	{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = lngIdPubClassCaseFreeSenate; //公开课案例自由评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetIdPubClassCase(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strIdPubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubClassCase, convPubClassCaseFreeSenate.IdPubClassCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCase, 8, convPubClassCaseFreeSenate.IdPubClassCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCase, 8, convPubClassCaseFreeSenate.IdPubClassCase);
}
objvPubClassCaseFreeSenateEN.IdPubClassCase = strIdPubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.IdPubClassCase) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.IdPubClassCase, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.IdPubClassCase] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseID(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseID, convPubClassCaseFreeSenate.PubClassCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseID, 8, convPubClassCaseFreeSenate.PubClassCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseID, 8, convPubClassCaseFreeSenate.PubClassCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseName(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseName, convPubClassCaseFreeSenate.PubClassCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, convPubClassCaseFreeSenate.PubClassCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseExecutor(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, convPubClassCaseFreeSenate.PubClassCaseExecutor);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseTheme(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTheme, 500, convPubClassCaseFreeSenate.PubClassCaseTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetUserId(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convPubClassCaseFreeSenate.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convPubClassCaseFreeSenate.UserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetUserName(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convPubClassCaseFreeSenate.UserName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetAppraiseTheme(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strAppraiseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTheme, 200, convPubClassCaseFreeSenate.AppraiseTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateTitle(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateTitle, 200, convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateConten(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateConten, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateConten, 2000, convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateDate(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateDate, 8, convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseFreeSenateDate, 8, convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateTime(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateTime, 6, convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseFreeSenateTime, 6, convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetBrowseCount(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, int? intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetVideoStopTime(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strVideoStopTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoStopTime, 48, convPubClassCaseFreeSenate.VideoStopTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetIdDiscipline(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convPubClassCaseFreeSenate.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convPubClassCaseFreeSenate.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convPubClassCaseFreeSenate.IdDiscipline);
}
objvPubClassCaseFreeSenateEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.IdDiscipline) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.IdDiscipline, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.IdDiscipline] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetDisciplineID(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineID, convPubClassCaseFreeSenate.DisciplineID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convPubClassCaseFreeSenate.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convPubClassCaseFreeSenate.DisciplineID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetDisciplineName(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convPubClassCaseFreeSenate.DisciplineName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convPubClassCaseFreeSenate.DisciplineName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetIdStudyLevel(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strIdStudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudyLevel, convPubClassCaseFreeSenate.IdStudyLevel);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convPubClassCaseFreeSenate.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convPubClassCaseFreeSenate.IdStudyLevel);
}
objvPubClassCaseFreeSenateEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.IdStudyLevel) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.IdStudyLevel, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.IdStudyLevel] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetStudyLevelName(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convPubClassCaseFreeSenate.StudyLevelName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convPubClassCaseFreeSenate.StudyLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseTeachDate(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseTeachDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTeachDate, 8, convPubClassCaseFreeSenate.PubClassCaseTeachDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTeachDate, 8, convPubClassCaseFreeSenate.PubClassCaseTeachDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubClassCaseDateIn(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubClassCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseDateIn, 8, convPubClassCaseFreeSenate.PubClassCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseDateIn, 8, convPubClassCaseFreeSenate.PubClassCaseDateIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetIdTeachingPlan(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strIdTeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachingPlan, convPubClassCaseFreeSenate.IdTeachingPlan);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convPubClassCaseFreeSenate.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convPubClassCaseFreeSenate.IdTeachingPlan);
}
objvPubClassCaseFreeSenateEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.IdTeachingPlan) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.IdTeachingPlan, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.IdTeachingPlan] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetSubjectName(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strSubjectName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSubjectName, convPubClassCaseFreeSenate.SubjectName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubjectName, 200, convPubClassCaseFreeSenate.SubjectName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetIdPubCaseType(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strIdPubCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubCaseType, convPubClassCaseFreeSenate.IdPubCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubCaseType, 4, convPubClassCaseFreeSenate.IdPubCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubCaseType, 4, convPubClassCaseFreeSenate.IdPubCaseType);
}
objvPubClassCaseFreeSenateEN.IdPubCaseType = strIdPubCaseType; //公开课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.IdPubCaseType) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.IdPubCaseType, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.IdPubCaseType] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubCaseTypeID(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubCaseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeID, convPubClassCaseFreeSenate.PubCaseTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubCaseTypeID, 4, convPubClassCaseFreeSenate.PubCaseTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubCaseTypeID, 4, convPubClassCaseFreeSenate.PubCaseTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetPubCaseTypeName(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strPubCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeName, convPubClassCaseFreeSenate.PubCaseTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubCaseTypeName, 50, convPubClassCaseFreeSenate.PubCaseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetCollegeID(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convPubClassCaseFreeSenate.CollegeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetCollegeName(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convPubClassCaseFreeSenate.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetIdXzCollege(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convPubClassCaseFreeSenate.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convPubClassCaseFreeSenate.IdXzCollege);
}
objvPubClassCaseFreeSenateEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseFreeSenate.IdXzCollege) == false)
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(convPubClassCaseFreeSenate.IdXzCollege, strComparisonOp);
}
else
{
objvPubClassCaseFreeSenateEN.dicFldComparisonOp[convPubClassCaseFreeSenate.IdXzCollege] = strComparisonOp;
}
}
return objvPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetStuIdTeacherId(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strStuIdTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuIdTeacherId, 20, convPubClassCaseFreeSenate.StuIdTeacherId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetBrowseCount4Case(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, int? intBrowseCount4Case, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseFreeSenateEN SetCollegeNameA(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convPubClassCaseFreeSenate.CollegeNameA);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateENS">源对象</param>
 /// <param name = "objvPubClassCaseFreeSenateENT">目标对象</param>
 public static void CopyTo(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateENS, clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateENT)
{
try
{
objvPubClassCaseFreeSenateENT.IdPubClassCaseFreeSenate = objvPubClassCaseFreeSenateENS.IdPubClassCaseFreeSenate; //公开课案例自由评议流水号
objvPubClassCaseFreeSenateENT.IdPubClassCase = objvPubClassCaseFreeSenateENS.IdPubClassCase; //案例流水号
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
objvPubClassCaseFreeSenateENT.IdDiscipline = objvPubClassCaseFreeSenateENS.IdDiscipline; //学科流水号
objvPubClassCaseFreeSenateENT.DisciplineID = objvPubClassCaseFreeSenateENS.DisciplineID; //学科ID
objvPubClassCaseFreeSenateENT.DisciplineName = objvPubClassCaseFreeSenateENS.DisciplineName; //学科名称
objvPubClassCaseFreeSenateENT.IdStudyLevel = objvPubClassCaseFreeSenateENS.IdStudyLevel; //id_StudyLevel
objvPubClassCaseFreeSenateENT.StudyLevelName = objvPubClassCaseFreeSenateENS.StudyLevelName; //学段名称
objvPubClassCaseFreeSenateENT.PubClassCaseTeachDate = objvPubClassCaseFreeSenateENS.PubClassCaseTeachDate; //案例授课日期
objvPubClassCaseFreeSenateENT.PubClassCaseDateIn = objvPubClassCaseFreeSenateENS.PubClassCaseDateIn; //案例入库日期
objvPubClassCaseFreeSenateENT.IdTeachingPlan = objvPubClassCaseFreeSenateENS.IdTeachingPlan; //教案流水号
objvPubClassCaseFreeSenateENT.SubjectName = objvPubClassCaseFreeSenateENS.SubjectName; //课题名称
objvPubClassCaseFreeSenateENT.IdPubCaseType = objvPubClassCaseFreeSenateENS.IdPubCaseType; //公开课案例类型流水号
objvPubClassCaseFreeSenateENT.PubCaseTypeID = objvPubClassCaseFreeSenateENS.PubCaseTypeID; //公开课案例类型ID
objvPubClassCaseFreeSenateENT.PubCaseTypeName = objvPubClassCaseFreeSenateENS.PubCaseTypeName; //公开课案例类型名称
objvPubClassCaseFreeSenateENT.CollegeID = objvPubClassCaseFreeSenateENS.CollegeID; //学院ID
objvPubClassCaseFreeSenateENT.CollegeName = objvPubClassCaseFreeSenateENS.CollegeName; //学院名称
objvPubClassCaseFreeSenateENT.IdXzCollege = objvPubClassCaseFreeSenateENS.IdXzCollege; //学院流水号
objvPubClassCaseFreeSenateENT.IsLeaved = objvPubClassCaseFreeSenateENS.IsLeaved; //IsLeaved
objvPubClassCaseFreeSenateENT.StuIdTeacherId = objvPubClassCaseFreeSenateENS.StuIdTeacherId; //学工号
objvPubClassCaseFreeSenateENT.BrowseCount4Case = objvPubClassCaseFreeSenateENS.BrowseCount4Case; //课例浏览次数
objvPubClassCaseFreeSenateENT.CollegeNameA = objvPubClassCaseFreeSenateENS.CollegeNameA; //学院名称简写
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
 /// <param name = "objvPubClassCaseFreeSenateENS">源对象</param>
 /// <returns>目标对象=>clsvPubClassCaseFreeSenateEN:objvPubClassCaseFreeSenateENT</returns>
 public static clsvPubClassCaseFreeSenateEN CopyTo(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateENS)
{
try
{
 clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateENT = new clsvPubClassCaseFreeSenateEN()
{
IdPubClassCaseFreeSenate = objvPubClassCaseFreeSenateENS.IdPubClassCaseFreeSenate, //公开课案例自由评议流水号
IdPubClassCase = objvPubClassCaseFreeSenateENS.IdPubClassCase, //案例流水号
PubClassCaseID = objvPubClassCaseFreeSenateENS.PubClassCaseID, //案例ID
PubClassCaseName = objvPubClassCaseFreeSenateENS.PubClassCaseName, //案例课题名称
PubClassCaseExecutor = objvPubClassCaseFreeSenateENS.PubClassCaseExecutor, //案例执教者
PubClassCaseTheme = objvPubClassCaseFreeSenateENS.PubClassCaseTheme, //案例主题词
UserId = objvPubClassCaseFreeSenateENS.UserId, //用户ID
UserName = objvPubClassCaseFreeSenateENS.UserName, //用户名
AppraiseTheme = objvPubClassCaseFreeSenateENS.AppraiseTheme, //评议主题
PubClassCaseFreeSenateTitle = objvPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTitle, //公开课案例自由评议标题
PubClassCaseFreeSenateConten = objvPubClassCaseFreeSenateENS.PubClassCaseFreeSenateConten, //公开课案例自由评议内容
PubClassCaseFreeSenateDate = objvPubClassCaseFreeSenateENS.PubClassCaseFreeSenateDate, //公开课案例自由评议日期
PubClassCaseFreeSenateTime = objvPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTime, //公开课案例自由评议时间
BrowseCount = objvPubClassCaseFreeSenateENS.BrowseCount, //浏览次数
VideoStopTime = objvPubClassCaseFreeSenateENS.VideoStopTime, //公开课案例视频暂停时间
IsVisible = objvPubClassCaseFreeSenateENS.IsVisible, //是否显示
IdDiscipline = objvPubClassCaseFreeSenateENS.IdDiscipline, //学科流水号
DisciplineID = objvPubClassCaseFreeSenateENS.DisciplineID, //学科ID
DisciplineName = objvPubClassCaseFreeSenateENS.DisciplineName, //学科名称
IdStudyLevel = objvPubClassCaseFreeSenateENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvPubClassCaseFreeSenateENS.StudyLevelName, //学段名称
PubClassCaseTeachDate = objvPubClassCaseFreeSenateENS.PubClassCaseTeachDate, //案例授课日期
PubClassCaseDateIn = objvPubClassCaseFreeSenateENS.PubClassCaseDateIn, //案例入库日期
IdTeachingPlan = objvPubClassCaseFreeSenateENS.IdTeachingPlan, //教案流水号
SubjectName = objvPubClassCaseFreeSenateENS.SubjectName, //课题名称
IdPubCaseType = objvPubClassCaseFreeSenateENS.IdPubCaseType, //公开课案例类型流水号
PubCaseTypeID = objvPubClassCaseFreeSenateENS.PubCaseTypeID, //公开课案例类型ID
PubCaseTypeName = objvPubClassCaseFreeSenateENS.PubCaseTypeName, //公开课案例类型名称
CollegeID = objvPubClassCaseFreeSenateENS.CollegeID, //学院ID
CollegeName = objvPubClassCaseFreeSenateENS.CollegeName, //学院名称
IdXzCollege = objvPubClassCaseFreeSenateENS.IdXzCollege, //学院流水号
IsLeaved = objvPubClassCaseFreeSenateENS.IsLeaved, //IsLeaved
StuIdTeacherId = objvPubClassCaseFreeSenateENS.StuIdTeacherId, //学工号
BrowseCount4Case = objvPubClassCaseFreeSenateENS.BrowseCount4Case, //课例浏览次数
CollegeNameA = objvPubClassCaseFreeSenateENS.CollegeNameA, //学院名称简写
};
 return objvPubClassCaseFreeSenateENT;
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
public static void CheckProperty4Condition(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN)
{
 clsvPubClassCaseFreeSenateBL.vPubClassCaseFreeSenateDA.CheckProperty4Condition(objvPubClassCaseFreeSenateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate) == true)
{
string strComparisonOpIdPubClassCaseFreeSenate = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate, objvPubClassCaseFreeSenateCond.IdPubClassCaseFreeSenate, strComparisonOpIdPubClassCaseFreeSenate);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.IdPubClassCase) == true)
{
string strComparisonOpIdPubClassCase = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.IdPubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.IdPubClassCase, objvPubClassCaseFreeSenateCond.IdPubClassCase, strComparisonOpIdPubClassCase);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseID) == true)
{
string strComparisonOpPubClassCaseID = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseID, objvPubClassCaseFreeSenateCond.PubClassCaseID, strComparisonOpPubClassCaseID);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseName) == true)
{
string strComparisonOpPubClassCaseName = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseName, objvPubClassCaseFreeSenateCond.PubClassCaseName, strComparisonOpPubClassCaseName);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseExecutor) == true)
{
string strComparisonOpPubClassCaseExecutor = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseExecutor, objvPubClassCaseFreeSenateCond.PubClassCaseExecutor, strComparisonOpPubClassCaseExecutor);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseTheme) == true)
{
string strComparisonOpPubClassCaseTheme = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseTheme, objvPubClassCaseFreeSenateCond.PubClassCaseTheme, strComparisonOpPubClassCaseTheme);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.UserId) == true)
{
string strComparisonOpUserId = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.UserId, objvPubClassCaseFreeSenateCond.UserId, strComparisonOpUserId);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.UserName) == true)
{
string strComparisonOpUserName = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.UserName, objvPubClassCaseFreeSenateCond.UserName, strComparisonOpUserName);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.AppraiseTheme) == true)
{
string strComparisonOpAppraiseTheme = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.AppraiseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.AppraiseTheme, objvPubClassCaseFreeSenateCond.AppraiseTheme, strComparisonOpAppraiseTheme);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle) == true)
{
string strComparisonOpPubClassCaseFreeSenateTitle = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle, objvPubClassCaseFreeSenateCond.PubClassCaseFreeSenateTitle, strComparisonOpPubClassCaseFreeSenateTitle);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten) == true)
{
string strComparisonOpPubClassCaseFreeSenateConten = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten, objvPubClassCaseFreeSenateCond.PubClassCaseFreeSenateConten, strComparisonOpPubClassCaseFreeSenateConten);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate) == true)
{
string strComparisonOpPubClassCaseFreeSenateDate = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate, objvPubClassCaseFreeSenateCond.PubClassCaseFreeSenateDate, strComparisonOpPubClassCaseFreeSenateDate);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime) == true)
{
string strComparisonOpPubClassCaseFreeSenateTime = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime, objvPubClassCaseFreeSenateCond.PubClassCaseFreeSenateTime, strComparisonOpPubClassCaseFreeSenateTime);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseFreeSenate.BrowseCount, objvPubClassCaseFreeSenateCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.VideoStopTime) == true)
{
string strComparisonOpVideoStopTime = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.VideoStopTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.VideoStopTime, objvPubClassCaseFreeSenateCond.VideoStopTime, strComparisonOpVideoStopTime);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.IsVisible) == true)
{
if (objvPubClassCaseFreeSenateCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseFreeSenate.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseFreeSenate.IsVisible);
}
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.IdDiscipline, objvPubClassCaseFreeSenateCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.DisciplineID, objvPubClassCaseFreeSenateCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.DisciplineName, objvPubClassCaseFreeSenateCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.IdStudyLevel, objvPubClassCaseFreeSenateCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.StudyLevelName, objvPubClassCaseFreeSenateCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseTeachDate) == true)
{
string strComparisonOpPubClassCaseTeachDate = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseTeachDate, objvPubClassCaseFreeSenateCond.PubClassCaseTeachDate, strComparisonOpPubClassCaseTeachDate);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.PubClassCaseDateIn) == true)
{
string strComparisonOpPubClassCaseDateIn = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubClassCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubClassCaseDateIn, objvPubClassCaseFreeSenateCond.PubClassCaseDateIn, strComparisonOpPubClassCaseDateIn);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.IdTeachingPlan, objvPubClassCaseFreeSenateCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.SubjectName) == true)
{
string strComparisonOpSubjectName = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.SubjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.SubjectName, objvPubClassCaseFreeSenateCond.SubjectName, strComparisonOpSubjectName);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.IdPubCaseType) == true)
{
string strComparisonOpIdPubCaseType = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.IdPubCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.IdPubCaseType, objvPubClassCaseFreeSenateCond.IdPubCaseType, strComparisonOpIdPubCaseType);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.PubCaseTypeID) == true)
{
string strComparisonOpPubCaseTypeID = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubCaseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubCaseTypeID, objvPubClassCaseFreeSenateCond.PubCaseTypeID, strComparisonOpPubCaseTypeID);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.PubCaseTypeName) == true)
{
string strComparisonOpPubCaseTypeName = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.PubCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.PubCaseTypeName, objvPubClassCaseFreeSenateCond.PubCaseTypeName, strComparisonOpPubCaseTypeName);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.CollegeID) == true)
{
string strComparisonOpCollegeID = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.CollegeID, objvPubClassCaseFreeSenateCond.CollegeID, strComparisonOpCollegeID);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.CollegeName) == true)
{
string strComparisonOpCollegeName = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.CollegeName, objvPubClassCaseFreeSenateCond.CollegeName, strComparisonOpCollegeName);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.IdXzCollege, objvPubClassCaseFreeSenateCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.IsLeaved) == true)
{
if (objvPubClassCaseFreeSenateCond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseFreeSenate.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseFreeSenate.IsLeaved);
}
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.StuIdTeacherId) == true)
{
string strComparisonOpStuIdTeacherId = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.StuIdTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.StuIdTeacherId, objvPubClassCaseFreeSenateCond.StuIdTeacherId, strComparisonOpStuIdTeacherId);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseFreeSenate.BrowseCount4Case, objvPubClassCaseFreeSenateCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvPubClassCaseFreeSenateCond.IsUpdated(convPubClassCaseFreeSenate.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[convPubClassCaseFreeSenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseFreeSenate.CollegeNameA, objvPubClassCaseFreeSenateCond.CollegeNameA, strComparisonOpCollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPubClassCaseFreeSenate
{
public virtual bool UpdRelaTabDate(long lngIdPubClassCaseFreeSenate, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v公开课案例自由评议(vPubClassCaseFreeSenate)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPubClassCaseFreeSenateBL
{
public static RelatedActions_vPubClassCaseFreeSenate relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPubClassCaseFreeSenateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPubClassCaseFreeSenateDA vPubClassCaseFreeSenateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPubClassCaseFreeSenateDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPubClassCaseFreeSenateBL()
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
if (string.IsNullOrEmpty(clsvPubClassCaseFreeSenateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPubClassCaseFreeSenateEN._ConnectString);
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
public static DataTable GetDataTable_vPubClassCaseFreeSenate(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPubClassCaseFreeSenateDA.GetDataTable_vPubClassCaseFreeSenate(strWhereCond);
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
objDT = vPubClassCaseFreeSenateDA.GetDataTable(strWhereCond);
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
objDT = vPubClassCaseFreeSenateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPubClassCaseFreeSenateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPubClassCaseFreeSenateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPubClassCaseFreeSenateDA.GetDataTable_Top(objTopPara);
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
objDT = vPubClassCaseFreeSenateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPubClassCaseFreeSenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPubClassCaseFreeSenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdPubClassCaseFreeSenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPubClassCaseFreeSenateEN> GetObjLstByIdPubClassCaseFreeSenateLst(List<long> arrIdPubClassCaseFreeSenateLst)
{
List<clsvPubClassCaseFreeSenateEN> arrObjLst = new List<clsvPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPubClassCaseFreeSenateLst);
 string strWhereCond = string.Format("IdPubClassCaseFreeSenate in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN();
try
{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objvPubClassCaseFreeSenateEN.IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseFreeSenateEN.PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseFreeSenateEN.PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseFreeSenateEN.UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseFreeSenateEN.UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseFreeSenateEN.AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objvPubClassCaseFreeSenateEN.BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
objvPubClassCaseFreeSenateEN.VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvPubClassCaseFreeSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseFreeSenateEN.IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseFreeSenateEN.DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseFreeSenateEN.DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseFreeSenateEN.IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseFreeSenateEN.StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseFreeSenateEN.IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseFreeSenateEN.SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseFreeSenateEN.IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseFreeSenateEN.PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseFreeSenateEN.PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseFreeSenateEN.CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseFreeSenateEN.CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseFreeSenateEN.IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseFreeSenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseFreeSenateEN.StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseFreeSenateEN.BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCaseFreeSenateEN.CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseFreeSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPubClassCaseFreeSenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPubClassCaseFreeSenateEN> GetObjLstByIdPubClassCaseFreeSenateLstCache(List<long> arrIdPubClassCaseFreeSenateLst)
{
string strKey = string.Format("{0}", clsvPubClassCaseFreeSenateEN._CurrTabName);
List<clsvPubClassCaseFreeSenateEN> arrvPubClassCaseFreeSenateObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseFreeSenateEN> arrvPubClassCaseFreeSenateObjLst_Sel =
arrvPubClassCaseFreeSenateObjLstCache
.Where(x => arrIdPubClassCaseFreeSenateLst.Contains(x.IdPubClassCaseFreeSenate));
return arrvPubClassCaseFreeSenateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseFreeSenateEN> GetObjLst(string strWhereCond)
{
List<clsvPubClassCaseFreeSenateEN> arrObjLst = new List<clsvPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN();
try
{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objvPubClassCaseFreeSenateEN.IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseFreeSenateEN.PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseFreeSenateEN.PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseFreeSenateEN.UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseFreeSenateEN.UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseFreeSenateEN.AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objvPubClassCaseFreeSenateEN.BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
objvPubClassCaseFreeSenateEN.VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvPubClassCaseFreeSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseFreeSenateEN.IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseFreeSenateEN.DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseFreeSenateEN.DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseFreeSenateEN.IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseFreeSenateEN.StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseFreeSenateEN.IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseFreeSenateEN.SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseFreeSenateEN.IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseFreeSenateEN.PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseFreeSenateEN.PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseFreeSenateEN.CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseFreeSenateEN.CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseFreeSenateEN.IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseFreeSenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseFreeSenateEN.StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseFreeSenateEN.BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCaseFreeSenateEN.CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseFreeSenateEN);
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
public static List<clsvPubClassCaseFreeSenateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPubClassCaseFreeSenateEN> arrObjLst = new List<clsvPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN();
try
{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objvPubClassCaseFreeSenateEN.IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseFreeSenateEN.PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseFreeSenateEN.PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseFreeSenateEN.UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseFreeSenateEN.UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseFreeSenateEN.AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objvPubClassCaseFreeSenateEN.BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
objvPubClassCaseFreeSenateEN.VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvPubClassCaseFreeSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseFreeSenateEN.IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseFreeSenateEN.DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseFreeSenateEN.DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseFreeSenateEN.IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseFreeSenateEN.StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseFreeSenateEN.IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseFreeSenateEN.SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseFreeSenateEN.IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseFreeSenateEN.PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseFreeSenateEN.PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseFreeSenateEN.CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseFreeSenateEN.CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseFreeSenateEN.IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseFreeSenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseFreeSenateEN.StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseFreeSenateEN.BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCaseFreeSenateEN.CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseFreeSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPubClassCaseFreeSenateEN> GetSubObjLstCache(clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateCond)
{
List<clsvPubClassCaseFreeSenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseFreeSenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPubClassCaseFreeSenate.AttributeName)
{
if (objvPubClassCaseFreeSenateCond.IsUpdated(strFldName) == false) continue;
if (objvPubClassCaseFreeSenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseFreeSenateCond[strFldName].ToString());
}
else
{
if (objvPubClassCaseFreeSenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseFreeSenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPubClassCaseFreeSenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseFreeSenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseFreeSenateCond[strFldName]));
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
public static List<clsvPubClassCaseFreeSenateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPubClassCaseFreeSenateEN> arrObjLst = new List<clsvPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN();
try
{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objvPubClassCaseFreeSenateEN.IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseFreeSenateEN.PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseFreeSenateEN.PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseFreeSenateEN.UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseFreeSenateEN.UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseFreeSenateEN.AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objvPubClassCaseFreeSenateEN.BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
objvPubClassCaseFreeSenateEN.VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvPubClassCaseFreeSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseFreeSenateEN.IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseFreeSenateEN.DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseFreeSenateEN.DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseFreeSenateEN.IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseFreeSenateEN.StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseFreeSenateEN.IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseFreeSenateEN.SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseFreeSenateEN.IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseFreeSenateEN.PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseFreeSenateEN.PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseFreeSenateEN.CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseFreeSenateEN.CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseFreeSenateEN.IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseFreeSenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseFreeSenateEN.StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseFreeSenateEN.BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCaseFreeSenateEN.CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseFreeSenateEN);
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
public static List<clsvPubClassCaseFreeSenateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPubClassCaseFreeSenateEN> arrObjLst = new List<clsvPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN();
try
{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objvPubClassCaseFreeSenateEN.IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseFreeSenateEN.PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseFreeSenateEN.PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseFreeSenateEN.UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseFreeSenateEN.UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseFreeSenateEN.AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objvPubClassCaseFreeSenateEN.BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
objvPubClassCaseFreeSenateEN.VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvPubClassCaseFreeSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseFreeSenateEN.IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseFreeSenateEN.DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseFreeSenateEN.DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseFreeSenateEN.IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseFreeSenateEN.StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseFreeSenateEN.IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseFreeSenateEN.SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseFreeSenateEN.IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseFreeSenateEN.PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseFreeSenateEN.PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseFreeSenateEN.CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseFreeSenateEN.CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseFreeSenateEN.IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseFreeSenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseFreeSenateEN.StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseFreeSenateEN.BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCaseFreeSenateEN.CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseFreeSenateEN);
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
List<clsvPubClassCaseFreeSenateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPubClassCaseFreeSenateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseFreeSenateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPubClassCaseFreeSenateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPubClassCaseFreeSenateEN> arrObjLst = new List<clsvPubClassCaseFreeSenateEN>(); 
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
	clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN();
try
{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objvPubClassCaseFreeSenateEN.IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseFreeSenateEN.PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseFreeSenateEN.PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseFreeSenateEN.UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseFreeSenateEN.UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseFreeSenateEN.AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objvPubClassCaseFreeSenateEN.BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
objvPubClassCaseFreeSenateEN.VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvPubClassCaseFreeSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseFreeSenateEN.IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseFreeSenateEN.DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseFreeSenateEN.DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseFreeSenateEN.IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseFreeSenateEN.StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseFreeSenateEN.IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseFreeSenateEN.SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseFreeSenateEN.IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseFreeSenateEN.PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseFreeSenateEN.PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseFreeSenateEN.CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseFreeSenateEN.CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseFreeSenateEN.IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseFreeSenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseFreeSenateEN.StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseFreeSenateEN.BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCaseFreeSenateEN.CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseFreeSenateEN);
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
public static List<clsvPubClassCaseFreeSenateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPubClassCaseFreeSenateEN> arrObjLst = new List<clsvPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN();
try
{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objvPubClassCaseFreeSenateEN.IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseFreeSenateEN.PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseFreeSenateEN.PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseFreeSenateEN.UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseFreeSenateEN.UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseFreeSenateEN.AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objvPubClassCaseFreeSenateEN.BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
objvPubClassCaseFreeSenateEN.VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvPubClassCaseFreeSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseFreeSenateEN.IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseFreeSenateEN.DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseFreeSenateEN.DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseFreeSenateEN.IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseFreeSenateEN.StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseFreeSenateEN.IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseFreeSenateEN.SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseFreeSenateEN.IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseFreeSenateEN.PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseFreeSenateEN.PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseFreeSenateEN.CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseFreeSenateEN.CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseFreeSenateEN.IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseFreeSenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseFreeSenateEN.StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseFreeSenateEN.BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCaseFreeSenateEN.CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseFreeSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPubClassCaseFreeSenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPubClassCaseFreeSenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPubClassCaseFreeSenateEN> arrObjLst = new List<clsvPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN();
try
{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objvPubClassCaseFreeSenateEN.IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseFreeSenateEN.PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseFreeSenateEN.PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseFreeSenateEN.UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseFreeSenateEN.UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseFreeSenateEN.AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objvPubClassCaseFreeSenateEN.BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
objvPubClassCaseFreeSenateEN.VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvPubClassCaseFreeSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseFreeSenateEN.IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseFreeSenateEN.DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseFreeSenateEN.DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseFreeSenateEN.IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseFreeSenateEN.StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseFreeSenateEN.IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseFreeSenateEN.SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseFreeSenateEN.IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseFreeSenateEN.PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseFreeSenateEN.PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseFreeSenateEN.CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseFreeSenateEN.CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseFreeSenateEN.IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseFreeSenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseFreeSenateEN.StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseFreeSenateEN.BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCaseFreeSenateEN.CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseFreeSenateEN);
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
public static List<clsvPubClassCaseFreeSenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPubClassCaseFreeSenateEN> arrObjLst = new List<clsvPubClassCaseFreeSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN();
try
{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objvPubClassCaseFreeSenateEN.IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseFreeSenateEN.PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseFreeSenateEN.PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseFreeSenateEN.UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseFreeSenateEN.UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseFreeSenateEN.AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objvPubClassCaseFreeSenateEN.BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
objvPubClassCaseFreeSenateEN.VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvPubClassCaseFreeSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseFreeSenateEN.IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseFreeSenateEN.DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseFreeSenateEN.DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseFreeSenateEN.IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseFreeSenateEN.StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseFreeSenateEN.IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseFreeSenateEN.SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseFreeSenateEN.IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseFreeSenateEN.PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseFreeSenateEN.PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseFreeSenateEN.CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseFreeSenateEN.CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseFreeSenateEN.IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseFreeSenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseFreeSenateEN.StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseFreeSenateEN.BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCaseFreeSenateEN.CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseFreeSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseFreeSenateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPubClassCaseFreeSenateEN> arrObjLst = new List<clsvPubClassCaseFreeSenateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN();
try
{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objvPubClassCaseFreeSenateEN.IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseFreeSenateEN.PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseFreeSenateEN.PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseFreeSenateEN.UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseFreeSenateEN.UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseFreeSenateEN.AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objvPubClassCaseFreeSenateEN.BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
objvPubClassCaseFreeSenateEN.VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvPubClassCaseFreeSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseFreeSenateEN.IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseFreeSenateEN.DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseFreeSenateEN.DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseFreeSenateEN.IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseFreeSenateEN.StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseFreeSenateEN.IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseFreeSenateEN.SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseFreeSenateEN.IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseFreeSenateEN.PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseFreeSenateEN.PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseFreeSenateEN.CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseFreeSenateEN.CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseFreeSenateEN.IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseFreeSenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseFreeSenateEN.StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseFreeSenateEN.BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCaseFreeSenateEN.CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseFreeSenateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPubClassCaseFreeSenate(ref clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN)
{
bool bolResult = vPubClassCaseFreeSenateDA.GetvPubClassCaseFreeSenate(ref objvPubClassCaseFreeSenateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubClassCaseFreeSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseFreeSenateEN GetObjByIdPubClassCaseFreeSenate(long lngIdPubClassCaseFreeSenate)
{
clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = vPubClassCaseFreeSenateDA.GetObjByIdPubClassCaseFreeSenate(lngIdPubClassCaseFreeSenate);
return objvPubClassCaseFreeSenateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPubClassCaseFreeSenateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = vPubClassCaseFreeSenateDA.GetFirstObj(strWhereCond);
 return objvPubClassCaseFreeSenateEN;
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
public static clsvPubClassCaseFreeSenateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = vPubClassCaseFreeSenateDA.GetObjByDataRow(objRow);
 return objvPubClassCaseFreeSenateEN;
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
public static clsvPubClassCaseFreeSenateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = vPubClassCaseFreeSenateDA.GetObjByDataRow(objRow);
 return objvPubClassCaseFreeSenateEN;
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
 /// <param name = "lngIdPubClassCaseFreeSenate">所给的关键字</param>
 /// <param name = "lstvPubClassCaseFreeSenateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCaseFreeSenateEN GetObjByIdPubClassCaseFreeSenateFromList(long lngIdPubClassCaseFreeSenate, List<clsvPubClassCaseFreeSenateEN> lstvPubClassCaseFreeSenateObjLst)
{
foreach (clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN in lstvPubClassCaseFreeSenateObjLst)
{
if (objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate == lngIdPubClassCaseFreeSenate)
{
return objvPubClassCaseFreeSenateEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngIdPubClassCaseFreeSenate;
 try
 {
 lngIdPubClassCaseFreeSenate = new clsvPubClassCaseFreeSenateDA().GetFirstID(strWhereCond);
 return lngIdPubClassCaseFreeSenate;
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
 arrList = vPubClassCaseFreeSenateDA.GetID(strWhereCond);
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
bool bolIsExist = vPubClassCaseFreeSenateDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdPubClassCaseFreeSenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdPubClassCaseFreeSenate)
{
//检测记录是否存在
bool bolIsExist = vPubClassCaseFreeSenateDA.IsExist(lngIdPubClassCaseFreeSenate);
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
 bolIsExist = clsvPubClassCaseFreeSenateDA.IsExistTable();
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
 bolIsExist = vPubClassCaseFreeSenateDA.IsExistTable(strTabName);
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
 /// <param name = "objvPubClassCaseFreeSenateENS">源对象</param>
 /// <param name = "objvPubClassCaseFreeSenateENT">目标对象</param>
 public static void CopyTo(clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateENS, clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateENT)
{
try
{
objvPubClassCaseFreeSenateENT.IdPubClassCaseFreeSenate = objvPubClassCaseFreeSenateENS.IdPubClassCaseFreeSenate; //公开课案例自由评议流水号
objvPubClassCaseFreeSenateENT.IdPubClassCase = objvPubClassCaseFreeSenateENS.IdPubClassCase; //案例流水号
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
objvPubClassCaseFreeSenateENT.IdDiscipline = objvPubClassCaseFreeSenateENS.IdDiscipline; //学科流水号
objvPubClassCaseFreeSenateENT.DisciplineID = objvPubClassCaseFreeSenateENS.DisciplineID; //学科ID
objvPubClassCaseFreeSenateENT.DisciplineName = objvPubClassCaseFreeSenateENS.DisciplineName; //学科名称
objvPubClassCaseFreeSenateENT.IdStudyLevel = objvPubClassCaseFreeSenateENS.IdStudyLevel; //id_StudyLevel
objvPubClassCaseFreeSenateENT.StudyLevelName = objvPubClassCaseFreeSenateENS.StudyLevelName; //学段名称
objvPubClassCaseFreeSenateENT.PubClassCaseTeachDate = objvPubClassCaseFreeSenateENS.PubClassCaseTeachDate; //案例授课日期
objvPubClassCaseFreeSenateENT.PubClassCaseDateIn = objvPubClassCaseFreeSenateENS.PubClassCaseDateIn; //案例入库日期
objvPubClassCaseFreeSenateENT.IdTeachingPlan = objvPubClassCaseFreeSenateENS.IdTeachingPlan; //教案流水号
objvPubClassCaseFreeSenateENT.SubjectName = objvPubClassCaseFreeSenateENS.SubjectName; //课题名称
objvPubClassCaseFreeSenateENT.IdPubCaseType = objvPubClassCaseFreeSenateENS.IdPubCaseType; //公开课案例类型流水号
objvPubClassCaseFreeSenateENT.PubCaseTypeID = objvPubClassCaseFreeSenateENS.PubCaseTypeID; //公开课案例类型ID
objvPubClassCaseFreeSenateENT.PubCaseTypeName = objvPubClassCaseFreeSenateENS.PubCaseTypeName; //公开课案例类型名称
objvPubClassCaseFreeSenateENT.CollegeID = objvPubClassCaseFreeSenateENS.CollegeID; //学院ID
objvPubClassCaseFreeSenateENT.CollegeName = objvPubClassCaseFreeSenateENS.CollegeName; //学院名称
objvPubClassCaseFreeSenateENT.IdXzCollege = objvPubClassCaseFreeSenateENS.IdXzCollege; //学院流水号
objvPubClassCaseFreeSenateENT.IsLeaved = objvPubClassCaseFreeSenateENS.IsLeaved; //IsLeaved
objvPubClassCaseFreeSenateENT.StuIdTeacherId = objvPubClassCaseFreeSenateENS.StuIdTeacherId; //学工号
objvPubClassCaseFreeSenateENT.BrowseCount4Case = objvPubClassCaseFreeSenateENS.BrowseCount4Case; //课例浏览次数
objvPubClassCaseFreeSenateENT.CollegeNameA = objvPubClassCaseFreeSenateENS.CollegeNameA; //学院名称简写
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
 /// <param name = "objvPubClassCaseFreeSenateEN">源简化对象</param>
 public static void SetUpdFlag(clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN)
{
try
{
objvPubClassCaseFreeSenateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPubClassCaseFreeSenateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate; //公开课案例自由评议流水号
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.IdPubClassCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.IdPubClassCase = objvPubClassCaseFreeSenateEN.IdPubClassCase; //案例流水号
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.PubClassCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.PubClassCaseID = objvPubClassCaseFreeSenateEN.PubClassCaseID; //案例ID
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.PubClassCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.PubClassCaseName = objvPubClassCaseFreeSenateEN.PubClassCaseName; //案例课题名称
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.PubClassCaseExecutor, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objvPubClassCaseFreeSenateEN.PubClassCaseExecutor == "[null]" ? null :  objvPubClassCaseFreeSenateEN.PubClassCaseExecutor; //案例执教者
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.PubClassCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objvPubClassCaseFreeSenateEN.PubClassCaseTheme == "[null]" ? null :  objvPubClassCaseFreeSenateEN.PubClassCaseTheme; //案例主题词
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.UserId = objvPubClassCaseFreeSenateEN.UserId; //用户ID
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.UserName = objvPubClassCaseFreeSenateEN.UserName == "[null]" ? null :  objvPubClassCaseFreeSenateEN.UserName; //用户名
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.AppraiseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.AppraiseTheme = objvPubClassCaseFreeSenateEN.AppraiseTheme == "[null]" ? null :  objvPubClassCaseFreeSenateEN.AppraiseTheme; //评议主题
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle == "[null]" ? null :  objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle; //公开课案例自由评议标题
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten == "[null]" ? null :  objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten; //公开课案例自由评议内容
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate == "[null]" ? null :  objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate; //公开课案例自由评议日期
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime == "[null]" ? null :  objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime; //公开课案例自由评议时间
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.BrowseCount = objvPubClassCaseFreeSenateEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.VideoStopTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.VideoStopTime = objvPubClassCaseFreeSenateEN.VideoStopTime == "[null]" ? null :  objvPubClassCaseFreeSenateEN.VideoStopTime; //公开课案例视频暂停时间
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.IsVisible = objvPubClassCaseFreeSenateEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.IdDiscipline = objvPubClassCaseFreeSenateEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.DisciplineID = objvPubClassCaseFreeSenateEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.DisciplineName = objvPubClassCaseFreeSenateEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.IdStudyLevel = objvPubClassCaseFreeSenateEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.StudyLevelName = objvPubClassCaseFreeSenateEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.PubClassCaseTeachDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate == "[null]" ? null :  objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate; //案例授课日期
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.PubClassCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objvPubClassCaseFreeSenateEN.PubClassCaseDateIn == "[null]" ? null :  objvPubClassCaseFreeSenateEN.PubClassCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.IdTeachingPlan = objvPubClassCaseFreeSenateEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.SubjectName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.SubjectName = objvPubClassCaseFreeSenateEN.SubjectName; //课题名称
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.IdPubCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.IdPubCaseType = objvPubClassCaseFreeSenateEN.IdPubCaseType; //公开课案例类型流水号
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.PubCaseTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.PubCaseTypeID = objvPubClassCaseFreeSenateEN.PubCaseTypeID; //公开课案例类型ID
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.PubCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.PubCaseTypeName = objvPubClassCaseFreeSenateEN.PubCaseTypeName; //公开课案例类型名称
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.CollegeID = objvPubClassCaseFreeSenateEN.CollegeID == "[null]" ? null :  objvPubClassCaseFreeSenateEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.CollegeName = objvPubClassCaseFreeSenateEN.CollegeName == "[null]" ? null :  objvPubClassCaseFreeSenateEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.IdXzCollege = objvPubClassCaseFreeSenateEN.IdXzCollege == "[null]" ? null :  objvPubClassCaseFreeSenateEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.IsLeaved, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.IsLeaved = objvPubClassCaseFreeSenateEN.IsLeaved; //IsLeaved
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.StuIdTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.StuIdTeacherId = objvPubClassCaseFreeSenateEN.StuIdTeacherId == "[null]" ? null :  objvPubClassCaseFreeSenateEN.StuIdTeacherId; //学工号
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.BrowseCount4Case = objvPubClassCaseFreeSenateEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convPubClassCaseFreeSenate.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseFreeSenateEN.CollegeNameA = objvPubClassCaseFreeSenateEN.CollegeNameA == "[null]" ? null :  objvPubClassCaseFreeSenateEN.CollegeNameA; //学院名称简写
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
 /// <param name = "objvPubClassCaseFreeSenateEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN)
{
try
{
if (objvPubClassCaseFreeSenateEN.PubClassCaseExecutor == "[null]") objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = null; //案例执教者
if (objvPubClassCaseFreeSenateEN.PubClassCaseTheme == "[null]") objvPubClassCaseFreeSenateEN.PubClassCaseTheme = null; //案例主题词
if (objvPubClassCaseFreeSenateEN.UserName == "[null]") objvPubClassCaseFreeSenateEN.UserName = null; //用户名
if (objvPubClassCaseFreeSenateEN.AppraiseTheme == "[null]") objvPubClassCaseFreeSenateEN.AppraiseTheme = null; //评议主题
if (objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle == "[null]") objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = null; //公开课案例自由评议标题
if (objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten == "[null]") objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = null; //公开课案例自由评议内容
if (objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate == "[null]") objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = null; //公开课案例自由评议日期
if (objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime == "[null]") objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = null; //公开课案例自由评议时间
if (objvPubClassCaseFreeSenateEN.VideoStopTime == "[null]") objvPubClassCaseFreeSenateEN.VideoStopTime = null; //公开课案例视频暂停时间
if (objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate == "[null]") objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = null; //案例授课日期
if (objvPubClassCaseFreeSenateEN.PubClassCaseDateIn == "[null]") objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = null; //案例入库日期
if (objvPubClassCaseFreeSenateEN.CollegeID == "[null]") objvPubClassCaseFreeSenateEN.CollegeID = null; //学院ID
if (objvPubClassCaseFreeSenateEN.CollegeName == "[null]") objvPubClassCaseFreeSenateEN.CollegeName = null; //学院名称
if (objvPubClassCaseFreeSenateEN.IdXzCollege == "[null]") objvPubClassCaseFreeSenateEN.IdXzCollege = null; //学院流水号
if (objvPubClassCaseFreeSenateEN.StuIdTeacherId == "[null]") objvPubClassCaseFreeSenateEN.StuIdTeacherId = null; //学工号
if (objvPubClassCaseFreeSenateEN.CollegeNameA == "[null]") objvPubClassCaseFreeSenateEN.CollegeNameA = null; //学院名称简写
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
public static void CheckProperty4Condition(clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN)
{
 vPubClassCaseFreeSenateDA.CheckProperty4Condition(objvPubClassCaseFreeSenateEN);
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
if (clsPubClassCaseFreeSenateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseFreeSenateBL没有刷新缓存机制(clsPubClassCaseFreeSenateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseBL没有刷新缓存机制(clsPubClassCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingPlanBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingPlanBL没有刷新缓存机制(clsTeachingPlanBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateGaugeVersionBL没有刷新缓存机制(clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubCaseTypeBL没有刷新缓存机制(clsPubCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdPubClassCaseFreeSenate");
//if (arrvPubClassCaseFreeSenateObjLstCache == null)
//{
//arrvPubClassCaseFreeSenateObjLstCache = vPubClassCaseFreeSenateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdPubClassCaseFreeSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCaseFreeSenateEN GetObjByIdPubClassCaseFreeSenateCache(long lngIdPubClassCaseFreeSenate)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPubClassCaseFreeSenateEN._CurrTabName);
List<clsvPubClassCaseFreeSenateEN> arrvPubClassCaseFreeSenateObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseFreeSenateEN> arrvPubClassCaseFreeSenateObjLst_Sel =
arrvPubClassCaseFreeSenateObjLstCache
.Where(x=> x.IdPubClassCaseFreeSenate == lngIdPubClassCaseFreeSenate 
);
if (arrvPubClassCaseFreeSenateObjLst_Sel.Count() == 0)
{
   clsvPubClassCaseFreeSenateEN obj = clsvPubClassCaseFreeSenateBL.GetObjByIdPubClassCaseFreeSenate(lngIdPubClassCaseFreeSenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPubClassCaseFreeSenateObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPubClassCaseFreeSenateEN> GetAllvPubClassCaseFreeSenateObjLstCache()
{
//获取缓存中的对象列表
List<clsvPubClassCaseFreeSenateEN> arrvPubClassCaseFreeSenateObjLstCache = GetObjLstCache(); 
return arrvPubClassCaseFreeSenateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPubClassCaseFreeSenateEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPubClassCaseFreeSenateEN._CurrTabName);
List<clsvPubClassCaseFreeSenateEN> arrvPubClassCaseFreeSenateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPubClassCaseFreeSenateObjLstCache;
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
string strKey = string.Format("{0}", clsvPubClassCaseFreeSenateEN._CurrTabName);
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
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdPubClassCaseFreeSenate)
{
if (strInFldName != convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPubClassCaseFreeSenate.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPubClassCaseFreeSenate.AttributeName));
throw new Exception(strMsg);
}
var objvPubClassCaseFreeSenate = clsvPubClassCaseFreeSenateBL.GetObjByIdPubClassCaseFreeSenateCache(lngIdPubClassCaseFreeSenate);
if (objvPubClassCaseFreeSenate == null) return "";
return objvPubClassCaseFreeSenate[strOutFldName].ToString();
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
int intRecCount = clsvPubClassCaseFreeSenateDA.GetRecCount(strTabName);
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
int intRecCount = clsvPubClassCaseFreeSenateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPubClassCaseFreeSenateDA.GetRecCount();
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
int intRecCount = clsvPubClassCaseFreeSenateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateCond)
{
List<clsvPubClassCaseFreeSenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseFreeSenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPubClassCaseFreeSenate.AttributeName)
{
if (objvPubClassCaseFreeSenateCond.IsUpdated(strFldName) == false) continue;
if (objvPubClassCaseFreeSenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseFreeSenateCond[strFldName].ToString());
}
else
{
if (objvPubClassCaseFreeSenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPubClassCaseFreeSenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseFreeSenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPubClassCaseFreeSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPubClassCaseFreeSenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseFreeSenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseFreeSenateCond[strFldName]));
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
 List<string> arrList = clsvPubClassCaseFreeSenateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPubClassCaseFreeSenateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPubClassCaseFreeSenateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}