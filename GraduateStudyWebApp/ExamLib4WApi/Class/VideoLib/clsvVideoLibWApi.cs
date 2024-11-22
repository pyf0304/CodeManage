
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibWApi
 表名:vVideoLib(01120262)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:49
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
public static class clsvVideoLibWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetId_VideoLib(this clsvVideoLibEN objvVideoLibEN, string strId_VideoLib, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_VideoLib, 8, convVideoLib.Id_VideoLib);
clsCheckSql.CheckFieldForeignKey(strId_VideoLib, 8, convVideoLib.Id_VideoLib);
objvVideoLibEN.Id_VideoLib = strId_VideoLib; //视频库流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.Id_VideoLib) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.Id_VideoLib, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.Id_VideoLib] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetAppraiseCount(this clsvVideoLibEN objvVideoLibEN, int intAppraiseCount, string strComparisonOp="")
	{
objvVideoLibEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.AppraiseCount) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.AppraiseCount, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.AppraiseCount] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetLikeNum(this clsvVideoLibEN objvVideoLibEN, int intLikeNum, string strComparisonOp="")
	{
objvVideoLibEN.LikeNum = intLikeNum; //点赞数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.LikeNum) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.LikeNum, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.LikeNum] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetPlayNum(this clsvVideoLibEN objvVideoLibEN, int intPlayNum, string strComparisonOp="")
	{
objvVideoLibEN.PlayNum = intPlayNum; //播放数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.PlayNum) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.PlayNum, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.PlayNum] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibID(this clsvVideoLibEN objvVideoLibEN, string strVideoLibID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoLibID, convVideoLib.VideoLibID);
clsCheckSql.CheckFieldLen(strVideoLibID, 8, convVideoLib.VideoLibID);
clsCheckSql.CheckFieldForeignKey(strVideoLibID, 8, convVideoLib.VideoLibID);
objvVideoLibEN.VideoLibID = strVideoLibID; //视频库ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibID) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibID, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibID] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibName(this clsvVideoLibEN objvVideoLibEN, string strVideoLibName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoLibName, convVideoLib.VideoLibName);
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoLib.VideoLibName);
objvVideoLibEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibTheme(this clsvVideoLibEN objvVideoLibEN, string strVideoLibTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTheme, 200, convVideoLib.VideoLibTheme);
objvVideoLibEN.VideoLibTheme = strVideoLibTheme; //视频库主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibTheme) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibTheme, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibTheme] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN Setid_VideoLibType(this clsvVideoLibEN objvVideoLibEN, string strid_VideoLibType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_VideoLibType, convVideoLib.id_VideoLibType);
clsCheckSql.CheckFieldLen(strid_VideoLibType, 4, convVideoLib.id_VideoLibType);
clsCheckSql.CheckFieldForeignKey(strid_VideoLibType, 4, convVideoLib.id_VideoLibType);
objvVideoLibEN.id_VideoLibType = strid_VideoLibType; //视频库类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.id_VideoLibType) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.id_VideoLibType, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.id_VideoLibType] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibTypeName(this clsvVideoLibEN objvVideoLibEN, string strVideoLibTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoLibTypeName, convVideoLib.VideoLibTypeName);
clsCheckSql.CheckFieldLen(strVideoLibTypeName, 30, convVideoLib.VideoLibTypeName);
objvVideoLibEN.VideoLibTypeName = strVideoLibTypeName; //视频库类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibTypeName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibTypeName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibTypeName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibText(this clsvVideoLibEN objvVideoLibEN, string strVideoLibText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibText, 8000, convVideoLib.VideoLibText);
objvVideoLibEN.VideoLibText = strVideoLibText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibText) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibText, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibText] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibDate(this clsvVideoLibEN objvVideoLibEN, string strVideoLibDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibDate, 20, convVideoLib.VideoLibDate);
objvVideoLibEN.VideoLibDate = strVideoLibDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibDate) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibDate, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibDate] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibTime(this clsvVideoLibEN objvVideoLibEN, string strVideoLibTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTime, 6, convVideoLib.VideoLibTime);
clsCheckSql.CheckFieldForeignKey(strVideoLibTime, 6, convVideoLib.VideoLibTime);
objvVideoLibEN.VideoLibTime = strVideoLibTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibTime) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibTime, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibTime] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibDateIn(this clsvVideoLibEN objvVideoLibEN, string strVideoLibDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibDateIn, 8, convVideoLib.VideoLibDateIn);
clsCheckSql.CheckFieldForeignKey(strVideoLibDateIn, 8, convVideoLib.VideoLibDateIn);
objvVideoLibEN.VideoLibDateIn = strVideoLibDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibDateIn) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibDateIn, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibDateIn] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibTimeIn(this clsvVideoLibEN objvVideoLibEN, string strVideoLibTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTimeIn, 6, convVideoLib.VideoLibTimeIn);
clsCheckSql.CheckFieldForeignKey(strVideoLibTimeIn, 6, convVideoLib.VideoLibTimeIn);
objvVideoLibEN.VideoLibTimeIn = strVideoLibTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibTimeIn) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibTimeIn, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibTimeIn] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetOwnerId(this clsvVideoLibEN objvVideoLibEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convVideoLib.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convVideoLib.OwnerId);
objvVideoLibEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.OwnerId) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.OwnerId, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.OwnerId] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN Setid_TeachingPlan(this clsvVideoLibEN objvVideoLibEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingPlan, convVideoLib.id_TeachingPlan);
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convVideoLib.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convVideoLib.id_TeachingPlan);
objvVideoLibEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.id_TeachingPlan) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.id_TeachingPlan, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.id_TeachingPlan] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN Setid_SenateGaugeVersion(this clsvVideoLibEN objvVideoLibEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convVideoLib.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convVideoLib.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convVideoLib.id_SenateGaugeVersion);
objvVideoLibEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.id_SenateGaugeVersion) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetsenateGaugeVersionID(this clsvVideoLibEN objvVideoLibEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convVideoLib.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convVideoLib.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convVideoLib.senateGaugeVersionID);
objvVideoLibEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.senateGaugeVersionID) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.senateGaugeVersionID, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.senateGaugeVersionID] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetsenateGaugeVersionName(this clsvVideoLibEN objvVideoLibEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convVideoLib.senateGaugeVersionName);
objvVideoLibEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.senateGaugeVersionName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.senateGaugeVersionName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.senateGaugeVersionName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetsenateGaugeVersionTtlScore(this clsvVideoLibEN objvVideoLibEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convVideoLib.senateGaugeVersionTtlScore);
objvVideoLibEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.senateGaugeVersionTtlScore) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetIsUse(this clsvVideoLibEN objvVideoLibEN, bool bolIsUse, string strComparisonOp="")
	{
objvVideoLibEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.IsUse) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.IsUse, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.IsUse] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetVersionNo(this clsvVideoLibEN objvVideoLibEN, int intVersionNo, string strComparisonOp="")
	{
objvVideoLibEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VersionNo) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VersionNo, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VersionNo] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetCaseLevelId(this clsvVideoLibEN objvVideoLibEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convVideoLib.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convVideoLib.CaseLevelId);
objvVideoLibEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CaseLevelId) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CaseLevelId, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CaseLevelId] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetCaseLevelName(this clsvVideoLibEN objvVideoLibEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convVideoLib.CaseLevelName);
objvVideoLibEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CaseLevelName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CaseLevelName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CaseLevelName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetIsVisible(this clsvVideoLibEN objvVideoLibEN, bool bolIsVisible, string strComparisonOp="")
	{
objvVideoLibEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.IsVisible) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.IsVisible, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.IsVisible] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN Setid_XzCollege(this clsvVideoLibEN objvVideoLibEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convVideoLib.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convVideoLib.id_XzCollege);
objvVideoLibEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.id_XzCollege) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.id_XzCollege, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.id_XzCollege] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetCollegeID(this clsvVideoLibEN objvVideoLibEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeID, convVideoLib.CollegeID);
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoLib.CollegeID);
objvVideoLibEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CollegeID) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CollegeID, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CollegeID] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetCollegeName(this clsvVideoLibEN objvVideoLibEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convVideoLib.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoLib.CollegeName);
objvVideoLibEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CollegeName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CollegeName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CollegeName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetCollegeNameA(this clsvVideoLibEN objvVideoLibEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoLib.CollegeNameA);
objvVideoLibEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CollegeNameA) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CollegeNameA, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CollegeNameA] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetViewCount(this clsvVideoLibEN objvVideoLibEN, int intViewCount, string strComparisonOp="")
	{
objvVideoLibEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.ViewCount) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.ViewCount, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.ViewCount] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetDownloadNumber(this clsvVideoLibEN objvVideoLibEN, int intDownloadNumber, string strComparisonOp="")
	{
objvVideoLibEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.DownloadNumber) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.DownloadNumber, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.DownloadNumber] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetFileIntegration(this clsvVideoLibEN objvVideoLibEN, int intFileIntegration, string strComparisonOp="")
	{
objvVideoLibEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.FileIntegration) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.FileIntegration, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.FileIntegration] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetLikeCount(this clsvVideoLibEN objvVideoLibEN, long lngLikeCount, string strComparisonOp="")
	{
objvVideoLibEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.LikeCount) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.LikeCount, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.LikeCount] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetCollectionCount(this clsvVideoLibEN objvVideoLibEN, long lngCollectionCount, string strComparisonOp="")
	{
objvVideoLibEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CollectionCount) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CollectionCount, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CollectionCount] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetRecommendedDegreeId(this clsvVideoLibEN objvVideoLibEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convVideoLib.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convVideoLib.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convVideoLib.RecommendedDegreeId);
objvVideoLibEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.RecommendedDegreeId) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.RecommendedDegreeId, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.RecommendedDegreeId] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetRecommendedDegreeName(this clsvVideoLibEN objvVideoLibEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeName, convVideoLib.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convVideoLib.RecommendedDegreeName);
objvVideoLibEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.RecommendedDegreeName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.RecommendedDegreeName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.RecommendedDegreeName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetCourseId(this clsvVideoLibEN objvVideoLibEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convVideoLib.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoLib.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoLib.CourseId);
objvVideoLibEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CourseId) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CourseId, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CourseId] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetCourseCode(this clsvVideoLibEN objvVideoLibEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoLib.CourseCode);
objvVideoLibEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CourseCode) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CourseCode, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CourseCode] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetCourseName(this clsvVideoLibEN objvVideoLibEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoLib.CourseName);
objvVideoLibEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CourseName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CourseName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CourseName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetVideoUrl(this clsvVideoLibEN objvVideoLibEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convVideoLib.VideoUrl);
objvVideoLibEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoUrl) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoUrl, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoUrl] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetVideoPath(this clsvVideoLibEN objvVideoLibEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convVideoLib.VideoPath);
objvVideoLibEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoPath) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoPath, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoPath] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetCoverPicUrl(this clsvVideoLibEN objvVideoLibEN, string strCoverPicUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoverPicUrl, 1000, convVideoLib.CoverPicUrl);
objvVideoLibEN.CoverPicUrl = strCoverPicUrl; //封面Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CoverPicUrl) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CoverPicUrl, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CoverPicUrl] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetCoverPicShortUrl(this clsvVideoLibEN objvVideoLibEN, string strCoverPicShortUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoverPicShortUrl, 1000, convVideoLib.CoverPicShortUrl);
objvVideoLibEN.CoverPicShortUrl = strCoverPicShortUrl; //封面短Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CoverPicShortUrl) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CoverPicShortUrl, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CoverPicShortUrl] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetResErrMsg(this clsvVideoLibEN objvVideoLibEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convVideoLib.ResErrMsg);
objvVideoLibEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.ResErrMsg) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.ResErrMsg, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.ResErrMsg] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetUpdDate(this clsvVideoLibEN objvVideoLibEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convVideoLib.UpdDate);
objvVideoLibEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.UpdDate) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.UpdDate, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.UpdDate] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetUpdUserId(this clsvVideoLibEN objvVideoLibEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convVideoLib.UpdUserId);
objvVideoLibEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.UpdUserId) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.UpdUserId, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.UpdUserId] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetMemo(this clsvVideoLibEN objvVideoLibEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoLib.Memo);
objvVideoLibEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.Memo) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.Memo, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.Memo] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetBrowseCount4Case(this clsvVideoLibEN objvVideoLibEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvVideoLibEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.BrowseCount4Case) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.BrowseCount4Case, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.BrowseCount4Case] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetOwnerName(this clsvVideoLibEN objvVideoLibEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convVideoLib.OwnerName);
objvVideoLibEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.OwnerName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.OwnerName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.OwnerName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetOwnerNameWithId(this clsvVideoLibEN objvVideoLibEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convVideoLib.OwnerNameWithId);
objvVideoLibEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.OwnerNameWithId) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.OwnerNameWithId, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.OwnerNameWithId] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibEN SetIsHaveVideo(this clsvVideoLibEN objvVideoLibEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convVideoLib.IsHaveVideo);
objvVideoLibEN.IsHaveVideo = strIsHaveVideo; //IsHaveVideo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.IsHaveVideo) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.IsHaveVideo, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.IsHaveVideo] = strComparisonOp;
}
}
return objvVideoLibEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoLibEN objvVideoLib_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoLib_Cond.IsUpdated(convVideoLib.Id_VideoLib) == true)
{
string strComparisonOp_Id_VideoLib = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.Id_VideoLib];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.Id_VideoLib, objvVideoLib_Cond.Id_VideoLib, strComparisonOp_Id_VideoLib);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.AppraiseCount) == true)
{
string strComparisonOp_AppraiseCount = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.AppraiseCount, objvVideoLib_Cond.AppraiseCount, strComparisonOp_AppraiseCount);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.LikeNum) == true)
{
string strComparisonOp_LikeNum = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.LikeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.LikeNum, objvVideoLib_Cond.LikeNum, strComparisonOp_LikeNum);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.PlayNum) == true)
{
string strComparisonOp_PlayNum = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.PlayNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.PlayNum, objvVideoLib_Cond.PlayNum, strComparisonOp_PlayNum);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.VideoLibID) == true)
{
string strComparisonOp_VideoLibID = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.VideoLibID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibID, objvVideoLib_Cond.VideoLibID, strComparisonOp_VideoLibID);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.VideoLibName) == true)
{
string strComparisonOp_VideoLibName = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibName, objvVideoLib_Cond.VideoLibName, strComparisonOp_VideoLibName);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.VideoLibTheme) == true)
{
string strComparisonOp_VideoLibTheme = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.VideoLibTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibTheme, objvVideoLib_Cond.VideoLibTheme, strComparisonOp_VideoLibTheme);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.id_VideoLibType) == true)
{
string strComparisonOp_id_VideoLibType = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.id_VideoLibType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.id_VideoLibType, objvVideoLib_Cond.id_VideoLibType, strComparisonOp_id_VideoLibType);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.VideoLibTypeName) == true)
{
string strComparisonOp_VideoLibTypeName = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.VideoLibTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibTypeName, objvVideoLib_Cond.VideoLibTypeName, strComparisonOp_VideoLibTypeName);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.VideoLibText) == true)
{
string strComparisonOp_VideoLibText = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.VideoLibText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibText, objvVideoLib_Cond.VideoLibText, strComparisonOp_VideoLibText);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.VideoLibDate) == true)
{
string strComparisonOp_VideoLibDate = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.VideoLibDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibDate, objvVideoLib_Cond.VideoLibDate, strComparisonOp_VideoLibDate);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.VideoLibTime) == true)
{
string strComparisonOp_VideoLibTime = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.VideoLibTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibTime, objvVideoLib_Cond.VideoLibTime, strComparisonOp_VideoLibTime);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.VideoLibDateIn) == true)
{
string strComparisonOp_VideoLibDateIn = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.VideoLibDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibDateIn, objvVideoLib_Cond.VideoLibDateIn, strComparisonOp_VideoLibDateIn);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.VideoLibTimeIn) == true)
{
string strComparisonOp_VideoLibTimeIn = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.VideoLibTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibTimeIn, objvVideoLib_Cond.VideoLibTimeIn, strComparisonOp_VideoLibTimeIn);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.OwnerId, objvVideoLib_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.id_TeachingPlan, objvVideoLib_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.id_SenateGaugeVersion, objvVideoLib_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.senateGaugeVersionID, objvVideoLib_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.senateGaugeVersionName, objvVideoLib_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.senateGaugeVersionTtlScore, objvVideoLib_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.IsUse) == true)
{
if (objvVideoLib_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLib.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLib.IsUse);
}
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.VersionNo, objvVideoLib_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CaseLevelId, objvVideoLib_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CaseLevelName, objvVideoLib_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.IsVisible) == true)
{
if (objvVideoLib_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLib.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLib.IsVisible);
}
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.id_XzCollege, objvVideoLib_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CollegeID, objvVideoLib_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CollegeName, objvVideoLib_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CollegeNameA, objvVideoLib_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.ViewCount, objvVideoLib_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.DownloadNumber, objvVideoLib_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.FileIntegration, objvVideoLib_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.LikeCount, objvVideoLib_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.CollectionCount, objvVideoLib_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.RecommendedDegreeId, objvVideoLib_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.RecommendedDegreeName, objvVideoLib_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.CourseId) == true)
{
string strComparisonOp_CourseId = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CourseId, objvVideoLib_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CourseCode, objvVideoLib_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.CourseName) == true)
{
string strComparisonOp_CourseName = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CourseName, objvVideoLib_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoUrl, objvVideoLib_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoPath, objvVideoLib_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.CoverPicUrl) == true)
{
string strComparisonOp_CoverPicUrl = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.CoverPicUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CoverPicUrl, objvVideoLib_Cond.CoverPicUrl, strComparisonOp_CoverPicUrl);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.CoverPicShortUrl) == true)
{
string strComparisonOp_CoverPicShortUrl = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.CoverPicShortUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CoverPicShortUrl, objvVideoLib_Cond.CoverPicShortUrl, strComparisonOp_CoverPicShortUrl);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.ResErrMsg, objvVideoLib_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.UpdDate, objvVideoLib_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.UpdUserId, objvVideoLib_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.Memo) == true)
{
string strComparisonOp_Memo = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.Memo, objvVideoLib_Cond.Memo, strComparisonOp_Memo);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.BrowseCount4Case, objvVideoLib_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.OwnerName, objvVideoLib_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.OwnerNameWithId, objvVideoLib_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvVideoLib_Cond.IsUpdated(convVideoLib.IsHaveVideo) == true)
{
string strComparisonOp_IsHaveVideo = objvVideoLib_Cond.dicFldComparisonOp[convVideoLib.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.IsHaveVideo, objvVideoLib_Cond.IsHaveVideo, strComparisonOp_IsHaveVideo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频库(vVideoLib)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoLibWApi
{
private static readonly string mstrApiControllerName = "vVideoLibApi";

 public clsvVideoLibWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_VideoLib">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibEN GetObjById_VideoLib(string strId_VideoLib)
{
string strAction = "GetObjById_VideoLib";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLibEN objvVideoLibEN = null;
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
objvVideoLibEN = JsonConvert.DeserializeObject<clsvVideoLibEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLibEN;
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
public static clsvVideoLibEN GetObjById_VideoLib_WA_Cache(string strId_VideoLib)
{
string strAction = "GetObjById_VideoLib_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLibEN objvVideoLibEN = null;
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
objvVideoLibEN = JsonConvert.DeserializeObject<clsvVideoLibEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLibEN;
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
public static clsvVideoLibEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLibEN objvVideoLibEN = null;
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
objvVideoLibEN = JsonConvert.DeserializeObject<clsvVideoLibEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLibEN;
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
public static clsvVideoLibEN GetObjById_VideoLib_Cache(string strId_VideoLib)
{
if (string.IsNullOrEmpty(strId_VideoLib) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLibEN._CurrTabName_S);
List<clsvVideoLibEN> arrvVideoLibObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLibEN> arrvVideoLibObjLst_Sel =
from objvVideoLibEN in arrvVideoLibObjLst_Cache
where objvVideoLibEN.Id_VideoLib == strId_VideoLib
select objvVideoLibEN;
if (arrvVideoLibObjLst_Sel.Count() == 0)
{
   clsvVideoLibEN obj = clsvVideoLibWApi.GetObjById_VideoLib(strId_VideoLib);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoLibObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibEN> GetObjLst(string strWhereCond)
{
 List<clsvVideoLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibEN> GetObjLstById_VideoLibLst(List<string> arrId_VideoLib)
{
 List<clsvVideoLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvVideoLibEN> GetObjLstById_VideoLibLst_Cache(List<string> arrId_VideoLib)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLibEN._CurrTabName_S);
List<clsvVideoLibEN> arrvVideoLibObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLibEN> arrvVideoLibObjLst_Sel =
from objvVideoLibEN in arrvVideoLibObjLst_Cache
where arrId_VideoLib.Contains(objvVideoLibEN.Id_VideoLib)
select objvVideoLibEN;
return arrvVideoLibObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibEN> GetObjLstById_VideoLibLst_WA_Cache(List<string> arrId_VideoLib)
{
 List<clsvVideoLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvVideoLibENS">源对象</param>
 /// <param name = "objvVideoLibENT">目标对象</param>
 public static void CopyTo(clsvVideoLibEN objvVideoLibENS, clsvVideoLibEN objvVideoLibENT)
{
try
{
objvVideoLibENT.Id_VideoLib = objvVideoLibENS.Id_VideoLib; //视频库流水号
objvVideoLibENT.AppraiseCount = objvVideoLibENS.AppraiseCount; //评论数
objvVideoLibENT.LikeNum = objvVideoLibENS.LikeNum; //点赞数
objvVideoLibENT.PlayNum = objvVideoLibENS.PlayNum; //播放数
objvVideoLibENT.VideoLibID = objvVideoLibENS.VideoLibID; //视频库ID
objvVideoLibENT.VideoLibName = objvVideoLibENS.VideoLibName; //视频名称
objvVideoLibENT.VideoLibTheme = objvVideoLibENS.VideoLibTheme; //视频库主题词
objvVideoLibENT.id_VideoLibType = objvVideoLibENS.id_VideoLibType; //视频库类型流水号
objvVideoLibENT.VideoLibTypeName = objvVideoLibENS.VideoLibTypeName; //视频库类型名称
objvVideoLibENT.VideoLibText = objvVideoLibENS.VideoLibText; //案例文本内容
objvVideoLibENT.VideoLibDate = objvVideoLibENS.VideoLibDate; //视频资源日期
objvVideoLibENT.VideoLibTime = objvVideoLibENS.VideoLibTime; //视频资源时间
objvVideoLibENT.VideoLibDateIn = objvVideoLibENS.VideoLibDateIn; //案例入库日期
objvVideoLibENT.VideoLibTimeIn = objvVideoLibENS.VideoLibTimeIn; //案例入库时间
objvVideoLibENT.OwnerId = objvVideoLibENS.OwnerId; //拥有者Id
objvVideoLibENT.id_TeachingPlan = objvVideoLibENS.id_TeachingPlan; //教案流水号
objvVideoLibENT.id_SenateGaugeVersion = objvVideoLibENS.id_SenateGaugeVersion; //评价量表版本流水号
objvVideoLibENT.senateGaugeVersionID = objvVideoLibENS.senateGaugeVersionID; //评价量表版本ID
objvVideoLibENT.senateGaugeVersionName = objvVideoLibENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLibENT.senateGaugeVersionTtlScore = objvVideoLibENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoLibENT.IsUse = objvVideoLibENS.IsUse; //是否使用
objvVideoLibENT.VersionNo = objvVideoLibENS.VersionNo; //版本号
objvVideoLibENT.CaseLevelId = objvVideoLibENS.CaseLevelId; //课例等级Id
objvVideoLibENT.CaseLevelName = objvVideoLibENS.CaseLevelName; //案例等级名称
objvVideoLibENT.IsVisible = objvVideoLibENS.IsVisible; //是否显示
objvVideoLibENT.id_XzCollege = objvVideoLibENS.id_XzCollege; //学院流水号
objvVideoLibENT.CollegeID = objvVideoLibENS.CollegeID; //学院ID
objvVideoLibENT.CollegeName = objvVideoLibENS.CollegeName; //学院名称
objvVideoLibENT.CollegeNameA = objvVideoLibENS.CollegeNameA; //学院名称简写
objvVideoLibENT.ViewCount = objvVideoLibENS.ViewCount; //浏览量
objvVideoLibENT.DownloadNumber = objvVideoLibENS.DownloadNumber; //下载数目
objvVideoLibENT.FileIntegration = objvVideoLibENS.FileIntegration; //文件积分
objvVideoLibENT.LikeCount = objvVideoLibENS.LikeCount; //资源喜欢数量
objvVideoLibENT.CollectionCount = objvVideoLibENS.CollectionCount; //收藏数量
objvVideoLibENT.RecommendedDegreeId = objvVideoLibENS.RecommendedDegreeId; //推荐度Id
objvVideoLibENT.RecommendedDegreeName = objvVideoLibENS.RecommendedDegreeName; //推荐度名称
objvVideoLibENT.CourseId = objvVideoLibENS.CourseId; //课程Id
objvVideoLibENT.CourseCode = objvVideoLibENS.CourseCode; //课程代码
objvVideoLibENT.CourseName = objvVideoLibENS.CourseName; //课程名称
objvVideoLibENT.VideoUrl = objvVideoLibENS.VideoUrl; //视频Url
objvVideoLibENT.VideoPath = objvVideoLibENS.VideoPath; //视频目录
objvVideoLibENT.CoverPicUrl = objvVideoLibENS.CoverPicUrl; //封面Url
objvVideoLibENT.CoverPicShortUrl = objvVideoLibENS.CoverPicShortUrl; //封面短Url
objvVideoLibENT.ResErrMsg = objvVideoLibENS.ResErrMsg; //资源错误信息
objvVideoLibENT.UpdDate = objvVideoLibENS.UpdDate; //修改日期
objvVideoLibENT.UpdUserId = objvVideoLibENS.UpdUserId; //修改用户Id
objvVideoLibENT.Memo = objvVideoLibENS.Memo; //备注
objvVideoLibENT.BrowseCount4Case = objvVideoLibENS.BrowseCount4Case; //课例浏览次数
objvVideoLibENT.OwnerName = objvVideoLibENS.OwnerName; //拥有者姓名
objvVideoLibENT.OwnerNameWithId = objvVideoLibENS.OwnerNameWithId; //拥有者名称附Id
objvVideoLibENT.IsHaveVideo = objvVideoLibENS.IsHaveVideo; //IsHaveVideo
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
public static DataTable ToDataTable(List<clsvVideoLibEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoLibEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoLibEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoLibEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoLibEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoLibEN.AttributeName)
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
if (clsVideoLikeLogWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLikeLogWApi没有刷新缓存机制(clsVideoLikeLogWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoPlayLogWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoPlayLogWApi没有刷新缓存机制(clsVideoPlayLogWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachAppraiseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachAppraiseWApi没有刷新缓存机制(clsMicroteachAppraiseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_VideoLib");
//if (arrvVideoLibObjLst_Cache == null)
//{
//arrvVideoLibObjLst_Cache = await clsvVideoLibWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoLibEN._CurrTabName_S);
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
public static List<clsvVideoLibEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoLibEN._CurrTabName_S);
List<clsvVideoLibEN> arrvVideoLibObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoLibObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoLibEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoLib.Id_VideoLib, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.AppraiseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib.LikeNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib.PlayNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib.VideoLibID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.VideoLibName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.VideoLibTheme, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.id_VideoLibType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.VideoLibTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.VideoLibText, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.VideoLibDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.VideoLibTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.VideoLibDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.VideoLibTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoLib.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoLib.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoLib.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoLib.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoLib.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.CoverPicUrl, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.CoverPicShortUrl, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLib.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLib.IsHaveVideo, Type.GetType("System.String"));
foreach (clsvVideoLibEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoLib.Id_VideoLib] = objInFor[convVideoLib.Id_VideoLib];
objDR[convVideoLib.AppraiseCount] = objInFor[convVideoLib.AppraiseCount];
objDR[convVideoLib.LikeNum] = objInFor[convVideoLib.LikeNum];
objDR[convVideoLib.PlayNum] = objInFor[convVideoLib.PlayNum];
objDR[convVideoLib.VideoLibID] = objInFor[convVideoLib.VideoLibID];
objDR[convVideoLib.VideoLibName] = objInFor[convVideoLib.VideoLibName];
objDR[convVideoLib.VideoLibTheme] = objInFor[convVideoLib.VideoLibTheme];
objDR[convVideoLib.id_VideoLibType] = objInFor[convVideoLib.id_VideoLibType];
objDR[convVideoLib.VideoLibTypeName] = objInFor[convVideoLib.VideoLibTypeName];
objDR[convVideoLib.VideoLibText] = objInFor[convVideoLib.VideoLibText];
objDR[convVideoLib.VideoLibDate] = objInFor[convVideoLib.VideoLibDate];
objDR[convVideoLib.VideoLibTime] = objInFor[convVideoLib.VideoLibTime];
objDR[convVideoLib.VideoLibDateIn] = objInFor[convVideoLib.VideoLibDateIn];
objDR[convVideoLib.VideoLibTimeIn] = objInFor[convVideoLib.VideoLibTimeIn];
objDR[convVideoLib.OwnerId] = objInFor[convVideoLib.OwnerId];
objDR[convVideoLib.id_TeachingPlan] = objInFor[convVideoLib.id_TeachingPlan];
objDR[convVideoLib.id_SenateGaugeVersion] = objInFor[convVideoLib.id_SenateGaugeVersion];
objDR[convVideoLib.senateGaugeVersionID] = objInFor[convVideoLib.senateGaugeVersionID];
objDR[convVideoLib.senateGaugeVersionName] = objInFor[convVideoLib.senateGaugeVersionName];
objDR[convVideoLib.senateGaugeVersionTtlScore] = objInFor[convVideoLib.senateGaugeVersionTtlScore];
objDR[convVideoLib.IsUse] = objInFor[convVideoLib.IsUse];
objDR[convVideoLib.VersionNo] = objInFor[convVideoLib.VersionNo];
objDR[convVideoLib.CaseLevelId] = objInFor[convVideoLib.CaseLevelId];
objDR[convVideoLib.CaseLevelName] = objInFor[convVideoLib.CaseLevelName];
objDR[convVideoLib.IsVisible] = objInFor[convVideoLib.IsVisible];
objDR[convVideoLib.id_XzCollege] = objInFor[convVideoLib.id_XzCollege];
objDR[convVideoLib.CollegeID] = objInFor[convVideoLib.CollegeID];
objDR[convVideoLib.CollegeName] = objInFor[convVideoLib.CollegeName];
objDR[convVideoLib.CollegeNameA] = objInFor[convVideoLib.CollegeNameA];
objDR[convVideoLib.ViewCount] = objInFor[convVideoLib.ViewCount];
objDR[convVideoLib.DownloadNumber] = objInFor[convVideoLib.DownloadNumber];
objDR[convVideoLib.FileIntegration] = objInFor[convVideoLib.FileIntegration];
objDR[convVideoLib.LikeCount] = objInFor[convVideoLib.LikeCount];
objDR[convVideoLib.CollectionCount] = objInFor[convVideoLib.CollectionCount];
objDR[convVideoLib.RecommendedDegreeId] = objInFor[convVideoLib.RecommendedDegreeId];
objDR[convVideoLib.RecommendedDegreeName] = objInFor[convVideoLib.RecommendedDegreeName];
objDR[convVideoLib.CourseId] = objInFor[convVideoLib.CourseId];
objDR[convVideoLib.CourseCode] = objInFor[convVideoLib.CourseCode];
objDR[convVideoLib.CourseName] = objInFor[convVideoLib.CourseName];
objDR[convVideoLib.VideoUrl] = objInFor[convVideoLib.VideoUrl];
objDR[convVideoLib.VideoPath] = objInFor[convVideoLib.VideoPath];
objDR[convVideoLib.CoverPicUrl] = objInFor[convVideoLib.CoverPicUrl];
objDR[convVideoLib.CoverPicShortUrl] = objInFor[convVideoLib.CoverPicShortUrl];
objDR[convVideoLib.ResErrMsg] = objInFor[convVideoLib.ResErrMsg];
objDR[convVideoLib.UpdDate] = objInFor[convVideoLib.UpdDate];
objDR[convVideoLib.UpdUserId] = objInFor[convVideoLib.UpdUserId];
objDR[convVideoLib.Memo] = objInFor[convVideoLib.Memo];
objDR[convVideoLib.BrowseCount4Case] = objInFor[convVideoLib.BrowseCount4Case];
objDR[convVideoLib.OwnerName] = objInFor[convVideoLib.OwnerName];
objDR[convVideoLib.OwnerNameWithId] = objInFor[convVideoLib.OwnerNameWithId];
objDR[convVideoLib.IsHaveVideo] = objInFor[convVideoLib.IsHaveVideo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}