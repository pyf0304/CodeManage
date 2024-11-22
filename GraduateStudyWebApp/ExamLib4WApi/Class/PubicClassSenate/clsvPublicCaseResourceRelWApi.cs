
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPublicCaseResourceRelWApi
 表名:vPublicCaseResourceRel(01120406)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:44
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
public static class clsvPublicCaseResourceRelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN Setid_PubClassCase_Resource_Rel(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, long lngid_PubClassCase_Resource_Rel, string strComparisonOp="")
	{
objvPublicCaseResourceRelEN.id_PubClassCase_Resource_Rel = lngid_PubClassCase_Resource_Rel; //案例与资源关系表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.id_PubClassCase_Resource_Rel) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.id_PubClassCase_Resource_Rel, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.id_PubClassCase_Resource_Rel] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN Setid_PubClassCase(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strid_PubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubClassCase, convPublicCaseResourceRel.id_PubClassCase);
clsCheckSql.CheckFieldLen(strid_PubClassCase, 8, convPublicCaseResourceRel.id_PubClassCase);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCase, 8, convPublicCaseResourceRel.id_PubClassCase);
objvPublicCaseResourceRelEN.id_PubClassCase = strid_PubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.id_PubClassCase) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.id_PubClassCase, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.id_PubClassCase] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetPubClassCaseName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strPubClassCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseName, convPublicCaseResourceRel.PubClassCaseName);
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, convPublicCaseResourceRel.PubClassCaseName);
objvPublicCaseResourceRelEN.PubClassCaseName = strPubClassCaseName; //案例课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.PubClassCaseName) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.PubClassCaseName, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseName] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetPubClassCaseExecutor(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, convPublicCaseResourceRel.PubClassCaseExecutor);
objvPublicCaseResourceRelEN.PubClassCaseExecutor = strPubClassCaseExecutor; //案例执教者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.PubClassCaseExecutor) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.PubClassCaseExecutor, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseExecutor] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetPubClassCaseTheme(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strPubClassCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTheme, 500, convPublicCaseResourceRel.PubClassCaseTheme);
objvPublicCaseResourceRelEN.PubClassCaseTheme = strPubClassCaseTheme; //案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.PubClassCaseTheme) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.PubClassCaseTheme, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseTheme] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetPubClassCaseBG(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strPubClassCaseBG, string strComparisonOp="")
	{
objvPublicCaseResourceRelEN.PubClassCaseBG = strPubClassCaseBG; //案例背景资料
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.PubClassCaseBG) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.PubClassCaseBG, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseBG] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetPubClassCaseTeachDate(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strPubClassCaseTeachDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTeachDate, 8, convPublicCaseResourceRel.PubClassCaseTeachDate);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTeachDate, 8, convPublicCaseResourceRel.PubClassCaseTeachDate);
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = strPubClassCaseTeachDate; //案例授课日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.PubClassCaseTeachDate) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.PubClassCaseTeachDate, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseTeachDate] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetPubClassCaseDateIn(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strPubClassCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseDateIn, 8, convPublicCaseResourceRel.PubClassCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseDateIn, 8, convPublicCaseResourceRel.PubClassCaseDateIn);
objvPublicCaseResourceRelEN.PubClassCaseDateIn = strPubClassCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.PubClassCaseDateIn) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.PubClassCaseDateIn, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseDateIn] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN Setid_Discipline(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convPublicCaseResourceRel.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convPublicCaseResourceRel.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convPublicCaseResourceRel.id_Discipline);
objvPublicCaseResourceRelEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.id_Discipline) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.id_Discipline, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.id_Discipline] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetDisciplineID(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineID, convPublicCaseResourceRel.DisciplineID);
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convPublicCaseResourceRel.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convPublicCaseResourceRel.DisciplineID);
objvPublicCaseResourceRelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.DisciplineID) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.DisciplineID, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.DisciplineID] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetDisciplineName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convPublicCaseResourceRel.DisciplineName);
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convPublicCaseResourceRel.DisciplineName);
objvPublicCaseResourceRelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.DisciplineName) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.DisciplineName, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.DisciplineName] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN Setid_TeachingPlan(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingPlan, convPublicCaseResourceRel.id_TeachingPlan);
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convPublicCaseResourceRel.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convPublicCaseResourceRel.id_TeachingPlan);
objvPublicCaseResourceRelEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.id_TeachingPlan) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.id_TeachingPlan, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.id_TeachingPlan] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetSubjectName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strSubjectName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSubjectName, convPublicCaseResourceRel.SubjectName);
clsCheckSql.CheckFieldLen(strSubjectName, 200, convPublicCaseResourceRel.SubjectName);
objvPublicCaseResourceRelEN.SubjectName = strSubjectName; //课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.SubjectName) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.SubjectName, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.SubjectName] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetTeachingPlanAuthor(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strTeachingPlanAuthor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingPlanAuthor, 50, convPublicCaseResourceRel.TeachingPlanAuthor);
objvPublicCaseResourceRelEN.TeachingPlanAuthor = strTeachingPlanAuthor; //教案撰写人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.TeachingPlanAuthor) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.TeachingPlanAuthor, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.TeachingPlanAuthor] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetTeachingObject(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strTeachingObject, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingObject, 5000, convPublicCaseResourceRel.TeachingObject);
objvPublicCaseResourceRelEN.TeachingObject = strTeachingObject; //教学目标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.TeachingObject) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.TeachingObject, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.TeachingObject] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetTeachingEmphases(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strTeachingEmphases, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingEmphases, 5000, convPublicCaseResourceRel.TeachingEmphases);
objvPublicCaseResourceRelEN.TeachingEmphases = strTeachingEmphases; //教学重点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.TeachingEmphases) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.TeachingEmphases, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.TeachingEmphases] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetTeachingDifficulty(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strTeachingDifficulty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingDifficulty, 5000, convPublicCaseResourceRel.TeachingDifficulty);
objvPublicCaseResourceRelEN.TeachingDifficulty = strTeachingDifficulty; //教学难点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.TeachingDifficulty) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.TeachingDifficulty, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.TeachingDifficulty] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetTeachingTool(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strTeachingTool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingTool, 5000, convPublicCaseResourceRel.TeachingTool);
objvPublicCaseResourceRelEN.TeachingTool = strTeachingTool; //教学用具
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.TeachingTool) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.TeachingTool, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.TeachingTool] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetTeachingProcess(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strTeachingProcess, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingProcess, 8000, convPublicCaseResourceRel.TeachingProcess);
objvPublicCaseResourceRelEN.TeachingProcess = strTeachingProcess; //教学过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.TeachingProcess) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.TeachingProcess, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.TeachingProcess] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetTeachingPlanType(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strTeachingPlanType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingPlanType, 1, convPublicCaseResourceRel.TeachingPlanType);
clsCheckSql.CheckFieldForeignKey(strTeachingPlanType, 1, convPublicCaseResourceRel.TeachingPlanType);
objvPublicCaseResourceRelEN.TeachingPlanType = strTeachingPlanType; //教案类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.TeachingPlanType) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.TeachingPlanType, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.TeachingPlanType] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetSimplePlanContent(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strSimplePlanContent, string strComparisonOp="")
	{
objvPublicCaseResourceRelEN.SimplePlanContent = strSimplePlanContent; //简案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.SimplePlanContent) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.SimplePlanContent, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.SimplePlanContent] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetPubClassCaseTimeIn(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strPubClassCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTimeIn, 6, convPublicCaseResourceRel.PubClassCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTimeIn, 6, convPublicCaseResourceRel.PubClassCaseTimeIn);
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = strPubClassCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.PubClassCaseTimeIn) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.PubClassCaseTimeIn, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseTimeIn] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetPubCaseTypeName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strPubCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubCaseTypeName, 50, convPublicCaseResourceRel.PubCaseTypeName);
objvPublicCaseResourceRelEN.PubCaseTypeName = strPubCaseTypeName; //公开课案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.PubCaseTypeName) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.PubCaseTypeName, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.PubCaseTypeName] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN Setid_StudyLevel(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convPublicCaseResourceRel.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convPublicCaseResourceRel.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convPublicCaseResourceRel.id_StudyLevel);
objvPublicCaseResourceRelEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.id_StudyLevel) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.id_StudyLevel, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.id_StudyLevel] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetStudyLevelName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convPublicCaseResourceRel.StudyLevelName);
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convPublicCaseResourceRel.StudyLevelName);
objvPublicCaseResourceRelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.StudyLevelName) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.StudyLevelName, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.StudyLevelName] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIntroduction(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strIntroduction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIntroduction, 4000, convPublicCaseResourceRel.Introduction);
objvPublicCaseResourceRelEN.Introduction = strIntroduction; //简要介绍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.Introduction) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.Introduction, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.Introduction] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetCaseIsVisible(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, bool bolCaseIsVisible, string strComparisonOp="")
	{
objvPublicCaseResourceRelEN.CaseIsVisible = bolCaseIsVisible; //CaseIsVisible
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.CaseIsVisible) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.CaseIsVisible, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.CaseIsVisible] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIsDualVideo(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvPublicCaseResourceRelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.IsDualVideo) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.IsDualVideo, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.IsDualVideo] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetRecommendedDegreeId(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convPublicCaseResourceRel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convPublicCaseResourceRel.RecommendedDegreeId);
objvPublicCaseResourceRelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.RecommendedDegreeId) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetRecommendedDegreeName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convPublicCaseResourceRel.RecommendedDegreeName);
objvPublicCaseResourceRelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.RecommendedDegreeName) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN Setid_Resource(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convPublicCaseResourceRel.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convPublicCaseResourceRel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convPublicCaseResourceRel.id_Resource);
objvPublicCaseResourceRelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.id_Resource) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.id_Resource, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.id_Resource] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetResourceID(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convPublicCaseResourceRel.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, convPublicCaseResourceRel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convPublicCaseResourceRel.ResourceID);
objvPublicCaseResourceRelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.ResourceID) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.ResourceID, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.ResourceID] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetResourceName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convPublicCaseResourceRel.ResourceName);
objvPublicCaseResourceRelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.ResourceName) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.ResourceName, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.ResourceName] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN Setid_FtpResource(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convPublicCaseResourceRel.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convPublicCaseResourceRel.id_FtpResource);
objvPublicCaseResourceRelEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.id_FtpResource) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.id_FtpResource, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.id_FtpResource] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN Setid_File(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convPublicCaseResourceRel.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convPublicCaseResourceRel.id_File);
objvPublicCaseResourceRelEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.id_File) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.id_File, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.id_File] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convPublicCaseResourceRel.FileName);
objvPublicCaseResourceRelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.FileName) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.FileName, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.FileName] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileType(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convPublicCaseResourceRel.FileType);
objvPublicCaseResourceRelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.FileType) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.FileType, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.FileType] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetSaveDate(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convPublicCaseResourceRel.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convPublicCaseResourceRel.SaveDate);
objvPublicCaseResourceRelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.SaveDate) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.SaveDate, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.SaveDate] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileSize(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convPublicCaseResourceRel.FileSize);
objvPublicCaseResourceRelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.FileSize) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.FileSize, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.FileSize] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetSaveTime(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convPublicCaseResourceRel.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convPublicCaseResourceRel.SaveTime);
objvPublicCaseResourceRelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.SaveTime) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.SaveTime, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.SaveTime] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFtpResourceID(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convPublicCaseResourceRel.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convPublicCaseResourceRel.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convPublicCaseResourceRel.FtpResourceID);
objvPublicCaseResourceRelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.FtpResourceID) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.FtpResourceID, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.FtpResourceID] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileOriginalName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convPublicCaseResourceRel.FileOriginalName);
objvPublicCaseResourceRelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.FileOriginalName) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.FileOriginalName, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.FileOriginalName] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileDirName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convPublicCaseResourceRel.FileDirName);
objvPublicCaseResourceRelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.FileDirName) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.FileDirName, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.FileDirName] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileRename(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convPublicCaseResourceRel.FileRename);
objvPublicCaseResourceRelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.FileRename) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.FileRename, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.FileRename] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileUpDate(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convPublicCaseResourceRel.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convPublicCaseResourceRel.FileUpDate);
objvPublicCaseResourceRelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.FileUpDate) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.FileUpDate, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.FileUpDate] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileUpTime(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convPublicCaseResourceRel.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convPublicCaseResourceRel.FileUpTime);
objvPublicCaseResourceRelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.FileUpTime) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.FileUpTime, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.FileUpTime] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetSaveMode(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvPublicCaseResourceRelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.SaveMode) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.SaveMode, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.SaveMode] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN Setid_ResourceType(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convPublicCaseResourceRel.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convPublicCaseResourceRel.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convPublicCaseResourceRel.id_ResourceType);
objvPublicCaseResourceRelEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.id_ResourceType) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.id_ResourceType, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.id_ResourceType] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetResourceTypeID(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convPublicCaseResourceRel.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convPublicCaseResourceRel.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convPublicCaseResourceRel.ResourceTypeID);
objvPublicCaseResourceRelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.ResourceTypeID) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.ResourceTypeID, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.ResourceTypeID] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetResourceTypeName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convPublicCaseResourceRel.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convPublicCaseResourceRel.ResourceTypeName);
objvPublicCaseResourceRelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.ResourceTypeName) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.ResourceTypeName, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.ResourceTypeName] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetResourceOwner(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convPublicCaseResourceRel.ResourceOwner);
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convPublicCaseResourceRel.ResourceOwner);
objvPublicCaseResourceRelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.ResourceOwner) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.ResourceOwner, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.ResourceOwner] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetftpFileType(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convPublicCaseResourceRel.ftpFileType);
objvPublicCaseResourceRelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.ftpFileType) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.ftpFileType, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.ftpFileType] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetftpFileSize(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convPublicCaseResourceRel.ftpFileSize);
objvPublicCaseResourceRelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.ftpFileSize) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.ftpFileSize, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.ftpFileSize] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetftpResourceOwner(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convPublicCaseResourceRel.ftpResourceOwner);
objvPublicCaseResourceRelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.ftpResourceOwner) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.ftpResourceOwner, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.ftpResourceOwner] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileOriginName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convPublicCaseResourceRel.FileOriginName);
objvPublicCaseResourceRelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.FileOriginName) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.FileOriginName, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.FileOriginName] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIsExistFile(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvPublicCaseResourceRelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.IsExistFile) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.IsExistFile, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.IsExistFile] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileNewName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convPublicCaseResourceRel.FileNewName);
objvPublicCaseResourceRelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.FileNewName) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.FileNewName, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.FileNewName] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileOldName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convPublicCaseResourceRel.FileOldName);
objvPublicCaseResourceRelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.FileOldName) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.FileOldName, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.FileOldName] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIsMain(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, bool bolIsMain, string strComparisonOp="")
	{
objvPublicCaseResourceRelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.IsMain) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.IsMain, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.IsMain] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIndexNO(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, int intIndexNO, string strComparisonOp="")
	{
objvPublicCaseResourceRelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.IndexNO) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.IndexNO, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.IndexNO] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetMemo(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPublicCaseResourceRel.Memo);
objvPublicCaseResourceRelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.Memo) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.Memo, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.Memo] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIsVisible(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvPublicCaseResourceRelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.IsVisible) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.IsVisible, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.IsVisible] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetBrowseCount(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, int intBrowseCount, string strComparisonOp="")
	{
objvPublicCaseResourceRelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.BrowseCount) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.BrowseCount, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.BrowseCount] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.id_PubClassCase_Resource_Rel) == true)
{
string strComparisonOp_id_PubClassCase_Resource_Rel = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.id_PubClassCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convPublicCaseResourceRel.id_PubClassCase_Resource_Rel, objvPublicCaseResourceRel_Cond.id_PubClassCase_Resource_Rel, strComparisonOp_id_PubClassCase_Resource_Rel);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.id_PubClassCase) == true)
{
string strComparisonOp_id_PubClassCase = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.id_PubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.id_PubClassCase, objvPublicCaseResourceRel_Cond.id_PubClassCase, strComparisonOp_id_PubClassCase);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.PubClassCaseName) == true)
{
string strComparisonOp_PubClassCaseName = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.PubClassCaseName, objvPublicCaseResourceRel_Cond.PubClassCaseName, strComparisonOp_PubClassCaseName);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.PubClassCaseExecutor) == true)
{
string strComparisonOp_PubClassCaseExecutor = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.PubClassCaseExecutor, objvPublicCaseResourceRel_Cond.PubClassCaseExecutor, strComparisonOp_PubClassCaseExecutor);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.PubClassCaseTheme) == true)
{
string strComparisonOp_PubClassCaseTheme = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.PubClassCaseTheme, objvPublicCaseResourceRel_Cond.PubClassCaseTheme, strComparisonOp_PubClassCaseTheme);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.PubClassCaseTeachDate) == true)
{
string strComparisonOp_PubClassCaseTeachDate = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.PubClassCaseTeachDate, objvPublicCaseResourceRel_Cond.PubClassCaseTeachDate, strComparisonOp_PubClassCaseTeachDate);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.PubClassCaseDateIn) == true)
{
string strComparisonOp_PubClassCaseDateIn = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.PubClassCaseDateIn, objvPublicCaseResourceRel_Cond.PubClassCaseDateIn, strComparisonOp_PubClassCaseDateIn);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.id_Discipline, objvPublicCaseResourceRel_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.DisciplineID, objvPublicCaseResourceRel_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.DisciplineName, objvPublicCaseResourceRel_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.id_TeachingPlan, objvPublicCaseResourceRel_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.SubjectName) == true)
{
string strComparisonOp_SubjectName = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.SubjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.SubjectName, objvPublicCaseResourceRel_Cond.SubjectName, strComparisonOp_SubjectName);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.TeachingPlanAuthor) == true)
{
string strComparisonOp_TeachingPlanAuthor = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.TeachingPlanAuthor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.TeachingPlanAuthor, objvPublicCaseResourceRel_Cond.TeachingPlanAuthor, strComparisonOp_TeachingPlanAuthor);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.TeachingObject) == true)
{
string strComparisonOp_TeachingObject = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.TeachingObject];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.TeachingObject, objvPublicCaseResourceRel_Cond.TeachingObject, strComparisonOp_TeachingObject);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.TeachingEmphases) == true)
{
string strComparisonOp_TeachingEmphases = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.TeachingEmphases];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.TeachingEmphases, objvPublicCaseResourceRel_Cond.TeachingEmphases, strComparisonOp_TeachingEmphases);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.TeachingDifficulty) == true)
{
string strComparisonOp_TeachingDifficulty = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.TeachingDifficulty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.TeachingDifficulty, objvPublicCaseResourceRel_Cond.TeachingDifficulty, strComparisonOp_TeachingDifficulty);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.TeachingTool) == true)
{
string strComparisonOp_TeachingTool = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.TeachingTool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.TeachingTool, objvPublicCaseResourceRel_Cond.TeachingTool, strComparisonOp_TeachingTool);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.TeachingProcess) == true)
{
string strComparisonOp_TeachingProcess = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.TeachingProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.TeachingProcess, objvPublicCaseResourceRel_Cond.TeachingProcess, strComparisonOp_TeachingProcess);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.TeachingPlanType) == true)
{
string strComparisonOp_TeachingPlanType = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.TeachingPlanType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.TeachingPlanType, objvPublicCaseResourceRel_Cond.TeachingPlanType, strComparisonOp_TeachingPlanType);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.PubClassCaseTimeIn) == true)
{
string strComparisonOp_PubClassCaseTimeIn = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.PubClassCaseTimeIn, objvPublicCaseResourceRel_Cond.PubClassCaseTimeIn, strComparisonOp_PubClassCaseTimeIn);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.PubCaseTypeName) == true)
{
string strComparisonOp_PubCaseTypeName = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.PubCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.PubCaseTypeName, objvPublicCaseResourceRel_Cond.PubCaseTypeName, strComparisonOp_PubCaseTypeName);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.id_StudyLevel, objvPublicCaseResourceRel_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.StudyLevelName, objvPublicCaseResourceRel_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.Introduction) == true)
{
string strComparisonOp_Introduction = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.Introduction];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.Introduction, objvPublicCaseResourceRel_Cond.Introduction, strComparisonOp_Introduction);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.CaseIsVisible) == true)
{
if (objvPublicCaseResourceRel_Cond.CaseIsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPublicCaseResourceRel.CaseIsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPublicCaseResourceRel.CaseIsVisible);
}
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.IsDualVideo) == true)
{
if (objvPublicCaseResourceRel_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPublicCaseResourceRel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPublicCaseResourceRel.IsDualVideo);
}
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.RecommendedDegreeId, objvPublicCaseResourceRel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.RecommendedDegreeName, objvPublicCaseResourceRel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.id_Resource, objvPublicCaseResourceRel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ResourceID, objvPublicCaseResourceRel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ResourceName, objvPublicCaseResourceRel_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.id_FtpResource, objvPublicCaseResourceRel_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.id_File) == true)
{
string strComparisonOp_id_File = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.id_File, objvPublicCaseResourceRel_Cond.id_File, strComparisonOp_id_File);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.FileName) == true)
{
string strComparisonOp_FileName = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileName, objvPublicCaseResourceRel_Cond.FileName, strComparisonOp_FileName);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.FileType) == true)
{
string strComparisonOp_FileType = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileType, objvPublicCaseResourceRel_Cond.FileType, strComparisonOp_FileType);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.SaveDate, objvPublicCaseResourceRel_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.FileSize) == true)
{
string strComparisonOp_FileSize = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileSize, objvPublicCaseResourceRel_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.SaveTime, objvPublicCaseResourceRel_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FtpResourceID, objvPublicCaseResourceRel_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileOriginalName, objvPublicCaseResourceRel_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileDirName, objvPublicCaseResourceRel_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.FileRename) == true)
{
string strComparisonOp_FileRename = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileRename, objvPublicCaseResourceRel_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileUpDate, objvPublicCaseResourceRel_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileUpTime, objvPublicCaseResourceRel_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.SaveMode) == true)
{
if (objvPublicCaseResourceRel_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPublicCaseResourceRel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPublicCaseResourceRel.SaveMode);
}
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.id_ResourceType, objvPublicCaseResourceRel_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ResourceTypeID, objvPublicCaseResourceRel_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ResourceTypeName, objvPublicCaseResourceRel_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ResourceOwner, objvPublicCaseResourceRel_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ftpFileType, objvPublicCaseResourceRel_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ftpFileSize, objvPublicCaseResourceRel_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ftpResourceOwner, objvPublicCaseResourceRel_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileOriginName, objvPublicCaseResourceRel_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.IsExistFile) == true)
{
if (objvPublicCaseResourceRel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPublicCaseResourceRel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPublicCaseResourceRel.IsExistFile);
}
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileNewName, objvPublicCaseResourceRel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileOldName, objvPublicCaseResourceRel_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.IsMain) == true)
{
if (objvPublicCaseResourceRel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPublicCaseResourceRel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPublicCaseResourceRel.IsMain);
}
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convPublicCaseResourceRel.IndexNO, objvPublicCaseResourceRel_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.Memo) == true)
{
string strComparisonOp_Memo = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.Memo, objvPublicCaseResourceRel_Cond.Memo, strComparisonOp_Memo);
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.IsVisible) == true)
{
if (objvPublicCaseResourceRel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPublicCaseResourceRel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPublicCaseResourceRel.IsVisible);
}
}
if (objvPublicCaseResourceRel_Cond.IsUpdated(convPublicCaseResourceRel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvPublicCaseResourceRel_Cond.dicFldComparisonOp[convPublicCaseResourceRel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPublicCaseResourceRel.BrowseCount, objvPublicCaseResourceRel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vPublicCaseResourceRel(vPublicCaseResourceRel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPublicCaseResourceRelWApi
{
private static readonly string mstrApiControllerName = "vPublicCaseResourceRelApi";

 public clsvPublicCaseResourceRelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_PubClassCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPublicCaseResourceRelEN GetObjByid_PubClassCase_Resource_Rel(long lngid_PubClassCase_Resource_Rel)
{
string strAction = "GetObjByid_PubClassCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCase_Resource_Rel"] = lngid_PubClassCase_Resource_Rel.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPublicCaseResourceRelEN = JsonConvert.DeserializeObject<clsvPublicCaseResourceRelEN>((string)jobjReturn["ReturnObj"]);
return objvPublicCaseResourceRelEN;
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
 /// <param name = "lngid_PubClassCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPublicCaseResourceRelEN GetObjByid_PubClassCase_Resource_Rel_WA_Cache(long lngid_PubClassCase_Resource_Rel)
{
string strAction = "GetObjByid_PubClassCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCase_Resource_Rel"] = lngid_PubClassCase_Resource_Rel.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPublicCaseResourceRelEN = JsonConvert.DeserializeObject<clsvPublicCaseResourceRelEN>((string)jobjReturn["ReturnObj"]);
return objvPublicCaseResourceRelEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvPublicCaseResourceRelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = null;
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
objvPublicCaseResourceRelEN = JsonConvert.DeserializeObject<clsvPublicCaseResourceRelEN>((string)jobjReturn["ReturnObj"]);
return objvPublicCaseResourceRelEN;
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
 /// <param name = "lngid_PubClassCase_Resource_Rel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPublicCaseResourceRelEN GetObjByid_PubClassCase_Resource_Rel_Cache(long lngid_PubClassCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPublicCaseResourceRelEN._CurrTabName_S);
List<clsvPublicCaseResourceRelEN> arrvPublicCaseResourceRelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPublicCaseResourceRelEN> arrvPublicCaseResourceRelObjLst_Sel =
from objvPublicCaseResourceRelEN in arrvPublicCaseResourceRelObjLst_Cache
where objvPublicCaseResourceRelEN.id_PubClassCase_Resource_Rel == lngid_PubClassCase_Resource_Rel
select objvPublicCaseResourceRelEN;
if (arrvPublicCaseResourceRelObjLst_Sel.Count() == 0)
{
   clsvPublicCaseResourceRelEN obj = clsvPublicCaseResourceRelWApi.GetObjByid_PubClassCase_Resource_Rel(lngid_PubClassCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPublicCaseResourceRelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPublicCaseResourceRelEN> GetObjLst(string strWhereCond)
{
 List<clsvPublicCaseResourceRelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPublicCaseResourceRelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPublicCaseResourceRelEN> GetObjLstById_PubClassCase_Resource_RelLst(List<long> arrId_PubClassCase_Resource_Rel)
{
 List<clsvPublicCaseResourceRelEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCase_Resource_RelLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCase_Resource_Rel);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPublicCaseResourceRelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_PubClassCase_Resource_Rel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvPublicCaseResourceRelEN> GetObjLstById_PubClassCase_Resource_RelLst_Cache(List<long> arrId_PubClassCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPublicCaseResourceRelEN._CurrTabName_S);
List<clsvPublicCaseResourceRelEN> arrvPublicCaseResourceRelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPublicCaseResourceRelEN> arrvPublicCaseResourceRelObjLst_Sel =
from objvPublicCaseResourceRelEN in arrvPublicCaseResourceRelObjLst_Cache
where arrId_PubClassCase_Resource_Rel.Contains(objvPublicCaseResourceRelEN.id_PubClassCase_Resource_Rel)
select objvPublicCaseResourceRelEN;
return arrvPublicCaseResourceRelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPublicCaseResourceRelEN> GetObjLstById_PubClassCase_Resource_RelLst_WA_Cache(List<long> arrId_PubClassCase_Resource_Rel)
{
 List<clsvPublicCaseResourceRelEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCase_Resource_RelLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCase_Resource_Rel);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPublicCaseResourceRelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPublicCaseResourceRelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPublicCaseResourceRelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPublicCaseResourceRelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPublicCaseResourceRelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPublicCaseResourceRelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPublicCaseResourceRelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPublicCaseResourceRelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPublicCaseResourceRelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPublicCaseResourceRelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPublicCaseResourceRelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPublicCaseResourceRelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPublicCaseResourceRelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_PubClassCase_Resource_Rel)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCase_Resource_Rel"] = lngid_PubClassCase_Resource_Rel.ToString()
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
 /// <param name = "objvPublicCaseResourceRelENS">源对象</param>
 /// <param name = "objvPublicCaseResourceRelENT">目标对象</param>
 public static void CopyTo(clsvPublicCaseResourceRelEN objvPublicCaseResourceRelENS, clsvPublicCaseResourceRelEN objvPublicCaseResourceRelENT)
{
try
{
objvPublicCaseResourceRelENT.id_PubClassCase_Resource_Rel = objvPublicCaseResourceRelENS.id_PubClassCase_Resource_Rel; //案例与资源关系表流水号
objvPublicCaseResourceRelENT.id_PubClassCase = objvPublicCaseResourceRelENS.id_PubClassCase; //案例流水号
objvPublicCaseResourceRelENT.PubClassCaseName = objvPublicCaseResourceRelENS.PubClassCaseName; //案例课题名称
objvPublicCaseResourceRelENT.PubClassCaseExecutor = objvPublicCaseResourceRelENS.PubClassCaseExecutor; //案例执教者
objvPublicCaseResourceRelENT.PubClassCaseTheme = objvPublicCaseResourceRelENS.PubClassCaseTheme; //案例主题词
objvPublicCaseResourceRelENT.PubClassCaseBG = objvPublicCaseResourceRelENS.PubClassCaseBG; //案例背景资料
objvPublicCaseResourceRelENT.PubClassCaseTeachDate = objvPublicCaseResourceRelENS.PubClassCaseTeachDate; //案例授课日期
objvPublicCaseResourceRelENT.PubClassCaseDateIn = objvPublicCaseResourceRelENS.PubClassCaseDateIn; //案例入库日期
objvPublicCaseResourceRelENT.id_Discipline = objvPublicCaseResourceRelENS.id_Discipline; //学科流水号
objvPublicCaseResourceRelENT.DisciplineID = objvPublicCaseResourceRelENS.DisciplineID; //学科ID
objvPublicCaseResourceRelENT.DisciplineName = objvPublicCaseResourceRelENS.DisciplineName; //学科名称
objvPublicCaseResourceRelENT.id_TeachingPlan = objvPublicCaseResourceRelENS.id_TeachingPlan; //教案流水号
objvPublicCaseResourceRelENT.SubjectName = objvPublicCaseResourceRelENS.SubjectName; //课题名称
objvPublicCaseResourceRelENT.TeachingPlanAuthor = objvPublicCaseResourceRelENS.TeachingPlanAuthor; //教案撰写人
objvPublicCaseResourceRelENT.TeachingObject = objvPublicCaseResourceRelENS.TeachingObject; //教学目标
objvPublicCaseResourceRelENT.TeachingEmphases = objvPublicCaseResourceRelENS.TeachingEmphases; //教学重点
objvPublicCaseResourceRelENT.TeachingDifficulty = objvPublicCaseResourceRelENS.TeachingDifficulty; //教学难点
objvPublicCaseResourceRelENT.TeachingTool = objvPublicCaseResourceRelENS.TeachingTool; //教学用具
objvPublicCaseResourceRelENT.TeachingProcess = objvPublicCaseResourceRelENS.TeachingProcess; //教学过程
objvPublicCaseResourceRelENT.TeachingPlanType = objvPublicCaseResourceRelENS.TeachingPlanType; //教案类型
objvPublicCaseResourceRelENT.SimplePlanContent = objvPublicCaseResourceRelENS.SimplePlanContent; //简案内容
objvPublicCaseResourceRelENT.PubClassCaseTimeIn = objvPublicCaseResourceRelENS.PubClassCaseTimeIn; //案例入库时间
objvPublicCaseResourceRelENT.PubCaseTypeName = objvPublicCaseResourceRelENS.PubCaseTypeName; //公开课案例类型名称
objvPublicCaseResourceRelENT.id_StudyLevel = objvPublicCaseResourceRelENS.id_StudyLevel; //id_StudyLevel
objvPublicCaseResourceRelENT.StudyLevelName = objvPublicCaseResourceRelENS.StudyLevelName; //学段名称
objvPublicCaseResourceRelENT.Introduction = objvPublicCaseResourceRelENS.Introduction; //简要介绍
objvPublicCaseResourceRelENT.CaseIsVisible = objvPublicCaseResourceRelENS.CaseIsVisible; //CaseIsVisible
objvPublicCaseResourceRelENT.IsDualVideo = objvPublicCaseResourceRelENS.IsDualVideo; //是否双视频
objvPublicCaseResourceRelENT.RecommendedDegreeId = objvPublicCaseResourceRelENS.RecommendedDegreeId; //推荐度Id
objvPublicCaseResourceRelENT.RecommendedDegreeName = objvPublicCaseResourceRelENS.RecommendedDegreeName; //推荐度名称
objvPublicCaseResourceRelENT.id_Resource = objvPublicCaseResourceRelENS.id_Resource; //资源流水号
objvPublicCaseResourceRelENT.ResourceID = objvPublicCaseResourceRelENS.ResourceID; //资源ID
objvPublicCaseResourceRelENT.ResourceName = objvPublicCaseResourceRelENS.ResourceName; //资源名称
objvPublicCaseResourceRelENT.id_FtpResource = objvPublicCaseResourceRelENS.id_FtpResource; //FTP资源流水号
objvPublicCaseResourceRelENT.id_File = objvPublicCaseResourceRelENS.id_File; //文件流水号
objvPublicCaseResourceRelENT.FileName = objvPublicCaseResourceRelENS.FileName; //文件名称
objvPublicCaseResourceRelENT.FileType = objvPublicCaseResourceRelENS.FileType; //文件类型
objvPublicCaseResourceRelENT.SaveDate = objvPublicCaseResourceRelENS.SaveDate; //创建日期
objvPublicCaseResourceRelENT.FileSize = objvPublicCaseResourceRelENS.FileSize; //文件大小
objvPublicCaseResourceRelENT.SaveTime = objvPublicCaseResourceRelENS.SaveTime; //创建时间
objvPublicCaseResourceRelENT.FtpResourceID = objvPublicCaseResourceRelENS.FtpResourceID; //FTP资源ID
objvPublicCaseResourceRelENT.FileOriginalName = objvPublicCaseResourceRelENS.FileOriginalName; //文件原名
objvPublicCaseResourceRelENT.FileDirName = objvPublicCaseResourceRelENS.FileDirName; //文件目录名
objvPublicCaseResourceRelENT.FileRename = objvPublicCaseResourceRelENS.FileRename; //文件新名
objvPublicCaseResourceRelENT.FileUpDate = objvPublicCaseResourceRelENS.FileUpDate; //创建日期
objvPublicCaseResourceRelENT.FileUpTime = objvPublicCaseResourceRelENS.FileUpTime; //创建时间
objvPublicCaseResourceRelENT.SaveMode = objvPublicCaseResourceRelENS.SaveMode; //文件存放方式
objvPublicCaseResourceRelENT.id_ResourceType = objvPublicCaseResourceRelENS.id_ResourceType; //资源类型流水号
objvPublicCaseResourceRelENT.ResourceTypeID = objvPublicCaseResourceRelENS.ResourceTypeID; //资源类型ID
objvPublicCaseResourceRelENT.ResourceTypeName = objvPublicCaseResourceRelENS.ResourceTypeName; //资源类型名称
objvPublicCaseResourceRelENT.ResourceOwner = objvPublicCaseResourceRelENS.ResourceOwner; //上传者
objvPublicCaseResourceRelENT.ftpFileType = objvPublicCaseResourceRelENS.ftpFileType; //ftp文件类型
objvPublicCaseResourceRelENT.ftpFileSize = objvPublicCaseResourceRelENS.ftpFileSize; //ftp文件大小
objvPublicCaseResourceRelENT.ftpResourceOwner = objvPublicCaseResourceRelENS.ftpResourceOwner; //Ftp资源拥有者
objvPublicCaseResourceRelENT.FileOriginName = objvPublicCaseResourceRelENS.FileOriginName; //原文件名
objvPublicCaseResourceRelENT.IsExistFile = objvPublicCaseResourceRelENS.IsExistFile; //是否存在文件
objvPublicCaseResourceRelENT.FileNewName = objvPublicCaseResourceRelENS.FileNewName; //新文件名
objvPublicCaseResourceRelENT.FileOldName = objvPublicCaseResourceRelENS.FileOldName; //旧文件名
objvPublicCaseResourceRelENT.IsMain = objvPublicCaseResourceRelENS.IsMain; //是否主资源
objvPublicCaseResourceRelENT.IndexNO = objvPublicCaseResourceRelENS.IndexNO; //序号
objvPublicCaseResourceRelENT.Memo = objvPublicCaseResourceRelENS.Memo; //备注
objvPublicCaseResourceRelENT.IsVisible = objvPublicCaseResourceRelENS.IsVisible; //是否显示
objvPublicCaseResourceRelENT.BrowseCount = objvPublicCaseResourceRelENS.BrowseCount; //浏览次数
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
public static DataTable ToDataTable(List<clsvPublicCaseResourceRelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPublicCaseResourceRelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPublicCaseResourceRelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPublicCaseResourceRelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPublicCaseResourceRelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPublicCaseResourceRelEN.AttributeName)
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
if (clsPubClassCase_Resource_RelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCase_Resource_RelWApi没有刷新缓存机制(clsPubClassCase_Resource_RelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeWApi没有刷新缓存机制(clsResourceTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceWApi没有刷新缓存机制(clsResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerWApi没有刷新缓存机制(clsFileServerWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceWApi没有刷新缓存机制(clsFtpResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_PubClassCase_Resource_Rel");
//if (arrvPublicCaseResourceRelObjLst_Cache == null)
//{
//arrvPublicCaseResourceRelObjLst_Cache = await clsvPublicCaseResourceRelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvPublicCaseResourceRelEN._CurrTabName_S);
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
public static List<clsvPublicCaseResourceRelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPublicCaseResourceRelEN._CurrTabName_S);
List<clsvPublicCaseResourceRelEN> arrvPublicCaseResourceRelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPublicCaseResourceRelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPublicCaseResourceRelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPublicCaseResourceRel.id_PubClassCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convPublicCaseResourceRel.id_PubClassCase, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.PubClassCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.PubClassCaseExecutor, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.PubClassCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.PubClassCaseBG, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.PubClassCaseTeachDate, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.PubClassCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.SubjectName, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.TeachingPlanAuthor, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.TeachingObject, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.TeachingEmphases, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.TeachingDifficulty, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.TeachingTool, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.TeachingProcess, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.TeachingPlanType, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.SimplePlanContent, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.PubClassCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.PubCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.Introduction, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.CaseIsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPublicCaseResourceRel.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPublicCaseResourceRel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPublicCaseResourceRel.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPublicCaseResourceRel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPublicCaseResourceRel.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convPublicCaseResourceRel.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convPublicCaseResourceRel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPublicCaseResourceRel.BrowseCount, Type.GetType("System.Int32"));
foreach (clsvPublicCaseResourceRelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPublicCaseResourceRel.id_PubClassCase_Resource_Rel] = objInFor[convPublicCaseResourceRel.id_PubClassCase_Resource_Rel];
objDR[convPublicCaseResourceRel.id_PubClassCase] = objInFor[convPublicCaseResourceRel.id_PubClassCase];
objDR[convPublicCaseResourceRel.PubClassCaseName] = objInFor[convPublicCaseResourceRel.PubClassCaseName];
objDR[convPublicCaseResourceRel.PubClassCaseExecutor] = objInFor[convPublicCaseResourceRel.PubClassCaseExecutor];
objDR[convPublicCaseResourceRel.PubClassCaseTheme] = objInFor[convPublicCaseResourceRel.PubClassCaseTheme];
objDR[convPublicCaseResourceRel.PubClassCaseBG] = objInFor[convPublicCaseResourceRel.PubClassCaseBG];
objDR[convPublicCaseResourceRel.PubClassCaseTeachDate] = objInFor[convPublicCaseResourceRel.PubClassCaseTeachDate];
objDR[convPublicCaseResourceRel.PubClassCaseDateIn] = objInFor[convPublicCaseResourceRel.PubClassCaseDateIn];
objDR[convPublicCaseResourceRel.id_Discipline] = objInFor[convPublicCaseResourceRel.id_Discipline];
objDR[convPublicCaseResourceRel.DisciplineID] = objInFor[convPublicCaseResourceRel.DisciplineID];
objDR[convPublicCaseResourceRel.DisciplineName] = objInFor[convPublicCaseResourceRel.DisciplineName];
objDR[convPublicCaseResourceRel.id_TeachingPlan] = objInFor[convPublicCaseResourceRel.id_TeachingPlan];
objDR[convPublicCaseResourceRel.SubjectName] = objInFor[convPublicCaseResourceRel.SubjectName];
objDR[convPublicCaseResourceRel.TeachingPlanAuthor] = objInFor[convPublicCaseResourceRel.TeachingPlanAuthor];
objDR[convPublicCaseResourceRel.TeachingObject] = objInFor[convPublicCaseResourceRel.TeachingObject];
objDR[convPublicCaseResourceRel.TeachingEmphases] = objInFor[convPublicCaseResourceRel.TeachingEmphases];
objDR[convPublicCaseResourceRel.TeachingDifficulty] = objInFor[convPublicCaseResourceRel.TeachingDifficulty];
objDR[convPublicCaseResourceRel.TeachingTool] = objInFor[convPublicCaseResourceRel.TeachingTool];
objDR[convPublicCaseResourceRel.TeachingProcess] = objInFor[convPublicCaseResourceRel.TeachingProcess];
objDR[convPublicCaseResourceRel.TeachingPlanType] = objInFor[convPublicCaseResourceRel.TeachingPlanType];
objDR[convPublicCaseResourceRel.SimplePlanContent] = objInFor[convPublicCaseResourceRel.SimplePlanContent];
objDR[convPublicCaseResourceRel.PubClassCaseTimeIn] = objInFor[convPublicCaseResourceRel.PubClassCaseTimeIn];
objDR[convPublicCaseResourceRel.PubCaseTypeName] = objInFor[convPublicCaseResourceRel.PubCaseTypeName];
objDR[convPublicCaseResourceRel.id_StudyLevel] = objInFor[convPublicCaseResourceRel.id_StudyLevel];
objDR[convPublicCaseResourceRel.StudyLevelName] = objInFor[convPublicCaseResourceRel.StudyLevelName];
objDR[convPublicCaseResourceRel.Introduction] = objInFor[convPublicCaseResourceRel.Introduction];
objDR[convPublicCaseResourceRel.CaseIsVisible] = objInFor[convPublicCaseResourceRel.CaseIsVisible];
objDR[convPublicCaseResourceRel.IsDualVideo] = objInFor[convPublicCaseResourceRel.IsDualVideo];
objDR[convPublicCaseResourceRel.RecommendedDegreeId] = objInFor[convPublicCaseResourceRel.RecommendedDegreeId];
objDR[convPublicCaseResourceRel.RecommendedDegreeName] = objInFor[convPublicCaseResourceRel.RecommendedDegreeName];
objDR[convPublicCaseResourceRel.id_Resource] = objInFor[convPublicCaseResourceRel.id_Resource];
objDR[convPublicCaseResourceRel.ResourceID] = objInFor[convPublicCaseResourceRel.ResourceID];
objDR[convPublicCaseResourceRel.ResourceName] = objInFor[convPublicCaseResourceRel.ResourceName];
objDR[convPublicCaseResourceRel.id_FtpResource] = objInFor[convPublicCaseResourceRel.id_FtpResource];
objDR[convPublicCaseResourceRel.id_File] = objInFor[convPublicCaseResourceRel.id_File];
objDR[convPublicCaseResourceRel.FileName] = objInFor[convPublicCaseResourceRel.FileName];
objDR[convPublicCaseResourceRel.FileType] = objInFor[convPublicCaseResourceRel.FileType];
objDR[convPublicCaseResourceRel.SaveDate] = objInFor[convPublicCaseResourceRel.SaveDate];
objDR[convPublicCaseResourceRel.FileSize] = objInFor[convPublicCaseResourceRel.FileSize];
objDR[convPublicCaseResourceRel.SaveTime] = objInFor[convPublicCaseResourceRel.SaveTime];
objDR[convPublicCaseResourceRel.FtpResourceID] = objInFor[convPublicCaseResourceRel.FtpResourceID];
objDR[convPublicCaseResourceRel.FileOriginalName] = objInFor[convPublicCaseResourceRel.FileOriginalName];
objDR[convPublicCaseResourceRel.FileDirName] = objInFor[convPublicCaseResourceRel.FileDirName];
objDR[convPublicCaseResourceRel.FileRename] = objInFor[convPublicCaseResourceRel.FileRename];
objDR[convPublicCaseResourceRel.FileUpDate] = objInFor[convPublicCaseResourceRel.FileUpDate];
objDR[convPublicCaseResourceRel.FileUpTime] = objInFor[convPublicCaseResourceRel.FileUpTime];
objDR[convPublicCaseResourceRel.SaveMode] = objInFor[convPublicCaseResourceRel.SaveMode];
objDR[convPublicCaseResourceRel.id_ResourceType] = objInFor[convPublicCaseResourceRel.id_ResourceType];
objDR[convPublicCaseResourceRel.ResourceTypeID] = objInFor[convPublicCaseResourceRel.ResourceTypeID];
objDR[convPublicCaseResourceRel.ResourceTypeName] = objInFor[convPublicCaseResourceRel.ResourceTypeName];
objDR[convPublicCaseResourceRel.ResourceOwner] = objInFor[convPublicCaseResourceRel.ResourceOwner];
objDR[convPublicCaseResourceRel.ftpFileType] = objInFor[convPublicCaseResourceRel.ftpFileType];
objDR[convPublicCaseResourceRel.ftpFileSize] = objInFor[convPublicCaseResourceRel.ftpFileSize];
objDR[convPublicCaseResourceRel.ftpResourceOwner] = objInFor[convPublicCaseResourceRel.ftpResourceOwner];
objDR[convPublicCaseResourceRel.FileOriginName] = objInFor[convPublicCaseResourceRel.FileOriginName];
objDR[convPublicCaseResourceRel.IsExistFile] = objInFor[convPublicCaseResourceRel.IsExistFile];
objDR[convPublicCaseResourceRel.FileNewName] = objInFor[convPublicCaseResourceRel.FileNewName];
objDR[convPublicCaseResourceRel.FileOldName] = objInFor[convPublicCaseResourceRel.FileOldName];
objDR[convPublicCaseResourceRel.IsMain] = objInFor[convPublicCaseResourceRel.IsMain];
objDR[convPublicCaseResourceRel.IndexNO] = objInFor[convPublicCaseResourceRel.IndexNO];
objDR[convPublicCaseResourceRel.Memo] = objInFor[convPublicCaseResourceRel.Memo];
objDR[convPublicCaseResourceRel.IsVisible] = objInFor[convPublicCaseResourceRel.IsVisible];
objDR[convPublicCaseResourceRel.BrowseCount] = objInFor[convPublicCaseResourceRel.BrowseCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}