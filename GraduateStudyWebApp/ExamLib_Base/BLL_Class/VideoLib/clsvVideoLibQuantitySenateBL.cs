
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibQuantitySenateBL
 表名:vVideoLibQuantitySenate(01120449)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频库(VideoLib)
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
public static class  clsvVideoLibQuantitySenateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibQuantitySenateEN GetObj(this K_IdmicroteachCaseQuantitySenate_vVideoLibQuantitySenate myKey)
{
clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = clsvVideoLibQuantitySenateBL.vVideoLibQuantitySenateDA.GetObjByIdmicroteachCaseQuantitySenate(myKey.Value);
return objvVideoLibQuantitySenateEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetIdmicroteachCaseQuantitySenate(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, long lngIdmicroteachCaseQuantitySenate, string strComparisonOp="")
	{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = lngIdmicroteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetFuncModuleId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoLibQuantitySenate.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoLibQuantitySenate.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoLibQuantitySenate.FuncModuleId);
}
objvVideoLibQuantitySenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.FuncModuleId) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.FuncModuleId, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.FuncModuleId] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetFuncModuleName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convVideoLibQuantitySenate.FuncModuleName);
}
objvVideoLibQuantitySenateEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.FuncModuleName) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.FuncModuleName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.FuncModuleName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetIdMicroteachCase(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convVideoLibQuantitySenate.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convVideoLibQuantitySenate.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convVideoLibQuantitySenate.IdMicroteachCase);
}
objvVideoLibQuantitySenateEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.IdMicroteachCase) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.IdMicroteachCase, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.IdMicroteachCase] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetIdVideoLib(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strIdVideoLib, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdVideoLib, 8, convVideoLibQuantitySenate.IdVideoLib);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdVideoLib, 8, convVideoLibQuantitySenate.IdVideoLib);
}
objvVideoLibQuantitySenateEN.IdVideoLib = strIdVideoLib; //视频库流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.IdVideoLib) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.IdVideoLib, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.IdVideoLib] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibID(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibID, 8, convVideoLibQuantitySenate.VideoLibID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibID, 8, convVideoLibQuantitySenate.VideoLibID);
}
objvVideoLibQuantitySenateEN.VideoLibID = strVideoLibID; //视频库ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.VideoLibID) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.VideoLibID, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibID] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoLibQuantitySenate.VideoLibName);
}
objvVideoLibQuantitySenateEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.VideoLibName) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.VideoLibName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibTheme(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTheme, 200, convVideoLibQuantitySenate.VideoLibTheme);
}
objvVideoLibQuantitySenateEN.VideoLibTheme = strVideoLibTheme; //视频库主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.VideoLibTheme) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.VideoLibTheme, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibTheme] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibTypeName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTypeName, 30, convVideoLibQuantitySenate.VideoLibTypeName);
}
objvVideoLibQuantitySenateEN.VideoLibTypeName = strVideoLibTypeName; //视频库类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.VideoLibTypeName) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.VideoLibTypeName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibTypeName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibDate(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibDate, 8, convVideoLibQuantitySenate.VideoLibDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibDate, 8, convVideoLibQuantitySenate.VideoLibDate);
}
objvVideoLibQuantitySenateEN.VideoLibDate = strVideoLibDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.VideoLibDate) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.VideoLibDate, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibDate] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibTime(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTime, 6, convVideoLibQuantitySenate.VideoLibTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibTime, 6, convVideoLibQuantitySenate.VideoLibTime);
}
objvVideoLibQuantitySenateEN.VideoLibTime = strVideoLibTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.VideoLibTime) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.VideoLibTime, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibTime] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibDateIn(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibDateIn, 8, convVideoLibQuantitySenate.VideoLibDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibDateIn, 8, convVideoLibQuantitySenate.VideoLibDateIn);
}
objvVideoLibQuantitySenateEN.VideoLibDateIn = strVideoLibDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.VideoLibDateIn) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.VideoLibDateIn, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibDateIn] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibTimeIn(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTimeIn, 6, convVideoLibQuantitySenate.VideoLibTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibTimeIn, 6, convVideoLibQuantitySenate.VideoLibTimeIn);
}
objvVideoLibQuantitySenateEN.VideoLibTimeIn = strVideoLibTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.VideoLibTimeIn) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.VideoLibTimeIn, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibTimeIn] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetOwnerId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convVideoLibQuantitySenate.OwnerId);
}
objvVideoLibQuantitySenateEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.OwnerId) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.OwnerId, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.OwnerId] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetIdXzCollege(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convVideoLibQuantitySenate.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convVideoLibQuantitySenate.IdXzCollege);
}
objvVideoLibQuantitySenateEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.IdXzCollege) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.IdXzCollege, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.IdXzCollege] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetCollegeID(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoLibQuantitySenate.CollegeID);
}
objvVideoLibQuantitySenateEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.CollegeID) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.CollegeID, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.CollegeID] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetCollegeName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoLibQuantitySenate.CollegeName);
}
objvVideoLibQuantitySenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.CollegeName) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.CollegeName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.CollegeName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetCollegeNameA(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoLibQuantitySenate.CollegeNameA);
}
objvVideoLibQuantitySenateEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.CollegeNameA) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.CollegeNameA, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.CollegeNameA] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetViewCount(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, int? intViewCount, string strComparisonOp="")
	{
objvVideoLibQuantitySenateEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.ViewCount) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.ViewCount, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.ViewCount] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetDownloadNumber(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, int? intDownloadNumber, string strComparisonOp="")
	{
objvVideoLibQuantitySenateEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.DownloadNumber) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.DownloadNumber, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.DownloadNumber] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetFileIntegration(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, int? intFileIntegration, string strComparisonOp="")
	{
objvVideoLibQuantitySenateEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.FileIntegration) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.FileIntegration, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.FileIntegration] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetLikeCount(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, long? lngLikeCount, string strComparisonOp="")
	{
objvVideoLibQuantitySenateEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.LikeCount) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.LikeCount, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.LikeCount] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetCollectionCount(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvVideoLibQuantitySenateEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.CollectionCount) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.CollectionCount, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.CollectionCount] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetCourseId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoLibQuantitySenate.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoLibQuantitySenate.CourseId);
}
objvVideoLibQuantitySenateEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.CourseId) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.CourseId, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.CourseId] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetCourseCode(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoLibQuantitySenate.CourseCode);
}
objvVideoLibQuantitySenateEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.CourseCode) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.CourseCode, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.CourseCode] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetCourseName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoLibQuantitySenate.CourseName);
}
objvVideoLibQuantitySenateEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.CourseName) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.CourseName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.CourseName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetOwnerName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convVideoLibQuantitySenate.OwnerName);
}
objvVideoLibQuantitySenateEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.OwnerName) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.OwnerName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.OwnerName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetOwnerNameWithId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convVideoLibQuantitySenate.OwnerNameWithId);
}
objvVideoLibQuantitySenateEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.OwnerNameWithId) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.OwnerNameWithId, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.OwnerNameWithId] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetIdAppraiseType(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strIdAppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdAppraiseType, convVideoLibQuantitySenate.IdAppraiseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAppraiseType, 4, convVideoLibQuantitySenate.IdAppraiseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAppraiseType, 4, convVideoLibQuantitySenate.IdAppraiseType);
}
objvVideoLibQuantitySenateEN.IdAppraiseType = strIdAppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.IdAppraiseType) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.IdAppraiseType, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.IdAppraiseType] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetAppraiseTypeName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convVideoLibQuantitySenate.AppraiseTypeName);
}
objvVideoLibQuantitySenateEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.AppraiseTypeName) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.AppraiseTypeName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.AppraiseTypeName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetSenateTheme(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convVideoLibQuantitySenate.SenateTheme);
}
objvVideoLibQuantitySenateEN.SenateTheme = strSenateTheme; //量化评价主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.SenateTheme) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.SenateTheme, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.SenateTheme] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetSenateContent(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convVideoLibQuantitySenate.SenateContent);
}
objvVideoLibQuantitySenateEN.SenateContent = strSenateContent; //评价内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.SenateContent) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.SenateContent, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.SenateContent] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetSenateTotalScore(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, float fltSenateTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltSenateTotalScore, convVideoLibQuantitySenate.SenateTotalScore);
objvVideoLibQuantitySenateEN.SenateTotalScore = fltSenateTotalScore; //评价分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.SenateTotalScore) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.SenateTotalScore, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.SenateTotalScore] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetSenateDate(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convVideoLibQuantitySenate.SenateDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convVideoLibQuantitySenate.SenateDate);
}
objvVideoLibQuantitySenateEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.SenateDate) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.SenateDate, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.SenateDate] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetSenateTime(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convVideoLibQuantitySenate.SenateTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convVideoLibQuantitySenate.SenateTime);
}
objvVideoLibQuantitySenateEN.SenateTime = strSenateTime; //评价时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.SenateTime) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.SenateTime, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.SenateTime] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetSenateIp(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSenateIp, convVideoLibQuantitySenate.SenateIp);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateIp, 50, convVideoLibQuantitySenate.SenateIp);
}
objvVideoLibQuantitySenateEN.SenateIp = strSenateIp; //评议Ip
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.SenateIp) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.SenateIp, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.SenateIp] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetBrowseCount(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, int? intBrowseCount, string strComparisonOp="")
	{
objvVideoLibQuantitySenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.BrowseCount) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.BrowseCount, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.BrowseCount] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetIdSenateGaugeVersion(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeVersion, convVideoLibQuantitySenate.IdSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convVideoLibQuantitySenate.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convVideoLibQuantitySenate.IdSenateGaugeVersion);
}
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.IdSenateGaugeVersion) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetsenateGaugeVersionID(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convVideoLibQuantitySenate.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convVideoLibQuantitySenate.senateGaugeVersionID);
}
objvVideoLibQuantitySenateEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.senateGaugeVersionID) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.senateGaugeVersionID, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.senateGaugeVersionID] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetsenateGaugeVersionName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convVideoLibQuantitySenate.senateGaugeVersionName);
}
objvVideoLibQuantitySenateEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.senateGaugeVersionName) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.senateGaugeVersionName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.senateGaugeVersionName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetsenateGaugeVersionTtlScore(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.senateGaugeVersionTtlScore) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUserId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convVideoLibQuantitySenate.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convVideoLibQuantitySenate.UserId);
}
objvVideoLibQuantitySenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.UserId) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.UserId, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.UserId] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUserNameWithUserId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convVideoLibQuantitySenate.UserNameWithUserId);
}
objvVideoLibQuantitySenateEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.UserNameWithUserId) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.UserNameWithUserId, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.UserNameWithUserId] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUserName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convVideoLibQuantitySenate.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convVideoLibQuantitySenate.UserName);
}
objvVideoLibQuantitySenateEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.UserName) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.UserName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.UserName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUserKindId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convVideoLibQuantitySenate.UserKindId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convVideoLibQuantitySenate.UserKindId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convVideoLibQuantitySenate.UserKindId);
}
objvVideoLibQuantitySenateEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.UserKindId) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.UserKindId, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.UserKindId] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUserKindName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUserKindName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convVideoLibQuantitySenate.UserKindName);
}
objvVideoLibQuantitySenateEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.UserKindName) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.UserKindName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.UserKindName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUserTypeId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convVideoLibQuantitySenate.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convVideoLibQuantitySenate.UserTypeId);
}
objvVideoLibQuantitySenateEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.UserTypeId) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.UserTypeId, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.UserTypeId] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUserTypeName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUserTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convVideoLibQuantitySenate.UserTypeName);
}
objvVideoLibQuantitySenateEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.UserTypeName) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.UserTypeName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.UserTypeName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUpdUser(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convVideoLibQuantitySenate.UpdUser);
}
objvVideoLibQuantitySenateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.UpdUser) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.UpdUser, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.UpdUser] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetMemo(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoLibQuantitySenate.Memo);
}
objvVideoLibQuantitySenateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.Memo) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.Memo, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.Memo] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUpdUserName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convVideoLibQuantitySenate.UpdUserName);
}
objvVideoLibQuantitySenateEN.UpdUserName = strUpdUserName; //UpdUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.UpdUserName) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.UpdUserName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.UpdUserName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateENS">源对象</param>
 /// <param name = "objvVideoLibQuantitySenateENT">目标对象</param>
 public static void CopyTo(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateENS, clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateENT)
{
try
{
objvVideoLibQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvVideoLibQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvVideoLibQuantitySenateENT.FuncModuleId = objvVideoLibQuantitySenateENS.FuncModuleId; //功能模块Id
objvVideoLibQuantitySenateENT.FuncModuleName = objvVideoLibQuantitySenateENS.FuncModuleName; //功能模块名称
objvVideoLibQuantitySenateENT.IdMicroteachCase = objvVideoLibQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvVideoLibQuantitySenateENT.IdVideoLib = objvVideoLibQuantitySenateENS.IdVideoLib; //视频库流水号
objvVideoLibQuantitySenateENT.VideoLibID = objvVideoLibQuantitySenateENS.VideoLibID; //视频库ID
objvVideoLibQuantitySenateENT.VideoLibName = objvVideoLibQuantitySenateENS.VideoLibName; //视频名称
objvVideoLibQuantitySenateENT.VideoLibTheme = objvVideoLibQuantitySenateENS.VideoLibTheme; //视频库主题词
objvVideoLibQuantitySenateENT.VideoLibTypeName = objvVideoLibQuantitySenateENS.VideoLibTypeName; //视频库类型名称
objvVideoLibQuantitySenateENT.VideoLibDate = objvVideoLibQuantitySenateENS.VideoLibDate; //视频资源日期
objvVideoLibQuantitySenateENT.VideoLibTime = objvVideoLibQuantitySenateENS.VideoLibTime; //视频资源时间
objvVideoLibQuantitySenateENT.VideoLibDateIn = objvVideoLibQuantitySenateENS.VideoLibDateIn; //案例入库日期
objvVideoLibQuantitySenateENT.VideoLibTimeIn = objvVideoLibQuantitySenateENS.VideoLibTimeIn; //案例入库时间
objvVideoLibQuantitySenateENT.OwnerId = objvVideoLibQuantitySenateENS.OwnerId; //拥有者Id
objvVideoLibQuantitySenateENT.IdXzCollege = objvVideoLibQuantitySenateENS.IdXzCollege; //学院流水号
objvVideoLibQuantitySenateENT.CollegeID = objvVideoLibQuantitySenateENS.CollegeID; //学院ID
objvVideoLibQuantitySenateENT.CollegeName = objvVideoLibQuantitySenateENS.CollegeName; //学院名称
objvVideoLibQuantitySenateENT.CollegeNameA = objvVideoLibQuantitySenateENS.CollegeNameA; //学院名称简写
objvVideoLibQuantitySenateENT.ViewCount = objvVideoLibQuantitySenateENS.ViewCount; //浏览量
objvVideoLibQuantitySenateENT.DownloadNumber = objvVideoLibQuantitySenateENS.DownloadNumber; //下载数目
objvVideoLibQuantitySenateENT.FileIntegration = objvVideoLibQuantitySenateENS.FileIntegration; //文件积分
objvVideoLibQuantitySenateENT.LikeCount = objvVideoLibQuantitySenateENS.LikeCount; //资源喜欢数量
objvVideoLibQuantitySenateENT.CollectionCount = objvVideoLibQuantitySenateENS.CollectionCount; //收藏数量
objvVideoLibQuantitySenateENT.CourseId = objvVideoLibQuantitySenateENS.CourseId; //课程Id
objvVideoLibQuantitySenateENT.CourseCode = objvVideoLibQuantitySenateENS.CourseCode; //课程代码
objvVideoLibQuantitySenateENT.CourseName = objvVideoLibQuantitySenateENS.CourseName; //课程名称
objvVideoLibQuantitySenateENT.OwnerName = objvVideoLibQuantitySenateENS.OwnerName; //拥有者姓名
objvVideoLibQuantitySenateENT.OwnerNameWithId = objvVideoLibQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvVideoLibQuantitySenateENT.IdAppraiseType = objvVideoLibQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvVideoLibQuantitySenateENT.AppraiseTypeName = objvVideoLibQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvVideoLibQuantitySenateENT.SenateTheme = objvVideoLibQuantitySenateENS.SenateTheme; //量化评价主题
objvVideoLibQuantitySenateENT.SenateContent = objvVideoLibQuantitySenateENS.SenateContent; //评价内容
objvVideoLibQuantitySenateENT.SenateTotalScore = objvVideoLibQuantitySenateENS.SenateTotalScore; //评价分数
objvVideoLibQuantitySenateENT.SenateDate = objvVideoLibQuantitySenateENS.SenateDate; //评价日期
objvVideoLibQuantitySenateENT.SenateTime = objvVideoLibQuantitySenateENS.SenateTime; //评价时间
objvVideoLibQuantitySenateENT.SenateIp = objvVideoLibQuantitySenateENS.SenateIp; //评议Ip
objvVideoLibQuantitySenateENT.BrowseCount = objvVideoLibQuantitySenateENS.BrowseCount; //浏览次数
objvVideoLibQuantitySenateENT.IdSenateGaugeVersion = objvVideoLibQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvVideoLibQuantitySenateENT.senateGaugeVersionID = objvVideoLibQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvVideoLibQuantitySenateENT.senateGaugeVersionName = objvVideoLibQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLibQuantitySenateENT.senateGaugeVersionTtlScore = objvVideoLibQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoLibQuantitySenateENT.UserId = objvVideoLibQuantitySenateENS.UserId; //用户ID
objvVideoLibQuantitySenateENT.UserNameWithUserId = objvVideoLibQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvVideoLibQuantitySenateENT.UserName = objvVideoLibQuantitySenateENS.UserName; //用户名
objvVideoLibQuantitySenateENT.UserKindId = objvVideoLibQuantitySenateENS.UserKindId; //用户类别Id
objvVideoLibQuantitySenateENT.UserKindName = objvVideoLibQuantitySenateENS.UserKindName; //用户类别名
objvVideoLibQuantitySenateENT.UserTypeId = objvVideoLibQuantitySenateENS.UserTypeId; //用户类型Id
objvVideoLibQuantitySenateENT.UserTypeName = objvVideoLibQuantitySenateENS.UserTypeName; //用户类型名称
objvVideoLibQuantitySenateENT.UpdUser = objvVideoLibQuantitySenateENS.UpdUser; //修改人
objvVideoLibQuantitySenateENT.Memo = objvVideoLibQuantitySenateENS.Memo; //备注
objvVideoLibQuantitySenateENT.UpdUserName = objvVideoLibQuantitySenateENS.UpdUserName; //UpdUserName
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
 /// <param name = "objvVideoLibQuantitySenateENS">源对象</param>
 /// <returns>目标对象=>clsvVideoLibQuantitySenateEN:objvVideoLibQuantitySenateENT</returns>
 public static clsvVideoLibQuantitySenateEN CopyTo(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateENS)
{
try
{
 clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateENT = new clsvVideoLibQuantitySenateEN()
{
IdmicroteachCaseQuantitySenate = objvVideoLibQuantitySenateENS.IdmicroteachCaseQuantitySenate, //微格量化评价流水号
FuncModuleId = objvVideoLibQuantitySenateENS.FuncModuleId, //功能模块Id
FuncModuleName = objvVideoLibQuantitySenateENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvVideoLibQuantitySenateENS.IdMicroteachCase, //微格教学案例流水号
IdVideoLib = objvVideoLibQuantitySenateENS.IdVideoLib, //视频库流水号
VideoLibID = objvVideoLibQuantitySenateENS.VideoLibID, //视频库ID
VideoLibName = objvVideoLibQuantitySenateENS.VideoLibName, //视频名称
VideoLibTheme = objvVideoLibQuantitySenateENS.VideoLibTheme, //视频库主题词
VideoLibTypeName = objvVideoLibQuantitySenateENS.VideoLibTypeName, //视频库类型名称
VideoLibDate = objvVideoLibQuantitySenateENS.VideoLibDate, //视频资源日期
VideoLibTime = objvVideoLibQuantitySenateENS.VideoLibTime, //视频资源时间
VideoLibDateIn = objvVideoLibQuantitySenateENS.VideoLibDateIn, //案例入库日期
VideoLibTimeIn = objvVideoLibQuantitySenateENS.VideoLibTimeIn, //案例入库时间
OwnerId = objvVideoLibQuantitySenateENS.OwnerId, //拥有者Id
IdXzCollege = objvVideoLibQuantitySenateENS.IdXzCollege, //学院流水号
CollegeID = objvVideoLibQuantitySenateENS.CollegeID, //学院ID
CollegeName = objvVideoLibQuantitySenateENS.CollegeName, //学院名称
CollegeNameA = objvVideoLibQuantitySenateENS.CollegeNameA, //学院名称简写
ViewCount = objvVideoLibQuantitySenateENS.ViewCount, //浏览量
DownloadNumber = objvVideoLibQuantitySenateENS.DownloadNumber, //下载数目
FileIntegration = objvVideoLibQuantitySenateENS.FileIntegration, //文件积分
LikeCount = objvVideoLibQuantitySenateENS.LikeCount, //资源喜欢数量
CollectionCount = objvVideoLibQuantitySenateENS.CollectionCount, //收藏数量
CourseId = objvVideoLibQuantitySenateENS.CourseId, //课程Id
CourseCode = objvVideoLibQuantitySenateENS.CourseCode, //课程代码
CourseName = objvVideoLibQuantitySenateENS.CourseName, //课程名称
OwnerName = objvVideoLibQuantitySenateENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvVideoLibQuantitySenateENS.OwnerNameWithId, //拥有者名称附Id
IdAppraiseType = objvVideoLibQuantitySenateENS.IdAppraiseType, //评议类型流水号
AppraiseTypeName = objvVideoLibQuantitySenateENS.AppraiseTypeName, //评议类型名称
SenateTheme = objvVideoLibQuantitySenateENS.SenateTheme, //量化评价主题
SenateContent = objvVideoLibQuantitySenateENS.SenateContent, //评价内容
SenateTotalScore = objvVideoLibQuantitySenateENS.SenateTotalScore, //评价分数
SenateDate = objvVideoLibQuantitySenateENS.SenateDate, //评价日期
SenateTime = objvVideoLibQuantitySenateENS.SenateTime, //评价时间
SenateIp = objvVideoLibQuantitySenateENS.SenateIp, //评议Ip
BrowseCount = objvVideoLibQuantitySenateENS.BrowseCount, //浏览次数
IdSenateGaugeVersion = objvVideoLibQuantitySenateENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvVideoLibQuantitySenateENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvVideoLibQuantitySenateENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvVideoLibQuantitySenateENS.senateGaugeVersionTtlScore, //评价量表版本总分
UserId = objvVideoLibQuantitySenateENS.UserId, //用户ID
UserNameWithUserId = objvVideoLibQuantitySenateENS.UserNameWithUserId, //UserNameWithUserId
UserName = objvVideoLibQuantitySenateENS.UserName, //用户名
UserKindId = objvVideoLibQuantitySenateENS.UserKindId, //用户类别Id
UserKindName = objvVideoLibQuantitySenateENS.UserKindName, //用户类别名
UserTypeId = objvVideoLibQuantitySenateENS.UserTypeId, //用户类型Id
UserTypeName = objvVideoLibQuantitySenateENS.UserTypeName, //用户类型名称
UpdUser = objvVideoLibQuantitySenateENS.UpdUser, //修改人
Memo = objvVideoLibQuantitySenateENS.Memo, //备注
UpdUserName = objvVideoLibQuantitySenateENS.UpdUserName, //UpdUserName
};
 return objvVideoLibQuantitySenateENT;
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
public static void CheckProperty4Condition(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN)
{
 clsvVideoLibQuantitySenateBL.vVideoLibQuantitySenateDA.CheckProperty4Condition(objvVideoLibQuantitySenateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate) == true)
{
string strComparisonOpIdmicroteachCaseQuantitySenate = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate, objvVideoLibQuantitySenateCond.IdmicroteachCaseQuantitySenate, strComparisonOpIdmicroteachCaseQuantitySenate);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.FuncModuleId, objvVideoLibQuantitySenateCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.FuncModuleName, objvVideoLibQuantitySenateCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.IdMicroteachCase, objvVideoLibQuantitySenateCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.IdVideoLib) == true)
{
string strComparisonOpIdVideoLib = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.IdVideoLib];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.IdVideoLib, objvVideoLibQuantitySenateCond.IdVideoLib, strComparisonOpIdVideoLib);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.VideoLibID) == true)
{
string strComparisonOpVideoLibID = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibID, objvVideoLibQuantitySenateCond.VideoLibID, strComparisonOpVideoLibID);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.VideoLibName) == true)
{
string strComparisonOpVideoLibName = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibName, objvVideoLibQuantitySenateCond.VideoLibName, strComparisonOpVideoLibName);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.VideoLibTheme) == true)
{
string strComparisonOpVideoLibTheme = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibTheme, objvVideoLibQuantitySenateCond.VideoLibTheme, strComparisonOpVideoLibTheme);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.VideoLibTypeName) == true)
{
string strComparisonOpVideoLibTypeName = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibTypeName, objvVideoLibQuantitySenateCond.VideoLibTypeName, strComparisonOpVideoLibTypeName);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.VideoLibDate) == true)
{
string strComparisonOpVideoLibDate = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibDate, objvVideoLibQuantitySenateCond.VideoLibDate, strComparisonOpVideoLibDate);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.VideoLibTime) == true)
{
string strComparisonOpVideoLibTime = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibTime, objvVideoLibQuantitySenateCond.VideoLibTime, strComparisonOpVideoLibTime);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.VideoLibDateIn) == true)
{
string strComparisonOpVideoLibDateIn = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibDateIn, objvVideoLibQuantitySenateCond.VideoLibDateIn, strComparisonOpVideoLibDateIn);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.VideoLibTimeIn) == true)
{
string strComparisonOpVideoLibTimeIn = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibTimeIn, objvVideoLibQuantitySenateCond.VideoLibTimeIn, strComparisonOpVideoLibTimeIn);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.OwnerId) == true)
{
string strComparisonOpOwnerId = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.OwnerId, objvVideoLibQuantitySenateCond.OwnerId, strComparisonOpOwnerId);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.IdXzCollege, objvVideoLibQuantitySenateCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.CollegeID) == true)
{
string strComparisonOpCollegeID = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.CollegeID, objvVideoLibQuantitySenateCond.CollegeID, strComparisonOpCollegeID);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.CollegeName) == true)
{
string strComparisonOpCollegeName = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.CollegeName, objvVideoLibQuantitySenateCond.CollegeName, strComparisonOpCollegeName);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.CollegeNameA, objvVideoLibQuantitySenateCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.ViewCount) == true)
{
string strComparisonOpViewCount = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.ViewCount, objvVideoLibQuantitySenateCond.ViewCount, strComparisonOpViewCount);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.DownloadNumber, objvVideoLibQuantitySenateCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.FileIntegration, objvVideoLibQuantitySenateCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.LikeCount) == true)
{
string strComparisonOpLikeCount = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.LikeCount, objvVideoLibQuantitySenateCond.LikeCount, strComparisonOpLikeCount);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.CollectionCount, objvVideoLibQuantitySenateCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.CourseId) == true)
{
string strComparisonOpCourseId = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.CourseId, objvVideoLibQuantitySenateCond.CourseId, strComparisonOpCourseId);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.CourseCode) == true)
{
string strComparisonOpCourseCode = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.CourseCode, objvVideoLibQuantitySenateCond.CourseCode, strComparisonOpCourseCode);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.CourseName) == true)
{
string strComparisonOpCourseName = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.CourseName, objvVideoLibQuantitySenateCond.CourseName, strComparisonOpCourseName);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.OwnerName) == true)
{
string strComparisonOpOwnerName = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.OwnerName, objvVideoLibQuantitySenateCond.OwnerName, strComparisonOpOwnerName);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.OwnerNameWithId, objvVideoLibQuantitySenateCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.IdAppraiseType) == true)
{
string strComparisonOpIdAppraiseType = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.IdAppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.IdAppraiseType, objvVideoLibQuantitySenateCond.IdAppraiseType, strComparisonOpIdAppraiseType);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOpAppraiseTypeName = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.AppraiseTypeName, objvVideoLibQuantitySenateCond.AppraiseTypeName, strComparisonOpAppraiseTypeName);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.SenateTheme) == true)
{
string strComparisonOpSenateTheme = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.SenateTheme, objvVideoLibQuantitySenateCond.SenateTheme, strComparisonOpSenateTheme);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.SenateContent) == true)
{
string strComparisonOpSenateContent = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.SenateContent, objvVideoLibQuantitySenateCond.SenateContent, strComparisonOpSenateContent);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOpSenateTotalScore = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.SenateTotalScore, objvVideoLibQuantitySenateCond.SenateTotalScore, strComparisonOpSenateTotalScore);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.SenateDate) == true)
{
string strComparisonOpSenateDate = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.SenateDate, objvVideoLibQuantitySenateCond.SenateDate, strComparisonOpSenateDate);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.SenateTime) == true)
{
string strComparisonOpSenateTime = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.SenateTime, objvVideoLibQuantitySenateCond.SenateTime, strComparisonOpSenateTime);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.SenateIp) == true)
{
string strComparisonOpSenateIp = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.SenateIp, objvVideoLibQuantitySenateCond.SenateIp, strComparisonOpSenateIp);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.BrowseCount, objvVideoLibQuantitySenateCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.IdSenateGaugeVersion, objvVideoLibQuantitySenateCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.senateGaugeVersionID, objvVideoLibQuantitySenateCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.senateGaugeVersionName, objvVideoLibQuantitySenateCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.senateGaugeVersionTtlScore, objvVideoLibQuantitySenateCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.UserId) == true)
{
string strComparisonOpUserId = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UserId, objvVideoLibQuantitySenateCond.UserId, strComparisonOpUserId);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOpUserNameWithUserId = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UserNameWithUserId, objvVideoLibQuantitySenateCond.UserNameWithUserId, strComparisonOpUserNameWithUserId);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.UserName) == true)
{
string strComparisonOpUserName = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UserName, objvVideoLibQuantitySenateCond.UserName, strComparisonOpUserName);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.UserKindId) == true)
{
string strComparisonOpUserKindId = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UserKindId, objvVideoLibQuantitySenateCond.UserKindId, strComparisonOpUserKindId);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.UserKindName) == true)
{
string strComparisonOpUserKindName = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UserKindName, objvVideoLibQuantitySenateCond.UserKindName, strComparisonOpUserKindName);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UserTypeId, objvVideoLibQuantitySenateCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.UserTypeName) == true)
{
string strComparisonOpUserTypeName = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UserTypeName, objvVideoLibQuantitySenateCond.UserTypeName, strComparisonOpUserTypeName);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.UpdUser) == true)
{
string strComparisonOpUpdUser = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UpdUser, objvVideoLibQuantitySenateCond.UpdUser, strComparisonOpUpdUser);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.Memo) == true)
{
string strComparisonOpMemo = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.Memo, objvVideoLibQuantitySenateCond.Memo, strComparisonOpMemo);
}
if (objvVideoLibQuantitySenateCond.IsUpdated(convVideoLibQuantitySenate.UpdUserName) == true)
{
string strComparisonOpUpdUserName = objvVideoLibQuantitySenateCond.dicFldComparisonOp[convVideoLibQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UpdUserName, objvVideoLibQuantitySenateCond.UpdUserName, strComparisonOpUpdUserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vVideoLibQuantitySenate
{
public virtual bool UpdRelaTabDate(long lngIdmicroteachCaseQuantitySenate, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v视频库量化评议(vVideoLibQuantitySenate)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvVideoLibQuantitySenateBL
{
public static RelatedActions_vVideoLibQuantitySenate relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvVideoLibQuantitySenateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvVideoLibQuantitySenateDA vVideoLibQuantitySenateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvVideoLibQuantitySenateDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvVideoLibQuantitySenateBL()
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
if (string.IsNullOrEmpty(clsvVideoLibQuantitySenateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoLibQuantitySenateEN._ConnectString);
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
public static DataTable GetDataTable_vVideoLibQuantitySenate(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vVideoLibQuantitySenateDA.GetDataTable_vVideoLibQuantitySenate(strWhereCond);
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
objDT = vVideoLibQuantitySenateDA.GetDataTable(strWhereCond);
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
objDT = vVideoLibQuantitySenateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vVideoLibQuantitySenateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vVideoLibQuantitySenateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vVideoLibQuantitySenateDA.GetDataTable_Top(objTopPara);
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
objDT = vVideoLibQuantitySenateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vVideoLibQuantitySenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vVideoLibQuantitySenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvVideoLibQuantitySenateEN> GetObjLstByIdmicroteachCaseQuantitySenateLst(List<long> arrIdmicroteachCaseQuantitySenateLst)
{
List<clsvVideoLibQuantitySenateEN> arrObjLst = new List<clsvVideoLibQuantitySenateEN>(); 
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
	clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN();
try
{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateEN.FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateEN.FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateEN.IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateEN.IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibQuantitySenateEN.VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateEN.VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateEN.VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibQuantitySenateEN.VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibQuantitySenateEN.VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibQuantitySenateEN.VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibQuantitySenateEN.VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibQuantitySenateEN.VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibQuantitySenateEN.OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibQuantitySenateEN.IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibQuantitySenateEN.CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoLibQuantitySenateEN.CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoLibQuantitySenateEN.CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibQuantitySenateEN.ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoLibQuantitySenateEN.DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibQuantitySenateEN.FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibQuantitySenateEN.LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibQuantitySenateEN.CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibQuantitySenateEN.CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoLibQuantitySenateEN.CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoLibQuantitySenateEN.CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoLibQuantitySenateEN.OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibQuantitySenateEN.OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibQuantitySenateEN.IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateEN.AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateEN.SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoLibQuantitySenateEN.SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoLibQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoLibQuantitySenateEN.SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateEN.SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoLibQuantitySenateEN.SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoLibQuantitySenateEN.BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibQuantitySenateEN.senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibQuantitySenateEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibQuantitySenateEN.UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoLibQuantitySenateEN.UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoLibQuantitySenateEN.UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateEN.UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoLibQuantitySenateEN.UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoLibQuantitySenateEN.UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvVideoLibQuantitySenateEN.UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoLibQuantitySenateEN.UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoLibQuantitySenateEN.Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoLibQuantitySenateEN.UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdmicroteachCaseQuantitySenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvVideoLibQuantitySenateEN> GetObjLstByIdmicroteachCaseQuantitySenateLstCache(List<long> arrIdmicroteachCaseQuantitySenateLst)
{
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateEN._CurrTabName);
List<clsvVideoLibQuantitySenateEN> arrvVideoLibQuantitySenateObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibQuantitySenateEN> arrvVideoLibQuantitySenateObjLst_Sel =
arrvVideoLibQuantitySenateObjLstCache
.Where(x => arrIdmicroteachCaseQuantitySenateLst.Contains(x.IdmicroteachCaseQuantitySenate));
return arrvVideoLibQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibQuantitySenateEN> GetObjLst(string strWhereCond)
{
List<clsvVideoLibQuantitySenateEN> arrObjLst = new List<clsvVideoLibQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN();
try
{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateEN.FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateEN.FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateEN.IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateEN.IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibQuantitySenateEN.VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateEN.VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateEN.VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibQuantitySenateEN.VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibQuantitySenateEN.VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibQuantitySenateEN.VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibQuantitySenateEN.VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibQuantitySenateEN.VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibQuantitySenateEN.OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibQuantitySenateEN.IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibQuantitySenateEN.CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoLibQuantitySenateEN.CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoLibQuantitySenateEN.CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibQuantitySenateEN.ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoLibQuantitySenateEN.DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibQuantitySenateEN.FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibQuantitySenateEN.LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibQuantitySenateEN.CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibQuantitySenateEN.CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoLibQuantitySenateEN.CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoLibQuantitySenateEN.CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoLibQuantitySenateEN.OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibQuantitySenateEN.OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibQuantitySenateEN.IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateEN.AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateEN.SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoLibQuantitySenateEN.SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoLibQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoLibQuantitySenateEN.SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateEN.SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoLibQuantitySenateEN.SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoLibQuantitySenateEN.BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibQuantitySenateEN.senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibQuantitySenateEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibQuantitySenateEN.UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoLibQuantitySenateEN.UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoLibQuantitySenateEN.UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateEN.UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoLibQuantitySenateEN.UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoLibQuantitySenateEN.UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvVideoLibQuantitySenateEN.UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoLibQuantitySenateEN.UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoLibQuantitySenateEN.Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoLibQuantitySenateEN.UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateEN);
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
public static List<clsvVideoLibQuantitySenateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvVideoLibQuantitySenateEN> arrObjLst = new List<clsvVideoLibQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN();
try
{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateEN.FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateEN.FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateEN.IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateEN.IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibQuantitySenateEN.VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateEN.VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateEN.VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibQuantitySenateEN.VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibQuantitySenateEN.VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibQuantitySenateEN.VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibQuantitySenateEN.VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibQuantitySenateEN.VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibQuantitySenateEN.OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibQuantitySenateEN.IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibQuantitySenateEN.CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoLibQuantitySenateEN.CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoLibQuantitySenateEN.CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibQuantitySenateEN.ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoLibQuantitySenateEN.DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibQuantitySenateEN.FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibQuantitySenateEN.LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibQuantitySenateEN.CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibQuantitySenateEN.CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoLibQuantitySenateEN.CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoLibQuantitySenateEN.CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoLibQuantitySenateEN.OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibQuantitySenateEN.OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibQuantitySenateEN.IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateEN.AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateEN.SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoLibQuantitySenateEN.SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoLibQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoLibQuantitySenateEN.SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateEN.SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoLibQuantitySenateEN.SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoLibQuantitySenateEN.BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibQuantitySenateEN.senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibQuantitySenateEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibQuantitySenateEN.UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoLibQuantitySenateEN.UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoLibQuantitySenateEN.UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateEN.UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoLibQuantitySenateEN.UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoLibQuantitySenateEN.UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvVideoLibQuantitySenateEN.UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoLibQuantitySenateEN.UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoLibQuantitySenateEN.Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoLibQuantitySenateEN.UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvVideoLibQuantitySenateEN> GetSubObjLstCache(clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateCond)
{
List<clsvVideoLibQuantitySenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibQuantitySenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoLibQuantitySenate.AttributeName)
{
if (objvVideoLibQuantitySenateCond.IsUpdated(strFldName) == false) continue;
if (objvVideoLibQuantitySenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibQuantitySenateCond[strFldName].ToString());
}
else
{
if (objvVideoLibQuantitySenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoLibQuantitySenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibQuantitySenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoLibQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoLibQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoLibQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoLibQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoLibQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoLibQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoLibQuantitySenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoLibQuantitySenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoLibQuantitySenateCond[strFldName]));
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
public static List<clsvVideoLibQuantitySenateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvVideoLibQuantitySenateEN> arrObjLst = new List<clsvVideoLibQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN();
try
{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateEN.FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateEN.FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateEN.IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateEN.IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibQuantitySenateEN.VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateEN.VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateEN.VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibQuantitySenateEN.VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibQuantitySenateEN.VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibQuantitySenateEN.VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibQuantitySenateEN.VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibQuantitySenateEN.VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibQuantitySenateEN.OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibQuantitySenateEN.IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibQuantitySenateEN.CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoLibQuantitySenateEN.CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoLibQuantitySenateEN.CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibQuantitySenateEN.ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoLibQuantitySenateEN.DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibQuantitySenateEN.FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibQuantitySenateEN.LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibQuantitySenateEN.CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibQuantitySenateEN.CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoLibQuantitySenateEN.CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoLibQuantitySenateEN.CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoLibQuantitySenateEN.OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibQuantitySenateEN.OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibQuantitySenateEN.IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateEN.AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateEN.SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoLibQuantitySenateEN.SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoLibQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoLibQuantitySenateEN.SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateEN.SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoLibQuantitySenateEN.SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoLibQuantitySenateEN.BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibQuantitySenateEN.senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibQuantitySenateEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibQuantitySenateEN.UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoLibQuantitySenateEN.UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoLibQuantitySenateEN.UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateEN.UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoLibQuantitySenateEN.UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoLibQuantitySenateEN.UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvVideoLibQuantitySenateEN.UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoLibQuantitySenateEN.UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoLibQuantitySenateEN.Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoLibQuantitySenateEN.UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateEN);
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
public static List<clsvVideoLibQuantitySenateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvVideoLibQuantitySenateEN> arrObjLst = new List<clsvVideoLibQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN();
try
{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateEN.FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateEN.FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateEN.IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateEN.IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibQuantitySenateEN.VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateEN.VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateEN.VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibQuantitySenateEN.VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibQuantitySenateEN.VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibQuantitySenateEN.VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibQuantitySenateEN.VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibQuantitySenateEN.VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibQuantitySenateEN.OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibQuantitySenateEN.IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibQuantitySenateEN.CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoLibQuantitySenateEN.CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoLibQuantitySenateEN.CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibQuantitySenateEN.ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoLibQuantitySenateEN.DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibQuantitySenateEN.FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibQuantitySenateEN.LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibQuantitySenateEN.CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibQuantitySenateEN.CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoLibQuantitySenateEN.CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoLibQuantitySenateEN.CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoLibQuantitySenateEN.OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibQuantitySenateEN.OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibQuantitySenateEN.IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateEN.AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateEN.SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoLibQuantitySenateEN.SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoLibQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoLibQuantitySenateEN.SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateEN.SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoLibQuantitySenateEN.SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoLibQuantitySenateEN.BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibQuantitySenateEN.senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibQuantitySenateEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibQuantitySenateEN.UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoLibQuantitySenateEN.UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoLibQuantitySenateEN.UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateEN.UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoLibQuantitySenateEN.UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoLibQuantitySenateEN.UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvVideoLibQuantitySenateEN.UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoLibQuantitySenateEN.UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoLibQuantitySenateEN.Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoLibQuantitySenateEN.UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateEN);
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
List<clsvVideoLibQuantitySenateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvVideoLibQuantitySenateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvVideoLibQuantitySenateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoLibQuantitySenateEN> arrObjLst = new List<clsvVideoLibQuantitySenateEN>(); 
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
	clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN();
try
{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateEN.FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateEN.FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateEN.IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateEN.IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibQuantitySenateEN.VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateEN.VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateEN.VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibQuantitySenateEN.VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibQuantitySenateEN.VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibQuantitySenateEN.VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibQuantitySenateEN.VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibQuantitySenateEN.VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibQuantitySenateEN.OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibQuantitySenateEN.IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibQuantitySenateEN.CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoLibQuantitySenateEN.CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoLibQuantitySenateEN.CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibQuantitySenateEN.ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoLibQuantitySenateEN.DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibQuantitySenateEN.FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibQuantitySenateEN.LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibQuantitySenateEN.CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibQuantitySenateEN.CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoLibQuantitySenateEN.CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoLibQuantitySenateEN.CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoLibQuantitySenateEN.OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibQuantitySenateEN.OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibQuantitySenateEN.IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateEN.AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateEN.SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoLibQuantitySenateEN.SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoLibQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoLibQuantitySenateEN.SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateEN.SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoLibQuantitySenateEN.SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoLibQuantitySenateEN.BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibQuantitySenateEN.senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibQuantitySenateEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibQuantitySenateEN.UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoLibQuantitySenateEN.UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoLibQuantitySenateEN.UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateEN.UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoLibQuantitySenateEN.UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoLibQuantitySenateEN.UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvVideoLibQuantitySenateEN.UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoLibQuantitySenateEN.UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoLibQuantitySenateEN.Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoLibQuantitySenateEN.UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateEN);
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
public static List<clsvVideoLibQuantitySenateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvVideoLibQuantitySenateEN> arrObjLst = new List<clsvVideoLibQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN();
try
{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateEN.FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateEN.FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateEN.IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateEN.IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibQuantitySenateEN.VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateEN.VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateEN.VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibQuantitySenateEN.VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibQuantitySenateEN.VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibQuantitySenateEN.VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibQuantitySenateEN.VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibQuantitySenateEN.VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibQuantitySenateEN.OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibQuantitySenateEN.IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibQuantitySenateEN.CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoLibQuantitySenateEN.CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoLibQuantitySenateEN.CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibQuantitySenateEN.ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoLibQuantitySenateEN.DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibQuantitySenateEN.FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibQuantitySenateEN.LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibQuantitySenateEN.CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibQuantitySenateEN.CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoLibQuantitySenateEN.CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoLibQuantitySenateEN.CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoLibQuantitySenateEN.OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibQuantitySenateEN.OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibQuantitySenateEN.IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateEN.AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateEN.SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoLibQuantitySenateEN.SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoLibQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoLibQuantitySenateEN.SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateEN.SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoLibQuantitySenateEN.SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoLibQuantitySenateEN.BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibQuantitySenateEN.senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibQuantitySenateEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibQuantitySenateEN.UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoLibQuantitySenateEN.UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoLibQuantitySenateEN.UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateEN.UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoLibQuantitySenateEN.UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoLibQuantitySenateEN.UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvVideoLibQuantitySenateEN.UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoLibQuantitySenateEN.UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoLibQuantitySenateEN.Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoLibQuantitySenateEN.UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvVideoLibQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvVideoLibQuantitySenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoLibQuantitySenateEN> arrObjLst = new List<clsvVideoLibQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN();
try
{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateEN.FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateEN.FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateEN.IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateEN.IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibQuantitySenateEN.VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateEN.VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateEN.VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibQuantitySenateEN.VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibQuantitySenateEN.VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibQuantitySenateEN.VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibQuantitySenateEN.VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibQuantitySenateEN.VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibQuantitySenateEN.OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibQuantitySenateEN.IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibQuantitySenateEN.CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoLibQuantitySenateEN.CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoLibQuantitySenateEN.CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibQuantitySenateEN.ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoLibQuantitySenateEN.DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibQuantitySenateEN.FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibQuantitySenateEN.LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibQuantitySenateEN.CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibQuantitySenateEN.CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoLibQuantitySenateEN.CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoLibQuantitySenateEN.CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoLibQuantitySenateEN.OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibQuantitySenateEN.OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibQuantitySenateEN.IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateEN.AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateEN.SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoLibQuantitySenateEN.SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoLibQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoLibQuantitySenateEN.SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateEN.SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoLibQuantitySenateEN.SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoLibQuantitySenateEN.BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibQuantitySenateEN.senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibQuantitySenateEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibQuantitySenateEN.UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoLibQuantitySenateEN.UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoLibQuantitySenateEN.UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateEN.UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoLibQuantitySenateEN.UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoLibQuantitySenateEN.UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvVideoLibQuantitySenateEN.UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoLibQuantitySenateEN.UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoLibQuantitySenateEN.Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoLibQuantitySenateEN.UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateEN);
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
public static List<clsvVideoLibQuantitySenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvVideoLibQuantitySenateEN> arrObjLst = new List<clsvVideoLibQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN();
try
{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateEN.FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateEN.FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateEN.IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateEN.IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibQuantitySenateEN.VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateEN.VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateEN.VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibQuantitySenateEN.VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibQuantitySenateEN.VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibQuantitySenateEN.VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibQuantitySenateEN.VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibQuantitySenateEN.VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibQuantitySenateEN.OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibQuantitySenateEN.IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibQuantitySenateEN.CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoLibQuantitySenateEN.CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoLibQuantitySenateEN.CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibQuantitySenateEN.ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoLibQuantitySenateEN.DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibQuantitySenateEN.FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibQuantitySenateEN.LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibQuantitySenateEN.CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibQuantitySenateEN.CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoLibQuantitySenateEN.CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoLibQuantitySenateEN.CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoLibQuantitySenateEN.OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibQuantitySenateEN.OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibQuantitySenateEN.IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateEN.AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateEN.SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoLibQuantitySenateEN.SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoLibQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoLibQuantitySenateEN.SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateEN.SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoLibQuantitySenateEN.SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoLibQuantitySenateEN.BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibQuantitySenateEN.senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibQuantitySenateEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibQuantitySenateEN.UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoLibQuantitySenateEN.UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoLibQuantitySenateEN.UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateEN.UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoLibQuantitySenateEN.UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoLibQuantitySenateEN.UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvVideoLibQuantitySenateEN.UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoLibQuantitySenateEN.UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoLibQuantitySenateEN.Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoLibQuantitySenateEN.UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibQuantitySenateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvVideoLibQuantitySenateEN> arrObjLst = new List<clsvVideoLibQuantitySenateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN();
try
{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateEN.FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateEN.FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateEN.IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateEN.IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibQuantitySenateEN.VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateEN.VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateEN.VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibQuantitySenateEN.VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibQuantitySenateEN.VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibQuantitySenateEN.VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibQuantitySenateEN.VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibQuantitySenateEN.VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibQuantitySenateEN.OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibQuantitySenateEN.IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibQuantitySenateEN.CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoLibQuantitySenateEN.CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoLibQuantitySenateEN.CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibQuantitySenateEN.ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoLibQuantitySenateEN.DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibQuantitySenateEN.FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibQuantitySenateEN.LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibQuantitySenateEN.CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibQuantitySenateEN.CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoLibQuantitySenateEN.CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoLibQuantitySenateEN.CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoLibQuantitySenateEN.OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibQuantitySenateEN.OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibQuantitySenateEN.IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateEN.AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateEN.SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoLibQuantitySenateEN.SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoLibQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoLibQuantitySenateEN.SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateEN.SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoLibQuantitySenateEN.SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoLibQuantitySenateEN.BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibQuantitySenateEN.senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibQuantitySenateEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibQuantitySenateEN.UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoLibQuantitySenateEN.UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoLibQuantitySenateEN.UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateEN.UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoLibQuantitySenateEN.UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoLibQuantitySenateEN.UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvVideoLibQuantitySenateEN.UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoLibQuantitySenateEN.UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoLibQuantitySenateEN.Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoLibQuantitySenateEN.UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvVideoLibQuantitySenate(ref clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN)
{
bool bolResult = vVideoLibQuantitySenateDA.GetvVideoLibQuantitySenate(ref objvVideoLibQuantitySenateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = vVideoLibQuantitySenateDA.GetObjByIdmicroteachCaseQuantitySenate(lngIdmicroteachCaseQuantitySenate);
return objvVideoLibQuantitySenateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvVideoLibQuantitySenateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = vVideoLibQuantitySenateDA.GetFirstObj(strWhereCond);
 return objvVideoLibQuantitySenateEN;
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
public static clsvVideoLibQuantitySenateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = vVideoLibQuantitySenateDA.GetObjByDataRow(objRow);
 return objvVideoLibQuantitySenateEN;
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
public static clsvVideoLibQuantitySenateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = vVideoLibQuantitySenateDA.GetObjByDataRow(objRow);
 return objvVideoLibQuantitySenateEN;
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
 /// <param name = "lstvVideoLibQuantitySenateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLibQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenateFromList(long lngIdmicroteachCaseQuantitySenate, List<clsvVideoLibQuantitySenateEN> lstvVideoLibQuantitySenateObjLst)
{
foreach (clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN in lstvVideoLibQuantitySenateObjLst)
{
if (objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate == lngIdmicroteachCaseQuantitySenate)
{
return objvVideoLibQuantitySenateEN;
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
 lngIdmicroteachCaseQuantitySenate = new clsvVideoLibQuantitySenateDA().GetFirstID(strWhereCond);
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
 arrList = vVideoLibQuantitySenateDA.GetID(strWhereCond);
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
bool bolIsExist = vVideoLibQuantitySenateDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vVideoLibQuantitySenateDA.IsExist(lngIdmicroteachCaseQuantitySenate);
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
 bolIsExist = clsvVideoLibQuantitySenateDA.IsExistTable();
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
 bolIsExist = vVideoLibQuantitySenateDA.IsExistTable(strTabName);
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
 /// <param name = "objvVideoLibQuantitySenateENS">源对象</param>
 /// <param name = "objvVideoLibQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateENS, clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateENT)
{
try
{
objvVideoLibQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvVideoLibQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvVideoLibQuantitySenateENT.FuncModuleId = objvVideoLibQuantitySenateENS.FuncModuleId; //功能模块Id
objvVideoLibQuantitySenateENT.FuncModuleName = objvVideoLibQuantitySenateENS.FuncModuleName; //功能模块名称
objvVideoLibQuantitySenateENT.IdMicroteachCase = objvVideoLibQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvVideoLibQuantitySenateENT.IdVideoLib = objvVideoLibQuantitySenateENS.IdVideoLib; //视频库流水号
objvVideoLibQuantitySenateENT.VideoLibID = objvVideoLibQuantitySenateENS.VideoLibID; //视频库ID
objvVideoLibQuantitySenateENT.VideoLibName = objvVideoLibQuantitySenateENS.VideoLibName; //视频名称
objvVideoLibQuantitySenateENT.VideoLibTheme = objvVideoLibQuantitySenateENS.VideoLibTheme; //视频库主题词
objvVideoLibQuantitySenateENT.VideoLibTypeName = objvVideoLibQuantitySenateENS.VideoLibTypeName; //视频库类型名称
objvVideoLibQuantitySenateENT.VideoLibDate = objvVideoLibQuantitySenateENS.VideoLibDate; //视频资源日期
objvVideoLibQuantitySenateENT.VideoLibTime = objvVideoLibQuantitySenateENS.VideoLibTime; //视频资源时间
objvVideoLibQuantitySenateENT.VideoLibDateIn = objvVideoLibQuantitySenateENS.VideoLibDateIn; //案例入库日期
objvVideoLibQuantitySenateENT.VideoLibTimeIn = objvVideoLibQuantitySenateENS.VideoLibTimeIn; //案例入库时间
objvVideoLibQuantitySenateENT.OwnerId = objvVideoLibQuantitySenateENS.OwnerId; //拥有者Id
objvVideoLibQuantitySenateENT.IdXzCollege = objvVideoLibQuantitySenateENS.IdXzCollege; //学院流水号
objvVideoLibQuantitySenateENT.CollegeID = objvVideoLibQuantitySenateENS.CollegeID; //学院ID
objvVideoLibQuantitySenateENT.CollegeName = objvVideoLibQuantitySenateENS.CollegeName; //学院名称
objvVideoLibQuantitySenateENT.CollegeNameA = objvVideoLibQuantitySenateENS.CollegeNameA; //学院名称简写
objvVideoLibQuantitySenateENT.ViewCount = objvVideoLibQuantitySenateENS.ViewCount; //浏览量
objvVideoLibQuantitySenateENT.DownloadNumber = objvVideoLibQuantitySenateENS.DownloadNumber; //下载数目
objvVideoLibQuantitySenateENT.FileIntegration = objvVideoLibQuantitySenateENS.FileIntegration; //文件积分
objvVideoLibQuantitySenateENT.LikeCount = objvVideoLibQuantitySenateENS.LikeCount; //资源喜欢数量
objvVideoLibQuantitySenateENT.CollectionCount = objvVideoLibQuantitySenateENS.CollectionCount; //收藏数量
objvVideoLibQuantitySenateENT.CourseId = objvVideoLibQuantitySenateENS.CourseId; //课程Id
objvVideoLibQuantitySenateENT.CourseCode = objvVideoLibQuantitySenateENS.CourseCode; //课程代码
objvVideoLibQuantitySenateENT.CourseName = objvVideoLibQuantitySenateENS.CourseName; //课程名称
objvVideoLibQuantitySenateENT.OwnerName = objvVideoLibQuantitySenateENS.OwnerName; //拥有者姓名
objvVideoLibQuantitySenateENT.OwnerNameWithId = objvVideoLibQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvVideoLibQuantitySenateENT.IdAppraiseType = objvVideoLibQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvVideoLibQuantitySenateENT.AppraiseTypeName = objvVideoLibQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvVideoLibQuantitySenateENT.SenateTheme = objvVideoLibQuantitySenateENS.SenateTheme; //量化评价主题
objvVideoLibQuantitySenateENT.SenateContent = objvVideoLibQuantitySenateENS.SenateContent; //评价内容
objvVideoLibQuantitySenateENT.SenateTotalScore = objvVideoLibQuantitySenateENS.SenateTotalScore; //评价分数
objvVideoLibQuantitySenateENT.SenateDate = objvVideoLibQuantitySenateENS.SenateDate; //评价日期
objvVideoLibQuantitySenateENT.SenateTime = objvVideoLibQuantitySenateENS.SenateTime; //评价时间
objvVideoLibQuantitySenateENT.SenateIp = objvVideoLibQuantitySenateENS.SenateIp; //评议Ip
objvVideoLibQuantitySenateENT.BrowseCount = objvVideoLibQuantitySenateENS.BrowseCount; //浏览次数
objvVideoLibQuantitySenateENT.IdSenateGaugeVersion = objvVideoLibQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvVideoLibQuantitySenateENT.senateGaugeVersionID = objvVideoLibQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvVideoLibQuantitySenateENT.senateGaugeVersionName = objvVideoLibQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLibQuantitySenateENT.senateGaugeVersionTtlScore = objvVideoLibQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoLibQuantitySenateENT.UserId = objvVideoLibQuantitySenateENS.UserId; //用户ID
objvVideoLibQuantitySenateENT.UserNameWithUserId = objvVideoLibQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvVideoLibQuantitySenateENT.UserName = objvVideoLibQuantitySenateENS.UserName; //用户名
objvVideoLibQuantitySenateENT.UserKindId = objvVideoLibQuantitySenateENS.UserKindId; //用户类别Id
objvVideoLibQuantitySenateENT.UserKindName = objvVideoLibQuantitySenateENS.UserKindName; //用户类别名
objvVideoLibQuantitySenateENT.UserTypeId = objvVideoLibQuantitySenateENS.UserTypeId; //用户类型Id
objvVideoLibQuantitySenateENT.UserTypeName = objvVideoLibQuantitySenateENS.UserTypeName; //用户类型名称
objvVideoLibQuantitySenateENT.UpdUser = objvVideoLibQuantitySenateENS.UpdUser; //修改人
objvVideoLibQuantitySenateENT.Memo = objvVideoLibQuantitySenateENS.Memo; //备注
objvVideoLibQuantitySenateENT.UpdUserName = objvVideoLibQuantitySenateENS.UpdUserName; //UpdUserName
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
 /// <param name = "objvVideoLibQuantitySenateEN">源简化对象</param>
 public static void SetUpdFlag(clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN)
{
try
{
objvVideoLibQuantitySenateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvVideoLibQuantitySenateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.FuncModuleId = objvVideoLibQuantitySenateEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.FuncModuleName = objvVideoLibQuantitySenateEN.FuncModuleName == "[null]" ? null :  objvVideoLibQuantitySenateEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.IdMicroteachCase = objvVideoLibQuantitySenateEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.IdVideoLib, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.IdVideoLib = objvVideoLibQuantitySenateEN.IdVideoLib == "[null]" ? null :  objvVideoLibQuantitySenateEN.IdVideoLib; //视频库流水号
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.VideoLibID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.VideoLibID = objvVideoLibQuantitySenateEN.VideoLibID == "[null]" ? null :  objvVideoLibQuantitySenateEN.VideoLibID; //视频库ID
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.VideoLibName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.VideoLibName = objvVideoLibQuantitySenateEN.VideoLibName == "[null]" ? null :  objvVideoLibQuantitySenateEN.VideoLibName; //视频名称
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.VideoLibTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.VideoLibTheme = objvVideoLibQuantitySenateEN.VideoLibTheme == "[null]" ? null :  objvVideoLibQuantitySenateEN.VideoLibTheme; //视频库主题词
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.VideoLibTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.VideoLibTypeName = objvVideoLibQuantitySenateEN.VideoLibTypeName == "[null]" ? null :  objvVideoLibQuantitySenateEN.VideoLibTypeName; //视频库类型名称
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.VideoLibDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.VideoLibDate = objvVideoLibQuantitySenateEN.VideoLibDate == "[null]" ? null :  objvVideoLibQuantitySenateEN.VideoLibDate; //视频资源日期
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.VideoLibTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.VideoLibTime = objvVideoLibQuantitySenateEN.VideoLibTime == "[null]" ? null :  objvVideoLibQuantitySenateEN.VideoLibTime; //视频资源时间
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.VideoLibDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.VideoLibDateIn = objvVideoLibQuantitySenateEN.VideoLibDateIn == "[null]" ? null :  objvVideoLibQuantitySenateEN.VideoLibDateIn; //案例入库日期
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.VideoLibTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.VideoLibTimeIn = objvVideoLibQuantitySenateEN.VideoLibTimeIn == "[null]" ? null :  objvVideoLibQuantitySenateEN.VideoLibTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.OwnerId = objvVideoLibQuantitySenateEN.OwnerId == "[null]" ? null :  objvVideoLibQuantitySenateEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.IdXzCollege = objvVideoLibQuantitySenateEN.IdXzCollege == "[null]" ? null :  objvVideoLibQuantitySenateEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.CollegeID = objvVideoLibQuantitySenateEN.CollegeID == "[null]" ? null :  objvVideoLibQuantitySenateEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.CollegeName = objvVideoLibQuantitySenateEN.CollegeName == "[null]" ? null :  objvVideoLibQuantitySenateEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.CollegeNameA = objvVideoLibQuantitySenateEN.CollegeNameA == "[null]" ? null :  objvVideoLibQuantitySenateEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.ViewCount = objvVideoLibQuantitySenateEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.DownloadNumber = objvVideoLibQuantitySenateEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.FileIntegration = objvVideoLibQuantitySenateEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.LikeCount = objvVideoLibQuantitySenateEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.CollectionCount = objvVideoLibQuantitySenateEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.CourseId = objvVideoLibQuantitySenateEN.CourseId == "[null]" ? null :  objvVideoLibQuantitySenateEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.CourseCode = objvVideoLibQuantitySenateEN.CourseCode == "[null]" ? null :  objvVideoLibQuantitySenateEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.CourseName = objvVideoLibQuantitySenateEN.CourseName == "[null]" ? null :  objvVideoLibQuantitySenateEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.OwnerName = objvVideoLibQuantitySenateEN.OwnerName == "[null]" ? null :  objvVideoLibQuantitySenateEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.OwnerNameWithId = objvVideoLibQuantitySenateEN.OwnerNameWithId == "[null]" ? null :  objvVideoLibQuantitySenateEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.IdAppraiseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.IdAppraiseType = objvVideoLibQuantitySenateEN.IdAppraiseType; //评议类型流水号
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.AppraiseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.AppraiseTypeName = objvVideoLibQuantitySenateEN.AppraiseTypeName == "[null]" ? null :  objvVideoLibQuantitySenateEN.AppraiseTypeName; //评议类型名称
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.SenateTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.SenateTheme = objvVideoLibQuantitySenateEN.SenateTheme == "[null]" ? null :  objvVideoLibQuantitySenateEN.SenateTheme; //量化评价主题
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.SenateContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.SenateContent = objvVideoLibQuantitySenateEN.SenateContent == "[null]" ? null :  objvVideoLibQuantitySenateEN.SenateContent; //评价内容
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.SenateTotalScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.SenateTotalScore = objvVideoLibQuantitySenateEN.SenateTotalScore; //评价分数
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.SenateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.SenateDate = objvVideoLibQuantitySenateEN.SenateDate == "[null]" ? null :  objvVideoLibQuantitySenateEN.SenateDate; //评价日期
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.SenateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.SenateTime = objvVideoLibQuantitySenateEN.SenateTime == "[null]" ? null :  objvVideoLibQuantitySenateEN.SenateTime; //评价时间
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.SenateIp, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.SenateIp = objvVideoLibQuantitySenateEN.SenateIp; //评议Ip
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.BrowseCount = objvVideoLibQuantitySenateEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objvVideoLibQuantitySenateEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.senateGaugeVersionID = objvVideoLibQuantitySenateEN.senateGaugeVersionID == "[null]" ? null :  objvVideoLibQuantitySenateEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.senateGaugeVersionName = objvVideoLibQuantitySenateEN.senateGaugeVersionName == "[null]" ? null :  objvVideoLibQuantitySenateEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.UserId = objvVideoLibQuantitySenateEN.UserId; //用户ID
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.UserNameWithUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.UserNameWithUserId = objvVideoLibQuantitySenateEN.UserNameWithUserId == "[null]" ? null :  objvVideoLibQuantitySenateEN.UserNameWithUserId; //UserNameWithUserId
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.UserName = objvVideoLibQuantitySenateEN.UserName; //用户名
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.UserKindId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.UserKindId = objvVideoLibQuantitySenateEN.UserKindId; //用户类别Id
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.UserKindName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.UserKindName = objvVideoLibQuantitySenateEN.UserKindName == "[null]" ? null :  objvVideoLibQuantitySenateEN.UserKindName; //用户类别名
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.UserTypeId = objvVideoLibQuantitySenateEN.UserTypeId == "[null]" ? null :  objvVideoLibQuantitySenateEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.UserTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.UserTypeName = objvVideoLibQuantitySenateEN.UserTypeName == "[null]" ? null :  objvVideoLibQuantitySenateEN.UserTypeName; //用户类型名称
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.UpdUser = objvVideoLibQuantitySenateEN.UpdUser == "[null]" ? null :  objvVideoLibQuantitySenateEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.Memo = objvVideoLibQuantitySenateEN.Memo == "[null]" ? null :  objvVideoLibQuantitySenateEN.Memo; //备注
}
if (arrFldSet.Contains(convVideoLibQuantitySenate.UpdUserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateEN.UpdUserName = objvVideoLibQuantitySenateEN.UpdUserName == "[null]" ? null :  objvVideoLibQuantitySenateEN.UpdUserName; //UpdUserName
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
 /// <param name = "objvVideoLibQuantitySenateEN">源简化对象</param>
 public static void AccessFldValueNull(clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN)
{
try
{
if (objvVideoLibQuantitySenateEN.FuncModuleName == "[null]") objvVideoLibQuantitySenateEN.FuncModuleName = null; //功能模块名称
if (objvVideoLibQuantitySenateEN.IdVideoLib == "[null]") objvVideoLibQuantitySenateEN.IdVideoLib = null; //视频库流水号
if (objvVideoLibQuantitySenateEN.VideoLibID == "[null]") objvVideoLibQuantitySenateEN.VideoLibID = null; //视频库ID
if (objvVideoLibQuantitySenateEN.VideoLibName == "[null]") objvVideoLibQuantitySenateEN.VideoLibName = null; //视频名称
if (objvVideoLibQuantitySenateEN.VideoLibTheme == "[null]") objvVideoLibQuantitySenateEN.VideoLibTheme = null; //视频库主题词
if (objvVideoLibQuantitySenateEN.VideoLibTypeName == "[null]") objvVideoLibQuantitySenateEN.VideoLibTypeName = null; //视频库类型名称
if (objvVideoLibQuantitySenateEN.VideoLibDate == "[null]") objvVideoLibQuantitySenateEN.VideoLibDate = null; //视频资源日期
if (objvVideoLibQuantitySenateEN.VideoLibTime == "[null]") objvVideoLibQuantitySenateEN.VideoLibTime = null; //视频资源时间
if (objvVideoLibQuantitySenateEN.VideoLibDateIn == "[null]") objvVideoLibQuantitySenateEN.VideoLibDateIn = null; //案例入库日期
if (objvVideoLibQuantitySenateEN.VideoLibTimeIn == "[null]") objvVideoLibQuantitySenateEN.VideoLibTimeIn = null; //案例入库时间
if (objvVideoLibQuantitySenateEN.OwnerId == "[null]") objvVideoLibQuantitySenateEN.OwnerId = null; //拥有者Id
if (objvVideoLibQuantitySenateEN.IdXzCollege == "[null]") objvVideoLibQuantitySenateEN.IdXzCollege = null; //学院流水号
if (objvVideoLibQuantitySenateEN.CollegeID == "[null]") objvVideoLibQuantitySenateEN.CollegeID = null; //学院ID
if (objvVideoLibQuantitySenateEN.CollegeName == "[null]") objvVideoLibQuantitySenateEN.CollegeName = null; //学院名称
if (objvVideoLibQuantitySenateEN.CollegeNameA == "[null]") objvVideoLibQuantitySenateEN.CollegeNameA = null; //学院名称简写
if (objvVideoLibQuantitySenateEN.CourseId == "[null]") objvVideoLibQuantitySenateEN.CourseId = null; //课程Id
if (objvVideoLibQuantitySenateEN.CourseCode == "[null]") objvVideoLibQuantitySenateEN.CourseCode = null; //课程代码
if (objvVideoLibQuantitySenateEN.CourseName == "[null]") objvVideoLibQuantitySenateEN.CourseName = null; //课程名称
if (objvVideoLibQuantitySenateEN.OwnerName == "[null]") objvVideoLibQuantitySenateEN.OwnerName = null; //拥有者姓名
if (objvVideoLibQuantitySenateEN.OwnerNameWithId == "[null]") objvVideoLibQuantitySenateEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvVideoLibQuantitySenateEN.AppraiseTypeName == "[null]") objvVideoLibQuantitySenateEN.AppraiseTypeName = null; //评议类型名称
if (objvVideoLibQuantitySenateEN.SenateTheme == "[null]") objvVideoLibQuantitySenateEN.SenateTheme = null; //量化评价主题
if (objvVideoLibQuantitySenateEN.SenateContent == "[null]") objvVideoLibQuantitySenateEN.SenateContent = null; //评价内容
if (objvVideoLibQuantitySenateEN.SenateDate == "[null]") objvVideoLibQuantitySenateEN.SenateDate = null; //评价日期
if (objvVideoLibQuantitySenateEN.SenateTime == "[null]") objvVideoLibQuantitySenateEN.SenateTime = null; //评价时间
if (objvVideoLibQuantitySenateEN.senateGaugeVersionID == "[null]") objvVideoLibQuantitySenateEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvVideoLibQuantitySenateEN.senateGaugeVersionName == "[null]") objvVideoLibQuantitySenateEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvVideoLibQuantitySenateEN.UserNameWithUserId == "[null]") objvVideoLibQuantitySenateEN.UserNameWithUserId = null; //UserNameWithUserId
if (objvVideoLibQuantitySenateEN.UserKindName == "[null]") objvVideoLibQuantitySenateEN.UserKindName = null; //用户类别名
if (objvVideoLibQuantitySenateEN.UserTypeId == "[null]") objvVideoLibQuantitySenateEN.UserTypeId = null; //用户类型Id
if (objvVideoLibQuantitySenateEN.UserTypeName == "[null]") objvVideoLibQuantitySenateEN.UserTypeName = null; //用户类型名称
if (objvVideoLibQuantitySenateEN.UpdUser == "[null]") objvVideoLibQuantitySenateEN.UpdUser = null; //修改人
if (objvVideoLibQuantitySenateEN.Memo == "[null]") objvVideoLibQuantitySenateEN.Memo = null; //备注
if (objvVideoLibQuantitySenateEN.UpdUserName == "[null]") objvVideoLibQuantitySenateEN.UpdUserName = null; //UpdUserName
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
public static void CheckProperty4Condition(clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN)
{
 vVideoLibQuantitySenateDA.CheckProperty4Condition(objvVideoLibQuantitySenateEN);
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
if (clsVideoLibBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibBL没有刷新缓存机制(clsVideoLibBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoLibTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibTypeBL没有刷新缓存机制(clsVideoLibTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelBL没有刷新缓存机制(clsCaseLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdmicroteachCaseQuantitySenate");
//if (arrvVideoLibQuantitySenateObjLstCache == null)
//{
//arrvVideoLibQuantitySenateObjLstCache = vVideoLibQuantitySenateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLibQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenateCache(long lngIdmicroteachCaseQuantitySenate)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateEN._CurrTabName);
List<clsvVideoLibQuantitySenateEN> arrvVideoLibQuantitySenateObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibQuantitySenateEN> arrvVideoLibQuantitySenateObjLst_Sel =
arrvVideoLibQuantitySenateObjLstCache
.Where(x=> x.IdmicroteachCaseQuantitySenate == lngIdmicroteachCaseQuantitySenate 
);
if (arrvVideoLibQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvVideoLibQuantitySenateEN obj = clsvVideoLibQuantitySenateBL.GetObjByIdmicroteachCaseQuantitySenate(lngIdmicroteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvVideoLibQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoLibQuantitySenateEN> GetAllvVideoLibQuantitySenateObjLstCache()
{
//获取缓存中的对象列表
List<clsvVideoLibQuantitySenateEN> arrvVideoLibQuantitySenateObjLstCache = GetObjLstCache(); 
return arrvVideoLibQuantitySenateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoLibQuantitySenateEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateEN._CurrTabName);
List<clsvVideoLibQuantitySenateEN> arrvVideoLibQuantitySenateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoLibQuantitySenateObjLstCache;
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
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateEN._CurrTabName);
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
if (strInFldName != convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convVideoLibQuantitySenate.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convVideoLibQuantitySenate.AttributeName));
throw new Exception(strMsg);
}
var objvVideoLibQuantitySenate = clsvVideoLibQuantitySenateBL.GetObjByIdmicroteachCaseQuantitySenateCache(lngIdmicroteachCaseQuantitySenate);
if (objvVideoLibQuantitySenate == null) return "";
return objvVideoLibQuantitySenate[strOutFldName].ToString();
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
int intRecCount = clsvVideoLibQuantitySenateDA.GetRecCount(strTabName);
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
int intRecCount = clsvVideoLibQuantitySenateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvVideoLibQuantitySenateDA.GetRecCount();
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
int intRecCount = clsvVideoLibQuantitySenateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateCond)
{
List<clsvVideoLibQuantitySenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibQuantitySenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoLibQuantitySenate.AttributeName)
{
if (objvVideoLibQuantitySenateCond.IsUpdated(strFldName) == false) continue;
if (objvVideoLibQuantitySenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibQuantitySenateCond[strFldName].ToString());
}
else
{
if (objvVideoLibQuantitySenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoLibQuantitySenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibQuantitySenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoLibQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoLibQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoLibQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoLibQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoLibQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoLibQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoLibQuantitySenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoLibQuantitySenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoLibQuantitySenateCond[strFldName]));
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
 List<string> arrList = clsvVideoLibQuantitySenateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vVideoLibQuantitySenateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vVideoLibQuantitySenateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}