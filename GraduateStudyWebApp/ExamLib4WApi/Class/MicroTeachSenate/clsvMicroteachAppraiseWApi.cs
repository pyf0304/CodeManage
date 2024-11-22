
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachAppraiseWApi
 表名:vMicroteachAppraise(01120265)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:42
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
public static class clsvMicroteachAppraiseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN Setid_MicroteachAppraise(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, long lngid_MicroteachAppraise, string strComparisonOp="")
	{
objvMicroteachAppraiseEN.id_MicroteachAppraise = lngid_MicroteachAppraise; //评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.id_MicroteachAppraise) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.id_MicroteachAppraise, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.id_MicroteachAppraise] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetFuncModuleId(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMicroteachAppraise.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroteachAppraise.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroteachAppraise.FuncModuleId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetFuncModuleName(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMicroteachAppraise.FuncModuleName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN Setid_MicroteachCase(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convMicroteachAppraise.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMicroteachAppraise.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMicroteachAppraise.id_MicroteachCase);
objvMicroteachAppraiseEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.id_MicroteachCase) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.id_MicroteachCase, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.id_MicroteachCase] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetMicroteachCaseID(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseID, convMicroteachAppraise.MicroteachCaseID);
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachAppraise.MicroteachCaseID);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachAppraise.MicroteachCaseID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetMicroteachCaseName(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, convMicroteachAppraise.MicroteachCaseName);
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachAppraise.MicroteachCaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN Setid_AppraiseType(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convMicroteachAppraise.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convMicroteachAppraise.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convMicroteachAppraise.id_AppraiseType);
objvMicroteachAppraiseEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.id_AppraiseType) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.id_AppraiseType, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.id_AppraiseType] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetAppraiseTypeName(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseTypeName, convMicroteachAppraise.AppraiseTypeName);
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convMicroteachAppraise.AppraiseTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetOwnerId(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachAppraise.OwnerId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetOwnerName(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroteachAppraise.OwnerName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetUserId(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convMicroteachAppraise.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convMicroteachAppraise.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetUserName(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convMicroteachAppraise.UserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetAppraiseTheme(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strAppraiseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTheme, 200, convMicroteachAppraise.AppraiseTheme);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetAppraiseContent(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strAppraiseContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, convMicroteachAppraise.AppraiseContent);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetAppraiseDate(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strAppraiseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseDate, 8, convMicroteachAppraise.AppraiseDate);
clsCheckSql.CheckFieldForeignKey(strAppraiseDate, 8, convMicroteachAppraise.AppraiseDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetAppraiseTime(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strAppraiseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTime, 6, convMicroteachAppraise.AppraiseTime);
clsCheckSql.CheckFieldForeignKey(strAppraiseTime, 6, convMicroteachAppraise.AppraiseTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetExcellentOne(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strExcellentOne, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentOne, 1000, convMicroteachAppraise.ExcellentOne);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetExcellentTwo(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strExcellentTwo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentTwo, 1000, convMicroteachAppraise.ExcellentTwo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetSuggestOne(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strSuggestOne, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSuggestOne, 1000, convMicroteachAppraise.SuggestOne);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetSuggestTwo(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strSuggestTwo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSuggestTwo, 1000, convMicroteachAppraise.SuggestTwo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetMicroteachAppriseScore(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, float fltMicroteachAppriseScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetBrowseCount(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, int intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetCollegeID(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMicroteachAppraise.CollegeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetCollegeName(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachAppraise.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetVideoStopTime(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strVideoStopTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoStopTime, 48, convMicroteachAppraise.VideoStopTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetMicroteachCaseDate(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, convMicroteachAppraise.MicroteachCaseDate);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, convMicroteachAppraise.MicroteachCaseDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetOwnerNameWithId(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convMicroteachAppraise.OwnerNameWithId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetUserNameWithUserId(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convMicroteachAppraise.UserNameWithUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetBrowseCount4Case(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, int intBrowseCount4Case, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN Setid_XzCollege(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convMicroteachAppraise.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convMicroteachAppraise.id_XzCollege);
objvMicroteachAppraiseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(convMicroteachAppraise.id_XzCollege) == false)
{
objvMicroteachAppraiseEN.dicFldComparisonOp.Add(convMicroteachAppraise.id_XzCollege, strComparisonOp);
}
else
{
objvMicroteachAppraiseEN.dicFldComparisonOp[convMicroteachAppraise.id_XzCollege] = strComparisonOp;
}
}
return objvMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachAppraiseEN SetCollegeNameA(this clsvMicroteachAppraiseEN objvMicroteachAppraiseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroteachAppraise.CollegeNameA);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachAppraiseEN objvMicroteachAppraise_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.id_MicroteachAppraise) == true)
{
string strComparisonOp_id_MicroteachAppraise = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.id_MicroteachAppraise];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachAppraise.id_MicroteachAppraise, objvMicroteachAppraise_Cond.id_MicroteachAppraise, strComparisonOp_id_MicroteachAppraise);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.FuncModuleId, objvMicroteachAppraise_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.FuncModuleName, objvMicroteachAppraise_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.id_MicroteachCase, objvMicroteachAppraise_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.MicroteachCaseID) == true)
{
string strComparisonOp_MicroteachCaseID = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.MicroteachCaseID, objvMicroteachAppraise_Cond.MicroteachCaseID, strComparisonOp_MicroteachCaseID);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.MicroteachCaseName) == true)
{
string strComparisonOp_MicroteachCaseName = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.MicroteachCaseName, objvMicroteachAppraise_Cond.MicroteachCaseName, strComparisonOp_MicroteachCaseName);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.id_AppraiseType, objvMicroteachAppraise_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.AppraiseTypeName, objvMicroteachAppraise_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.OwnerId, objvMicroteachAppraise_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.OwnerName, objvMicroteachAppraise_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.UserId) == true)
{
string strComparisonOp_UserId = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.UserId, objvMicroteachAppraise_Cond.UserId, strComparisonOp_UserId);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.UserName) == true)
{
string strComparisonOp_UserName = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.UserName, objvMicroteachAppraise_Cond.UserName, strComparisonOp_UserName);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.AppraiseTheme) == true)
{
string strComparisonOp_AppraiseTheme = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.AppraiseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.AppraiseTheme, objvMicroteachAppraise_Cond.AppraiseTheme, strComparisonOp_AppraiseTheme);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.AppraiseContent) == true)
{
string strComparisonOp_AppraiseContent = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.AppraiseContent, objvMicroteachAppraise_Cond.AppraiseContent, strComparisonOp_AppraiseContent);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.AppraiseDate) == true)
{
string strComparisonOp_AppraiseDate = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.AppraiseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.AppraiseDate, objvMicroteachAppraise_Cond.AppraiseDate, strComparisonOp_AppraiseDate);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.AppraiseTime) == true)
{
string strComparisonOp_AppraiseTime = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.AppraiseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.AppraiseTime, objvMicroteachAppraise_Cond.AppraiseTime, strComparisonOp_AppraiseTime);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.ExcellentOne) == true)
{
string strComparisonOp_ExcellentOne = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.ExcellentOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.ExcellentOne, objvMicroteachAppraise_Cond.ExcellentOne, strComparisonOp_ExcellentOne);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.ExcellentTwo) == true)
{
string strComparisonOp_ExcellentTwo = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.ExcellentTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.ExcellentTwo, objvMicroteachAppraise_Cond.ExcellentTwo, strComparisonOp_ExcellentTwo);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.SuggestOne) == true)
{
string strComparisonOp_SuggestOne = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.SuggestOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.SuggestOne, objvMicroteachAppraise_Cond.SuggestOne, strComparisonOp_SuggestOne);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.SuggestTwo) == true)
{
string strComparisonOp_SuggestTwo = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.SuggestTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.SuggestTwo, objvMicroteachAppraise_Cond.SuggestTwo, strComparisonOp_SuggestTwo);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.MicroteachAppriseScore) == true)
{
string strComparisonOp_MicroteachAppriseScore = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.MicroteachAppriseScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachAppraise.MicroteachAppriseScore, objvMicroteachAppraise_Cond.MicroteachAppriseScore, strComparisonOp_MicroteachAppriseScore);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachAppraise.BrowseCount, objvMicroteachAppraise_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.CollegeID, objvMicroteachAppraise_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.CollegeName, objvMicroteachAppraise_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.VideoStopTime) == true)
{
string strComparisonOp_VideoStopTime = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.VideoStopTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.VideoStopTime, objvMicroteachAppraise_Cond.VideoStopTime, strComparisonOp_VideoStopTime);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.IsElite) == true)
{
if (objvMicroteachAppraise_Cond.IsElite == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachAppraise.IsElite);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachAppraise.IsElite);
}
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.IsVisual) == true)
{
if (objvMicroteachAppraise_Cond.IsVisual == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachAppraise.IsVisual);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachAppraise.IsVisual);
}
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.MicroteachCaseDate) == true)
{
string strComparisonOp_MicroteachCaseDate = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.MicroteachCaseDate, objvMicroteachAppraise_Cond.MicroteachCaseDate, strComparisonOp_MicroteachCaseDate);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.OwnerNameWithId, objvMicroteachAppraise_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.UserNameWithUserId, objvMicroteachAppraise_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachAppraise.BrowseCount4Case, objvMicroteachAppraise_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.id_XzCollege, objvMicroteachAppraise_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvMicroteachAppraise_Cond.IsUpdated(convMicroteachAppraise.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvMicroteachAppraise_Cond.dicFldComparisonOp[convMicroteachAppraise.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachAppraise.CollegeNameA, objvMicroteachAppraise_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 微格案例评议信息表视图(vMicroteachAppraise)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachAppraiseWApi
{
private static readonly string mstrApiControllerName = "vMicroteachAppraiseApi";

 public clsvMicroteachAppraiseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachAppraiseEN GetObjByid_MicroteachAppraise(long lngid_MicroteachAppraise)
{
string strAction = "GetObjByid_MicroteachAppraise";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachAppraise"] = lngid_MicroteachAppraise.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMicroteachAppraiseEN = JsonConvert.DeserializeObject<clsvMicroteachAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachAppraiseEN;
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
 /// <param name = "lngid_MicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachAppraiseEN GetObjByid_MicroteachAppraise_WA_Cache(long lngid_MicroteachAppraise)
{
string strAction = "GetObjByid_MicroteachAppraise_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachAppraise"] = lngid_MicroteachAppraise.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMicroteachAppraiseEN = JsonConvert.DeserializeObject<clsvMicroteachAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachAppraiseEN;
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
public static clsvMicroteachAppraiseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = null;
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
objvMicroteachAppraiseEN = JsonConvert.DeserializeObject<clsvMicroteachAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachAppraiseEN;
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
 /// <param name = "lngid_MicroteachAppraise">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachAppraiseEN GetObjByid_MicroteachAppraise_Cache(long lngid_MicroteachAppraise)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachAppraiseEN._CurrTabName_S);
List<clsvMicroteachAppraiseEN> arrvMicroteachAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachAppraiseEN> arrvMicroteachAppraiseObjLst_Sel =
from objvMicroteachAppraiseEN in arrvMicroteachAppraiseObjLst_Cache
where objvMicroteachAppraiseEN.id_MicroteachAppraise == lngid_MicroteachAppraise
select objvMicroteachAppraiseEN;
if (arrvMicroteachAppraiseObjLst_Sel.Count() == 0)
{
   clsvMicroteachAppraiseEN obj = clsvMicroteachAppraiseWApi.GetObjByid_MicroteachAppraise(lngid_MicroteachAppraise);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMicroteachAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachAppraiseEN> GetObjLst(string strWhereCond)
{
 List<clsvMicroteachAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachAppraiseEN> GetObjLstById_MicroteachAppraiseLst(List<long> arrId_MicroteachAppraise)
{
 List<clsvMicroteachAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachAppraiseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachAppraise);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_MicroteachAppraise">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvMicroteachAppraiseEN> GetObjLstById_MicroteachAppraiseLst_Cache(List<long> arrId_MicroteachAppraise)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachAppraiseEN._CurrTabName_S);
List<clsvMicroteachAppraiseEN> arrvMicroteachAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachAppraiseEN> arrvMicroteachAppraiseObjLst_Sel =
from objvMicroteachAppraiseEN in arrvMicroteachAppraiseObjLst_Cache
where arrId_MicroteachAppraise.Contains(objvMicroteachAppraiseEN.id_MicroteachAppraise)
select objvMicroteachAppraiseEN;
return arrvMicroteachAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachAppraiseEN> GetObjLstById_MicroteachAppraiseLst_WA_Cache(List<long> arrId_MicroteachAppraise)
{
 List<clsvMicroteachAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachAppraiseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachAppraise);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMicroteachAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachAppraiseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMicroteachAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMicroteachAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachAppraiseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMicroteachAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_MicroteachAppraise)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachAppraise"] = lngid_MicroteachAppraise.ToString()
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
 /// <param name = "objvMicroteachAppraiseENS">源对象</param>
 /// <param name = "objvMicroteachAppraiseENT">目标对象</param>
 public static void CopyTo(clsvMicroteachAppraiseEN objvMicroteachAppraiseENS, clsvMicroteachAppraiseEN objvMicroteachAppraiseENT)
{
try
{
objvMicroteachAppraiseENT.id_MicroteachAppraise = objvMicroteachAppraiseENS.id_MicroteachAppraise; //评议流水号
objvMicroteachAppraiseENT.FuncModuleId = objvMicroteachAppraiseENS.FuncModuleId; //功能模块Id
objvMicroteachAppraiseENT.FuncModuleName = objvMicroteachAppraiseENS.FuncModuleName; //功能模块名称
objvMicroteachAppraiseENT.id_MicroteachCase = objvMicroteachAppraiseENS.id_MicroteachCase; //微格教学案例流水号
objvMicroteachAppraiseENT.MicroteachCaseID = objvMicroteachAppraiseENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachAppraiseENT.MicroteachCaseName = objvMicroteachAppraiseENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachAppraiseENT.id_AppraiseType = objvMicroteachAppraiseENS.id_AppraiseType; //评议类型流水号
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
objvMicroteachAppraiseENT.id_XzCollege = objvMicroteachAppraiseENS.id_XzCollege; //学院流水号
objvMicroteachAppraiseENT.CollegeNameA = objvMicroteachAppraiseENS.CollegeNameA; //学院名称简写
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
public static DataTable ToDataTable(List<clsvMicroteachAppraiseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMicroteachAppraiseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMicroteachAppraiseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMicroteachAppraiseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMicroteachAppraiseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMicroteachAppraiseEN.AttributeName)
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
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachAppraiseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachAppraiseWApi没有刷新缓存机制(clsMicroteachAppraiseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeWApi没有刷新缓存机制(clsAppraiseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachAppraise");
//if (arrvMicroteachAppraiseObjLst_Cache == null)
//{
//arrvMicroteachAppraiseObjLst_Cache = await clsvMicroteachAppraiseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMicroteachAppraiseEN._CurrTabName_S);
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
public static List<clsvMicroteachAppraiseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachAppraiseEN._CurrTabName_S);
List<clsvMicroteachAppraiseEN> arrvMicroteachAppraiseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachAppraiseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMicroteachAppraiseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMicroteachAppraise.id_MicroteachAppraise, Type.GetType("System.Int64"));
objDT.Columns.Add(convMicroteachAppraise.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.MicroteachCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.MicroteachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.AppraiseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.AppraiseContent, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.AppraiseDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.AppraiseTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.ExcellentOne, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.ExcellentTwo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.SuggestOne, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.SuggestTwo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.MicroteachAppriseScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMicroteachAppraise.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachAppraise.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.VideoStopTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.IsElite, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachAppraise.IsVisual, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachAppraise.MicroteachCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachAppraise.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachAppraise.CollegeNameA, Type.GetType("System.String"));
foreach (clsvMicroteachAppraiseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMicroteachAppraise.id_MicroteachAppraise] = objInFor[convMicroteachAppraise.id_MicroteachAppraise];
objDR[convMicroteachAppraise.FuncModuleId] = objInFor[convMicroteachAppraise.FuncModuleId];
objDR[convMicroteachAppraise.FuncModuleName] = objInFor[convMicroteachAppraise.FuncModuleName];
objDR[convMicroteachAppraise.id_MicroteachCase] = objInFor[convMicroteachAppraise.id_MicroteachCase];
objDR[convMicroteachAppraise.MicroteachCaseID] = objInFor[convMicroteachAppraise.MicroteachCaseID];
objDR[convMicroteachAppraise.MicroteachCaseName] = objInFor[convMicroteachAppraise.MicroteachCaseName];
objDR[convMicroteachAppraise.id_AppraiseType] = objInFor[convMicroteachAppraise.id_AppraiseType];
objDR[convMicroteachAppraise.AppraiseTypeName] = objInFor[convMicroteachAppraise.AppraiseTypeName];
objDR[convMicroteachAppraise.OwnerId] = objInFor[convMicroteachAppraise.OwnerId];
objDR[convMicroteachAppraise.OwnerName] = objInFor[convMicroteachAppraise.OwnerName];
objDR[convMicroteachAppraise.UserId] = objInFor[convMicroteachAppraise.UserId];
objDR[convMicroteachAppraise.UserName] = objInFor[convMicroteachAppraise.UserName];
objDR[convMicroteachAppraise.AppraiseTheme] = objInFor[convMicroteachAppraise.AppraiseTheme];
objDR[convMicroteachAppraise.AppraiseContent] = objInFor[convMicroteachAppraise.AppraiseContent];
objDR[convMicroteachAppraise.AppraiseDate] = objInFor[convMicroteachAppraise.AppraiseDate];
objDR[convMicroteachAppraise.AppraiseTime] = objInFor[convMicroteachAppraise.AppraiseTime];
objDR[convMicroteachAppraise.ExcellentOne] = objInFor[convMicroteachAppraise.ExcellentOne];
objDR[convMicroteachAppraise.ExcellentTwo] = objInFor[convMicroteachAppraise.ExcellentTwo];
objDR[convMicroteachAppraise.SuggestOne] = objInFor[convMicroteachAppraise.SuggestOne];
objDR[convMicroteachAppraise.SuggestTwo] = objInFor[convMicroteachAppraise.SuggestTwo];
objDR[convMicroteachAppraise.MicroteachAppriseScore] = objInFor[convMicroteachAppraise.MicroteachAppriseScore];
objDR[convMicroteachAppraise.BrowseCount] = objInFor[convMicroteachAppraise.BrowseCount];
objDR[convMicroteachAppraise.CollegeID] = objInFor[convMicroteachAppraise.CollegeID];
objDR[convMicroteachAppraise.CollegeName] = objInFor[convMicroteachAppraise.CollegeName];
objDR[convMicroteachAppraise.VideoStopTime] = objInFor[convMicroteachAppraise.VideoStopTime];
objDR[convMicroteachAppraise.IsElite] = objInFor[convMicroteachAppraise.IsElite];
objDR[convMicroteachAppraise.IsVisual] = objInFor[convMicroteachAppraise.IsVisual];
objDR[convMicroteachAppraise.MicroteachCaseDate] = objInFor[convMicroteachAppraise.MicroteachCaseDate];
objDR[convMicroteachAppraise.OwnerNameWithId] = objInFor[convMicroteachAppraise.OwnerNameWithId];
objDR[convMicroteachAppraise.UserNameWithUserId] = objInFor[convMicroteachAppraise.UserNameWithUserId];
objDR[convMicroteachAppraise.BrowseCount4Case] = objInFor[convMicroteachAppraise.BrowseCount4Case];
objDR[convMicroteachAppraise.id_XzCollege] = objInFor[convMicroteachAppraise.id_XzCollege];
objDR[convMicroteachAppraise.CollegeNameA] = objInFor[convMicroteachAppraise.CollegeNameA];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}