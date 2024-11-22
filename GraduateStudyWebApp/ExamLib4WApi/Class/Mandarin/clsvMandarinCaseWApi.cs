
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMandarinCaseWApi
 表名:vMandarinCase(01120465)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:41
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:普通话点播
 模块英文名:Mandarin
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
public static class clsvMandarinCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN Setid_MandarinCase(this clsvMandarinCaseEN objvMandarinCaseEN, string strid_MandarinCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MandarinCase, 8, convMandarinCase.id_MandarinCase);
clsCheckSql.CheckFieldForeignKey(strid_MandarinCase, 8, convMandarinCase.id_MandarinCase);
objvMandarinCaseEN.id_MandarinCase = strid_MandarinCase; //普通话案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.id_MandarinCase) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.id_MandarinCase, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.id_MandarinCase] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetMandarinCaseID(this clsvMandarinCaseEN objvMandarinCaseEN, string strMandarinCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMandarinCaseID, convMandarinCase.MandarinCaseID);
clsCheckSql.CheckFieldLen(strMandarinCaseID, 8, convMandarinCase.MandarinCaseID);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseID, 8, convMandarinCase.MandarinCaseID);
objvMandarinCaseEN.MandarinCaseID = strMandarinCaseID; //普通话教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.MandarinCaseID) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.MandarinCaseID, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.MandarinCaseID] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetMandarinCaseName(this clsvMandarinCaseEN objvMandarinCaseEN, string strMandarinCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMandarinCaseName, convMandarinCase.MandarinCaseName);
clsCheckSql.CheckFieldLen(strMandarinCaseName, 100, convMandarinCase.MandarinCaseName);
objvMandarinCaseEN.MandarinCaseName = strMandarinCaseName; //普通话教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.MandarinCaseName) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.MandarinCaseName, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.MandarinCaseName] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN Setid_Discipline(this clsvMandarinCaseEN objvMandarinCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convMandarinCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convMandarinCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convMandarinCase.id_Discipline);
objvMandarinCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.id_Discipline) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.id_Discipline, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.id_Discipline] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetDisciplineID(this clsvMandarinCaseEN objvMandarinCaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineID, convMandarinCase.DisciplineID);
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convMandarinCase.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convMandarinCase.DisciplineID);
objvMandarinCaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.DisciplineID) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.DisciplineID, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.DisciplineID] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetDisciplineName(this clsvMandarinCaseEN objvMandarinCaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convMandarinCase.DisciplineName);
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convMandarinCase.DisciplineName);
objvMandarinCaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.DisciplineName) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.DisciplineName, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.DisciplineName] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN Setid_StudyLevel(this clsvMandarinCaseEN objvMandarinCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convMandarinCase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convMandarinCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convMandarinCase.id_StudyLevel);
objvMandarinCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.id_StudyLevel) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.id_StudyLevel, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.id_StudyLevel] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetStudyLevelName(this clsvMandarinCaseEN objvMandarinCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convMandarinCase.StudyLevelName);
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMandarinCase.StudyLevelName);
objvMandarinCaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.StudyLevelName) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.StudyLevelName, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.StudyLevelName] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetMandarinCaseTheme(this clsvMandarinCaseEN objvMandarinCaseEN, string strMandarinCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseTheme, 200, convMandarinCase.MandarinCaseTheme);
objvMandarinCaseEN.MandarinCaseTheme = strMandarinCaseTheme; //普通话教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.MandarinCaseTheme) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.MandarinCaseTheme, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.MandarinCaseTheme] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetMandarinCaseDate(this clsvMandarinCaseEN objvMandarinCaseEN, string strMandarinCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseDate, 8, convMandarinCase.MandarinCaseDate);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseDate, 8, convMandarinCase.MandarinCaseDate);
objvMandarinCaseEN.MandarinCaseDate = strMandarinCaseDate; //普通话教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.MandarinCaseDate) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.MandarinCaseDate, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.MandarinCaseDate] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetMandarinCaseTime(this clsvMandarinCaseEN objvMandarinCaseEN, string strMandarinCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseTime, 6, convMandarinCase.MandarinCaseTime);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseTime, 6, convMandarinCase.MandarinCaseTime);
objvMandarinCaseEN.MandarinCaseTime = strMandarinCaseTime; //普通话教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.MandarinCaseTime) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.MandarinCaseTime, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.MandarinCaseTime] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetMandarinCaseDateIn(this clsvMandarinCaseEN objvMandarinCaseEN, string strMandarinCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseDateIn, 8, convMandarinCase.MandarinCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseDateIn, 8, convMandarinCase.MandarinCaseDateIn);
objvMandarinCaseEN.MandarinCaseDateIn = strMandarinCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.MandarinCaseDateIn) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.MandarinCaseDateIn, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.MandarinCaseDateIn] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetMandarinCaseTimeIn(this clsvMandarinCaseEN objvMandarinCaseEN, string strMandarinCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseTimeIn, 6, convMandarinCase.MandarinCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseTimeIn, 6, convMandarinCase.MandarinCaseTimeIn);
objvMandarinCaseEN.MandarinCaseTimeIn = strMandarinCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.MandarinCaseTimeIn) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.MandarinCaseTimeIn, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.MandarinCaseTimeIn] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN Setid_TeachingPlan(this clsvMandarinCaseEN objvMandarinCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingPlan, convMandarinCase.id_TeachingPlan);
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convMandarinCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convMandarinCase.id_TeachingPlan);
objvMandarinCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.id_TeachingPlan) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.id_TeachingPlan, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.id_TeachingPlan] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN Setid_SenateGaugeVersion(this clsvMandarinCaseEN objvMandarinCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convMandarinCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convMandarinCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convMandarinCase.id_SenateGaugeVersion);
objvMandarinCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.id_SenateGaugeVersion) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetsenateGaugeVersionID(this clsvMandarinCaseEN objvMandarinCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convMandarinCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMandarinCase.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMandarinCase.senateGaugeVersionID);
objvMandarinCaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.senateGaugeVersionID) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.senateGaugeVersionID, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.senateGaugeVersionID] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetsenateGaugeVersionName(this clsvMandarinCaseEN objvMandarinCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMandarinCase.senateGaugeVersionName);
objvMandarinCaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.senateGaugeVersionName) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.senateGaugeVersionName, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.senateGaugeVersionName] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetsenateGaugeVersionTtlScore(this clsvMandarinCaseEN objvMandarinCaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convMandarinCase.senateGaugeVersionTtlScore);
objvMandarinCaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.senateGaugeVersionTtlScore) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetVersionNo(this clsvMandarinCaseEN objvMandarinCaseEN, int intVersionNo, string strComparisonOp="")
	{
objvMandarinCaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.VersionNo) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.VersionNo, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.VersionNo] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetCaseLevelId(this clsvMandarinCaseEN objvMandarinCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convMandarinCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convMandarinCase.CaseLevelId);
objvMandarinCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.CaseLevelId) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.CaseLevelId, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.CaseLevelId] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetIsNeedGeneWord(this clsvMandarinCaseEN objvMandarinCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvMandarinCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.IsNeedGeneWord) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetDocFile(this clsvMandarinCaseEN objvMandarinCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convMandarinCase.DocFile);
objvMandarinCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.DocFile) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.DocFile, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.DocFile] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetWordCreateDate(this clsvMandarinCaseEN objvMandarinCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convMandarinCase.WordCreateDate);
objvMandarinCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.WordCreateDate) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.WordCreateDate, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.WordCreateDate] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetIsVisible(this clsvMandarinCaseEN objvMandarinCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvMandarinCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.IsVisible) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.IsVisible, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.IsVisible] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetOwnerId(this clsvMandarinCaseEN objvMandarinCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convMandarinCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMandarinCase.OwnerId);
objvMandarinCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.OwnerId) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.OwnerId, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.OwnerId] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetStuName(this clsvMandarinCaseEN objvMandarinCaseEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convMandarinCase.StuName);
objvMandarinCaseEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.StuName) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.StuName, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.StuName] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetStuID(this clsvMandarinCaseEN objvMandarinCaseEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convMandarinCase.StuID);
objvMandarinCaseEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.StuID) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.StuID, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.StuID] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetCollegeID(this clsvMandarinCaseEN objvMandarinCaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMandarinCase.CollegeID);
objvMandarinCaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.CollegeID) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.CollegeID, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.CollegeID] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetCollegeName(this clsvMandarinCaseEN objvMandarinCaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convMandarinCase.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMandarinCase.CollegeName);
objvMandarinCaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.CollegeName) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.CollegeName, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.CollegeName] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN Setid_XzCollege(this clsvMandarinCaseEN objvMandarinCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convMandarinCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convMandarinCase.id_XzCollege);
objvMandarinCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.id_XzCollege) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.id_XzCollege, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.id_XzCollege] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetCollegeNameA(this clsvMandarinCaseEN objvMandarinCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMandarinCase.CollegeNameA);
objvMandarinCaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.CollegeNameA) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.CollegeNameA, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.CollegeNameA] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN Setid_XzMajor(this clsvMandarinCaseEN objvMandarinCaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convMandarinCase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convMandarinCase.id_XzMajor);
objvMandarinCaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.id_XzMajor) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.id_XzMajor, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.id_XzMajor] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetMajorName(this clsvMandarinCaseEN objvMandarinCaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convMandarinCase.MajorName);
objvMandarinCaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.MajorName) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.MajorName, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.MajorName] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN Setid_GradeBase(this clsvMandarinCaseEN objvMandarinCaseEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convMandarinCase.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convMandarinCase.id_GradeBase);
objvMandarinCaseEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.id_GradeBase) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.id_GradeBase, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.id_GradeBase] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetGradeBaseName(this clsvMandarinCaseEN objvMandarinCaseEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convMandarinCase.GradeBaseName);
objvMandarinCaseEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.GradeBaseName) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.GradeBaseName, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.GradeBaseName] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN Setid_AdminCls(this clsvMandarinCaseEN objvMandarinCaseEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convMandarinCase.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convMandarinCase.id_AdminCls);
objvMandarinCaseEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.id_AdminCls) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.id_AdminCls, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.id_AdminCls] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetIsDualVideo(this clsvMandarinCaseEN objvMandarinCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, convMandarinCase.IsDualVideo);
objvMandarinCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.IsDualVideo) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.IsDualVideo, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.IsDualVideo] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN Setid_MandarinCaseType(this clsvMandarinCaseEN objvMandarinCaseEN, string strid_MandarinCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MandarinCaseType, convMandarinCase.id_MandarinCaseType);
clsCheckSql.CheckFieldLen(strid_MandarinCaseType, 4, convMandarinCase.id_MandarinCaseType);
clsCheckSql.CheckFieldForeignKey(strid_MandarinCaseType, 4, convMandarinCase.id_MandarinCaseType);
objvMandarinCaseEN.id_MandarinCaseType = strid_MandarinCaseType; //普通话案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.id_MandarinCaseType) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.id_MandarinCaseType, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.id_MandarinCaseType] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetMandarinCaseTypeName(this clsvMandarinCaseEN objvMandarinCaseEN, string strMandarinCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseTypeName, 50, convMandarinCase.MandarinCaseTypeName);
objvMandarinCaseEN.MandarinCaseTypeName = strMandarinCaseTypeName; //普通话案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.MandarinCaseTypeName) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.MandarinCaseTypeName, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.MandarinCaseTypeName] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetUserTypeId(this clsvMandarinCaseEN objvMandarinCaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMandarinCase.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMandarinCase.UserTypeId);
objvMandarinCaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.UserTypeId) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.UserTypeId, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.UserTypeId] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetUserTypeName(this clsvMandarinCaseEN objvMandarinCaseEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convMandarinCase.UserTypeName);
objvMandarinCaseEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.UserTypeName) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.UserTypeName, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.UserTypeName] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetRecommendedDegreeId(this clsvMandarinCaseEN objvMandarinCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convMandarinCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convMandarinCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convMandarinCase.RecommendedDegreeId);
objvMandarinCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.RecommendedDegreeId) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetRecommendedDegreeName(this clsvMandarinCaseEN objvMandarinCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convMandarinCase.RecommendedDegreeName);
objvMandarinCaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.RecommendedDegreeName) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.RecommendedDegreeName, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.RecommendedDegreeName] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetftpFileType(this clsvMandarinCaseEN objvMandarinCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMandarinCase.ftpFileType);
objvMandarinCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.ftpFileType) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.ftpFileType, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.ftpFileType] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetVideoUrl(this clsvMandarinCaseEN objvMandarinCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convMandarinCase.VideoUrl);
objvMandarinCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.VideoUrl) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.VideoUrl, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.VideoUrl] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetVideoPath(this clsvMandarinCaseEN objvMandarinCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convMandarinCase.VideoPath);
objvMandarinCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.VideoPath) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.VideoPath, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.VideoPath] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetResErrMsg(this clsvMandarinCaseEN objvMandarinCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convMandarinCase.ResErrMsg);
objvMandarinCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.ResErrMsg) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.ResErrMsg, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.ResErrMsg] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetUpdDate(this clsvMandarinCaseEN objvMandarinCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMandarinCase.UpdDate);
objvMandarinCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.UpdDate) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.UpdDate, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.UpdDate] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetUpdUserId(this clsvMandarinCaseEN objvMandarinCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convMandarinCase.UpdUserId);
objvMandarinCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.UpdUserId) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.UpdUserId, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.UpdUserId] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetMemo(this clsvMandarinCaseEN objvMandarinCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMandarinCase.Memo);
objvMandarinCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.Memo) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.Memo, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.Memo] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetBrowseCount4Case(this clsvMandarinCaseEN objvMandarinCaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvMandarinCaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.BrowseCount4Case) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.BrowseCount4Case, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.BrowseCount4Case] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetIsHaveVideo(this clsvMandarinCaseEN objvMandarinCaseEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convMandarinCase.IsHaveVideo);
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convMandarinCase.IsHaveVideo);
objvMandarinCaseEN.IsHaveVideo = strIsHaveVideo; //IsHaveVideo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.IsHaveVideo) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.IsHaveVideo, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.IsHaveVideo] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetOwnerNameWithId(this clsvMandarinCaseEN objvMandarinCaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convMandarinCase.OwnerNameWithId);
objvMandarinCaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.OwnerNameWithId) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.OwnerNameWithId, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.OwnerNameWithId] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseEN SetOwnerName(this clsvMandarinCaseEN objvMandarinCaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMandarinCase.OwnerName);
objvMandarinCaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseEN.dicFldComparisonOp.ContainsKey(convMandarinCase.OwnerName) == false)
{
objvMandarinCaseEN.dicFldComparisonOp.Add(convMandarinCase.OwnerName, strComparisonOp);
}
else
{
objvMandarinCaseEN.dicFldComparisonOp[convMandarinCase.OwnerName] = strComparisonOp;
}
}
return objvMandarinCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMandarinCaseEN objvMandarinCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.id_MandarinCase) == true)
{
string strComparisonOp_id_MandarinCase = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.id_MandarinCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.id_MandarinCase, objvMandarinCase_Cond.id_MandarinCase, strComparisonOp_id_MandarinCase);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.MandarinCaseID) == true)
{
string strComparisonOp_MandarinCaseID = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.MandarinCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.MandarinCaseID, objvMandarinCase_Cond.MandarinCaseID, strComparisonOp_MandarinCaseID);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.MandarinCaseName) == true)
{
string strComparisonOp_MandarinCaseName = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.MandarinCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.MandarinCaseName, objvMandarinCase_Cond.MandarinCaseName, strComparisonOp_MandarinCaseName);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.id_Discipline, objvMandarinCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.DisciplineID, objvMandarinCase_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.DisciplineName, objvMandarinCase_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.id_StudyLevel, objvMandarinCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.StudyLevelName, objvMandarinCase_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.MandarinCaseTheme) == true)
{
string strComparisonOp_MandarinCaseTheme = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.MandarinCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.MandarinCaseTheme, objvMandarinCase_Cond.MandarinCaseTheme, strComparisonOp_MandarinCaseTheme);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.MandarinCaseDate) == true)
{
string strComparisonOp_MandarinCaseDate = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.MandarinCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.MandarinCaseDate, objvMandarinCase_Cond.MandarinCaseDate, strComparisonOp_MandarinCaseDate);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.MandarinCaseTime) == true)
{
string strComparisonOp_MandarinCaseTime = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.MandarinCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.MandarinCaseTime, objvMandarinCase_Cond.MandarinCaseTime, strComparisonOp_MandarinCaseTime);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.MandarinCaseDateIn) == true)
{
string strComparisonOp_MandarinCaseDateIn = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.MandarinCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.MandarinCaseDateIn, objvMandarinCase_Cond.MandarinCaseDateIn, strComparisonOp_MandarinCaseDateIn);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.MandarinCaseTimeIn) == true)
{
string strComparisonOp_MandarinCaseTimeIn = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.MandarinCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.MandarinCaseTimeIn, objvMandarinCase_Cond.MandarinCaseTimeIn, strComparisonOp_MandarinCaseTimeIn);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.id_TeachingPlan, objvMandarinCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.id_SenateGaugeVersion, objvMandarinCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.senateGaugeVersionID, objvMandarinCase_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.senateGaugeVersionName, objvMandarinCase_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMandarinCase.senateGaugeVersionTtlScore, objvMandarinCase_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convMandarinCase.VersionNo, objvMandarinCase_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.CaseLevelId, objvMandarinCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.IsNeedGeneWord) == true)
{
if (objvMandarinCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMandarinCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMandarinCase.IsNeedGeneWord);
}
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.DocFile) == true)
{
string strComparisonOp_DocFile = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.DocFile, objvMandarinCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.WordCreateDate, objvMandarinCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.IsVisible) == true)
{
if (objvMandarinCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMandarinCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMandarinCase.IsVisible);
}
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.OwnerId, objvMandarinCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.StuName) == true)
{
string strComparisonOp_StuName = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.StuName, objvMandarinCase_Cond.StuName, strComparisonOp_StuName);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.StuID) == true)
{
string strComparisonOp_StuID = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.StuID, objvMandarinCase_Cond.StuID, strComparisonOp_StuID);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.CollegeID, objvMandarinCase_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.CollegeName, objvMandarinCase_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.id_XzCollege, objvMandarinCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.CollegeNameA, objvMandarinCase_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.id_XzMajor, objvMandarinCase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.MajorName) == true)
{
string strComparisonOp_MajorName = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.MajorName, objvMandarinCase_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.id_GradeBase, objvMandarinCase_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.GradeBaseName, objvMandarinCase_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.id_AdminCls, objvMandarinCase_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.IsDualVideo) == true)
{
if (objvMandarinCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMandarinCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMandarinCase.IsDualVideo);
}
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.id_MandarinCaseType) == true)
{
string strComparisonOp_id_MandarinCaseType = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.id_MandarinCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.id_MandarinCaseType, objvMandarinCase_Cond.id_MandarinCaseType, strComparisonOp_id_MandarinCaseType);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.MandarinCaseTypeName) == true)
{
string strComparisonOp_MandarinCaseTypeName = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.MandarinCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.MandarinCaseTypeName, objvMandarinCase_Cond.MandarinCaseTypeName, strComparisonOp_MandarinCaseTypeName);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.UserTypeId, objvMandarinCase_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.UserTypeName, objvMandarinCase_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.RecommendedDegreeId, objvMandarinCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.RecommendedDegreeName, objvMandarinCase_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.ftpFileType, objvMandarinCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.VideoUrl, objvMandarinCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.VideoPath, objvMandarinCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.ResErrMsg, objvMandarinCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.UpdDate, objvMandarinCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.UpdUserId, objvMandarinCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.Memo) == true)
{
string strComparisonOp_Memo = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.Memo, objvMandarinCase_Cond.Memo, strComparisonOp_Memo);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMandarinCase.BrowseCount4Case, objvMandarinCase_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.IsHaveVideo) == true)
{
string strComparisonOp_IsHaveVideo = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.IsHaveVideo, objvMandarinCase_Cond.IsHaveVideo, strComparisonOp_IsHaveVideo);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.OwnerNameWithId, objvMandarinCase_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvMandarinCase_Cond.IsUpdated(convMandarinCase.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvMandarinCase_Cond.dicFldComparisonOp[convMandarinCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase.OwnerName, objvMandarinCase_Cond.OwnerName, strComparisonOp_OwnerName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v普通话教学案例(vMandarinCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMandarinCaseWApi
{
private static readonly string mstrApiControllerName = "vMandarinCaseApi";

 public clsvMandarinCaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_MandarinCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMandarinCaseEN GetObjByid_MandarinCase(string strid_MandarinCase)
{
string strAction = "GetObjByid_MandarinCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvMandarinCaseEN objvMandarinCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MandarinCase"] = strid_MandarinCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMandarinCaseEN = JsonConvert.DeserializeObject<clsvMandarinCaseEN>((string)jobjReturn["ReturnObj"]);
return objvMandarinCaseEN;
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
 /// <param name = "strid_MandarinCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMandarinCaseEN GetObjByid_MandarinCase_WA_Cache(string strid_MandarinCase)
{
string strAction = "GetObjByid_MandarinCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMandarinCaseEN objvMandarinCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MandarinCase"] = strid_MandarinCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMandarinCaseEN = JsonConvert.DeserializeObject<clsvMandarinCaseEN>((string)jobjReturn["ReturnObj"]);
return objvMandarinCaseEN;
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
public static clsvMandarinCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMandarinCaseEN objvMandarinCaseEN = null;
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
objvMandarinCaseEN = JsonConvert.DeserializeObject<clsvMandarinCaseEN>((string)jobjReturn["ReturnObj"]);
return objvMandarinCaseEN;
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
 /// <param name = "strid_MandarinCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMandarinCaseEN GetObjByid_MandarinCase_Cache(string strid_MandarinCase)
{
if (string.IsNullOrEmpty(strid_MandarinCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvMandarinCaseEN._CurrTabName_S);
List<clsvMandarinCaseEN> arrvMandarinCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMandarinCaseEN> arrvMandarinCaseObjLst_Sel =
from objvMandarinCaseEN in arrvMandarinCaseObjLst_Cache
where objvMandarinCaseEN.id_MandarinCase == strid_MandarinCase
select objvMandarinCaseEN;
if (arrvMandarinCaseObjLst_Sel.Count() == 0)
{
   clsvMandarinCaseEN obj = clsvMandarinCaseWApi.GetObjByid_MandarinCase(strid_MandarinCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMandarinCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMandarinCaseEN> GetObjLst(string strWhereCond)
{
 List<clsvMandarinCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCaseEN> GetObjLstById_MandarinCaseLst(List<string> arrId_MandarinCase)
{
 List<clsvMandarinCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_MandarinCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MandarinCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_MandarinCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvMandarinCaseEN> GetObjLstById_MandarinCaseLst_Cache(List<string> arrId_MandarinCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMandarinCaseEN._CurrTabName_S);
List<clsvMandarinCaseEN> arrvMandarinCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMandarinCaseEN> arrvMandarinCaseObjLst_Sel =
from objvMandarinCaseEN in arrvMandarinCaseObjLst_Cache
where arrId_MandarinCase.Contains(objvMandarinCaseEN.id_MandarinCase)
select objvMandarinCaseEN;
return arrvMandarinCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMandarinCaseEN> GetObjLstById_MandarinCaseLst_WA_Cache(List<string> arrId_MandarinCase)
{
 List<clsvMandarinCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_MandarinCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MandarinCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMandarinCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMandarinCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMandarinCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMandarinCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_MandarinCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MandarinCase"] = strid_MandarinCase
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
 /// <param name = "objvMandarinCaseENS">源对象</param>
 /// <param name = "objvMandarinCaseENT">目标对象</param>
 public static void CopyTo(clsvMandarinCaseEN objvMandarinCaseENS, clsvMandarinCaseEN objvMandarinCaseENT)
{
try
{
objvMandarinCaseENT.id_MandarinCase = objvMandarinCaseENS.id_MandarinCase; //普通话案例流水号
objvMandarinCaseENT.MandarinCaseID = objvMandarinCaseENS.MandarinCaseID; //普通话教学案例ID
objvMandarinCaseENT.MandarinCaseName = objvMandarinCaseENS.MandarinCaseName; //普通话教学案例名称
objvMandarinCaseENT.id_Discipline = objvMandarinCaseENS.id_Discipline; //学科流水号
objvMandarinCaseENT.DisciplineID = objvMandarinCaseENS.DisciplineID; //学科ID
objvMandarinCaseENT.DisciplineName = objvMandarinCaseENS.DisciplineName; //学科名称
objvMandarinCaseENT.id_StudyLevel = objvMandarinCaseENS.id_StudyLevel; //id_StudyLevel
objvMandarinCaseENT.StudyLevelName = objvMandarinCaseENS.StudyLevelName; //学段名称
objvMandarinCaseENT.MandarinCaseTheme = objvMandarinCaseENS.MandarinCaseTheme; //普通话教学案例主题词
objvMandarinCaseENT.MandarinCaseDate = objvMandarinCaseENS.MandarinCaseDate; //普通话教学日期
objvMandarinCaseENT.MandarinCaseTime = objvMandarinCaseENS.MandarinCaseTime; //普通话教学时间
objvMandarinCaseENT.MandarinCaseDateIn = objvMandarinCaseENS.MandarinCaseDateIn; //案例入库日期
objvMandarinCaseENT.MandarinCaseTimeIn = objvMandarinCaseENS.MandarinCaseTimeIn; //案例入库时间
objvMandarinCaseENT.id_TeachingPlan = objvMandarinCaseENS.id_TeachingPlan; //教案流水号
objvMandarinCaseENT.id_SenateGaugeVersion = objvMandarinCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvMandarinCaseENT.senateGaugeVersionID = objvMandarinCaseENS.senateGaugeVersionID; //评价量表版本ID
objvMandarinCaseENT.senateGaugeVersionName = objvMandarinCaseENS.senateGaugeVersionName; //评价量表版本名称
objvMandarinCaseENT.senateGaugeVersionTtlScore = objvMandarinCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMandarinCaseENT.VersionNo = objvMandarinCaseENS.VersionNo; //版本号
objvMandarinCaseENT.CaseLevelId = objvMandarinCaseENS.CaseLevelId; //课例等级Id
objvMandarinCaseENT.IsNeedGeneWord = objvMandarinCaseENS.IsNeedGeneWord; //是否需要生成Word
objvMandarinCaseENT.DocFile = objvMandarinCaseENS.DocFile; //生成的Word文件名
objvMandarinCaseENT.WordCreateDate = objvMandarinCaseENS.WordCreateDate; //Word生成日期
objvMandarinCaseENT.IsVisible = objvMandarinCaseENS.IsVisible; //是否显示
objvMandarinCaseENT.OwnerId = objvMandarinCaseENS.OwnerId; //拥有者Id
objvMandarinCaseENT.StuName = objvMandarinCaseENS.StuName; //姓名
objvMandarinCaseENT.StuID = objvMandarinCaseENS.StuID; //学号
objvMandarinCaseENT.CollegeID = objvMandarinCaseENS.CollegeID; //学院ID
objvMandarinCaseENT.CollegeName = objvMandarinCaseENS.CollegeName; //学院名称
objvMandarinCaseENT.id_XzCollege = objvMandarinCaseENS.id_XzCollege; //学院流水号
objvMandarinCaseENT.CollegeNameA = objvMandarinCaseENS.CollegeNameA; //学院名称简写
objvMandarinCaseENT.id_XzMajor = objvMandarinCaseENS.id_XzMajor; //专业流水号
objvMandarinCaseENT.MajorName = objvMandarinCaseENS.MajorName; //专业名称
objvMandarinCaseENT.id_GradeBase = objvMandarinCaseENS.id_GradeBase; //年级流水号
objvMandarinCaseENT.GradeBaseName = objvMandarinCaseENS.GradeBaseName; //年级名称
objvMandarinCaseENT.id_AdminCls = objvMandarinCaseENS.id_AdminCls; //行政班流水号
objvMandarinCaseENT.IsDualVideo = objvMandarinCaseENS.IsDualVideo; //是否双视频
objvMandarinCaseENT.id_MandarinCaseType = objvMandarinCaseENS.id_MandarinCaseType; //普通话案例类型流水号
objvMandarinCaseENT.MandarinCaseTypeName = objvMandarinCaseENS.MandarinCaseTypeName; //普通话案例类型名称
objvMandarinCaseENT.UserTypeId = objvMandarinCaseENS.UserTypeId; //用户类型Id
objvMandarinCaseENT.UserTypeName = objvMandarinCaseENS.UserTypeName; //用户类型名称
objvMandarinCaseENT.RecommendedDegreeId = objvMandarinCaseENS.RecommendedDegreeId; //推荐度Id
objvMandarinCaseENT.RecommendedDegreeName = objvMandarinCaseENS.RecommendedDegreeName; //推荐度名称
objvMandarinCaseENT.ftpFileType = objvMandarinCaseENS.ftpFileType; //ftp文件类型
objvMandarinCaseENT.VideoUrl = objvMandarinCaseENS.VideoUrl; //视频Url
objvMandarinCaseENT.VideoPath = objvMandarinCaseENS.VideoPath; //视频目录
objvMandarinCaseENT.ResErrMsg = objvMandarinCaseENS.ResErrMsg; //资源错误信息
objvMandarinCaseENT.UpdDate = objvMandarinCaseENS.UpdDate; //修改日期
objvMandarinCaseENT.UpdUserId = objvMandarinCaseENS.UpdUserId; //修改用户Id
objvMandarinCaseENT.Memo = objvMandarinCaseENS.Memo; //备注
objvMandarinCaseENT.BrowseCount4Case = objvMandarinCaseENS.BrowseCount4Case; //课例浏览次数
objvMandarinCaseENT.IsHaveVideo = objvMandarinCaseENS.IsHaveVideo; //IsHaveVideo
objvMandarinCaseENT.OwnerNameWithId = objvMandarinCaseENS.OwnerNameWithId; //拥有者名称附Id
objvMandarinCaseENT.OwnerName = objvMandarinCaseENS.OwnerName; //拥有者姓名
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
public static DataTable ToDataTable(List<clsvMandarinCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMandarinCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMandarinCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMandarinCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMandarinCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMandarinCaseEN.AttributeName)
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
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMandarinCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMandarinCaseWApi没有刷新缓存机制(clsMandarinCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMandarinCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMandarinCaseTypeWApi没有刷新缓存机制(clsMandarinCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoWApi没有刷新缓存机制(clsStudentInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeWApi没有刷新缓存机制(clsRsStuTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsWApi没有刷新缓存机制(clsXzAdminClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeWApi没有刷新缓存机制(clsXzAdminClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MandarinCase");
//if (arrvMandarinCaseObjLst_Cache == null)
//{
//arrvMandarinCaseObjLst_Cache = await clsvMandarinCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMandarinCaseEN._CurrTabName_S);
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
public static List<clsvMandarinCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMandarinCaseEN._CurrTabName_S);
List<clsvMandarinCaseEN> arrvMandarinCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMandarinCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMandarinCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMandarinCase.id_MandarinCase, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.MandarinCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.MandarinCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.MandarinCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.MandarinCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.MandarinCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.MandarinCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.MandarinCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMandarinCase.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convMandarinCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMandarinCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMandarinCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMandarinCase.id_MandarinCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.MandarinCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convMandarinCase.IsHaveVideo, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase.OwnerName, Type.GetType("System.String"));
foreach (clsvMandarinCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMandarinCase.id_MandarinCase] = objInFor[convMandarinCase.id_MandarinCase];
objDR[convMandarinCase.MandarinCaseID] = objInFor[convMandarinCase.MandarinCaseID];
objDR[convMandarinCase.MandarinCaseName] = objInFor[convMandarinCase.MandarinCaseName];
objDR[convMandarinCase.id_Discipline] = objInFor[convMandarinCase.id_Discipline];
objDR[convMandarinCase.DisciplineID] = objInFor[convMandarinCase.DisciplineID];
objDR[convMandarinCase.DisciplineName] = objInFor[convMandarinCase.DisciplineName];
objDR[convMandarinCase.id_StudyLevel] = objInFor[convMandarinCase.id_StudyLevel];
objDR[convMandarinCase.StudyLevelName] = objInFor[convMandarinCase.StudyLevelName];
objDR[convMandarinCase.MandarinCaseTheme] = objInFor[convMandarinCase.MandarinCaseTheme];
objDR[convMandarinCase.MandarinCaseDate] = objInFor[convMandarinCase.MandarinCaseDate];
objDR[convMandarinCase.MandarinCaseTime] = objInFor[convMandarinCase.MandarinCaseTime];
objDR[convMandarinCase.MandarinCaseDateIn] = objInFor[convMandarinCase.MandarinCaseDateIn];
objDR[convMandarinCase.MandarinCaseTimeIn] = objInFor[convMandarinCase.MandarinCaseTimeIn];
objDR[convMandarinCase.id_TeachingPlan] = objInFor[convMandarinCase.id_TeachingPlan];
objDR[convMandarinCase.id_SenateGaugeVersion] = objInFor[convMandarinCase.id_SenateGaugeVersion];
objDR[convMandarinCase.senateGaugeVersionID] = objInFor[convMandarinCase.senateGaugeVersionID];
objDR[convMandarinCase.senateGaugeVersionName] = objInFor[convMandarinCase.senateGaugeVersionName];
objDR[convMandarinCase.senateGaugeVersionTtlScore] = objInFor[convMandarinCase.senateGaugeVersionTtlScore];
objDR[convMandarinCase.VersionNo] = objInFor[convMandarinCase.VersionNo];
objDR[convMandarinCase.CaseLevelId] = objInFor[convMandarinCase.CaseLevelId];
objDR[convMandarinCase.IsNeedGeneWord] = objInFor[convMandarinCase.IsNeedGeneWord];
objDR[convMandarinCase.DocFile] = objInFor[convMandarinCase.DocFile];
objDR[convMandarinCase.WordCreateDate] = objInFor[convMandarinCase.WordCreateDate];
objDR[convMandarinCase.IsVisible] = objInFor[convMandarinCase.IsVisible];
objDR[convMandarinCase.OwnerId] = objInFor[convMandarinCase.OwnerId];
objDR[convMandarinCase.StuName] = objInFor[convMandarinCase.StuName];
objDR[convMandarinCase.StuID] = objInFor[convMandarinCase.StuID];
objDR[convMandarinCase.CollegeID] = objInFor[convMandarinCase.CollegeID];
objDR[convMandarinCase.CollegeName] = objInFor[convMandarinCase.CollegeName];
objDR[convMandarinCase.id_XzCollege] = objInFor[convMandarinCase.id_XzCollege];
objDR[convMandarinCase.CollegeNameA] = objInFor[convMandarinCase.CollegeNameA];
objDR[convMandarinCase.id_XzMajor] = objInFor[convMandarinCase.id_XzMajor];
objDR[convMandarinCase.MajorName] = objInFor[convMandarinCase.MajorName];
objDR[convMandarinCase.id_GradeBase] = objInFor[convMandarinCase.id_GradeBase];
objDR[convMandarinCase.GradeBaseName] = objInFor[convMandarinCase.GradeBaseName];
objDR[convMandarinCase.id_AdminCls] = objInFor[convMandarinCase.id_AdminCls];
objDR[convMandarinCase.IsDualVideo] = objInFor[convMandarinCase.IsDualVideo];
objDR[convMandarinCase.id_MandarinCaseType] = objInFor[convMandarinCase.id_MandarinCaseType];
objDR[convMandarinCase.MandarinCaseTypeName] = objInFor[convMandarinCase.MandarinCaseTypeName];
objDR[convMandarinCase.UserTypeId] = objInFor[convMandarinCase.UserTypeId];
objDR[convMandarinCase.UserTypeName] = objInFor[convMandarinCase.UserTypeName];
objDR[convMandarinCase.RecommendedDegreeId] = objInFor[convMandarinCase.RecommendedDegreeId];
objDR[convMandarinCase.RecommendedDegreeName] = objInFor[convMandarinCase.RecommendedDegreeName];
objDR[convMandarinCase.ftpFileType] = objInFor[convMandarinCase.ftpFileType];
objDR[convMandarinCase.VideoUrl] = objInFor[convMandarinCase.VideoUrl];
objDR[convMandarinCase.VideoPath] = objInFor[convMandarinCase.VideoPath];
objDR[convMandarinCase.ResErrMsg] = objInFor[convMandarinCase.ResErrMsg];
objDR[convMandarinCase.UpdDate] = objInFor[convMandarinCase.UpdDate];
objDR[convMandarinCase.UpdUserId] = objInFor[convMandarinCase.UpdUserId];
objDR[convMandarinCase.Memo] = objInFor[convMandarinCase.Memo];
objDR[convMandarinCase.BrowseCount4Case] = objInFor[convMandarinCase.BrowseCount4Case];
objDR[convMandarinCase.IsHaveVideo] = objInFor[convMandarinCase.IsHaveVideo];
objDR[convMandarinCase.OwnerNameWithId] = objInFor[convMandarinCase.OwnerNameWithId];
objDR[convMandarinCase.OwnerName] = objInFor[convMandarinCase.OwnerName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}