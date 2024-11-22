
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWritingOnBBCaseQuantitySenateWApi
 表名:vWritingOnBBCaseQuantitySenate(01120446)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:49
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:板书点播
 模块英文名:WritingOnBlackboard
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
public static class clsvWritingOnBBCaseQuantitySenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN Setid_microteachCaseQuantitySenate(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
objvWritingOnBBCaseQuantitySenateEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.id_microteachCaseQuantitySenate) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetFuncModuleId(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convWritingOnBBCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convWritingOnBBCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convWritingOnBBCaseQuantitySenate.FuncModuleId);
objvWritingOnBBCaseQuantitySenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.FuncModuleId) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.FuncModuleId, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.FuncModuleId] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetFuncModuleName(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convWritingOnBBCaseQuantitySenate.FuncModuleName);
objvWritingOnBBCaseQuantitySenateEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.FuncModuleName) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.FuncModuleName, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.FuncModuleName] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN Setid_MicroteachCase(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convWritingOnBBCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convWritingOnBBCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convWritingOnBBCaseQuantitySenate.id_MicroteachCase);
objvWritingOnBBCaseQuantitySenateEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.id_MicroteachCase) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.id_MicroteachCase, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.id_MicroteachCase] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN Setid_AppraiseType(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convWritingOnBBCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convWritingOnBBCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convWritingOnBBCaseQuantitySenate.id_AppraiseType);
objvWritingOnBBCaseQuantitySenateEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.id_AppraiseType) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.id_AppraiseType, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.id_AppraiseType] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetAppraiseTypeName(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convWritingOnBBCaseQuantitySenate.AppraiseTypeName);
objvWritingOnBBCaseQuantitySenateEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.AppraiseTypeName) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.AppraiseTypeName, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.AppraiseTypeName] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN Setid_WritingOnBBCase(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strid_WritingOnBBCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_WritingOnBBCase, convWritingOnBBCaseQuantitySenate.id_WritingOnBBCase);
clsCheckSql.CheckFieldLen(strid_WritingOnBBCase, 8, convWritingOnBBCaseQuantitySenate.id_WritingOnBBCase);
clsCheckSql.CheckFieldForeignKey(strid_WritingOnBBCase, 8, convWritingOnBBCaseQuantitySenate.id_WritingOnBBCase);
objvWritingOnBBCaseQuantitySenateEN.id_WritingOnBBCase = strid_WritingOnBBCase; //板书案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.id_WritingOnBBCase) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.id_WritingOnBBCase, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.id_WritingOnBBCase] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetWritingOnBBCaseID(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strWritingOnBBCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWritingOnBBCaseID, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID);
clsCheckSql.CheckFieldLen(strWritingOnBBCaseID, 8, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseID, 8, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID);
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseID = strWritingOnBBCaseID; //板书教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetWritingOnBBCaseName(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strWritingOnBBCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWritingOnBBCaseName, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName);
clsCheckSql.CheckFieldLen(strWritingOnBBCaseName, 100, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName);
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseName = strWritingOnBBCaseName; //板书教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetWritingOnBBCaseDate(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strWritingOnBBCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseDate, 8, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseDate, 8, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate);
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseDate = strWritingOnBBCaseDate; //板书教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetBrowseCount(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, int intBrowseCount, string strComparisonOp="")
	{
objvWritingOnBBCaseQuantitySenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.BrowseCount) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.BrowseCount, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.BrowseCount] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetSenateTheme(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convWritingOnBBCaseQuantitySenate.SenateTheme);
objvWritingOnBBCaseQuantitySenateEN.SenateTheme = strSenateTheme; //量化评价主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.SenateTheme) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.SenateTheme, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.SenateTheme] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetSenateContent(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convWritingOnBBCaseQuantitySenate.SenateContent);
objvWritingOnBBCaseQuantitySenateEN.SenateContent = strSenateContent; //评价内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.SenateContent) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.SenateContent, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.SenateContent] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetSenateTotalScore(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, float fltSenateTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltSenateTotalScore, convWritingOnBBCaseQuantitySenate.SenateTotalScore);
objvWritingOnBBCaseQuantitySenateEN.SenateTotalScore = fltSenateTotalScore; //评价分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.SenateTotalScore) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.SenateTotalScore, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.SenateTotalScore] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetSenateDate(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convWritingOnBBCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convWritingOnBBCaseQuantitySenate.SenateDate);
objvWritingOnBBCaseQuantitySenateEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.SenateDate) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.SenateDate, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.SenateDate] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetSenateTime(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convWritingOnBBCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convWritingOnBBCaseQuantitySenate.SenateTime);
objvWritingOnBBCaseQuantitySenateEN.SenateTime = strSenateTime; //评价时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.SenateTime) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.SenateTime, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.SenateTime] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN Setid_SenateGaugeVersion(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convWritingOnBBCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convWritingOnBBCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convWritingOnBBCaseQuantitySenate.id_SenateGaugeVersion);
objvWritingOnBBCaseQuantitySenateEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.id_SenateGaugeVersion) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convWritingOnBBCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convWritingOnBBCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convWritingOnBBCaseQuantitySenate.senateGaugeVersionID);
objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.senateGaugeVersionID) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.senateGaugeVersionID, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.senateGaugeVersionID] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convWritingOnBBCaseQuantitySenate.senateGaugeVersionName);
objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.senateGaugeVersionName) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.senateGaugeVersionName, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetsenateGaugeVersionTtlScore(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore);
objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetUpdUserName(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convWritingOnBBCaseQuantitySenate.UpdUserName);
objvWritingOnBBCaseQuantitySenateEN.UpdUserName = strUpdUserName; //UpdUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.UpdUserName) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.UpdUserName, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.UpdUserName] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetUpdUser(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convWritingOnBBCaseQuantitySenate.UpdUser);
objvWritingOnBBCaseQuantitySenateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.UpdUser) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.UpdUser, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.UpdUser] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetCollegeID(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convWritingOnBBCaseQuantitySenate.CollegeID);
objvWritingOnBBCaseQuantitySenateEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.CollegeID) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.CollegeID, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.CollegeID] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetCollegeName(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convWritingOnBBCaseQuantitySenate.CollegeName);
objvWritingOnBBCaseQuantitySenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.CollegeName) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.CollegeName, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.CollegeName] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetIsLeaved(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, bool bolIsLeaved, string strComparisonOp="")
	{
objvWritingOnBBCaseQuantitySenateEN.IsLeaved = bolIsLeaved; //IsLeaved
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.IsLeaved) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.IsLeaved, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.IsLeaved] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetSenateIp(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateIp, 50, convWritingOnBBCaseQuantitySenate.SenateIp);
objvWritingOnBBCaseQuantitySenateEN.SenateIp = strSenateIp; //评议Ip
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.SenateIp) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.SenateIp, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.SenateIp] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetStuIdTeacherId(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strStuIdTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuIdTeacherId, 20, convWritingOnBBCaseQuantitySenate.StuIdTeacherId);
objvWritingOnBBCaseQuantitySenateEN.StuIdTeacherId = strStuIdTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.StuIdTeacherId) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.StuIdTeacherId, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.StuIdTeacherId] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetUserId(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convWritingOnBBCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convWritingOnBBCaseQuantitySenate.UserId);
objvWritingOnBBCaseQuantitySenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.UserId) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.UserId, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.UserId] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetUserName(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convWritingOnBBCaseQuantitySenate.UserName);
objvWritingOnBBCaseQuantitySenateEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.UserName) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.UserName, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.UserName] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetOwnerId(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convWritingOnBBCaseQuantitySenate.OwnerId);
objvWritingOnBBCaseQuantitySenateEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.OwnerId) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.OwnerId, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.OwnerId] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetStuID(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convWritingOnBBCaseQuantitySenate.StuID);
objvWritingOnBBCaseQuantitySenateEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.StuID) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.StuID, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.StuID] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetStuName(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convWritingOnBBCaseQuantitySenate.StuName);
objvWritingOnBBCaseQuantitySenateEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.StuName) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.StuName, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.StuName] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetOwnerName(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convWritingOnBBCaseQuantitySenate.OwnerName);
objvWritingOnBBCaseQuantitySenateEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.OwnerName) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.OwnerName, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.OwnerName] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetUserNameWithUserId(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convWritingOnBBCaseQuantitySenate.UserNameWithUserId);
objvWritingOnBBCaseQuantitySenateEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.UserNameWithUserId) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.UserNameWithUserId, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.UserNameWithUserId] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetWritingOnBBCaseTypeName(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strWritingOnBBCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseTypeName, 50, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName);
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseTypeName = strWritingOnBBCaseTypeName; //板书案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN Setid_XzCollege(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convWritingOnBBCaseQuantitySenate.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convWritingOnBBCaseQuantitySenate.id_XzCollege);
objvWritingOnBBCaseQuantitySenateEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.id_XzCollege) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.id_XzCollege, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.id_XzCollege] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseQuantitySenateEN SetCollegeNameA(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convWritingOnBBCaseQuantitySenate.CollegeNameA);
objvWritingOnBBCaseQuantitySenateEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseQuantitySenate.CollegeNameA) == false)
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp.Add(convWritingOnBBCaseQuantitySenate.CollegeNameA, strComparisonOp);
}
else
{
objvWritingOnBBCaseQuantitySenateEN.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.CollegeNameA] = strComparisonOp;
}
}
return objvWritingOnBBCaseQuantitySenateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convWritingOnBBCaseQuantitySenate.id_microteachCaseQuantitySenate, objvWritingOnBBCaseQuantitySenate_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.FuncModuleId, objvWritingOnBBCaseQuantitySenate_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.FuncModuleName, objvWritingOnBBCaseQuantitySenate_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.id_MicroteachCase, objvWritingOnBBCaseQuantitySenate_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.id_AppraiseType, objvWritingOnBBCaseQuantitySenate_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.AppraiseTypeName, objvWritingOnBBCaseQuantitySenate_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.id_WritingOnBBCase) == true)
{
string strComparisonOp_id_WritingOnBBCase = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.id_WritingOnBBCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.id_WritingOnBBCase, objvWritingOnBBCaseQuantitySenate_Cond.id_WritingOnBBCase, strComparisonOp_id_WritingOnBBCase);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID) == true)
{
string strComparisonOp_WritingOnBBCaseID = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID, objvWritingOnBBCaseQuantitySenate_Cond.WritingOnBBCaseID, strComparisonOp_WritingOnBBCaseID);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName) == true)
{
string strComparisonOp_WritingOnBBCaseName = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName, objvWritingOnBBCaseQuantitySenate_Cond.WritingOnBBCaseName, strComparisonOp_WritingOnBBCaseName);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate) == true)
{
string strComparisonOp_WritingOnBBCaseDate = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate, objvWritingOnBBCaseQuantitySenate_Cond.WritingOnBBCaseDate, strComparisonOp_WritingOnBBCaseDate);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convWritingOnBBCaseQuantitySenate.BrowseCount, objvWritingOnBBCaseQuantitySenate_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.SenateTheme) == true)
{
string strComparisonOp_SenateTheme = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.SenateTheme, objvWritingOnBBCaseQuantitySenate_Cond.SenateTheme, strComparisonOp_SenateTheme);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.SenateContent) == true)
{
string strComparisonOp_SenateContent = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.SenateContent, objvWritingOnBBCaseQuantitySenate_Cond.SenateContent, strComparisonOp_SenateContent);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOp_SenateTotalScore = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convWritingOnBBCaseQuantitySenate.SenateTotalScore, objvWritingOnBBCaseQuantitySenate_Cond.SenateTotalScore, strComparisonOp_SenateTotalScore);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.SenateDate, objvWritingOnBBCaseQuantitySenate_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.SenateTime) == true)
{
string strComparisonOp_SenateTime = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.SenateTime, objvWritingOnBBCaseQuantitySenate_Cond.SenateTime, strComparisonOp_SenateTime);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.id_SenateGaugeVersion, objvWritingOnBBCaseQuantitySenate_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.senateGaugeVersionID, objvWritingOnBBCaseQuantitySenate_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.senateGaugeVersionName, objvWritingOnBBCaseQuantitySenate_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore, objvWritingOnBBCaseQuantitySenate_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.UpdUserName) == true)
{
string strComparisonOp_UpdUserName = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.UpdUserName, objvWritingOnBBCaseQuantitySenate_Cond.UpdUserName, strComparisonOp_UpdUserName);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.UpdUser, objvWritingOnBBCaseQuantitySenate_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.CollegeID, objvWritingOnBBCaseQuantitySenate_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.CollegeName, objvWritingOnBBCaseQuantitySenate_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.IsLeaved) == true)
{
if (objvWritingOnBBCaseQuantitySenate_Cond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWritingOnBBCaseQuantitySenate.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWritingOnBBCaseQuantitySenate.IsLeaved);
}
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.SenateIp) == true)
{
string strComparisonOp_SenateIp = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.SenateIp, objvWritingOnBBCaseQuantitySenate_Cond.SenateIp, strComparisonOp_SenateIp);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.StuIdTeacherId) == true)
{
string strComparisonOp_StuIdTeacherId = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.StuIdTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.StuIdTeacherId, objvWritingOnBBCaseQuantitySenate_Cond.StuIdTeacherId, strComparisonOp_StuIdTeacherId);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.UserId) == true)
{
string strComparisonOp_UserId = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.UserId, objvWritingOnBBCaseQuantitySenate_Cond.UserId, strComparisonOp_UserId);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.UserName) == true)
{
string strComparisonOp_UserName = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.UserName, objvWritingOnBBCaseQuantitySenate_Cond.UserName, strComparisonOp_UserName);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.OwnerId, objvWritingOnBBCaseQuantitySenate_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.StuID) == true)
{
string strComparisonOp_StuID = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.StuID, objvWritingOnBBCaseQuantitySenate_Cond.StuID, strComparisonOp_StuID);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.StuName) == true)
{
string strComparisonOp_StuName = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.StuName, objvWritingOnBBCaseQuantitySenate_Cond.StuName, strComparisonOp_StuName);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.OwnerName, objvWritingOnBBCaseQuantitySenate_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.UserNameWithUserId, objvWritingOnBBCaseQuantitySenate_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName) == true)
{
string strComparisonOp_WritingOnBBCaseTypeName = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName, objvWritingOnBBCaseQuantitySenate_Cond.WritingOnBBCaseTypeName, strComparisonOp_WritingOnBBCaseTypeName);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.id_XzCollege, objvWritingOnBBCaseQuantitySenate_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvWritingOnBBCaseQuantitySenate_Cond.IsUpdated(convWritingOnBBCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvWritingOnBBCaseQuantitySenate_Cond.dicFldComparisonOp[convWritingOnBBCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseQuantitySenate.CollegeNameA, objvWritingOnBBCaseQuantitySenate_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vWritingOnBBCaseQuantitySenate(vWritingOnBBCaseQuantitySenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvWritingOnBBCaseQuantitySenateWApi
{
private static readonly string mstrApiControllerName = "vWritingOnBBCaseQuantitySenateApi";

 public clsvWritingOnBBCaseQuantitySenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWritingOnBBCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN = null;
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
objvWritingOnBBCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvWritingOnBBCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvWritingOnBBCaseQuantitySenateEN;
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
public static clsvWritingOnBBCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_WA_Cache(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN = null;
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
objvWritingOnBBCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvWritingOnBBCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvWritingOnBBCaseQuantitySenateEN;
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
public static clsvWritingOnBBCaseQuantitySenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN = null;
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
objvWritingOnBBCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvWritingOnBBCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvWritingOnBBCaseQuantitySenateEN;
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
public static clsvWritingOnBBCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_Cache(long lngid_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvWritingOnBBCaseQuantitySenateEN._CurrTabName_S);
List<clsvWritingOnBBCaseQuantitySenateEN> arrvWritingOnBBCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvWritingOnBBCaseQuantitySenateEN> arrvWritingOnBBCaseQuantitySenateObjLst_Sel =
from objvWritingOnBBCaseQuantitySenateEN in arrvWritingOnBBCaseQuantitySenateObjLst_Cache
where objvWritingOnBBCaseQuantitySenateEN.id_microteachCaseQuantitySenate == lngid_microteachCaseQuantitySenate
select objvWritingOnBBCaseQuantitySenateEN;
if (arrvWritingOnBBCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvWritingOnBBCaseQuantitySenateEN obj = clsvWritingOnBBCaseQuantitySenateWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvWritingOnBBCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWritingOnBBCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
 List<clsvWritingOnBBCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvWritingOnBBCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvWritingOnBBCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvWritingOnBBCaseQuantitySenateEN._CurrTabName_S);
List<clsvWritingOnBBCaseQuantitySenateEN> arrvWritingOnBBCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvWritingOnBBCaseQuantitySenateEN> arrvWritingOnBBCaseQuantitySenateObjLst_Sel =
from objvWritingOnBBCaseQuantitySenateEN in arrvWritingOnBBCaseQuantitySenateObjLst_Cache
where arrId_microteachCaseQuantitySenate.Contains(objvWritingOnBBCaseQuantitySenateEN.id_microteachCaseQuantitySenate)
select objvWritingOnBBCaseQuantitySenateEN;
return arrvWritingOnBBCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWritingOnBBCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvWritingOnBBCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvWritingOnBBCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCaseQuantitySenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvWritingOnBBCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvWritingOnBBCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCaseQuantitySenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvWritingOnBBCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvWritingOnBBCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvWritingOnBBCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateENS, clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateENT)
{
try
{
objvWritingOnBBCaseQuantitySenateENT.id_microteachCaseQuantitySenate = objvWritingOnBBCaseQuantitySenateENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvWritingOnBBCaseQuantitySenateENT.FuncModuleId = objvWritingOnBBCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvWritingOnBBCaseQuantitySenateENT.FuncModuleName = objvWritingOnBBCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvWritingOnBBCaseQuantitySenateENT.id_MicroteachCase = objvWritingOnBBCaseQuantitySenateENS.id_MicroteachCase; //微格教学案例流水号
objvWritingOnBBCaseQuantitySenateENT.id_AppraiseType = objvWritingOnBBCaseQuantitySenateENS.id_AppraiseType; //评议类型流水号
objvWritingOnBBCaseQuantitySenateENT.AppraiseTypeName = objvWritingOnBBCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvWritingOnBBCaseQuantitySenateENT.id_WritingOnBBCase = objvWritingOnBBCaseQuantitySenateENS.id_WritingOnBBCase; //板书案例流水号
objvWritingOnBBCaseQuantitySenateENT.WritingOnBBCaseID = objvWritingOnBBCaseQuantitySenateENS.WritingOnBBCaseID; //板书教学案例ID
objvWritingOnBBCaseQuantitySenateENT.WritingOnBBCaseName = objvWritingOnBBCaseQuantitySenateENS.WritingOnBBCaseName; //板书教学案例名称
objvWritingOnBBCaseQuantitySenateENT.WritingOnBBCaseDate = objvWritingOnBBCaseQuantitySenateENS.WritingOnBBCaseDate; //板书教学日期
objvWritingOnBBCaseQuantitySenateENT.BrowseCount = objvWritingOnBBCaseQuantitySenateENS.BrowseCount; //浏览次数
objvWritingOnBBCaseQuantitySenateENT.SenateTheme = objvWritingOnBBCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvWritingOnBBCaseQuantitySenateENT.SenateContent = objvWritingOnBBCaseQuantitySenateENS.SenateContent; //评价内容
objvWritingOnBBCaseQuantitySenateENT.SenateTotalScore = objvWritingOnBBCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvWritingOnBBCaseQuantitySenateENT.SenateDate = objvWritingOnBBCaseQuantitySenateENS.SenateDate; //评价日期
objvWritingOnBBCaseQuantitySenateENT.SenateTime = objvWritingOnBBCaseQuantitySenateENS.SenateTime; //评价时间
objvWritingOnBBCaseQuantitySenateENT.id_SenateGaugeVersion = objvWritingOnBBCaseQuantitySenateENS.id_SenateGaugeVersion; //评价量表版本流水号
objvWritingOnBBCaseQuantitySenateENT.senateGaugeVersionID = objvWritingOnBBCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvWritingOnBBCaseQuantitySenateENT.senateGaugeVersionName = objvWritingOnBBCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvWritingOnBBCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvWritingOnBBCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvWritingOnBBCaseQuantitySenateENT.UpdUserName = objvWritingOnBBCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvWritingOnBBCaseQuantitySenateENT.UpdUser = objvWritingOnBBCaseQuantitySenateENS.UpdUser; //修改人
objvWritingOnBBCaseQuantitySenateENT.CollegeID = objvWritingOnBBCaseQuantitySenateENS.CollegeID; //学院ID
objvWritingOnBBCaseQuantitySenateENT.CollegeName = objvWritingOnBBCaseQuantitySenateENS.CollegeName; //学院名称
objvWritingOnBBCaseQuantitySenateENT.IsLeaved = objvWritingOnBBCaseQuantitySenateENS.IsLeaved; //IsLeaved
objvWritingOnBBCaseQuantitySenateENT.SenateIp = objvWritingOnBBCaseQuantitySenateENS.SenateIp; //评议Ip
objvWritingOnBBCaseQuantitySenateENT.StuIdTeacherId = objvWritingOnBBCaseQuantitySenateENS.StuIdTeacherId; //学工号
objvWritingOnBBCaseQuantitySenateENT.UserId = objvWritingOnBBCaseQuantitySenateENS.UserId; //用户ID
objvWritingOnBBCaseQuantitySenateENT.UserName = objvWritingOnBBCaseQuantitySenateENS.UserName; //用户名
objvWritingOnBBCaseQuantitySenateENT.OwnerId = objvWritingOnBBCaseQuantitySenateENS.OwnerId; //拥有者Id
objvWritingOnBBCaseQuantitySenateENT.StuID = objvWritingOnBBCaseQuantitySenateENS.StuID; //学号
objvWritingOnBBCaseQuantitySenateENT.StuName = objvWritingOnBBCaseQuantitySenateENS.StuName; //姓名
objvWritingOnBBCaseQuantitySenateENT.OwnerName = objvWritingOnBBCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvWritingOnBBCaseQuantitySenateENT.UserNameWithUserId = objvWritingOnBBCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvWritingOnBBCaseQuantitySenateENT.WritingOnBBCaseTypeName = objvWritingOnBBCaseQuantitySenateENS.WritingOnBBCaseTypeName; //板书案例类型名称
objvWritingOnBBCaseQuantitySenateENT.id_XzCollege = objvWritingOnBBCaseQuantitySenateENS.id_XzCollege; //学院流水号
objvWritingOnBBCaseQuantitySenateENT.CollegeNameA = objvWritingOnBBCaseQuantitySenateENS.CollegeNameA; //学院名称简写
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
public static DataTable ToDataTable(List<clsvWritingOnBBCaseQuantitySenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvWritingOnBBCaseQuantitySenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvWritingOnBBCaseQuantitySenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvWritingOnBBCaseQuantitySenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvWritingOnBBCaseQuantitySenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvWritingOnBBCaseQuantitySenateEN.AttributeName)
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
if (clsWritingOnBBCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsWritingOnBBCaseWApi没有刷新缓存机制(clsWritingOnBBCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWritingOnBBCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsWritingOnBBCaseTypeWApi没有刷新缓存机制(clsWritingOnBBCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvWritingOnBBCaseQuantitySenateObjLst_Cache == null)
//{
//arrvWritingOnBBCaseQuantitySenateObjLst_Cache = await clsvWritingOnBBCaseQuantitySenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvWritingOnBBCaseQuantitySenateEN._CurrTabName_S);
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
public static List<clsvWritingOnBBCaseQuantitySenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvWritingOnBBCaseQuantitySenateEN._CurrTabName_S);
List<clsvWritingOnBBCaseQuantitySenateEN> arrvWritingOnBBCaseQuantitySenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvWritingOnBBCaseQuantitySenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvWritingOnBBCaseQuantitySenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.id_WritingOnBBCase, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.SenateTheme, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.SenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.SenateTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.SenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.UpdUserName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.IsLeaved, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.SenateIp, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.StuIdTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseQuantitySenate.CollegeNameA, Type.GetType("System.String"));
foreach (clsvWritingOnBBCaseQuantitySenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convWritingOnBBCaseQuantitySenate.id_microteachCaseQuantitySenate] = objInFor[convWritingOnBBCaseQuantitySenate.id_microteachCaseQuantitySenate];
objDR[convWritingOnBBCaseQuantitySenate.FuncModuleId] = objInFor[convWritingOnBBCaseQuantitySenate.FuncModuleId];
objDR[convWritingOnBBCaseQuantitySenate.FuncModuleName] = objInFor[convWritingOnBBCaseQuantitySenate.FuncModuleName];
objDR[convWritingOnBBCaseQuantitySenate.id_MicroteachCase] = objInFor[convWritingOnBBCaseQuantitySenate.id_MicroteachCase];
objDR[convWritingOnBBCaseQuantitySenate.id_AppraiseType] = objInFor[convWritingOnBBCaseQuantitySenate.id_AppraiseType];
objDR[convWritingOnBBCaseQuantitySenate.AppraiseTypeName] = objInFor[convWritingOnBBCaseQuantitySenate.AppraiseTypeName];
objDR[convWritingOnBBCaseQuantitySenate.id_WritingOnBBCase] = objInFor[convWritingOnBBCaseQuantitySenate.id_WritingOnBBCase];
objDR[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID] = objInFor[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID];
objDR[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName] = objInFor[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName];
objDR[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate] = objInFor[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate];
objDR[convWritingOnBBCaseQuantitySenate.BrowseCount] = objInFor[convWritingOnBBCaseQuantitySenate.BrowseCount];
objDR[convWritingOnBBCaseQuantitySenate.SenateTheme] = objInFor[convWritingOnBBCaseQuantitySenate.SenateTheme];
objDR[convWritingOnBBCaseQuantitySenate.SenateContent] = objInFor[convWritingOnBBCaseQuantitySenate.SenateContent];
objDR[convWritingOnBBCaseQuantitySenate.SenateTotalScore] = objInFor[convWritingOnBBCaseQuantitySenate.SenateTotalScore];
objDR[convWritingOnBBCaseQuantitySenate.SenateDate] = objInFor[convWritingOnBBCaseQuantitySenate.SenateDate];
objDR[convWritingOnBBCaseQuantitySenate.SenateTime] = objInFor[convWritingOnBBCaseQuantitySenate.SenateTime];
objDR[convWritingOnBBCaseQuantitySenate.id_SenateGaugeVersion] = objInFor[convWritingOnBBCaseQuantitySenate.id_SenateGaugeVersion];
objDR[convWritingOnBBCaseQuantitySenate.senateGaugeVersionID] = objInFor[convWritingOnBBCaseQuantitySenate.senateGaugeVersionID];
objDR[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName] = objInFor[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName];
objDR[convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore] = objInFor[convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore];
objDR[convWritingOnBBCaseQuantitySenate.UpdUserName] = objInFor[convWritingOnBBCaseQuantitySenate.UpdUserName];
objDR[convWritingOnBBCaseQuantitySenate.UpdUser] = objInFor[convWritingOnBBCaseQuantitySenate.UpdUser];
objDR[convWritingOnBBCaseQuantitySenate.CollegeID] = objInFor[convWritingOnBBCaseQuantitySenate.CollegeID];
objDR[convWritingOnBBCaseQuantitySenate.CollegeName] = objInFor[convWritingOnBBCaseQuantitySenate.CollegeName];
objDR[convWritingOnBBCaseQuantitySenate.IsLeaved] = objInFor[convWritingOnBBCaseQuantitySenate.IsLeaved];
objDR[convWritingOnBBCaseQuantitySenate.SenateIp] = objInFor[convWritingOnBBCaseQuantitySenate.SenateIp];
objDR[convWritingOnBBCaseQuantitySenate.StuIdTeacherId] = objInFor[convWritingOnBBCaseQuantitySenate.StuIdTeacherId];
objDR[convWritingOnBBCaseQuantitySenate.UserId] = objInFor[convWritingOnBBCaseQuantitySenate.UserId];
objDR[convWritingOnBBCaseQuantitySenate.UserName] = objInFor[convWritingOnBBCaseQuantitySenate.UserName];
objDR[convWritingOnBBCaseQuantitySenate.OwnerId] = objInFor[convWritingOnBBCaseQuantitySenate.OwnerId];
objDR[convWritingOnBBCaseQuantitySenate.StuID] = objInFor[convWritingOnBBCaseQuantitySenate.StuID];
objDR[convWritingOnBBCaseQuantitySenate.StuName] = objInFor[convWritingOnBBCaseQuantitySenate.StuName];
objDR[convWritingOnBBCaseQuantitySenate.OwnerName] = objInFor[convWritingOnBBCaseQuantitySenate.OwnerName];
objDR[convWritingOnBBCaseQuantitySenate.UserNameWithUserId] = objInFor[convWritingOnBBCaseQuantitySenate.UserNameWithUserId];
objDR[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName] = objInFor[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName];
objDR[convWritingOnBBCaseQuantitySenate.id_XzCollege] = objInFor[convWritingOnBBCaseQuantitySenate.id_XzCollege];
objDR[convWritingOnBBCaseQuantitySenate.CollegeNameA] = objInFor[convWritingOnBBCaseQuantitySenate.CollegeNameA];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}