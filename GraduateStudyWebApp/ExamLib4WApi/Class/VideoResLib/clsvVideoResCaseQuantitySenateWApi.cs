
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoResCaseQuantitySenateWApi
 表名:vVideoResCaseQuantitySenate(01120448)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:30
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
public static class clsvVideoResCaseQuantitySenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetUserTypeName(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convVideoResCaseQuantitySenate.UserTypeName);
objvVideoResCaseQuantitySenateEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.UserTypeName) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.UserTypeName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.UserTypeName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN Setid_microteachCaseQuantitySenate(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.id_microteachCaseQuantitySenate) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetFuncModuleId(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoResCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoResCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoResCaseQuantitySenate.FuncModuleId);
objvVideoResCaseQuantitySenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.FuncModuleId) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.FuncModuleId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.FuncModuleId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetFuncModuleName(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convVideoResCaseQuantitySenate.FuncModuleName);
objvVideoResCaseQuantitySenateEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.FuncModuleName) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.FuncModuleName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.FuncModuleName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN Setid_MicroteachCase(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convVideoResCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convVideoResCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convVideoResCaseQuantitySenate.id_MicroteachCase);
objvVideoResCaseQuantitySenateEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.id_MicroteachCase) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.id_MicroteachCase, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.id_MicroteachCase] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetId_VideoResCase(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strId_VideoResCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_VideoResCase, 8, convVideoResCaseQuantitySenate.Id_VideoResCase);
clsCheckSql.CheckFieldForeignKey(strId_VideoResCase, 8, convVideoResCaseQuantitySenate.Id_VideoResCase);
objvVideoResCaseQuantitySenateEN.Id_VideoResCase = strId_VideoResCase; //视频资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.Id_VideoResCase) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.Id_VideoResCase, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.Id_VideoResCase] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetVideoResCaseID(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strVideoResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseID, 8, convVideoResCaseQuantitySenate.VideoResCaseID);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseID, 8, convVideoResCaseQuantitySenate.VideoResCaseID);
objvVideoResCaseQuantitySenateEN.VideoResCaseID = strVideoResCaseID; //视频资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.VideoResCaseID) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.VideoResCaseID, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseID] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetVideoResCaseName(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strVideoResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseName, 100, convVideoResCaseQuantitySenate.VideoResCaseName);
objvVideoResCaseQuantitySenateEN.VideoResCaseName = strVideoResCaseName; //视频资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.VideoResCaseName) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.VideoResCaseName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetVideoResCaseTheme(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strVideoResCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTheme, 200, convVideoResCaseQuantitySenate.VideoResCaseTheme);
objvVideoResCaseQuantitySenateEN.VideoResCaseTheme = strVideoResCaseTheme; //视频资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.VideoResCaseTheme) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.VideoResCaseTheme, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseTheme] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetVideoResCaseTypeName(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strVideoResCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTypeName, 30, convVideoResCaseQuantitySenate.VideoResCaseTypeName);
objvVideoResCaseQuantitySenateEN.VideoResCaseTypeName = strVideoResCaseTypeName; //视频资源案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.VideoResCaseTypeName) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.VideoResCaseTypeName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseTypeName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetVideoResCaseDate(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strVideoResCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseDate, 8, convVideoResCaseQuantitySenate.VideoResCaseDate);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseDate, 8, convVideoResCaseQuantitySenate.VideoResCaseDate);
objvVideoResCaseQuantitySenateEN.VideoResCaseDate = strVideoResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.VideoResCaseDate) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.VideoResCaseDate, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseDate] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetVideoResCaseTime(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strVideoResCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTime, 6, convVideoResCaseQuantitySenate.VideoResCaseTime);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseTime, 6, convVideoResCaseQuantitySenate.VideoResCaseTime);
objvVideoResCaseQuantitySenateEN.VideoResCaseTime = strVideoResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.VideoResCaseTime) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.VideoResCaseTime, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseTime] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetVideoResCaseDateIn(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strVideoResCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseDateIn, 8, convVideoResCaseQuantitySenate.VideoResCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseDateIn, 8, convVideoResCaseQuantitySenate.VideoResCaseDateIn);
objvVideoResCaseQuantitySenateEN.VideoResCaseDateIn = strVideoResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.VideoResCaseDateIn) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.VideoResCaseDateIn, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseDateIn] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetVideoResCaseTimeIn(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strVideoResCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTimeIn, 6, convVideoResCaseQuantitySenate.VideoResCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseTimeIn, 6, convVideoResCaseQuantitySenate.VideoResCaseTimeIn);
objvVideoResCaseQuantitySenateEN.VideoResCaseTimeIn = strVideoResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.VideoResCaseTimeIn) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.VideoResCaseTimeIn, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseTimeIn] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetOwnerId(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convVideoResCaseQuantitySenate.OwnerId);
objvVideoResCaseQuantitySenateEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.OwnerId) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.OwnerId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.OwnerId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetIsDualVideo(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.IsDualVideo) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.IsDualVideo, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.IsDualVideo] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN Setid_XzCollege(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convVideoResCaseQuantitySenate.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convVideoResCaseQuantitySenate.id_XzCollege);
objvVideoResCaseQuantitySenateEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.id_XzCollege) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.id_XzCollege, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.id_XzCollege] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetCollegeID(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoResCaseQuantitySenate.CollegeID);
objvVideoResCaseQuantitySenateEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.CollegeID) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.CollegeID, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.CollegeID] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetCollegeName(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoResCaseQuantitySenate.CollegeName);
objvVideoResCaseQuantitySenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.CollegeName) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.CollegeName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.CollegeName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetCollegeNameA(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoResCaseQuantitySenate.CollegeNameA);
objvVideoResCaseQuantitySenateEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.CollegeNameA) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.CollegeNameA, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.CollegeNameA] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN Setid_XzMajor(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convVideoResCaseQuantitySenate.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convVideoResCaseQuantitySenate.id_XzMajor);
objvVideoResCaseQuantitySenateEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.id_XzMajor) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.id_XzMajor, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.id_XzMajor] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetMajorID(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convVideoResCaseQuantitySenate.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convVideoResCaseQuantitySenate.MajorID);
objvVideoResCaseQuantitySenateEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.MajorID) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.MajorID, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.MajorID] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetMajorName(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convVideoResCaseQuantitySenate.MajorName);
objvVideoResCaseQuantitySenateEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.MajorName) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.MajorName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.MajorName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetCourseId(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoResCaseQuantitySenate.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoResCaseQuantitySenate.CourseId);
objvVideoResCaseQuantitySenateEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.CourseId) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.CourseId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.CourseId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetCourseCode(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoResCaseQuantitySenate.CourseCode);
objvVideoResCaseQuantitySenateEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.CourseCode) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.CourseCode, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.CourseCode] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetCourseName(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoResCaseQuantitySenate.CourseName);
objvVideoResCaseQuantitySenateEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.CourseName) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.CourseName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.CourseName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetViewCount(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, int intViewCount, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.ViewCount) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.ViewCount, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.ViewCount] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetIsShow(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, bool bolIsShow, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.IsShow) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.IsShow, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.IsShow] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetDownloadNumber(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, int intDownloadNumber, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.DownloadNumber) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.DownloadNumber, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.DownloadNumber] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetFileIntegration(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, int intFileIntegration, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.FileIntegration) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.FileIntegration, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.FileIntegration] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetLikeCount(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, long lngLikeCount, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.LikeCount) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.LikeCount, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.LikeCount] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetCollectionCount(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, long lngCollectionCount, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.CollectionCount) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.CollectionCount, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.CollectionCount] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetOwnerName(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convVideoResCaseQuantitySenate.OwnerName);
objvVideoResCaseQuantitySenateEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.OwnerName) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.OwnerName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.OwnerName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetOwnerNameWithId(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convVideoResCaseQuantitySenate.OwnerNameWithId);
objvVideoResCaseQuantitySenateEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.OwnerNameWithId) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.OwnerNameWithId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.OwnerNameWithId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN Setid_AppraiseType(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convVideoResCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convVideoResCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convVideoResCaseQuantitySenate.id_AppraiseType);
objvVideoResCaseQuantitySenateEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.id_AppraiseType) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.id_AppraiseType, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.id_AppraiseType] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetAppraiseTypeName(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convVideoResCaseQuantitySenate.AppraiseTypeName);
objvVideoResCaseQuantitySenateEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.AppraiseTypeName) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.AppraiseTypeName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.AppraiseTypeName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetSenateTheme(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convVideoResCaseQuantitySenate.SenateTheme);
objvVideoResCaseQuantitySenateEN.SenateTheme = strSenateTheme; //量化评价主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.SenateTheme) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.SenateTheme, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.SenateTheme] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetSenateContent(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convVideoResCaseQuantitySenate.SenateContent);
objvVideoResCaseQuantitySenateEN.SenateContent = strSenateContent; //评价内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.SenateContent) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.SenateContent, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.SenateContent] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetSenateTotalScore(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, float fltSenateTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltSenateTotalScore, convVideoResCaseQuantitySenate.SenateTotalScore);
objvVideoResCaseQuantitySenateEN.SenateTotalScore = fltSenateTotalScore; //评价分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.SenateTotalScore) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.SenateTotalScore, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.SenateTotalScore] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetSenateDate(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convVideoResCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convVideoResCaseQuantitySenate.SenateDate);
objvVideoResCaseQuantitySenateEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.SenateDate) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.SenateDate, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.SenateDate] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetSenateTime(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convVideoResCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convVideoResCaseQuantitySenate.SenateTime);
objvVideoResCaseQuantitySenateEN.SenateTime = strSenateTime; //评价时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.SenateTime) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.SenateTime, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.SenateTime] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetSenateIp(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSenateIp, convVideoResCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(strSenateIp, 50, convVideoResCaseQuantitySenate.SenateIp);
objvVideoResCaseQuantitySenateEN.SenateIp = strSenateIp; //评议Ip
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.SenateIp) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.SenateIp, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.SenateIp] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetBrowseCount(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, int intBrowseCount, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.BrowseCount) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.BrowseCount, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.BrowseCount] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN Setid_SenateGaugeVersion(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convVideoResCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convVideoResCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convVideoResCaseQuantitySenate.id_SenateGaugeVersion);
objvVideoResCaseQuantitySenateEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.id_SenateGaugeVersion) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convVideoResCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convVideoResCaseQuantitySenate.senateGaugeVersionID);
objvVideoResCaseQuantitySenateEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.senateGaugeVersionID) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.senateGaugeVersionID, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.senateGaugeVersionID] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convVideoResCaseQuantitySenate.senateGaugeVersionName);
objvVideoResCaseQuantitySenateEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.senateGaugeVersionName) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.senateGaugeVersionName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.senateGaugeVersionName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetsenateGaugeVersionTtlScore(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetUserId(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convVideoResCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convVideoResCaseQuantitySenate.UserId);
objvVideoResCaseQuantitySenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.UserId) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.UserId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.UserId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetUserNameWithUserId(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convVideoResCaseQuantitySenate.UserNameWithUserId);
objvVideoResCaseQuantitySenateEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.UserNameWithUserId) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.UserNameWithUserId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.UserNameWithUserId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetUserName(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convVideoResCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(strUserName, 50, convVideoResCaseQuantitySenate.UserName);
objvVideoResCaseQuantitySenateEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.UserName) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.UserName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.UserName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetUserKindId(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convVideoResCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convVideoResCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convVideoResCaseQuantitySenate.UserKindId);
objvVideoResCaseQuantitySenateEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.UserKindId) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.UserKindId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.UserKindId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetUserKindName(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convVideoResCaseQuantitySenate.UserKindName);
objvVideoResCaseQuantitySenateEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.UserKindName) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.UserKindName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.UserKindName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetUpdUser(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convVideoResCaseQuantitySenate.UpdUser);
objvVideoResCaseQuantitySenateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.UpdUser) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.UpdUser, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.UpdUser] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetMemo(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoResCaseQuantitySenate.Memo);
objvVideoResCaseQuantitySenateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.Memo) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.Memo, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.Memo] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetUpdUserName(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convVideoResCaseQuantitySenate.UpdUserName);
objvVideoResCaseQuantitySenateEN.UpdUserName = strUpdUserName; //UpdUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.UpdUserName) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.UpdUserName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.UpdUserName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateEN SetUserTypeId(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convVideoResCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convVideoResCaseQuantitySenate.UserTypeId);
objvVideoResCaseQuantitySenateEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenate.UserTypeId) == false)
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenate.UserTypeId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateEN.dicFldComparisonOp[convVideoResCaseQuantitySenate.UserTypeId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.UserTypeName, objvVideoResCaseQuantitySenate_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenate.id_microteachCaseQuantitySenate, objvVideoResCaseQuantitySenate_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.FuncModuleId, objvVideoResCaseQuantitySenate_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.FuncModuleName, objvVideoResCaseQuantitySenate_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.id_MicroteachCase, objvVideoResCaseQuantitySenate_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.Id_VideoResCase) == true)
{
string strComparisonOp_Id_VideoResCase = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.Id_VideoResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.Id_VideoResCase, objvVideoResCaseQuantitySenate_Cond.Id_VideoResCase, strComparisonOp_Id_VideoResCase);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.VideoResCaseID) == true)
{
string strComparisonOp_VideoResCaseID = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.VideoResCaseID, objvVideoResCaseQuantitySenate_Cond.VideoResCaseID, strComparisonOp_VideoResCaseID);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.VideoResCaseName) == true)
{
string strComparisonOp_VideoResCaseName = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.VideoResCaseName, objvVideoResCaseQuantitySenate_Cond.VideoResCaseName, strComparisonOp_VideoResCaseName);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.VideoResCaseTheme) == true)
{
string strComparisonOp_VideoResCaseTheme = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.VideoResCaseTheme, objvVideoResCaseQuantitySenate_Cond.VideoResCaseTheme, strComparisonOp_VideoResCaseTheme);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.VideoResCaseTypeName) == true)
{
string strComparisonOp_VideoResCaseTypeName = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.VideoResCaseTypeName, objvVideoResCaseQuantitySenate_Cond.VideoResCaseTypeName, strComparisonOp_VideoResCaseTypeName);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.VideoResCaseDate) == true)
{
string strComparisonOp_VideoResCaseDate = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.VideoResCaseDate, objvVideoResCaseQuantitySenate_Cond.VideoResCaseDate, strComparisonOp_VideoResCaseDate);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.VideoResCaseTime) == true)
{
string strComparisonOp_VideoResCaseTime = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.VideoResCaseTime, objvVideoResCaseQuantitySenate_Cond.VideoResCaseTime, strComparisonOp_VideoResCaseTime);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.VideoResCaseDateIn) == true)
{
string strComparisonOp_VideoResCaseDateIn = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.VideoResCaseDateIn, objvVideoResCaseQuantitySenate_Cond.VideoResCaseDateIn, strComparisonOp_VideoResCaseDateIn);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.VideoResCaseTimeIn) == true)
{
string strComparisonOp_VideoResCaseTimeIn = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.VideoResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.VideoResCaseTimeIn, objvVideoResCaseQuantitySenate_Cond.VideoResCaseTimeIn, strComparisonOp_VideoResCaseTimeIn);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.OwnerId, objvVideoResCaseQuantitySenate_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.IsDualVideo) == true)
{
if (objvVideoResCaseQuantitySenate_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCaseQuantitySenate.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCaseQuantitySenate.IsDualVideo);
}
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.id_XzCollege, objvVideoResCaseQuantitySenate_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.CollegeID, objvVideoResCaseQuantitySenate_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.CollegeName, objvVideoResCaseQuantitySenate_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.CollegeNameA, objvVideoResCaseQuantitySenate_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.id_XzMajor, objvVideoResCaseQuantitySenate_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.MajorID) == true)
{
string strComparisonOp_MajorID = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.MajorID, objvVideoResCaseQuantitySenate_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.MajorName) == true)
{
string strComparisonOp_MajorName = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.MajorName, objvVideoResCaseQuantitySenate_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.CourseId) == true)
{
string strComparisonOp_CourseId = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.CourseId, objvVideoResCaseQuantitySenate_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.CourseCode, objvVideoResCaseQuantitySenate_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.CourseName) == true)
{
string strComparisonOp_CourseName = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.CourseName, objvVideoResCaseQuantitySenate_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenate.ViewCount, objvVideoResCaseQuantitySenate_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.IsShow) == true)
{
if (objvVideoResCaseQuantitySenate_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCaseQuantitySenate.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCaseQuantitySenate.IsShow);
}
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenate.DownloadNumber, objvVideoResCaseQuantitySenate_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenate.FileIntegration, objvVideoResCaseQuantitySenate_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenate.LikeCount, objvVideoResCaseQuantitySenate_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenate.CollectionCount, objvVideoResCaseQuantitySenate_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.OwnerName, objvVideoResCaseQuantitySenate_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.OwnerNameWithId, objvVideoResCaseQuantitySenate_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.id_AppraiseType, objvVideoResCaseQuantitySenate_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.AppraiseTypeName, objvVideoResCaseQuantitySenate_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.SenateTheme) == true)
{
string strComparisonOp_SenateTheme = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.SenateTheme, objvVideoResCaseQuantitySenate_Cond.SenateTheme, strComparisonOp_SenateTheme);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.SenateContent) == true)
{
string strComparisonOp_SenateContent = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.SenateContent, objvVideoResCaseQuantitySenate_Cond.SenateContent, strComparisonOp_SenateContent);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOp_SenateTotalScore = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenate.SenateTotalScore, objvVideoResCaseQuantitySenate_Cond.SenateTotalScore, strComparisonOp_SenateTotalScore);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.SenateDate, objvVideoResCaseQuantitySenate_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.SenateTime) == true)
{
string strComparisonOp_SenateTime = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.SenateTime, objvVideoResCaseQuantitySenate_Cond.SenateTime, strComparisonOp_SenateTime);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.SenateIp) == true)
{
string strComparisonOp_SenateIp = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.SenateIp, objvVideoResCaseQuantitySenate_Cond.SenateIp, strComparisonOp_SenateIp);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenate.BrowseCount, objvVideoResCaseQuantitySenate_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.id_SenateGaugeVersion, objvVideoResCaseQuantitySenate_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.senateGaugeVersionID, objvVideoResCaseQuantitySenate_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.senateGaugeVersionName, objvVideoResCaseQuantitySenate_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore, objvVideoResCaseQuantitySenate_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.UserId) == true)
{
string strComparisonOp_UserId = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.UserId, objvVideoResCaseQuantitySenate_Cond.UserId, strComparisonOp_UserId);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.UserNameWithUserId, objvVideoResCaseQuantitySenate_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.UserName) == true)
{
string strComparisonOp_UserName = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.UserName, objvVideoResCaseQuantitySenate_Cond.UserName, strComparisonOp_UserName);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.UserKindId, objvVideoResCaseQuantitySenate_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.UserKindName, objvVideoResCaseQuantitySenate_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.UpdUser, objvVideoResCaseQuantitySenate_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.Memo) == true)
{
string strComparisonOp_Memo = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.Memo, objvVideoResCaseQuantitySenate_Cond.Memo, strComparisonOp_Memo);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.UpdUserName) == true)
{
string strComparisonOp_UpdUserName = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.UpdUserName, objvVideoResCaseQuantitySenate_Cond.UpdUserName, strComparisonOp_UpdUserName);
}
if (objvVideoResCaseQuantitySenate_Cond.IsUpdated(convVideoResCaseQuantitySenate.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvVideoResCaseQuantitySenate_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenate.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenate.UserTypeId, objvVideoResCaseQuantitySenate_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频资源量化评议(vVideoResCaseQuantitySenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoResCaseQuantitySenateWApi
{
private static readonly string mstrApiControllerName = "vVideoResCaseQuantitySenateApi";

 public clsvVideoResCaseQuantitySenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoResCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN = null;
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
objvVideoResCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvVideoResCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCaseQuantitySenateEN;
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
public static clsvVideoResCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_WA_Cache(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN = null;
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
objvVideoResCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvVideoResCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCaseQuantitySenateEN;
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
public static clsvVideoResCaseQuantitySenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateEN = null;
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
objvVideoResCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvVideoResCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCaseQuantitySenateEN;
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
public static clsvVideoResCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_Cache(long lngid_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoResCaseQuantitySenateEN._CurrTabName_S);
List<clsvVideoResCaseQuantitySenateEN> arrvVideoResCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoResCaseQuantitySenateEN> arrvVideoResCaseQuantitySenateObjLst_Sel =
from objvVideoResCaseQuantitySenateEN in arrvVideoResCaseQuantitySenateObjLst_Cache
where objvVideoResCaseQuantitySenateEN.id_microteachCaseQuantitySenate == lngid_microteachCaseQuantitySenate
select objvVideoResCaseQuantitySenateEN;
if (arrvVideoResCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvVideoResCaseQuantitySenateEN obj = clsvVideoResCaseQuantitySenateWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoResCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoResCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
 List<clsvVideoResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvVideoResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvVideoResCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoResCaseQuantitySenateEN._CurrTabName_S);
List<clsvVideoResCaseQuantitySenateEN> arrvVideoResCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoResCaseQuantitySenateEN> arrvVideoResCaseQuantitySenateObjLst_Sel =
from objvVideoResCaseQuantitySenateEN in arrvVideoResCaseQuantitySenateObjLst_Cache
where arrId_microteachCaseQuantitySenate.Contains(objvVideoResCaseQuantitySenateEN.id_microteachCaseQuantitySenate)
select objvVideoResCaseQuantitySenateEN;
return arrvVideoResCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoResCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvVideoResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseQuantitySenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseQuantitySenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvVideoResCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvVideoResCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateENS, clsvVideoResCaseQuantitySenateEN objvVideoResCaseQuantitySenateENT)
{
try
{
objvVideoResCaseQuantitySenateENT.UserTypeName = objvVideoResCaseQuantitySenateENS.UserTypeName; //用户类型名称
objvVideoResCaseQuantitySenateENT.id_microteachCaseQuantitySenate = objvVideoResCaseQuantitySenateENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvVideoResCaseQuantitySenateENT.FuncModuleId = objvVideoResCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvVideoResCaseQuantitySenateENT.FuncModuleName = objvVideoResCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvVideoResCaseQuantitySenateENT.id_MicroteachCase = objvVideoResCaseQuantitySenateENS.id_MicroteachCase; //微格教学案例流水号
objvVideoResCaseQuantitySenateENT.Id_VideoResCase = objvVideoResCaseQuantitySenateENS.Id_VideoResCase; //视频资源案例流水号
objvVideoResCaseQuantitySenateENT.VideoResCaseID = objvVideoResCaseQuantitySenateENS.VideoResCaseID; //视频资源案例ID
objvVideoResCaseQuantitySenateENT.VideoResCaseName = objvVideoResCaseQuantitySenateENS.VideoResCaseName; //视频资源案例名称
objvVideoResCaseQuantitySenateENT.VideoResCaseTheme = objvVideoResCaseQuantitySenateENS.VideoResCaseTheme; //视频资源案例主题词
objvVideoResCaseQuantitySenateENT.VideoResCaseTypeName = objvVideoResCaseQuantitySenateENS.VideoResCaseTypeName; //视频资源案例类型名称
objvVideoResCaseQuantitySenateENT.VideoResCaseDate = objvVideoResCaseQuantitySenateENS.VideoResCaseDate; //视频资源日期
objvVideoResCaseQuantitySenateENT.VideoResCaseTime = objvVideoResCaseQuantitySenateENS.VideoResCaseTime; //视频资源时间
objvVideoResCaseQuantitySenateENT.VideoResCaseDateIn = objvVideoResCaseQuantitySenateENS.VideoResCaseDateIn; //案例入库日期
objvVideoResCaseQuantitySenateENT.VideoResCaseTimeIn = objvVideoResCaseQuantitySenateENS.VideoResCaseTimeIn; //案例入库时间
objvVideoResCaseQuantitySenateENT.OwnerId = objvVideoResCaseQuantitySenateENS.OwnerId; //拥有者Id
objvVideoResCaseQuantitySenateENT.IsDualVideo = objvVideoResCaseQuantitySenateENS.IsDualVideo; //是否双视频
objvVideoResCaseQuantitySenateENT.id_XzCollege = objvVideoResCaseQuantitySenateENS.id_XzCollege; //学院流水号
objvVideoResCaseQuantitySenateENT.CollegeID = objvVideoResCaseQuantitySenateENS.CollegeID; //学院ID
objvVideoResCaseQuantitySenateENT.CollegeName = objvVideoResCaseQuantitySenateENS.CollegeName; //学院名称
objvVideoResCaseQuantitySenateENT.CollegeNameA = objvVideoResCaseQuantitySenateENS.CollegeNameA; //学院名称简写
objvVideoResCaseQuantitySenateENT.id_XzMajor = objvVideoResCaseQuantitySenateENS.id_XzMajor; //专业流水号
objvVideoResCaseQuantitySenateENT.MajorID = objvVideoResCaseQuantitySenateENS.MajorID; //专业ID
objvVideoResCaseQuantitySenateENT.MajorName = objvVideoResCaseQuantitySenateENS.MajorName; //专业名称
objvVideoResCaseQuantitySenateENT.CourseId = objvVideoResCaseQuantitySenateENS.CourseId; //课程Id
objvVideoResCaseQuantitySenateENT.CourseCode = objvVideoResCaseQuantitySenateENS.CourseCode; //课程代码
objvVideoResCaseQuantitySenateENT.CourseName = objvVideoResCaseQuantitySenateENS.CourseName; //课程名称
objvVideoResCaseQuantitySenateENT.ViewCount = objvVideoResCaseQuantitySenateENS.ViewCount; //浏览量
objvVideoResCaseQuantitySenateENT.IsShow = objvVideoResCaseQuantitySenateENS.IsShow; //是否启用
objvVideoResCaseQuantitySenateENT.DownloadNumber = objvVideoResCaseQuantitySenateENS.DownloadNumber; //下载数目
objvVideoResCaseQuantitySenateENT.FileIntegration = objvVideoResCaseQuantitySenateENS.FileIntegration; //文件积分
objvVideoResCaseQuantitySenateENT.LikeCount = objvVideoResCaseQuantitySenateENS.LikeCount; //资源喜欢数量
objvVideoResCaseQuantitySenateENT.CollectionCount = objvVideoResCaseQuantitySenateENS.CollectionCount; //收藏数量
objvVideoResCaseQuantitySenateENT.OwnerName = objvVideoResCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvVideoResCaseQuantitySenateENT.OwnerNameWithId = objvVideoResCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvVideoResCaseQuantitySenateENT.id_AppraiseType = objvVideoResCaseQuantitySenateENS.id_AppraiseType; //评议类型流水号
objvVideoResCaseQuantitySenateENT.AppraiseTypeName = objvVideoResCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvVideoResCaseQuantitySenateENT.SenateTheme = objvVideoResCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvVideoResCaseQuantitySenateENT.SenateContent = objvVideoResCaseQuantitySenateENS.SenateContent; //评价内容
objvVideoResCaseQuantitySenateENT.SenateTotalScore = objvVideoResCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvVideoResCaseQuantitySenateENT.SenateDate = objvVideoResCaseQuantitySenateENS.SenateDate; //评价日期
objvVideoResCaseQuantitySenateENT.SenateTime = objvVideoResCaseQuantitySenateENS.SenateTime; //评价时间
objvVideoResCaseQuantitySenateENT.SenateIp = objvVideoResCaseQuantitySenateENS.SenateIp; //评议Ip
objvVideoResCaseQuantitySenateENT.BrowseCount = objvVideoResCaseQuantitySenateENS.BrowseCount; //浏览次数
objvVideoResCaseQuantitySenateENT.id_SenateGaugeVersion = objvVideoResCaseQuantitySenateENS.id_SenateGaugeVersion; //评价量表版本流水号
objvVideoResCaseQuantitySenateENT.senateGaugeVersionID = objvVideoResCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvVideoResCaseQuantitySenateENT.senateGaugeVersionName = objvVideoResCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvVideoResCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvVideoResCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoResCaseQuantitySenateENT.UserId = objvVideoResCaseQuantitySenateENS.UserId; //用户ID
objvVideoResCaseQuantitySenateENT.UserNameWithUserId = objvVideoResCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvVideoResCaseQuantitySenateENT.UserName = objvVideoResCaseQuantitySenateENS.UserName; //用户名
objvVideoResCaseQuantitySenateENT.UserKindId = objvVideoResCaseQuantitySenateENS.UserKindId; //用户类别Id
objvVideoResCaseQuantitySenateENT.UserKindName = objvVideoResCaseQuantitySenateENS.UserKindName; //用户类别名
objvVideoResCaseQuantitySenateENT.UpdUser = objvVideoResCaseQuantitySenateENS.UpdUser; //修改人
objvVideoResCaseQuantitySenateENT.Memo = objvVideoResCaseQuantitySenateENS.Memo; //备注
objvVideoResCaseQuantitySenateENT.UpdUserName = objvVideoResCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvVideoResCaseQuantitySenateENT.UserTypeId = objvVideoResCaseQuantitySenateENS.UserTypeId; //用户类型Id
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
public static DataTable ToDataTable(List<clsvVideoResCaseQuantitySenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoResCaseQuantitySenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoResCaseQuantitySenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoResCaseQuantitySenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoResCaseQuantitySenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoResCaseQuantitySenateEN.AttributeName)
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
//if (arrvVideoResCaseQuantitySenateObjLst_Cache == null)
//{
//arrvVideoResCaseQuantitySenateObjLst_Cache = await clsvVideoResCaseQuantitySenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoResCaseQuantitySenateEN._CurrTabName_S);
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
public static List<clsvVideoResCaseQuantitySenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoResCaseQuantitySenateEN._CurrTabName_S);
List<clsvVideoResCaseQuantitySenateEN> arrvVideoResCaseQuantitySenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoResCaseQuantitySenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoResCaseQuantitySenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoResCaseQuantitySenate.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.Id_VideoResCase, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.VideoResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.VideoResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.VideoResCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.VideoResCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.VideoResCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.VideoResCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.VideoResCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.VideoResCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.SenateTheme, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.SenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.SenateTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.SenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.SenateIp, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.UpdUserName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenate.UserTypeId, Type.GetType("System.String"));
foreach (clsvVideoResCaseQuantitySenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoResCaseQuantitySenate.UserTypeName] = objInFor[convVideoResCaseQuantitySenate.UserTypeName];
objDR[convVideoResCaseQuantitySenate.id_microteachCaseQuantitySenate] = objInFor[convVideoResCaseQuantitySenate.id_microteachCaseQuantitySenate];
objDR[convVideoResCaseQuantitySenate.FuncModuleId] = objInFor[convVideoResCaseQuantitySenate.FuncModuleId];
objDR[convVideoResCaseQuantitySenate.FuncModuleName] = objInFor[convVideoResCaseQuantitySenate.FuncModuleName];
objDR[convVideoResCaseQuantitySenate.id_MicroteachCase] = objInFor[convVideoResCaseQuantitySenate.id_MicroteachCase];
objDR[convVideoResCaseQuantitySenate.Id_VideoResCase] = objInFor[convVideoResCaseQuantitySenate.Id_VideoResCase];
objDR[convVideoResCaseQuantitySenate.VideoResCaseID] = objInFor[convVideoResCaseQuantitySenate.VideoResCaseID];
objDR[convVideoResCaseQuantitySenate.VideoResCaseName] = objInFor[convVideoResCaseQuantitySenate.VideoResCaseName];
objDR[convVideoResCaseQuantitySenate.VideoResCaseTheme] = objInFor[convVideoResCaseQuantitySenate.VideoResCaseTheme];
objDR[convVideoResCaseQuantitySenate.VideoResCaseTypeName] = objInFor[convVideoResCaseQuantitySenate.VideoResCaseTypeName];
objDR[convVideoResCaseQuantitySenate.VideoResCaseDate] = objInFor[convVideoResCaseQuantitySenate.VideoResCaseDate];
objDR[convVideoResCaseQuantitySenate.VideoResCaseTime] = objInFor[convVideoResCaseQuantitySenate.VideoResCaseTime];
objDR[convVideoResCaseQuantitySenate.VideoResCaseDateIn] = objInFor[convVideoResCaseQuantitySenate.VideoResCaseDateIn];
objDR[convVideoResCaseQuantitySenate.VideoResCaseTimeIn] = objInFor[convVideoResCaseQuantitySenate.VideoResCaseTimeIn];
objDR[convVideoResCaseQuantitySenate.OwnerId] = objInFor[convVideoResCaseQuantitySenate.OwnerId];
objDR[convVideoResCaseQuantitySenate.IsDualVideo] = objInFor[convVideoResCaseQuantitySenate.IsDualVideo];
objDR[convVideoResCaseQuantitySenate.id_XzCollege] = objInFor[convVideoResCaseQuantitySenate.id_XzCollege];
objDR[convVideoResCaseQuantitySenate.CollegeID] = objInFor[convVideoResCaseQuantitySenate.CollegeID];
objDR[convVideoResCaseQuantitySenate.CollegeName] = objInFor[convVideoResCaseQuantitySenate.CollegeName];
objDR[convVideoResCaseQuantitySenate.CollegeNameA] = objInFor[convVideoResCaseQuantitySenate.CollegeNameA];
objDR[convVideoResCaseQuantitySenate.id_XzMajor] = objInFor[convVideoResCaseQuantitySenate.id_XzMajor];
objDR[convVideoResCaseQuantitySenate.MajorID] = objInFor[convVideoResCaseQuantitySenate.MajorID];
objDR[convVideoResCaseQuantitySenate.MajorName] = objInFor[convVideoResCaseQuantitySenate.MajorName];
objDR[convVideoResCaseQuantitySenate.CourseId] = objInFor[convVideoResCaseQuantitySenate.CourseId];
objDR[convVideoResCaseQuantitySenate.CourseCode] = objInFor[convVideoResCaseQuantitySenate.CourseCode];
objDR[convVideoResCaseQuantitySenate.CourseName] = objInFor[convVideoResCaseQuantitySenate.CourseName];
objDR[convVideoResCaseQuantitySenate.ViewCount] = objInFor[convVideoResCaseQuantitySenate.ViewCount];
objDR[convVideoResCaseQuantitySenate.IsShow] = objInFor[convVideoResCaseQuantitySenate.IsShow];
objDR[convVideoResCaseQuantitySenate.DownloadNumber] = objInFor[convVideoResCaseQuantitySenate.DownloadNumber];
objDR[convVideoResCaseQuantitySenate.FileIntegration] = objInFor[convVideoResCaseQuantitySenate.FileIntegration];
objDR[convVideoResCaseQuantitySenate.LikeCount] = objInFor[convVideoResCaseQuantitySenate.LikeCount];
objDR[convVideoResCaseQuantitySenate.CollectionCount] = objInFor[convVideoResCaseQuantitySenate.CollectionCount];
objDR[convVideoResCaseQuantitySenate.OwnerName] = objInFor[convVideoResCaseQuantitySenate.OwnerName];
objDR[convVideoResCaseQuantitySenate.OwnerNameWithId] = objInFor[convVideoResCaseQuantitySenate.OwnerNameWithId];
objDR[convVideoResCaseQuantitySenate.id_AppraiseType] = objInFor[convVideoResCaseQuantitySenate.id_AppraiseType];
objDR[convVideoResCaseQuantitySenate.AppraiseTypeName] = objInFor[convVideoResCaseQuantitySenate.AppraiseTypeName];
objDR[convVideoResCaseQuantitySenate.SenateTheme] = objInFor[convVideoResCaseQuantitySenate.SenateTheme];
objDR[convVideoResCaseQuantitySenate.SenateContent] = objInFor[convVideoResCaseQuantitySenate.SenateContent];
objDR[convVideoResCaseQuantitySenate.SenateTotalScore] = objInFor[convVideoResCaseQuantitySenate.SenateTotalScore];
objDR[convVideoResCaseQuantitySenate.SenateDate] = objInFor[convVideoResCaseQuantitySenate.SenateDate];
objDR[convVideoResCaseQuantitySenate.SenateTime] = objInFor[convVideoResCaseQuantitySenate.SenateTime];
objDR[convVideoResCaseQuantitySenate.SenateIp] = objInFor[convVideoResCaseQuantitySenate.SenateIp];
objDR[convVideoResCaseQuantitySenate.BrowseCount] = objInFor[convVideoResCaseQuantitySenate.BrowseCount];
objDR[convVideoResCaseQuantitySenate.id_SenateGaugeVersion] = objInFor[convVideoResCaseQuantitySenate.id_SenateGaugeVersion];
objDR[convVideoResCaseQuantitySenate.senateGaugeVersionID] = objInFor[convVideoResCaseQuantitySenate.senateGaugeVersionID];
objDR[convVideoResCaseQuantitySenate.senateGaugeVersionName] = objInFor[convVideoResCaseQuantitySenate.senateGaugeVersionName];
objDR[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore] = objInFor[convVideoResCaseQuantitySenate.senateGaugeVersionTtlScore];
objDR[convVideoResCaseQuantitySenate.UserId] = objInFor[convVideoResCaseQuantitySenate.UserId];
objDR[convVideoResCaseQuantitySenate.UserNameWithUserId] = objInFor[convVideoResCaseQuantitySenate.UserNameWithUserId];
objDR[convVideoResCaseQuantitySenate.UserName] = objInFor[convVideoResCaseQuantitySenate.UserName];
objDR[convVideoResCaseQuantitySenate.UserKindId] = objInFor[convVideoResCaseQuantitySenate.UserKindId];
objDR[convVideoResCaseQuantitySenate.UserKindName] = objInFor[convVideoResCaseQuantitySenate.UserKindName];
objDR[convVideoResCaseQuantitySenate.UpdUser] = objInFor[convVideoResCaseQuantitySenate.UpdUser];
objDR[convVideoResCaseQuantitySenate.Memo] = objInFor[convVideoResCaseQuantitySenate.Memo];
objDR[convVideoResCaseQuantitySenate.UpdUserName] = objInFor[convVideoResCaseQuantitySenate.UpdUserName];
objDR[convVideoResCaseQuantitySenate.UserTypeId] = objInFor[convVideoResCaseQuantitySenate.UserTypeId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}