
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLib_Resource_RelWApi
 表名:vVideoLib_Resource_Rel(01120442)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:55
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频库
 模块英文名:VideoLib
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
public static class clsvVideoLib_Resource_RelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN Setid_MicroteachCase_Resource_Rel(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.id_MicroteachCase_Resource_Rel) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFuncModuleId(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoLib_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoLib_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoLib_Resource_Rel.FuncModuleId);
objvVideoLib_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FuncModuleId) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFuncModuleName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convVideoLib_Resource_Rel.FuncModuleName);
objvVideoLib_Resource_RelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FuncModuleName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FuncModuleName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FuncModuleName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN Setid_MicroteachCase(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convVideoLib_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convVideoLib_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convVideoLib_Resource_Rel.id_MicroteachCase);
objvVideoLib_Resource_RelEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.id_MicroteachCase) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.id_MicroteachCase, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.id_MicroteachCase] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibID(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibID, 8, convVideoLib_Resource_Rel.VideoLibID);
clsCheckSql.CheckFieldForeignKey(strVideoLibID, 8, convVideoLib_Resource_Rel.VideoLibID);
objvVideoLib_Resource_RelEN.VideoLibID = strVideoLibID; //视频库ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibID) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibID, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibID] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoLib_Resource_Rel.VideoLibName);
objvVideoLib_Resource_RelEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibTheme(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTheme, 200, convVideoLib_Resource_Rel.VideoLibTheme);
objvVideoLib_Resource_RelEN.VideoLibTheme = strVideoLibTheme; //视频库主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibTheme) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibTheme, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTheme] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN Setid_VideoLibType(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strid_VideoLibType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_VideoLibType, 4, convVideoLib_Resource_Rel.id_VideoLibType);
clsCheckSql.CheckFieldForeignKey(strid_VideoLibType, 4, convVideoLib_Resource_Rel.id_VideoLibType);
objvVideoLib_Resource_RelEN.id_VideoLibType = strid_VideoLibType; //视频库类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.id_VideoLibType) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.id_VideoLibType, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.id_VideoLibType] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibTypeName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTypeName, 30, convVideoLib_Resource_Rel.VideoLibTypeName);
objvVideoLib_Resource_RelEN.VideoLibTypeName = strVideoLibTypeName; //视频库类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibTypeName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibTypeName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTypeName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibText(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibText, 8000, convVideoLib_Resource_Rel.VideoLibText);
objvVideoLib_Resource_RelEN.VideoLibText = strVideoLibText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibText) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibText, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibText] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibDate(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibDate, 8, convVideoLib_Resource_Rel.VideoLibDate);
clsCheckSql.CheckFieldForeignKey(strVideoLibDate, 8, convVideoLib_Resource_Rel.VideoLibDate);
objvVideoLib_Resource_RelEN.VideoLibDate = strVideoLibDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibDate) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibDate, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibDate] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibTime(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTime, 6, convVideoLib_Resource_Rel.VideoLibTime);
clsCheckSql.CheckFieldForeignKey(strVideoLibTime, 6, convVideoLib_Resource_Rel.VideoLibTime);
objvVideoLib_Resource_RelEN.VideoLibTime = strVideoLibTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibTime) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibTime, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTime] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibDateIn(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibDateIn, 8, convVideoLib_Resource_Rel.VideoLibDateIn);
clsCheckSql.CheckFieldForeignKey(strVideoLibDateIn, 8, convVideoLib_Resource_Rel.VideoLibDateIn);
objvVideoLib_Resource_RelEN.VideoLibDateIn = strVideoLibDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibDateIn) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibDateIn, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibDateIn] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibTimeIn(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTimeIn, 6, convVideoLib_Resource_Rel.VideoLibTimeIn);
clsCheckSql.CheckFieldForeignKey(strVideoLibTimeIn, 6, convVideoLib_Resource_Rel.VideoLibTimeIn);
objvVideoLib_Resource_RelEN.VideoLibTimeIn = strVideoLibTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibTimeIn) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibTimeIn, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTimeIn] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetOwnerId(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convVideoLib_Resource_Rel.OwnerId);
objvVideoLib_Resource_RelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.OwnerId) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.OwnerId, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.OwnerId] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN Setid_TeachingPlan(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convVideoLib_Resource_Rel.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convVideoLib_Resource_Rel.id_TeachingPlan);
objvVideoLib_Resource_RelEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.id_TeachingPlan) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.id_TeachingPlan, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.id_TeachingPlan] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetsenateGaugeVersionID(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convVideoLib_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convVideoLib_Resource_Rel.senateGaugeVersionID);
objvVideoLib_Resource_RelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.senateGaugeVersionID) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetsenateGaugeVersionName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convVideoLib_Resource_Rel.senateGaugeVersionName);
objvVideoLib_Resource_RelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.senateGaugeVersionName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.senateGaugeVersionTtlScore) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVersionNo(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, int intVersionNo, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VersionNo) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VersionNo, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VersionNo] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCaseLevelId(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convVideoLib_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convVideoLib_Resource_Rel.CaseLevelId);
objvVideoLib_Resource_RelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CaseLevelId) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CaseLevelId, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CaseLevelId] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN Setid_XzCollege(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convVideoLib_Resource_Rel.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convVideoLib_Resource_Rel.id_XzCollege);
objvVideoLib_Resource_RelEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.id_XzCollege) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.id_XzCollege, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.id_XzCollege] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCollegeID(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoLib_Resource_Rel.CollegeID);
objvVideoLib_Resource_RelEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CollegeID) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CollegeID, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CollegeID] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCollegeName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoLib_Resource_Rel.CollegeName);
objvVideoLib_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CollegeName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCollegeNameA(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoLib_Resource_Rel.CollegeNameA);
objvVideoLib_Resource_RelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CollegeNameA) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CollegeNameA, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CollegeNameA] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetViewCount(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, int intViewCount, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ViewCount) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ViewCount, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ViewCount] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetDownloadNumber(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, int intDownloadNumber, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.DownloadNumber) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.DownloadNumber, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.DownloadNumber] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileIntegration(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, int intFileIntegration, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileIntegration) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileIntegration, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileIntegration] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetLikeCount(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, long lngLikeCount, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.LikeCount) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.LikeCount, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.LikeCount] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCollectionCount(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, long lngCollectionCount, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CollectionCount) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CollectionCount, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CollectionCount] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetRecommendedDegreeId(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convVideoLib_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convVideoLib_Resource_Rel.RecommendedDegreeId);
objvVideoLib_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.RecommendedDegreeId) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetRecommendedDegreeName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convVideoLib_Resource_Rel.RecommendedDegreeName);
objvVideoLib_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.RecommendedDegreeName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCourseId(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoLib_Resource_Rel.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoLib_Resource_Rel.CourseId);
objvVideoLib_Resource_RelEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CourseId) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CourseId, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CourseId] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCourseCode(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoLib_Resource_Rel.CourseCode);
objvVideoLib_Resource_RelEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CourseCode) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CourseCode, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CourseCode] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCourseName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoLib_Resource_Rel.CourseName);
objvVideoLib_Resource_RelEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CourseName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CourseName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CourseName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetBrowseCount4Case(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.BrowseCount4Case) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetOwnerName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convVideoLib_Resource_Rel.OwnerName);
objvVideoLib_Resource_RelEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.OwnerName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.OwnerName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.OwnerName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetOwnerNameWithId(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convVideoLib_Resource_Rel.OwnerNameWithId);
objvVideoLib_Resource_RelEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.OwnerNameWithId) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.OwnerNameWithId, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.OwnerNameWithId] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN Setid_Resource(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convVideoLib_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convVideoLib_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convVideoLib_Resource_Rel.id_Resource);
objvVideoLib_Resource_RelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.id_Resource) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.id_Resource, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.id_Resource] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetResourceID(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convVideoLib_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convVideoLib_Resource_Rel.ResourceID);
objvVideoLib_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ResourceID) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetResourceName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convVideoLib_Resource_Rel.ResourceName);
objvVideoLib_Resource_RelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ResourceName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ResourceName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetSaveMode(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.SaveMode) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN Setid_FtpResource(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convVideoLib_Resource_Rel.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convVideoLib_Resource_Rel.id_FtpResource);
objvVideoLib_Resource_RelEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.id_FtpResource) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.id_FtpResource, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.id_FtpResource] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFtpResourceID(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convVideoLib_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convVideoLib_Resource_Rel.FtpResourceID);
objvVideoLib_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FtpResourceID) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileOriginalName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convVideoLib_Resource_Rel.FileOriginalName);
objvVideoLib_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileOriginalName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileDirName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convVideoLib_Resource_Rel.FileDirName);
objvVideoLib_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileDirName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileRename(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convVideoLib_Resource_Rel.FileRename);
objvVideoLib_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileRename) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileUpDate(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convVideoLib_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convVideoLib_Resource_Rel.FileUpDate);
objvVideoLib_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileUpDate) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileUpTime(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convVideoLib_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convVideoLib_Resource_Rel.FileUpTime);
objvVideoLib_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileUpTime) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileSize(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convVideoLib_Resource_Rel.FileSize);
objvVideoLib_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileSize) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileType(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convVideoLib_Resource_Rel.FileType);
objvVideoLib_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileType) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetResourceOwner(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convVideoLib_Resource_Rel.ResourceOwner);
objvVideoLib_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ResourceOwner) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIsExistFile(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IsExistFile) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN Setid_File(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convVideoLib_Resource_Rel.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convVideoLib_Resource_Rel.id_File);
objvVideoLib_Resource_RelEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.id_File) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.id_File, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.id_File] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convVideoLib_Resource_Rel.FileName);
objvVideoLib_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetSaveDate(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convVideoLib_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convVideoLib_Resource_Rel.SaveDate);
objvVideoLib_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.SaveDate) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetSaveTime(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convVideoLib_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convVideoLib_Resource_Rel.SaveTime);
objvVideoLib_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.SaveTime) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileOriginName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convVideoLib_Resource_Rel.FileOriginName);
objvVideoLib_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileOriginName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN Setid_ResourceType(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convVideoLib_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convVideoLib_Resource_Rel.id_ResourceType);
objvVideoLib_Resource_RelEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.id_ResourceType) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.id_ResourceType, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.id_ResourceType] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetResourceTypeID(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convVideoLib_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convVideoLib_Resource_Rel.ResourceTypeID);
objvVideoLib_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ResourceTypeID) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetResourceTypeName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convVideoLib_Resource_Rel.ResourceTypeName);
objvVideoLib_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ResourceTypeName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileNewName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convVideoLib_Resource_Rel.FileNewName);
objvVideoLib_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileNewName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileOldName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convVideoLib_Resource_Rel.FileOldName);
objvVideoLib_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileOldName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetftpFileType(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convVideoLib_Resource_Rel.ftpFileType);
objvVideoLib_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ftpFileType) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetftpFileSize(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convVideoLib_Resource_Rel.ftpFileSize);
objvVideoLib_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ftpFileSize) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetftpResourceOwner(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convVideoLib_Resource_Rel.ftpResourceOwner);
objvVideoLib_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ftpResourceOwner) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIsMain(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IsMain) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN Setid_UsingMode(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strid_UsingMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UsingMode, 4, convVideoLib_Resource_Rel.id_UsingMode);
clsCheckSql.CheckFieldForeignKey(strid_UsingMode, 4, convVideoLib_Resource_Rel.id_UsingMode);
objvVideoLib_Resource_RelEN.id_UsingMode = strid_UsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.id_UsingMode) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.id_UsingMode, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.id_UsingMode] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIsVisible(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IsVisible) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIndexNO(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, int intIndexNO, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IndexNO) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetBrowseCount(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, int intBrowseCount, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.BrowseCount) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetUpdDate(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convVideoLib_Resource_Rel.UpdDate);
objvVideoLib_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.UpdDate) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetUpdUser(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convVideoLib_Resource_Rel.UpdUser);
objvVideoLib_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.UpdUser) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetMemo(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoLib_Resource_Rel.Memo);
objvVideoLib_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.Memo) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_Rel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.id_MicroteachCase_Resource_Rel, objvVideoLib_Resource_Rel_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FuncModuleId, objvVideoLib_Resource_Rel_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FuncModuleName, objvVideoLib_Resource_Rel_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.id_MicroteachCase, objvVideoLib_Resource_Rel_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.VideoLibID) == true)
{
string strComparisonOp_VideoLibID = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibID, objvVideoLib_Resource_Rel_Cond.VideoLibID, strComparisonOp_VideoLibID);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.VideoLibName) == true)
{
string strComparisonOp_VideoLibName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibName, objvVideoLib_Resource_Rel_Cond.VideoLibName, strComparisonOp_VideoLibName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.VideoLibTheme) == true)
{
string strComparisonOp_VideoLibTheme = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibTheme, objvVideoLib_Resource_Rel_Cond.VideoLibTheme, strComparisonOp_VideoLibTheme);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.id_VideoLibType) == true)
{
string strComparisonOp_id_VideoLibType = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.id_VideoLibType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.id_VideoLibType, objvVideoLib_Resource_Rel_Cond.id_VideoLibType, strComparisonOp_id_VideoLibType);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.VideoLibTypeName) == true)
{
string strComparisonOp_VideoLibTypeName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibTypeName, objvVideoLib_Resource_Rel_Cond.VideoLibTypeName, strComparisonOp_VideoLibTypeName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.VideoLibText) == true)
{
string strComparisonOp_VideoLibText = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibText, objvVideoLib_Resource_Rel_Cond.VideoLibText, strComparisonOp_VideoLibText);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.VideoLibDate) == true)
{
string strComparisonOp_VideoLibDate = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibDate, objvVideoLib_Resource_Rel_Cond.VideoLibDate, strComparisonOp_VideoLibDate);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.VideoLibTime) == true)
{
string strComparisonOp_VideoLibTime = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibTime, objvVideoLib_Resource_Rel_Cond.VideoLibTime, strComparisonOp_VideoLibTime);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.VideoLibDateIn) == true)
{
string strComparisonOp_VideoLibDateIn = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibDateIn, objvVideoLib_Resource_Rel_Cond.VideoLibDateIn, strComparisonOp_VideoLibDateIn);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.VideoLibTimeIn) == true)
{
string strComparisonOp_VideoLibTimeIn = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibTimeIn, objvVideoLib_Resource_Rel_Cond.VideoLibTimeIn, strComparisonOp_VideoLibTimeIn);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.OwnerId, objvVideoLib_Resource_Rel_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.id_TeachingPlan, objvVideoLib_Resource_Rel_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.senateGaugeVersionID, objvVideoLib_Resource_Rel_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.senateGaugeVersionName, objvVideoLib_Resource_Rel_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.senateGaugeVersionTtlScore, objvVideoLib_Resource_Rel_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.VersionNo, objvVideoLib_Resource_Rel_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.CaseLevelId, objvVideoLib_Resource_Rel_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.id_XzCollege, objvVideoLib_Resource_Rel_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.CollegeID, objvVideoLib_Resource_Rel_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.CollegeName, objvVideoLib_Resource_Rel_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.CollegeNameA, objvVideoLib_Resource_Rel_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.ViewCount, objvVideoLib_Resource_Rel_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.DownloadNumber, objvVideoLib_Resource_Rel_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.FileIntegration, objvVideoLib_Resource_Rel_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.LikeCount, objvVideoLib_Resource_Rel_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.CollectionCount, objvVideoLib_Resource_Rel_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.RecommendedDegreeId, objvVideoLib_Resource_Rel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.RecommendedDegreeName, objvVideoLib_Resource_Rel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.CourseId) == true)
{
string strComparisonOp_CourseId = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.CourseId, objvVideoLib_Resource_Rel_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.CourseCode, objvVideoLib_Resource_Rel_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.CourseName) == true)
{
string strComparisonOp_CourseName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.CourseName, objvVideoLib_Resource_Rel_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.BrowseCount4Case, objvVideoLib_Resource_Rel_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.OwnerName, objvVideoLib_Resource_Rel_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.OwnerNameWithId, objvVideoLib_Resource_Rel_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.id_Resource, objvVideoLib_Resource_Rel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ResourceID, objvVideoLib_Resource_Rel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ResourceName, objvVideoLib_Resource_Rel_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.SaveMode) == true)
{
if (objvVideoLib_Resource_Rel_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLib_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLib_Resource_Rel.SaveMode);
}
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.id_FtpResource, objvVideoLib_Resource_Rel_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FtpResourceID, objvVideoLib_Resource_Rel_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileOriginalName, objvVideoLib_Resource_Rel_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileDirName, objvVideoLib_Resource_Rel_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.FileRename) == true)
{
string strComparisonOp_FileRename = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileRename, objvVideoLib_Resource_Rel_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileUpDate, objvVideoLib_Resource_Rel_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileUpTime, objvVideoLib_Resource_Rel_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.FileSize) == true)
{
string strComparisonOp_FileSize = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileSize, objvVideoLib_Resource_Rel_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.FileType) == true)
{
string strComparisonOp_FileType = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileType, objvVideoLib_Resource_Rel_Cond.FileType, strComparisonOp_FileType);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ResourceOwner, objvVideoLib_Resource_Rel_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.IsExistFile) == true)
{
if (objvVideoLib_Resource_Rel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLib_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLib_Resource_Rel.IsExistFile);
}
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.id_File) == true)
{
string strComparisonOp_id_File = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.id_File, objvVideoLib_Resource_Rel_Cond.id_File, strComparisonOp_id_File);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.FileName) == true)
{
string strComparisonOp_FileName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileName, objvVideoLib_Resource_Rel_Cond.FileName, strComparisonOp_FileName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.SaveDate, objvVideoLib_Resource_Rel_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.SaveTime, objvVideoLib_Resource_Rel_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileOriginName, objvVideoLib_Resource_Rel_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.id_ResourceType, objvVideoLib_Resource_Rel_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ResourceTypeID, objvVideoLib_Resource_Rel_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ResourceTypeName, objvVideoLib_Resource_Rel_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileNewName, objvVideoLib_Resource_Rel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileOldName, objvVideoLib_Resource_Rel_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ftpFileType, objvVideoLib_Resource_Rel_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ftpFileSize, objvVideoLib_Resource_Rel_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ftpResourceOwner, objvVideoLib_Resource_Rel_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.IsMain) == true)
{
if (objvVideoLib_Resource_Rel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLib_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLib_Resource_Rel.IsMain);
}
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.id_UsingMode) == true)
{
string strComparisonOp_id_UsingMode = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.id_UsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.id_UsingMode, objvVideoLib_Resource_Rel_Cond.id_UsingMode, strComparisonOp_id_UsingMode);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.IsVisible) == true)
{
if (objvVideoLib_Resource_Rel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLib_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLib_Resource_Rel.IsVisible);
}
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.IndexNO, objvVideoLib_Resource_Rel_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.BrowseCount, objvVideoLib_Resource_Rel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.UpdDate, objvVideoLib_Resource_Rel_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.UpdUser, objvVideoLib_Resource_Rel_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvVideoLib_Resource_Rel_Cond.IsUpdated(convVideoLib_Resource_Rel.Memo) == true)
{
string strComparisonOp_Memo = objvVideoLib_Resource_Rel_Cond.dicFldComparisonOp[convVideoLib_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.Memo, objvVideoLib_Resource_Rel_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频库资源关系(vVideoLib_Resource_Rel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoLib_Resource_RelWApi
{
private static readonly string mstrApiControllerName = "vVideoLib_Resource_RelApi";

 public clsvVideoLib_Resource_RelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLib_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = null;
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
objvVideoLib_Resource_RelEN = JsonConvert.DeserializeObject<clsvVideoLib_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLib_Resource_RelEN;
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
public static clsvVideoLib_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_WA_Cache(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = null;
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
objvVideoLib_Resource_RelEN = JsonConvert.DeserializeObject<clsvVideoLib_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLib_Resource_RelEN;
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
public static clsvVideoLib_Resource_RelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = null;
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
objvVideoLib_Resource_RelEN = JsonConvert.DeserializeObject<clsvVideoLib_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLib_Resource_RelEN;
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
public static clsvVideoLib_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_Cache(long lngid_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLib_Resource_RelEN._CurrTabName_S);
List<clsvVideoLib_Resource_RelEN> arrvVideoLib_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLib_Resource_RelEN> arrvVideoLib_Resource_RelObjLst_Sel =
from objvVideoLib_Resource_RelEN in arrvVideoLib_Resource_RelObjLst_Cache
where objvVideoLib_Resource_RelEN.id_MicroteachCase_Resource_Rel == lngid_MicroteachCase_Resource_Rel
select objvVideoLib_Resource_RelEN;
if (arrvVideoLib_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvVideoLib_Resource_RelEN obj = clsvVideoLib_Resource_RelWApi.GetObjByid_MicroteachCase_Resource_Rel(lngid_MicroteachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoLib_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLib_Resource_RelEN> GetObjLst(string strWhereCond)
{
 List<clsvVideoLib_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLib_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLib_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvVideoLib_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLib_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvVideoLib_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLib_Resource_RelEN._CurrTabName_S);
List<clsvVideoLib_Resource_RelEN> arrvVideoLib_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLib_Resource_RelEN> arrvVideoLib_Resource_RelObjLst_Sel =
from objvVideoLib_Resource_RelEN in arrvVideoLib_Resource_RelObjLst_Cache
where arrId_MicroteachCase_Resource_Rel.Contains(objvVideoLib_Resource_RelEN.id_MicroteachCase_Resource_Rel)
select objvVideoLib_Resource_RelEN;
return arrvVideoLib_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLib_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_WA_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvVideoLib_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLib_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLib_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoLib_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLib_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLib_Resource_RelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoLib_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLib_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLib_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoLib_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLib_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLib_Resource_RelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoLib_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLib_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvVideoLib_Resource_RelENS">源对象</param>
 /// <param name = "objvVideoLib_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelENS, clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelENT)
{
try
{
objvVideoLib_Resource_RelENT.id_MicroteachCase_Resource_Rel = objvVideoLib_Resource_RelENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvVideoLib_Resource_RelENT.FuncModuleId = objvVideoLib_Resource_RelENS.FuncModuleId; //功能模块Id
objvVideoLib_Resource_RelENT.FuncModuleName = objvVideoLib_Resource_RelENS.FuncModuleName; //功能模块名称
objvVideoLib_Resource_RelENT.id_MicroteachCase = objvVideoLib_Resource_RelENS.id_MicroteachCase; //微格教学案例流水号
objvVideoLib_Resource_RelENT.VideoLibID = objvVideoLib_Resource_RelENS.VideoLibID; //视频库ID
objvVideoLib_Resource_RelENT.VideoLibName = objvVideoLib_Resource_RelENS.VideoLibName; //视频名称
objvVideoLib_Resource_RelENT.VideoLibTheme = objvVideoLib_Resource_RelENS.VideoLibTheme; //视频库主题词
objvVideoLib_Resource_RelENT.id_VideoLibType = objvVideoLib_Resource_RelENS.id_VideoLibType; //视频库类型流水号
objvVideoLib_Resource_RelENT.VideoLibTypeName = objvVideoLib_Resource_RelENS.VideoLibTypeName; //视频库类型名称
objvVideoLib_Resource_RelENT.VideoLibText = objvVideoLib_Resource_RelENS.VideoLibText; //案例文本内容
objvVideoLib_Resource_RelENT.VideoLibDate = objvVideoLib_Resource_RelENS.VideoLibDate; //视频资源日期
objvVideoLib_Resource_RelENT.VideoLibTime = objvVideoLib_Resource_RelENS.VideoLibTime; //视频资源时间
objvVideoLib_Resource_RelENT.VideoLibDateIn = objvVideoLib_Resource_RelENS.VideoLibDateIn; //案例入库日期
objvVideoLib_Resource_RelENT.VideoLibTimeIn = objvVideoLib_Resource_RelENS.VideoLibTimeIn; //案例入库时间
objvVideoLib_Resource_RelENT.OwnerId = objvVideoLib_Resource_RelENS.OwnerId; //拥有者Id
objvVideoLib_Resource_RelENT.id_TeachingPlan = objvVideoLib_Resource_RelENS.id_TeachingPlan; //教案流水号
objvVideoLib_Resource_RelENT.senateGaugeVersionID = objvVideoLib_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvVideoLib_Resource_RelENT.senateGaugeVersionName = objvVideoLib_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLib_Resource_RelENT.senateGaugeVersionTtlScore = objvVideoLib_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoLib_Resource_RelENT.VersionNo = objvVideoLib_Resource_RelENS.VersionNo; //版本号
objvVideoLib_Resource_RelENT.CaseLevelId = objvVideoLib_Resource_RelENS.CaseLevelId; //课例等级Id
objvVideoLib_Resource_RelENT.id_XzCollege = objvVideoLib_Resource_RelENS.id_XzCollege; //学院流水号
objvVideoLib_Resource_RelENT.CollegeID = objvVideoLib_Resource_RelENS.CollegeID; //学院ID
objvVideoLib_Resource_RelENT.CollegeName = objvVideoLib_Resource_RelENS.CollegeName; //学院名称
objvVideoLib_Resource_RelENT.CollegeNameA = objvVideoLib_Resource_RelENS.CollegeNameA; //学院名称简写
objvVideoLib_Resource_RelENT.ViewCount = objvVideoLib_Resource_RelENS.ViewCount; //浏览量
objvVideoLib_Resource_RelENT.DownloadNumber = objvVideoLib_Resource_RelENS.DownloadNumber; //下载数目
objvVideoLib_Resource_RelENT.FileIntegration = objvVideoLib_Resource_RelENS.FileIntegration; //文件积分
objvVideoLib_Resource_RelENT.LikeCount = objvVideoLib_Resource_RelENS.LikeCount; //资源喜欢数量
objvVideoLib_Resource_RelENT.CollectionCount = objvVideoLib_Resource_RelENS.CollectionCount; //收藏数量
objvVideoLib_Resource_RelENT.RecommendedDegreeId = objvVideoLib_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvVideoLib_Resource_RelENT.RecommendedDegreeName = objvVideoLib_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvVideoLib_Resource_RelENT.CourseId = objvVideoLib_Resource_RelENS.CourseId; //课程Id
objvVideoLib_Resource_RelENT.CourseCode = objvVideoLib_Resource_RelENS.CourseCode; //课程代码
objvVideoLib_Resource_RelENT.CourseName = objvVideoLib_Resource_RelENS.CourseName; //课程名称
objvVideoLib_Resource_RelENT.BrowseCount4Case = objvVideoLib_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvVideoLib_Resource_RelENT.OwnerName = objvVideoLib_Resource_RelENS.OwnerName; //拥有者姓名
objvVideoLib_Resource_RelENT.OwnerNameWithId = objvVideoLib_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvVideoLib_Resource_RelENT.id_Resource = objvVideoLib_Resource_RelENS.id_Resource; //资源流水号
objvVideoLib_Resource_RelENT.ResourceID = objvVideoLib_Resource_RelENS.ResourceID; //资源ID
objvVideoLib_Resource_RelENT.ResourceName = objvVideoLib_Resource_RelENS.ResourceName; //资源名称
objvVideoLib_Resource_RelENT.SaveMode = objvVideoLib_Resource_RelENS.SaveMode; //文件存放方式
objvVideoLib_Resource_RelENT.id_FtpResource = objvVideoLib_Resource_RelENS.id_FtpResource; //FTP资源流水号
objvVideoLib_Resource_RelENT.FtpResourceID = objvVideoLib_Resource_RelENS.FtpResourceID; //FTP资源ID
objvVideoLib_Resource_RelENT.FileOriginalName = objvVideoLib_Resource_RelENS.FileOriginalName; //文件原名
objvVideoLib_Resource_RelENT.FileDirName = objvVideoLib_Resource_RelENS.FileDirName; //文件目录名
objvVideoLib_Resource_RelENT.FileRename = objvVideoLib_Resource_RelENS.FileRename; //文件新名
objvVideoLib_Resource_RelENT.FileUpDate = objvVideoLib_Resource_RelENS.FileUpDate; //创建日期
objvVideoLib_Resource_RelENT.FileUpTime = objvVideoLib_Resource_RelENS.FileUpTime; //创建时间
objvVideoLib_Resource_RelENT.FileSize = objvVideoLib_Resource_RelENS.FileSize; //文件大小
objvVideoLib_Resource_RelENT.FileType = objvVideoLib_Resource_RelENS.FileType; //文件类型
objvVideoLib_Resource_RelENT.ResourceOwner = objvVideoLib_Resource_RelENS.ResourceOwner; //上传者
objvVideoLib_Resource_RelENT.IsExistFile = objvVideoLib_Resource_RelENS.IsExistFile; //是否存在文件
objvVideoLib_Resource_RelENT.id_File = objvVideoLib_Resource_RelENS.id_File; //文件流水号
objvVideoLib_Resource_RelENT.FileName = objvVideoLib_Resource_RelENS.FileName; //文件名称
objvVideoLib_Resource_RelENT.SaveDate = objvVideoLib_Resource_RelENS.SaveDate; //创建日期
objvVideoLib_Resource_RelENT.SaveTime = objvVideoLib_Resource_RelENS.SaveTime; //创建时间
objvVideoLib_Resource_RelENT.FileOriginName = objvVideoLib_Resource_RelENS.FileOriginName; //原文件名
objvVideoLib_Resource_RelENT.id_ResourceType = objvVideoLib_Resource_RelENS.id_ResourceType; //资源类型流水号
objvVideoLib_Resource_RelENT.ResourceTypeID = objvVideoLib_Resource_RelENS.ResourceTypeID; //资源类型ID
objvVideoLib_Resource_RelENT.ResourceTypeName = objvVideoLib_Resource_RelENS.ResourceTypeName; //资源类型名称
objvVideoLib_Resource_RelENT.FileNewName = objvVideoLib_Resource_RelENS.FileNewName; //新文件名
objvVideoLib_Resource_RelENT.FileOldName = objvVideoLib_Resource_RelENS.FileOldName; //旧文件名
objvVideoLib_Resource_RelENT.ftpFileType = objvVideoLib_Resource_RelENS.ftpFileType; //ftp文件类型
objvVideoLib_Resource_RelENT.ftpFileSize = objvVideoLib_Resource_RelENS.ftpFileSize; //ftp文件大小
objvVideoLib_Resource_RelENT.ftpResourceOwner = objvVideoLib_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvVideoLib_Resource_RelENT.IsMain = objvVideoLib_Resource_RelENS.IsMain; //是否主资源
objvVideoLib_Resource_RelENT.id_UsingMode = objvVideoLib_Resource_RelENS.id_UsingMode; //资源使用模式流水号
objvVideoLib_Resource_RelENT.IsVisible = objvVideoLib_Resource_RelENS.IsVisible; //是否显示
objvVideoLib_Resource_RelENT.IndexNO = objvVideoLib_Resource_RelENS.IndexNO; //序号
objvVideoLib_Resource_RelENT.BrowseCount = objvVideoLib_Resource_RelENS.BrowseCount; //浏览次数
objvVideoLib_Resource_RelENT.UpdDate = objvVideoLib_Resource_RelENS.UpdDate; //修改日期
objvVideoLib_Resource_RelENT.UpdUser = objvVideoLib_Resource_RelENS.UpdUser; //修改人
objvVideoLib_Resource_RelENT.Memo = objvVideoLib_Resource_RelENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvVideoLib_Resource_RelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoLib_Resource_RelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoLib_Resource_RelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoLib_Resource_RelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoLib_Resource_RelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoLib_Resource_RelEN.AttributeName)
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
if (clsVideoLibWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibWApi没有刷新缓存机制(clsVideoLibWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoLibTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibTypeWApi没有刷新缓存机制(clsVideoLibTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase_Resource_Rel");
//if (arrvVideoLib_Resource_RelObjLst_Cache == null)
//{
//arrvVideoLib_Resource_RelObjLst_Cache = await clsvVideoLib_Resource_RelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoLib_Resource_RelEN._CurrTabName_S);
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
public static List<clsvVideoLib_Resource_RelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoLib_Resource_RelEN._CurrTabName_S);
List<clsvVideoLib_Resource_RelEN> arrvVideoLib_Resource_RelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoLib_Resource_RelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoLib_Resource_RelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoLib_Resource_Rel.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoLib_Resource_Rel.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.VideoLibID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.VideoLibName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.VideoLibTheme, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.id_VideoLibType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.VideoLibTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.VideoLibText, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.VideoLibDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.VideoLibTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.VideoLibDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.VideoLibTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoLib_Resource_Rel.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib_Resource_Rel.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib_Resource_Rel.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib_Resource_Rel.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib_Resource_Rel.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoLib_Resource_Rel.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoLib_Resource_Rel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib_Resource_Rel.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoLib_Resource_Rel.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoLib_Resource_Rel.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoLib_Resource_Rel.id_UsingMode, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoLib_Resource_Rel.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib_Resource_Rel.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib_Resource_Rel.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Resource_Rel.Memo, Type.GetType("System.String"));
foreach (clsvVideoLib_Resource_RelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoLib_Resource_Rel.id_MicroteachCase_Resource_Rel] = objInFor[convVideoLib_Resource_Rel.id_MicroteachCase_Resource_Rel];
objDR[convVideoLib_Resource_Rel.FuncModuleId] = objInFor[convVideoLib_Resource_Rel.FuncModuleId];
objDR[convVideoLib_Resource_Rel.FuncModuleName] = objInFor[convVideoLib_Resource_Rel.FuncModuleName];
objDR[convVideoLib_Resource_Rel.id_MicroteachCase] = objInFor[convVideoLib_Resource_Rel.id_MicroteachCase];
objDR[convVideoLib_Resource_Rel.VideoLibID] = objInFor[convVideoLib_Resource_Rel.VideoLibID];
objDR[convVideoLib_Resource_Rel.VideoLibName] = objInFor[convVideoLib_Resource_Rel.VideoLibName];
objDR[convVideoLib_Resource_Rel.VideoLibTheme] = objInFor[convVideoLib_Resource_Rel.VideoLibTheme];
objDR[convVideoLib_Resource_Rel.id_VideoLibType] = objInFor[convVideoLib_Resource_Rel.id_VideoLibType];
objDR[convVideoLib_Resource_Rel.VideoLibTypeName] = objInFor[convVideoLib_Resource_Rel.VideoLibTypeName];
objDR[convVideoLib_Resource_Rel.VideoLibText] = objInFor[convVideoLib_Resource_Rel.VideoLibText];
objDR[convVideoLib_Resource_Rel.VideoLibDate] = objInFor[convVideoLib_Resource_Rel.VideoLibDate];
objDR[convVideoLib_Resource_Rel.VideoLibTime] = objInFor[convVideoLib_Resource_Rel.VideoLibTime];
objDR[convVideoLib_Resource_Rel.VideoLibDateIn] = objInFor[convVideoLib_Resource_Rel.VideoLibDateIn];
objDR[convVideoLib_Resource_Rel.VideoLibTimeIn] = objInFor[convVideoLib_Resource_Rel.VideoLibTimeIn];
objDR[convVideoLib_Resource_Rel.OwnerId] = objInFor[convVideoLib_Resource_Rel.OwnerId];
objDR[convVideoLib_Resource_Rel.id_TeachingPlan] = objInFor[convVideoLib_Resource_Rel.id_TeachingPlan];
objDR[convVideoLib_Resource_Rel.senateGaugeVersionID] = objInFor[convVideoLib_Resource_Rel.senateGaugeVersionID];
objDR[convVideoLib_Resource_Rel.senateGaugeVersionName] = objInFor[convVideoLib_Resource_Rel.senateGaugeVersionName];
objDR[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] = objInFor[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore];
objDR[convVideoLib_Resource_Rel.VersionNo] = objInFor[convVideoLib_Resource_Rel.VersionNo];
objDR[convVideoLib_Resource_Rel.CaseLevelId] = objInFor[convVideoLib_Resource_Rel.CaseLevelId];
objDR[convVideoLib_Resource_Rel.id_XzCollege] = objInFor[convVideoLib_Resource_Rel.id_XzCollege];
objDR[convVideoLib_Resource_Rel.CollegeID] = objInFor[convVideoLib_Resource_Rel.CollegeID];
objDR[convVideoLib_Resource_Rel.CollegeName] = objInFor[convVideoLib_Resource_Rel.CollegeName];
objDR[convVideoLib_Resource_Rel.CollegeNameA] = objInFor[convVideoLib_Resource_Rel.CollegeNameA];
objDR[convVideoLib_Resource_Rel.ViewCount] = objInFor[convVideoLib_Resource_Rel.ViewCount];
objDR[convVideoLib_Resource_Rel.DownloadNumber] = objInFor[convVideoLib_Resource_Rel.DownloadNumber];
objDR[convVideoLib_Resource_Rel.FileIntegration] = objInFor[convVideoLib_Resource_Rel.FileIntegration];
objDR[convVideoLib_Resource_Rel.LikeCount] = objInFor[convVideoLib_Resource_Rel.LikeCount];
objDR[convVideoLib_Resource_Rel.CollectionCount] = objInFor[convVideoLib_Resource_Rel.CollectionCount];
objDR[convVideoLib_Resource_Rel.RecommendedDegreeId] = objInFor[convVideoLib_Resource_Rel.RecommendedDegreeId];
objDR[convVideoLib_Resource_Rel.RecommendedDegreeName] = objInFor[convVideoLib_Resource_Rel.RecommendedDegreeName];
objDR[convVideoLib_Resource_Rel.CourseId] = objInFor[convVideoLib_Resource_Rel.CourseId];
objDR[convVideoLib_Resource_Rel.CourseCode] = objInFor[convVideoLib_Resource_Rel.CourseCode];
objDR[convVideoLib_Resource_Rel.CourseName] = objInFor[convVideoLib_Resource_Rel.CourseName];
objDR[convVideoLib_Resource_Rel.BrowseCount4Case] = objInFor[convVideoLib_Resource_Rel.BrowseCount4Case];
objDR[convVideoLib_Resource_Rel.OwnerName] = objInFor[convVideoLib_Resource_Rel.OwnerName];
objDR[convVideoLib_Resource_Rel.OwnerNameWithId] = objInFor[convVideoLib_Resource_Rel.OwnerNameWithId];
objDR[convVideoLib_Resource_Rel.id_Resource] = objInFor[convVideoLib_Resource_Rel.id_Resource];
objDR[convVideoLib_Resource_Rel.ResourceID] = objInFor[convVideoLib_Resource_Rel.ResourceID];
objDR[convVideoLib_Resource_Rel.ResourceName] = objInFor[convVideoLib_Resource_Rel.ResourceName];
objDR[convVideoLib_Resource_Rel.SaveMode] = objInFor[convVideoLib_Resource_Rel.SaveMode];
objDR[convVideoLib_Resource_Rel.id_FtpResource] = objInFor[convVideoLib_Resource_Rel.id_FtpResource];
objDR[convVideoLib_Resource_Rel.FtpResourceID] = objInFor[convVideoLib_Resource_Rel.FtpResourceID];
objDR[convVideoLib_Resource_Rel.FileOriginalName] = objInFor[convVideoLib_Resource_Rel.FileOriginalName];
objDR[convVideoLib_Resource_Rel.FileDirName] = objInFor[convVideoLib_Resource_Rel.FileDirName];
objDR[convVideoLib_Resource_Rel.FileRename] = objInFor[convVideoLib_Resource_Rel.FileRename];
objDR[convVideoLib_Resource_Rel.FileUpDate] = objInFor[convVideoLib_Resource_Rel.FileUpDate];
objDR[convVideoLib_Resource_Rel.FileUpTime] = objInFor[convVideoLib_Resource_Rel.FileUpTime];
objDR[convVideoLib_Resource_Rel.FileSize] = objInFor[convVideoLib_Resource_Rel.FileSize];
objDR[convVideoLib_Resource_Rel.FileType] = objInFor[convVideoLib_Resource_Rel.FileType];
objDR[convVideoLib_Resource_Rel.ResourceOwner] = objInFor[convVideoLib_Resource_Rel.ResourceOwner];
objDR[convVideoLib_Resource_Rel.IsExistFile] = objInFor[convVideoLib_Resource_Rel.IsExistFile];
objDR[convVideoLib_Resource_Rel.id_File] = objInFor[convVideoLib_Resource_Rel.id_File];
objDR[convVideoLib_Resource_Rel.FileName] = objInFor[convVideoLib_Resource_Rel.FileName];
objDR[convVideoLib_Resource_Rel.SaveDate] = objInFor[convVideoLib_Resource_Rel.SaveDate];
objDR[convVideoLib_Resource_Rel.SaveTime] = objInFor[convVideoLib_Resource_Rel.SaveTime];
objDR[convVideoLib_Resource_Rel.FileOriginName] = objInFor[convVideoLib_Resource_Rel.FileOriginName];
objDR[convVideoLib_Resource_Rel.id_ResourceType] = objInFor[convVideoLib_Resource_Rel.id_ResourceType];
objDR[convVideoLib_Resource_Rel.ResourceTypeID] = objInFor[convVideoLib_Resource_Rel.ResourceTypeID];
objDR[convVideoLib_Resource_Rel.ResourceTypeName] = objInFor[convVideoLib_Resource_Rel.ResourceTypeName];
objDR[convVideoLib_Resource_Rel.FileNewName] = objInFor[convVideoLib_Resource_Rel.FileNewName];
objDR[convVideoLib_Resource_Rel.FileOldName] = objInFor[convVideoLib_Resource_Rel.FileOldName];
objDR[convVideoLib_Resource_Rel.ftpFileType] = objInFor[convVideoLib_Resource_Rel.ftpFileType];
objDR[convVideoLib_Resource_Rel.ftpFileSize] = objInFor[convVideoLib_Resource_Rel.ftpFileSize];
objDR[convVideoLib_Resource_Rel.ftpResourceOwner] = objInFor[convVideoLib_Resource_Rel.ftpResourceOwner];
objDR[convVideoLib_Resource_Rel.IsMain] = objInFor[convVideoLib_Resource_Rel.IsMain];
objDR[convVideoLib_Resource_Rel.id_UsingMode] = objInFor[convVideoLib_Resource_Rel.id_UsingMode];
objDR[convVideoLib_Resource_Rel.IsVisible] = objInFor[convVideoLib_Resource_Rel.IsVisible];
objDR[convVideoLib_Resource_Rel.IndexNO] = objInFor[convVideoLib_Resource_Rel.IndexNO];
objDR[convVideoLib_Resource_Rel.BrowseCount] = objInFor[convVideoLib_Resource_Rel.BrowseCount];
objDR[convVideoLib_Resource_Rel.UpdDate] = objInFor[convVideoLib_Resource_Rel.UpdDate];
objDR[convVideoLib_Resource_Rel.UpdUser] = objInFor[convVideoLib_Resource_Rel.UpdUser];
objDR[convVideoLib_Resource_Rel.Memo] = objInFor[convVideoLib_Resource_Rel.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}