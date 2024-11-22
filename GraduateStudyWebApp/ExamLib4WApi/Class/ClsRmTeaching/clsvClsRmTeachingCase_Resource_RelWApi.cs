
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClsRmTeachingCase_Resource_RelWApi
 表名:vClsRmTeachingCase_Resource_Rel(01120435)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:26
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学
 模块英文名:ClsRmTeaching
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
public static class clsvClsRmTeachingCase_Resource_RelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_MicroteachCase_Resource_Rel(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvClsRmTeachingCase_Resource_RelEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetFuncModuleId(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convClsRmTeachingCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convClsRmTeachingCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convClsRmTeachingCase_Resource_Rel.FuncModuleId);
objvClsRmTeachingCase_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.FuncModuleId) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetFuncModuleName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convClsRmTeachingCase_Resource_Rel.FuncModuleName);
objvClsRmTeachingCase_Resource_RelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.FuncModuleName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.FuncModuleName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FuncModuleName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_MicroteachCase(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convClsRmTeachingCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convClsRmTeachingCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convClsRmTeachingCase_Resource_Rel.id_MicroteachCase);
objvClsRmTeachingCase_Resource_RelEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_MicroteachCase) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_MicroteachCase, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_MicroteachCase] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetClsRmTeachingCaseID(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strClsRmTeachingCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseID, 8, convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseID);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseID, 8, convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseID);
objvClsRmTeachingCase_Resource_RelEN.ClsRmTeachingCaseID = strClsRmTeachingCaseID; //课堂教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseID) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetClsRmTeachingCaseName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strClsRmTeachingCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseName, 100, convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseName);
objvClsRmTeachingCase_Resource_RelEN.ClsRmTeachingCaseName = strClsRmTeachingCaseName; //课堂教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetClsRmTeachingCaseTheme(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strClsRmTeachingCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTheme, 200, convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTheme);
objvClsRmTeachingCase_Resource_RelEN.ClsRmTeachingCaseTheme = strClsRmTeachingCaseTheme; //课堂教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTheme) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTheme, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTheme] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_ClsRmTeachingCaseType(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_ClsRmTeachingCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ClsRmTeachingCaseType, 4, convClsRmTeachingCase_Resource_Rel.id_ClsRmTeachingCaseType);
clsCheckSql.CheckFieldForeignKey(strid_ClsRmTeachingCaseType, 4, convClsRmTeachingCase_Resource_Rel.id_ClsRmTeachingCaseType);
objvClsRmTeachingCase_Resource_RelEN.id_ClsRmTeachingCaseType = strid_ClsRmTeachingCaseType; //课堂案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_ClsRmTeachingCaseType) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_ClsRmTeachingCaseType, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_ClsRmTeachingCaseType] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetClsRmTeachingCaseTypeName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strClsRmTeachingCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTypeName, 30, convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTypeName);
objvClsRmTeachingCase_Resource_RelEN.ClsRmTeachingCaseTypeName = strClsRmTeachingCaseTypeName; //课堂案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTypeName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTypeName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTypeName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetClsRmTeachingCaseText(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strClsRmTeachingCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseText, 8000, convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseText);
objvClsRmTeachingCase_Resource_RelEN.ClsRmTeachingCaseText = strClsRmTeachingCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseText) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseText, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseText] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetClsRmTeachingCaseDate(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strClsRmTeachingCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseDate, 8, convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDate);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseDate, 8, convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDate);
objvClsRmTeachingCase_Resource_RelEN.ClsRmTeachingCaseDate = strClsRmTeachingCaseDate; //课堂教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDate) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDate, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDate] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetClsRmTeachingCaseTime(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strClsRmTeachingCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTime, 6, convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTime);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseTime, 6, convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTime);
objvClsRmTeachingCase_Resource_RelEN.ClsRmTeachingCaseTime = strClsRmTeachingCaseTime; //课堂教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTime) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTime, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTime] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetClsRmTeachingCaseDateIn(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strClsRmTeachingCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseDateIn, 8, convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseDateIn, 8, convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDateIn);
objvClsRmTeachingCase_Resource_RelEN.ClsRmTeachingCaseDateIn = strClsRmTeachingCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDateIn) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDateIn, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDateIn] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetClsRmTeachingCaseTimeIn(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strClsRmTeachingCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTimeIn, 6, convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseTimeIn, 6, convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTimeIn);
objvClsRmTeachingCase_Resource_RelEN.ClsRmTeachingCaseTimeIn = strClsRmTeachingCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTimeIn) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTimeIn, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTimeIn] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_StudyLevel(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convClsRmTeachingCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convClsRmTeachingCase_Resource_Rel.id_StudyLevel);
objvClsRmTeachingCase_Resource_RelEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_StudyLevel) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_StudyLevel, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_StudyLevel] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetStudyLevelName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convClsRmTeachingCase_Resource_Rel.StudyLevelName);
objvClsRmTeachingCase_Resource_RelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.StudyLevelName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.StudyLevelName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.StudyLevelName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_TeachingPlan(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convClsRmTeachingCase_Resource_Rel.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convClsRmTeachingCase_Resource_Rel.id_TeachingPlan);
objvClsRmTeachingCase_Resource_RelEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_TeachingPlan) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_TeachingPlan, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_TeachingPlan] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetId_CaseType(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convClsRmTeachingCase_Resource_Rel.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convClsRmTeachingCase_Resource_Rel.Id_CaseType);
objvClsRmTeachingCase_Resource_RelEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.Id_CaseType) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.Id_CaseType, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.Id_CaseType] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_Discipline(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convClsRmTeachingCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convClsRmTeachingCase_Resource_Rel.id_Discipline);
objvClsRmTeachingCase_Resource_RelEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_Discipline) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_Discipline, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_Discipline] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetDisciplineID(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convClsRmTeachingCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convClsRmTeachingCase_Resource_Rel.DisciplineID);
objvClsRmTeachingCase_Resource_RelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.DisciplineID) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.DisciplineID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.DisciplineID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_School_Ps(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_School_Ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School_Ps, 4, convClsRmTeachingCase_Resource_Rel.id_School_Ps);
clsCheckSql.CheckFieldForeignKey(strid_School_Ps, 4, convClsRmTeachingCase_Resource_Rel.id_School_Ps);
objvClsRmTeachingCase_Resource_RelEN.id_School_Ps = strid_School_Ps; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_School_Ps) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_School_Ps, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_School_Ps] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetSchoolId(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convClsRmTeachingCase_Resource_Rel.SchoolId);
objvClsRmTeachingCase_Resource_RelEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.SchoolId) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.SchoolId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.SchoolId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetSchoolName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convClsRmTeachingCase_Resource_Rel.SchoolName);
objvClsRmTeachingCase_Resource_RelEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.SchoolName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.SchoolName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.SchoolName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_Discipline_Ps(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_Discipline_Ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline_Ps, 4, convClsRmTeachingCase_Resource_Rel.id_Discipline_Ps);
clsCheckSql.CheckFieldForeignKey(strid_Discipline_Ps, 4, convClsRmTeachingCase_Resource_Rel.id_Discipline_Ps);
objvClsRmTeachingCase_Resource_RelEN.id_Discipline_Ps = strid_Discipline_Ps; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_Discipline_Ps) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_Discipline_Ps, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_Discipline_Ps] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetDisciplineName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convClsRmTeachingCase_Resource_Rel.DisciplineName);
objvClsRmTeachingCase_Resource_RelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.DisciplineName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.DisciplineName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.DisciplineName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_GradeBase(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convClsRmTeachingCase_Resource_Rel.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convClsRmTeachingCase_Resource_Rel.id_GradeBase);
objvClsRmTeachingCase_Resource_RelEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_GradeBase) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_GradeBase, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_GradeBase] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetsenateGaugeVersionID(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convClsRmTeachingCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convClsRmTeachingCase_Resource_Rel.senateGaugeVersionID);
objvClsRmTeachingCase_Resource_RelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.senateGaugeVersionID) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetsenateGaugeVersionName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convClsRmTeachingCase_Resource_Rel.senateGaugeVersionName);
objvClsRmTeachingCase_Resource_RelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.senateGaugeVersionName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvClsRmTeachingCase_Resource_RelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.senateGaugeVersionTtlScore) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetVersionNo(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, int intVersionNo, string strComparisonOp="")
	{
objvClsRmTeachingCase_Resource_RelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.VersionNo) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.VersionNo, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.VersionNo] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_TeachSkill(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convClsRmTeachingCase_Resource_Rel.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convClsRmTeachingCase_Resource_Rel.id_TeachSkill);
objvClsRmTeachingCase_Resource_RelEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_TeachSkill) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_TeachSkill, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_TeachSkill] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetTeachSkillID(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convClsRmTeachingCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convClsRmTeachingCase_Resource_Rel.TeachSkillID);
objvClsRmTeachingCase_Resource_RelEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.TeachSkillID) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.TeachSkillID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.TeachSkillID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetSkillTypeName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convClsRmTeachingCase_Resource_Rel.SkillTypeName);
objvClsRmTeachingCase_Resource_RelEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.SkillTypeName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.SkillTypeName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.SkillTypeName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetTeachSkillName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convClsRmTeachingCase_Resource_Rel.TeachSkillName);
objvClsRmTeachingCase_Resource_RelEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.TeachSkillName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.TeachSkillName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.TeachSkillName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetTeachSkillTheory(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convClsRmTeachingCase_Resource_Rel.TeachSkillTheory);
objvClsRmTeachingCase_Resource_RelEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.TeachSkillTheory) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.TeachSkillTheory, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.TeachSkillTheory] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetTeachSkillOperMethod(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convClsRmTeachingCase_Resource_Rel.TeachSkillOperMethod);
objvClsRmTeachingCase_Resource_RelEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.TeachSkillOperMethod) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_SkillType(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convClsRmTeachingCase_Resource_Rel.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convClsRmTeachingCase_Resource_Rel.id_SkillType);
objvClsRmTeachingCase_Resource_RelEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_SkillType) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_SkillType, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_SkillType] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetSkillTypeID(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convClsRmTeachingCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convClsRmTeachingCase_Resource_Rel.SkillTypeID);
objvClsRmTeachingCase_Resource_RelEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.SkillTypeID) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.SkillTypeID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.SkillTypeID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetCaseLevelId(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convClsRmTeachingCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convClsRmTeachingCase_Resource_Rel.CaseLevelId);
objvClsRmTeachingCase_Resource_RelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.CaseLevelId) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.CaseLevelId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.CaseLevelId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetOwnerId(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convClsRmTeachingCase_Resource_Rel.OwnerId);
objvClsRmTeachingCase_Resource_RelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.OwnerId) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.OwnerId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.OwnerId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetStuName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convClsRmTeachingCase_Resource_Rel.StuName);
objvClsRmTeachingCase_Resource_RelEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.StuName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.StuName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.StuName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetStuID(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convClsRmTeachingCase_Resource_Rel.StuID);
objvClsRmTeachingCase_Resource_RelEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.StuID) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.StuID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.StuID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetPoliticsName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convClsRmTeachingCase_Resource_Rel.PoliticsName);
objvClsRmTeachingCase_Resource_RelEN.PoliticsName = strPoliticsName; //政治面貌
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.PoliticsName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.PoliticsName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.PoliticsName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetSexDesc(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convClsRmTeachingCase_Resource_Rel.SexDesc);
objvClsRmTeachingCase_Resource_RelEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.SexDesc) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.SexDesc, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.SexDesc] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetEthnicName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strEthnicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convClsRmTeachingCase_Resource_Rel.EthnicName);
objvClsRmTeachingCase_Resource_RelEN.EthnicName = strEthnicName; //民族名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.EthnicName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.EthnicName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.EthnicName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetUniZoneDesc(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convClsRmTeachingCase_Resource_Rel.UniZoneDesc);
objvClsRmTeachingCase_Resource_RelEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.UniZoneDesc) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.UniZoneDesc, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.UniZoneDesc] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetStuTypeDesc(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strStuTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convClsRmTeachingCase_Resource_Rel.StuTypeDesc);
objvClsRmTeachingCase_Resource_RelEN.StuTypeDesc = strStuTypeDesc; //学生类别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.StuTypeDesc) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.StuTypeDesc, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.StuTypeDesc] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_XzCollege(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convClsRmTeachingCase_Resource_Rel.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convClsRmTeachingCase_Resource_Rel.id_XzCollege);
objvClsRmTeachingCase_Resource_RelEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_XzCollege) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_XzCollege, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_XzCollege] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetCollegeName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convClsRmTeachingCase_Resource_Rel.CollegeName);
objvClsRmTeachingCase_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.CollegeName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetCollegeNameA(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convClsRmTeachingCase_Resource_Rel.CollegeNameA);
objvClsRmTeachingCase_Resource_RelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.CollegeNameA) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.CollegeNameA, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.CollegeNameA] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_XzMajor(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convClsRmTeachingCase_Resource_Rel.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convClsRmTeachingCase_Resource_Rel.id_XzMajor);
objvClsRmTeachingCase_Resource_RelEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_XzMajor) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_XzMajor, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_XzMajor] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetMajorName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convClsRmTeachingCase_Resource_Rel.MajorName);
objvClsRmTeachingCase_Resource_RelEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.MajorName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.MajorName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.MajorName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetGradeBaseName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convClsRmTeachingCase_Resource_Rel.GradeBaseName);
objvClsRmTeachingCase_Resource_RelEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.GradeBaseName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.GradeBaseName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.GradeBaseName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_AdminCls(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convClsRmTeachingCase_Resource_Rel.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convClsRmTeachingCase_Resource_Rel.id_AdminCls);
objvClsRmTeachingCase_Resource_RelEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_AdminCls) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_AdminCls, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_AdminCls] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetAdminClsId(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convClsRmTeachingCase_Resource_Rel.AdminClsId);
objvClsRmTeachingCase_Resource_RelEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.AdminClsId) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.AdminClsId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.AdminClsId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetAdminClsName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convClsRmTeachingCase_Resource_Rel.AdminClsName);
objvClsRmTeachingCase_Resource_RelEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.AdminClsName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.AdminClsName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.AdminClsName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetBirthday(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convClsRmTeachingCase_Resource_Rel.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convClsRmTeachingCase_Resource_Rel.Birthday);
objvClsRmTeachingCase_Resource_RelEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.Birthday) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.Birthday, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.Birthday] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetNativePlace(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strNativePlace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convClsRmTeachingCase_Resource_Rel.NativePlace);
objvClsRmTeachingCase_Resource_RelEN.NativePlace = strNativePlace; //籍贯
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.NativePlace) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.NativePlace, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.NativePlace] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetDuty(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strDuty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDuty, 30, convClsRmTeachingCase_Resource_Rel.Duty);
objvClsRmTeachingCase_Resource_RelEN.Duty = strDuty; //职位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.Duty) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.Duty, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.Duty] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetIDCardNo(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strIDCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIDCardNo, 20, convClsRmTeachingCase_Resource_Rel.IDCardNo);
objvClsRmTeachingCase_Resource_RelEN.IDCardNo = strIDCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.IDCardNo) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.IDCardNo, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.IDCardNo] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetStuCardNo(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strStuCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convClsRmTeachingCase_Resource_Rel.StuCardNo);
objvClsRmTeachingCase_Resource_RelEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.StuCardNo) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.StuCardNo, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.StuCardNo] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetLiveAddress(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strLiveAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convClsRmTeachingCase_Resource_Rel.LiveAddress);
objvClsRmTeachingCase_Resource_RelEN.LiveAddress = strLiveAddress; //居住地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.LiveAddress) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.LiveAddress, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.LiveAddress] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetHomePhone(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strHomePhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convClsRmTeachingCase_Resource_Rel.HomePhone);
objvClsRmTeachingCase_Resource_RelEN.HomePhone = strHomePhone; //住宅电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.HomePhone) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.HomePhone, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.HomePhone] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetEnrollmentDate(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strEnrollmentDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convClsRmTeachingCase_Resource_Rel.EnrollmentDate);
objvClsRmTeachingCase_Resource_RelEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.EnrollmentDate) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.EnrollmentDate, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.EnrollmentDate] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetPostCode(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strPostCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPostCode, 6, convClsRmTeachingCase_Resource_Rel.PostCode);
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convClsRmTeachingCase_Resource_Rel.PostCode);
objvClsRmTeachingCase_Resource_RelEN.PostCode = strPostCode; //邮编
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.PostCode) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.PostCode, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.PostCode] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetUserKindId(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convClsRmTeachingCase_Resource_Rel.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convClsRmTeachingCase_Resource_Rel.UserKindId);
objvClsRmTeachingCase_Resource_RelEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.UserKindId) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.UserKindId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.UserKindId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetUserKindName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convClsRmTeachingCase_Resource_Rel.UserKindName);
objvClsRmTeachingCase_Resource_RelEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.UserKindName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.UserKindName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.UserKindName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetUserTypeId(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convClsRmTeachingCase_Resource_Rel.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convClsRmTeachingCase_Resource_Rel.UserTypeId);
objvClsRmTeachingCase_Resource_RelEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.UserTypeId) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.UserTypeId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.UserTypeId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetIsDualVideo(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvClsRmTeachingCase_Resource_RelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.IsDualVideo) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.IsDualVideo, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.IsDualVideo] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetRecommendedDegreeId(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convClsRmTeachingCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convClsRmTeachingCase_Resource_Rel.RecommendedDegreeId);
objvClsRmTeachingCase_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.RecommendedDegreeId) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetRecommendedDegreeName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convClsRmTeachingCase_Resource_Rel.RecommendedDegreeName);
objvClsRmTeachingCase_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.RecommendedDegreeName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetDisciplineName_ps(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strDisciplineName_ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName_ps, 50, convClsRmTeachingCase_Resource_Rel.DisciplineName_ps);
objvClsRmTeachingCase_Resource_RelEN.DisciplineName_ps = strDisciplineName_ps; //学科
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.DisciplineName_ps) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.DisciplineName_ps, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.DisciplineName_ps] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetGradeName_ps(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strGradeName_ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeName_ps, 50, convClsRmTeachingCase_Resource_Rel.GradeName_ps);
objvClsRmTeachingCase_Resource_RelEN.GradeName_ps = strGradeName_ps; //年级
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.GradeName_ps) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.GradeName_ps, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.GradeName_ps] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_Grade_ps(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_Grade_ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Grade_ps, 4, convClsRmTeachingCase_Resource_Rel.id_Grade_ps);
clsCheckSql.CheckFieldForeignKey(strid_Grade_ps, 4, convClsRmTeachingCase_Resource_Rel.id_Grade_ps);
objvClsRmTeachingCase_Resource_RelEN.id_Grade_ps = strid_Grade_ps; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_Grade_ps) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_Grade_ps, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_Grade_ps] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetOwnerName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convClsRmTeachingCase_Resource_Rel.OwnerName);
objvClsRmTeachingCase_Resource_RelEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.OwnerName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.OwnerName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.OwnerName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetBrowseCount4Case(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvClsRmTeachingCase_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.BrowseCount4Case) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_Resource(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convClsRmTeachingCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convClsRmTeachingCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convClsRmTeachingCase_Resource_Rel.id_Resource);
objvClsRmTeachingCase_Resource_RelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_Resource) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_Resource, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_Resource] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetResourceID(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convClsRmTeachingCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convClsRmTeachingCase_Resource_Rel.ResourceID);
objvClsRmTeachingCase_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ResourceID) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetResourceName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convClsRmTeachingCase_Resource_Rel.ResourceName);
objvClsRmTeachingCase_Resource_RelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ResourceName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ResourceName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ResourceName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_FtpResource(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convClsRmTeachingCase_Resource_Rel.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convClsRmTeachingCase_Resource_Rel.id_FtpResource);
objvClsRmTeachingCase_Resource_RelEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_FtpResource) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_FtpResource, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_FtpResource] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_File(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convClsRmTeachingCase_Resource_Rel.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convClsRmTeachingCase_Resource_Rel.id_File);
objvClsRmTeachingCase_Resource_RelEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_File) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_File, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_File] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetFileName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convClsRmTeachingCase_Resource_Rel.FileName);
objvClsRmTeachingCase_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.FileName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetFileType(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convClsRmTeachingCase_Resource_Rel.FileType);
objvClsRmTeachingCase_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.FileType) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetSaveDate(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convClsRmTeachingCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convClsRmTeachingCase_Resource_Rel.SaveDate);
objvClsRmTeachingCase_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.SaveDate) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetFileSize(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convClsRmTeachingCase_Resource_Rel.FileSize);
objvClsRmTeachingCase_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.FileSize) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetSaveTime(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convClsRmTeachingCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convClsRmTeachingCase_Resource_Rel.SaveTime);
objvClsRmTeachingCase_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.SaveTime) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetFtpResourceID(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convClsRmTeachingCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convClsRmTeachingCase_Resource_Rel.FtpResourceID);
objvClsRmTeachingCase_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.FtpResourceID) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetFileOriginalName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convClsRmTeachingCase_Resource_Rel.FileOriginalName);
objvClsRmTeachingCase_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.FileOriginalName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetFileDirName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convClsRmTeachingCase_Resource_Rel.FileDirName);
objvClsRmTeachingCase_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.FileDirName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetFileRename(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convClsRmTeachingCase_Resource_Rel.FileRename);
objvClsRmTeachingCase_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.FileRename) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetFileUpDate(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convClsRmTeachingCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convClsRmTeachingCase_Resource_Rel.FileUpDate);
objvClsRmTeachingCase_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.FileUpDate) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetFileUpTime(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convClsRmTeachingCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convClsRmTeachingCase_Resource_Rel.FileUpTime);
objvClsRmTeachingCase_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.FileUpTime) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetSaveMode(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvClsRmTeachingCase_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.SaveMode) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_ResourceType(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convClsRmTeachingCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convClsRmTeachingCase_Resource_Rel.id_ResourceType);
objvClsRmTeachingCase_Resource_RelEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_ResourceType) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_ResourceType, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_ResourceType] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetResourceTypeID(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convClsRmTeachingCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convClsRmTeachingCase_Resource_Rel.ResourceTypeID);
objvClsRmTeachingCase_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ResourceTypeID) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetResourceTypeName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convClsRmTeachingCase_Resource_Rel.ResourceTypeName);
objvClsRmTeachingCase_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ResourceTypeName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetResourceOwner(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convClsRmTeachingCase_Resource_Rel.ResourceOwner);
objvClsRmTeachingCase_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ResourceOwner) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetftpFileType(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convClsRmTeachingCase_Resource_Rel.ftpFileType);
objvClsRmTeachingCase_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ftpFileType) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetftpFileSize(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convClsRmTeachingCase_Resource_Rel.ftpFileSize);
objvClsRmTeachingCase_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ftpFileSize) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetftpResourceOwner(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convClsRmTeachingCase_Resource_Rel.ftpResourceOwner);
objvClsRmTeachingCase_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.ftpResourceOwner) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetFileOriginName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convClsRmTeachingCase_Resource_Rel.FileOriginName);
objvClsRmTeachingCase_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.FileOriginName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetIsExistFile(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvClsRmTeachingCase_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.IsExistFile) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetFileNewName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convClsRmTeachingCase_Resource_Rel.FileNewName);
objvClsRmTeachingCase_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.FileNewName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetFileOldName(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convClsRmTeachingCase_Resource_Rel.FileOldName);
objvClsRmTeachingCase_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.FileOldName) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetIsMain(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvClsRmTeachingCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.IsMain) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN Setid_UsingMode(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strid_UsingMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UsingMode, 4, convClsRmTeachingCase_Resource_Rel.id_UsingMode);
clsCheckSql.CheckFieldForeignKey(strid_UsingMode, 4, convClsRmTeachingCase_Resource_Rel.id_UsingMode);
objvClsRmTeachingCase_Resource_RelEN.id_UsingMode = strid_UsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.id_UsingMode) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.id_UsingMode, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_UsingMode] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetIsVisible(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvClsRmTeachingCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.IsVisible) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetIndexNO(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, int intIndexNO, string strComparisonOp="")
	{
objvClsRmTeachingCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.IndexNO) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetBrowseCount(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, int intBrowseCount, string strComparisonOp="")
	{
objvClsRmTeachingCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.BrowseCount) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetUpdDate(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convClsRmTeachingCase_Resource_Rel.UpdDate);
objvClsRmTeachingCase_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.UpdDate) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetUpdUser(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convClsRmTeachingCase_Resource_Rel.UpdUser);
objvClsRmTeachingCase_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.UpdUser) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_Resource_RelEN SetMemo(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convClsRmTeachingCase_Resource_Rel.Memo);
objvClsRmTeachingCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Resource_Rel.Memo) == false)
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvClsRmTeachingCase_Resource_RelEN.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvClsRmTeachingCase_Resource_RelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_Rel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase_Resource_Rel.id_MicroteachCase_Resource_Rel, objvClsRmTeachingCase_Resource_Rel_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.FuncModuleId, objvClsRmTeachingCase_Resource_Rel_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.FuncModuleName, objvClsRmTeachingCase_Resource_Rel_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_MicroteachCase, objvClsRmTeachingCase_Resource_Rel_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseID) == true)
{
string strComparisonOp_ClsRmTeachingCaseID = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseID, objvClsRmTeachingCase_Resource_Rel_Cond.ClsRmTeachingCaseID, strComparisonOp_ClsRmTeachingCaseID);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseName) == true)
{
string strComparisonOp_ClsRmTeachingCaseName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseName, objvClsRmTeachingCase_Resource_Rel_Cond.ClsRmTeachingCaseName, strComparisonOp_ClsRmTeachingCaseName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTheme) == true)
{
string strComparisonOp_ClsRmTeachingCaseTheme = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTheme, objvClsRmTeachingCase_Resource_Rel_Cond.ClsRmTeachingCaseTheme, strComparisonOp_ClsRmTeachingCaseTheme);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_ClsRmTeachingCaseType) == true)
{
string strComparisonOp_id_ClsRmTeachingCaseType = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_ClsRmTeachingCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_ClsRmTeachingCaseType, objvClsRmTeachingCase_Resource_Rel_Cond.id_ClsRmTeachingCaseType, strComparisonOp_id_ClsRmTeachingCaseType);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTypeName) == true)
{
string strComparisonOp_ClsRmTeachingCaseTypeName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTypeName, objvClsRmTeachingCase_Resource_Rel_Cond.ClsRmTeachingCaseTypeName, strComparisonOp_ClsRmTeachingCaseTypeName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseText) == true)
{
string strComparisonOp_ClsRmTeachingCaseText = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseText, objvClsRmTeachingCase_Resource_Rel_Cond.ClsRmTeachingCaseText, strComparisonOp_ClsRmTeachingCaseText);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDate) == true)
{
string strComparisonOp_ClsRmTeachingCaseDate = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDate, objvClsRmTeachingCase_Resource_Rel_Cond.ClsRmTeachingCaseDate, strComparisonOp_ClsRmTeachingCaseDate);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTime) == true)
{
string strComparisonOp_ClsRmTeachingCaseTime = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTime, objvClsRmTeachingCase_Resource_Rel_Cond.ClsRmTeachingCaseTime, strComparisonOp_ClsRmTeachingCaseTime);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDateIn) == true)
{
string strComparisonOp_ClsRmTeachingCaseDateIn = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDateIn, objvClsRmTeachingCase_Resource_Rel_Cond.ClsRmTeachingCaseDateIn, strComparisonOp_ClsRmTeachingCaseDateIn);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTimeIn) == true)
{
string strComparisonOp_ClsRmTeachingCaseTimeIn = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTimeIn, objvClsRmTeachingCase_Resource_Rel_Cond.ClsRmTeachingCaseTimeIn, strComparisonOp_ClsRmTeachingCaseTimeIn);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_StudyLevel, objvClsRmTeachingCase_Resource_Rel_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.StudyLevelName, objvClsRmTeachingCase_Resource_Rel_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_TeachingPlan, objvClsRmTeachingCase_Resource_Rel_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.Id_CaseType, objvClsRmTeachingCase_Resource_Rel_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_Discipline, objvClsRmTeachingCase_Resource_Rel_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.DisciplineID, objvClsRmTeachingCase_Resource_Rel_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_School_Ps) == true)
{
string strComparisonOp_id_School_Ps = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_School_Ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_School_Ps, objvClsRmTeachingCase_Resource_Rel_Cond.id_School_Ps, strComparisonOp_id_School_Ps);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.SchoolId, objvClsRmTeachingCase_Resource_Rel_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.SchoolName, objvClsRmTeachingCase_Resource_Rel_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_Discipline_Ps) == true)
{
string strComparisonOp_id_Discipline_Ps = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_Discipline_Ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_Discipline_Ps, objvClsRmTeachingCase_Resource_Rel_Cond.id_Discipline_Ps, strComparisonOp_id_Discipline_Ps);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.DisciplineName, objvClsRmTeachingCase_Resource_Rel_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_GradeBase, objvClsRmTeachingCase_Resource_Rel_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.senateGaugeVersionID, objvClsRmTeachingCase_Resource_Rel_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.senateGaugeVersionName, objvClsRmTeachingCase_Resource_Rel_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase_Resource_Rel.senateGaugeVersionTtlScore, objvClsRmTeachingCase_Resource_Rel_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase_Resource_Rel.VersionNo, objvClsRmTeachingCase_Resource_Rel_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_TeachSkill, objvClsRmTeachingCase_Resource_Rel_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.TeachSkillID, objvClsRmTeachingCase_Resource_Rel_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.SkillTypeName, objvClsRmTeachingCase_Resource_Rel_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.TeachSkillName, objvClsRmTeachingCase_Resource_Rel_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.TeachSkillTheory, objvClsRmTeachingCase_Resource_Rel_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.TeachSkillOperMethod, objvClsRmTeachingCase_Resource_Rel_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_SkillType, objvClsRmTeachingCase_Resource_Rel_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.SkillTypeID, objvClsRmTeachingCase_Resource_Rel_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.CaseLevelId, objvClsRmTeachingCase_Resource_Rel_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.OwnerId, objvClsRmTeachingCase_Resource_Rel_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.StuName) == true)
{
string strComparisonOp_StuName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.StuName, objvClsRmTeachingCase_Resource_Rel_Cond.StuName, strComparisonOp_StuName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.StuID) == true)
{
string strComparisonOp_StuID = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.StuID, objvClsRmTeachingCase_Resource_Rel_Cond.StuID, strComparisonOp_StuID);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.PoliticsName) == true)
{
string strComparisonOp_PoliticsName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.PoliticsName, objvClsRmTeachingCase_Resource_Rel_Cond.PoliticsName, strComparisonOp_PoliticsName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.SexDesc, objvClsRmTeachingCase_Resource_Rel_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.EthnicName) == true)
{
string strComparisonOp_EthnicName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.EthnicName, objvClsRmTeachingCase_Resource_Rel_Cond.EthnicName, strComparisonOp_EthnicName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.UniZoneDesc) == true)
{
string strComparisonOp_UniZoneDesc = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.UniZoneDesc, objvClsRmTeachingCase_Resource_Rel_Cond.UniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.StuTypeDesc) == true)
{
string strComparisonOp_StuTypeDesc = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.StuTypeDesc, objvClsRmTeachingCase_Resource_Rel_Cond.StuTypeDesc, strComparisonOp_StuTypeDesc);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_XzCollege, objvClsRmTeachingCase_Resource_Rel_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.CollegeName, objvClsRmTeachingCase_Resource_Rel_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.CollegeNameA, objvClsRmTeachingCase_Resource_Rel_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_XzMajor, objvClsRmTeachingCase_Resource_Rel_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.MajorName) == true)
{
string strComparisonOp_MajorName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.MajorName, objvClsRmTeachingCase_Resource_Rel_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.GradeBaseName, objvClsRmTeachingCase_Resource_Rel_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_AdminCls, objvClsRmTeachingCase_Resource_Rel_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.AdminClsId, objvClsRmTeachingCase_Resource_Rel_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.AdminClsName, objvClsRmTeachingCase_Resource_Rel_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.Birthday) == true)
{
string strComparisonOp_Birthday = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.Birthday, objvClsRmTeachingCase_Resource_Rel_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.NativePlace) == true)
{
string strComparisonOp_NativePlace = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.NativePlace, objvClsRmTeachingCase_Resource_Rel_Cond.NativePlace, strComparisonOp_NativePlace);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.Duty) == true)
{
string strComparisonOp_Duty = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.Duty, objvClsRmTeachingCase_Resource_Rel_Cond.Duty, strComparisonOp_Duty);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.IDCardNo) == true)
{
string strComparisonOp_IDCardNo = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.IDCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.IDCardNo, objvClsRmTeachingCase_Resource_Rel_Cond.IDCardNo, strComparisonOp_IDCardNo);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.StuCardNo) == true)
{
string strComparisonOp_StuCardNo = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.StuCardNo, objvClsRmTeachingCase_Resource_Rel_Cond.StuCardNo, strComparisonOp_StuCardNo);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.LiveAddress) == true)
{
string strComparisonOp_LiveAddress = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.LiveAddress, objvClsRmTeachingCase_Resource_Rel_Cond.LiveAddress, strComparisonOp_LiveAddress);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.HomePhone) == true)
{
string strComparisonOp_HomePhone = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.HomePhone, objvClsRmTeachingCase_Resource_Rel_Cond.HomePhone, strComparisonOp_HomePhone);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.EnrollmentDate) == true)
{
string strComparisonOp_EnrollmentDate = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.EnrollmentDate, objvClsRmTeachingCase_Resource_Rel_Cond.EnrollmentDate, strComparisonOp_EnrollmentDate);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.PostCode) == true)
{
string strComparisonOp_PostCode = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.PostCode, objvClsRmTeachingCase_Resource_Rel_Cond.PostCode, strComparisonOp_PostCode);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.UserKindId, objvClsRmTeachingCase_Resource_Rel_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.UserKindName, objvClsRmTeachingCase_Resource_Rel_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.UserTypeId, objvClsRmTeachingCase_Resource_Rel_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.IsDualVideo) == true)
{
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase_Resource_Rel.IsDualVideo);
}
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.RecommendedDegreeId, objvClsRmTeachingCase_Resource_Rel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.RecommendedDegreeName, objvClsRmTeachingCase_Resource_Rel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.DisciplineName_ps) == true)
{
string strComparisonOp_DisciplineName_ps = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.DisciplineName_ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.DisciplineName_ps, objvClsRmTeachingCase_Resource_Rel_Cond.DisciplineName_ps, strComparisonOp_DisciplineName_ps);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.GradeName_ps) == true)
{
string strComparisonOp_GradeName_ps = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.GradeName_ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.GradeName_ps, objvClsRmTeachingCase_Resource_Rel_Cond.GradeName_ps, strComparisonOp_GradeName_ps);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_Grade_ps) == true)
{
string strComparisonOp_id_Grade_ps = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_Grade_ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_Grade_ps, objvClsRmTeachingCase_Resource_Rel_Cond.id_Grade_ps, strComparisonOp_id_Grade_ps);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.OwnerName, objvClsRmTeachingCase_Resource_Rel_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase_Resource_Rel.BrowseCount4Case, objvClsRmTeachingCase_Resource_Rel_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_Resource, objvClsRmTeachingCase_Resource_Rel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ResourceID, objvClsRmTeachingCase_Resource_Rel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ResourceName, objvClsRmTeachingCase_Resource_Rel_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_FtpResource, objvClsRmTeachingCase_Resource_Rel_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_File) == true)
{
string strComparisonOp_id_File = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_File, objvClsRmTeachingCase_Resource_Rel_Cond.id_File, strComparisonOp_id_File);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.FileName) == true)
{
string strComparisonOp_FileName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.FileName, objvClsRmTeachingCase_Resource_Rel_Cond.FileName, strComparisonOp_FileName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.FileType) == true)
{
string strComparisonOp_FileType = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.FileType, objvClsRmTeachingCase_Resource_Rel_Cond.FileType, strComparisonOp_FileType);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.SaveDate, objvClsRmTeachingCase_Resource_Rel_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.FileSize) == true)
{
string strComparisonOp_FileSize = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.FileSize, objvClsRmTeachingCase_Resource_Rel_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.SaveTime, objvClsRmTeachingCase_Resource_Rel_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.FtpResourceID, objvClsRmTeachingCase_Resource_Rel_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.FileOriginalName, objvClsRmTeachingCase_Resource_Rel_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.FileDirName, objvClsRmTeachingCase_Resource_Rel_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.FileRename) == true)
{
string strComparisonOp_FileRename = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.FileRename, objvClsRmTeachingCase_Resource_Rel_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.FileUpDate, objvClsRmTeachingCase_Resource_Rel_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.FileUpTime, objvClsRmTeachingCase_Resource_Rel_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.SaveMode) == true)
{
if (objvClsRmTeachingCase_Resource_Rel_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase_Resource_Rel.SaveMode);
}
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_ResourceType, objvClsRmTeachingCase_Resource_Rel_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ResourceTypeID, objvClsRmTeachingCase_Resource_Rel_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ResourceTypeName, objvClsRmTeachingCase_Resource_Rel_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ResourceOwner, objvClsRmTeachingCase_Resource_Rel_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ftpFileType, objvClsRmTeachingCase_Resource_Rel_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ftpFileSize, objvClsRmTeachingCase_Resource_Rel_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.ftpResourceOwner, objvClsRmTeachingCase_Resource_Rel_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.FileOriginName, objvClsRmTeachingCase_Resource_Rel_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.IsExistFile) == true)
{
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase_Resource_Rel.IsExistFile);
}
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.FileNewName, objvClsRmTeachingCase_Resource_Rel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.FileOldName, objvClsRmTeachingCase_Resource_Rel_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.IsMain) == true)
{
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase_Resource_Rel.IsMain);
}
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.id_UsingMode) == true)
{
string strComparisonOp_id_UsingMode = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.id_UsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.id_UsingMode, objvClsRmTeachingCase_Resource_Rel_Cond.id_UsingMode, strComparisonOp_id_UsingMode);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.IsVisible) == true)
{
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase_Resource_Rel.IsVisible);
}
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase_Resource_Rel.IndexNO, objvClsRmTeachingCase_Resource_Rel_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase_Resource_Rel.BrowseCount, objvClsRmTeachingCase_Resource_Rel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.UpdDate, objvClsRmTeachingCase_Resource_Rel_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.UpdUser, objvClsRmTeachingCase_Resource_Rel_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvClsRmTeachingCase_Resource_Rel_Cond.IsUpdated(convClsRmTeachingCase_Resource_Rel.Memo) == true)
{
string strComparisonOp_Memo = objvClsRmTeachingCase_Resource_Rel_Cond.dicFldComparisonOp[convClsRmTeachingCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Resource_Rel.Memo, objvClsRmTeachingCase_Resource_Rel_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课堂教学案例资源关系(vClsRmTeachingCase_Resource_Rel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvClsRmTeachingCase_Resource_RelWApi
{
private static readonly string mstrApiControllerName = "vClsRmTeachingCase_Resource_RelApi";

 public clsvClsRmTeachingCase_Resource_RelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClsRmTeachingCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN = null;
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
objvClsRmTeachingCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvClsRmTeachingCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvClsRmTeachingCase_Resource_RelEN;
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
public static clsvClsRmTeachingCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_WA_Cache(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN = null;
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
objvClsRmTeachingCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvClsRmTeachingCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvClsRmTeachingCase_Resource_RelEN;
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
public static clsvClsRmTeachingCase_Resource_RelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelEN = null;
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
objvClsRmTeachingCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvClsRmTeachingCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvClsRmTeachingCase_Resource_RelEN;
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
public static clsvClsRmTeachingCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_Cache(long lngid_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvClsRmTeachingCase_Resource_RelEN._CurrTabName_S);
List<clsvClsRmTeachingCase_Resource_RelEN> arrvClsRmTeachingCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClsRmTeachingCase_Resource_RelEN> arrvClsRmTeachingCase_Resource_RelObjLst_Sel =
from objvClsRmTeachingCase_Resource_RelEN in arrvClsRmTeachingCase_Resource_RelObjLst_Cache
where objvClsRmTeachingCase_Resource_RelEN.id_MicroteachCase_Resource_Rel == lngid_MicroteachCase_Resource_Rel
select objvClsRmTeachingCase_Resource_RelEN;
if (arrvClsRmTeachingCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvClsRmTeachingCase_Resource_RelEN obj = clsvClsRmTeachingCase_Resource_RelWApi.GetObjByid_MicroteachCase_Resource_Rel(lngid_MicroteachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvClsRmTeachingCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
 List<clsvClsRmTeachingCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvClsRmTeachingCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvClsRmTeachingCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvClsRmTeachingCase_Resource_RelEN._CurrTabName_S);
List<clsvClsRmTeachingCase_Resource_RelEN> arrvClsRmTeachingCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClsRmTeachingCase_Resource_RelEN> arrvClsRmTeachingCase_Resource_RelObjLst_Sel =
from objvClsRmTeachingCase_Resource_RelEN in arrvClsRmTeachingCase_Resource_RelObjLst_Cache
where arrId_MicroteachCase_Resource_Rel.Contains(objvClsRmTeachingCase_Resource_RelEN.id_MicroteachCase_Resource_Rel)
select objvClsRmTeachingCase_Resource_RelEN;
return arrvClsRmTeachingCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_WA_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvClsRmTeachingCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvClsRmTeachingCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCase_Resource_RelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvClsRmTeachingCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvClsRmTeachingCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCase_Resource_RelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvClsRmTeachingCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvClsRmTeachingCase_Resource_RelENS">源对象</param>
 /// <param name = "objvClsRmTeachingCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelENS, clsvClsRmTeachingCase_Resource_RelEN objvClsRmTeachingCase_Resource_RelENT)
{
try
{
objvClsRmTeachingCase_Resource_RelENT.id_MicroteachCase_Resource_Rel = objvClsRmTeachingCase_Resource_RelENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvClsRmTeachingCase_Resource_RelENT.FuncModuleId = objvClsRmTeachingCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvClsRmTeachingCase_Resource_RelENT.FuncModuleName = objvClsRmTeachingCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvClsRmTeachingCase_Resource_RelENT.id_MicroteachCase = objvClsRmTeachingCase_Resource_RelENS.id_MicroteachCase; //微格教学案例流水号
objvClsRmTeachingCase_Resource_RelENT.ClsRmTeachingCaseID = objvClsRmTeachingCase_Resource_RelENS.ClsRmTeachingCaseID; //课堂教学案例ID
objvClsRmTeachingCase_Resource_RelENT.ClsRmTeachingCaseName = objvClsRmTeachingCase_Resource_RelENS.ClsRmTeachingCaseName; //课堂教学案例名称
objvClsRmTeachingCase_Resource_RelENT.ClsRmTeachingCaseTheme = objvClsRmTeachingCase_Resource_RelENS.ClsRmTeachingCaseTheme; //课堂教学案例主题词
objvClsRmTeachingCase_Resource_RelENT.id_ClsRmTeachingCaseType = objvClsRmTeachingCase_Resource_RelENS.id_ClsRmTeachingCaseType; //课堂案例类型流水号
objvClsRmTeachingCase_Resource_RelENT.ClsRmTeachingCaseTypeName = objvClsRmTeachingCase_Resource_RelENS.ClsRmTeachingCaseTypeName; //课堂案例类型名称
objvClsRmTeachingCase_Resource_RelENT.ClsRmTeachingCaseText = objvClsRmTeachingCase_Resource_RelENS.ClsRmTeachingCaseText; //案例文本内容
objvClsRmTeachingCase_Resource_RelENT.ClsRmTeachingCaseDate = objvClsRmTeachingCase_Resource_RelENS.ClsRmTeachingCaseDate; //课堂教学日期
objvClsRmTeachingCase_Resource_RelENT.ClsRmTeachingCaseTime = objvClsRmTeachingCase_Resource_RelENS.ClsRmTeachingCaseTime; //课堂教学时间
objvClsRmTeachingCase_Resource_RelENT.ClsRmTeachingCaseDateIn = objvClsRmTeachingCase_Resource_RelENS.ClsRmTeachingCaseDateIn; //案例入库日期
objvClsRmTeachingCase_Resource_RelENT.ClsRmTeachingCaseTimeIn = objvClsRmTeachingCase_Resource_RelENS.ClsRmTeachingCaseTimeIn; //案例入库时间
objvClsRmTeachingCase_Resource_RelENT.id_StudyLevel = objvClsRmTeachingCase_Resource_RelENS.id_StudyLevel; //id_StudyLevel
objvClsRmTeachingCase_Resource_RelENT.StudyLevelName = objvClsRmTeachingCase_Resource_RelENS.StudyLevelName; //学段名称
objvClsRmTeachingCase_Resource_RelENT.id_TeachingPlan = objvClsRmTeachingCase_Resource_RelENS.id_TeachingPlan; //教案流水号
objvClsRmTeachingCase_Resource_RelENT.Id_CaseType = objvClsRmTeachingCase_Resource_RelENS.Id_CaseType; //案例类型流水号
objvClsRmTeachingCase_Resource_RelENT.id_Discipline = objvClsRmTeachingCase_Resource_RelENS.id_Discipline; //学科流水号
objvClsRmTeachingCase_Resource_RelENT.DisciplineID = objvClsRmTeachingCase_Resource_RelENS.DisciplineID; //学科ID
objvClsRmTeachingCase_Resource_RelENT.id_School_Ps = objvClsRmTeachingCase_Resource_RelENS.id_School_Ps; //学校流水号
objvClsRmTeachingCase_Resource_RelENT.SchoolId = objvClsRmTeachingCase_Resource_RelENS.SchoolId; //学校编号
objvClsRmTeachingCase_Resource_RelENT.SchoolName = objvClsRmTeachingCase_Resource_RelENS.SchoolName; //学校名称
objvClsRmTeachingCase_Resource_RelENT.id_Discipline_Ps = objvClsRmTeachingCase_Resource_RelENS.id_Discipline_Ps; //学科流水号
objvClsRmTeachingCase_Resource_RelENT.DisciplineName = objvClsRmTeachingCase_Resource_RelENS.DisciplineName; //学科名称
objvClsRmTeachingCase_Resource_RelENT.id_GradeBase = objvClsRmTeachingCase_Resource_RelENS.id_GradeBase; //年级流水号
objvClsRmTeachingCase_Resource_RelENT.senateGaugeVersionID = objvClsRmTeachingCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvClsRmTeachingCase_Resource_RelENT.senateGaugeVersionName = objvClsRmTeachingCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvClsRmTeachingCase_Resource_RelENT.senateGaugeVersionTtlScore = objvClsRmTeachingCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvClsRmTeachingCase_Resource_RelENT.VersionNo = objvClsRmTeachingCase_Resource_RelENS.VersionNo; //版本号
objvClsRmTeachingCase_Resource_RelENT.id_TeachSkill = objvClsRmTeachingCase_Resource_RelENS.id_TeachSkill; //教学技能流水号
objvClsRmTeachingCase_Resource_RelENT.TeachSkillID = objvClsRmTeachingCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvClsRmTeachingCase_Resource_RelENT.SkillTypeName = objvClsRmTeachingCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvClsRmTeachingCase_Resource_RelENT.TeachSkillName = objvClsRmTeachingCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvClsRmTeachingCase_Resource_RelENT.TeachSkillTheory = objvClsRmTeachingCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvClsRmTeachingCase_Resource_RelENT.TeachSkillOperMethod = objvClsRmTeachingCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvClsRmTeachingCase_Resource_RelENT.id_SkillType = objvClsRmTeachingCase_Resource_RelENS.id_SkillType; //技能类型流水号
objvClsRmTeachingCase_Resource_RelENT.SkillTypeID = objvClsRmTeachingCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvClsRmTeachingCase_Resource_RelENT.CaseLevelId = objvClsRmTeachingCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvClsRmTeachingCase_Resource_RelENT.OwnerId = objvClsRmTeachingCase_Resource_RelENS.OwnerId; //拥有者Id
objvClsRmTeachingCase_Resource_RelENT.StuName = objvClsRmTeachingCase_Resource_RelENS.StuName; //姓名
objvClsRmTeachingCase_Resource_RelENT.StuID = objvClsRmTeachingCase_Resource_RelENS.StuID; //学号
objvClsRmTeachingCase_Resource_RelENT.PoliticsName = objvClsRmTeachingCase_Resource_RelENS.PoliticsName; //政治面貌
objvClsRmTeachingCase_Resource_RelENT.SexDesc = objvClsRmTeachingCase_Resource_RelENS.SexDesc; //性别名称
objvClsRmTeachingCase_Resource_RelENT.EthnicName = objvClsRmTeachingCase_Resource_RelENS.EthnicName; //民族名称
objvClsRmTeachingCase_Resource_RelENT.UniZoneDesc = objvClsRmTeachingCase_Resource_RelENS.UniZoneDesc; //校区名称
objvClsRmTeachingCase_Resource_RelENT.StuTypeDesc = objvClsRmTeachingCase_Resource_RelENS.StuTypeDesc; //学生类别名称
objvClsRmTeachingCase_Resource_RelENT.id_XzCollege = objvClsRmTeachingCase_Resource_RelENS.id_XzCollege; //学院流水号
objvClsRmTeachingCase_Resource_RelENT.CollegeName = objvClsRmTeachingCase_Resource_RelENS.CollegeName; //学院名称
objvClsRmTeachingCase_Resource_RelENT.CollegeNameA = objvClsRmTeachingCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvClsRmTeachingCase_Resource_RelENT.id_XzMajor = objvClsRmTeachingCase_Resource_RelENS.id_XzMajor; //专业流水号
objvClsRmTeachingCase_Resource_RelENT.MajorName = objvClsRmTeachingCase_Resource_RelENS.MajorName; //专业名称
objvClsRmTeachingCase_Resource_RelENT.GradeBaseName = objvClsRmTeachingCase_Resource_RelENS.GradeBaseName; //年级名称
objvClsRmTeachingCase_Resource_RelENT.id_AdminCls = objvClsRmTeachingCase_Resource_RelENS.id_AdminCls; //行政班流水号
objvClsRmTeachingCase_Resource_RelENT.AdminClsId = objvClsRmTeachingCase_Resource_RelENS.AdminClsId; //行政班代号
objvClsRmTeachingCase_Resource_RelENT.AdminClsName = objvClsRmTeachingCase_Resource_RelENS.AdminClsName; //行政班名称
objvClsRmTeachingCase_Resource_RelENT.Birthday = objvClsRmTeachingCase_Resource_RelENS.Birthday; //出生日期
objvClsRmTeachingCase_Resource_RelENT.NativePlace = objvClsRmTeachingCase_Resource_RelENS.NativePlace; //籍贯
objvClsRmTeachingCase_Resource_RelENT.Duty = objvClsRmTeachingCase_Resource_RelENS.Duty; //职位
objvClsRmTeachingCase_Resource_RelENT.IDCardNo = objvClsRmTeachingCase_Resource_RelENS.IDCardNo; //身份证号
objvClsRmTeachingCase_Resource_RelENT.StuCardNo = objvClsRmTeachingCase_Resource_RelENS.StuCardNo; //学生证号
objvClsRmTeachingCase_Resource_RelENT.LiveAddress = objvClsRmTeachingCase_Resource_RelENS.LiveAddress; //居住地址
objvClsRmTeachingCase_Resource_RelENT.HomePhone = objvClsRmTeachingCase_Resource_RelENS.HomePhone; //住宅电话
objvClsRmTeachingCase_Resource_RelENT.EnrollmentDate = objvClsRmTeachingCase_Resource_RelENS.EnrollmentDate; //入校日期
objvClsRmTeachingCase_Resource_RelENT.PostCode = objvClsRmTeachingCase_Resource_RelENS.PostCode; //邮编
objvClsRmTeachingCase_Resource_RelENT.UserKindId = objvClsRmTeachingCase_Resource_RelENS.UserKindId; //用户类别Id
objvClsRmTeachingCase_Resource_RelENT.UserKindName = objvClsRmTeachingCase_Resource_RelENS.UserKindName; //用户类别名
objvClsRmTeachingCase_Resource_RelENT.UserTypeId = objvClsRmTeachingCase_Resource_RelENS.UserTypeId; //用户类型Id
objvClsRmTeachingCase_Resource_RelENT.IsDualVideo = objvClsRmTeachingCase_Resource_RelENS.IsDualVideo; //是否双视频
objvClsRmTeachingCase_Resource_RelENT.RecommendedDegreeId = objvClsRmTeachingCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvClsRmTeachingCase_Resource_RelENT.RecommendedDegreeName = objvClsRmTeachingCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvClsRmTeachingCase_Resource_RelENT.DisciplineName_ps = objvClsRmTeachingCase_Resource_RelENS.DisciplineName_ps; //学科
objvClsRmTeachingCase_Resource_RelENT.GradeName_ps = objvClsRmTeachingCase_Resource_RelENS.GradeName_ps; //年级
objvClsRmTeachingCase_Resource_RelENT.id_Grade_ps = objvClsRmTeachingCase_Resource_RelENS.id_Grade_ps; //年级流水号
objvClsRmTeachingCase_Resource_RelENT.OwnerName = objvClsRmTeachingCase_Resource_RelENS.OwnerName; //拥有者姓名
objvClsRmTeachingCase_Resource_RelENT.BrowseCount4Case = objvClsRmTeachingCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvClsRmTeachingCase_Resource_RelENT.id_Resource = objvClsRmTeachingCase_Resource_RelENS.id_Resource; //资源流水号
objvClsRmTeachingCase_Resource_RelENT.ResourceID = objvClsRmTeachingCase_Resource_RelENS.ResourceID; //资源ID
objvClsRmTeachingCase_Resource_RelENT.ResourceName = objvClsRmTeachingCase_Resource_RelENS.ResourceName; //资源名称
objvClsRmTeachingCase_Resource_RelENT.id_FtpResource = objvClsRmTeachingCase_Resource_RelENS.id_FtpResource; //FTP资源流水号
objvClsRmTeachingCase_Resource_RelENT.id_File = objvClsRmTeachingCase_Resource_RelENS.id_File; //文件流水号
objvClsRmTeachingCase_Resource_RelENT.FileName = objvClsRmTeachingCase_Resource_RelENS.FileName; //文件名称
objvClsRmTeachingCase_Resource_RelENT.FileType = objvClsRmTeachingCase_Resource_RelENS.FileType; //文件类型
objvClsRmTeachingCase_Resource_RelENT.SaveDate = objvClsRmTeachingCase_Resource_RelENS.SaveDate; //创建日期
objvClsRmTeachingCase_Resource_RelENT.FileSize = objvClsRmTeachingCase_Resource_RelENS.FileSize; //文件大小
objvClsRmTeachingCase_Resource_RelENT.SaveTime = objvClsRmTeachingCase_Resource_RelENS.SaveTime; //创建时间
objvClsRmTeachingCase_Resource_RelENT.FtpResourceID = objvClsRmTeachingCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvClsRmTeachingCase_Resource_RelENT.FileOriginalName = objvClsRmTeachingCase_Resource_RelENS.FileOriginalName; //文件原名
objvClsRmTeachingCase_Resource_RelENT.FileDirName = objvClsRmTeachingCase_Resource_RelENS.FileDirName; //文件目录名
objvClsRmTeachingCase_Resource_RelENT.FileRename = objvClsRmTeachingCase_Resource_RelENS.FileRename; //文件新名
objvClsRmTeachingCase_Resource_RelENT.FileUpDate = objvClsRmTeachingCase_Resource_RelENS.FileUpDate; //创建日期
objvClsRmTeachingCase_Resource_RelENT.FileUpTime = objvClsRmTeachingCase_Resource_RelENS.FileUpTime; //创建时间
objvClsRmTeachingCase_Resource_RelENT.SaveMode = objvClsRmTeachingCase_Resource_RelENS.SaveMode; //文件存放方式
objvClsRmTeachingCase_Resource_RelENT.id_ResourceType = objvClsRmTeachingCase_Resource_RelENS.id_ResourceType; //资源类型流水号
objvClsRmTeachingCase_Resource_RelENT.ResourceTypeID = objvClsRmTeachingCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvClsRmTeachingCase_Resource_RelENT.ResourceTypeName = objvClsRmTeachingCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvClsRmTeachingCase_Resource_RelENT.ResourceOwner = objvClsRmTeachingCase_Resource_RelENS.ResourceOwner; //上传者
objvClsRmTeachingCase_Resource_RelENT.ftpFileType = objvClsRmTeachingCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvClsRmTeachingCase_Resource_RelENT.ftpFileSize = objvClsRmTeachingCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvClsRmTeachingCase_Resource_RelENT.ftpResourceOwner = objvClsRmTeachingCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvClsRmTeachingCase_Resource_RelENT.FileOriginName = objvClsRmTeachingCase_Resource_RelENS.FileOriginName; //原文件名
objvClsRmTeachingCase_Resource_RelENT.IsExistFile = objvClsRmTeachingCase_Resource_RelENS.IsExistFile; //是否存在文件
objvClsRmTeachingCase_Resource_RelENT.FileNewName = objvClsRmTeachingCase_Resource_RelENS.FileNewName; //新文件名
objvClsRmTeachingCase_Resource_RelENT.FileOldName = objvClsRmTeachingCase_Resource_RelENS.FileOldName; //旧文件名
objvClsRmTeachingCase_Resource_RelENT.IsMain = objvClsRmTeachingCase_Resource_RelENS.IsMain; //是否主资源
objvClsRmTeachingCase_Resource_RelENT.id_UsingMode = objvClsRmTeachingCase_Resource_RelENS.id_UsingMode; //资源使用模式流水号
objvClsRmTeachingCase_Resource_RelENT.IsVisible = objvClsRmTeachingCase_Resource_RelENS.IsVisible; //是否显示
objvClsRmTeachingCase_Resource_RelENT.IndexNO = objvClsRmTeachingCase_Resource_RelENS.IndexNO; //序号
objvClsRmTeachingCase_Resource_RelENT.BrowseCount = objvClsRmTeachingCase_Resource_RelENS.BrowseCount; //浏览次数
objvClsRmTeachingCase_Resource_RelENT.UpdDate = objvClsRmTeachingCase_Resource_RelENS.UpdDate; //修改日期
objvClsRmTeachingCase_Resource_RelENT.UpdUser = objvClsRmTeachingCase_Resource_RelENS.UpdUser; //修改人
objvClsRmTeachingCase_Resource_RelENT.Memo = objvClsRmTeachingCase_Resource_RelENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvClsRmTeachingCase_Resource_RelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvClsRmTeachingCase_Resource_RelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvClsRmTeachingCase_Resource_RelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvClsRmTeachingCase_Resource_RelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvClsRmTeachingCase_Resource_RelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvClsRmTeachingCase_Resource_RelEN.AttributeName)
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
if (clsDiscipline_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline_psWApi没有刷新缓存机制(clsDiscipline_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzSchool_PsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchool_PsWApi没有刷新缓存机制(clsXzSchool_PsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseTypeWApi没有刷新缓存机制(clsCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGrade_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGrade_psWApi没有刷新缓存机制(clsXzGrade_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsClsRmTeachingCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsClsRmTeachingCaseWApi没有刷新缓存机制(clsClsRmTeachingCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsClsRmTeachingCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsClsRmTeachingCaseTypeWApi没有刷新缓存机制(clsClsRmTeachingCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase_Resource_Rel");
//if (arrvClsRmTeachingCase_Resource_RelObjLst_Cache == null)
//{
//arrvClsRmTeachingCase_Resource_RelObjLst_Cache = await clsvClsRmTeachingCase_Resource_RelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvClsRmTeachingCase_Resource_RelEN._CurrTabName_S);
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
public static List<clsvClsRmTeachingCase_Resource_RelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvClsRmTeachingCase_Resource_RelEN._CurrTabName_S);
List<clsvClsRmTeachingCase_Resource_RelEN> arrvClsRmTeachingCase_Resource_RelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvClsRmTeachingCase_Resource_RelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvClsRmTeachingCase_Resource_RelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_ClsRmTeachingCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_School_Ps, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_Discipline_Ps, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.PoliticsName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.EthnicName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.UniZoneDesc, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.StuTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.NativePlace, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.Duty, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.IDCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.StuCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.LiveAddress, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.HomePhone, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.EnrollmentDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.PostCode, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.DisciplineName_ps, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.GradeName_ps, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_Grade_ps, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.id_UsingMode, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Resource_Rel.Memo, Type.GetType("System.String"));
foreach (clsvClsRmTeachingCase_Resource_RelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convClsRmTeachingCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = objInFor[convClsRmTeachingCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
objDR[convClsRmTeachingCase_Resource_Rel.FuncModuleId] = objInFor[convClsRmTeachingCase_Resource_Rel.FuncModuleId];
objDR[convClsRmTeachingCase_Resource_Rel.FuncModuleName] = objInFor[convClsRmTeachingCase_Resource_Rel.FuncModuleName];
objDR[convClsRmTeachingCase_Resource_Rel.id_MicroteachCase] = objInFor[convClsRmTeachingCase_Resource_Rel.id_MicroteachCase];
objDR[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseID] = objInFor[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseID];
objDR[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseName] = objInFor[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseName];
objDR[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTheme] = objInFor[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTheme];
objDR[convClsRmTeachingCase_Resource_Rel.id_ClsRmTeachingCaseType] = objInFor[convClsRmTeachingCase_Resource_Rel.id_ClsRmTeachingCaseType];
objDR[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTypeName] = objInFor[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTypeName];
objDR[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseText] = objInFor[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseText];
objDR[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDate] = objInFor[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDate];
objDR[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTime] = objInFor[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTime];
objDR[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDateIn] = objInFor[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseDateIn];
objDR[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTimeIn] = objInFor[convClsRmTeachingCase_Resource_Rel.ClsRmTeachingCaseTimeIn];
objDR[convClsRmTeachingCase_Resource_Rel.id_StudyLevel] = objInFor[convClsRmTeachingCase_Resource_Rel.id_StudyLevel];
objDR[convClsRmTeachingCase_Resource_Rel.StudyLevelName] = objInFor[convClsRmTeachingCase_Resource_Rel.StudyLevelName];
objDR[convClsRmTeachingCase_Resource_Rel.id_TeachingPlan] = objInFor[convClsRmTeachingCase_Resource_Rel.id_TeachingPlan];
objDR[convClsRmTeachingCase_Resource_Rel.Id_CaseType] = objInFor[convClsRmTeachingCase_Resource_Rel.Id_CaseType];
objDR[convClsRmTeachingCase_Resource_Rel.id_Discipline] = objInFor[convClsRmTeachingCase_Resource_Rel.id_Discipline];
objDR[convClsRmTeachingCase_Resource_Rel.DisciplineID] = objInFor[convClsRmTeachingCase_Resource_Rel.DisciplineID];
objDR[convClsRmTeachingCase_Resource_Rel.id_School_Ps] = objInFor[convClsRmTeachingCase_Resource_Rel.id_School_Ps];
objDR[convClsRmTeachingCase_Resource_Rel.SchoolId] = objInFor[convClsRmTeachingCase_Resource_Rel.SchoolId];
objDR[convClsRmTeachingCase_Resource_Rel.SchoolName] = objInFor[convClsRmTeachingCase_Resource_Rel.SchoolName];
objDR[convClsRmTeachingCase_Resource_Rel.id_Discipline_Ps] = objInFor[convClsRmTeachingCase_Resource_Rel.id_Discipline_Ps];
objDR[convClsRmTeachingCase_Resource_Rel.DisciplineName] = objInFor[convClsRmTeachingCase_Resource_Rel.DisciplineName];
objDR[convClsRmTeachingCase_Resource_Rel.id_GradeBase] = objInFor[convClsRmTeachingCase_Resource_Rel.id_GradeBase];
objDR[convClsRmTeachingCase_Resource_Rel.senateGaugeVersionID] = objInFor[convClsRmTeachingCase_Resource_Rel.senateGaugeVersionID];
objDR[convClsRmTeachingCase_Resource_Rel.senateGaugeVersionName] = objInFor[convClsRmTeachingCase_Resource_Rel.senateGaugeVersionName];
objDR[convClsRmTeachingCase_Resource_Rel.senateGaugeVersionTtlScore] = objInFor[convClsRmTeachingCase_Resource_Rel.senateGaugeVersionTtlScore];
objDR[convClsRmTeachingCase_Resource_Rel.VersionNo] = objInFor[convClsRmTeachingCase_Resource_Rel.VersionNo];
objDR[convClsRmTeachingCase_Resource_Rel.id_TeachSkill] = objInFor[convClsRmTeachingCase_Resource_Rel.id_TeachSkill];
objDR[convClsRmTeachingCase_Resource_Rel.TeachSkillID] = objInFor[convClsRmTeachingCase_Resource_Rel.TeachSkillID];
objDR[convClsRmTeachingCase_Resource_Rel.SkillTypeName] = objInFor[convClsRmTeachingCase_Resource_Rel.SkillTypeName];
objDR[convClsRmTeachingCase_Resource_Rel.TeachSkillName] = objInFor[convClsRmTeachingCase_Resource_Rel.TeachSkillName];
objDR[convClsRmTeachingCase_Resource_Rel.TeachSkillTheory] = objInFor[convClsRmTeachingCase_Resource_Rel.TeachSkillTheory];
objDR[convClsRmTeachingCase_Resource_Rel.TeachSkillOperMethod] = objInFor[convClsRmTeachingCase_Resource_Rel.TeachSkillOperMethod];
objDR[convClsRmTeachingCase_Resource_Rel.id_SkillType] = objInFor[convClsRmTeachingCase_Resource_Rel.id_SkillType];
objDR[convClsRmTeachingCase_Resource_Rel.SkillTypeID] = objInFor[convClsRmTeachingCase_Resource_Rel.SkillTypeID];
objDR[convClsRmTeachingCase_Resource_Rel.CaseLevelId] = objInFor[convClsRmTeachingCase_Resource_Rel.CaseLevelId];
objDR[convClsRmTeachingCase_Resource_Rel.OwnerId] = objInFor[convClsRmTeachingCase_Resource_Rel.OwnerId];
objDR[convClsRmTeachingCase_Resource_Rel.StuName] = objInFor[convClsRmTeachingCase_Resource_Rel.StuName];
objDR[convClsRmTeachingCase_Resource_Rel.StuID] = objInFor[convClsRmTeachingCase_Resource_Rel.StuID];
objDR[convClsRmTeachingCase_Resource_Rel.PoliticsName] = objInFor[convClsRmTeachingCase_Resource_Rel.PoliticsName];
objDR[convClsRmTeachingCase_Resource_Rel.SexDesc] = objInFor[convClsRmTeachingCase_Resource_Rel.SexDesc];
objDR[convClsRmTeachingCase_Resource_Rel.EthnicName] = objInFor[convClsRmTeachingCase_Resource_Rel.EthnicName];
objDR[convClsRmTeachingCase_Resource_Rel.UniZoneDesc] = objInFor[convClsRmTeachingCase_Resource_Rel.UniZoneDesc];
objDR[convClsRmTeachingCase_Resource_Rel.StuTypeDesc] = objInFor[convClsRmTeachingCase_Resource_Rel.StuTypeDesc];
objDR[convClsRmTeachingCase_Resource_Rel.id_XzCollege] = objInFor[convClsRmTeachingCase_Resource_Rel.id_XzCollege];
objDR[convClsRmTeachingCase_Resource_Rel.CollegeName] = objInFor[convClsRmTeachingCase_Resource_Rel.CollegeName];
objDR[convClsRmTeachingCase_Resource_Rel.CollegeNameA] = objInFor[convClsRmTeachingCase_Resource_Rel.CollegeNameA];
objDR[convClsRmTeachingCase_Resource_Rel.id_XzMajor] = objInFor[convClsRmTeachingCase_Resource_Rel.id_XzMajor];
objDR[convClsRmTeachingCase_Resource_Rel.MajorName] = objInFor[convClsRmTeachingCase_Resource_Rel.MajorName];
objDR[convClsRmTeachingCase_Resource_Rel.GradeBaseName] = objInFor[convClsRmTeachingCase_Resource_Rel.GradeBaseName];
objDR[convClsRmTeachingCase_Resource_Rel.id_AdminCls] = objInFor[convClsRmTeachingCase_Resource_Rel.id_AdminCls];
objDR[convClsRmTeachingCase_Resource_Rel.AdminClsId] = objInFor[convClsRmTeachingCase_Resource_Rel.AdminClsId];
objDR[convClsRmTeachingCase_Resource_Rel.AdminClsName] = objInFor[convClsRmTeachingCase_Resource_Rel.AdminClsName];
objDR[convClsRmTeachingCase_Resource_Rel.Birthday] = objInFor[convClsRmTeachingCase_Resource_Rel.Birthday];
objDR[convClsRmTeachingCase_Resource_Rel.NativePlace] = objInFor[convClsRmTeachingCase_Resource_Rel.NativePlace];
objDR[convClsRmTeachingCase_Resource_Rel.Duty] = objInFor[convClsRmTeachingCase_Resource_Rel.Duty];
objDR[convClsRmTeachingCase_Resource_Rel.IDCardNo] = objInFor[convClsRmTeachingCase_Resource_Rel.IDCardNo];
objDR[convClsRmTeachingCase_Resource_Rel.StuCardNo] = objInFor[convClsRmTeachingCase_Resource_Rel.StuCardNo];
objDR[convClsRmTeachingCase_Resource_Rel.LiveAddress] = objInFor[convClsRmTeachingCase_Resource_Rel.LiveAddress];
objDR[convClsRmTeachingCase_Resource_Rel.HomePhone] = objInFor[convClsRmTeachingCase_Resource_Rel.HomePhone];
objDR[convClsRmTeachingCase_Resource_Rel.EnrollmentDate] = objInFor[convClsRmTeachingCase_Resource_Rel.EnrollmentDate];
objDR[convClsRmTeachingCase_Resource_Rel.PostCode] = objInFor[convClsRmTeachingCase_Resource_Rel.PostCode];
objDR[convClsRmTeachingCase_Resource_Rel.UserKindId] = objInFor[convClsRmTeachingCase_Resource_Rel.UserKindId];
objDR[convClsRmTeachingCase_Resource_Rel.UserKindName] = objInFor[convClsRmTeachingCase_Resource_Rel.UserKindName];
objDR[convClsRmTeachingCase_Resource_Rel.UserTypeId] = objInFor[convClsRmTeachingCase_Resource_Rel.UserTypeId];
objDR[convClsRmTeachingCase_Resource_Rel.IsDualVideo] = objInFor[convClsRmTeachingCase_Resource_Rel.IsDualVideo];
objDR[convClsRmTeachingCase_Resource_Rel.RecommendedDegreeId] = objInFor[convClsRmTeachingCase_Resource_Rel.RecommendedDegreeId];
objDR[convClsRmTeachingCase_Resource_Rel.RecommendedDegreeName] = objInFor[convClsRmTeachingCase_Resource_Rel.RecommendedDegreeName];
objDR[convClsRmTeachingCase_Resource_Rel.DisciplineName_ps] = objInFor[convClsRmTeachingCase_Resource_Rel.DisciplineName_ps];
objDR[convClsRmTeachingCase_Resource_Rel.GradeName_ps] = objInFor[convClsRmTeachingCase_Resource_Rel.GradeName_ps];
objDR[convClsRmTeachingCase_Resource_Rel.id_Grade_ps] = objInFor[convClsRmTeachingCase_Resource_Rel.id_Grade_ps];
objDR[convClsRmTeachingCase_Resource_Rel.OwnerName] = objInFor[convClsRmTeachingCase_Resource_Rel.OwnerName];
objDR[convClsRmTeachingCase_Resource_Rel.BrowseCount4Case] = objInFor[convClsRmTeachingCase_Resource_Rel.BrowseCount4Case];
objDR[convClsRmTeachingCase_Resource_Rel.id_Resource] = objInFor[convClsRmTeachingCase_Resource_Rel.id_Resource];
objDR[convClsRmTeachingCase_Resource_Rel.ResourceID] = objInFor[convClsRmTeachingCase_Resource_Rel.ResourceID];
objDR[convClsRmTeachingCase_Resource_Rel.ResourceName] = objInFor[convClsRmTeachingCase_Resource_Rel.ResourceName];
objDR[convClsRmTeachingCase_Resource_Rel.id_FtpResource] = objInFor[convClsRmTeachingCase_Resource_Rel.id_FtpResource];
objDR[convClsRmTeachingCase_Resource_Rel.id_File] = objInFor[convClsRmTeachingCase_Resource_Rel.id_File];
objDR[convClsRmTeachingCase_Resource_Rel.FileName] = objInFor[convClsRmTeachingCase_Resource_Rel.FileName];
objDR[convClsRmTeachingCase_Resource_Rel.FileType] = objInFor[convClsRmTeachingCase_Resource_Rel.FileType];
objDR[convClsRmTeachingCase_Resource_Rel.SaveDate] = objInFor[convClsRmTeachingCase_Resource_Rel.SaveDate];
objDR[convClsRmTeachingCase_Resource_Rel.FileSize] = objInFor[convClsRmTeachingCase_Resource_Rel.FileSize];
objDR[convClsRmTeachingCase_Resource_Rel.SaveTime] = objInFor[convClsRmTeachingCase_Resource_Rel.SaveTime];
objDR[convClsRmTeachingCase_Resource_Rel.FtpResourceID] = objInFor[convClsRmTeachingCase_Resource_Rel.FtpResourceID];
objDR[convClsRmTeachingCase_Resource_Rel.FileOriginalName] = objInFor[convClsRmTeachingCase_Resource_Rel.FileOriginalName];
objDR[convClsRmTeachingCase_Resource_Rel.FileDirName] = objInFor[convClsRmTeachingCase_Resource_Rel.FileDirName];
objDR[convClsRmTeachingCase_Resource_Rel.FileRename] = objInFor[convClsRmTeachingCase_Resource_Rel.FileRename];
objDR[convClsRmTeachingCase_Resource_Rel.FileUpDate] = objInFor[convClsRmTeachingCase_Resource_Rel.FileUpDate];
objDR[convClsRmTeachingCase_Resource_Rel.FileUpTime] = objInFor[convClsRmTeachingCase_Resource_Rel.FileUpTime];
objDR[convClsRmTeachingCase_Resource_Rel.SaveMode] = objInFor[convClsRmTeachingCase_Resource_Rel.SaveMode];
objDR[convClsRmTeachingCase_Resource_Rel.id_ResourceType] = objInFor[convClsRmTeachingCase_Resource_Rel.id_ResourceType];
objDR[convClsRmTeachingCase_Resource_Rel.ResourceTypeID] = objInFor[convClsRmTeachingCase_Resource_Rel.ResourceTypeID];
objDR[convClsRmTeachingCase_Resource_Rel.ResourceTypeName] = objInFor[convClsRmTeachingCase_Resource_Rel.ResourceTypeName];
objDR[convClsRmTeachingCase_Resource_Rel.ResourceOwner] = objInFor[convClsRmTeachingCase_Resource_Rel.ResourceOwner];
objDR[convClsRmTeachingCase_Resource_Rel.ftpFileType] = objInFor[convClsRmTeachingCase_Resource_Rel.ftpFileType];
objDR[convClsRmTeachingCase_Resource_Rel.ftpFileSize] = objInFor[convClsRmTeachingCase_Resource_Rel.ftpFileSize];
objDR[convClsRmTeachingCase_Resource_Rel.ftpResourceOwner] = objInFor[convClsRmTeachingCase_Resource_Rel.ftpResourceOwner];
objDR[convClsRmTeachingCase_Resource_Rel.FileOriginName] = objInFor[convClsRmTeachingCase_Resource_Rel.FileOriginName];
objDR[convClsRmTeachingCase_Resource_Rel.IsExistFile] = objInFor[convClsRmTeachingCase_Resource_Rel.IsExistFile];
objDR[convClsRmTeachingCase_Resource_Rel.FileNewName] = objInFor[convClsRmTeachingCase_Resource_Rel.FileNewName];
objDR[convClsRmTeachingCase_Resource_Rel.FileOldName] = objInFor[convClsRmTeachingCase_Resource_Rel.FileOldName];
objDR[convClsRmTeachingCase_Resource_Rel.IsMain] = objInFor[convClsRmTeachingCase_Resource_Rel.IsMain];
objDR[convClsRmTeachingCase_Resource_Rel.id_UsingMode] = objInFor[convClsRmTeachingCase_Resource_Rel.id_UsingMode];
objDR[convClsRmTeachingCase_Resource_Rel.IsVisible] = objInFor[convClsRmTeachingCase_Resource_Rel.IsVisible];
objDR[convClsRmTeachingCase_Resource_Rel.IndexNO] = objInFor[convClsRmTeachingCase_Resource_Rel.IndexNO];
objDR[convClsRmTeachingCase_Resource_Rel.BrowseCount] = objInFor[convClsRmTeachingCase_Resource_Rel.BrowseCount];
objDR[convClsRmTeachingCase_Resource_Rel.UpdDate] = objInFor[convClsRmTeachingCase_Resource_Rel.UpdDate];
objDR[convClsRmTeachingCase_Resource_Rel.UpdUser] = objInFor[convClsRmTeachingCase_Resource_Rel.UpdUser];
objDR[convClsRmTeachingCase_Resource_Rel.Memo] = objInFor[convClsRmTeachingCase_Resource_Rel.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}