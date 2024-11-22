
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachCaseWApi
 表名:TeachCase(01120383)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:27
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范
 模块英文名:SkillDemo
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
public static class clsTeachCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN Setid_TeachCase(this clsTeachCaseEN objTeachCaseEN, string strid_TeachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachCase, 8, conTeachCase.id_TeachCase);
clsCheckSql.CheckFieldForeignKey(strid_TeachCase, 8, conTeachCase.id_TeachCase);
objTeachCaseEN.id_TeachCase = strid_TeachCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.id_TeachCase) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.id_TeachCase, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.id_TeachCase] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseID(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseID, conTeachCase.TeachCaseID);
clsCheckSql.CheckFieldLen(strTeachCaseID, 8, conTeachCase.TeachCaseID);
clsCheckSql.CheckFieldForeignKey(strTeachCaseID, 8, conTeachCase.TeachCaseID);
objTeachCaseEN.TeachCaseID = strTeachCaseID; //案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseID) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseID, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseID] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseName(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseName, conTeachCase.TeachCaseName);
clsCheckSql.CheckFieldLen(strTeachCaseName, 200, conTeachCase.TeachCaseName);
objTeachCaseEN.TeachCaseName = strTeachCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseName) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseName, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseName] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseExecutor(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseExecutor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseExecutor, 50, conTeachCase.TeachCaseExecutor);
objTeachCaseEN.TeachCaseExecutor = strTeachCaseExecutor; //案例执教者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseExecutor) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseExecutor, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseExecutor] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseTheme(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseTheme, 200, conTeachCase.TeachCaseTheme);
objTeachCaseEN.TeachCaseTheme = strTeachCaseTheme; //案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseTheme) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseTheme, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseTheme] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseTeachDate(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseTeachDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseTeachDate, 8, conTeachCase.TeachCaseTeachDate);
clsCheckSql.CheckFieldForeignKey(strTeachCaseTeachDate, 8, conTeachCase.TeachCaseTeachDate);
objTeachCaseEN.TeachCaseTeachDate = strTeachCaseTeachDate; //案例授课日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseTeachDate) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseTeachDate, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseTeachDate] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseBG(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseBG, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseBG, 8000, conTeachCase.TeachCaseBG);
objTeachCaseEN.TeachCaseBG = strTeachCaseBG; //案例背景资料
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseBG) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseBG, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseBG] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN Setid_TeachSkill(this clsTeachCaseEN objTeachCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, conTeachCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, conTeachCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, conTeachCase.id_TeachSkill);
objTeachCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.id_TeachSkill) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.id_TeachSkill, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.id_TeachSkill] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN Setid_Discipline(this clsTeachCaseEN objTeachCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, conTeachCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, conTeachCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, conTeachCase.id_Discipline);
objTeachCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.id_Discipline) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.id_Discipline, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.id_Discipline] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN Setid_StudyLevel(this clsTeachCaseEN objTeachCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, conTeachCase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, conTeachCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, conTeachCase.id_StudyLevel);
objTeachCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.id_StudyLevel) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.id_StudyLevel, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.id_StudyLevel] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseDateIn(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseDateIn, 8, conTeachCase.TeachCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strTeachCaseDateIn, 8, conTeachCase.TeachCaseDateIn);
objTeachCaseEN.TeachCaseDateIn = strTeachCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseDateIn) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseDateIn, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseDateIn] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN Setid_TeachingPlan(this clsTeachCaseEN objTeachCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, conTeachCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, conTeachCase.id_TeachingPlan);
objTeachCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.id_TeachingPlan) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.id_TeachingPlan, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.id_TeachingPlan] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseTimeIn(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseTimeIn, 6, conTeachCase.TeachCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strTeachCaseTimeIn, 6, conTeachCase.TeachCaseTimeIn);
objTeachCaseEN.TeachCaseTimeIn = strTeachCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseTimeIn) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseTimeIn, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseTimeIn] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetWorkUnit(this clsTeachCaseEN objTeachCaseEN, string strWorkUnit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, conTeachCase.WorkUnit);
objTeachCaseEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.WorkUnit) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.WorkUnit, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.WorkUnit] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetCD_ID(this clsTeachCaseEN objTeachCaseEN, string strCD_ID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCD_ID, 50, conTeachCase.CD_ID);
objTeachCaseEN.CD_ID = strCD_ID; //光盘编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.CD_ID) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.CD_ID, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.CD_ID] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetBrowseCount(this clsTeachCaseEN objTeachCaseEN, int intBrowseCount, string strComparisonOp="")
	{
objTeachCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.BrowseCount) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.BrowseCount, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.BrowseCount] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetIsVisible(this clsTeachCaseEN objTeachCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objTeachCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.IsVisible) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.IsVisible, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.IsVisible] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetIsDualVideo(this clsTeachCaseEN objTeachCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objTeachCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.IsDualVideo) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.IsDualVideo, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.IsDualVideo] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN Setid_XzCollege(this clsTeachCaseEN objTeachCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conTeachCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conTeachCase.id_XzCollege);
objTeachCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.id_XzCollege) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.id_XzCollege, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.id_XzCollege] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetRecommendedDegreeId(this clsTeachCaseEN objTeachCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conTeachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conTeachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conTeachCase.RecommendedDegreeId);
objTeachCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.RecommendedDegreeId) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetftpFileType(this clsTeachCaseEN objTeachCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conTeachCase.ftpFileType);
objTeachCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.ftpFileType) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.ftpFileType, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.ftpFileType] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetVideoUrl(this clsTeachCaseEN objTeachCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conTeachCase.VideoUrl);
objTeachCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.VideoUrl) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.VideoUrl, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.VideoUrl] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetVideoPath(this clsTeachCaseEN objTeachCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conTeachCase.VideoPath);
objTeachCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.VideoPath) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.VideoPath, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.VideoPath] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetResErrMsg(this clsTeachCaseEN objTeachCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conTeachCase.ResErrMsg);
objTeachCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.ResErrMsg) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.ResErrMsg, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.ResErrMsg] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetUpdDate(this clsTeachCaseEN objTeachCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTeachCase.UpdDate);
objTeachCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.UpdDate) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.UpdDate, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.UpdDate] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetUpdUserId(this clsTeachCaseEN objTeachCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conTeachCase.UpdUserId);
objTeachCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.UpdUserId) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.UpdUserId, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.UpdUserId] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachCaseEN SetMemo(this clsTeachCaseEN objTeachCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTeachCase.Memo);
objTeachCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.Memo) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.Memo, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.Memo] = strComparisonOp;
}
}
return objTeachCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTeachCaseEN objTeachCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTeachCase_Cond.IsUpdated(conTeachCase.id_TeachCase) == true)
{
string strComparisonOp_id_TeachCase = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.id_TeachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.id_TeachCase, objTeachCase_Cond.id_TeachCase, strComparisonOp_id_TeachCase);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.TeachCaseID) == true)
{
string strComparisonOp_TeachCaseID = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.TeachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseID, objTeachCase_Cond.TeachCaseID, strComparisonOp_TeachCaseID);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.TeachCaseName) == true)
{
string strComparisonOp_TeachCaseName = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.TeachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseName, objTeachCase_Cond.TeachCaseName, strComparisonOp_TeachCaseName);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.TeachCaseExecutor) == true)
{
string strComparisonOp_TeachCaseExecutor = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.TeachCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseExecutor, objTeachCase_Cond.TeachCaseExecutor, strComparisonOp_TeachCaseExecutor);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.TeachCaseTheme) == true)
{
string strComparisonOp_TeachCaseTheme = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.TeachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseTheme, objTeachCase_Cond.TeachCaseTheme, strComparisonOp_TeachCaseTheme);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.TeachCaseTeachDate) == true)
{
string strComparisonOp_TeachCaseTeachDate = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.TeachCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseTeachDate, objTeachCase_Cond.TeachCaseTeachDate, strComparisonOp_TeachCaseTeachDate);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.TeachCaseBG) == true)
{
string strComparisonOp_TeachCaseBG = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.TeachCaseBG];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseBG, objTeachCase_Cond.TeachCaseBG, strComparisonOp_TeachCaseBG);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.id_TeachSkill, objTeachCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.id_Discipline, objTeachCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.id_StudyLevel, objTeachCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.TeachCaseDateIn) == true)
{
string strComparisonOp_TeachCaseDateIn = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.TeachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseDateIn, objTeachCase_Cond.TeachCaseDateIn, strComparisonOp_TeachCaseDateIn);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.id_TeachingPlan, objTeachCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.TeachCaseTimeIn) == true)
{
string strComparisonOp_TeachCaseTimeIn = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.TeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseTimeIn, objTeachCase_Cond.TeachCaseTimeIn, strComparisonOp_TeachCaseTimeIn);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.WorkUnit) == true)
{
string strComparisonOp_WorkUnit = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.WorkUnit, objTeachCase_Cond.WorkUnit, strComparisonOp_WorkUnit);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.CD_ID) == true)
{
string strComparisonOp_CD_ID = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.CD_ID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.CD_ID, objTeachCase_Cond.CD_ID, strComparisonOp_CD_ID);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachCase.BrowseCount, objTeachCase_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.IsVisible) == true)
{
if (objTeachCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeachCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeachCase.IsVisible);
}
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.IsDualVideo) == true)
{
if (objTeachCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeachCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeachCase.IsDualVideo);
}
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.id_XzCollege, objTeachCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.RecommendedDegreeId, objTeachCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.ftpFileType, objTeachCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.VideoUrl, objTeachCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.VideoPath, objTeachCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.ResErrMsg, objTeachCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.UpdDate, objTeachCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.UpdUserId, objTeachCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objTeachCase_Cond.IsUpdated(conTeachCase.Memo) == true)
{
string strComparisonOp_Memo = objTeachCase_Cond.dicFldComparisonOp[conTeachCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.Memo, objTeachCase_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeachCaseEN objTeachCaseEN)
{
 if (string.IsNullOrEmpty(objTeachCaseEN.id_TeachCase) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objTeachCaseEN.sf_UpdFldSetStr = objTeachCaseEN.getsf_UpdFldSetStr();
clsTeachCaseWApi.CheckPropertyNew(objTeachCaseEN); 
bool bolResult = clsTeachCaseWApi.UpdateRecord(objTeachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseWApi.ReFreshCache();
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
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTeachCaseEN objTeachCaseEN)
{
 if (string.IsNullOrEmpty(objTeachCaseEN.id_TeachCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTeachCaseWApi.IsExist(objTeachCaseEN.id_TeachCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objTeachCaseEN.id_TeachCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsTeachCaseWApi.CheckPropertyNew(objTeachCaseEN); 
bool bolResult = clsTeachCaseWApi.AddNewRecord(objTeachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseWApi.ReFreshCache();
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
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsTeachCaseEN objTeachCaseEN)
{
try
{
clsTeachCaseWApi.CheckPropertyNew(objTeachCaseEN); 
string strid_TeachCase = clsTeachCaseWApi.AddNewRecordWithMaxId(objTeachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseWApi.ReFreshCache();
return strid_TeachCase;
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
 /// <param name = "objTeachCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeachCaseEN objTeachCaseEN, string strWhereCond)
{
try
{
clsTeachCaseWApi.CheckPropertyNew(objTeachCaseEN); 
bool bolResult = clsTeachCaseWApi.UpdateWithCondition(objTeachCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseWApi.ReFreshCache();
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
 /// 案例(TeachCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsTeachCaseWApi
{
private static readonly string mstrApiControllerName = "TeachCaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsTeachCaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_TeachCase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[案例]...","0");
List<clsTeachCaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_TeachCase";
objDDL.DataTextField="TeachCaseName";
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
public static void BindCbo_id_TeachCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conTeachCase.id_TeachCase); 
List<clsTeachCaseEN> arrObjLst = clsTeachCaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN()
{
id_TeachCase = "0",
TeachCaseName = "选[案例]..."
};
arrObjLst.Insert(0, objTeachCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conTeachCase.id_TeachCase;
objComboBox.DisplayMember = conTeachCase.TeachCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsTeachCaseEN objTeachCaseEN)
{
if (!Object.Equals(null, objTeachCaseEN.id_TeachCase) && GetStrLen(objTeachCaseEN.id_TeachCase) > 8)
{
 throw new Exception("字段[案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachCaseEN.TeachCaseID) && GetStrLen(objTeachCaseEN.TeachCaseID) > 8)
{
 throw new Exception("字段[案例ID]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachCaseEN.TeachCaseName) && GetStrLen(objTeachCaseEN.TeachCaseName) > 200)
{
 throw new Exception("字段[案例名称]的长度不能超过200!");
}
if (!Object.Equals(null, objTeachCaseEN.TeachCaseExecutor) && GetStrLen(objTeachCaseEN.TeachCaseExecutor) > 50)
{
 throw new Exception("字段[案例执教者]的长度不能超过50!");
}
if (!Object.Equals(null, objTeachCaseEN.TeachCaseTheme) && GetStrLen(objTeachCaseEN.TeachCaseTheme) > 200)
{
 throw new Exception("字段[案例主题词]的长度不能超过200!");
}
if (!Object.Equals(null, objTeachCaseEN.TeachCaseTeachDate) && GetStrLen(objTeachCaseEN.TeachCaseTeachDate) > 8)
{
 throw new Exception("字段[案例授课日期]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachCaseEN.TeachCaseBG) && GetStrLen(objTeachCaseEN.TeachCaseBG) > 8000)
{
 throw new Exception("字段[案例背景资料]的长度不能超过8000!");
}
if (!Object.Equals(null, objTeachCaseEN.id_TeachSkill) && GetStrLen(objTeachCaseEN.id_TeachSkill) > 8)
{
 throw new Exception("字段[教学技能流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachCaseEN.id_Discipline) && GetStrLen(objTeachCaseEN.id_Discipline) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeachCaseEN.id_StudyLevel) && GetStrLen(objTeachCaseEN.id_StudyLevel) > 4)
{
 throw new Exception("字段[id_StudyLevel]的长度不能超过4!");
}
if (!Object.Equals(null, objTeachCaseEN.TeachCaseDateIn) && GetStrLen(objTeachCaseEN.TeachCaseDateIn) > 8)
{
 throw new Exception("字段[案例入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachCaseEN.id_TeachingPlan) && GetStrLen(objTeachCaseEN.id_TeachingPlan) > 8)
{
 throw new Exception("字段[教案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachCaseEN.TeachCaseTimeIn) && GetStrLen(objTeachCaseEN.TeachCaseTimeIn) > 6)
{
 throw new Exception("字段[案例入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objTeachCaseEN.WorkUnit) && GetStrLen(objTeachCaseEN.WorkUnit) > 100)
{
 throw new Exception("字段[工作单位]的长度不能超过100!");
}
if (!Object.Equals(null, objTeachCaseEN.CD_ID) && GetStrLen(objTeachCaseEN.CD_ID) > 50)
{
 throw new Exception("字段[光盘编号]的长度不能超过50!");
}
if (!Object.Equals(null, objTeachCaseEN.id_XzCollege) && GetStrLen(objTeachCaseEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeachCaseEN.RecommendedDegreeId) && GetStrLen(objTeachCaseEN.RecommendedDegreeId) > 2)
{
 throw new Exception("字段[推荐度Id]的长度不能超过2!");
}
if (!Object.Equals(null, objTeachCaseEN.ftpFileType) && GetStrLen(objTeachCaseEN.ftpFileType) > 30)
{
 throw new Exception("字段[ftp文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objTeachCaseEN.VideoUrl) && GetStrLen(objTeachCaseEN.VideoUrl) > 1000)
{
 throw new Exception("字段[视频Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objTeachCaseEN.VideoPath) && GetStrLen(objTeachCaseEN.VideoPath) > 1000)
{
 throw new Exception("字段[视频目录]的长度不能超过1000!");
}
if (!Object.Equals(null, objTeachCaseEN.ResErrMsg) && GetStrLen(objTeachCaseEN.ResErrMsg) > 30)
{
 throw new Exception("字段[资源错误信息]的长度不能超过30!");
}
if (!Object.Equals(null, objTeachCaseEN.UpdDate) && GetStrLen(objTeachCaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objTeachCaseEN.UpdUserId) && GetStrLen(objTeachCaseEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objTeachCaseEN.Memo) && GetStrLen(objTeachCaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objTeachCaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_TeachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachCaseEN GetObjByid_TeachCase(string strid_TeachCase)
{
string strAction = "GetObjByid_TeachCase";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachCaseEN objTeachCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachCase"] = strid_TeachCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objTeachCaseEN = JsonConvert.DeserializeObject<clsTeachCaseEN>((string)jobjReturn["ReturnObj"]);
return objTeachCaseEN;
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
 /// <param name = "strid_TeachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachCaseEN GetObjByid_TeachCase_WA_Cache(string strid_TeachCase)
{
string strAction = "GetObjByid_TeachCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachCaseEN objTeachCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachCase"] = strid_TeachCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objTeachCaseEN = JsonConvert.DeserializeObject<clsTeachCaseEN>((string)jobjReturn["ReturnObj"]);
return objTeachCaseEN;
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
public static clsTeachCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachCaseEN objTeachCaseEN = null;
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
objTeachCaseEN = JsonConvert.DeserializeObject<clsTeachCaseEN>((string)jobjReturn["ReturnObj"]);
return objTeachCaseEN;
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
 /// <param name = "strid_TeachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTeachCaseEN GetObjByid_TeachCase_Cache(string strid_TeachCase)
{
if (string.IsNullOrEmpty(strid_TeachCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsTeachCaseEN._CurrTabName_S);
List<clsTeachCaseEN> arrTeachCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeachCaseEN> arrTeachCaseObjLst_Sel =
from objTeachCaseEN in arrTeachCaseObjLst_Cache
where objTeachCaseEN.id_TeachCase == strid_TeachCase
select objTeachCaseEN;
if (arrTeachCaseObjLst_Sel.Count() == 0)
{
   clsTeachCaseEN obj = clsTeachCaseWApi.GetObjByid_TeachCase(strid_TeachCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrTeachCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_TeachCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTeachCaseNameByid_TeachCase_Cache(string strid_TeachCase)
{
if (string.IsNullOrEmpty(strid_TeachCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsTeachCaseEN._CurrTabName_S);
List<clsTeachCaseEN> arrTeachCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeachCaseEN> arrTeachCaseObjLst_Sel1 =
from objTeachCaseEN in arrTeachCaseObjLst_Cache
where objTeachCaseEN.id_TeachCase == strid_TeachCase
select objTeachCaseEN;
List <clsTeachCaseEN> arrTeachCaseObjLst_Sel = new List<clsTeachCaseEN>();
foreach (clsTeachCaseEN obj in arrTeachCaseObjLst_Sel1)
{
arrTeachCaseObjLst_Sel.Add(obj);
}
if (arrTeachCaseObjLst_Sel.Count > 0)
{
return arrTeachCaseObjLst_Sel[0].TeachCaseName;
}
string strErrMsgForGetObjById = string.Format("在TeachCase对象缓存列表中,找不到记录[id_TeachCase = {0}](函数:{1})", strid_TeachCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsTeachCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_TeachCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_TeachCase_Cache(string strid_TeachCase)
{
if (string.IsNullOrEmpty(strid_TeachCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsTeachCaseEN._CurrTabName_S);
List<clsTeachCaseEN> arrTeachCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeachCaseEN> arrTeachCaseObjLst_Sel1 =
from objTeachCaseEN in arrTeachCaseObjLst_Cache
where objTeachCaseEN.id_TeachCase == strid_TeachCase
select objTeachCaseEN;
List <clsTeachCaseEN> arrTeachCaseObjLst_Sel = new List<clsTeachCaseEN>();
foreach (clsTeachCaseEN obj in arrTeachCaseObjLst_Sel1)
{
arrTeachCaseObjLst_Sel.Add(obj);
}
if (arrTeachCaseObjLst_Sel.Count > 0)
{
return arrTeachCaseObjLst_Sel[0].TeachCaseName;
}
string strErrMsgForGetObjById = string.Format("在TeachCase对象缓存列表中,找不到记录的相关名称[id_TeachCase = {0}](函数:{1})", strid_TeachCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsTeachCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachCaseEN> GetObjLst(string strWhereCond)
{
 List<clsTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachCaseEN> GetObjLstById_TeachCaseLst(List<string> arrId_TeachCase)
{
 List<clsTeachCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeachCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_TeachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsTeachCaseEN> GetObjLstById_TeachCaseLst_Cache(List<string> arrId_TeachCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsTeachCaseEN._CurrTabName_S);
List<clsTeachCaseEN> arrTeachCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeachCaseEN> arrTeachCaseObjLst_Sel =
from objTeachCaseEN in arrTeachCaseObjLst_Cache
where arrId_TeachCase.Contains(objTeachCaseEN.id_TeachCase)
select objTeachCaseEN;
return arrTeachCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachCaseEN> GetObjLstById_TeachCaseLst_WA_Cache(List<string> arrId_TeachCase)
{
 List<clsTeachCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeachCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_TeachCase)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsTeachCaseEN objTeachCaseEN = clsTeachCaseWApi.GetObjByid_TeachCase(strid_TeachCase);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_TeachCase.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsTeachCaseWApi.ReFreshCache();
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
public static int DelTeachCases(List<string> arrid_TeachCase)
{
string strAction = "DelTeachCases";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_TeachCase);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsTeachCaseWApi.ReFreshCache();
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
public static int DelTeachCasesByCond(string strWhereCond)
{
string strAction = "DelTeachCasesByCond";
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
public static bool AddNewRecord(clsTeachCaseEN objTeachCaseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachCaseEN>(objTeachCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsTeachCaseEN objTeachCaseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachCaseEN>(objTeachCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseWApi.ReFreshCache();
var strid_TeachCase = (string)jobjReturn["ReturnStr"];
return strid_TeachCase;
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
public static bool UpdateRecord(clsTeachCaseEN objTeachCaseEN)
{
if (string.IsNullOrEmpty(objTeachCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachCaseEN.id_TeachCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachCaseEN>(objTeachCaseEN);
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
 /// <param name = "objTeachCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsTeachCaseEN objTeachCaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objTeachCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachCaseEN.id_TeachCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachCaseEN.id_TeachCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachCaseEN>(objTeachCaseEN);
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
public static bool IsExist(string strid_TeachCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachCase"] = strid_TeachCase
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
 /// <param name = "objTeachCaseENS">源对象</param>
 /// <param name = "objTeachCaseENT">目标对象</param>
 public static void CopyTo(clsTeachCaseEN objTeachCaseENS, clsTeachCaseEN objTeachCaseENT)
{
try
{
objTeachCaseENT.id_TeachCase = objTeachCaseENS.id_TeachCase; //案例流水号
objTeachCaseENT.TeachCaseID = objTeachCaseENS.TeachCaseID; //案例ID
objTeachCaseENT.TeachCaseName = objTeachCaseENS.TeachCaseName; //案例名称
objTeachCaseENT.TeachCaseExecutor = objTeachCaseENS.TeachCaseExecutor; //案例执教者
objTeachCaseENT.TeachCaseTheme = objTeachCaseENS.TeachCaseTheme; //案例主题词
objTeachCaseENT.TeachCaseTeachDate = objTeachCaseENS.TeachCaseTeachDate; //案例授课日期
objTeachCaseENT.TeachCaseBG = objTeachCaseENS.TeachCaseBG; //案例背景资料
objTeachCaseENT.id_TeachSkill = objTeachCaseENS.id_TeachSkill; //教学技能流水号
objTeachCaseENT.id_Discipline = objTeachCaseENS.id_Discipline; //学科流水号
objTeachCaseENT.id_StudyLevel = objTeachCaseENS.id_StudyLevel; //id_StudyLevel
objTeachCaseENT.TeachCaseDateIn = objTeachCaseENS.TeachCaseDateIn; //案例入库日期
objTeachCaseENT.id_TeachingPlan = objTeachCaseENS.id_TeachingPlan; //教案流水号
objTeachCaseENT.TeachCaseTimeIn = objTeachCaseENS.TeachCaseTimeIn; //案例入库时间
objTeachCaseENT.WorkUnit = objTeachCaseENS.WorkUnit; //工作单位
objTeachCaseENT.CD_ID = objTeachCaseENS.CD_ID; //光盘编号
objTeachCaseENT.BrowseCount = objTeachCaseENS.BrowseCount; //浏览次数
objTeachCaseENT.IsVisible = objTeachCaseENS.IsVisible; //是否显示
objTeachCaseENT.IsDualVideo = objTeachCaseENS.IsDualVideo; //是否双视频
objTeachCaseENT.id_XzCollege = objTeachCaseENS.id_XzCollege; //学院流水号
objTeachCaseENT.RecommendedDegreeId = objTeachCaseENS.RecommendedDegreeId; //推荐度Id
objTeachCaseENT.ftpFileType = objTeachCaseENS.ftpFileType; //ftp文件类型
objTeachCaseENT.VideoUrl = objTeachCaseENS.VideoUrl; //视频Url
objTeachCaseENT.VideoPath = objTeachCaseENS.VideoPath; //视频目录
objTeachCaseENT.ResErrMsg = objTeachCaseENS.ResErrMsg; //资源错误信息
objTeachCaseENT.UpdDate = objTeachCaseENS.UpdDate; //修改日期
objTeachCaseENT.UpdUserId = objTeachCaseENS.UpdUserId; //修改用户Id
objTeachCaseENT.Memo = objTeachCaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsTeachCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsTeachCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsTeachCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsTeachCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsTeachCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsTeachCaseEN.AttributeName)
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
if (clsTeachCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachCaseWApi没有刷新缓存机制(clsTeachCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_TeachCase");
//if (arrTeachCaseObjLst_Cache == null)
//{
//arrTeachCaseObjLst_Cache = await clsTeachCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsTeachCaseEN._CurrTabName_S);
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
if (clsTeachCaseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTeachCaseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsTeachCaseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeachCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsTeachCaseEN._CurrTabName_S);
List<clsTeachCaseEN> arrTeachCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTeachCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsTeachCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conTeachCase.id_TeachCase, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.TeachCaseID, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.TeachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.TeachCaseExecutor, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.TeachCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.TeachCaseTeachDate, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.TeachCaseBG, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.TeachCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.TeachCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.WorkUnit, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.CD_ID, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conTeachCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTeachCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTeachCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachCase.Memo, Type.GetType("System.String"));
foreach (clsTeachCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conTeachCase.id_TeachCase] = objInFor[conTeachCase.id_TeachCase];
objDR[conTeachCase.TeachCaseID] = objInFor[conTeachCase.TeachCaseID];
objDR[conTeachCase.TeachCaseName] = objInFor[conTeachCase.TeachCaseName];
objDR[conTeachCase.TeachCaseExecutor] = objInFor[conTeachCase.TeachCaseExecutor];
objDR[conTeachCase.TeachCaseTheme] = objInFor[conTeachCase.TeachCaseTheme];
objDR[conTeachCase.TeachCaseTeachDate] = objInFor[conTeachCase.TeachCaseTeachDate];
objDR[conTeachCase.TeachCaseBG] = objInFor[conTeachCase.TeachCaseBG];
objDR[conTeachCase.id_TeachSkill] = objInFor[conTeachCase.id_TeachSkill];
objDR[conTeachCase.id_Discipline] = objInFor[conTeachCase.id_Discipline];
objDR[conTeachCase.id_StudyLevel] = objInFor[conTeachCase.id_StudyLevel];
objDR[conTeachCase.TeachCaseDateIn] = objInFor[conTeachCase.TeachCaseDateIn];
objDR[conTeachCase.id_TeachingPlan] = objInFor[conTeachCase.id_TeachingPlan];
objDR[conTeachCase.TeachCaseTimeIn] = objInFor[conTeachCase.TeachCaseTimeIn];
objDR[conTeachCase.WorkUnit] = objInFor[conTeachCase.WorkUnit];
objDR[conTeachCase.CD_ID] = objInFor[conTeachCase.CD_ID];
objDR[conTeachCase.BrowseCount] = objInFor[conTeachCase.BrowseCount];
objDR[conTeachCase.IsVisible] = objInFor[conTeachCase.IsVisible];
objDR[conTeachCase.IsDualVideo] = objInFor[conTeachCase.IsDualVideo];
objDR[conTeachCase.id_XzCollege] = objInFor[conTeachCase.id_XzCollege];
objDR[conTeachCase.RecommendedDegreeId] = objInFor[conTeachCase.RecommendedDegreeId];
objDR[conTeachCase.ftpFileType] = objInFor[conTeachCase.ftpFileType];
objDR[conTeachCase.VideoUrl] = objInFor[conTeachCase.VideoUrl];
objDR[conTeachCase.VideoPath] = objInFor[conTeachCase.VideoPath];
objDR[conTeachCase.ResErrMsg] = objInFor[conTeachCase.ResErrMsg];
objDR[conTeachCase.UpdDate] = objInFor[conTeachCase.UpdDate];
objDR[conTeachCase.UpdUserId] = objInFor[conTeachCase.UpdUserId];
objDR[conTeachCase.Memo] = objInFor[conTeachCase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 案例(TeachCase)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4TeachCase : clsCommFun4BL
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
clsTeachCaseWApi.ReFreshThisCache();
}
}

}