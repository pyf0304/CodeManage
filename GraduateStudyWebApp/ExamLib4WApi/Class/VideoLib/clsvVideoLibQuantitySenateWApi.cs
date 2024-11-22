
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibQuantitySenateWApi
 表名:vVideoLibQuantitySenate(01120449)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:19
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
public static class clsvVideoLibQuantitySenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN Setid_microteachCaseQuantitySenate(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
objvVideoLibQuantitySenateEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.id_microteachCaseQuantitySenate) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetFuncModuleId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoLibQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoLibQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoLibQuantitySenate.FuncModuleId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetFuncModuleName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convVideoLibQuantitySenate.FuncModuleName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN Setid_MicroteachCase(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convVideoLibQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convVideoLibQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convVideoLibQuantitySenate.id_MicroteachCase);
objvVideoLibQuantitySenateEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.id_MicroteachCase) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.id_MicroteachCase, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.id_MicroteachCase] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetId_VideoLib(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strId_VideoLib, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_VideoLib, 8, convVideoLibQuantitySenate.Id_VideoLib);
clsCheckSql.CheckFieldForeignKey(strId_VideoLib, 8, convVideoLibQuantitySenate.Id_VideoLib);
objvVideoLibQuantitySenateEN.Id_VideoLib = strId_VideoLib; //视频库流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.Id_VideoLib) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.Id_VideoLib, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.Id_VideoLib] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibID(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibID, 8, convVideoLibQuantitySenate.VideoLibID);
clsCheckSql.CheckFieldForeignKey(strVideoLibID, 8, convVideoLibQuantitySenate.VideoLibID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoLibQuantitySenate.VideoLibName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibTheme(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTheme, 200, convVideoLibQuantitySenate.VideoLibTheme);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibTypeName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTypeName, 30, convVideoLibQuantitySenate.VideoLibTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibDate(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibDate, 8, convVideoLibQuantitySenate.VideoLibDate);
clsCheckSql.CheckFieldForeignKey(strVideoLibDate, 8, convVideoLibQuantitySenate.VideoLibDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibTime(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTime, 6, convVideoLibQuantitySenate.VideoLibTime);
clsCheckSql.CheckFieldForeignKey(strVideoLibTime, 6, convVideoLibQuantitySenate.VideoLibTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibDateIn(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibDateIn, 8, convVideoLibQuantitySenate.VideoLibDateIn);
clsCheckSql.CheckFieldForeignKey(strVideoLibDateIn, 8, convVideoLibQuantitySenate.VideoLibDateIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetVideoLibTimeIn(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strVideoLibTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTimeIn, 6, convVideoLibQuantitySenate.VideoLibTimeIn);
clsCheckSql.CheckFieldForeignKey(strVideoLibTimeIn, 6, convVideoLibQuantitySenate.VideoLibTimeIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetOwnerId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convVideoLibQuantitySenate.OwnerId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN Setid_XzCollege(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convVideoLibQuantitySenate.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convVideoLibQuantitySenate.id_XzCollege);
objvVideoLibQuantitySenateEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.id_XzCollege) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.id_XzCollege, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.id_XzCollege] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetCollegeID(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoLibQuantitySenate.CollegeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetCollegeName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoLibQuantitySenate.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetCollegeNameA(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoLibQuantitySenate.CollegeNameA);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetViewCount(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, int intViewCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetDownloadNumber(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, int intDownloadNumber, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetFileIntegration(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, int intFileIntegration, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetLikeCount(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, long lngLikeCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetCollectionCount(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, long lngCollectionCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetCourseId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoLibQuantitySenate.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoLibQuantitySenate.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetCourseCode(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoLibQuantitySenate.CourseCode);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetCourseName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoLibQuantitySenate.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetOwnerName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convVideoLibQuantitySenate.OwnerName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetOwnerNameWithId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convVideoLibQuantitySenate.OwnerNameWithId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN Setid_AppraiseType(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convVideoLibQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convVideoLibQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convVideoLibQuantitySenate.id_AppraiseType);
objvVideoLibQuantitySenateEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.id_AppraiseType) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.id_AppraiseType, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.id_AppraiseType] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetAppraiseTypeName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convVideoLibQuantitySenate.AppraiseTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetSenateTheme(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convVideoLibQuantitySenate.SenateTheme);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetSenateContent(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convVideoLibQuantitySenate.SenateContent);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetSenateDate(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convVideoLibQuantitySenate.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convVideoLibQuantitySenate.SenateDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetSenateTime(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convVideoLibQuantitySenate.SenateTime);
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convVideoLibQuantitySenate.SenateTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetSenateIp(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSenateIp, convVideoLibQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(strSenateIp, 50, convVideoLibQuantitySenate.SenateIp);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetBrowseCount(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, int intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN Setid_SenateGaugeVersion(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convVideoLibQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convVideoLibQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convVideoLibQuantitySenate.id_SenateGaugeVersion);
objvVideoLibQuantitySenateEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenate.id_SenateGaugeVersion) == false)
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp.Add(convVideoLibQuantitySenate.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateEN.dicFldComparisonOp[convVideoLibQuantitySenate.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetsenateGaugeVersionID(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convVideoLibQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convVideoLibQuantitySenate.senateGaugeVersionID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetsenateGaugeVersionName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convVideoLibQuantitySenate.senateGaugeVersionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetsenateGaugeVersionTtlScore(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUserId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convVideoLibQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convVideoLibQuantitySenate.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUserNameWithUserId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convVideoLibQuantitySenate.UserNameWithUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUserName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convVideoLibQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(strUserName, 50, convVideoLibQuantitySenate.UserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUserKindId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convVideoLibQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convVideoLibQuantitySenate.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convVideoLibQuantitySenate.UserKindId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUserKindName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convVideoLibQuantitySenate.UserKindName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUserTypeId(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convVideoLibQuantitySenate.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convVideoLibQuantitySenate.UserTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUserTypeName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convVideoLibQuantitySenate.UserTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUpdUser(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convVideoLibQuantitySenate.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetMemo(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoLibQuantitySenate.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateEN SetUpdUserName(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convVideoLibQuantitySenate.UpdUserName);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.id_microteachCaseQuantitySenate, objvVideoLibQuantitySenate_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.FuncModuleId, objvVideoLibQuantitySenate_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.FuncModuleName, objvVideoLibQuantitySenate_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.id_MicroteachCase, objvVideoLibQuantitySenate_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.Id_VideoLib) == true)
{
string strComparisonOp_Id_VideoLib = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.Id_VideoLib];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.Id_VideoLib, objvVideoLibQuantitySenate_Cond.Id_VideoLib, strComparisonOp_Id_VideoLib);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.VideoLibID) == true)
{
string strComparisonOp_VideoLibID = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibID, objvVideoLibQuantitySenate_Cond.VideoLibID, strComparisonOp_VideoLibID);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.VideoLibName) == true)
{
string strComparisonOp_VideoLibName = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibName, objvVideoLibQuantitySenate_Cond.VideoLibName, strComparisonOp_VideoLibName);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.VideoLibTheme) == true)
{
string strComparisonOp_VideoLibTheme = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibTheme, objvVideoLibQuantitySenate_Cond.VideoLibTheme, strComparisonOp_VideoLibTheme);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.VideoLibTypeName) == true)
{
string strComparisonOp_VideoLibTypeName = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibTypeName, objvVideoLibQuantitySenate_Cond.VideoLibTypeName, strComparisonOp_VideoLibTypeName);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.VideoLibDate) == true)
{
string strComparisonOp_VideoLibDate = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibDate, objvVideoLibQuantitySenate_Cond.VideoLibDate, strComparisonOp_VideoLibDate);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.VideoLibTime) == true)
{
string strComparisonOp_VideoLibTime = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibTime, objvVideoLibQuantitySenate_Cond.VideoLibTime, strComparisonOp_VideoLibTime);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.VideoLibDateIn) == true)
{
string strComparisonOp_VideoLibDateIn = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibDateIn, objvVideoLibQuantitySenate_Cond.VideoLibDateIn, strComparisonOp_VideoLibDateIn);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.VideoLibTimeIn) == true)
{
string strComparisonOp_VideoLibTimeIn = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.VideoLibTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.VideoLibTimeIn, objvVideoLibQuantitySenate_Cond.VideoLibTimeIn, strComparisonOp_VideoLibTimeIn);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.OwnerId, objvVideoLibQuantitySenate_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.id_XzCollege, objvVideoLibQuantitySenate_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.CollegeID, objvVideoLibQuantitySenate_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.CollegeName, objvVideoLibQuantitySenate_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.CollegeNameA, objvVideoLibQuantitySenate_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.ViewCount, objvVideoLibQuantitySenate_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.DownloadNumber, objvVideoLibQuantitySenate_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.FileIntegration, objvVideoLibQuantitySenate_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.LikeCount, objvVideoLibQuantitySenate_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.CollectionCount, objvVideoLibQuantitySenate_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.CourseId) == true)
{
string strComparisonOp_CourseId = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.CourseId, objvVideoLibQuantitySenate_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.CourseCode, objvVideoLibQuantitySenate_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.CourseName) == true)
{
string strComparisonOp_CourseName = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.CourseName, objvVideoLibQuantitySenate_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.OwnerName, objvVideoLibQuantitySenate_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.OwnerNameWithId, objvVideoLibQuantitySenate_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.id_AppraiseType, objvVideoLibQuantitySenate_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.AppraiseTypeName, objvVideoLibQuantitySenate_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.SenateTheme) == true)
{
string strComparisonOp_SenateTheme = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.SenateTheme, objvVideoLibQuantitySenate_Cond.SenateTheme, strComparisonOp_SenateTheme);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.SenateContent) == true)
{
string strComparisonOp_SenateContent = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.SenateContent, objvVideoLibQuantitySenate_Cond.SenateContent, strComparisonOp_SenateContent);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOp_SenateTotalScore = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.SenateTotalScore, objvVideoLibQuantitySenate_Cond.SenateTotalScore, strComparisonOp_SenateTotalScore);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.SenateDate, objvVideoLibQuantitySenate_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.SenateTime) == true)
{
string strComparisonOp_SenateTime = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.SenateTime, objvVideoLibQuantitySenate_Cond.SenateTime, strComparisonOp_SenateTime);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.SenateIp) == true)
{
string strComparisonOp_SenateIp = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.SenateIp, objvVideoLibQuantitySenate_Cond.SenateIp, strComparisonOp_SenateIp);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.BrowseCount, objvVideoLibQuantitySenate_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.id_SenateGaugeVersion, objvVideoLibQuantitySenate_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.senateGaugeVersionID, objvVideoLibQuantitySenate_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.senateGaugeVersionName, objvVideoLibQuantitySenate_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenate.senateGaugeVersionTtlScore, objvVideoLibQuantitySenate_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.UserId) == true)
{
string strComparisonOp_UserId = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UserId, objvVideoLibQuantitySenate_Cond.UserId, strComparisonOp_UserId);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UserNameWithUserId, objvVideoLibQuantitySenate_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.UserName) == true)
{
string strComparisonOp_UserName = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UserName, objvVideoLibQuantitySenate_Cond.UserName, strComparisonOp_UserName);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UserKindId, objvVideoLibQuantitySenate_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UserKindName, objvVideoLibQuantitySenate_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UserTypeId, objvVideoLibQuantitySenate_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UserTypeName, objvVideoLibQuantitySenate_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UpdUser, objvVideoLibQuantitySenate_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.Memo) == true)
{
string strComparisonOp_Memo = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.Memo, objvVideoLibQuantitySenate_Cond.Memo, strComparisonOp_Memo);
}
if (objvVideoLibQuantitySenate_Cond.IsUpdated(convVideoLibQuantitySenate.UpdUserName) == true)
{
string strComparisonOp_UpdUserName = objvVideoLibQuantitySenate_Cond.dicFldComparisonOp[convVideoLibQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenate.UpdUserName, objvVideoLibQuantitySenate_Cond.UpdUserName, strComparisonOp_UpdUserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频库量化评议(vVideoLibQuantitySenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoLibQuantitySenateWApi
{
private static readonly string mstrApiControllerName = "vVideoLibQuantitySenateApi";

 public clsvVideoLibQuantitySenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibQuantitySenateEN GetObjByid_microteachCaseQuantitySenate(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = null;
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
objvVideoLibQuantitySenateEN = JsonConvert.DeserializeObject<clsvVideoLibQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLibQuantitySenateEN;
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
public static clsvVideoLibQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_WA_Cache(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = null;
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
objvVideoLibQuantitySenateEN = JsonConvert.DeserializeObject<clsvVideoLibQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLibQuantitySenateEN;
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
public static clsvVideoLibQuantitySenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = null;
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
objvVideoLibQuantitySenateEN = JsonConvert.DeserializeObject<clsvVideoLibQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLibQuantitySenateEN;
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
public static clsvVideoLibQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_Cache(long lngid_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateEN._CurrTabName_S);
List<clsvVideoLibQuantitySenateEN> arrvVideoLibQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLibQuantitySenateEN> arrvVideoLibQuantitySenateObjLst_Sel =
from objvVideoLibQuantitySenateEN in arrvVideoLibQuantitySenateObjLst_Cache
where objvVideoLibQuantitySenateEN.id_microteachCaseQuantitySenate == lngid_microteachCaseQuantitySenate
select objvVideoLibQuantitySenateEN;
if (arrvVideoLibQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvVideoLibQuantitySenateEN obj = clsvVideoLibQuantitySenateWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoLibQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibQuantitySenateEN> GetObjLst(string strWhereCond)
{
 List<clsvVideoLibQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvVideoLibQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvVideoLibQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateEN._CurrTabName_S);
List<clsvVideoLibQuantitySenateEN> arrvVideoLibQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLibQuantitySenateEN> arrvVideoLibQuantitySenateObjLst_Sel =
from objvVideoLibQuantitySenateEN in arrvVideoLibQuantitySenateObjLst_Cache
where arrId_microteachCaseQuantitySenate.Contains(objvVideoLibQuantitySenateEN.id_microteachCaseQuantitySenate)
select objvVideoLibQuantitySenateEN;
return arrvVideoLibQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvVideoLibQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoLibQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibQuantitySenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoLibQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoLibQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibQuantitySenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoLibQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvVideoLibQuantitySenateENS">源对象</param>
 /// <param name = "objvVideoLibQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateENS, clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateENT)
{
try
{
objvVideoLibQuantitySenateENT.id_microteachCaseQuantitySenate = objvVideoLibQuantitySenateENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvVideoLibQuantitySenateENT.FuncModuleId = objvVideoLibQuantitySenateENS.FuncModuleId; //功能模块Id
objvVideoLibQuantitySenateENT.FuncModuleName = objvVideoLibQuantitySenateENS.FuncModuleName; //功能模块名称
objvVideoLibQuantitySenateENT.id_MicroteachCase = objvVideoLibQuantitySenateENS.id_MicroteachCase; //微格教学案例流水号
objvVideoLibQuantitySenateENT.Id_VideoLib = objvVideoLibQuantitySenateENS.Id_VideoLib; //视频库流水号
objvVideoLibQuantitySenateENT.VideoLibID = objvVideoLibQuantitySenateENS.VideoLibID; //视频库ID
objvVideoLibQuantitySenateENT.VideoLibName = objvVideoLibQuantitySenateENS.VideoLibName; //视频名称
objvVideoLibQuantitySenateENT.VideoLibTheme = objvVideoLibQuantitySenateENS.VideoLibTheme; //视频库主题词
objvVideoLibQuantitySenateENT.VideoLibTypeName = objvVideoLibQuantitySenateENS.VideoLibTypeName; //视频库类型名称
objvVideoLibQuantitySenateENT.VideoLibDate = objvVideoLibQuantitySenateENS.VideoLibDate; //视频资源日期
objvVideoLibQuantitySenateENT.VideoLibTime = objvVideoLibQuantitySenateENS.VideoLibTime; //视频资源时间
objvVideoLibQuantitySenateENT.VideoLibDateIn = objvVideoLibQuantitySenateENS.VideoLibDateIn; //案例入库日期
objvVideoLibQuantitySenateENT.VideoLibTimeIn = objvVideoLibQuantitySenateENS.VideoLibTimeIn; //案例入库时间
objvVideoLibQuantitySenateENT.OwnerId = objvVideoLibQuantitySenateENS.OwnerId; //拥有者Id
objvVideoLibQuantitySenateENT.id_XzCollege = objvVideoLibQuantitySenateENS.id_XzCollege; //学院流水号
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
objvVideoLibQuantitySenateENT.id_AppraiseType = objvVideoLibQuantitySenateENS.id_AppraiseType; //评议类型流水号
objvVideoLibQuantitySenateENT.AppraiseTypeName = objvVideoLibQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvVideoLibQuantitySenateENT.SenateTheme = objvVideoLibQuantitySenateENS.SenateTheme; //量化评价主题
objvVideoLibQuantitySenateENT.SenateContent = objvVideoLibQuantitySenateENS.SenateContent; //评价内容
objvVideoLibQuantitySenateENT.SenateTotalScore = objvVideoLibQuantitySenateENS.SenateTotalScore; //评价分数
objvVideoLibQuantitySenateENT.SenateDate = objvVideoLibQuantitySenateENS.SenateDate; //评价日期
objvVideoLibQuantitySenateENT.SenateTime = objvVideoLibQuantitySenateENS.SenateTime; //评价时间
objvVideoLibQuantitySenateENT.SenateIp = objvVideoLibQuantitySenateENS.SenateIp; //评议Ip
objvVideoLibQuantitySenateENT.BrowseCount = objvVideoLibQuantitySenateENS.BrowseCount; //浏览次数
objvVideoLibQuantitySenateENT.id_SenateGaugeVersion = objvVideoLibQuantitySenateENS.id_SenateGaugeVersion; //评价量表版本流水号
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
public static DataTable ToDataTable(List<clsvVideoLibQuantitySenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoLibQuantitySenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoLibQuantitySenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoLibQuantitySenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoLibQuantitySenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoLibQuantitySenateEN.AttributeName)
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
if (clsCaseLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelWApi没有刷新缓存机制(clsCaseLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenate");
//if (arrvVideoLibQuantitySenateObjLst_Cache == null)
//{
//arrvVideoLibQuantitySenateObjLst_Cache = await clsvVideoLibQuantitySenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateEN._CurrTabName_S);
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
public static List<clsvVideoLibQuantitySenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateEN._CurrTabName_S);
List<clsvVideoLibQuantitySenateEN> arrvVideoLibQuantitySenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoLibQuantitySenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoLibQuantitySenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoLibQuantitySenate.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoLibQuantitySenate.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.Id_VideoLib, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.VideoLibID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.VideoLibName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.VideoLibTheme, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.VideoLibTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.VideoLibDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.VideoLibTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.VideoLibDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.VideoLibTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLibQuantitySenate.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLibQuantitySenate.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLibQuantitySenate.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoLibQuantitySenate.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoLibQuantitySenate.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.SenateTheme, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.SenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.SenateTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoLibQuantitySenate.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.SenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.SenateIp, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLibQuantitySenate.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoLibQuantitySenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenate.UpdUserName, Type.GetType("System.String"));
foreach (clsvVideoLibQuantitySenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoLibQuantitySenate.id_microteachCaseQuantitySenate] = objInFor[convVideoLibQuantitySenate.id_microteachCaseQuantitySenate];
objDR[convVideoLibQuantitySenate.FuncModuleId] = objInFor[convVideoLibQuantitySenate.FuncModuleId];
objDR[convVideoLibQuantitySenate.FuncModuleName] = objInFor[convVideoLibQuantitySenate.FuncModuleName];
objDR[convVideoLibQuantitySenate.id_MicroteachCase] = objInFor[convVideoLibQuantitySenate.id_MicroteachCase];
objDR[convVideoLibQuantitySenate.Id_VideoLib] = objInFor[convVideoLibQuantitySenate.Id_VideoLib];
objDR[convVideoLibQuantitySenate.VideoLibID] = objInFor[convVideoLibQuantitySenate.VideoLibID];
objDR[convVideoLibQuantitySenate.VideoLibName] = objInFor[convVideoLibQuantitySenate.VideoLibName];
objDR[convVideoLibQuantitySenate.VideoLibTheme] = objInFor[convVideoLibQuantitySenate.VideoLibTheme];
objDR[convVideoLibQuantitySenate.VideoLibTypeName] = objInFor[convVideoLibQuantitySenate.VideoLibTypeName];
objDR[convVideoLibQuantitySenate.VideoLibDate] = objInFor[convVideoLibQuantitySenate.VideoLibDate];
objDR[convVideoLibQuantitySenate.VideoLibTime] = objInFor[convVideoLibQuantitySenate.VideoLibTime];
objDR[convVideoLibQuantitySenate.VideoLibDateIn] = objInFor[convVideoLibQuantitySenate.VideoLibDateIn];
objDR[convVideoLibQuantitySenate.VideoLibTimeIn] = objInFor[convVideoLibQuantitySenate.VideoLibTimeIn];
objDR[convVideoLibQuantitySenate.OwnerId] = objInFor[convVideoLibQuantitySenate.OwnerId];
objDR[convVideoLibQuantitySenate.id_XzCollege] = objInFor[convVideoLibQuantitySenate.id_XzCollege];
objDR[convVideoLibQuantitySenate.CollegeID] = objInFor[convVideoLibQuantitySenate.CollegeID];
objDR[convVideoLibQuantitySenate.CollegeName] = objInFor[convVideoLibQuantitySenate.CollegeName];
objDR[convVideoLibQuantitySenate.CollegeNameA] = objInFor[convVideoLibQuantitySenate.CollegeNameA];
objDR[convVideoLibQuantitySenate.ViewCount] = objInFor[convVideoLibQuantitySenate.ViewCount];
objDR[convVideoLibQuantitySenate.DownloadNumber] = objInFor[convVideoLibQuantitySenate.DownloadNumber];
objDR[convVideoLibQuantitySenate.FileIntegration] = objInFor[convVideoLibQuantitySenate.FileIntegration];
objDR[convVideoLibQuantitySenate.LikeCount] = objInFor[convVideoLibQuantitySenate.LikeCount];
objDR[convVideoLibQuantitySenate.CollectionCount] = objInFor[convVideoLibQuantitySenate.CollectionCount];
objDR[convVideoLibQuantitySenate.CourseId] = objInFor[convVideoLibQuantitySenate.CourseId];
objDR[convVideoLibQuantitySenate.CourseCode] = objInFor[convVideoLibQuantitySenate.CourseCode];
objDR[convVideoLibQuantitySenate.CourseName] = objInFor[convVideoLibQuantitySenate.CourseName];
objDR[convVideoLibQuantitySenate.OwnerName] = objInFor[convVideoLibQuantitySenate.OwnerName];
objDR[convVideoLibQuantitySenate.OwnerNameWithId] = objInFor[convVideoLibQuantitySenate.OwnerNameWithId];
objDR[convVideoLibQuantitySenate.id_AppraiseType] = objInFor[convVideoLibQuantitySenate.id_AppraiseType];
objDR[convVideoLibQuantitySenate.AppraiseTypeName] = objInFor[convVideoLibQuantitySenate.AppraiseTypeName];
objDR[convVideoLibQuantitySenate.SenateTheme] = objInFor[convVideoLibQuantitySenate.SenateTheme];
objDR[convVideoLibQuantitySenate.SenateContent] = objInFor[convVideoLibQuantitySenate.SenateContent];
objDR[convVideoLibQuantitySenate.SenateTotalScore] = objInFor[convVideoLibQuantitySenate.SenateTotalScore];
objDR[convVideoLibQuantitySenate.SenateDate] = objInFor[convVideoLibQuantitySenate.SenateDate];
objDR[convVideoLibQuantitySenate.SenateTime] = objInFor[convVideoLibQuantitySenate.SenateTime];
objDR[convVideoLibQuantitySenate.SenateIp] = objInFor[convVideoLibQuantitySenate.SenateIp];
objDR[convVideoLibQuantitySenate.BrowseCount] = objInFor[convVideoLibQuantitySenate.BrowseCount];
objDR[convVideoLibQuantitySenate.id_SenateGaugeVersion] = objInFor[convVideoLibQuantitySenate.id_SenateGaugeVersion];
objDR[convVideoLibQuantitySenate.senateGaugeVersionID] = objInFor[convVideoLibQuantitySenate.senateGaugeVersionID];
objDR[convVideoLibQuantitySenate.senateGaugeVersionName] = objInFor[convVideoLibQuantitySenate.senateGaugeVersionName];
objDR[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] = objInFor[convVideoLibQuantitySenate.senateGaugeVersionTtlScore];
objDR[convVideoLibQuantitySenate.UserId] = objInFor[convVideoLibQuantitySenate.UserId];
objDR[convVideoLibQuantitySenate.UserNameWithUserId] = objInFor[convVideoLibQuantitySenate.UserNameWithUserId];
objDR[convVideoLibQuantitySenate.UserName] = objInFor[convVideoLibQuantitySenate.UserName];
objDR[convVideoLibQuantitySenate.UserKindId] = objInFor[convVideoLibQuantitySenate.UserKindId];
objDR[convVideoLibQuantitySenate.UserKindName] = objInFor[convVideoLibQuantitySenate.UserKindName];
objDR[convVideoLibQuantitySenate.UserTypeId] = objInFor[convVideoLibQuantitySenate.UserTypeId];
objDR[convVideoLibQuantitySenate.UserTypeName] = objInFor[convVideoLibQuantitySenate.UserTypeName];
objDR[convVideoLibQuantitySenate.UpdUser] = objInFor[convVideoLibQuantitySenate.UpdUser];
objDR[convVideoLibQuantitySenate.Memo] = objInFor[convVideoLibQuantitySenate.Memo];
objDR[convVideoLibQuantitySenate.UpdUserName] = objInFor[convVideoLibQuantitySenate.UpdUserName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}