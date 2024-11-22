
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoResCase_BaseWApi
 表名:vVideoResCase_Base(01120527)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:08
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
public static class clsvVideoResCase_BaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetId_VideoResCase(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strId_VideoResCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_VideoResCase, 8, convVideoResCase_Base.Id_VideoResCase);
clsCheckSql.CheckFieldForeignKey(strId_VideoResCase, 8, convVideoResCase_Base.Id_VideoResCase);
objvVideoResCase_BaseEN.Id_VideoResCase = strId_VideoResCase; //视频资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.Id_VideoResCase) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.Id_VideoResCase, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.Id_VideoResCase] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetVideoResCaseID(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strVideoResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoResCaseID, convVideoResCase_Base.VideoResCaseID);
clsCheckSql.CheckFieldLen(strVideoResCaseID, 8, convVideoResCase_Base.VideoResCaseID);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseID, 8, convVideoResCase_Base.VideoResCaseID);
objvVideoResCase_BaseEN.VideoResCaseID = strVideoResCaseID; //视频资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.VideoResCaseID) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.VideoResCaseID, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseID] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetVideoResCaseName(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strVideoResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoResCaseName, convVideoResCase_Base.VideoResCaseName);
clsCheckSql.CheckFieldLen(strVideoResCaseName, 100, convVideoResCase_Base.VideoResCaseName);
objvVideoResCase_BaseEN.VideoResCaseName = strVideoResCaseName; //视频资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.VideoResCaseName) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.VideoResCaseName, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseName] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetVideoResCaseTheme(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strVideoResCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTheme, 200, convVideoResCase_Base.VideoResCaseTheme);
objvVideoResCase_BaseEN.VideoResCaseTheme = strVideoResCaseTheme; //视频资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.VideoResCaseTheme) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.VideoResCaseTheme, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseTheme] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN Setid_VideoResCaseType(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strid_VideoResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_VideoResCaseType, convVideoResCase_Base.id_VideoResCaseType);
clsCheckSql.CheckFieldLen(strid_VideoResCaseType, 4, convVideoResCase_Base.id_VideoResCaseType);
clsCheckSql.CheckFieldForeignKey(strid_VideoResCaseType, 4, convVideoResCase_Base.id_VideoResCaseType);
objvVideoResCase_BaseEN.id_VideoResCaseType = strid_VideoResCaseType; //视频资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.id_VideoResCaseType) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.id_VideoResCaseType, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.id_VideoResCaseType] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetVideoResCaseTypeName(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strVideoResCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTypeName, 30, convVideoResCase_Base.VideoResCaseTypeName);
objvVideoResCase_BaseEN.VideoResCaseTypeName = strVideoResCaseTypeName; //视频资源案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.VideoResCaseTypeName) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.VideoResCaseTypeName, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseTypeName] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetVideoResCaseText(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strVideoResCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseText, 8000, convVideoResCase_Base.VideoResCaseText);
objvVideoResCase_BaseEN.VideoResCaseText = strVideoResCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.VideoResCaseText) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.VideoResCaseText, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseText] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetVideoResCaseDate(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strVideoResCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseDate, 8, convVideoResCase_Base.VideoResCaseDate);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseDate, 8, convVideoResCase_Base.VideoResCaseDate);
objvVideoResCase_BaseEN.VideoResCaseDate = strVideoResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.VideoResCaseDate) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.VideoResCaseDate, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseDate] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetVideoResCaseTime(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strVideoResCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTime, 6, convVideoResCase_Base.VideoResCaseTime);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseTime, 6, convVideoResCase_Base.VideoResCaseTime);
objvVideoResCase_BaseEN.VideoResCaseTime = strVideoResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.VideoResCaseTime) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.VideoResCaseTime, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseTime] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetVideoResCaseDateIn(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strVideoResCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseDateIn, 8, convVideoResCase_Base.VideoResCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseDateIn, 8, convVideoResCase_Base.VideoResCaseDateIn);
objvVideoResCase_BaseEN.VideoResCaseDateIn = strVideoResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.VideoResCaseDateIn) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.VideoResCaseDateIn, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseDateIn] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetVideoResCaseTimeIn(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strVideoResCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTimeIn, 6, convVideoResCase_Base.VideoResCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseTimeIn, 6, convVideoResCase_Base.VideoResCaseTimeIn);
objvVideoResCase_BaseEN.VideoResCaseTimeIn = strVideoResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.VideoResCaseTimeIn) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.VideoResCaseTimeIn, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseTimeIn] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetOwnerId(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convVideoResCase_Base.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convVideoResCase_Base.OwnerId);
objvVideoResCase_BaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.OwnerId) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.OwnerId, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.OwnerId] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN Setid_StudyLevel(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convVideoResCase_Base.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convVideoResCase_Base.id_StudyLevel);
objvVideoResCase_BaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.id_StudyLevel) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.id_StudyLevel, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.id_StudyLevel] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetStudyLevelName(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convVideoResCase_Base.StudyLevelName);
objvVideoResCase_BaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.StudyLevelName) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.StudyLevelName, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.StudyLevelName] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN Setid_TeachingPlan(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convVideoResCase_Base.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convVideoResCase_Base.id_TeachingPlan);
objvVideoResCase_BaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.id_TeachingPlan) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.id_TeachingPlan, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.id_TeachingPlan] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN Setid_Discipline(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convVideoResCase_Base.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convVideoResCase_Base.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convVideoResCase_Base.id_Discipline);
objvVideoResCase_BaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.id_Discipline) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.id_Discipline, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.id_Discipline] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetDisciplineID(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convVideoResCase_Base.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convVideoResCase_Base.DisciplineID);
objvVideoResCase_BaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.DisciplineID) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.DisciplineID, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.DisciplineID] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetDisciplineName(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convVideoResCase_Base.DisciplineName);
objvVideoResCase_BaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.DisciplineName) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.DisciplineName, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.DisciplineName] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN Setid_SenateGaugeVersion(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convVideoResCase_Base.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convVideoResCase_Base.id_SenateGaugeVersion);
objvVideoResCase_BaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.id_SenateGaugeVersion) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetsenateGaugeVersionID(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convVideoResCase_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convVideoResCase_Base.senateGaugeVersionID);
objvVideoResCase_BaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.senateGaugeVersionID) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.senateGaugeVersionID, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.senateGaugeVersionID] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetsenateGaugeVersionName(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convVideoResCase_Base.senateGaugeVersionName);
objvVideoResCase_BaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.senateGaugeVersionName) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.senateGaugeVersionName, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.senateGaugeVersionName] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetsenateGaugeVersionTtlScore(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvVideoResCase_BaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.senateGaugeVersionTtlScore) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetVersionNo(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, int intVersionNo, string strComparisonOp="")
	{
objvVideoResCase_BaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.VersionNo) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.VersionNo, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.VersionNo] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN Setid_TeachSkill(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convVideoResCase_Base.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convVideoResCase_Base.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convVideoResCase_Base.id_TeachSkill);
objvVideoResCase_BaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.id_TeachSkill) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.id_TeachSkill, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.id_TeachSkill] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetTeachSkillID(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convVideoResCase_Base.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convVideoResCase_Base.TeachSkillID);
objvVideoResCase_BaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.TeachSkillID) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.TeachSkillID, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.TeachSkillID] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetSkillTypeName(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convVideoResCase_Base.SkillTypeName);
objvVideoResCase_BaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.SkillTypeName) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.SkillTypeName, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.SkillTypeName] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetTeachSkillName(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convVideoResCase_Base.TeachSkillName);
objvVideoResCase_BaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.TeachSkillName) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.TeachSkillName, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.TeachSkillName] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetTeachSkillTheory(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convVideoResCase_Base.TeachSkillTheory);
objvVideoResCase_BaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.TeachSkillTheory) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.TeachSkillTheory, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.TeachSkillTheory] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetTeachSkillOperMethod(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convVideoResCase_Base.TeachSkillOperMethod);
objvVideoResCase_BaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.TeachSkillOperMethod) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN Setid_SkillType(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convVideoResCase_Base.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convVideoResCase_Base.id_SkillType);
objvVideoResCase_BaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.id_SkillType) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.id_SkillType, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.id_SkillType] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetSkillTypeID(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convVideoResCase_Base.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convVideoResCase_Base.SkillTypeID);
objvVideoResCase_BaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.SkillTypeID) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.SkillTypeID, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.SkillTypeID] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetCaseLevelId(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convVideoResCase_Base.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convVideoResCase_Base.CaseLevelId);
objvVideoResCase_BaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.CaseLevelId) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.CaseLevelId, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.CaseLevelId] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetCaseLevelName(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convVideoResCase_Base.CaseLevelName);
objvVideoResCase_BaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.CaseLevelName) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.CaseLevelName, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.CaseLevelName] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetDocFile(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convVideoResCase_Base.DocFile);
objvVideoResCase_BaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.DocFile) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.DocFile, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.DocFile] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetIsNeedGeneWord(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvVideoResCase_BaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.IsNeedGeneWord) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.IsNeedGeneWord, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.IsNeedGeneWord] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetWordCreateDate(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convVideoResCase_Base.WordCreateDate);
objvVideoResCase_BaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.WordCreateDate) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.WordCreateDate, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.WordCreateDate] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetIsVisible(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvVideoResCase_BaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.IsVisible) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.IsVisible, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.IsVisible] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetIsDualVideo(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvVideoResCase_BaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.IsDualVideo) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.IsDualVideo, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.IsDualVideo] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN Setid_XzCollege(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, convVideoResCase_Base.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convVideoResCase_Base.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convVideoResCase_Base.id_XzCollege);
objvVideoResCase_BaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.id_XzCollege) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.id_XzCollege, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.id_XzCollege] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetCollegeID(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoResCase_Base.CollegeID);
objvVideoResCase_BaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.CollegeID) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.CollegeID, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.CollegeID] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetCollegeName(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoResCase_Base.CollegeName);
objvVideoResCase_BaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.CollegeName) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.CollegeName, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.CollegeName] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetCollegeNameA(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoResCase_Base.CollegeNameA);
objvVideoResCase_BaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.CollegeNameA) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.CollegeNameA, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.CollegeNameA] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN Setid_XzMajor(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convVideoResCase_Base.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convVideoResCase_Base.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convVideoResCase_Base.id_XzMajor);
objvVideoResCase_BaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.id_XzMajor) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.id_XzMajor, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.id_XzMajor] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetMajorID(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convVideoResCase_Base.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convVideoResCase_Base.MajorID);
objvVideoResCase_BaseEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.MajorID) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.MajorID, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.MajorID] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetMajorName(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convVideoResCase_Base.MajorName);
objvVideoResCase_BaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.MajorName) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.MajorName, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.MajorName] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetCourseChapterId(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convVideoResCase_Base.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convVideoResCase_Base.CourseChapterId);
objvVideoResCase_BaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.CourseChapterId) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.CourseChapterId, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.CourseChapterId] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetCourseChapterName(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convVideoResCase_Base.CourseChapterName);
objvVideoResCase_BaseEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.CourseChapterName) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.CourseChapterName, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.CourseChapterName] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetParentNodeID(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convVideoResCase_Base.ParentNodeID);
objvVideoResCase_BaseEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.ParentNodeID) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.ParentNodeID, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.ParentNodeID] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetParentNodeName(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convVideoResCase_Base.ParentNodeName);
objvVideoResCase_BaseEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.ParentNodeName) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.ParentNodeName, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.ParentNodeName] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetViewCount(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, int intViewCount, string strComparisonOp="")
	{
objvVideoResCase_BaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.ViewCount) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.ViewCount, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.ViewCount] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetIsShow(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, bool bolIsShow, string strComparisonOp="")
	{
objvVideoResCase_BaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.IsShow) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.IsShow, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.IsShow] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetDownloadNumber(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, int intDownloadNumber, string strComparisonOp="")
	{
objvVideoResCase_BaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.DownloadNumber) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.DownloadNumber, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.DownloadNumber] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetFileIntegration(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, int intFileIntegration, string strComparisonOp="")
	{
objvVideoResCase_BaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.FileIntegration) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.FileIntegration, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.FileIntegration] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetLikeCount(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, long lngLikeCount, string strComparisonOp="")
	{
objvVideoResCase_BaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.LikeCount) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.LikeCount, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.LikeCount] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetCollectionCount(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, long lngCollectionCount, string strComparisonOp="")
	{
objvVideoResCase_BaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.CollectionCount) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.CollectionCount, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.CollectionCount] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetRecommendedDegreeId(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convVideoResCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convVideoResCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convVideoResCase_Base.RecommendedDegreeId);
objvVideoResCase_BaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.RecommendedDegreeId) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.RecommendedDegreeId, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.RecommendedDegreeId] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetRecommendedDegreeName(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convVideoResCase_Base.RecommendedDegreeName);
objvVideoResCase_BaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.RecommendedDegreeName) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.RecommendedDegreeName, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.RecommendedDegreeName] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetftpFileType(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convVideoResCase_Base.ftpFileType);
objvVideoResCase_BaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.ftpFileType) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.ftpFileType, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.ftpFileType] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetCourseId(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convVideoResCase_Base.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoResCase_Base.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoResCase_Base.CourseId);
objvVideoResCase_BaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.CourseId) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.CourseId, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.CourseId] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetCourseCode(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoResCase_Base.CourseCode);
objvVideoResCase_BaseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.CourseCode) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.CourseCode, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.CourseCode] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetCourseName(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoResCase_Base.CourseName);
objvVideoResCase_BaseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.CourseName) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.CourseName, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.CourseName] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetVideoUrl(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convVideoResCase_Base.VideoUrl);
objvVideoResCase_BaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.VideoUrl) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.VideoUrl, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.VideoUrl] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetVideoPath(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convVideoResCase_Base.VideoPath);
objvVideoResCase_BaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.VideoPath) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.VideoPath, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.VideoPath] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetResErrMsg(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convVideoResCase_Base.ResErrMsg);
objvVideoResCase_BaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.ResErrMsg) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.ResErrMsg, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.ResErrMsg] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetMemo(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoResCase_Base.Memo);
objvVideoResCase_BaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.Memo) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.Memo, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.Memo] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetOwnerName(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convVideoResCase_Base.OwnerName);
objvVideoResCase_BaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.OwnerName) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.OwnerName, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.OwnerName] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetOwnerNameWithId(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convVideoResCase_Base.OwnerNameWithId);
objvVideoResCase_BaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.OwnerNameWithId) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.OwnerNameWithId, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.OwnerNameWithId] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCase_BaseEN SetBrowseCount4Case(this clsvVideoResCase_BaseEN objvVideoResCase_BaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvVideoResCase_BaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCase_BaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase_Base.BrowseCount4Case) == false)
{
objvVideoResCase_BaseEN.dicFldComparisonOp.Add(convVideoResCase_Base.BrowseCount4Case, strComparisonOp);
}
else
{
objvVideoResCase_BaseEN.dicFldComparisonOp[convVideoResCase_Base.BrowseCount4Case] = strComparisonOp;
}
}
return objvVideoResCase_BaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoResCase_BaseEN objvVideoResCase_Base_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.Id_VideoResCase) == true)
{
string strComparisonOp_Id_VideoResCase = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.Id_VideoResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.Id_VideoResCase, objvVideoResCase_Base_Cond.Id_VideoResCase, strComparisonOp_Id_VideoResCase);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.VideoResCaseID) == true)
{
string strComparisonOp_VideoResCaseID = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.VideoResCaseID, objvVideoResCase_Base_Cond.VideoResCaseID, strComparisonOp_VideoResCaseID);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.VideoResCaseName) == true)
{
string strComparisonOp_VideoResCaseName = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.VideoResCaseName, objvVideoResCase_Base_Cond.VideoResCaseName, strComparisonOp_VideoResCaseName);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.VideoResCaseTheme) == true)
{
string strComparisonOp_VideoResCaseTheme = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.VideoResCaseTheme, objvVideoResCase_Base_Cond.VideoResCaseTheme, strComparisonOp_VideoResCaseTheme);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.id_VideoResCaseType) == true)
{
string strComparisonOp_id_VideoResCaseType = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.id_VideoResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.id_VideoResCaseType, objvVideoResCase_Base_Cond.id_VideoResCaseType, strComparisonOp_id_VideoResCaseType);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.VideoResCaseTypeName) == true)
{
string strComparisonOp_VideoResCaseTypeName = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.VideoResCaseTypeName, objvVideoResCase_Base_Cond.VideoResCaseTypeName, strComparisonOp_VideoResCaseTypeName);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.VideoResCaseText) == true)
{
string strComparisonOp_VideoResCaseText = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.VideoResCaseText, objvVideoResCase_Base_Cond.VideoResCaseText, strComparisonOp_VideoResCaseText);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.VideoResCaseDate) == true)
{
string strComparisonOp_VideoResCaseDate = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.VideoResCaseDate, objvVideoResCase_Base_Cond.VideoResCaseDate, strComparisonOp_VideoResCaseDate);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.VideoResCaseTime) == true)
{
string strComparisonOp_VideoResCaseTime = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.VideoResCaseTime, objvVideoResCase_Base_Cond.VideoResCaseTime, strComparisonOp_VideoResCaseTime);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.VideoResCaseDateIn) == true)
{
string strComparisonOp_VideoResCaseDateIn = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.VideoResCaseDateIn, objvVideoResCase_Base_Cond.VideoResCaseDateIn, strComparisonOp_VideoResCaseDateIn);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.VideoResCaseTimeIn) == true)
{
string strComparisonOp_VideoResCaseTimeIn = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.VideoResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.VideoResCaseTimeIn, objvVideoResCase_Base_Cond.VideoResCaseTimeIn, strComparisonOp_VideoResCaseTimeIn);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.OwnerId, objvVideoResCase_Base_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.id_StudyLevel, objvVideoResCase_Base_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.StudyLevelName, objvVideoResCase_Base_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.id_TeachingPlan, objvVideoResCase_Base_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.id_Discipline, objvVideoResCase_Base_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.DisciplineID, objvVideoResCase_Base_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.DisciplineName, objvVideoResCase_Base_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.id_SenateGaugeVersion, objvVideoResCase_Base_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.senateGaugeVersionID, objvVideoResCase_Base_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.senateGaugeVersionName, objvVideoResCase_Base_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Base.senateGaugeVersionTtlScore, objvVideoResCase_Base_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Base.VersionNo, objvVideoResCase_Base_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.id_TeachSkill, objvVideoResCase_Base_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.TeachSkillID, objvVideoResCase_Base_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.SkillTypeName, objvVideoResCase_Base_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.TeachSkillName, objvVideoResCase_Base_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.TeachSkillTheory, objvVideoResCase_Base_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.TeachSkillOperMethod, objvVideoResCase_Base_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.id_SkillType, objvVideoResCase_Base_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.SkillTypeID, objvVideoResCase_Base_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.CaseLevelId, objvVideoResCase_Base_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.CaseLevelName, objvVideoResCase_Base_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.DocFile) == true)
{
string strComparisonOp_DocFile = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.DocFile, objvVideoResCase_Base_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.IsNeedGeneWord) == true)
{
if (objvVideoResCase_Base_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCase_Base.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCase_Base.IsNeedGeneWord);
}
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.WordCreateDate, objvVideoResCase_Base_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.IsVisible) == true)
{
if (objvVideoResCase_Base_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCase_Base.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCase_Base.IsVisible);
}
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.IsDualVideo) == true)
{
if (objvVideoResCase_Base_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCase_Base.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCase_Base.IsDualVideo);
}
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.id_XzCollege, objvVideoResCase_Base_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.CollegeID, objvVideoResCase_Base_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.CollegeName, objvVideoResCase_Base_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.CollegeNameA, objvVideoResCase_Base_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.id_XzMajor, objvVideoResCase_Base_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.MajorID) == true)
{
string strComparisonOp_MajorID = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.MajorID, objvVideoResCase_Base_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.MajorName) == true)
{
string strComparisonOp_MajorName = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.MajorName, objvVideoResCase_Base_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.CourseChapterId, objvVideoResCase_Base_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.CourseChapterName, objvVideoResCase_Base_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.ParentNodeID, objvVideoResCase_Base_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.ParentNodeName, objvVideoResCase_Base_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Base.ViewCount, objvVideoResCase_Base_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.IsShow) == true)
{
if (objvVideoResCase_Base_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCase_Base.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCase_Base.IsShow);
}
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Base.DownloadNumber, objvVideoResCase_Base_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Base.FileIntegration, objvVideoResCase_Base_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Base.LikeCount, objvVideoResCase_Base_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Base.CollectionCount, objvVideoResCase_Base_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.RecommendedDegreeId, objvVideoResCase_Base_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.RecommendedDegreeName, objvVideoResCase_Base_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.ftpFileType, objvVideoResCase_Base_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.CourseId) == true)
{
string strComparisonOp_CourseId = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.CourseId, objvVideoResCase_Base_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.CourseCode, objvVideoResCase_Base_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.CourseName) == true)
{
string strComparisonOp_CourseName = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.CourseName, objvVideoResCase_Base_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.VideoUrl, objvVideoResCase_Base_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.VideoPath, objvVideoResCase_Base_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.ResErrMsg, objvVideoResCase_Base_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.Memo) == true)
{
string strComparisonOp_Memo = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.Memo, objvVideoResCase_Base_Cond.Memo, strComparisonOp_Memo);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.OwnerName, objvVideoResCase_Base_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase_Base.OwnerNameWithId, objvVideoResCase_Base_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvVideoResCase_Base_Cond.IsUpdated(convVideoResCase_Base.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvVideoResCase_Base_Cond.dicFldComparisonOp[convVideoResCase_Base.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase_Base.BrowseCount4Case, objvVideoResCase_Base_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频资源案例_Base(vVideoResCase_Base)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoResCase_BaseWApi
{
private static readonly string mstrApiControllerName = "vVideoResCase_BaseApi";

 public clsvVideoResCase_BaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_VideoResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoResCase_BaseEN GetObjById_VideoResCase(string strId_VideoResCase)
{
string strAction = "GetObjById_VideoResCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCase_BaseEN objvVideoResCase_BaseEN = null;
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
objvVideoResCase_BaseEN = JsonConvert.DeserializeObject<clsvVideoResCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCase_BaseEN;
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
public static clsvVideoResCase_BaseEN GetObjById_VideoResCase_WA_Cache(string strId_VideoResCase)
{
string strAction = "GetObjById_VideoResCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCase_BaseEN objvVideoResCase_BaseEN = null;
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
objvVideoResCase_BaseEN = JsonConvert.DeserializeObject<clsvVideoResCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCase_BaseEN;
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
public static clsvVideoResCase_BaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCase_BaseEN objvVideoResCase_BaseEN = null;
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
objvVideoResCase_BaseEN = JsonConvert.DeserializeObject<clsvVideoResCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCase_BaseEN;
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
public static clsvVideoResCase_BaseEN GetObjById_VideoResCase_Cache(string strId_VideoResCase)
{
if (string.IsNullOrEmpty(strId_VideoResCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoResCase_BaseEN._CurrTabName_S);
List<clsvVideoResCase_BaseEN> arrvVideoResCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoResCase_BaseEN> arrvVideoResCase_BaseObjLst_Sel =
from objvVideoResCase_BaseEN in arrvVideoResCase_BaseObjLst_Cache
where objvVideoResCase_BaseEN.Id_VideoResCase == strId_VideoResCase
select objvVideoResCase_BaseEN;
if (arrvVideoResCase_BaseObjLst_Sel.Count() == 0)
{
   clsvVideoResCase_BaseEN obj = clsvVideoResCase_BaseWApi.GetObjById_VideoResCase(strId_VideoResCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoResCase_BaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoResCase_BaseEN> GetObjLst(string strWhereCond)
{
 List<clsvVideoResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCase_BaseEN> GetObjLstById_VideoResCaseLst(List<string> arrId_VideoResCase)
{
 List<clsvVideoResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvVideoResCase_BaseEN> GetObjLstById_VideoResCaseLst_Cache(List<string> arrId_VideoResCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoResCase_BaseEN._CurrTabName_S);
List<clsvVideoResCase_BaseEN> arrvVideoResCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoResCase_BaseEN> arrvVideoResCase_BaseObjLst_Sel =
from objvVideoResCase_BaseEN in arrvVideoResCase_BaseObjLst_Cache
where arrId_VideoResCase.Contains(objvVideoResCase_BaseEN.Id_VideoResCase)
select objvVideoResCase_BaseEN;
return arrvVideoResCase_BaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoResCase_BaseEN> GetObjLstById_VideoResCaseLst_WA_Cache(List<string> arrId_VideoResCase)
{
 List<clsvVideoResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCase_BaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCase_BaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCase_BaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCase_BaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseENS">源对象</param>
 /// <param name = "objvVideoResCase_BaseENT">目标对象</param>
 public static void CopyTo(clsvVideoResCase_BaseEN objvVideoResCase_BaseENS, clsvVideoResCase_BaseEN objvVideoResCase_BaseENT)
{
try
{
objvVideoResCase_BaseENT.Id_VideoResCase = objvVideoResCase_BaseENS.Id_VideoResCase; //视频资源案例流水号
objvVideoResCase_BaseENT.VideoResCaseID = objvVideoResCase_BaseENS.VideoResCaseID; //视频资源案例ID
objvVideoResCase_BaseENT.VideoResCaseName = objvVideoResCase_BaseENS.VideoResCaseName; //视频资源案例名称
objvVideoResCase_BaseENT.VideoResCaseTheme = objvVideoResCase_BaseENS.VideoResCaseTheme; //视频资源案例主题词
objvVideoResCase_BaseENT.id_VideoResCaseType = objvVideoResCase_BaseENS.id_VideoResCaseType; //视频资源类型流水号
objvVideoResCase_BaseENT.VideoResCaseTypeName = objvVideoResCase_BaseENS.VideoResCaseTypeName; //视频资源案例类型名称
objvVideoResCase_BaseENT.VideoResCaseText = objvVideoResCase_BaseENS.VideoResCaseText; //案例文本内容
objvVideoResCase_BaseENT.VideoResCaseDate = objvVideoResCase_BaseENS.VideoResCaseDate; //视频资源日期
objvVideoResCase_BaseENT.VideoResCaseTime = objvVideoResCase_BaseENS.VideoResCaseTime; //视频资源时间
objvVideoResCase_BaseENT.VideoResCaseDateIn = objvVideoResCase_BaseENS.VideoResCaseDateIn; //案例入库日期
objvVideoResCase_BaseENT.VideoResCaseTimeIn = objvVideoResCase_BaseENS.VideoResCaseTimeIn; //案例入库时间
objvVideoResCase_BaseENT.OwnerId = objvVideoResCase_BaseENS.OwnerId; //拥有者Id
objvVideoResCase_BaseENT.id_StudyLevel = objvVideoResCase_BaseENS.id_StudyLevel; //id_StudyLevel
objvVideoResCase_BaseENT.StudyLevelName = objvVideoResCase_BaseENS.StudyLevelName; //学段名称
objvVideoResCase_BaseENT.id_TeachingPlan = objvVideoResCase_BaseENS.id_TeachingPlan; //教案流水号
objvVideoResCase_BaseENT.id_Discipline = objvVideoResCase_BaseENS.id_Discipline; //学科流水号
objvVideoResCase_BaseENT.DisciplineID = objvVideoResCase_BaseENS.DisciplineID; //学科ID
objvVideoResCase_BaseENT.DisciplineName = objvVideoResCase_BaseENS.DisciplineName; //学科名称
objvVideoResCase_BaseENT.id_SenateGaugeVersion = objvVideoResCase_BaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvVideoResCase_BaseENT.senateGaugeVersionID = objvVideoResCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvVideoResCase_BaseENT.senateGaugeVersionName = objvVideoResCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvVideoResCase_BaseENT.senateGaugeVersionTtlScore = objvVideoResCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoResCase_BaseENT.VersionNo = objvVideoResCase_BaseENS.VersionNo; //版本号
objvVideoResCase_BaseENT.id_TeachSkill = objvVideoResCase_BaseENS.id_TeachSkill; //教学技能流水号
objvVideoResCase_BaseENT.TeachSkillID = objvVideoResCase_BaseENS.TeachSkillID; //教学技能ID
objvVideoResCase_BaseENT.SkillTypeName = objvVideoResCase_BaseENS.SkillTypeName; //技能类型名称
objvVideoResCase_BaseENT.TeachSkillName = objvVideoResCase_BaseENS.TeachSkillName; //教学技能名称
objvVideoResCase_BaseENT.TeachSkillTheory = objvVideoResCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvVideoResCase_BaseENT.TeachSkillOperMethod = objvVideoResCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvVideoResCase_BaseENT.id_SkillType = objvVideoResCase_BaseENS.id_SkillType; //技能类型流水号
objvVideoResCase_BaseENT.SkillTypeID = objvVideoResCase_BaseENS.SkillTypeID; //技能类型ID
objvVideoResCase_BaseENT.CaseLevelId = objvVideoResCase_BaseENS.CaseLevelId; //课例等级Id
objvVideoResCase_BaseENT.CaseLevelName = objvVideoResCase_BaseENS.CaseLevelName; //案例等级名称
objvVideoResCase_BaseENT.DocFile = objvVideoResCase_BaseENS.DocFile; //生成的Word文件名
objvVideoResCase_BaseENT.IsNeedGeneWord = objvVideoResCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvVideoResCase_BaseENT.WordCreateDate = objvVideoResCase_BaseENS.WordCreateDate; //Word生成日期
objvVideoResCase_BaseENT.IsVisible = objvVideoResCase_BaseENS.IsVisible; //是否显示
objvVideoResCase_BaseENT.IsDualVideo = objvVideoResCase_BaseENS.IsDualVideo; //是否双视频
objvVideoResCase_BaseENT.id_XzCollege = objvVideoResCase_BaseENS.id_XzCollege; //学院流水号
objvVideoResCase_BaseENT.CollegeID = objvVideoResCase_BaseENS.CollegeID; //学院ID
objvVideoResCase_BaseENT.CollegeName = objvVideoResCase_BaseENS.CollegeName; //学院名称
objvVideoResCase_BaseENT.CollegeNameA = objvVideoResCase_BaseENS.CollegeNameA; //学院名称简写
objvVideoResCase_BaseENT.id_XzMajor = objvVideoResCase_BaseENS.id_XzMajor; //专业流水号
objvVideoResCase_BaseENT.MajorID = objvVideoResCase_BaseENS.MajorID; //专业ID
objvVideoResCase_BaseENT.MajorName = objvVideoResCase_BaseENS.MajorName; //专业名称
objvVideoResCase_BaseENT.CourseChapterId = objvVideoResCase_BaseENS.CourseChapterId; //课程章节ID
objvVideoResCase_BaseENT.CourseChapterName = objvVideoResCase_BaseENS.CourseChapterName; //课程章节名称
objvVideoResCase_BaseENT.ParentNodeID = objvVideoResCase_BaseENS.ParentNodeID; //父节点编号
objvVideoResCase_BaseENT.ParentNodeName = objvVideoResCase_BaseENS.ParentNodeName; //父节点名称
objvVideoResCase_BaseENT.ViewCount = objvVideoResCase_BaseENS.ViewCount; //浏览量
objvVideoResCase_BaseENT.IsShow = objvVideoResCase_BaseENS.IsShow; //是否启用
objvVideoResCase_BaseENT.DownloadNumber = objvVideoResCase_BaseENS.DownloadNumber; //下载数目
objvVideoResCase_BaseENT.FileIntegration = objvVideoResCase_BaseENS.FileIntegration; //文件积分
objvVideoResCase_BaseENT.LikeCount = objvVideoResCase_BaseENS.LikeCount; //资源喜欢数量
objvVideoResCase_BaseENT.CollectionCount = objvVideoResCase_BaseENS.CollectionCount; //收藏数量
objvVideoResCase_BaseENT.RecommendedDegreeId = objvVideoResCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvVideoResCase_BaseENT.RecommendedDegreeName = objvVideoResCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvVideoResCase_BaseENT.ftpFileType = objvVideoResCase_BaseENS.ftpFileType; //ftp文件类型
objvVideoResCase_BaseENT.CourseId = objvVideoResCase_BaseENS.CourseId; //课程Id
objvVideoResCase_BaseENT.CourseCode = objvVideoResCase_BaseENS.CourseCode; //课程代码
objvVideoResCase_BaseENT.CourseName = objvVideoResCase_BaseENS.CourseName; //课程名称
objvVideoResCase_BaseENT.VideoUrl = objvVideoResCase_BaseENS.VideoUrl; //视频Url
objvVideoResCase_BaseENT.VideoPath = objvVideoResCase_BaseENS.VideoPath; //视频目录
objvVideoResCase_BaseENT.ResErrMsg = objvVideoResCase_BaseENS.ResErrMsg; //资源错误信息
objvVideoResCase_BaseENT.Memo = objvVideoResCase_BaseENS.Memo; //备注
objvVideoResCase_BaseENT.OwnerName = objvVideoResCase_BaseENS.OwnerName; //拥有者姓名
objvVideoResCase_BaseENT.OwnerNameWithId = objvVideoResCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvVideoResCase_BaseENT.BrowseCount4Case = objvVideoResCase_BaseENS.BrowseCount4Case; //课例浏览次数
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
public static DataTable ToDataTable(List<clsvVideoResCase_BaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoResCase_BaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoResCase_BaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoResCase_BaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoResCase_BaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoResCase_BaseEN.AttributeName)
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
//string strWhereCond = string.Format("1 = 1 order by Id_VideoResCase");
//if (arrvVideoResCase_BaseObjLst_Cache == null)
//{
//arrvVideoResCase_BaseObjLst_Cache = await clsvVideoResCase_BaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoResCase_BaseEN._CurrTabName_S);
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
public static List<clsvVideoResCase_BaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoResCase_BaseEN._CurrTabName_S);
List<clsvVideoResCase_BaseEN> arrvVideoResCase_BaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoResCase_BaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoResCase_BaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoResCase_Base.Id_VideoResCase, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.VideoResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.VideoResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.VideoResCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.id_VideoResCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.VideoResCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.VideoResCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.VideoResCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.VideoResCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.VideoResCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.VideoResCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoResCase_Base.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase_Base.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCase_Base.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCase_Base.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCase_Base.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase_Base.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCase_Base.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase_Base.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase_Base.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoResCase_Base.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoResCase_Base.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase_Base.BrowseCount4Case, Type.GetType("System.Int32"));
foreach (clsvVideoResCase_BaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoResCase_Base.Id_VideoResCase] = objInFor[convVideoResCase_Base.Id_VideoResCase];
objDR[convVideoResCase_Base.VideoResCaseID] = objInFor[convVideoResCase_Base.VideoResCaseID];
objDR[convVideoResCase_Base.VideoResCaseName] = objInFor[convVideoResCase_Base.VideoResCaseName];
objDR[convVideoResCase_Base.VideoResCaseTheme] = objInFor[convVideoResCase_Base.VideoResCaseTheme];
objDR[convVideoResCase_Base.id_VideoResCaseType] = objInFor[convVideoResCase_Base.id_VideoResCaseType];
objDR[convVideoResCase_Base.VideoResCaseTypeName] = objInFor[convVideoResCase_Base.VideoResCaseTypeName];
objDR[convVideoResCase_Base.VideoResCaseText] = objInFor[convVideoResCase_Base.VideoResCaseText];
objDR[convVideoResCase_Base.VideoResCaseDate] = objInFor[convVideoResCase_Base.VideoResCaseDate];
objDR[convVideoResCase_Base.VideoResCaseTime] = objInFor[convVideoResCase_Base.VideoResCaseTime];
objDR[convVideoResCase_Base.VideoResCaseDateIn] = objInFor[convVideoResCase_Base.VideoResCaseDateIn];
objDR[convVideoResCase_Base.VideoResCaseTimeIn] = objInFor[convVideoResCase_Base.VideoResCaseTimeIn];
objDR[convVideoResCase_Base.OwnerId] = objInFor[convVideoResCase_Base.OwnerId];
objDR[convVideoResCase_Base.id_StudyLevel] = objInFor[convVideoResCase_Base.id_StudyLevel];
objDR[convVideoResCase_Base.StudyLevelName] = objInFor[convVideoResCase_Base.StudyLevelName];
objDR[convVideoResCase_Base.id_TeachingPlan] = objInFor[convVideoResCase_Base.id_TeachingPlan];
objDR[convVideoResCase_Base.id_Discipline] = objInFor[convVideoResCase_Base.id_Discipline];
objDR[convVideoResCase_Base.DisciplineID] = objInFor[convVideoResCase_Base.DisciplineID];
objDR[convVideoResCase_Base.DisciplineName] = objInFor[convVideoResCase_Base.DisciplineName];
objDR[convVideoResCase_Base.id_SenateGaugeVersion] = objInFor[convVideoResCase_Base.id_SenateGaugeVersion];
objDR[convVideoResCase_Base.senateGaugeVersionID] = objInFor[convVideoResCase_Base.senateGaugeVersionID];
objDR[convVideoResCase_Base.senateGaugeVersionName] = objInFor[convVideoResCase_Base.senateGaugeVersionName];
objDR[convVideoResCase_Base.senateGaugeVersionTtlScore] = objInFor[convVideoResCase_Base.senateGaugeVersionTtlScore];
objDR[convVideoResCase_Base.VersionNo] = objInFor[convVideoResCase_Base.VersionNo];
objDR[convVideoResCase_Base.id_TeachSkill] = objInFor[convVideoResCase_Base.id_TeachSkill];
objDR[convVideoResCase_Base.TeachSkillID] = objInFor[convVideoResCase_Base.TeachSkillID];
objDR[convVideoResCase_Base.SkillTypeName] = objInFor[convVideoResCase_Base.SkillTypeName];
objDR[convVideoResCase_Base.TeachSkillName] = objInFor[convVideoResCase_Base.TeachSkillName];
objDR[convVideoResCase_Base.TeachSkillTheory] = objInFor[convVideoResCase_Base.TeachSkillTheory];
objDR[convVideoResCase_Base.TeachSkillOperMethod] = objInFor[convVideoResCase_Base.TeachSkillOperMethod];
objDR[convVideoResCase_Base.id_SkillType] = objInFor[convVideoResCase_Base.id_SkillType];
objDR[convVideoResCase_Base.SkillTypeID] = objInFor[convVideoResCase_Base.SkillTypeID];
objDR[convVideoResCase_Base.CaseLevelId] = objInFor[convVideoResCase_Base.CaseLevelId];
objDR[convVideoResCase_Base.CaseLevelName] = objInFor[convVideoResCase_Base.CaseLevelName];
objDR[convVideoResCase_Base.DocFile] = objInFor[convVideoResCase_Base.DocFile];
objDR[convVideoResCase_Base.IsNeedGeneWord] = objInFor[convVideoResCase_Base.IsNeedGeneWord];
objDR[convVideoResCase_Base.WordCreateDate] = objInFor[convVideoResCase_Base.WordCreateDate];
objDR[convVideoResCase_Base.IsVisible] = objInFor[convVideoResCase_Base.IsVisible];
objDR[convVideoResCase_Base.IsDualVideo] = objInFor[convVideoResCase_Base.IsDualVideo];
objDR[convVideoResCase_Base.id_XzCollege] = objInFor[convVideoResCase_Base.id_XzCollege];
objDR[convVideoResCase_Base.CollegeID] = objInFor[convVideoResCase_Base.CollegeID];
objDR[convVideoResCase_Base.CollegeName] = objInFor[convVideoResCase_Base.CollegeName];
objDR[convVideoResCase_Base.CollegeNameA] = objInFor[convVideoResCase_Base.CollegeNameA];
objDR[convVideoResCase_Base.id_XzMajor] = objInFor[convVideoResCase_Base.id_XzMajor];
objDR[convVideoResCase_Base.MajorID] = objInFor[convVideoResCase_Base.MajorID];
objDR[convVideoResCase_Base.MajorName] = objInFor[convVideoResCase_Base.MajorName];
objDR[convVideoResCase_Base.CourseChapterId] = objInFor[convVideoResCase_Base.CourseChapterId];
objDR[convVideoResCase_Base.CourseChapterName] = objInFor[convVideoResCase_Base.CourseChapterName];
objDR[convVideoResCase_Base.ParentNodeID] = objInFor[convVideoResCase_Base.ParentNodeID];
objDR[convVideoResCase_Base.ParentNodeName] = objInFor[convVideoResCase_Base.ParentNodeName];
objDR[convVideoResCase_Base.ViewCount] = objInFor[convVideoResCase_Base.ViewCount];
objDR[convVideoResCase_Base.IsShow] = objInFor[convVideoResCase_Base.IsShow];
objDR[convVideoResCase_Base.DownloadNumber] = objInFor[convVideoResCase_Base.DownloadNumber];
objDR[convVideoResCase_Base.FileIntegration] = objInFor[convVideoResCase_Base.FileIntegration];
objDR[convVideoResCase_Base.LikeCount] = objInFor[convVideoResCase_Base.LikeCount];
objDR[convVideoResCase_Base.CollectionCount] = objInFor[convVideoResCase_Base.CollectionCount];
objDR[convVideoResCase_Base.RecommendedDegreeId] = objInFor[convVideoResCase_Base.RecommendedDegreeId];
objDR[convVideoResCase_Base.RecommendedDegreeName] = objInFor[convVideoResCase_Base.RecommendedDegreeName];
objDR[convVideoResCase_Base.ftpFileType] = objInFor[convVideoResCase_Base.ftpFileType];
objDR[convVideoResCase_Base.CourseId] = objInFor[convVideoResCase_Base.CourseId];
objDR[convVideoResCase_Base.CourseCode] = objInFor[convVideoResCase_Base.CourseCode];
objDR[convVideoResCase_Base.CourseName] = objInFor[convVideoResCase_Base.CourseName];
objDR[convVideoResCase_Base.VideoUrl] = objInFor[convVideoResCase_Base.VideoUrl];
objDR[convVideoResCase_Base.VideoPath] = objInFor[convVideoResCase_Base.VideoPath];
objDR[convVideoResCase_Base.ResErrMsg] = objInFor[convVideoResCase_Base.ResErrMsg];
objDR[convVideoResCase_Base.Memo] = objInFor[convVideoResCase_Base.Memo];
objDR[convVideoResCase_Base.OwnerName] = objInFor[convVideoResCase_Base.OwnerName];
objDR[convVideoResCase_Base.OwnerNameWithId] = objInFor[convVideoResCase_Base.OwnerNameWithId];
objDR[convVideoResCase_Base.BrowseCount4Case] = objInFor[convVideoResCase_Base.BrowseCount4Case];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}