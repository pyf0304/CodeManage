
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoResCaseWApi
 表名:vVideoResCase(01120372)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:02
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
public static class clsvVideoResCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetId_VideoResCase(this clsvVideoResCaseEN objvVideoResCaseEN, string strId_VideoResCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_VideoResCase, 8, convVideoResCase.Id_VideoResCase);
clsCheckSql.CheckFieldForeignKey(strId_VideoResCase, 8, convVideoResCase.Id_VideoResCase);
objvVideoResCaseEN.Id_VideoResCase = strId_VideoResCase; //视频资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.Id_VideoResCase) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.Id_VideoResCase, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.Id_VideoResCase] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetVideoResCaseID(this clsvVideoResCaseEN objvVideoResCaseEN, string strVideoResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoResCaseID, convVideoResCase.VideoResCaseID);
clsCheckSql.CheckFieldLen(strVideoResCaseID, 8, convVideoResCase.VideoResCaseID);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseID, 8, convVideoResCase.VideoResCaseID);
objvVideoResCaseEN.VideoResCaseID = strVideoResCaseID; //视频资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.VideoResCaseID) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.VideoResCaseID, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.VideoResCaseID] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetVideoResCaseName(this clsvVideoResCaseEN objvVideoResCaseEN, string strVideoResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoResCaseName, convVideoResCase.VideoResCaseName);
clsCheckSql.CheckFieldLen(strVideoResCaseName, 100, convVideoResCase.VideoResCaseName);
objvVideoResCaseEN.VideoResCaseName = strVideoResCaseName; //视频资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.VideoResCaseName) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.VideoResCaseName, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.VideoResCaseName] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetVideoResCaseTheme(this clsvVideoResCaseEN objvVideoResCaseEN, string strVideoResCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTheme, 200, convVideoResCase.VideoResCaseTheme);
objvVideoResCaseEN.VideoResCaseTheme = strVideoResCaseTheme; //视频资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.VideoResCaseTheme) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.VideoResCaseTheme, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.VideoResCaseTheme] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN Setid_VideoResCaseType(this clsvVideoResCaseEN objvVideoResCaseEN, string strid_VideoResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_VideoResCaseType, convVideoResCase.id_VideoResCaseType);
clsCheckSql.CheckFieldLen(strid_VideoResCaseType, 4, convVideoResCase.id_VideoResCaseType);
clsCheckSql.CheckFieldForeignKey(strid_VideoResCaseType, 4, convVideoResCase.id_VideoResCaseType);
objvVideoResCaseEN.id_VideoResCaseType = strid_VideoResCaseType; //视频资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.id_VideoResCaseType) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.id_VideoResCaseType, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.id_VideoResCaseType] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetVideoResCaseTypeName(this clsvVideoResCaseEN objvVideoResCaseEN, string strVideoResCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTypeName, 30, convVideoResCase.VideoResCaseTypeName);
objvVideoResCaseEN.VideoResCaseTypeName = strVideoResCaseTypeName; //视频资源案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.VideoResCaseTypeName) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.VideoResCaseTypeName, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.VideoResCaseTypeName] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetVideoResCaseText(this clsvVideoResCaseEN objvVideoResCaseEN, string strVideoResCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseText, 8000, convVideoResCase.VideoResCaseText);
objvVideoResCaseEN.VideoResCaseText = strVideoResCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.VideoResCaseText) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.VideoResCaseText, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.VideoResCaseText] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetVideoResCaseDate(this clsvVideoResCaseEN objvVideoResCaseEN, string strVideoResCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseDate, 8, convVideoResCase.VideoResCaseDate);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseDate, 8, convVideoResCase.VideoResCaseDate);
objvVideoResCaseEN.VideoResCaseDate = strVideoResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.VideoResCaseDate) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.VideoResCaseDate, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.VideoResCaseDate] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetVideoResCaseTime(this clsvVideoResCaseEN objvVideoResCaseEN, string strVideoResCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTime, 6, convVideoResCase.VideoResCaseTime);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseTime, 6, convVideoResCase.VideoResCaseTime);
objvVideoResCaseEN.VideoResCaseTime = strVideoResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.VideoResCaseTime) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.VideoResCaseTime, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.VideoResCaseTime] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetVideoResCaseDateIn(this clsvVideoResCaseEN objvVideoResCaseEN, string strVideoResCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseDateIn, 8, convVideoResCase.VideoResCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseDateIn, 8, convVideoResCase.VideoResCaseDateIn);
objvVideoResCaseEN.VideoResCaseDateIn = strVideoResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.VideoResCaseDateIn) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.VideoResCaseDateIn, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.VideoResCaseDateIn] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetVideoResCaseTimeIn(this clsvVideoResCaseEN objvVideoResCaseEN, string strVideoResCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseTimeIn, 6, convVideoResCase.VideoResCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseTimeIn, 6, convVideoResCase.VideoResCaseTimeIn);
objvVideoResCaseEN.VideoResCaseTimeIn = strVideoResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.VideoResCaseTimeIn) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.VideoResCaseTimeIn, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.VideoResCaseTimeIn] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetOwnerId(this clsvVideoResCaseEN objvVideoResCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convVideoResCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convVideoResCase.OwnerId);
objvVideoResCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.OwnerId) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.OwnerId, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.OwnerId] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN Setid_StudyLevel(this clsvVideoResCaseEN objvVideoResCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convVideoResCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convVideoResCase.id_StudyLevel);
objvVideoResCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.id_StudyLevel) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.id_StudyLevel, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.id_StudyLevel] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetStudyLevelName(this clsvVideoResCaseEN objvVideoResCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convVideoResCase.StudyLevelName);
objvVideoResCaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.StudyLevelName) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.StudyLevelName, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.StudyLevelName] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN Setid_TeachingPlan(this clsvVideoResCaseEN objvVideoResCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convVideoResCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convVideoResCase.id_TeachingPlan);
objvVideoResCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.id_TeachingPlan) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.id_TeachingPlan, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.id_TeachingPlan] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN Setid_Discipline(this clsvVideoResCaseEN objvVideoResCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convVideoResCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convVideoResCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convVideoResCase.id_Discipline);
objvVideoResCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.id_Discipline) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.id_Discipline, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.id_Discipline] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetDisciplineID(this clsvVideoResCaseEN objvVideoResCaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convVideoResCase.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convVideoResCase.DisciplineID);
objvVideoResCaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.DisciplineID) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.DisciplineID, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.DisciplineID] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetDisciplineName(this clsvVideoResCaseEN objvVideoResCaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convVideoResCase.DisciplineName);
objvVideoResCaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.DisciplineName) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.DisciplineName, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.DisciplineName] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN Setid_SenateGaugeVersion(this clsvVideoResCaseEN objvVideoResCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convVideoResCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convVideoResCase.id_SenateGaugeVersion);
objvVideoResCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.id_SenateGaugeVersion) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetsenateGaugeVersionID(this clsvVideoResCaseEN objvVideoResCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convVideoResCase.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convVideoResCase.senateGaugeVersionID);
objvVideoResCaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.senateGaugeVersionID) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.senateGaugeVersionID, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.senateGaugeVersionID] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetsenateGaugeVersionName(this clsvVideoResCaseEN objvVideoResCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convVideoResCase.senateGaugeVersionName);
objvVideoResCaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.senateGaugeVersionName) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.senateGaugeVersionName, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.senateGaugeVersionName] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetsenateGaugeVersionTtlScore(this clsvVideoResCaseEN objvVideoResCaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvVideoResCaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.senateGaugeVersionTtlScore) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetVersionNo(this clsvVideoResCaseEN objvVideoResCaseEN, int intVersionNo, string strComparisonOp="")
	{
objvVideoResCaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.VersionNo) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.VersionNo, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.VersionNo] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN Setid_TeachSkill(this clsvVideoResCaseEN objvVideoResCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convVideoResCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convVideoResCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convVideoResCase.id_TeachSkill);
objvVideoResCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.id_TeachSkill) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.id_TeachSkill, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.id_TeachSkill] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetTeachSkillID(this clsvVideoResCaseEN objvVideoResCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convVideoResCase.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convVideoResCase.TeachSkillID);
objvVideoResCaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.TeachSkillID) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.TeachSkillID, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.TeachSkillID] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetSkillTypeName(this clsvVideoResCaseEN objvVideoResCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convVideoResCase.SkillTypeName);
objvVideoResCaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.SkillTypeName) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.SkillTypeName, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.SkillTypeName] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetTeachSkillName(this clsvVideoResCaseEN objvVideoResCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convVideoResCase.TeachSkillName);
objvVideoResCaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.TeachSkillName) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.TeachSkillName, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.TeachSkillName] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetTeachSkillTheory(this clsvVideoResCaseEN objvVideoResCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convVideoResCase.TeachSkillTheory);
objvVideoResCaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.TeachSkillTheory) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.TeachSkillTheory, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.TeachSkillTheory] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetTeachSkillOperMethod(this clsvVideoResCaseEN objvVideoResCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convVideoResCase.TeachSkillOperMethod);
objvVideoResCaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.TeachSkillOperMethod) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN Setid_SkillType(this clsvVideoResCaseEN objvVideoResCaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convVideoResCase.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convVideoResCase.id_SkillType);
objvVideoResCaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.id_SkillType) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.id_SkillType, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.id_SkillType] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetSkillTypeID(this clsvVideoResCaseEN objvVideoResCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convVideoResCase.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convVideoResCase.SkillTypeID);
objvVideoResCaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.SkillTypeID) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.SkillTypeID, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.SkillTypeID] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetCaseLevelId(this clsvVideoResCaseEN objvVideoResCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convVideoResCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convVideoResCase.CaseLevelId);
objvVideoResCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.CaseLevelId) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.CaseLevelId, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.CaseLevelId] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetCaseLevelName(this clsvVideoResCaseEN objvVideoResCaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convVideoResCase.CaseLevelName);
objvVideoResCaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.CaseLevelName) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.CaseLevelName, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.CaseLevelName] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetDocFile(this clsvVideoResCaseEN objvVideoResCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convVideoResCase.DocFile);
objvVideoResCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.DocFile) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.DocFile, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.DocFile] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetIsNeedGeneWord(this clsvVideoResCaseEN objvVideoResCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvVideoResCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.IsNeedGeneWord) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetWordCreateDate(this clsvVideoResCaseEN objvVideoResCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convVideoResCase.WordCreateDate);
objvVideoResCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.WordCreateDate) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.WordCreateDate, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.WordCreateDate] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetIsVisible(this clsvVideoResCaseEN objvVideoResCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvVideoResCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.IsVisible) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.IsVisible, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.IsVisible] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetIsDualVideo(this clsvVideoResCaseEN objvVideoResCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvVideoResCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.IsDualVideo) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.IsDualVideo, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.IsDualVideo] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN Setid_XzCollege(this clsvVideoResCaseEN objvVideoResCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, convVideoResCase.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convVideoResCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convVideoResCase.id_XzCollege);
objvVideoResCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.id_XzCollege) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.id_XzCollege, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.id_XzCollege] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetCollegeID(this clsvVideoResCaseEN objvVideoResCaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoResCase.CollegeID);
objvVideoResCaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.CollegeID) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.CollegeID, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.CollegeID] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetCollegeName(this clsvVideoResCaseEN objvVideoResCaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoResCase.CollegeName);
objvVideoResCaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.CollegeName) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.CollegeName, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.CollegeName] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetCollegeNameA(this clsvVideoResCaseEN objvVideoResCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoResCase.CollegeNameA);
objvVideoResCaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.CollegeNameA) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.CollegeNameA, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.CollegeNameA] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN Setid_XzMajor(this clsvVideoResCaseEN objvVideoResCaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convVideoResCase.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convVideoResCase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convVideoResCase.id_XzMajor);
objvVideoResCaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.id_XzMajor) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.id_XzMajor, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.id_XzMajor] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetMajorID(this clsvVideoResCaseEN objvVideoResCaseEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convVideoResCase.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convVideoResCase.MajorID);
objvVideoResCaseEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.MajorID) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.MajorID, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.MajorID] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetMajorName(this clsvVideoResCaseEN objvVideoResCaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convVideoResCase.MajorName);
objvVideoResCaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.MajorName) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.MajorName, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.MajorName] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetCourseChapterId(this clsvVideoResCaseEN objvVideoResCaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convVideoResCase.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convVideoResCase.CourseChapterId);
objvVideoResCaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.CourseChapterId) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.CourseChapterId, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.CourseChapterId] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetCourseChapterName(this clsvVideoResCaseEN objvVideoResCaseEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convVideoResCase.CourseChapterName);
objvVideoResCaseEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.CourseChapterName) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.CourseChapterName, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.CourseChapterName] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetParentNodeID(this clsvVideoResCaseEN objvVideoResCaseEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convVideoResCase.ParentNodeID);
objvVideoResCaseEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.ParentNodeID) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.ParentNodeID, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.ParentNodeID] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetParentNodeName(this clsvVideoResCaseEN objvVideoResCaseEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convVideoResCase.ParentNodeName);
objvVideoResCaseEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.ParentNodeName) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.ParentNodeName, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.ParentNodeName] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetViewCount(this clsvVideoResCaseEN objvVideoResCaseEN, int intViewCount, string strComparisonOp="")
	{
objvVideoResCaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.ViewCount) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.ViewCount, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.ViewCount] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetIsShow(this clsvVideoResCaseEN objvVideoResCaseEN, bool bolIsShow, string strComparisonOp="")
	{
objvVideoResCaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.IsShow) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.IsShow, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.IsShow] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetDownloadNumber(this clsvVideoResCaseEN objvVideoResCaseEN, int intDownloadNumber, string strComparisonOp="")
	{
objvVideoResCaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.DownloadNumber) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.DownloadNumber, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.DownloadNumber] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetFileIntegration(this clsvVideoResCaseEN objvVideoResCaseEN, int intFileIntegration, string strComparisonOp="")
	{
objvVideoResCaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.FileIntegration) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.FileIntegration, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.FileIntegration] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetLikeCount(this clsvVideoResCaseEN objvVideoResCaseEN, long lngLikeCount, string strComparisonOp="")
	{
objvVideoResCaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.LikeCount) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.LikeCount, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.LikeCount] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetCollectionCount(this clsvVideoResCaseEN objvVideoResCaseEN, long lngCollectionCount, string strComparisonOp="")
	{
objvVideoResCaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.CollectionCount) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.CollectionCount, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.CollectionCount] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetRecommendedDegreeId(this clsvVideoResCaseEN objvVideoResCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convVideoResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convVideoResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convVideoResCase.RecommendedDegreeId);
objvVideoResCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.RecommendedDegreeId) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetRecommendedDegreeName(this clsvVideoResCaseEN objvVideoResCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convVideoResCase.RecommendedDegreeName);
objvVideoResCaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.RecommendedDegreeName) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.RecommendedDegreeName, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.RecommendedDegreeName] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetftpFileType(this clsvVideoResCaseEN objvVideoResCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convVideoResCase.ftpFileType);
objvVideoResCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.ftpFileType) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.ftpFileType, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.ftpFileType] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetCourseId(this clsvVideoResCaseEN objvVideoResCaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoResCase.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoResCase.CourseId);
objvVideoResCaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.CourseId) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.CourseId, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.CourseId] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetCourseCode(this clsvVideoResCaseEN objvVideoResCaseEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoResCase.CourseCode);
objvVideoResCaseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.CourseCode) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.CourseCode, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.CourseCode] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetCourseName(this clsvVideoResCaseEN objvVideoResCaseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoResCase.CourseName);
objvVideoResCaseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.CourseName) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.CourseName, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.CourseName] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetVideoUrl(this clsvVideoResCaseEN objvVideoResCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convVideoResCase.VideoUrl);
objvVideoResCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.VideoUrl) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.VideoUrl, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.VideoUrl] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetVideoPath(this clsvVideoResCaseEN objvVideoResCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convVideoResCase.VideoPath);
objvVideoResCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.VideoPath) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.VideoPath, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.VideoPath] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetResErrMsg(this clsvVideoResCaseEN objvVideoResCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convVideoResCase.ResErrMsg);
objvVideoResCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.ResErrMsg) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.ResErrMsg, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.ResErrMsg] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetUpdDate(this clsvVideoResCaseEN objvVideoResCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convVideoResCase.UpdDate);
objvVideoResCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.UpdDate) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.UpdDate, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.UpdDate] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetUpdUserId(this clsvVideoResCaseEN objvVideoResCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convVideoResCase.UpdUserId);
objvVideoResCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.UpdUserId) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.UpdUserId, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.UpdUserId] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetMemo(this clsvVideoResCaseEN objvVideoResCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoResCase.Memo);
objvVideoResCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.Memo) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.Memo, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.Memo] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetOwnerNameWithId(this clsvVideoResCaseEN objvVideoResCaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convVideoResCase.OwnerNameWithId);
objvVideoResCaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.OwnerNameWithId) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.OwnerNameWithId, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.OwnerNameWithId] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetOwnerName(this clsvVideoResCaseEN objvVideoResCaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convVideoResCase.OwnerName);
objvVideoResCaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.OwnerName) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.OwnerName, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.OwnerName] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetBrowseCount4Case(this clsvVideoResCaseEN objvVideoResCaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvVideoResCaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.BrowseCount4Case) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.BrowseCount4Case, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.BrowseCount4Case] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseEN SetIsHaveVideo(this clsvVideoResCaseEN objvVideoResCaseEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convVideoResCase.IsHaveVideo);
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convVideoResCase.IsHaveVideo);
objvVideoResCaseEN.IsHaveVideo = strIsHaveVideo; //IsHaveVideo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseEN.dicFldComparisonOp.ContainsKey(convVideoResCase.IsHaveVideo) == false)
{
objvVideoResCaseEN.dicFldComparisonOp.Add(convVideoResCase.IsHaveVideo, strComparisonOp);
}
else
{
objvVideoResCaseEN.dicFldComparisonOp[convVideoResCase.IsHaveVideo] = strComparisonOp;
}
}
return objvVideoResCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoResCaseEN objvVideoResCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.Id_VideoResCase) == true)
{
string strComparisonOp_Id_VideoResCase = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.Id_VideoResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.Id_VideoResCase, objvVideoResCase_Cond.Id_VideoResCase, strComparisonOp_Id_VideoResCase);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.VideoResCaseID) == true)
{
string strComparisonOp_VideoResCaseID = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.VideoResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.VideoResCaseID, objvVideoResCase_Cond.VideoResCaseID, strComparisonOp_VideoResCaseID);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.VideoResCaseName) == true)
{
string strComparisonOp_VideoResCaseName = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.VideoResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.VideoResCaseName, objvVideoResCase_Cond.VideoResCaseName, strComparisonOp_VideoResCaseName);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.VideoResCaseTheme) == true)
{
string strComparisonOp_VideoResCaseTheme = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.VideoResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.VideoResCaseTheme, objvVideoResCase_Cond.VideoResCaseTheme, strComparisonOp_VideoResCaseTheme);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.id_VideoResCaseType) == true)
{
string strComparisonOp_id_VideoResCaseType = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.id_VideoResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.id_VideoResCaseType, objvVideoResCase_Cond.id_VideoResCaseType, strComparisonOp_id_VideoResCaseType);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.VideoResCaseTypeName) == true)
{
string strComparisonOp_VideoResCaseTypeName = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.VideoResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.VideoResCaseTypeName, objvVideoResCase_Cond.VideoResCaseTypeName, strComparisonOp_VideoResCaseTypeName);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.VideoResCaseText) == true)
{
string strComparisonOp_VideoResCaseText = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.VideoResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.VideoResCaseText, objvVideoResCase_Cond.VideoResCaseText, strComparisonOp_VideoResCaseText);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.VideoResCaseDate) == true)
{
string strComparisonOp_VideoResCaseDate = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.VideoResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.VideoResCaseDate, objvVideoResCase_Cond.VideoResCaseDate, strComparisonOp_VideoResCaseDate);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.VideoResCaseTime) == true)
{
string strComparisonOp_VideoResCaseTime = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.VideoResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.VideoResCaseTime, objvVideoResCase_Cond.VideoResCaseTime, strComparisonOp_VideoResCaseTime);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.VideoResCaseDateIn) == true)
{
string strComparisonOp_VideoResCaseDateIn = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.VideoResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.VideoResCaseDateIn, objvVideoResCase_Cond.VideoResCaseDateIn, strComparisonOp_VideoResCaseDateIn);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.VideoResCaseTimeIn) == true)
{
string strComparisonOp_VideoResCaseTimeIn = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.VideoResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.VideoResCaseTimeIn, objvVideoResCase_Cond.VideoResCaseTimeIn, strComparisonOp_VideoResCaseTimeIn);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.OwnerId, objvVideoResCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.id_StudyLevel, objvVideoResCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.StudyLevelName, objvVideoResCase_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.id_TeachingPlan, objvVideoResCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.id_Discipline, objvVideoResCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.DisciplineID, objvVideoResCase_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.DisciplineName, objvVideoResCase_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.id_SenateGaugeVersion, objvVideoResCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.senateGaugeVersionID, objvVideoResCase_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.senateGaugeVersionName, objvVideoResCase_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase.senateGaugeVersionTtlScore, objvVideoResCase_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase.VersionNo, objvVideoResCase_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.id_TeachSkill, objvVideoResCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.TeachSkillID, objvVideoResCase_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.SkillTypeName, objvVideoResCase_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.TeachSkillName, objvVideoResCase_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.TeachSkillTheory, objvVideoResCase_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.TeachSkillOperMethod, objvVideoResCase_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.id_SkillType, objvVideoResCase_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.SkillTypeID, objvVideoResCase_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.CaseLevelId, objvVideoResCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.CaseLevelName, objvVideoResCase_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.DocFile) == true)
{
string strComparisonOp_DocFile = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.DocFile, objvVideoResCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.IsNeedGeneWord) == true)
{
if (objvVideoResCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCase.IsNeedGeneWord);
}
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.WordCreateDate, objvVideoResCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.IsVisible) == true)
{
if (objvVideoResCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCase.IsVisible);
}
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.IsDualVideo) == true)
{
if (objvVideoResCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCase.IsDualVideo);
}
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.id_XzCollege, objvVideoResCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.CollegeID, objvVideoResCase_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.CollegeName, objvVideoResCase_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.CollegeNameA, objvVideoResCase_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.id_XzMajor, objvVideoResCase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.MajorID) == true)
{
string strComparisonOp_MajorID = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.MajorID, objvVideoResCase_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.MajorName) == true)
{
string strComparisonOp_MajorName = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.MajorName, objvVideoResCase_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.CourseChapterId, objvVideoResCase_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.CourseChapterName, objvVideoResCase_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.ParentNodeID, objvVideoResCase_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.ParentNodeName, objvVideoResCase_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase.ViewCount, objvVideoResCase_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.IsShow) == true)
{
if (objvVideoResCase_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCase.IsShow);
}
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase.DownloadNumber, objvVideoResCase_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase.FileIntegration, objvVideoResCase_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase.LikeCount, objvVideoResCase_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase.CollectionCount, objvVideoResCase_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.RecommendedDegreeId, objvVideoResCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.RecommendedDegreeName, objvVideoResCase_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.ftpFileType, objvVideoResCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.CourseId) == true)
{
string strComparisonOp_CourseId = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.CourseId, objvVideoResCase_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.CourseCode, objvVideoResCase_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.CourseName) == true)
{
string strComparisonOp_CourseName = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.CourseName, objvVideoResCase_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.VideoUrl, objvVideoResCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.VideoPath, objvVideoResCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.ResErrMsg, objvVideoResCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.UpdDate, objvVideoResCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.UpdUserId, objvVideoResCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.Memo) == true)
{
string strComparisonOp_Memo = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.Memo, objvVideoResCase_Cond.Memo, strComparisonOp_Memo);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.OwnerNameWithId, objvVideoResCase_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.OwnerName, objvVideoResCase_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCase.BrowseCount4Case, objvVideoResCase_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvVideoResCase_Cond.IsUpdated(convVideoResCase.IsHaveVideo) == true)
{
string strComparisonOp_IsHaveVideo = objvVideoResCase_Cond.dicFldComparisonOp[convVideoResCase.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCase.IsHaveVideo, objvVideoResCase_Cond.IsHaveVideo, strComparisonOp_IsHaveVideo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频资源案例(vVideoResCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoResCaseWApi
{
private static readonly string mstrApiControllerName = "vVideoResCaseApi";

 public clsvVideoResCaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_VideoResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoResCaseEN GetObjById_VideoResCase(string strId_VideoResCase)
{
string strAction = "GetObjById_VideoResCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCaseEN objvVideoResCaseEN = null;
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
objvVideoResCaseEN = JsonConvert.DeserializeObject<clsvVideoResCaseEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCaseEN;
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
public static clsvVideoResCaseEN GetObjById_VideoResCase_WA_Cache(string strId_VideoResCase)
{
string strAction = "GetObjById_VideoResCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCaseEN objvVideoResCaseEN = null;
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
objvVideoResCaseEN = JsonConvert.DeserializeObject<clsvVideoResCaseEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCaseEN;
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
public static clsvVideoResCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCaseEN objvVideoResCaseEN = null;
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
objvVideoResCaseEN = JsonConvert.DeserializeObject<clsvVideoResCaseEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCaseEN;
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
public static clsvVideoResCaseEN GetObjById_VideoResCase_Cache(string strId_VideoResCase)
{
if (string.IsNullOrEmpty(strId_VideoResCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoResCaseEN._CurrTabName_S);
List<clsvVideoResCaseEN> arrvVideoResCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoResCaseEN> arrvVideoResCaseObjLst_Sel =
from objvVideoResCaseEN in arrvVideoResCaseObjLst_Cache
where objvVideoResCaseEN.Id_VideoResCase == strId_VideoResCase
select objvVideoResCaseEN;
if (arrvVideoResCaseObjLst_Sel.Count() == 0)
{
   clsvVideoResCaseEN obj = clsvVideoResCaseWApi.GetObjById_VideoResCase(strId_VideoResCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoResCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoResCaseEN> GetObjLst(string strWhereCond)
{
 List<clsvVideoResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseEN> GetObjLstById_VideoResCaseLst(List<string> arrId_VideoResCase)
{
 List<clsvVideoResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvVideoResCaseEN> GetObjLstById_VideoResCaseLst_Cache(List<string> arrId_VideoResCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoResCaseEN._CurrTabName_S);
List<clsvVideoResCaseEN> arrvVideoResCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoResCaseEN> arrvVideoResCaseObjLst_Sel =
from objvVideoResCaseEN in arrvVideoResCaseObjLst_Cache
where arrId_VideoResCase.Contains(objvVideoResCaseEN.Id_VideoResCase)
select objvVideoResCaseEN;
return arrvVideoResCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoResCaseEN> GetObjLstById_VideoResCaseLst_WA_Cache(List<string> arrId_VideoResCase)
{
 List<clsvVideoResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvVideoResCaseENS">源对象</param>
 /// <param name = "objvVideoResCaseENT">目标对象</param>
 public static void CopyTo(clsvVideoResCaseEN objvVideoResCaseENS, clsvVideoResCaseEN objvVideoResCaseENT)
{
try
{
objvVideoResCaseENT.Id_VideoResCase = objvVideoResCaseENS.Id_VideoResCase; //视频资源案例流水号
objvVideoResCaseENT.VideoResCaseID = objvVideoResCaseENS.VideoResCaseID; //视频资源案例ID
objvVideoResCaseENT.VideoResCaseName = objvVideoResCaseENS.VideoResCaseName; //视频资源案例名称
objvVideoResCaseENT.VideoResCaseTheme = objvVideoResCaseENS.VideoResCaseTheme; //视频资源案例主题词
objvVideoResCaseENT.id_VideoResCaseType = objvVideoResCaseENS.id_VideoResCaseType; //视频资源类型流水号
objvVideoResCaseENT.VideoResCaseTypeName = objvVideoResCaseENS.VideoResCaseTypeName; //视频资源案例类型名称
objvVideoResCaseENT.VideoResCaseText = objvVideoResCaseENS.VideoResCaseText; //案例文本内容
objvVideoResCaseENT.VideoResCaseDate = objvVideoResCaseENS.VideoResCaseDate; //视频资源日期
objvVideoResCaseENT.VideoResCaseTime = objvVideoResCaseENS.VideoResCaseTime; //视频资源时间
objvVideoResCaseENT.VideoResCaseDateIn = objvVideoResCaseENS.VideoResCaseDateIn; //案例入库日期
objvVideoResCaseENT.VideoResCaseTimeIn = objvVideoResCaseENS.VideoResCaseTimeIn; //案例入库时间
objvVideoResCaseENT.OwnerId = objvVideoResCaseENS.OwnerId; //拥有者Id
objvVideoResCaseENT.id_StudyLevel = objvVideoResCaseENS.id_StudyLevel; //id_StudyLevel
objvVideoResCaseENT.StudyLevelName = objvVideoResCaseENS.StudyLevelName; //学段名称
objvVideoResCaseENT.id_TeachingPlan = objvVideoResCaseENS.id_TeachingPlan; //教案流水号
objvVideoResCaseENT.id_Discipline = objvVideoResCaseENS.id_Discipline; //学科流水号
objvVideoResCaseENT.DisciplineID = objvVideoResCaseENS.DisciplineID; //学科ID
objvVideoResCaseENT.DisciplineName = objvVideoResCaseENS.DisciplineName; //学科名称
objvVideoResCaseENT.id_SenateGaugeVersion = objvVideoResCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvVideoResCaseENT.senateGaugeVersionID = objvVideoResCaseENS.senateGaugeVersionID; //评价量表版本ID
objvVideoResCaseENT.senateGaugeVersionName = objvVideoResCaseENS.senateGaugeVersionName; //评价量表版本名称
objvVideoResCaseENT.senateGaugeVersionTtlScore = objvVideoResCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoResCaseENT.VersionNo = objvVideoResCaseENS.VersionNo; //版本号
objvVideoResCaseENT.id_TeachSkill = objvVideoResCaseENS.id_TeachSkill; //教学技能流水号
objvVideoResCaseENT.TeachSkillID = objvVideoResCaseENS.TeachSkillID; //教学技能ID
objvVideoResCaseENT.SkillTypeName = objvVideoResCaseENS.SkillTypeName; //技能类型名称
objvVideoResCaseENT.TeachSkillName = objvVideoResCaseENS.TeachSkillName; //教学技能名称
objvVideoResCaseENT.TeachSkillTheory = objvVideoResCaseENS.TeachSkillTheory; //教学技能理论阐述
objvVideoResCaseENT.TeachSkillOperMethod = objvVideoResCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvVideoResCaseENT.id_SkillType = objvVideoResCaseENS.id_SkillType; //技能类型流水号
objvVideoResCaseENT.SkillTypeID = objvVideoResCaseENS.SkillTypeID; //技能类型ID
objvVideoResCaseENT.CaseLevelId = objvVideoResCaseENS.CaseLevelId; //课例等级Id
objvVideoResCaseENT.CaseLevelName = objvVideoResCaseENS.CaseLevelName; //案例等级名称
objvVideoResCaseENT.DocFile = objvVideoResCaseENS.DocFile; //生成的Word文件名
objvVideoResCaseENT.IsNeedGeneWord = objvVideoResCaseENS.IsNeedGeneWord; //是否需要生成Word
objvVideoResCaseENT.WordCreateDate = objvVideoResCaseENS.WordCreateDate; //Word生成日期
objvVideoResCaseENT.IsVisible = objvVideoResCaseENS.IsVisible; //是否显示
objvVideoResCaseENT.IsDualVideo = objvVideoResCaseENS.IsDualVideo; //是否双视频
objvVideoResCaseENT.id_XzCollege = objvVideoResCaseENS.id_XzCollege; //学院流水号
objvVideoResCaseENT.CollegeID = objvVideoResCaseENS.CollegeID; //学院ID
objvVideoResCaseENT.CollegeName = objvVideoResCaseENS.CollegeName; //学院名称
objvVideoResCaseENT.CollegeNameA = objvVideoResCaseENS.CollegeNameA; //学院名称简写
objvVideoResCaseENT.id_XzMajor = objvVideoResCaseENS.id_XzMajor; //专业流水号
objvVideoResCaseENT.MajorID = objvVideoResCaseENS.MajorID; //专业ID
objvVideoResCaseENT.MajorName = objvVideoResCaseENS.MajorName; //专业名称
objvVideoResCaseENT.CourseChapterId = objvVideoResCaseENS.CourseChapterId; //课程章节ID
objvVideoResCaseENT.CourseChapterName = objvVideoResCaseENS.CourseChapterName; //课程章节名称
objvVideoResCaseENT.ParentNodeID = objvVideoResCaseENS.ParentNodeID; //父节点编号
objvVideoResCaseENT.ParentNodeName = objvVideoResCaseENS.ParentNodeName; //父节点名称
objvVideoResCaseENT.ViewCount = objvVideoResCaseENS.ViewCount; //浏览量
objvVideoResCaseENT.IsShow = objvVideoResCaseENS.IsShow; //是否启用
objvVideoResCaseENT.DownloadNumber = objvVideoResCaseENS.DownloadNumber; //下载数目
objvVideoResCaseENT.FileIntegration = objvVideoResCaseENS.FileIntegration; //文件积分
objvVideoResCaseENT.LikeCount = objvVideoResCaseENS.LikeCount; //资源喜欢数量
objvVideoResCaseENT.CollectionCount = objvVideoResCaseENS.CollectionCount; //收藏数量
objvVideoResCaseENT.RecommendedDegreeId = objvVideoResCaseENS.RecommendedDegreeId; //推荐度Id
objvVideoResCaseENT.RecommendedDegreeName = objvVideoResCaseENS.RecommendedDegreeName; //推荐度名称
objvVideoResCaseENT.ftpFileType = objvVideoResCaseENS.ftpFileType; //ftp文件类型
objvVideoResCaseENT.CourseId = objvVideoResCaseENS.CourseId; //课程Id
objvVideoResCaseENT.CourseCode = objvVideoResCaseENS.CourseCode; //课程代码
objvVideoResCaseENT.CourseName = objvVideoResCaseENS.CourseName; //课程名称
objvVideoResCaseENT.VideoUrl = objvVideoResCaseENS.VideoUrl; //视频Url
objvVideoResCaseENT.VideoPath = objvVideoResCaseENS.VideoPath; //视频目录
objvVideoResCaseENT.ResErrMsg = objvVideoResCaseENS.ResErrMsg; //资源错误信息
objvVideoResCaseENT.UpdDate = objvVideoResCaseENS.UpdDate; //修改日期
objvVideoResCaseENT.UpdUserId = objvVideoResCaseENS.UpdUserId; //修改用户Id
objvVideoResCaseENT.Memo = objvVideoResCaseENS.Memo; //备注
objvVideoResCaseENT.OwnerNameWithId = objvVideoResCaseENS.OwnerNameWithId; //拥有者名称附Id
objvVideoResCaseENT.OwnerName = objvVideoResCaseENS.OwnerName; //拥有者姓名
objvVideoResCaseENT.BrowseCount4Case = objvVideoResCaseENS.BrowseCount4Case; //课例浏览次数
objvVideoResCaseENT.IsHaveVideo = objvVideoResCaseENS.IsHaveVideo; //IsHaveVideo
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
public static DataTable ToDataTable(List<clsvVideoResCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoResCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoResCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoResCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoResCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoResCaseEN.AttributeName)
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
//if (arrvVideoResCaseObjLst_Cache == null)
//{
//arrvVideoResCaseObjLst_Cache = await clsvVideoResCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoResCaseEN._CurrTabName_S);
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
public static List<clsvVideoResCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoResCaseEN._CurrTabName_S);
List<clsvVideoResCaseEN> arrvVideoResCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoResCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoResCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoResCase.Id_VideoResCase, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.VideoResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.VideoResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.VideoResCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.id_VideoResCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.VideoResCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.VideoResCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.VideoResCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.VideoResCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.VideoResCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.VideoResCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoResCase.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCase.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoResCase.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoResCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCase.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCase.IsHaveVideo, Type.GetType("System.String"));
foreach (clsvVideoResCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoResCase.Id_VideoResCase] = objInFor[convVideoResCase.Id_VideoResCase];
objDR[convVideoResCase.VideoResCaseID] = objInFor[convVideoResCase.VideoResCaseID];
objDR[convVideoResCase.VideoResCaseName] = objInFor[convVideoResCase.VideoResCaseName];
objDR[convVideoResCase.VideoResCaseTheme] = objInFor[convVideoResCase.VideoResCaseTheme];
objDR[convVideoResCase.id_VideoResCaseType] = objInFor[convVideoResCase.id_VideoResCaseType];
objDR[convVideoResCase.VideoResCaseTypeName] = objInFor[convVideoResCase.VideoResCaseTypeName];
objDR[convVideoResCase.VideoResCaseText] = objInFor[convVideoResCase.VideoResCaseText];
objDR[convVideoResCase.VideoResCaseDate] = objInFor[convVideoResCase.VideoResCaseDate];
objDR[convVideoResCase.VideoResCaseTime] = objInFor[convVideoResCase.VideoResCaseTime];
objDR[convVideoResCase.VideoResCaseDateIn] = objInFor[convVideoResCase.VideoResCaseDateIn];
objDR[convVideoResCase.VideoResCaseTimeIn] = objInFor[convVideoResCase.VideoResCaseTimeIn];
objDR[convVideoResCase.OwnerId] = objInFor[convVideoResCase.OwnerId];
objDR[convVideoResCase.id_StudyLevel] = objInFor[convVideoResCase.id_StudyLevel];
objDR[convVideoResCase.StudyLevelName] = objInFor[convVideoResCase.StudyLevelName];
objDR[convVideoResCase.id_TeachingPlan] = objInFor[convVideoResCase.id_TeachingPlan];
objDR[convVideoResCase.id_Discipline] = objInFor[convVideoResCase.id_Discipline];
objDR[convVideoResCase.DisciplineID] = objInFor[convVideoResCase.DisciplineID];
objDR[convVideoResCase.DisciplineName] = objInFor[convVideoResCase.DisciplineName];
objDR[convVideoResCase.id_SenateGaugeVersion] = objInFor[convVideoResCase.id_SenateGaugeVersion];
objDR[convVideoResCase.senateGaugeVersionID] = objInFor[convVideoResCase.senateGaugeVersionID];
objDR[convVideoResCase.senateGaugeVersionName] = objInFor[convVideoResCase.senateGaugeVersionName];
objDR[convVideoResCase.senateGaugeVersionTtlScore] = objInFor[convVideoResCase.senateGaugeVersionTtlScore];
objDR[convVideoResCase.VersionNo] = objInFor[convVideoResCase.VersionNo];
objDR[convVideoResCase.id_TeachSkill] = objInFor[convVideoResCase.id_TeachSkill];
objDR[convVideoResCase.TeachSkillID] = objInFor[convVideoResCase.TeachSkillID];
objDR[convVideoResCase.SkillTypeName] = objInFor[convVideoResCase.SkillTypeName];
objDR[convVideoResCase.TeachSkillName] = objInFor[convVideoResCase.TeachSkillName];
objDR[convVideoResCase.TeachSkillTheory] = objInFor[convVideoResCase.TeachSkillTheory];
objDR[convVideoResCase.TeachSkillOperMethod] = objInFor[convVideoResCase.TeachSkillOperMethod];
objDR[convVideoResCase.id_SkillType] = objInFor[convVideoResCase.id_SkillType];
objDR[convVideoResCase.SkillTypeID] = objInFor[convVideoResCase.SkillTypeID];
objDR[convVideoResCase.CaseLevelId] = objInFor[convVideoResCase.CaseLevelId];
objDR[convVideoResCase.CaseLevelName] = objInFor[convVideoResCase.CaseLevelName];
objDR[convVideoResCase.DocFile] = objInFor[convVideoResCase.DocFile];
objDR[convVideoResCase.IsNeedGeneWord] = objInFor[convVideoResCase.IsNeedGeneWord];
objDR[convVideoResCase.WordCreateDate] = objInFor[convVideoResCase.WordCreateDate];
objDR[convVideoResCase.IsVisible] = objInFor[convVideoResCase.IsVisible];
objDR[convVideoResCase.IsDualVideo] = objInFor[convVideoResCase.IsDualVideo];
objDR[convVideoResCase.id_XzCollege] = objInFor[convVideoResCase.id_XzCollege];
objDR[convVideoResCase.CollegeID] = objInFor[convVideoResCase.CollegeID];
objDR[convVideoResCase.CollegeName] = objInFor[convVideoResCase.CollegeName];
objDR[convVideoResCase.CollegeNameA] = objInFor[convVideoResCase.CollegeNameA];
objDR[convVideoResCase.id_XzMajor] = objInFor[convVideoResCase.id_XzMajor];
objDR[convVideoResCase.MajorID] = objInFor[convVideoResCase.MajorID];
objDR[convVideoResCase.MajorName] = objInFor[convVideoResCase.MajorName];
objDR[convVideoResCase.CourseChapterId] = objInFor[convVideoResCase.CourseChapterId];
objDR[convVideoResCase.CourseChapterName] = objInFor[convVideoResCase.CourseChapterName];
objDR[convVideoResCase.ParentNodeID] = objInFor[convVideoResCase.ParentNodeID];
objDR[convVideoResCase.ParentNodeName] = objInFor[convVideoResCase.ParentNodeName];
objDR[convVideoResCase.ViewCount] = objInFor[convVideoResCase.ViewCount];
objDR[convVideoResCase.IsShow] = objInFor[convVideoResCase.IsShow];
objDR[convVideoResCase.DownloadNumber] = objInFor[convVideoResCase.DownloadNumber];
objDR[convVideoResCase.FileIntegration] = objInFor[convVideoResCase.FileIntegration];
objDR[convVideoResCase.LikeCount] = objInFor[convVideoResCase.LikeCount];
objDR[convVideoResCase.CollectionCount] = objInFor[convVideoResCase.CollectionCount];
objDR[convVideoResCase.RecommendedDegreeId] = objInFor[convVideoResCase.RecommendedDegreeId];
objDR[convVideoResCase.RecommendedDegreeName] = objInFor[convVideoResCase.RecommendedDegreeName];
objDR[convVideoResCase.ftpFileType] = objInFor[convVideoResCase.ftpFileType];
objDR[convVideoResCase.CourseId] = objInFor[convVideoResCase.CourseId];
objDR[convVideoResCase.CourseCode] = objInFor[convVideoResCase.CourseCode];
objDR[convVideoResCase.CourseName] = objInFor[convVideoResCase.CourseName];
objDR[convVideoResCase.VideoUrl] = objInFor[convVideoResCase.VideoUrl];
objDR[convVideoResCase.VideoPath] = objInFor[convVideoResCase.VideoPath];
objDR[convVideoResCase.ResErrMsg] = objInFor[convVideoResCase.ResErrMsg];
objDR[convVideoResCase.UpdDate] = objInFor[convVideoResCase.UpdDate];
objDR[convVideoResCase.UpdUserId] = objInFor[convVideoResCase.UpdUserId];
objDR[convVideoResCase.Memo] = objInFor[convVideoResCase.Memo];
objDR[convVideoResCase.OwnerNameWithId] = objInFor[convVideoResCase.OwnerNameWithId];
objDR[convVideoResCase.OwnerName] = objInFor[convVideoResCase.OwnerName];
objDR[convVideoResCase.BrowseCount4Case] = objInFor[convVideoResCase.BrowseCount4Case];
objDR[convVideoResCase.IsHaveVideo] = objInFor[convVideoResCase.IsHaveVideo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}