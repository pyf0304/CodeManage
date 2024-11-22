
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLib_BaseWApi
 表名:vVideoLib_Base(01120329)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:14
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
public static class clsvVideoLib_BaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetId_VideoLib(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strId_VideoLib, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_VideoLib, 8, convVideoLib_Base.Id_VideoLib);
clsCheckSql.CheckFieldForeignKey(strId_VideoLib, 8, convVideoLib_Base.Id_VideoLib);
objvVideoLib_BaseEN.Id_VideoLib = strId_VideoLib; //视频库流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.Id_VideoLib) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.Id_VideoLib, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.Id_VideoLib] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibID(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoLibID, convVideoLib_Base.VideoLibID);
clsCheckSql.CheckFieldLen(strVideoLibID, 8, convVideoLib_Base.VideoLibID);
clsCheckSql.CheckFieldForeignKey(strVideoLibID, 8, convVideoLib_Base.VideoLibID);
objvVideoLib_BaseEN.VideoLibID = strVideoLibID; //视频库ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibID) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibID, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibID] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoLibName, convVideoLib_Base.VideoLibName);
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoLib_Base.VideoLibName);
objvVideoLib_BaseEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibTheme(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTheme, 200, convVideoLib_Base.VideoLibTheme);
objvVideoLib_BaseEN.VideoLibTheme = strVideoLibTheme; //视频库主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibTheme) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibTheme, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibTheme] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN Setid_VideoLibType(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strid_VideoLibType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_VideoLibType, convVideoLib_Base.id_VideoLibType);
clsCheckSql.CheckFieldLen(strid_VideoLibType, 4, convVideoLib_Base.id_VideoLibType);
clsCheckSql.CheckFieldForeignKey(strid_VideoLibType, 4, convVideoLib_Base.id_VideoLibType);
objvVideoLib_BaseEN.id_VideoLibType = strid_VideoLibType; //视频库类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.id_VideoLibType) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.id_VideoLibType, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.id_VideoLibType] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibTypeName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTypeName, 30, convVideoLib_Base.VideoLibTypeName);
objvVideoLib_BaseEN.VideoLibTypeName = strVideoLibTypeName; //视频库类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibTypeName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibTypeName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibTypeName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibText(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibText, 8000, convVideoLib_Base.VideoLibText);
objvVideoLib_BaseEN.VideoLibText = strVideoLibText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibText) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibText, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibText] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibDate(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibDate, 20, convVideoLib_Base.VideoLibDate);
objvVideoLib_BaseEN.VideoLibDate = strVideoLibDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibDate) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibDate, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibDate] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibTime(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTime, 6, convVideoLib_Base.VideoLibTime);
clsCheckSql.CheckFieldForeignKey(strVideoLibTime, 6, convVideoLib_Base.VideoLibTime);
objvVideoLib_BaseEN.VideoLibTime = strVideoLibTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibTime) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibTime, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibTime] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibDateIn(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibDateIn, 8, convVideoLib_Base.VideoLibDateIn);
clsCheckSql.CheckFieldForeignKey(strVideoLibDateIn, 8, convVideoLib_Base.VideoLibDateIn);
objvVideoLib_BaseEN.VideoLibDateIn = strVideoLibDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibDateIn) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibDateIn, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibDateIn] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibTimeIn(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTimeIn, 6, convVideoLib_Base.VideoLibTimeIn);
clsCheckSql.CheckFieldForeignKey(strVideoLibTimeIn, 6, convVideoLib_Base.VideoLibTimeIn);
objvVideoLib_BaseEN.VideoLibTimeIn = strVideoLibTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibTimeIn) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibTimeIn, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibTimeIn] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetOwnerId(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convVideoLib_Base.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convVideoLib_Base.OwnerId);
objvVideoLib_BaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.OwnerId) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.OwnerId, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.OwnerId] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN Setid_TeachingPlan(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convVideoLib_Base.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convVideoLib_Base.id_TeachingPlan);
objvVideoLib_BaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.id_TeachingPlan) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.id_TeachingPlan, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.id_TeachingPlan] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN Setid_SenateGaugeVersion(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convVideoLib_Base.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convVideoLib_Base.id_SenateGaugeVersion);
objvVideoLib_BaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.id_SenateGaugeVersion) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetsenateGaugeVersionID(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convVideoLib_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convVideoLib_Base.senateGaugeVersionID);
objvVideoLib_BaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.senateGaugeVersionID) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.senateGaugeVersionID, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.senateGaugeVersionID] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetsenateGaugeVersionName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convVideoLib_Base.senateGaugeVersionName);
objvVideoLib_BaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.senateGaugeVersionName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.senateGaugeVersionName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.senateGaugeVersionName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetsenateGaugeVersionTtlScore(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.senateGaugeVersionTtlScore) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVersionNo(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, int intVersionNo, string strComparisonOp="")
	{
objvVideoLib_BaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VersionNo) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VersionNo, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VersionNo] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCaseLevelId(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convVideoLib_Base.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convVideoLib_Base.CaseLevelId);
objvVideoLib_BaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CaseLevelId) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CaseLevelId, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CaseLevelId] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCaseLevelName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convVideoLib_Base.CaseLevelName);
objvVideoLib_BaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CaseLevelName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CaseLevelName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CaseLevelName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetIsVisible(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvVideoLib_BaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.IsVisible) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.IsVisible, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.IsVisible] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN Setid_XzCollege(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, convVideoLib_Base.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convVideoLib_Base.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convVideoLib_Base.id_XzCollege);
objvVideoLib_BaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.id_XzCollege) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.id_XzCollege, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.id_XzCollege] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCollegeID(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoLib_Base.CollegeID);
objvVideoLib_BaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CollegeID) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CollegeID, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CollegeID] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCollegeName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoLib_Base.CollegeName);
objvVideoLib_BaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CollegeName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CollegeName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CollegeName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCollegeNameA(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoLib_Base.CollegeNameA);
objvVideoLib_BaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CollegeNameA) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CollegeNameA, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CollegeNameA] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetViewCount(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, int intViewCount, string strComparisonOp="")
	{
objvVideoLib_BaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.ViewCount) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.ViewCount, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.ViewCount] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetDownloadNumber(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, int intDownloadNumber, string strComparisonOp="")
	{
objvVideoLib_BaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.DownloadNumber) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.DownloadNumber, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.DownloadNumber] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetFileIntegration(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, int intFileIntegration, string strComparisonOp="")
	{
objvVideoLib_BaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.FileIntegration) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.FileIntegration, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.FileIntegration] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetLikeCount(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, long lngLikeCount, string strComparisonOp="")
	{
objvVideoLib_BaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.LikeCount) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.LikeCount, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.LikeCount] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCollectionCount(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, long lngCollectionCount, string strComparisonOp="")
	{
objvVideoLib_BaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CollectionCount) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CollectionCount, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CollectionCount] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetRecommendedDegreeId(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convVideoLib_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convVideoLib_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convVideoLib_Base.RecommendedDegreeId);
objvVideoLib_BaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.RecommendedDegreeId) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.RecommendedDegreeId, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.RecommendedDegreeId] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetRecommendedDegreeName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convVideoLib_Base.RecommendedDegreeName);
objvVideoLib_BaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.RecommendedDegreeName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.RecommendedDegreeName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.RecommendedDegreeName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCourseId(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convVideoLib_Base.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoLib_Base.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoLib_Base.CourseId);
objvVideoLib_BaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CourseId) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CourseId, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CourseId] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCourseCode(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoLib_Base.CourseCode);
objvVideoLib_BaseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CourseCode) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CourseCode, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CourseCode] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCourseName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoLib_Base.CourseName);
objvVideoLib_BaseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CourseName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CourseName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CourseName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoUrl(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convVideoLib_Base.VideoUrl);
objvVideoLib_BaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoUrl) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoUrl, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoUrl] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoPath(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convVideoLib_Base.VideoPath);
objvVideoLib_BaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoPath) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoPath, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoPath] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCoverPicUrl(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCoverPicUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoverPicUrl, 1000, convVideoLib_Base.CoverPicUrl);
objvVideoLib_BaseEN.CoverPicUrl = strCoverPicUrl; //封面Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CoverPicUrl) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CoverPicUrl, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CoverPicUrl] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCoverPicShortUrl(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCoverPicShortUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoverPicShortUrl, 1000, convVideoLib_Base.CoverPicShortUrl);
objvVideoLib_BaseEN.CoverPicShortUrl = strCoverPicShortUrl; //封面短Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CoverPicShortUrl) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CoverPicShortUrl, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CoverPicShortUrl] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetResErrMsg(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convVideoLib_Base.ResErrMsg);
objvVideoLib_BaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.ResErrMsg) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.ResErrMsg, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.ResErrMsg] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetMemo(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoLib_Base.Memo);
objvVideoLib_BaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.Memo) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.Memo, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.Memo] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetBrowseCount4Case(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvVideoLib_BaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.BrowseCount4Case) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.BrowseCount4Case, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.BrowseCount4Case] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetOwnerName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convVideoLib_Base.OwnerName);
objvVideoLib_BaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.OwnerName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.OwnerName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.OwnerName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLib_BaseEN SetOwnerNameWithId(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convVideoLib_Base.OwnerNameWithId);
objvVideoLib_BaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.OwnerNameWithId) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.OwnerNameWithId, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.OwnerNameWithId] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoLib_BaseEN objvVideoLib_Base_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.Id_VideoLib) == true)
{
string strComparisonOp_Id_VideoLib = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.Id_VideoLib];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.Id_VideoLib, objvVideoLib_Base_Cond.Id_VideoLib, strComparisonOp_Id_VideoLib);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.VideoLibID) == true)
{
string strComparisonOp_VideoLibID = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.VideoLibID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibID, objvVideoLib_Base_Cond.VideoLibID, strComparisonOp_VideoLibID);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.VideoLibName) == true)
{
string strComparisonOp_VideoLibName = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibName, objvVideoLib_Base_Cond.VideoLibName, strComparisonOp_VideoLibName);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.VideoLibTheme) == true)
{
string strComparisonOp_VideoLibTheme = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.VideoLibTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibTheme, objvVideoLib_Base_Cond.VideoLibTheme, strComparisonOp_VideoLibTheme);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.id_VideoLibType) == true)
{
string strComparisonOp_id_VideoLibType = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.id_VideoLibType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.id_VideoLibType, objvVideoLib_Base_Cond.id_VideoLibType, strComparisonOp_id_VideoLibType);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.VideoLibTypeName) == true)
{
string strComparisonOp_VideoLibTypeName = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.VideoLibTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibTypeName, objvVideoLib_Base_Cond.VideoLibTypeName, strComparisonOp_VideoLibTypeName);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.VideoLibText) == true)
{
string strComparisonOp_VideoLibText = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.VideoLibText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibText, objvVideoLib_Base_Cond.VideoLibText, strComparisonOp_VideoLibText);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.VideoLibDate) == true)
{
string strComparisonOp_VideoLibDate = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.VideoLibDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibDate, objvVideoLib_Base_Cond.VideoLibDate, strComparisonOp_VideoLibDate);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.VideoLibTime) == true)
{
string strComparisonOp_VideoLibTime = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.VideoLibTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibTime, objvVideoLib_Base_Cond.VideoLibTime, strComparisonOp_VideoLibTime);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.VideoLibDateIn) == true)
{
string strComparisonOp_VideoLibDateIn = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.VideoLibDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibDateIn, objvVideoLib_Base_Cond.VideoLibDateIn, strComparisonOp_VideoLibDateIn);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.VideoLibTimeIn) == true)
{
string strComparisonOp_VideoLibTimeIn = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.VideoLibTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibTimeIn, objvVideoLib_Base_Cond.VideoLibTimeIn, strComparisonOp_VideoLibTimeIn);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.OwnerId, objvVideoLib_Base_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.id_TeachingPlan, objvVideoLib_Base_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.id_SenateGaugeVersion, objvVideoLib_Base_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.senateGaugeVersionID, objvVideoLib_Base_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.senateGaugeVersionName, objvVideoLib_Base_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.senateGaugeVersionTtlScore, objvVideoLib_Base_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.VersionNo, objvVideoLib_Base_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CaseLevelId, objvVideoLib_Base_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CaseLevelName, objvVideoLib_Base_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.IsVisible) == true)
{
if (objvVideoLib_Base_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLib_Base.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLib_Base.IsVisible);
}
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.id_XzCollege, objvVideoLib_Base_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CollegeID, objvVideoLib_Base_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CollegeName, objvVideoLib_Base_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CollegeNameA, objvVideoLib_Base_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.ViewCount, objvVideoLib_Base_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.DownloadNumber, objvVideoLib_Base_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.FileIntegration, objvVideoLib_Base_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.LikeCount, objvVideoLib_Base_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.CollectionCount, objvVideoLib_Base_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.RecommendedDegreeId, objvVideoLib_Base_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.RecommendedDegreeName, objvVideoLib_Base_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.CourseId) == true)
{
string strComparisonOp_CourseId = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CourseId, objvVideoLib_Base_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CourseCode, objvVideoLib_Base_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.CourseName) == true)
{
string strComparisonOp_CourseName = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CourseName, objvVideoLib_Base_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoUrl, objvVideoLib_Base_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoPath, objvVideoLib_Base_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.CoverPicUrl) == true)
{
string strComparisonOp_CoverPicUrl = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.CoverPicUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CoverPicUrl, objvVideoLib_Base_Cond.CoverPicUrl, strComparisonOp_CoverPicUrl);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.CoverPicShortUrl) == true)
{
string strComparisonOp_CoverPicShortUrl = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.CoverPicShortUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CoverPicShortUrl, objvVideoLib_Base_Cond.CoverPicShortUrl, strComparisonOp_CoverPicShortUrl);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.ResErrMsg, objvVideoLib_Base_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.Memo) == true)
{
string strComparisonOp_Memo = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.Memo, objvVideoLib_Base_Cond.Memo, strComparisonOp_Memo);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.BrowseCount4Case, objvVideoLib_Base_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.OwnerName, objvVideoLib_Base_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvVideoLib_Base_Cond.IsUpdated(convVideoLib_Base.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvVideoLib_Base_Cond.dicFldComparisonOp[convVideoLib_Base.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.OwnerNameWithId, objvVideoLib_Base_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频库_Base(vVideoLib_Base)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoLib_BaseWApi
{
private static readonly string mstrApiControllerName = "vVideoLib_BaseApi";

 public clsvVideoLib_BaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_VideoLib">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLib_BaseEN GetObjById_VideoLib(string strId_VideoLib)
{
string strAction = "GetObjById_VideoLib";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLib_BaseEN objvVideoLib_BaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_VideoLib"] = strId_VideoLib
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvVideoLib_BaseEN = JsonConvert.DeserializeObject<clsvVideoLib_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLib_BaseEN;
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
 /// <param name = "strId_VideoLib">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLib_BaseEN GetObjById_VideoLib_WA_Cache(string strId_VideoLib)
{
string strAction = "GetObjById_VideoLib_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLib_BaseEN objvVideoLib_BaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_VideoLib"] = strId_VideoLib
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvVideoLib_BaseEN = JsonConvert.DeserializeObject<clsvVideoLib_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLib_BaseEN;
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
public static string GetFirstID(string strWhereCond)
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
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
public static clsvVideoLib_BaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLib_BaseEN objvVideoLib_BaseEN = null;
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
objvVideoLib_BaseEN = JsonConvert.DeserializeObject<clsvVideoLib_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLib_BaseEN;
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
 /// <param name = "strId_VideoLib">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLib_BaseEN GetObjById_VideoLib_Cache(string strId_VideoLib)
{
if (string.IsNullOrEmpty(strId_VideoLib) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLib_BaseEN._CurrTabName_S);
List<clsvVideoLib_BaseEN> arrvVideoLib_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLib_BaseEN> arrvVideoLib_BaseObjLst_Sel =
from objvVideoLib_BaseEN in arrvVideoLib_BaseObjLst_Cache
where objvVideoLib_BaseEN.Id_VideoLib == strId_VideoLib
select objvVideoLib_BaseEN;
if (arrvVideoLib_BaseObjLst_Sel.Count() == 0)
{
   clsvVideoLib_BaseEN obj = clsvVideoLib_BaseWApi.GetObjById_VideoLib(strId_VideoLib);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoLib_BaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLib_BaseEN> GetObjLst(string strWhereCond)
{
 List<clsvVideoLib_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLib_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLib_BaseEN> GetObjLstById_VideoLibLst(List<string> arrId_VideoLib)
{
 List<clsvVideoLib_BaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_VideoLibLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_VideoLib);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLib_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_VideoLib">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvVideoLib_BaseEN> GetObjLstById_VideoLibLst_Cache(List<string> arrId_VideoLib)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLib_BaseEN._CurrTabName_S);
List<clsvVideoLib_BaseEN> arrvVideoLib_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLib_BaseEN> arrvVideoLib_BaseObjLst_Sel =
from objvVideoLib_BaseEN in arrvVideoLib_BaseObjLst_Cache
where arrId_VideoLib.Contains(objvVideoLib_BaseEN.Id_VideoLib)
select objvVideoLib_BaseEN;
return arrvVideoLib_BaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLib_BaseEN> GetObjLstById_VideoLibLst_WA_Cache(List<string> arrId_VideoLib)
{
 List<clsvVideoLib_BaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_VideoLibLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_VideoLib);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLib_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLib_BaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoLib_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLib_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLib_BaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoLib_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLib_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLib_BaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoLib_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLib_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLib_BaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoLib_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLib_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strId_VideoLib)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_VideoLib"] = strId_VideoLib
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
 /// <param name = "objvVideoLib_BaseENS">源对象</param>
 /// <param name = "objvVideoLib_BaseENT">目标对象</param>
 public static void CopyTo(clsvVideoLib_BaseEN objvVideoLib_BaseENS, clsvVideoLib_BaseEN objvVideoLib_BaseENT)
{
try
{
objvVideoLib_BaseENT.Id_VideoLib = objvVideoLib_BaseENS.Id_VideoLib; //视频库流水号
objvVideoLib_BaseENT.VideoLibID = objvVideoLib_BaseENS.VideoLibID; //视频库ID
objvVideoLib_BaseENT.VideoLibName = objvVideoLib_BaseENS.VideoLibName; //视频名称
objvVideoLib_BaseENT.VideoLibTheme = objvVideoLib_BaseENS.VideoLibTheme; //视频库主题词
objvVideoLib_BaseENT.id_VideoLibType = objvVideoLib_BaseENS.id_VideoLibType; //视频库类型流水号
objvVideoLib_BaseENT.VideoLibTypeName = objvVideoLib_BaseENS.VideoLibTypeName; //视频库类型名称
objvVideoLib_BaseENT.VideoLibText = objvVideoLib_BaseENS.VideoLibText; //案例文本内容
objvVideoLib_BaseENT.VideoLibDate = objvVideoLib_BaseENS.VideoLibDate; //视频资源日期
objvVideoLib_BaseENT.VideoLibTime = objvVideoLib_BaseENS.VideoLibTime; //视频资源时间
objvVideoLib_BaseENT.VideoLibDateIn = objvVideoLib_BaseENS.VideoLibDateIn; //案例入库日期
objvVideoLib_BaseENT.VideoLibTimeIn = objvVideoLib_BaseENS.VideoLibTimeIn; //案例入库时间
objvVideoLib_BaseENT.OwnerId = objvVideoLib_BaseENS.OwnerId; //拥有者Id
objvVideoLib_BaseENT.id_TeachingPlan = objvVideoLib_BaseENS.id_TeachingPlan; //教案流水号
objvVideoLib_BaseENT.id_SenateGaugeVersion = objvVideoLib_BaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvVideoLib_BaseENT.senateGaugeVersionID = objvVideoLib_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvVideoLib_BaseENT.senateGaugeVersionName = objvVideoLib_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLib_BaseENT.senateGaugeVersionTtlScore = objvVideoLib_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoLib_BaseENT.VersionNo = objvVideoLib_BaseENS.VersionNo; //版本号
objvVideoLib_BaseENT.CaseLevelId = objvVideoLib_BaseENS.CaseLevelId; //课例等级Id
objvVideoLib_BaseENT.CaseLevelName = objvVideoLib_BaseENS.CaseLevelName; //案例等级名称
objvVideoLib_BaseENT.IsVisible = objvVideoLib_BaseENS.IsVisible; //是否显示
objvVideoLib_BaseENT.id_XzCollege = objvVideoLib_BaseENS.id_XzCollege; //学院流水号
objvVideoLib_BaseENT.CollegeID = objvVideoLib_BaseENS.CollegeID; //学院ID
objvVideoLib_BaseENT.CollegeName = objvVideoLib_BaseENS.CollegeName; //学院名称
objvVideoLib_BaseENT.CollegeNameA = objvVideoLib_BaseENS.CollegeNameA; //学院名称简写
objvVideoLib_BaseENT.ViewCount = objvVideoLib_BaseENS.ViewCount; //浏览量
objvVideoLib_BaseENT.DownloadNumber = objvVideoLib_BaseENS.DownloadNumber; //下载数目
objvVideoLib_BaseENT.FileIntegration = objvVideoLib_BaseENS.FileIntegration; //文件积分
objvVideoLib_BaseENT.LikeCount = objvVideoLib_BaseENS.LikeCount; //资源喜欢数量
objvVideoLib_BaseENT.CollectionCount = objvVideoLib_BaseENS.CollectionCount; //收藏数量
objvVideoLib_BaseENT.RecommendedDegreeId = objvVideoLib_BaseENS.RecommendedDegreeId; //推荐度Id
objvVideoLib_BaseENT.RecommendedDegreeName = objvVideoLib_BaseENS.RecommendedDegreeName; //推荐度名称
objvVideoLib_BaseENT.CourseId = objvVideoLib_BaseENS.CourseId; //课程Id
objvVideoLib_BaseENT.CourseCode = objvVideoLib_BaseENS.CourseCode; //课程代码
objvVideoLib_BaseENT.CourseName = objvVideoLib_BaseENS.CourseName; //课程名称
objvVideoLib_BaseENT.VideoUrl = objvVideoLib_BaseENS.VideoUrl; //视频Url
objvVideoLib_BaseENT.VideoPath = objvVideoLib_BaseENS.VideoPath; //视频目录
objvVideoLib_BaseENT.CoverPicUrl = objvVideoLib_BaseENS.CoverPicUrl; //封面Url
objvVideoLib_BaseENT.CoverPicShortUrl = objvVideoLib_BaseENS.CoverPicShortUrl; //封面短Url
objvVideoLib_BaseENT.ResErrMsg = objvVideoLib_BaseENS.ResErrMsg; //资源错误信息
objvVideoLib_BaseENT.Memo = objvVideoLib_BaseENS.Memo; //备注
objvVideoLib_BaseENT.BrowseCount4Case = objvVideoLib_BaseENS.BrowseCount4Case; //课例浏览次数
objvVideoLib_BaseENT.OwnerName = objvVideoLib_BaseENS.OwnerName; //拥有者姓名
objvVideoLib_BaseENT.OwnerNameWithId = objvVideoLib_BaseENS.OwnerNameWithId; //拥有者名称附Id
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
public static DataTable ToDataTable(List<clsvVideoLib_BaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoLib_BaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoLib_BaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoLib_BaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoLib_BaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoLib_BaseEN.AttributeName)
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
//string strWhereCond = string.Format("1 = 1 order by Id_VideoLib");
//if (arrvVideoLib_BaseObjLst_Cache == null)
//{
//arrvVideoLib_BaseObjLst_Cache = await clsvVideoLib_BaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoLib_BaseEN._CurrTabName_S);
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
public static List<clsvVideoLib_BaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoLib_BaseEN._CurrTabName_S);
List<clsvVideoLib_BaseEN> arrvVideoLib_BaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoLib_BaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoLib_BaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoLib_Base.Id_VideoLib, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.VideoLibID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.VideoLibName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.VideoLibTheme, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.id_VideoLibType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.VideoLibTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.VideoLibText, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.VideoLibDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.VideoLibTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.VideoLibDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.VideoLibTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoLib_Base.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib_Base.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoLib_Base.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib_Base.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib_Base.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib_Base.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoLib_Base.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoLib_Base.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.CoverPicUrl, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.CoverPicShortUrl, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib_Base.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib_Base.OwnerNameWithId, Type.GetType("System.String"));
foreach (clsvVideoLib_BaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoLib_Base.Id_VideoLib] = objInFor[convVideoLib_Base.Id_VideoLib];
objDR[convVideoLib_Base.VideoLibID] = objInFor[convVideoLib_Base.VideoLibID];
objDR[convVideoLib_Base.VideoLibName] = objInFor[convVideoLib_Base.VideoLibName];
objDR[convVideoLib_Base.VideoLibTheme] = objInFor[convVideoLib_Base.VideoLibTheme];
objDR[convVideoLib_Base.id_VideoLibType] = objInFor[convVideoLib_Base.id_VideoLibType];
objDR[convVideoLib_Base.VideoLibTypeName] = objInFor[convVideoLib_Base.VideoLibTypeName];
objDR[convVideoLib_Base.VideoLibText] = objInFor[convVideoLib_Base.VideoLibText];
objDR[convVideoLib_Base.VideoLibDate] = objInFor[convVideoLib_Base.VideoLibDate];
objDR[convVideoLib_Base.VideoLibTime] = objInFor[convVideoLib_Base.VideoLibTime];
objDR[convVideoLib_Base.VideoLibDateIn] = objInFor[convVideoLib_Base.VideoLibDateIn];
objDR[convVideoLib_Base.VideoLibTimeIn] = objInFor[convVideoLib_Base.VideoLibTimeIn];
objDR[convVideoLib_Base.OwnerId] = objInFor[convVideoLib_Base.OwnerId];
objDR[convVideoLib_Base.id_TeachingPlan] = objInFor[convVideoLib_Base.id_TeachingPlan];
objDR[convVideoLib_Base.id_SenateGaugeVersion] = objInFor[convVideoLib_Base.id_SenateGaugeVersion];
objDR[convVideoLib_Base.senateGaugeVersionID] = objInFor[convVideoLib_Base.senateGaugeVersionID];
objDR[convVideoLib_Base.senateGaugeVersionName] = objInFor[convVideoLib_Base.senateGaugeVersionName];
objDR[convVideoLib_Base.senateGaugeVersionTtlScore] = objInFor[convVideoLib_Base.senateGaugeVersionTtlScore];
objDR[convVideoLib_Base.VersionNo] = objInFor[convVideoLib_Base.VersionNo];
objDR[convVideoLib_Base.CaseLevelId] = objInFor[convVideoLib_Base.CaseLevelId];
objDR[convVideoLib_Base.CaseLevelName] = objInFor[convVideoLib_Base.CaseLevelName];
objDR[convVideoLib_Base.IsVisible] = objInFor[convVideoLib_Base.IsVisible];
objDR[convVideoLib_Base.id_XzCollege] = objInFor[convVideoLib_Base.id_XzCollege];
objDR[convVideoLib_Base.CollegeID] = objInFor[convVideoLib_Base.CollegeID];
objDR[convVideoLib_Base.CollegeName] = objInFor[convVideoLib_Base.CollegeName];
objDR[convVideoLib_Base.CollegeNameA] = objInFor[convVideoLib_Base.CollegeNameA];
objDR[convVideoLib_Base.ViewCount] = objInFor[convVideoLib_Base.ViewCount];
objDR[convVideoLib_Base.DownloadNumber] = objInFor[convVideoLib_Base.DownloadNumber];
objDR[convVideoLib_Base.FileIntegration] = objInFor[convVideoLib_Base.FileIntegration];
objDR[convVideoLib_Base.LikeCount] = objInFor[convVideoLib_Base.LikeCount];
objDR[convVideoLib_Base.CollectionCount] = objInFor[convVideoLib_Base.CollectionCount];
objDR[convVideoLib_Base.RecommendedDegreeId] = objInFor[convVideoLib_Base.RecommendedDegreeId];
objDR[convVideoLib_Base.RecommendedDegreeName] = objInFor[convVideoLib_Base.RecommendedDegreeName];
objDR[convVideoLib_Base.CourseId] = objInFor[convVideoLib_Base.CourseId];
objDR[convVideoLib_Base.CourseCode] = objInFor[convVideoLib_Base.CourseCode];
objDR[convVideoLib_Base.CourseName] = objInFor[convVideoLib_Base.CourseName];
objDR[convVideoLib_Base.VideoUrl] = objInFor[convVideoLib_Base.VideoUrl];
objDR[convVideoLib_Base.VideoPath] = objInFor[convVideoLib_Base.VideoPath];
objDR[convVideoLib_Base.CoverPicUrl] = objInFor[convVideoLib_Base.CoverPicUrl];
objDR[convVideoLib_Base.CoverPicShortUrl] = objInFor[convVideoLib_Base.CoverPicShortUrl];
objDR[convVideoLib_Base.ResErrMsg] = objInFor[convVideoLib_Base.ResErrMsg];
objDR[convVideoLib_Base.Memo] = objInFor[convVideoLib_Base.Memo];
objDR[convVideoLib_Base.BrowseCount4Case] = objInFor[convVideoLib_Base.BrowseCount4Case];
objDR[convVideoLib_Base.OwnerName] = objInFor[convVideoLib_Base.OwnerName];
objDR[convVideoLib_Base.OwnerNameWithId] = objInFor[convVideoLib_Base.OwnerNameWithId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}