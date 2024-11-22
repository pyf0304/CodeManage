
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCaseQuantitySenateBL
 表名:vTeachingCaseResCaseQuantitySenate(01120450)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学案例资源(TeachingCaseResLib)
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
public static class  clsvTeachingCaseResCaseQuantitySenateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN GetObj(this K_IdmicroteachCaseQuantitySenate_vTeachingCaseResCaseQuantitySenate myKey)
{
clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = clsvTeachingCaseResCaseQuantitySenateBL.vTeachingCaseResCaseQuantitySenateDA.GetObjByIdmicroteachCaseQuantitySenate(myKey.Value);
return objvTeachingCaseResCaseQuantitySenateEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUserTypeName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUserTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convTeachingCaseResCaseQuantitySenate.UserTypeName);
}
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.UserTypeName) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.UserTypeName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserTypeName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetIdmicroteachCaseQuantitySenate(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, long lngIdmicroteachCaseQuantitySenate, string strComparisonOp="")
	{
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = lngIdmicroteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetFuncModuleId(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convTeachingCaseResCaseQuantitySenate.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convTeachingCaseResCaseQuantitySenate.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convTeachingCaseResCaseQuantitySenate.FuncModuleId);
}
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.FuncModuleId) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.FuncModuleId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.FuncModuleId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetFuncModuleName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convTeachingCaseResCaseQuantitySenate.FuncModuleName);
}
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.FuncModuleName) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.FuncModuleName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.FuncModuleName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetIdMicroteachCase(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convTeachingCaseResCaseQuantitySenate.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convTeachingCaseResCaseQuantitySenate.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convTeachingCaseResCaseQuantitySenate.IdMicroteachCase);
}
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.IdMicroteachCase) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.IdMicroteachCase, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetIdTeachingCaseResCase(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strIdTeachingCaseResCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingCaseResCase, 8, convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingCaseResCase, 8, convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase);
}
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = strIdTeachingCaseResCase; //教学案例资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseID(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseID, 8, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseID, 8, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID);
}
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = strTeachingCaseResCaseID; //教学案例资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseName, 100, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName);
}
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = strTeachingCaseResCaseName; //教学案例资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseTheme(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTheme, 200, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme);
}
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = strTeachingCaseResCaseTheme; //教学案例资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseDate(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDate, 8, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDate, 8, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate);
}
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = strTeachingCaseResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseTime(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTime, 6, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTime, 6, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime);
}
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = strTeachingCaseResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseDateIn(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn);
}
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = strTeachingCaseResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseTimeIn(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn);
}
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = strTeachingCaseResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseTypeName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTypeName, 30, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName);
}
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = strTeachingCaseResCaseTypeName; //教学案例资源案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetOwnerId(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convTeachingCaseResCaseQuantitySenate.OwnerId);
}
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.OwnerId) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.OwnerId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.OwnerId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetOwnerName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convTeachingCaseResCaseQuantitySenate.OwnerName);
}
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.OwnerName) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.OwnerName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.OwnerName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetOwnerNameWithId(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convTeachingCaseResCaseQuantitySenate.OwnerNameWithId);
}
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.OwnerNameWithId) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.OwnerNameWithId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetIsDualVideo(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.IsDualVideo) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.IsDualVideo, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IsDualVideo] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetIdXzCollege(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convTeachingCaseResCaseQuantitySenate.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convTeachingCaseResCaseQuantitySenate.IdXzCollege);
}
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.IdXzCollege) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.IdXzCollege, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IdXzCollege] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetCollegeID(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convTeachingCaseResCaseQuantitySenate.CollegeID);
}
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.CollegeID) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.CollegeID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CollegeID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetCollegeName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachingCaseResCaseQuantitySenate.CollegeName);
}
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.CollegeName) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.CollegeName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CollegeName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetIdXzMajor(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convTeachingCaseResCaseQuantitySenate.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convTeachingCaseResCaseQuantitySenate.IdXzMajor);
}
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.IdXzMajor) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.IdXzMajor, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IdXzMajor] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetMajorID(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convTeachingCaseResCaseQuantitySenate.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convTeachingCaseResCaseQuantitySenate.MajorID);
}
objvTeachingCaseResCaseQuantitySenateEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.MajorID) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.MajorID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.MajorID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetMajorName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convTeachingCaseResCaseQuantitySenate.MajorName);
}
objvTeachingCaseResCaseQuantitySenateEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.MajorName) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.MajorName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.MajorName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetCourseId(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convTeachingCaseResCaseQuantitySenate.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convTeachingCaseResCaseQuantitySenate.CourseId);
}
objvTeachingCaseResCaseQuantitySenateEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.CourseId) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.CourseId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CourseId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetCourseCode(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convTeachingCaseResCaseQuantitySenate.CourseCode);
}
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.CourseCode) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.CourseCode, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CourseCode] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetCourseName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convTeachingCaseResCaseQuantitySenate.CourseName);
}
objvTeachingCaseResCaseQuantitySenateEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.CourseName) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.CourseName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CourseName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetViewCount(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, int? intViewCount, string strComparisonOp="")
	{
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.ViewCount) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.ViewCount, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.ViewCount] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetIsShow(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, bool bolIsShow, string strComparisonOp="")
	{
objvTeachingCaseResCaseQuantitySenateEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.IsShow) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.IsShow, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IsShow] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetDownloadNumber(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, int? intDownloadNumber, string strComparisonOp="")
	{
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.DownloadNumber) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.DownloadNumber, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.DownloadNumber] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetFileIntegration(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, int? intFileIntegration, string strComparisonOp="")
	{
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.FileIntegration) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.FileIntegration, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.FileIntegration] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetLikeCount(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, long? lngLikeCount, string strComparisonOp="")
	{
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.LikeCount) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.LikeCount, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.LikeCount] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetCollectionCount(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.CollectionCount) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.CollectionCount, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CollectionCount] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetCollegeNameA(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeachingCaseResCaseQuantitySenate.CollegeNameA);
}
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.CollegeNameA) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.CollegeNameA, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CollegeNameA] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetIdAppraiseType(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strIdAppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdAppraiseType, convTeachingCaseResCaseQuantitySenate.IdAppraiseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAppraiseType, 4, convTeachingCaseResCaseQuantitySenate.IdAppraiseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAppraiseType, 4, convTeachingCaseResCaseQuantitySenate.IdAppraiseType);
}
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = strIdAppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.IdAppraiseType) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.IdAppraiseType, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IdAppraiseType] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetAppraiseTypeName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convTeachingCaseResCaseQuantitySenate.AppraiseTypeName);
}
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.AppraiseTypeName) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.AppraiseTypeName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetSenateTheme(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convTeachingCaseResCaseQuantitySenate.SenateTheme);
}
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = strSenateTheme; //量化评价主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.SenateTheme) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.SenateTheme, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateTheme] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetSenateContent(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convTeachingCaseResCaseQuantitySenate.SenateContent);
}
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = strSenateContent; //评价内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.SenateContent) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.SenateContent, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateContent] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetSenateTotalScore(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, float fltSenateTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltSenateTotalScore, convTeachingCaseResCaseQuantitySenate.SenateTotalScore);
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = fltSenateTotalScore; //评价分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.SenateTotalScore) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.SenateTotalScore, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateTotalScore] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetSenateDate(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convTeachingCaseResCaseQuantitySenate.SenateDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convTeachingCaseResCaseQuantitySenate.SenateDate);
}
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.SenateDate) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.SenateDate, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateDate] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetSenateTime(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convTeachingCaseResCaseQuantitySenate.SenateTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convTeachingCaseResCaseQuantitySenate.SenateTime);
}
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = strSenateTime; //评价时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.SenateTime) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.SenateTime, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateTime] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetSenateIp(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSenateIp, convTeachingCaseResCaseQuantitySenate.SenateIp);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateIp, 50, convTeachingCaseResCaseQuantitySenate.SenateIp);
}
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = strSenateIp; //评议Ip
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.SenateIp) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.SenateIp, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateIp] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetBrowseCount(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, int? intBrowseCount, string strComparisonOp="")
	{
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.BrowseCount) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.BrowseCount, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.BrowseCount] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetIdSenateGaugeVersion(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeVersion, convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion);
}
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID);
}
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName);
}
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetsenateGaugeVersionTtlScore(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUserId(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convTeachingCaseResCaseQuantitySenate.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convTeachingCaseResCaseQuantitySenate.UserId);
}
objvTeachingCaseResCaseQuantitySenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.UserId) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.UserId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUserNameWithUserId(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convTeachingCaseResCaseQuantitySenate.UserNameWithUserId);
}
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.UserNameWithUserId) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.UserNameWithUserId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUserName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convTeachingCaseResCaseQuantitySenate.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convTeachingCaseResCaseQuantitySenate.UserName);
}
objvTeachingCaseResCaseQuantitySenateEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.UserName) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.UserName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUserKindId(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convTeachingCaseResCaseQuantitySenate.UserKindId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convTeachingCaseResCaseQuantitySenate.UserKindId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convTeachingCaseResCaseQuantitySenate.UserKindId);
}
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.UserKindId) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.UserKindId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserKindId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUserKindName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUserKindName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convTeachingCaseResCaseQuantitySenate.UserKindName);
}
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.UserKindName) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.UserKindName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserKindName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUpdUser(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTeachingCaseResCaseQuantitySenate.UpdUser);
}
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.UpdUser) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.UpdUser, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UpdUser] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetMemo(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingCaseResCaseQuantitySenate.Memo);
}
objvTeachingCaseResCaseQuantitySenateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.Memo) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.Memo, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.Memo] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUpdUserName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convTeachingCaseResCaseQuantitySenate.UpdUserName);
}
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = strUpdUserName; //UpdUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.UpdUserName) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.UpdUserName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UpdUserName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateENS, clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateENT)
{
try
{
objvTeachingCaseResCaseQuantitySenateENT.UserTypeName = objvTeachingCaseResCaseQuantitySenateENS.UserTypeName; //用户类型名称
objvTeachingCaseResCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvTeachingCaseResCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateENT.FuncModuleId = objvTeachingCaseResCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvTeachingCaseResCaseQuantitySenateENT.FuncModuleName = objvTeachingCaseResCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvTeachingCaseResCaseQuantitySenateENT.IdMicroteachCase = objvTeachingCaseResCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateENT.IdTeachingCaseResCase = objvTeachingCaseResCaseQuantitySenateENS.IdTeachingCaseResCase; //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseID = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseID; //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseName = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseTheme = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseDate = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseDate; //视频资源日期
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseTime = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTime; //视频资源时间
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseDateIn = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseDateIn; //案例入库日期
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseTimeIn = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTimeIn; //案例入库时间
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseTypeName = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateENT.OwnerId = objvTeachingCaseResCaseQuantitySenateENS.OwnerId; //拥有者Id
objvTeachingCaseResCaseQuantitySenateENT.OwnerName = objvTeachingCaseResCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvTeachingCaseResCaseQuantitySenateENT.OwnerNameWithId = objvTeachingCaseResCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateENT.IsDualVideo = objvTeachingCaseResCaseQuantitySenateENS.IsDualVideo; //是否双视频
objvTeachingCaseResCaseQuantitySenateENT.IdXzCollege = objvTeachingCaseResCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvTeachingCaseResCaseQuantitySenateENT.CollegeID = objvTeachingCaseResCaseQuantitySenateENS.CollegeID; //学院ID
objvTeachingCaseResCaseQuantitySenateENT.CollegeName = objvTeachingCaseResCaseQuantitySenateENS.CollegeName; //学院名称
objvTeachingCaseResCaseQuantitySenateENT.IdXzMajor = objvTeachingCaseResCaseQuantitySenateENS.IdXzMajor; //专业流水号
objvTeachingCaseResCaseQuantitySenateENT.MajorID = objvTeachingCaseResCaseQuantitySenateENS.MajorID; //专业ID
objvTeachingCaseResCaseQuantitySenateENT.MajorName = objvTeachingCaseResCaseQuantitySenateENS.MajorName; //专业名称
objvTeachingCaseResCaseQuantitySenateENT.CourseId = objvTeachingCaseResCaseQuantitySenateENS.CourseId; //课程Id
objvTeachingCaseResCaseQuantitySenateENT.CourseCode = objvTeachingCaseResCaseQuantitySenateENS.CourseCode; //课程代码
objvTeachingCaseResCaseQuantitySenateENT.CourseName = objvTeachingCaseResCaseQuantitySenateENS.CourseName; //课程名称
objvTeachingCaseResCaseQuantitySenateENT.ViewCount = objvTeachingCaseResCaseQuantitySenateENS.ViewCount; //浏览量
objvTeachingCaseResCaseQuantitySenateENT.IsShow = objvTeachingCaseResCaseQuantitySenateENS.IsShow; //是否启用
objvTeachingCaseResCaseQuantitySenateENT.DownloadNumber = objvTeachingCaseResCaseQuantitySenateENS.DownloadNumber; //下载数目
objvTeachingCaseResCaseQuantitySenateENT.FileIntegration = objvTeachingCaseResCaseQuantitySenateENS.FileIntegration; //文件积分
objvTeachingCaseResCaseQuantitySenateENT.LikeCount = objvTeachingCaseResCaseQuantitySenateENS.LikeCount; //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateENT.CollectionCount = objvTeachingCaseResCaseQuantitySenateENS.CollectionCount; //收藏数量
objvTeachingCaseResCaseQuantitySenateENT.CollegeNameA = objvTeachingCaseResCaseQuantitySenateENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCaseQuantitySenateENT.IdAppraiseType = objvTeachingCaseResCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvTeachingCaseResCaseQuantitySenateENT.AppraiseTypeName = objvTeachingCaseResCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvTeachingCaseResCaseQuantitySenateENT.SenateTheme = objvTeachingCaseResCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvTeachingCaseResCaseQuantitySenateENT.SenateContent = objvTeachingCaseResCaseQuantitySenateENS.SenateContent; //评价内容
objvTeachingCaseResCaseQuantitySenateENT.SenateTotalScore = objvTeachingCaseResCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvTeachingCaseResCaseQuantitySenateENT.SenateDate = objvTeachingCaseResCaseQuantitySenateENS.SenateDate; //评价日期
objvTeachingCaseResCaseQuantitySenateENT.SenateTime = objvTeachingCaseResCaseQuantitySenateENS.SenateTime; //评价时间
objvTeachingCaseResCaseQuantitySenateENT.SenateIp = objvTeachingCaseResCaseQuantitySenateENS.SenateIp; //评议Ip
objvTeachingCaseResCaseQuantitySenateENT.BrowseCount = objvTeachingCaseResCaseQuantitySenateENS.BrowseCount; //浏览次数
objvTeachingCaseResCaseQuantitySenateENT.IdSenateGaugeVersion = objvTeachingCaseResCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateENT.senateGaugeVersionID = objvTeachingCaseResCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateENT.senateGaugeVersionName = objvTeachingCaseResCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvTeachingCaseResCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateENT.UserId = objvTeachingCaseResCaseQuantitySenateENS.UserId; //用户ID
objvTeachingCaseResCaseQuantitySenateENT.UserNameWithUserId = objvTeachingCaseResCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateENT.UserName = objvTeachingCaseResCaseQuantitySenateENS.UserName; //用户名
objvTeachingCaseResCaseQuantitySenateENT.UserKindId = objvTeachingCaseResCaseQuantitySenateENS.UserKindId; //用户类别Id
objvTeachingCaseResCaseQuantitySenateENT.UserKindName = objvTeachingCaseResCaseQuantitySenateENS.UserKindName; //用户类别名
objvTeachingCaseResCaseQuantitySenateENT.UpdUser = objvTeachingCaseResCaseQuantitySenateENS.UpdUser; //修改人
objvTeachingCaseResCaseQuantitySenateENT.Memo = objvTeachingCaseResCaseQuantitySenateENS.Memo; //备注
objvTeachingCaseResCaseQuantitySenateENT.UpdUserName = objvTeachingCaseResCaseQuantitySenateENS.UpdUserName; //UpdUserName
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
 /// <param name = "objvTeachingCaseResCaseQuantitySenateENS">源对象</param>
 /// <returns>目标对象=>clsvTeachingCaseResCaseQuantitySenateEN:objvTeachingCaseResCaseQuantitySenateENT</returns>
 public static clsvTeachingCaseResCaseQuantitySenateEN CopyTo(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateENS)
{
try
{
 clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateENT = new clsvTeachingCaseResCaseQuantitySenateEN()
{
UserTypeName = objvTeachingCaseResCaseQuantitySenateENS.UserTypeName, //用户类型名称
IdmicroteachCaseQuantitySenate = objvTeachingCaseResCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate, //微格量化评价流水号
FuncModuleId = objvTeachingCaseResCaseQuantitySenateENS.FuncModuleId, //功能模块Id
FuncModuleName = objvTeachingCaseResCaseQuantitySenateENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvTeachingCaseResCaseQuantitySenateENS.IdMicroteachCase, //微格教学案例流水号
IdTeachingCaseResCase = objvTeachingCaseResCaseQuantitySenateENS.IdTeachingCaseResCase, //教学案例资源案例流水号
TeachingCaseResCaseID = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseID, //教学案例资源案例ID
TeachingCaseResCaseName = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseName, //教学案例资源案例名称
TeachingCaseResCaseTheme = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTheme, //教学案例资源案例主题词
TeachingCaseResCaseDate = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseDate, //视频资源日期
TeachingCaseResCaseTime = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTime, //视频资源时间
TeachingCaseResCaseDateIn = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseDateIn, //案例入库日期
TeachingCaseResCaseTimeIn = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTimeIn, //案例入库时间
TeachingCaseResCaseTypeName = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTypeName, //教学案例资源案例类型名称
OwnerId = objvTeachingCaseResCaseQuantitySenateENS.OwnerId, //拥有者Id
OwnerName = objvTeachingCaseResCaseQuantitySenateENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvTeachingCaseResCaseQuantitySenateENS.OwnerNameWithId, //拥有者名称附Id
IsDualVideo = objvTeachingCaseResCaseQuantitySenateENS.IsDualVideo, //是否双视频
IdXzCollege = objvTeachingCaseResCaseQuantitySenateENS.IdXzCollege, //学院流水号
CollegeID = objvTeachingCaseResCaseQuantitySenateENS.CollegeID, //学院ID
CollegeName = objvTeachingCaseResCaseQuantitySenateENS.CollegeName, //学院名称
IdXzMajor = objvTeachingCaseResCaseQuantitySenateENS.IdXzMajor, //专业流水号
MajorID = objvTeachingCaseResCaseQuantitySenateENS.MajorID, //专业ID
MajorName = objvTeachingCaseResCaseQuantitySenateENS.MajorName, //专业名称
CourseId = objvTeachingCaseResCaseQuantitySenateENS.CourseId, //课程Id
CourseCode = objvTeachingCaseResCaseQuantitySenateENS.CourseCode, //课程代码
CourseName = objvTeachingCaseResCaseQuantitySenateENS.CourseName, //课程名称
ViewCount = objvTeachingCaseResCaseQuantitySenateENS.ViewCount, //浏览量
IsShow = objvTeachingCaseResCaseQuantitySenateENS.IsShow, //是否启用
DownloadNumber = objvTeachingCaseResCaseQuantitySenateENS.DownloadNumber, //下载数目
FileIntegration = objvTeachingCaseResCaseQuantitySenateENS.FileIntegration, //文件积分
LikeCount = objvTeachingCaseResCaseQuantitySenateENS.LikeCount, //资源喜欢数量
CollectionCount = objvTeachingCaseResCaseQuantitySenateENS.CollectionCount, //收藏数量
CollegeNameA = objvTeachingCaseResCaseQuantitySenateENS.CollegeNameA, //学院名称简写
IdAppraiseType = objvTeachingCaseResCaseQuantitySenateENS.IdAppraiseType, //评议类型流水号
AppraiseTypeName = objvTeachingCaseResCaseQuantitySenateENS.AppraiseTypeName, //评议类型名称
SenateTheme = objvTeachingCaseResCaseQuantitySenateENS.SenateTheme, //量化评价主题
SenateContent = objvTeachingCaseResCaseQuantitySenateENS.SenateContent, //评价内容
SenateTotalScore = objvTeachingCaseResCaseQuantitySenateENS.SenateTotalScore, //评价分数
SenateDate = objvTeachingCaseResCaseQuantitySenateENS.SenateDate, //评价日期
SenateTime = objvTeachingCaseResCaseQuantitySenateENS.SenateTime, //评价时间
SenateIp = objvTeachingCaseResCaseQuantitySenateENS.SenateIp, //评议Ip
BrowseCount = objvTeachingCaseResCaseQuantitySenateENS.BrowseCount, //浏览次数
IdSenateGaugeVersion = objvTeachingCaseResCaseQuantitySenateENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvTeachingCaseResCaseQuantitySenateENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvTeachingCaseResCaseQuantitySenateENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvTeachingCaseResCaseQuantitySenateENS.senateGaugeVersionTtlScore, //评价量表版本总分
UserId = objvTeachingCaseResCaseQuantitySenateENS.UserId, //用户ID
UserNameWithUserId = objvTeachingCaseResCaseQuantitySenateENS.UserNameWithUserId, //UserNameWithUserId
UserName = objvTeachingCaseResCaseQuantitySenateENS.UserName, //用户名
UserKindId = objvTeachingCaseResCaseQuantitySenateENS.UserKindId, //用户类别Id
UserKindName = objvTeachingCaseResCaseQuantitySenateENS.UserKindName, //用户类别名
UpdUser = objvTeachingCaseResCaseQuantitySenateENS.UpdUser, //修改人
Memo = objvTeachingCaseResCaseQuantitySenateENS.Memo, //备注
UpdUserName = objvTeachingCaseResCaseQuantitySenateENS.UpdUserName, //UpdUserName
};
 return objvTeachingCaseResCaseQuantitySenateENT;
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
public static void CheckProperty4Condition(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN)
{
 clsvTeachingCaseResCaseQuantitySenateBL.vTeachingCaseResCaseQuantitySenateDA.CheckProperty4Condition(objvTeachingCaseResCaseQuantitySenateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UserTypeName) == true)
{
string strComparisonOpUserTypeName = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UserTypeName, objvTeachingCaseResCaseQuantitySenateCond.UserTypeName, strComparisonOpUserTypeName);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate) == true)
{
string strComparisonOpIdmicroteachCaseQuantitySenate = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate, objvTeachingCaseResCaseQuantitySenateCond.IdmicroteachCaseQuantitySenate, strComparisonOpIdmicroteachCaseQuantitySenate);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.FuncModuleId, objvTeachingCaseResCaseQuantitySenateCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.FuncModuleName, objvTeachingCaseResCaseQuantitySenateCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.IdMicroteachCase, objvTeachingCaseResCaseQuantitySenateCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase) == true)
{
string strComparisonOpIdTeachingCaseResCase = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase, objvTeachingCaseResCaseQuantitySenateCond.IdTeachingCaseResCase, strComparisonOpIdTeachingCaseResCase);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID) == true)
{
string strComparisonOpTeachingCaseResCaseID = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID, objvTeachingCaseResCaseQuantitySenateCond.TeachingCaseResCaseID, strComparisonOpTeachingCaseResCaseID);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName) == true)
{
string strComparisonOpTeachingCaseResCaseName = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName, objvTeachingCaseResCaseQuantitySenateCond.TeachingCaseResCaseName, strComparisonOpTeachingCaseResCaseName);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme) == true)
{
string strComparisonOpTeachingCaseResCaseTheme = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme, objvTeachingCaseResCaseQuantitySenateCond.TeachingCaseResCaseTheme, strComparisonOpTeachingCaseResCaseTheme);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate) == true)
{
string strComparisonOpTeachingCaseResCaseDate = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate, objvTeachingCaseResCaseQuantitySenateCond.TeachingCaseResCaseDate, strComparisonOpTeachingCaseResCaseDate);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime) == true)
{
string strComparisonOpTeachingCaseResCaseTime = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime, objvTeachingCaseResCaseQuantitySenateCond.TeachingCaseResCaseTime, strComparisonOpTeachingCaseResCaseTime);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn) == true)
{
string strComparisonOpTeachingCaseResCaseDateIn = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn, objvTeachingCaseResCaseQuantitySenateCond.TeachingCaseResCaseDateIn, strComparisonOpTeachingCaseResCaseDateIn);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn) == true)
{
string strComparisonOpTeachingCaseResCaseTimeIn = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn, objvTeachingCaseResCaseQuantitySenateCond.TeachingCaseResCaseTimeIn, strComparisonOpTeachingCaseResCaseTimeIn);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName) == true)
{
string strComparisonOpTeachingCaseResCaseTypeName = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName, objvTeachingCaseResCaseQuantitySenateCond.TeachingCaseResCaseTypeName, strComparisonOpTeachingCaseResCaseTypeName);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.OwnerId) == true)
{
string strComparisonOpOwnerId = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.OwnerId, objvTeachingCaseResCaseQuantitySenateCond.OwnerId, strComparisonOpOwnerId);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.OwnerName) == true)
{
string strComparisonOpOwnerName = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.OwnerName, objvTeachingCaseResCaseQuantitySenateCond.OwnerName, strComparisonOpOwnerName);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.OwnerNameWithId, objvTeachingCaseResCaseQuantitySenateCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.IsDualVideo) == true)
{
if (objvTeachingCaseResCaseQuantitySenateCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCaseQuantitySenate.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCaseQuantitySenate.IsDualVideo);
}
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.IdXzCollege, objvTeachingCaseResCaseQuantitySenateCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOpCollegeID = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.CollegeID, objvTeachingCaseResCaseQuantitySenateCond.CollegeID, strComparisonOpCollegeID);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOpCollegeName = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.CollegeName, objvTeachingCaseResCaseQuantitySenateCond.CollegeName, strComparisonOpCollegeName);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.IdXzMajor, objvTeachingCaseResCaseQuantitySenateCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.MajorID) == true)
{
string strComparisonOpMajorID = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.MajorID, objvTeachingCaseResCaseQuantitySenateCond.MajorID, strComparisonOpMajorID);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.MajorName) == true)
{
string strComparisonOpMajorName = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.MajorName, objvTeachingCaseResCaseQuantitySenateCond.MajorName, strComparisonOpMajorName);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.CourseId) == true)
{
string strComparisonOpCourseId = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.CourseId, objvTeachingCaseResCaseQuantitySenateCond.CourseId, strComparisonOpCourseId);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.CourseCode) == true)
{
string strComparisonOpCourseCode = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.CourseCode, objvTeachingCaseResCaseQuantitySenateCond.CourseCode, strComparisonOpCourseCode);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.CourseName) == true)
{
string strComparisonOpCourseName = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.CourseName, objvTeachingCaseResCaseQuantitySenateCond.CourseName, strComparisonOpCourseName);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.ViewCount) == true)
{
string strComparisonOpViewCount = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.ViewCount, objvTeachingCaseResCaseQuantitySenateCond.ViewCount, strComparisonOpViewCount);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.IsShow) == true)
{
if (objvTeachingCaseResCaseQuantitySenateCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCaseQuantitySenate.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCaseQuantitySenate.IsShow);
}
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.DownloadNumber, objvTeachingCaseResCaseQuantitySenateCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.FileIntegration, objvTeachingCaseResCaseQuantitySenateCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.LikeCount) == true)
{
string strComparisonOpLikeCount = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.LikeCount, objvTeachingCaseResCaseQuantitySenateCond.LikeCount, strComparisonOpLikeCount);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.CollectionCount, objvTeachingCaseResCaseQuantitySenateCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.CollegeNameA, objvTeachingCaseResCaseQuantitySenateCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.IdAppraiseType) == true)
{
string strComparisonOpIdAppraiseType = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IdAppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.IdAppraiseType, objvTeachingCaseResCaseQuantitySenateCond.IdAppraiseType, strComparisonOpIdAppraiseType);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOpAppraiseTypeName = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.AppraiseTypeName, objvTeachingCaseResCaseQuantitySenateCond.AppraiseTypeName, strComparisonOpAppraiseTypeName);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.SenateTheme) == true)
{
string strComparisonOpSenateTheme = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.SenateTheme, objvTeachingCaseResCaseQuantitySenateCond.SenateTheme, strComparisonOpSenateTheme);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.SenateContent) == true)
{
string strComparisonOpSenateContent = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.SenateContent, objvTeachingCaseResCaseQuantitySenateCond.SenateContent, strComparisonOpSenateContent);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOpSenateTotalScore = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.SenateTotalScore, objvTeachingCaseResCaseQuantitySenateCond.SenateTotalScore, strComparisonOpSenateTotalScore);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.SenateDate) == true)
{
string strComparisonOpSenateDate = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.SenateDate, objvTeachingCaseResCaseQuantitySenateCond.SenateDate, strComparisonOpSenateDate);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.SenateTime) == true)
{
string strComparisonOpSenateTime = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.SenateTime, objvTeachingCaseResCaseQuantitySenateCond.SenateTime, strComparisonOpSenateTime);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.SenateIp) == true)
{
string strComparisonOpSenateIp = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.SenateIp, objvTeachingCaseResCaseQuantitySenateCond.SenateIp, strComparisonOpSenateIp);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.BrowseCount, objvTeachingCaseResCaseQuantitySenateCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion, objvTeachingCaseResCaseQuantitySenateCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID, objvTeachingCaseResCaseQuantitySenateCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName, objvTeachingCaseResCaseQuantitySenateCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore, objvTeachingCaseResCaseQuantitySenateCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UserId) == true)
{
string strComparisonOpUserId = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UserId, objvTeachingCaseResCaseQuantitySenateCond.UserId, strComparisonOpUserId);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOpUserNameWithUserId = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UserNameWithUserId, objvTeachingCaseResCaseQuantitySenateCond.UserNameWithUserId, strComparisonOpUserNameWithUserId);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UserName) == true)
{
string strComparisonOpUserName = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UserName, objvTeachingCaseResCaseQuantitySenateCond.UserName, strComparisonOpUserName);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UserKindId) == true)
{
string strComparisonOpUserKindId = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UserKindId, objvTeachingCaseResCaseQuantitySenateCond.UserKindId, strComparisonOpUserKindId);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UserKindName) == true)
{
string strComparisonOpUserKindName = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UserKindName, objvTeachingCaseResCaseQuantitySenateCond.UserKindName, strComparisonOpUserKindName);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UpdUser) == true)
{
string strComparisonOpUpdUser = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UpdUser, objvTeachingCaseResCaseQuantitySenateCond.UpdUser, strComparisonOpUpdUser);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.Memo) == true)
{
string strComparisonOpMemo = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.Memo, objvTeachingCaseResCaseQuantitySenateCond.Memo, strComparisonOpMemo);
}
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UpdUserName) == true)
{
string strComparisonOpUpdUserName = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UpdUserName, objvTeachingCaseResCaseQuantitySenateCond.UpdUserName, strComparisonOpUpdUserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTeachingCaseResCaseQuantitySenate
{
public virtual bool UpdRelaTabDate(long lngIdmicroteachCaseQuantitySenate, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v教学案例资源量化评议(vTeachingCaseResCaseQuantitySenate)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingCaseResCaseQuantitySenateBL
{
public static RelatedActions_vTeachingCaseResCaseQuantitySenate relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTeachingCaseResCaseQuantitySenateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTeachingCaseResCaseQuantitySenateDA vTeachingCaseResCaseQuantitySenateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTeachingCaseResCaseQuantitySenateDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTeachingCaseResCaseQuantitySenateBL()
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
if (string.IsNullOrEmpty(clsvTeachingCaseResCaseQuantitySenateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachingCaseResCaseQuantitySenateEN._ConnectString);
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
public static DataTable GetDataTable_vTeachingCaseResCaseQuantitySenate(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTeachingCaseResCaseQuantitySenateDA.GetDataTable_vTeachingCaseResCaseQuantitySenate(strWhereCond);
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
objDT = vTeachingCaseResCaseQuantitySenateDA.GetDataTable(strWhereCond);
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
objDT = vTeachingCaseResCaseQuantitySenateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTeachingCaseResCaseQuantitySenateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTeachingCaseResCaseQuantitySenateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTeachingCaseResCaseQuantitySenateDA.GetDataTable_Top(objTopPara);
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
objDT = vTeachingCaseResCaseQuantitySenateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTeachingCaseResCaseQuantitySenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTeachingCaseResCaseQuantitySenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstByIdmicroteachCaseQuantitySenateLst(List<long> arrIdmicroteachCaseQuantitySenateLst)
{
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = new List<clsvTeachingCaseResCaseQuantitySenateEN>(); 
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
	clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN();
try
{
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseQuantitySenateEN.MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseQuantitySenateEN.MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseQuantitySenateEN.CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseQuantitySenateEN.CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateEN.UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateEN.UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseQuantitySenateEN.Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdmicroteachCaseQuantitySenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstByIdmicroteachCaseQuantitySenateLstCache(List<long> arrIdmicroteachCaseQuantitySenateLst)
{
string strKey = string.Format("{0}", clsvTeachingCaseResCaseQuantitySenateEN._CurrTabName);
List<clsvTeachingCaseResCaseQuantitySenateEN> arrvTeachingCaseResCaseQuantitySenateObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCaseQuantitySenateEN> arrvTeachingCaseResCaseQuantitySenateObjLst_Sel =
arrvTeachingCaseResCaseQuantitySenateObjLstCache
.Where(x => arrIdmicroteachCaseQuantitySenateLst.Contains(x.IdmicroteachCaseQuantitySenate));
return arrvTeachingCaseResCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = new List<clsvTeachingCaseResCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN();
try
{
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseQuantitySenateEN.MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseQuantitySenateEN.MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseQuantitySenateEN.CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseQuantitySenateEN.CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateEN.UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateEN.UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseQuantitySenateEN.Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseQuantitySenateEN);
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
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = new List<clsvTeachingCaseResCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN();
try
{
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseQuantitySenateEN.MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseQuantitySenateEN.MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseQuantitySenateEN.CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseQuantitySenateEN.CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateEN.UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateEN.UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseQuantitySenateEN.Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTeachingCaseResCaseQuantitySenateEN> GetSubObjLstCache(clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateCond)
{
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCaseQuantitySenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachingCaseResCaseQuantitySenate.AttributeName)
{
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(strFldName) == false) continue;
if (objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString());
}
else
{
if (objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCaseQuantitySenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCaseQuantitySenateCond[strFldName]));
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
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = new List<clsvTeachingCaseResCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN();
try
{
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseQuantitySenateEN.MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseQuantitySenateEN.MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseQuantitySenateEN.CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseQuantitySenateEN.CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateEN.UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateEN.UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseQuantitySenateEN.Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseQuantitySenateEN);
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
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = new List<clsvTeachingCaseResCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN();
try
{
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseQuantitySenateEN.MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseQuantitySenateEN.MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseQuantitySenateEN.CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseQuantitySenateEN.CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateEN.UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateEN.UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseQuantitySenateEN.Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseQuantitySenateEN);
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
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = new List<clsvTeachingCaseResCaseQuantitySenateEN>(); 
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
	clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN();
try
{
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseQuantitySenateEN.MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseQuantitySenateEN.MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseQuantitySenateEN.CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseQuantitySenateEN.CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateEN.UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateEN.UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseQuantitySenateEN.Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseQuantitySenateEN);
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
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = new List<clsvTeachingCaseResCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN();
try
{
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseQuantitySenateEN.MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseQuantitySenateEN.MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseQuantitySenateEN.CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseQuantitySenateEN.CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateEN.UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateEN.UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseQuantitySenateEN.Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = new List<clsvTeachingCaseResCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN();
try
{
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseQuantitySenateEN.MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseQuantitySenateEN.MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseQuantitySenateEN.CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseQuantitySenateEN.CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateEN.UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateEN.UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseQuantitySenateEN.Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseQuantitySenateEN);
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
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = new List<clsvTeachingCaseResCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN();
try
{
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseQuantitySenateEN.MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseQuantitySenateEN.MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseQuantitySenateEN.CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseQuantitySenateEN.CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateEN.UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateEN.UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseQuantitySenateEN.Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = new List<clsvTeachingCaseResCaseQuantitySenateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN();
try
{
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseQuantitySenateEN.MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseQuantitySenateEN.MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseQuantitySenateEN.CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseQuantitySenateEN.CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateEN.UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateEN.UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseQuantitySenateEN.Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseQuantitySenateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTeachingCaseResCaseQuantitySenate(ref clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN)
{
bool bolResult = vTeachingCaseResCaseQuantitySenateDA.GetvTeachingCaseResCaseQuantitySenate(ref objvTeachingCaseResCaseQuantitySenateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = vTeachingCaseResCaseQuantitySenateDA.GetObjByIdmicroteachCaseQuantitySenate(lngIdmicroteachCaseQuantitySenate);
return objvTeachingCaseResCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = vTeachingCaseResCaseQuantitySenateDA.GetFirstObj(strWhereCond);
 return objvTeachingCaseResCaseQuantitySenateEN;
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
public static clsvTeachingCaseResCaseQuantitySenateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = vTeachingCaseResCaseQuantitySenateDA.GetObjByDataRow(objRow);
 return objvTeachingCaseResCaseQuantitySenateEN;
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
public static clsvTeachingCaseResCaseQuantitySenateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = vTeachingCaseResCaseQuantitySenateDA.GetObjByDataRow(objRow);
 return objvTeachingCaseResCaseQuantitySenateEN;
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
 /// <param name = "lstvTeachingCaseResCaseQuantitySenateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenateFromList(long lngIdmicroteachCaseQuantitySenate, List<clsvTeachingCaseResCaseQuantitySenateEN> lstvTeachingCaseResCaseQuantitySenateObjLst)
{
foreach (clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN in lstvTeachingCaseResCaseQuantitySenateObjLst)
{
if (objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate == lngIdmicroteachCaseQuantitySenate)
{
return objvTeachingCaseResCaseQuantitySenateEN;
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
 lngIdmicroteachCaseQuantitySenate = new clsvTeachingCaseResCaseQuantitySenateDA().GetFirstID(strWhereCond);
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
 arrList = vTeachingCaseResCaseQuantitySenateDA.GetID(strWhereCond);
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
bool bolIsExist = vTeachingCaseResCaseQuantitySenateDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vTeachingCaseResCaseQuantitySenateDA.IsExist(lngIdmicroteachCaseQuantitySenate);
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
 bolIsExist = clsvTeachingCaseResCaseQuantitySenateDA.IsExistTable();
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
 bolIsExist = vTeachingCaseResCaseQuantitySenateDA.IsExistTable(strTabName);
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
 /// <param name = "objvTeachingCaseResCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateENS, clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateENT)
{
try
{
objvTeachingCaseResCaseQuantitySenateENT.UserTypeName = objvTeachingCaseResCaseQuantitySenateENS.UserTypeName; //用户类型名称
objvTeachingCaseResCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvTeachingCaseResCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateENT.FuncModuleId = objvTeachingCaseResCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvTeachingCaseResCaseQuantitySenateENT.FuncModuleName = objvTeachingCaseResCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvTeachingCaseResCaseQuantitySenateENT.IdMicroteachCase = objvTeachingCaseResCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateENT.IdTeachingCaseResCase = objvTeachingCaseResCaseQuantitySenateENS.IdTeachingCaseResCase; //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseID = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseID; //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseName = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseTheme = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseDate = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseDate; //视频资源日期
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseTime = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTime; //视频资源时间
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseDateIn = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseDateIn; //案例入库日期
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseTimeIn = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTimeIn; //案例入库时间
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseTypeName = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateENT.OwnerId = objvTeachingCaseResCaseQuantitySenateENS.OwnerId; //拥有者Id
objvTeachingCaseResCaseQuantitySenateENT.OwnerName = objvTeachingCaseResCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvTeachingCaseResCaseQuantitySenateENT.OwnerNameWithId = objvTeachingCaseResCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateENT.IsDualVideo = objvTeachingCaseResCaseQuantitySenateENS.IsDualVideo; //是否双视频
objvTeachingCaseResCaseQuantitySenateENT.IdXzCollege = objvTeachingCaseResCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvTeachingCaseResCaseQuantitySenateENT.CollegeID = objvTeachingCaseResCaseQuantitySenateENS.CollegeID; //学院ID
objvTeachingCaseResCaseQuantitySenateENT.CollegeName = objvTeachingCaseResCaseQuantitySenateENS.CollegeName; //学院名称
objvTeachingCaseResCaseQuantitySenateENT.IdXzMajor = objvTeachingCaseResCaseQuantitySenateENS.IdXzMajor; //专业流水号
objvTeachingCaseResCaseQuantitySenateENT.MajorID = objvTeachingCaseResCaseQuantitySenateENS.MajorID; //专业ID
objvTeachingCaseResCaseQuantitySenateENT.MajorName = objvTeachingCaseResCaseQuantitySenateENS.MajorName; //专业名称
objvTeachingCaseResCaseQuantitySenateENT.CourseId = objvTeachingCaseResCaseQuantitySenateENS.CourseId; //课程Id
objvTeachingCaseResCaseQuantitySenateENT.CourseCode = objvTeachingCaseResCaseQuantitySenateENS.CourseCode; //课程代码
objvTeachingCaseResCaseQuantitySenateENT.CourseName = objvTeachingCaseResCaseQuantitySenateENS.CourseName; //课程名称
objvTeachingCaseResCaseQuantitySenateENT.ViewCount = objvTeachingCaseResCaseQuantitySenateENS.ViewCount; //浏览量
objvTeachingCaseResCaseQuantitySenateENT.IsShow = objvTeachingCaseResCaseQuantitySenateENS.IsShow; //是否启用
objvTeachingCaseResCaseQuantitySenateENT.DownloadNumber = objvTeachingCaseResCaseQuantitySenateENS.DownloadNumber; //下载数目
objvTeachingCaseResCaseQuantitySenateENT.FileIntegration = objvTeachingCaseResCaseQuantitySenateENS.FileIntegration; //文件积分
objvTeachingCaseResCaseQuantitySenateENT.LikeCount = objvTeachingCaseResCaseQuantitySenateENS.LikeCount; //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateENT.CollectionCount = objvTeachingCaseResCaseQuantitySenateENS.CollectionCount; //收藏数量
objvTeachingCaseResCaseQuantitySenateENT.CollegeNameA = objvTeachingCaseResCaseQuantitySenateENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCaseQuantitySenateENT.IdAppraiseType = objvTeachingCaseResCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvTeachingCaseResCaseQuantitySenateENT.AppraiseTypeName = objvTeachingCaseResCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvTeachingCaseResCaseQuantitySenateENT.SenateTheme = objvTeachingCaseResCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvTeachingCaseResCaseQuantitySenateENT.SenateContent = objvTeachingCaseResCaseQuantitySenateENS.SenateContent; //评价内容
objvTeachingCaseResCaseQuantitySenateENT.SenateTotalScore = objvTeachingCaseResCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvTeachingCaseResCaseQuantitySenateENT.SenateDate = objvTeachingCaseResCaseQuantitySenateENS.SenateDate; //评价日期
objvTeachingCaseResCaseQuantitySenateENT.SenateTime = objvTeachingCaseResCaseQuantitySenateENS.SenateTime; //评价时间
objvTeachingCaseResCaseQuantitySenateENT.SenateIp = objvTeachingCaseResCaseQuantitySenateENS.SenateIp; //评议Ip
objvTeachingCaseResCaseQuantitySenateENT.BrowseCount = objvTeachingCaseResCaseQuantitySenateENS.BrowseCount; //浏览次数
objvTeachingCaseResCaseQuantitySenateENT.IdSenateGaugeVersion = objvTeachingCaseResCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateENT.senateGaugeVersionID = objvTeachingCaseResCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateENT.senateGaugeVersionName = objvTeachingCaseResCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvTeachingCaseResCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateENT.UserId = objvTeachingCaseResCaseQuantitySenateENS.UserId; //用户ID
objvTeachingCaseResCaseQuantitySenateENT.UserNameWithUserId = objvTeachingCaseResCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateENT.UserName = objvTeachingCaseResCaseQuantitySenateENS.UserName; //用户名
objvTeachingCaseResCaseQuantitySenateENT.UserKindId = objvTeachingCaseResCaseQuantitySenateENS.UserKindId; //用户类别Id
objvTeachingCaseResCaseQuantitySenateENT.UserKindName = objvTeachingCaseResCaseQuantitySenateENS.UserKindName; //用户类别名
objvTeachingCaseResCaseQuantitySenateENT.UpdUser = objvTeachingCaseResCaseQuantitySenateENS.UpdUser; //修改人
objvTeachingCaseResCaseQuantitySenateENT.Memo = objvTeachingCaseResCaseQuantitySenateENS.Memo; //备注
objvTeachingCaseResCaseQuantitySenateENT.UpdUserName = objvTeachingCaseResCaseQuantitySenateENS.UpdUserName; //UpdUserName
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
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">源简化对象</param>
 public static void SetUpdFlag(clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN)
{
try
{
objvTeachingCaseResCaseQuantitySenateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTeachingCaseResCaseQuantitySenateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.UserTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objvTeachingCaseResCaseQuantitySenateEN.UserTypeName == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.UserTypeName; //用户类型名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase; //教学案例资源案例流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID; //教学案例资源案例ID
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName; //教学案例资源案例名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme; //教学案例资源案例主题词
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate; //视频资源日期
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime; //视频资源时间
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objvTeachingCaseResCaseQuantitySenateEN.OwnerId == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objvTeachingCaseResCaseQuantitySenateEN.OwnerName == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objvTeachingCaseResCaseQuantitySenateEN.CollegeID == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objvTeachingCaseResCaseQuantitySenateEN.CollegeName == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.MajorID = objvTeachingCaseResCaseQuantitySenateEN.MajorID == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.MajorName = objvTeachingCaseResCaseQuantitySenateEN.MajorName == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.CourseId = objvTeachingCaseResCaseQuantitySenateEN.CourseId == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objvTeachingCaseResCaseQuantitySenateEN.CourseCode == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.CourseName = objvTeachingCaseResCaseQuantitySenateEN.CourseName == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objvTeachingCaseResCaseQuantitySenateEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.IsShow = objvTeachingCaseResCaseQuantitySenateEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objvTeachingCaseResCaseQuantitySenateEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objvTeachingCaseResCaseQuantitySenateEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objvTeachingCaseResCaseQuantitySenateEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.IdAppraiseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType; //评议类型流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.AppraiseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName; //评议类型名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.SenateTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objvTeachingCaseResCaseQuantitySenateEN.SenateTheme == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.SenateTheme; //量化评价主题
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.SenateContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objvTeachingCaseResCaseQuantitySenateEN.SenateContent == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.SenateContent; //评价内容
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.SenateTotalScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore; //评价分数
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.SenateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objvTeachingCaseResCaseQuantitySenateEN.SenateDate == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.SenateDate; //评价日期
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.SenateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objvTeachingCaseResCaseQuantitySenateEN.SenateTime == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.SenateTime; //评价时间
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.SenateIp, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objvTeachingCaseResCaseQuantitySenateEN.SenateIp; //评议Ip
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objvTeachingCaseResCaseQuantitySenateEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.UserId = objvTeachingCaseResCaseQuantitySenateEN.UserId; //用户ID
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.UserNameWithUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId; //UserNameWithUserId
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.UserName = objvTeachingCaseResCaseQuantitySenateEN.UserName; //用户名
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.UserKindId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objvTeachingCaseResCaseQuantitySenateEN.UserKindId; //用户类别Id
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.UserKindName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objvTeachingCaseResCaseQuantitySenateEN.UserKindName == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.UserKindName; //用户类别名
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objvTeachingCaseResCaseQuantitySenateEN.UpdUser == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.Memo = objvTeachingCaseResCaseQuantitySenateEN.Memo == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.Memo; //备注
}
if (arrFldSet.Contains(convTeachingCaseResCaseQuantitySenate.UpdUserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objvTeachingCaseResCaseQuantitySenateEN.UpdUserName == "[null]" ? null :  objvTeachingCaseResCaseQuantitySenateEN.UpdUserName; //UpdUserName
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
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN)
{
try
{
if (objvTeachingCaseResCaseQuantitySenateEN.UserTypeName == "[null]") objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = null; //用户类型名称
if (objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName == "[null]") objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = null; //功能模块名称
if (objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase == "[null]") objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = null; //教学案例资源案例流水号
if (objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID == "[null]") objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = null; //教学案例资源案例ID
if (objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName == "[null]") objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = null; //教学案例资源案例名称
if (objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme == "[null]") objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = null; //教学案例资源案例主题词
if (objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate == "[null]") objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = null; //视频资源日期
if (objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime == "[null]") objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = null; //视频资源时间
if (objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn == "[null]") objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = null; //案例入库日期
if (objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn == "[null]") objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = null; //案例入库时间
if (objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName == "[null]") objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = null; //教学案例资源案例类型名称
if (objvTeachingCaseResCaseQuantitySenateEN.OwnerId == "[null]") objvTeachingCaseResCaseQuantitySenateEN.OwnerId = null; //拥有者Id
if (objvTeachingCaseResCaseQuantitySenateEN.OwnerName == "[null]") objvTeachingCaseResCaseQuantitySenateEN.OwnerName = null; //拥有者姓名
if (objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId == "[null]") objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege == "[null]") objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = null; //学院流水号
if (objvTeachingCaseResCaseQuantitySenateEN.CollegeID == "[null]") objvTeachingCaseResCaseQuantitySenateEN.CollegeID = null; //学院ID
if (objvTeachingCaseResCaseQuantitySenateEN.CollegeName == "[null]") objvTeachingCaseResCaseQuantitySenateEN.CollegeName = null; //学院名称
if (objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor == "[null]") objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = null; //专业流水号
if (objvTeachingCaseResCaseQuantitySenateEN.MajorID == "[null]") objvTeachingCaseResCaseQuantitySenateEN.MajorID = null; //专业ID
if (objvTeachingCaseResCaseQuantitySenateEN.MajorName == "[null]") objvTeachingCaseResCaseQuantitySenateEN.MajorName = null; //专业名称
if (objvTeachingCaseResCaseQuantitySenateEN.CourseId == "[null]") objvTeachingCaseResCaseQuantitySenateEN.CourseId = null; //课程Id
if (objvTeachingCaseResCaseQuantitySenateEN.CourseCode == "[null]") objvTeachingCaseResCaseQuantitySenateEN.CourseCode = null; //课程代码
if (objvTeachingCaseResCaseQuantitySenateEN.CourseName == "[null]") objvTeachingCaseResCaseQuantitySenateEN.CourseName = null; //课程名称
if (objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA == "[null]") objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = null; //学院名称简写
if (objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName == "[null]") objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = null; //评议类型名称
if (objvTeachingCaseResCaseQuantitySenateEN.SenateTheme == "[null]") objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = null; //量化评价主题
if (objvTeachingCaseResCaseQuantitySenateEN.SenateContent == "[null]") objvTeachingCaseResCaseQuantitySenateEN.SenateContent = null; //评价内容
if (objvTeachingCaseResCaseQuantitySenateEN.SenateDate == "[null]") objvTeachingCaseResCaseQuantitySenateEN.SenateDate = null; //评价日期
if (objvTeachingCaseResCaseQuantitySenateEN.SenateTime == "[null]") objvTeachingCaseResCaseQuantitySenateEN.SenateTime = null; //评价时间
if (objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID == "[null]") objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName == "[null]") objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId == "[null]") objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = null; //UserNameWithUserId
if (objvTeachingCaseResCaseQuantitySenateEN.UserKindName == "[null]") objvTeachingCaseResCaseQuantitySenateEN.UserKindName = null; //用户类别名
if (objvTeachingCaseResCaseQuantitySenateEN.UpdUser == "[null]") objvTeachingCaseResCaseQuantitySenateEN.UpdUser = null; //修改人
if (objvTeachingCaseResCaseQuantitySenateEN.Memo == "[null]") objvTeachingCaseResCaseQuantitySenateEN.Memo = null; //备注
if (objvTeachingCaseResCaseQuantitySenateEN.UpdUserName == "[null]") objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = null; //UpdUserName
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
public static void CheckProperty4Condition(clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN)
{
 vTeachingCaseResCaseQuantitySenateDA.CheckProperty4Condition(objvTeachingCaseResCaseQuantitySenateEN);
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
if (clsUserTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeBL没有刷新缓存机制(clsUserTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindBL没有刷新缓存机制(clsUserKindBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingCaseResCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseBL没有刷新缓存机制(clsTeachingCaseResCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingCaseResCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseTypeBL没有刷新缓存机制(clsTeachingCaseResCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeBL没有刷新缓存机制(clscc_ExcellentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeBL没有刷新缓存机制(clsXzDegreeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeBL没有刷新缓存机制(clsXzMajorTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeBL没有刷新缓存机制(clsXzMajorShoolTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdmicroteachCaseQuantitySenate");
//if (arrvTeachingCaseResCaseQuantitySenateObjLstCache == null)
//{
//arrvTeachingCaseResCaseQuantitySenateObjLstCache = vTeachingCaseResCaseQuantitySenateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenateCache(long lngIdmicroteachCaseQuantitySenate)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvTeachingCaseResCaseQuantitySenateEN._CurrTabName);
List<clsvTeachingCaseResCaseQuantitySenateEN> arrvTeachingCaseResCaseQuantitySenateObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCaseQuantitySenateEN> arrvTeachingCaseResCaseQuantitySenateObjLst_Sel =
arrvTeachingCaseResCaseQuantitySenateObjLstCache
.Where(x=> x.IdmicroteachCaseQuantitySenate == lngIdmicroteachCaseQuantitySenate 
);
if (arrvTeachingCaseResCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvTeachingCaseResCaseQuantitySenateEN obj = clsvTeachingCaseResCaseQuantitySenateBL.GetObjByIdmicroteachCaseQuantitySenate(lngIdmicroteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvTeachingCaseResCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetAllvTeachingCaseResCaseQuantitySenateObjLstCache()
{
//获取缓存中的对象列表
List<clsvTeachingCaseResCaseQuantitySenateEN> arrvTeachingCaseResCaseQuantitySenateObjLstCache = GetObjLstCache(); 
return arrvTeachingCaseResCaseQuantitySenateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvTeachingCaseResCaseQuantitySenateEN._CurrTabName);
List<clsvTeachingCaseResCaseQuantitySenateEN> arrvTeachingCaseResCaseQuantitySenateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachingCaseResCaseQuantitySenateObjLstCache;
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
string strKey = string.Format("{0}", clsvTeachingCaseResCaseQuantitySenateEN._CurrTabName);
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
if (strInFldName != convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTeachingCaseResCaseQuantitySenate.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTeachingCaseResCaseQuantitySenate.AttributeName));
throw new Exception(strMsg);
}
var objvTeachingCaseResCaseQuantitySenate = clsvTeachingCaseResCaseQuantitySenateBL.GetObjByIdmicroteachCaseQuantitySenateCache(lngIdmicroteachCaseQuantitySenate);
if (objvTeachingCaseResCaseQuantitySenate == null) return "";
return objvTeachingCaseResCaseQuantitySenate[strOutFldName].ToString();
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
int intRecCount = clsvTeachingCaseResCaseQuantitySenateDA.GetRecCount(strTabName);
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
int intRecCount = clsvTeachingCaseResCaseQuantitySenateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTeachingCaseResCaseQuantitySenateDA.GetRecCount();
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
int intRecCount = clsvTeachingCaseResCaseQuantitySenateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateCond)
{
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCaseQuantitySenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachingCaseResCaseQuantitySenate.AttributeName)
{
if (objvTeachingCaseResCaseQuantitySenateCond.IsUpdated(strFldName) == false) continue;
if (objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString());
}
else
{
if (objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachingCaseResCaseQuantitySenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachingCaseResCaseQuantitySenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCaseQuantitySenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCaseQuantitySenateCond[strFldName]));
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
 List<string> arrList = clsvTeachingCaseResCaseQuantitySenateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTeachingCaseResCaseQuantitySenateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTeachingCaseResCaseQuantitySenateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}