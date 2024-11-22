
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMandarinCaseQuantitySenateWApi
 表名:vMandarinCaseQuantitySenate(01120451)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:54
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:普通话点播
 模块英文名:Mandarin
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
public static class clsvMandarinCaseQuantitySenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN Setid_microteachCaseQuantitySenate(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
objvMandarinCaseQuantitySenateEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.id_microteachCaseQuantitySenate) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetFuncModuleId(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMandarinCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMandarinCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMandarinCaseQuantitySenate.FuncModuleId);
objvMandarinCaseQuantitySenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.FuncModuleId) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.FuncModuleId, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.FuncModuleId] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetFuncModuleName(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMandarinCaseQuantitySenate.FuncModuleName);
objvMandarinCaseQuantitySenateEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.FuncModuleName) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.FuncModuleName, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.FuncModuleName] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN Setid_AppraiseType(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convMandarinCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convMandarinCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convMandarinCaseQuantitySenate.id_AppraiseType);
objvMandarinCaseQuantitySenateEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.id_AppraiseType) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.id_AppraiseType, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.id_AppraiseType] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetAppraiseTypeName(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convMandarinCaseQuantitySenate.AppraiseTypeName);
objvMandarinCaseQuantitySenateEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.AppraiseTypeName) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.AppraiseTypeName, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.AppraiseTypeName] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN Setid_MicroteachCase(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convMandarinCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMandarinCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMandarinCaseQuantitySenate.id_MicroteachCase);
objvMandarinCaseQuantitySenateEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.id_MicroteachCase) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.id_MicroteachCase, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.id_MicroteachCase] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetMandarinCaseID(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strMandarinCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseID, 8, convMandarinCaseQuantitySenate.MandarinCaseID);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseID, 8, convMandarinCaseQuantitySenate.MandarinCaseID);
objvMandarinCaseQuantitySenateEN.MandarinCaseID = strMandarinCaseID; //普通话教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.MandarinCaseID) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.MandarinCaseID, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.MandarinCaseID] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetMandarinCaseName(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strMandarinCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseName, 100, convMandarinCaseQuantitySenate.MandarinCaseName);
objvMandarinCaseQuantitySenateEN.MandarinCaseName = strMandarinCaseName; //普通话教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.MandarinCaseName) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.MandarinCaseName, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.MandarinCaseName] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetMandarinCaseDate(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strMandarinCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseDate, 8, convMandarinCaseQuantitySenate.MandarinCaseDate);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseDate, 8, convMandarinCaseQuantitySenate.MandarinCaseDate);
objvMandarinCaseQuantitySenateEN.MandarinCaseDate = strMandarinCaseDate; //普通话教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.MandarinCaseDate) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.MandarinCaseDate, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.MandarinCaseDate] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetSenateTheme(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convMandarinCaseQuantitySenate.SenateTheme);
objvMandarinCaseQuantitySenateEN.SenateTheme = strSenateTheme; //量化评价主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.SenateTheme) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.SenateTheme, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.SenateTheme] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetSenateContent(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convMandarinCaseQuantitySenate.SenateContent);
objvMandarinCaseQuantitySenateEN.SenateContent = strSenateContent; //评价内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.SenateContent) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.SenateContent, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.SenateContent] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetSenateTotalScore(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, float fltSenateTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltSenateTotalScore, convMandarinCaseQuantitySenate.SenateTotalScore);
objvMandarinCaseQuantitySenateEN.SenateTotalScore = fltSenateTotalScore; //评价分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.SenateTotalScore) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.SenateTotalScore, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.SenateTotalScore] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetSenateDate(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convMandarinCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convMandarinCaseQuantitySenate.SenateDate);
objvMandarinCaseQuantitySenateEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.SenateDate) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.SenateDate, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.SenateDate] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetSenateTime(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convMandarinCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convMandarinCaseQuantitySenate.SenateTime);
objvMandarinCaseQuantitySenateEN.SenateTime = strSenateTime; //评价时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.SenateTime) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.SenateTime, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.SenateTime] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetBrowseCount(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, int intBrowseCount, string strComparisonOp="")
	{
objvMandarinCaseQuantitySenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.BrowseCount) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.BrowseCount, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.BrowseCount] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN Setid_SenateGaugeVersion(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convMandarinCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convMandarinCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convMandarinCaseQuantitySenate.id_SenateGaugeVersion);
objvMandarinCaseQuantitySenateEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.id_SenateGaugeVersion) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convMandarinCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMandarinCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMandarinCaseQuantitySenate.senateGaugeVersionID);
objvMandarinCaseQuantitySenateEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.senateGaugeVersionID) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.senateGaugeVersionID, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.senateGaugeVersionID] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMandarinCaseQuantitySenate.senateGaugeVersionName);
objvMandarinCaseQuantitySenateEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.senateGaugeVersionName) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.senateGaugeVersionName, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.senateGaugeVersionName] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetsenateGaugeVersionTtlScore(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore);
objvMandarinCaseQuantitySenateEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetSenateIp(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateIp, 50, convMandarinCaseQuantitySenate.SenateIp);
objvMandarinCaseQuantitySenateEN.SenateIp = strSenateIp; //评议Ip
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.SenateIp) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.SenateIp, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.SenateIp] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetUpdUserName(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convMandarinCaseQuantitySenate.UpdUserName);
objvMandarinCaseQuantitySenateEN.UpdUserName = strUpdUserName; //UpdUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.UpdUserName) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.UpdUserName, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.UpdUserName] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetUpdUser(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMandarinCaseQuantitySenate.UpdUser);
objvMandarinCaseQuantitySenateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.UpdUser) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.UpdUser, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.UpdUser] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetCollegeID(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMandarinCaseQuantitySenate.CollegeID);
objvMandarinCaseQuantitySenateEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.CollegeID) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.CollegeID, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.CollegeID] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetCollegeName(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMandarinCaseQuantitySenate.CollegeName);
objvMandarinCaseQuantitySenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.CollegeName) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.CollegeName, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.CollegeName] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetIsLeaved(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, bool bolIsLeaved, string strComparisonOp="")
	{
objvMandarinCaseQuantitySenateEN.IsLeaved = bolIsLeaved; //IsLeaved
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.IsLeaved) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.IsLeaved, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.IsLeaved] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetStuIdTeacherId(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strStuIdTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuIdTeacherId, 20, convMandarinCaseQuantitySenate.StuIdTeacherId);
objvMandarinCaseQuantitySenateEN.StuIdTeacherId = strStuIdTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.StuIdTeacherId) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.StuIdTeacherId, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.StuIdTeacherId] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetUserId(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convMandarinCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convMandarinCaseQuantitySenate.UserId);
objvMandarinCaseQuantitySenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.UserId) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.UserId, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.UserId] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetUserName(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convMandarinCaseQuantitySenate.UserName);
objvMandarinCaseQuantitySenateEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.UserName) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.UserName, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.UserName] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetOwnerId(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMandarinCaseQuantitySenate.OwnerId);
objvMandarinCaseQuantitySenateEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.OwnerId) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.OwnerId, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.OwnerId] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetOwnerName(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMandarinCaseQuantitySenate.OwnerName);
objvMandarinCaseQuantitySenateEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.OwnerName) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.OwnerName, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.OwnerName] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetStuID(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convMandarinCaseQuantitySenate.StuID);
objvMandarinCaseQuantitySenateEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.StuID) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.StuID, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.StuID] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetStuName(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convMandarinCaseQuantitySenate.StuName);
objvMandarinCaseQuantitySenateEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.StuName) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.StuName, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.StuName] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN Setid_MandarinCase(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strid_MandarinCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MandarinCase, 8, convMandarinCaseQuantitySenate.id_MandarinCase);
clsCheckSql.CheckFieldForeignKey(strid_MandarinCase, 8, convMandarinCaseQuantitySenate.id_MandarinCase);
objvMandarinCaseQuantitySenateEN.id_MandarinCase = strid_MandarinCase; //普通话案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.id_MandarinCase) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.id_MandarinCase, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.id_MandarinCase] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetMandarinCaseTypeName(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strMandarinCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseTypeName, 50, convMandarinCaseQuantitySenate.MandarinCaseTypeName);
objvMandarinCaseQuantitySenateEN.MandarinCaseTypeName = strMandarinCaseTypeName; //普通话案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.MandarinCaseTypeName) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.MandarinCaseTypeName, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.MandarinCaseTypeName] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetUserNameWithUserId(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convMandarinCaseQuantitySenate.UserNameWithUserId);
objvMandarinCaseQuantitySenateEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.UserNameWithUserId) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.UserNameWithUserId, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.UserNameWithUserId] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetOwnerNameWithId(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convMandarinCaseQuantitySenate.OwnerNameWithId);
objvMandarinCaseQuantitySenateEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.OwnerNameWithId) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.OwnerNameWithId, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.OwnerNameWithId] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN Setid_XzCollege(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convMandarinCaseQuantitySenate.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convMandarinCaseQuantitySenate.id_XzCollege);
objvMandarinCaseQuantitySenateEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.id_XzCollege) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.id_XzCollege, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.id_XzCollege] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseQuantitySenateEN SetCollegeNameA(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMandarinCaseQuantitySenate.CollegeNameA);
objvMandarinCaseQuantitySenateEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMandarinCaseQuantitySenate.CollegeNameA) == false)
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp.Add(convMandarinCaseQuantitySenate.CollegeNameA, strComparisonOp);
}
else
{
objvMandarinCaseQuantitySenateEN.dicFldComparisonOp[convMandarinCaseQuantitySenate.CollegeNameA] = strComparisonOp;
}
}
return objvMandarinCaseQuantitySenateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convMandarinCaseQuantitySenate.id_microteachCaseQuantitySenate, objvMandarinCaseQuantitySenate_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.FuncModuleId, objvMandarinCaseQuantitySenate_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.FuncModuleName, objvMandarinCaseQuantitySenate_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.id_AppraiseType, objvMandarinCaseQuantitySenate_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.AppraiseTypeName, objvMandarinCaseQuantitySenate_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.id_MicroteachCase, objvMandarinCaseQuantitySenate_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.MandarinCaseID) == true)
{
string strComparisonOp_MandarinCaseID = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.MandarinCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.MandarinCaseID, objvMandarinCaseQuantitySenate_Cond.MandarinCaseID, strComparisonOp_MandarinCaseID);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.MandarinCaseName) == true)
{
string strComparisonOp_MandarinCaseName = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.MandarinCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.MandarinCaseName, objvMandarinCaseQuantitySenate_Cond.MandarinCaseName, strComparisonOp_MandarinCaseName);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.MandarinCaseDate) == true)
{
string strComparisonOp_MandarinCaseDate = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.MandarinCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.MandarinCaseDate, objvMandarinCaseQuantitySenate_Cond.MandarinCaseDate, strComparisonOp_MandarinCaseDate);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.SenateTheme) == true)
{
string strComparisonOp_SenateTheme = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.SenateTheme, objvMandarinCaseQuantitySenate_Cond.SenateTheme, strComparisonOp_SenateTheme);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.SenateContent) == true)
{
string strComparisonOp_SenateContent = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.SenateContent, objvMandarinCaseQuantitySenate_Cond.SenateContent, strComparisonOp_SenateContent);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOp_SenateTotalScore = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMandarinCaseQuantitySenate.SenateTotalScore, objvMandarinCaseQuantitySenate_Cond.SenateTotalScore, strComparisonOp_SenateTotalScore);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.SenateDate, objvMandarinCaseQuantitySenate_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.SenateTime) == true)
{
string strComparisonOp_SenateTime = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.SenateTime, objvMandarinCaseQuantitySenate_Cond.SenateTime, strComparisonOp_SenateTime);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMandarinCaseQuantitySenate.BrowseCount, objvMandarinCaseQuantitySenate_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.id_SenateGaugeVersion, objvMandarinCaseQuantitySenate_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.senateGaugeVersionID, objvMandarinCaseQuantitySenate_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.senateGaugeVersionName, objvMandarinCaseQuantitySenate_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore, objvMandarinCaseQuantitySenate_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.SenateIp) == true)
{
string strComparisonOp_SenateIp = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.SenateIp, objvMandarinCaseQuantitySenate_Cond.SenateIp, strComparisonOp_SenateIp);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.UpdUserName) == true)
{
string strComparisonOp_UpdUserName = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.UpdUserName, objvMandarinCaseQuantitySenate_Cond.UpdUserName, strComparisonOp_UpdUserName);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.UpdUser, objvMandarinCaseQuantitySenate_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.CollegeID, objvMandarinCaseQuantitySenate_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.CollegeName, objvMandarinCaseQuantitySenate_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.IsLeaved) == true)
{
if (objvMandarinCaseQuantitySenate_Cond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMandarinCaseQuantitySenate.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMandarinCaseQuantitySenate.IsLeaved);
}
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.StuIdTeacherId) == true)
{
string strComparisonOp_StuIdTeacherId = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.StuIdTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.StuIdTeacherId, objvMandarinCaseQuantitySenate_Cond.StuIdTeacherId, strComparisonOp_StuIdTeacherId);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.UserId) == true)
{
string strComparisonOp_UserId = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.UserId, objvMandarinCaseQuantitySenate_Cond.UserId, strComparisonOp_UserId);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.UserName) == true)
{
string strComparisonOp_UserName = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.UserName, objvMandarinCaseQuantitySenate_Cond.UserName, strComparisonOp_UserName);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.OwnerId, objvMandarinCaseQuantitySenate_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.OwnerName, objvMandarinCaseQuantitySenate_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.StuID) == true)
{
string strComparisonOp_StuID = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.StuID, objvMandarinCaseQuantitySenate_Cond.StuID, strComparisonOp_StuID);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.StuName) == true)
{
string strComparisonOp_StuName = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.StuName, objvMandarinCaseQuantitySenate_Cond.StuName, strComparisonOp_StuName);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.id_MandarinCase) == true)
{
string strComparisonOp_id_MandarinCase = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.id_MandarinCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.id_MandarinCase, objvMandarinCaseQuantitySenate_Cond.id_MandarinCase, strComparisonOp_id_MandarinCase);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.MandarinCaseTypeName) == true)
{
string strComparisonOp_MandarinCaseTypeName = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.MandarinCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.MandarinCaseTypeName, objvMandarinCaseQuantitySenate_Cond.MandarinCaseTypeName, strComparisonOp_MandarinCaseTypeName);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.UserNameWithUserId, objvMandarinCaseQuantitySenate_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.OwnerNameWithId, objvMandarinCaseQuantitySenate_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.id_XzCollege, objvMandarinCaseQuantitySenate_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvMandarinCaseQuantitySenate_Cond.IsUpdated(convMandarinCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvMandarinCaseQuantitySenate_Cond.dicFldComparisonOp[convMandarinCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseQuantitySenate.CollegeNameA, objvMandarinCaseQuantitySenate_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vMandarinCaseQuantitySenate(vMandarinCaseQuantitySenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMandarinCaseQuantitySenateWApi
{
private static readonly string mstrApiControllerName = "vMandarinCaseQuantitySenateApi";

 public clsvMandarinCaseQuantitySenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMandarinCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenate"] = lngid_microteachCaseQuantitySenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMandarinCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvMandarinCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvMandarinCaseQuantitySenateEN;
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
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMandarinCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_WA_Cache(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenate"] = lngid_microteachCaseQuantitySenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMandarinCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvMandarinCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvMandarinCaseQuantitySenateEN;
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
public static clsvMandarinCaseQuantitySenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN = null;
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
objvMandarinCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvMandarinCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvMandarinCaseQuantitySenateEN;
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
 /// <param name = "lngid_microteachCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMandarinCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_Cache(long lngid_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMandarinCaseQuantitySenateEN._CurrTabName_S);
List<clsvMandarinCaseQuantitySenateEN> arrvMandarinCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMandarinCaseQuantitySenateEN> arrvMandarinCaseQuantitySenateObjLst_Sel =
from objvMandarinCaseQuantitySenateEN in arrvMandarinCaseQuantitySenateObjLst_Cache
where objvMandarinCaseQuantitySenateEN.id_microteachCaseQuantitySenate == lngid_microteachCaseQuantitySenate
select objvMandarinCaseQuantitySenateEN;
if (arrvMandarinCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvMandarinCaseQuantitySenateEN obj = clsvMandarinCaseQuantitySenateWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMandarinCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMandarinCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
 List<clsvMandarinCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvMandarinCaseQuantitySenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_microteachCaseQuantitySenateLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_microteachCaseQuantitySenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_microteachCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvMandarinCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMandarinCaseQuantitySenateEN._CurrTabName_S);
List<clsvMandarinCaseQuantitySenateEN> arrvMandarinCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMandarinCaseQuantitySenateEN> arrvMandarinCaseQuantitySenateObjLst_Sel =
from objvMandarinCaseQuantitySenateEN in arrvMandarinCaseQuantitySenateObjLst_Cache
where arrId_microteachCaseQuantitySenate.Contains(objvMandarinCaseQuantitySenateEN.id_microteachCaseQuantitySenate)
select objvMandarinCaseQuantitySenateEN;
return arrvMandarinCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMandarinCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvMandarinCaseQuantitySenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_microteachCaseQuantitySenateLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_microteachCaseQuantitySenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMandarinCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCaseQuantitySenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMandarinCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMandarinCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCaseQuantitySenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMandarinCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_microteachCaseQuantitySenate)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenate"] = lngid_microteachCaseQuantitySenate.ToString()
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
 /// <param name = "objvMandarinCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvMandarinCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateENS, clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateENT)
{
try
{
objvMandarinCaseQuantitySenateENT.id_microteachCaseQuantitySenate = objvMandarinCaseQuantitySenateENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvMandarinCaseQuantitySenateENT.FuncModuleId = objvMandarinCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvMandarinCaseQuantitySenateENT.FuncModuleName = objvMandarinCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvMandarinCaseQuantitySenateENT.id_AppraiseType = objvMandarinCaseQuantitySenateENS.id_AppraiseType; //评议类型流水号
objvMandarinCaseQuantitySenateENT.AppraiseTypeName = objvMandarinCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvMandarinCaseQuantitySenateENT.id_MicroteachCase = objvMandarinCaseQuantitySenateENS.id_MicroteachCase; //微格教学案例流水号
objvMandarinCaseQuantitySenateENT.MandarinCaseID = objvMandarinCaseQuantitySenateENS.MandarinCaseID; //普通话教学案例ID
objvMandarinCaseQuantitySenateENT.MandarinCaseName = objvMandarinCaseQuantitySenateENS.MandarinCaseName; //普通话教学案例名称
objvMandarinCaseQuantitySenateENT.MandarinCaseDate = objvMandarinCaseQuantitySenateENS.MandarinCaseDate; //普通话教学日期
objvMandarinCaseQuantitySenateENT.SenateTheme = objvMandarinCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvMandarinCaseQuantitySenateENT.SenateContent = objvMandarinCaseQuantitySenateENS.SenateContent; //评价内容
objvMandarinCaseQuantitySenateENT.SenateTotalScore = objvMandarinCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvMandarinCaseQuantitySenateENT.SenateDate = objvMandarinCaseQuantitySenateENS.SenateDate; //评价日期
objvMandarinCaseQuantitySenateENT.SenateTime = objvMandarinCaseQuantitySenateENS.SenateTime; //评价时间
objvMandarinCaseQuantitySenateENT.BrowseCount = objvMandarinCaseQuantitySenateENS.BrowseCount; //浏览次数
objvMandarinCaseQuantitySenateENT.id_SenateGaugeVersion = objvMandarinCaseQuantitySenateENS.id_SenateGaugeVersion; //评价量表版本流水号
objvMandarinCaseQuantitySenateENT.senateGaugeVersionID = objvMandarinCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvMandarinCaseQuantitySenateENT.senateGaugeVersionName = objvMandarinCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvMandarinCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvMandarinCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMandarinCaseQuantitySenateENT.SenateIp = objvMandarinCaseQuantitySenateENS.SenateIp; //评议Ip
objvMandarinCaseQuantitySenateENT.UpdUserName = objvMandarinCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvMandarinCaseQuantitySenateENT.UpdUser = objvMandarinCaseQuantitySenateENS.UpdUser; //修改人
objvMandarinCaseQuantitySenateENT.CollegeID = objvMandarinCaseQuantitySenateENS.CollegeID; //学院ID
objvMandarinCaseQuantitySenateENT.CollegeName = objvMandarinCaseQuantitySenateENS.CollegeName; //学院名称
objvMandarinCaseQuantitySenateENT.IsLeaved = objvMandarinCaseQuantitySenateENS.IsLeaved; //IsLeaved
objvMandarinCaseQuantitySenateENT.StuIdTeacherId = objvMandarinCaseQuantitySenateENS.StuIdTeacherId; //学工号
objvMandarinCaseQuantitySenateENT.UserId = objvMandarinCaseQuantitySenateENS.UserId; //用户ID
objvMandarinCaseQuantitySenateENT.UserName = objvMandarinCaseQuantitySenateENS.UserName; //用户名
objvMandarinCaseQuantitySenateENT.OwnerId = objvMandarinCaseQuantitySenateENS.OwnerId; //拥有者Id
objvMandarinCaseQuantitySenateENT.OwnerName = objvMandarinCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvMandarinCaseQuantitySenateENT.StuID = objvMandarinCaseQuantitySenateENS.StuID; //学号
objvMandarinCaseQuantitySenateENT.StuName = objvMandarinCaseQuantitySenateENS.StuName; //姓名
objvMandarinCaseQuantitySenateENT.id_MandarinCase = objvMandarinCaseQuantitySenateENS.id_MandarinCase; //普通话案例流水号
objvMandarinCaseQuantitySenateENT.MandarinCaseTypeName = objvMandarinCaseQuantitySenateENS.MandarinCaseTypeName; //普通话案例类型名称
objvMandarinCaseQuantitySenateENT.UserNameWithUserId = objvMandarinCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvMandarinCaseQuantitySenateENT.OwnerNameWithId = objvMandarinCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvMandarinCaseQuantitySenateENT.id_XzCollege = objvMandarinCaseQuantitySenateENS.id_XzCollege; //学院流水号
objvMandarinCaseQuantitySenateENT.CollegeNameA = objvMandarinCaseQuantitySenateENS.CollegeNameA; //学院名称简写
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
public static DataTable ToDataTable(List<clsvMandarinCaseQuantitySenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMandarinCaseQuantitySenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMandarinCaseQuantitySenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMandarinCaseQuantitySenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMandarinCaseQuantitySenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMandarinCaseQuantitySenateEN.AttributeName)
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
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeWApi没有刷新缓存机制(clsAppraiseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateWApi没有刷新缓存机制(clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMandarinCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMandarinCaseWApi没有刷新缓存机制(clsMandarinCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMandarinCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMandarinCaseTypeWApi没有刷新缓存机制(clsMandarinCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoWApi没有刷新缓存机制(clsStudentInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeWApi没有刷新缓存机制(clsRsStuTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsWApi没有刷新缓存机制(clsXzAdminClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeWApi没有刷新缓存机制(clsXzAdminClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenate");
//if (arrvMandarinCaseQuantitySenateObjLst_Cache == null)
//{
//arrvMandarinCaseQuantitySenateObjLst_Cache = await clsvMandarinCaseQuantitySenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMandarinCaseQuantitySenateEN._CurrTabName_S);
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
public static List<clsvMandarinCaseQuantitySenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMandarinCaseQuantitySenateEN._CurrTabName_S);
List<clsvMandarinCaseQuantitySenateEN> arrvMandarinCaseQuantitySenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMandarinCaseQuantitySenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMandarinCaseQuantitySenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMandarinCaseQuantitySenate.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.MandarinCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.MandarinCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.MandarinCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.SenateTheme, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.SenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.SenateTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.SenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.SenateIp, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.UpdUserName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.IsLeaved, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.StuIdTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.id_MandarinCase, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.MandarinCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseQuantitySenate.CollegeNameA, Type.GetType("System.String"));
foreach (clsvMandarinCaseQuantitySenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMandarinCaseQuantitySenate.id_microteachCaseQuantitySenate] = objInFor[convMandarinCaseQuantitySenate.id_microteachCaseQuantitySenate];
objDR[convMandarinCaseQuantitySenate.FuncModuleId] = objInFor[convMandarinCaseQuantitySenate.FuncModuleId];
objDR[convMandarinCaseQuantitySenate.FuncModuleName] = objInFor[convMandarinCaseQuantitySenate.FuncModuleName];
objDR[convMandarinCaseQuantitySenate.id_AppraiseType] = objInFor[convMandarinCaseQuantitySenate.id_AppraiseType];
objDR[convMandarinCaseQuantitySenate.AppraiseTypeName] = objInFor[convMandarinCaseQuantitySenate.AppraiseTypeName];
objDR[convMandarinCaseQuantitySenate.id_MicroteachCase] = objInFor[convMandarinCaseQuantitySenate.id_MicroteachCase];
objDR[convMandarinCaseQuantitySenate.MandarinCaseID] = objInFor[convMandarinCaseQuantitySenate.MandarinCaseID];
objDR[convMandarinCaseQuantitySenate.MandarinCaseName] = objInFor[convMandarinCaseQuantitySenate.MandarinCaseName];
objDR[convMandarinCaseQuantitySenate.MandarinCaseDate] = objInFor[convMandarinCaseQuantitySenate.MandarinCaseDate];
objDR[convMandarinCaseQuantitySenate.SenateTheme] = objInFor[convMandarinCaseQuantitySenate.SenateTheme];
objDR[convMandarinCaseQuantitySenate.SenateContent] = objInFor[convMandarinCaseQuantitySenate.SenateContent];
objDR[convMandarinCaseQuantitySenate.SenateTotalScore] = objInFor[convMandarinCaseQuantitySenate.SenateTotalScore];
objDR[convMandarinCaseQuantitySenate.SenateDate] = objInFor[convMandarinCaseQuantitySenate.SenateDate];
objDR[convMandarinCaseQuantitySenate.SenateTime] = objInFor[convMandarinCaseQuantitySenate.SenateTime];
objDR[convMandarinCaseQuantitySenate.BrowseCount] = objInFor[convMandarinCaseQuantitySenate.BrowseCount];
objDR[convMandarinCaseQuantitySenate.id_SenateGaugeVersion] = objInFor[convMandarinCaseQuantitySenate.id_SenateGaugeVersion];
objDR[convMandarinCaseQuantitySenate.senateGaugeVersionID] = objInFor[convMandarinCaseQuantitySenate.senateGaugeVersionID];
objDR[convMandarinCaseQuantitySenate.senateGaugeVersionName] = objInFor[convMandarinCaseQuantitySenate.senateGaugeVersionName];
objDR[convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore] = objInFor[convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore];
objDR[convMandarinCaseQuantitySenate.SenateIp] = objInFor[convMandarinCaseQuantitySenate.SenateIp];
objDR[convMandarinCaseQuantitySenate.UpdUserName] = objInFor[convMandarinCaseQuantitySenate.UpdUserName];
objDR[convMandarinCaseQuantitySenate.UpdUser] = objInFor[convMandarinCaseQuantitySenate.UpdUser];
objDR[convMandarinCaseQuantitySenate.CollegeID] = objInFor[convMandarinCaseQuantitySenate.CollegeID];
objDR[convMandarinCaseQuantitySenate.CollegeName] = objInFor[convMandarinCaseQuantitySenate.CollegeName];
objDR[convMandarinCaseQuantitySenate.IsLeaved] = objInFor[convMandarinCaseQuantitySenate.IsLeaved];
objDR[convMandarinCaseQuantitySenate.StuIdTeacherId] = objInFor[convMandarinCaseQuantitySenate.StuIdTeacherId];
objDR[convMandarinCaseQuantitySenate.UserId] = objInFor[convMandarinCaseQuantitySenate.UserId];
objDR[convMandarinCaseQuantitySenate.UserName] = objInFor[convMandarinCaseQuantitySenate.UserName];
objDR[convMandarinCaseQuantitySenate.OwnerId] = objInFor[convMandarinCaseQuantitySenate.OwnerId];
objDR[convMandarinCaseQuantitySenate.OwnerName] = objInFor[convMandarinCaseQuantitySenate.OwnerName];
objDR[convMandarinCaseQuantitySenate.StuID] = objInFor[convMandarinCaseQuantitySenate.StuID];
objDR[convMandarinCaseQuantitySenate.StuName] = objInFor[convMandarinCaseQuantitySenate.StuName];
objDR[convMandarinCaseQuantitySenate.id_MandarinCase] = objInFor[convMandarinCaseQuantitySenate.id_MandarinCase];
objDR[convMandarinCaseQuantitySenate.MandarinCaseTypeName] = objInFor[convMandarinCaseQuantitySenate.MandarinCaseTypeName];
objDR[convMandarinCaseQuantitySenate.UserNameWithUserId] = objInFor[convMandarinCaseQuantitySenate.UserNameWithUserId];
objDR[convMandarinCaseQuantitySenate.OwnerNameWithId] = objInFor[convMandarinCaseQuantitySenate.OwnerNameWithId];
objDR[convMandarinCaseQuantitySenate.id_XzCollege] = objInFor[convMandarinCaseQuantitySenate.id_XzCollege];
objDR[convMandarinCaseQuantitySenate.CollegeNameA] = objInFor[convMandarinCaseQuantitySenate.CollegeNameA];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}