
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseWApi
 表名:PubClassCase(01120385)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:50
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩
 模块英文名:PubicClassSenate
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
public static class clsPubClassCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN Setid_PubClassCase(this clsPubClassCaseEN objPubClassCaseEN, string strid_PubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_PubClassCase, 8, conPubClassCase.id_PubClassCase);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCase, 8, conPubClassCase.id_PubClassCase);
objPubClassCaseEN.id_PubClassCase = strid_PubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.id_PubClassCase) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.id_PubClassCase, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.id_PubClassCase] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseID(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseID, conPubClassCase.PubClassCaseID);
clsCheckSql.CheckFieldLen(strPubClassCaseID, 8, conPubClassCase.PubClassCaseID);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseID, 8, conPubClassCase.PubClassCaseID);
objPubClassCaseEN.PubClassCaseID = strPubClassCaseID; //案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseID) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseID, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseID] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseName(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseName, conPubClassCase.PubClassCaseName);
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, conPubClassCase.PubClassCaseName);
objPubClassCaseEN.PubClassCaseName = strPubClassCaseName; //案例课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseName) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseName, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseName] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseExecutor(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, conPubClassCase.PubClassCaseExecutor);
objPubClassCaseEN.PubClassCaseExecutor = strPubClassCaseExecutor; //案例执教者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseExecutor) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseExecutor, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseExecutor] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetWorkUnit(this clsPubClassCaseEN objPubClassCaseEN, string strWorkUnit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, conPubClassCase.WorkUnit);
objPubClassCaseEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.WorkUnit) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.WorkUnit, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.WorkUnit] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseTheme(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTheme, 500, conPubClassCase.PubClassCaseTheme);
objPubClassCaseEN.PubClassCaseTheme = strPubClassCaseTheme; //案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseTheme) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseTheme, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseTheme] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseBG(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseBG, string strComparisonOp="")
	{
objPubClassCaseEN.PubClassCaseBG = strPubClassCaseBG; //案例背景资料
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseBG) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseBG, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseBG] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseTeachDate(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseTeachDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTeachDate, 8, conPubClassCase.PubClassCaseTeachDate);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTeachDate, 8, conPubClassCase.PubClassCaseTeachDate);
objPubClassCaseEN.PubClassCaseTeachDate = strPubClassCaseTeachDate; //案例授课日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseTeachDate) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseTeachDate, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseTeachDate] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseDateIn(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseDateIn, 8, conPubClassCase.PubClassCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseDateIn, 8, conPubClassCase.PubClassCaseDateIn);
objPubClassCaseEN.PubClassCaseDateIn = strPubClassCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseDateIn) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseDateIn, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseDateIn] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN Setid_Discipline(this clsPubClassCaseEN objPubClassCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, conPubClassCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, conPubClassCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, conPubClassCase.id_Discipline);
objPubClassCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.id_Discipline) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.id_Discipline, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.id_Discipline] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN Setid_TeachingPlan(this clsPubClassCaseEN objPubClassCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, conPubClassCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, conPubClassCase.id_TeachingPlan);
objPubClassCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.id_TeachingPlan) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.id_TeachingPlan, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.id_TeachingPlan] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseTimeIn(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTimeIn, 6, conPubClassCase.PubClassCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTimeIn, 6, conPubClassCase.PubClassCaseTimeIn);
objPubClassCaseEN.PubClassCaseTimeIn = strPubClassCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseTimeIn) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseTimeIn, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseTimeIn] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN Setid_PubClassCaseSenateGaugeVersion(this clsPubClassCaseEN objPubClassCaseEN, string strid_PubClassCaseSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubClassCaseSenateGaugeVersion, conPubClassCase.id_PubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_PubClassCaseSenateGaugeVersion, 4, conPubClassCase.id_PubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCaseSenateGaugeVersion, 4, conPubClassCase.id_PubClassCaseSenateGaugeVersion);
objPubClassCaseEN.id_PubClassCaseSenateGaugeVersion = strid_PubClassCaseSenateGaugeVersion; //公开课量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.id_PubClassCaseSenateGaugeVersion) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.id_PubClassCaseSenateGaugeVersion, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.id_PubClassCaseSenateGaugeVersion] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetBrowseCount(this clsPubClassCaseEN objPubClassCaseEN, int intBrowseCount, string strComparisonOp="")
	{
objPubClassCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.BrowseCount) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.BrowseCount, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.BrowseCount] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN Setid_PubCaseType(this clsPubClassCaseEN objPubClassCaseEN, string strid_PubCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_PubCaseType, 4, conPubClassCase.id_PubCaseType);
clsCheckSql.CheckFieldForeignKey(strid_PubCaseType, 4, conPubClassCase.id_PubCaseType);
objPubClassCaseEN.id_PubCaseType = strid_PubCaseType; //公开课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.id_PubCaseType) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.id_PubCaseType, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.id_PubCaseType] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN Setid_StudyLevel(this clsPubClassCaseEN objPubClassCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, conPubClassCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, conPubClassCase.id_StudyLevel);
objPubClassCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.id_StudyLevel) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.id_StudyLevel, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.id_StudyLevel] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetCD_ID(this clsPubClassCaseEN objPubClassCaseEN, string strCD_ID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCD_ID, 50, conPubClassCase.CD_ID);
objPubClassCaseEN.CD_ID = strCD_ID; //光盘编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.CD_ID) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.CD_ID, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.CD_ID] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetIntroduction(this clsPubClassCaseEN objPubClassCaseEN, string strIntroduction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIntroduction, 4000, conPubClassCase.Introduction);
objPubClassCaseEN.Introduction = strIntroduction; //简要介绍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.Introduction) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.Introduction, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.Introduction] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetIsVisible(this clsPubClassCaseEN objPubClassCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objPubClassCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.IsVisible) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.IsVisible, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.IsVisible] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetIsDualVideo(this clsPubClassCaseEN objPubClassCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objPubClassCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.IsDualVideo) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.IsDualVideo, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.IsDualVideo] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetRecommendedDegreeId(this clsPubClassCaseEN objPubClassCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conPubClassCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conPubClassCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conPubClassCase.RecommendedDegreeId);
objPubClassCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.RecommendedDegreeId) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetftpFileType(this clsPubClassCaseEN objPubClassCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conPubClassCase.ftpFileType);
objPubClassCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.ftpFileType) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.ftpFileType, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.ftpFileType] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetVideoUrl(this clsPubClassCaseEN objPubClassCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conPubClassCase.VideoUrl);
objPubClassCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.VideoUrl) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.VideoUrl, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.VideoUrl] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetVideoPath(this clsPubClassCaseEN objPubClassCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conPubClassCase.VideoPath);
objPubClassCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.VideoPath) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.VideoPath, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.VideoPath] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetResErrMsg(this clsPubClassCaseEN objPubClassCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conPubClassCase.ResErrMsg);
objPubClassCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.ResErrMsg) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.ResErrMsg, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.ResErrMsg] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetUpdDate(this clsPubClassCaseEN objPubClassCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPubClassCase.UpdDate);
objPubClassCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.UpdDate) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.UpdDate, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.UpdDate] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetUpdUserId(this clsPubClassCaseEN objPubClassCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conPubClassCase.UpdUserId);
objPubClassCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.UpdUserId) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.UpdUserId, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.UpdUserId] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseEN SetMemo(this clsPubClassCaseEN objPubClassCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPubClassCase.Memo);
objPubClassCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.Memo) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.Memo, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.Memo] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPubClassCaseEN objPubClassCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.id_PubClassCase) == true)
{
string strComparisonOp_id_PubClassCase = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.id_PubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.id_PubClassCase, objPubClassCase_Cond.id_PubClassCase, strComparisonOp_id_PubClassCase);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.PubClassCaseID) == true)
{
string strComparisonOp_PubClassCaseID = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.PubClassCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.PubClassCaseID, objPubClassCase_Cond.PubClassCaseID, strComparisonOp_PubClassCaseID);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.PubClassCaseName) == true)
{
string strComparisonOp_PubClassCaseName = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.PubClassCaseName, objPubClassCase_Cond.PubClassCaseName, strComparisonOp_PubClassCaseName);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.PubClassCaseExecutor) == true)
{
string strComparisonOp_PubClassCaseExecutor = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.PubClassCaseExecutor, objPubClassCase_Cond.PubClassCaseExecutor, strComparisonOp_PubClassCaseExecutor);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.WorkUnit) == true)
{
string strComparisonOp_WorkUnit = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.WorkUnit, objPubClassCase_Cond.WorkUnit, strComparisonOp_WorkUnit);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.PubClassCaseTheme) == true)
{
string strComparisonOp_PubClassCaseTheme = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.PubClassCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.PubClassCaseTheme, objPubClassCase_Cond.PubClassCaseTheme, strComparisonOp_PubClassCaseTheme);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.PubClassCaseTeachDate) == true)
{
string strComparisonOp_PubClassCaseTeachDate = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.PubClassCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.PubClassCaseTeachDate, objPubClassCase_Cond.PubClassCaseTeachDate, strComparisonOp_PubClassCaseTeachDate);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.PubClassCaseDateIn) == true)
{
string strComparisonOp_PubClassCaseDateIn = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.PubClassCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.PubClassCaseDateIn, objPubClassCase_Cond.PubClassCaseDateIn, strComparisonOp_PubClassCaseDateIn);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.id_Discipline, objPubClassCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.id_TeachingPlan, objPubClassCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.PubClassCaseTimeIn) == true)
{
string strComparisonOp_PubClassCaseTimeIn = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.PubClassCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.PubClassCaseTimeIn, objPubClassCase_Cond.PubClassCaseTimeIn, strComparisonOp_PubClassCaseTimeIn);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.id_PubClassCaseSenateGaugeVersion) == true)
{
string strComparisonOp_id_PubClassCaseSenateGaugeVersion = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.id_PubClassCaseSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.id_PubClassCaseSenateGaugeVersion, objPubClassCase_Cond.id_PubClassCaseSenateGaugeVersion, strComparisonOp_id_PubClassCaseSenateGaugeVersion);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPubClassCase.BrowseCount, objPubClassCase_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.id_PubCaseType) == true)
{
string strComparisonOp_id_PubCaseType = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.id_PubCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.id_PubCaseType, objPubClassCase_Cond.id_PubCaseType, strComparisonOp_id_PubCaseType);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.id_StudyLevel, objPubClassCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.CD_ID) == true)
{
string strComparisonOp_CD_ID = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.CD_ID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.CD_ID, objPubClassCase_Cond.CD_ID, strComparisonOp_CD_ID);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.Introduction) == true)
{
string strComparisonOp_Introduction = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.Introduction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.Introduction, objPubClassCase_Cond.Introduction, strComparisonOp_Introduction);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.IsVisible) == true)
{
if (objPubClassCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPubClassCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPubClassCase.IsVisible);
}
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.IsDualVideo) == true)
{
if (objPubClassCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPubClassCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPubClassCase.IsDualVideo);
}
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.RecommendedDegreeId, objPubClassCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.ftpFileType, objPubClassCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.VideoUrl, objPubClassCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.VideoPath, objPubClassCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.ResErrMsg, objPubClassCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.UpdDate, objPubClassCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.UpdUserId, objPubClassCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objPubClassCase_Cond.IsUpdated(conPubClassCase.Memo) == true)
{
string strComparisonOp_Memo = objPubClassCase_Cond.dicFldComparisonOp[conPubClassCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.Memo, objPubClassCase_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPubClassCaseEN objPubClassCaseEN)
{
 if (string.IsNullOrEmpty(objPubClassCaseEN.id_PubClassCase) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objPubClassCaseEN.sf_UpdFldSetStr = objPubClassCaseEN.getsf_UpdFldSetStr();
clsPubClassCaseWApi.CheckPropertyNew(objPubClassCaseEN); 
bool bolResult = clsPubClassCaseWApi.UpdateRecord(objPubClassCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseWApi.ReFreshCache();
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
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPubClassCaseEN objPubClassCaseEN)
{
 if (string.IsNullOrEmpty(objPubClassCaseEN.id_PubClassCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPubClassCaseWApi.IsExist(objPubClassCaseEN.id_PubClassCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objPubClassCaseEN.id_PubClassCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsPubClassCaseWApi.CheckPropertyNew(objPubClassCaseEN); 
bool bolResult = clsPubClassCaseWApi.AddNewRecord(objPubClassCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseWApi.ReFreshCache();
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
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPubClassCaseEN objPubClassCaseEN)
{
try
{
clsPubClassCaseWApi.CheckPropertyNew(objPubClassCaseEN); 
string strid_PubClassCase = clsPubClassCaseWApi.AddNewRecordWithMaxId(objPubClassCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseWApi.ReFreshCache();
return strid_PubClassCase;
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
 /// <param name = "objPubClassCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPubClassCaseEN objPubClassCaseEN, string strWhereCond)
{
try
{
clsPubClassCaseWApi.CheckPropertyNew(objPubClassCaseEN); 
bool bolResult = clsPubClassCaseWApi.UpdateWithCondition(objPubClassCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseWApi.ReFreshCache();
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
 /// 公开课案例(PubClassCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsPubClassCaseWApi
{
private static readonly string mstrApiControllerName = "PubClassCaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsPubClassCaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_PubClassCase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[公开课案例]...","0");
List<clsPubClassCaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_PubClassCase";
objDDL.DataTextField="PubClassCaseName";
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
public static void BindCbo_id_PubClassCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPubClassCase.id_PubClassCase); 
List<clsPubClassCaseEN> arrObjLst = clsPubClassCaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN()
{
id_PubClassCase = "0",
PubClassCaseName = "选[公开课案例]..."
};
arrObjLst.Insert(0, objPubClassCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conPubClassCase.id_PubClassCase;
objComboBox.DisplayMember = conPubClassCase.PubClassCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsPubClassCaseEN objPubClassCaseEN)
{
if (!Object.Equals(null, objPubClassCaseEN.id_PubClassCase) && GetStrLen(objPubClassCaseEN.id_PubClassCase) > 8)
{
 throw new Exception("字段[案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objPubClassCaseEN.PubClassCaseID) && GetStrLen(objPubClassCaseEN.PubClassCaseID) > 8)
{
 throw new Exception("字段[案例ID]的长度不能超过8!");
}
if (!Object.Equals(null, objPubClassCaseEN.PubClassCaseName) && GetStrLen(objPubClassCaseEN.PubClassCaseName) > 200)
{
 throw new Exception("字段[案例课题名称]的长度不能超过200!");
}
if (!Object.Equals(null, objPubClassCaseEN.PubClassCaseExecutor) && GetStrLen(objPubClassCaseEN.PubClassCaseExecutor) > 50)
{
 throw new Exception("字段[案例执教者]的长度不能超过50!");
}
if (!Object.Equals(null, objPubClassCaseEN.WorkUnit) && GetStrLen(objPubClassCaseEN.WorkUnit) > 100)
{
 throw new Exception("字段[工作单位]的长度不能超过100!");
}
if (!Object.Equals(null, objPubClassCaseEN.PubClassCaseTheme) && GetStrLen(objPubClassCaseEN.PubClassCaseTheme) > 500)
{
 throw new Exception("字段[案例主题词]的长度不能超过500!");
}
if (!Object.Equals(null, objPubClassCaseEN.PubClassCaseTeachDate) && GetStrLen(objPubClassCaseEN.PubClassCaseTeachDate) > 8)
{
 throw new Exception("字段[案例授课日期]的长度不能超过8!");
}
if (!Object.Equals(null, objPubClassCaseEN.PubClassCaseDateIn) && GetStrLen(objPubClassCaseEN.PubClassCaseDateIn) > 8)
{
 throw new Exception("字段[案例入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objPubClassCaseEN.id_Discipline) && GetStrLen(objPubClassCaseEN.id_Discipline) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objPubClassCaseEN.id_TeachingPlan) && GetStrLen(objPubClassCaseEN.id_TeachingPlan) > 8)
{
 throw new Exception("字段[教案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objPubClassCaseEN.PubClassCaseTimeIn) && GetStrLen(objPubClassCaseEN.PubClassCaseTimeIn) > 6)
{
 throw new Exception("字段[案例入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objPubClassCaseEN.id_PubClassCaseSenateGaugeVersion) && GetStrLen(objPubClassCaseEN.id_PubClassCaseSenateGaugeVersion) > 4)
{
 throw new Exception("字段[公开课量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objPubClassCaseEN.id_PubCaseType) && GetStrLen(objPubClassCaseEN.id_PubCaseType) > 4)
{
 throw new Exception("字段[公开课案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objPubClassCaseEN.id_StudyLevel) && GetStrLen(objPubClassCaseEN.id_StudyLevel) > 4)
{
 throw new Exception("字段[id_StudyLevel]的长度不能超过4!");
}
if (!Object.Equals(null, objPubClassCaseEN.CD_ID) && GetStrLen(objPubClassCaseEN.CD_ID) > 50)
{
 throw new Exception("字段[光盘编号]的长度不能超过50!");
}
if (!Object.Equals(null, objPubClassCaseEN.Introduction) && GetStrLen(objPubClassCaseEN.Introduction) > 4000)
{
 throw new Exception("字段[简要介绍]的长度不能超过4000!");
}
if (!Object.Equals(null, objPubClassCaseEN.RecommendedDegreeId) && GetStrLen(objPubClassCaseEN.RecommendedDegreeId) > 2)
{
 throw new Exception("字段[推荐度Id]的长度不能超过2!");
}
if (!Object.Equals(null, objPubClassCaseEN.ftpFileType) && GetStrLen(objPubClassCaseEN.ftpFileType) > 30)
{
 throw new Exception("字段[ftp文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objPubClassCaseEN.VideoUrl) && GetStrLen(objPubClassCaseEN.VideoUrl) > 1000)
{
 throw new Exception("字段[视频Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objPubClassCaseEN.VideoPath) && GetStrLen(objPubClassCaseEN.VideoPath) > 1000)
{
 throw new Exception("字段[视频目录]的长度不能超过1000!");
}
if (!Object.Equals(null, objPubClassCaseEN.ResErrMsg) && GetStrLen(objPubClassCaseEN.ResErrMsg) > 30)
{
 throw new Exception("字段[资源错误信息]的长度不能超过30!");
}
if (!Object.Equals(null, objPubClassCaseEN.UpdDate) && GetStrLen(objPubClassCaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objPubClassCaseEN.UpdUserId) && GetStrLen(objPubClassCaseEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objPubClassCaseEN.Memo) && GetStrLen(objPubClassCaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objPubClassCaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_PubClassCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCaseEN GetObjByid_PubClassCase(string strid_PubClassCase)
{
string strAction = "GetObjByid_PubClassCase";
string strErrMsg = string.Empty;
string strResult = "";
clsPubClassCaseEN objPubClassCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCase"] = strid_PubClassCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objPubClassCaseEN = JsonConvert.DeserializeObject<clsPubClassCaseEN>((string)jobjReturn["ReturnObj"]);
return objPubClassCaseEN;
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
 /// <param name = "strid_PubClassCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCaseEN GetObjByid_PubClassCase_WA_Cache(string strid_PubClassCase)
{
string strAction = "GetObjByid_PubClassCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsPubClassCaseEN objPubClassCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCase"] = strid_PubClassCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objPubClassCaseEN = JsonConvert.DeserializeObject<clsPubClassCaseEN>((string)jobjReturn["ReturnObj"]);
return objPubClassCaseEN;
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
public static clsPubClassCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsPubClassCaseEN objPubClassCaseEN = null;
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
objPubClassCaseEN = JsonConvert.DeserializeObject<clsPubClassCaseEN>((string)jobjReturn["ReturnObj"]);
return objPubClassCaseEN;
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
 /// <param name = "strid_PubClassCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPubClassCaseEN GetObjByid_PubClassCase_Cache(string strid_PubClassCase)
{
if (string.IsNullOrEmpty(strid_PubClassCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsPubClassCaseEN._CurrTabName_S);
List<clsPubClassCaseEN> arrPubClassCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPubClassCaseEN> arrPubClassCaseObjLst_Sel =
from objPubClassCaseEN in arrPubClassCaseObjLst_Cache
where objPubClassCaseEN.id_PubClassCase == strid_PubClassCase
select objPubClassCaseEN;
if (arrPubClassCaseObjLst_Sel.Count() == 0)
{
   clsPubClassCaseEN obj = clsPubClassCaseWApi.GetObjByid_PubClassCase(strid_PubClassCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrPubClassCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_PubClassCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPubClassCaseNameByid_PubClassCase_Cache(string strid_PubClassCase)
{
if (string.IsNullOrEmpty(strid_PubClassCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsPubClassCaseEN._CurrTabName_S);
List<clsPubClassCaseEN> arrPubClassCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPubClassCaseEN> arrPubClassCaseObjLst_Sel1 =
from objPubClassCaseEN in arrPubClassCaseObjLst_Cache
where objPubClassCaseEN.id_PubClassCase == strid_PubClassCase
select objPubClassCaseEN;
List <clsPubClassCaseEN> arrPubClassCaseObjLst_Sel = new List<clsPubClassCaseEN>();
foreach (clsPubClassCaseEN obj in arrPubClassCaseObjLst_Sel1)
{
arrPubClassCaseObjLst_Sel.Add(obj);
}
if (arrPubClassCaseObjLst_Sel.Count > 0)
{
return arrPubClassCaseObjLst_Sel[0].PubClassCaseName;
}
string strErrMsgForGetObjById = string.Format("在PubClassCase对象缓存列表中,找不到记录[id_PubClassCase = {0}](函数:{1})", strid_PubClassCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPubClassCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_PubClassCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_PubClassCase_Cache(string strid_PubClassCase)
{
if (string.IsNullOrEmpty(strid_PubClassCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsPubClassCaseEN._CurrTabName_S);
List<clsPubClassCaseEN> arrPubClassCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPubClassCaseEN> arrPubClassCaseObjLst_Sel1 =
from objPubClassCaseEN in arrPubClassCaseObjLst_Cache
where objPubClassCaseEN.id_PubClassCase == strid_PubClassCase
select objPubClassCaseEN;
List <clsPubClassCaseEN> arrPubClassCaseObjLst_Sel = new List<clsPubClassCaseEN>();
foreach (clsPubClassCaseEN obj in arrPubClassCaseObjLst_Sel1)
{
arrPubClassCaseObjLst_Sel.Add(obj);
}
if (arrPubClassCaseObjLst_Sel.Count > 0)
{
return arrPubClassCaseObjLst_Sel[0].PubClassCaseName;
}
string strErrMsgForGetObjById = string.Format("在PubClassCase对象缓存列表中,找不到记录的相关名称[id_PubClassCase = {0}](函数:{1})", strid_PubClassCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPubClassCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseEN> GetObjLst(string strWhereCond)
{
 List<clsPubClassCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubClassCaseEN> GetObjLstById_PubClassCaseLst(List<string> arrId_PubClassCase)
{
 List<clsPubClassCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_PubClassCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsPubClassCaseEN> GetObjLstById_PubClassCaseLst_Cache(List<string> arrId_PubClassCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsPubClassCaseEN._CurrTabName_S);
List<clsPubClassCaseEN> arrPubClassCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPubClassCaseEN> arrPubClassCaseObjLst_Sel =
from objPubClassCaseEN in arrPubClassCaseObjLst_Cache
where arrId_PubClassCase.Contains(objPubClassCaseEN.id_PubClassCase)
select objPubClassCaseEN;
return arrPubClassCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseEN> GetObjLstById_PubClassCaseLst_WA_Cache(List<string> arrId_PubClassCase)
{
 List<clsPubClassCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubClassCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsPubClassCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubClassCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsPubClassCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubClassCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsPubClassCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubClassCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsPubClassCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_PubClassCase)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsPubClassCaseEN objPubClassCaseEN = clsPubClassCaseWApi.GetObjByid_PubClassCase(strid_PubClassCase);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_PubClassCase.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsPubClassCaseWApi.ReFreshCache();
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
public static int DelPubClassCases(List<string> arrid_PubClassCase)
{
string strAction = "DelPubClassCases";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_PubClassCase);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsPubClassCaseWApi.ReFreshCache();
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
public static int DelPubClassCasesByCond(string strWhereCond)
{
string strAction = "DelPubClassCasesByCond";
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
public static bool AddNewRecord(clsPubClassCaseEN objPubClassCaseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubClassCaseEN>(objPubClassCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsPubClassCaseEN objPubClassCaseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubClassCaseEN>(objPubClassCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseWApi.ReFreshCache();
var strid_PubClassCase = (string)jobjReturn["ReturnStr"];
return strid_PubClassCase;
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
public static bool UpdateRecord(clsPubClassCaseEN objPubClassCaseEN)
{
if (string.IsNullOrEmpty(objPubClassCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPubClassCaseEN.id_PubClassCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubClassCaseEN>(objPubClassCaseEN);
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
 /// <param name = "objPubClassCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsPubClassCaseEN objPubClassCaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objPubClassCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPubClassCaseEN.id_PubClassCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPubClassCaseEN.id_PubClassCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubClassCaseEN>(objPubClassCaseEN);
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
public static bool IsExist(string strid_PubClassCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCase"] = strid_PubClassCase
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
 /// <param name = "objPubClassCaseENS">源对象</param>
 /// <param name = "objPubClassCaseENT">目标对象</param>
 public static void CopyTo(clsPubClassCaseEN objPubClassCaseENS, clsPubClassCaseEN objPubClassCaseENT)
{
try
{
objPubClassCaseENT.id_PubClassCase = objPubClassCaseENS.id_PubClassCase; //案例流水号
objPubClassCaseENT.PubClassCaseID = objPubClassCaseENS.PubClassCaseID; //案例ID
objPubClassCaseENT.PubClassCaseName = objPubClassCaseENS.PubClassCaseName; //案例课题名称
objPubClassCaseENT.PubClassCaseExecutor = objPubClassCaseENS.PubClassCaseExecutor; //案例执教者
objPubClassCaseENT.WorkUnit = objPubClassCaseENS.WorkUnit; //工作单位
objPubClassCaseENT.PubClassCaseTheme = objPubClassCaseENS.PubClassCaseTheme; //案例主题词
objPubClassCaseENT.PubClassCaseBG = objPubClassCaseENS.PubClassCaseBG; //案例背景资料
objPubClassCaseENT.PubClassCaseTeachDate = objPubClassCaseENS.PubClassCaseTeachDate; //案例授课日期
objPubClassCaseENT.PubClassCaseDateIn = objPubClassCaseENS.PubClassCaseDateIn; //案例入库日期
objPubClassCaseENT.id_Discipline = objPubClassCaseENS.id_Discipline; //学科流水号
objPubClassCaseENT.id_TeachingPlan = objPubClassCaseENS.id_TeachingPlan; //教案流水号
objPubClassCaseENT.PubClassCaseTimeIn = objPubClassCaseENS.PubClassCaseTimeIn; //案例入库时间
objPubClassCaseENT.id_PubClassCaseSenateGaugeVersion = objPubClassCaseENS.id_PubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objPubClassCaseENT.BrowseCount = objPubClassCaseENS.BrowseCount; //浏览次数
objPubClassCaseENT.id_PubCaseType = objPubClassCaseENS.id_PubCaseType; //公开课案例类型流水号
objPubClassCaseENT.id_StudyLevel = objPubClassCaseENS.id_StudyLevel; //id_StudyLevel
objPubClassCaseENT.CD_ID = objPubClassCaseENS.CD_ID; //光盘编号
objPubClassCaseENT.Introduction = objPubClassCaseENS.Introduction; //简要介绍
objPubClassCaseENT.IsVisible = objPubClassCaseENS.IsVisible; //是否显示
objPubClassCaseENT.IsDualVideo = objPubClassCaseENS.IsDualVideo; //是否双视频
objPubClassCaseENT.RecommendedDegreeId = objPubClassCaseENS.RecommendedDegreeId; //推荐度Id
objPubClassCaseENT.ftpFileType = objPubClassCaseENS.ftpFileType; //ftp文件类型
objPubClassCaseENT.VideoUrl = objPubClassCaseENS.VideoUrl; //视频Url
objPubClassCaseENT.VideoPath = objPubClassCaseENS.VideoPath; //视频目录
objPubClassCaseENT.ResErrMsg = objPubClassCaseENS.ResErrMsg; //资源错误信息
objPubClassCaseENT.UpdDate = objPubClassCaseENS.UpdDate; //修改日期
objPubClassCaseENT.UpdUserId = objPubClassCaseENS.UpdUserId; //修改用户Id
objPubClassCaseENT.Memo = objPubClassCaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsPubClassCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsPubClassCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsPubClassCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsPubClassCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsPubClassCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsPubClassCaseEN.AttributeName)
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
if (clsPubClassCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseWApi没有刷新缓存机制(clsPubClassCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_PubClassCase");
//if (arrPubClassCaseObjLst_Cache == null)
//{
//arrPubClassCaseObjLst_Cache = await clsPubClassCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsPubClassCaseEN._CurrTabName_S);
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
if (clsPubClassCaseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPubClassCaseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsPubClassCaseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPubClassCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsPubClassCaseEN._CurrTabName_S);
List<clsPubClassCaseEN> arrPubClassCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPubClassCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsPubClassCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conPubClassCase.id_PubClassCase, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.PubClassCaseID, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.PubClassCaseName, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.PubClassCaseExecutor, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.WorkUnit, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.PubClassCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.PubClassCaseBG, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.PubClassCaseTeachDate, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.PubClassCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.PubClassCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.id_PubClassCaseSenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conPubClassCase.id_PubCaseType, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.CD_ID, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.Introduction, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPubClassCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPubClassCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCase.Memo, Type.GetType("System.String"));
foreach (clsPubClassCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conPubClassCase.id_PubClassCase] = objInFor[conPubClassCase.id_PubClassCase];
objDR[conPubClassCase.PubClassCaseID] = objInFor[conPubClassCase.PubClassCaseID];
objDR[conPubClassCase.PubClassCaseName] = objInFor[conPubClassCase.PubClassCaseName];
objDR[conPubClassCase.PubClassCaseExecutor] = objInFor[conPubClassCase.PubClassCaseExecutor];
objDR[conPubClassCase.WorkUnit] = objInFor[conPubClassCase.WorkUnit];
objDR[conPubClassCase.PubClassCaseTheme] = objInFor[conPubClassCase.PubClassCaseTheme];
objDR[conPubClassCase.PubClassCaseBG] = objInFor[conPubClassCase.PubClassCaseBG];
objDR[conPubClassCase.PubClassCaseTeachDate] = objInFor[conPubClassCase.PubClassCaseTeachDate];
objDR[conPubClassCase.PubClassCaseDateIn] = objInFor[conPubClassCase.PubClassCaseDateIn];
objDR[conPubClassCase.id_Discipline] = objInFor[conPubClassCase.id_Discipline];
objDR[conPubClassCase.id_TeachingPlan] = objInFor[conPubClassCase.id_TeachingPlan];
objDR[conPubClassCase.PubClassCaseTimeIn] = objInFor[conPubClassCase.PubClassCaseTimeIn];
objDR[conPubClassCase.id_PubClassCaseSenateGaugeVersion] = objInFor[conPubClassCase.id_PubClassCaseSenateGaugeVersion];
objDR[conPubClassCase.BrowseCount] = objInFor[conPubClassCase.BrowseCount];
objDR[conPubClassCase.id_PubCaseType] = objInFor[conPubClassCase.id_PubCaseType];
objDR[conPubClassCase.id_StudyLevel] = objInFor[conPubClassCase.id_StudyLevel];
objDR[conPubClassCase.CD_ID] = objInFor[conPubClassCase.CD_ID];
objDR[conPubClassCase.Introduction] = objInFor[conPubClassCase.Introduction];
objDR[conPubClassCase.IsVisible] = objInFor[conPubClassCase.IsVisible];
objDR[conPubClassCase.IsDualVideo] = objInFor[conPubClassCase.IsDualVideo];
objDR[conPubClassCase.RecommendedDegreeId] = objInFor[conPubClassCase.RecommendedDegreeId];
objDR[conPubClassCase.ftpFileType] = objInFor[conPubClassCase.ftpFileType];
objDR[conPubClassCase.VideoUrl] = objInFor[conPubClassCase.VideoUrl];
objDR[conPubClassCase.VideoPath] = objInFor[conPubClassCase.VideoPath];
objDR[conPubClassCase.ResErrMsg] = objInFor[conPubClassCase.ResErrMsg];
objDR[conPubClassCase.UpdDate] = objInFor[conPubClassCase.UpdDate];
objDR[conPubClassCase.UpdUserId] = objInFor[conPubClassCase.UpdUserId];
objDR[conPubClassCase.Memo] = objInFor[conPubClassCase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 公开课案例(PubClassCase)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4PubClassCase : clsCommFun4BL
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
clsPubClassCaseWApi.ReFreshThisCache();
}
}

}