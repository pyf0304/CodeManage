
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseWApi
 表名:vPubClassCase(01120386)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:39
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
public static class clsvPubClassCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN Setid_PubClassCase(this clsvPubClassCaseEN objvPubClassCaseEN, string strid_PubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_PubClassCase, 8, convPubClassCase.id_PubClassCase);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCase, 8, convPubClassCase.id_PubClassCase);
objvPubClassCaseEN.id_PubClassCase = strid_PubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.id_PubClassCase) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.id_PubClassCase, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.id_PubClassCase] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetPubClassCaseID(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubClassCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseID, convPubClassCase.PubClassCaseID);
clsCheckSql.CheckFieldLen(strPubClassCaseID, 8, convPubClassCase.PubClassCaseID);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseID, 8, convPubClassCase.PubClassCaseID);
objvPubClassCaseEN.PubClassCaseID = strPubClassCaseID; //案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.PubClassCaseID) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.PubClassCaseID, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.PubClassCaseID] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetPubClassCaseName(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubClassCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseName, convPubClassCase.PubClassCaseName);
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, convPubClassCase.PubClassCaseName);
objvPubClassCaseEN.PubClassCaseName = strPubClassCaseName; //案例课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.PubClassCaseName) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.PubClassCaseName, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.PubClassCaseName] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetPubClassCaseExecutor(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, convPubClassCase.PubClassCaseExecutor);
objvPubClassCaseEN.PubClassCaseExecutor = strPubClassCaseExecutor; //案例执教者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.PubClassCaseExecutor) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.PubClassCaseExecutor, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.PubClassCaseExecutor] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetWorkUnit(this clsvPubClassCaseEN objvPubClassCaseEN, string strWorkUnit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, convPubClassCase.WorkUnit);
objvPubClassCaseEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.WorkUnit) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.WorkUnit, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.WorkUnit] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetPubClassCaseTheme(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubClassCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTheme, 500, convPubClassCase.PubClassCaseTheme);
objvPubClassCaseEN.PubClassCaseTheme = strPubClassCaseTheme; //案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.PubClassCaseTheme) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.PubClassCaseTheme, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.PubClassCaseTheme] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetPubClassCaseBG(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubClassCaseBG, string strComparisonOp="")
	{
objvPubClassCaseEN.PubClassCaseBG = strPubClassCaseBG; //案例背景资料
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.PubClassCaseBG) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.PubClassCaseBG, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.PubClassCaseBG] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetPubClassCaseTeachDate(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubClassCaseTeachDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTeachDate, 8, convPubClassCase.PubClassCaseTeachDate);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTeachDate, 8, convPubClassCase.PubClassCaseTeachDate);
objvPubClassCaseEN.PubClassCaseTeachDate = strPubClassCaseTeachDate; //案例授课日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.PubClassCaseTeachDate) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.PubClassCaseTeachDate, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.PubClassCaseTeachDate] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetPubClassCaseDateIn(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubClassCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseDateIn, 8, convPubClassCase.PubClassCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseDateIn, 8, convPubClassCase.PubClassCaseDateIn);
objvPubClassCaseEN.PubClassCaseDateIn = strPubClassCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.PubClassCaseDateIn) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.PubClassCaseDateIn, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.PubClassCaseDateIn] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN Setid_Discipline(this clsvPubClassCaseEN objvPubClassCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convPubClassCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convPubClassCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convPubClassCase.id_Discipline);
objvPubClassCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.id_Discipline) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.id_Discipline, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.id_Discipline] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetDisciplineID(this clsvPubClassCaseEN objvPubClassCaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convPubClassCase.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convPubClassCase.DisciplineID);
objvPubClassCaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.DisciplineID) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.DisciplineID, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.DisciplineID] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetDisciplineName(this clsvPubClassCaseEN objvPubClassCaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convPubClassCase.DisciplineName);
objvPubClassCaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.DisciplineName) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.DisciplineName, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.DisciplineName] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN Setid_TeachingPlan(this clsvPubClassCaseEN objvPubClassCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convPubClassCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convPubClassCase.id_TeachingPlan);
objvPubClassCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.id_TeachingPlan) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.id_TeachingPlan, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.id_TeachingPlan] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetSubjectName(this clsvPubClassCaseEN objvPubClassCaseEN, string strSubjectName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSubjectName, 200, convPubClassCase.SubjectName);
objvPubClassCaseEN.SubjectName = strSubjectName; //课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.SubjectName) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.SubjectName, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.SubjectName] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetTeachingPlanAuthor(this clsvPubClassCaseEN objvPubClassCaseEN, string strTeachingPlanAuthor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingPlanAuthor, 50, convPubClassCase.TeachingPlanAuthor);
objvPubClassCaseEN.TeachingPlanAuthor = strTeachingPlanAuthor; //教案撰写人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.TeachingPlanAuthor) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.TeachingPlanAuthor, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.TeachingPlanAuthor] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetTeachingObject(this clsvPubClassCaseEN objvPubClassCaseEN, string strTeachingObject, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingObject, 5000, convPubClassCase.TeachingObject);
objvPubClassCaseEN.TeachingObject = strTeachingObject; //教学目标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.TeachingObject) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.TeachingObject, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.TeachingObject] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetTeachingEmphases(this clsvPubClassCaseEN objvPubClassCaseEN, string strTeachingEmphases, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingEmphases, 5000, convPubClassCase.TeachingEmphases);
objvPubClassCaseEN.TeachingEmphases = strTeachingEmphases; //教学重点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.TeachingEmphases) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.TeachingEmphases, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.TeachingEmphases] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetTeachingDifficulty(this clsvPubClassCaseEN objvPubClassCaseEN, string strTeachingDifficulty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingDifficulty, 5000, convPubClassCase.TeachingDifficulty);
objvPubClassCaseEN.TeachingDifficulty = strTeachingDifficulty; //教学难点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.TeachingDifficulty) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.TeachingDifficulty, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.TeachingDifficulty] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetTeachingTool(this clsvPubClassCaseEN objvPubClassCaseEN, string strTeachingTool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingTool, 5000, convPubClassCase.TeachingTool);
objvPubClassCaseEN.TeachingTool = strTeachingTool; //教学用具
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.TeachingTool) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.TeachingTool, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.TeachingTool] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetTeachingProcess(this clsvPubClassCaseEN objvPubClassCaseEN, string strTeachingProcess, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingProcess, 8000, convPubClassCase.TeachingProcess);
objvPubClassCaseEN.TeachingProcess = strTeachingProcess; //教学过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.TeachingProcess) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.TeachingProcess, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.TeachingProcess] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetTeachingPlanType(this clsvPubClassCaseEN objvPubClassCaseEN, string strTeachingPlanType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingPlanType, 1, convPubClassCase.TeachingPlanType);
clsCheckSql.CheckFieldForeignKey(strTeachingPlanType, 1, convPubClassCase.TeachingPlanType);
objvPubClassCaseEN.TeachingPlanType = strTeachingPlanType; //教案类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.TeachingPlanType) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.TeachingPlanType, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.TeachingPlanType] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetSimplePlanContent(this clsvPubClassCaseEN objvPubClassCaseEN, string strSimplePlanContent, string strComparisonOp="")
	{
objvPubClassCaseEN.SimplePlanContent = strSimplePlanContent; //简案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.SimplePlanContent) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.SimplePlanContent, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.SimplePlanContent] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetPubClassCaseTimeIn(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubClassCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTimeIn, 6, convPubClassCase.PubClassCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTimeIn, 6, convPubClassCase.PubClassCaseTimeIn);
objvPubClassCaseEN.PubClassCaseTimeIn = strPubClassCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.PubClassCaseTimeIn) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.PubClassCaseTimeIn, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.PubClassCaseTimeIn] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN Setid_PubClassCaseSenateGaugeVersion(this clsvPubClassCaseEN objvPubClassCaseEN, string strid_PubClassCaseSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubClassCaseSenateGaugeVersion, convPubClassCase.id_PubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_PubClassCaseSenateGaugeVersion, 4, convPubClassCase.id_PubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCaseSenateGaugeVersion, 4, convPubClassCase.id_PubClassCaseSenateGaugeVersion);
objvPubClassCaseEN.id_PubClassCaseSenateGaugeVersion = strid_PubClassCaseSenateGaugeVersion; //公开课量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.id_PubClassCaseSenateGaugeVersion) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.id_PubClassCaseSenateGaugeVersion, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.id_PubClassCaseSenateGaugeVersion] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetsenateGaugeVersionID(this clsvPubClassCaseEN objvPubClassCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convPubClassCase.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convPubClassCase.senateGaugeVersionID);
objvPubClassCaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.senateGaugeVersionID) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.senateGaugeVersionID, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.senateGaugeVersionID] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetsenateGaugeVersionName(this clsvPubClassCaseEN objvPubClassCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convPubClassCase.senateGaugeVersionName);
objvPubClassCaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.senateGaugeVersionName) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.senateGaugeVersionName, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.senateGaugeVersionName] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetsenateGaugeVersionTtlScore(this clsvPubClassCaseEN objvPubClassCaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvPubClassCaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.senateGaugeVersionTtlScore) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN Setid_PubCaseType(this clsvPubClassCaseEN objvPubClassCaseEN, string strid_PubCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_PubCaseType, 4, convPubClassCase.id_PubCaseType);
clsCheckSql.CheckFieldForeignKey(strid_PubCaseType, 4, convPubClassCase.id_PubCaseType);
objvPubClassCaseEN.id_PubCaseType = strid_PubCaseType; //公开课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.id_PubCaseType) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.id_PubCaseType, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.id_PubCaseType] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetPubCaseTypeID(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubCaseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubCaseTypeID, 4, convPubClassCase.PubCaseTypeID);
clsCheckSql.CheckFieldForeignKey(strPubCaseTypeID, 4, convPubClassCase.PubCaseTypeID);
objvPubClassCaseEN.PubCaseTypeID = strPubCaseTypeID; //公开课案例类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.PubCaseTypeID) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.PubCaseTypeID, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.PubCaseTypeID] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetPubCaseTypeName(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubCaseTypeName, 50, convPubClassCase.PubCaseTypeName);
objvPubClassCaseEN.PubCaseTypeName = strPubCaseTypeName; //公开课案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.PubCaseTypeName) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.PubCaseTypeName, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.PubCaseTypeName] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN Setid_StudyLevel(this clsvPubClassCaseEN objvPubClassCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convPubClassCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convPubClassCase.id_StudyLevel);
objvPubClassCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.id_StudyLevel) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.id_StudyLevel, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.id_StudyLevel] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetStudyLevelName(this clsvPubClassCaseEN objvPubClassCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convPubClassCase.StudyLevelName);
objvPubClassCaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.StudyLevelName) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.StudyLevelName, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.StudyLevelName] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetCD_ID(this clsvPubClassCaseEN objvPubClassCaseEN, string strCD_ID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCD_ID, 50, convPubClassCase.CD_ID);
objvPubClassCaseEN.CD_ID = strCD_ID; //光盘编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.CD_ID) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.CD_ID, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.CD_ID] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetIntroduction(this clsvPubClassCaseEN objvPubClassCaseEN, string strIntroduction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIntroduction, 4000, convPubClassCase.Introduction);
objvPubClassCaseEN.Introduction = strIntroduction; //简要介绍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.Introduction) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.Introduction, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.Introduction] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetIsVisible(this clsvPubClassCaseEN objvPubClassCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvPubClassCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.IsVisible) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.IsVisible, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.IsVisible] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetIsDualVideo(this clsvPubClassCaseEN objvPubClassCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, convPubClassCase.IsDualVideo);
objvPubClassCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.IsDualVideo) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.IsDualVideo, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.IsDualVideo] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetRecommendedDegreeId(this clsvPubClassCaseEN objvPubClassCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convPubClassCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convPubClassCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convPubClassCase.RecommendedDegreeId);
objvPubClassCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.RecommendedDegreeId) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetRecommendedDegreeName(this clsvPubClassCaseEN objvPubClassCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convPubClassCase.RecommendedDegreeName);
objvPubClassCaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.RecommendedDegreeName) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.RecommendedDegreeName, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.RecommendedDegreeName] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetftpFileType(this clsvPubClassCaseEN objvPubClassCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convPubClassCase.ftpFileType);
objvPubClassCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.ftpFileType) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.ftpFileType, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.ftpFileType] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetVideoUrl(this clsvPubClassCaseEN objvPubClassCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convPubClassCase.VideoUrl);
objvPubClassCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.VideoUrl) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.VideoUrl, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.VideoUrl] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetVideoPath(this clsvPubClassCaseEN objvPubClassCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convPubClassCase.VideoPath);
objvPubClassCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.VideoPath) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.VideoPath, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.VideoPath] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetResErrMsg(this clsvPubClassCaseEN objvPubClassCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convPubClassCase.ResErrMsg);
objvPubClassCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.ResErrMsg) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.ResErrMsg, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.ResErrMsg] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetMemo(this clsvPubClassCaseEN objvPubClassCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPubClassCase.Memo);
objvPubClassCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.Memo) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.Memo, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.Memo] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseEN SetBrowseCount4Case(this clsvPubClassCaseEN objvPubClassCaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvPubClassCaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.BrowseCount4Case) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.BrowseCount4Case, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.BrowseCount4Case] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPubClassCaseEN objvPubClassCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.id_PubClassCase) == true)
{
string strComparisonOp_id_PubClassCase = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.id_PubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.id_PubClassCase, objvPubClassCase_Cond.id_PubClassCase, strComparisonOp_id_PubClassCase);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.PubClassCaseID) == true)
{
string strComparisonOp_PubClassCaseID = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.PubClassCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubClassCaseID, objvPubClassCase_Cond.PubClassCaseID, strComparisonOp_PubClassCaseID);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.PubClassCaseName) == true)
{
string strComparisonOp_PubClassCaseName = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubClassCaseName, objvPubClassCase_Cond.PubClassCaseName, strComparisonOp_PubClassCaseName);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.PubClassCaseExecutor) == true)
{
string strComparisonOp_PubClassCaseExecutor = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubClassCaseExecutor, objvPubClassCase_Cond.PubClassCaseExecutor, strComparisonOp_PubClassCaseExecutor);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.WorkUnit) == true)
{
string strComparisonOp_WorkUnit = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.WorkUnit, objvPubClassCase_Cond.WorkUnit, strComparisonOp_WorkUnit);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.PubClassCaseTheme) == true)
{
string strComparisonOp_PubClassCaseTheme = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.PubClassCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubClassCaseTheme, objvPubClassCase_Cond.PubClassCaseTheme, strComparisonOp_PubClassCaseTheme);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.PubClassCaseTeachDate) == true)
{
string strComparisonOp_PubClassCaseTeachDate = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.PubClassCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubClassCaseTeachDate, objvPubClassCase_Cond.PubClassCaseTeachDate, strComparisonOp_PubClassCaseTeachDate);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.PubClassCaseDateIn) == true)
{
string strComparisonOp_PubClassCaseDateIn = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.PubClassCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubClassCaseDateIn, objvPubClassCase_Cond.PubClassCaseDateIn, strComparisonOp_PubClassCaseDateIn);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.id_Discipline, objvPubClassCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.DisciplineID, objvPubClassCase_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.DisciplineName, objvPubClassCase_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.id_TeachingPlan, objvPubClassCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.SubjectName) == true)
{
string strComparisonOp_SubjectName = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.SubjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.SubjectName, objvPubClassCase_Cond.SubjectName, strComparisonOp_SubjectName);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.TeachingPlanAuthor) == true)
{
string strComparisonOp_TeachingPlanAuthor = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.TeachingPlanAuthor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.TeachingPlanAuthor, objvPubClassCase_Cond.TeachingPlanAuthor, strComparisonOp_TeachingPlanAuthor);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.TeachingObject) == true)
{
string strComparisonOp_TeachingObject = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.TeachingObject];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.TeachingObject, objvPubClassCase_Cond.TeachingObject, strComparisonOp_TeachingObject);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.TeachingEmphases) == true)
{
string strComparisonOp_TeachingEmphases = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.TeachingEmphases];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.TeachingEmphases, objvPubClassCase_Cond.TeachingEmphases, strComparisonOp_TeachingEmphases);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.TeachingDifficulty) == true)
{
string strComparisonOp_TeachingDifficulty = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.TeachingDifficulty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.TeachingDifficulty, objvPubClassCase_Cond.TeachingDifficulty, strComparisonOp_TeachingDifficulty);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.TeachingTool) == true)
{
string strComparisonOp_TeachingTool = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.TeachingTool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.TeachingTool, objvPubClassCase_Cond.TeachingTool, strComparisonOp_TeachingTool);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.TeachingProcess) == true)
{
string strComparisonOp_TeachingProcess = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.TeachingProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.TeachingProcess, objvPubClassCase_Cond.TeachingProcess, strComparisonOp_TeachingProcess);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.TeachingPlanType) == true)
{
string strComparisonOp_TeachingPlanType = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.TeachingPlanType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.TeachingPlanType, objvPubClassCase_Cond.TeachingPlanType, strComparisonOp_TeachingPlanType);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.PubClassCaseTimeIn) == true)
{
string strComparisonOp_PubClassCaseTimeIn = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.PubClassCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubClassCaseTimeIn, objvPubClassCase_Cond.PubClassCaseTimeIn, strComparisonOp_PubClassCaseTimeIn);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.id_PubClassCaseSenateGaugeVersion) == true)
{
string strComparisonOp_id_PubClassCaseSenateGaugeVersion = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.id_PubClassCaseSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.id_PubClassCaseSenateGaugeVersion, objvPubClassCase_Cond.id_PubClassCaseSenateGaugeVersion, strComparisonOp_id_PubClassCaseSenateGaugeVersion);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.senateGaugeVersionID, objvPubClassCase_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.senateGaugeVersionName, objvPubClassCase_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCase.senateGaugeVersionTtlScore, objvPubClassCase_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.id_PubCaseType) == true)
{
string strComparisonOp_id_PubCaseType = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.id_PubCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.id_PubCaseType, objvPubClassCase_Cond.id_PubCaseType, strComparisonOp_id_PubCaseType);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.PubCaseTypeID) == true)
{
string strComparisonOp_PubCaseTypeID = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.PubCaseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubCaseTypeID, objvPubClassCase_Cond.PubCaseTypeID, strComparisonOp_PubCaseTypeID);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.PubCaseTypeName) == true)
{
string strComparisonOp_PubCaseTypeName = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.PubCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubCaseTypeName, objvPubClassCase_Cond.PubCaseTypeName, strComparisonOp_PubCaseTypeName);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.id_StudyLevel, objvPubClassCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.StudyLevelName, objvPubClassCase_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.CD_ID) == true)
{
string strComparisonOp_CD_ID = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.CD_ID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.CD_ID, objvPubClassCase_Cond.CD_ID, strComparisonOp_CD_ID);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.Introduction) == true)
{
string strComparisonOp_Introduction = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.Introduction];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.Introduction, objvPubClassCase_Cond.Introduction, strComparisonOp_Introduction);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.IsVisible) == true)
{
if (objvPubClassCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCase.IsVisible);
}
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.IsDualVideo) == true)
{
if (objvPubClassCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCase.IsDualVideo);
}
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.RecommendedDegreeId, objvPubClassCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.RecommendedDegreeName, objvPubClassCase_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.ftpFileType, objvPubClassCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.VideoUrl, objvPubClassCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.VideoPath, objvPubClassCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.ResErrMsg, objvPubClassCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.Memo) == true)
{
string strComparisonOp_Memo = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.Memo, objvPubClassCase_Cond.Memo, strComparisonOp_Memo);
}
if (objvPubClassCase_Cond.IsUpdated(convPubClassCase.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvPubClassCase_Cond.dicFldComparisonOp[convPubClassCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCase.BrowseCount4Case, objvPubClassCase_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v公开课案例(vPubClassCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPubClassCaseWApi
{
private static readonly string mstrApiControllerName = "vPubClassCaseApi";

 public clsvPubClassCaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_PubClassCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseEN GetObjByid_PubClassCase(string strid_PubClassCase)
{
string strAction = "GetObjByid_PubClassCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCaseEN objvPubClassCaseEN = null;
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
objvPubClassCaseEN = JsonConvert.DeserializeObject<clsvPubClassCaseEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCaseEN;
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
public static clsvPubClassCaseEN GetObjByid_PubClassCase_WA_Cache(string strid_PubClassCase)
{
string strAction = "GetObjByid_PubClassCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCaseEN objvPubClassCaseEN = null;
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
objvPubClassCaseEN = JsonConvert.DeserializeObject<clsvPubClassCaseEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCaseEN;
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
public static clsvPubClassCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCaseEN objvPubClassCaseEN = null;
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
objvPubClassCaseEN = JsonConvert.DeserializeObject<clsvPubClassCaseEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCaseEN;
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
public static clsvPubClassCaseEN GetObjByid_PubClassCase_Cache(string strid_PubClassCase)
{
if (string.IsNullOrEmpty(strid_PubClassCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubClassCaseEN._CurrTabName_S);
List<clsvPubClassCaseEN> arrvPubClassCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubClassCaseEN> arrvPubClassCaseObjLst_Sel =
from objvPubClassCaseEN in arrvPubClassCaseObjLst_Cache
where objvPubClassCaseEN.id_PubClassCase == strid_PubClassCase
select objvPubClassCaseEN;
if (arrvPubClassCaseObjLst_Sel.Count() == 0)
{
   clsvPubClassCaseEN obj = clsvPubClassCaseWApi.GetObjByid_PubClassCase(strid_PubClassCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPubClassCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseEN> GetObjLst(string strWhereCond)
{
 List<clsvPubClassCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseEN> GetObjLstById_PubClassCaseLst(List<string> arrId_PubClassCase)
{
 List<clsvPubClassCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvPubClassCaseEN> GetObjLstById_PubClassCaseLst_Cache(List<string> arrId_PubClassCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubClassCaseEN._CurrTabName_S);
List<clsvPubClassCaseEN> arrvPubClassCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubClassCaseEN> arrvPubClassCaseObjLst_Sel =
from objvPubClassCaseEN in arrvPubClassCaseObjLst_Cache
where arrId_PubClassCase.Contains(objvPubClassCaseEN.id_PubClassCase)
select objvPubClassCaseEN;
return arrvPubClassCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseEN> GetObjLstById_PubClassCaseLst_WA_Cache(List<string> arrId_PubClassCase)
{
 List<clsvPubClassCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPubClassCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPubClassCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPubClassCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPubClassCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvPubClassCaseENS">源对象</param>
 /// <param name = "objvPubClassCaseENT">目标对象</param>
 public static void CopyTo(clsvPubClassCaseEN objvPubClassCaseENS, clsvPubClassCaseEN objvPubClassCaseENT)
{
try
{
objvPubClassCaseENT.id_PubClassCase = objvPubClassCaseENS.id_PubClassCase; //案例流水号
objvPubClassCaseENT.PubClassCaseID = objvPubClassCaseENS.PubClassCaseID; //案例ID
objvPubClassCaseENT.PubClassCaseName = objvPubClassCaseENS.PubClassCaseName; //案例课题名称
objvPubClassCaseENT.PubClassCaseExecutor = objvPubClassCaseENS.PubClassCaseExecutor; //案例执教者
objvPubClassCaseENT.WorkUnit = objvPubClassCaseENS.WorkUnit; //工作单位
objvPubClassCaseENT.PubClassCaseTheme = objvPubClassCaseENS.PubClassCaseTheme; //案例主题词
objvPubClassCaseENT.PubClassCaseBG = objvPubClassCaseENS.PubClassCaseBG; //案例背景资料
objvPubClassCaseENT.PubClassCaseTeachDate = objvPubClassCaseENS.PubClassCaseTeachDate; //案例授课日期
objvPubClassCaseENT.PubClassCaseDateIn = objvPubClassCaseENS.PubClassCaseDateIn; //案例入库日期
objvPubClassCaseENT.id_Discipline = objvPubClassCaseENS.id_Discipline; //学科流水号
objvPubClassCaseENT.DisciplineID = objvPubClassCaseENS.DisciplineID; //学科ID
objvPubClassCaseENT.DisciplineName = objvPubClassCaseENS.DisciplineName; //学科名称
objvPubClassCaseENT.id_TeachingPlan = objvPubClassCaseENS.id_TeachingPlan; //教案流水号
objvPubClassCaseENT.SubjectName = objvPubClassCaseENS.SubjectName; //课题名称
objvPubClassCaseENT.TeachingPlanAuthor = objvPubClassCaseENS.TeachingPlanAuthor; //教案撰写人
objvPubClassCaseENT.TeachingObject = objvPubClassCaseENS.TeachingObject; //教学目标
objvPubClassCaseENT.TeachingEmphases = objvPubClassCaseENS.TeachingEmphases; //教学重点
objvPubClassCaseENT.TeachingDifficulty = objvPubClassCaseENS.TeachingDifficulty; //教学难点
objvPubClassCaseENT.TeachingTool = objvPubClassCaseENS.TeachingTool; //教学用具
objvPubClassCaseENT.TeachingProcess = objvPubClassCaseENS.TeachingProcess; //教学过程
objvPubClassCaseENT.TeachingPlanType = objvPubClassCaseENS.TeachingPlanType; //教案类型
objvPubClassCaseENT.SimplePlanContent = objvPubClassCaseENS.SimplePlanContent; //简案内容
objvPubClassCaseENT.PubClassCaseTimeIn = objvPubClassCaseENS.PubClassCaseTimeIn; //案例入库时间
objvPubClassCaseENT.id_PubClassCaseSenateGaugeVersion = objvPubClassCaseENS.id_PubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objvPubClassCaseENT.senateGaugeVersionID = objvPubClassCaseENS.senateGaugeVersionID; //评价量表版本ID
objvPubClassCaseENT.senateGaugeVersionName = objvPubClassCaseENS.senateGaugeVersionName; //评价量表版本名称
objvPubClassCaseENT.senateGaugeVersionTtlScore = objvPubClassCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvPubClassCaseENT.id_PubCaseType = objvPubClassCaseENS.id_PubCaseType; //公开课案例类型流水号
objvPubClassCaseENT.PubCaseTypeID = objvPubClassCaseENS.PubCaseTypeID; //公开课案例类型ID
objvPubClassCaseENT.PubCaseTypeName = objvPubClassCaseENS.PubCaseTypeName; //公开课案例类型名称
objvPubClassCaseENT.id_StudyLevel = objvPubClassCaseENS.id_StudyLevel; //id_StudyLevel
objvPubClassCaseENT.StudyLevelName = objvPubClassCaseENS.StudyLevelName; //学段名称
objvPubClassCaseENT.CD_ID = objvPubClassCaseENS.CD_ID; //光盘编号
objvPubClassCaseENT.Introduction = objvPubClassCaseENS.Introduction; //简要介绍
objvPubClassCaseENT.IsVisible = objvPubClassCaseENS.IsVisible; //是否显示
objvPubClassCaseENT.IsDualVideo = objvPubClassCaseENS.IsDualVideo; //是否双视频
objvPubClassCaseENT.RecommendedDegreeId = objvPubClassCaseENS.RecommendedDegreeId; //推荐度Id
objvPubClassCaseENT.RecommendedDegreeName = objvPubClassCaseENS.RecommendedDegreeName; //推荐度名称
objvPubClassCaseENT.ftpFileType = objvPubClassCaseENS.ftpFileType; //ftp文件类型
objvPubClassCaseENT.VideoUrl = objvPubClassCaseENS.VideoUrl; //视频Url
objvPubClassCaseENT.VideoPath = objvPubClassCaseENS.VideoPath; //视频目录
objvPubClassCaseENT.ResErrMsg = objvPubClassCaseENS.ResErrMsg; //资源错误信息
objvPubClassCaseENT.Memo = objvPubClassCaseENS.Memo; //备注
objvPubClassCaseENT.BrowseCount4Case = objvPubClassCaseENS.BrowseCount4Case; //课例浏览次数
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
public static DataTable ToDataTable(List<clsvPubClassCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPubClassCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPubClassCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPubClassCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPubClassCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPubClassCaseEN.AttributeName)
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
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseWApi没有刷新缓存机制(clsPubClassCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingPlanWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingPlanWApi没有刷新缓存机制(clsTeachingPlanWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateGaugeVersionWApi没有刷新缓存机制(clsPubClassCaseSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubCaseTypeWApi没有刷新缓存机制(clsPubCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_PubClassCase");
//if (arrvPubClassCaseObjLst_Cache == null)
//{
//arrvPubClassCaseObjLst_Cache = await clsvPubClassCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvPubClassCaseEN._CurrTabName_S);
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
public static List<clsvPubClassCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPubClassCaseEN._CurrTabName_S);
List<clsvPubClassCaseEN> arrvPubClassCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPubClassCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPubClassCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPubClassCase.id_PubClassCase, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.PubClassCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.PubClassCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.PubClassCaseExecutor, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.WorkUnit, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.PubClassCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.PubClassCaseBG, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.PubClassCaseTeachDate, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.PubClassCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.SubjectName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.TeachingPlanAuthor, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.TeachingObject, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.TeachingEmphases, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.TeachingDifficulty, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.TeachingTool, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.TeachingProcess, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.TeachingPlanType, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.SimplePlanContent, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.PubClassCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.id_PubClassCaseSenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convPubClassCase.id_PubCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.PubCaseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.PubCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.CD_ID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.Introduction, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubClassCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubClassCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase.BrowseCount4Case, Type.GetType("System.Int32"));
foreach (clsvPubClassCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPubClassCase.id_PubClassCase] = objInFor[convPubClassCase.id_PubClassCase];
objDR[convPubClassCase.PubClassCaseID] = objInFor[convPubClassCase.PubClassCaseID];
objDR[convPubClassCase.PubClassCaseName] = objInFor[convPubClassCase.PubClassCaseName];
objDR[convPubClassCase.PubClassCaseExecutor] = objInFor[convPubClassCase.PubClassCaseExecutor];
objDR[convPubClassCase.WorkUnit] = objInFor[convPubClassCase.WorkUnit];
objDR[convPubClassCase.PubClassCaseTheme] = objInFor[convPubClassCase.PubClassCaseTheme];
objDR[convPubClassCase.PubClassCaseBG] = objInFor[convPubClassCase.PubClassCaseBG];
objDR[convPubClassCase.PubClassCaseTeachDate] = objInFor[convPubClassCase.PubClassCaseTeachDate];
objDR[convPubClassCase.PubClassCaseDateIn] = objInFor[convPubClassCase.PubClassCaseDateIn];
objDR[convPubClassCase.id_Discipline] = objInFor[convPubClassCase.id_Discipline];
objDR[convPubClassCase.DisciplineID] = objInFor[convPubClassCase.DisciplineID];
objDR[convPubClassCase.DisciplineName] = objInFor[convPubClassCase.DisciplineName];
objDR[convPubClassCase.id_TeachingPlan] = objInFor[convPubClassCase.id_TeachingPlan];
objDR[convPubClassCase.SubjectName] = objInFor[convPubClassCase.SubjectName];
objDR[convPubClassCase.TeachingPlanAuthor] = objInFor[convPubClassCase.TeachingPlanAuthor];
objDR[convPubClassCase.TeachingObject] = objInFor[convPubClassCase.TeachingObject];
objDR[convPubClassCase.TeachingEmphases] = objInFor[convPubClassCase.TeachingEmphases];
objDR[convPubClassCase.TeachingDifficulty] = objInFor[convPubClassCase.TeachingDifficulty];
objDR[convPubClassCase.TeachingTool] = objInFor[convPubClassCase.TeachingTool];
objDR[convPubClassCase.TeachingProcess] = objInFor[convPubClassCase.TeachingProcess];
objDR[convPubClassCase.TeachingPlanType] = objInFor[convPubClassCase.TeachingPlanType];
objDR[convPubClassCase.SimplePlanContent] = objInFor[convPubClassCase.SimplePlanContent];
objDR[convPubClassCase.PubClassCaseTimeIn] = objInFor[convPubClassCase.PubClassCaseTimeIn];
objDR[convPubClassCase.id_PubClassCaseSenateGaugeVersion] = objInFor[convPubClassCase.id_PubClassCaseSenateGaugeVersion];
objDR[convPubClassCase.senateGaugeVersionID] = objInFor[convPubClassCase.senateGaugeVersionID];
objDR[convPubClassCase.senateGaugeVersionName] = objInFor[convPubClassCase.senateGaugeVersionName];
objDR[convPubClassCase.senateGaugeVersionTtlScore] = objInFor[convPubClassCase.senateGaugeVersionTtlScore];
objDR[convPubClassCase.id_PubCaseType] = objInFor[convPubClassCase.id_PubCaseType];
objDR[convPubClassCase.PubCaseTypeID] = objInFor[convPubClassCase.PubCaseTypeID];
objDR[convPubClassCase.PubCaseTypeName] = objInFor[convPubClassCase.PubCaseTypeName];
objDR[convPubClassCase.id_StudyLevel] = objInFor[convPubClassCase.id_StudyLevel];
objDR[convPubClassCase.StudyLevelName] = objInFor[convPubClassCase.StudyLevelName];
objDR[convPubClassCase.CD_ID] = objInFor[convPubClassCase.CD_ID];
objDR[convPubClassCase.Introduction] = objInFor[convPubClassCase.Introduction];
objDR[convPubClassCase.IsVisible] = objInFor[convPubClassCase.IsVisible];
objDR[convPubClassCase.IsDualVideo] = objInFor[convPubClassCase.IsDualVideo];
objDR[convPubClassCase.RecommendedDegreeId] = objInFor[convPubClassCase.RecommendedDegreeId];
objDR[convPubClassCase.RecommendedDegreeName] = objInFor[convPubClassCase.RecommendedDegreeName];
objDR[convPubClassCase.ftpFileType] = objInFor[convPubClassCase.ftpFileType];
objDR[convPubClassCase.VideoUrl] = objInFor[convPubClassCase.VideoUrl];
objDR[convPubClassCase.VideoPath] = objInFor[convPubClassCase.VideoPath];
objDR[convPubClassCase.ResErrMsg] = objInFor[convPubClassCase.ResErrMsg];
objDR[convPubClassCase.Memo] = objInFor[convPubClassCase.Memo];
objDR[convPubClassCase.BrowseCount4Case] = objInFor[convPubClassCase.BrowseCount4Case];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}