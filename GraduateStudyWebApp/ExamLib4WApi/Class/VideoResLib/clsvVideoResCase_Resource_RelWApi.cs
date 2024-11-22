
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoResCase_Resource_RelWApi
 表名:vVideoResCase_Resource_Rel(01120424)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:44
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频资源库
 模块英文名:VideoResLib
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
public static class clsvVideoResCase_Resource_RelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN Setid_MicroteachCase_Resource_Rel(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetFuncModuleId(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoResCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoResCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoResCase_Resource_Rel.FuncModuleId);
objvVideoResCase_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.FuncModuleId) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetFuncModuleName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convVideoResCase_Resource_Rel.FuncModuleName);
objvVideoResCase_Resource_RelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.FuncModuleName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.FuncModuleName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.FuncModuleName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN Setid_MicroteachCase(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convVideoResCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convVideoResCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convVideoResCase_Resource_Rel.id_MicroteachCase);
objvVideoResCase_Resource_RelEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.id_MicroteachCase) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.id_MicroteachCase, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_MicroteachCase] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetVideoResCaseID(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strVideoResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseID, 8, convVideoResCase_Resource_Rel.VideoResCaseID);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseID, 8, convVideoResCase_Resource_Rel.VideoResCaseID);
objvVideoResCase_Resource_RelEN.VideoResCaseID = strVideoResCaseID; //视频资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.VideoResCaseID) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.VideoResCaseID, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseID] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetVideoResCaseName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strVideoResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseName, 100, convVideoResCase_Resource_Rel.VideoResCaseName);
objvVideoResCase_Resource_RelEN.VideoResCaseName = strVideoResCaseName; //视频资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.VideoResCaseName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.VideoResCaseName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetVideoResCaseTheme(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strVideoResCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTheme, 200, convVideoResCase_Resource_Rel.VideoResCaseTheme);
objvVideoResCase_Resource_RelEN.VideoResCaseTheme = strVideoResCaseTheme; //视频资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.VideoResCaseTheme) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.VideoResCaseTheme, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseTheme] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN Setid_VideoResCaseType(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strid_VideoResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_VideoResCaseType, 4, convVideoResCase_Resource_Rel.id_VideoResCaseType);
clsCheckSql.CheckFieldForeignKey(strid_VideoResCaseType, 4, convVideoResCase_Resource_Rel.id_VideoResCaseType);
objvVideoResCase_Resource_RelEN.id_VideoResCaseType = strid_VideoResCaseType; //视频资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.id_VideoResCaseType) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.id_VideoResCaseType, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_VideoResCaseType] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetVideoResCaseTypeName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strVideoResCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTypeName, 30, convVideoResCase_Resource_Rel.VideoResCaseTypeName);
objvVideoResCase_Resource_RelEN.VideoResCaseTypeName = strVideoResCaseTypeName; //视频资源案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.VideoResCaseTypeName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.VideoResCaseTypeName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseTypeName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetVideoResCaseText(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strVideoResCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseText, 8000, convVideoResCase_Resource_Rel.VideoResCaseText);
objvVideoResCase_Resource_RelEN.VideoResCaseText = strVideoResCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.VideoResCaseText) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.VideoResCaseText, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseText] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetVideoResCaseDate(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strVideoResCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseDate, 8, convVideoResCase_Resource_Rel.VideoResCaseDate);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseDate, 8, convVideoResCase_Resource_Rel.VideoResCaseDate);
objvVideoResCase_Resource_RelEN.VideoResCaseDate = strVideoResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.VideoResCaseDate) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.VideoResCaseDate, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseDate] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetVideoResCaseTime(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strVideoResCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTime, 6, convVideoResCase_Resource_Rel.VideoResCaseTime);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseTime, 6, convVideoResCase_Resource_Rel.VideoResCaseTime);
objvVideoResCase_Resource_RelEN.VideoResCaseTime = strVideoResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.VideoResCaseTime) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.VideoResCaseTime, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseTime] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetVideoResCaseDateIn(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strVideoResCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseDateIn, 8, convVideoResCase_Resource_Rel.VideoResCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseDateIn, 8, convVideoResCase_Resource_Rel.VideoResCaseDateIn);
objvVideoResCase_Resource_RelEN.VideoResCaseDateIn = strVideoResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.VideoResCaseDateIn) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.VideoResCaseDateIn, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseDateIn] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetVideoResCaseTimeIn(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strVideoResCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTimeIn, 6, convVideoResCase_Resource_Rel.VideoResCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseTimeIn, 6, convVideoResCase_Resource_Rel.VideoResCaseTimeIn);
objvVideoResCase_Resource_RelEN.VideoResCaseTimeIn = strVideoResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.VideoResCaseTimeIn) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.VideoResCaseTimeIn, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseTimeIn] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetOwnerId(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convVideoResCase_Resource_Rel.OwnerId);
objvVideoResCase_Resource_RelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.OwnerId) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.OwnerId, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.OwnerId] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN Setid_StudyLevel(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convVideoResCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convVideoResCase_Resource_Rel.id_StudyLevel);
objvVideoResCase_Resource_RelEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.id_StudyLevel) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.id_StudyLevel, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_StudyLevel] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetStudyLevelName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convVideoResCase_Resource_Rel.StudyLevelName);
objvVideoResCase_Resource_RelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.StudyLevelName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.StudyLevelName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.StudyLevelName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN Setid_TeachingPlan(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convVideoResCase_Resource_Rel.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convVideoResCase_Resource_Rel.id_TeachingPlan);
objvVideoResCase_Resource_RelEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.id_TeachingPlan) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.id_TeachingPlan, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_TeachingPlan] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN Setid_Discipline(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convVideoResCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convVideoResCase_Resource_Rel.id_Discipline);
objvVideoResCase_Resource_RelEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.id_Discipline) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.id_Discipline, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_Discipline] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetDisciplineID(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convVideoResCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convVideoResCase_Resource_Rel.DisciplineID);
objvVideoResCase_Resource_RelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.DisciplineID) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.DisciplineID, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.DisciplineID] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetDisciplineName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convVideoResCase_Resource_Rel.DisciplineName);
objvVideoResCase_Resource_RelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.DisciplineName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.DisciplineName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.DisciplineName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetsenateGaugeVersionID(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convVideoResCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convVideoResCase_Resource_Rel.senateGaugeVersionID);
objvVideoResCase_Resource_RelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.senateGaugeVersionID) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetsenateGaugeVersionName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convVideoResCase_Resource_Rel.senateGaugeVersionName);
objvVideoResCase_Resource_RelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.senateGaugeVersionName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetVersionNo(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, int intVersionNo, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.VersionNo) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.VersionNo, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.VersionNo] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN Setid_TeachSkill(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convVideoResCase_Resource_Rel.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convVideoResCase_Resource_Rel.id_TeachSkill);
objvVideoResCase_Resource_RelEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.id_TeachSkill) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.id_TeachSkill, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_TeachSkill] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetTeachSkillID(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convVideoResCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convVideoResCase_Resource_Rel.TeachSkillID);
objvVideoResCase_Resource_RelEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.TeachSkillID) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.TeachSkillID, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.TeachSkillID] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetSkillTypeName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convVideoResCase_Resource_Rel.SkillTypeName);
objvVideoResCase_Resource_RelEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.SkillTypeName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.SkillTypeName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.SkillTypeName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetTeachSkillName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convVideoResCase_Resource_Rel.TeachSkillName);
objvVideoResCase_Resource_RelEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.TeachSkillName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.TeachSkillName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.TeachSkillName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetTeachSkillTheory(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convVideoResCase_Resource_Rel.TeachSkillTheory);
objvVideoResCase_Resource_RelEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.TeachSkillTheory) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.TeachSkillTheory, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.TeachSkillTheory] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetTeachSkillOperMethod(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convVideoResCase_Resource_Rel.TeachSkillOperMethod);
objvVideoResCase_Resource_RelEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.TeachSkillOperMethod) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN Setid_SkillType(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convVideoResCase_Resource_Rel.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convVideoResCase_Resource_Rel.id_SkillType);
objvVideoResCase_Resource_RelEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.id_SkillType) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.id_SkillType, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_SkillType] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetSkillTypeID(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convVideoResCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convVideoResCase_Resource_Rel.SkillTypeID);
objvVideoResCase_Resource_RelEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.SkillTypeID) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.SkillTypeID, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.SkillTypeID] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetCaseLevelId(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convVideoResCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convVideoResCase_Resource_Rel.CaseLevelId);
objvVideoResCase_Resource_RelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.CaseLevelId) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.CaseLevelId, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.CaseLevelId] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetIsDualVideo(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.IsDualVideo) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.IsDualVideo, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.IsDualVideo] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN Setid_XzCollege(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convVideoResCase_Resource_Rel.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convVideoResCase_Resource_Rel.id_XzCollege);
objvVideoResCase_Resource_RelEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.id_XzCollege) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.id_XzCollege, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_XzCollege] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetCollegeID(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoResCase_Resource_Rel.CollegeID);
objvVideoResCase_Resource_RelEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.CollegeID) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.CollegeID, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.CollegeID] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetCollegeName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoResCase_Resource_Rel.CollegeName);
objvVideoResCase_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.CollegeName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetCollegeNameA(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoResCase_Resource_Rel.CollegeNameA);
objvVideoResCase_Resource_RelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.CollegeNameA) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.CollegeNameA, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.CollegeNameA] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN Setid_XzMajor(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convVideoResCase_Resource_Rel.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convVideoResCase_Resource_Rel.id_XzMajor);
objvVideoResCase_Resource_RelEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.id_XzMajor) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.id_XzMajor, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_XzMajor] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetMajorID(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convVideoResCase_Resource_Rel.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convVideoResCase_Resource_Rel.MajorID);
objvVideoResCase_Resource_RelEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.MajorID) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.MajorID, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.MajorID] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetMajorName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convVideoResCase_Resource_Rel.MajorName);
objvVideoResCase_Resource_RelEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.MajorName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.MajorName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.MajorName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetCourseId(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoResCase_Resource_Rel.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoResCase_Resource_Rel.CourseId);
objvVideoResCase_Resource_RelEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.CourseId) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.CourseId, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.CourseId] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetCourseCode(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoResCase_Resource_Rel.CourseCode);
objvVideoResCase_Resource_RelEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.CourseCode) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.CourseCode, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.CourseCode] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetCourseName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoResCase_Resource_Rel.CourseName);
objvVideoResCase_Resource_RelEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.CourseName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.CourseName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.CourseName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetCourseChapterId(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convVideoResCase_Resource_Rel.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convVideoResCase_Resource_Rel.CourseChapterId);
objvVideoResCase_Resource_RelEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.CourseChapterId) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.CourseChapterId, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.CourseChapterId] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetCourseChapterName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convVideoResCase_Resource_Rel.CourseChapterName);
objvVideoResCase_Resource_RelEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.CourseChapterName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.CourseChapterName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.CourseChapterName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetParentNodeID(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convVideoResCase_Resource_Rel.ParentNodeID);
objvVideoResCase_Resource_RelEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.ParentNodeID) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.ParentNodeID, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.ParentNodeID] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetParentNodeName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convVideoResCase_Resource_Rel.ParentNodeName);
objvVideoResCase_Resource_RelEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.ParentNodeName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.ParentNodeName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.ParentNodeName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetViewCount(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, int intViewCount, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.ViewCount) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.ViewCount, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.ViewCount] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetIsShow(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, bool bolIsShow, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.IsShow) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.IsShow, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.IsShow] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetDownloadNumber(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, int intDownloadNumber, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.DownloadNumber) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.DownloadNumber, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.DownloadNumber] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetFileIntegration(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, int intFileIntegration, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.FileIntegration) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.FileIntegration, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileIntegration] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetLikeCount(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, long lngLikeCount, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.LikeCount) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.LikeCount, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.LikeCount] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetCollectionCount(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, long lngCollectionCount, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.CollectionCount) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.CollectionCount, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.CollectionCount] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetRecommendedDegreeId(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convVideoResCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convVideoResCase_Resource_Rel.RecommendedDegreeId);
objvVideoResCase_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.RecommendedDegreeId) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetRecommendedDegreeName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convVideoResCase_Resource_Rel.RecommendedDegreeName);
objvVideoResCase_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.RecommendedDegreeName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetBrowseCount4Case(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.BrowseCount4Case) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetOwnerName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convVideoResCase_Resource_Rel.OwnerName);
objvVideoResCase_Resource_RelEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.OwnerName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.OwnerName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.OwnerName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetOwnerNameWithId(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convVideoResCase_Resource_Rel.OwnerNameWithId);
objvVideoResCase_Resource_RelEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.OwnerNameWithId) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.OwnerNameWithId, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.OwnerNameWithId] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN Setid_Resource(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convVideoResCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convVideoResCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convVideoResCase_Resource_Rel.id_Resource);
objvVideoResCase_Resource_RelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.id_Resource) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.id_Resource, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_Resource] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetResourceID(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convVideoResCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convVideoResCase_Resource_Rel.ResourceID);
objvVideoResCase_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.ResourceID) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetResourceName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convVideoResCase_Resource_Rel.ResourceName);
objvVideoResCase_Resource_RelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.ResourceName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.ResourceName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.ResourceName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN Setid_FtpResource(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convVideoResCase_Resource_Rel.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convVideoResCase_Resource_Rel.id_FtpResource);
objvVideoResCase_Resource_RelEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.id_FtpResource) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.id_FtpResource, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_FtpResource] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN Setid_File(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convVideoResCase_Resource_Rel.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convVideoResCase_Resource_Rel.id_File);
objvVideoResCase_Resource_RelEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.id_File) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.id_File, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_File] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetFileName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convVideoResCase_Resource_Rel.FileName);
objvVideoResCase_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.FileName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetFileType(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convVideoResCase_Resource_Rel.FileType);
objvVideoResCase_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.FileType) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetSaveDate(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convVideoResCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convVideoResCase_Resource_Rel.SaveDate);
objvVideoResCase_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.SaveDate) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetFileSize(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convVideoResCase_Resource_Rel.FileSize);
objvVideoResCase_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.FileSize) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetSaveTime(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convVideoResCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convVideoResCase_Resource_Rel.SaveTime);
objvVideoResCase_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.SaveTime) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetFtpResourceID(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convVideoResCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convVideoResCase_Resource_Rel.FtpResourceID);
objvVideoResCase_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.FtpResourceID) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetFileOriginalName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convVideoResCase_Resource_Rel.FileOriginalName);
objvVideoResCase_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.FileOriginalName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetFileDirName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convVideoResCase_Resource_Rel.FileDirName);
objvVideoResCase_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.FileDirName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetFileRename(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convVideoResCase_Resource_Rel.FileRename);
objvVideoResCase_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.FileRename) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetFileUpDate(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convVideoResCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convVideoResCase_Resource_Rel.FileUpDate);
objvVideoResCase_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.FileUpDate) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetFileUpTime(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convVideoResCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convVideoResCase_Resource_Rel.FileUpTime);
objvVideoResCase_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.FileUpTime) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetSaveMode(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.SaveMode) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN Setid_ResourceType(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convVideoResCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convVideoResCase_Resource_Rel.id_ResourceType);
objvVideoResCase_Resource_RelEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.id_ResourceType) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.id_ResourceType, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_ResourceType] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetResourceTypeID(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convVideoResCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convVideoResCase_Resource_Rel.ResourceTypeID);
objvVideoResCase_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.ResourceTypeID) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetResourceTypeName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convVideoResCase_Resource_Rel.ResourceTypeName);
objvVideoResCase_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.ResourceTypeName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetResourceOwner(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convVideoResCase_Resource_Rel.ResourceOwner);
objvVideoResCase_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.ResourceOwner) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetftpFileType(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convVideoResCase_Resource_Rel.ftpFileType);
objvVideoResCase_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.ftpFileType) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetftpFileSize(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convVideoResCase_Resource_Rel.ftpFileSize);
objvVideoResCase_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.ftpFileSize) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetftpResourceOwner(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convVideoResCase_Resource_Rel.ftpResourceOwner);
objvVideoResCase_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.ftpResourceOwner) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetFileOriginName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convVideoResCase_Resource_Rel.FileOriginName);
objvVideoResCase_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.FileOriginName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetIsExistFile(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.IsExistFile) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetFileNewName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convVideoResCase_Resource_Rel.FileNewName);
objvVideoResCase_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.FileNewName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetFileOldName(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convVideoResCase_Resource_Rel.FileOldName);
objvVideoResCase_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.FileOldName) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetIsMain(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.IsMain) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN Setid_UsingMode(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strid_UsingMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UsingMode, 4, convVideoResCase_Resource_Rel.id_UsingMode);
clsCheckSql.CheckFieldForeignKey(strid_UsingMode, 4, convVideoResCase_Resource_Rel.id_UsingMode);
objvVideoResCase_Resource_RelEN.id_UsingMode = strid_UsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.id_UsingMode) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.id_UsingMode, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_UsingMode] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetIsVisible(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.IsVisible) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetIndexNO(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, int intIndexNO, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.IndexNO) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetBrowseCount(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, int intBrowseCount, string strComparisonOp="")
	{
objvVideoResCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.BrowseCount) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetUpdDate(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convVideoResCase_Resource_Rel.UpdDate);
objvVideoResCase_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.UpdDate) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetUpdUser(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convVideoResCase_Resource_Rel.UpdUser);
objvVideoResCase_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.UpdUser) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_Resource_RelEN SetMemo(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoResCase_Resource_Rel.Memo);
objvVideoResCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Resource_Rel.Memo) == false)
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp.Add(convVideoResCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvVideoResCase_Resource_RelEN.dicFldComparisonOp[convVideoResCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvVideoResCase_Resource_RelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_Rel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Resource_Rel.id_MicroteachCase_Resource_Rel, objvVideoResCase_Resource_Rel_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.FuncModuleId, objvVideoResCase_Resource_Rel_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.FuncModuleName, objvVideoResCase_Resource_Rel_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.id_MicroteachCase, objvVideoResCase_Resource_Rel_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.VideoResCaseID) == true)
{
string strComparisonOp_VideoResCaseID = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.VideoResCaseID, objvVideoResCase_Resource_Rel_Cond.VideoResCaseID, strComparisonOp_VideoResCaseID);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.VideoResCaseName) == true)
{
string strComparisonOp_VideoResCaseName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.VideoResCaseName, objvVideoResCase_Resource_Rel_Cond.VideoResCaseName, strComparisonOp_VideoResCaseName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.VideoResCaseTheme) == true)
{
string strComparisonOp_VideoResCaseTheme = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.VideoResCaseTheme, objvVideoResCase_Resource_Rel_Cond.VideoResCaseTheme, strComparisonOp_VideoResCaseTheme);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.id_VideoResCaseType) == true)
{
string strComparisonOp_id_VideoResCaseType = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_VideoResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.id_VideoResCaseType, objvVideoResCase_Resource_Rel_Cond.id_VideoResCaseType, strComparisonOp_id_VideoResCaseType);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.VideoResCaseTypeName) == true)
{
string strComparisonOp_VideoResCaseTypeName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.VideoResCaseTypeName, objvVideoResCase_Resource_Rel_Cond.VideoResCaseTypeName, strComparisonOp_VideoResCaseTypeName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.VideoResCaseText) == true)
{
string strComparisonOp_VideoResCaseText = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.VideoResCaseText, objvVideoResCase_Resource_Rel_Cond.VideoResCaseText, strComparisonOp_VideoResCaseText);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.VideoResCaseDate) == true)
{
string strComparisonOp_VideoResCaseDate = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.VideoResCaseDate, objvVideoResCase_Resource_Rel_Cond.VideoResCaseDate, strComparisonOp_VideoResCaseDate);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.VideoResCaseTime) == true)
{
string strComparisonOp_VideoResCaseTime = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.VideoResCaseTime, objvVideoResCase_Resource_Rel_Cond.VideoResCaseTime, strComparisonOp_VideoResCaseTime);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.VideoResCaseDateIn) == true)
{
string strComparisonOp_VideoResCaseDateIn = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.VideoResCaseDateIn, objvVideoResCase_Resource_Rel_Cond.VideoResCaseDateIn, strComparisonOp_VideoResCaseDateIn);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.VideoResCaseTimeIn) == true)
{
string strComparisonOp_VideoResCaseTimeIn = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.VideoResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.VideoResCaseTimeIn, objvVideoResCase_Resource_Rel_Cond.VideoResCaseTimeIn, strComparisonOp_VideoResCaseTimeIn);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.OwnerId, objvVideoResCase_Resource_Rel_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.id_StudyLevel, objvVideoResCase_Resource_Rel_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.StudyLevelName, objvVideoResCase_Resource_Rel_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.id_TeachingPlan, objvVideoResCase_Resource_Rel_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.id_Discipline, objvVideoResCase_Resource_Rel_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.DisciplineID, objvVideoResCase_Resource_Rel_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.DisciplineName, objvVideoResCase_Resource_Rel_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.senateGaugeVersionID, objvVideoResCase_Resource_Rel_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.senateGaugeVersionName, objvVideoResCase_Resource_Rel_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore, objvVideoResCase_Resource_Rel_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Resource_Rel.VersionNo, objvVideoResCase_Resource_Rel_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.id_TeachSkill, objvVideoResCase_Resource_Rel_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.TeachSkillID, objvVideoResCase_Resource_Rel_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.SkillTypeName, objvVideoResCase_Resource_Rel_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.TeachSkillName, objvVideoResCase_Resource_Rel_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.TeachSkillTheory, objvVideoResCase_Resource_Rel_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.TeachSkillOperMethod, objvVideoResCase_Resource_Rel_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.id_SkillType, objvVideoResCase_Resource_Rel_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.SkillTypeID, objvVideoResCase_Resource_Rel_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.CaseLevelId, objvVideoResCase_Resource_Rel_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.IsDualVideo) == true)
{
if (objvVideoResCase_Resource_Rel_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCase_Resource_Rel.IsDualVideo);
}
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.id_XzCollege, objvVideoResCase_Resource_Rel_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.CollegeID, objvVideoResCase_Resource_Rel_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.CollegeName, objvVideoResCase_Resource_Rel_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.CollegeNameA, objvVideoResCase_Resource_Rel_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.id_XzMajor, objvVideoResCase_Resource_Rel_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.MajorID) == true)
{
string strComparisonOp_MajorID = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.MajorID, objvVideoResCase_Resource_Rel_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.MajorName) == true)
{
string strComparisonOp_MajorName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.MajorName, objvVideoResCase_Resource_Rel_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.CourseId) == true)
{
string strComparisonOp_CourseId = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.CourseId, objvVideoResCase_Resource_Rel_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.CourseCode, objvVideoResCase_Resource_Rel_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.CourseName) == true)
{
string strComparisonOp_CourseName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.CourseName, objvVideoResCase_Resource_Rel_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.CourseChapterId, objvVideoResCase_Resource_Rel_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.CourseChapterName, objvVideoResCase_Resource_Rel_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.ParentNodeID, objvVideoResCase_Resource_Rel_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.ParentNodeName, objvVideoResCase_Resource_Rel_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Resource_Rel.ViewCount, objvVideoResCase_Resource_Rel_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.IsShow) == true)
{
if (objvVideoResCase_Resource_Rel_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCase_Resource_Rel.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCase_Resource_Rel.IsShow);
}
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Resource_Rel.DownloadNumber, objvVideoResCase_Resource_Rel_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Resource_Rel.FileIntegration, objvVideoResCase_Resource_Rel_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Resource_Rel.LikeCount, objvVideoResCase_Resource_Rel_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Resource_Rel.CollectionCount, objvVideoResCase_Resource_Rel_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.RecommendedDegreeId, objvVideoResCase_Resource_Rel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.RecommendedDegreeName, objvVideoResCase_Resource_Rel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Resource_Rel.BrowseCount4Case, objvVideoResCase_Resource_Rel_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.OwnerName, objvVideoResCase_Resource_Rel_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.OwnerNameWithId, objvVideoResCase_Resource_Rel_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.id_Resource, objvVideoResCase_Resource_Rel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.ResourceID, objvVideoResCase_Resource_Rel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.ResourceName, objvVideoResCase_Resource_Rel_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.id_FtpResource, objvVideoResCase_Resource_Rel_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.id_File) == true)
{
string strComparisonOp_id_File = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.id_File, objvVideoResCase_Resource_Rel_Cond.id_File, strComparisonOp_id_File);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.FileName) == true)
{
string strComparisonOp_FileName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.FileName, objvVideoResCase_Resource_Rel_Cond.FileName, strComparisonOp_FileName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.FileType) == true)
{
string strComparisonOp_FileType = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.FileType, objvVideoResCase_Resource_Rel_Cond.FileType, strComparisonOp_FileType);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.SaveDate, objvVideoResCase_Resource_Rel_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.FileSize) == true)
{
string strComparisonOp_FileSize = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.FileSize, objvVideoResCase_Resource_Rel_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.SaveTime, objvVideoResCase_Resource_Rel_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.FtpResourceID, objvVideoResCase_Resource_Rel_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.FileOriginalName, objvVideoResCase_Resource_Rel_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.FileDirName, objvVideoResCase_Resource_Rel_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.FileRename) == true)
{
string strComparisonOp_FileRename = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.FileRename, objvVideoResCase_Resource_Rel_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.FileUpDate, objvVideoResCase_Resource_Rel_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.FileUpTime, objvVideoResCase_Resource_Rel_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.SaveMode) == true)
{
if (objvVideoResCase_Resource_Rel_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCase_Resource_Rel.SaveMode);
}
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.id_ResourceType, objvVideoResCase_Resource_Rel_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.ResourceTypeID, objvVideoResCase_Resource_Rel_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.ResourceTypeName, objvVideoResCase_Resource_Rel_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.ResourceOwner, objvVideoResCase_Resource_Rel_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.ftpFileType, objvVideoResCase_Resource_Rel_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.ftpFileSize, objvVideoResCase_Resource_Rel_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.ftpResourceOwner, objvVideoResCase_Resource_Rel_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.FileOriginName, objvVideoResCase_Resource_Rel_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.IsExistFile) == true)
{
if (objvVideoResCase_Resource_Rel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCase_Resource_Rel.IsExistFile);
}
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.FileNewName, objvVideoResCase_Resource_Rel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.FileOldName, objvVideoResCase_Resource_Rel_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.IsMain) == true)
{
if (objvVideoResCase_Resource_Rel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCase_Resource_Rel.IsMain);
}
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.id_UsingMode) == true)
{
string strComparisonOp_id_UsingMode = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.id_UsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.id_UsingMode, objvVideoResCase_Resource_Rel_Cond.id_UsingMode, strComparisonOp_id_UsingMode);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.IsVisible) == true)
{
if (objvVideoResCase_Resource_Rel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCase_Resource_Rel.IsVisible);
}
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Resource_Rel.IndexNO, objvVideoResCase_Resource_Rel_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Resource_Rel.BrowseCount, objvVideoResCase_Resource_Rel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.UpdDate, objvVideoResCase_Resource_Rel_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.UpdUser, objvVideoResCase_Resource_Rel_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvVideoResCase_Resource_Rel_Cond.IsUpdated(convVideoResCase_Resource_Rel.Memo) == true)
{
string strComparisonOp_Memo = objvVideoResCase_Resource_Rel_Cond.dicFldComparisonOp[convVideoResCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Resource_Rel.Memo, objvVideoResCase_Resource_Rel_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频资源案例资源关系(vVideoResCase_Resource_Rel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoResCase_Resource_RelWApi
{
private static readonly string mstrApiControllerName = "vVideoResCase_Resource_RelApi";

 public clsvVideoResCase_Resource_RelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoResCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN = null;
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
objvVideoResCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvVideoResCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCase_Resource_RelEN;
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
public static clsvVideoResCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_WA_Cache(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN = null;
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
objvVideoResCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvVideoResCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCase_Resource_RelEN;
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
public static clsvVideoResCase_Resource_RelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN = null;
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
objvVideoResCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvVideoResCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCase_Resource_RelEN;
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
public static clsvVideoResCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_Cache(long lngid_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoResCase_Resource_RelEN._CurrTabName_S);
List<clsvVideoResCase_Resource_RelEN> arrvVideoResCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoResCase_Resource_RelEN> arrvVideoResCase_Resource_RelObjLst_Sel =
from objvVideoResCase_Resource_RelEN in arrvVideoResCase_Resource_RelObjLst_Cache
where objvVideoResCase_Resource_RelEN.id_MicroteachCase_Resource_Rel == lngid_MicroteachCase_Resource_Rel
select objvVideoResCase_Resource_RelEN;
if (arrvVideoResCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvVideoResCase_Resource_RelEN obj = clsvVideoResCase_Resource_RelWApi.GetObjByid_MicroteachCase_Resource_Rel(lngid_MicroteachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoResCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoResCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
 List<clsvVideoResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvVideoResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvVideoResCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoResCase_Resource_RelEN._CurrTabName_S);
List<clsvVideoResCase_Resource_RelEN> arrvVideoResCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoResCase_Resource_RelEN> arrvVideoResCase_Resource_RelObjLst_Sel =
from objvVideoResCase_Resource_RelEN in arrvVideoResCase_Resource_RelObjLst_Cache
where arrId_MicroteachCase_Resource_Rel.Contains(objvVideoResCase_Resource_RelEN.id_MicroteachCase_Resource_Rel)
select objvVideoResCase_Resource_RelEN;
return arrvVideoResCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoResCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_WA_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvVideoResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCase_Resource_RelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCase_Resource_RelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvVideoResCase_Resource_RelENS">源对象</param>
 /// <param name = "objvVideoResCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelENS, clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelENT)
{
try
{
objvVideoResCase_Resource_RelENT.id_MicroteachCase_Resource_Rel = objvVideoResCase_Resource_RelENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvVideoResCase_Resource_RelENT.FuncModuleId = objvVideoResCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvVideoResCase_Resource_RelENT.FuncModuleName = objvVideoResCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvVideoResCase_Resource_RelENT.id_MicroteachCase = objvVideoResCase_Resource_RelENS.id_MicroteachCase; //微格教学案例流水号
objvVideoResCase_Resource_RelENT.VideoResCaseID = objvVideoResCase_Resource_RelENS.VideoResCaseID; //视频资源案例ID
objvVideoResCase_Resource_RelENT.VideoResCaseName = objvVideoResCase_Resource_RelENS.VideoResCaseName; //视频资源案例名称
objvVideoResCase_Resource_RelENT.VideoResCaseTheme = objvVideoResCase_Resource_RelENS.VideoResCaseTheme; //视频资源案例主题词
objvVideoResCase_Resource_RelENT.id_VideoResCaseType = objvVideoResCase_Resource_RelENS.id_VideoResCaseType; //视频资源类型流水号
objvVideoResCase_Resource_RelENT.VideoResCaseTypeName = objvVideoResCase_Resource_RelENS.VideoResCaseTypeName; //视频资源案例类型名称
objvVideoResCase_Resource_RelENT.VideoResCaseText = objvVideoResCase_Resource_RelENS.VideoResCaseText; //案例文本内容
objvVideoResCase_Resource_RelENT.VideoResCaseDate = objvVideoResCase_Resource_RelENS.VideoResCaseDate; //视频资源日期
objvVideoResCase_Resource_RelENT.VideoResCaseTime = objvVideoResCase_Resource_RelENS.VideoResCaseTime; //视频资源时间
objvVideoResCase_Resource_RelENT.VideoResCaseDateIn = objvVideoResCase_Resource_RelENS.VideoResCaseDateIn; //案例入库日期
objvVideoResCase_Resource_RelENT.VideoResCaseTimeIn = objvVideoResCase_Resource_RelENS.VideoResCaseTimeIn; //案例入库时间
objvVideoResCase_Resource_RelENT.OwnerId = objvVideoResCase_Resource_RelENS.OwnerId; //拥有者Id
objvVideoResCase_Resource_RelENT.id_StudyLevel = objvVideoResCase_Resource_RelENS.id_StudyLevel; //id_StudyLevel
objvVideoResCase_Resource_RelENT.StudyLevelName = objvVideoResCase_Resource_RelENS.StudyLevelName; //学段名称
objvVideoResCase_Resource_RelENT.id_TeachingPlan = objvVideoResCase_Resource_RelENS.id_TeachingPlan; //教案流水号
objvVideoResCase_Resource_RelENT.id_Discipline = objvVideoResCase_Resource_RelENS.id_Discipline; //学科流水号
objvVideoResCase_Resource_RelENT.DisciplineID = objvVideoResCase_Resource_RelENS.DisciplineID; //学科ID
objvVideoResCase_Resource_RelENT.DisciplineName = objvVideoResCase_Resource_RelENS.DisciplineName; //学科名称
objvVideoResCase_Resource_RelENT.senateGaugeVersionID = objvVideoResCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvVideoResCase_Resource_RelENT.senateGaugeVersionName = objvVideoResCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvVideoResCase_Resource_RelENT.senateGaugeVersionTtlScore = objvVideoResCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoResCase_Resource_RelENT.VersionNo = objvVideoResCase_Resource_RelENS.VersionNo; //版本号
objvVideoResCase_Resource_RelENT.id_TeachSkill = objvVideoResCase_Resource_RelENS.id_TeachSkill; //教学技能流水号
objvVideoResCase_Resource_RelENT.TeachSkillID = objvVideoResCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvVideoResCase_Resource_RelENT.SkillTypeName = objvVideoResCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvVideoResCase_Resource_RelENT.TeachSkillName = objvVideoResCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvVideoResCase_Resource_RelENT.TeachSkillTheory = objvVideoResCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvVideoResCase_Resource_RelENT.TeachSkillOperMethod = objvVideoResCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvVideoResCase_Resource_RelENT.id_SkillType = objvVideoResCase_Resource_RelENS.id_SkillType; //技能类型流水号
objvVideoResCase_Resource_RelENT.SkillTypeID = objvVideoResCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvVideoResCase_Resource_RelENT.CaseLevelId = objvVideoResCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvVideoResCase_Resource_RelENT.IsDualVideo = objvVideoResCase_Resource_RelENS.IsDualVideo; //是否双视频
objvVideoResCase_Resource_RelENT.id_XzCollege = objvVideoResCase_Resource_RelENS.id_XzCollege; //学院流水号
objvVideoResCase_Resource_RelENT.CollegeID = objvVideoResCase_Resource_RelENS.CollegeID; //学院ID
objvVideoResCase_Resource_RelENT.CollegeName = objvVideoResCase_Resource_RelENS.CollegeName; //学院名称
objvVideoResCase_Resource_RelENT.CollegeNameA = objvVideoResCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvVideoResCase_Resource_RelENT.id_XzMajor = objvVideoResCase_Resource_RelENS.id_XzMajor; //专业流水号
objvVideoResCase_Resource_RelENT.MajorID = objvVideoResCase_Resource_RelENS.MajorID; //专业ID
objvVideoResCase_Resource_RelENT.MajorName = objvVideoResCase_Resource_RelENS.MajorName; //专业名称
objvVideoResCase_Resource_RelENT.CourseId = objvVideoResCase_Resource_RelENS.CourseId; //课程Id
objvVideoResCase_Resource_RelENT.CourseCode = objvVideoResCase_Resource_RelENS.CourseCode; //课程代码
objvVideoResCase_Resource_RelENT.CourseName = objvVideoResCase_Resource_RelENS.CourseName; //课程名称
objvVideoResCase_Resource_RelENT.CourseChapterId = objvVideoResCase_Resource_RelENS.CourseChapterId; //课程章节ID
objvVideoResCase_Resource_RelENT.CourseChapterName = objvVideoResCase_Resource_RelENS.CourseChapterName; //课程章节名称
objvVideoResCase_Resource_RelENT.ParentNodeID = objvVideoResCase_Resource_RelENS.ParentNodeID; //父节点编号
objvVideoResCase_Resource_RelENT.ParentNodeName = objvVideoResCase_Resource_RelENS.ParentNodeName; //父节点名称
objvVideoResCase_Resource_RelENT.ViewCount = objvVideoResCase_Resource_RelENS.ViewCount; //浏览量
objvVideoResCase_Resource_RelENT.IsShow = objvVideoResCase_Resource_RelENS.IsShow; //是否启用
objvVideoResCase_Resource_RelENT.DownloadNumber = objvVideoResCase_Resource_RelENS.DownloadNumber; //下载数目
objvVideoResCase_Resource_RelENT.FileIntegration = objvVideoResCase_Resource_RelENS.FileIntegration; //文件积分
objvVideoResCase_Resource_RelENT.LikeCount = objvVideoResCase_Resource_RelENS.LikeCount; //资源喜欢数量
objvVideoResCase_Resource_RelENT.CollectionCount = objvVideoResCase_Resource_RelENS.CollectionCount; //收藏数量
objvVideoResCase_Resource_RelENT.RecommendedDegreeId = objvVideoResCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvVideoResCase_Resource_RelENT.RecommendedDegreeName = objvVideoResCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvVideoResCase_Resource_RelENT.BrowseCount4Case = objvVideoResCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvVideoResCase_Resource_RelENT.OwnerName = objvVideoResCase_Resource_RelENS.OwnerName; //拥有者姓名
objvVideoResCase_Resource_RelENT.OwnerNameWithId = objvVideoResCase_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvVideoResCase_Resource_RelENT.id_Resource = objvVideoResCase_Resource_RelENS.id_Resource; //资源流水号
objvVideoResCase_Resource_RelENT.ResourceID = objvVideoResCase_Resource_RelENS.ResourceID; //资源ID
objvVideoResCase_Resource_RelENT.ResourceName = objvVideoResCase_Resource_RelENS.ResourceName; //资源名称
objvVideoResCase_Resource_RelENT.id_FtpResource = objvVideoResCase_Resource_RelENS.id_FtpResource; //FTP资源流水号
objvVideoResCase_Resource_RelENT.id_File = objvVideoResCase_Resource_RelENS.id_File; //文件流水号
objvVideoResCase_Resource_RelENT.FileName = objvVideoResCase_Resource_RelENS.FileName; //文件名称
objvVideoResCase_Resource_RelENT.FileType = objvVideoResCase_Resource_RelENS.FileType; //文件类型
objvVideoResCase_Resource_RelENT.SaveDate = objvVideoResCase_Resource_RelENS.SaveDate; //创建日期
objvVideoResCase_Resource_RelENT.FileSize = objvVideoResCase_Resource_RelENS.FileSize; //文件大小
objvVideoResCase_Resource_RelENT.SaveTime = objvVideoResCase_Resource_RelENS.SaveTime; //创建时间
objvVideoResCase_Resource_RelENT.FtpResourceID = objvVideoResCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvVideoResCase_Resource_RelENT.FileOriginalName = objvVideoResCase_Resource_RelENS.FileOriginalName; //文件原名
objvVideoResCase_Resource_RelENT.FileDirName = objvVideoResCase_Resource_RelENS.FileDirName; //文件目录名
objvVideoResCase_Resource_RelENT.FileRename = objvVideoResCase_Resource_RelENS.FileRename; //文件新名
objvVideoResCase_Resource_RelENT.FileUpDate = objvVideoResCase_Resource_RelENS.FileUpDate; //创建日期
objvVideoResCase_Resource_RelENT.FileUpTime = objvVideoResCase_Resource_RelENS.FileUpTime; //创建时间
objvVideoResCase_Resource_RelENT.SaveMode = objvVideoResCase_Resource_RelENS.SaveMode; //文件存放方式
objvVideoResCase_Resource_RelENT.id_ResourceType = objvVideoResCase_Resource_RelENS.id_ResourceType; //资源类型流水号
objvVideoResCase_Resource_RelENT.ResourceTypeID = objvVideoResCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvVideoResCase_Resource_RelENT.ResourceTypeName = objvVideoResCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvVideoResCase_Resource_RelENT.ResourceOwner = objvVideoResCase_Resource_RelENS.ResourceOwner; //上传者
objvVideoResCase_Resource_RelENT.ftpFileType = objvVideoResCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvVideoResCase_Resource_RelENT.ftpFileSize = objvVideoResCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvVideoResCase_Resource_RelENT.ftpResourceOwner = objvVideoResCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvVideoResCase_Resource_RelENT.FileOriginName = objvVideoResCase_Resource_RelENS.FileOriginName; //原文件名
objvVideoResCase_Resource_RelENT.IsExistFile = objvVideoResCase_Resource_RelENS.IsExistFile; //是否存在文件
objvVideoResCase_Resource_RelENT.FileNewName = objvVideoResCase_Resource_RelENS.FileNewName; //新文件名
objvVideoResCase_Resource_RelENT.FileOldName = objvVideoResCase_Resource_RelENS.FileOldName; //旧文件名
objvVideoResCase_Resource_RelENT.IsMain = objvVideoResCase_Resource_RelENS.IsMain; //是否主资源
objvVideoResCase_Resource_RelENT.id_UsingMode = objvVideoResCase_Resource_RelENS.id_UsingMode; //资源使用模式流水号
objvVideoResCase_Resource_RelENT.IsVisible = objvVideoResCase_Resource_RelENS.IsVisible; //是否显示
objvVideoResCase_Resource_RelENT.IndexNO = objvVideoResCase_Resource_RelENS.IndexNO; //序号
objvVideoResCase_Resource_RelENT.BrowseCount = objvVideoResCase_Resource_RelENS.BrowseCount; //浏览次数
objvVideoResCase_Resource_RelENT.UpdDate = objvVideoResCase_Resource_RelENS.UpdDate; //修改日期
objvVideoResCase_Resource_RelENT.UpdUser = objvVideoResCase_Resource_RelENS.UpdUser; //修改人
objvVideoResCase_Resource_RelENT.Memo = objvVideoResCase_Resource_RelENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvVideoResCase_Resource_RelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoResCase_Resource_RelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoResCase_Resource_RelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoResCase_Resource_RelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoResCase_Resource_RelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoResCase_Resource_RelEN.AttributeName)
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
if (clsVideoResCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoResCaseWApi没有刷新缓存机制(clsVideoResCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoResCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoResCaseTypeWApi没有刷新缓存机制(clsVideoResCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvVideoResCase_Resource_RelObjLst_Cache == null)
//{
//arrvVideoResCase_Resource_RelObjLst_Cache = await clsvVideoResCase_Resource_RelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoResCase_Resource_RelEN._CurrTabName_S);
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
public static List<clsvVideoResCase_Resource_RelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoResCase_Resource_RelEN._CurrTabName_S);
List<clsvVideoResCase_Resource_RelEN> arrvVideoResCase_Resource_RelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoResCase_Resource_RelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoResCase_Resource_RelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoResCase_Resource_Rel.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.VideoResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.VideoResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.VideoResCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.id_VideoResCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.VideoResCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.VideoResCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.VideoResCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.VideoResCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.VideoResCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.VideoResCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.id_UsingMode, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Resource_Rel.Memo, Type.GetType("System.String"));
foreach (clsvVideoResCase_Resource_RelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoResCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = objInFor[convVideoResCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
objDR[convVideoResCase_Resource_Rel.FuncModuleId] = objInFor[convVideoResCase_Resource_Rel.FuncModuleId];
objDR[convVideoResCase_Resource_Rel.FuncModuleName] = objInFor[convVideoResCase_Resource_Rel.FuncModuleName];
objDR[convVideoResCase_Resource_Rel.id_MicroteachCase] = objInFor[convVideoResCase_Resource_Rel.id_MicroteachCase];
objDR[convVideoResCase_Resource_Rel.VideoResCaseID] = objInFor[convVideoResCase_Resource_Rel.VideoResCaseID];
objDR[convVideoResCase_Resource_Rel.VideoResCaseName] = objInFor[convVideoResCase_Resource_Rel.VideoResCaseName];
objDR[convVideoResCase_Resource_Rel.VideoResCaseTheme] = objInFor[convVideoResCase_Resource_Rel.VideoResCaseTheme];
objDR[convVideoResCase_Resource_Rel.id_VideoResCaseType] = objInFor[convVideoResCase_Resource_Rel.id_VideoResCaseType];
objDR[convVideoResCase_Resource_Rel.VideoResCaseTypeName] = objInFor[convVideoResCase_Resource_Rel.VideoResCaseTypeName];
objDR[convVideoResCase_Resource_Rel.VideoResCaseText] = objInFor[convVideoResCase_Resource_Rel.VideoResCaseText];
objDR[convVideoResCase_Resource_Rel.VideoResCaseDate] = objInFor[convVideoResCase_Resource_Rel.VideoResCaseDate];
objDR[convVideoResCase_Resource_Rel.VideoResCaseTime] = objInFor[convVideoResCase_Resource_Rel.VideoResCaseTime];
objDR[convVideoResCase_Resource_Rel.VideoResCaseDateIn] = objInFor[convVideoResCase_Resource_Rel.VideoResCaseDateIn];
objDR[convVideoResCase_Resource_Rel.VideoResCaseTimeIn] = objInFor[convVideoResCase_Resource_Rel.VideoResCaseTimeIn];
objDR[convVideoResCase_Resource_Rel.OwnerId] = objInFor[convVideoResCase_Resource_Rel.OwnerId];
objDR[convVideoResCase_Resource_Rel.id_StudyLevel] = objInFor[convVideoResCase_Resource_Rel.id_StudyLevel];
objDR[convVideoResCase_Resource_Rel.StudyLevelName] = objInFor[convVideoResCase_Resource_Rel.StudyLevelName];
objDR[convVideoResCase_Resource_Rel.id_TeachingPlan] = objInFor[convVideoResCase_Resource_Rel.id_TeachingPlan];
objDR[convVideoResCase_Resource_Rel.id_Discipline] = objInFor[convVideoResCase_Resource_Rel.id_Discipline];
objDR[convVideoResCase_Resource_Rel.DisciplineID] = objInFor[convVideoResCase_Resource_Rel.DisciplineID];
objDR[convVideoResCase_Resource_Rel.DisciplineName] = objInFor[convVideoResCase_Resource_Rel.DisciplineName];
objDR[convVideoResCase_Resource_Rel.senateGaugeVersionID] = objInFor[convVideoResCase_Resource_Rel.senateGaugeVersionID];
objDR[convVideoResCase_Resource_Rel.senateGaugeVersionName] = objInFor[convVideoResCase_Resource_Rel.senateGaugeVersionName];
objDR[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore] = objInFor[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore];
objDR[convVideoResCase_Resource_Rel.VersionNo] = objInFor[convVideoResCase_Resource_Rel.VersionNo];
objDR[convVideoResCase_Resource_Rel.id_TeachSkill] = objInFor[convVideoResCase_Resource_Rel.id_TeachSkill];
objDR[convVideoResCase_Resource_Rel.TeachSkillID] = objInFor[convVideoResCase_Resource_Rel.TeachSkillID];
objDR[convVideoResCase_Resource_Rel.SkillTypeName] = objInFor[convVideoResCase_Resource_Rel.SkillTypeName];
objDR[convVideoResCase_Resource_Rel.TeachSkillName] = objInFor[convVideoResCase_Resource_Rel.TeachSkillName];
objDR[convVideoResCase_Resource_Rel.TeachSkillTheory] = objInFor[convVideoResCase_Resource_Rel.TeachSkillTheory];
objDR[convVideoResCase_Resource_Rel.TeachSkillOperMethod] = objInFor[convVideoResCase_Resource_Rel.TeachSkillOperMethod];
objDR[convVideoResCase_Resource_Rel.id_SkillType] = objInFor[convVideoResCase_Resource_Rel.id_SkillType];
objDR[convVideoResCase_Resource_Rel.SkillTypeID] = objInFor[convVideoResCase_Resource_Rel.SkillTypeID];
objDR[convVideoResCase_Resource_Rel.CaseLevelId] = objInFor[convVideoResCase_Resource_Rel.CaseLevelId];
objDR[convVideoResCase_Resource_Rel.IsDualVideo] = objInFor[convVideoResCase_Resource_Rel.IsDualVideo];
objDR[convVideoResCase_Resource_Rel.id_XzCollege] = objInFor[convVideoResCase_Resource_Rel.id_XzCollege];
objDR[convVideoResCase_Resource_Rel.CollegeID] = objInFor[convVideoResCase_Resource_Rel.CollegeID];
objDR[convVideoResCase_Resource_Rel.CollegeName] = objInFor[convVideoResCase_Resource_Rel.CollegeName];
objDR[convVideoResCase_Resource_Rel.CollegeNameA] = objInFor[convVideoResCase_Resource_Rel.CollegeNameA];
objDR[convVideoResCase_Resource_Rel.id_XzMajor] = objInFor[convVideoResCase_Resource_Rel.id_XzMajor];
objDR[convVideoResCase_Resource_Rel.MajorID] = objInFor[convVideoResCase_Resource_Rel.MajorID];
objDR[convVideoResCase_Resource_Rel.MajorName] = objInFor[convVideoResCase_Resource_Rel.MajorName];
objDR[convVideoResCase_Resource_Rel.CourseId] = objInFor[convVideoResCase_Resource_Rel.CourseId];
objDR[convVideoResCase_Resource_Rel.CourseCode] = objInFor[convVideoResCase_Resource_Rel.CourseCode];
objDR[convVideoResCase_Resource_Rel.CourseName] = objInFor[convVideoResCase_Resource_Rel.CourseName];
objDR[convVideoResCase_Resource_Rel.CourseChapterId] = objInFor[convVideoResCase_Resource_Rel.CourseChapterId];
objDR[convVideoResCase_Resource_Rel.CourseChapterName] = objInFor[convVideoResCase_Resource_Rel.CourseChapterName];
objDR[convVideoResCase_Resource_Rel.ParentNodeID] = objInFor[convVideoResCase_Resource_Rel.ParentNodeID];
objDR[convVideoResCase_Resource_Rel.ParentNodeName] = objInFor[convVideoResCase_Resource_Rel.ParentNodeName];
objDR[convVideoResCase_Resource_Rel.ViewCount] = objInFor[convVideoResCase_Resource_Rel.ViewCount];
objDR[convVideoResCase_Resource_Rel.IsShow] = objInFor[convVideoResCase_Resource_Rel.IsShow];
objDR[convVideoResCase_Resource_Rel.DownloadNumber] = objInFor[convVideoResCase_Resource_Rel.DownloadNumber];
objDR[convVideoResCase_Resource_Rel.FileIntegration] = objInFor[convVideoResCase_Resource_Rel.FileIntegration];
objDR[convVideoResCase_Resource_Rel.LikeCount] = objInFor[convVideoResCase_Resource_Rel.LikeCount];
objDR[convVideoResCase_Resource_Rel.CollectionCount] = objInFor[convVideoResCase_Resource_Rel.CollectionCount];
objDR[convVideoResCase_Resource_Rel.RecommendedDegreeId] = objInFor[convVideoResCase_Resource_Rel.RecommendedDegreeId];
objDR[convVideoResCase_Resource_Rel.RecommendedDegreeName] = objInFor[convVideoResCase_Resource_Rel.RecommendedDegreeName];
objDR[convVideoResCase_Resource_Rel.BrowseCount4Case] = objInFor[convVideoResCase_Resource_Rel.BrowseCount4Case];
objDR[convVideoResCase_Resource_Rel.OwnerName] = objInFor[convVideoResCase_Resource_Rel.OwnerName];
objDR[convVideoResCase_Resource_Rel.OwnerNameWithId] = objInFor[convVideoResCase_Resource_Rel.OwnerNameWithId];
objDR[convVideoResCase_Resource_Rel.id_Resource] = objInFor[convVideoResCase_Resource_Rel.id_Resource];
objDR[convVideoResCase_Resource_Rel.ResourceID] = objInFor[convVideoResCase_Resource_Rel.ResourceID];
objDR[convVideoResCase_Resource_Rel.ResourceName] = objInFor[convVideoResCase_Resource_Rel.ResourceName];
objDR[convVideoResCase_Resource_Rel.id_FtpResource] = objInFor[convVideoResCase_Resource_Rel.id_FtpResource];
objDR[convVideoResCase_Resource_Rel.id_File] = objInFor[convVideoResCase_Resource_Rel.id_File];
objDR[convVideoResCase_Resource_Rel.FileName] = objInFor[convVideoResCase_Resource_Rel.FileName];
objDR[convVideoResCase_Resource_Rel.FileType] = objInFor[convVideoResCase_Resource_Rel.FileType];
objDR[convVideoResCase_Resource_Rel.SaveDate] = objInFor[convVideoResCase_Resource_Rel.SaveDate];
objDR[convVideoResCase_Resource_Rel.FileSize] = objInFor[convVideoResCase_Resource_Rel.FileSize];
objDR[convVideoResCase_Resource_Rel.SaveTime] = objInFor[convVideoResCase_Resource_Rel.SaveTime];
objDR[convVideoResCase_Resource_Rel.FtpResourceID] = objInFor[convVideoResCase_Resource_Rel.FtpResourceID];
objDR[convVideoResCase_Resource_Rel.FileOriginalName] = objInFor[convVideoResCase_Resource_Rel.FileOriginalName];
objDR[convVideoResCase_Resource_Rel.FileDirName] = objInFor[convVideoResCase_Resource_Rel.FileDirName];
objDR[convVideoResCase_Resource_Rel.FileRename] = objInFor[convVideoResCase_Resource_Rel.FileRename];
objDR[convVideoResCase_Resource_Rel.FileUpDate] = objInFor[convVideoResCase_Resource_Rel.FileUpDate];
objDR[convVideoResCase_Resource_Rel.FileUpTime] = objInFor[convVideoResCase_Resource_Rel.FileUpTime];
objDR[convVideoResCase_Resource_Rel.SaveMode] = objInFor[convVideoResCase_Resource_Rel.SaveMode];
objDR[convVideoResCase_Resource_Rel.id_ResourceType] = objInFor[convVideoResCase_Resource_Rel.id_ResourceType];
objDR[convVideoResCase_Resource_Rel.ResourceTypeID] = objInFor[convVideoResCase_Resource_Rel.ResourceTypeID];
objDR[convVideoResCase_Resource_Rel.ResourceTypeName] = objInFor[convVideoResCase_Resource_Rel.ResourceTypeName];
objDR[convVideoResCase_Resource_Rel.ResourceOwner] = objInFor[convVideoResCase_Resource_Rel.ResourceOwner];
objDR[convVideoResCase_Resource_Rel.ftpFileType] = objInFor[convVideoResCase_Resource_Rel.ftpFileType];
objDR[convVideoResCase_Resource_Rel.ftpFileSize] = objInFor[convVideoResCase_Resource_Rel.ftpFileSize];
objDR[convVideoResCase_Resource_Rel.ftpResourceOwner] = objInFor[convVideoResCase_Resource_Rel.ftpResourceOwner];
objDR[convVideoResCase_Resource_Rel.FileOriginName] = objInFor[convVideoResCase_Resource_Rel.FileOriginName];
objDR[convVideoResCase_Resource_Rel.IsExistFile] = objInFor[convVideoResCase_Resource_Rel.IsExistFile];
objDR[convVideoResCase_Resource_Rel.FileNewName] = objInFor[convVideoResCase_Resource_Rel.FileNewName];
objDR[convVideoResCase_Resource_Rel.FileOldName] = objInFor[convVideoResCase_Resource_Rel.FileOldName];
objDR[convVideoResCase_Resource_Rel.IsMain] = objInFor[convVideoResCase_Resource_Rel.IsMain];
objDR[convVideoResCase_Resource_Rel.id_UsingMode] = objInFor[convVideoResCase_Resource_Rel.id_UsingMode];
objDR[convVideoResCase_Resource_Rel.IsVisible] = objInFor[convVideoResCase_Resource_Rel.IsVisible];
objDR[convVideoResCase_Resource_Rel.IndexNO] = objInFor[convVideoResCase_Resource_Rel.IndexNO];
objDR[convVideoResCase_Resource_Rel.BrowseCount] = objInFor[convVideoResCase_Resource_Rel.BrowseCount];
objDR[convVideoResCase_Resource_Rel.UpdDate] = objInFor[convVideoResCase_Resource_Rel.UpdDate];
objDR[convVideoResCase_Resource_Rel.UpdUser] = objInFor[convVideoResCase_Resource_Rel.UpdUser];
objDR[convVideoResCase_Resource_Rel.Memo] = objInFor[convVideoResCase_Resource_Rel.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}