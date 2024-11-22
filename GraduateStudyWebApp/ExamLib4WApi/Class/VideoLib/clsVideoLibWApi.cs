
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVideoLibWApi
 表名:VideoLib(01120261)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:25
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
public static class clsVideoLibWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetId_VideoLib(this clsVideoLibEN objVideoLibEN, string strId_VideoLib, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_VideoLib, 8, conVideoLib.Id_VideoLib);
clsCheckSql.CheckFieldForeignKey(strId_VideoLib, 8, conVideoLib.Id_VideoLib);
objVideoLibEN.Id_VideoLib = strId_VideoLib; //视频库流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.Id_VideoLib) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.Id_VideoLib, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.Id_VideoLib] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetVideoLibID(this clsVideoLibEN objVideoLibEN, string strVideoLibID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoLibID, conVideoLib.VideoLibID);
clsCheckSql.CheckFieldLen(strVideoLibID, 8, conVideoLib.VideoLibID);
clsCheckSql.CheckFieldForeignKey(strVideoLibID, 8, conVideoLib.VideoLibID);
objVideoLibEN.VideoLibID = strVideoLibID; //视频库ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibID) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibID, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibID] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetVideoLibName(this clsVideoLibEN objVideoLibEN, string strVideoLibName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoLibName, conVideoLib.VideoLibName);
clsCheckSql.CheckFieldLen(strVideoLibName, 100, conVideoLib.VideoLibName);
objVideoLibEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibName) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibName, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibName] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetVideoLibTheme(this clsVideoLibEN objVideoLibEN, string strVideoLibTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTheme, 200, conVideoLib.VideoLibTheme);
objVideoLibEN.VideoLibTheme = strVideoLibTheme; //视频库主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibTheme) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibTheme, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibTheme] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN Setid_VideoLibType(this clsVideoLibEN objVideoLibEN, string strid_VideoLibType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_VideoLibType, conVideoLib.id_VideoLibType);
clsCheckSql.CheckFieldLen(strid_VideoLibType, 4, conVideoLib.id_VideoLibType);
clsCheckSql.CheckFieldForeignKey(strid_VideoLibType, 4, conVideoLib.id_VideoLibType);
objVideoLibEN.id_VideoLibType = strid_VideoLibType; //视频库类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.id_VideoLibType) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.id_VideoLibType, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.id_VideoLibType] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetVideoLibText(this clsVideoLibEN objVideoLibEN, string strVideoLibText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibText, 8000, conVideoLib.VideoLibText);
objVideoLibEN.VideoLibText = strVideoLibText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibText) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibText, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibText] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetVideoLibDate(this clsVideoLibEN objVideoLibEN, string strVideoLibDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibDate, 20, conVideoLib.VideoLibDate);
objVideoLibEN.VideoLibDate = strVideoLibDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibDate) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibDate, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibDate] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetVideoLibTime(this clsVideoLibEN objVideoLibEN, string strVideoLibTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTime, 6, conVideoLib.VideoLibTime);
clsCheckSql.CheckFieldForeignKey(strVideoLibTime, 6, conVideoLib.VideoLibTime);
objVideoLibEN.VideoLibTime = strVideoLibTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibTime) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibTime, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibTime] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetVideoLibDateIn(this clsVideoLibEN objVideoLibEN, string strVideoLibDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibDateIn, 8, conVideoLib.VideoLibDateIn);
clsCheckSql.CheckFieldForeignKey(strVideoLibDateIn, 8, conVideoLib.VideoLibDateIn);
objVideoLibEN.VideoLibDateIn = strVideoLibDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibDateIn) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibDateIn, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibDateIn] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetVideoLibTimeIn(this clsVideoLibEN objVideoLibEN, string strVideoLibTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTimeIn, 6, conVideoLib.VideoLibTimeIn);
clsCheckSql.CheckFieldForeignKey(strVideoLibTimeIn, 6, conVideoLib.VideoLibTimeIn);
objVideoLibEN.VideoLibTimeIn = strVideoLibTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibTimeIn) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibTimeIn, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibTimeIn] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetOwnerId(this clsVideoLibEN objVideoLibEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conVideoLib.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, conVideoLib.OwnerId);
objVideoLibEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.OwnerId) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.OwnerId, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.OwnerId] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN Setid_TeachingPlan(this clsVideoLibEN objVideoLibEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, conVideoLib.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, conVideoLib.id_TeachingPlan);
objVideoLibEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.id_TeachingPlan) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.id_TeachingPlan, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.id_TeachingPlan] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetBrowseCount(this clsVideoLibEN objVideoLibEN, int intBrowseCount, string strComparisonOp="")
	{
objVideoLibEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.BrowseCount) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.BrowseCount, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.BrowseCount] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN Setid_SenateGaugeVersion(this clsVideoLibEN objVideoLibEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conVideoLib.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conVideoLib.id_SenateGaugeVersion);
objVideoLibEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.id_SenateGaugeVersion) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetCaseLevelId(this clsVideoLibEN objVideoLibEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conVideoLib.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conVideoLib.CaseLevelId);
objVideoLibEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.CaseLevelId) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.CaseLevelId, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.CaseLevelId] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetIsVisible(this clsVideoLibEN objVideoLibEN, bool bolIsVisible, string strComparisonOp="")
	{
objVideoLibEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.IsVisible) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.IsVisible, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.IsVisible] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN Setid_XzCollege(this clsVideoLibEN objVideoLibEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conVideoLib.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conVideoLib.id_XzCollege);
objVideoLibEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.id_XzCollege) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.id_XzCollege, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.id_XzCollege] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetViewCount(this clsVideoLibEN objVideoLibEN, int intViewCount, string strComparisonOp="")
	{
objVideoLibEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.ViewCount) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.ViewCount, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.ViewCount] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetDownloadNumber(this clsVideoLibEN objVideoLibEN, int intDownloadNumber, string strComparisonOp="")
	{
objVideoLibEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.DownloadNumber) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.DownloadNumber, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.DownloadNumber] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetFileIntegration(this clsVideoLibEN objVideoLibEN, int intFileIntegration, string strComparisonOp="")
	{
objVideoLibEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.FileIntegration) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.FileIntegration, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.FileIntegration] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetLikeCount(this clsVideoLibEN objVideoLibEN, long lngLikeCount, string strComparisonOp="")
	{
objVideoLibEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.LikeCount) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.LikeCount, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.LikeCount] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetCollectionCount(this clsVideoLibEN objVideoLibEN, long lngCollectionCount, string strComparisonOp="")
	{
objVideoLibEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.CollectionCount) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.CollectionCount, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.CollectionCount] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetRecommendedDegreeId(this clsVideoLibEN objVideoLibEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conVideoLib.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conVideoLib.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conVideoLib.RecommendedDegreeId);
objVideoLibEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.RecommendedDegreeId) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.RecommendedDegreeId, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.RecommendedDegreeId] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetCourseId(this clsVideoLibEN objVideoLibEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, conVideoLib.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conVideoLib.CourseId);
objVideoLibEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.CourseId) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.CourseId, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.CourseId] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetVideoUrl(this clsVideoLibEN objVideoLibEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conVideoLib.VideoUrl);
objVideoLibEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoUrl) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoUrl, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoUrl] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetVideoPath(this clsVideoLibEN objVideoLibEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conVideoLib.VideoPath);
objVideoLibEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoPath) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoPath, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoPath] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetCoverPicUrl(this clsVideoLibEN objVideoLibEN, string strCoverPicUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoverPicUrl, 1000, conVideoLib.CoverPicUrl);
objVideoLibEN.CoverPicUrl = strCoverPicUrl; //封面Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.CoverPicUrl) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.CoverPicUrl, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.CoverPicUrl] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetCoverPicShortUrl(this clsVideoLibEN objVideoLibEN, string strCoverPicShortUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoverPicShortUrl, 1000, conVideoLib.CoverPicShortUrl);
objVideoLibEN.CoverPicShortUrl = strCoverPicShortUrl; //封面短Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.CoverPicShortUrl) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.CoverPicShortUrl, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.CoverPicShortUrl] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetResErrMsg(this clsVideoLibEN objVideoLibEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conVideoLib.ResErrMsg);
objVideoLibEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.ResErrMsg) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.ResErrMsg, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.ResErrMsg] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetUpdDate(this clsVideoLibEN objVideoLibEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conVideoLib.UpdDate);
objVideoLibEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.UpdDate) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.UpdDate, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.UpdDate] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetUpdUserId(this clsVideoLibEN objVideoLibEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conVideoLib.UpdUserId);
objVideoLibEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.UpdUserId) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.UpdUserId, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.UpdUserId] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoLibEN SetMemo(this clsVideoLibEN objVideoLibEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conVideoLib.Memo);
objVideoLibEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.Memo) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.Memo, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.Memo] = strComparisonOp;
}
}
return objVideoLibEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsVideoLibEN objVideoLib_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objVideoLib_Cond.IsUpdated(conVideoLib.Id_VideoLib) == true)
{
string strComparisonOp_Id_VideoLib = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.Id_VideoLib];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.Id_VideoLib, objVideoLib_Cond.Id_VideoLib, strComparisonOp_Id_VideoLib);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.VideoLibID) == true)
{
string strComparisonOp_VideoLibID = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.VideoLibID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibID, objVideoLib_Cond.VideoLibID, strComparisonOp_VideoLibID);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.VideoLibName) == true)
{
string strComparisonOp_VideoLibName = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibName, objVideoLib_Cond.VideoLibName, strComparisonOp_VideoLibName);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.VideoLibTheme) == true)
{
string strComparisonOp_VideoLibTheme = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.VideoLibTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibTheme, objVideoLib_Cond.VideoLibTheme, strComparisonOp_VideoLibTheme);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.id_VideoLibType) == true)
{
string strComparisonOp_id_VideoLibType = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.id_VideoLibType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.id_VideoLibType, objVideoLib_Cond.id_VideoLibType, strComparisonOp_id_VideoLibType);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.VideoLibText) == true)
{
string strComparisonOp_VideoLibText = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.VideoLibText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibText, objVideoLib_Cond.VideoLibText, strComparisonOp_VideoLibText);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.VideoLibDate) == true)
{
string strComparisonOp_VideoLibDate = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.VideoLibDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibDate, objVideoLib_Cond.VideoLibDate, strComparisonOp_VideoLibDate);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.VideoLibTime) == true)
{
string strComparisonOp_VideoLibTime = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.VideoLibTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibTime, objVideoLib_Cond.VideoLibTime, strComparisonOp_VideoLibTime);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.VideoLibDateIn) == true)
{
string strComparisonOp_VideoLibDateIn = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.VideoLibDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibDateIn, objVideoLib_Cond.VideoLibDateIn, strComparisonOp_VideoLibDateIn);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.VideoLibTimeIn) == true)
{
string strComparisonOp_VideoLibTimeIn = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.VideoLibTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibTimeIn, objVideoLib_Cond.VideoLibTimeIn, strComparisonOp_VideoLibTimeIn);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.OwnerId) == true)
{
string strComparisonOp_OwnerId = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.OwnerId, objVideoLib_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.id_TeachingPlan, objVideoLib_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoLib.BrowseCount, objVideoLib_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.id_SenateGaugeVersion, objVideoLib_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.CaseLevelId, objVideoLib_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.IsVisible) == true)
{
if (objVideoLib_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conVideoLib.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conVideoLib.IsVisible);
}
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.id_XzCollege, objVideoLib_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.ViewCount) == true)
{
string strComparisonOp_ViewCount = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoLib.ViewCount, objVideoLib_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoLib.DownloadNumber, objVideoLib_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoLib.FileIntegration, objVideoLib_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.LikeCount) == true)
{
string strComparisonOp_LikeCount = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoLib.LikeCount, objVideoLib_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoLib.CollectionCount, objVideoLib_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.RecommendedDegreeId, objVideoLib_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.CourseId) == true)
{
string strComparisonOp_CourseId = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.CourseId, objVideoLib_Cond.CourseId, strComparisonOp_CourseId);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoUrl, objVideoLib_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.VideoPath) == true)
{
string strComparisonOp_VideoPath = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoPath, objVideoLib_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.CoverPicUrl) == true)
{
string strComparisonOp_CoverPicUrl = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.CoverPicUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.CoverPicUrl, objVideoLib_Cond.CoverPicUrl, strComparisonOp_CoverPicUrl);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.CoverPicShortUrl) == true)
{
string strComparisonOp_CoverPicShortUrl = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.CoverPicShortUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.CoverPicShortUrl, objVideoLib_Cond.CoverPicShortUrl, strComparisonOp_CoverPicShortUrl);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.ResErrMsg, objVideoLib_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.UpdDate) == true)
{
string strComparisonOp_UpdDate = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.UpdDate, objVideoLib_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.UpdUserId, objVideoLib_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objVideoLib_Cond.IsUpdated(conVideoLib.Memo) == true)
{
string strComparisonOp_Memo = objVideoLib_Cond.dicFldComparisonOp[conVideoLib.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.Memo, objVideoLib_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsVideoLibEN objVideoLibEN)
{
 if (string.IsNullOrEmpty(objVideoLibEN.Id_VideoLib) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objVideoLibEN.sf_UpdFldSetStr = objVideoLibEN.getsf_UpdFldSetStr();
clsVideoLibWApi.CheckPropertyNew(objVideoLibEN); 
bool bolResult = clsVideoLibWApi.UpdateRecord(objVideoLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsVideoLibEN objVideoLibEN)
{
 if (string.IsNullOrEmpty(objVideoLibEN.Id_VideoLib) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsVideoLibWApi.IsExist(objVideoLibEN.Id_VideoLib) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objVideoLibEN.Id_VideoLib, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsVideoLibWApi.CheckPropertyNew(objVideoLibEN); 
bool bolResult = clsVideoLibWApi.AddNewRecord(objVideoLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsVideoLibEN objVideoLibEN)
{
try
{
clsVideoLibWApi.CheckPropertyNew(objVideoLibEN); 
string strId_VideoLib = clsVideoLibWApi.AddNewRecordWithMaxId(objVideoLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibWApi.ReFreshCache();
return strId_VideoLib;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objVideoLibEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsVideoLibEN objVideoLibEN, string strWhereCond)
{
try
{
clsVideoLibWApi.CheckPropertyNew(objVideoLibEN); 
bool bolResult = clsVideoLibWApi.UpdateWithCondition(objVideoLibEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 视频库(VideoLib)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsVideoLibWApi
{
private static readonly string mstrApiControllerName = "VideoLibApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsVideoLibWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsVideoLibEN objVideoLibEN)
{
if (!Object.Equals(null, objVideoLibEN.Id_VideoLib) && GetStrLen(objVideoLibEN.Id_VideoLib) > 8)
{
 throw new Exception("字段[视频库流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objVideoLibEN.VideoLibID) && GetStrLen(objVideoLibEN.VideoLibID) > 8)
{
 throw new Exception("字段[视频库ID]的长度不能超过8!");
}
if (!Object.Equals(null, objVideoLibEN.VideoLibName) && GetStrLen(objVideoLibEN.VideoLibName) > 100)
{
 throw new Exception("字段[视频名称]的长度不能超过100!");
}
if (!Object.Equals(null, objVideoLibEN.VideoLibTheme) && GetStrLen(objVideoLibEN.VideoLibTheme) > 200)
{
 throw new Exception("字段[视频库主题词]的长度不能超过200!");
}
if (!Object.Equals(null, objVideoLibEN.id_VideoLibType) && GetStrLen(objVideoLibEN.id_VideoLibType) > 4)
{
 throw new Exception("字段[视频库类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objVideoLibEN.VideoLibText) && GetStrLen(objVideoLibEN.VideoLibText) > 8000)
{
 throw new Exception("字段[案例文本内容]的长度不能超过8000!");
}
if (!Object.Equals(null, objVideoLibEN.VideoLibDate) && GetStrLen(objVideoLibEN.VideoLibDate) > 20)
{
 throw new Exception("字段[视频资源日期]的长度不能超过20!");
}
if (!Object.Equals(null, objVideoLibEN.VideoLibTime) && GetStrLen(objVideoLibEN.VideoLibTime) > 6)
{
 throw new Exception("字段[视频资源时间]的长度不能超过6!");
}
if (!Object.Equals(null, objVideoLibEN.VideoLibDateIn) && GetStrLen(objVideoLibEN.VideoLibDateIn) > 8)
{
 throw new Exception("字段[案例入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objVideoLibEN.VideoLibTimeIn) && GetStrLen(objVideoLibEN.VideoLibTimeIn) > 6)
{
 throw new Exception("字段[案例入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objVideoLibEN.OwnerId) && GetStrLen(objVideoLibEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objVideoLibEN.id_TeachingPlan) && GetStrLen(objVideoLibEN.id_TeachingPlan) > 8)
{
 throw new Exception("字段[教案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objVideoLibEN.id_SenateGaugeVersion) && GetStrLen(objVideoLibEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objVideoLibEN.CaseLevelId) && GetStrLen(objVideoLibEN.CaseLevelId) > 2)
{
 throw new Exception("字段[课例等级Id]的长度不能超过2!");
}
if (!Object.Equals(null, objVideoLibEN.id_XzCollege) && GetStrLen(objVideoLibEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objVideoLibEN.RecommendedDegreeId) && GetStrLen(objVideoLibEN.RecommendedDegreeId) > 2)
{
 throw new Exception("字段[推荐度Id]的长度不能超过2!");
}
if (!Object.Equals(null, objVideoLibEN.CourseId) && GetStrLen(objVideoLibEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objVideoLibEN.VideoUrl) && GetStrLen(objVideoLibEN.VideoUrl) > 1000)
{
 throw new Exception("字段[视频Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objVideoLibEN.VideoPath) && GetStrLen(objVideoLibEN.VideoPath) > 1000)
{
 throw new Exception("字段[视频目录]的长度不能超过1000!");
}
if (!Object.Equals(null, objVideoLibEN.CoverPicUrl) && GetStrLen(objVideoLibEN.CoverPicUrl) > 1000)
{
 throw new Exception("字段[封面Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objVideoLibEN.CoverPicShortUrl) && GetStrLen(objVideoLibEN.CoverPicShortUrl) > 1000)
{
 throw new Exception("字段[封面短Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objVideoLibEN.ResErrMsg) && GetStrLen(objVideoLibEN.ResErrMsg) > 30)
{
 throw new Exception("字段[资源错误信息]的长度不能超过30!");
}
if (!Object.Equals(null, objVideoLibEN.UpdDate) && GetStrLen(objVideoLibEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objVideoLibEN.UpdUserId) && GetStrLen(objVideoLibEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objVideoLibEN.Memo) && GetStrLen(objVideoLibEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objVideoLibEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_VideoLib">表关键字</param>
 /// <returns>表对象</returns>
public static clsVideoLibEN GetObjById_VideoLib(string strId_VideoLib)
{
string strAction = "GetObjById_VideoLib";
string strErrMsg = string.Empty;
string strResult = "";
clsVideoLibEN objVideoLibEN = null;
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
objVideoLibEN = JsonConvert.DeserializeObject<clsVideoLibEN>((string)jobjReturn["ReturnObj"]);
return objVideoLibEN;
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
public static clsVideoLibEN GetObjById_VideoLib_WA_Cache(string strId_VideoLib)
{
string strAction = "GetObjById_VideoLib_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsVideoLibEN objVideoLibEN = null;
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
objVideoLibEN = JsonConvert.DeserializeObject<clsVideoLibEN>((string)jobjReturn["ReturnObj"]);
return objVideoLibEN;
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
public static clsVideoLibEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsVideoLibEN objVideoLibEN = null;
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
objVideoLibEN = JsonConvert.DeserializeObject<clsVideoLibEN>((string)jobjReturn["ReturnObj"]);
return objVideoLibEN;
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
public static clsVideoLibEN GetObjById_VideoLib_Cache(string strId_VideoLib)
{
if (string.IsNullOrEmpty(strId_VideoLib) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsVideoLibEN._CurrTabName_S);
List<clsVideoLibEN> arrVideoLibObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsVideoLibEN> arrVideoLibObjLst_Sel =
from objVideoLibEN in arrVideoLibObjLst_Cache
where objVideoLibEN.Id_VideoLib == strId_VideoLib
select objVideoLibEN;
if (arrVideoLibObjLst_Sel.Count() == 0)
{
   clsVideoLibEN obj = clsVideoLibWApi.GetObjById_VideoLib(strId_VideoLib);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrVideoLibObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsVideoLibEN> GetObjLst(string strWhereCond)
{
 List<clsVideoLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsVideoLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsVideoLibEN> GetObjLstById_VideoLibLst(List<string> arrId_VideoLib)
{
 List<clsVideoLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsVideoLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsVideoLibEN> GetObjLstById_VideoLibLst_Cache(List<string> arrId_VideoLib)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsVideoLibEN._CurrTabName_S);
List<clsVideoLibEN> arrVideoLibObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsVideoLibEN> arrVideoLibObjLst_Sel =
from objVideoLibEN in arrVideoLibObjLst_Cache
where arrId_VideoLib.Contains(objVideoLibEN.Id_VideoLib)
select objVideoLibEN;
return arrVideoLibObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsVideoLibEN> GetObjLstById_VideoLibLst_WA_Cache(List<string> arrId_VideoLib)
{
 List<clsVideoLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsVideoLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsVideoLibEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsVideoLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsVideoLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsVideoLibEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsVideoLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsVideoLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsVideoLibEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsVideoLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsVideoLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsVideoLibEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsVideoLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsVideoLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strId_VideoLib)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsVideoLibEN objVideoLibEN = clsVideoLibWApi.GetObjById_VideoLib(strId_VideoLib);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strId_VideoLib.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsVideoLibWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelVideoLibs(List<string> arrId_VideoLib)
{
string strAction = "DelVideoLibs";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_VideoLib);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsVideoLibWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelVideoLibsByCond(string strWhereCond)
{
string strAction = "DelVideoLibsByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsVideoLibEN objVideoLibEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsVideoLibEN>(objVideoLibEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsVideoLibEN objVideoLibEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsVideoLibEN>(objVideoLibEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibWApi.ReFreshCache();
var strId_VideoLib = (string)jobjReturn["ReturnStr"];
return strId_VideoLib;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsVideoLibEN objVideoLibEN)
{
if (string.IsNullOrEmpty(objVideoLibEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objVideoLibEN.Id_VideoLib, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsVideoLibEN>(objVideoLibEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objVideoLibEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsVideoLibEN objVideoLibEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objVideoLibEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objVideoLibEN.Id_VideoLib, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objVideoLibEN.Id_VideoLib, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsVideoLibEN>(objVideoLibEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objVideoLibENS">源对象</param>
 /// <param name = "objVideoLibENT">目标对象</param>
 public static void CopyTo(clsVideoLibEN objVideoLibENS, clsVideoLibEN objVideoLibENT)
{
try
{
objVideoLibENT.Id_VideoLib = objVideoLibENS.Id_VideoLib; //视频库流水号
objVideoLibENT.VideoLibID = objVideoLibENS.VideoLibID; //视频库ID
objVideoLibENT.VideoLibName = objVideoLibENS.VideoLibName; //视频名称
objVideoLibENT.VideoLibTheme = objVideoLibENS.VideoLibTheme; //视频库主题词
objVideoLibENT.id_VideoLibType = objVideoLibENS.id_VideoLibType; //视频库类型流水号
objVideoLibENT.VideoLibText = objVideoLibENS.VideoLibText; //案例文本内容
objVideoLibENT.VideoLibDate = objVideoLibENS.VideoLibDate; //视频资源日期
objVideoLibENT.VideoLibTime = objVideoLibENS.VideoLibTime; //视频资源时间
objVideoLibENT.VideoLibDateIn = objVideoLibENS.VideoLibDateIn; //案例入库日期
objVideoLibENT.VideoLibTimeIn = objVideoLibENS.VideoLibTimeIn; //案例入库时间
objVideoLibENT.OwnerId = objVideoLibENS.OwnerId; //拥有者Id
objVideoLibENT.id_TeachingPlan = objVideoLibENS.id_TeachingPlan; //教案流水号
objVideoLibENT.BrowseCount = objVideoLibENS.BrowseCount; //浏览次数
objVideoLibENT.id_SenateGaugeVersion = objVideoLibENS.id_SenateGaugeVersion; //评价量表版本流水号
objVideoLibENT.CaseLevelId = objVideoLibENS.CaseLevelId; //课例等级Id
objVideoLibENT.IsVisible = objVideoLibENS.IsVisible; //是否显示
objVideoLibENT.id_XzCollege = objVideoLibENS.id_XzCollege; //学院流水号
objVideoLibENT.ViewCount = objVideoLibENS.ViewCount; //浏览量
objVideoLibENT.DownloadNumber = objVideoLibENS.DownloadNumber; //下载数目
objVideoLibENT.FileIntegration = objVideoLibENS.FileIntegration; //文件积分
objVideoLibENT.LikeCount = objVideoLibENS.LikeCount; //资源喜欢数量
objVideoLibENT.CollectionCount = objVideoLibENS.CollectionCount; //收藏数量
objVideoLibENT.RecommendedDegreeId = objVideoLibENS.RecommendedDegreeId; //推荐度Id
objVideoLibENT.CourseId = objVideoLibENS.CourseId; //课程Id
objVideoLibENT.VideoUrl = objVideoLibENS.VideoUrl; //视频Url
objVideoLibENT.VideoPath = objVideoLibENS.VideoPath; //视频目录
objVideoLibENT.CoverPicUrl = objVideoLibENS.CoverPicUrl; //封面Url
objVideoLibENT.CoverPicShortUrl = objVideoLibENS.CoverPicShortUrl; //封面短Url
objVideoLibENT.ResErrMsg = objVideoLibENS.ResErrMsg; //资源错误信息
objVideoLibENT.UpdDate = objVideoLibENS.UpdDate; //修改日期
objVideoLibENT.UpdUserId = objVideoLibENS.UpdUserId; //修改用户Id
objVideoLibENT.Memo = objVideoLibENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsVideoLibEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsVideoLibEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsVideoLibEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsVideoLibEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsVideoLibEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsVideoLibEN.AttributeName)
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
if (clsVideoLibWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibWApi没有刷新缓存机制(clsVideoLibWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_VideoLib");
//if (arrVideoLibObjLst_Cache == null)
//{
//arrVideoLibObjLst_Cache = await clsVideoLibWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsVideoLibEN._CurrTabName_S);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsVideoLibWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsVideoLibEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsVideoLibWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsVideoLibEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsVideoLibEN._CurrTabName_S);
List<clsVideoLibEN> arrVideoLibObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrVideoLibObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsVideoLibEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conVideoLib.Id_VideoLib, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.VideoLibID, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.VideoLibName, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.VideoLibTheme, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.id_VideoLibType, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.VideoLibText, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.VideoLibDate, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.VideoLibTime, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.VideoLibDateIn, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.VideoLibTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conVideoLib.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conVideoLib.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conVideoLib.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(conVideoLib.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(conVideoLib.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(conVideoLib.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(conVideoLib.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.CoverPicUrl, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.CoverPicShortUrl, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conVideoLib.Memo, Type.GetType("System.String"));
foreach (clsVideoLibEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conVideoLib.Id_VideoLib] = objInFor[conVideoLib.Id_VideoLib];
objDR[conVideoLib.VideoLibID] = objInFor[conVideoLib.VideoLibID];
objDR[conVideoLib.VideoLibName] = objInFor[conVideoLib.VideoLibName];
objDR[conVideoLib.VideoLibTheme] = objInFor[conVideoLib.VideoLibTheme];
objDR[conVideoLib.id_VideoLibType] = objInFor[conVideoLib.id_VideoLibType];
objDR[conVideoLib.VideoLibText] = objInFor[conVideoLib.VideoLibText];
objDR[conVideoLib.VideoLibDate] = objInFor[conVideoLib.VideoLibDate];
objDR[conVideoLib.VideoLibTime] = objInFor[conVideoLib.VideoLibTime];
objDR[conVideoLib.VideoLibDateIn] = objInFor[conVideoLib.VideoLibDateIn];
objDR[conVideoLib.VideoLibTimeIn] = objInFor[conVideoLib.VideoLibTimeIn];
objDR[conVideoLib.OwnerId] = objInFor[conVideoLib.OwnerId];
objDR[conVideoLib.id_TeachingPlan] = objInFor[conVideoLib.id_TeachingPlan];
objDR[conVideoLib.BrowseCount] = objInFor[conVideoLib.BrowseCount];
objDR[conVideoLib.id_SenateGaugeVersion] = objInFor[conVideoLib.id_SenateGaugeVersion];
objDR[conVideoLib.CaseLevelId] = objInFor[conVideoLib.CaseLevelId];
objDR[conVideoLib.IsVisible] = objInFor[conVideoLib.IsVisible];
objDR[conVideoLib.id_XzCollege] = objInFor[conVideoLib.id_XzCollege];
objDR[conVideoLib.ViewCount] = objInFor[conVideoLib.ViewCount];
objDR[conVideoLib.DownloadNumber] = objInFor[conVideoLib.DownloadNumber];
objDR[conVideoLib.FileIntegration] = objInFor[conVideoLib.FileIntegration];
objDR[conVideoLib.LikeCount] = objInFor[conVideoLib.LikeCount];
objDR[conVideoLib.CollectionCount] = objInFor[conVideoLib.CollectionCount];
objDR[conVideoLib.RecommendedDegreeId] = objInFor[conVideoLib.RecommendedDegreeId];
objDR[conVideoLib.CourseId] = objInFor[conVideoLib.CourseId];
objDR[conVideoLib.VideoUrl] = objInFor[conVideoLib.VideoUrl];
objDR[conVideoLib.VideoPath] = objInFor[conVideoLib.VideoPath];
objDR[conVideoLib.CoverPicUrl] = objInFor[conVideoLib.CoverPicUrl];
objDR[conVideoLib.CoverPicShortUrl] = objInFor[conVideoLib.CoverPicShortUrl];
objDR[conVideoLib.ResErrMsg] = objInFor[conVideoLib.ResErrMsg];
objDR[conVideoLib.UpdDate] = objInFor[conVideoLib.UpdDate];
objDR[conVideoLib.UpdUserId] = objInFor[conVideoLib.UpdUserId];
objDR[conVideoLib.Memo] = objInFor[conVideoLib.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 视频库(VideoLib)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4VideoLib : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibWApi.ReFreshThisCache();
}
}

}