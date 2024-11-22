
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCaseQuantitySenateBL
 表名:vMicroteachCaseQuantitySenate(01120444)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
public static class  clsvMicroteachCaseQuantitySenateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCaseQuantitySenateEN GetObj(this K_IdmicroteachCaseQuantitySenate_vMicroteachCaseQuantitySenate myKey)
{
clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = clsvMicroteachCaseQuantitySenateBL.vMicroteachCaseQuantitySenateDA.GetObjByIdmicroteachCaseQuantitySenate(myKey.Value);
return objvMicroteachCaseQuantitySenateEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetIdmicroteachCaseQuantitySenate(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, long lngIdmicroteachCaseQuantitySenate, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = lngIdmicroteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetFuncModuleId(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMicroteachCaseQuantitySenate.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroteachCaseQuantitySenate.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroteachCaseQuantitySenate.FuncModuleId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetFuncModuleName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMicroteachCaseQuantitySenate.FuncModuleName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetIdMicroteachCase(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convMicroteachCaseQuantitySenate.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convMicroteachCaseQuantitySenate.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convMicroteachCaseQuantitySenate.IdMicroteachCase);
}
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.IdMicroteachCase) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.IdMicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.IdMicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetIdAppraiseType(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strIdAppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdAppraiseType, convMicroteachCaseQuantitySenate.IdAppraiseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAppraiseType, 4, convMicroteachCaseQuantitySenate.IdAppraiseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAppraiseType, 4, convMicroteachCaseQuantitySenate.IdAppraiseType);
}
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = strIdAppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.IdAppraiseType) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.IdAppraiseType, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.IdAppraiseType] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetAppraiseTypeName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convMicroteachCaseQuantitySenate.AppraiseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetSenateTheme(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convMicroteachCaseQuantitySenate.SenateTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetSenateContent(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convMicroteachCaseQuantitySenate.SenateContent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetSenateDate(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convMicroteachCaseQuantitySenate.SenateDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convMicroteachCaseQuantitySenate.SenateDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetSenateTime(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convMicroteachCaseQuantitySenate.SenateTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convMicroteachCaseQuantitySenate.SenateTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetBrowseCount(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, int? intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetIdSenateGaugeVersion(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convMicroteachCaseQuantitySenate.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convMicroteachCaseQuantitySenate.IdSenateGaugeVersion);
}
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.IdSenateGaugeVersion) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetMicroteachCaseDate(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachCaseQuantitySenate.MicroteachCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachCaseQuantitySenate.MicroteachCaseDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetMicroteachCaseID(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strMicroteachCaseID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCaseQuantitySenate.MicroteachCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCaseQuantitySenate.MicroteachCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetMicroteachCaseName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strMicroteachCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCaseQuantitySenate.MicroteachCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroteachCaseQuantitySenate.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroteachCaseQuantitySenate.senateGaugeVersionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroteachCaseQuantitySenate.senateGaugeVersionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetCollegeID(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMicroteachCaseQuantitySenate.CollegeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetCollegeName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCaseQuantitySenate.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUserId(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convMicroteachCaseQuantitySenate.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convMicroteachCaseQuantitySenate.UserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUserName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convMicroteachCaseQuantitySenate.UserName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetOwnerId(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCaseQuantitySenate.OwnerId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetOwnerName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroteachCaseQuantitySenate.OwnerName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetOwnerNameWithId(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convMicroteachCaseQuantitySenate.OwnerNameWithId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetSenateIp(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateIp, 50, convMicroteachCaseQuantitySenate.SenateIp);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUserNameWithUserId(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convMicroteachCaseQuantitySenate.UserNameWithUserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUserKindId(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convMicroteachCaseQuantitySenate.UserKindId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convMicroteachCaseQuantitySenate.UserKindId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convMicroteachCaseQuantitySenate.UserKindId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUserKindName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUserKindName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convMicroteachCaseQuantitySenate.UserKindName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUserTypeId(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroteachCaseQuantitySenate.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroteachCaseQuantitySenate.UserTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUserTypeName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUserTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convMicroteachCaseQuantitySenate.UserTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUpdUserName(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convMicroteachCaseQuantitySenate.UpdUserName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetUpdUser(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMicroteachCaseQuantitySenate.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetMemo(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCaseQuantitySenate.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetIdXzCollege(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convMicroteachCaseQuantitySenate.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convMicroteachCaseQuantitySenate.IdXzCollege);
}
objvMicroteachCaseQuantitySenateEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenate.IdXzCollege) == false)
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenate.IdXzCollege, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateEN.dicFldComparisonOp[convMicroteachCaseQuantitySenate.IdXzCollege] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateEN SetCollegeNameA(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroteachCaseQuantitySenate.CollegeNameA);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvMicroteachCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateENS, clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateENT)
{
try
{
objvMicroteachCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvMicroteachCaseQuantitySenateENT.FuncModuleId = objvMicroteachCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvMicroteachCaseQuantitySenateENT.FuncModuleName = objvMicroteachCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvMicroteachCaseQuantitySenateENT.IdMicroteachCase = objvMicroteachCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCaseQuantitySenateENT.IdAppraiseType = objvMicroteachCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvMicroteachCaseQuantitySenateENT.AppraiseTypeName = objvMicroteachCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvMicroteachCaseQuantitySenateENT.SenateTheme = objvMicroteachCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvMicroteachCaseQuantitySenateENT.SenateContent = objvMicroteachCaseQuantitySenateENS.SenateContent; //评价内容
objvMicroteachCaseQuantitySenateENT.SenateTotalScore = objvMicroteachCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvMicroteachCaseQuantitySenateENT.SenateDate = objvMicroteachCaseQuantitySenateENS.SenateDate; //评价日期
objvMicroteachCaseQuantitySenateENT.SenateTime = objvMicroteachCaseQuantitySenateENS.SenateTime; //评价时间
objvMicroteachCaseQuantitySenateENT.BrowseCount = objvMicroteachCaseQuantitySenateENS.BrowseCount; //浏览次数
objvMicroteachCaseQuantitySenateENT.IdSenateGaugeVersion = objvMicroteachCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
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
objvMicroteachCaseQuantitySenateENT.IdXzCollege = objvMicroteachCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvMicroteachCaseQuantitySenateENT.CollegeNameA = objvMicroteachCaseQuantitySenateENS.CollegeNameA; //学院名称简写
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
 /// <param name = "objvMicroteachCaseQuantitySenateENS">源对象</param>
 /// <returns>目标对象=>clsvMicroteachCaseQuantitySenateEN:objvMicroteachCaseQuantitySenateENT</returns>
 public static clsvMicroteachCaseQuantitySenateEN CopyTo(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateENS)
{
try
{
 clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateENT = new clsvMicroteachCaseQuantitySenateEN()
{
IdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate, //微格量化评价流水号
FuncModuleId = objvMicroteachCaseQuantitySenateENS.FuncModuleId, //功能模块Id
FuncModuleName = objvMicroteachCaseQuantitySenateENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvMicroteachCaseQuantitySenateENS.IdMicroteachCase, //微格教学案例流水号
IdAppraiseType = objvMicroteachCaseQuantitySenateENS.IdAppraiseType, //评议类型流水号
AppraiseTypeName = objvMicroteachCaseQuantitySenateENS.AppraiseTypeName, //评议类型名称
SenateTheme = objvMicroteachCaseQuantitySenateENS.SenateTheme, //量化评价主题
SenateContent = objvMicroteachCaseQuantitySenateENS.SenateContent, //评价内容
SenateTotalScore = objvMicroteachCaseQuantitySenateENS.SenateTotalScore, //评价分数
SenateDate = objvMicroteachCaseQuantitySenateENS.SenateDate, //评价日期
SenateTime = objvMicroteachCaseQuantitySenateENS.SenateTime, //评价时间
BrowseCount = objvMicroteachCaseQuantitySenateENS.BrowseCount, //浏览次数
IdSenateGaugeVersion = objvMicroteachCaseQuantitySenateENS.IdSenateGaugeVersion, //评价量表版本流水号
MicroteachCaseDate = objvMicroteachCaseQuantitySenateENS.MicroteachCaseDate, //微格教学日期
MicroteachCaseID = objvMicroteachCaseQuantitySenateENS.MicroteachCaseID, //微格教学案例ID
MicroteachCaseName = objvMicroteachCaseQuantitySenateENS.MicroteachCaseName, //微格教学案例名称
senateGaugeVersionID = objvMicroteachCaseQuantitySenateENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvMicroteachCaseQuantitySenateENS.senateGaugeVersionName, //评价量表版本名称
CollegeID = objvMicroteachCaseQuantitySenateENS.CollegeID, //学院ID
CollegeName = objvMicroteachCaseQuantitySenateENS.CollegeName, //学院名称
UserId = objvMicroteachCaseQuantitySenateENS.UserId, //用户ID
UserName = objvMicroteachCaseQuantitySenateENS.UserName, //用户名
OwnerId = objvMicroteachCaseQuantitySenateENS.OwnerId, //拥有者Id
OwnerName = objvMicroteachCaseQuantitySenateENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvMicroteachCaseQuantitySenateENS.OwnerNameWithId, //拥有者名称附Id
SenateIp = objvMicroteachCaseQuantitySenateENS.SenateIp, //评议Ip
UserNameWithUserId = objvMicroteachCaseQuantitySenateENS.UserNameWithUserId, //UserNameWithUserId
UserKindId = objvMicroteachCaseQuantitySenateENS.UserKindId, //用户类别Id
UserKindName = objvMicroteachCaseQuantitySenateENS.UserKindName, //用户类别名
UserTypeId = objvMicroteachCaseQuantitySenateENS.UserTypeId, //用户类型Id
UserTypeName = objvMicroteachCaseQuantitySenateENS.UserTypeName, //用户类型名称
UpdUserName = objvMicroteachCaseQuantitySenateENS.UpdUserName, //UpdUserName
UpdUser = objvMicroteachCaseQuantitySenateENS.UpdUser, //修改人
Memo = objvMicroteachCaseQuantitySenateENS.Memo, //备注
IdXzCollege = objvMicroteachCaseQuantitySenateENS.IdXzCollege, //学院流水号
CollegeNameA = objvMicroteachCaseQuantitySenateENS.CollegeNameA, //学院名称简写
};
 return objvMicroteachCaseQuantitySenateENT;
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
public static void CheckProperty4Condition(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN)
{
 clsvMicroteachCaseQuantitySenateBL.vMicroteachCaseQuantitySenateDA.CheckProperty4Condition(objvMicroteachCaseQuantitySenateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate) == true)
{
string strComparisonOpIdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate, objvMicroteachCaseQuantitySenateCond.IdmicroteachCaseQuantitySenate, strComparisonOpIdmicroteachCaseQuantitySenate);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.FuncModuleId, objvMicroteachCaseQuantitySenateCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.FuncModuleName, objvMicroteachCaseQuantitySenateCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.IdMicroteachCase, objvMicroteachCaseQuantitySenateCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.IdAppraiseType) == true)
{
string strComparisonOpIdAppraiseType = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.IdAppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.IdAppraiseType, objvMicroteachCaseQuantitySenateCond.IdAppraiseType, strComparisonOpIdAppraiseType);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOpAppraiseTypeName = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.AppraiseTypeName, objvMicroteachCaseQuantitySenateCond.AppraiseTypeName, strComparisonOpAppraiseTypeName);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.SenateTheme) == true)
{
string strComparisonOpSenateTheme = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.SenateTheme, objvMicroteachCaseQuantitySenateCond.SenateTheme, strComparisonOpSenateTheme);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.SenateContent) == true)
{
string strComparisonOpSenateContent = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.SenateContent, objvMicroteachCaseQuantitySenateCond.SenateContent, strComparisonOpSenateContent);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOpSenateTotalScore = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenate.SenateTotalScore, objvMicroteachCaseQuantitySenateCond.SenateTotalScore, strComparisonOpSenateTotalScore);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.SenateDate) == true)
{
string strComparisonOpSenateDate = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.SenateDate, objvMicroteachCaseQuantitySenateCond.SenateDate, strComparisonOpSenateDate);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.SenateTime) == true)
{
string strComparisonOpSenateTime = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.SenateTime, objvMicroteachCaseQuantitySenateCond.SenateTime, strComparisonOpSenateTime);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenate.BrowseCount, objvMicroteachCaseQuantitySenateCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.IdSenateGaugeVersion, objvMicroteachCaseQuantitySenateCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.MicroteachCaseDate) == true)
{
string strComparisonOpMicroteachCaseDate = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.MicroteachCaseDate, objvMicroteachCaseQuantitySenateCond.MicroteachCaseDate, strComparisonOpMicroteachCaseDate);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.MicroteachCaseID) == true)
{
string strComparisonOpMicroteachCaseID = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.MicroteachCaseID, objvMicroteachCaseQuantitySenateCond.MicroteachCaseID, strComparisonOpMicroteachCaseID);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.MicroteachCaseName) == true)
{
string strComparisonOpMicroteachCaseName = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.MicroteachCaseName, objvMicroteachCaseQuantitySenateCond.MicroteachCaseName, strComparisonOpMicroteachCaseName);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.senateGaugeVersionID, objvMicroteachCaseQuantitySenateCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.senateGaugeVersionName, objvMicroteachCaseQuantitySenateCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOpCollegeID = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.CollegeID, objvMicroteachCaseQuantitySenateCond.CollegeID, strComparisonOpCollegeID);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOpCollegeName = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.CollegeName, objvMicroteachCaseQuantitySenateCond.CollegeName, strComparisonOpCollegeName);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.UserId) == true)
{
string strComparisonOpUserId = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UserId, objvMicroteachCaseQuantitySenateCond.UserId, strComparisonOpUserId);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.UserName) == true)
{
string strComparisonOpUserName = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UserName, objvMicroteachCaseQuantitySenateCond.UserName, strComparisonOpUserName);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.OwnerId) == true)
{
string strComparisonOpOwnerId = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.OwnerId, objvMicroteachCaseQuantitySenateCond.OwnerId, strComparisonOpOwnerId);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.OwnerName) == true)
{
string strComparisonOpOwnerName = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.OwnerName, objvMicroteachCaseQuantitySenateCond.OwnerName, strComparisonOpOwnerName);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.OwnerNameWithId, objvMicroteachCaseQuantitySenateCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.SenateIp) == true)
{
string strComparisonOpSenateIp = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.SenateIp, objvMicroteachCaseQuantitySenateCond.SenateIp, strComparisonOpSenateIp);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOpUserNameWithUserId = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UserNameWithUserId, objvMicroteachCaseQuantitySenateCond.UserNameWithUserId, strComparisonOpUserNameWithUserId);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.UserKindId) == true)
{
string strComparisonOpUserKindId = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UserKindId, objvMicroteachCaseQuantitySenateCond.UserKindId, strComparisonOpUserKindId);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.UserKindName) == true)
{
string strComparisonOpUserKindName = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UserKindName, objvMicroteachCaseQuantitySenateCond.UserKindName, strComparisonOpUserKindName);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UserTypeId, objvMicroteachCaseQuantitySenateCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.UserTypeName) == true)
{
string strComparisonOpUserTypeName = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UserTypeName, objvMicroteachCaseQuantitySenateCond.UserTypeName, strComparisonOpUserTypeName);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.UpdUserName) == true)
{
string strComparisonOpUpdUserName = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UpdUserName, objvMicroteachCaseQuantitySenateCond.UpdUserName, strComparisonOpUpdUserName);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.UpdUser) == true)
{
string strComparisonOpUpdUser = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.UpdUser, objvMicroteachCaseQuantitySenateCond.UpdUser, strComparisonOpUpdUser);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.Memo) == true)
{
string strComparisonOpMemo = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.Memo, objvMicroteachCaseQuantitySenateCond.Memo, strComparisonOpMemo);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.IdXzCollege, objvMicroteachCaseQuantitySenateCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(convMicroteachCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[convMicroteachCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenate.CollegeNameA, objvMicroteachCaseQuantitySenateCond.CollegeNameA, strComparisonOpCollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMicroteachCaseQuantitySenate
{
public virtual bool UpdRelaTabDate(long lngIdmicroteachCaseQuantitySenate, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v微格教学教师量化评价视图(vMicroteachCaseQuantitySenate)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCaseQuantitySenateBL
{
public static RelatedActions_vMicroteachCaseQuantitySenate relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMicroteachCaseQuantitySenateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMicroteachCaseQuantitySenateDA vMicroteachCaseQuantitySenateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMicroteachCaseQuantitySenateDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMicroteachCaseQuantitySenateBL()
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
if (string.IsNullOrEmpty(clsvMicroteachCaseQuantitySenateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCaseQuantitySenateEN._ConnectString);
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
public static DataTable GetDataTable_vMicroteachCaseQuantitySenate(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMicroteachCaseQuantitySenateDA.GetDataTable_vMicroteachCaseQuantitySenate(strWhereCond);
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
objDT = vMicroteachCaseQuantitySenateDA.GetDataTable(strWhereCond);
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
objDT = vMicroteachCaseQuantitySenateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMicroteachCaseQuantitySenateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMicroteachCaseQuantitySenateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMicroteachCaseQuantitySenateDA.GetDataTable_Top(objTopPara);
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
objDT = vMicroteachCaseQuantitySenateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMicroteachCaseQuantitySenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMicroteachCaseQuantitySenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdmicroteachCaseQuantitySenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLstByIdmicroteachCaseQuantitySenateLst(List<long> arrIdmicroteachCaseQuantitySenateLst)
{
List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdmicroteachCaseQuantitySenateLst);
 string strWhereCond = string.Format("IdmicroteachCaseQuantitySenate in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN();
try
{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateEN.SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateEN.SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateEN.SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateEN.SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateEN.BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateEN.CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateEN.CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateEN.UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateEN.UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateEN.OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateEN.OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateEN.SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateEN.UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateEN.UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateEN.UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateEN.UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateEN.UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMicroteachCaseQuantitySenateEN.UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateEN.Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdmicroteachCaseQuantitySenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMicroteachCaseQuantitySenateEN> GetObjLstByIdmicroteachCaseQuantitySenateLstCache(List<long> arrIdmicroteachCaseQuantitySenateLst)
{
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateEN._CurrTabName);
List<clsvMicroteachCaseQuantitySenateEN> arrvMicroteachCaseQuantitySenateObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseQuantitySenateEN> arrvMicroteachCaseQuantitySenateObjLst_Sel =
arrvMicroteachCaseQuantitySenateObjLstCache
.Where(x => arrIdmicroteachCaseQuantitySenateLst.Contains(x.IdmicroteachCaseQuantitySenate));
return arrvMicroteachCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN();
try
{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateEN.SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateEN.SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateEN.SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateEN.SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateEN.BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateEN.CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateEN.CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateEN.UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateEN.UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateEN.OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateEN.OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateEN.SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateEN.UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateEN.UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateEN.UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateEN.UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateEN.UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMicroteachCaseQuantitySenateEN.UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateEN.Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateEN);
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
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN();
try
{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateEN.SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateEN.SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateEN.SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateEN.SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateEN.BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateEN.CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateEN.CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateEN.UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateEN.UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateEN.OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateEN.OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateEN.SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateEN.UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateEN.UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateEN.UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateEN.UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateEN.UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMicroteachCaseQuantitySenateEN.UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateEN.Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMicroteachCaseQuantitySenateEN> GetSubObjLstCache(clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateCond)
{
List<clsvMicroteachCaseQuantitySenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseQuantitySenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCaseQuantitySenate.AttributeName)
{
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseQuantitySenateCond[strFldName].ToString());
}
else
{
if (objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseQuantitySenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCaseQuantitySenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseQuantitySenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseQuantitySenateCond[strFldName]));
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
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN();
try
{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateEN.SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateEN.SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateEN.SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateEN.SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateEN.BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateEN.CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateEN.CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateEN.UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateEN.UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateEN.OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateEN.OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateEN.SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateEN.UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateEN.UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateEN.UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateEN.UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateEN.UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMicroteachCaseQuantitySenateEN.UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateEN.Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateEN);
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
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN();
try
{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateEN.SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateEN.SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateEN.SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateEN.SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateEN.BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateEN.CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateEN.CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateEN.UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateEN.UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateEN.OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateEN.OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateEN.SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateEN.UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateEN.UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateEN.UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateEN.UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateEN.UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMicroteachCaseQuantitySenateEN.UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateEN.Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateEN);
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
List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMicroteachCaseQuantitySenateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateEN>(); 
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
	clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN();
try
{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateEN.SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateEN.SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateEN.SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateEN.SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateEN.BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateEN.CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateEN.CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateEN.UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateEN.UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateEN.OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateEN.OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateEN.SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateEN.UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateEN.UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateEN.UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateEN.UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateEN.UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMicroteachCaseQuantitySenateEN.UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateEN.Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateEN);
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
public static List<clsvMicroteachCaseQuantitySenateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN();
try
{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateEN.SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateEN.SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateEN.SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateEN.SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateEN.BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateEN.CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateEN.CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateEN.UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateEN.UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateEN.OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateEN.OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateEN.SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateEN.UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateEN.UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateEN.UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateEN.UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateEN.UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMicroteachCaseQuantitySenateEN.UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateEN.Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN();
try
{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateEN.SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateEN.SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateEN.SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateEN.SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateEN.BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateEN.CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateEN.CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateEN.UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateEN.UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateEN.OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateEN.OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateEN.SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateEN.UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateEN.UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateEN.UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateEN.UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateEN.UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMicroteachCaseQuantitySenateEN.UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateEN.Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateEN);
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
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN();
try
{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateEN.SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateEN.SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateEN.SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateEN.SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateEN.BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateEN.CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateEN.CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateEN.UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateEN.UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateEN.OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateEN.OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateEN.SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateEN.UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateEN.UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateEN.UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateEN.UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateEN.UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMicroteachCaseQuantitySenateEN.UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateEN.Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN();
try
{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateEN.SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateEN.SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateEN.SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateEN.SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateEN.BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateEN.CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateEN.CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateEN.UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateEN.UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateEN.OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateEN.OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateEN.SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateEN.UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateEN.UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateEN.UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateEN.UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateEN.UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMicroteachCaseQuantitySenateEN.UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateEN.Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMicroteachCaseQuantitySenate(ref clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN)
{
bool bolResult = vMicroteachCaseQuantitySenateDA.GetvMicroteachCaseQuantitySenate(ref objvMicroteachCaseQuantitySenateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = vMicroteachCaseQuantitySenateDA.GetObjByIdmicroteachCaseQuantitySenate(lngIdmicroteachCaseQuantitySenate);
return objvMicroteachCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMicroteachCaseQuantitySenateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = vMicroteachCaseQuantitySenateDA.GetFirstObj(strWhereCond);
 return objvMicroteachCaseQuantitySenateEN;
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
public static clsvMicroteachCaseQuantitySenateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = vMicroteachCaseQuantitySenateDA.GetObjByDataRow(objRow);
 return objvMicroteachCaseQuantitySenateEN;
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
public static clsvMicroteachCaseQuantitySenateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = vMicroteachCaseQuantitySenateDA.GetObjByDataRow(objRow);
 return objvMicroteachCaseQuantitySenateEN;
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
 /// <param name = "lngIdmicroteachCaseQuantitySenate">所给的关键字</param>
 /// <param name = "lstvMicroteachCaseQuantitySenateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenateFromList(long lngIdmicroteachCaseQuantitySenate, List<clsvMicroteachCaseQuantitySenateEN> lstvMicroteachCaseQuantitySenateObjLst)
{
foreach (clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN in lstvMicroteachCaseQuantitySenateObjLst)
{
if (objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate == lngIdmicroteachCaseQuantitySenate)
{
return objvMicroteachCaseQuantitySenateEN;
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
 long lngIdmicroteachCaseQuantitySenate;
 try
 {
 lngIdmicroteachCaseQuantitySenate = new clsvMicroteachCaseQuantitySenateDA().GetFirstID(strWhereCond);
 return lngIdmicroteachCaseQuantitySenate;
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
 arrList = vMicroteachCaseQuantitySenateDA.GetID(strWhereCond);
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
bool bolIsExist = vMicroteachCaseQuantitySenateDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdmicroteachCaseQuantitySenate)
{
//检测记录是否存在
bool bolIsExist = vMicroteachCaseQuantitySenateDA.IsExist(lngIdmicroteachCaseQuantitySenate);
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
 bolIsExist = clsvMicroteachCaseQuantitySenateDA.IsExistTable();
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
 bolIsExist = vMicroteachCaseQuantitySenateDA.IsExistTable(strTabName);
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
 /// <param name = "objvMicroteachCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvMicroteachCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateENS, clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateENT)
{
try
{
objvMicroteachCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvMicroteachCaseQuantitySenateENT.FuncModuleId = objvMicroteachCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvMicroteachCaseQuantitySenateENT.FuncModuleName = objvMicroteachCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvMicroteachCaseQuantitySenateENT.IdMicroteachCase = objvMicroteachCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCaseQuantitySenateENT.IdAppraiseType = objvMicroteachCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvMicroteachCaseQuantitySenateENT.AppraiseTypeName = objvMicroteachCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvMicroteachCaseQuantitySenateENT.SenateTheme = objvMicroteachCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvMicroteachCaseQuantitySenateENT.SenateContent = objvMicroteachCaseQuantitySenateENS.SenateContent; //评价内容
objvMicroteachCaseQuantitySenateENT.SenateTotalScore = objvMicroteachCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvMicroteachCaseQuantitySenateENT.SenateDate = objvMicroteachCaseQuantitySenateENS.SenateDate; //评价日期
objvMicroteachCaseQuantitySenateENT.SenateTime = objvMicroteachCaseQuantitySenateENS.SenateTime; //评价时间
objvMicroteachCaseQuantitySenateENT.BrowseCount = objvMicroteachCaseQuantitySenateENS.BrowseCount; //浏览次数
objvMicroteachCaseQuantitySenateENT.IdSenateGaugeVersion = objvMicroteachCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
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
objvMicroteachCaseQuantitySenateENT.IdXzCollege = objvMicroteachCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvMicroteachCaseQuantitySenateENT.CollegeNameA = objvMicroteachCaseQuantitySenateENS.CollegeNameA; //学院名称简写
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
 /// <param name = "objvMicroteachCaseQuantitySenateEN">源简化对象</param>
 public static void SetUpdFlag(clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN)
{
try
{
objvMicroteachCaseQuantitySenateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMicroteachCaseQuantitySenateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.FuncModuleId = objvMicroteachCaseQuantitySenateEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.FuncModuleName = objvMicroteachCaseQuantitySenateEN.FuncModuleName == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objvMicroteachCaseQuantitySenateEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.IdAppraiseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objvMicroteachCaseQuantitySenateEN.IdAppraiseType; //评议类型流水号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.AppraiseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objvMicroteachCaseQuantitySenateEN.AppraiseTypeName == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.AppraiseTypeName; //评议类型名称
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.SenateTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.SenateTheme = objvMicroteachCaseQuantitySenateEN.SenateTheme == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.SenateTheme; //量化评价主题
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.SenateContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.SenateContent = objvMicroteachCaseQuantitySenateEN.SenateContent == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.SenateContent; //评价内容
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.SenateTotalScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = objvMicroteachCaseQuantitySenateEN.SenateTotalScore; //评价分数
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.SenateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.SenateDate = objvMicroteachCaseQuantitySenateEN.SenateDate == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.SenateDate; //评价日期
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.SenateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.SenateTime = objvMicroteachCaseQuantitySenateEN.SenateTime == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.SenateTime; //评价时间
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.BrowseCount = objvMicroteachCaseQuantitySenateEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.MicroteachCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate; //微格教学日期
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.MicroteachCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objvMicroteachCaseQuantitySenateEN.MicroteachCaseID == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.MicroteachCaseID; //微格教学案例ID
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.MicroteachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objvMicroteachCaseQuantitySenateEN.MicroteachCaseName == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.MicroteachCaseName; //微格教学案例名称
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.CollegeID = objvMicroteachCaseQuantitySenateEN.CollegeID == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.CollegeName = objvMicroteachCaseQuantitySenateEN.CollegeName == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.UserId = objvMicroteachCaseQuantitySenateEN.UserId; //用户ID
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.UserName = objvMicroteachCaseQuantitySenateEN.UserName == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.UserName; //用户名
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.OwnerId = objvMicroteachCaseQuantitySenateEN.OwnerId == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.OwnerName = objvMicroteachCaseQuantitySenateEN.OwnerName == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objvMicroteachCaseQuantitySenateEN.OwnerNameWithId == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.SenateIp, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.SenateIp = objvMicroteachCaseQuantitySenateEN.SenateIp == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.SenateIp; //评议Ip
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.UserNameWithUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objvMicroteachCaseQuantitySenateEN.UserNameWithUserId == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.UserNameWithUserId; //UserNameWithUserId
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.UserKindId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.UserKindId = objvMicroteachCaseQuantitySenateEN.UserKindId; //用户类别Id
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.UserKindName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.UserKindName = objvMicroteachCaseQuantitySenateEN.UserKindName == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.UserKindName; //用户类别名
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.UserTypeId = objvMicroteachCaseQuantitySenateEN.UserTypeId == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.UserTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.UserTypeName = objvMicroteachCaseQuantitySenateEN.UserTypeName == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.UserTypeName; //用户类型名称
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.UpdUserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.UpdUserName = objvMicroteachCaseQuantitySenateEN.UpdUserName == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.UpdUserName; //UpdUserName
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.UpdUser = objvMicroteachCaseQuantitySenateEN.UpdUser == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.Memo = objvMicroteachCaseQuantitySenateEN.Memo == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.Memo; //备注
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.IdXzCollege = objvMicroteachCaseQuantitySenateEN.IdXzCollege == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenate.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateEN.CollegeNameA = objvMicroteachCaseQuantitySenateEN.CollegeNameA == "[null]" ? null :  objvMicroteachCaseQuantitySenateEN.CollegeNameA; //学院名称简写
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
 /// <param name = "objvMicroteachCaseQuantitySenateEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN)
{
try
{
if (objvMicroteachCaseQuantitySenateEN.FuncModuleName == "[null]") objvMicroteachCaseQuantitySenateEN.FuncModuleName = null; //功能模块名称
if (objvMicroteachCaseQuantitySenateEN.AppraiseTypeName == "[null]") objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = null; //评议类型名称
if (objvMicroteachCaseQuantitySenateEN.SenateTheme == "[null]") objvMicroteachCaseQuantitySenateEN.SenateTheme = null; //量化评价主题
if (objvMicroteachCaseQuantitySenateEN.SenateContent == "[null]") objvMicroteachCaseQuantitySenateEN.SenateContent = null; //评价内容
if (objvMicroteachCaseQuantitySenateEN.SenateDate == "[null]") objvMicroteachCaseQuantitySenateEN.SenateDate = null; //评价日期
if (objvMicroteachCaseQuantitySenateEN.SenateTime == "[null]") objvMicroteachCaseQuantitySenateEN.SenateTime = null; //评价时间
if (objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion == "[null]") objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate == "[null]") objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = null; //微格教学日期
if (objvMicroteachCaseQuantitySenateEN.MicroteachCaseID == "[null]") objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = null; //微格教学案例ID
if (objvMicroteachCaseQuantitySenateEN.MicroteachCaseName == "[null]") objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = null; //微格教学案例名称
if (objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID == "[null]") objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName == "[null]") objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvMicroteachCaseQuantitySenateEN.CollegeID == "[null]") objvMicroteachCaseQuantitySenateEN.CollegeID = null; //学院ID
if (objvMicroteachCaseQuantitySenateEN.CollegeName == "[null]") objvMicroteachCaseQuantitySenateEN.CollegeName = null; //学院名称
if (objvMicroteachCaseQuantitySenateEN.UserName == "[null]") objvMicroteachCaseQuantitySenateEN.UserName = null; //用户名
if (objvMicroteachCaseQuantitySenateEN.OwnerId == "[null]") objvMicroteachCaseQuantitySenateEN.OwnerId = null; //拥有者Id
if (objvMicroteachCaseQuantitySenateEN.OwnerName == "[null]") objvMicroteachCaseQuantitySenateEN.OwnerName = null; //拥有者姓名
if (objvMicroteachCaseQuantitySenateEN.OwnerNameWithId == "[null]") objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvMicroteachCaseQuantitySenateEN.SenateIp == "[null]") objvMicroteachCaseQuantitySenateEN.SenateIp = null; //评议Ip
if (objvMicroteachCaseQuantitySenateEN.UserNameWithUserId == "[null]") objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = null; //UserNameWithUserId
if (objvMicroteachCaseQuantitySenateEN.UserKindName == "[null]") objvMicroteachCaseQuantitySenateEN.UserKindName = null; //用户类别名
if (objvMicroteachCaseQuantitySenateEN.UserTypeId == "[null]") objvMicroteachCaseQuantitySenateEN.UserTypeId = null; //用户类型Id
if (objvMicroteachCaseQuantitySenateEN.UserTypeName == "[null]") objvMicroteachCaseQuantitySenateEN.UserTypeName = null; //用户类型名称
if (objvMicroteachCaseQuantitySenateEN.UpdUserName == "[null]") objvMicroteachCaseQuantitySenateEN.UpdUserName = null; //UpdUserName
if (objvMicroteachCaseQuantitySenateEN.UpdUser == "[null]") objvMicroteachCaseQuantitySenateEN.UpdUser = null; //修改人
if (objvMicroteachCaseQuantitySenateEN.Memo == "[null]") objvMicroteachCaseQuantitySenateEN.Memo = null; //备注
if (objvMicroteachCaseQuantitySenateEN.IdXzCollege == "[null]") objvMicroteachCaseQuantitySenateEN.IdXzCollege = null; //学院流水号
if (objvMicroteachCaseQuantitySenateEN.CollegeNameA == "[null]") objvMicroteachCaseQuantitySenateEN.CollegeNameA = null; //学院名称简写
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
public static void CheckProperty4Condition(clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN)
{
 vMicroteachCaseQuantitySenateDA.CheckProperty4Condition(objvMicroteachCaseQuantitySenateEN);
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
if (clsTeacherInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoBL没有刷新缓存机制(clsTeacherInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionBL没有刷新缓存机制(clsSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeBL没有刷新缓存机制(clsAppraiseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseQuantitySenateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateBL没有刷新缓存机制(clsMicroteachCaseQuantitySenateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCaseLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelBL没有刷新缓存机制(clsCaseLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeBL没有刷新缓存机制(clsUserTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseBL没有刷新缓存机制(clsMicroteachCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseTypeBL没有刷新缓存机制(clsMicroteachCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindBL没有刷新缓存机制(clsUserKindBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeBL没有刷新缓存机制(clsSkillTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillBL没有刷新缓存机制(clsTeachSkillBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdmicroteachCaseQuantitySenate");
//if (arrvMicroteachCaseQuantitySenateObjLstCache == null)
//{
//arrvMicroteachCaseQuantitySenateObjLstCache = vMicroteachCaseQuantitySenateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenateCache(long lngIdmicroteachCaseQuantitySenate)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateEN._CurrTabName);
List<clsvMicroteachCaseQuantitySenateEN> arrvMicroteachCaseQuantitySenateObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseQuantitySenateEN> arrvMicroteachCaseQuantitySenateObjLst_Sel =
arrvMicroteachCaseQuantitySenateObjLstCache
.Where(x=> x.IdmicroteachCaseQuantitySenate == lngIdmicroteachCaseQuantitySenate 
);
if (arrvMicroteachCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvMicroteachCaseQuantitySenateEN obj = clsvMicroteachCaseQuantitySenateBL.GetObjByIdmicroteachCaseQuantitySenate(lngIdmicroteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMicroteachCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateEN> GetAllvMicroteachCaseQuantitySenateObjLstCache()
{
//获取缓存中的对象列表
List<clsvMicroteachCaseQuantitySenateEN> arrvMicroteachCaseQuantitySenateObjLstCache = GetObjLstCache(); 
return arrvMicroteachCaseQuantitySenateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateEN._CurrTabName);
List<clsvMicroteachCaseQuantitySenateEN> arrvMicroteachCaseQuantitySenateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCaseQuantitySenateObjLstCache;
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
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdmicroteachCaseQuantitySenate)
{
if (strInFldName != convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMicroteachCaseQuantitySenate.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMicroteachCaseQuantitySenate.AttributeName));
throw new Exception(strMsg);
}
var objvMicroteachCaseQuantitySenate = clsvMicroteachCaseQuantitySenateBL.GetObjByIdmicroteachCaseQuantitySenateCache(lngIdmicroteachCaseQuantitySenate);
if (objvMicroteachCaseQuantitySenate == null) return "";
return objvMicroteachCaseQuantitySenate[strOutFldName].ToString();
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
int intRecCount = clsvMicroteachCaseQuantitySenateDA.GetRecCount(strTabName);
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
int intRecCount = clsvMicroteachCaseQuantitySenateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMicroteachCaseQuantitySenateDA.GetRecCount();
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
int intRecCount = clsvMicroteachCaseQuantitySenateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateCond)
{
List<clsvMicroteachCaseQuantitySenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseQuantitySenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCaseQuantitySenate.AttributeName)
{
if (objvMicroteachCaseQuantitySenateCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseQuantitySenateCond[strFldName].ToString());
}
else
{
if (objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCaseQuantitySenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseQuantitySenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCaseQuantitySenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseQuantitySenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseQuantitySenateCond[strFldName]));
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
 List<string> arrList = clsvMicroteachCaseQuantitySenateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCaseQuantitySenateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCaseQuantitySenateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}