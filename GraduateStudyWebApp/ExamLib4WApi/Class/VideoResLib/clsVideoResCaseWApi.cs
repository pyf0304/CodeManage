
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVideoResCaseWApi
 表名:VideoResCase(01120371)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:07
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
public static class clsVideoResCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetId_VideoResCase(this clsVideoResCaseEN objVideoResCaseEN, string strId_VideoResCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_VideoResCase, 8, conVideoResCase.Id_VideoResCase);
clsCheckSql.CheckFieldForeignKey(strId_VideoResCase, 8, conVideoResCase.Id_VideoResCase);
objVideoResCaseEN.Id_VideoResCase = strId_VideoResCase; //视频资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.Id_VideoResCase) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.Id_VideoResCase, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.Id_VideoResCase] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetVideoResCaseID(this clsVideoResCaseEN objVideoResCaseEN, string strVideoResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoResCaseID, conVideoResCase.VideoResCaseID);
clsCheckSql.CheckFieldLen(strVideoResCaseID, 8, conVideoResCase.VideoResCaseID);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseID, 8, conVideoResCase.VideoResCaseID);
objVideoResCaseEN.VideoResCaseID = strVideoResCaseID; //视频资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.VideoResCaseID) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.VideoResCaseID, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.VideoResCaseID] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetVideoResCaseName(this clsVideoResCaseEN objVideoResCaseEN, string strVideoResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoResCaseName, conVideoResCase.VideoResCaseName);
clsCheckSql.CheckFieldLen(strVideoResCaseName, 100, conVideoResCase.VideoResCaseName);
objVideoResCaseEN.VideoResCaseName = strVideoResCaseName; //视频资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.VideoResCaseName) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.VideoResCaseName, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.VideoResCaseName] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetVideoResCaseTheme(this clsVideoResCaseEN objVideoResCaseEN, string strVideoResCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTheme, 200, conVideoResCase.VideoResCaseTheme);
objVideoResCaseEN.VideoResCaseTheme = strVideoResCaseTheme; //视频资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.VideoResCaseTheme) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.VideoResCaseTheme, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.VideoResCaseTheme] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN Setid_VideoResCaseType(this clsVideoResCaseEN objVideoResCaseEN, string strid_VideoResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_VideoResCaseType, conVideoResCase.id_VideoResCaseType);
clsCheckSql.CheckFieldLen(strid_VideoResCaseType, 4, conVideoResCase.id_VideoResCaseType);
clsCheckSql.CheckFieldForeignKey(strid_VideoResCaseType, 4, conVideoResCase.id_VideoResCaseType);
objVideoResCaseEN.id_VideoResCaseType = strid_VideoResCaseType; //视频资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.id_VideoResCaseType) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.id_VideoResCaseType, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.id_VideoResCaseType] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetVideoResCaseText(this clsVideoResCaseEN objVideoResCaseEN, string strVideoResCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseText, 8000, conVideoResCase.VideoResCaseText);
objVideoResCaseEN.VideoResCaseText = strVideoResCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.VideoResCaseText) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.VideoResCaseText, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.VideoResCaseText] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetVideoResCaseDate(this clsVideoResCaseEN objVideoResCaseEN, string strVideoResCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseDate, 8, conVideoResCase.VideoResCaseDate);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseDate, 8, conVideoResCase.VideoResCaseDate);
objVideoResCaseEN.VideoResCaseDate = strVideoResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.VideoResCaseDate) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.VideoResCaseDate, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.VideoResCaseDate] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetVideoResCaseTime(this clsVideoResCaseEN objVideoResCaseEN, string strVideoResCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTime, 6, conVideoResCase.VideoResCaseTime);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseTime, 6, conVideoResCase.VideoResCaseTime);
objVideoResCaseEN.VideoResCaseTime = strVideoResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.VideoResCaseTime) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.VideoResCaseTime, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.VideoResCaseTime] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetVideoResCaseDateIn(this clsVideoResCaseEN objVideoResCaseEN, string strVideoResCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseDateIn, 8, conVideoResCase.VideoResCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseDateIn, 8, conVideoResCase.VideoResCaseDateIn);
objVideoResCaseEN.VideoResCaseDateIn = strVideoResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.VideoResCaseDateIn) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.VideoResCaseDateIn, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.VideoResCaseDateIn] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetVideoResCaseTimeIn(this clsVideoResCaseEN objVideoResCaseEN, string strVideoResCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTimeIn, 6, conVideoResCase.VideoResCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseTimeIn, 6, conVideoResCase.VideoResCaseTimeIn);
objVideoResCaseEN.VideoResCaseTimeIn = strVideoResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.VideoResCaseTimeIn) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.VideoResCaseTimeIn, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.VideoResCaseTimeIn] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetOwnerId(this clsVideoResCaseEN objVideoResCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conVideoResCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, conVideoResCase.OwnerId);
objVideoResCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.OwnerId) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.OwnerId, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.OwnerId] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN Setid_StudyLevel(this clsVideoResCaseEN objVideoResCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, conVideoResCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, conVideoResCase.id_StudyLevel);
objVideoResCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.id_StudyLevel) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.id_StudyLevel, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.id_StudyLevel] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN Setid_TeachingPlan(this clsVideoResCaseEN objVideoResCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, conVideoResCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, conVideoResCase.id_TeachingPlan);
objVideoResCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.id_TeachingPlan) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.id_TeachingPlan, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.id_TeachingPlan] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN Setid_Discipline(this clsVideoResCaseEN objVideoResCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline, 4, conVideoResCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, conVideoResCase.id_Discipline);
objVideoResCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.id_Discipline) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.id_Discipline, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.id_Discipline] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetBrowseCount(this clsVideoResCaseEN objVideoResCaseEN, int intBrowseCount, string strComparisonOp="")
	{
objVideoResCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.BrowseCount) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.BrowseCount, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.BrowseCount] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN Setid_SenateGaugeVersion(this clsVideoResCaseEN objVideoResCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conVideoResCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conVideoResCase.id_SenateGaugeVersion);
objVideoResCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.id_SenateGaugeVersion) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN Setid_TeachSkill(this clsVideoResCaseEN objVideoResCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, conVideoResCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, conVideoResCase.id_TeachSkill);
objVideoResCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.id_TeachSkill) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.id_TeachSkill, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.id_TeachSkill] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetCaseLevelId(this clsVideoResCaseEN objVideoResCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conVideoResCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conVideoResCase.CaseLevelId);
objVideoResCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.CaseLevelId) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.CaseLevelId, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.CaseLevelId] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetDocFile(this clsVideoResCaseEN objVideoResCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, conVideoResCase.DocFile);
objVideoResCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.DocFile) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.DocFile, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.DocFile] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetIsNeedGeneWord(this clsVideoResCaseEN objVideoResCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objVideoResCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.IsNeedGeneWord) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetWordCreateDate(this clsVideoResCaseEN objVideoResCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conVideoResCase.WordCreateDate);
objVideoResCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.WordCreateDate) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.WordCreateDate, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.WordCreateDate] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetIsVisible(this clsVideoResCaseEN objVideoResCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objVideoResCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.IsVisible) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.IsVisible, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.IsVisible] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetIsDualVideo(this clsVideoResCaseEN objVideoResCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objVideoResCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.IsDualVideo) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.IsDualVideo, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.IsDualVideo] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN Setid_XzCollege(this clsVideoResCaseEN objVideoResCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, conVideoResCase.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conVideoResCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conVideoResCase.id_XzCollege);
objVideoResCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.id_XzCollege) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.id_XzCollege, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.id_XzCollege] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN Setid_XzMajor(this clsVideoResCaseEN objVideoResCaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, conVideoResCase.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, conVideoResCase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, conVideoResCase.id_XzMajor);
objVideoResCaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.id_XzMajor) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.id_XzMajor, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.id_XzMajor] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetCourseChapterId(this clsVideoResCaseEN objVideoResCaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, conVideoResCase.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, conVideoResCase.CourseChapterId);
objVideoResCaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.CourseChapterId) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.CourseChapterId, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.CourseChapterId] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetViewCount(this clsVideoResCaseEN objVideoResCaseEN, int intViewCount, string strComparisonOp="")
	{
objVideoResCaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.ViewCount) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.ViewCount, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.ViewCount] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetIsShow(this clsVideoResCaseEN objVideoResCaseEN, bool bolIsShow, string strComparisonOp="")
	{
objVideoResCaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.IsShow) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.IsShow, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.IsShow] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetDownloadNumber(this clsVideoResCaseEN objVideoResCaseEN, int intDownloadNumber, string strComparisonOp="")
	{
objVideoResCaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.DownloadNumber) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.DownloadNumber, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.DownloadNumber] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetFileIntegration(this clsVideoResCaseEN objVideoResCaseEN, int intFileIntegration, string strComparisonOp="")
	{
objVideoResCaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.FileIntegration) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.FileIntegration, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.FileIntegration] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetLikeCount(this clsVideoResCaseEN objVideoResCaseEN, long lngLikeCount, string strComparisonOp="")
	{
objVideoResCaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.LikeCount) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.LikeCount, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.LikeCount] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetCollectionCount(this clsVideoResCaseEN objVideoResCaseEN, long lngCollectionCount, string strComparisonOp="")
	{
objVideoResCaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.CollectionCount) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.CollectionCount, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.CollectionCount] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetRecommendedDegreeId(this clsVideoResCaseEN objVideoResCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conVideoResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conVideoResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conVideoResCase.RecommendedDegreeId);
objVideoResCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.RecommendedDegreeId) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetftpFileType(this clsVideoResCaseEN objVideoResCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conVideoResCase.ftpFileType);
objVideoResCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.ftpFileType) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.ftpFileType, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.ftpFileType] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetCourseId(this clsVideoResCaseEN objVideoResCaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conVideoResCase.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, conVideoResCase.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conVideoResCase.CourseId);
objVideoResCaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.CourseId) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.CourseId, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.CourseId] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetVideoUrl(this clsVideoResCaseEN objVideoResCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conVideoResCase.VideoUrl);
objVideoResCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.VideoUrl) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.VideoUrl, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.VideoUrl] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetVideoPath(this clsVideoResCaseEN objVideoResCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conVideoResCase.VideoPath);
objVideoResCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.VideoPath) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.VideoPath, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.VideoPath] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetResErrMsg(this clsVideoResCaseEN objVideoResCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conVideoResCase.ResErrMsg);
objVideoResCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.ResErrMsg) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.ResErrMsg, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.ResErrMsg] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetUpdDate(this clsVideoResCaseEN objVideoResCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conVideoResCase.UpdDate);
objVideoResCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.UpdDate) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.UpdDate, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.UpdDate] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetUpdUserId(this clsVideoResCaseEN objVideoResCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conVideoResCase.UpdUserId);
objVideoResCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.UpdUserId) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.UpdUserId, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.UpdUserId] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsVideoResCaseEN SetMemo(this clsVideoResCaseEN objVideoResCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conVideoResCase.Memo);
objVideoResCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoResCaseEN.dicFldComparisonOp.ContainsKey(conVideoResCase.Memo) == false)
{
objVideoResCaseEN.dicFldComparisonOp.Add(conVideoResCase.Memo, strComparisonOp);
}
else
{
objVideoResCaseEN.dicFldComparisonOp[conVideoResCase.Memo] = strComparisonOp;
}
}
return objVideoResCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsVideoResCaseEN objVideoResCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.Id_VideoResCase) == true)
{
string strComparisonOp_Id_VideoResCase = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.Id_VideoResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.Id_VideoResCase, objVideoResCase_Cond.Id_VideoResCase, strComparisonOp_Id_VideoResCase);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.VideoResCaseID) == true)
{
string strComparisonOp_VideoResCaseID = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.VideoResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.VideoResCaseID, objVideoResCase_Cond.VideoResCaseID, strComparisonOp_VideoResCaseID);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.VideoResCaseName) == true)
{
string strComparisonOp_VideoResCaseName = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.VideoResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.VideoResCaseName, objVideoResCase_Cond.VideoResCaseName, strComparisonOp_VideoResCaseName);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.VideoResCaseTheme) == true)
{
string strComparisonOp_VideoResCaseTheme = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.VideoResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.VideoResCaseTheme, objVideoResCase_Cond.VideoResCaseTheme, strComparisonOp_VideoResCaseTheme);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.id_VideoResCaseType) == true)
{
string strComparisonOp_id_VideoResCaseType = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.id_VideoResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.id_VideoResCaseType, objVideoResCase_Cond.id_VideoResCaseType, strComparisonOp_id_VideoResCaseType);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.VideoResCaseText) == true)
{
string strComparisonOp_VideoResCaseText = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.VideoResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.VideoResCaseText, objVideoResCase_Cond.VideoResCaseText, strComparisonOp_VideoResCaseText);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.VideoResCaseDate) == true)
{
string strComparisonOp_VideoResCaseDate = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.VideoResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.VideoResCaseDate, objVideoResCase_Cond.VideoResCaseDate, strComparisonOp_VideoResCaseDate);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.VideoResCaseTime) == true)
{
string strComparisonOp_VideoResCaseTime = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.VideoResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.VideoResCaseTime, objVideoResCase_Cond.VideoResCaseTime, strComparisonOp_VideoResCaseTime);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.VideoResCaseDateIn) == true)
{
string strComparisonOp_VideoResCaseDateIn = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.VideoResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.VideoResCaseDateIn, objVideoResCase_Cond.VideoResCaseDateIn, strComparisonOp_VideoResCaseDateIn);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.VideoResCaseTimeIn) == true)
{
string strComparisonOp_VideoResCaseTimeIn = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.VideoResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.VideoResCaseTimeIn, objVideoResCase_Cond.VideoResCaseTimeIn, strComparisonOp_VideoResCaseTimeIn);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.OwnerId, objVideoResCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.id_StudyLevel, objVideoResCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.id_TeachingPlan, objVideoResCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.id_Discipline, objVideoResCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoResCase.BrowseCount, objVideoResCase_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.id_SenateGaugeVersion, objVideoResCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.id_TeachSkill, objVideoResCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.CaseLevelId, objVideoResCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.DocFile) == true)
{
string strComparisonOp_DocFile = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.DocFile, objVideoResCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.IsNeedGeneWord) == true)
{
if (objVideoResCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conVideoResCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conVideoResCase.IsNeedGeneWord);
}
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.WordCreateDate, objVideoResCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.IsVisible) == true)
{
if (objVideoResCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conVideoResCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conVideoResCase.IsVisible);
}
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.IsDualVideo) == true)
{
if (objVideoResCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conVideoResCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conVideoResCase.IsDualVideo);
}
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.id_XzCollege, objVideoResCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.id_XzMajor, objVideoResCase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.CourseChapterId, objVideoResCase_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.ViewCount) == true)
{
string strComparisonOp_ViewCount = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoResCase.ViewCount, objVideoResCase_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.IsShow) == true)
{
if (objVideoResCase_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conVideoResCase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conVideoResCase.IsShow);
}
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoResCase.DownloadNumber, objVideoResCase_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoResCase.FileIntegration, objVideoResCase_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.LikeCount) == true)
{
string strComparisonOp_LikeCount = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoResCase.LikeCount, objVideoResCase_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoResCase.CollectionCount, objVideoResCase_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.RecommendedDegreeId, objVideoResCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.ftpFileType, objVideoResCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.CourseId) == true)
{
string strComparisonOp_CourseId = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.CourseId, objVideoResCase_Cond.CourseId, strComparisonOp_CourseId);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.VideoUrl, objVideoResCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.VideoPath, objVideoResCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.ResErrMsg, objVideoResCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.UpdDate, objVideoResCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.UpdUserId, objVideoResCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objVideoResCase_Cond.IsUpdated(conVideoResCase.Memo) == true)
{
string strComparisonOp_Memo = objVideoResCase_Cond.dicFldComparisonOp[conVideoResCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoResCase.Memo, objVideoResCase_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsVideoResCaseEN objVideoResCaseEN)
{
 if (string.IsNullOrEmpty(objVideoResCaseEN.Id_VideoResCase) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objVideoResCaseEN.sf_UpdFldSetStr = objVideoResCaseEN.getsf_UpdFldSetStr();
clsVideoResCaseWApi.CheckPropertyNew(objVideoResCaseEN); 
bool bolResult = clsVideoResCaseWApi.UpdateRecord(objVideoResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoResCaseWApi.ReFreshCache();
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
 /// <param name = "objVideoResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsVideoResCaseEN objVideoResCaseEN)
{
 if (string.IsNullOrEmpty(objVideoResCaseEN.Id_VideoResCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsVideoResCaseWApi.IsExist(objVideoResCaseEN.Id_VideoResCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objVideoResCaseEN.Id_VideoResCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsVideoResCaseWApi.CheckPropertyNew(objVideoResCaseEN); 
bool bolResult = clsVideoResCaseWApi.AddNewRecord(objVideoResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoResCaseWApi.ReFreshCache();
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
 /// <param name = "objVideoResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsVideoResCaseEN objVideoResCaseEN)
{
try
{
clsVideoResCaseWApi.CheckPropertyNew(objVideoResCaseEN); 
string strId_VideoResCase = clsVideoResCaseWApi.AddNewRecordWithMaxId(objVideoResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoResCaseWApi.ReFreshCache();
return strId_VideoResCase;
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
 /// <param name = "objVideoResCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsVideoResCaseEN objVideoResCaseEN, string strWhereCond)
{
try
{
clsVideoResCaseWApi.CheckPropertyNew(objVideoResCaseEN); 
bool bolResult = clsVideoResCaseWApi.UpdateWithCondition(objVideoResCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoResCaseWApi.ReFreshCache();
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
 /// 视频资源案例(VideoResCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsVideoResCaseWApi
{
private static readonly string mstrApiControllerName = "VideoResCaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsVideoResCaseWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsVideoResCaseEN objVideoResCaseEN)
{
if (!Object.Equals(null, objVideoResCaseEN.Id_VideoResCase) && GetStrLen(objVideoResCaseEN.Id_VideoResCase) > 8)
{
 throw new Exception("字段[视频资源案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objVideoResCaseEN.VideoResCaseID) && GetStrLen(objVideoResCaseEN.VideoResCaseID) > 8)
{
 throw new Exception("字段[视频资源案例ID]的长度不能超过8!");
}
if (!Object.Equals(null, objVideoResCaseEN.VideoResCaseName) && GetStrLen(objVideoResCaseEN.VideoResCaseName) > 100)
{
 throw new Exception("字段[视频资源案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objVideoResCaseEN.VideoResCaseTheme) && GetStrLen(objVideoResCaseEN.VideoResCaseTheme) > 200)
{
 throw new Exception("字段[视频资源案例主题词]的长度不能超过200!");
}
if (!Object.Equals(null, objVideoResCaseEN.id_VideoResCaseType) && GetStrLen(objVideoResCaseEN.id_VideoResCaseType) > 4)
{
 throw new Exception("字段[视频资源类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objVideoResCaseEN.VideoResCaseText) && GetStrLen(objVideoResCaseEN.VideoResCaseText) > 8000)
{
 throw new Exception("字段[案例文本内容]的长度不能超过8000!");
}
if (!Object.Equals(null, objVideoResCaseEN.VideoResCaseDate) && GetStrLen(objVideoResCaseEN.VideoResCaseDate) > 8)
{
 throw new Exception("字段[视频资源日期]的长度不能超过8!");
}
if (!Object.Equals(null, objVideoResCaseEN.VideoResCaseTime) && GetStrLen(objVideoResCaseEN.VideoResCaseTime) > 6)
{
 throw new Exception("字段[视频资源时间]的长度不能超过6!");
}
if (!Object.Equals(null, objVideoResCaseEN.VideoResCaseDateIn) && GetStrLen(objVideoResCaseEN.VideoResCaseDateIn) > 8)
{
 throw new Exception("字段[案例入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objVideoResCaseEN.VideoResCaseTimeIn) && GetStrLen(objVideoResCaseEN.VideoResCaseTimeIn) > 6)
{
 throw new Exception("字段[案例入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objVideoResCaseEN.OwnerId) && GetStrLen(objVideoResCaseEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objVideoResCaseEN.id_StudyLevel) && GetStrLen(objVideoResCaseEN.id_StudyLevel) > 4)
{
 throw new Exception("字段[id_StudyLevel]的长度不能超过4!");
}
if (!Object.Equals(null, objVideoResCaseEN.id_TeachingPlan) && GetStrLen(objVideoResCaseEN.id_TeachingPlan) > 8)
{
 throw new Exception("字段[教案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objVideoResCaseEN.id_Discipline) && GetStrLen(objVideoResCaseEN.id_Discipline) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objVideoResCaseEN.id_SenateGaugeVersion) && GetStrLen(objVideoResCaseEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objVideoResCaseEN.id_TeachSkill) && GetStrLen(objVideoResCaseEN.id_TeachSkill) > 8)
{
 throw new Exception("字段[教学技能流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objVideoResCaseEN.CaseLevelId) && GetStrLen(objVideoResCaseEN.CaseLevelId) > 2)
{
 throw new Exception("字段[课例等级Id]的长度不能超过2!");
}
if (!Object.Equals(null, objVideoResCaseEN.DocFile) && GetStrLen(objVideoResCaseEN.DocFile) > 200)
{
 throw new Exception("字段[生成的Word文件名]的长度不能超过200!");
}
if (!Object.Equals(null, objVideoResCaseEN.WordCreateDate) && GetStrLen(objVideoResCaseEN.WordCreateDate) > 14)
{
 throw new Exception("字段[Word生成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objVideoResCaseEN.id_XzCollege) && GetStrLen(objVideoResCaseEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objVideoResCaseEN.id_XzMajor) && GetStrLen(objVideoResCaseEN.id_XzMajor) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objVideoResCaseEN.CourseChapterId) && GetStrLen(objVideoResCaseEN.CourseChapterId) > 8)
{
 throw new Exception("字段[课程章节ID]的长度不能超过8!");
}
if (!Object.Equals(null, objVideoResCaseEN.RecommendedDegreeId) && GetStrLen(objVideoResCaseEN.RecommendedDegreeId) > 2)
{
 throw new Exception("字段[推荐度Id]的长度不能超过2!");
}
if (!Object.Equals(null, objVideoResCaseEN.ftpFileType) && GetStrLen(objVideoResCaseEN.ftpFileType) > 30)
{
 throw new Exception("字段[ftp文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objVideoResCaseEN.CourseId) && GetStrLen(objVideoResCaseEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objVideoResCaseEN.VideoUrl) && GetStrLen(objVideoResCaseEN.VideoUrl) > 1000)
{
 throw new Exception("字段[视频Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objVideoResCaseEN.VideoPath) && GetStrLen(objVideoResCaseEN.VideoPath) > 1000)
{
 throw new Exception("字段[视频目录]的长度不能超过1000!");
}
if (!Object.Equals(null, objVideoResCaseEN.ResErrMsg) && GetStrLen(objVideoResCaseEN.ResErrMsg) > 30)
{
 throw new Exception("字段[资源错误信息]的长度不能超过30!");
}
if (!Object.Equals(null, objVideoResCaseEN.UpdDate) && GetStrLen(objVideoResCaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objVideoResCaseEN.UpdUserId) && GetStrLen(objVideoResCaseEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objVideoResCaseEN.Memo) && GetStrLen(objVideoResCaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objVideoResCaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_VideoResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsVideoResCaseEN GetObjById_VideoResCase(string strId_VideoResCase)
{
string strAction = "GetObjById_VideoResCase";
string strErrMsg = string.Empty;
string strResult = "";
clsVideoResCaseEN objVideoResCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_VideoResCase"] = strId_VideoResCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objVideoResCaseEN = JsonConvert.DeserializeObject<clsVideoResCaseEN>((string)jobjReturn["ReturnObj"]);
return objVideoResCaseEN;
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
 /// <param name = "strId_VideoResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsVideoResCaseEN GetObjById_VideoResCase_WA_Cache(string strId_VideoResCase)
{
string strAction = "GetObjById_VideoResCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsVideoResCaseEN objVideoResCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_VideoResCase"] = strId_VideoResCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objVideoResCaseEN = JsonConvert.DeserializeObject<clsVideoResCaseEN>((string)jobjReturn["ReturnObj"]);
return objVideoResCaseEN;
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
public static clsVideoResCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsVideoResCaseEN objVideoResCaseEN = null;
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
objVideoResCaseEN = JsonConvert.DeserializeObject<clsVideoResCaseEN>((string)jobjReturn["ReturnObj"]);
return objVideoResCaseEN;
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
 /// <param name = "strId_VideoResCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsVideoResCaseEN GetObjById_VideoResCase_Cache(string strId_VideoResCase)
{
if (string.IsNullOrEmpty(strId_VideoResCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsVideoResCaseEN._CurrTabName_S);
List<clsVideoResCaseEN> arrVideoResCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsVideoResCaseEN> arrVideoResCaseObjLst_Sel =
from objVideoResCaseEN in arrVideoResCaseObjLst_Cache
where objVideoResCaseEN.Id_VideoResCase == strId_VideoResCase
select objVideoResCaseEN;
if (arrVideoResCaseObjLst_Sel.Count() == 0)
{
   clsVideoResCaseEN obj = clsVideoResCaseWApi.GetObjById_VideoResCase(strId_VideoResCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrVideoResCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsVideoResCaseEN> GetObjLst(string strWhereCond)
{
 List<clsVideoResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsVideoResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsVideoResCaseEN> GetObjLstById_VideoResCaseLst(List<string> arrId_VideoResCase)
{
 List<clsVideoResCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_VideoResCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_VideoResCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsVideoResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_VideoResCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsVideoResCaseEN> GetObjLstById_VideoResCaseLst_Cache(List<string> arrId_VideoResCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsVideoResCaseEN._CurrTabName_S);
List<clsVideoResCaseEN> arrVideoResCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsVideoResCaseEN> arrVideoResCaseObjLst_Sel =
from objVideoResCaseEN in arrVideoResCaseObjLst_Cache
where arrId_VideoResCase.Contains(objVideoResCaseEN.Id_VideoResCase)
select objVideoResCaseEN;
return arrVideoResCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsVideoResCaseEN> GetObjLstById_VideoResCaseLst_WA_Cache(List<string> arrId_VideoResCase)
{
 List<clsVideoResCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_VideoResCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_VideoResCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsVideoResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsVideoResCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsVideoResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsVideoResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsVideoResCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsVideoResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsVideoResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsVideoResCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsVideoResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsVideoResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsVideoResCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsVideoResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsVideoResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strId_VideoResCase)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsVideoResCaseEN objVideoResCaseEN = clsVideoResCaseWApi.GetObjById_VideoResCase(strId_VideoResCase);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strId_VideoResCase.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsVideoResCaseWApi.ReFreshCache();
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
public static int DelVideoResCases(List<string> arrId_VideoResCase)
{
string strAction = "DelVideoResCases";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_VideoResCase);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsVideoResCaseWApi.ReFreshCache();
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
public static int DelVideoResCasesByCond(string strWhereCond)
{
string strAction = "DelVideoResCasesByCond";
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
public static bool AddNewRecord(clsVideoResCaseEN objVideoResCaseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsVideoResCaseEN>(objVideoResCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoResCaseWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsVideoResCaseEN objVideoResCaseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsVideoResCaseEN>(objVideoResCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoResCaseWApi.ReFreshCache();
var strId_VideoResCase = (string)jobjReturn["ReturnStr"];
return strId_VideoResCase;
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
public static bool UpdateRecord(clsVideoResCaseEN objVideoResCaseEN)
{
if (string.IsNullOrEmpty(objVideoResCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objVideoResCaseEN.Id_VideoResCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsVideoResCaseEN>(objVideoResCaseEN);
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
 /// <param name = "objVideoResCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsVideoResCaseEN objVideoResCaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objVideoResCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objVideoResCaseEN.Id_VideoResCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objVideoResCaseEN.Id_VideoResCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsVideoResCaseEN>(objVideoResCaseEN);
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
public static bool IsExist(string strId_VideoResCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_VideoResCase"] = strId_VideoResCase
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
 /// <param name = "objVideoResCaseENS">源对象</param>
 /// <param name = "objVideoResCaseENT">目标对象</param>
 public static void CopyTo(clsVideoResCaseEN objVideoResCaseENS, clsVideoResCaseEN objVideoResCaseENT)
{
try
{
objVideoResCaseENT.Id_VideoResCase = objVideoResCaseENS.Id_VideoResCase; //视频资源案例流水号
objVideoResCaseENT.VideoResCaseID = objVideoResCaseENS.VideoResCaseID; //视频资源案例ID
objVideoResCaseENT.VideoResCaseName = objVideoResCaseENS.VideoResCaseName; //视频资源案例名称
objVideoResCaseENT.VideoResCaseTheme = objVideoResCaseENS.VideoResCaseTheme; //视频资源案例主题词
objVideoResCaseENT.id_VideoResCaseType = objVideoResCaseENS.id_VideoResCaseType; //视频资源类型流水号
objVideoResCaseENT.VideoResCaseText = objVideoResCaseENS.VideoResCaseText; //案例文本内容
objVideoResCaseENT.VideoResCaseDate = objVideoResCaseENS.VideoResCaseDate; //视频资源日期
objVideoResCaseENT.VideoResCaseTime = objVideoResCaseENS.VideoResCaseTime; //视频资源时间
objVideoResCaseENT.VideoResCaseDateIn = objVideoResCaseENS.VideoResCaseDateIn; //案例入库日期
objVideoResCaseENT.VideoResCaseTimeIn = objVideoResCaseENS.VideoResCaseTimeIn; //案例入库时间
objVideoResCaseENT.OwnerId = objVideoResCaseENS.OwnerId; //拥有者Id
objVideoResCaseENT.id_StudyLevel = objVideoResCaseENS.id_StudyLevel; //id_StudyLevel
objVideoResCaseENT.id_TeachingPlan = objVideoResCaseENS.id_TeachingPlan; //教案流水号
objVideoResCaseENT.id_Discipline = objVideoResCaseENS.id_Discipline; //学科流水号
objVideoResCaseENT.BrowseCount = objVideoResCaseENS.BrowseCount; //浏览次数
objVideoResCaseENT.id_SenateGaugeVersion = objVideoResCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objVideoResCaseENT.id_TeachSkill = objVideoResCaseENS.id_TeachSkill; //教学技能流水号
objVideoResCaseENT.CaseLevelId = objVideoResCaseENS.CaseLevelId; //课例等级Id
objVideoResCaseENT.DocFile = objVideoResCaseENS.DocFile; //生成的Word文件名
objVideoResCaseENT.IsNeedGeneWord = objVideoResCaseENS.IsNeedGeneWord; //是否需要生成Word
objVideoResCaseENT.WordCreateDate = objVideoResCaseENS.WordCreateDate; //Word生成日期
objVideoResCaseENT.IsVisible = objVideoResCaseENS.IsVisible; //是否显示
objVideoResCaseENT.IsDualVideo = objVideoResCaseENS.IsDualVideo; //是否双视频
objVideoResCaseENT.id_XzCollege = objVideoResCaseENS.id_XzCollege; //学院流水号
objVideoResCaseENT.id_XzMajor = objVideoResCaseENS.id_XzMajor; //专业流水号
objVideoResCaseENT.CourseChapterId = objVideoResCaseENS.CourseChapterId; //课程章节ID
objVideoResCaseENT.ViewCount = objVideoResCaseENS.ViewCount; //浏览量
objVideoResCaseENT.IsShow = objVideoResCaseENS.IsShow; //是否启用
objVideoResCaseENT.DownloadNumber = objVideoResCaseENS.DownloadNumber; //下载数目
objVideoResCaseENT.FileIntegration = objVideoResCaseENS.FileIntegration; //文件积分
objVideoResCaseENT.LikeCount = objVideoResCaseENS.LikeCount; //资源喜欢数量
objVideoResCaseENT.CollectionCount = objVideoResCaseENS.CollectionCount; //收藏数量
objVideoResCaseENT.RecommendedDegreeId = objVideoResCaseENS.RecommendedDegreeId; //推荐度Id
objVideoResCaseENT.ftpFileType = objVideoResCaseENS.ftpFileType; //ftp文件类型
objVideoResCaseENT.CourseId = objVideoResCaseENS.CourseId; //课程Id
objVideoResCaseENT.VideoUrl = objVideoResCaseENS.VideoUrl; //视频Url
objVideoResCaseENT.VideoPath = objVideoResCaseENS.VideoPath; //视频目录
objVideoResCaseENT.ResErrMsg = objVideoResCaseENS.ResErrMsg; //资源错误信息
objVideoResCaseENT.UpdDate = objVideoResCaseENS.UpdDate; //修改日期
objVideoResCaseENT.UpdUserId = objVideoResCaseENS.UpdUserId; //修改用户Id
objVideoResCaseENT.Memo = objVideoResCaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsVideoResCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsVideoResCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsVideoResCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsVideoResCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsVideoResCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsVideoResCaseEN.AttributeName)
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
if (clsVideoResCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoResCaseWApi没有刷新缓存机制(clsVideoResCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_VideoResCase");
//if (arrVideoResCaseObjLst_Cache == null)
//{
//arrVideoResCaseObjLst_Cache = await clsVideoResCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsVideoResCaseEN._CurrTabName_S);
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
if (clsVideoResCaseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsVideoResCaseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsVideoResCaseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsVideoResCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsVideoResCaseEN._CurrTabName_S);
List<clsVideoResCaseEN> arrVideoResCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrVideoResCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsVideoResCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conVideoResCase.Id_VideoResCase, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.VideoResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.VideoResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.VideoResCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.id_VideoResCaseType, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.VideoResCaseText, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.VideoResCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.VideoResCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.VideoResCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.VideoResCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conVideoResCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(conVideoResCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conVideoResCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conVideoResCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conVideoResCase.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(conVideoResCase.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(conVideoResCase.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(conVideoResCase.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(conVideoResCase.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(conVideoResCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conVideoResCase.Memo, Type.GetType("System.String"));
foreach (clsVideoResCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conVideoResCase.Id_VideoResCase] = objInFor[conVideoResCase.Id_VideoResCase];
objDR[conVideoResCase.VideoResCaseID] = objInFor[conVideoResCase.VideoResCaseID];
objDR[conVideoResCase.VideoResCaseName] = objInFor[conVideoResCase.VideoResCaseName];
objDR[conVideoResCase.VideoResCaseTheme] = objInFor[conVideoResCase.VideoResCaseTheme];
objDR[conVideoResCase.id_VideoResCaseType] = objInFor[conVideoResCase.id_VideoResCaseType];
objDR[conVideoResCase.VideoResCaseText] = objInFor[conVideoResCase.VideoResCaseText];
objDR[conVideoResCase.VideoResCaseDate] = objInFor[conVideoResCase.VideoResCaseDate];
objDR[conVideoResCase.VideoResCaseTime] = objInFor[conVideoResCase.VideoResCaseTime];
objDR[conVideoResCase.VideoResCaseDateIn] = objInFor[conVideoResCase.VideoResCaseDateIn];
objDR[conVideoResCase.VideoResCaseTimeIn] = objInFor[conVideoResCase.VideoResCaseTimeIn];
objDR[conVideoResCase.OwnerId] = objInFor[conVideoResCase.OwnerId];
objDR[conVideoResCase.id_StudyLevel] = objInFor[conVideoResCase.id_StudyLevel];
objDR[conVideoResCase.id_TeachingPlan] = objInFor[conVideoResCase.id_TeachingPlan];
objDR[conVideoResCase.id_Discipline] = objInFor[conVideoResCase.id_Discipline];
objDR[conVideoResCase.BrowseCount] = objInFor[conVideoResCase.BrowseCount];
objDR[conVideoResCase.id_SenateGaugeVersion] = objInFor[conVideoResCase.id_SenateGaugeVersion];
objDR[conVideoResCase.id_TeachSkill] = objInFor[conVideoResCase.id_TeachSkill];
objDR[conVideoResCase.CaseLevelId] = objInFor[conVideoResCase.CaseLevelId];
objDR[conVideoResCase.DocFile] = objInFor[conVideoResCase.DocFile];
objDR[conVideoResCase.IsNeedGeneWord] = objInFor[conVideoResCase.IsNeedGeneWord];
objDR[conVideoResCase.WordCreateDate] = objInFor[conVideoResCase.WordCreateDate];
objDR[conVideoResCase.IsVisible] = objInFor[conVideoResCase.IsVisible];
objDR[conVideoResCase.IsDualVideo] = objInFor[conVideoResCase.IsDualVideo];
objDR[conVideoResCase.id_XzCollege] = objInFor[conVideoResCase.id_XzCollege];
objDR[conVideoResCase.id_XzMajor] = objInFor[conVideoResCase.id_XzMajor];
objDR[conVideoResCase.CourseChapterId] = objInFor[conVideoResCase.CourseChapterId];
objDR[conVideoResCase.ViewCount] = objInFor[conVideoResCase.ViewCount];
objDR[conVideoResCase.IsShow] = objInFor[conVideoResCase.IsShow];
objDR[conVideoResCase.DownloadNumber] = objInFor[conVideoResCase.DownloadNumber];
objDR[conVideoResCase.FileIntegration] = objInFor[conVideoResCase.FileIntegration];
objDR[conVideoResCase.LikeCount] = objInFor[conVideoResCase.LikeCount];
objDR[conVideoResCase.CollectionCount] = objInFor[conVideoResCase.CollectionCount];
objDR[conVideoResCase.RecommendedDegreeId] = objInFor[conVideoResCase.RecommendedDegreeId];
objDR[conVideoResCase.ftpFileType] = objInFor[conVideoResCase.ftpFileType];
objDR[conVideoResCase.CourseId] = objInFor[conVideoResCase.CourseId];
objDR[conVideoResCase.VideoUrl] = objInFor[conVideoResCase.VideoUrl];
objDR[conVideoResCase.VideoPath] = objInFor[conVideoResCase.VideoPath];
objDR[conVideoResCase.ResErrMsg] = objInFor[conVideoResCase.ResErrMsg];
objDR[conVideoResCase.UpdDate] = objInFor[conVideoResCase.UpdDate];
objDR[conVideoResCase.UpdUserId] = objInFor[conVideoResCase.UpdUserId];
objDR[conVideoResCase.Memo] = objInFor[conVideoResCase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 视频资源案例(VideoResCase)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4VideoResCase : clsCommFun4BL
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
clsVideoResCaseWApi.ReFreshThisCache();
}
}

}