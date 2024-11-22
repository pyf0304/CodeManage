
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCaseQuantitySenateWApi
 表名:vMicroteachCaseQuantitySenate(01120444)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:04
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议
 模块英文名:MicroTeachSenate
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
public static class clsvMicroteachCaseQuantitySenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN Setid_microteachCaseQuantitySenate(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetFuncModuleId(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMicroteachCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroteachCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroteachCaseQuantitySenate.FuncModuleId);
objvMicroteachCaseQuantitySenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.FuncModuleId) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.FuncModuleId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.FuncModuleId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetFuncModuleName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMicroteachCaseQuantitySenate.FuncModuleName);
objvMicroteachCaseQuantitySenateEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.FuncModuleName) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.FuncModuleName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.FuncModuleName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN Setid_MicroteachCase(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convMicroteachCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMicroteachCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMicroteachCaseQuantitySenate.id_MicroteachCase);
objvMicroteachCaseQuantitySenateEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.id_MicroteachCase) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.id_MicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.id_MicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN Setid_AppraiseType(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convMicroteachCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convMicroteachCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convMicroteachCaseQuantitySenate.id_AppraiseType);
objvMicroteachCaseQuantitySenateEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.id_AppraiseType) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.id_AppraiseType, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.id_AppraiseType] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetAppraiseTypeName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convMicroteachCaseQuantitySenate.AppraiseTypeName);
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.AppraiseTypeName) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.AppraiseTypeName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.AppraiseTypeName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetSenateTheme(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convMicroteachCaseQuantitySenate.SenateTheme);
objvMicroteachCaseQuantitySenateEN.SenateTheme = strSenateTheme; //量化评价主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.SenateTheme) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.SenateTheme, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateTheme] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetSenateContent(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convMicroteachCaseQuantitySenate.SenateContent);
objvMicroteachCaseQuantitySenateEN.SenateContent = strSenateContent; //评价内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.SenateContent) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.SenateContent, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateContent] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetSenateTotalScore(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, float fltSenateTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltSenateTotalScore, convMicroteachCaseQuantitySenate.SenateTotalScore);
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = fltSenateTotalScore; //评价分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.SenateTotalScore) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.SenateTotalScore, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateTotalScore] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetSenateDate(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convMicroteachCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convMicroteachCaseQuantitySenate.SenateDate);
objvMicroteachCaseQuantitySenateEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.SenateDate) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.SenateDate, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateDate] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetSenateTime(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convMicroteachCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convMicroteachCaseQuantitySenate.SenateTime);
objvMicroteachCaseQuantitySenateEN.SenateTime = strSenateTime; //评价时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.SenateTime) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.SenateTime, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateTime] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetBrowseCount(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, int intBrowseCount, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.BrowseCount) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.BrowseCount, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.BrowseCount] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN Setid_SenateGaugeVersion(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convMicroteachCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convMicroteachCaseQuantitySenate.id_SenateGaugeVersion);
objvMicroteachCaseQuantitySenateEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.id_SenateGaugeVersion) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetMicroteachCaseDate(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachCaseQuantitySenate.MicroteachCaseDate);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachCaseQuantitySenate.MicroteachCaseDate);
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = strMicroteachCaseDate; //微格教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.MicroteachCaseDate) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.MicroteachCaseDate, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.MicroteachCaseDate] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetMicroteachCaseID(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCaseQuantitySenate.MicroteachCaseID);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCaseQuantitySenate.MicroteachCaseID);
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = strMicroteachCaseID; //微格教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.MicroteachCaseID) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.MicroteachCaseID, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.MicroteachCaseID] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetMicroteachCaseName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCaseQuantitySenate.MicroteachCaseName);
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = strMicroteachCaseName; //微格教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.MicroteachCaseName) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.MicroteachCaseName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.MicroteachCaseName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroteachCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroteachCaseQuantitySenate.senateGaugeVersionID);
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.senateGaugeVersionID) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.senateGaugeVersionID, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.senateGaugeVersionID] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroteachCaseQuantitySenate.senateGaugeVersionName);
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.senateGaugeVersionName) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.senateGaugeVersionName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.senateGaugeVersionName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetCollegeID(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMicroteachCaseQuantitySenate.CollegeID);
objvMicroteachCaseQuantitySenateEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.CollegeID) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.CollegeID, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.CollegeID] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetCollegeName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCaseQuantitySenate.CollegeName);
objvMicroteachCaseQuantitySenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.CollegeName) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.CollegeName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.CollegeName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUserId(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convMicroteachCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convMicroteachCaseQuantitySenate.UserId);
objvMicroteachCaseQuantitySenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.UserId) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.UserId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUserName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convMicroteachCaseQuantitySenate.UserName);
objvMicroteachCaseQuantitySenateEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.UserName) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.UserName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetOwnerId(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCaseQuantitySenate.OwnerId);
objvMicroteachCaseQuantitySenateEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.OwnerId) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.OwnerId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.OwnerId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetOwnerName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroteachCaseQuantitySenate.OwnerName);
objvMicroteachCaseQuantitySenateEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.OwnerName) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.OwnerName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.OwnerName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetOwnerNameWithId(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convMicroteachCaseQuantitySenate.OwnerNameWithId);
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.OwnerNameWithId) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.OwnerNameWithId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.OwnerNameWithId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetSenateIp(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateIp, 50, convMicroteachCaseQuantitySenate.SenateIp);
objvMicroteachCaseQuantitySenateEN.SenateIp = strSenateIp; //评议Ip
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.SenateIp) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.SenateIp, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateIp] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUserNameWithUserId(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convMicroteachCaseQuantitySenate.UserNameWithUserId);
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.UserNameWithUserId) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.UserNameWithUserId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserNameWithUserId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUserKindId(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convMicroteachCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convMicroteachCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convMicroteachCaseQuantitySenate.UserKindId);
objvMicroteachCaseQuantitySenateEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.UserKindId) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.UserKindId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserKindId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUserKindName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convMicroteachCaseQuantitySenate.UserKindName);
objvMicroteachCaseQuantitySenateEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.UserKindName) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.UserKindName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserKindName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUserTypeId(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroteachCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroteachCaseQuantitySenate.UserTypeId);
objvMicroteachCaseQuantitySenateEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.UserTypeId) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.UserTypeId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserTypeId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUserTypeName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convMicroteachCaseQuantitySenate.UserTypeName);
objvMicroteachCaseQuantitySenateEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.UserTypeName) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.UserTypeName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserTypeName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUpdUserName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convMicroteachCaseQuantitySenate.UpdUserName);
objvMicroteachCaseQuantitySenateEN.UpdUserName = strUpdUserName; //UpdUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.UpdUserName) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.UpdUserName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UpdUserName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUpdUser(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMicroteachCaseQuantitySenate.UpdUser);
objvMicroteachCaseQuantitySenateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.UpdUser) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.UpdUser, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UpdUser] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetMemo(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCaseQuantitySenate.Memo);
objvMicroteachCaseQuantitySenateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.Memo) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.Memo, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.Memo] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN Setid_XzCollege(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convMicroteachCaseQuantitySenate.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convMicroteachCaseQuantitySenate.id_XzCollege);
objvMicroteachCaseQuantitySenateEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.id_XzCollege) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.id_XzCollege, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.id_XzCollege] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetCollegeNameA(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroteachCaseQuantitySenate.CollegeNameA);
objvMicroteachCaseQuantitySenateEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.CollegeNameA) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.CollegeNameA, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.CollegeNameA] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate, objvMicroteachCaseQuantitySenate_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.FuncModuleId, objvMicroteachCaseQuantitySenate_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.FuncModuleName, objvMicroteachCaseQuantitySenate_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.id_MicroteachCase, objvMicroteachCaseQuantitySenate_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.id_AppraiseType, objvMicroteachCaseQuantitySenate_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.AppraiseTypeName, objvMicroteachCaseQuantitySenate_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.SenateTheme) == true)
{
string strComparisonOp_SenateTheme = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.SenateTheme, objvMicroteachCaseQuantitySenate_Cond.SenateTheme, strComparisonOp_SenateTheme);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.SenateContent) == true)
{
string strComparisonOp_SenateContent = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.SenateContent, objvMicroteachCaseQuantitySenate_Cond.SenateContent, strComparisonOp_SenateContent);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOp_SenateTotalScore = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenate.SenateTotalScore, objvMicroteachCaseQuantitySenate_Cond.SenateTotalScore, strComparisonOp_SenateTotalScore);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.SenateDate, objvMicroteachCaseQuantitySenate_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.SenateTime) == true)
{
string strComparisonOp_SenateTime = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.SenateTime, objvMicroteachCaseQuantitySenate_Cond.SenateTime, strComparisonOp_SenateTime);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenate.BrowseCount, objvMicroteachCaseQuantitySenate_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.id_SenateGaugeVersion, objvMicroteachCaseQuantitySenate_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.MicroteachCaseDate) == true)
{
string strComparisonOp_MicroteachCaseDate = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.MicroteachCaseDate, objvMicroteachCaseQuantitySenate_Cond.MicroteachCaseDate, strComparisonOp_MicroteachCaseDate);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.MicroteachCaseID) == true)
{
string strComparisonOp_MicroteachCaseID = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.MicroteachCaseID, objvMicroteachCaseQuantitySenate_Cond.MicroteachCaseID, strComparisonOp_MicroteachCaseID);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.MicroteachCaseName) == true)
{
string strComparisonOp_MicroteachCaseName = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.MicroteachCaseName, objvMicroteachCaseQuantitySenate_Cond.MicroteachCaseName, strComparisonOp_MicroteachCaseName);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.senateGaugeVersionID, objvMicroteachCaseQuantitySenate_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.senateGaugeVersionName, objvMicroteachCaseQuantitySenate_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.CollegeID, objvMicroteachCaseQuantitySenate_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.CollegeName, objvMicroteachCaseQuantitySenate_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.UserId) == true)
{
string strComparisonOp_UserId = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UserId, objvMicroteachCaseQuantitySenate_Cond.UserId, strComparisonOp_UserId);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.UserName) == true)
{
string strComparisonOp_UserName = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UserName, objvMicroteachCaseQuantitySenate_Cond.UserName, strComparisonOp_UserName);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.OwnerId, objvMicroteachCaseQuantitySenate_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.OwnerName, objvMicroteachCaseQuantitySenate_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.OwnerNameWithId, objvMicroteachCaseQuantitySenate_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.SenateIp) == true)
{
string strComparisonOp_SenateIp = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.SenateIp, objvMicroteachCaseQuantitySenate_Cond.SenateIp, strComparisonOp_SenateIp);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UserNameWithUserId, objvMicroteachCaseQuantitySenate_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UserKindId, objvMicroteachCaseQuantitySenate_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UserKindName, objvMicroteachCaseQuantitySenate_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UserTypeId, objvMicroteachCaseQuantitySenate_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UserTypeName, objvMicroteachCaseQuantitySenate_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.UpdUserName) == true)
{
string strComparisonOp_UpdUserName = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UpdUserName, objvMicroteachCaseQuantitySenate_Cond.UpdUserName, strComparisonOp_UpdUserName);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UpdUser, objvMicroteachCaseQuantitySenate_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.Memo) == true)
{
string strComparisonOp_Memo = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.Memo, objvMicroteachCaseQuantitySenate_Cond.Memo, strComparisonOp_Memo);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.id_XzCollege, objvMicroteachCaseQuantitySenate_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvMicroteachCaseQuantitySenate_Cond.IsUpdated(convMicroteachCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.CollegeNameA, objvMicroteachCaseQuantitySenate_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v微格教学教师量化评价视图(vMicroteachCaseQuantitySenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCaseQuantitySenateWApi
{
private static readonly string mstrApiControllerName = "vMicroteachCaseQuantitySenateApi";

 public clsvMicroteachCaseQuantitySenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = null;
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
objvMicroteachCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvMicroteachCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCaseQuantitySenateEN;
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
public static clsvMicroteachCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_WA_Cache(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = null;
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
objvMicroteachCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvMicroteachCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCaseQuantitySenateEN;
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
public static clsvMicroteachCaseQuantitySenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = null;
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
objvMicroteachCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvMicroteachCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCaseQuantitySenateEN;
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
public static clsvMicroteachCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_Cache(long lngid_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateEN._CurrTabName_S);
List<clsvMicroteachCaseQuantitySenateEN> arrvMicroteachCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCaseQuantitySenateEN> arrvMicroteachCaseQuantitySenateObjLst_Sel =
from objvMicroteachCaseQuantitySenateEN in arrvMicroteachCaseQuantitySenateObjLst_Cache
where objvMicroteachCaseQuantitySenateEN.id_microteachCaseQuantitySenate == lngid_microteachCaseQuantitySenate
select objvMicroteachCaseQuantitySenateEN;
if (arrvMicroteachCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvMicroteachCaseQuantitySenateEN obj = clsvMicroteachCaseQuantitySenateWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMicroteachCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
 List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvMicroteachCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateEN._CurrTabName_S);
List<clsvMicroteachCaseQuantitySenateEN> arrvMicroteachCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCaseQuantitySenateEN> arrvMicroteachCaseQuantitySenateObjLst_Sel =
from objvMicroteachCaseQuantitySenateEN in arrvMicroteachCaseQuantitySenateObjLst_Cache
where arrId_microteachCaseQuantitySenate.Contains(objvMicroteachCaseQuantitySenateEN.id_microteachCaseQuantitySenate)
select objvMicroteachCaseQuantitySenateEN;
return arrvMicroteachCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvMicroteachCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvMicroteachCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateENS, clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateENT)
{
try
{
objvMicroteachCaseQuantitySenateENT.id_microteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvMicroteachCaseQuantitySenateENT.FuncModuleId = objvMicroteachCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvMicroteachCaseQuantitySenateENT.FuncModuleName = objvMicroteachCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvMicroteachCaseQuantitySenateENT.id_MicroteachCase = objvMicroteachCaseQuantitySenateENS.id_MicroteachCase; //微格教学案例流水号
objvMicroteachCaseQuantitySenateENT.id_AppraiseType = objvMicroteachCaseQuantitySenateENS.id_AppraiseType; //评议类型流水号
objvMicroteachCaseQuantitySenateENT.AppraiseTypeName = objvMicroteachCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvMicroteachCaseQuantitySenateENT.SenateTheme = objvMicroteachCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvMicroteachCaseQuantitySenateENT.SenateContent = objvMicroteachCaseQuantitySenateENS.SenateContent; //评价内容
objvMicroteachCaseQuantitySenateENT.SenateTotalScore = objvMicroteachCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvMicroteachCaseQuantitySenateENT.SenateDate = objvMicroteachCaseQuantitySenateENS.SenateDate; //评价日期
objvMicroteachCaseQuantitySenateENT.SenateTime = objvMicroteachCaseQuantitySenateENS.SenateTime; //评价时间
objvMicroteachCaseQuantitySenateENT.BrowseCount = objvMicroteachCaseQuantitySenateENS.BrowseCount; //浏览次数
objvMicroteachCaseQuantitySenateENT.id_SenateGaugeVersion = objvMicroteachCaseQuantitySenateENS.id_SenateGaugeVersion; //评价量表版本流水号
objvMicroteachCaseQuantitySenateENT.MicroteachCaseDate = objvMicroteachCaseQuantitySenateENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCaseQuantitySenateENT.MicroteachCaseID = objvMicroteachCaseQuantitySenateENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCaseQuantitySenateENT.MicroteachCaseName = objvMicroteachCaseQuantitySenateENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCaseQuantitySenateENT.senateGaugeVersionID = objvMicroteachCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCaseQuantitySenateENT.senateGaugeVersionName = objvMicroteachCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCaseQuantitySenateENT.CollegeID = objvMicroteachCaseQuantitySenateENS.CollegeID; //学院ID
objvMicroteachCaseQuantitySenateENT.CollegeName = objvMicroteachCaseQuantitySenateENS.CollegeName; //学院名称
objvMicroteachCaseQuantitySenateENT.UserId = objvMicroteachCaseQuantitySenateENS.UserId; //用户ID
objvMicroteachCaseQuantitySenateENT.UserName = objvMicroteachCaseQuantitySenateENS.UserName; //用户名
objvMicroteachCaseQuantitySenateENT.OwnerId = objvMicroteachCaseQuantitySenateENS.OwnerId; //拥有者Id
objvMicroteachCaseQuantitySenateENT.OwnerName = objvMicroteachCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvMicroteachCaseQuantitySenateENT.OwnerNameWithId = objvMicroteachCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvMicroteachCaseQuantitySenateENT.SenateIp = objvMicroteachCaseQuantitySenateENS.SenateIp; //评议Ip
objvMicroteachCaseQuantitySenateENT.UserNameWithUserId = objvMicroteachCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvMicroteachCaseQuantitySenateENT.UserKindId = objvMicroteachCaseQuantitySenateENS.UserKindId; //用户类别Id
objvMicroteachCaseQuantitySenateENT.UserKindName = objvMicroteachCaseQuantitySenateENS.UserKindName; //用户类别名
objvMicroteachCaseQuantitySenateENT.UserTypeId = objvMicroteachCaseQuantitySenateENS.UserTypeId; //用户类型Id
objvMicroteachCaseQuantitySenateENT.UserTypeName = objvMicroteachCaseQuantitySenateENS.UserTypeName; //用户类型名称
objvMicroteachCaseQuantitySenateENT.UpdUserName = objvMicroteachCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvMicroteachCaseQuantitySenateENT.UpdUser = objvMicroteachCaseQuantitySenateENS.UpdUser; //修改人
objvMicroteachCaseQuantitySenateENT.Memo = objvMicroteachCaseQuantitySenateENS.Memo; //备注
objvMicroteachCaseQuantitySenateENT.id_XzCollege = objvMicroteachCaseQuantitySenateENS.id_XzCollege; //学院流水号
objvMicroteachCaseQuantitySenateENT.CollegeNameA = objvMicroteachCaseQuantitySenateENS.CollegeNameA; //学院名称简写
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
public static DataTable ToDataTable(List<clsvMicroteachCaseQuantitySenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMicroteachCaseQuantitySenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMicroteachCaseQuantitySenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMicroteachCaseQuantitySenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMicroteachCaseQuantitySenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMicroteachCaseQuantitySenateEN.AttributeName)
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
if (clsCaseLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelWApi没有刷新缓存机制(clsCaseLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsMicroteachCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseWApi没有刷新缓存机制(clsMicroteachCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseTypeWApi没有刷新缓存机制(clsMicroteachCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeWApi没有刷新缓存机制(clsSkillTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillWApi没有刷新缓存机制(clsTeachSkillWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenate");
//if (arrvMicroteachCaseQuantitySenateObjLst_Cache == null)
//{
//arrvMicroteachCaseQuantitySenateObjLst_Cache = await clsvMicroteachCaseQuantitySenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateEN._CurrTabName_S);
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
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateEN._CurrTabName_S);
List<clsvMicroteachCaseQuantitySenateEN> arrvMicroteachCaseQuantitySenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCaseQuantitySenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMicroteachCaseQuantitySenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.SenateTheme, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.SenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.SenateTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.SenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.MicroteachCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.MicroteachCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.MicroteachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.SenateIp, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.UpdUserName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenate.CollegeNameA, Type.GetType("System.String"));
foreach (clsvMicroteachCaseQuantitySenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate] = objInFor[convMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate];
objDR[convMicroteachCaseQuantitySenate.FuncModuleId] = objInFor[convMicroteachCaseQuantitySenate.FuncModuleId];
objDR[convMicroteachCaseQuantitySenate.FuncModuleName] = objInFor[convMicroteachCaseQuantitySenate.FuncModuleName];
objDR[convMicroteachCaseQuantitySenate.id_MicroteachCase] = objInFor[convMicroteachCaseQuantitySenate.id_MicroteachCase];
objDR[convMicroteachCaseQuantitySenate.id_AppraiseType] = objInFor[convMicroteachCaseQuantitySenate.id_AppraiseType];
objDR[convMicroteachCaseQuantitySenate.AppraiseTypeName] = objInFor[convMicroteachCaseQuantitySenate.AppraiseTypeName];
objDR[convMicroteachCaseQuantitySenate.SenateTheme] = objInFor[convMicroteachCaseQuantitySenate.SenateTheme];
objDR[convMicroteachCaseQuantitySenate.SenateContent] = objInFor[convMicroteachCaseQuantitySenate.SenateContent];
objDR[convMicroteachCaseQuantitySenate.SenateTotalScore] = objInFor[convMicroteachCaseQuantitySenate.SenateTotalScore];
objDR[convMicroteachCaseQuantitySenate.SenateDate] = objInFor[convMicroteachCaseQuantitySenate.SenateDate];
objDR[convMicroteachCaseQuantitySenate.SenateTime] = objInFor[convMicroteachCaseQuantitySenate.SenateTime];
objDR[convMicroteachCaseQuantitySenate.BrowseCount] = objInFor[convMicroteachCaseQuantitySenate.BrowseCount];
objDR[convMicroteachCaseQuantitySenate.id_SenateGaugeVersion] = objInFor[convMicroteachCaseQuantitySenate.id_SenateGaugeVersion];
objDR[convMicroteachCaseQuantitySenate.MicroteachCaseDate] = objInFor[convMicroteachCaseQuantitySenate.MicroteachCaseDate];
objDR[convMicroteachCaseQuantitySenate.MicroteachCaseID] = objInFor[convMicroteachCaseQuantitySenate.MicroteachCaseID];
objDR[convMicroteachCaseQuantitySenate.MicroteachCaseName] = objInFor[convMicroteachCaseQuantitySenate.MicroteachCaseName];
objDR[convMicroteachCaseQuantitySenate.senateGaugeVersionID] = objInFor[convMicroteachCaseQuantitySenate.senateGaugeVersionID];
objDR[convMicroteachCaseQuantitySenate.senateGaugeVersionName] = objInFor[convMicroteachCaseQuantitySenate.senateGaugeVersionName];
objDR[convMicroteachCaseQuantitySenate.CollegeID] = objInFor[convMicroteachCaseQuantitySenate.CollegeID];
objDR[convMicroteachCaseQuantitySenate.CollegeName] = objInFor[convMicroteachCaseQuantitySenate.CollegeName];
objDR[convMicroteachCaseQuantitySenate.UserId] = objInFor[convMicroteachCaseQuantitySenate.UserId];
objDR[convMicroteachCaseQuantitySenate.UserName] = objInFor[convMicroteachCaseQuantitySenate.UserName];
objDR[convMicroteachCaseQuantitySenate.OwnerId] = objInFor[convMicroteachCaseQuantitySenate.OwnerId];
objDR[convMicroteachCaseQuantitySenate.OwnerName] = objInFor[convMicroteachCaseQuantitySenate.OwnerName];
objDR[convMicroteachCaseQuantitySenate.OwnerNameWithId] = objInFor[convMicroteachCaseQuantitySenate.OwnerNameWithId];
objDR[convMicroteachCaseQuantitySenate.SenateIp] = objInFor[convMicroteachCaseQuantitySenate.SenateIp];
objDR[convMicroteachCaseQuantitySenate.UserNameWithUserId] = objInFor[convMicroteachCaseQuantitySenate.UserNameWithUserId];
objDR[convMicroteachCaseQuantitySenate.UserKindId] = objInFor[convMicroteachCaseQuantitySenate.UserKindId];
objDR[convMicroteachCaseQuantitySenate.UserKindName] = objInFor[convMicroteachCaseQuantitySenate.UserKindName];
objDR[convMicroteachCaseQuantitySenate.UserTypeId] = objInFor[convMicroteachCaseQuantitySenate.UserTypeId];
objDR[convMicroteachCaseQuantitySenate.UserTypeName] = objInFor[convMicroteachCaseQuantitySenate.UserTypeName];
objDR[convMicroteachCaseQuantitySenate.UpdUserName] = objInFor[convMicroteachCaseQuantitySenate.UpdUserName];
objDR[convMicroteachCaseQuantitySenate.UpdUser] = objInFor[convMicroteachCaseQuantitySenate.UpdUser];
objDR[convMicroteachCaseQuantitySenate.Memo] = objInFor[convMicroteachCaseQuantitySenate.Memo];
objDR[convMicroteachCaseQuantitySenate.id_XzCollege] = objInFor[convMicroteachCaseQuantitySenate.id_XzCollege];
objDR[convMicroteachCaseQuantitySenate.CollegeNameA] = objInFor[convMicroteachCaseQuantitySenate.CollegeNameA];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}