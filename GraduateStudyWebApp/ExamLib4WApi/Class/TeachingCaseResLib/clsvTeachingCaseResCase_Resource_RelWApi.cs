
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCase_Resource_RelWApi
 表名:vTeachingCaseResCase_Resource_Rel(01120425)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:25
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
public static class clsvTeachingCaseResCase_Resource_RelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN Setid_MicroteachCase_Resource_Rel(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFuncModuleId(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convTeachingCaseResCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convTeachingCaseResCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convTeachingCaseResCase_Resource_Rel.FuncModuleId);
objvTeachingCaseResCase_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FuncModuleId) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFuncModuleName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convTeachingCaseResCase_Resource_Rel.FuncModuleName);
objvTeachingCaseResCase_Resource_RelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FuncModuleName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FuncModuleName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FuncModuleName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN Setid_MicroteachCase(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convTeachingCaseResCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convTeachingCaseResCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convTeachingCaseResCase_Resource_Rel.id_MicroteachCase);
objvTeachingCaseResCase_Resource_RelEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.id_MicroteachCase) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.id_MicroteachCase, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_MicroteachCase] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseID, 8, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseID, 8, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID);
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID = strTeachingCaseResCaseID; //教学案例资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseName, 100, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName);
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName = strTeachingCaseResCaseName; //教学案例资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseTheme(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTheme, 200, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme);
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme = strTeachingCaseResCaseTheme; //教学案例资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseText(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseText, 8000, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText);
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText = strTeachingCaseResCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseDate(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDate, 8, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDate, 8, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate);
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate = strTeachingCaseResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseTime(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTime, 6, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTime, 6, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime);
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime = strTeachingCaseResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseDateIn(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn);
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn = strTeachingCaseResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseTimeIn(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn);
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn = strTeachingCaseResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN Setid_TeachingCaseResCaseType(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strid_TeachingCaseResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingCaseResCaseType, 4, convTeachingCaseResCase_Resource_Rel.id_TeachingCaseResCaseType);
clsCheckSql.CheckFieldForeignKey(strid_TeachingCaseResCaseType, 4, convTeachingCaseResCase_Resource_Rel.id_TeachingCaseResCaseType);
objvTeachingCaseResCase_Resource_RelEN.id_TeachingCaseResCaseType = strid_TeachingCaseResCaseType; //教学案例资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.id_TeachingCaseResCaseType) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.id_TeachingCaseResCaseType, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_TeachingCaseResCaseType] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseTypeName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTypeName, 30, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName);
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName = strTeachingCaseResCaseTypeName; //教学案例资源案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetOwnerId(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convTeachingCaseResCase_Resource_Rel.OwnerId);
objvTeachingCaseResCase_Resource_RelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.OwnerId) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.OwnerId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.OwnerId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetOwnerName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convTeachingCaseResCase_Resource_Rel.OwnerName);
objvTeachingCaseResCase_Resource_RelEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.OwnerName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.OwnerName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.OwnerName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetOwnerNameWithId(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convTeachingCaseResCase_Resource_Rel.OwnerNameWithId);
objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.OwnerNameWithId) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.OwnerNameWithId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN Setid_StudyLevel(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convTeachingCaseResCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convTeachingCaseResCase_Resource_Rel.id_StudyLevel);
objvTeachingCaseResCase_Resource_RelEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.id_StudyLevel) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.id_StudyLevel, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_StudyLevel] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetStudyLevelName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convTeachingCaseResCase_Resource_Rel.StudyLevelName);
objvTeachingCaseResCase_Resource_RelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.StudyLevelName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.StudyLevelName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.StudyLevelName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN Setid_TeachingPlan(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convTeachingCaseResCase_Resource_Rel.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convTeachingCaseResCase_Resource_Rel.id_TeachingPlan);
objvTeachingCaseResCase_Resource_RelEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.id_TeachingPlan) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.id_TeachingPlan, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_TeachingPlan] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN Setid_Discipline(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convTeachingCaseResCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convTeachingCaseResCase_Resource_Rel.id_Discipline);
objvTeachingCaseResCase_Resource_RelEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.id_Discipline) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.id_Discipline, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_Discipline] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetDisciplineID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convTeachingCaseResCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convTeachingCaseResCase_Resource_Rel.DisciplineID);
objvTeachingCaseResCase_Resource_RelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.DisciplineID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.DisciplineID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.DisciplineID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetDisciplineName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convTeachingCaseResCase_Resource_Rel.DisciplineName);
objvTeachingCaseResCase_Resource_RelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.DisciplineName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.DisciplineName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.DisciplineName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetsenateGaugeVersionID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID);
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetsenateGaugeVersionName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName);
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetVersionNo(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, int intVersionNo, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.VersionNo) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.VersionNo, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.VersionNo] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN Setid_TeachSkill(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convTeachingCaseResCase_Resource_Rel.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convTeachingCaseResCase_Resource_Rel.id_TeachSkill);
objvTeachingCaseResCase_Resource_RelEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.id_TeachSkill) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.id_TeachSkill, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_TeachSkill] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachSkillID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convTeachingCaseResCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convTeachingCaseResCase_Resource_Rel.TeachSkillID);
objvTeachingCaseResCase_Resource_RelEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachSkillID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachSkillID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetSkillTypeName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convTeachingCaseResCase_Resource_Rel.SkillTypeName);
objvTeachingCaseResCase_Resource_RelEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.SkillTypeName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.SkillTypeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SkillTypeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachSkillName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convTeachingCaseResCase_Resource_Rel.TeachSkillName);
objvTeachingCaseResCase_Resource_RelEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachSkillName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachSkillName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachSkillTheory(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convTeachingCaseResCase_Resource_Rel.TeachSkillTheory);
objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachSkillTheory) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachSkillTheory, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachSkillOperMethod(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod);
objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN Setid_SkillType(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convTeachingCaseResCase_Resource_Rel.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convTeachingCaseResCase_Resource_Rel.id_SkillType);
objvTeachingCaseResCase_Resource_RelEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.id_SkillType) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.id_SkillType, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_SkillType] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetSkillTypeID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convTeachingCaseResCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convTeachingCaseResCase_Resource_Rel.SkillTypeID);
objvTeachingCaseResCase_Resource_RelEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.SkillTypeID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.SkillTypeID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SkillTypeID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCaseLevelId(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convTeachingCaseResCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convTeachingCaseResCase_Resource_Rel.CaseLevelId);
objvTeachingCaseResCase_Resource_RelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CaseLevelId) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CaseLevelId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CaseLevelId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIsDualVideo(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IsDualVideo) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IsDualVideo, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IsDualVideo] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN Setid_XzCollege(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convTeachingCaseResCase_Resource_Rel.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convTeachingCaseResCase_Resource_Rel.id_XzCollege);
objvTeachingCaseResCase_Resource_RelEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.id_XzCollege) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.id_XzCollege, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_XzCollege] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCollegeID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convTeachingCaseResCase_Resource_Rel.CollegeID);
objvTeachingCaseResCase_Resource_RelEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CollegeID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CollegeID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollegeID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCollegeName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachingCaseResCase_Resource_Rel.CollegeName);
objvTeachingCaseResCase_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CollegeName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN Setid_XzMajor(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convTeachingCaseResCase_Resource_Rel.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convTeachingCaseResCase_Resource_Rel.id_XzMajor);
objvTeachingCaseResCase_Resource_RelEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.id_XzMajor) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.id_XzMajor, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_XzMajor] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetMajorID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convTeachingCaseResCase_Resource_Rel.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convTeachingCaseResCase_Resource_Rel.MajorID);
objvTeachingCaseResCase_Resource_RelEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.MajorID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.MajorID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.MajorID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetMajorName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convTeachingCaseResCase_Resource_Rel.MajorName);
objvTeachingCaseResCase_Resource_RelEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.MajorName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.MajorName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.MajorName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCourseId(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convTeachingCaseResCase_Resource_Rel.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convTeachingCaseResCase_Resource_Rel.CourseId);
objvTeachingCaseResCase_Resource_RelEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CourseId) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CourseId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCourseCode(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convTeachingCaseResCase_Resource_Rel.CourseCode);
objvTeachingCaseResCase_Resource_RelEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CourseCode) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CourseCode, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseCode] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCourseName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convTeachingCaseResCase_Resource_Rel.CourseName);
objvTeachingCaseResCase_Resource_RelEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CourseName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CourseName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCourseChapterId(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convTeachingCaseResCase_Resource_Rel.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convTeachingCaseResCase_Resource_Rel.CourseChapterId);
objvTeachingCaseResCase_Resource_RelEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CourseChapterId) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CourseChapterId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseChapterId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCourseChapterName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convTeachingCaseResCase_Resource_Rel.CourseChapterName);
objvTeachingCaseResCase_Resource_RelEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CourseChapterName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CourseChapterName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseChapterName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetParentNodeID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convTeachingCaseResCase_Resource_Rel.ParentNodeID);
objvTeachingCaseResCase_Resource_RelEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ParentNodeID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ParentNodeID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ParentNodeID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetParentNodeName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convTeachingCaseResCase_Resource_Rel.ParentNodeName);
objvTeachingCaseResCase_Resource_RelEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ParentNodeName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ParentNodeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ParentNodeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetViewCount(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, int intViewCount, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ViewCount) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ViewCount, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ViewCount] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIsShow(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, bool bolIsShow, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IsShow) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IsShow, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IsShow] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetDownloadNumber(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, int intDownloadNumber, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.DownloadNumber) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.DownloadNumber, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.DownloadNumber] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileIntegration(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, int intFileIntegration, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileIntegration) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileIntegration, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileIntegration] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetLikeCount(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, long lngLikeCount, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.LikeCount) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.LikeCount, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.LikeCount] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCollectionCount(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, long lngCollectionCount, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CollectionCount) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CollectionCount, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollectionCount] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetRecommendedDegreeId(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId);
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetRecommendedDegreeName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName);
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetBrowseCount4Case(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.BrowseCount4Case) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN Setid_Resource(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convTeachingCaseResCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convTeachingCaseResCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convTeachingCaseResCase_Resource_Rel.id_Resource);
objvTeachingCaseResCase_Resource_RelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.id_Resource) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.id_Resource, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_Resource] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetResourceID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convTeachingCaseResCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convTeachingCaseResCase_Resource_Rel.ResourceID);
objvTeachingCaseResCase_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ResourceID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetResourceName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convTeachingCaseResCase_Resource_Rel.ResourceName);
objvTeachingCaseResCase_Resource_RelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ResourceName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ResourceName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN Setid_FtpResource(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convTeachingCaseResCase_Resource_Rel.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convTeachingCaseResCase_Resource_Rel.id_FtpResource);
objvTeachingCaseResCase_Resource_RelEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.id_FtpResource) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.id_FtpResource, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_FtpResource] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN Setid_File(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convTeachingCaseResCase_Resource_Rel.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convTeachingCaseResCase_Resource_Rel.id_File);
objvTeachingCaseResCase_Resource_RelEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.id_File) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.id_File, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_File] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convTeachingCaseResCase_Resource_Rel.FileName);
objvTeachingCaseResCase_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileType(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convTeachingCaseResCase_Resource_Rel.FileType);
objvTeachingCaseResCase_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileType) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetSaveDate(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convTeachingCaseResCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convTeachingCaseResCase_Resource_Rel.SaveDate);
objvTeachingCaseResCase_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.SaveDate) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileSize(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convTeachingCaseResCase_Resource_Rel.FileSize);
objvTeachingCaseResCase_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileSize) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetSaveTime(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convTeachingCaseResCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convTeachingCaseResCase_Resource_Rel.SaveTime);
objvTeachingCaseResCase_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.SaveTime) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFtpResourceID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convTeachingCaseResCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convTeachingCaseResCase_Resource_Rel.FtpResourceID);
objvTeachingCaseResCase_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FtpResourceID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileOriginalName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convTeachingCaseResCase_Resource_Rel.FileOriginalName);
objvTeachingCaseResCase_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileOriginalName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileDirName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convTeachingCaseResCase_Resource_Rel.FileDirName);
objvTeachingCaseResCase_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileDirName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileRename(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convTeachingCaseResCase_Resource_Rel.FileRename);
objvTeachingCaseResCase_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileRename) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileUpDate(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convTeachingCaseResCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convTeachingCaseResCase_Resource_Rel.FileUpDate);
objvTeachingCaseResCase_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileUpDate) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileUpTime(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convTeachingCaseResCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convTeachingCaseResCase_Resource_Rel.FileUpTime);
objvTeachingCaseResCase_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileUpTime) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetSaveMode(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.SaveMode) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN Setid_ResourceType(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convTeachingCaseResCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convTeachingCaseResCase_Resource_Rel.id_ResourceType);
objvTeachingCaseResCase_Resource_RelEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.id_ResourceType) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.id_ResourceType, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_ResourceType] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetResourceTypeID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convTeachingCaseResCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convTeachingCaseResCase_Resource_Rel.ResourceTypeID);
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ResourceTypeID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetResourceTypeName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convTeachingCaseResCase_Resource_Rel.ResourceTypeName);
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ResourceTypeName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetResourceOwner(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convTeachingCaseResCase_Resource_Rel.ResourceOwner);
objvTeachingCaseResCase_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ResourceOwner) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetftpFileType(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convTeachingCaseResCase_Resource_Rel.ftpFileType);
objvTeachingCaseResCase_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ftpFileType) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetftpFileSize(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convTeachingCaseResCase_Resource_Rel.ftpFileSize);
objvTeachingCaseResCase_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ftpFileSize) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetftpResourceOwner(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convTeachingCaseResCase_Resource_Rel.ftpResourceOwner);
objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ftpResourceOwner) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileOriginName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convTeachingCaseResCase_Resource_Rel.FileOriginName);
objvTeachingCaseResCase_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileOriginName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIsExistFile(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IsExistFile) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileNewName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convTeachingCaseResCase_Resource_Rel.FileNewName);
objvTeachingCaseResCase_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileNewName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileOldName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convTeachingCaseResCase_Resource_Rel.FileOldName);
objvTeachingCaseResCase_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileOldName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIsMain(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IsMain) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN Setid_UsingMode(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strid_UsingMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UsingMode, 4, convTeachingCaseResCase_Resource_Rel.id_UsingMode);
clsCheckSql.CheckFieldForeignKey(strid_UsingMode, 4, convTeachingCaseResCase_Resource_Rel.id_UsingMode);
objvTeachingCaseResCase_Resource_RelEN.id_UsingMode = strid_UsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.id_UsingMode) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.id_UsingMode, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_UsingMode] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIsVisible(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IsVisible) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIndexNO(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, int intIndexNO, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IndexNO) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetBrowseCount(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, int intBrowseCount, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.BrowseCount) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetUpdDate(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTeachingCaseResCase_Resource_Rel.UpdDate);
objvTeachingCaseResCase_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.UpdDate) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetUpdUser(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTeachingCaseResCase_Resource_Rel.UpdUser);
objvTeachingCaseResCase_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.UpdUser) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetMemo(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingCaseResCase_Resource_Rel.Memo);
objvTeachingCaseResCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.Memo) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCollegeNameA(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeachingCaseResCase_Resource_Rel.CollegeNameA);
objvTeachingCaseResCase_Resource_RelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CollegeNameA) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CollegeNameA, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollegeNameA] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCourseChapterReferred(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convTeachingCaseResCase_Resource_Rel.CourseChapterReferred);
objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CourseChapterReferred) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CourseChapterReferred, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetParentNodeReferred(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convTeachingCaseResCase_Resource_Rel.ParentNodeReferred);
objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ParentNodeReferred) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ParentNodeReferred, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_Rel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.id_MicroteachCase_Resource_Rel, objvTeachingCaseResCase_Resource_Rel_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FuncModuleId, objvTeachingCaseResCase_Resource_Rel_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FuncModuleName, objvTeachingCaseResCase_Resource_Rel_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.id_MicroteachCase, objvTeachingCaseResCase_Resource_Rel_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID) == true)
{
string strComparisonOp_TeachingCaseResCaseID = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID, objvTeachingCaseResCase_Resource_Rel_Cond.TeachingCaseResCaseID, strComparisonOp_TeachingCaseResCaseID);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName) == true)
{
string strComparisonOp_TeachingCaseResCaseName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName, objvTeachingCaseResCase_Resource_Rel_Cond.TeachingCaseResCaseName, strComparisonOp_TeachingCaseResCaseName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme) == true)
{
string strComparisonOp_TeachingCaseResCaseTheme = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme, objvTeachingCaseResCase_Resource_Rel_Cond.TeachingCaseResCaseTheme, strComparisonOp_TeachingCaseResCaseTheme);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText) == true)
{
string strComparisonOp_TeachingCaseResCaseText = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText, objvTeachingCaseResCase_Resource_Rel_Cond.TeachingCaseResCaseText, strComparisonOp_TeachingCaseResCaseText);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate) == true)
{
string strComparisonOp_TeachingCaseResCaseDate = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate, objvTeachingCaseResCase_Resource_Rel_Cond.TeachingCaseResCaseDate, strComparisonOp_TeachingCaseResCaseDate);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime) == true)
{
string strComparisonOp_TeachingCaseResCaseTime = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime, objvTeachingCaseResCase_Resource_Rel_Cond.TeachingCaseResCaseTime, strComparisonOp_TeachingCaseResCaseTime);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn) == true)
{
string strComparisonOp_TeachingCaseResCaseDateIn = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn, objvTeachingCaseResCase_Resource_Rel_Cond.TeachingCaseResCaseDateIn, strComparisonOp_TeachingCaseResCaseDateIn);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn) == true)
{
string strComparisonOp_TeachingCaseResCaseTimeIn = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn, objvTeachingCaseResCase_Resource_Rel_Cond.TeachingCaseResCaseTimeIn, strComparisonOp_TeachingCaseResCaseTimeIn);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.id_TeachingCaseResCaseType) == true)
{
string strComparisonOp_id_TeachingCaseResCaseType = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_TeachingCaseResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.id_TeachingCaseResCaseType, objvTeachingCaseResCase_Resource_Rel_Cond.id_TeachingCaseResCaseType, strComparisonOp_id_TeachingCaseResCaseType);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName) == true)
{
string strComparisonOp_TeachingCaseResCaseTypeName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName, objvTeachingCaseResCase_Resource_Rel_Cond.TeachingCaseResCaseTypeName, strComparisonOp_TeachingCaseResCaseTypeName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.OwnerId, objvTeachingCaseResCase_Resource_Rel_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.OwnerName, objvTeachingCaseResCase_Resource_Rel_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.OwnerNameWithId, objvTeachingCaseResCase_Resource_Rel_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.id_StudyLevel, objvTeachingCaseResCase_Resource_Rel_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.StudyLevelName, objvTeachingCaseResCase_Resource_Rel_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.id_TeachingPlan, objvTeachingCaseResCase_Resource_Rel_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.id_Discipline, objvTeachingCaseResCase_Resource_Rel_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.DisciplineID, objvTeachingCaseResCase_Resource_Rel_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.DisciplineName, objvTeachingCaseResCase_Resource_Rel_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID, objvTeachingCaseResCase_Resource_Rel_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName, objvTeachingCaseResCase_Resource_Rel_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore, objvTeachingCaseResCase_Resource_Rel_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.VersionNo, objvTeachingCaseResCase_Resource_Rel_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.id_TeachSkill, objvTeachingCaseResCase_Resource_Rel_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachSkillID, objvTeachingCaseResCase_Resource_Rel_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.SkillTypeName, objvTeachingCaseResCase_Resource_Rel_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachSkillName, objvTeachingCaseResCase_Resource_Rel_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachSkillTheory, objvTeachingCaseResCase_Resource_Rel_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod, objvTeachingCaseResCase_Resource_Rel_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.id_SkillType, objvTeachingCaseResCase_Resource_Rel_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.SkillTypeID, objvTeachingCaseResCase_Resource_Rel_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CaseLevelId, objvTeachingCaseResCase_Resource_Rel_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IsDualVideo) == true)
{
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Resource_Rel.IsDualVideo);
}
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.id_XzCollege, objvTeachingCaseResCase_Resource_Rel_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CollegeID, objvTeachingCaseResCase_Resource_Rel_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CollegeName, objvTeachingCaseResCase_Resource_Rel_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.id_XzMajor, objvTeachingCaseResCase_Resource_Rel_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.MajorID) == true)
{
string strComparisonOp_MajorID = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.MajorID, objvTeachingCaseResCase_Resource_Rel_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.MajorName) == true)
{
string strComparisonOp_MajorName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.MajorName, objvTeachingCaseResCase_Resource_Rel_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CourseId) == true)
{
string strComparisonOp_CourseId = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CourseId, objvTeachingCaseResCase_Resource_Rel_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CourseCode, objvTeachingCaseResCase_Resource_Rel_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CourseName) == true)
{
string strComparisonOp_CourseName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CourseName, objvTeachingCaseResCase_Resource_Rel_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CourseChapterId, objvTeachingCaseResCase_Resource_Rel_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CourseChapterName, objvTeachingCaseResCase_Resource_Rel_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ParentNodeID, objvTeachingCaseResCase_Resource_Rel_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ParentNodeName, objvTeachingCaseResCase_Resource_Rel_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.ViewCount, objvTeachingCaseResCase_Resource_Rel_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IsShow) == true)
{
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Resource_Rel.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Resource_Rel.IsShow);
}
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.DownloadNumber, objvTeachingCaseResCase_Resource_Rel_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.FileIntegration, objvTeachingCaseResCase_Resource_Rel_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.LikeCount, objvTeachingCaseResCase_Resource_Rel_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.CollectionCount, objvTeachingCaseResCase_Resource_Rel_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId, objvTeachingCaseResCase_Resource_Rel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName, objvTeachingCaseResCase_Resource_Rel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.BrowseCount4Case, objvTeachingCaseResCase_Resource_Rel_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.id_Resource, objvTeachingCaseResCase_Resource_Rel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ResourceID, objvTeachingCaseResCase_Resource_Rel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ResourceName, objvTeachingCaseResCase_Resource_Rel_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.id_FtpResource, objvTeachingCaseResCase_Resource_Rel_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.id_File) == true)
{
string strComparisonOp_id_File = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.id_File, objvTeachingCaseResCase_Resource_Rel_Cond.id_File, strComparisonOp_id_File);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileName) == true)
{
string strComparisonOp_FileName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileName, objvTeachingCaseResCase_Resource_Rel_Cond.FileName, strComparisonOp_FileName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileType) == true)
{
string strComparisonOp_FileType = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileType, objvTeachingCaseResCase_Resource_Rel_Cond.FileType, strComparisonOp_FileType);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.SaveDate, objvTeachingCaseResCase_Resource_Rel_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileSize) == true)
{
string strComparisonOp_FileSize = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileSize, objvTeachingCaseResCase_Resource_Rel_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.SaveTime, objvTeachingCaseResCase_Resource_Rel_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FtpResourceID, objvTeachingCaseResCase_Resource_Rel_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileOriginalName, objvTeachingCaseResCase_Resource_Rel_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileDirName, objvTeachingCaseResCase_Resource_Rel_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileRename) == true)
{
string strComparisonOp_FileRename = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileRename, objvTeachingCaseResCase_Resource_Rel_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileUpDate, objvTeachingCaseResCase_Resource_Rel_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileUpTime, objvTeachingCaseResCase_Resource_Rel_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.SaveMode) == true)
{
if (objvTeachingCaseResCase_Resource_Rel_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Resource_Rel.SaveMode);
}
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.id_ResourceType, objvTeachingCaseResCase_Resource_Rel_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ResourceTypeID, objvTeachingCaseResCase_Resource_Rel_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ResourceTypeName, objvTeachingCaseResCase_Resource_Rel_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ResourceOwner, objvTeachingCaseResCase_Resource_Rel_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ftpFileType, objvTeachingCaseResCase_Resource_Rel_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ftpFileSize, objvTeachingCaseResCase_Resource_Rel_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ftpResourceOwner, objvTeachingCaseResCase_Resource_Rel_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileOriginName, objvTeachingCaseResCase_Resource_Rel_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IsExistFile) == true)
{
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Resource_Rel.IsExistFile);
}
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileNewName, objvTeachingCaseResCase_Resource_Rel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileOldName, objvTeachingCaseResCase_Resource_Rel_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IsMain) == true)
{
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Resource_Rel.IsMain);
}
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.id_UsingMode) == true)
{
string strComparisonOp_id_UsingMode = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.id_UsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.id_UsingMode, objvTeachingCaseResCase_Resource_Rel_Cond.id_UsingMode, strComparisonOp_id_UsingMode);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IsVisible) == true)
{
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Resource_Rel.IsVisible);
}
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.IndexNO, objvTeachingCaseResCase_Resource_Rel_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.BrowseCount, objvTeachingCaseResCase_Resource_Rel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.UpdDate, objvTeachingCaseResCase_Resource_Rel_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.UpdUser, objvTeachingCaseResCase_Resource_Rel_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.Memo) == true)
{
string strComparisonOp_Memo = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.Memo, objvTeachingCaseResCase_Resource_Rel_Cond.Memo, strComparisonOp_Memo);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CollegeNameA, objvTeachingCaseResCase_Resource_Rel_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CourseChapterReferred, objvTeachingCaseResCase_Resource_Rel_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvTeachingCaseResCase_Resource_Rel_Cond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvTeachingCaseResCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ParentNodeReferred, objvTeachingCaseResCase_Resource_Rel_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教学案例资源案例资源关系(vTeachingCaseResCase_Resource_Rel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingCaseResCase_Resource_RelWApi
{
private static readonly string mstrApiControllerName = "vTeachingCaseResCase_Resource_RelApi";

 public clsvTeachingCaseResCase_Resource_RelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase_Resource_Rel"] = lngid_MicroteachCase_Resource_Rel.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachingCaseResCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvTeachingCaseResCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingCaseResCase_Resource_RelEN;
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
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_WA_Cache(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase_Resource_Rel"] = lngid_MicroteachCase_Resource_Rel.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachingCaseResCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvTeachingCaseResCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingCaseResCase_Resource_RelEN;
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
public static clsvTeachingCaseResCase_Resource_RelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = null;
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
objvTeachingCaseResCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvTeachingCaseResCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingCaseResCase_Resource_RelEN;
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
 /// <param name = "lngid_MicroteachCase_Resource_Rel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingCaseResCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_Cache(long lngid_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingCaseResCase_Resource_RelEN._CurrTabName_S);
List<clsvTeachingCaseResCase_Resource_RelEN> arrvTeachingCaseResCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingCaseResCase_Resource_RelEN> arrvTeachingCaseResCase_Resource_RelObjLst_Sel =
from objvTeachingCaseResCase_Resource_RelEN in arrvTeachingCaseResCase_Resource_RelObjLst_Cache
where objvTeachingCaseResCase_Resource_RelEN.id_MicroteachCase_Resource_Rel == lngid_MicroteachCase_Resource_Rel
select objvTeachingCaseResCase_Resource_RelEN;
if (arrvTeachingCaseResCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvTeachingCaseResCase_Resource_RelEN obj = clsvTeachingCaseResCase_Resource_RelWApi.GetObjByid_MicroteachCase_Resource_Rel(lngid_MicroteachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTeachingCaseResCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
 List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCase_Resource_RelLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCase_Resource_Rel);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_MicroteachCase_Resource_Rel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvTeachingCaseResCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingCaseResCase_Resource_RelEN._CurrTabName_S);
List<clsvTeachingCaseResCase_Resource_RelEN> arrvTeachingCaseResCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingCaseResCase_Resource_RelEN> arrvTeachingCaseResCase_Resource_RelObjLst_Sel =
from objvTeachingCaseResCase_Resource_RelEN in arrvTeachingCaseResCase_Resource_RelObjLst_Cache
where arrId_MicroteachCase_Resource_Rel.Contains(objvTeachingCaseResCase_Resource_RelEN.id_MicroteachCase_Resource_Rel)
select objvTeachingCaseResCase_Resource_RelEN;
return arrvTeachingCaseResCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_WA_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCase_Resource_RelLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCase_Resource_Rel);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_MicroteachCase_Resource_Rel)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase_Resource_Rel"] = lngid_MicroteachCase_Resource_Rel.ToString()
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
 /// <param name = "objvTeachingCaseResCase_Resource_RelENS">源对象</param>
 /// <param name = "objvTeachingCaseResCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelENS, clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelENT)
{
try
{
objvTeachingCaseResCase_Resource_RelENT.id_MicroteachCase_Resource_Rel = objvTeachingCaseResCase_Resource_RelENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvTeachingCaseResCase_Resource_RelENT.FuncModuleId = objvTeachingCaseResCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvTeachingCaseResCase_Resource_RelENT.FuncModuleName = objvTeachingCaseResCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvTeachingCaseResCase_Resource_RelENT.id_MicroteachCase = objvTeachingCaseResCase_Resource_RelENS.id_MicroteachCase; //微格教学案例流水号
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseID = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseID; //教学案例资源案例ID
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseName = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseTheme = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseText = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseText; //案例文本内容
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseDate = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseDate; //视频资源日期
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseTime = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTime; //视频资源时间
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseDateIn = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseDateIn; //案例入库日期
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseTimeIn = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTimeIn; //案例入库时间
objvTeachingCaseResCase_Resource_RelENT.id_TeachingCaseResCaseType = objvTeachingCaseResCase_Resource_RelENS.id_TeachingCaseResCaseType; //教学案例资源类型流水号
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseTypeName = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
objvTeachingCaseResCase_Resource_RelENT.OwnerId = objvTeachingCaseResCase_Resource_RelENS.OwnerId; //拥有者Id
objvTeachingCaseResCase_Resource_RelENT.OwnerName = objvTeachingCaseResCase_Resource_RelENS.OwnerName; //拥有者姓名
objvTeachingCaseResCase_Resource_RelENT.OwnerNameWithId = objvTeachingCaseResCase_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvTeachingCaseResCase_Resource_RelENT.id_StudyLevel = objvTeachingCaseResCase_Resource_RelENS.id_StudyLevel; //id_StudyLevel
objvTeachingCaseResCase_Resource_RelENT.StudyLevelName = objvTeachingCaseResCase_Resource_RelENS.StudyLevelName; //学段名称
objvTeachingCaseResCase_Resource_RelENT.id_TeachingPlan = objvTeachingCaseResCase_Resource_RelENS.id_TeachingPlan; //教案流水号
objvTeachingCaseResCase_Resource_RelENT.id_Discipline = objvTeachingCaseResCase_Resource_RelENS.id_Discipline; //学科流水号
objvTeachingCaseResCase_Resource_RelENT.DisciplineID = objvTeachingCaseResCase_Resource_RelENS.DisciplineID; //学科ID
objvTeachingCaseResCase_Resource_RelENT.DisciplineName = objvTeachingCaseResCase_Resource_RelENS.DisciplineName; //学科名称
objvTeachingCaseResCase_Resource_RelENT.senateGaugeVersionID = objvTeachingCaseResCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvTeachingCaseResCase_Resource_RelENT.senateGaugeVersionName = objvTeachingCaseResCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvTeachingCaseResCase_Resource_RelENT.senateGaugeVersionTtlScore = objvTeachingCaseResCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvTeachingCaseResCase_Resource_RelENT.VersionNo = objvTeachingCaseResCase_Resource_RelENS.VersionNo; //版本号
objvTeachingCaseResCase_Resource_RelENT.id_TeachSkill = objvTeachingCaseResCase_Resource_RelENS.id_TeachSkill; //教学技能流水号
objvTeachingCaseResCase_Resource_RelENT.TeachSkillID = objvTeachingCaseResCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvTeachingCaseResCase_Resource_RelENT.SkillTypeName = objvTeachingCaseResCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvTeachingCaseResCase_Resource_RelENT.TeachSkillName = objvTeachingCaseResCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvTeachingCaseResCase_Resource_RelENT.TeachSkillTheory = objvTeachingCaseResCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvTeachingCaseResCase_Resource_RelENT.TeachSkillOperMethod = objvTeachingCaseResCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachingCaseResCase_Resource_RelENT.id_SkillType = objvTeachingCaseResCase_Resource_RelENS.id_SkillType; //技能类型流水号
objvTeachingCaseResCase_Resource_RelENT.SkillTypeID = objvTeachingCaseResCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvTeachingCaseResCase_Resource_RelENT.CaseLevelId = objvTeachingCaseResCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvTeachingCaseResCase_Resource_RelENT.IsDualVideo = objvTeachingCaseResCase_Resource_RelENS.IsDualVideo; //是否双视频
objvTeachingCaseResCase_Resource_RelENT.id_XzCollege = objvTeachingCaseResCase_Resource_RelENS.id_XzCollege; //学院流水号
objvTeachingCaseResCase_Resource_RelENT.CollegeID = objvTeachingCaseResCase_Resource_RelENS.CollegeID; //学院ID
objvTeachingCaseResCase_Resource_RelENT.CollegeName = objvTeachingCaseResCase_Resource_RelENS.CollegeName; //学院名称
objvTeachingCaseResCase_Resource_RelENT.id_XzMajor = objvTeachingCaseResCase_Resource_RelENS.id_XzMajor; //专业流水号
objvTeachingCaseResCase_Resource_RelENT.MajorID = objvTeachingCaseResCase_Resource_RelENS.MajorID; //专业ID
objvTeachingCaseResCase_Resource_RelENT.MajorName = objvTeachingCaseResCase_Resource_RelENS.MajorName; //专业名称
objvTeachingCaseResCase_Resource_RelENT.CourseId = objvTeachingCaseResCase_Resource_RelENS.CourseId; //课程Id
objvTeachingCaseResCase_Resource_RelENT.CourseCode = objvTeachingCaseResCase_Resource_RelENS.CourseCode; //课程代码
objvTeachingCaseResCase_Resource_RelENT.CourseName = objvTeachingCaseResCase_Resource_RelENS.CourseName; //课程名称
objvTeachingCaseResCase_Resource_RelENT.CourseChapterId = objvTeachingCaseResCase_Resource_RelENS.CourseChapterId; //课程章节ID
objvTeachingCaseResCase_Resource_RelENT.CourseChapterName = objvTeachingCaseResCase_Resource_RelENS.CourseChapterName; //课程章节名称
objvTeachingCaseResCase_Resource_RelENT.ParentNodeID = objvTeachingCaseResCase_Resource_RelENS.ParentNodeID; //父节点编号
objvTeachingCaseResCase_Resource_RelENT.ParentNodeName = objvTeachingCaseResCase_Resource_RelENS.ParentNodeName; //父节点名称
objvTeachingCaseResCase_Resource_RelENT.ViewCount = objvTeachingCaseResCase_Resource_RelENS.ViewCount; //浏览量
objvTeachingCaseResCase_Resource_RelENT.IsShow = objvTeachingCaseResCase_Resource_RelENS.IsShow; //是否启用
objvTeachingCaseResCase_Resource_RelENT.DownloadNumber = objvTeachingCaseResCase_Resource_RelENS.DownloadNumber; //下载数目
objvTeachingCaseResCase_Resource_RelENT.FileIntegration = objvTeachingCaseResCase_Resource_RelENS.FileIntegration; //文件积分
objvTeachingCaseResCase_Resource_RelENT.LikeCount = objvTeachingCaseResCase_Resource_RelENS.LikeCount; //资源喜欢数量
objvTeachingCaseResCase_Resource_RelENT.CollectionCount = objvTeachingCaseResCase_Resource_RelENS.CollectionCount; //收藏数量
objvTeachingCaseResCase_Resource_RelENT.RecommendedDegreeId = objvTeachingCaseResCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvTeachingCaseResCase_Resource_RelENT.RecommendedDegreeName = objvTeachingCaseResCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvTeachingCaseResCase_Resource_RelENT.BrowseCount4Case = objvTeachingCaseResCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvTeachingCaseResCase_Resource_RelENT.id_Resource = objvTeachingCaseResCase_Resource_RelENS.id_Resource; //资源流水号
objvTeachingCaseResCase_Resource_RelENT.ResourceID = objvTeachingCaseResCase_Resource_RelENS.ResourceID; //资源ID
objvTeachingCaseResCase_Resource_RelENT.ResourceName = objvTeachingCaseResCase_Resource_RelENS.ResourceName; //资源名称
objvTeachingCaseResCase_Resource_RelENT.id_FtpResource = objvTeachingCaseResCase_Resource_RelENS.id_FtpResource; //FTP资源流水号
objvTeachingCaseResCase_Resource_RelENT.id_File = objvTeachingCaseResCase_Resource_RelENS.id_File; //文件流水号
objvTeachingCaseResCase_Resource_RelENT.FileName = objvTeachingCaseResCase_Resource_RelENS.FileName; //文件名称
objvTeachingCaseResCase_Resource_RelENT.FileType = objvTeachingCaseResCase_Resource_RelENS.FileType; //文件类型
objvTeachingCaseResCase_Resource_RelENT.SaveDate = objvTeachingCaseResCase_Resource_RelENS.SaveDate; //创建日期
objvTeachingCaseResCase_Resource_RelENT.FileSize = objvTeachingCaseResCase_Resource_RelENS.FileSize; //文件大小
objvTeachingCaseResCase_Resource_RelENT.SaveTime = objvTeachingCaseResCase_Resource_RelENS.SaveTime; //创建时间
objvTeachingCaseResCase_Resource_RelENT.FtpResourceID = objvTeachingCaseResCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvTeachingCaseResCase_Resource_RelENT.FileOriginalName = objvTeachingCaseResCase_Resource_RelENS.FileOriginalName; //文件原名
objvTeachingCaseResCase_Resource_RelENT.FileDirName = objvTeachingCaseResCase_Resource_RelENS.FileDirName; //文件目录名
objvTeachingCaseResCase_Resource_RelENT.FileRename = objvTeachingCaseResCase_Resource_RelENS.FileRename; //文件新名
objvTeachingCaseResCase_Resource_RelENT.FileUpDate = objvTeachingCaseResCase_Resource_RelENS.FileUpDate; //创建日期
objvTeachingCaseResCase_Resource_RelENT.FileUpTime = objvTeachingCaseResCase_Resource_RelENS.FileUpTime; //创建时间
objvTeachingCaseResCase_Resource_RelENT.SaveMode = objvTeachingCaseResCase_Resource_RelENS.SaveMode; //文件存放方式
objvTeachingCaseResCase_Resource_RelENT.id_ResourceType = objvTeachingCaseResCase_Resource_RelENS.id_ResourceType; //资源类型流水号
objvTeachingCaseResCase_Resource_RelENT.ResourceTypeID = objvTeachingCaseResCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvTeachingCaseResCase_Resource_RelENT.ResourceTypeName = objvTeachingCaseResCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvTeachingCaseResCase_Resource_RelENT.ResourceOwner = objvTeachingCaseResCase_Resource_RelENS.ResourceOwner; //上传者
objvTeachingCaseResCase_Resource_RelENT.ftpFileType = objvTeachingCaseResCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvTeachingCaseResCase_Resource_RelENT.ftpFileSize = objvTeachingCaseResCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvTeachingCaseResCase_Resource_RelENT.ftpResourceOwner = objvTeachingCaseResCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvTeachingCaseResCase_Resource_RelENT.FileOriginName = objvTeachingCaseResCase_Resource_RelENS.FileOriginName; //原文件名
objvTeachingCaseResCase_Resource_RelENT.IsExistFile = objvTeachingCaseResCase_Resource_RelENS.IsExistFile; //是否存在文件
objvTeachingCaseResCase_Resource_RelENT.FileNewName = objvTeachingCaseResCase_Resource_RelENS.FileNewName; //新文件名
objvTeachingCaseResCase_Resource_RelENT.FileOldName = objvTeachingCaseResCase_Resource_RelENS.FileOldName; //旧文件名
objvTeachingCaseResCase_Resource_RelENT.IsMain = objvTeachingCaseResCase_Resource_RelENS.IsMain; //是否主资源
objvTeachingCaseResCase_Resource_RelENT.id_UsingMode = objvTeachingCaseResCase_Resource_RelENS.id_UsingMode; //资源使用模式流水号
objvTeachingCaseResCase_Resource_RelENT.IsVisible = objvTeachingCaseResCase_Resource_RelENS.IsVisible; //是否显示
objvTeachingCaseResCase_Resource_RelENT.IndexNO = objvTeachingCaseResCase_Resource_RelENS.IndexNO; //序号
objvTeachingCaseResCase_Resource_RelENT.BrowseCount = objvTeachingCaseResCase_Resource_RelENS.BrowseCount; //浏览次数
objvTeachingCaseResCase_Resource_RelENT.UpdDate = objvTeachingCaseResCase_Resource_RelENS.UpdDate; //修改日期
objvTeachingCaseResCase_Resource_RelENT.UpdUser = objvTeachingCaseResCase_Resource_RelENS.UpdUser; //修改人
objvTeachingCaseResCase_Resource_RelENT.Memo = objvTeachingCaseResCase_Resource_RelENS.Memo; //备注
objvTeachingCaseResCase_Resource_RelENT.CollegeNameA = objvTeachingCaseResCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCase_Resource_RelENT.CourseChapterReferred = objvTeachingCaseResCase_Resource_RelENS.CourseChapterReferred; //节简称
objvTeachingCaseResCase_Resource_RelENT.ParentNodeReferred = objvTeachingCaseResCase_Resource_RelENS.ParentNodeReferred; //章简称
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
public static DataTable ToDataTable(List<clsvTeachingCaseResCase_Resource_RelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTeachingCaseResCase_Resource_RelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTeachingCaseResCase_Resource_RelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTeachingCaseResCase_Resource_RelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTeachingCaseResCase_Resource_RelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTeachingCaseResCase_Resource_RelEN.AttributeName)
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
if (clsMicroteachCase_Resource_RelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCase_Resource_RelWApi没有刷新缓存机制(clsMicroteachCase_Resource_RelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeWApi没有刷新缓存机制(clsResourceTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceWApi没有刷新缓存机制(clsResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerWApi没有刷新缓存机制(clsFileServerWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceWApi没有刷新缓存机制(clsFtpResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase_Resource_Rel");
//if (arrvTeachingCaseResCase_Resource_RelObjLst_Cache == null)
//{
//arrvTeachingCaseResCase_Resource_RelObjLst_Cache = await clsvTeachingCaseResCase_Resource_RelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvTeachingCaseResCase_Resource_RelEN._CurrTabName_S);
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
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvTeachingCaseResCase_Resource_RelEN._CurrTabName_S);
List<clsvTeachingCaseResCase_Resource_RelEN> arrvTeachingCaseResCase_Resource_RelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachingCaseResCase_Resource_RelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.id_TeachingCaseResCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.id_UsingMode, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Resource_Rel.ParentNodeReferred, Type.GetType("System.String"));
foreach (clsvTeachingCaseResCase_Resource_RelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTeachingCaseResCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = objInFor[convTeachingCaseResCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
objDR[convTeachingCaseResCase_Resource_Rel.FuncModuleId] = objInFor[convTeachingCaseResCase_Resource_Rel.FuncModuleId];
objDR[convTeachingCaseResCase_Resource_Rel.FuncModuleName] = objInFor[convTeachingCaseResCase_Resource_Rel.FuncModuleName];
objDR[convTeachingCaseResCase_Resource_Rel.id_MicroteachCase] = objInFor[convTeachingCaseResCase_Resource_Rel.id_MicroteachCase];
objDR[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID] = objInFor[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID];
objDR[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName] = objInFor[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName];
objDR[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme] = objInFor[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme];
objDR[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText] = objInFor[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText];
objDR[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate] = objInFor[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate];
objDR[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime] = objInFor[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime];
objDR[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn] = objInFor[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn];
objDR[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn] = objInFor[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn];
objDR[convTeachingCaseResCase_Resource_Rel.id_TeachingCaseResCaseType] = objInFor[convTeachingCaseResCase_Resource_Rel.id_TeachingCaseResCaseType];
objDR[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName] = objInFor[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName];
objDR[convTeachingCaseResCase_Resource_Rel.OwnerId] = objInFor[convTeachingCaseResCase_Resource_Rel.OwnerId];
objDR[convTeachingCaseResCase_Resource_Rel.OwnerName] = objInFor[convTeachingCaseResCase_Resource_Rel.OwnerName];
objDR[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId] = objInFor[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId];
objDR[convTeachingCaseResCase_Resource_Rel.id_StudyLevel] = objInFor[convTeachingCaseResCase_Resource_Rel.id_StudyLevel];
objDR[convTeachingCaseResCase_Resource_Rel.StudyLevelName] = objInFor[convTeachingCaseResCase_Resource_Rel.StudyLevelName];
objDR[convTeachingCaseResCase_Resource_Rel.id_TeachingPlan] = objInFor[convTeachingCaseResCase_Resource_Rel.id_TeachingPlan];
objDR[convTeachingCaseResCase_Resource_Rel.id_Discipline] = objInFor[convTeachingCaseResCase_Resource_Rel.id_Discipline];
objDR[convTeachingCaseResCase_Resource_Rel.DisciplineID] = objInFor[convTeachingCaseResCase_Resource_Rel.DisciplineID];
objDR[convTeachingCaseResCase_Resource_Rel.DisciplineName] = objInFor[convTeachingCaseResCase_Resource_Rel.DisciplineName];
objDR[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID] = objInFor[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID];
objDR[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName] = objInFor[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName];
objDR[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore] = objInFor[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore];
objDR[convTeachingCaseResCase_Resource_Rel.VersionNo] = objInFor[convTeachingCaseResCase_Resource_Rel.VersionNo];
objDR[convTeachingCaseResCase_Resource_Rel.id_TeachSkill] = objInFor[convTeachingCaseResCase_Resource_Rel.id_TeachSkill];
objDR[convTeachingCaseResCase_Resource_Rel.TeachSkillID] = objInFor[convTeachingCaseResCase_Resource_Rel.TeachSkillID];
objDR[convTeachingCaseResCase_Resource_Rel.SkillTypeName] = objInFor[convTeachingCaseResCase_Resource_Rel.SkillTypeName];
objDR[convTeachingCaseResCase_Resource_Rel.TeachSkillName] = objInFor[convTeachingCaseResCase_Resource_Rel.TeachSkillName];
objDR[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory] = objInFor[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory];
objDR[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod] = objInFor[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod];
objDR[convTeachingCaseResCase_Resource_Rel.id_SkillType] = objInFor[convTeachingCaseResCase_Resource_Rel.id_SkillType];
objDR[convTeachingCaseResCase_Resource_Rel.SkillTypeID] = objInFor[convTeachingCaseResCase_Resource_Rel.SkillTypeID];
objDR[convTeachingCaseResCase_Resource_Rel.CaseLevelId] = objInFor[convTeachingCaseResCase_Resource_Rel.CaseLevelId];
objDR[convTeachingCaseResCase_Resource_Rel.IsDualVideo] = objInFor[convTeachingCaseResCase_Resource_Rel.IsDualVideo];
objDR[convTeachingCaseResCase_Resource_Rel.id_XzCollege] = objInFor[convTeachingCaseResCase_Resource_Rel.id_XzCollege];
objDR[convTeachingCaseResCase_Resource_Rel.CollegeID] = objInFor[convTeachingCaseResCase_Resource_Rel.CollegeID];
objDR[convTeachingCaseResCase_Resource_Rel.CollegeName] = objInFor[convTeachingCaseResCase_Resource_Rel.CollegeName];
objDR[convTeachingCaseResCase_Resource_Rel.id_XzMajor] = objInFor[convTeachingCaseResCase_Resource_Rel.id_XzMajor];
objDR[convTeachingCaseResCase_Resource_Rel.MajorID] = objInFor[convTeachingCaseResCase_Resource_Rel.MajorID];
objDR[convTeachingCaseResCase_Resource_Rel.MajorName] = objInFor[convTeachingCaseResCase_Resource_Rel.MajorName];
objDR[convTeachingCaseResCase_Resource_Rel.CourseId] = objInFor[convTeachingCaseResCase_Resource_Rel.CourseId];
objDR[convTeachingCaseResCase_Resource_Rel.CourseCode] = objInFor[convTeachingCaseResCase_Resource_Rel.CourseCode];
objDR[convTeachingCaseResCase_Resource_Rel.CourseName] = objInFor[convTeachingCaseResCase_Resource_Rel.CourseName];
objDR[convTeachingCaseResCase_Resource_Rel.CourseChapterId] = objInFor[convTeachingCaseResCase_Resource_Rel.CourseChapterId];
objDR[convTeachingCaseResCase_Resource_Rel.CourseChapterName] = objInFor[convTeachingCaseResCase_Resource_Rel.CourseChapterName];
objDR[convTeachingCaseResCase_Resource_Rel.ParentNodeID] = objInFor[convTeachingCaseResCase_Resource_Rel.ParentNodeID];
objDR[convTeachingCaseResCase_Resource_Rel.ParentNodeName] = objInFor[convTeachingCaseResCase_Resource_Rel.ParentNodeName];
objDR[convTeachingCaseResCase_Resource_Rel.ViewCount] = objInFor[convTeachingCaseResCase_Resource_Rel.ViewCount];
objDR[convTeachingCaseResCase_Resource_Rel.IsShow] = objInFor[convTeachingCaseResCase_Resource_Rel.IsShow];
objDR[convTeachingCaseResCase_Resource_Rel.DownloadNumber] = objInFor[convTeachingCaseResCase_Resource_Rel.DownloadNumber];
objDR[convTeachingCaseResCase_Resource_Rel.FileIntegration] = objInFor[convTeachingCaseResCase_Resource_Rel.FileIntegration];
objDR[convTeachingCaseResCase_Resource_Rel.LikeCount] = objInFor[convTeachingCaseResCase_Resource_Rel.LikeCount];
objDR[convTeachingCaseResCase_Resource_Rel.CollectionCount] = objInFor[convTeachingCaseResCase_Resource_Rel.CollectionCount];
objDR[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId] = objInFor[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId];
objDR[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName] = objInFor[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName];
objDR[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case] = objInFor[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case];
objDR[convTeachingCaseResCase_Resource_Rel.id_Resource] = objInFor[convTeachingCaseResCase_Resource_Rel.id_Resource];
objDR[convTeachingCaseResCase_Resource_Rel.ResourceID] = objInFor[convTeachingCaseResCase_Resource_Rel.ResourceID];
objDR[convTeachingCaseResCase_Resource_Rel.ResourceName] = objInFor[convTeachingCaseResCase_Resource_Rel.ResourceName];
objDR[convTeachingCaseResCase_Resource_Rel.id_FtpResource] = objInFor[convTeachingCaseResCase_Resource_Rel.id_FtpResource];
objDR[convTeachingCaseResCase_Resource_Rel.id_File] = objInFor[convTeachingCaseResCase_Resource_Rel.id_File];
objDR[convTeachingCaseResCase_Resource_Rel.FileName] = objInFor[convTeachingCaseResCase_Resource_Rel.FileName];
objDR[convTeachingCaseResCase_Resource_Rel.FileType] = objInFor[convTeachingCaseResCase_Resource_Rel.FileType];
objDR[convTeachingCaseResCase_Resource_Rel.SaveDate] = objInFor[convTeachingCaseResCase_Resource_Rel.SaveDate];
objDR[convTeachingCaseResCase_Resource_Rel.FileSize] = objInFor[convTeachingCaseResCase_Resource_Rel.FileSize];
objDR[convTeachingCaseResCase_Resource_Rel.SaveTime] = objInFor[convTeachingCaseResCase_Resource_Rel.SaveTime];
objDR[convTeachingCaseResCase_Resource_Rel.FtpResourceID] = objInFor[convTeachingCaseResCase_Resource_Rel.FtpResourceID];
objDR[convTeachingCaseResCase_Resource_Rel.FileOriginalName] = objInFor[convTeachingCaseResCase_Resource_Rel.FileOriginalName];
objDR[convTeachingCaseResCase_Resource_Rel.FileDirName] = objInFor[convTeachingCaseResCase_Resource_Rel.FileDirName];
objDR[convTeachingCaseResCase_Resource_Rel.FileRename] = objInFor[convTeachingCaseResCase_Resource_Rel.FileRename];
objDR[convTeachingCaseResCase_Resource_Rel.FileUpDate] = objInFor[convTeachingCaseResCase_Resource_Rel.FileUpDate];
objDR[convTeachingCaseResCase_Resource_Rel.FileUpTime] = objInFor[convTeachingCaseResCase_Resource_Rel.FileUpTime];
objDR[convTeachingCaseResCase_Resource_Rel.SaveMode] = objInFor[convTeachingCaseResCase_Resource_Rel.SaveMode];
objDR[convTeachingCaseResCase_Resource_Rel.id_ResourceType] = objInFor[convTeachingCaseResCase_Resource_Rel.id_ResourceType];
objDR[convTeachingCaseResCase_Resource_Rel.ResourceTypeID] = objInFor[convTeachingCaseResCase_Resource_Rel.ResourceTypeID];
objDR[convTeachingCaseResCase_Resource_Rel.ResourceTypeName] = objInFor[convTeachingCaseResCase_Resource_Rel.ResourceTypeName];
objDR[convTeachingCaseResCase_Resource_Rel.ResourceOwner] = objInFor[convTeachingCaseResCase_Resource_Rel.ResourceOwner];
objDR[convTeachingCaseResCase_Resource_Rel.ftpFileType] = objInFor[convTeachingCaseResCase_Resource_Rel.ftpFileType];
objDR[convTeachingCaseResCase_Resource_Rel.ftpFileSize] = objInFor[convTeachingCaseResCase_Resource_Rel.ftpFileSize];
objDR[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner] = objInFor[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner];
objDR[convTeachingCaseResCase_Resource_Rel.FileOriginName] = objInFor[convTeachingCaseResCase_Resource_Rel.FileOriginName];
objDR[convTeachingCaseResCase_Resource_Rel.IsExistFile] = objInFor[convTeachingCaseResCase_Resource_Rel.IsExistFile];
objDR[convTeachingCaseResCase_Resource_Rel.FileNewName] = objInFor[convTeachingCaseResCase_Resource_Rel.FileNewName];
objDR[convTeachingCaseResCase_Resource_Rel.FileOldName] = objInFor[convTeachingCaseResCase_Resource_Rel.FileOldName];
objDR[convTeachingCaseResCase_Resource_Rel.IsMain] = objInFor[convTeachingCaseResCase_Resource_Rel.IsMain];
objDR[convTeachingCaseResCase_Resource_Rel.id_UsingMode] = objInFor[convTeachingCaseResCase_Resource_Rel.id_UsingMode];
objDR[convTeachingCaseResCase_Resource_Rel.IsVisible] = objInFor[convTeachingCaseResCase_Resource_Rel.IsVisible];
objDR[convTeachingCaseResCase_Resource_Rel.IndexNO] = objInFor[convTeachingCaseResCase_Resource_Rel.IndexNO];
objDR[convTeachingCaseResCase_Resource_Rel.BrowseCount] = objInFor[convTeachingCaseResCase_Resource_Rel.BrowseCount];
objDR[convTeachingCaseResCase_Resource_Rel.UpdDate] = objInFor[convTeachingCaseResCase_Resource_Rel.UpdDate];
objDR[convTeachingCaseResCase_Resource_Rel.UpdUser] = objInFor[convTeachingCaseResCase_Resource_Rel.UpdUser];
objDR[convTeachingCaseResCase_Resource_Rel.Memo] = objInFor[convTeachingCaseResCase_Resource_Rel.Memo];
objDR[convTeachingCaseResCase_Resource_Rel.CollegeNameA] = objInFor[convTeachingCaseResCase_Resource_Rel.CollegeNameA];
objDR[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred] = objInFor[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred];
objDR[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred] = objInFor[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}