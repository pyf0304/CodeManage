
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCaseQuantitySenateWApi
 表名:vTeachingCaseResCaseQuantitySenate(01120450)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:48
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学案例资源
 模块英文名:TeachingCaseResLib
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
public static class clsvTeachingCaseResCaseQuantitySenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUserTypeName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convTeachingCaseResCaseQuantitySenate.UserTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN Setid_microteachCaseQuantitySenate(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
objvTeachingCaseResCaseQuantitySenateEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.id_microteachCaseQuantitySenate) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetFuncModuleId(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convTeachingCaseResCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convTeachingCaseResCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convTeachingCaseResCaseQuantitySenate.FuncModuleId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetFuncModuleName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convTeachingCaseResCaseQuantitySenate.FuncModuleName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN Setid_MicroteachCase(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convTeachingCaseResCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convTeachingCaseResCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convTeachingCaseResCaseQuantitySenate.id_MicroteachCase);
objvTeachingCaseResCaseQuantitySenateEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.id_MicroteachCase) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.id_MicroteachCase, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.id_MicroteachCase] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetId_TeachingCaseResCase(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strId_TeachingCaseResCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_TeachingCaseResCase, 8, convTeachingCaseResCaseQuantitySenate.Id_TeachingCaseResCase);
clsCheckSql.CheckFieldForeignKey(strId_TeachingCaseResCase, 8, convTeachingCaseResCaseQuantitySenate.Id_TeachingCaseResCase);
objvTeachingCaseResCaseQuantitySenateEN.Id_TeachingCaseResCase = strId_TeachingCaseResCase; //教学案例资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.Id_TeachingCaseResCase) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.Id_TeachingCaseResCase, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.Id_TeachingCaseResCase] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseID(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseID, 8, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseID, 8, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseName, 100, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseTheme(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTheme, 200, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseDate(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDate, 8, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDate, 8, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseTime(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTime, 6, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTime, 6, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseDateIn(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseTimeIn(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetTeachingCaseResCaseTypeName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strTeachingCaseResCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTypeName, 30, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetOwnerId(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convTeachingCaseResCaseQuantitySenate.OwnerId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetOwnerName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convTeachingCaseResCaseQuantitySenate.OwnerName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetOwnerNameWithId(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convTeachingCaseResCaseQuantitySenate.OwnerNameWithId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN Setid_XzCollege(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convTeachingCaseResCaseQuantitySenate.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convTeachingCaseResCaseQuantitySenate.id_XzCollege);
objvTeachingCaseResCaseQuantitySenateEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.id_XzCollege) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.id_XzCollege, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.id_XzCollege] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetCollegeID(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convTeachingCaseResCaseQuantitySenate.CollegeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetCollegeName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachingCaseResCaseQuantitySenate.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN Setid_XzMajor(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convTeachingCaseResCaseQuantitySenate.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convTeachingCaseResCaseQuantitySenate.id_XzMajor);
objvTeachingCaseResCaseQuantitySenateEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.id_XzMajor) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.id_XzMajor, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.id_XzMajor] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetMajorID(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convTeachingCaseResCaseQuantitySenate.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convTeachingCaseResCaseQuantitySenate.MajorID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetMajorName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convTeachingCaseResCaseQuantitySenate.MajorName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetCourseId(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convTeachingCaseResCaseQuantitySenate.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convTeachingCaseResCaseQuantitySenate.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetCourseCode(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convTeachingCaseResCaseQuantitySenate.CourseCode);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetCourseName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convTeachingCaseResCaseQuantitySenate.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetViewCount(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, int intViewCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetDownloadNumber(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, int intDownloadNumber, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetFileIntegration(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, int intFileIntegration, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetLikeCount(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, long lngLikeCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetCollectionCount(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, long lngCollectionCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetCollegeNameA(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeachingCaseResCaseQuantitySenate.CollegeNameA);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN Setid_AppraiseType(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convTeachingCaseResCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convTeachingCaseResCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convTeachingCaseResCaseQuantitySenate.id_AppraiseType);
objvTeachingCaseResCaseQuantitySenateEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.id_AppraiseType) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.id_AppraiseType, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.id_AppraiseType] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetAppraiseTypeName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convTeachingCaseResCaseQuantitySenate.AppraiseTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetSenateTheme(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convTeachingCaseResCaseQuantitySenate.SenateTheme);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetSenateContent(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convTeachingCaseResCaseQuantitySenate.SenateContent);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetSenateDate(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convTeachingCaseResCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convTeachingCaseResCaseQuantitySenate.SenateDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetSenateTime(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convTeachingCaseResCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convTeachingCaseResCaseQuantitySenate.SenateTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetSenateIp(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSenateIp, convTeachingCaseResCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(strSenateIp, 50, convTeachingCaseResCaseQuantitySenate.SenateIp);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetBrowseCount(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, int intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN Setid_SenateGaugeVersion(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convTeachingCaseResCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convTeachingCaseResCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convTeachingCaseResCaseQuantitySenate.id_SenateGaugeVersion);
objvTeachingCaseResCaseQuantitySenateEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseQuantitySenate.id_SenateGaugeVersion) == false)
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp.Add(convTeachingCaseResCaseQuantitySenate.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvTeachingCaseResCaseQuantitySenateEN.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvTeachingCaseResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetsenateGaugeVersionTtlScore(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUserId(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convTeachingCaseResCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convTeachingCaseResCaseQuantitySenate.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUserNameWithUserId(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convTeachingCaseResCaseQuantitySenate.UserNameWithUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUserName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convTeachingCaseResCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(strUserName, 50, convTeachingCaseResCaseQuantitySenate.UserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUserKindId(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convTeachingCaseResCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convTeachingCaseResCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convTeachingCaseResCaseQuantitySenate.UserKindId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUserKindName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convTeachingCaseResCaseQuantitySenate.UserKindName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUpdUser(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTeachingCaseResCaseQuantitySenate.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetMemo(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingCaseResCaseQuantitySenate.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN SetUpdUserName(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convTeachingCaseResCaseQuantitySenate.UpdUserName);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UserTypeName, objvTeachingCaseResCaseQuantitySenate_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.id_microteachCaseQuantitySenate, objvTeachingCaseResCaseQuantitySenate_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.FuncModuleId, objvTeachingCaseResCaseQuantitySenate_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.FuncModuleName, objvTeachingCaseResCaseQuantitySenate_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.id_MicroteachCase, objvTeachingCaseResCaseQuantitySenate_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.Id_TeachingCaseResCase) == true)
{
string strComparisonOp_Id_TeachingCaseResCase = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.Id_TeachingCaseResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.Id_TeachingCaseResCase, objvTeachingCaseResCaseQuantitySenate_Cond.Id_TeachingCaseResCase, strComparisonOp_Id_TeachingCaseResCase);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID) == true)
{
string strComparisonOp_TeachingCaseResCaseID = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID, objvTeachingCaseResCaseQuantitySenate_Cond.TeachingCaseResCaseID, strComparisonOp_TeachingCaseResCaseID);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName) == true)
{
string strComparisonOp_TeachingCaseResCaseName = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName, objvTeachingCaseResCaseQuantitySenate_Cond.TeachingCaseResCaseName, strComparisonOp_TeachingCaseResCaseName);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme) == true)
{
string strComparisonOp_TeachingCaseResCaseTheme = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme, objvTeachingCaseResCaseQuantitySenate_Cond.TeachingCaseResCaseTheme, strComparisonOp_TeachingCaseResCaseTheme);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate) == true)
{
string strComparisonOp_TeachingCaseResCaseDate = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate, objvTeachingCaseResCaseQuantitySenate_Cond.TeachingCaseResCaseDate, strComparisonOp_TeachingCaseResCaseDate);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime) == true)
{
string strComparisonOp_TeachingCaseResCaseTime = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime, objvTeachingCaseResCaseQuantitySenate_Cond.TeachingCaseResCaseTime, strComparisonOp_TeachingCaseResCaseTime);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn) == true)
{
string strComparisonOp_TeachingCaseResCaseDateIn = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn, objvTeachingCaseResCaseQuantitySenate_Cond.TeachingCaseResCaseDateIn, strComparisonOp_TeachingCaseResCaseDateIn);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn) == true)
{
string strComparisonOp_TeachingCaseResCaseTimeIn = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn, objvTeachingCaseResCaseQuantitySenate_Cond.TeachingCaseResCaseTimeIn, strComparisonOp_TeachingCaseResCaseTimeIn);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName) == true)
{
string strComparisonOp_TeachingCaseResCaseTypeName = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName, objvTeachingCaseResCaseQuantitySenate_Cond.TeachingCaseResCaseTypeName, strComparisonOp_TeachingCaseResCaseTypeName);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.OwnerId, objvTeachingCaseResCaseQuantitySenate_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.OwnerName, objvTeachingCaseResCaseQuantitySenate_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.OwnerNameWithId, objvTeachingCaseResCaseQuantitySenate_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.IsDualVideo) == true)
{
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCaseQuantitySenate.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCaseQuantitySenate.IsDualVideo);
}
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.id_XzCollege, objvTeachingCaseResCaseQuantitySenate_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.CollegeID, objvTeachingCaseResCaseQuantitySenate_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.CollegeName, objvTeachingCaseResCaseQuantitySenate_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.id_XzMajor, objvTeachingCaseResCaseQuantitySenate_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.MajorID) == true)
{
string strComparisonOp_MajorID = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.MajorID, objvTeachingCaseResCaseQuantitySenate_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.MajorName) == true)
{
string strComparisonOp_MajorName = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.MajorName, objvTeachingCaseResCaseQuantitySenate_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.CourseId) == true)
{
string strComparisonOp_CourseId = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.CourseId, objvTeachingCaseResCaseQuantitySenate_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.CourseCode, objvTeachingCaseResCaseQuantitySenate_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.CourseName) == true)
{
string strComparisonOp_CourseName = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.CourseName, objvTeachingCaseResCaseQuantitySenate_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.ViewCount, objvTeachingCaseResCaseQuantitySenate_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.IsShow) == true)
{
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCaseQuantitySenate.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCaseQuantitySenate.IsShow);
}
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.DownloadNumber, objvTeachingCaseResCaseQuantitySenate_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.FileIntegration, objvTeachingCaseResCaseQuantitySenate_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.LikeCount, objvTeachingCaseResCaseQuantitySenate_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.CollectionCount, objvTeachingCaseResCaseQuantitySenate_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.CollegeNameA, objvTeachingCaseResCaseQuantitySenate_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.id_AppraiseType, objvTeachingCaseResCaseQuantitySenate_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.AppraiseTypeName, objvTeachingCaseResCaseQuantitySenate_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.SenateTheme) == true)
{
string strComparisonOp_SenateTheme = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.SenateTheme, objvTeachingCaseResCaseQuantitySenate_Cond.SenateTheme, strComparisonOp_SenateTheme);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.SenateContent) == true)
{
string strComparisonOp_SenateContent = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.SenateContent, objvTeachingCaseResCaseQuantitySenate_Cond.SenateContent, strComparisonOp_SenateContent);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOp_SenateTotalScore = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.SenateTotalScore, objvTeachingCaseResCaseQuantitySenate_Cond.SenateTotalScore, strComparisonOp_SenateTotalScore);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.SenateDate, objvTeachingCaseResCaseQuantitySenate_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.SenateTime) == true)
{
string strComparisonOp_SenateTime = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.SenateTime, objvTeachingCaseResCaseQuantitySenate_Cond.SenateTime, strComparisonOp_SenateTime);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.SenateIp) == true)
{
string strComparisonOp_SenateIp = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.SenateIp, objvTeachingCaseResCaseQuantitySenate_Cond.SenateIp, strComparisonOp_SenateIp);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.BrowseCount, objvTeachingCaseResCaseQuantitySenate_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.id_SenateGaugeVersion, objvTeachingCaseResCaseQuantitySenate_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID, objvTeachingCaseResCaseQuantitySenate_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName, objvTeachingCaseResCaseQuantitySenate_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore, objvTeachingCaseResCaseQuantitySenate_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UserId) == true)
{
string strComparisonOp_UserId = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UserId, objvTeachingCaseResCaseQuantitySenate_Cond.UserId, strComparisonOp_UserId);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UserNameWithUserId, objvTeachingCaseResCaseQuantitySenate_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UserName) == true)
{
string strComparisonOp_UserName = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UserName, objvTeachingCaseResCaseQuantitySenate_Cond.UserName, strComparisonOp_UserName);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UserKindId, objvTeachingCaseResCaseQuantitySenate_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UserKindName, objvTeachingCaseResCaseQuantitySenate_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UpdUser, objvTeachingCaseResCaseQuantitySenate_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.Memo) == true)
{
string strComparisonOp_Memo = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.Memo, objvTeachingCaseResCaseQuantitySenate_Cond.Memo, strComparisonOp_Memo);
}
if (objvTeachingCaseResCaseQuantitySenate_Cond.IsUpdated(convTeachingCaseResCaseQuantitySenate.UpdUserName) == true)
{
string strComparisonOp_UpdUserName = objvTeachingCaseResCaseQuantitySenate_Cond.dicFldComparisonOp[convTeachingCaseResCaseQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseQuantitySenate.UpdUserName, objvTeachingCaseResCaseQuantitySenate_Cond.UpdUserName, strComparisonOp_UpdUserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教学案例资源量化评议(vTeachingCaseResCaseQuantitySenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingCaseResCaseQuantitySenateWApi
{
private static readonly string mstrApiControllerName = "vTeachingCaseResCaseQuantitySenateApi";

 public clsvTeachingCaseResCaseQuantitySenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = null;
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
objvTeachingCaseResCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvTeachingCaseResCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingCaseResCaseQuantitySenateEN;
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
public static clsvTeachingCaseResCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_WA_Cache(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = null;
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
objvTeachingCaseResCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvTeachingCaseResCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingCaseResCaseQuantitySenateEN;
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
public static clsvTeachingCaseResCaseQuantitySenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = null;
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
objvTeachingCaseResCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvTeachingCaseResCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingCaseResCaseQuantitySenateEN;
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
public static clsvTeachingCaseResCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_Cache(long lngid_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingCaseResCaseQuantitySenateEN._CurrTabName_S);
List<clsvTeachingCaseResCaseQuantitySenateEN> arrvTeachingCaseResCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingCaseResCaseQuantitySenateEN> arrvTeachingCaseResCaseQuantitySenateObjLst_Sel =
from objvTeachingCaseResCaseQuantitySenateEN in arrvTeachingCaseResCaseQuantitySenateObjLst_Cache
where objvTeachingCaseResCaseQuantitySenateEN.id_microteachCaseQuantitySenate == lngid_microteachCaseQuantitySenate
select objvTeachingCaseResCaseQuantitySenateEN;
if (arrvTeachingCaseResCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvTeachingCaseResCaseQuantitySenateEN obj = clsvTeachingCaseResCaseQuantitySenateWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTeachingCaseResCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
 List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingCaseResCaseQuantitySenateEN._CurrTabName_S);
List<clsvTeachingCaseResCaseQuantitySenateEN> arrvTeachingCaseResCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingCaseResCaseQuantitySenateEN> arrvTeachingCaseResCaseQuantitySenateObjLst_Sel =
from objvTeachingCaseResCaseQuantitySenateEN in arrvTeachingCaseResCaseQuantitySenateObjLst_Cache
where arrId_microteachCaseQuantitySenate.Contains(objvTeachingCaseResCaseQuantitySenateEN.id_microteachCaseQuantitySenate)
select objvTeachingCaseResCaseQuantitySenateEN;
return arrvTeachingCaseResCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvTeachingCaseResCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateENS, clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateENT)
{
try
{
objvTeachingCaseResCaseQuantitySenateENT.UserTypeName = objvTeachingCaseResCaseQuantitySenateENS.UserTypeName; //用户类型名称
objvTeachingCaseResCaseQuantitySenateENT.id_microteachCaseQuantitySenate = objvTeachingCaseResCaseQuantitySenateENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateENT.FuncModuleId = objvTeachingCaseResCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvTeachingCaseResCaseQuantitySenateENT.FuncModuleName = objvTeachingCaseResCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvTeachingCaseResCaseQuantitySenateENT.id_MicroteachCase = objvTeachingCaseResCaseQuantitySenateENS.id_MicroteachCase; //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateENT.Id_TeachingCaseResCase = objvTeachingCaseResCaseQuantitySenateENS.Id_TeachingCaseResCase; //教学案例资源案例流水号
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
objvTeachingCaseResCaseQuantitySenateENT.id_XzCollege = objvTeachingCaseResCaseQuantitySenateENS.id_XzCollege; //学院流水号
objvTeachingCaseResCaseQuantitySenateENT.CollegeID = objvTeachingCaseResCaseQuantitySenateENS.CollegeID; //学院ID
objvTeachingCaseResCaseQuantitySenateENT.CollegeName = objvTeachingCaseResCaseQuantitySenateENS.CollegeName; //学院名称
objvTeachingCaseResCaseQuantitySenateENT.id_XzMajor = objvTeachingCaseResCaseQuantitySenateENS.id_XzMajor; //专业流水号
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
objvTeachingCaseResCaseQuantitySenateENT.id_AppraiseType = objvTeachingCaseResCaseQuantitySenateENS.id_AppraiseType; //评议类型流水号
objvTeachingCaseResCaseQuantitySenateENT.AppraiseTypeName = objvTeachingCaseResCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvTeachingCaseResCaseQuantitySenateENT.SenateTheme = objvTeachingCaseResCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvTeachingCaseResCaseQuantitySenateENT.SenateContent = objvTeachingCaseResCaseQuantitySenateENS.SenateContent; //评价内容
objvTeachingCaseResCaseQuantitySenateENT.SenateTotalScore = objvTeachingCaseResCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvTeachingCaseResCaseQuantitySenateENT.SenateDate = objvTeachingCaseResCaseQuantitySenateENS.SenateDate; //评价日期
objvTeachingCaseResCaseQuantitySenateENT.SenateTime = objvTeachingCaseResCaseQuantitySenateENS.SenateTime; //评价时间
objvTeachingCaseResCaseQuantitySenateENT.SenateIp = objvTeachingCaseResCaseQuantitySenateENS.SenateIp; //评议Ip
objvTeachingCaseResCaseQuantitySenateENT.BrowseCount = objvTeachingCaseResCaseQuantitySenateENS.BrowseCount; //浏览次数
objvTeachingCaseResCaseQuantitySenateENT.id_SenateGaugeVersion = objvTeachingCaseResCaseQuantitySenateENS.id_SenateGaugeVersion; //评价量表版本流水号
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
public static DataTable ToDataTable(List<clsvTeachingCaseResCaseQuantitySenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTeachingCaseResCaseQuantitySenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTeachingCaseResCaseQuantitySenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTeachingCaseResCaseQuantitySenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTeachingCaseResCaseQuantitySenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTeachingCaseResCaseQuantitySenateEN.AttributeName)
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
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingCaseResCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseWApi没有刷新缓存机制(clsTeachingCaseResCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingCaseResCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseTypeWApi没有刷新缓存机制(clsTeachingCaseResCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeWApi没有刷新缓存机制(clscc_ExcellentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeWApi没有刷新缓存机制(clsXzDegreeTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeWApi没有刷新缓存机制(clsXzMajorTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeWApi没有刷新缓存机制(clsXzMajorShoolTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenate");
//if (arrvTeachingCaseResCaseQuantitySenateObjLst_Cache == null)
//{
//arrvTeachingCaseResCaseQuantitySenateObjLst_Cache = await clsvTeachingCaseResCaseQuantitySenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvTeachingCaseResCaseQuantitySenateEN._CurrTabName_S);
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
public static List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvTeachingCaseResCaseQuantitySenateEN._CurrTabName_S);
List<clsvTeachingCaseResCaseQuantitySenateEN> arrvTeachingCaseResCaseQuantitySenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachingCaseResCaseQuantitySenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.Id_TeachingCaseResCase, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.SenateTheme, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.SenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.SenateTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.SenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.SenateIp, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseQuantitySenate.UpdUserName, Type.GetType("System.String"));
foreach (clsvTeachingCaseResCaseQuantitySenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTeachingCaseResCaseQuantitySenate.UserTypeName] = objInFor[convTeachingCaseResCaseQuantitySenate.UserTypeName];
objDR[convTeachingCaseResCaseQuantitySenate.id_microteachCaseQuantitySenate] = objInFor[convTeachingCaseResCaseQuantitySenate.id_microteachCaseQuantitySenate];
objDR[convTeachingCaseResCaseQuantitySenate.FuncModuleId] = objInFor[convTeachingCaseResCaseQuantitySenate.FuncModuleId];
objDR[convTeachingCaseResCaseQuantitySenate.FuncModuleName] = objInFor[convTeachingCaseResCaseQuantitySenate.FuncModuleName];
objDR[convTeachingCaseResCaseQuantitySenate.id_MicroteachCase] = objInFor[convTeachingCaseResCaseQuantitySenate.id_MicroteachCase];
objDR[convTeachingCaseResCaseQuantitySenate.Id_TeachingCaseResCase] = objInFor[convTeachingCaseResCaseQuantitySenate.Id_TeachingCaseResCase];
objDR[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] = objInFor[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID];
objDR[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] = objInFor[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName];
objDR[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] = objInFor[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme];
objDR[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] = objInFor[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate];
objDR[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] = objInFor[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime];
objDR[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] = objInFor[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn];
objDR[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] = objInFor[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn];
objDR[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] = objInFor[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName];
objDR[convTeachingCaseResCaseQuantitySenate.OwnerId] = objInFor[convTeachingCaseResCaseQuantitySenate.OwnerId];
objDR[convTeachingCaseResCaseQuantitySenate.OwnerName] = objInFor[convTeachingCaseResCaseQuantitySenate.OwnerName];
objDR[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] = objInFor[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId];
objDR[convTeachingCaseResCaseQuantitySenate.IsDualVideo] = objInFor[convTeachingCaseResCaseQuantitySenate.IsDualVideo];
objDR[convTeachingCaseResCaseQuantitySenate.id_XzCollege] = objInFor[convTeachingCaseResCaseQuantitySenate.id_XzCollege];
objDR[convTeachingCaseResCaseQuantitySenate.CollegeID] = objInFor[convTeachingCaseResCaseQuantitySenate.CollegeID];
objDR[convTeachingCaseResCaseQuantitySenate.CollegeName] = objInFor[convTeachingCaseResCaseQuantitySenate.CollegeName];
objDR[convTeachingCaseResCaseQuantitySenate.id_XzMajor] = objInFor[convTeachingCaseResCaseQuantitySenate.id_XzMajor];
objDR[convTeachingCaseResCaseQuantitySenate.MajorID] = objInFor[convTeachingCaseResCaseQuantitySenate.MajorID];
objDR[convTeachingCaseResCaseQuantitySenate.MajorName] = objInFor[convTeachingCaseResCaseQuantitySenate.MajorName];
objDR[convTeachingCaseResCaseQuantitySenate.CourseId] = objInFor[convTeachingCaseResCaseQuantitySenate.CourseId];
objDR[convTeachingCaseResCaseQuantitySenate.CourseCode] = objInFor[convTeachingCaseResCaseQuantitySenate.CourseCode];
objDR[convTeachingCaseResCaseQuantitySenate.CourseName] = objInFor[convTeachingCaseResCaseQuantitySenate.CourseName];
objDR[convTeachingCaseResCaseQuantitySenate.ViewCount] = objInFor[convTeachingCaseResCaseQuantitySenate.ViewCount];
objDR[convTeachingCaseResCaseQuantitySenate.IsShow] = objInFor[convTeachingCaseResCaseQuantitySenate.IsShow];
objDR[convTeachingCaseResCaseQuantitySenate.DownloadNumber] = objInFor[convTeachingCaseResCaseQuantitySenate.DownloadNumber];
objDR[convTeachingCaseResCaseQuantitySenate.FileIntegration] = objInFor[convTeachingCaseResCaseQuantitySenate.FileIntegration];
objDR[convTeachingCaseResCaseQuantitySenate.LikeCount] = objInFor[convTeachingCaseResCaseQuantitySenate.LikeCount];
objDR[convTeachingCaseResCaseQuantitySenate.CollectionCount] = objInFor[convTeachingCaseResCaseQuantitySenate.CollectionCount];
objDR[convTeachingCaseResCaseQuantitySenate.CollegeNameA] = objInFor[convTeachingCaseResCaseQuantitySenate.CollegeNameA];
objDR[convTeachingCaseResCaseQuantitySenate.id_AppraiseType] = objInFor[convTeachingCaseResCaseQuantitySenate.id_AppraiseType];
objDR[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] = objInFor[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName];
objDR[convTeachingCaseResCaseQuantitySenate.SenateTheme] = objInFor[convTeachingCaseResCaseQuantitySenate.SenateTheme];
objDR[convTeachingCaseResCaseQuantitySenate.SenateContent] = objInFor[convTeachingCaseResCaseQuantitySenate.SenateContent];
objDR[convTeachingCaseResCaseQuantitySenate.SenateTotalScore] = objInFor[convTeachingCaseResCaseQuantitySenate.SenateTotalScore];
objDR[convTeachingCaseResCaseQuantitySenate.SenateDate] = objInFor[convTeachingCaseResCaseQuantitySenate.SenateDate];
objDR[convTeachingCaseResCaseQuantitySenate.SenateTime] = objInFor[convTeachingCaseResCaseQuantitySenate.SenateTime];
objDR[convTeachingCaseResCaseQuantitySenate.SenateIp] = objInFor[convTeachingCaseResCaseQuantitySenate.SenateIp];
objDR[convTeachingCaseResCaseQuantitySenate.BrowseCount] = objInFor[convTeachingCaseResCaseQuantitySenate.BrowseCount];
objDR[convTeachingCaseResCaseQuantitySenate.id_SenateGaugeVersion] = objInFor[convTeachingCaseResCaseQuantitySenate.id_SenateGaugeVersion];
objDR[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] = objInFor[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID];
objDR[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] = objInFor[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName];
objDR[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] = objInFor[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore];
objDR[convTeachingCaseResCaseQuantitySenate.UserId] = objInFor[convTeachingCaseResCaseQuantitySenate.UserId];
objDR[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] = objInFor[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId];
objDR[convTeachingCaseResCaseQuantitySenate.UserName] = objInFor[convTeachingCaseResCaseQuantitySenate.UserName];
objDR[convTeachingCaseResCaseQuantitySenate.UserKindId] = objInFor[convTeachingCaseResCaseQuantitySenate.UserKindId];
objDR[convTeachingCaseResCaseQuantitySenate.UserKindName] = objInFor[convTeachingCaseResCaseQuantitySenate.UserKindName];
objDR[convTeachingCaseResCaseQuantitySenate.UpdUser] = objInFor[convTeachingCaseResCaseQuantitySenate.UpdUser];
objDR[convTeachingCaseResCaseQuantitySenate.Memo] = objInFor[convTeachingCaseResCaseQuantitySenate.Memo];
objDR[convTeachingCaseResCaseQuantitySenate.UpdUserName] = objInFor[convTeachingCaseResCaseQuantitySenate.UpdUserName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}