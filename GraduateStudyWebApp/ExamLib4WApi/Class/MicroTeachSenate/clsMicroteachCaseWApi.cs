
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCaseWApi
 表名:MicroteachCase(01120322)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:04
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议
 模块英文名:MicroTeachSenate
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
public static class clsMicroteachCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN Setid_MicroteachCase(this clsMicroteachCaseEN objMicroteachCaseEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, conMicroteachCase.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, conMicroteachCase.id_MicroteachCase);
objMicroteachCaseEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.id_MicroteachCase) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.id_MicroteachCase, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.id_MicroteachCase] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetMicroteachCaseID(this clsMicroteachCaseEN objMicroteachCaseEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseID, conMicroteachCase.MicroteachCaseID);
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, conMicroteachCase.MicroteachCaseID);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, conMicroteachCase.MicroteachCaseID);
objMicroteachCaseEN.MicroteachCaseID = strMicroteachCaseID; //微格教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.MicroteachCaseID) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.MicroteachCaseID, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.MicroteachCaseID] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetMicroteachCaseName(this clsMicroteachCaseEN objMicroteachCaseEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, conMicroteachCase.MicroteachCaseName);
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, conMicroteachCase.MicroteachCaseName);
objMicroteachCaseEN.MicroteachCaseName = strMicroteachCaseName; //微格教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.MicroteachCaseName) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.MicroteachCaseName, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.MicroteachCaseName] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetMicroteachCaseTheme(this clsMicroteachCaseEN objMicroteachCaseEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, conMicroteachCase.MicroteachCaseTheme);
objMicroteachCaseEN.MicroteachCaseTheme = strMicroteachCaseTheme; //微格教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.MicroteachCaseTheme) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.MicroteachCaseTheme, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.MicroteachCaseTheme] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetMicroteachCaseDate(this clsMicroteachCaseEN objMicroteachCaseEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, conMicroteachCase.MicroteachCaseDate);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, conMicroteachCase.MicroteachCaseDate);
objMicroteachCaseEN.MicroteachCaseDate = strMicroteachCaseDate; //微格教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.MicroteachCaseDate) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.MicroteachCaseDate, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.MicroteachCaseDate] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetMicroteachCaseTime(this clsMicroteachCaseEN objMicroteachCaseEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, conMicroteachCase.MicroteachCaseTime);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, conMicroteachCase.MicroteachCaseTime);
objMicroteachCaseEN.MicroteachCaseTime = strMicroteachCaseTime; //微格教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.MicroteachCaseTime) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.MicroteachCaseTime, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.MicroteachCaseTime] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetMicroteachCaseDateIn(this clsMicroteachCaseEN objMicroteachCaseEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, conMicroteachCase.MicroteachCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, conMicroteachCase.MicroteachCaseDateIn);
objMicroteachCaseEN.MicroteachCaseDateIn = strMicroteachCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.MicroteachCaseDateIn) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.MicroteachCaseDateIn, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.MicroteachCaseDateIn] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN Setid_StudyLevel(this clsMicroteachCaseEN objMicroteachCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, conMicroteachCase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, conMicroteachCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, conMicroteachCase.id_StudyLevel);
objMicroteachCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.id_StudyLevel) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.id_StudyLevel, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.id_StudyLevel] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN Setid_TeachingPlan(this clsMicroteachCaseEN objMicroteachCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, conMicroteachCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, conMicroteachCase.id_TeachingPlan);
objMicroteachCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.id_TeachingPlan) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.id_TeachingPlan, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.id_TeachingPlan] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetMicroTeachCaseTimeIn(this clsMicroteachCaseEN objMicroteachCaseEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, conMicroteachCase.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, conMicroteachCase.MicroTeachCaseTimeIn);
objMicroteachCaseEN.MicroTeachCaseTimeIn = strMicroTeachCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.MicroTeachCaseTimeIn) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.MicroTeachCaseTimeIn, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.MicroTeachCaseTimeIn] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN Setid_MicroteachCaseType(this clsMicroteachCaseEN objMicroteachCaseEN, string strid_MicroteachCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCaseType, 4, conMicroteachCase.id_MicroteachCaseType);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCaseType, 4, conMicroteachCase.id_MicroteachCaseType);
objMicroteachCaseEN.id_MicroteachCaseType = strid_MicroteachCaseType; //微格案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.id_MicroteachCaseType) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.id_MicroteachCaseType, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.id_MicroteachCaseType] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetId_CaseType(this clsMicroteachCaseEN objMicroteachCaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, conMicroteachCase.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, conMicroteachCase.Id_CaseType);
objMicroteachCaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.Id_CaseType) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.Id_CaseType, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.Id_CaseType] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN Setid_Discipline(this clsMicroteachCaseEN objMicroteachCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, conMicroteachCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, conMicroteachCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, conMicroteachCase.id_Discipline);
objMicroteachCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.id_Discipline) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.id_Discipline, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.id_Discipline] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetBrowseCount(this clsMicroteachCaseEN objMicroteachCaseEN, int intBrowseCount, string strComparisonOp="")
	{
objMicroteachCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.BrowseCount) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.BrowseCount, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.BrowseCount] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN Setid_SenateGaugeVersion(this clsMicroteachCaseEN objMicroteachCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conMicroteachCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conMicroteachCase.id_SenateGaugeVersion);
objMicroteachCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.id_SenateGaugeVersion) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN Setid_TeachSkill(this clsMicroteachCaseEN objMicroteachCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, conMicroteachCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, conMicroteachCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, conMicroteachCase.id_TeachSkill);
objMicroteachCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.id_TeachSkill) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.id_TeachSkill, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.id_TeachSkill] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetCaseLevelId(this clsMicroteachCaseEN objMicroteachCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conMicroteachCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conMicroteachCase.CaseLevelId);
objMicroteachCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.CaseLevelId) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.CaseLevelId, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.CaseLevelId] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetDocFile(this clsMicroteachCaseEN objMicroteachCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, conMicroteachCase.DocFile);
objMicroteachCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.DocFile) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.DocFile, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.DocFile] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetIsNeedGeneWord(this clsMicroteachCaseEN objMicroteachCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objMicroteachCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.IsNeedGeneWord) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetWordCreateDate(this clsMicroteachCaseEN objMicroteachCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conMicroteachCase.WordCreateDate);
objMicroteachCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.WordCreateDate) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.WordCreateDate, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.WordCreateDate] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetIsVisible(this clsMicroteachCaseEN objMicroteachCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objMicroteachCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.IsVisible) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.IsVisible, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.IsVisible] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetmicroteachCaseText(this clsMicroteachCaseEN objMicroteachCaseEN, string strmicroteachCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, conMicroteachCase.microteachCaseText);
objMicroteachCaseEN.microteachCaseText = strmicroteachCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.microteachCaseText) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.microteachCaseText, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.microteachCaseText] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetOwnerId(this clsMicroteachCaseEN objMicroteachCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conMicroteachCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, conMicroteachCase.OwnerId);
objMicroteachCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.OwnerId) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.OwnerId, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.OwnerId] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetIsDualVideo(this clsMicroteachCaseEN objMicroteachCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objMicroteachCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.IsDualVideo) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.IsDualVideo, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.IsDualVideo] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetUserKindId(this clsMicroteachCaseEN objMicroteachCaseEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, conMicroteachCase.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, conMicroteachCase.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, conMicroteachCase.UserKindId);
objMicroteachCaseEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.UserKindId) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.UserKindId, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.UserKindId] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetUserTypeId(this clsMicroteachCaseEN objMicroteachCaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conMicroteachCase.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conMicroteachCase.UserTypeId);
objMicroteachCaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.UserTypeId) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.UserTypeId, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.UserTypeId] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetRecommendedDegreeId(this clsMicroteachCaseEN objMicroteachCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conMicroteachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conMicroteachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conMicroteachCase.RecommendedDegreeId);
objMicroteachCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.RecommendedDegreeId) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetftpFileType(this clsMicroteachCaseEN objMicroteachCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conMicroteachCase.ftpFileType);
objMicroteachCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.ftpFileType) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.ftpFileType, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.ftpFileType] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetVideoUrl(this clsMicroteachCaseEN objMicroteachCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conMicroteachCase.VideoUrl);
objMicroteachCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.VideoUrl) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.VideoUrl, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.VideoUrl] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetVideoPath(this clsMicroteachCaseEN objMicroteachCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conMicroteachCase.VideoPath);
objMicroteachCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.VideoPath) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.VideoPath, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.VideoPath] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetResErrMsg(this clsMicroteachCaseEN objMicroteachCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conMicroteachCase.ResErrMsg);
objMicroteachCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.ResErrMsg) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.ResErrMsg, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.ResErrMsg] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetUpdDate(this clsMicroteachCaseEN objMicroteachCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conMicroteachCase.UpdDate);
objMicroteachCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.UpdDate) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.UpdDate, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.UpdDate] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetUpdUserId(this clsMicroteachCaseEN objMicroteachCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conMicroteachCase.UpdUserId);
objMicroteachCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.UpdUserId) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.UpdUserId, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.UpdUserId] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseEN SetMemo(this clsMicroteachCaseEN objMicroteachCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conMicroteachCase.Memo);
objMicroteachCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.Memo) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.Memo, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.Memo] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMicroteachCaseEN objMicroteachCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.id_MicroteachCase, objMicroteachCase_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.MicroteachCaseID) == true)
{
string strComparisonOp_MicroteachCaseID = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.MicroteachCaseID, objMicroteachCase_Cond.MicroteachCaseID, strComparisonOp_MicroteachCaseID);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.MicroteachCaseName) == true)
{
string strComparisonOp_MicroteachCaseName = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.MicroteachCaseName, objMicroteachCase_Cond.MicroteachCaseName, strComparisonOp_MicroteachCaseName);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.MicroteachCaseTheme) == true)
{
string strComparisonOp_MicroteachCaseTheme = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.MicroteachCaseTheme, objMicroteachCase_Cond.MicroteachCaseTheme, strComparisonOp_MicroteachCaseTheme);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.MicroteachCaseDate) == true)
{
string strComparisonOp_MicroteachCaseDate = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.MicroteachCaseDate, objMicroteachCase_Cond.MicroteachCaseDate, strComparisonOp_MicroteachCaseDate);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.MicroteachCaseTime) == true)
{
string strComparisonOp_MicroteachCaseTime = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.MicroteachCaseTime, objMicroteachCase_Cond.MicroteachCaseTime, strComparisonOp_MicroteachCaseTime);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.MicroteachCaseDateIn) == true)
{
string strComparisonOp_MicroteachCaseDateIn = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.MicroteachCaseDateIn, objMicroteachCase_Cond.MicroteachCaseDateIn, strComparisonOp_MicroteachCaseDateIn);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.id_StudyLevel, objMicroteachCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.id_TeachingPlan, objMicroteachCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.MicroTeachCaseTimeIn) == true)
{
string strComparisonOp_MicroTeachCaseTimeIn = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.MicroTeachCaseTimeIn, objMicroteachCase_Cond.MicroTeachCaseTimeIn, strComparisonOp_MicroTeachCaseTimeIn);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.id_MicroteachCaseType) == true)
{
string strComparisonOp_id_MicroteachCaseType = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.id_MicroteachCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.id_MicroteachCaseType, objMicroteachCase_Cond.id_MicroteachCaseType, strComparisonOp_id_MicroteachCaseType);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.Id_CaseType, objMicroteachCase_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.id_Discipline, objMicroteachCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCase.BrowseCount, objMicroteachCase_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.id_SenateGaugeVersion, objMicroteachCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.id_TeachSkill, objMicroteachCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.CaseLevelId, objMicroteachCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.DocFile) == true)
{
string strComparisonOp_DocFile = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.DocFile, objMicroteachCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.IsNeedGeneWord) == true)
{
if (objMicroteachCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachCase.IsNeedGeneWord);
}
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.WordCreateDate, objMicroteachCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.IsVisible) == true)
{
if (objMicroteachCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachCase.IsVisible);
}
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.microteachCaseText) == true)
{
string strComparisonOp_microteachCaseText = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.microteachCaseText, objMicroteachCase_Cond.microteachCaseText, strComparisonOp_microteachCaseText);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.OwnerId, objMicroteachCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.IsDualVideo) == true)
{
if (objMicroteachCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachCase.IsDualVideo);
}
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.UserKindId) == true)
{
string strComparisonOp_UserKindId = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.UserKindId, objMicroteachCase_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.UserTypeId, objMicroteachCase_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.RecommendedDegreeId, objMicroteachCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.ftpFileType, objMicroteachCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.VideoUrl, objMicroteachCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.VideoPath, objMicroteachCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.ResErrMsg, objMicroteachCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.UpdDate, objMicroteachCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.UpdUserId, objMicroteachCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objMicroteachCase_Cond.IsUpdated(conMicroteachCase.Memo) == true)
{
string strComparisonOp_Memo = objMicroteachCase_Cond.dicFldComparisonOp[conMicroteachCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.Memo, objMicroteachCase_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachCaseEN objMicroteachCaseEN)
{
 if (string.IsNullOrEmpty(objMicroteachCaseEN.id_MicroteachCase) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objMicroteachCaseEN.sf_UpdFldSetStr = objMicroteachCaseEN.getsf_UpdFldSetStr();
clsMicroteachCaseWApi.CheckPropertyNew(objMicroteachCaseEN); 
bool bolResult = clsMicroteachCaseWApi.UpdateRecord(objMicroteachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseWApi.ReFreshCache();
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
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMicroteachCaseEN objMicroteachCaseEN)
{
 if (string.IsNullOrEmpty(objMicroteachCaseEN.id_MicroteachCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsMicroteachCaseWApi.IsExist(objMicroteachCaseEN.id_MicroteachCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objMicroteachCaseEN.id_MicroteachCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsMicroteachCaseWApi.CheckPropertyNew(objMicroteachCaseEN); 
bool bolResult = clsMicroteachCaseWApi.AddNewRecord(objMicroteachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseWApi.ReFreshCache();
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
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsMicroteachCaseEN objMicroteachCaseEN)
{
try
{
clsMicroteachCaseWApi.CheckPropertyNew(objMicroteachCaseEN); 
string strid_MicroteachCase = clsMicroteachCaseWApi.AddNewRecordWithMaxId(objMicroteachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseWApi.ReFreshCache();
return strid_MicroteachCase;
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
 /// <param name = "objMicroteachCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachCaseEN objMicroteachCaseEN, string strWhereCond)
{
try
{
clsMicroteachCaseWApi.CheckPropertyNew(objMicroteachCaseEN); 
bool bolResult = clsMicroteachCaseWApi.UpdateWithCondition(objMicroteachCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseWApi.ReFreshCache();
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
 /// 微格教学案例(MicroteachCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsMicroteachCaseWApi
{
private static readonly string mstrApiControllerName = "MicroteachCaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsMicroteachCaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_MicroteachCase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[微格教学案例]...","0");
List<clsMicroteachCaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_MicroteachCase";
objDDL.DataTextField="MicroteachCaseName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_id_MicroteachCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conMicroteachCase.id_MicroteachCase); 
List<clsMicroteachCaseEN> arrObjLst = clsMicroteachCaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN()
{
id_MicroteachCase = "0",
MicroteachCaseName = "选[微格教学案例]..."
};
arrObjLst.Insert(0, objMicroteachCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conMicroteachCase.id_MicroteachCase;
objComboBox.DisplayMember = conMicroteachCase.MicroteachCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsMicroteachCaseEN objMicroteachCaseEN)
{
if (!Object.Equals(null, objMicroteachCaseEN.id_MicroteachCase) && GetStrLen(objMicroteachCaseEN.id_MicroteachCase) > 8)
{
 throw new Exception("字段[微格教学案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objMicroteachCaseEN.MicroteachCaseID) && GetStrLen(objMicroteachCaseEN.MicroteachCaseID) > 8)
{
 throw new Exception("字段[微格教学案例ID]的长度不能超过8!");
}
if (!Object.Equals(null, objMicroteachCaseEN.MicroteachCaseName) && GetStrLen(objMicroteachCaseEN.MicroteachCaseName) > 100)
{
 throw new Exception("字段[微格教学案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objMicroteachCaseEN.MicroteachCaseTheme) && GetStrLen(objMicroteachCaseEN.MicroteachCaseTheme) > 200)
{
 throw new Exception("字段[微格教学案例主题词]的长度不能超过200!");
}
if (!Object.Equals(null, objMicroteachCaseEN.MicroteachCaseDate) && GetStrLen(objMicroteachCaseEN.MicroteachCaseDate) > 8)
{
 throw new Exception("字段[微格教学日期]的长度不能超过8!");
}
if (!Object.Equals(null, objMicroteachCaseEN.MicroteachCaseTime) && GetStrLen(objMicroteachCaseEN.MicroteachCaseTime) > 6)
{
 throw new Exception("字段[微格教学时间]的长度不能超过6!");
}
if (!Object.Equals(null, objMicroteachCaseEN.MicroteachCaseDateIn) && GetStrLen(objMicroteachCaseEN.MicroteachCaseDateIn) > 8)
{
 throw new Exception("字段[案例入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objMicroteachCaseEN.id_StudyLevel) && GetStrLen(objMicroteachCaseEN.id_StudyLevel) > 4)
{
 throw new Exception("字段[id_StudyLevel]的长度不能超过4!");
}
if (!Object.Equals(null, objMicroteachCaseEN.id_TeachingPlan) && GetStrLen(objMicroteachCaseEN.id_TeachingPlan) > 8)
{
 throw new Exception("字段[教案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objMicroteachCaseEN.MicroTeachCaseTimeIn) && GetStrLen(objMicroteachCaseEN.MicroTeachCaseTimeIn) > 6)
{
 throw new Exception("字段[案例入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objMicroteachCaseEN.id_MicroteachCaseType) && GetStrLen(objMicroteachCaseEN.id_MicroteachCaseType) > 4)
{
 throw new Exception("字段[微格案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objMicroteachCaseEN.Id_CaseType) && GetStrLen(objMicroteachCaseEN.Id_CaseType) > 4)
{
 throw new Exception("字段[案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objMicroteachCaseEN.id_Discipline) && GetStrLen(objMicroteachCaseEN.id_Discipline) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objMicroteachCaseEN.id_SenateGaugeVersion) && GetStrLen(objMicroteachCaseEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objMicroteachCaseEN.id_TeachSkill) && GetStrLen(objMicroteachCaseEN.id_TeachSkill) > 8)
{
 throw new Exception("字段[教学技能流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objMicroteachCaseEN.CaseLevelId) && GetStrLen(objMicroteachCaseEN.CaseLevelId) > 2)
{
 throw new Exception("字段[课例等级Id]的长度不能超过2!");
}
if (!Object.Equals(null, objMicroteachCaseEN.DocFile) && GetStrLen(objMicroteachCaseEN.DocFile) > 200)
{
 throw new Exception("字段[生成的Word文件名]的长度不能超过200!");
}
if (!Object.Equals(null, objMicroteachCaseEN.WordCreateDate) && GetStrLen(objMicroteachCaseEN.WordCreateDate) > 14)
{
 throw new Exception("字段[Word生成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objMicroteachCaseEN.microteachCaseText) && GetStrLen(objMicroteachCaseEN.microteachCaseText) > 8000)
{
 throw new Exception("字段[案例文本内容]的长度不能超过8000!");
}
if (!Object.Equals(null, objMicroteachCaseEN.OwnerId) && GetStrLen(objMicroteachCaseEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objMicroteachCaseEN.UserKindId) && GetStrLen(objMicroteachCaseEN.UserKindId) > 2)
{
 throw new Exception("字段[用户类别Id]的长度不能超过2!");
}
if (!Object.Equals(null, objMicroteachCaseEN.UserTypeId) && GetStrLen(objMicroteachCaseEN.UserTypeId) > 2)
{
 throw new Exception("字段[用户类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objMicroteachCaseEN.RecommendedDegreeId) && GetStrLen(objMicroteachCaseEN.RecommendedDegreeId) > 2)
{
 throw new Exception("字段[推荐度Id]的长度不能超过2!");
}
if (!Object.Equals(null, objMicroteachCaseEN.ftpFileType) && GetStrLen(objMicroteachCaseEN.ftpFileType) > 30)
{
 throw new Exception("字段[ftp文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objMicroteachCaseEN.VideoUrl) && GetStrLen(objMicroteachCaseEN.VideoUrl) > 1000)
{
 throw new Exception("字段[视频Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objMicroteachCaseEN.VideoPath) && GetStrLen(objMicroteachCaseEN.VideoPath) > 1000)
{
 throw new Exception("字段[视频目录]的长度不能超过1000!");
}
if (!Object.Equals(null, objMicroteachCaseEN.ResErrMsg) && GetStrLen(objMicroteachCaseEN.ResErrMsg) > 30)
{
 throw new Exception("字段[资源错误信息]的长度不能超过30!");
}
if (!Object.Equals(null, objMicroteachCaseEN.UpdDate) && GetStrLen(objMicroteachCaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objMicroteachCaseEN.UpdUserId) && GetStrLen(objMicroteachCaseEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objMicroteachCaseEN.Memo) && GetStrLen(objMicroteachCaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objMicroteachCaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_MicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCaseEN GetObjByid_MicroteachCase(string strid_MicroteachCase)
{
string strAction = "GetObjByid_MicroteachCase";
string strErrMsg = string.Empty;
string strResult = "";
clsMicroteachCaseEN objMicroteachCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase"] = strid_MicroteachCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objMicroteachCaseEN = JsonConvert.DeserializeObject<clsMicroteachCaseEN>((string)jobjReturn["ReturnObj"]);
return objMicroteachCaseEN;
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
 /// <param name = "strid_MicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCaseEN GetObjByid_MicroteachCase_WA_Cache(string strid_MicroteachCase)
{
string strAction = "GetObjByid_MicroteachCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsMicroteachCaseEN objMicroteachCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase"] = strid_MicroteachCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objMicroteachCaseEN = JsonConvert.DeserializeObject<clsMicroteachCaseEN>((string)jobjReturn["ReturnObj"]);
return objMicroteachCaseEN;
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
public static clsMicroteachCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsMicroteachCaseEN objMicroteachCaseEN = null;
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
objMicroteachCaseEN = JsonConvert.DeserializeObject<clsMicroteachCaseEN>((string)jobjReturn["ReturnObj"]);
return objMicroteachCaseEN;
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
 /// <param name = "strid_MicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroteachCaseEN GetObjByid_MicroteachCase_Cache(string strid_MicroteachCase)
{
if (string.IsNullOrEmpty(strid_MicroteachCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsMicroteachCaseEN._CurrTabName_S);
List<clsMicroteachCaseEN> arrMicroteachCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMicroteachCaseEN> arrMicroteachCaseObjLst_Sel =
from objMicroteachCaseEN in arrMicroteachCaseObjLst_Cache
where objMicroteachCaseEN.id_MicroteachCase == strid_MicroteachCase
select objMicroteachCaseEN;
if (arrMicroteachCaseObjLst_Sel.Count() == 0)
{
   clsMicroteachCaseEN obj = clsMicroteachCaseWApi.GetObjByid_MicroteachCase(strid_MicroteachCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrMicroteachCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_MicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMicroteachCaseNameByid_MicroteachCase_Cache(string strid_MicroteachCase)
{
if (string.IsNullOrEmpty(strid_MicroteachCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsMicroteachCaseEN._CurrTabName_S);
List<clsMicroteachCaseEN> arrMicroteachCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMicroteachCaseEN> arrMicroteachCaseObjLst_Sel1 =
from objMicroteachCaseEN in arrMicroteachCaseObjLst_Cache
where objMicroteachCaseEN.id_MicroteachCase == strid_MicroteachCase
select objMicroteachCaseEN;
List <clsMicroteachCaseEN> arrMicroteachCaseObjLst_Sel = new List<clsMicroteachCaseEN>();
foreach (clsMicroteachCaseEN obj in arrMicroteachCaseObjLst_Sel1)
{
arrMicroteachCaseObjLst_Sel.Add(obj);
}
if (arrMicroteachCaseObjLst_Sel.Count > 0)
{
return arrMicroteachCaseObjLst_Sel[0].MicroteachCaseName;
}
string strErrMsgForGetObjById = string.Format("在MicroteachCase对象缓存列表中,找不到记录[id_MicroteachCase = {0}](函数:{1})", strid_MicroteachCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsMicroteachCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_MicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_MicroteachCase_Cache(string strid_MicroteachCase)
{
if (string.IsNullOrEmpty(strid_MicroteachCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsMicroteachCaseEN._CurrTabName_S);
List<clsMicroteachCaseEN> arrMicroteachCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMicroteachCaseEN> arrMicroteachCaseObjLst_Sel1 =
from objMicroteachCaseEN in arrMicroteachCaseObjLst_Cache
where objMicroteachCaseEN.id_MicroteachCase == strid_MicroteachCase
select objMicroteachCaseEN;
List <clsMicroteachCaseEN> arrMicroteachCaseObjLst_Sel = new List<clsMicroteachCaseEN>();
foreach (clsMicroteachCaseEN obj in arrMicroteachCaseObjLst_Sel1)
{
arrMicroteachCaseObjLst_Sel.Add(obj);
}
if (arrMicroteachCaseObjLst_Sel.Count > 0)
{
return arrMicroteachCaseObjLst_Sel[0].MicroteachCaseName;
}
string strErrMsgForGetObjById = string.Format("在MicroteachCase对象缓存列表中,找不到记录的相关名称[id_MicroteachCase = {0}](函数:{1})", strid_MicroteachCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsMicroteachCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseEN> GetObjLst(string strWhereCond)
{
 List<clsMicroteachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseEN> GetObjLstById_MicroteachCaseLst(List<string> arrId_MicroteachCase)
{
 List<clsMicroteachCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_MicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsMicroteachCaseEN> GetObjLstById_MicroteachCaseLst_Cache(List<string> arrId_MicroteachCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsMicroteachCaseEN._CurrTabName_S);
List<clsMicroteachCaseEN> arrMicroteachCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMicroteachCaseEN> arrMicroteachCaseObjLst_Sel =
from objMicroteachCaseEN in arrMicroteachCaseObjLst_Cache
where arrId_MicroteachCase.Contains(objMicroteachCaseEN.id_MicroteachCase)
select objMicroteachCaseEN;
return arrMicroteachCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseEN> GetObjLstById_MicroteachCaseLst_WA_Cache(List<string> arrId_MicroteachCase)
{
 List<clsMicroteachCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsMicroteachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsMicroteachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsMicroteachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsMicroteachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_MicroteachCase)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsMicroteachCaseEN objMicroteachCaseEN = clsMicroteachCaseWApi.GetObjByid_MicroteachCase(strid_MicroteachCase);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_MicroteachCase.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsMicroteachCaseWApi.ReFreshCache();
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
public static int DelMicroteachCases(List<string> arrid_MicroteachCase)
{
string strAction = "DelMicroteachCases";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_MicroteachCase);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsMicroteachCaseWApi.ReFreshCache();
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
public static int DelMicroteachCasesByCond(string strWhereCond)
{
string strAction = "DelMicroteachCasesByCond";
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
public static bool AddNewRecord(clsMicroteachCaseEN objMicroteachCaseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseEN>(objMicroteachCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsMicroteachCaseEN objMicroteachCaseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseEN>(objMicroteachCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseWApi.ReFreshCache();
var strid_MicroteachCase = (string)jobjReturn["ReturnStr"];
return strid_MicroteachCase;
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
public static bool UpdateRecord(clsMicroteachCaseEN objMicroteachCaseEN)
{
if (string.IsNullOrEmpty(objMicroteachCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMicroteachCaseEN.id_MicroteachCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseEN>(objMicroteachCaseEN);
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
 /// <param name = "objMicroteachCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsMicroteachCaseEN objMicroteachCaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objMicroteachCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMicroteachCaseEN.id_MicroteachCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMicroteachCaseEN.id_MicroteachCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseEN>(objMicroteachCaseEN);
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
public static bool IsExist(string strid_MicroteachCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase"] = strid_MicroteachCase
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
 /// <param name = "objMicroteachCaseENS">源对象</param>
 /// <param name = "objMicroteachCaseENT">目标对象</param>
 public static void CopyTo(clsMicroteachCaseEN objMicroteachCaseENS, clsMicroteachCaseEN objMicroteachCaseENT)
{
try
{
objMicroteachCaseENT.id_MicroteachCase = objMicroteachCaseENS.id_MicroteachCase; //微格教学案例流水号
objMicroteachCaseENT.MicroteachCaseID = objMicroteachCaseENS.MicroteachCaseID; //微格教学案例ID
objMicroteachCaseENT.MicroteachCaseName = objMicroteachCaseENS.MicroteachCaseName; //微格教学案例名称
objMicroteachCaseENT.MicroteachCaseTheme = objMicroteachCaseENS.MicroteachCaseTheme; //微格教学案例主题词
objMicroteachCaseENT.MicroteachCaseDate = objMicroteachCaseENS.MicroteachCaseDate; //微格教学日期
objMicroteachCaseENT.MicroteachCaseTime = objMicroteachCaseENS.MicroteachCaseTime; //微格教学时间
objMicroteachCaseENT.MicroteachCaseDateIn = objMicroteachCaseENS.MicroteachCaseDateIn; //案例入库日期
objMicroteachCaseENT.id_StudyLevel = objMicroteachCaseENS.id_StudyLevel; //id_StudyLevel
objMicroteachCaseENT.id_TeachingPlan = objMicroteachCaseENS.id_TeachingPlan; //教案流水号
objMicroteachCaseENT.MicroTeachCaseTimeIn = objMicroteachCaseENS.MicroTeachCaseTimeIn; //案例入库时间
objMicroteachCaseENT.id_MicroteachCaseType = objMicroteachCaseENS.id_MicroteachCaseType; //微格案例类型流水号
objMicroteachCaseENT.Id_CaseType = objMicroteachCaseENS.Id_CaseType; //案例类型流水号
objMicroteachCaseENT.id_Discipline = objMicroteachCaseENS.id_Discipline; //学科流水号
objMicroteachCaseENT.BrowseCount = objMicroteachCaseENS.BrowseCount; //浏览次数
objMicroteachCaseENT.id_SenateGaugeVersion = objMicroteachCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objMicroteachCaseENT.id_TeachSkill = objMicroteachCaseENS.id_TeachSkill; //教学技能流水号
objMicroteachCaseENT.CaseLevelId = objMicroteachCaseENS.CaseLevelId; //课例等级Id
objMicroteachCaseENT.DocFile = objMicroteachCaseENS.DocFile; //生成的Word文件名
objMicroteachCaseENT.IsNeedGeneWord = objMicroteachCaseENS.IsNeedGeneWord; //是否需要生成Word
objMicroteachCaseENT.WordCreateDate = objMicroteachCaseENS.WordCreateDate; //Word生成日期
objMicroteachCaseENT.IsVisible = objMicroteachCaseENS.IsVisible; //是否显示
objMicroteachCaseENT.microteachCaseText = objMicroteachCaseENS.microteachCaseText; //案例文本内容
objMicroteachCaseENT.OwnerId = objMicroteachCaseENS.OwnerId; //拥有者Id
objMicroteachCaseENT.IsDualVideo = objMicroteachCaseENS.IsDualVideo; //是否双视频
objMicroteachCaseENT.UserKindId = objMicroteachCaseENS.UserKindId; //用户类别Id
objMicroteachCaseENT.UserTypeId = objMicroteachCaseENS.UserTypeId; //用户类型Id
objMicroteachCaseENT.RecommendedDegreeId = objMicroteachCaseENS.RecommendedDegreeId; //推荐度Id
objMicroteachCaseENT.ftpFileType = objMicroteachCaseENS.ftpFileType; //ftp文件类型
objMicroteachCaseENT.VideoUrl = objMicroteachCaseENS.VideoUrl; //视频Url
objMicroteachCaseENT.VideoPath = objMicroteachCaseENS.VideoPath; //视频目录
objMicroteachCaseENT.ResErrMsg = objMicroteachCaseENS.ResErrMsg; //资源错误信息
objMicroteachCaseENT.UpdDate = objMicroteachCaseENS.UpdDate; //修改日期
objMicroteachCaseENT.UpdUserId = objMicroteachCaseENS.UpdUserId; //修改用户Id
objMicroteachCaseENT.Memo = objMicroteachCaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsMicroteachCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsMicroteachCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsMicroteachCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsMicroteachCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsMicroteachCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsMicroteachCaseEN.AttributeName)
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
if (clsMicroteachCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseWApi没有刷新缓存机制(clsMicroteachCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase");
//if (arrMicroteachCaseObjLst_Cache == null)
//{
//arrMicroteachCaseObjLst_Cache = await clsMicroteachCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsMicroteachCaseEN._CurrTabName_S);
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
if (clsMicroteachCaseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMicroteachCaseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsMicroteachCaseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsMicroteachCaseEN._CurrTabName_S);
List<clsMicroteachCaseEN> arrMicroteachCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMicroteachCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsMicroteachCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conMicroteachCase.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.MicroteachCaseID, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.MicroteachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.MicroteachCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.MicroteachCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.MicroteachCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.MicroteachCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.MicroTeachCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.id_MicroteachCaseType, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conMicroteachCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(conMicroteachCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conMicroteachCase.microteachCaseText, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conMicroteachCase.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCase.Memo, Type.GetType("System.String"));
foreach (clsMicroteachCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conMicroteachCase.id_MicroteachCase] = objInFor[conMicroteachCase.id_MicroteachCase];
objDR[conMicroteachCase.MicroteachCaseID] = objInFor[conMicroteachCase.MicroteachCaseID];
objDR[conMicroteachCase.MicroteachCaseName] = objInFor[conMicroteachCase.MicroteachCaseName];
objDR[conMicroteachCase.MicroteachCaseTheme] = objInFor[conMicroteachCase.MicroteachCaseTheme];
objDR[conMicroteachCase.MicroteachCaseDate] = objInFor[conMicroteachCase.MicroteachCaseDate];
objDR[conMicroteachCase.MicroteachCaseTime] = objInFor[conMicroteachCase.MicroteachCaseTime];
objDR[conMicroteachCase.MicroteachCaseDateIn] = objInFor[conMicroteachCase.MicroteachCaseDateIn];
objDR[conMicroteachCase.id_StudyLevel] = objInFor[conMicroteachCase.id_StudyLevel];
objDR[conMicroteachCase.id_TeachingPlan] = objInFor[conMicroteachCase.id_TeachingPlan];
objDR[conMicroteachCase.MicroTeachCaseTimeIn] = objInFor[conMicroteachCase.MicroTeachCaseTimeIn];
objDR[conMicroteachCase.id_MicroteachCaseType] = objInFor[conMicroteachCase.id_MicroteachCaseType];
objDR[conMicroteachCase.Id_CaseType] = objInFor[conMicroteachCase.Id_CaseType];
objDR[conMicroteachCase.id_Discipline] = objInFor[conMicroteachCase.id_Discipline];
objDR[conMicroteachCase.BrowseCount] = objInFor[conMicroteachCase.BrowseCount];
objDR[conMicroteachCase.id_SenateGaugeVersion] = objInFor[conMicroteachCase.id_SenateGaugeVersion];
objDR[conMicroteachCase.id_TeachSkill] = objInFor[conMicroteachCase.id_TeachSkill];
objDR[conMicroteachCase.CaseLevelId] = objInFor[conMicroteachCase.CaseLevelId];
objDR[conMicroteachCase.DocFile] = objInFor[conMicroteachCase.DocFile];
objDR[conMicroteachCase.IsNeedGeneWord] = objInFor[conMicroteachCase.IsNeedGeneWord];
objDR[conMicroteachCase.WordCreateDate] = objInFor[conMicroteachCase.WordCreateDate];
objDR[conMicroteachCase.IsVisible] = objInFor[conMicroteachCase.IsVisible];
objDR[conMicroteachCase.microteachCaseText] = objInFor[conMicroteachCase.microteachCaseText];
objDR[conMicroteachCase.OwnerId] = objInFor[conMicroteachCase.OwnerId];
objDR[conMicroteachCase.IsDualVideo] = objInFor[conMicroteachCase.IsDualVideo];
objDR[conMicroteachCase.UserKindId] = objInFor[conMicroteachCase.UserKindId];
objDR[conMicroteachCase.UserTypeId] = objInFor[conMicroteachCase.UserTypeId];
objDR[conMicroteachCase.RecommendedDegreeId] = objInFor[conMicroteachCase.RecommendedDegreeId];
objDR[conMicroteachCase.ftpFileType] = objInFor[conMicroteachCase.ftpFileType];
objDR[conMicroteachCase.VideoUrl] = objInFor[conMicroteachCase.VideoUrl];
objDR[conMicroteachCase.VideoPath] = objInFor[conMicroteachCase.VideoPath];
objDR[conMicroteachCase.ResErrMsg] = objInFor[conMicroteachCase.ResErrMsg];
objDR[conMicroteachCase.UpdDate] = objInFor[conMicroteachCase.UpdDate];
objDR[conMicroteachCase.UpdUserId] = objInFor[conMicroteachCase.UpdUserId];
objDR[conMicroteachCase.Memo] = objInFor[conMicroteachCase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 微格教学案例(MicroteachCase)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4MicroteachCase : clsCommFun4BL
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
clsMicroteachCaseWApi.ReFreshThisCache();
}
}

}