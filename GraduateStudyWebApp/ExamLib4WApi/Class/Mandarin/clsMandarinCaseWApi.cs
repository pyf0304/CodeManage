
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMandarinCaseWApi
 表名:MandarinCase(01120466)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:50
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
public static class clsMandarinCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN Setid_MandarinCase(this clsMandarinCaseEN objMandarinCaseEN, string strid_MandarinCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MandarinCase, 8, conMandarinCase.id_MandarinCase);
clsCheckSql.CheckFieldForeignKey(strid_MandarinCase, 8, conMandarinCase.id_MandarinCase);
objMandarinCaseEN.id_MandarinCase = strid_MandarinCase; //普通话案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.id_MandarinCase) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.id_MandarinCase, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.id_MandarinCase] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetMandarinCaseID(this clsMandarinCaseEN objMandarinCaseEN, string strMandarinCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMandarinCaseID, conMandarinCase.MandarinCaseID);
clsCheckSql.CheckFieldLen(strMandarinCaseID, 8, conMandarinCase.MandarinCaseID);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseID, 8, conMandarinCase.MandarinCaseID);
objMandarinCaseEN.MandarinCaseID = strMandarinCaseID; //普通话教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.MandarinCaseID) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.MandarinCaseID, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.MandarinCaseID] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetMandarinCaseName(this clsMandarinCaseEN objMandarinCaseEN, string strMandarinCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMandarinCaseName, conMandarinCase.MandarinCaseName);
clsCheckSql.CheckFieldLen(strMandarinCaseName, 100, conMandarinCase.MandarinCaseName);
objMandarinCaseEN.MandarinCaseName = strMandarinCaseName; //普通话教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.MandarinCaseName) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.MandarinCaseName, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.MandarinCaseName] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN Setid_Discipline(this clsMandarinCaseEN objMandarinCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, conMandarinCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, conMandarinCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, conMandarinCase.id_Discipline);
objMandarinCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.id_Discipline) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.id_Discipline, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.id_Discipline] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN Setid_StudyLevel(this clsMandarinCaseEN objMandarinCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, conMandarinCase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, conMandarinCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, conMandarinCase.id_StudyLevel);
objMandarinCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.id_StudyLevel) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.id_StudyLevel, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.id_StudyLevel] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetMandarinCaseTheme(this clsMandarinCaseEN objMandarinCaseEN, string strMandarinCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseTheme, 200, conMandarinCase.MandarinCaseTheme);
objMandarinCaseEN.MandarinCaseTheme = strMandarinCaseTheme; //普通话教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.MandarinCaseTheme) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.MandarinCaseTheme, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.MandarinCaseTheme] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetMandarinCaseDate(this clsMandarinCaseEN objMandarinCaseEN, string strMandarinCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseDate, 8, conMandarinCase.MandarinCaseDate);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseDate, 8, conMandarinCase.MandarinCaseDate);
objMandarinCaseEN.MandarinCaseDate = strMandarinCaseDate; //普通话教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.MandarinCaseDate) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.MandarinCaseDate, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.MandarinCaseDate] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetMandarinCaseTime(this clsMandarinCaseEN objMandarinCaseEN, string strMandarinCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseTime, 6, conMandarinCase.MandarinCaseTime);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseTime, 6, conMandarinCase.MandarinCaseTime);
objMandarinCaseEN.MandarinCaseTime = strMandarinCaseTime; //普通话教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.MandarinCaseTime) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.MandarinCaseTime, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.MandarinCaseTime] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetMandarinCaseDateIn(this clsMandarinCaseEN objMandarinCaseEN, string strMandarinCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseDateIn, 8, conMandarinCase.MandarinCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseDateIn, 8, conMandarinCase.MandarinCaseDateIn);
objMandarinCaseEN.MandarinCaseDateIn = strMandarinCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.MandarinCaseDateIn) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.MandarinCaseDateIn, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.MandarinCaseDateIn] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetMandarinCaseTimeIn(this clsMandarinCaseEN objMandarinCaseEN, string strMandarinCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseTimeIn, 6, conMandarinCase.MandarinCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseTimeIn, 6, conMandarinCase.MandarinCaseTimeIn);
objMandarinCaseEN.MandarinCaseTimeIn = strMandarinCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.MandarinCaseTimeIn) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.MandarinCaseTimeIn, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.MandarinCaseTimeIn] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN Setid_TeachingPlan(this clsMandarinCaseEN objMandarinCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingPlan, conMandarinCase.id_TeachingPlan);
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, conMandarinCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, conMandarinCase.id_TeachingPlan);
objMandarinCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.id_TeachingPlan) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.id_TeachingPlan, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.id_TeachingPlan] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN Setid_SenateGaugeVersion(this clsMandarinCaseEN objMandarinCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, conMandarinCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conMandarinCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conMandarinCase.id_SenateGaugeVersion);
objMandarinCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.id_SenateGaugeVersion) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetCaseLevelId(this clsMandarinCaseEN objMandarinCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conMandarinCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conMandarinCase.CaseLevelId);
objMandarinCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.CaseLevelId) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.CaseLevelId, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.CaseLevelId] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetIsNeedGeneWord(this clsMandarinCaseEN objMandarinCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objMandarinCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.IsNeedGeneWord) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetDocFile(this clsMandarinCaseEN objMandarinCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, conMandarinCase.DocFile);
objMandarinCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.DocFile) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.DocFile, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.DocFile] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetWordCreateDate(this clsMandarinCaseEN objMandarinCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conMandarinCase.WordCreateDate);
objMandarinCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.WordCreateDate) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.WordCreateDate, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.WordCreateDate] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetBrowseCount(this clsMandarinCaseEN objMandarinCaseEN, int intBrowseCount, string strComparisonOp="")
	{
objMandarinCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.BrowseCount) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.BrowseCount, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.BrowseCount] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetIsVisible(this clsMandarinCaseEN objMandarinCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objMandarinCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.IsVisible) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.IsVisible, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.IsVisible] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetOwnerId(this clsMandarinCaseEN objMandarinCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conMandarinCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, conMandarinCase.OwnerId);
objMandarinCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.OwnerId) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.OwnerId, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.OwnerId] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetIsDualVideo(this clsMandarinCaseEN objMandarinCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, conMandarinCase.IsDualVideo);
objMandarinCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.IsDualVideo) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.IsDualVideo, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.IsDualVideo] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN Setid_MandarinCaseType(this clsMandarinCaseEN objMandarinCaseEN, string strid_MandarinCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MandarinCaseType, 4, conMandarinCase.id_MandarinCaseType);
clsCheckSql.CheckFieldForeignKey(strid_MandarinCaseType, 4, conMandarinCase.id_MandarinCaseType);
objMandarinCaseEN.id_MandarinCaseType = strid_MandarinCaseType; //普通话案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.id_MandarinCaseType) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.id_MandarinCaseType, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.id_MandarinCaseType] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetUserTypeId(this clsMandarinCaseEN objMandarinCaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conMandarinCase.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conMandarinCase.UserTypeId);
objMandarinCaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.UserTypeId) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.UserTypeId, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.UserTypeId] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetRecommendedDegreeId(this clsMandarinCaseEN objMandarinCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conMandarinCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conMandarinCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conMandarinCase.RecommendedDegreeId);
objMandarinCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.RecommendedDegreeId) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetftpFileType(this clsMandarinCaseEN objMandarinCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conMandarinCase.ftpFileType);
objMandarinCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.ftpFileType) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.ftpFileType, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.ftpFileType] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetVideoUrl(this clsMandarinCaseEN objMandarinCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conMandarinCase.VideoUrl);
objMandarinCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.VideoUrl) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.VideoUrl, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.VideoUrl] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetVideoPath(this clsMandarinCaseEN objMandarinCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conMandarinCase.VideoPath);
objMandarinCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.VideoPath) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.VideoPath, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.VideoPath] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetResErrMsg(this clsMandarinCaseEN objMandarinCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conMandarinCase.ResErrMsg);
objMandarinCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.ResErrMsg) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.ResErrMsg, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.ResErrMsg] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetUpdDate(this clsMandarinCaseEN objMandarinCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conMandarinCase.UpdDate);
objMandarinCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.UpdDate) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.UpdDate, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.UpdDate] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetUpdUserId(this clsMandarinCaseEN objMandarinCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conMandarinCase.UpdUserId);
objMandarinCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.UpdUserId) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.UpdUserId, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.UpdUserId] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMandarinCaseEN SetMemo(this clsMandarinCaseEN objMandarinCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conMandarinCase.Memo);
objMandarinCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMandarinCaseEN.dicFldComparisonOp.ContainsKey(conMandarinCase.Memo) == false)
{
objMandarinCaseEN.dicFldComparisonOp.Add(conMandarinCase.Memo, strComparisonOp);
}
else
{
objMandarinCaseEN.dicFldComparisonOp[conMandarinCase.Memo] = strComparisonOp;
}
}
return objMandarinCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMandarinCaseEN objMandarinCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.id_MandarinCase) == true)
{
string strComparisonOp_id_MandarinCase = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.id_MandarinCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.id_MandarinCase, objMandarinCase_Cond.id_MandarinCase, strComparisonOp_id_MandarinCase);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.MandarinCaseID) == true)
{
string strComparisonOp_MandarinCaseID = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.MandarinCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.MandarinCaseID, objMandarinCase_Cond.MandarinCaseID, strComparisonOp_MandarinCaseID);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.MandarinCaseName) == true)
{
string strComparisonOp_MandarinCaseName = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.MandarinCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.MandarinCaseName, objMandarinCase_Cond.MandarinCaseName, strComparisonOp_MandarinCaseName);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.id_Discipline, objMandarinCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.id_StudyLevel, objMandarinCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.MandarinCaseTheme) == true)
{
string strComparisonOp_MandarinCaseTheme = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.MandarinCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.MandarinCaseTheme, objMandarinCase_Cond.MandarinCaseTheme, strComparisonOp_MandarinCaseTheme);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.MandarinCaseDate) == true)
{
string strComparisonOp_MandarinCaseDate = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.MandarinCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.MandarinCaseDate, objMandarinCase_Cond.MandarinCaseDate, strComparisonOp_MandarinCaseDate);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.MandarinCaseTime) == true)
{
string strComparisonOp_MandarinCaseTime = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.MandarinCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.MandarinCaseTime, objMandarinCase_Cond.MandarinCaseTime, strComparisonOp_MandarinCaseTime);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.MandarinCaseDateIn) == true)
{
string strComparisonOp_MandarinCaseDateIn = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.MandarinCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.MandarinCaseDateIn, objMandarinCase_Cond.MandarinCaseDateIn, strComparisonOp_MandarinCaseDateIn);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.MandarinCaseTimeIn) == true)
{
string strComparisonOp_MandarinCaseTimeIn = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.MandarinCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.MandarinCaseTimeIn, objMandarinCase_Cond.MandarinCaseTimeIn, strComparisonOp_MandarinCaseTimeIn);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.id_TeachingPlan, objMandarinCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.id_SenateGaugeVersion, objMandarinCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.CaseLevelId, objMandarinCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.IsNeedGeneWord) == true)
{
if (objMandarinCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMandarinCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMandarinCase.IsNeedGeneWord);
}
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.DocFile) == true)
{
string strComparisonOp_DocFile = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.DocFile, objMandarinCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.WordCreateDate, objMandarinCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conMandarinCase.BrowseCount, objMandarinCase_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.IsVisible) == true)
{
if (objMandarinCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMandarinCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMandarinCase.IsVisible);
}
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.OwnerId, objMandarinCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.IsDualVideo) == true)
{
if (objMandarinCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMandarinCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMandarinCase.IsDualVideo);
}
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.id_MandarinCaseType) == true)
{
string strComparisonOp_id_MandarinCaseType = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.id_MandarinCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.id_MandarinCaseType, objMandarinCase_Cond.id_MandarinCaseType, strComparisonOp_id_MandarinCaseType);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.UserTypeId, objMandarinCase_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.RecommendedDegreeId, objMandarinCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.ftpFileType, objMandarinCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.VideoUrl, objMandarinCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.VideoPath, objMandarinCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.ResErrMsg, objMandarinCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.UpdDate, objMandarinCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.UpdUserId, objMandarinCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objMandarinCase_Cond.IsUpdated(conMandarinCase.Memo) == true)
{
string strComparisonOp_Memo = objMandarinCase_Cond.dicFldComparisonOp[conMandarinCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMandarinCase.Memo, objMandarinCase_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMandarinCaseEN objMandarinCaseEN)
{
 if (string.IsNullOrEmpty(objMandarinCaseEN.id_MandarinCase) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objMandarinCaseEN.sf_UpdFldSetStr = objMandarinCaseEN.getsf_UpdFldSetStr();
clsMandarinCaseWApi.CheckPropertyNew(objMandarinCaseEN); 
bool bolResult = clsMandarinCaseWApi.UpdateRecord(objMandarinCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMandarinCaseWApi.ReFreshCache();
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
 /// <param name = "objMandarinCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMandarinCaseEN objMandarinCaseEN)
{
 if (string.IsNullOrEmpty(objMandarinCaseEN.id_MandarinCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsMandarinCaseWApi.IsExist(objMandarinCaseEN.id_MandarinCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objMandarinCaseEN.id_MandarinCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsMandarinCaseWApi.CheckPropertyNew(objMandarinCaseEN); 
bool bolResult = clsMandarinCaseWApi.AddNewRecord(objMandarinCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMandarinCaseWApi.ReFreshCache();
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
 /// <param name = "objMandarinCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsMandarinCaseEN objMandarinCaseEN)
{
try
{
clsMandarinCaseWApi.CheckPropertyNew(objMandarinCaseEN); 
string strid_MandarinCase = clsMandarinCaseWApi.AddNewRecordWithMaxId(objMandarinCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMandarinCaseWApi.ReFreshCache();
return strid_MandarinCase;
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
 /// <param name = "objMandarinCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMandarinCaseEN objMandarinCaseEN, string strWhereCond)
{
try
{
clsMandarinCaseWApi.CheckPropertyNew(objMandarinCaseEN); 
bool bolResult = clsMandarinCaseWApi.UpdateWithCondition(objMandarinCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMandarinCaseWApi.ReFreshCache();
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
 /// 普通话教学案例(MandarinCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsMandarinCaseWApi
{
private static readonly string mstrApiControllerName = "MandarinCaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsMandarinCaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_MandarinCase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[普通话教学案例]...","0");
List<clsMandarinCaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_MandarinCase";
objDDL.DataTextField="MandarinCaseName";
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
public static void BindCbo_id_MandarinCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conMandarinCase.id_MandarinCase); 
List<clsMandarinCaseEN> arrObjLst = clsMandarinCaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsMandarinCaseEN objMandarinCaseEN = new clsMandarinCaseEN()
{
id_MandarinCase = "0",
MandarinCaseName = "选[普通话教学案例]..."
};
arrObjLst.Insert(0, objMandarinCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conMandarinCase.id_MandarinCase;
objComboBox.DisplayMember = conMandarinCase.MandarinCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsMandarinCaseEN objMandarinCaseEN)
{
if (!Object.Equals(null, objMandarinCaseEN.id_MandarinCase) && GetStrLen(objMandarinCaseEN.id_MandarinCase) > 8)
{
 throw new Exception("字段[普通话案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objMandarinCaseEN.MandarinCaseID) && GetStrLen(objMandarinCaseEN.MandarinCaseID) > 8)
{
 throw new Exception("字段[普通话教学案例ID]的长度不能超过8!");
}
if (!Object.Equals(null, objMandarinCaseEN.MandarinCaseName) && GetStrLen(objMandarinCaseEN.MandarinCaseName) > 100)
{
 throw new Exception("字段[普通话教学案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objMandarinCaseEN.id_Discipline) && GetStrLen(objMandarinCaseEN.id_Discipline) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objMandarinCaseEN.id_StudyLevel) && GetStrLen(objMandarinCaseEN.id_StudyLevel) > 4)
{
 throw new Exception("字段[id_StudyLevel]的长度不能超过4!");
}
if (!Object.Equals(null, objMandarinCaseEN.MandarinCaseTheme) && GetStrLen(objMandarinCaseEN.MandarinCaseTheme) > 200)
{
 throw new Exception("字段[普通话教学案例主题词]的长度不能超过200!");
}
if (!Object.Equals(null, objMandarinCaseEN.MandarinCaseDate) && GetStrLen(objMandarinCaseEN.MandarinCaseDate) > 8)
{
 throw new Exception("字段[普通话教学日期]的长度不能超过8!");
}
if (!Object.Equals(null, objMandarinCaseEN.MandarinCaseTime) && GetStrLen(objMandarinCaseEN.MandarinCaseTime) > 6)
{
 throw new Exception("字段[普通话教学时间]的长度不能超过6!");
}
if (!Object.Equals(null, objMandarinCaseEN.MandarinCaseDateIn) && GetStrLen(objMandarinCaseEN.MandarinCaseDateIn) > 8)
{
 throw new Exception("字段[案例入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objMandarinCaseEN.MandarinCaseTimeIn) && GetStrLen(objMandarinCaseEN.MandarinCaseTimeIn) > 6)
{
 throw new Exception("字段[案例入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objMandarinCaseEN.id_TeachingPlan) && GetStrLen(objMandarinCaseEN.id_TeachingPlan) > 8)
{
 throw new Exception("字段[教案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objMandarinCaseEN.id_SenateGaugeVersion) && GetStrLen(objMandarinCaseEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objMandarinCaseEN.CaseLevelId) && GetStrLen(objMandarinCaseEN.CaseLevelId) > 2)
{
 throw new Exception("字段[课例等级Id]的长度不能超过2!");
}
if (!Object.Equals(null, objMandarinCaseEN.DocFile) && GetStrLen(objMandarinCaseEN.DocFile) > 200)
{
 throw new Exception("字段[生成的Word文件名]的长度不能超过200!");
}
if (!Object.Equals(null, objMandarinCaseEN.WordCreateDate) && GetStrLen(objMandarinCaseEN.WordCreateDate) > 14)
{
 throw new Exception("字段[Word生成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objMandarinCaseEN.OwnerId) && GetStrLen(objMandarinCaseEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objMandarinCaseEN.id_MandarinCaseType) && GetStrLen(objMandarinCaseEN.id_MandarinCaseType) > 4)
{
 throw new Exception("字段[普通话案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objMandarinCaseEN.UserTypeId) && GetStrLen(objMandarinCaseEN.UserTypeId) > 2)
{
 throw new Exception("字段[用户类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objMandarinCaseEN.RecommendedDegreeId) && GetStrLen(objMandarinCaseEN.RecommendedDegreeId) > 2)
{
 throw new Exception("字段[推荐度Id]的长度不能超过2!");
}
if (!Object.Equals(null, objMandarinCaseEN.ftpFileType) && GetStrLen(objMandarinCaseEN.ftpFileType) > 30)
{
 throw new Exception("字段[ftp文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objMandarinCaseEN.VideoUrl) && GetStrLen(objMandarinCaseEN.VideoUrl) > 1000)
{
 throw new Exception("字段[视频Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objMandarinCaseEN.VideoPath) && GetStrLen(objMandarinCaseEN.VideoPath) > 1000)
{
 throw new Exception("字段[视频目录]的长度不能超过1000!");
}
if (!Object.Equals(null, objMandarinCaseEN.ResErrMsg) && GetStrLen(objMandarinCaseEN.ResErrMsg) > 30)
{
 throw new Exception("字段[资源错误信息]的长度不能超过30!");
}
if (!Object.Equals(null, objMandarinCaseEN.UpdDate) && GetStrLen(objMandarinCaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objMandarinCaseEN.UpdUserId) && GetStrLen(objMandarinCaseEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objMandarinCaseEN.Memo) && GetStrLen(objMandarinCaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objMandarinCaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_MandarinCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsMandarinCaseEN GetObjByid_MandarinCase(string strid_MandarinCase)
{
string strAction = "GetObjByid_MandarinCase";
string strErrMsg = string.Empty;
string strResult = "";
clsMandarinCaseEN objMandarinCaseEN = null;
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
objMandarinCaseEN = JsonConvert.DeserializeObject<clsMandarinCaseEN>((string)jobjReturn["ReturnObj"]);
return objMandarinCaseEN;
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
public static clsMandarinCaseEN GetObjByid_MandarinCase_WA_Cache(string strid_MandarinCase)
{
string strAction = "GetObjByid_MandarinCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsMandarinCaseEN objMandarinCaseEN = null;
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
objMandarinCaseEN = JsonConvert.DeserializeObject<clsMandarinCaseEN>((string)jobjReturn["ReturnObj"]);
return objMandarinCaseEN;
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
public static clsMandarinCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsMandarinCaseEN objMandarinCaseEN = null;
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
objMandarinCaseEN = JsonConvert.DeserializeObject<clsMandarinCaseEN>((string)jobjReturn["ReturnObj"]);
return objMandarinCaseEN;
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
public static clsMandarinCaseEN GetObjByid_MandarinCase_Cache(string strid_MandarinCase)
{
if (string.IsNullOrEmpty(strid_MandarinCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsMandarinCaseEN._CurrTabName_S);
List<clsMandarinCaseEN> arrMandarinCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMandarinCaseEN> arrMandarinCaseObjLst_Sel =
from objMandarinCaseEN in arrMandarinCaseObjLst_Cache
where objMandarinCaseEN.id_MandarinCase == strid_MandarinCase
select objMandarinCaseEN;
if (arrMandarinCaseObjLst_Sel.Count() == 0)
{
   clsMandarinCaseEN obj = clsMandarinCaseWApi.GetObjByid_MandarinCase(strid_MandarinCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrMandarinCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_MandarinCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMandarinCaseNameByid_MandarinCase_Cache(string strid_MandarinCase)
{
if (string.IsNullOrEmpty(strid_MandarinCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsMandarinCaseEN._CurrTabName_S);
List<clsMandarinCaseEN> arrMandarinCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMandarinCaseEN> arrMandarinCaseObjLst_Sel1 =
from objMandarinCaseEN in arrMandarinCaseObjLst_Cache
where objMandarinCaseEN.id_MandarinCase == strid_MandarinCase
select objMandarinCaseEN;
List <clsMandarinCaseEN> arrMandarinCaseObjLst_Sel = new List<clsMandarinCaseEN>();
foreach (clsMandarinCaseEN obj in arrMandarinCaseObjLst_Sel1)
{
arrMandarinCaseObjLst_Sel.Add(obj);
}
if (arrMandarinCaseObjLst_Sel.Count > 0)
{
return arrMandarinCaseObjLst_Sel[0].MandarinCaseName;
}
string strErrMsgForGetObjById = string.Format("在MandarinCase对象缓存列表中,找不到记录[id_MandarinCase = {0}](函数:{1})", strid_MandarinCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsMandarinCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_MandarinCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_MandarinCase_Cache(string strid_MandarinCase)
{
if (string.IsNullOrEmpty(strid_MandarinCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsMandarinCaseEN._CurrTabName_S);
List<clsMandarinCaseEN> arrMandarinCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMandarinCaseEN> arrMandarinCaseObjLst_Sel1 =
from objMandarinCaseEN in arrMandarinCaseObjLst_Cache
where objMandarinCaseEN.id_MandarinCase == strid_MandarinCase
select objMandarinCaseEN;
List <clsMandarinCaseEN> arrMandarinCaseObjLst_Sel = new List<clsMandarinCaseEN>();
foreach (clsMandarinCaseEN obj in arrMandarinCaseObjLst_Sel1)
{
arrMandarinCaseObjLst_Sel.Add(obj);
}
if (arrMandarinCaseObjLst_Sel.Count > 0)
{
return arrMandarinCaseObjLst_Sel[0].MandarinCaseName;
}
string strErrMsgForGetObjById = string.Format("在MandarinCase对象缓存列表中,找不到记录的相关名称[id_MandarinCase = {0}](函数:{1})", strid_MandarinCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsMandarinCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMandarinCaseEN> GetObjLst(string strWhereCond)
{
 List<clsMandarinCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMandarinCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMandarinCaseEN> GetObjLstById_MandarinCaseLst(List<string> arrId_MandarinCase)
{
 List<clsMandarinCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMandarinCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsMandarinCaseEN> GetObjLstById_MandarinCaseLst_Cache(List<string> arrId_MandarinCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsMandarinCaseEN._CurrTabName_S);
List<clsMandarinCaseEN> arrMandarinCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMandarinCaseEN> arrMandarinCaseObjLst_Sel =
from objMandarinCaseEN in arrMandarinCaseObjLst_Cache
where arrId_MandarinCase.Contains(objMandarinCaseEN.id_MandarinCase)
select objMandarinCaseEN;
return arrMandarinCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMandarinCaseEN> GetObjLstById_MandarinCaseLst_WA_Cache(List<string> arrId_MandarinCase)
{
 List<clsMandarinCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMandarinCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMandarinCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsMandarinCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMandarinCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMandarinCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsMandarinCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMandarinCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMandarinCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsMandarinCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMandarinCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMandarinCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsMandarinCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMandarinCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_MandarinCase)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsMandarinCaseEN objMandarinCaseEN = clsMandarinCaseWApi.GetObjByid_MandarinCase(strid_MandarinCase);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_MandarinCase.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsMandarinCaseWApi.ReFreshCache();
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
public static int DelMandarinCases(List<string> arrid_MandarinCase)
{
string strAction = "DelMandarinCases";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_MandarinCase);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsMandarinCaseWApi.ReFreshCache();
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
public static int DelMandarinCasesByCond(string strWhereCond)
{
string strAction = "DelMandarinCasesByCond";
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
public static bool AddNewRecord(clsMandarinCaseEN objMandarinCaseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMandarinCaseEN>(objMandarinCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMandarinCaseWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsMandarinCaseEN objMandarinCaseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMandarinCaseEN>(objMandarinCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMandarinCaseWApi.ReFreshCache();
var strid_MandarinCase = (string)jobjReturn["ReturnStr"];
return strid_MandarinCase;
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
public static bool UpdateRecord(clsMandarinCaseEN objMandarinCaseEN)
{
if (string.IsNullOrEmpty(objMandarinCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMandarinCaseEN.id_MandarinCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMandarinCaseEN>(objMandarinCaseEN);
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
 /// <param name = "objMandarinCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsMandarinCaseEN objMandarinCaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objMandarinCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMandarinCaseEN.id_MandarinCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMandarinCaseEN.id_MandarinCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMandarinCaseEN>(objMandarinCaseEN);
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
 /// <param name = "objMandarinCaseENS">源对象</param>
 /// <param name = "objMandarinCaseENT">目标对象</param>
 public static void CopyTo(clsMandarinCaseEN objMandarinCaseENS, clsMandarinCaseEN objMandarinCaseENT)
{
try
{
objMandarinCaseENT.id_MandarinCase = objMandarinCaseENS.id_MandarinCase; //普通话案例流水号
objMandarinCaseENT.MandarinCaseID = objMandarinCaseENS.MandarinCaseID; //普通话教学案例ID
objMandarinCaseENT.MandarinCaseName = objMandarinCaseENS.MandarinCaseName; //普通话教学案例名称
objMandarinCaseENT.id_Discipline = objMandarinCaseENS.id_Discipline; //学科流水号
objMandarinCaseENT.id_StudyLevel = objMandarinCaseENS.id_StudyLevel; //id_StudyLevel
objMandarinCaseENT.MandarinCaseTheme = objMandarinCaseENS.MandarinCaseTheme; //普通话教学案例主题词
objMandarinCaseENT.MandarinCaseDate = objMandarinCaseENS.MandarinCaseDate; //普通话教学日期
objMandarinCaseENT.MandarinCaseTime = objMandarinCaseENS.MandarinCaseTime; //普通话教学时间
objMandarinCaseENT.MandarinCaseDateIn = objMandarinCaseENS.MandarinCaseDateIn; //案例入库日期
objMandarinCaseENT.MandarinCaseTimeIn = objMandarinCaseENS.MandarinCaseTimeIn; //案例入库时间
objMandarinCaseENT.id_TeachingPlan = objMandarinCaseENS.id_TeachingPlan; //教案流水号
objMandarinCaseENT.id_SenateGaugeVersion = objMandarinCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objMandarinCaseENT.CaseLevelId = objMandarinCaseENS.CaseLevelId; //课例等级Id
objMandarinCaseENT.IsNeedGeneWord = objMandarinCaseENS.IsNeedGeneWord; //是否需要生成Word
objMandarinCaseENT.DocFile = objMandarinCaseENS.DocFile; //生成的Word文件名
objMandarinCaseENT.WordCreateDate = objMandarinCaseENS.WordCreateDate; //Word生成日期
objMandarinCaseENT.BrowseCount = objMandarinCaseENS.BrowseCount; //浏览次数
objMandarinCaseENT.IsVisible = objMandarinCaseENS.IsVisible; //是否显示
objMandarinCaseENT.OwnerId = objMandarinCaseENS.OwnerId; //拥有者Id
objMandarinCaseENT.IsDualVideo = objMandarinCaseENS.IsDualVideo; //是否双视频
objMandarinCaseENT.id_MandarinCaseType = objMandarinCaseENS.id_MandarinCaseType; //普通话案例类型流水号
objMandarinCaseENT.UserTypeId = objMandarinCaseENS.UserTypeId; //用户类型Id
objMandarinCaseENT.RecommendedDegreeId = objMandarinCaseENS.RecommendedDegreeId; //推荐度Id
objMandarinCaseENT.ftpFileType = objMandarinCaseENS.ftpFileType; //ftp文件类型
objMandarinCaseENT.VideoUrl = objMandarinCaseENS.VideoUrl; //视频Url
objMandarinCaseENT.VideoPath = objMandarinCaseENS.VideoPath; //视频目录
objMandarinCaseENT.ResErrMsg = objMandarinCaseENS.ResErrMsg; //资源错误信息
objMandarinCaseENT.UpdDate = objMandarinCaseENS.UpdDate; //修改日期
objMandarinCaseENT.UpdUserId = objMandarinCaseENS.UpdUserId; //修改用户Id
objMandarinCaseENT.Memo = objMandarinCaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsMandarinCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsMandarinCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsMandarinCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsMandarinCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsMandarinCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsMandarinCaseEN.AttributeName)
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
if (clsMandarinCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMandarinCaseWApi没有刷新缓存机制(clsMandarinCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MandarinCase");
//if (arrMandarinCaseObjLst_Cache == null)
//{
//arrMandarinCaseObjLst_Cache = await clsMandarinCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsMandarinCaseEN._CurrTabName_S);
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
if (clsMandarinCaseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMandarinCaseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsMandarinCaseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMandarinCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsMandarinCaseEN._CurrTabName_S);
List<clsMandarinCaseEN> arrMandarinCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMandarinCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsMandarinCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conMandarinCase.id_MandarinCase, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.MandarinCaseID, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.MandarinCaseName, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.MandarinCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.MandarinCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.MandarinCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.MandarinCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.MandarinCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(conMandarinCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conMandarinCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conMandarinCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conMandarinCase.id_MandarinCaseType, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conMandarinCase.Memo, Type.GetType("System.String"));
foreach (clsMandarinCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conMandarinCase.id_MandarinCase] = objInFor[conMandarinCase.id_MandarinCase];
objDR[conMandarinCase.MandarinCaseID] = objInFor[conMandarinCase.MandarinCaseID];
objDR[conMandarinCase.MandarinCaseName] = objInFor[conMandarinCase.MandarinCaseName];
objDR[conMandarinCase.id_Discipline] = objInFor[conMandarinCase.id_Discipline];
objDR[conMandarinCase.id_StudyLevel] = objInFor[conMandarinCase.id_StudyLevel];
objDR[conMandarinCase.MandarinCaseTheme] = objInFor[conMandarinCase.MandarinCaseTheme];
objDR[conMandarinCase.MandarinCaseDate] = objInFor[conMandarinCase.MandarinCaseDate];
objDR[conMandarinCase.MandarinCaseTime] = objInFor[conMandarinCase.MandarinCaseTime];
objDR[conMandarinCase.MandarinCaseDateIn] = objInFor[conMandarinCase.MandarinCaseDateIn];
objDR[conMandarinCase.MandarinCaseTimeIn] = objInFor[conMandarinCase.MandarinCaseTimeIn];
objDR[conMandarinCase.id_TeachingPlan] = objInFor[conMandarinCase.id_TeachingPlan];
objDR[conMandarinCase.id_SenateGaugeVersion] = objInFor[conMandarinCase.id_SenateGaugeVersion];
objDR[conMandarinCase.CaseLevelId] = objInFor[conMandarinCase.CaseLevelId];
objDR[conMandarinCase.IsNeedGeneWord] = objInFor[conMandarinCase.IsNeedGeneWord];
objDR[conMandarinCase.DocFile] = objInFor[conMandarinCase.DocFile];
objDR[conMandarinCase.WordCreateDate] = objInFor[conMandarinCase.WordCreateDate];
objDR[conMandarinCase.BrowseCount] = objInFor[conMandarinCase.BrowseCount];
objDR[conMandarinCase.IsVisible] = objInFor[conMandarinCase.IsVisible];
objDR[conMandarinCase.OwnerId] = objInFor[conMandarinCase.OwnerId];
objDR[conMandarinCase.IsDualVideo] = objInFor[conMandarinCase.IsDualVideo];
objDR[conMandarinCase.id_MandarinCaseType] = objInFor[conMandarinCase.id_MandarinCaseType];
objDR[conMandarinCase.UserTypeId] = objInFor[conMandarinCase.UserTypeId];
objDR[conMandarinCase.RecommendedDegreeId] = objInFor[conMandarinCase.RecommendedDegreeId];
objDR[conMandarinCase.ftpFileType] = objInFor[conMandarinCase.ftpFileType];
objDR[conMandarinCase.VideoUrl] = objInFor[conMandarinCase.VideoUrl];
objDR[conMandarinCase.VideoPath] = objInFor[conMandarinCase.VideoPath];
objDR[conMandarinCase.ResErrMsg] = objInFor[conMandarinCase.ResErrMsg];
objDR[conMandarinCase.UpdDate] = objInFor[conMandarinCase.UpdDate];
objDR[conMandarinCase.UpdUserId] = objInFor[conMandarinCase.UpdUserId];
objDR[conMandarinCase.Memo] = objInFor[conMandarinCase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 普通话教学案例(MandarinCase)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4MandarinCase : clsCommFun4BL
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
clsMandarinCaseWApi.ReFreshThisCache();
}
}

}