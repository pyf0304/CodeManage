
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachAppraiseBL
 表名:vMicroteachAppraise(01120265)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:16
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
public static class  clsvMicroteachAppraiseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachAppraiseEN GetObj(this K_IdMicroteachAppraise_vMicroteachAppraise myKey)
{
clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = clsvMicroteachAppraiseBL.vMicroteachAppraiseDA.GetObjByIdMicroteachAppraise(myKey.Value);
return objvMicroteachAppraiseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetIdMicroteachAppraise(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, long lngIdMicroteachAppraise, string strComparisonOp="")
	{
objvMicroteachAppraiseEN.IdMicroteachAppraise = lngIdMicroteachAppraise; //评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.IdMicroteachAppraise) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.IdMicroteachAppraise, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.IdMicroteachAppraise] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetFuncModuleId(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMicroteachAppraise.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroteachAppraise.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroteachAppraise.FuncModuleId);
}
objvMicroteachAppraiseEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.FuncModuleId) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.FuncModuleId, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.FuncModuleId] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetFuncModuleName(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMicroteachAppraise.FuncModuleName);
}
objvMicroteachAppraiseEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.FuncModuleName) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.FuncModuleName, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.FuncModuleName] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetIdMicroteachCase(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convMicroteachAppraise.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convMicroteachAppraise.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convMicroteachAppraise.IdMicroteachCase);
}
objvMicroteachAppraiseEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.IdMicroteachCase) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.IdMicroteachCase, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.IdMicroteachCase] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetMicroteachCaseID(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseID, convMicroteachAppraise.MicroteachCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachAppraise.MicroteachCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachAppraise.MicroteachCaseID);
}
objvMicroteachAppraiseEN.MicroteachCaseID = strMicroteachCaseID; //微格教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.MicroteachCaseID) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.MicroteachCaseID, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.MicroteachCaseID] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetMicroteachCaseName(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, convMicroteachAppraise.MicroteachCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachAppraise.MicroteachCaseName);
}
objvMicroteachAppraiseEN.MicroteachCaseName = strMicroteachCaseName; //微格教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.MicroteachCaseName) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.MicroteachCaseName, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.MicroteachCaseName] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetIdAppraiseType(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strIdAppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdAppraiseType, convMicroteachAppraise.IdAppraiseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAppraiseType, 4, convMicroteachAppraise.IdAppraiseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAppraiseType, 4, convMicroteachAppraise.IdAppraiseType);
}
objvMicroteachAppraiseEN.IdAppraiseType = strIdAppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.IdAppraiseType) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.IdAppraiseType, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.IdAppraiseType] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetAppraiseTypeName(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseTypeName, convMicroteachAppraise.AppraiseTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convMicroteachAppraise.AppraiseTypeName);
}
objvMicroteachAppraiseEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.AppraiseTypeName) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.AppraiseTypeName, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.AppraiseTypeName] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetOwnerId(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachAppraise.OwnerId);
}
objvMicroteachAppraiseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.OwnerId) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.OwnerId, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.OwnerId] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetOwnerName(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroteachAppraise.OwnerName);
}
objvMicroteachAppraiseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.OwnerName) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.OwnerName, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.OwnerName] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetUserId(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convMicroteachAppraise.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convMicroteachAppraise.UserId);
}
objvMicroteachAppraiseEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.UserId) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.UserId, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.UserId] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetUserName(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convMicroteachAppraise.UserName);
}
objvMicroteachAppraiseEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.UserName) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.UserName, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.UserName] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetAppraiseTheme(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strAppraiseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTheme, 200, convMicroteachAppraise.AppraiseTheme);
}
objvMicroteachAppraiseEN.AppraiseTheme = strAppraiseTheme; //评议主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.AppraiseTheme) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.AppraiseTheme, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.AppraiseTheme] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetAppraiseContent(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strAppraiseContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, convMicroteachAppraise.AppraiseContent);
}
objvMicroteachAppraiseEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.AppraiseContent) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.AppraiseContent, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.AppraiseContent] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetAppraiseDate(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strAppraiseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseDate, 8, convMicroteachAppraise.AppraiseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAppraiseDate, 8, convMicroteachAppraise.AppraiseDate);
}
objvMicroteachAppraiseEN.AppraiseDate = strAppraiseDate; //评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.AppraiseDate) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.AppraiseDate, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.AppraiseDate] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetAppraiseTime(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strAppraiseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTime, 6, convMicroteachAppraise.AppraiseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAppraiseTime, 6, convMicroteachAppraise.AppraiseTime);
}
objvMicroteachAppraiseEN.AppraiseTime = strAppraiseTime; //评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.AppraiseTime) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.AppraiseTime, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.AppraiseTime] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetExcellentOne(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strExcellentOne, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentOne, 1000, convMicroteachAppraise.ExcellentOne);
}
objvMicroteachAppraiseEN.ExcellentOne = strExcellentOne; //优点1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.ExcellentOne) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.ExcellentOne, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.ExcellentOne] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetExcellentTwo(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strExcellentTwo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentTwo, 1000, convMicroteachAppraise.ExcellentTwo);
}
objvMicroteachAppraiseEN.ExcellentTwo = strExcellentTwo; //优点2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.ExcellentTwo) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.ExcellentTwo, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.ExcellentTwo] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetSuggestOne(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strSuggestOne, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSuggestOne, 1000, convMicroteachAppraise.SuggestOne);
}
objvMicroteachAppraiseEN.SuggestOne = strSuggestOne; //建议1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.SuggestOne) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.SuggestOne, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.SuggestOne] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetSuggestTwo(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strSuggestTwo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSuggestTwo, 1000, convMicroteachAppraise.SuggestTwo);
}
objvMicroteachAppraiseEN.SuggestTwo = strSuggestTwo; //建议2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.SuggestTwo) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.SuggestTwo, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.SuggestTwo] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetMicroteachAppriseScore(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, float? fltMicroteachAppriseScore, string strComparisonOp="")
	{
objvMicroteachAppraiseEN.MicroteachAppriseScore = fltMicroteachAppriseScore; //打分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.MicroteachAppriseScore) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.MicroteachAppriseScore, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.MicroteachAppriseScore] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetBrowseCount(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, int? intBrowseCount, string strComparisonOp="")
	{
objvMicroteachAppraiseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.BrowseCount) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.BrowseCount, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.BrowseCount] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetCollegeID(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMicroteachAppraise.CollegeID);
}
objvMicroteachAppraiseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.CollegeID) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.CollegeID, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.CollegeID] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetCollegeName(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachAppraise.CollegeName);
}
objvMicroteachAppraiseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.CollegeName) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.CollegeName, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.CollegeName] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetVideoStopTime(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strVideoStopTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoStopTime, 48, convMicroteachAppraise.VideoStopTime);
}
objvMicroteachAppraiseEN.VideoStopTime = strVideoStopTime; //公开课案例视频暂停时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.VideoStopTime) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.VideoStopTime, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.VideoStopTime] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetIsElite(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, bool bolIsElite, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsElite, convMicroteachAppraise.IsElite);
objvMicroteachAppraiseEN.IsElite = bolIsElite; //精华标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.IsElite) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.IsElite, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.IsElite] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetIsVisual(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, bool bolIsVisual, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsVisual, convMicroteachAppraise.IsVisual);
objvMicroteachAppraiseEN.IsVisual = bolIsVisual; //隐藏标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.IsVisual) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.IsVisual, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.IsVisual] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetMicroteachCaseDate(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachAppraise.MicroteachCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachAppraise.MicroteachCaseDate);
}
objvMicroteachAppraiseEN.MicroteachCaseDate = strMicroteachCaseDate; //微格教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.MicroteachCaseDate) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.MicroteachCaseDate, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.MicroteachCaseDate] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetOwnerNameWithId(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convMicroteachAppraise.OwnerNameWithId);
}
objvMicroteachAppraiseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.OwnerNameWithId) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.OwnerNameWithId, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.OwnerNameWithId] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetUserNameWithUserId(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strUserNameWithUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convMicroteachAppraise.UserNameWithUserId);
}
objvMicroteachAppraiseEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.UserNameWithUserId) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.UserNameWithUserId, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.UserNameWithUserId] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetBrowseCount4Case(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvMicroteachAppraiseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.BrowseCount4Case) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.BrowseCount4Case, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.BrowseCount4Case] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetIdXzCollege(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convMicroteachAppraise.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convMicroteachAppraise.IdXzCollege);
}
objvMicroteachAppraiseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.IdXzCollege) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.IdXzCollege, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.IdXzCollege] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetCollegeNameA(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroteachAppraise.CollegeNameA);
}
objvMicroteachAppraiseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.CollegeNameA) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.CollegeNameA, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.CollegeNameA] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseENS">源对象</param>
 /// <param name = "objvMicroteachAppraiseENT">目标对象</param>
 public static void CopyTo(this clsvMicroteachAppraiseEN objvMicroteachAppraiseENS, clsvMicroteachAppraiseEN objvMicroteachAppraiseENT)
{
try
{
objvMicroteachAppraiseENT.IdMicroteachAppraise = objvMicroteachAppraiseENS.IdMicroteachAppraise; //评议流水号
objvMicroteachAppraiseENT.FuncModuleId = objvMicroteachAppraiseENS.FuncModuleId; //功能模块Id
objvMicroteachAppraiseENT.FuncModuleName = objvMicroteachAppraiseENS.FuncModuleName; //功能模块名称
objvMicroteachAppraiseENT.IdMicroteachCase = objvMicroteachAppraiseENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachAppraiseENT.MicroteachCaseID = objvMicroteachAppraiseENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachAppraiseENT.MicroteachCaseName = objvMicroteachAppraiseENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachAppraiseENT.IdAppraiseType = objvMicroteachAppraiseENS.IdAppraiseType; //评议类型流水号
objvMicroteachAppraiseENT.AppraiseTypeName = objvMicroteachAppraiseENS.AppraiseTypeName; //评议类型名称
objvMicroteachAppraiseENT.OwnerId = objvMicroteachAppraiseENS.OwnerId; //拥有者Id
objvMicroteachAppraiseENT.OwnerName = objvMicroteachAppraiseENS.OwnerName; //拥有者姓名
objvMicroteachAppraiseENT.UserId = objvMicroteachAppraiseENS.UserId; //用户ID
objvMicroteachAppraiseENT.UserName = objvMicroteachAppraiseENS.UserName; //用户名
objvMicroteachAppraiseENT.AppraiseTheme = objvMicroteachAppraiseENS.AppraiseTheme; //评议主题
objvMicroteachAppraiseENT.AppraiseContent = objvMicroteachAppraiseENS.AppraiseContent; //评议内容
objvMicroteachAppraiseENT.AppraiseDate = objvMicroteachAppraiseENS.AppraiseDate; //评议日期
objvMicroteachAppraiseENT.AppraiseTime = objvMicroteachAppraiseENS.AppraiseTime; //评议时间
objvMicroteachAppraiseENT.ExcellentOne = objvMicroteachAppraiseENS.ExcellentOne; //优点1
objvMicroteachAppraiseENT.ExcellentTwo = objvMicroteachAppraiseENS.ExcellentTwo; //优点2
objvMicroteachAppraiseENT.SuggestOne = objvMicroteachAppraiseENS.SuggestOne; //建议1
objvMicroteachAppraiseENT.SuggestTwo = objvMicroteachAppraiseENS.SuggestTwo; //建议2
objvMicroteachAppraiseENT.MicroteachAppriseScore = objvMicroteachAppraiseENS.MicroteachAppriseScore; //打分
objvMicroteachAppraiseENT.BrowseCount = objvMicroteachAppraiseENS.BrowseCount; //浏览次数
objvMicroteachAppraiseENT.CollegeID = objvMicroteachAppraiseENS.CollegeID; //学院ID
objvMicroteachAppraiseENT.CollegeName = objvMicroteachAppraiseENS.CollegeName; //学院名称
objvMicroteachAppraiseENT.VideoStopTime = objvMicroteachAppraiseENS.VideoStopTime; //公开课案例视频暂停时间
objvMicroteachAppraiseENT.IsElite = objvMicroteachAppraiseENS.IsElite; //精华标志
objvMicroteachAppraiseENT.IsVisual = objvMicroteachAppraiseENS.IsVisual; //隐藏标志
objvMicroteachAppraiseENT.MicroteachCaseDate = objvMicroteachAppraiseENS.MicroteachCaseDate; //微格教学日期
objvMicroteachAppraiseENT.OwnerNameWithId = objvMicroteachAppraiseENS.OwnerNameWithId; //拥有者名称附Id
objvMicroteachAppraiseENT.UserNameWithUserId = objvMicroteachAppraiseENS.UserNameWithUserId; //UserNameWithUserId
objvMicroteachAppraiseENT.BrowseCount4Case = objvMicroteachAppraiseENS.BrowseCount4Case; //课例浏览次数
objvMicroteachAppraiseENT.IdXzCollege = objvMicroteachAppraiseENS.IdXzCollege; //学院流水号
objvMicroteachAppraiseENT.CollegeNameA = objvMicroteachAppraiseENS.CollegeNameA; //学院名称简写
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
 /// <param name = "objvMicroteachAppraiseENS">源对象</param>
 /// <returns>目标对象=>clsvMicroteachAppraiseEN:objvMicroteachAppraiseENT</returns>
 public static clsvMicroteachAppraiseEN CopyTo(this clsvMicroteachAppraiseEN objvMicroteachAppraiseENS)
{
try
{
 clsvMicroteachAppraiseEN objvMicroteachAppraiseENT = new clsvMicroteachAppraiseEN()
{
IdMicroteachAppraise = objvMicroteachAppraiseENS.IdMicroteachAppraise, //评议流水号
FuncModuleId = objvMicroteachAppraiseENS.FuncModuleId, //功能模块Id
FuncModuleName = objvMicroteachAppraiseENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvMicroteachAppraiseENS.IdMicroteachCase, //微格教学案例流水号
MicroteachCaseID = objvMicroteachAppraiseENS.MicroteachCaseID, //微格教学案例ID
MicroteachCaseName = objvMicroteachAppraiseENS.MicroteachCaseName, //微格教学案例名称
IdAppraiseType = objvMicroteachAppraiseENS.IdAppraiseType, //评议类型流水号
AppraiseTypeName = objvMicroteachAppraiseENS.AppraiseTypeName, //评议类型名称
OwnerId = objvMicroteachAppraiseENS.OwnerId, //拥有者Id
OwnerName = objvMicroteachAppraiseENS.OwnerName, //拥有者姓名
UserId = objvMicroteachAppraiseENS.UserId, //用户ID
UserName = objvMicroteachAppraiseENS.UserName, //用户名
AppraiseTheme = objvMicroteachAppraiseENS.AppraiseTheme, //评议主题
AppraiseContent = objvMicroteachAppraiseENS.AppraiseContent, //评议内容
AppraiseDate = objvMicroteachAppraiseENS.AppraiseDate, //评议日期
AppraiseTime = objvMicroteachAppraiseENS.AppraiseTime, //评议时间
ExcellentOne = objvMicroteachAppraiseENS.ExcellentOne, //优点1
ExcellentTwo = objvMicroteachAppraiseENS.ExcellentTwo, //优点2
SuggestOne = objvMicroteachAppraiseENS.SuggestOne, //建议1
SuggestTwo = objvMicroteachAppraiseENS.SuggestTwo, //建议2
MicroteachAppriseScore = objvMicroteachAppraiseENS.MicroteachAppriseScore, //打分
BrowseCount = objvMicroteachAppraiseENS.BrowseCount, //浏览次数
CollegeID = objvMicroteachAppraiseENS.CollegeID, //学院ID
CollegeName = objvMicroteachAppraiseENS.CollegeName, //学院名称
VideoStopTime = objvMicroteachAppraiseENS.VideoStopTime, //公开课案例视频暂停时间
IsElite = objvMicroteachAppraiseENS.IsElite, //精华标志
IsVisual = objvMicroteachAppraiseENS.IsVisual, //隐藏标志
MicroteachCaseDate = objvMicroteachAppraiseENS.MicroteachCaseDate, //微格教学日期
OwnerNameWithId = objvMicroteachAppraiseENS.OwnerNameWithId, //拥有者名称附Id
UserNameWithUserId = objvMicroteachAppraiseENS.UserNameWithUserId, //UserNameWithUserId
BrowseCount4Case = objvMicroteachAppraiseENS.BrowseCount4Case, //课例浏览次数
IdXzCollege = objvMicroteachAppraiseENS.IdXzCollege, //学院流水号
CollegeNameA = objvMicroteachAppraiseENS.CollegeNameA, //学院名称简写
};
 return objvMicroteachAppraiseENT;
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
public static void CheckProperty4Condition(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN)
{
 clsvMicroteachAppraiseBL.vMicroteachAppraiseDA.CheckProperty4Condition(objvMicroteachAppraiseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachAppraiseEN objvMicroteachAppraiseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.IdMicroteachAppraise) == true)
{
string strComparisonOpIdMicroteachAppraise = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.IdMicroteachAppraise];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachAppraise.IdMicroteachAppraise, objvMicroteachAppraiseCond.IdMicroteachAppraise, strComparisonOpIdMicroteachAppraise);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.FuncModuleId, objvMicroteachAppraiseCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.FuncModuleName, objvMicroteachAppraiseCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.IdMicroteachCase, objvMicroteachAppraiseCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.MicroteachCaseID) == true)
{
string strComparisonOpMicroteachCaseID = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.MicroteachCaseID, objvMicroteachAppraiseCond.MicroteachCaseID, strComparisonOpMicroteachCaseID);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.MicroteachCaseName) == true)
{
string strComparisonOpMicroteachCaseName = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.MicroteachCaseName, objvMicroteachAppraiseCond.MicroteachCaseName, strComparisonOpMicroteachCaseName);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.IdAppraiseType) == true)
{
string strComparisonOpIdAppraiseType = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.IdAppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.IdAppraiseType, objvMicroteachAppraiseCond.IdAppraiseType, strComparisonOpIdAppraiseType);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.AppraiseTypeName) == true)
{
string strComparisonOpAppraiseTypeName = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.AppraiseTypeName, objvMicroteachAppraiseCond.AppraiseTypeName, strComparisonOpAppraiseTypeName);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.OwnerId) == true)
{
string strComparisonOpOwnerId = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.OwnerId, objvMicroteachAppraiseCond.OwnerId, strComparisonOpOwnerId);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.OwnerName) == true)
{
string strComparisonOpOwnerName = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.OwnerName, objvMicroteachAppraiseCond.OwnerName, strComparisonOpOwnerName);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.UserId) == true)
{
string strComparisonOpUserId = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.UserId, objvMicroteachAppraiseCond.UserId, strComparisonOpUserId);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.UserName) == true)
{
string strComparisonOpUserName = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.UserName, objvMicroteachAppraiseCond.UserName, strComparisonOpUserName);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.AppraiseTheme) == true)
{
string strComparisonOpAppraiseTheme = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.AppraiseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.AppraiseTheme, objvMicroteachAppraiseCond.AppraiseTheme, strComparisonOpAppraiseTheme);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.AppraiseContent) == true)
{
string strComparisonOpAppraiseContent = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.AppraiseContent, objvMicroteachAppraiseCond.AppraiseContent, strComparisonOpAppraiseContent);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.AppraiseDate) == true)
{
string strComparisonOpAppraiseDate = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.AppraiseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.AppraiseDate, objvMicroteachAppraiseCond.AppraiseDate, strComparisonOpAppraiseDate);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.AppraiseTime) == true)
{
string strComparisonOpAppraiseTime = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.AppraiseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.AppraiseTime, objvMicroteachAppraiseCond.AppraiseTime, strComparisonOpAppraiseTime);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.ExcellentOne) == true)
{
string strComparisonOpExcellentOne = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.ExcellentOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.ExcellentOne, objvMicroteachAppraiseCond.ExcellentOne, strComparisonOpExcellentOne);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.ExcellentTwo) == true)
{
string strComparisonOpExcellentTwo = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.ExcellentTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.ExcellentTwo, objvMicroteachAppraiseCond.ExcellentTwo, strComparisonOpExcellentTwo);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.SuggestOne) == true)
{
string strComparisonOpSuggestOne = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.SuggestOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.SuggestOne, objvMicroteachAppraiseCond.SuggestOne, strComparisonOpSuggestOne);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.SuggestTwo) == true)
{
string strComparisonOpSuggestTwo = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.SuggestTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.SuggestTwo, objvMicroteachAppraiseCond.SuggestTwo, strComparisonOpSuggestTwo);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.MicroteachAppriseScore) == true)
{
string strComparisonOpMicroteachAppriseScore = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.MicroteachAppriseScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachAppraise.MicroteachAppriseScore, objvMicroteachAppraiseCond.MicroteachAppriseScore, strComparisonOpMicroteachAppriseScore);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachAppraise.BrowseCount, objvMicroteachAppraiseCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.CollegeID) == true)
{
string strComparisonOpCollegeID = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.CollegeID, objvMicroteachAppraiseCond.CollegeID, strComparisonOpCollegeID);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.CollegeName) == true)
{
string strComparisonOpCollegeName = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.CollegeName, objvMicroteachAppraiseCond.CollegeName, strComparisonOpCollegeName);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.VideoStopTime) == true)
{
string strComparisonOpVideoStopTime = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.VideoStopTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.VideoStopTime, objvMicroteachAppraiseCond.VideoStopTime, strComparisonOpVideoStopTime);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.IsElite) == true)
{
if (objvMicroteachAppraiseCond.IsElite == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachAppraise.IsElite);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachAppraise.IsElite);
}
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.IsVisual) == true)
{
if (objvMicroteachAppraiseCond.IsVisual == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachAppraise.IsVisual);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachAppraise.IsVisual);
}
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.MicroteachCaseDate) == true)
{
string strComparisonOpMicroteachCaseDate = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.MicroteachCaseDate, objvMicroteachAppraiseCond.MicroteachCaseDate, strComparisonOpMicroteachCaseDate);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.OwnerNameWithId, objvMicroteachAppraiseCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.UserNameWithUserId) == true)
{
string strComparisonOpUserNameWithUserId = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.UserNameWithUserId, objvMicroteachAppraiseCond.UserNameWithUserId, strComparisonOpUserNameWithUserId);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachAppraise.BrowseCount4Case, objvMicroteachAppraiseCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.IdXzCollege, objvMicroteachAppraiseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvMicroteachAppraiseCond.IsUpdated(convMicroteachAppraise.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvMicroteachAppraiseCond.dicFldComparisonOp[convMicroteachAppraise.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.CollegeNameA, objvMicroteachAppraiseCond.CollegeNameA, strComparisonOpCollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMicroteachAppraise
{
public virtual bool UpdRelaTabDate(long lngIdMicroteachAppraise, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 微格案例评议信息表视图(vMicroteachAppraise)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachAppraiseBL
{
public static RelatedActions_vMicroteachAppraise relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMicroteachAppraiseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMicroteachAppraiseDA vMicroteachAppraiseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMicroteachAppraiseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMicroteachAppraiseBL()
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
if (string.IsNullOrEmpty(clsvMicroteachAppraiseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachAppraiseEN._ConnectString);
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
public static DataTable GetDataTable_vMicroteachAppraise(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMicroteachAppraiseDA.GetDataTable_vMicroteachAppraise(strWhereCond);
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
objDT = vMicroteachAppraiseDA.GetDataTable(strWhereCond);
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
objDT = vMicroteachAppraiseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMicroteachAppraiseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMicroteachAppraiseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMicroteachAppraiseDA.GetDataTable_Top(objTopPara);
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
objDT = vMicroteachAppraiseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMicroteachAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMicroteachAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachAppraiseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvMicroteachAppraiseEN> GetObjLstByIdMicroteachAppraiseLst(List<long> arrIdMicroteachAppraiseLst)
{
List<clsvMicroteachAppraiseEN> arrObjLst = new List<clsvMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachAppraiseLst);
 string strWhereCond = string.Format("IdMicroteachAppraise in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN();
try
{
objvMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvMicroteachAppraiseEN.FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachAppraiseEN.FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachAppraiseEN.IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachAppraiseEN.MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachAppraiseEN.MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachAppraiseEN.IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachAppraiseEN.AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachAppraiseEN.OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachAppraiseEN.OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachAppraiseEN.UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(); //用户ID
objvMicroteachAppraiseEN.UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(); //用户名
objvMicroteachAppraiseEN.AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvMicroteachAppraiseEN.AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvMicroteachAppraiseEN.AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvMicroteachAppraiseEN.AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvMicroteachAppraiseEN.ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objvMicroteachAppraiseEN.ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvMicroteachAppraiseEN.SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objvMicroteachAppraiseEN.SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objvMicroteachAppraiseEN.MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvMicroteachAppraiseEN.BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachAppraiseEN.CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID
objvMicroteachAppraiseEN.CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称
objvMicroteachAppraiseEN.VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objvMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvMicroteachAppraiseEN.MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachAppraiseEN.OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachAppraiseEN.UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachAppraiseEN.BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachAppraiseEN.IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachAppraiseEN.CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachAppraiseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMicroteachAppraiseEN> GetObjLstByIdMicroteachAppraiseLstCache(List<long> arrIdMicroteachAppraiseLst)
{
string strKey = string.Format("{0}", clsvMicroteachAppraiseEN._CurrTabName);
List<clsvMicroteachAppraiseEN> arrvMicroteachAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachAppraiseEN> arrvMicroteachAppraiseObjLst_Sel =
arrvMicroteachAppraiseObjLstCache
.Where(x => arrIdMicroteachAppraiseLst.Contains(x.IdMicroteachAppraise));
return arrvMicroteachAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachAppraiseEN> GetObjLst(string strWhereCond)
{
List<clsvMicroteachAppraiseEN> arrObjLst = new List<clsvMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN();
try
{
objvMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvMicroteachAppraiseEN.FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachAppraiseEN.FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachAppraiseEN.IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachAppraiseEN.MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachAppraiseEN.MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachAppraiseEN.IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachAppraiseEN.AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachAppraiseEN.OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachAppraiseEN.OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachAppraiseEN.UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(); //用户ID
objvMicroteachAppraiseEN.UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(); //用户名
objvMicroteachAppraiseEN.AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvMicroteachAppraiseEN.AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvMicroteachAppraiseEN.AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvMicroteachAppraiseEN.AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvMicroteachAppraiseEN.ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objvMicroteachAppraiseEN.ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvMicroteachAppraiseEN.SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objvMicroteachAppraiseEN.SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objvMicroteachAppraiseEN.MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvMicroteachAppraiseEN.BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachAppraiseEN.CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID
objvMicroteachAppraiseEN.CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称
objvMicroteachAppraiseEN.VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objvMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvMicroteachAppraiseEN.MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachAppraiseEN.OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachAppraiseEN.UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachAppraiseEN.BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachAppraiseEN.IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachAppraiseEN.CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachAppraiseEN);
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
public static List<clsvMicroteachAppraiseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachAppraiseEN> arrObjLst = new List<clsvMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN();
try
{
objvMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvMicroteachAppraiseEN.FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachAppraiseEN.FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachAppraiseEN.IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachAppraiseEN.MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachAppraiseEN.MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachAppraiseEN.IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachAppraiseEN.AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachAppraiseEN.OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachAppraiseEN.OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachAppraiseEN.UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(); //用户ID
objvMicroteachAppraiseEN.UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(); //用户名
objvMicroteachAppraiseEN.AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvMicroteachAppraiseEN.AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvMicroteachAppraiseEN.AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvMicroteachAppraiseEN.AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvMicroteachAppraiseEN.ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objvMicroteachAppraiseEN.ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvMicroteachAppraiseEN.SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objvMicroteachAppraiseEN.SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objvMicroteachAppraiseEN.MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvMicroteachAppraiseEN.BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachAppraiseEN.CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID
objvMicroteachAppraiseEN.CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称
objvMicroteachAppraiseEN.VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objvMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvMicroteachAppraiseEN.MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachAppraiseEN.OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachAppraiseEN.UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachAppraiseEN.BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachAppraiseEN.IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachAppraiseEN.CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMicroteachAppraiseEN> GetSubObjLstCache(clsvMicroteachAppraiseEN objvMicroteachAppraiseCond)
{
List<clsvMicroteachAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachAppraise.AttributeName)
{
if (objvMicroteachAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachAppraiseCond[strFldName].ToString());
}
else
{
if (objvMicroteachAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachAppraiseCond[strFldName]));
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
public static List<clsvMicroteachAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMicroteachAppraiseEN> arrObjLst = new List<clsvMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN();
try
{
objvMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvMicroteachAppraiseEN.FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachAppraiseEN.FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachAppraiseEN.IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachAppraiseEN.MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachAppraiseEN.MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachAppraiseEN.IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachAppraiseEN.AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachAppraiseEN.OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachAppraiseEN.OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachAppraiseEN.UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(); //用户ID
objvMicroteachAppraiseEN.UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(); //用户名
objvMicroteachAppraiseEN.AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvMicroteachAppraiseEN.AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvMicroteachAppraiseEN.AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvMicroteachAppraiseEN.AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvMicroteachAppraiseEN.ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objvMicroteachAppraiseEN.ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvMicroteachAppraiseEN.SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objvMicroteachAppraiseEN.SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objvMicroteachAppraiseEN.MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvMicroteachAppraiseEN.BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachAppraiseEN.CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID
objvMicroteachAppraiseEN.CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称
objvMicroteachAppraiseEN.VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objvMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvMicroteachAppraiseEN.MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachAppraiseEN.OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachAppraiseEN.UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachAppraiseEN.BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachAppraiseEN.IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachAppraiseEN.CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachAppraiseEN);
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
public static List<clsvMicroteachAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMicroteachAppraiseEN> arrObjLst = new List<clsvMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN();
try
{
objvMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvMicroteachAppraiseEN.FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachAppraiseEN.FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachAppraiseEN.IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachAppraiseEN.MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachAppraiseEN.MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachAppraiseEN.IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachAppraiseEN.AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachAppraiseEN.OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachAppraiseEN.OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachAppraiseEN.UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(); //用户ID
objvMicroteachAppraiseEN.UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(); //用户名
objvMicroteachAppraiseEN.AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvMicroteachAppraiseEN.AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvMicroteachAppraiseEN.AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvMicroteachAppraiseEN.AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvMicroteachAppraiseEN.ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objvMicroteachAppraiseEN.ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvMicroteachAppraiseEN.SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objvMicroteachAppraiseEN.SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objvMicroteachAppraiseEN.MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvMicroteachAppraiseEN.BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachAppraiseEN.CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID
objvMicroteachAppraiseEN.CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称
objvMicroteachAppraiseEN.VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objvMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvMicroteachAppraiseEN.MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachAppraiseEN.OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachAppraiseEN.UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachAppraiseEN.BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachAppraiseEN.IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachAppraiseEN.CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachAppraiseEN);
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
List<clsvMicroteachAppraiseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMicroteachAppraiseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMicroteachAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachAppraiseEN> arrObjLst = new List<clsvMicroteachAppraiseEN>(); 
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
	clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN();
try
{
objvMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvMicroteachAppraiseEN.FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachAppraiseEN.FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachAppraiseEN.IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachAppraiseEN.MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachAppraiseEN.MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachAppraiseEN.IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachAppraiseEN.AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachAppraiseEN.OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachAppraiseEN.OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachAppraiseEN.UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(); //用户ID
objvMicroteachAppraiseEN.UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(); //用户名
objvMicroteachAppraiseEN.AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvMicroteachAppraiseEN.AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvMicroteachAppraiseEN.AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvMicroteachAppraiseEN.AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvMicroteachAppraiseEN.ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objvMicroteachAppraiseEN.ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvMicroteachAppraiseEN.SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objvMicroteachAppraiseEN.SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objvMicroteachAppraiseEN.MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvMicroteachAppraiseEN.BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachAppraiseEN.CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID
objvMicroteachAppraiseEN.CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称
objvMicroteachAppraiseEN.VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objvMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvMicroteachAppraiseEN.MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachAppraiseEN.OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachAppraiseEN.UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachAppraiseEN.BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachAppraiseEN.IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachAppraiseEN.CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachAppraiseEN);
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
public static List<clsvMicroteachAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachAppraiseEN> arrObjLst = new List<clsvMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN();
try
{
objvMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvMicroteachAppraiseEN.FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachAppraiseEN.FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachAppraiseEN.IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachAppraiseEN.MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachAppraiseEN.MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachAppraiseEN.IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachAppraiseEN.AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachAppraiseEN.OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachAppraiseEN.OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachAppraiseEN.UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(); //用户ID
objvMicroteachAppraiseEN.UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(); //用户名
objvMicroteachAppraiseEN.AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvMicroteachAppraiseEN.AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvMicroteachAppraiseEN.AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvMicroteachAppraiseEN.AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvMicroteachAppraiseEN.ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objvMicroteachAppraiseEN.ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvMicroteachAppraiseEN.SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objvMicroteachAppraiseEN.SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objvMicroteachAppraiseEN.MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvMicroteachAppraiseEN.BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachAppraiseEN.CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID
objvMicroteachAppraiseEN.CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称
objvMicroteachAppraiseEN.VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objvMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvMicroteachAppraiseEN.MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachAppraiseEN.OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachAppraiseEN.UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachAppraiseEN.BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachAppraiseEN.IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachAppraiseEN.CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMicroteachAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMicroteachAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachAppraiseEN> arrObjLst = new List<clsvMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN();
try
{
objvMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvMicroteachAppraiseEN.FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachAppraiseEN.FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachAppraiseEN.IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachAppraiseEN.MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachAppraiseEN.MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachAppraiseEN.IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachAppraiseEN.AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachAppraiseEN.OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachAppraiseEN.OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachAppraiseEN.UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(); //用户ID
objvMicroteachAppraiseEN.UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(); //用户名
objvMicroteachAppraiseEN.AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvMicroteachAppraiseEN.AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvMicroteachAppraiseEN.AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvMicroteachAppraiseEN.AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvMicroteachAppraiseEN.ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objvMicroteachAppraiseEN.ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvMicroteachAppraiseEN.SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objvMicroteachAppraiseEN.SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objvMicroteachAppraiseEN.MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvMicroteachAppraiseEN.BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachAppraiseEN.CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID
objvMicroteachAppraiseEN.CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称
objvMicroteachAppraiseEN.VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objvMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvMicroteachAppraiseEN.MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachAppraiseEN.OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachAppraiseEN.UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachAppraiseEN.BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachAppraiseEN.IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachAppraiseEN.CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachAppraiseEN);
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
public static List<clsvMicroteachAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMicroteachAppraiseEN> arrObjLst = new List<clsvMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN();
try
{
objvMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvMicroteachAppraiseEN.FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachAppraiseEN.FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachAppraiseEN.IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachAppraiseEN.MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachAppraiseEN.MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachAppraiseEN.IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachAppraiseEN.AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachAppraiseEN.OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachAppraiseEN.OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachAppraiseEN.UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(); //用户ID
objvMicroteachAppraiseEN.UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(); //用户名
objvMicroteachAppraiseEN.AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvMicroteachAppraiseEN.AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvMicroteachAppraiseEN.AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvMicroteachAppraiseEN.AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvMicroteachAppraiseEN.ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objvMicroteachAppraiseEN.ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvMicroteachAppraiseEN.SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objvMicroteachAppraiseEN.SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objvMicroteachAppraiseEN.MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvMicroteachAppraiseEN.BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachAppraiseEN.CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID
objvMicroteachAppraiseEN.CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称
objvMicroteachAppraiseEN.VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objvMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvMicroteachAppraiseEN.MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachAppraiseEN.OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachAppraiseEN.UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachAppraiseEN.BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachAppraiseEN.IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachAppraiseEN.CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachAppraiseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMicroteachAppraiseEN> arrObjLst = new List<clsvMicroteachAppraiseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN();
try
{
objvMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvMicroteachAppraiseEN.FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachAppraiseEN.FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachAppraiseEN.IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachAppraiseEN.MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachAppraiseEN.MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachAppraiseEN.IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachAppraiseEN.AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachAppraiseEN.OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachAppraiseEN.OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachAppraiseEN.UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(); //用户ID
objvMicroteachAppraiseEN.UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(); //用户名
objvMicroteachAppraiseEN.AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvMicroteachAppraiseEN.AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvMicroteachAppraiseEN.AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvMicroteachAppraiseEN.AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvMicroteachAppraiseEN.ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objvMicroteachAppraiseEN.ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvMicroteachAppraiseEN.SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objvMicroteachAppraiseEN.SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objvMicroteachAppraiseEN.MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvMicroteachAppraiseEN.BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachAppraiseEN.CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID
objvMicroteachAppraiseEN.CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称
objvMicroteachAppraiseEN.VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objvMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvMicroteachAppraiseEN.MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachAppraiseEN.OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachAppraiseEN.UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachAppraiseEN.BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachAppraiseEN.IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachAppraiseEN.CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachAppraiseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMicroteachAppraise(ref clsvMicroteachAppraiseEN objvMicroteachAppraiseEN)
{
bool bolResult = vMicroteachAppraiseDA.GetvMicroteachAppraise(ref objvMicroteachAppraiseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachAppraiseEN GetObjByIdMicroteachAppraise(long lngIdMicroteachAppraise)
{
clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = vMicroteachAppraiseDA.GetObjByIdMicroteachAppraise(lngIdMicroteachAppraise);
return objvMicroteachAppraiseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMicroteachAppraiseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = vMicroteachAppraiseDA.GetFirstObj(strWhereCond);
 return objvMicroteachAppraiseEN;
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
public static clsvMicroteachAppraiseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = vMicroteachAppraiseDA.GetObjByDataRow(objRow);
 return objvMicroteachAppraiseEN;
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
public static clsvMicroteachAppraiseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = vMicroteachAppraiseDA.GetObjByDataRow(objRow);
 return objvMicroteachAppraiseEN;
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
 /// <param name = "lngIdMicroteachAppraise">所给的关键字</param>
 /// <param name = "lstvMicroteachAppraiseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachAppraiseEN GetObjByIdMicroteachAppraiseFromList(long lngIdMicroteachAppraise, List<clsvMicroteachAppraiseEN> lstvMicroteachAppraiseObjLst)
{
foreach (clsvMicroteachAppraiseEN objvMicroteachAppraiseEN in lstvMicroteachAppraiseObjLst)
{
if (objvMicroteachAppraiseEN.IdMicroteachAppraise == lngIdMicroteachAppraise)
{
return objvMicroteachAppraiseEN;
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
 long lngIdMicroteachAppraise;
 try
 {
 lngIdMicroteachAppraise = new clsvMicroteachAppraiseDA().GetFirstID(strWhereCond);
 return lngIdMicroteachAppraise;
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
 arrList = vMicroteachAppraiseDA.GetID(strWhereCond);
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
bool bolIsExist = vMicroteachAppraiseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdMicroteachAppraise)
{
//检测记录是否存在
bool bolIsExist = vMicroteachAppraiseDA.IsExist(lngIdMicroteachAppraise);
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
 bolIsExist = clsvMicroteachAppraiseDA.IsExistTable();
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
 bolIsExist = vMicroteachAppraiseDA.IsExistTable(strTabName);
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
 /// <param name = "objvMicroteachAppraiseENS">源对象</param>
 /// <param name = "objvMicroteachAppraiseENT">目标对象</param>
 public static void CopyTo(clsvMicroteachAppraiseEN objvMicroteachAppraiseENS, clsvMicroteachAppraiseEN objvMicroteachAppraiseENT)
{
try
{
objvMicroteachAppraiseENT.IdMicroteachAppraise = objvMicroteachAppraiseENS.IdMicroteachAppraise; //评议流水号
objvMicroteachAppraiseENT.FuncModuleId = objvMicroteachAppraiseENS.FuncModuleId; //功能模块Id
objvMicroteachAppraiseENT.FuncModuleName = objvMicroteachAppraiseENS.FuncModuleName; //功能模块名称
objvMicroteachAppraiseENT.IdMicroteachCase = objvMicroteachAppraiseENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachAppraiseENT.MicroteachCaseID = objvMicroteachAppraiseENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachAppraiseENT.MicroteachCaseName = objvMicroteachAppraiseENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachAppraiseENT.IdAppraiseType = objvMicroteachAppraiseENS.IdAppraiseType; //评议类型流水号
objvMicroteachAppraiseENT.AppraiseTypeName = objvMicroteachAppraiseENS.AppraiseTypeName; //评议类型名称
objvMicroteachAppraiseENT.OwnerId = objvMicroteachAppraiseENS.OwnerId; //拥有者Id
objvMicroteachAppraiseENT.OwnerName = objvMicroteachAppraiseENS.OwnerName; //拥有者姓名
objvMicroteachAppraiseENT.UserId = objvMicroteachAppraiseENS.UserId; //用户ID
objvMicroteachAppraiseENT.UserName = objvMicroteachAppraiseENS.UserName; //用户名
objvMicroteachAppraiseENT.AppraiseTheme = objvMicroteachAppraiseENS.AppraiseTheme; //评议主题
objvMicroteachAppraiseENT.AppraiseContent = objvMicroteachAppraiseENS.AppraiseContent; //评议内容
objvMicroteachAppraiseENT.AppraiseDate = objvMicroteachAppraiseENS.AppraiseDate; //评议日期
objvMicroteachAppraiseENT.AppraiseTime = objvMicroteachAppraiseENS.AppraiseTime; //评议时间
objvMicroteachAppraiseENT.ExcellentOne = objvMicroteachAppraiseENS.ExcellentOne; //优点1
objvMicroteachAppraiseENT.ExcellentTwo = objvMicroteachAppraiseENS.ExcellentTwo; //优点2
objvMicroteachAppraiseENT.SuggestOne = objvMicroteachAppraiseENS.SuggestOne; //建议1
objvMicroteachAppraiseENT.SuggestTwo = objvMicroteachAppraiseENS.SuggestTwo; //建议2
objvMicroteachAppraiseENT.MicroteachAppriseScore = objvMicroteachAppraiseENS.MicroteachAppriseScore; //打分
objvMicroteachAppraiseENT.BrowseCount = objvMicroteachAppraiseENS.BrowseCount; //浏览次数
objvMicroteachAppraiseENT.CollegeID = objvMicroteachAppraiseENS.CollegeID; //学院ID
objvMicroteachAppraiseENT.CollegeName = objvMicroteachAppraiseENS.CollegeName; //学院名称
objvMicroteachAppraiseENT.VideoStopTime = objvMicroteachAppraiseENS.VideoStopTime; //公开课案例视频暂停时间
objvMicroteachAppraiseENT.IsElite = objvMicroteachAppraiseENS.IsElite; //精华标志
objvMicroteachAppraiseENT.IsVisual = objvMicroteachAppraiseENS.IsVisual; //隐藏标志
objvMicroteachAppraiseENT.MicroteachCaseDate = objvMicroteachAppraiseENS.MicroteachCaseDate; //微格教学日期
objvMicroteachAppraiseENT.OwnerNameWithId = objvMicroteachAppraiseENS.OwnerNameWithId; //拥有者名称附Id
objvMicroteachAppraiseENT.UserNameWithUserId = objvMicroteachAppraiseENS.UserNameWithUserId; //UserNameWithUserId
objvMicroteachAppraiseENT.BrowseCount4Case = objvMicroteachAppraiseENS.BrowseCount4Case; //课例浏览次数
objvMicroteachAppraiseENT.IdXzCollege = objvMicroteachAppraiseENS.IdXzCollege; //学院流水号
objvMicroteachAppraiseENT.CollegeNameA = objvMicroteachAppraiseENS.CollegeNameA; //学院名称简写
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
 /// <param name = "objvMicroteachAppraiseEN">源简化对象</param>
 public static void SetUpdFlag(clsvMicroteachAppraiseEN objvMicroteachAppraiseEN)
{
try
{
objvMicroteachAppraiseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMicroteachAppraiseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMicroteachAppraise.IdMicroteachAppraise, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.IdMicroteachAppraise = objvMicroteachAppraiseEN.IdMicroteachAppraise; //评议流水号
}
if (arrFldSet.Contains(convMicroteachAppraise.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.FuncModuleId = objvMicroteachAppraiseEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convMicroteachAppraise.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.FuncModuleName = objvMicroteachAppraiseEN.FuncModuleName == "[null]" ? null :  objvMicroteachAppraiseEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convMicroteachAppraise.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.IdMicroteachCase = objvMicroteachAppraiseEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convMicroteachAppraise.MicroteachCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.MicroteachCaseID = objvMicroteachAppraiseEN.MicroteachCaseID; //微格教学案例ID
}
if (arrFldSet.Contains(convMicroteachAppraise.MicroteachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.MicroteachCaseName = objvMicroteachAppraiseEN.MicroteachCaseName; //微格教学案例名称
}
if (arrFldSet.Contains(convMicroteachAppraise.IdAppraiseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.IdAppraiseType = objvMicroteachAppraiseEN.IdAppraiseType; //评议类型流水号
}
if (arrFldSet.Contains(convMicroteachAppraise.AppraiseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.AppraiseTypeName = objvMicroteachAppraiseEN.AppraiseTypeName; //评议类型名称
}
if (arrFldSet.Contains(convMicroteachAppraise.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.OwnerId = objvMicroteachAppraiseEN.OwnerId == "[null]" ? null :  objvMicroteachAppraiseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convMicroteachAppraise.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.OwnerName = objvMicroteachAppraiseEN.OwnerName == "[null]" ? null :  objvMicroteachAppraiseEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convMicroteachAppraise.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.UserId = objvMicroteachAppraiseEN.UserId; //用户ID
}
if (arrFldSet.Contains(convMicroteachAppraise.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.UserName = objvMicroteachAppraiseEN.UserName == "[null]" ? null :  objvMicroteachAppraiseEN.UserName; //用户名
}
if (arrFldSet.Contains(convMicroteachAppraise.AppraiseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.AppraiseTheme = objvMicroteachAppraiseEN.AppraiseTheme == "[null]" ? null :  objvMicroteachAppraiseEN.AppraiseTheme; //评议主题
}
if (arrFldSet.Contains(convMicroteachAppraise.AppraiseContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.AppraiseContent = objvMicroteachAppraiseEN.AppraiseContent == "[null]" ? null :  objvMicroteachAppraiseEN.AppraiseContent; //评议内容
}
if (arrFldSet.Contains(convMicroteachAppraise.AppraiseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.AppraiseDate = objvMicroteachAppraiseEN.AppraiseDate == "[null]" ? null :  objvMicroteachAppraiseEN.AppraiseDate; //评议日期
}
if (arrFldSet.Contains(convMicroteachAppraise.AppraiseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.AppraiseTime = objvMicroteachAppraiseEN.AppraiseTime == "[null]" ? null :  objvMicroteachAppraiseEN.AppraiseTime; //评议时间
}
if (arrFldSet.Contains(convMicroteachAppraise.ExcellentOne, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.ExcellentOne = objvMicroteachAppraiseEN.ExcellentOne == "[null]" ? null :  objvMicroteachAppraiseEN.ExcellentOne; //优点1
}
if (arrFldSet.Contains(convMicroteachAppraise.ExcellentTwo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.ExcellentTwo = objvMicroteachAppraiseEN.ExcellentTwo == "[null]" ? null :  objvMicroteachAppraiseEN.ExcellentTwo; //优点2
}
if (arrFldSet.Contains(convMicroteachAppraise.SuggestOne, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.SuggestOne = objvMicroteachAppraiseEN.SuggestOne == "[null]" ? null :  objvMicroteachAppraiseEN.SuggestOne; //建议1
}
if (arrFldSet.Contains(convMicroteachAppraise.SuggestTwo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.SuggestTwo = objvMicroteachAppraiseEN.SuggestTwo == "[null]" ? null :  objvMicroteachAppraiseEN.SuggestTwo; //建议2
}
if (arrFldSet.Contains(convMicroteachAppraise.MicroteachAppriseScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.MicroteachAppriseScore = objvMicroteachAppraiseEN.MicroteachAppriseScore; //打分
}
if (arrFldSet.Contains(convMicroteachAppraise.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.BrowseCount = objvMicroteachAppraiseEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convMicroteachAppraise.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.CollegeID = objvMicroteachAppraiseEN.CollegeID == "[null]" ? null :  objvMicroteachAppraiseEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convMicroteachAppraise.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.CollegeName = objvMicroteachAppraiseEN.CollegeName == "[null]" ? null :  objvMicroteachAppraiseEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convMicroteachAppraise.VideoStopTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.VideoStopTime = objvMicroteachAppraiseEN.VideoStopTime == "[null]" ? null :  objvMicroteachAppraiseEN.VideoStopTime; //公开课案例视频暂停时间
}
if (arrFldSet.Contains(convMicroteachAppraise.IsElite, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.IsElite = objvMicroteachAppraiseEN.IsElite; //精华标志
}
if (arrFldSet.Contains(convMicroteachAppraise.IsVisual, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.IsVisual = objvMicroteachAppraiseEN.IsVisual; //隐藏标志
}
if (arrFldSet.Contains(convMicroteachAppraise.MicroteachCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.MicroteachCaseDate = objvMicroteachAppraiseEN.MicroteachCaseDate == "[null]" ? null :  objvMicroteachAppraiseEN.MicroteachCaseDate; //微格教学日期
}
if (arrFldSet.Contains(convMicroteachAppraise.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.OwnerNameWithId = objvMicroteachAppraiseEN.OwnerNameWithId == "[null]" ? null :  objvMicroteachAppraiseEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convMicroteachAppraise.UserNameWithUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.UserNameWithUserId = objvMicroteachAppraiseEN.UserNameWithUserId == "[null]" ? null :  objvMicroteachAppraiseEN.UserNameWithUserId; //UserNameWithUserId
}
if (arrFldSet.Contains(convMicroteachAppraise.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.BrowseCount4Case = objvMicroteachAppraiseEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convMicroteachAppraise.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.IdXzCollege = objvMicroteachAppraiseEN.IdXzCollege == "[null]" ? null :  objvMicroteachAppraiseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convMicroteachAppraise.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachAppraiseEN.CollegeNameA = objvMicroteachAppraiseEN.CollegeNameA == "[null]" ? null :  objvMicroteachAppraiseEN.CollegeNameA; //学院名称简写
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
 /// <param name = "objvMicroteachAppraiseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMicroteachAppraiseEN objvMicroteachAppraiseEN)
{
try
{
if (objvMicroteachAppraiseEN.FuncModuleName == "[null]") objvMicroteachAppraiseEN.FuncModuleName = null; //功能模块名称
if (objvMicroteachAppraiseEN.OwnerId == "[null]") objvMicroteachAppraiseEN.OwnerId = null; //拥有者Id
if (objvMicroteachAppraiseEN.OwnerName == "[null]") objvMicroteachAppraiseEN.OwnerName = null; //拥有者姓名
if (objvMicroteachAppraiseEN.UserName == "[null]") objvMicroteachAppraiseEN.UserName = null; //用户名
if (objvMicroteachAppraiseEN.AppraiseTheme == "[null]") objvMicroteachAppraiseEN.AppraiseTheme = null; //评议主题
if (objvMicroteachAppraiseEN.AppraiseContent == "[null]") objvMicroteachAppraiseEN.AppraiseContent = null; //评议内容
if (objvMicroteachAppraiseEN.AppraiseDate == "[null]") objvMicroteachAppraiseEN.AppraiseDate = null; //评议日期
if (objvMicroteachAppraiseEN.AppraiseTime == "[null]") objvMicroteachAppraiseEN.AppraiseTime = null; //评议时间
if (objvMicroteachAppraiseEN.ExcellentOne == "[null]") objvMicroteachAppraiseEN.ExcellentOne = null; //优点1
if (objvMicroteachAppraiseEN.ExcellentTwo == "[null]") objvMicroteachAppraiseEN.ExcellentTwo = null; //优点2
if (objvMicroteachAppraiseEN.SuggestOne == "[null]") objvMicroteachAppraiseEN.SuggestOne = null; //建议1
if (objvMicroteachAppraiseEN.SuggestTwo == "[null]") objvMicroteachAppraiseEN.SuggestTwo = null; //建议2
if (objvMicroteachAppraiseEN.CollegeID == "[null]") objvMicroteachAppraiseEN.CollegeID = null; //学院ID
if (objvMicroteachAppraiseEN.CollegeName == "[null]") objvMicroteachAppraiseEN.CollegeName = null; //学院名称
if (objvMicroteachAppraiseEN.VideoStopTime == "[null]") objvMicroteachAppraiseEN.VideoStopTime = null; //公开课案例视频暂停时间
if (objvMicroteachAppraiseEN.MicroteachCaseDate == "[null]") objvMicroteachAppraiseEN.MicroteachCaseDate = null; //微格教学日期
if (objvMicroteachAppraiseEN.OwnerNameWithId == "[null]") objvMicroteachAppraiseEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvMicroteachAppraiseEN.UserNameWithUserId == "[null]") objvMicroteachAppraiseEN.UserNameWithUserId = null; //UserNameWithUserId
if (objvMicroteachAppraiseEN.IdXzCollege == "[null]") objvMicroteachAppraiseEN.IdXzCollege = null; //学院流水号
if (objvMicroteachAppraiseEN.CollegeNameA == "[null]") objvMicroteachAppraiseEN.CollegeNameA = null; //学院名称简写
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
public static void CheckProperty4Condition(clsvMicroteachAppraiseEN objvMicroteachAppraiseEN)
{
 vMicroteachAppraiseDA.CheckProperty4Condition(objvMicroteachAppraiseEN);
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
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachAppraiseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachAppraiseBL没有刷新缓存机制(clsMicroteachAppraiseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeBL没有刷新缓存机制(clsAppraiseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsQxUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserIdentityBL没有刷新缓存机制(clsQxUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionBL没有刷新缓存机制(clsSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachAppraise");
//if (arrvMicroteachAppraiseObjLstCache == null)
//{
//arrvMicroteachAppraiseObjLstCache = vMicroteachAppraiseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachAppraiseEN GetObjByIdMicroteachAppraiseCache(long lngIdMicroteachAppraise)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMicroteachAppraiseEN._CurrTabName);
List<clsvMicroteachAppraiseEN> arrvMicroteachAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachAppraiseEN> arrvMicroteachAppraiseObjLst_Sel =
arrvMicroteachAppraiseObjLstCache
.Where(x=> x.IdMicroteachAppraise == lngIdMicroteachAppraise 
);
if (arrvMicroteachAppraiseObjLst_Sel.Count() == 0)
{
   clsvMicroteachAppraiseEN obj = clsvMicroteachAppraiseBL.GetObjByIdMicroteachAppraise(lngIdMicroteachAppraise);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMicroteachAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachAppraiseEN> GetAllvMicroteachAppraiseObjLstCache()
{
//获取缓存中的对象列表
List<clsvMicroteachAppraiseEN> arrvMicroteachAppraiseObjLstCache = GetObjLstCache(); 
return arrvMicroteachAppraiseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachAppraiseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachAppraiseEN._CurrTabName);
List<clsvMicroteachAppraiseEN> arrvMicroteachAppraiseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachAppraiseObjLstCache;
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
string strKey = string.Format("{0}", clsvMicroteachAppraiseEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdMicroteachAppraise)
{
if (strInFldName != convMicroteachAppraise.IdMicroteachAppraise)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMicroteachAppraise.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMicroteachAppraise.AttributeName));
throw new Exception(strMsg);
}
var objvMicroteachAppraise = clsvMicroteachAppraiseBL.GetObjByIdMicroteachAppraiseCache(lngIdMicroteachAppraise);
if (objvMicroteachAppraise == null) return "";
return objvMicroteachAppraise[strOutFldName].ToString();
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
int intRecCount = clsvMicroteachAppraiseDA.GetRecCount(strTabName);
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
int intRecCount = clsvMicroteachAppraiseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMicroteachAppraiseDA.GetRecCount();
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
int intRecCount = clsvMicroteachAppraiseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMicroteachAppraiseEN objvMicroteachAppraiseCond)
{
List<clsvMicroteachAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachAppraise.AttributeName)
{
if (objvMicroteachAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachAppraiseCond[strFldName].ToString());
}
else
{
if (objvMicroteachAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachAppraiseCond[strFldName]));
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
 List<string> arrList = clsvMicroteachAppraiseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachAppraiseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachAppraiseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}