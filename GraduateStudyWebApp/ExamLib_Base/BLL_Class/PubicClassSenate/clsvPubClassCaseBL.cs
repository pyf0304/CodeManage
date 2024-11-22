
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseBL
 表名:vPubClassCase(01120386)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clsvPubClassCaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdPubClassCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseEN GetObj(this K_IdPubClassCase_vPubClassCase myKey)
{
clsvPubClassCaseEN objvPubClassCaseEN = clsvPubClassCaseBL.vPubClassCaseDA.GetObjByIdPubClassCase(myKey.Value);
return objvPubClassCaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetIdPubClassCase(this clsvPubClassCaseEN objvPubClassCaseEN, string strIdPubClassCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCase, 8, convPubClassCase.IdPubClassCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCase, 8, convPubClassCase.IdPubClassCase);
}
objvPubClassCaseEN.IdPubClassCase = strIdPubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.IdPubClassCase) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.IdPubClassCase, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.IdPubClassCase] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetPubClassCaseID(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubClassCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseID, convPubClassCase.PubClassCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseID, 8, convPubClassCase.PubClassCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseID, 8, convPubClassCase.PubClassCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetPubClassCaseName(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubClassCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseName, convPubClassCase.PubClassCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, convPubClassCase.PubClassCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetPubClassCaseExecutor(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, convPubClassCase.PubClassCaseExecutor);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetWorkUnit(this clsvPubClassCaseEN objvPubClassCaseEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, convPubClassCase.WorkUnit);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetPubClassCaseTheme(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubClassCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTheme, 500, convPubClassCase.PubClassCaseTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetPubClassCaseTeachDate(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubClassCaseTeachDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTeachDate, 8, convPubClassCase.PubClassCaseTeachDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTeachDate, 8, convPubClassCase.PubClassCaseTeachDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetPubClassCaseDateIn(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubClassCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseDateIn, 8, convPubClassCase.PubClassCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseDateIn, 8, convPubClassCase.PubClassCaseDateIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetIdDiscipline(this clsvPubClassCaseEN objvPubClassCaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convPubClassCase.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convPubClassCase.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convPubClassCase.IdDiscipline);
}
objvPubClassCaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.IdDiscipline) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.IdDiscipline, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.IdDiscipline] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetDisciplineID(this clsvPubClassCaseEN objvPubClassCaseEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convPubClassCase.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convPubClassCase.DisciplineID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetDisciplineName(this clsvPubClassCaseEN objvPubClassCaseEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convPubClassCase.DisciplineName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetIdTeachingPlan(this clsvPubClassCaseEN objvPubClassCaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convPubClassCase.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convPubClassCase.IdTeachingPlan);
}
objvPubClassCaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.IdTeachingPlan) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.IdTeachingPlan, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.IdTeachingPlan] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetSubjectName(this clsvPubClassCaseEN objvPubClassCaseEN, string strSubjectName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubjectName, 200, convPubClassCase.SubjectName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetTeachingPlanAuthor(this clsvPubClassCaseEN objvPubClassCaseEN, string strTeachingPlanAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanAuthor, 50, convPubClassCase.TeachingPlanAuthor);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetTeachingObject(this clsvPubClassCaseEN objvPubClassCaseEN, string strTeachingObject, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingObject, 5000, convPubClassCase.TeachingObject);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetTeachingEmphases(this clsvPubClassCaseEN objvPubClassCaseEN, string strTeachingEmphases, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingEmphases, 5000, convPubClassCase.TeachingEmphases);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetTeachingDifficulty(this clsvPubClassCaseEN objvPubClassCaseEN, string strTeachingDifficulty, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingDifficulty, 5000, convPubClassCase.TeachingDifficulty);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetTeachingTool(this clsvPubClassCaseEN objvPubClassCaseEN, string strTeachingTool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingTool, 5000, convPubClassCase.TeachingTool);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetTeachingProcess(this clsvPubClassCaseEN objvPubClassCaseEN, string strTeachingProcess, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingProcess, 8000, convPubClassCase.TeachingProcess);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetTeachingPlanType(this clsvPubClassCaseEN objvPubClassCaseEN, string strTeachingPlanType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanType, 1, convPubClassCase.TeachingPlanType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingPlanType, 1, convPubClassCase.TeachingPlanType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetPubClassCaseTimeIn(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubClassCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTimeIn, 6, convPubClassCase.PubClassCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTimeIn, 6, convPubClassCase.PubClassCaseTimeIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetIdPubClassCaseSenateGaugeVersion(this clsvPubClassCaseEN objvPubClassCaseEN, string strIdPubClassCaseSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubClassCaseSenateGaugeVersion, convPubClassCase.IdPubClassCaseSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCaseSenateGaugeVersion, 4, convPubClassCase.IdPubClassCaseSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCaseSenateGaugeVersion, 4, convPubClassCase.IdPubClassCaseSenateGaugeVersion);
}
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = strIdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.IdPubClassCaseSenateGaugeVersion) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.IdPubClassCaseSenateGaugeVersion, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.IdPubClassCaseSenateGaugeVersion] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetsenateGaugeVersionID(this clsvPubClassCaseEN objvPubClassCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convPubClassCase.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convPubClassCase.senateGaugeVersionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetsenateGaugeVersionName(this clsvPubClassCaseEN objvPubClassCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convPubClassCase.senateGaugeVersionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetsenateGaugeVersionTtlScore(this clsvPubClassCaseEN objvPubClassCaseEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetIdPubCaseType(this clsvPubClassCaseEN objvPubClassCaseEN, string strIdPubCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubCaseType, 4, convPubClassCase.IdPubCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubCaseType, 4, convPubClassCase.IdPubCaseType);
}
objvPubClassCaseEN.IdPubCaseType = strIdPubCaseType; //公开课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.IdPubCaseType) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.IdPubCaseType, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.IdPubCaseType] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetPubCaseTypeID(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubCaseTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubCaseTypeID, 4, convPubClassCase.PubCaseTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubCaseTypeID, 4, convPubClassCase.PubCaseTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetPubCaseTypeName(this clsvPubClassCaseEN objvPubClassCaseEN, string strPubCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubCaseTypeName, 50, convPubClassCase.PubCaseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetIdStudyLevel(this clsvPubClassCaseEN objvPubClassCaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convPubClassCase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convPubClassCase.IdStudyLevel);
}
objvPubClassCaseEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.IdStudyLevel) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.IdStudyLevel, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.IdStudyLevel] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetStudyLevelName(this clsvPubClassCaseEN objvPubClassCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convPubClassCase.StudyLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetCDID(this clsvPubClassCaseEN objvPubClassCaseEN, string strCDID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCDID, 50, convPubClassCase.CDID);
}
objvPubClassCaseEN.CDID = strCDID; //光盘编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseEN.dicFldComparisonOp.ContainsKey(convPubClassCase.CDID) == false)
{
objvPubClassCaseEN.dicFldComparisonOp.Add(convPubClassCase.CDID, strComparisonOp);
}
else
{
objvPubClassCaseEN.dicFldComparisonOp[convPubClassCase.CDID] = strComparisonOp;
}
}
return objvPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetIntroduction(this clsvPubClassCaseEN objvPubClassCaseEN, string strIntroduction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIntroduction, 4000, convPubClassCase.Introduction);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetRecommendedDegreeId(this clsvPubClassCaseEN objvPubClassCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convPubClassCase.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convPubClassCase.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convPubClassCase.RecommendedDegreeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetRecommendedDegreeName(this clsvPubClassCaseEN objvPubClassCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convPubClassCase.RecommendedDegreeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetftpFileType(this clsvPubClassCaseEN objvPubClassCaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convPubClassCase.ftpFileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetVideoUrl(this clsvPubClassCaseEN objvPubClassCaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convPubClassCase.VideoUrl);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetVideoPath(this clsvPubClassCaseEN objvPubClassCaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convPubClassCase.VideoPath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetResErrMsg(this clsvPubClassCaseEN objvPubClassCaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convPubClassCase.ResErrMsg);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetMemo(this clsvPubClassCaseEN objvPubClassCaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPubClassCase.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseEN SetBrowseCount4Case(this clsvPubClassCaseEN objvPubClassCaseEN, int? intBrowseCount4Case, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPubClassCaseENS">源对象</param>
 /// <param name = "objvPubClassCaseENT">目标对象</param>
 public static void CopyTo(this clsvPubClassCaseEN objvPubClassCaseENS, clsvPubClassCaseEN objvPubClassCaseENT)
{
try
{
objvPubClassCaseENT.IdPubClassCase = objvPubClassCaseENS.IdPubClassCase; //案例流水号
objvPubClassCaseENT.PubClassCaseID = objvPubClassCaseENS.PubClassCaseID; //案例ID
objvPubClassCaseENT.PubClassCaseName = objvPubClassCaseENS.PubClassCaseName; //案例课题名称
objvPubClassCaseENT.PubClassCaseExecutor = objvPubClassCaseENS.PubClassCaseExecutor; //案例执教者
objvPubClassCaseENT.WorkUnit = objvPubClassCaseENS.WorkUnit; //工作单位
objvPubClassCaseENT.PubClassCaseTheme = objvPubClassCaseENS.PubClassCaseTheme; //案例主题词
objvPubClassCaseENT.PubClassCaseBG = objvPubClassCaseENS.PubClassCaseBG; //案例背景资料
objvPubClassCaseENT.PubClassCaseTeachDate = objvPubClassCaseENS.PubClassCaseTeachDate; //案例授课日期
objvPubClassCaseENT.PubClassCaseDateIn = objvPubClassCaseENS.PubClassCaseDateIn; //案例入库日期
objvPubClassCaseENT.IdDiscipline = objvPubClassCaseENS.IdDiscipline; //学科流水号
objvPubClassCaseENT.DisciplineID = objvPubClassCaseENS.DisciplineID; //学科ID
objvPubClassCaseENT.DisciplineName = objvPubClassCaseENS.DisciplineName; //学科名称
objvPubClassCaseENT.IdTeachingPlan = objvPubClassCaseENS.IdTeachingPlan; //教案流水号
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
objvPubClassCaseENT.IdPubClassCaseSenateGaugeVersion = objvPubClassCaseENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objvPubClassCaseENT.senateGaugeVersionID = objvPubClassCaseENS.senateGaugeVersionID; //评价量表版本ID
objvPubClassCaseENT.senateGaugeVersionName = objvPubClassCaseENS.senateGaugeVersionName; //评价量表版本名称
objvPubClassCaseENT.senateGaugeVersionTtlScore = objvPubClassCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvPubClassCaseENT.IdPubCaseType = objvPubClassCaseENS.IdPubCaseType; //公开课案例类型流水号
objvPubClassCaseENT.PubCaseTypeID = objvPubClassCaseENS.PubCaseTypeID; //公开课案例类型ID
objvPubClassCaseENT.PubCaseTypeName = objvPubClassCaseENS.PubCaseTypeName; //公开课案例类型名称
objvPubClassCaseENT.IdStudyLevel = objvPubClassCaseENS.IdStudyLevel; //id_StudyLevel
objvPubClassCaseENT.StudyLevelName = objvPubClassCaseENS.StudyLevelName; //学段名称
objvPubClassCaseENT.CDID = objvPubClassCaseENS.CDID; //光盘编号
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
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvPubClassCaseENS">源对象</param>
 /// <returns>目标对象=>clsvPubClassCaseEN:objvPubClassCaseENT</returns>
 public static clsvPubClassCaseEN CopyTo(this clsvPubClassCaseEN objvPubClassCaseENS)
{
try
{
 clsvPubClassCaseEN objvPubClassCaseENT = new clsvPubClassCaseEN()
{
IdPubClassCase = objvPubClassCaseENS.IdPubClassCase, //案例流水号
PubClassCaseID = objvPubClassCaseENS.PubClassCaseID, //案例ID
PubClassCaseName = objvPubClassCaseENS.PubClassCaseName, //案例课题名称
PubClassCaseExecutor = objvPubClassCaseENS.PubClassCaseExecutor, //案例执教者
WorkUnit = objvPubClassCaseENS.WorkUnit, //工作单位
PubClassCaseTheme = objvPubClassCaseENS.PubClassCaseTheme, //案例主题词
PubClassCaseBG = objvPubClassCaseENS.PubClassCaseBG, //案例背景资料
PubClassCaseTeachDate = objvPubClassCaseENS.PubClassCaseTeachDate, //案例授课日期
PubClassCaseDateIn = objvPubClassCaseENS.PubClassCaseDateIn, //案例入库日期
IdDiscipline = objvPubClassCaseENS.IdDiscipline, //学科流水号
DisciplineID = objvPubClassCaseENS.DisciplineID, //学科ID
DisciplineName = objvPubClassCaseENS.DisciplineName, //学科名称
IdTeachingPlan = objvPubClassCaseENS.IdTeachingPlan, //教案流水号
SubjectName = objvPubClassCaseENS.SubjectName, //课题名称
TeachingPlanAuthor = objvPubClassCaseENS.TeachingPlanAuthor, //教案撰写人
TeachingObject = objvPubClassCaseENS.TeachingObject, //教学目标
TeachingEmphases = objvPubClassCaseENS.TeachingEmphases, //教学重点
TeachingDifficulty = objvPubClassCaseENS.TeachingDifficulty, //教学难点
TeachingTool = objvPubClassCaseENS.TeachingTool, //教学用具
TeachingProcess = objvPubClassCaseENS.TeachingProcess, //教学过程
TeachingPlanType = objvPubClassCaseENS.TeachingPlanType, //教案类型
SimplePlanContent = objvPubClassCaseENS.SimplePlanContent, //简案内容
PubClassCaseTimeIn = objvPubClassCaseENS.PubClassCaseTimeIn, //案例入库时间
IdPubClassCaseSenateGaugeVersion = objvPubClassCaseENS.IdPubClassCaseSenateGaugeVersion, //公开课量表版本流水号
senateGaugeVersionID = objvPubClassCaseENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvPubClassCaseENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvPubClassCaseENS.senateGaugeVersionTtlScore, //评价量表版本总分
IdPubCaseType = objvPubClassCaseENS.IdPubCaseType, //公开课案例类型流水号
PubCaseTypeID = objvPubClassCaseENS.PubCaseTypeID, //公开课案例类型ID
PubCaseTypeName = objvPubClassCaseENS.PubCaseTypeName, //公开课案例类型名称
IdStudyLevel = objvPubClassCaseENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvPubClassCaseENS.StudyLevelName, //学段名称
CDID = objvPubClassCaseENS.CDID, //光盘编号
Introduction = objvPubClassCaseENS.Introduction, //简要介绍
IsVisible = objvPubClassCaseENS.IsVisible, //是否显示
IsDualVideo = objvPubClassCaseENS.IsDualVideo, //是否双视频
RecommendedDegreeId = objvPubClassCaseENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvPubClassCaseENS.RecommendedDegreeName, //推荐度名称
ftpFileType = objvPubClassCaseENS.ftpFileType, //ftp文件类型
VideoUrl = objvPubClassCaseENS.VideoUrl, //视频Url
VideoPath = objvPubClassCaseENS.VideoPath, //视频目录
ResErrMsg = objvPubClassCaseENS.ResErrMsg, //资源错误信息
Memo = objvPubClassCaseENS.Memo, //备注
BrowseCount4Case = objvPubClassCaseENS.BrowseCount4Case, //课例浏览次数
};
 return objvPubClassCaseENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvPubClassCaseEN objvPubClassCaseEN)
{
 clsvPubClassCaseBL.vPubClassCaseDA.CheckProperty4Condition(objvPubClassCaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPubClassCaseEN objvPubClassCaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.IdPubClassCase) == true)
{
string strComparisonOpIdPubClassCase = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.IdPubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.IdPubClassCase, objvPubClassCaseCond.IdPubClassCase, strComparisonOpIdPubClassCase);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.PubClassCaseID) == true)
{
string strComparisonOpPubClassCaseID = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.PubClassCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubClassCaseID, objvPubClassCaseCond.PubClassCaseID, strComparisonOpPubClassCaseID);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.PubClassCaseName) == true)
{
string strComparisonOpPubClassCaseName = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubClassCaseName, objvPubClassCaseCond.PubClassCaseName, strComparisonOpPubClassCaseName);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.PubClassCaseExecutor) == true)
{
string strComparisonOpPubClassCaseExecutor = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubClassCaseExecutor, objvPubClassCaseCond.PubClassCaseExecutor, strComparisonOpPubClassCaseExecutor);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.WorkUnit, objvPubClassCaseCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.PubClassCaseTheme) == true)
{
string strComparisonOpPubClassCaseTheme = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.PubClassCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubClassCaseTheme, objvPubClassCaseCond.PubClassCaseTheme, strComparisonOpPubClassCaseTheme);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.PubClassCaseTeachDate) == true)
{
string strComparisonOpPubClassCaseTeachDate = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.PubClassCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubClassCaseTeachDate, objvPubClassCaseCond.PubClassCaseTeachDate, strComparisonOpPubClassCaseTeachDate);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.PubClassCaseDateIn) == true)
{
string strComparisonOpPubClassCaseDateIn = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.PubClassCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubClassCaseDateIn, objvPubClassCaseCond.PubClassCaseDateIn, strComparisonOpPubClassCaseDateIn);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.IdDiscipline, objvPubClassCaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.DisciplineID, objvPubClassCaseCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.DisciplineName, objvPubClassCaseCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.IdTeachingPlan, objvPubClassCaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.SubjectName) == true)
{
string strComparisonOpSubjectName = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.SubjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.SubjectName, objvPubClassCaseCond.SubjectName, strComparisonOpSubjectName);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.TeachingPlanAuthor) == true)
{
string strComparisonOpTeachingPlanAuthor = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.TeachingPlanAuthor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.TeachingPlanAuthor, objvPubClassCaseCond.TeachingPlanAuthor, strComparisonOpTeachingPlanAuthor);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.TeachingObject) == true)
{
string strComparisonOpTeachingObject = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.TeachingObject];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.TeachingObject, objvPubClassCaseCond.TeachingObject, strComparisonOpTeachingObject);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.TeachingEmphases) == true)
{
string strComparisonOpTeachingEmphases = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.TeachingEmphases];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.TeachingEmphases, objvPubClassCaseCond.TeachingEmphases, strComparisonOpTeachingEmphases);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.TeachingDifficulty) == true)
{
string strComparisonOpTeachingDifficulty = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.TeachingDifficulty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.TeachingDifficulty, objvPubClassCaseCond.TeachingDifficulty, strComparisonOpTeachingDifficulty);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.TeachingTool) == true)
{
string strComparisonOpTeachingTool = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.TeachingTool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.TeachingTool, objvPubClassCaseCond.TeachingTool, strComparisonOpTeachingTool);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.TeachingProcess) == true)
{
string strComparisonOpTeachingProcess = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.TeachingProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.TeachingProcess, objvPubClassCaseCond.TeachingProcess, strComparisonOpTeachingProcess);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.TeachingPlanType) == true)
{
string strComparisonOpTeachingPlanType = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.TeachingPlanType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.TeachingPlanType, objvPubClassCaseCond.TeachingPlanType, strComparisonOpTeachingPlanType);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.PubClassCaseTimeIn) == true)
{
string strComparisonOpPubClassCaseTimeIn = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.PubClassCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubClassCaseTimeIn, objvPubClassCaseCond.PubClassCaseTimeIn, strComparisonOpPubClassCaseTimeIn);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.IdPubClassCaseSenateGaugeVersion) == true)
{
string strComparisonOpIdPubClassCaseSenateGaugeVersion = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.IdPubClassCaseSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.IdPubClassCaseSenateGaugeVersion, objvPubClassCaseCond.IdPubClassCaseSenateGaugeVersion, strComparisonOpIdPubClassCaseSenateGaugeVersion);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.senateGaugeVersionID, objvPubClassCaseCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.senateGaugeVersionName, objvPubClassCaseCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCase.senateGaugeVersionTtlScore, objvPubClassCaseCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.IdPubCaseType) == true)
{
string strComparisonOpIdPubCaseType = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.IdPubCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.IdPubCaseType, objvPubClassCaseCond.IdPubCaseType, strComparisonOpIdPubCaseType);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.PubCaseTypeID) == true)
{
string strComparisonOpPubCaseTypeID = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.PubCaseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubCaseTypeID, objvPubClassCaseCond.PubCaseTypeID, strComparisonOpPubCaseTypeID);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.PubCaseTypeName) == true)
{
string strComparisonOpPubCaseTypeName = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.PubCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.PubCaseTypeName, objvPubClassCaseCond.PubCaseTypeName, strComparisonOpPubCaseTypeName);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.IdStudyLevel, objvPubClassCaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.StudyLevelName, objvPubClassCaseCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.CDID) == true)
{
string strComparisonOpCDID = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.CDID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.CDID, objvPubClassCaseCond.CDID, strComparisonOpCDID);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.Introduction) == true)
{
string strComparisonOpIntroduction = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.Introduction];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.Introduction, objvPubClassCaseCond.Introduction, strComparisonOpIntroduction);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.IsVisible) == true)
{
if (objvPubClassCaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCase.IsVisible);
}
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.IsDualVideo) == true)
{
if (objvPubClassCaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCase.IsDualVideo);
}
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.RecommendedDegreeId, objvPubClassCaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.RecommendedDegreeName, objvPubClassCaseCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.ftpFileType, objvPubClassCaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.VideoUrl, objvPubClassCaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.VideoPath) == true)
{
string strComparisonOpVideoPath = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.VideoPath, objvPubClassCaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.ResErrMsg, objvPubClassCaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.Memo) == true)
{
string strComparisonOpMemo = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase.Memo, objvPubClassCaseCond.Memo, strComparisonOpMemo);
}
if (objvPubClassCaseCond.IsUpdated(convPubClassCase.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvPubClassCaseCond.dicFldComparisonOp[convPubClassCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCase.BrowseCount4Case, objvPubClassCaseCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPubClassCase
{
public virtual bool UpdRelaTabDate(string strIdPubClassCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v公开课案例(vPubClassCase)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPubClassCaseBL
{
public static RelatedActions_vPubClassCase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPubClassCaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPubClassCaseDA vPubClassCaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPubClassCaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPubClassCaseBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvPubClassCaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPubClassCaseEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vPubClassCase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPubClassCaseDA.GetDataTable_vPubClassCase(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPubClassCaseDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vPubClassCaseDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vPubClassCaseDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vPubClassCaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vPubClassCaseDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vPubClassCaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vPubClassCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vPubClassCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrIdPubClassCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPubClassCaseEN> GetObjLstByIdPubClassCaseLst(List<string> arrIdPubClassCaseLst)
{
List<clsvPubClassCaseEN> arrObjLst = new List<clsvPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPubClassCaseLst, true);
 string strWhereCond = string.Format("IdPubClassCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN();
try
{
objvPubClassCaseEN.IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseEN.PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseEN.PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseEN.PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseEN.WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objvPubClassCaseEN.PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseEN.PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseEN.PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseEN.PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseEN.IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseEN.DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseEN.DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseEN.IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseEN.SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseEN.TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubClassCaseEN.TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(); //教学目标
objvPubClassCaseEN.TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点
objvPubClassCaseEN.TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubClassCaseEN.TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(); //教学用具
objvPubClassCaseEN.TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程
objvPubClassCaseEN.TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型
objvPubClassCaseEN.SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容
objvPubClassCaseEN.PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseEN.senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseEN.senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseEN.senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseEN.IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseEN.PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseEN.PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseEN.IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseEN.StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseEN.CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(); //光盘编号
objvPubClassCaseEN.Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(); //简要介绍
objvPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCaseEN.RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCaseEN.RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCaseEN.ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseEN.VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objvPubClassCaseEN.VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(); //视频目录
objvPubClassCaseEN.ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvPubClassCaseEN.Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(); //备注
objvPubClassCaseEN.BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPubClassCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPubClassCaseEN> GetObjLstByIdPubClassCaseLstCache(List<string> arrIdPubClassCaseLst)
{
string strKey = string.Format("{0}", clsvPubClassCaseEN._CurrTabName);
List<clsvPubClassCaseEN> arrvPubClassCaseObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseEN> arrvPubClassCaseObjLst_Sel =
arrvPubClassCaseObjLstCache
.Where(x => arrIdPubClassCaseLst.Contains(x.IdPubClassCase));
return arrvPubClassCaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseEN> GetObjLst(string strWhereCond)
{
List<clsvPubClassCaseEN> arrObjLst = new List<clsvPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN();
try
{
objvPubClassCaseEN.IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseEN.PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseEN.PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseEN.PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseEN.WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objvPubClassCaseEN.PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseEN.PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseEN.PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseEN.PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseEN.IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseEN.DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseEN.DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseEN.IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseEN.SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseEN.TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubClassCaseEN.TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(); //教学目标
objvPubClassCaseEN.TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点
objvPubClassCaseEN.TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubClassCaseEN.TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(); //教学用具
objvPubClassCaseEN.TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程
objvPubClassCaseEN.TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型
objvPubClassCaseEN.SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容
objvPubClassCaseEN.PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseEN.senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseEN.senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseEN.senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseEN.IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseEN.PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseEN.PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseEN.IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseEN.StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseEN.CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(); //光盘编号
objvPubClassCaseEN.Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(); //简要介绍
objvPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCaseEN.RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCaseEN.RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCaseEN.ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseEN.VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objvPubClassCaseEN.VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(); //视频目录
objvPubClassCaseEN.ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvPubClassCaseEN.Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(); //备注
objvPubClassCaseEN.BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPubClassCaseEN> arrObjLst = new List<clsvPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN();
try
{
objvPubClassCaseEN.IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseEN.PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseEN.PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseEN.PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseEN.WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objvPubClassCaseEN.PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseEN.PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseEN.PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseEN.PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseEN.IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseEN.DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseEN.DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseEN.IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseEN.SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseEN.TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubClassCaseEN.TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(); //教学目标
objvPubClassCaseEN.TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点
objvPubClassCaseEN.TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubClassCaseEN.TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(); //教学用具
objvPubClassCaseEN.TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程
objvPubClassCaseEN.TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型
objvPubClassCaseEN.SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容
objvPubClassCaseEN.PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseEN.senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseEN.senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseEN.senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseEN.IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseEN.PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseEN.PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseEN.IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseEN.StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseEN.CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(); //光盘编号
objvPubClassCaseEN.Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(); //简要介绍
objvPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCaseEN.RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCaseEN.RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCaseEN.ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseEN.VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objvPubClassCaseEN.VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(); //视频目录
objvPubClassCaseEN.ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvPubClassCaseEN.Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(); //备注
objvPubClassCaseEN.BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPubClassCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPubClassCaseEN> GetSubObjLstCache(clsvPubClassCaseEN objvPubClassCaseCond)
{
List<clsvPubClassCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPubClassCase.AttributeName)
{
if (objvPubClassCaseCond.IsUpdated(strFldName) == false) continue;
if (objvPubClassCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseCond[strFldName].ToString());
}
else
{
if (objvPubClassCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPubClassCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPubClassCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPubClassCaseEN> arrObjLst = new List<clsvPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN();
try
{
objvPubClassCaseEN.IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseEN.PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseEN.PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseEN.PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseEN.WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objvPubClassCaseEN.PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseEN.PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseEN.PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseEN.PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseEN.IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseEN.DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseEN.DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseEN.IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseEN.SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseEN.TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubClassCaseEN.TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(); //教学目标
objvPubClassCaseEN.TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点
objvPubClassCaseEN.TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubClassCaseEN.TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(); //教学用具
objvPubClassCaseEN.TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程
objvPubClassCaseEN.TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型
objvPubClassCaseEN.SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容
objvPubClassCaseEN.PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseEN.senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseEN.senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseEN.senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseEN.IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseEN.PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseEN.PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseEN.IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseEN.StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseEN.CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(); //光盘编号
objvPubClassCaseEN.Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(); //简要介绍
objvPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCaseEN.RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCaseEN.RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCaseEN.ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseEN.VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objvPubClassCaseEN.VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(); //视频目录
objvPubClassCaseEN.ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvPubClassCaseEN.Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(); //备注
objvPubClassCaseEN.BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPubClassCaseEN> arrObjLst = new List<clsvPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN();
try
{
objvPubClassCaseEN.IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseEN.PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseEN.PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseEN.PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseEN.WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objvPubClassCaseEN.PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseEN.PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseEN.PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseEN.PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseEN.IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseEN.DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseEN.DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseEN.IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseEN.SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseEN.TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubClassCaseEN.TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(); //教学目标
objvPubClassCaseEN.TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点
objvPubClassCaseEN.TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubClassCaseEN.TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(); //教学用具
objvPubClassCaseEN.TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程
objvPubClassCaseEN.TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型
objvPubClassCaseEN.SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容
objvPubClassCaseEN.PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseEN.senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseEN.senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseEN.senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseEN.IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseEN.PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseEN.PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseEN.IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseEN.StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseEN.CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(); //光盘编号
objvPubClassCaseEN.Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(); //简要介绍
objvPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCaseEN.RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCaseEN.RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCaseEN.ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseEN.VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objvPubClassCaseEN.VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(); //视频目录
objvPubClassCaseEN.ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvPubClassCaseEN.Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(); //备注
objvPubClassCaseEN.BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvPubClassCaseEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPubClassCaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPubClassCaseEN> arrObjLst = new List<clsvPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN();
try
{
objvPubClassCaseEN.IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseEN.PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseEN.PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseEN.PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseEN.WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objvPubClassCaseEN.PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseEN.PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseEN.PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseEN.PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseEN.IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseEN.DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseEN.DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseEN.IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseEN.SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseEN.TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubClassCaseEN.TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(); //教学目标
objvPubClassCaseEN.TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点
objvPubClassCaseEN.TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubClassCaseEN.TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(); //教学用具
objvPubClassCaseEN.TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程
objvPubClassCaseEN.TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型
objvPubClassCaseEN.SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容
objvPubClassCaseEN.PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseEN.senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseEN.senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseEN.senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseEN.IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseEN.PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseEN.PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseEN.IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseEN.StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseEN.CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(); //光盘编号
objvPubClassCaseEN.Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(); //简要介绍
objvPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCaseEN.RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCaseEN.RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCaseEN.ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseEN.VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objvPubClassCaseEN.VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(); //视频目录
objvPubClassCaseEN.ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvPubClassCaseEN.Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(); //备注
objvPubClassCaseEN.BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPubClassCaseEN> arrObjLst = new List<clsvPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN();
try
{
objvPubClassCaseEN.IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseEN.PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseEN.PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseEN.PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseEN.WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objvPubClassCaseEN.PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseEN.PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseEN.PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseEN.PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseEN.IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseEN.DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseEN.DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseEN.IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseEN.SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseEN.TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubClassCaseEN.TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(); //教学目标
objvPubClassCaseEN.TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点
objvPubClassCaseEN.TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubClassCaseEN.TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(); //教学用具
objvPubClassCaseEN.TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程
objvPubClassCaseEN.TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型
objvPubClassCaseEN.SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容
objvPubClassCaseEN.PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseEN.senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseEN.senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseEN.senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseEN.IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseEN.PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseEN.PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseEN.IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseEN.StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseEN.CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(); //光盘编号
objvPubClassCaseEN.Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(); //简要介绍
objvPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCaseEN.RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCaseEN.RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCaseEN.ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseEN.VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objvPubClassCaseEN.VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(); //视频目录
objvPubClassCaseEN.ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvPubClassCaseEN.Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(); //备注
objvPubClassCaseEN.BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPubClassCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPubClassCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPubClassCaseEN> arrObjLst = new List<clsvPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN();
try
{
objvPubClassCaseEN.IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseEN.PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseEN.PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseEN.PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseEN.WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objvPubClassCaseEN.PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseEN.PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseEN.PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseEN.PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseEN.IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseEN.DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseEN.DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseEN.IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseEN.SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseEN.TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubClassCaseEN.TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(); //教学目标
objvPubClassCaseEN.TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点
objvPubClassCaseEN.TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubClassCaseEN.TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(); //教学用具
objvPubClassCaseEN.TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程
objvPubClassCaseEN.TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型
objvPubClassCaseEN.SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容
objvPubClassCaseEN.PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseEN.senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseEN.senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseEN.senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseEN.IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseEN.PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseEN.PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseEN.IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseEN.StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseEN.CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(); //光盘编号
objvPubClassCaseEN.Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(); //简要介绍
objvPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCaseEN.RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCaseEN.RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCaseEN.ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseEN.VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objvPubClassCaseEN.VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(); //视频目录
objvPubClassCaseEN.ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvPubClassCaseEN.Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(); //备注
objvPubClassCaseEN.BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPubClassCaseEN> arrObjLst = new List<clsvPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN();
try
{
objvPubClassCaseEN.IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseEN.PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseEN.PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseEN.PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseEN.WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objvPubClassCaseEN.PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseEN.PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseEN.PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseEN.PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseEN.IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseEN.DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseEN.DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseEN.IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseEN.SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseEN.TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubClassCaseEN.TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(); //教学目标
objvPubClassCaseEN.TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点
objvPubClassCaseEN.TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubClassCaseEN.TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(); //教学用具
objvPubClassCaseEN.TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程
objvPubClassCaseEN.TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型
objvPubClassCaseEN.SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容
objvPubClassCaseEN.PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseEN.senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseEN.senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseEN.senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseEN.IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseEN.PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseEN.PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseEN.IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseEN.StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseEN.CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(); //光盘编号
objvPubClassCaseEN.Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(); //简要介绍
objvPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCaseEN.RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCaseEN.RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCaseEN.ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseEN.VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objvPubClassCaseEN.VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(); //视频目录
objvPubClassCaseEN.ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvPubClassCaseEN.Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(); //备注
objvPubClassCaseEN.BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPubClassCaseEN> arrObjLst = new List<clsvPubClassCaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN();
try
{
objvPubClassCaseEN.IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseEN.PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseEN.PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseEN.PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseEN.WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objvPubClassCaseEN.PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseEN.PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseEN.PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseEN.PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseEN.IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseEN.DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseEN.DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseEN.IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseEN.SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseEN.TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubClassCaseEN.TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(); //教学目标
objvPubClassCaseEN.TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点
objvPubClassCaseEN.TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubClassCaseEN.TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(); //教学用具
objvPubClassCaseEN.TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程
objvPubClassCaseEN.TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型
objvPubClassCaseEN.SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容
objvPubClassCaseEN.PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseEN.senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseEN.senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseEN.senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseEN.IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseEN.PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseEN.PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseEN.IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseEN.StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseEN.CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(); //光盘编号
objvPubClassCaseEN.Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(); //简要介绍
objvPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCaseEN.RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCaseEN.RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCaseEN.ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseEN.VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objvPubClassCaseEN.VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(); //视频目录
objvPubClassCaseEN.ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvPubClassCaseEN.Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(); //备注
objvPubClassCaseEN.BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPubClassCase(ref clsvPubClassCaseEN objvPubClassCaseEN)
{
bool bolResult = vPubClassCaseDA.GetvPubClassCase(ref objvPubClassCaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdPubClassCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseEN GetObjByIdPubClassCase(string strIdPubClassCase)
{
if (strIdPubClassCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdPubClassCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdPubClassCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdPubClassCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPubClassCaseEN objvPubClassCaseEN = vPubClassCaseDA.GetObjByIdPubClassCase(strIdPubClassCase);
return objvPubClassCaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPubClassCaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPubClassCaseEN objvPubClassCaseEN = vPubClassCaseDA.GetFirstObj(strWhereCond);
 return objvPubClassCaseEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvPubClassCaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPubClassCaseEN objvPubClassCaseEN = vPubClassCaseDA.GetObjByDataRow(objRow);
 return objvPubClassCaseEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvPubClassCaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPubClassCaseEN objvPubClassCaseEN = vPubClassCaseDA.GetObjByDataRow(objRow);
 return objvPubClassCaseEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strIdPubClassCase">所给的关键字</param>
 /// <param name = "lstvPubClassCaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCaseEN GetObjByIdPubClassCaseFromList(string strIdPubClassCase, List<clsvPubClassCaseEN> lstvPubClassCaseObjLst)
{
foreach (clsvPubClassCaseEN objvPubClassCaseEN in lstvPubClassCaseObjLst)
{
if (objvPubClassCaseEN.IdPubClassCase == strIdPubClassCase)
{
return objvPubClassCaseEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdPubClassCase;
 try
 {
 strIdPubClassCase = new clsvPubClassCaseDA().GetFirstID(strWhereCond);
 return strIdPubClassCase;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vPubClassCaseDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vPubClassCaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdPubClassCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdPubClassCase)
{
if (string.IsNullOrEmpty(strIdPubClassCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdPubClassCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPubClassCaseDA.IsExist(strIdPubClassCase);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvPubClassCaseDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vPubClassCaseDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvPubClassCaseENS">源对象</param>
 /// <param name = "objvPubClassCaseENT">目标对象</param>
 public static void CopyTo(clsvPubClassCaseEN objvPubClassCaseENS, clsvPubClassCaseEN objvPubClassCaseENT)
{
try
{
objvPubClassCaseENT.IdPubClassCase = objvPubClassCaseENS.IdPubClassCase; //案例流水号
objvPubClassCaseENT.PubClassCaseID = objvPubClassCaseENS.PubClassCaseID; //案例ID
objvPubClassCaseENT.PubClassCaseName = objvPubClassCaseENS.PubClassCaseName; //案例课题名称
objvPubClassCaseENT.PubClassCaseExecutor = objvPubClassCaseENS.PubClassCaseExecutor; //案例执教者
objvPubClassCaseENT.WorkUnit = objvPubClassCaseENS.WorkUnit; //工作单位
objvPubClassCaseENT.PubClassCaseTheme = objvPubClassCaseENS.PubClassCaseTheme; //案例主题词
objvPubClassCaseENT.PubClassCaseBG = objvPubClassCaseENS.PubClassCaseBG; //案例背景资料
objvPubClassCaseENT.PubClassCaseTeachDate = objvPubClassCaseENS.PubClassCaseTeachDate; //案例授课日期
objvPubClassCaseENT.PubClassCaseDateIn = objvPubClassCaseENS.PubClassCaseDateIn; //案例入库日期
objvPubClassCaseENT.IdDiscipline = objvPubClassCaseENS.IdDiscipline; //学科流水号
objvPubClassCaseENT.DisciplineID = objvPubClassCaseENS.DisciplineID; //学科ID
objvPubClassCaseENT.DisciplineName = objvPubClassCaseENS.DisciplineName; //学科名称
objvPubClassCaseENT.IdTeachingPlan = objvPubClassCaseENS.IdTeachingPlan; //教案流水号
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
objvPubClassCaseENT.IdPubClassCaseSenateGaugeVersion = objvPubClassCaseENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objvPubClassCaseENT.senateGaugeVersionID = objvPubClassCaseENS.senateGaugeVersionID; //评价量表版本ID
objvPubClassCaseENT.senateGaugeVersionName = objvPubClassCaseENS.senateGaugeVersionName; //评价量表版本名称
objvPubClassCaseENT.senateGaugeVersionTtlScore = objvPubClassCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvPubClassCaseENT.IdPubCaseType = objvPubClassCaseENS.IdPubCaseType; //公开课案例类型流水号
objvPubClassCaseENT.PubCaseTypeID = objvPubClassCaseENS.PubCaseTypeID; //公开课案例类型ID
objvPubClassCaseENT.PubCaseTypeName = objvPubClassCaseENS.PubCaseTypeName; //公开课案例类型名称
objvPubClassCaseENT.IdStudyLevel = objvPubClassCaseENS.IdStudyLevel; //id_StudyLevel
objvPubClassCaseENT.StudyLevelName = objvPubClassCaseENS.StudyLevelName; //学段名称
objvPubClassCaseENT.CDID = objvPubClassCaseENS.CDID; //光盘编号
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
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvPubClassCaseEN objvPubClassCaseEN)
{
try
{
objvPubClassCaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPubClassCaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPubClassCase.IdPubClassCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.IdPubClassCase = objvPubClassCaseEN.IdPubClassCase; //案例流水号
}
if (arrFldSet.Contains(convPubClassCase.PubClassCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.PubClassCaseID = objvPubClassCaseEN.PubClassCaseID; //案例ID
}
if (arrFldSet.Contains(convPubClassCase.PubClassCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.PubClassCaseName = objvPubClassCaseEN.PubClassCaseName; //案例课题名称
}
if (arrFldSet.Contains(convPubClassCase.PubClassCaseExecutor, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.PubClassCaseExecutor = objvPubClassCaseEN.PubClassCaseExecutor == "[null]" ? null :  objvPubClassCaseEN.PubClassCaseExecutor; //案例执教者
}
if (arrFldSet.Contains(convPubClassCase.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.WorkUnit = objvPubClassCaseEN.WorkUnit == "[null]" ? null :  objvPubClassCaseEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(convPubClassCase.PubClassCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.PubClassCaseTheme = objvPubClassCaseEN.PubClassCaseTheme == "[null]" ? null :  objvPubClassCaseEN.PubClassCaseTheme; //案例主题词
}
if (arrFldSet.Contains(convPubClassCase.PubClassCaseBG, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.PubClassCaseBG = objvPubClassCaseEN.PubClassCaseBG == "[null]" ? null :  objvPubClassCaseEN.PubClassCaseBG; //案例背景资料
}
if (arrFldSet.Contains(convPubClassCase.PubClassCaseTeachDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.PubClassCaseTeachDate = objvPubClassCaseEN.PubClassCaseTeachDate == "[null]" ? null :  objvPubClassCaseEN.PubClassCaseTeachDate; //案例授课日期
}
if (arrFldSet.Contains(convPubClassCase.PubClassCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.PubClassCaseDateIn = objvPubClassCaseEN.PubClassCaseDateIn == "[null]" ? null :  objvPubClassCaseEN.PubClassCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convPubClassCase.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.IdDiscipline = objvPubClassCaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convPubClassCase.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.DisciplineID = objvPubClassCaseEN.DisciplineID == "[null]" ? null :  objvPubClassCaseEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convPubClassCase.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.DisciplineName = objvPubClassCaseEN.DisciplineName == "[null]" ? null :  objvPubClassCaseEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convPubClassCase.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.IdTeachingPlan = objvPubClassCaseEN.IdTeachingPlan == "[null]" ? null :  objvPubClassCaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convPubClassCase.SubjectName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.SubjectName = objvPubClassCaseEN.SubjectName == "[null]" ? null :  objvPubClassCaseEN.SubjectName; //课题名称
}
if (arrFldSet.Contains(convPubClassCase.TeachingPlanAuthor, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.TeachingPlanAuthor = objvPubClassCaseEN.TeachingPlanAuthor == "[null]" ? null :  objvPubClassCaseEN.TeachingPlanAuthor; //教案撰写人
}
if (arrFldSet.Contains(convPubClassCase.TeachingObject, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.TeachingObject = objvPubClassCaseEN.TeachingObject == "[null]" ? null :  objvPubClassCaseEN.TeachingObject; //教学目标
}
if (arrFldSet.Contains(convPubClassCase.TeachingEmphases, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.TeachingEmphases = objvPubClassCaseEN.TeachingEmphases == "[null]" ? null :  objvPubClassCaseEN.TeachingEmphases; //教学重点
}
if (arrFldSet.Contains(convPubClassCase.TeachingDifficulty, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.TeachingDifficulty = objvPubClassCaseEN.TeachingDifficulty == "[null]" ? null :  objvPubClassCaseEN.TeachingDifficulty; //教学难点
}
if (arrFldSet.Contains(convPubClassCase.TeachingTool, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.TeachingTool = objvPubClassCaseEN.TeachingTool == "[null]" ? null :  objvPubClassCaseEN.TeachingTool; //教学用具
}
if (arrFldSet.Contains(convPubClassCase.TeachingProcess, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.TeachingProcess = objvPubClassCaseEN.TeachingProcess == "[null]" ? null :  objvPubClassCaseEN.TeachingProcess; //教学过程
}
if (arrFldSet.Contains(convPubClassCase.TeachingPlanType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.TeachingPlanType = objvPubClassCaseEN.TeachingPlanType == "[null]" ? null :  objvPubClassCaseEN.TeachingPlanType; //教案类型
}
if (arrFldSet.Contains(convPubClassCase.SimplePlanContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.SimplePlanContent = objvPubClassCaseEN.SimplePlanContent == "[null]" ? null :  objvPubClassCaseEN.SimplePlanContent; //简案内容
}
if (arrFldSet.Contains(convPubClassCase.PubClassCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.PubClassCaseTimeIn = objvPubClassCaseEN.PubClassCaseTimeIn == "[null]" ? null :  objvPubClassCaseEN.PubClassCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convPubClassCase.IdPubClassCaseSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
}
if (arrFldSet.Contains(convPubClassCase.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.senateGaugeVersionID = objvPubClassCaseEN.senateGaugeVersionID == "[null]" ? null :  objvPubClassCaseEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convPubClassCase.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.senateGaugeVersionName = objvPubClassCaseEN.senateGaugeVersionName == "[null]" ? null :  objvPubClassCaseEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convPubClassCase.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.senateGaugeVersionTtlScore = objvPubClassCaseEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convPubClassCase.IdPubCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.IdPubCaseType = objvPubClassCaseEN.IdPubCaseType == "[null]" ? null :  objvPubClassCaseEN.IdPubCaseType; //公开课案例类型流水号
}
if (arrFldSet.Contains(convPubClassCase.PubCaseTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.PubCaseTypeID = objvPubClassCaseEN.PubCaseTypeID == "[null]" ? null :  objvPubClassCaseEN.PubCaseTypeID; //公开课案例类型ID
}
if (arrFldSet.Contains(convPubClassCase.PubCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.PubCaseTypeName = objvPubClassCaseEN.PubCaseTypeName == "[null]" ? null :  objvPubClassCaseEN.PubCaseTypeName; //公开课案例类型名称
}
if (arrFldSet.Contains(convPubClassCase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.IdStudyLevel = objvPubClassCaseEN.IdStudyLevel == "[null]" ? null :  objvPubClassCaseEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convPubClassCase.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.StudyLevelName = objvPubClassCaseEN.StudyLevelName == "[null]" ? null :  objvPubClassCaseEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convPubClassCase.CDID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.CDID = objvPubClassCaseEN.CDID == "[null]" ? null :  objvPubClassCaseEN.CDID; //光盘编号
}
if (arrFldSet.Contains(convPubClassCase.Introduction, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.Introduction = objvPubClassCaseEN.Introduction == "[null]" ? null :  objvPubClassCaseEN.Introduction; //简要介绍
}
if (arrFldSet.Contains(convPubClassCase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.IsVisible = objvPubClassCaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convPubClassCase.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.IsDualVideo = objvPubClassCaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convPubClassCase.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.RecommendedDegreeId = objvPubClassCaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convPubClassCase.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.RecommendedDegreeName = objvPubClassCaseEN.RecommendedDegreeName == "[null]" ? null :  objvPubClassCaseEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convPubClassCase.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.ftpFileType = objvPubClassCaseEN.ftpFileType == "[null]" ? null :  objvPubClassCaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convPubClassCase.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.VideoUrl = objvPubClassCaseEN.VideoUrl == "[null]" ? null :  objvPubClassCaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(convPubClassCase.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.VideoPath = objvPubClassCaseEN.VideoPath == "[null]" ? null :  objvPubClassCaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(convPubClassCase.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.ResErrMsg = objvPubClassCaseEN.ResErrMsg == "[null]" ? null :  objvPubClassCaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(convPubClassCase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.Memo = objvPubClassCaseEN.Memo == "[null]" ? null :  objvPubClassCaseEN.Memo; //备注
}
if (arrFldSet.Contains(convPubClassCase.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseEN.BrowseCount4Case = objvPubClassCaseEN.BrowseCount4Case; //课例浏览次数
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPubClassCaseEN objvPubClassCaseEN)
{
try
{
if (objvPubClassCaseEN.PubClassCaseExecutor == "[null]") objvPubClassCaseEN.PubClassCaseExecutor = null; //案例执教者
if (objvPubClassCaseEN.WorkUnit == "[null]") objvPubClassCaseEN.WorkUnit = null; //工作单位
if (objvPubClassCaseEN.PubClassCaseTheme == "[null]") objvPubClassCaseEN.PubClassCaseTheme = null; //案例主题词
if (objvPubClassCaseEN.PubClassCaseBG == "[null]") objvPubClassCaseEN.PubClassCaseBG = null; //案例背景资料
if (objvPubClassCaseEN.PubClassCaseTeachDate == "[null]") objvPubClassCaseEN.PubClassCaseTeachDate = null; //案例授课日期
if (objvPubClassCaseEN.PubClassCaseDateIn == "[null]") objvPubClassCaseEN.PubClassCaseDateIn = null; //案例入库日期
if (objvPubClassCaseEN.DisciplineID == "[null]") objvPubClassCaseEN.DisciplineID = null; //学科ID
if (objvPubClassCaseEN.DisciplineName == "[null]") objvPubClassCaseEN.DisciplineName = null; //学科名称
if (objvPubClassCaseEN.IdTeachingPlan == "[null]") objvPubClassCaseEN.IdTeachingPlan = null; //教案流水号
if (objvPubClassCaseEN.SubjectName == "[null]") objvPubClassCaseEN.SubjectName = null; //课题名称
if (objvPubClassCaseEN.TeachingPlanAuthor == "[null]") objvPubClassCaseEN.TeachingPlanAuthor = null; //教案撰写人
if (objvPubClassCaseEN.TeachingObject == "[null]") objvPubClassCaseEN.TeachingObject = null; //教学目标
if (objvPubClassCaseEN.TeachingEmphases == "[null]") objvPubClassCaseEN.TeachingEmphases = null; //教学重点
if (objvPubClassCaseEN.TeachingDifficulty == "[null]") objvPubClassCaseEN.TeachingDifficulty = null; //教学难点
if (objvPubClassCaseEN.TeachingTool == "[null]") objvPubClassCaseEN.TeachingTool = null; //教学用具
if (objvPubClassCaseEN.TeachingProcess == "[null]") objvPubClassCaseEN.TeachingProcess = null; //教学过程
if (objvPubClassCaseEN.TeachingPlanType == "[null]") objvPubClassCaseEN.TeachingPlanType = null; //教案类型
if (objvPubClassCaseEN.SimplePlanContent == "[null]") objvPubClassCaseEN.SimplePlanContent = null; //简案内容
if (objvPubClassCaseEN.PubClassCaseTimeIn == "[null]") objvPubClassCaseEN.PubClassCaseTimeIn = null; //案例入库时间
if (objvPubClassCaseEN.senateGaugeVersionID == "[null]") objvPubClassCaseEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvPubClassCaseEN.senateGaugeVersionName == "[null]") objvPubClassCaseEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvPubClassCaseEN.IdPubCaseType == "[null]") objvPubClassCaseEN.IdPubCaseType = null; //公开课案例类型流水号
if (objvPubClassCaseEN.PubCaseTypeID == "[null]") objvPubClassCaseEN.PubCaseTypeID = null; //公开课案例类型ID
if (objvPubClassCaseEN.PubCaseTypeName == "[null]") objvPubClassCaseEN.PubCaseTypeName = null; //公开课案例类型名称
if (objvPubClassCaseEN.IdStudyLevel == "[null]") objvPubClassCaseEN.IdStudyLevel = null; //id_StudyLevel
if (objvPubClassCaseEN.StudyLevelName == "[null]") objvPubClassCaseEN.StudyLevelName = null; //学段名称
if (objvPubClassCaseEN.CDID == "[null]") objvPubClassCaseEN.CDID = null; //光盘编号
if (objvPubClassCaseEN.Introduction == "[null]") objvPubClassCaseEN.Introduction = null; //简要介绍
if (objvPubClassCaseEN.RecommendedDegreeName == "[null]") objvPubClassCaseEN.RecommendedDegreeName = null; //推荐度名称
if (objvPubClassCaseEN.ftpFileType == "[null]") objvPubClassCaseEN.ftpFileType = null; //ftp文件类型
if (objvPubClassCaseEN.VideoUrl == "[null]") objvPubClassCaseEN.VideoUrl = null; //视频Url
if (objvPubClassCaseEN.VideoPath == "[null]") objvPubClassCaseEN.VideoPath = null; //视频目录
if (objvPubClassCaseEN.ResErrMsg == "[null]") objvPubClassCaseEN.ResErrMsg = null; //资源错误信息
if (objvPubClassCaseEN.Memo == "[null]") objvPubClassCaseEN.Memo = null; //备注
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvPubClassCaseEN objvPubClassCaseEN)
{
 vPubClassCaseDA.CheckProperty4Condition(objvPubClassCaseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseBL没有刷新缓存机制(clsPubClassCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingPlanBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingPlanBL没有刷新缓存机制(clsTeachingPlanBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateGaugeVersionBL没有刷新缓存机制(clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubCaseTypeBL没有刷新缓存机制(clsPubCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdPubClassCase");
//if (arrvPubClassCaseObjLstCache == null)
//{
//arrvPubClassCaseObjLstCache = vPubClassCaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdPubClassCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCaseEN GetObjByIdPubClassCaseCache(string strIdPubClassCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPubClassCaseEN._CurrTabName);
List<clsvPubClassCaseEN> arrvPubClassCaseObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseEN> arrvPubClassCaseObjLst_Sel =
arrvPubClassCaseObjLstCache
.Where(x=> x.IdPubClassCase == strIdPubClassCase 
);
if (arrvPubClassCaseObjLst_Sel.Count() == 0)
{
   clsvPubClassCaseEN obj = clsvPubClassCaseBL.GetObjByIdPubClassCase(strIdPubClassCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPubClassCaseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPubClassCaseEN> GetAllvPubClassCaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvPubClassCaseEN> arrvPubClassCaseObjLstCache = GetObjLstCache(); 
return arrvPubClassCaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPubClassCaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPubClassCaseEN._CurrTabName);
List<clsvPubClassCaseEN> arrvPubClassCaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPubClassCaseObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvPubClassCaseEN._CurrTabName);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdPubClassCase)
{
if (strInFldName != convPubClassCase.IdPubClassCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPubClassCase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPubClassCase.AttributeName));
throw new Exception(strMsg);
}
var objvPubClassCase = clsvPubClassCaseBL.GetObjByIdPubClassCaseCache(strIdPubClassCase);
if (objvPubClassCase == null) return "";
return objvPubClassCase[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvPubClassCaseDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvPubClassCaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPubClassCaseDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvPubClassCaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPubClassCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPubClassCaseEN objvPubClassCaseCond)
{
List<clsvPubClassCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPubClassCase.AttributeName)
{
if (objvPubClassCaseCond.IsUpdated(strFldName) == false) continue;
if (objvPubClassCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseCond[strFldName].ToString());
}
else
{
if (objvPubClassCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPubClassCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPubClassCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvPubClassCaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vPubClassCaseDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vPubClassCaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}